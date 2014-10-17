Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Office.Interop

Public Class Frm_Textura
    Inherits System.Windows.Forms.Form
    Dim Fila_Lectura As Integer
    Dim Ultimo_Blanco, EntRes, DecRes, Mascara As Double
    Dim Elemento, nombre, simbolo, Tit_Formula As String
    Public codigo As String
    Friend WithEvents Cba_Digitador As System.Windows.Forms.ComboBox
    Friend WithEvents Cba_Analista As System.Windows.Forms.ComboBox
    Public cont As Integer
    


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
    Friend WithEvents Txt_Lect1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Temp1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Lect2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Temp2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents GrbEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents Dtp_fechadigita As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtP_fechanalisis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    '  Friend WithEvents Cba_Analista As ComboboxAutoCompletar.AutoCompletarComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    ' Friend WithEvents Cba_Digitador As ComboboxAutoCompletar.AutoCompletarComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrbCargaPlanilla As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNlabDesdePla As System.Windows.Forms.TextBox
    Friend WithEvents DTPFechaDigPla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Nlab2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nlab1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Dtg_Textura As System.Windows.Forms.DataGrid
    Friend WithEvents bt_Graba As System.Windows.Forms.Button
    Friend WithEvents Bt_Cerrar As System.Windows.Forms.Button
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
    Friend WithEvents Bt_Limpiar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Txt_Lect1 = New System.Windows.Forms.TextBox
        Me.Txt_Temp1 = New System.Windows.Forms.TextBox
        Me.Txt_Lect2 = New System.Windows.Forms.TextBox
        Me.Txt_Temp2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.bt_Graba = New System.Windows.Forms.Button
        Me.Dtg_Textura = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
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
        Me.GrbEncabezado = New System.Windows.Forms.GroupBox
        Me.Cba_Digitador = New System.Windows.Forms.ComboBox
        Me.Cba_Analista = New System.Windows.Forms.ComboBox
        Me.Dtp_fechadigita = New System.Windows.Forms.DateTimePicker
        Me.DtP_fechanalisis = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrbCargaPlanilla = New System.Windows.Forms.GroupBox
        Me.TxtNlabDesdePla = New System.Windows.Forms.TextBox
        Me.DTPFechaDigPla = New System.Windows.Forms.DateTimePicker
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txt_Nlab2 = New System.Windows.Forms.TextBox
        Me.Txt_Nlab1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Bt_Cerrar = New System.Windows.Forms.Button
        Me.Bt_Limpiar = New System.Windows.Forms.Button
        CType(Me.Dtg_Textura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbEncabezado.SuspendLayout()
        Me.GrbCargaPlanilla.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Lect1
        '
        Me.Txt_Lect1.Location = New System.Drawing.Point(344, 48)
        Me.Txt_Lect1.Name = "Txt_Lect1"
        Me.Txt_Lect1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Lect1.TabIndex = 1
        Me.Txt_Lect1.Visible = False
        '
        'Txt_Temp1
        '
        Me.Txt_Temp1.Location = New System.Drawing.Point(344, 88)
        Me.Txt_Temp1.Name = "Txt_Temp1"
        Me.Txt_Temp1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Temp1.TabIndex = 2
        Me.Txt_Temp1.Visible = False
        '
        'Txt_Lect2
        '
        Me.Txt_Lect2.Location = New System.Drawing.Point(344, 120)
        Me.Txt_Lect2.Name = "Txt_Lect2"
        Me.Txt_Lect2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Lect2.TabIndex = 3
        Me.Txt_Lect2.Visible = False
        '
        'Txt_Temp2
        '
        Me.Txt_Temp2.Location = New System.Drawing.Point(344, 152)
        Me.Txt_Temp2.Name = "Txt_Temp2"
        Me.Txt_Temp2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Temp2.TabIndex = 4
        Me.Txt_Temp2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.printer
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(992, 944)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'bt_Graba
        '
        Me.bt_Graba.BackColor = System.Drawing.Color.Transparent
        Me.bt_Graba.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Graba.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.bt_Graba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Graba.Location = New System.Drawing.Point(896, 944)
        Me.bt_Graba.Name = "bt_Graba"
        Me.bt_Graba.Size = New System.Drawing.Size(80, 24)
        Me.bt_Graba.TabIndex = 63
        Me.bt_Graba.Text = "Grabar"
        Me.bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Graba.UseVisualStyleBackColor = False
        Me.bt_Graba.Visible = False
        '
        'Dtg_Textura
        '
        Me.Dtg_Textura.CaptionVisible = False
        Me.Dtg_Textura.DataMember = ""
        Me.Dtg_Textura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Textura.HeaderFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Textura.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Textura.Location = New System.Drawing.Point(336, 0)
        Me.Dtg_Textura.Name = "Dtg_Textura"
        Me.Dtg_Textura.Size = New System.Drawing.Size(816, 928)
        Me.Dtg_Textura.TabIndex = 64
        Me.Dtg_Textura.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.Dtg_Textura.Visible = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.Dtg_Textura
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "TEXTURA_SUELO1"
        Me.DataGridTableStyle2.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "NºLab"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 49
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "1ºLect"
        Me.DataGridTextBoxColumn2.MappingName = "LECTURA1"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "1ºTemp"
        Me.DataGridTextBoxColumn3.MappingName = "TEMP1"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "2ºLect"
        Me.DataGridTextBoxColumn4.MappingName = "LECTURA2"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "2ºTemp"
        Me.DataGridTextBoxColumn5.MappingName = "TEMP2"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "%Arcilla"
        Me.DataGridTextBoxColumn6.MappingName = "ARC"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "%Limo"
        Me.DataGridTextBoxColumn7.MappingName = "LIMO"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "%Arena"
        Me.DataGridTextBoxColumn8.MappingName = "ARENA"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Total"
        Me.DataGridTextBoxColumn9.MappingName = "TOTAL"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Clase Textural"
        Me.DataGridTextBoxColumn10.MappingName = "CLASE_TEXTURAL"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 140
        '
        'GrbEncabezado
        '
        Me.GrbEncabezado.Controls.Add(Me.Cba_Digitador)
        Me.GrbEncabezado.Controls.Add(Me.Cba_Analista)
        Me.GrbEncabezado.Controls.Add(Me.Dtp_fechadigita)
        Me.GrbEncabezado.Controls.Add(Me.DtP_fechanalisis)
        Me.GrbEncabezado.Controls.Add(Me.Label1)
        Me.GrbEncabezado.Controls.Add(Me.Label2)
        Me.GrbEncabezado.Controls.Add(Me.Label4)
        Me.GrbEncabezado.Controls.Add(Me.Label5)
        Me.GrbEncabezado.Controls.Add(Me.GrbCargaPlanilla)
        Me.GrbEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.GrbEncabezado.Name = "GrbEncabezado"
        Me.GrbEncabezado.Size = New System.Drawing.Size(336, 312)
        Me.GrbEncabezado.TabIndex = 65
        Me.GrbEncabezado.TabStop = False
        '
        'Cba_Digitador
        '
        Me.Cba_Digitador.FormattingEnabled = True
        Me.Cba_Digitador.Location = New System.Drawing.Point(136, 71)
        Me.Cba_Digitador.Name = "Cba_Digitador"
        Me.Cba_Digitador.Size = New System.Drawing.Size(121, 21)
        Me.Cba_Digitador.TabIndex = 55
        '
        'Cba_Analista
        '
        Me.Cba_Analista.FormattingEnabled = True
        Me.Cba_Analista.Location = New System.Drawing.Point(136, 41)
        Me.Cba_Analista.Name = "Cba_Analista"
        Me.Cba_Analista.Size = New System.Drawing.Size(121, 21)
        Me.Cba_Analista.TabIndex = 54
        '
        'Dtp_fechadigita
        '
        Me.Dtp_fechadigita.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_fechadigita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_fechadigita.Location = New System.Drawing.Point(136, 16)
        Me.Dtp_fechadigita.Name = "Dtp_fechadigita"
        Me.Dtp_fechadigita.Size = New System.Drawing.Size(88, 20)
        Me.Dtp_fechadigita.TabIndex = 1
        '
        'DtP_fechanalisis
        '
        Me.DtP_fechanalisis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtP_fechanalisis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtP_fechanalisis.Location = New System.Drawing.Point(136, 102)
        Me.DtP_fechanalisis.Name = "DtP_fechanalisis"
        Me.DtP_fechanalisis.Size = New System.Drawing.Size(88, 20)
        Me.DtP_fechanalisis.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "F.Digitación"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Análisis"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Analista"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Digitador "
        '
        'GrbCargaPlanilla
        '
        Me.GrbCargaPlanilla.Controls.Add(Me.TxtNlabDesdePla)
        Me.GrbCargaPlanilla.Controls.Add(Me.DTPFechaDigPla)
        Me.GrbCargaPlanilla.Controls.Add(Me.Label35)
        Me.GrbCargaPlanilla.Controls.Add(Me.Label34)
        Me.GrbCargaPlanilla.Controls.Add(Me.Label7)
        Me.GrbCargaPlanilla.Controls.Add(Me.Txt_Nlab2)
        Me.GrbCargaPlanilla.Controls.Add(Me.Txt_Nlab1)
        Me.GrbCargaPlanilla.Controls.Add(Me.Label8)
        Me.GrbCargaPlanilla.Controls.Add(Me.Button3)
        Me.GrbCargaPlanilla.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbCargaPlanilla.Location = New System.Drawing.Point(0, 128)
        Me.GrbCargaPlanilla.Name = "GrbCargaPlanilla"
        Me.GrbCargaPlanilla.Size = New System.Drawing.Size(336, 184)
        Me.GrbCargaPlanilla.TabIndex = 53
        Me.GrbCargaPlanilla.TabStop = False
        Me.GrbCargaPlanilla.Text = "Código Planilla"
        '
        'TxtNlabDesdePla
        '
        Me.TxtNlabDesdePla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNlabDesdePla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNlabDesdePla.Location = New System.Drawing.Point(136, 88)
        Me.TxtNlabDesdePla.Name = "TxtNlabDesdePla"
        Me.TxtNlabDesdePla.Size = New System.Drawing.Size(56, 20)
        Me.TxtNlabDesdePla.TabIndex = 67
        '
        'DTPFechaDigPla
        '
        Me.DTPFechaDigPla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaDigPla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDigPla.Location = New System.Drawing.Point(136, 24)
        Me.DTPFechaDigPla.Name = "DTPFechaDigPla"
        Me.DTPFechaDigPla.Size = New System.Drawing.Size(80, 20)
        Me.DTPFechaDigPla.TabIndex = 65
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(16, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 23)
        Me.Label35.TabIndex = 64
        Me.Label35.Text = "F.Planifica"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(16, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 23)
        Me.Label34.TabIndex = 43
        Me.Label34.Text = "N° Lab Inicial"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cód.Planifica"
        '
        'Txt_Nlab2
        '
        Me.Txt_Nlab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Nlab2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nlab2.Location = New System.Drawing.Point(248, 88)
        Me.Txt_Nlab2.Name = "Txt_Nlab2"
        Me.Txt_Nlab2.Size = New System.Drawing.Size(56, 20)
        Me.Txt_Nlab2.TabIndex = 6
        '
        'Txt_Nlab1
        '
        Me.Txt_Nlab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Nlab1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nlab1.Location = New System.Drawing.Point(136, 56)
        Me.Txt_Nlab1.Name = "Txt_Nlab1"
        Me.Txt_Nlab1.Size = New System.Drawing.Size(56, 20)
        Me.Txt_Nlab1.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(216, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "al "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.LabSys.My.Resources.Resources.server_database
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(136, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Carga"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Bt_Cerrar
        '
        Me.Bt_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Cerrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Cerrar.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Bt_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Cerrar.Location = New System.Drawing.Point(1184, 944)
        Me.Bt_Cerrar.Name = "Bt_Cerrar"
        Me.Bt_Cerrar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Cerrar.TabIndex = 66
        Me.Bt_Cerrar.Text = "Salir"
        Me.Bt_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Cerrar.UseVisualStyleBackColor = False
        '
        'Bt_Limpiar
        '
        Me.Bt_Limpiar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Limpiar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Limpiar.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Bt_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Limpiar.Location = New System.Drawing.Point(1088, 944)
        Me.Bt_Limpiar.Name = "Bt_Limpiar"
        Me.Bt_Limpiar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Limpiar.TabIndex = 67
        Me.Bt_Limpiar.Text = "Limpiar"
        Me.Bt_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Limpiar.UseVisualStyleBackColor = False
        '
        'Frm_Textura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Bt_Limpiar)
        Me.Controls.Add(Me.Bt_Cerrar)
        Me.Controls.Add(Me.bt_Graba)
        Me.Controls.Add(Me.Txt_Lect1)
        Me.Controls.Add(Me.Txt_Temp1)
        Me.Controls.Add(Me.Txt_Lect2)
        Me.Controls.Add(Me.Txt_Temp2)
        Me.Controls.Add(Me.GrbEncabezado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dtg_Textura)
        Me.Name = "Frm_Textura"
        Me.Text = "Textura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dtg_Textura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbEncabezado.ResumeLayout(False)
        Me.GrbCargaPlanilla.ResumeLayout(False)
        Me.GrbCargaPlanilla.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub dtg_textura_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtg_Textura.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        If Txt_Lect1.Visible = True Then Txt_Lect1.Visible = False
        If Txt_Temp1.Visible = True Then Txt_Temp1.Visible = False
        If Txt_Lect2.Visible = True Then Txt_Lect2.Visible = False
        If Txt_Temp2.Visible = True Then Txt_Temp2.Visible = False
        Fila_Lectura = Dtg_Textura.CurrentCell.RowNumber()
        Revision_Digitacion = "N"
        'If Dtg_Textura.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"
        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.
        If Dtg_Textura.CurrentCell.ColumnNumber = 1 Then
            Dim CeldaAlto As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).X + Dtg_Textura.Left
            Dim Posiciony As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Y + Dtg_Textura.Top
            Txt_Lect1.Left = Posicionx
            Txt_Lect1.Top = Posiciony
            Txt_Lect1.Height = CeldaAlto
            Txt_Lect1.Width = CeldaAncho
            Txt_Lect1.Visible = True
            Txt_Lect1.Text = ""
            Txt_Lect1.Enabled = True
            Txt_Lect1.TabIndex = 1
            Txt_Lect1.Focus()
        End If
        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.
        If Dtg_Textura.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).X + Dtg_Textura.Left
            Dim Posiciony As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Y + Dtg_Textura.Top
            Txt_Temp1.Left = Posicionx
            Txt_Temp1.Top = Posiciony
            Txt_Temp1.Height = CeldaAlto
            Txt_Temp1.Width = CeldaAncho
            Txt_Temp1.Visible = True
            Txt_Temp1.Text = ""
            Txt_Temp1.Enabled = True
            Txt_Temp1.TabIndex = 2
            Txt_Temp1.Focus()
        End If
        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.
        If Dtg_Textura.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).X + Dtg_Textura.Left
            Dim Posiciony As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Y + Dtg_Textura.Top
            Txt_Lect2.Left = Posicionx
            Txt_Lect2.Top = Posiciony
            Txt_Lect2.Height = CeldaAlto
            Txt_Lect2.Width = CeldaAncho
            Txt_Lect2.Visible = True
            Txt_Lect2.Text = ""
            Txt_Lect2.Enabled = True
            Txt_Lect2.TabIndex = 3
            Txt_Lect2.Focus()
        End If
        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.
        If Dtg_Textura.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).X + Dtg_Textura.Left
            Dim Posiciony As Integer = Dtg_Textura.GetCellBounds(Dtg_Textura.CurrentCell.RowNumber, Dtg_Textura.CurrentCell.ColumnNumber).Y + Dtg_Textura.Top
            Txt_Temp2.Left = Posicionx
            Txt_Temp2.Top = Posiciony
            Txt_Temp2.Height = CeldaAlto
            Txt_Temp2.Width = CeldaAncho
            Txt_Temp2.Visible = True
            Txt_Temp2.Text = ""
            Txt_Temp2.Enabled = True
            Txt_Temp2.TabIndex = 4
            Txt_Temp2.Focus()
        End If

    End Sub
    
    Private Sub Carga_Planilla()
        Dim Fila_Digitacion, Fila_Carga As DataRow
        Dim Carga_Digitacion, query, Son_Blancos As String
        Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
        Dim FactorE As Double
        Dim SqlConn As New SqlConnection
        SqlConn = New SqlConnection(Conexion1)
        Son_Blancos = "S"
        Elemento = "WTexBouyouco"
        If TxtNlabDesdePla.Text <> "" And Txt_Nlab2.Text <> "" Then
            Cjto_Tablas1.Tables("TEXTURA_SUELO1").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_Nlab1.Text & "' AND OTC_FECHA_PLANI='" & Me.DTPFechaDigPla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
            Dim myCommand As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read()
                Carga_Digitacion = "N"
                If CInt(myReader.GetString(0)) >= CInt(TxtNlabDesdePla.Text) And CInt(myReader.GetString(0)) <= CInt(Txt_Nlab2.Text) Then Carga_Digitacion = "S"

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
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_Nlab1.Text & "' AND OTC_FECHA_PLANI='" & Me.DTPFechaDigPla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
        Dim myCommand1 As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        While myReader1.Read()

            If Me.Txt_Nlab1.Text = "" Or Me.Txt_Nlab2.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
            If CInt(myReader1.GetString(0)) >= CInt(Txt_Nlab1.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_Nlab2.Text) Then Carga_Digitacion = "S"

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

    Private Sub ANTI_ELIMINA_LINEA()
        ' Con este codigo se puede Eliminar el datasource de la pagina de Diseño
        'Solamente hay que asignar al Datagrid el conjunto de tablas elejido
        Dtg_Textura.DataSource = Cjto_Tablas1.Tables("TEXTURA_SUELO1")
    End Sub
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' El boton 3 es el encargado de cargar la grilla, y asigna la propiedad visible a los
        ' Diferentes elementos

        Call Carga_Planilla()
        Dtg_Textura.Visible = True
        Button1.Visible = True
        bt_Graba.Visible = True
        Txt_Lect1.Focus()
    End Sub
    Private Sub Frm_Textura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.ANTI_ELIMINA_LINEA()
    End Sub
    Private Sub Txt_Temp2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Temp2.KeyPress
        Dim ARE, ARC, LIM, TOTAL, FILA As Double
        Dim mycell As New DataGridCell
        Dim Tipo As String
        If e.KeyChar = Chr(13) Then
            Dtg_Textura.Item(Fila_Lectura, 4) = Txt_Temp2.Text
            'El llamado a la funcion Clasificacion es para obtener los resultados de Arena, Limo y Arcilla
            Call Clasificacion(CDbl(Me.Txt_Lect1.Text), CDbl(Txt_Lect2.Text), CDbl(Me.Txt_Temp1.Text), CDbl(Me.Txt_Temp2.Text), ARC, ARE, LIM, TOTAL)
            Dtg_Textura.Item(Fila_Lectura, 5) = ARC
            Dtg_Textura.Item(Fila_Lectura, 6) = LIM
            Dtg_Textura.Item(Fila_Lectura, 7) = ARE
            Dtg_Textura.Item(Fila_Lectura, 8) = TOTAL
            ' Al llamar a la funcion de Clase Textural, se obtiene el nombre de la clase
            ' Ej:Franca,Arcillosa
            Call Clase_Textural(ARC, LIM, ARE, Tipo)
            Dtg_Textura.Item(Fila_Lectura, 9) = Tipo
            mycell.ColumnNumber = 1
            mycell.RowNumber = Fila_Lectura + 1
            Dtg_Textura.CurrentCell = mycell
            Me.Txt_Lect1.Focus()
        End If
    End Sub
    Private Sub Txt_lect1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Lect1.KeyPress
        Dim ARE, ARC, LIM, TOTAL, FILA As Double
        Dim mycell As New DataGridCell
        Dim txt_temp1 As Integer
        If e.KeyChar = Chr(13) Then
            Dtg_Textura.Item(Fila_Lectura, 1) = Txt_Lect1.Text
            mycell.ColumnNumber = 2
            mycell.RowNumber = Fila_Lectura
            Dtg_Textura.CurrentCell = mycell
            Me.Txt_Temp1.Focus()
        End If
    End Sub
    Private Sub Txt_Temp1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Temp1.KeyPress
        Dim ARE, ARC, LIM, TOTAL, FILA As Double
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_Textura.Item(Fila_Lectura, 2) = Txt_Temp1.Text
            mycell.ColumnNumber = 3
            mycell.RowNumber = Fila_Lectura
            Dtg_Textura.CurrentCell = mycell
            Me.Txt_Lect2.Focus()
        End If
    End Sub
    Private Sub Txt_Lect2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Lect2.KeyPress
        Dim ARE, ARC, LIM, TOTAL, FILA As Double
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_Textura.Item(Fila_Lectura, 3) = Txt_Lect2.Text
            mycell.ColumnNumber = 4
            mycell.RowNumber = Fila_Lectura
            Dtg_Textura.CurrentCell = mycell
            Me.Txt_Temp2.Focus()
        End If
    End Sub

    Private Sub Txt_Nlab1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Nlab1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtNlabDesdePla.Focus()
        End If
    End Sub
    Private Sub TxtNlabDesdePla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNlabDesdePla.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Txt_Nlab2.Focus()
        End If
    End Sub
    Private Sub Txt_Nlab2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Nlab2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Button3.Focus()
        End If
    End Sub
    Private Sub graba(ByVal cont As Integer, ByVal codigo As String)
        Dim con As New SqlConnection(Conexion1)
        Dim con2 As New SqlConnection(Conexion1)
        Dim CON3 As New SqlConnection(Conexion1)
        Dim COMAND, COMAND2, COMAND3 As SqlCommand
        Dim query, query2, query3 As String
        Dim LECT1, TEMP1, LECT2, TEMP2, ARE, LIM, ARC, TOTAL As Integer
        Call ANTI_ELIMINA_LINEA()
        Dim FILA_T As DataRow
        Dim FILA_G As Integer
        Dim FILA_D As Integer
        Dim I As Integer
        Dim FILA_DIGITA As DataRow


        FILA_DIGITA = Cjto_Tablas1.Tables("TEXTURA_SUELO2").NewRow

        Dim Carga As String
        FILA_G = 0
        query3 = "SELECT COUNT(OT_NLABD)FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_Nlab1.Text & "' AND OTC_FECHA_PLANI='" & Me.DTPFechaDigPla.Text & "' AND TMU_CODIGO=4000  "
        CON3.Open()
        COMAND3 = New SqlCommand(query3, CON3)
        cont = 0
        Dim MyReader3 As SqlDataReader = COMAND3.ExecuteReader
        MyReader3.Read()
        cont = MyReader3.GetInt32(0)
        MyReader3.Close()
        CON3.Close()

        Try
            For I = 1 To cont
                query = "INSERT INTO TEXTURA_SUELO(OT_NLAB,ELE_CODIGO,ARENA,LIMO,ARC,TOTAL, " & _
                 "CLASE_TEXTURAL,LECTURA1,LECTURA2,TEMP1,TEMP2) " & _
                " VALUES(" & Me.Dtg_Textura(FILA_G, 0) & ", '" & codigo & "', " & Me.Dtg_Textura(FILA_G, 7) & ", " & _
                Me.Dtg_Textura(FILA_G, 6) & ", " & Me.Dtg_Textura(FILA_G, 5) & ", " & Me.Dtg_Textura(FILA_G, 8) & ", '" & _
                Me.Dtg_Textura(FILA_G, 9) & "', " & Me.Dtg_Textura(FILA_G, 1) & ", " & Me.Dtg_Textura(FILA_G, 3) & ", " & _
                Me.Dtg_Textura(FILA_G, 2) & ", " & Me.Dtg_Textura(FILA_G, 4) & ")"
                con.Open()
                COMAND = New SqlCommand(query, con)
                If COMAND.ExecuteNonQuery <> 0 Then
                    COMAND.Dispose()
                    con.Close()
                End If
                FILA_G = FILA_G + 1
            Next


            For I = 1 To cont
                query2 = "UPDATE DIGITA_RESULTADOS SET ELE_ESTADO='xR',DIGRES_FECHA_ANA='" & DTPFechaDigPla.Text & "',DIGRES_FECHA='" & Dtp_fechadigita.Text & "' WHERE  OT_NLAB='" & Dtg_Textura.Item(FILA_D, 0) & "' AND ELE_CODIGO='" & Elemento & "'"
                con2.Open()
                COMAND2 = New SqlCommand(query2, con2)
                Dim MYREADER As SqlDataReader = COMAND2.ExecuteReader
                MYREADER.Close()
                con2.Close()
            Next
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try

    End Sub
    Private Sub bt_Graba_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_Graba.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Cont, i As Integer
        Dim Fila_Dat As DataRow

        Cont = Dtg_Textura.CurrentCell.RowNumber
        Fila_Lectura = 0

        Try
            For Each Fila_Dat In Cjto_Tablas1.Tables("TEXTURA_SUELO1").Rows
                With SP
                    .Inicializar()
                    .AgregarParametro("@Num_lab", CInt(Dtg_Textura(Fila_Lectura, 0)), SqlDbType.Int)

                    .AgregarParametro("@Blanco", 0, SqlDbType.Int)
                    .AgregarParametro("@Lect1", CInt(Fila_Dat("LECTURA1")), SqlDbType.Int)
                    .AgregarParametro("@Temp1", CInt(Fila_Dat("TEMP1")), SqlDbType.Int)
                    .AgregarParametro("@Lect2", CInt(Fila_Dat("LECTURA2")), SqlDbType.Int)
                    .AgregarParametro("@Temp2", CInt(Fila_Dat("TEMP2")), SqlDbType.Int)
                    .AgregarParametro("@Arena", CInt(Fila_Dat("ARENA")), SqlDbType.Int)
                    .AgregarParametro("@Limo", CInt(Fila_Dat("LIMO")), SqlDbType.Int)
                    .AgregarParametro("@Arcilla", CInt(Fila_Dat("ARC")), SqlDbType.Int)
                    .AgregarParametro("@Cla_textura", Fila_Dat("CLASE_TEXTURAL"), SqlDbType.NVarChar)
                    .AgregarParametro("@Cap1", 0, SqlDbType.Int)
                    .AgregarParametro("@Peso_cap1", CDbl(0), SqlDbType.Float)
                    .AgregarParametro("@Cap2", 0, SqlDbType.Int)
                    .AgregarParametro("@Peso_cap2", CDbl(0), SqlDbType.Float)
                    .AgregarParametro("@Peso_agruesa", CDbl(0), SqlDbType.Float)
                    .AgregarParametro("@Peso_afina", CDbl(0), SqlDbType.Float)
                    .AgregarParametro("@Porc_agruesa", 0, SqlDbType.Int)
                    .AgregarParametro("@Porc_afina", 0, SqlDbType.Int)
                    .EjecutarEscalar("usp_GrabaTextura")
                End With

                With SP
                    .Inicializar()
                    .AgregarParametro("@Fecha_analisis", DtP_fechanalisis.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Fecha_digita", Dtp_fechadigita.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Num_lab", Dtg_Textura(Fila_Lectura, 0), SqlDbType.Int)
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


    Private Sub Bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Cerrar.Click
        Frm_Textura.ActiveForm.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim Destino As String = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2008\040  DIGITACION Y CALCULO RESULTADOS\Formato Base\Copia de Formatos Resultados.xls"
        Dim Destino2 As String = "F:\Mis documentos\Graba Planillas\Suelo\" & nombre & " " & Txt_Nlab1.Text & ".xls"
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
        Call EncavezadoPag(Dtp_fechadigita.Text, DtP_fechanalisis.Text, objHojaExcel)
        Call EncavezadoTextura(objHojaExcel)
        ' Call Encavezado_ResultadoTex(objHojaExcel)
        Call Imprime_PiePagTex(objHojaExcel, Cba_Analista.Text, Cba_Digitador.Text)
        Call Imprime_ResultadosTex(objHojaExcel)
    End Sub

    Private Sub Bt_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Limpiar.Click
        TxtNlabDesdePla.ResetText()
        Txt_Nlab2.ResetText()
        Txt_Lect1.Visible = False
        Cjto_Tablas1.Tables("TEXTURA_SUELO1").Clear()
    End Sub
End Class



