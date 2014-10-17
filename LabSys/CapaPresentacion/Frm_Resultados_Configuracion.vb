Public Class Frm_Resultados_Configuracion
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
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TxtNumMues As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TxtFecIng As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TxtFecInforme As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GBEstandar As System.Windows.Forms.GroupBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GBConfig_Firmas As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GBConfig_Logo As System.Windows.Forms.GroupBox
    Friend WithEvents GBConfig_PosHojas As System.Windows.Forms.GroupBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents MCCalendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents CmdNombre As System.Windows.Forms.ComboBox
    Friend WithEvents CmdCargo As System.Windows.Forms.ComboBox
    Friend WithEvents CmdGraba As System.Windows.Forms.Button
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents LblTMuestra As System.Windows.Forms.Label
    Friend WithEvents ChkOtro As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRosita As System.Windows.Forms.CheckBox
    Friend WithEvents RdbLogoNo As System.Windows.Forms.RadioButton
    Friend WithEvents RdbLogoSi As System.Windows.Forms.RadioButton
    Friend WithEvents RdbPosHorizontal As System.Windows.Forms.RadioButton
    Friend WithEvents RdbPosVertical As System.Windows.Forms.RadioButton
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents cmdFecInforme As System.Windows.Forms.Button
    Friend WithEvents RdbRangoOmite As System.Windows.Forms.RadioButton
    Friend WithEvents RdbRangoIncluye As System.Windows.Forms.RadioButton
    Friend WithEvents LblCargo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaTermino As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaAnalisis As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Resultados_Configuracion))
        Me.Label31 = New System.Windows.Forms.Label
        Me.TxtNumMues = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.cmdFecInforme = New System.Windows.Forms.Button
        Me.TxtFecIng = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.TxtFecInforme = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.GBEstandar = New System.Windows.Forms.GroupBox
        Me.RdbRangoOmite = New System.Windows.Forms.RadioButton
        Me.RdbRangoIncluye = New System.Windows.Forms.RadioButton
        Me.Label38 = New System.Windows.Forms.Label
        Me.GBConfig_Firmas = New System.Windows.Forms.GroupBox
        Me.ChkOtro = New System.Windows.Forms.CheckBox
        Me.ChkRosita = New System.Windows.Forms.CheckBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.GBConfig_Logo = New System.Windows.Forms.GroupBox
        Me.RdbLogoNo = New System.Windows.Forms.RadioButton
        Me.RdbLogoSi = New System.Windows.Forms.RadioButton
        Me.GBConfig_PosHojas = New System.Windows.Forms.GroupBox
        Me.RdbPosHorizontal = New System.Windows.Forms.RadioButton
        Me.RdbPosVertical = New System.Windows.Forms.RadioButton
        Me.Label41 = New System.Windows.Forms.Label
        Me.MCCalendario = New System.Windows.Forms.MonthCalendar
        Me.CmdNombre = New System.Windows.Forms.ComboBox
        Me.CmdCargo = New System.Windows.Forms.ComboBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblCargo = New System.Windows.Forms.Label
        Me.CmdGraba = New System.Windows.Forms.Button
        Me.CmdSalir = New System.Windows.Forms.Button
        Me.LblTMuestra = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtFechaAnalisis = New System.Windows.Forms.TextBox
        Me.TxtFechaTermino = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GBEstandar.SuspendLayout()
        Me.GBConfig_Firmas.SuspendLayout()
        Me.GBConfig_Logo.SuspendLayout()
        Me.GBConfig_PosHojas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(192, 416)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 32)
        Me.Label31.TabIndex = 71
        Me.Label31.Text = "(N° entre 1 y 3)"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNumMues
        '
        Me.TxtNumMues.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumMues.Location = New System.Drawing.Point(152, 424)
        Me.TxtNumMues.Name = "TxtNumMues"
        Me.TxtNumMues.Size = New System.Drawing.Size(32, 20)
        Me.TxtNumMues.TabIndex = 70
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(16, 416)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 32)
        Me.Label35.TabIndex = 69
        Me.Label35.Text = "N° Muestras/pag"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdFecInforme
        '
        Me.cmdFecInforme.BackColor = System.Drawing.Color.Transparent
        Me.cmdFecInforme.Image = CType(resources.GetObject("cmdFecInforme.Image"), System.Drawing.Image)
        Me.cmdFecInforme.Location = New System.Drawing.Point(176, 16)
        Me.cmdFecInforme.Name = "cmdFecInforme"
        Me.cmdFecInforme.Size = New System.Drawing.Size(32, 23)
        Me.cmdFecInforme.TabIndex = 68
        Me.cmdFecInforme.UseVisualStyleBackColor = False
        '
        'TxtFecIng
        '
        Me.TxtFecIng.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecIng.Location = New System.Drawing.Point(304, 16)
        Me.TxtFecIng.Name = "TxtFecIng"
        Me.TxtFecIng.Size = New System.Drawing.Size(88, 20)
        Me.TxtFecIng.TabIndex = 67
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(232, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 24)
        Me.Label36.TabIndex = 66
        Me.Label36.Text = "F. Ingreso :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFecInforme
        '
        Me.TxtFecInforme.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecInforme.Location = New System.Drawing.Point(88, 16)
        Me.TxtFecInforme.Name = "TxtFecInforme"
        Me.TxtFecInforme.Size = New System.Drawing.Size(88, 20)
        Me.TxtFecInforme.TabIndex = 65
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(16, 336)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(128, 32)
        Me.Label37.TabIndex = 64
        Me.Label37.Text = "Fechas"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GBEstandar
        '
        Me.GBEstandar.Controls.Add(Me.RdbRangoOmite)
        Me.GBEstandar.Controls.Add(Me.RdbRangoIncluye)
        Me.GBEstandar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEstandar.Location = New System.Drawing.Point(152, 280)
        Me.GBEstandar.Name = "GBEstandar"
        Me.GBEstandar.Size = New System.Drawing.Size(176, 32)
        Me.GBEstandar.TabIndex = 63
        Me.GBEstandar.TabStop = False
        '
        'RdbRangoOmite
        '
        Me.RdbRangoOmite.Location = New System.Drawing.Point(104, 12)
        Me.RdbRangoOmite.Name = "RdbRangoOmite"
        Me.RdbRangoOmite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbRangoOmite.Size = New System.Drawing.Size(64, 16)
        Me.RdbRangoOmite.TabIndex = 1
        Me.RdbRangoOmite.Text = "Omite"
        '
        'RdbRangoIncluye
        '
        Me.RdbRangoIncluye.Location = New System.Drawing.Point(8, 12)
        Me.RdbRangoIncluye.Name = "RdbRangoIncluye"
        Me.RdbRangoIncluye.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbRangoIncluye.Size = New System.Drawing.Size(64, 16)
        Me.RdbRangoIncluye.TabIndex = 0
        Me.RdbRangoIncluye.Text = "Incluye"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(16, 288)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(136, 16)
        Me.Label38.TabIndex = 62
        Me.Label38.Text = "Rango Interpretación"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GBConfig_Firmas
        '
        Me.GBConfig_Firmas.Controls.Add(Me.ChkOtro)
        Me.GBConfig_Firmas.Controls.Add(Me.ChkRosita)
        Me.GBConfig_Firmas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConfig_Firmas.Location = New System.Drawing.Point(152, 208)
        Me.GBConfig_Firmas.Name = "GBConfig_Firmas"
        Me.GBConfig_Firmas.Size = New System.Drawing.Size(176, 32)
        Me.GBConfig_Firmas.TabIndex = 61
        Me.GBConfig_Firmas.TabStop = False
        '
        'ChkOtro
        '
        Me.ChkOtro.Location = New System.Drawing.Point(104, 12)
        Me.ChkOtro.Name = "ChkOtro"
        Me.ChkOtro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkOtro.Size = New System.Drawing.Size(64, 16)
        Me.ChkOtro.TabIndex = 1
        Me.ChkOtro.Text = "Otro"
        '
        'ChkRosita
        '
        Me.ChkRosita.Location = New System.Drawing.Point(8, 12)
        Me.ChkRosita.Name = "ChkRosita"
        Me.ChkRosita.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkRosita.Size = New System.Drawing.Size(64, 16)
        Me.ChkRosita.TabIndex = 0
        Me.ChkRosita.Text = "Rosita"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(16, 208)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(120, 32)
        Me.Label39.TabIndex = 60
        Me.Label39.Text = "Firma"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(16, 144)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(120, 32)
        Me.Label40.TabIndex = 59
        Me.Label40.Text = "Logo y pie de pagina"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GBConfig_Logo
        '
        Me.GBConfig_Logo.Controls.Add(Me.RdbLogoNo)
        Me.GBConfig_Logo.Controls.Add(Me.RdbLogoSi)
        Me.GBConfig_Logo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConfig_Logo.Location = New System.Drawing.Point(152, 144)
        Me.GBConfig_Logo.Name = "GBConfig_Logo"
        Me.GBConfig_Logo.Size = New System.Drawing.Size(176, 32)
        Me.GBConfig_Logo.TabIndex = 58
        Me.GBConfig_Logo.TabStop = False
        '
        'RdbLogoNo
        '
        Me.RdbLogoNo.Location = New System.Drawing.Point(128, 12)
        Me.RdbLogoNo.Name = "RdbLogoNo"
        Me.RdbLogoNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbLogoNo.Size = New System.Drawing.Size(38, 16)
        Me.RdbLogoNo.TabIndex = 1
        Me.RdbLogoNo.Text = "No"
        '
        'RdbLogoSi
        '
        Me.RdbLogoSi.Location = New System.Drawing.Point(32, 12)
        Me.RdbLogoSi.Name = "RdbLogoSi"
        Me.RdbLogoSi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbLogoSi.Size = New System.Drawing.Size(40, 16)
        Me.RdbLogoSi.TabIndex = 0
        Me.RdbLogoSi.Text = "Si"
        '
        'GBConfig_PosHojas
        '
        Me.GBConfig_PosHojas.Controls.Add(Me.RdbPosHorizontal)
        Me.GBConfig_PosHojas.Controls.Add(Me.RdbPosVertical)
        Me.GBConfig_PosHojas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConfig_PosHojas.Location = New System.Drawing.Point(152, 80)
        Me.GBConfig_PosHojas.Name = "GBConfig_PosHojas"
        Me.GBConfig_PosHojas.Size = New System.Drawing.Size(176, 32)
        Me.GBConfig_PosHojas.TabIndex = 57
        Me.GBConfig_PosHojas.TabStop = False
        '
        'RdbPosHorizontal
        '
        Me.RdbPosHorizontal.Location = New System.Drawing.Point(88, 12)
        Me.RdbPosHorizontal.Name = "RdbPosHorizontal"
        Me.RdbPosHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbPosHorizontal.Size = New System.Drawing.Size(80, 16)
        Me.RdbPosHorizontal.TabIndex = 1
        Me.RdbPosHorizontal.Text = "Horizontal"
        '
        'RdbPosVertical
        '
        Me.RdbPosVertical.Location = New System.Drawing.Point(8, 12)
        Me.RdbPosVertical.Name = "RdbPosVertical"
        Me.RdbPosVertical.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbPosVertical.Size = New System.Drawing.Size(64, 16)
        Me.RdbPosVertical.TabIndex = 23
        Me.RdbPosVertical.Text = "Vertical"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(16, 80)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(120, 32)
        Me.Label41.TabIndex = 56
        Me.Label41.Text = "Posición hojas"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MCCalendario
        '
        Me.MCCalendario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCCalendario.Location = New System.Drawing.Point(280, 424)
        Me.MCCalendario.Name = "MCCalendario"
        Me.MCCalendario.TabIndex = 72
        Me.MCCalendario.Visible = False
        '
        'CmdNombre
        '
        Me.CmdNombre.Location = New System.Drawing.Point(408, 216)
        Me.CmdNombre.Name = "CmdNombre"
        Me.CmdNombre.Size = New System.Drawing.Size(152, 21)
        Me.CmdNombre.TabIndex = 73
        Me.CmdNombre.Visible = False
        '
        'CmdCargo
        '
        Me.CmdCargo.Location = New System.Drawing.Point(408, 243)
        Me.CmdCargo.Name = "CmdCargo"
        Me.CmdCargo.Size = New System.Drawing.Size(152, 21)
        Me.CmdCargo.TabIndex = 74
        Me.CmdCargo.Visible = False
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(352, 216)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(56, 22)
        Me.LblNombre.TabIndex = 75
        Me.LblNombre.Text = "Nombre"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblNombre.Visible = False
        '
        'LblCargo
        '
        Me.LblCargo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargo.Location = New System.Drawing.Point(352, 243)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(56, 22)
        Me.LblCargo.TabIndex = 76
        Me.LblCargo.Text = "Cargo"
        Me.LblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblCargo.Visible = False
        '
        'CmdGraba
        '
        Me.CmdGraba.BackColor = System.Drawing.Color.Transparent
        Me.CmdGraba.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.CmdGraba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGraba.Location = New System.Drawing.Point(352, 616)
        Me.CmdGraba.Name = "CmdGraba"
        Me.CmdGraba.Size = New System.Drawing.Size(80, 24)
        Me.CmdGraba.TabIndex = 77
        Me.CmdGraba.Text = "Grabar"
        Me.CmdGraba.UseVisualStyleBackColor = False
        '
        'CmdSalir
        '
        Me.CmdSalir.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalir.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalir.Location = New System.Drawing.Point(504, 616)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(80, 24)
        Me.CmdSalir.TabIndex = 78
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = False
        '
        'LblTMuestra
        '
        Me.LblTMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTMuestra.Location = New System.Drawing.Point(16, 24)
        Me.LblTMuestra.Name = "LblTMuestra"
        Me.LblTMuestra.Size = New System.Drawing.Size(936, 32)
        Me.LblTMuestra.TabIndex = 79
        Me.LblTMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "F. análisis"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFechaAnalisis
        '
        Me.TxtFechaAnalisis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaAnalisis.Location = New System.Drawing.Point(496, 16)
        Me.TxtFechaAnalisis.Name = "TxtFechaAnalisis"
        Me.TxtFechaAnalisis.Size = New System.Drawing.Size(88, 20)
        Me.TxtFechaAnalisis.TabIndex = 81
        '
        'TxtFechaTermino
        '
        Me.TxtFechaTermino.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaTermino.Location = New System.Drawing.Point(494, 42)
        Me.TxtFechaTermino.Name = "TxtFechaTermino"
        Me.TxtFechaTermino.Size = New System.Drawing.Size(88, 20)
        Me.TxtFechaTermino.TabIndex = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtFechaAnalisis)
        Me.GroupBox1.Controls.Add(Me.TxtFechaTermino)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtFecIng)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.TxtFecInforme)
        Me.GroupBox1.Controls.Add(Me.cmdFecInforme)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 80)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "F.  Informe "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "F. término"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_Resultados_Configuracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(968, 701)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTMuestra)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdGraba)
        Me.Controls.Add(Me.LblCargo)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmdCargo)
        Me.Controls.Add(Me.CmdNombre)
        Me.Controls.Add(Me.MCCalendario)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TxtNumMues)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.GBEstandar)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.GBConfig_Firmas)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.GBConfig_Logo)
        Me.Controls.Add(Me.GBConfig_PosHojas)
        Me.Controls.Add(Me.Label41)
        Me.Name = "Frm_Resultados_Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración Resultados"
        Me.GBEstandar.ResumeLayout(False)
        Me.GBConfig_Firmas.ResumeLayout(False)
        Me.GBConfig_Logo.ResumeLayout(False)
        Me.GBConfig_PosHojas.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub


    Private Sub Frm_Resultados_Configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fila As DataRow
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim FIng As Date = "01-01-1900"

        CmdNombre.Items.Add("")
        For Each fila In Cjto_Resultados1.Tables("FIRMA_NOMBRE").Rows
            CmdNombre.Items.Add(fila("NOMBRE"))
        Next

        CmdCargo.Items.Add("")
        For Each fila In Cjto_Resultados1.Tables("FIRMA_CARGO").Rows
            CmdCargo.Items.Add(fila("CARGO"))
        Next

        Select Case ResultadosMuestrayOrden
            Case 1000
                LblTMuestra.Text = "CONFIGURACION FOLIAR"
            Case 2000
                LblTMuestra.Text = "CONFIGURACION TEJIDOS"
            Case 3000
                LblTMuestra.Text = "CONFIGURACION AGUA"
            Case 3600
                LblTMuestra.Text = "CONFIGURACION COLIFORMES"
            Case 4000
                LblTMuestra.Text = "CONFIGURACION SUELOS FERTILIDAD"
            Case 4500
                LblTMuestra.Text = "CONFIGURACION SUELOS SALIDAD"
            Case 5000
                LblTMuestra.Text = "CONFIGURACION FERTILIZANTE QUIMICO"
            Case 6000
                LblTMuestra.Text = "CONFIGURACION FERTILIZANTE ORGANICO"
            Case 7000
                LblTMuestra.Text = "CONFIGURACION OTROS ANALISIS"
            Case 8000
                LblTMuestra.Text = "CONFIGURACION NEMATODOS"
        End Select
        'If ResultadosMuestrayOrden = 4500 Then ResultadosMuestrayOrden = 4000
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectResultadosConfiguracion")
        End With

        If IsDBNull(ds.Tables(0).Rows(0).Item("POSICION_HOJA")) = False Then
            If ds.Tables(0).Rows(0).Item("POSICION_HOJA") = "V" Then RdbPosVertical.Checked = True Else RdbPosHorizontal.Checked = True
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("LOGO_PIE")) = False Then
            If ds.Tables(0).Rows(0).Item("LOGO_PIE") = "S" Then RdbLogoSi.Checked = True Else RdbLogoNo.Checked = True
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE1")) = False Then
            If Len(ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE1")) > 0 Then ChkRosita.Checked = True
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE2")) = False Then
            If Len(ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE2")) > 0 Then ChkOtro.Checked = True
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("RANGO")) = False Then
            If ds.Tables(0).Rows(0).Item("RANGO") = "1" Then RdbRangoIncluye.Checked = True Else RdbRangoOmite.Checked = True
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_INFORME")) = False Then
            TxtFecInforme.Text = Format(ds.Tables(0).Rows(0).Item("FECHA_INFORME"), "dd-MM-yyyy")
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_INGRESO")) = False Then
            If FIng = Format(ds.Tables(0).Rows(0).Item("FECHA_INGRESO"), "dd-MM-yyyy") Then TxtFecIng.Text = "" Else TxtFecIng.Text = Format(ds.Tables(0).Rows(0).Item("FECHA_INGRESO"), "dd-MM-yyyy")
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_ANALISIS")) = False Then
            If FIng = Format(ds.Tables(0).Rows(0).Item("FECHA_ANALISIS"), "dd-MM-yyyy") Then TxtFechaAnalisis.Text = "" Else TxtFechaAnalisis.Text = Format(ds.Tables(0).Rows(0).Item("FECHA_ANALISIS"), "dd-MM-yyyy")
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_TERMINO")) = False Then
            If FIng = Format(ds.Tables(0).Rows(0).Item("FECHA_TERMINO"), "dd-MM-yyyy") Then TxtFechaTermino.Text = "" Else TxtFechaTermino.Text = Format(ds.Tables(0).Rows(0).Item("FECHA_TERMINO"), "dd-MM-yyyy")
        End If

        If IsDBNull(ds.Tables(0).Rows(0).Item("MUESTRA_PAGINA")) = False Then
            TxtNumMues.Text = ds.Tables(0).Rows(0).Item("MUESTRA_PAGINA")
        End If
    End Sub


    Private Sub ChkOtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOtro.CheckedChanged
        If ChkOtro.Checked = True Then
            LblNombre.Visible = True
            LblCargo.Visible = True
            CmdNombre.Visible = True
            CmdCargo.Visible = True
        End If

        If ChkOtro.Checked = False Then
            LblNombre.Visible = False
            LblCargo.Visible = False
            CmdNombre.Visible = False
            CmdCargo.Visible = False
        End If
    End Sub

    Private Sub CmdGraba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGraba.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim FechaAux As Date
        FechaAux = "01-01-1900"
        FechaAux = Format(FechaAux, "dd-MM-yyyy")
        Dim retorno As Integer
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            If RdbPosHorizontal.Checked = True Then
                .AgregarParametro("@Posicion", "H", SqlDbType.NVarChar)
            Else
                .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            End If
            If RdbLogoSi.Checked = True Then
                .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            Else
                .AgregarParametro("@Logo", "N", SqlDbType.NVarChar)
            End If

            If ChkRosita.Checked = True Then
                .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
                .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            End If
            If ChkOtro.Checked = True Then
                .AgregarParametro("@Nombre2", CmdNombre.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Cargo2", CmdCargo.Text, SqlDbType.NVarChar)
            Else
                .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            End If

            If RdbRangoIncluye.Checked = True Then
                .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            Else
                .AgregarParametro("@Rango", "2", SqlDbType.NVarChar)
            End If

            .AgregarParametro("@Fecha_Informe", TxtFecInforme.Text, SqlDbType.DateTime)

            If TxtFecIng.Text <> "" Then
                .AgregarParametro("@Fecha_Ingreso", TxtFecIng.Text, SqlDbType.DateTime)
            Else
                .AgregarParametro("@Fecha_Ingreso", FechaAux, SqlDbType.DateTime)
            End If

            If TxtFechaAnalisis.Text <> "" Then
                .AgregarParametro("@Fecha_Analisis", TxtFechaAnalisis.Text, SqlDbType.DateTime)
            Else
                .AgregarParametro("@Fecha_Analisis", FechaAux, SqlDbType.DateTime)
            End If

            If TxtFechaTermino.Text <> "" Then
                .AgregarParametro("@Fecha_Termino", TxtFechaTermino.Text, SqlDbType.DateTime)
            Else
                .AgregarParametro("@Fecha_Termino", FechaAux, SqlDbType.DateTime)
            End If

            If TxtNumMues.Text = "" Then TxtNumMues.Text = 0
            .AgregarParametro("@Muestra_Pagina", CInt(TxtNumMues.Text), SqlDbType.Int)
            retorno = .EjecutarEscalar("usp_UpdateResultadosConfiguracion")
        End With
        MsgBox("Grabación de configuración finalizada", MsgBoxStyle.Information)
    End Sub

    Private Sub cmdFecInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFecInforme.Click
        Me.MCCalendario.Visible = True
    End Sub

    Private Sub MCCalendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCCalendario.DateChanged
        Me.TxtFecInforme.Text = Me.MCCalendario.SelectionRange.Start
        Me.MCCalendario.Visible = False
    End Sub

End Class