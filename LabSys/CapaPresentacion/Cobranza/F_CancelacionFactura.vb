Imports Microsoft.Office.Interop

Public Class F_CancelacionFactura
    Inherits System.Windows.Forms.Form
    Private sAño As String
    Friend WithEvents CBComuna As System.Windows.Forms.ComboBox
    Private sMes As String


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtgFacturasxCancelar As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFechaFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    'Friend WithEvents CBComuna As ComboboxAutoCompletar.AutoCompletarComboBox
    Friend WithEvents CmdGrabar As System.Windows.Forms.Button
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CKBPte As System.Windows.Forms.CheckBox
    Friend WithEvents CKBCan As System.Windows.Forms.CheckBox
    Friend WithEvents CKBNula As System.Windows.Forms.CheckBox
    Friend WithEvents TxtRSocial As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    Friend WithEvents CmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents CKBNC As System.Windows.Forms.CheckBox
    Friend WithEvents TxtFono As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents TxtRutFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DtgOrdenesFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblCantFact As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CmdImprimir As System.Windows.Forms.Button
    Friend WithEvents ChkMoroso As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtOT As System.Windows.Forms.TextBox
    Friend WithEvents CmdOrdenax As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_CancelacionFactura))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtgFacturasxCancelar = New System.Windows.Forms.DataGrid
        Me.DtpFechaFactura = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtRutFactura = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ChkMoroso = New System.Windows.Forms.CheckBox
        Me.CKBNC = New System.Windows.Forms.CheckBox
        Me.Label98 = New System.Windows.Forms.Label
        Me.CKBPte = New System.Windows.Forms.CheckBox
        Me.CKBCan = New System.Windows.Forms.CheckBox
        Me.CKBNula = New System.Windows.Forms.CheckBox
        Me.TxtRSocial = New System.Windows.Forms.TextBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.TxtFechaFactura = New System.Windows.Forms.TextBox
        Me.CmdAceptar = New System.Windows.Forms.Button
        Me.CmdLimpiar = New System.Windows.Forms.Button
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtFono = New System.Windows.Forms.TextBox
        Me.CmdGrabar = New System.Windows.Forms.Button
        Me.CmdSalir = New System.Windows.Forms.Button
        Me.TxtNumFactura = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEmpresa = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtgOrdenesFacturas = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblCantFact = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmdImprimir = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtOT = New System.Windows.Forms.TextBox
        Me.CmdOrdenax = New System.Windows.Forms.Button
        Me.CBComuna = New System.Windows.Forms.ComboBox
        CType(Me.DtgFacturasxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgOrdenesFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cancelación Facturas Pendientes"
        '
        'DtgFacturasxCancelar
        '
        Me.DtgFacturasxCancelar.AllowSorting = False
        Me.DtgFacturasxCancelar.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DtgFacturasxCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DtgFacturasxCancelar.CaptionBackColor = System.Drawing.Color.MediumBlue
        Me.DtgFacturasxCancelar.CaptionFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgFacturasxCancelar.CaptionVisible = False
        Me.DtgFacturasxCancelar.DataMember = ""
        Me.DtgFacturasxCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgFacturasxCancelar.HeaderBackColor = System.Drawing.SystemColors.ControlText
        Me.DtgFacturasxCancelar.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DtgFacturasxCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtgFacturasxCancelar.Location = New System.Drawing.Point(8, 56)
        Me.DtgFacturasxCancelar.Name = "DtgFacturasxCancelar"
        Me.DtgFacturasxCancelar.Size = New System.Drawing.Size(1256, 752)
        Me.DtgFacturasxCancelar.TabIndex = 59
        '
        'DtpFechaFactura
        '
        Me.DtpFechaFactura.CustomFormat = "dd-mm-yyyy"
        Me.DtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFactura.Location = New System.Drawing.Point(409, 869)
        Me.DtpFechaFactura.Name = "DtpFechaFactura"
        Me.DtpFechaFactura.Size = New System.Drawing.Size(20, 20)
        Me.DtpFechaFactura.TabIndex = 165
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(754, 843)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "(ej.: 9999999-9)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(586, 842)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Rut Fact :"
        '
        'TxtRutFactura
        '
        Me.TxtRutFactura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRutFactura.Location = New System.Drawing.Point(648, 840)
        Me.TxtRutFactura.Name = "TxtRutFactura"
        Me.TxtRutFactura.Size = New System.Drawing.Size(100, 20)
        Me.TxtRutFactura.TabIndex = 163
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkMoroso)
        Me.GroupBox3.Controls.Add(Me.CKBNC)
        Me.GroupBox3.Controls.Add(Me.Label98)
        Me.GroupBox3.Controls.Add(Me.CKBPte)
        Me.GroupBox3.Controls.Add(Me.CKBCan)
        Me.GroupBox3.Controls.Add(Me.CKBNula)
        Me.GroupBox3.Location = New System.Drawing.Point(576, 862)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 32)
        Me.GroupBox3.TabIndex = 161
        Me.GroupBox3.TabStop = False
        '
        'ChkMoroso
        '
        Me.ChkMoroso.Location = New System.Drawing.Point(352, 8)
        Me.ChkMoroso.Name = "ChkMoroso"
        Me.ChkMoroso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkMoroso.Size = New System.Drawing.Size(48, 16)
        Me.ChkMoroso.TabIndex = 31
        Me.ChkMoroso.Text = "Mor"
        '
        'CKBNC
        '
        Me.CKBNC.Location = New System.Drawing.Point(296, 8)
        Me.CKBNC.Name = "CKBNC"
        Me.CKBNC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBNC.Size = New System.Drawing.Size(48, 16)
        Me.CKBNC.TabIndex = 30
        Me.CKBNC.Text = "N/C"
        '
        'Label98
        '
        Me.Label98.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.Black
        Me.Label98.Location = New System.Drawing.Point(8, 8)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(96, 16)
        Me.Label98.TabIndex = 21
        Me.Label98.Text = "Estados Factura"
        '
        'CKBPte
        '
        Me.CKBPte.Location = New System.Drawing.Point(104, 8)
        Me.CKBPte.Name = "CKBPte"
        Me.CKBPte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBPte.Size = New System.Drawing.Size(48, 16)
        Me.CKBPte.TabIndex = 25
        Me.CKBPte.Text = "Pte"
        '
        'CKBCan
        '
        Me.CKBCan.Location = New System.Drawing.Point(168, 8)
        Me.CKBCan.Name = "CKBCan"
        Me.CKBCan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBCan.Size = New System.Drawing.Size(48, 16)
        Me.CKBCan.TabIndex = 29
        Me.CKBCan.Text = "Can"
        '
        'CKBNula
        '
        Me.CKBNula.Location = New System.Drawing.Point(232, 8)
        Me.CKBNula.Name = "CKBNula"
        Me.CKBNula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBNula.Size = New System.Drawing.Size(48, 16)
        Me.CKBNula.TabIndex = 27
        Me.CKBNula.Text = "Nula"
        '
        'TxtRSocial
        '
        Me.TxtRSocial.Location = New System.Drawing.Point(70, 840)
        Me.TxtRSocial.Name = "TxtRSocial"
        Me.TxtRSocial.Size = New System.Drawing.Size(136, 20)
        Me.TxtRSocial.TabIndex = 153
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Black
        Me.Label80.Location = New System.Drawing.Point(8, 842)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(64, 16)
        Me.Label80.TabIndex = 152
        Me.Label80.Text = "R.Social :"
        '
        'Label83
        '
        Me.Label83.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.Black
        Me.Label83.Location = New System.Drawing.Point(413, 842)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(72, 16)
        Me.Label83.TabIndex = 157
        Me.Label83.Text = "Comuna :"
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Black
        Me.Label73.Location = New System.Drawing.Point(269, 871)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(67, 16)
        Me.Label73.TabIndex = 150
        Me.Label73.Text = "F. Factura :"
        '
        'TxtFechaFactura
        '
        Me.TxtFechaFactura.Location = New System.Drawing.Point(338, 869)
        Me.TxtFechaFactura.MaxLength = 4
        Me.TxtFechaFactura.Name = "TxtFechaFactura"
        Me.TxtFechaFactura.Size = New System.Drawing.Size(72, 20)
        Me.TxtFechaFactura.TabIndex = 151
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.Color.Transparent
        Me.CmdAceptar.Image = CType(resources.GetObject("CmdAceptar.Image"), System.Drawing.Image)
        Me.CmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAceptar.Location = New System.Drawing.Point(1029, 876)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(65, 23)
        Me.CmdAceptar.TabIndex = 146
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'CmdLimpiar
        '
        Me.CmdLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.CmdLimpiar.Image = CType(resources.GetObject("CmdLimpiar.Image"), System.Drawing.Image)
        Me.CmdLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdLimpiar.Location = New System.Drawing.Point(1029, 840)
        Me.CmdLimpiar.Name = "CmdLimpiar"
        Me.CmdLimpiar.Size = New System.Drawing.Size(65, 24)
        Me.CmdLimpiar.TabIndex = 166
        Me.CmdLimpiar.Text = "Limpiar"
        Me.CmdLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdLimpiar.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(490, 869)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(80, 20)
        Me.TxtTotal.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(448, 871)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Total :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(850, 842)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "Fono :"
        '
        'TxtFono
        '
        Me.TxtFono.Location = New System.Drawing.Point(896, 840)
        Me.TxtFono.Name = "TxtFono"
        Me.TxtFono.Size = New System.Drawing.Size(96, 20)
        Me.TxtFono.TabIndex = 170
        '
        'CmdGrabar
        '
        Me.CmdGrabar.BackColor = System.Drawing.Color.Transparent
        Me.CmdGrabar.Image = CType(resources.GetObject("CmdGrabar.Image"), System.Drawing.Image)
        Me.CmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGrabar.Location = New System.Drawing.Point(1110, 876)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.Size = New System.Drawing.Size(74, 23)
        Me.CmdGrabar.TabIndex = 173
        Me.CmdGrabar.Text = "Grabar"
        Me.CmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdGrabar.UseVisualStyleBackColor = False
        '
        'CmdSalir
        '
        Me.CmdSalir.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), System.Drawing.Image)
        Me.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalir.Location = New System.Drawing.Point(1200, 876)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(64, 23)
        Me.CmdSalir.TabIndex = 174
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSalir.UseVisualStyleBackColor = False
        '
        'TxtNumFactura
        '
        Me.TxtNumFactura.Location = New System.Drawing.Point(78, 869)
        Me.TxtNumFactura.Name = "TxtNumFactura"
        Me.TxtNumFactura.Size = New System.Drawing.Size(64, 20)
        Me.TxtNumFactura.TabIndex = 176
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 871)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "Nº Factura :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(232, 842)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Empresa :"
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.Location = New System.Drawing.Point(298, 840)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Size = New System.Drawing.Size(96, 20)
        Me.TxtEmpresa.TabIndex = 177
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtgOrdenesFacturas)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 128)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'DtgOrdenesFacturas
        '
        Me.DtgOrdenesFacturas.BackgroundColor = System.Drawing.Color.White
        Me.DtgOrdenesFacturas.CaptionVisible = False
        Me.DtgOrdenesFacturas.DataMember = ""
        Me.DtgOrdenesFacturas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgOrdenesFacturas.Location = New System.Drawing.Point(16, 32)
        Me.DtgOrdenesFacturas.Name = "DtgOrdenesFacturas"
        Me.DtgOrdenesFacturas.ReadOnly = True
        Me.DtgOrdenesFacturas.Size = New System.Drawing.Size(840, 88)
        Me.DtgOrdenesFacturas.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(848, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 18)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(1, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(848, 16)
        Me.Label8.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(152, 816)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "Total :"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblTotal.Location = New System.Drawing.Point(192, 814)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(96, 20)
        Me.LblTotal.TabIndex = 181
        '
        'LblCantFact
        '
        Me.LblCantFact.BackColor = System.Drawing.Color.Gainsboro
        Me.LblCantFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCantFact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantFact.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblCantFact.Location = New System.Drawing.Point(78, 814)
        Me.LblCantFact.Name = "LblCantFact"
        Me.LblCantFact.Size = New System.Drawing.Size(40, 20)
        Me.LblCantFact.TabIndex = 183
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(8, 816)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "Cant.Fact :"
        '
        'CmdImprimir
        '
        Me.CmdImprimir.BackColor = System.Drawing.Color.Transparent
        Me.CmdImprimir.Image = CType(resources.GetObject("CmdImprimir.Image"), System.Drawing.Image)
        Me.CmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdImprimir.Location = New System.Drawing.Point(1200, 840)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.Size = New System.Drawing.Size(64, 23)
        Me.CmdImprimir.TabIndex = 184
        Me.CmdImprimir.Text = "Imprimir"
        Me.CmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdImprimir.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(151, 871)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "N° OT :"
        '
        'TxtOT
        '
        Me.TxtOT.Location = New System.Drawing.Point(201, 869)
        Me.TxtOT.Name = "TxtOT"
        Me.TxtOT.Size = New System.Drawing.Size(64, 20)
        Me.TxtOT.TabIndex = 185
        '
        'CmdOrdenax
        '
        Me.CmdOrdenax.BackColor = System.Drawing.Color.Transparent
        Me.CmdOrdenax.Image = Global.LabSys.My.Resources.Resources.table_multiple
        Me.CmdOrdenax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdOrdenax.Location = New System.Drawing.Point(1110, 840)
        Me.CmdOrdenax.Name = "CmdOrdenax"
        Me.CmdOrdenax.Size = New System.Drawing.Size(74, 23)
        Me.CmdOrdenax.TabIndex = 187
        Me.CmdOrdenax.Text = "Ordena x"
        Me.CmdOrdenax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdOrdenax.UseVisualStyleBackColor = False
        '
        'CBComuna
        '
        Me.CBComuna.FormattingEnabled = True
        Me.CBComuna.Location = New System.Drawing.Point(477, 840)
        Me.CBComuna.Name = "CBComuna"
        Me.CBComuna.Size = New System.Drawing.Size(99, 21)
        Me.CBComuna.TabIndex = 188
        '
        'F_CancelacionFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 925)
        Me.Controls.Add(Me.CBComuna)
        Me.Controls.Add(Me.CmdOrdenax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtOT)
        Me.Controls.Add(Me.CmdImprimir)
        Me.Controls.Add(Me.LblCantFact)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtEmpresa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNumFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdGrabar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtFono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.DtpFechaFactura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtRutFactura)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TxtRSocial)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.TxtFechaFactura)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdLimpiar)
        Me.Controls.Add(Me.DtgFacturasxCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_CancelacionFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelación de Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DtgFacturasxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgOrdenesFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub Form_CancelacionFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet = New DataSet
        Dim fila As DataRow
        Cjto_Tablas1.Tables("FACTURAS_POR").Clear()
        Call Anti_Elimina_lineas()

        CKBPte.Checked = True

        Call Crear_Formato_Grilla()
        Call Crear_Formato_Grilla_Ordenes()

        CBComuna.Items.Add("")
        For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
            CBComuna.Items.Add(fila("COMUNA"))
        Next
        'Call Filtro_Grilla()
        'Call Proceso_Ordena_Por()
    End Sub

    Private Sub Anti_Elimina_lineas()
        Me.DtgFacturasxCancelar.DataSource = Cjto_Tablas1.Tables("FACTURAS_POR")
        Me.DtgOrdenesFacturas.DataSource = Cjto_Tablas1.Tables("ORDENES_FACTURAS")
    End Sub

    Private Sub Crear_Formato_Grilla()
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "FACTURAS_POR"
        Dim NumLabo As New DataGridTextBoxColumn
        NumLabo.MappingName = "FAC_NUMERO"
        NumLabo.HeaderText = "N° Factura"
        NumLabo.Width = 50
        NumLabo.ReadOnly = True
        NumLabo.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(NumLabo)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "FAC_FECHA_EMISION"
        TextCol.HeaderText = "F.Emisión"
        TextCol.Width = 70
        TextCol.NullText = ""
        TextCol.ReadOnly = True
        TextCol.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol9 As New DataGridTextBoxColumn
        TextCol9.MappingName = "FAC_TOTAL"
        TextCol9.HeaderText = "Total"
        TextCol9.Width = 70
        TextCol9.Format = "####,##0"
        TextCol9.NullText = ""
        TextCol9.ReadOnly = True
        TextCol9.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol9)

        Dim TextCol21 As New DataGridTextBoxColumn
        TextCol21.MappingName = "FAC_ABONO"
        TextCol21.HeaderText = "Abono"
        TextCol21.Width = 60
        TextCol21.Format = "####,###"
        TextCol21.NullText = ""
        TextCol21.ReadOnly = False
        TextCol21.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol21)

        Dim TextCol22 As New DataGridTextBoxColumn
        TextCol22.MappingName = "FAC_CONDICION_PAGO"
        TextCol22.HeaderText = "Cond.Pago"
        TextCol22.Width = 60
        TextCol22.NullText = ""
        TextCol22.ReadOnly = True
        TextCol22.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol22)


        Dim TextCol16 As New DataGridTextBoxColumn
        TextCol16.MappingName = "FAC_NOTA_CREDITO"
        TextCol16.HeaderText = "N° NC"
        TextCol16.Width = 40
        TextCol16.NullText = ""
        TextCol16.Format = "####,###"
        TextCol16.ReadOnly = True
        TextCol16.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol16)

        Dim TextCol10 As New DataGridTextBoxColumn
        TextCol10.MappingName = "FAC_FECHA_CANCELADA"
        TextCol10.HeaderText = "F.Can"
        TextCol10.Width = 60
        TextCol10.NullText = ""
        TextCol10.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol10)

        Dim TextCol18 As New DataGridTextBoxColumn
        TextCol18.MappingName = "FAC_FECHA_DEPOSITO"
        TextCol18.HeaderText = "F.Dep"
        TextCol18.Width = 60
        TextCol18.NullText = ""
        TextCol18.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol18)

        Dim TextCol17 As New DataGridTextBoxColumn
        TextCol17.MappingName = "FAC_TIPO_COBRANZA"
        TextCol17.HeaderText = "Dep."
        TextCol17.Width = 30
        TextCol17.NullText = ""
        TextCol17.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol17)

        Dim TextCol19 As New DataGridTextBoxColumn
        TextCol19.MappingName = "FAC_ESTADO"
        TextCol19.HeaderText = "Est"
        TextCol19.Width = 30
        TextCol19.NullText = ""
        TextCol19.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol19)

        Dim TextCol11 As New DataGridTextBoxColumn
        TextCol11.MappingName = "FAC_RUT"
        TextCol11.HeaderText = "Rut"
        TextCol11.Width = 75
        TextCol11.ReadOnly = True
        TextCol11.NullText = ""
        TextCol11.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol11)

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "FAC_RSOCIAL"
        TextCol1.HeaderText = "Razón Social"
        TextCol1.Width = 170
        TextCol1.ReadOnly = True
        TextCol1.NullText = ""
        TextCol1.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol12 As New DataGridTextBoxColumn
        TextCol12.MappingName = "FAC_EMPRESA"
        TextCol12.HeaderText = "Empresa"
        TextCol12.Width = 40
        TextCol12.ReadOnly = True
        TextCol12.NullText = ""
        TextCol12.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol12)

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "FAC_COMUNA"
        TextCol2.HeaderText = "Comuna"
        TextCol2.Width = 70
        TextCol2.ReadOnly = True
        TextCol2.NullText = ""
        TextCol2.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "FAC_CIUDAD"
        TextCol3.HeaderText = "Ciudad"
        TextCol3.Width = 70
        TextCol3.ReadOnly = True
        TextCol3.NullText = ""
        TextCol3.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "FAC_ENCPAGO"
        TextCol4.HeaderText = "Encargado Pago"
        TextCol4.Width = 100
        TextCol4.NullText = ""
        TextCol4.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol4)

        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "FAC_F1PAGO"
        TextCol5.HeaderText = "Fono Pag1"
        TextCol5.Width = 70
        TextCol5.ReadOnly = False
        TextCol5.NullText = ""
        TextCol5.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol5)

        Dim TxtCol7 As New DataGridTextBoxColumn
        TxtCol7.MappingName = "FAC_F2PAGO"
        TxtCol7.HeaderText = "Fono Pag2"
        TxtCol7.Width = 70
        TxtCol7.ReadOnly = False
        TxtCol7.NullText = ""
        TxtCol7.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TxtCol7)

        Dim TxtCol20 As New DataGridTextBoxColumn
        TxtCol20.MappingName = "FAC_FECHA_LLAMAR"
        TxtCol20.HeaderText = "Llamar el:"
        TxtCol20.Width = 70
        TxtCol20.NullText = ""
        TxtCol20.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TxtCol20)

        Dim TxtCol8 As New DataGridTextBoxColumn
        TxtCol8.MappingName = "FAC_NOTA_COBRANZA"
        TxtCol8.HeaderText = "Nota"
        TxtCol8.Width = 600
        TxtCol8.NullText = ""
        TxtCol8.Alignment = HorizontalAlignment.Left

        ts1.GridColumnStyles.Add(TxtCol8)

        DtgFacturasxCancelar.TableStyles.Add(ts1)
    End Sub


    Private Sub Crear_Formato_Grilla_Ordenes()
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "ORDENES_FACTURAS"
        Dim NumLabo As New DataGridTextBoxColumn
        NumLabo.MappingName = "OT_NUMERO"
        NumLabo.HeaderText = "N° Orden"
        NumLabo.Width = 50
        NumLabo.ReadOnly = True
        NumLabo.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(NumLabo)

        Dim TextCol10 As New DataGridTextBoxColumn
        TextCol10.MappingName = "OT_FECHA_ORDEN"
        TextCol10.HeaderText = "F.Orden"
        TextCol10.Width = 75
        TextCol10.NullText = ""
        TextCol10.ReadOnly = True
        TextCol10.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol10)

        Dim TextCol9 As New DataGridTextBoxColumn
        TextCol9.MappingName = "PRO_PRODUCTOR"
        TextCol9.HeaderText = "Productor"
        TextCol9.Width = 200
        TextCol9.NullText = ""
        TextCol9.ReadOnly = True
        TextCol9.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol9)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "PRO_RUT"
        TextCol.HeaderText = "Rut Productor"
        TextCol.Width = 90
        TextCol.NullText = ""
        TextCol.ReadOnly = True
        TextCol.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol16 As New DataGridTextBoxColumn
        TextCol16.MappingName = "OT_FAC_RUT"
        TextCol16.HeaderText = "Rut Facturacion"
        TextCol16.Width = 90
        TextCol16.NullText = ""
        TextCol16.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol16)

        Dim TextCol11 As New DataGridTextBoxColumn
        TextCol11.MappingName = "OT_ABONO"
        TextCol11.HeaderText = "Abono"
        TextCol11.Width = 80
        TextCol11.ReadOnly = True
        TextCol11.NullText = ""
        TextCol11.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol11)

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "OT_TOTAL"
        TextCol1.HeaderText = "Total"
        TextCol1.Width = 80
        TextCol1.ReadOnly = True
        TextCol1.NullText = ""
        TextCol1.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol12 As New DataGridTextBoxColumn
        TextCol12.MappingName = "OT_ESTADO_ANA"
        TextCol12.HeaderText = "Ana"
        TextCol12.Width = 30
        TextCol12.ReadOnly = True
        TextCol12.NullText = ""
        TextCol12.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol12)

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "OT_ESTADO_PAG"
        TextCol2.HeaderText = "Pag"
        TextCol2.Width = 30
        TextCol2.ReadOnly = True
        TextCol2.NullText = ""
        TextCol2.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "OT_ESTADO_FAC"
        TextCol3.HeaderText = "Fac"
        TextCol3.Width = 30
        TextCol3.ReadOnly = True
        TextCol3.NullText = ""
        TextCol3.Alignment = HorizontalAlignment.Center

        ts1.GridColumnStyles.Add(TextCol3)

        DtgOrdenesFacturas.TableStyles.Add(ts1)
    End Sub

    Private Sub DTPFechaFactura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFechaFactura.ValueChanged
        TxtFechaFactura.Text = DtpFechaFactura.Text
    End Sub

    Private Sub Filtro_Grilla()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Factura, Fila_Cobranza As DataRow
        Dim PASO, Mypos As Integer


        Cjto_Tablas1.Tables("FACTURAS_TODAS").Clear()
        Cjto_Tablas1.Tables("FACTURAS_POR").Clear()

        If TxtOT.Text <> "" Then
            With SP
                .Inicializar()
                .AgregarParametro("@NumOT", CInt(TxtOT.Text), SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectFacturasTodasxOT", Cjto_Tablas1, "FACTURAS_TODAS")
            End With
        Else
            With SP
                .Inicializar()
                .EjecutarQueryDt("usp_SelectFacturasTodas", Cjto_Tablas1, "FACTURAS_TODAS")
            End With

        End If

        For Each Fila_Factura In Cjto_Tablas1.Tables("FACTURAS_TODAS").Rows
            PASO = 1

            If TxtRSocial.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_RSOCIAL")) = False Then Mypos = InStr(UCase(Fila_Factura("FAC_RSOCIAL")), UCase(TxtRSocial.Text))
                If Mypos = 0 Then PASO = 0
            End If

            If CBComuna.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_COMUNA")) = False Then
                    If Fila_Factura("FAC_COMUNA") <> CBComuna.Text Then PASO = 0
                End If
            End If

            If TxtRutFactura.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_RUT")) = False Then
                    If Fila_Factura("FAC_RUT") <> TxtRutFactura.Text Then PASO = 0
                End If
            End If


            If TxtEmpresa.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_EMPRESA")) = False Then Mypos = InStr(UCase(Fila_Factura("FAC_EMPRESA")), UCase(TxtEmpresa.Text))
                If Mypos = 0 Then PASO = 0
            End If

            If TxtFono.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_F1PAGO")) = False Then Mypos = InStr(UCase(Fila_Factura("FAC_F1PAGO")), UCase(TxtFono.Text))
                If Mypos = 0 Then PASO = 0
                If IsDBNull(Fila_Factura("FAC_F2PAGO")) = False Then Mypos = InStr(UCase(Fila_Factura("FAC_F2PAGO")), UCase(TxtFono.Text))
                If Mypos = 0 Then PASO = 0
            End If

            If TxtNumFactura.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_NUMERO")) = False Then
                    If Fila_Factura("FAC_NUMERO") <> TxtNumFactura.Text Then PASO = 0
                End If
            End If

            If TxtFechaFactura.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_FECHA_EMISION")) = False Then
                    If Fila_Factura("FAC_FECHA_EMISION") >= CDate(TxtFechaFactura.Text) Then PASO = 0
                End If
            End If

            If TxtTotal.Text <> "" Then
                If IsDBNull(Fila_Factura("FAC_TOTAL")) = False Then
                    If Fila_Factura("FAC_TOTAL") <> TxtTotal.Text Then PASO = 0
                End If
            End If

            If CKBPte.Checked = True Then
                If IsDBNull(Fila_Factura("FAC_ESTADO")) = False Then
                    If IsDBNull(Fila_Factura("FAC_FECHA_DEPOSITO")) = False Then
                        If Fila_Factura("FAC_ESTADO") <> "Pte" And Fila_Factura("FAC_FECHA_DEPOSITO") <> "" Then PASO = 0
                    End If
                    If Fila_Factura("FAC_ESTADO") = "Nula" Then PASO = 0
                End If
            End If

            If CKBCan.Checked = True Then
                If IsDBNull(Fila_Factura("FAC_ESTADO")) = False Then
                    If Fila_Factura("FAC_ESTADO") <> "Can" Then PASO = 0
                End If
            End If

            If CKBNula.Checked = True Then
                If IsDBNull(Fila_Factura("FAC_ESTADO")) = False Then
                    If Fila_Factura("FAC_ESTADO") <> "Nula" Then PASO = 0
                End If
            End If

            If CKBNC.Checked = True Then
                If IsDBNull(Fila_Factura("FAC_ESTADO")) = False Then
                    If Fila_Factura("FAC_ESTADO") <> "NC" Then PASO = 0
                End If
            End If

            If ChkMoroso.Checked = True Then
                If IsDBNull(Fila_Factura("FAC_ESTADO")) = False Then
                    If Fila_Factura("FAC_ESTADO") <> "Mor" Then PASO = 0
                End If
            End If

            If PASO = 1 Then
                Fila_Cobranza = Cjto_Tablas1.Tables("FACTURAS_POR").NewRow
                Fila_Cobranza("FAC_NUMERO") = Fila_Factura("FAC_NUMERO")
                Fila_Cobranza("FAC_TOTAL") = Fila_Factura("FAC_TOTAL")
                If IsDBNull(Fila_Factura("FAC_FECHA_CANCELADA")) = False Then Fila_Cobranza("FAC_FECHA_CANCELADA") = Fila_Factura("FAC_FECHA_CANCELADA")

                If IsDBNull(Fila_Factura("FAC_TIPO_COBRANZA")) = False Then Fila_Cobranza("FAC_TIPO_COBRANZA") = Fila_Factura("FAC_TIPO_COBRANZA")
                If IsDBNull(Fila_Factura("FAC_FECHA_EMISION")) = False Then Fila_Cobranza("FAC_FECHA_EMISION") = Fila_Factura("FAC_FECHA_EMISION")
                Fila_Cobranza("FAC_RUT") = Fila_Factura("FAC_RUT")
                Fila_Cobranza("FAC_RSOCIAL") = Fila_Factura("FAC_RSOCIAL")
                Fila_Cobranza("FAC_EMPRESA") = Fila_Factura("FAC_EMPRESA")
                Fila_Cobranza("FAC_COMUNA") = Fila_Factura("FAC_COMUNA")
                Fila_Cobranza("FAC_CIUDAD") = Fila_Factura("FAC_CIUDAD")
                Fila_Cobranza("FAC_ENCPAGO") = Fila_Factura("FAC_ENCPAGO")
                If IsDBNull(Fila_Factura("FAC_F1PAGO")) = False Then Fila_Cobranza("FAC_F1PAGO") = Fila_Factura("FAC_F1PAGO")
                If IsDBNull(Fila_Factura("FAC_F2PAGO")) = False Then Fila_Cobranza("FAC_F2PAGO") = Fila_Factura("FAC_F2PAGO")
                Fila_Cobranza("FAC_FECHA_LLAMAR") = Fila_Factura("FAC_FECHA_LLAMAR")
                Fila_Cobranza("FAC_NOTA_COBRANZA") = Fila_Factura("FAC_NOTA_COBRANZA")
                If IsDBNull(Fila_Factura("FAC_FECHA_DEPOSITO")) = False Then Fila_Cobranza("FAC_FECHA_DEPOSITO") = Fila_Factura("FAC_FECHA_DEPOSITO")
                If IsDBNull(Fila_Factura("FAC_ESTADO")) = False Then Fila_Cobranza("FAC_ESTADO") = Fila_Factura("FAC_ESTADO")
                If IsDBNull(Fila_Factura("FAC_NOTA_CREDITO")) = False Then Fila_Cobranza("FAC_NOTA_CREDITO") = Fila_Factura("FAC_NOTA_CREDITO")
                If IsDBNull(Fila_Factura("FAC_ABONO")) = False Then Fila_Cobranza("FAC_ABONO") = Fila_Factura("FAC_ABONO")
                Try
                    Cjto_Tablas1.Tables("FACTURAS_POR").Rows.Add(Fila_Cobranza)
                Catch ex As Exception
                End Try
            End If
        Next
        Call Calcula_Total()
    End Sub

    'Private Sub FormatGridCells2(ByVal sender As Object, ByVal e As Format_Grilla)
    '    If (e.Column = 7 Or e.Column = 8 Or e.Column = 9 Or e.Column = 10 Or e.Column = 11) Then
    '        e.TextFont = New Font(e.TextFont.Name, 7, FontStyle.Bold)
    '    End If
    'End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        Call Filtro_Grilla()
    End Sub

    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub CmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLimpiar.Click
        TxtRSocial.Text = ""
        TxtRutFactura.Text = ""
        TxtFono.Text = ""
        TxtNumFactura.Text = ""
        TxtFechaFactura.Text = ""
        TxtTotal.Text = ""
        CBComuna.Text = ""
        CKBPte.Checked = True
        CKBCan.Checked = False
        CKBNula.Checked = False
        CKBNC.Checked = False
        Cjto_Tablas1.Tables("FACTURAS_POR").Clear()
        Me.LblCantFact.Text = ""
        Me.LblTotal.Text = ""
    End Sub

    Private Sub CmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabar.Click
        Dim Fila_Cobranza, Fila_OrdenFacturadas, ff As DataRow
        Dim numFila As Integer
        Dim ds As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim respuesta As MsgBoxResult
        Dim a As String

        respuesta = MsgBox("Esta seguro de Grabar", MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            For Each Fila_Cobranza In Cjto_Tablas1.Tables("FACTURAS_POR").Rows
                'If Fila_Cobranza("FAC_NUMERO") = 43609 Then
                '    a = "0"
                'End If
                If IsDBNull(Fila_Cobranza("FAC_FECHA_CANCELADA")) = False Or IsDBNull(Fila_Cobranza("FAC_FECHA_DEPOSITO")) = False Or IsDBNull(Fila_Cobranza("FAC_NOTA_COBRANZA")) = False Or IsDBNull(Fila_Cobranza("FAC_FECHA_LLAMAR")) = False Or IsDBNull(Fila_Cobranza("FAC_ABONO")) = False Then
                    With SP
                        .Inicializar()
                        .AgregarParametro("@NumFact", Fila_Cobranza("FAC_NUMERO"), SqlDbType.Int)
                        .AgregarParametro("@FechaCancelada", Fila_Cobranza("FAC_FECHA_CANCELADA"), SqlDbType.NVarChar)
                        .AgregarParametro("@TipoCobranza", Fila_Cobranza("FAC_TIPO_COBRANZA"), SqlDbType.NVarChar)
                        .AgregarParametro("@Nota", Fila_Cobranza("FAC_NOTA_COBRANZA"), SqlDbType.NVarChar)
                        .AgregarParametro("@FechaDeposito", Fila_Cobranza("FAC_FECHA_DEPOSITO"), SqlDbType.NVarChar)
                        .AgregarParametro("@FechaLlamar", Fila_Cobranza("FAC_FECHA_LLAMAR"), SqlDbType.NVarChar)
                        .AgregarParametro("@EncPago", Fila_Cobranza("FAC_ENCPAGO"), SqlDbType.NVarChar)
                        .AgregarParametro("@F1Pago", Fila_Cobranza("FAC_F1PAGO"), SqlDbType.NVarChar)
                        .AgregarParametro("@F2Pago", Fila_Cobranza("FAC_F2PAGO"), SqlDbType.NVarChar)
                        .AgregarParametro("@Abono", Fila_Cobranza("FAC_ABONO"), SqlDbType.Int)
                        .EjecutarQuery("usp_UpdateCancelaFacturas")
                    End With

                    'With SP
                    '    .Inicializar()
                    '    .AgregarParametro("@NumFact", Fila_Cobranza("FAC_NUMERO"), SqlDbType.Int)
                    '    ds = .EjecutarQuery("usp_SelectOrdenesFacturadas")
                    'End With
                    'For Each Fila_OrdenFacturadas In ds.Tables(0).Rows
                    '    With SP
                    '        .Inicializar()
                    '        .AgregarParametro("@NumOt", Fila_OrdenFacturadas("OT_NUMERO"), SqlDbType.Int)
                    '        .EjecutarQuery("usp_TraspasoActualaHistorico")
                    '    End With
                    'Next

                End If
            Next
            MsgBox("Grabación finalizada")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GroupBox1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.GroupBox1.Visible = False
    End Sub

    Private Sub DtgFacturasxCancelar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgFacturasxCancelar.DoubleClick
        Dim Fila_Num As Integer
        Dim Num_Fac As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        Cjto_Tablas1.Tables("ORDENES_FACTURAS").Clear()
        Label8.Text = ""
        Fila_Num = DtgFacturasxCancelar.CurrentCell.RowNumber
        If IsDBNull(DtgFacturasxCancelar.Item(Fila_Num, 0)) = False Then
            Num_Fac = DtgFacturasxCancelar.Item(Fila_Num, 0)
            Label8.Text = "Factura Nº : " & Num_Fac
            With SP
                .Inicializar()
                .AgregarParametro("@NumFac", Num_Fac, SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectOrdenesFactura", Cjto_Tablas1, "ORDENES_FACTURAS")
            End With
            Me.GroupBox1.Visible = True
        End If
    End Sub

    Private Sub Calcula_Total()
        Dim ObjSum, ObjCant As Object
        Dim CantFact As Integer
        Dim SubTotal As Integer = 0

        ObjSum = Cjto_Tablas1.Tables("FACTURAS_POR").Compute("Sum(FAC_TOTAL)", "FAC_TOTAL > 0")
        CantFact = Cjto_Tablas1.Tables("FACTURAS_POR").Rows.Count
        Try
            SubTotal = CInt(ObjSum)
        Catch ex As Exception
        End Try

        LblTotal.Text = Format(SubTotal, "###,###,###")
        LblCantFact.Text = Format(CantFact, "###,###")

    End Sub

    Private Sub CmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImprimir.Click
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim m_Excel As Excel.Application
        Dim Fuente, Destino, TipoListado As String
        Dim FilaD As Integer = 2

        Dim FilaData As DataRow
        Dim MYDATE As Date
        sAño = Year(Today)
        sMes = Month(Today)
        MYDATE = Today
        If sMes = "01" Then
            sMes = "Enero"
        ElseIf sMes = "02" Then
            sMes = "Febrero"
        ElseIf sMes = "03" Then
            sMes = "Marzo"
        ElseIf sMes = "04" Then
            sMes = "Abril"
        ElseIf sMes = "05" Then
            sMes = "Mayo"
        ElseIf sMes = "06" Then
            sMes = "Junio"
        ElseIf sMes = "07" Then
            sMes = "Julio"
        ElseIf sMes = "08" Then
            sMes = "Agosto"
        ElseIf sMes = "09" Then
            sMes = "Septiembre"
        ElseIf sMes = "10" Then
            sMes = "Octubre"
        ElseIf sMes = "11" Then
            sMes = "Noviembre"
        ElseIf sMes = "12" Then
            sMes = "Diciembre"
        End If

        Fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato Facturas Pte.xls"
        Destino = "F:\Mis Documentos\LabSys-Pruebas\Libro de Facturas Pte\Libro Facturas " & sMes & " -" & sAño & ".xls"


        If CKBPte.Checked = True Then TipoListado = "PENDIENTES"
        If CKBCan.Checked = True Then TipoListado = "CANCELADAS"

        Try
            FileCopy(Fuente, Destino)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        m_Excel = CreateObject("EXCEL.APPLICATION")
        objLibroExcel = m_Excel.Workbooks.Open(Destino)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()
        'Imprime_Fact_Pte(objHojaExcel)



        objHojaExcel.Range("A" & FilaD.ToString & ":CQ" & FilaD.ToString).Merge()
        objHojaExcel.Range("A" & FilaD.ToString).Value = "LISTADO FACTURAS " & TipoListado
        objHojaExcel.Range("A" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("A" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("A" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        FilaD = FilaD + 1

        objHojaExcel.Range("A" & FilaD.ToString & ":CQ" & FilaD.ToString).Merge()
        objHojaExcel.Range("A" & FilaD.ToString).Value = "Fecha Informe : " & MYDATE
        objHojaExcel.Range("A" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("A" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("A" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        FilaD = FilaD + 2

        objHojaExcel.Range("A" & FilaD.ToString & ":J" & FilaD.ToString).Merge()
        objHojaExcel.Range("A" & FilaD.ToString).Value = "Nº Factura"
        objHojaExcel.Range("A" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("A" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("A" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("K" & FilaD.ToString & ":V" & FilaD.ToString).Merge()
        objHojaExcel.Range("K" & FilaD.ToString).Value = "F.Emisión"
        objHojaExcel.Range("K" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("K" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("K" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("K" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("K" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & FilaD.ToString & ":AH" & FilaD.ToString).Merge()
        objHojaExcel.Range("W" & FilaD.ToString).Value = "F.Deposito"
        objHojaExcel.Range("W" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("W" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("W" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("W" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("W" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AI" & FilaD.ToString & ":AU" & FilaD.ToString).Merge()
        objHojaExcel.Range("AI" & FilaD.ToString).Value = "Total"
        objHojaExcel.Range("AI" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("AI" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("AI" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("AI" & FilaD.ToString).NumberFormat = "###.###.###"
        objHojaExcel.Range("AI" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AI" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AV" & FilaD.ToString & ":BI" & FilaD.ToString).Merge()
        objHojaExcel.Range("AV" & FilaD.ToString).Value = "Rut"
        objHojaExcel.Range("AV" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("AV" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("AV" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("AV" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AV" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BJ" & FilaD.ToString & ":CS" & FilaD.ToString).Merge()
        objHojaExcel.Range("BJ" & FilaD.ToString).Value = "R.Social"
        objHojaExcel.Range("BJ" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("BJ" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("BJ" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("BJ" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BJ" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CT" & FilaD.ToString & ":DN" & FilaD.ToString).Merge()
        objHojaExcel.Range("CT" & FilaD.ToString).Value = "Empresa"
        objHojaExcel.Range("CT" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("CT" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("CT" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("CT" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CT" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        FilaD = FilaD + 1
        For Each FilaData In Cjto_Tablas1.Tables("FACTURAS_POR").Rows
            objHojaExcel.Range("A" & FilaD.ToString & ":J" & FilaD.ToString).Merge()
            objHojaExcel.Range("A" & FilaD.ToString).Value = FilaData("FAC_NUMERO")
            objHojaExcel.Range("A" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("A" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("A" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("K" & FilaD.ToString & ":V" & FilaD.ToString).Merge()
            objHojaExcel.Range("K" & FilaD.ToString).Value = FilaData("FAC_FECHA_EMISION")
            objHojaExcel.Range("K" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("K" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("K" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("K" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("W" & FilaD.ToString & ":AH" & FilaD.ToString).Merge()
            objHojaExcel.Range("W" & FilaD.ToString).Value = FilaData("FAC_FECHA_DEPOSITO")
            objHojaExcel.Range("W" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("W" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("W" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("W" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AI" & FilaD.ToString & ":AU" & FilaD.ToString).Merge()
            objHojaExcel.Range("AI" & FilaD.ToString).Value = FilaData("FAC_TOTAL")
            objHojaExcel.Range("AI" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("AI" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("AI" & FilaD.ToString).NumberFormat = "###.###.###"
            objHojaExcel.Range("AI" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            objHojaExcel.Range("AI" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AV" & FilaD.ToString & ":BI" & FilaD.ToString).Merge()
            objHojaExcel.Range("AV" & FilaD.ToString).Value = FilaData("FAC_RUT")
            objHojaExcel.Range("AV" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("AV" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("AV" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AV" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BJ" & FilaD.ToString & ":CS" & FilaD.ToString).Merge()
            objHojaExcel.Range("BJ" & FilaD.ToString).Value = FilaData("FAC_RSOCIAL")
            objHojaExcel.Range("BJ" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("BJ" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("BJ" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("BJ" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CT" & FilaD.ToString & ":DN" & FilaD.ToString).Merge()
            objHojaExcel.Range("CT" & FilaD.ToString).Value = FilaData("FAC_EMPRESA")
            objHojaExcel.Range("CT" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("CT" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("CT" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("CT" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


            FilaD = FilaD + 1
        Next

        FilaD = FilaD + 3

        objHojaExcel.Range("K" & FilaD.ToString & ":AX" & FilaD.ToString).Merge()
        objHojaExcel.Range("K" & FilaD.ToString).Value = "Cantidad de Facturas : " & LblCantFact.Text
        objHojaExcel.Range("K" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("K" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("K" & FilaD.ToString).Font.Bold = True
        objHojaExcel.Range("K" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        FilaD = FilaD + 2
        objHojaExcel.Range("K" & FilaD.ToString & ":AX" & FilaD.ToString).Merge()
        objHojaExcel.Range("K" & FilaD.ToString).Value = "Total $                            : " & LblTotal.Text
        objHojaExcel.Range("K" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("K" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("K" & FilaD.ToString).Font.Bold = True
        objHojaExcel.Range("K" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


    End Sub


    Private Sub Imprime_Fact_Pte(ByVal objHojaExcel As Excel.Worksheet)
        Dim Cont As Integer = 0
        Dim FilaData As DataRow
        Dim FilaD As Integer = 9
        Dim NumHoja As Integer = 1
        Dim Param As Integer
        Dim Separador As String = "--------------"
        Dim AcuNeto, AcuIva, AcuTotal As Double

        AcuNeto = 0
        AcuIva = 0
        AcuTotal = 0
        For Each FilaData In Cjto_Tablas1.Tables("LIBRO_VENTAS").Rows

            If NumHoja = 1 Then
                Param = 3
                Call Imprime_Encabezado(objHojaExcel, Param, sMes, sAño)
            ElseIf NumHoja <> 1 Then
                Call Imprime_Encabezado(objHojaExcel, Param, sMes, sAño)
            End If
            objHojaExcel.Range("A" & FilaD.ToString & ":J" & FilaD.ToString).Merge()
            objHojaExcel.Range("A" & FilaD.ToString).Value = FilaData("FAC_NUMERO")
            objHojaExcel.Range("A" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("A" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("A" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("K" & FilaD.ToString & ":V" & FilaD.ToString).Merge()
            objHojaExcel.Range("K" & FilaD.ToString).Value = FilaData("FAC_FECHA_EMISION")
            objHojaExcel.Range("K" & FilaD.ToString).Font.Name = "Arial"
            objHojaExcel.Range("K" & FilaD.ToString).Font.Size = 9
            objHojaExcel.Range("K" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("K" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



            If FilaData("FAC_ESTADO") = "Nula" Then
                objHojaExcel.Range("W" & FilaD.ToString & ":AJ" & FilaD.ToString).Merge()
                objHojaExcel.Range("W" & FilaD.ToString).Value = ""
                objHojaExcel.Range("W" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("W" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("W" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("W" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("AK" & FilaD.ToString & ":BY" & FilaD.ToString).Merge()
                objHojaExcel.Range("AK" & FilaD.ToString).Value = "NULA"
                objHojaExcel.Range("AK" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("AK" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("AK" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("AK" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("BZ" & FilaD.ToString & ":CM" & FilaD.ToString).Merge()
                objHojaExcel.Range("BZ" & FilaD.ToString).Value = ""
                objHojaExcel.Range("BZ" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("BZ" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("BZ" & FilaD.ToString).NumberFormat = "###.###.###"
                objHojaExcel.Range("BZ" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                objHojaExcel.Range("BZ" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("CN" & FilaD.ToString & ":DA" & FilaD.ToString).Merge()
                objHojaExcel.Range("CN" & FilaD.ToString).Value = ""
                objHojaExcel.Range("CN" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("CN" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("CN" & FilaD.ToString).NumberFormat = "###.###.###"
                objHojaExcel.Range("CN" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                objHojaExcel.Range("CN" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("DB" & FilaD.ToString & ":DO" & FilaD.ToString).Merge()
                objHojaExcel.Range("DB" & FilaD.ToString).Value = ""
                objHojaExcel.Range("DB" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("DB" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("DB" & FilaD.ToString).NumberFormat = "###.###.###"
                objHojaExcel.Range("DB" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                objHojaExcel.Range("DB" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            Else
                objHojaExcel.Range("W" & FilaD.ToString & ":AJ" & FilaD.ToString).Merge()
                objHojaExcel.Range("W" & FilaD.ToString).Value = FilaData("FAC_RUT")
                objHojaExcel.Range("W" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("W" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("W" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("W" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("AK" & FilaD.ToString & ":BY" & FilaD.ToString).Merge()
                objHojaExcel.Range("AK" & FilaD.ToString).Value = FilaData("FAC_RSOCIAL")
                objHojaExcel.Range("AK" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("AK" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("AK" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                objHojaExcel.Range("AK" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("BZ" & FilaD.ToString & ":CM" & FilaD.ToString).Merge()
                objHojaExcel.Range("BZ" & FilaD.ToString).Value = FilaData("FAC_NETO")
                objHojaExcel.Range("BZ" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("BZ" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("BZ" & FilaD.ToString).NumberFormat = "###.###.###"
                objHojaExcel.Range("BZ" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                objHojaExcel.Range("BZ" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("CN" & FilaD.ToString & ":DA" & FilaD.ToString).Merge()
                objHojaExcel.Range("CN" & FilaD.ToString).Value = FilaData("FAC_IVA")
                objHojaExcel.Range("CN" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("CN" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("CN" & FilaD.ToString).NumberFormat = "###.###.###"
                objHojaExcel.Range("CN" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                objHojaExcel.Range("CN" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("DB" & FilaD.ToString & ":DO" & FilaD.ToString).Merge()
                objHojaExcel.Range("DB" & FilaD.ToString).Value = FilaData("FAC_TOTAL")
                objHojaExcel.Range("DB" & FilaD.ToString).Font.Name = "Arial"
                objHojaExcel.Range("DB" & FilaD.ToString).Font.Size = 9
                objHojaExcel.Range("DB" & FilaD.ToString).NumberFormat = "###.###.###"
                objHojaExcel.Range("DB" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                objHojaExcel.Range("DB" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End If


            AcuNeto = AcuNeto + CInt(objHojaExcel.Range("BZ" & FilaD.ToString).Value)
            AcuIva = AcuIva + CInt(objHojaExcel.Range("CN" & FilaD.ToString).Value)
            AcuTotal = AcuTotal + CInt(objHojaExcel.Range("DB" & FilaD.ToString).Value)

            FilaD = FilaD + 1
            Cont = Cont + 1

            If Cont Mod 47 = 0 Then

                If NumHoja = 1 Then
                    FilaD = FilaD + 14
                    FilaD = FilaD - ((NumHoja - 1))
                    Param = FilaD - 6
                    NumHoja = NumHoja + 1
                    Cont = 0
                Else
                    FilaD = FilaD + 13
                    Param = FilaD - 6
                    NumHoja = NumHoja + 1
                    Cont = 0
                End If
                'Param = FilaD - 6
                'NumHoja = NumHoja + 1
            End If
        Next

        FilaD = FilaD + 1

        objHojaExcel.Range("A" & FilaD.ToString & ":BY" & FilaD.ToString).Merge()
        objHojaExcel.Range("A" & FilaD.ToString).Value = "Total Final"
        objHojaExcel.Range("A" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & FilaD.ToString).Font.Bold = 9
        objHojaExcel.Range("A" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("A" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("A" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BZ" & FilaD.ToString & ":CM" & FilaD.ToString).Merge()
        objHojaExcel.Range("BZ" & FilaD.ToString).Value = AcuNeto
        objHojaExcel.Range("BZ" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("BZ" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("BZ" & FilaD.ToString).NumberFormat = "###.###.###"
        objHojaExcel.Range("BZ" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("BZ" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CN" & FilaD.ToString & ":DA" & FilaD.ToString).Merge()
        objHojaExcel.Range("CN" & FilaD.ToString).Value = AcuIva
        objHojaExcel.Range("CN" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("CN" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("CN" & FilaD.ToString).NumberFormat = "###.###.###"
        objHojaExcel.Range("CN" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("CN" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DB" & FilaD.ToString & ":DO" & FilaD.ToString).Merge()
        objHojaExcel.Range("DB" & FilaD.ToString).Value = AcuTotal
        objHojaExcel.Range("DB" & FilaD.ToString).Font.Name = "Arial"
        objHojaExcel.Range("DB" & FilaD.ToString).Font.Size = 9
        objHojaExcel.Range("DB" & FilaD.ToString).NumberFormat = "###.###.###"
        objHojaExcel.Range("DB" & FilaD.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DB" & FilaD.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    End Sub



    Private Sub Imprime_Encabezado(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer, ByVal Mes As String, ByVal Año As Integer)
        Dim CADENA As String = "'==========================================================================================================================="
        Dim MYDATE As Date
        MYDATE = Today
        objHojaExcel.Range("AK" & Fila.ToString & ":CC" & Fila.ToString).Merge()
        objHojaExcel.Range("AK" & Fila.ToString).Value = "LIBRO DE FACTURAS PENDIENTES"
        objHojaExcel.Range("AK" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("AK" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("AK" & Fila.ToString).Font.Bold = 9
        objHojaExcel.Range("AK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("A" & Fila.ToString & ":F" & Fila.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "Fecha:"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila.ToString & ":AE" & Fila.ToString).Merge()
        objHojaExcel.Range("G" & Fila.ToString).Value = MYDATE
        objHojaExcel.Range("G" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("G" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("A" & Fila.ToString & ":DO" & Fila.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = CADENA
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("A" & Fila.ToString & ":V" & Fila.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "Factura"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & Fila.ToString & ":AJ" & Fila.ToString).Merge()
        objHojaExcel.Range("W" & Fila.ToString).Value = ""
        objHojaExcel.Range("W" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("W" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("W" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("W" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AK" & Fila.ToString & ":BY" & Fila.ToString).Merge()
        objHojaExcel.Range("AK" & Fila.ToString).Value = "Razon Social"
        objHojaExcel.Range("AK" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("AK" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("AK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BZ" & Fila.ToString & ":CM" & Fila.ToString).Merge()
        objHojaExcel.Range("BZ" & Fila.ToString).Value = "NETO"
        objHojaExcel.Range("BZ" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("BZ" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("BZ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BZ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CN" & Fila.ToString & ":DA" & Fila.ToString).Merge()
        objHojaExcel.Range("CN" & Fila.ToString).Value = "IVA"
        objHojaExcel.Range("CN" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("CN" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("CN" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CN" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DB" & Fila.ToString & ":DO" & Fila.ToString).Merge()
        objHojaExcel.Range("DB" & Fila.ToString).Value = "TOTAL"
        objHojaExcel.Range("DB" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("DB" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("DB" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DB" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "Nº"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("K" & Fila.ToString & ":V" & Fila.ToString).Merge()
        objHojaExcel.Range("K" & Fila.ToString).Value = "Fecha"
        objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("K" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("A" & Fila.ToString & ":DO" & Fila.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = CADENA
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Arial"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


    End Sub

    Private Sub TxtNumFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub TxtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotal.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub TxtRSocial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRSocial.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub TxtEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmpresa.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub TxtFechaFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFechaFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub TxtRutFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRutFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub TxtFono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFono.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub CBComuna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBComuna.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub TxtOT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOT.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub CmdOrdenax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOrdenax.Click
        CKBPte.Checked = True
        CKBCan.Checked = False
        CKBNC.Checked = False
        CKBNula.Checked = False
        ChkMoroso.Checked = False
        'Call Proceso_Ordena_Por()
    End Sub


    Private Sub Proceso_Ordena_Por()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Factura, Fila_Cobranza, Fila_Facturas_Rut As DataRow
        Dim PASO, Mypos As Integer
        Dim ds1 As DataSet = New DataSet
        Dim ds2 As DataSet = New DataSet


        Cjto_Tablas1.Tables("FACTURAS_TODAS").Clear()
        Cjto_Tablas1.Tables("FACTURAS_POR").Clear()


        With SP
            .Inicializar()
            ds1 = .EjecutarQuery("usp_SelectFacturasPte")
        End With


        For Each Fila_Factura In ds1.Tables(0).Rows
            With SP
                .Inicializar()
                .AgregarParametro("@RutFact", Fila_Factura("FAC_RUT"), SqlDbType.NVarChar)
                ds2 = .EjecutarQuery("usp_SelectFacturasxRut")
            End With

            For Each Fila_Facturas_Rut In ds2.Tables(0).Rows
                Fila_Cobranza = Cjto_Tablas1.Tables("FACTURAS_POR").NewRow
                Fila_Cobranza("FAC_NUMERO") = Fila_Facturas_Rut("FAC_NUMERO")
                Fila_Cobranza("FAC_TOTAL") = Fila_Facturas_Rut("FAC_TOTAL")
                If IsDBNull(Fila_Facturas_Rut("FAC_FECHA_CANCELADA")) = False Then Fila_Cobranza("FAC_FECHA_CANCELADA") = Fila_Facturas_Rut("FAC_FECHA_CANCELADA")

                If IsDBNull(Fila_Facturas_Rut("FAC_TIPO_COBRANZA")) = False Then Fila_Cobranza("FAC_TIPO_COBRANZA") = Fila_Facturas_Rut("FAC_TIPO_COBRANZA")
                If IsDBNull(Fila_Facturas_Rut("FAC_FECHA_EMISION")) = False Then Fila_Cobranza("FAC_FECHA_EMISION") = Fila_Facturas_Rut("FAC_FECHA_EMISION")
                Fila_Cobranza("FAC_RUT") = Fila_Facturas_Rut("FAC_RUT")
                Fila_Cobranza("FAC_RSOCIAL") = Fila_Facturas_Rut("FAC_RSOCIAL")
                Fila_Cobranza("FAC_EMPRESA") = Fila_Facturas_Rut("FAC_EMPRESA")
                Fila_Cobranza("FAC_COMUNA") = Fila_Facturas_Rut("FAC_COMUNA")
                Fila_Cobranza("FAC_CIUDAD") = Fila_Facturas_Rut("FAC_CIUDAD")
                Fila_Cobranza("FAC_ENCPAGO") = Fila_Facturas_Rut("FAC_ENCPAGO")
                If IsDBNull(Fila_Facturas_Rut("FAC_F1PAGO")) = False Then Fila_Cobranza("FAC_F1PAGO") = Fila_Facturas_Rut("FAC_F1PAGO")
                If IsDBNull(Fila_Facturas_Rut("FAC_F2PAGO")) = False Then Fila_Cobranza("FAC_F2PAGO") = Fila_Facturas_Rut("FAC_F2PAGO")
                Fila_Cobranza("FAC_FECHA_LLAMAR") = Fila_Facturas_Rut("FAC_FECHA_LLAMAR")
                Fila_Cobranza("FAC_NOTA_COBRANZA") = Fila_Facturas_Rut("FAC_NOTA_COBRANZA")
                If IsDBNull(Fila_Facturas_Rut("FAC_FECHA_DEPOSITO")) = False Then Fila_Cobranza("FAC_FECHA_DEPOSITO") = Fila_Facturas_Rut("FAC_FECHA_DEPOSITO")
                If IsDBNull(Fila_Facturas_Rut("FAC_ESTADO")) = False Then Fila_Cobranza("FAC_ESTADO") = Fila_Facturas_Rut("FAC_ESTADO")
                If IsDBNull(Fila_Facturas_Rut("FAC_NOTA_CREDITO")) = False Then Fila_Cobranza("FAC_NOTA_CREDITO") = Fila_Facturas_Rut("FAC_NOTA_CREDITO")
                If IsDBNull(Fila_Facturas_Rut("FAC_ABONO")) = False Then Fila_Cobranza("FAC_ABONO") = Fila_Facturas_Rut("FAC_ABONO")
                If IsDBNull(Fila_Facturas_Rut("FAC_CONDICION_PAGO")) = False Then Fila_Cobranza("FAC_CONDICION_PAGO") = Fila_Facturas_Rut("FAC_CONDICION_PAGO")

                Try
                    Cjto_Tablas1.Tables("FACTURAS_POR").Rows.Add(Fila_Cobranza)
                Catch ex As Exception
                End Try
            Next

        Next
        Call Calcula_Total()

    End Sub
End Class
