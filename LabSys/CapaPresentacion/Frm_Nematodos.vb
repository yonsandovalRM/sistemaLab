Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class Frm_Nematodos
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
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Bt_Imprime As System.Windows.Forms.Button
    Friend WithEvents Bt_Graba As System.Windows.Forms.Button
    Friend WithEvents Dtg_Nematodos As System.Windows.Forms.DataGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents Txt_Aphel As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Crico As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Helic As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Hemic As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Meloi As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Parat As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Praty As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Trich As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tylen As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tylenc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Dipht As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Longi As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Heter As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Xhipi As System.Windows.Forms.TextBox
    Friend WithEvents Txt_XhipiS As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tysem As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Dityl As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Sapro As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_Globo As System.Windows.Forms.TextBox
    Friend WithEvents Bt_CargaN As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_Obs As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Dtp_FechaPlanilla = New System.Windows.Forms.DateTimePicker
        Me.Bt_CargaN = New System.Windows.Forms.Button
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
        Me.Dtg_Nematodos = New System.Windows.Forms.DataGrid
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
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Graba = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txt_Aphel = New System.Windows.Forms.TextBox
        Me.Txt_Crico = New System.Windows.Forms.TextBox
        Me.Txt_Helic = New System.Windows.Forms.TextBox
        Me.Txt_Hemic = New System.Windows.Forms.TextBox
        Me.Txt_Meloi = New System.Windows.Forms.TextBox
        Me.Txt_Parat = New System.Windows.Forms.TextBox
        Me.Txt_Praty = New System.Windows.Forms.TextBox
        Me.Txt_Trich = New System.Windows.Forms.TextBox
        Me.Txt_Tylen = New System.Windows.Forms.TextBox
        Me.Txt_Tylenc = New System.Windows.Forms.TextBox
        Me.Txt_Dipht = New System.Windows.Forms.TextBox
        Me.Txt_Longi = New System.Windows.Forms.TextBox
        Me.Txt_Heter = New System.Windows.Forms.TextBox
        Me.Txt_Xhipi = New System.Windows.Forms.TextBox
        Me.Txt_XhipiS = New System.Windows.Forms.TextBox
        Me.Txt_Tysem = New System.Windows.Forms.TextBox
        Me.Txt_Dityl = New System.Windows.Forms.TextBox
        Me.Txt_Sapro = New System.Windows.Forms.TextBox
        Me.Txt_Globo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txt_Obs = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dtg_Nematodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtp_FechaPlanilla)
        Me.GroupBox2.Controls.Add(Me.Bt_CargaN)
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
        Me.GroupBox2.TabIndex = 75
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
        'Bt_CargaN
        '
        Me.Bt_CargaN.BackColor = System.Drawing.Color.Transparent
        Me.Bt_CargaN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_CargaN.Image = Global.LabSys.My.Resources.Resources.server_database
        Me.Bt_CargaN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_CargaN.Location = New System.Drawing.Point(144, 160)
        Me.Bt_CargaN.Name = "Bt_CargaN"
        Me.Bt_CargaN.Size = New System.Drawing.Size(75, 26)
        Me.Bt_CargaN.TabIndex = 9
        Me.Bt_CargaN.Text = "Carga"
        Me.Bt_CargaN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_CargaN.UseVisualStyleBackColor = False
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
        Me.GroupBox1.TabIndex = 74
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
        'Dtg_Nematodos
        '
        Me.Dtg_Nematodos.CaptionVisible = False
        Me.Dtg_Nematodos.DataMember = ""
        Me.Dtg_Nematodos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Nematodos.Location = New System.Drawing.Point(304, 24)
        Me.Dtg_Nematodos.Name = "Dtg_Nematodos"
        Me.Dtg_Nematodos.Size = New System.Drawing.Size(960, 888)
        Me.Dtg_Nematodos.TabIndex = 76
        Me.Dtg_Nematodos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_Nematodos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn21})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "NEMATODOS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "NºLab"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 45
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Aphel"
        Me.DataGridTextBoxColumn2.MappingName = "NAPHELENCHUS"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 45
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Crico"
        Me.DataGridTextBoxColumn3.MappingName = "NCRICONEMELLA"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 45
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Helic"
        Me.DataGridTextBoxColumn4.MappingName = "NHELICOTYLENCHUS"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 45
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Hemic"
        Me.DataGridTextBoxColumn5.MappingName = "NHEMYCYCLIOPHORA"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 45
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Meloi"
        Me.DataGridTextBoxColumn6.MappingName = "NMELOIDOGYNE"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 45
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Parat"
        Me.DataGridTextBoxColumn7.MappingName = "NPARATYLENCHUS"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 45
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Praty"
        Me.DataGridTextBoxColumn8.MappingName = "NPRATYLENCHUS"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 45
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Trich"
        Me.DataGridTextBoxColumn9.MappingName = "NTRICHODORUS"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 45
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Tylen"
        Me.DataGridTextBoxColumn10.MappingName = "NTYLENCHORHYNCHUS"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 45
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "TylenC"
        Me.DataGridTextBoxColumn11.MappingName = "NTYLENCHUS"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 45
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Dipht"
        Me.DataGridTextBoxColumn12.MappingName = "NDIPHTHEROPORA"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 45
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Longi"
        Me.DataGridTextBoxColumn13.MappingName = "NLONGIDORUS"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 45
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Xhipi I"
        Me.DataGridTextBoxColumn15.MappingName = "NXIPHINEMAINDEX"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 45
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Xhipi S"
        Me.DataGridTextBoxColumn16.MappingName = "NXIPHINEMASP"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 45
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Tysem"
        Me.DataGridTextBoxColumn17.MappingName = "NTYLENCHUSEMIPENET"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 45
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Dityl"
        Me.DataGridTextBoxColumn18.MappingName = "NDITYLENCHUS"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 45
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Globo"
        Me.DataGridTextBoxColumn20.MappingName = "GLOBODERA"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 45
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Heter"
        Me.DataGridTextBoxColumn14.MappingName = "NHETEREODERA"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 45
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Sapro"
        Me.DataGridTextBoxColumn19.MappingName = "NSAPROFITOS"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 45
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Obs."
        Me.DataGridTextBoxColumn21.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 200
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
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Limpiar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Bt_Salir.TabIndex = 79
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
        Me.Bt_Imprime.TabIndex = 78
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
        Me.Bt_Graba.TabIndex = 77
        Me.Bt_Graba.Text = "Grabar"
        Me.Bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Graba.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(304, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(800, 23)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Nematodos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Aphel
        '
        Me.Txt_Aphel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Aphel.Location = New System.Drawing.Point(312, 88)
        Me.Txt_Aphel.Name = "Txt_Aphel"
        Me.Txt_Aphel.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Aphel.TabIndex = 82
        Me.Txt_Aphel.Visible = False
        '
        'Txt_Crico
        '
        Me.Txt_Crico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Crico.Location = New System.Drawing.Point(312, 120)
        Me.Txt_Crico.Name = "Txt_Crico"
        Me.Txt_Crico.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Crico.TabIndex = 83
        Me.Txt_Crico.Visible = False
        '
        'Txt_Helic
        '
        Me.Txt_Helic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Helic.Location = New System.Drawing.Point(312, 152)
        Me.Txt_Helic.Name = "Txt_Helic"
        Me.Txt_Helic.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Helic.TabIndex = 84
        Me.Txt_Helic.Visible = False
        '
        'Txt_Hemic
        '
        Me.Txt_Hemic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Hemic.Location = New System.Drawing.Point(312, 184)
        Me.Txt_Hemic.Name = "Txt_Hemic"
        Me.Txt_Hemic.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Hemic.TabIndex = 85
        Me.Txt_Hemic.Visible = False
        '
        'Txt_Meloi
        '
        Me.Txt_Meloi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Meloi.Location = New System.Drawing.Point(312, 216)
        Me.Txt_Meloi.Name = "Txt_Meloi"
        Me.Txt_Meloi.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Meloi.TabIndex = 86
        Me.Txt_Meloi.Visible = False
        '
        'Txt_Parat
        '
        Me.Txt_Parat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Parat.Location = New System.Drawing.Point(312, 248)
        Me.Txt_Parat.Name = "Txt_Parat"
        Me.Txt_Parat.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Parat.TabIndex = 87
        Me.Txt_Parat.Visible = False
        '
        'Txt_Praty
        '
        Me.Txt_Praty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Praty.Location = New System.Drawing.Point(312, 280)
        Me.Txt_Praty.Name = "Txt_Praty"
        Me.Txt_Praty.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Praty.TabIndex = 88
        Me.Txt_Praty.Visible = False
        '
        'Txt_Trich
        '
        Me.Txt_Trich.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Trich.Location = New System.Drawing.Point(312, 312)
        Me.Txt_Trich.Name = "Txt_Trich"
        Me.Txt_Trich.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Trich.TabIndex = 89
        Me.Txt_Trich.Visible = False
        '
        'Txt_Tylen
        '
        Me.Txt_Tylen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Tylen.Location = New System.Drawing.Point(312, 344)
        Me.Txt_Tylen.Name = "Txt_Tylen"
        Me.Txt_Tylen.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Tylen.TabIndex = 90
        Me.Txt_Tylen.Visible = False
        '
        'Txt_Tylenc
        '
        Me.Txt_Tylenc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Tylenc.Location = New System.Drawing.Point(440, 88)
        Me.Txt_Tylenc.Name = "Txt_Tylenc"
        Me.Txt_Tylenc.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Tylenc.TabIndex = 91
        Me.Txt_Tylenc.Visible = False
        '
        'Txt_Dipht
        '
        Me.Txt_Dipht.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Dipht.Location = New System.Drawing.Point(440, 120)
        Me.Txt_Dipht.Name = "Txt_Dipht"
        Me.Txt_Dipht.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Dipht.TabIndex = 92
        Me.Txt_Dipht.Visible = False
        '
        'Txt_Longi
        '
        Me.Txt_Longi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Longi.Location = New System.Drawing.Point(440, 152)
        Me.Txt_Longi.Name = "Txt_Longi"
        Me.Txt_Longi.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Longi.TabIndex = 93
        Me.Txt_Longi.Visible = False
        '
        'Txt_Heter
        '
        Me.Txt_Heter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Heter.Location = New System.Drawing.Point(440, 184)
        Me.Txt_Heter.Name = "Txt_Heter"
        Me.Txt_Heter.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Heter.TabIndex = 94
        Me.Txt_Heter.Visible = False
        '
        'Txt_Xhipi
        '
        Me.Txt_Xhipi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Xhipi.Location = New System.Drawing.Point(440, 216)
        Me.Txt_Xhipi.Name = "Txt_Xhipi"
        Me.Txt_Xhipi.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Xhipi.TabIndex = 95
        Me.Txt_Xhipi.Visible = False
        '
        'Txt_XhipiS
        '
        Me.Txt_XhipiS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_XhipiS.Location = New System.Drawing.Point(440, 248)
        Me.Txt_XhipiS.Name = "Txt_XhipiS"
        Me.Txt_XhipiS.Size = New System.Drawing.Size(100, 20)
        Me.Txt_XhipiS.TabIndex = 96
        Me.Txt_XhipiS.Visible = False
        '
        'Txt_Tysem
        '
        Me.Txt_Tysem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Tysem.Location = New System.Drawing.Point(440, 280)
        Me.Txt_Tysem.Name = "Txt_Tysem"
        Me.Txt_Tysem.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Tysem.TabIndex = 97
        Me.Txt_Tysem.Visible = False
        '
        'Txt_Dityl
        '
        Me.Txt_Dityl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Dityl.Location = New System.Drawing.Point(440, 312)
        Me.Txt_Dityl.Name = "Txt_Dityl"
        Me.Txt_Dityl.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Dityl.TabIndex = 98
        Me.Txt_Dityl.Visible = False
        '
        'Txt_Sapro
        '
        Me.Txt_Sapro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Sapro.Location = New System.Drawing.Point(440, 344)
        Me.Txt_Sapro.Name = "Txt_Sapro"
        Me.Txt_Sapro.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Sapro.TabIndex = 99
        Me.Txt_Sapro.Visible = False
        '
        'Txt_Globo
        '
        Me.Txt_Globo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Globo.Location = New System.Drawing.Point(440, 384)
        Me.Txt_Globo.Name = "Txt_Globo"
        Me.Txt_Globo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Globo.TabIndex = 100
        Me.Txt_Globo.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(1104, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 23)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Nematodos Quistes"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Obs
        '
        Me.Txt_Obs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Obs.Location = New System.Drawing.Point(440, 424)
        Me.Txt_Obs.Name = "Txt_Obs"
        Me.Txt_Obs.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Obs.TabIndex = 102
        Me.Txt_Obs.Visible = False
        '
        'Frm_Nematodos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Txt_Obs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_Globo)
        Me.Controls.Add(Me.Txt_Sapro)
        Me.Controls.Add(Me.Txt_Dityl)
        Me.Controls.Add(Me.Txt_Tysem)
        Me.Controls.Add(Me.Txt_XhipiS)
        Me.Controls.Add(Me.Txt_Xhipi)
        Me.Controls.Add(Me.Txt_Heter)
        Me.Controls.Add(Me.Txt_Longi)
        Me.Controls.Add(Me.Txt_Dipht)
        Me.Controls.Add(Me.Txt_Tylenc)
        Me.Controls.Add(Me.Txt_Tylen)
        Me.Controls.Add(Me.Txt_Trich)
        Me.Controls.Add(Me.Txt_Praty)
        Me.Controls.Add(Me.Txt_Parat)
        Me.Controls.Add(Me.Txt_Meloi)
        Me.Controls.Add(Me.Txt_Hemic)
        Me.Controls.Add(Me.Txt_Helic)
        Me.Controls.Add(Me.Txt_Crico)
        Me.Controls.Add(Me.Txt_Aphel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.Dtg_Nematodos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Nematodos"
        Me.Text = "Nematodos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dtg_Nematodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Dtg_Nematodos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Nematodos.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        Fila_Lectura = Dtg_Nematodos.CurrentCell.RowNumber()
        Revision_Digitacion = "N"

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 1 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Aphel.Left = Posicionx
            Txt_Aphel.Top = Posiciony
            Txt_Aphel.Height = CeldaAlto
            Txt_Aphel.Width = CeldaAncho
            Txt_Aphel.Visible = True
            Txt_Aphel.Text = ""
            Txt_Aphel.Enabled = True
            Txt_Aphel.TabIndex = 82
            Txt_Aphel.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Crico.Left = Posicionx
            Txt_Crico.Top = Posiciony
            Txt_Crico.Height = CeldaAlto
            Txt_Crico.Width = CeldaAncho
            Txt_Crico.Visible = True
            Txt_Crico.Text = ""
            Txt_Crico.Enabled = True
            Txt_Crico.TabIndex = 83
            Txt_Crico.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Helic.Left = Posicionx
            Txt_Helic.Top = Posiciony
            Txt_Helic.Height = CeldaAlto
            Txt_Helic.Width = CeldaAncho
            Txt_Helic.Visible = True
            Txt_Helic.Text = ""
            Txt_Helic.Enabled = True
            Txt_Helic.TabIndex = 84
            Txt_Helic.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Hemic.Left = Posicionx
            Txt_Hemic.Top = Posiciony
            Txt_Hemic.Height = CeldaAlto
            Txt_Hemic.Width = CeldaAncho
            Txt_Hemic.Visible = True
            Txt_Hemic.Text = ""
            Txt_Hemic.Enabled = True
            Txt_Hemic.TabIndex = 85
            Txt_Hemic.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 5 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Meloi.Left = Posicionx
            Txt_Meloi.Top = Posiciony
            Txt_Meloi.Height = CeldaAlto
            Txt_Meloi.Width = CeldaAncho
            Txt_Meloi.Visible = True
            Txt_Meloi.Text = ""
            Txt_Meloi.Enabled = True
            Txt_Meloi.TabIndex = 86
            Txt_Meloi.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 6 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Parat.Left = Posicionx
            Txt_Parat.Top = Posiciony
            Txt_Parat.Height = CeldaAlto
            Txt_Parat.Width = CeldaAncho
            Txt_Parat.Visible = True
            Txt_Parat.Text = ""
            Txt_Parat.Enabled = True
            Txt_Parat.TabIndex = 87
            Txt_Parat.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 7 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Praty.Left = Posicionx
            Txt_Praty.Top = Posiciony
            Txt_Praty.Height = CeldaAlto
            Txt_Praty.Width = CeldaAncho
            Txt_Praty.Visible = True
            Txt_Praty.Text = ""
            Txt_Praty.Enabled = True
            Txt_Praty.TabIndex = 88
            Txt_Praty.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 8 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Trich.Left = Posicionx
            Txt_Trich.Top = Posiciony
            Txt_Trich.Height = CeldaAlto
            Txt_Trich.Width = CeldaAncho
            Txt_Trich.Visible = True
            Txt_Trich.Text = ""
            Txt_Trich.Enabled = True
            Txt_Trich.TabIndex = 89
            Txt_Trich.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 9 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Tylen.Left = Posicionx
            Txt_Tylen.Top = Posiciony
            Txt_Tylen.Height = CeldaAlto
            Txt_Tylen.Width = CeldaAncho
            Txt_Tylen.Visible = True
            Txt_Tylen.Text = ""
            Txt_Tylen.Enabled = True
            Txt_Tylen.TabIndex = 90
            Txt_Tylen.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 10 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Tylenc.Left = Posicionx
            Txt_Tylenc.Top = Posiciony
            Txt_Tylenc.Height = CeldaAlto
            Txt_Tylenc.Width = CeldaAncho
            Txt_Tylenc.Visible = True
            Txt_Tylenc.Text = ""
            Txt_Tylenc.Enabled = True
            Txt_Tylenc.TabIndex = 91
            Txt_Tylenc.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 11 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Dipht.Left = Posicionx
            Txt_Dipht.Top = Posiciony
            Txt_Dipht.Height = CeldaAlto
            Txt_Dipht.Width = CeldaAncho
            Txt_Dipht.Visible = True
            Txt_Dipht.Text = ""
            Txt_Dipht.Enabled = True
            Txt_Dipht.TabIndex = 92
            Txt_Dipht.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 12 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Longi.Left = Posicionx
            Txt_Longi.Top = Posiciony
            Txt_Longi.Height = CeldaAlto
            Txt_Longi.Width = CeldaAncho
            Txt_Longi.Visible = True
            Txt_Longi.Text = ""
            Txt_Longi.Enabled = True
            Txt_Longi.TabIndex = 93
            Txt_Longi.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 13 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Xhipi.Left = Posicionx
            Txt_Xhipi.Top = Posiciony
            Txt_Xhipi.Height = CeldaAlto
            Txt_Xhipi.Width = CeldaAncho
            Txt_Xhipi.Visible = True
            Txt_Xhipi.Text = ""
            Txt_Xhipi.Enabled = True
            Txt_Xhipi.TabIndex = 95
            Txt_Xhipi.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 14 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_XhipiS.Left = Posicionx
            Txt_XhipiS.Top = Posiciony
            Txt_XhipiS.Height = CeldaAlto
            Txt_XhipiS.Width = CeldaAncho
            Txt_XhipiS.Visible = True
            Txt_XhipiS.Text = ""
            Txt_XhipiS.Enabled = True
            Txt_XhipiS.TabIndex = 96
            Txt_XhipiS.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 15 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Tysem.Left = Posicionx
            Txt_Tysem.Top = Posiciony
            Txt_Tysem.Height = CeldaAlto
            Txt_Tysem.Width = CeldaAncho
            Txt_Tysem.Visible = True
            Txt_Tysem.Text = ""
            Txt_Tysem.Enabled = True
            Txt_Tysem.TabIndex = 97
            Txt_Tysem.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 16 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Dityl.Left = Posicionx
            Txt_Dityl.Top = Posiciony
            Txt_Dityl.Height = CeldaAlto
            Txt_Dityl.Width = CeldaAncho
            Txt_Dityl.Visible = True
            Txt_Dityl.Text = ""
            Txt_Dityl.Enabled = True
            Txt_Dityl.TabIndex = 98
            Txt_Dityl.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 17 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Globo.Left = Posicionx
            Txt_Globo.Top = Posiciony
            Txt_Globo.Height = CeldaAlto
            Txt_Globo.Width = CeldaAncho
            Txt_Globo.Visible = True
            Txt_Globo.Text = ""
            Txt_Globo.Enabled = True
            Txt_Globo.TabIndex = 100
            Txt_Globo.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 18 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Heter.Left = Posicionx
            Txt_Heter.Top = Posiciony
            Txt_Heter.Height = CeldaAlto
            Txt_Heter.Width = CeldaAncho
            Txt_Heter.Visible = True
            Txt_Heter.Text = ""
            Txt_Heter.Enabled = True
            Txt_Heter.TabIndex = 94
            Txt_Heter.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 19 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Sapro.Left = Posicionx
            Txt_Sapro.Top = Posiciony
            Txt_Sapro.Height = CeldaAlto
            Txt_Sapro.Width = CeldaAncho
            Txt_Sapro.Visible = True
            Txt_Sapro.Text = ""
            Txt_Sapro.Enabled = True
            Txt_Sapro.TabIndex = 99
            Txt_Sapro.Focus()
        End If

        If Dtg_Nematodos.CurrentCell.ColumnNumber = 20 Then
            Dim CeldaAlto As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).X + Dtg_Nematodos.Left
            Dim Posiciony As Integer = Dtg_Nematodos.GetCellBounds(Dtg_Nematodos.CurrentCell.RowNumber, Dtg_Nematodos.CurrentCell.ColumnNumber).Y + Dtg_Nematodos.Top
            Txt_Obs.Left = Posicionx
            Txt_Obs.Top = Posiciony
            Txt_Obs.Height = CeldaAlto
            Txt_Obs.Width = CeldaAncho
            Txt_Obs.Visible = True
            Txt_Obs.Text = ""
            Txt_Obs.Enabled = True
            Txt_Obs.TabIndex = 102
            Txt_Obs.Focus()
        End If
    End Sub

    Private Sub Bt_CargaN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_CargaN.Click
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
            Cjto_Tablas1.Tables("NEMATODOS").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=8000  ORDER BY PRIORIDAD"
            Dim myCommand1 As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
            While myReader1.Read()
                Carga_Digitacion = "N"
                If CInt(myReader1.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

                If Mypos = 0 Then
                    EstaRevisado = 0
                    EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, 8000)
                End If

                If Carga_Digitacion = "S" Then
                    If EstaRevisado = 0 Then
                        Fila_Digitacion = Cjto_Tablas1.Tables("NEMATODOS").NewRow
                        Fila_Digitacion("OT_NLAB") = myReader1.GetString(0)
                        Cjto_Tablas1.Tables("NEMATODOS").Rows.Add(Fila_Digitacion)
                    Else
                        MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
                    End If

                End If

            End While
            myReader1.Close()
            GoTo SaltoxIngresoDup
        End If


        Cjto_Tablas1.Tables("NEMATODOS").Clear()
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=8000  ORDER BY PRIORIDAD"
        Dim myCommand As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        While myReader.Read()

            If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
            If CInt(myReader.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
            If Mypos = 0 Then
                EstaRevisado = 0
                EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, 8000)
            End If

            If Carga_Digitacion = "S" Then
                If EstaRevisado = 0 Then
                    Fila_Digitacion = Cjto_Tablas1.Tables("NEMATODOS").NewRow
                    Fila_Digitacion("OT_NLAB") = myReader.GetString(0)
                    Cjto_Tablas1.Tables("NEMATODOS").Rows.Add(Fila_Digitacion)
                Else
                    MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                End If

            End If

        End While
        myReader.Close()
SaltoxIngresoDup:
        SqlConn.Close()
        Dtg_Nematodos.Visible = True
        
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



    End Sub

    Private Sub Txt_Aphel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Aphel.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Aphel.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 1) = 0

                mycell.ColumnNumber = 2
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Crico.Focus()
                Txt_Aphel.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 1) = Txt_Aphel.Text

                mycell.ColumnNumber = 2
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Crico.Focus()
                Txt_Aphel.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Crico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Crico.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Crico.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 2) = 0

                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Helic.Focus()
                Txt_Crico.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 2) = Txt_Crico.Text

                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Helic.Focus()
                Txt_Crico.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Helic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Helic.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Helic.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 3) = 0

                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Hemic.Focus()
                Txt_Helic.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 3) = Txt_Helic.Text

                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Hemic.Focus()
                Txt_Helic.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Hemic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Hemic.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Hemic.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 4) = 0

                mycell.ColumnNumber = 5
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Meloi.Focus()
                Txt_Hemic.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 4) = Txt_Hemic.Text

                mycell.ColumnNumber = 5
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Meloi.Focus()
                Txt_Hemic.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Meloi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Meloi.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Meloi.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 5) = 0

                mycell.ColumnNumber = 6
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Parat.Focus()
                Txt_Meloi.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 5) = Txt_Meloi.Text

                mycell.ColumnNumber = 6
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Parat.Focus()
                Txt_Meloi.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Parat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Parat.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Parat.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 6) = 0

                mycell.ColumnNumber = 7
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Praty.Focus()
                Txt_Parat.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 6) = Txt_Parat.Text

                mycell.ColumnNumber = 7
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Praty.Focus()
                Txt_Parat.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Praty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Praty.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Praty.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 7) = 0

                mycell.ColumnNumber = 8
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Trich.Focus()
                Txt_Praty.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 7) = Txt_Praty.Text

                mycell.ColumnNumber = 8
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Trich.Focus()
                Txt_Praty.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Trich_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Trich.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Trich.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 8) = 0

                mycell.ColumnNumber = 9
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Tylen.Focus()
                Txt_Trich.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 8) = Txt_Trich.Text

                mycell.ColumnNumber = 9
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Tylen.Focus()
                Txt_Trich.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Tylen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Tylen.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Tylen.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 9) = 0

                mycell.ColumnNumber = 10
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Tylenc.Focus()
                Txt_Tylen.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 9) = Txt_Tylen.Text

                mycell.ColumnNumber = 10
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Tylenc.Focus()
                Txt_Tylen.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Tylenc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Tylenc.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Tylenc.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 10) = 0

                mycell.ColumnNumber = 11
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Dipht.Focus()
                Txt_Tylenc.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 10) = Txt_Tylenc.Text

                mycell.ColumnNumber = 11
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Dipht.Focus()
                Txt_Tylenc.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Dipht_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Dipht.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Dipht.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 11) = 0

                mycell.ColumnNumber = 12
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Longi.Focus()
                Txt_Dipht.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 11) = Txt_Dipht.Text

                mycell.ColumnNumber = 12
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Longi.Focus()
                Txt_Dipht.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Longi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Longi.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Longi.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 12) = 0

                mycell.ColumnNumber = 13
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Xhipi.Focus()
                Txt_Longi.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 12) = Txt_Longi.Text

                mycell.ColumnNumber = 13
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Xhipi.Focus()
                Txt_Longi.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Xhipi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Xhipi.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Xhipi.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 13) = 0

                mycell.ColumnNumber = 14
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_XhipiS.Focus()
                Txt_Xhipi.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 13) = Txt_Xhipi.Text

                mycell.ColumnNumber = 14
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_XhipiS.Focus()
                Txt_Xhipi.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_XhipiS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_XhipiS.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_XhipiS.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 14) = 0

                mycell.ColumnNumber = 15
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Tysem.Focus()
                Txt_XhipiS.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 14) = Txt_XhipiS.Text

                mycell.ColumnNumber = 15
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Tysem.Focus()
                Txt_XhipiS.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Tysem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Tysem.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Tysem.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 15) = 0

                mycell.ColumnNumber = 16
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Dityl.Focus()
                Txt_Tysem.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 15) = Txt_Tysem.Text

                mycell.ColumnNumber = 16
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Dityl.Focus()
                Txt_Tysem.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Dityl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Dityl.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Dityl.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 16) = 0

                mycell.ColumnNumber = 17
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Globo.Focus()
                Txt_Dityl.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 16) = Txt_Dityl.Text

                mycell.ColumnNumber = 17
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Globo.Focus()
                Txt_Dityl.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Globo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Globo.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Globo.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 17) = 0

                mycell.ColumnNumber = 18
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Heter.Focus()
                Txt_Globo.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 17) = Txt_Globo.Text

                mycell.ColumnNumber = 18
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Heter.Focus()
                Txt_Globo.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Heter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Heter.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Heter.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 18) = 0

                mycell.ColumnNumber = 19
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Sapro.Focus()
                Txt_Heter.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 18) = Txt_Heter.Text

                mycell.ColumnNumber = 19
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Sapro.Focus()
                Txt_Heter.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Sapro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Sapro.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Sapro.Text = "" Then
                Dtg_Nematodos.Item(Fila_Lectura, 19) = 0

                mycell.ColumnNumber = 20
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Obs.Focus()
                Txt_Sapro.Visible = False
            Else
                Dtg_Nematodos.Item(Fila_Lectura, 19) = Txt_Sapro.Text

                mycell.ColumnNumber = 20
                mycell.RowNumber = Fila_Lectura
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Obs.Focus()
                Txt_Sapro.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_Obs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Obs.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_Nematodos.Item(Fila_Lectura, 20) = Txt_Obs.Text

                mycell.ColumnNumber = 1
                mycell.RowNumber = Fila_Lectura + 1
                Dtg_Nematodos.CurrentCell = mycell
                Me.Txt_Aphel.Focus()
            Txt_Obs.Visible = False
        End If
    End Sub

    Private Sub Anti_Elimina_Lineas()
        Cjto_Tablas1.Tables("NEMATODOS").Clear()
        Dtg_Nematodos.DataSource = Cjto_Tablas1.Tables("NEMATODOS")
    End Sub

    Private Sub Frm_Nematodos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina_Lineas()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cjto_Tablas1.Tables("NEMATODOS").Clear()
    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub

    Private Sub Graba_Nematodos()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila As DataRow
        Try
            For Each Fila In Cjto_Tablas1.Tables("NEMATODOS").Rows
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", Fila("OT_NLAB"), SqlDbType.NVarChar)
                    .AgregarParametro("@Aphe", Fila("NAPHELENCHUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Heli", Fila("NHELICOTYLENCHUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Hemi", Fila("NHEMYCYCLIOPHORA"), SqlDbType.NVarChar)
                    .AgregarParametro("@Melo", Fila("NMELOIDOGYNE"), SqlDbType.NVarChar)
                    .AgregarParametro("@Para", Fila("NPARATYLENCHUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Prat", Fila("NPRATYLENCHUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Tric", Fila("NTRICHODORUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Tylechor", Fila("NTYLENCHORHYNCHUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Tylenchus", Fila("NTYLENCHUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Dipht", Fila("NDIPHTHEROPORA"), SqlDbType.NVarChar)
                    .AgregarParametro("@Longi", Fila("NLONGIDORUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Heter", Fila("NHETEREODERA"), SqlDbType.NVarChar)
                    .AgregarParametro("@Xhipi", Fila("NXIPHINEMAINDEX"), SqlDbType.NVarChar)
                    .AgregarParametro("@XhipiS", Fila("NXIPHINEMASP"), SqlDbType.NVarChar)
                    .AgregarParametro("@TylenchuSemi", Fila("NTYLENCHUSEMIPENET"), SqlDbType.NVarChar)
                    .AgregarParametro("@Ditylenchus", Fila("NDITYLENCHUS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Sapro", Fila("NSAPROFITOS"), SqlDbType.NVarChar)
                    .AgregarParametro("@Crico", Fila("NCRICONEMELLA"), SqlDbType.NVarChar)
                    .AgregarParametro("@Globo", Fila("GLOBODERA"), SqlDbType.NVarChar)
                    .AgregarParametro("@Obs", Fila("OBSERVACION"), SqlDbType.NVarChar)
                    .EjecutarEscalar("usp_GrabaNematodos")
                End With
                With SP
                    .Inicializar()
                    .AgregarParametro("@Fecha_analisis", Dtp_FechaAnalisis.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Fecha_digita", Dtp_FechaDigitacion.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Num_lab", CInt(Fila("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@Elemento", Elemento, SqlDbType.NVarChar)
                    .EjecutarEscalar("usp_Update_DigitaResultados")
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub Bt_Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Call Graba_Nematodos()
    End Sub


End Class
