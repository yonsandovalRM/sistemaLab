Public Class Frm_Pantalla_Revision2
    Inherits System.Windows.Forms.Form
    Private CAMPO1, CAMPO2, CAMPO3, CAMPO4, MATRIZ_UNI(100), Primera_Pasada As String
    Private custDS As DataSet
    Private workTable, workTable1 As DataTable
    Private TS1, TS2, TS3 As New DataGridTableStyle
    Private Cuenta_Elementos, Fila_Seleccion_Grilla, Columna_Seleccion_Grilla, PosicionMatriz(3) As Integer
    Friend WithEvents tx_NlabDesdeG As System.Windows.Forms.TextBox
    Friend WithEvents tx_NlabHastaG As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTGRevision As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pnlImagen As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pBox As System.Windows.Forms.PictureBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents pb4 As System.Windows.Forms.PictureBox
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdImprimir As System.Windows.Forms.Button

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
    Friend WithEvents BTGenera As System.Windows.Forms.Button
    Friend WithEvents TxtNLabH As System.Windows.Forms.TextBox
    Friend WithEvents TxtNLabD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdAtras As System.Windows.Forms.Button
    Friend WithEvents CmdAdelante As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTVerResAnt As System.Windows.Forms.Button
    Friend WithEvents BTAntecedentesMuestras As System.Windows.Forms.Button
    Friend WithEvents CmdGrabar As System.Windows.Forms.Button
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents RDBDuplicacionxAnalizar As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RDBxRevisar As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtNLabDesdeRango As System.Windows.Forms.TextBox
    Friend WithEvents TxtNLabHastaRango As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptaAprobacion As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RDBOtro As System.Windows.Forms.RadioButton
    Friend WithEvents RDBAcepto As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Pantalla_Revision2))
        Me.BTGenera = New System.Windows.Forms.Button
        Me.TxtNLabH = New System.Windows.Forms.TextBox
        Me.TxtNLabD = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlImagen = New System.Windows.Forms.Panel
        Me.pb4 = New System.Windows.Forms.PictureBox
        Me.pb3 = New System.Windows.Forms.PictureBox
        Me.pb2 = New System.Windows.Forms.PictureBox
        Me.pb1 = New System.Windows.Forms.PictureBox
        Me.txtObs = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.pBox = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DTGRevision = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RDBOtro = New System.Windows.Forms.RadioButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.RDBxRevisar = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.RDBDuplicacionxAnalizar = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.RDBAcepto = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CmdImprimir = New System.Windows.Forms.Button
        Me.BTVerResAnt = New System.Windows.Forms.Button
        Me.BTAntecedentesMuestras = New System.Windows.Forms.Button
        Me.CmdGrabar = New System.Windows.Forms.Button
        Me.CmdCancelar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtNLabHastaRango = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CmdAceptaAprobacion = New System.Windows.Forms.Button
        Me.TxtNLabDesdeRango = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmdAdelante = New System.Windows.Forms.Button
        Me.CmdAtras = New System.Windows.Forms.Button
        Me.tx_NlabDesdeG = New System.Windows.Forms.TextBox
        Me.tx_NlabHastaG = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.pnlImagen.SuspendLayout()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGRevision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTGenera
        '
        Me.BTGenera.BackColor = System.Drawing.Color.Transparent
        Me.BTGenera.ForeColor = System.Drawing.Color.Black
        Me.BTGenera.Image = Global.LabSys.My.Resources.Resources.accept
        Me.BTGenera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTGenera.Location = New System.Drawing.Point(271, 7)
        Me.BTGenera.Name = "BTGenera"
        Me.BTGenera.Size = New System.Drawing.Size(71, 24)
        Me.BTGenera.TabIndex = 10
        Me.BTGenera.Text = "Aceptar"
        Me.BTGenera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTGenera.UseVisualStyleBackColor = False
        '
        'TxtNLabH
        '
        Me.TxtNLabH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNLabH.Location = New System.Drawing.Point(209, 8)
        Me.TxtNLabH.Name = "TxtNLabH"
        Me.TxtNLabH.Size = New System.Drawing.Size(56, 20)
        Me.TxtNLabH.TabIndex = 9
        '
        'TxtNLabD
        '
        Me.TxtNLabD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNLabD.Location = New System.Drawing.Point(90, 8)
        Me.TxtNLabD.Name = "TxtNLabD"
        Me.TxtNLabD.Size = New System.Drawing.Size(56, 20)
        Me.TxtNLabD.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(161, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "N° Lab Desde"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlImagen)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.DTGRevision)
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1272, 714)
        Me.Panel1.TabIndex = 11
        '
        'pnlImagen
        '
        Me.pnlImagen.BackColor = System.Drawing.Color.White
        Me.pnlImagen.Controls.Add(Me.pb4)
        Me.pnlImagen.Controls.Add(Me.pb3)
        Me.pnlImagen.Controls.Add(Me.pb2)
        Me.pnlImagen.Controls.Add(Me.pb1)
        Me.pnlImagen.Controls.Add(Me.txtObs)
        Me.pnlImagen.Controls.Add(Me.Button2)
        Me.pnlImagen.Controls.Add(Me.pBox)
        Me.pnlImagen.Location = New System.Drawing.Point(0, 8)
        Me.pnlImagen.Name = "pnlImagen"
        Me.pnlImagen.Size = New System.Drawing.Size(1272, 703)
        Me.pnlImagen.TabIndex = 3
        Me.pnlImagen.Visible = False
        '
        'pb4
        '
        Me.pb4.BackColor = System.Drawing.Color.LightBlue
        Me.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb4.Location = New System.Drawing.Point(122, 528)
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(196, 157)
        Me.pb4.TabIndex = 8
        Me.pb4.TabStop = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.LightBlue
        Me.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb3.Location = New System.Drawing.Point(122, 365)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(196, 157)
        Me.pb3.TabIndex = 7
        Me.pb3.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.LightBlue
        Me.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb2.Location = New System.Drawing.Point(122, 202)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(196, 157)
        Me.pb2.TabIndex = 6
        Me.pb2.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.LightBlue
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(122, 39)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(196, 157)
        Me.pb1.TabIndex = 5
        Me.pb1.TabStop = False
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(324, 665)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(814, 20)
        Me.txtObs.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Image = Global.LabSys.My.Resources.Resources.cancel
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1003, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cerrar Imagen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pBox
        '
        Me.pBox.BackColor = System.Drawing.Color.LightBlue
        Me.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBox.Location = New System.Drawing.Point(324, 39)
        Me.pBox.Name = "pBox"
        Me.pBox.Size = New System.Drawing.Size(814, 620)
        Me.pBox.TabIndex = 2
        Me.pBox.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 340)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(1272, 313)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'DTGRevision
        '
        Me.DTGRevision.BackgroundColor = System.Drawing.Color.White
        Me.DTGRevision.CaptionVisible = False
        Me.DTGRevision.DataMember = ""
        Me.DTGRevision.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGRevision.Location = New System.Drawing.Point(0, 8)
        Me.DTGRevision.Name = "DTGRevision"
        Me.DTGRevision.Size = New System.Drawing.Size(1280, 703)
        Me.DTGRevision.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(738, 749)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 25)
        Me.Label3.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.RDBOtro)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.RDBxRevisar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.RDBDuplicacionxAnalizar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.RDBAcepto)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 791)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 96)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estados del Análisis (en las muestras)"
        '
        'RDBOtro
        '
        Me.RDBOtro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBOtro.ForeColor = System.Drawing.Color.MediumBlue
        Me.RDBOtro.Location = New System.Drawing.Point(366, 32)
        Me.RDBOtro.Name = "RDBOtro"
        Me.RDBOtro.Size = New System.Drawing.Size(16, 16)
        Me.RDBOtro.TabIndex = 45
        Me.RDBOtro.Text = "Revisa Duplicaciones"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Coral
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(208, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 16)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Acepto Otro(prom,mejor,...)"
        '
        'RDBxRevisar
        '
        Me.RDBxRevisar.AllowDrop = True
        Me.RDBxRevisar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBxRevisar.ForeColor = System.Drawing.Color.MediumBlue
        Me.RDBxRevisar.Location = New System.Drawing.Point(134, 34)
        Me.RDBxRevisar.Name = "RDBxRevisar"
        Me.RDBxRevisar.Size = New System.Drawing.Size(16, 16)
        Me.RDBxRevisar.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkViolet
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(54, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "x Rev.Dup."
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(54, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "x Revisar"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = " Ptes."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(54, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "x Analizar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(208, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Acepto Análisis o Duplicado"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label11.Location = New System.Drawing.Point(208, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Nula"
        '
        'RDBDuplicacionxAnalizar
        '
        Me.RDBDuplicacionxAnalizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBDuplicacionxAnalizar.ForeColor = System.Drawing.Color.MediumBlue
        Me.RDBDuplicacionxAnalizar.Location = New System.Drawing.Point(134, 50)
        Me.RDBDuplicacionxAnalizar.Name = "RDBDuplicacionxAnalizar"
        Me.RDBDuplicacionxAnalizar.Size = New System.Drawing.Size(16, 16)
        Me.RDBDuplicacionxAnalizar.TabIndex = 6
        Me.RDBDuplicacionxAnalizar.Text = "Duplicación (DuxA)"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label10.Location = New System.Drawing.Point(176, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "OK"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Magenta
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(54, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "x Duplicar"
        '
        'RDBAcepto
        '
        Me.RDBAcepto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBAcepto.ForeColor = System.Drawing.Color.MediumBlue
        Me.RDBAcepto.Location = New System.Drawing.Point(366, 16)
        Me.RDBAcepto.Name = "RDBAcepto"
        Me.RDBAcepto.Size = New System.Drawing.Size(16, 16)
        Me.RDBAcepto.TabIndex = 41
        Me.RDBAcepto.Text = "Revisa Duplicaciones"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.CmdImprimir)
        Me.GroupBox3.Controls.Add(Me.BTVerResAnt)
        Me.GroupBox3.Controls.Add(Me.BTAntecedentesMuestras)
        Me.GroupBox3.Controls.Add(Me.CmdGrabar)
        Me.GroupBox3.Controls.Add(Me.CmdCancelar)
        Me.GroupBox3.Location = New System.Drawing.Point(926, 791)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 96)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        '
        'CmdImprimir
        '
        Me.CmdImprimir.BackColor = System.Drawing.Color.Transparent
        Me.CmdImprimir.Image = Global.LabSys.My.Resources.Resources.printer
        Me.CmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdImprimir.Location = New System.Drawing.Point(192, 40)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.Size = New System.Drawing.Size(128, 24)
        Me.CmdImprimir.TabIndex = 58
        Me.CmdImprimir.Text = "Imprimir"
        Me.CmdImprimir.UseVisualStyleBackColor = False
        '
        'BTVerResAnt
        '
        Me.BTVerResAnt.BackColor = System.Drawing.Color.Transparent
        Me.BTVerResAnt.Image = Global.LabSys.My.Resources.Resources.report_magnify
        Me.BTVerResAnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTVerResAnt.Location = New System.Drawing.Point(32, 40)
        Me.BTVerResAnt.Name = "BTVerResAnt"
        Me.BTVerResAnt.Size = New System.Drawing.Size(137, 24)
        Me.BTVerResAnt.TabIndex = 57
        Me.BTVerResAnt.Text = "Resultados Anteriores"
        Me.BTVerResAnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTVerResAnt.UseVisualStyleBackColor = False
        Me.BTVerResAnt.Visible = False
        '
        'BTAntecedentesMuestras
        '
        Me.BTAntecedentesMuestras.BackColor = System.Drawing.Color.Transparent
        Me.BTAntecedentesMuestras.Image = Global.LabSys.My.Resources.Resources.application_form_edit
        Me.BTAntecedentesMuestras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTAntecedentesMuestras.Location = New System.Drawing.Point(32, 12)
        Me.BTAntecedentesMuestras.Name = "BTAntecedentesMuestras"
        Me.BTAntecedentesMuestras.Size = New System.Drawing.Size(137, 24)
        Me.BTAntecedentesMuestras.TabIndex = 54
        Me.BTAntecedentesMuestras.Text = "Consulta/Modifica  OT"
        Me.BTAntecedentesMuestras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTAntecedentesMuestras.UseVisualStyleBackColor = False
        '
        'CmdGrabar
        '
        Me.CmdGrabar.BackColor = System.Drawing.Color.Transparent
        Me.CmdGrabar.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.CmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGrabar.Location = New System.Drawing.Point(192, 10)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.Size = New System.Drawing.Size(128, 24)
        Me.CmdGrabar.TabIndex = 55
        Me.CmdGrabar.Text = "Grabar"
        Me.CmdGrabar.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.Transparent
        Me.CmdCancelar.Image = Global.LabSys.My.Resources.Resources.cross
        Me.CmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdCancelar.Location = New System.Drawing.Point(118, 67)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(128, 24)
        Me.CmdCancelar.TabIndex = 56
        Me.CmdCancelar.Text = "Cerrar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.TxtNLabHastaRango)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.CmdAceptaAprobacion)
        Me.GroupBox2.Controls.Add(Me.TxtNLabDesdeRango)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(662, 791)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 96)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acepta Muestras"
        '
        'TxtNLabHastaRango
        '
        Me.TxtNLabHastaRango.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNLabHastaRango.Location = New System.Drawing.Point(200, 24)
        Me.TxtNLabHastaRango.Name = "TxtNLabHastaRango"
        Me.TxtNLabHastaRango.Size = New System.Drawing.Size(56, 20)
        Me.TxtNLabHastaRango.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(160, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 16)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Hasta"
        '
        'CmdAceptaAprobacion
        '
        Me.CmdAceptaAprobacion.BackColor = System.Drawing.Color.Transparent
        Me.CmdAceptaAprobacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAceptaAprobacion.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdAceptaAprobacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAceptaAprobacion.Location = New System.Drawing.Point(104, 56)
        Me.CmdAceptaAprobacion.Name = "CmdAceptaAprobacion"
        Me.CmdAceptaAprobacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptaAprobacion.Size = New System.Drawing.Size(72, 24)
        Me.CmdAceptaAprobacion.TabIndex = 57
        Me.CmdAceptaAprobacion.Text = "Aceptar"
        Me.CmdAceptaAprobacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAceptaAprobacion.UseVisualStyleBackColor = False
        '
        'TxtNLabDesdeRango
        '
        Me.TxtNLabDesdeRango.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNLabDesdeRango.Location = New System.Drawing.Point(96, 24)
        Me.TxtNLabDesdeRango.Name = "TxtNLabDesdeRango"
        Me.TxtNLabDesdeRango.Size = New System.Drawing.Size(56, 20)
        Me.TxtNLabDesdeRango.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nº Lab. Desde"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(390, 791)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(272, 96)
        Me.GroupBox4.TabIndex = 58
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Significado Columna"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(208, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "R  :  ""x"" análisis Revisado y Aceptado"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(200, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "D  :  ""x"" análisis por Duplicar"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(200, 16)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "+   : ""x"" OT contiene + análisis"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "O  : ""x"" Indica OT tiene observaciones"
        '
        'CmdAdelante
        '
        Me.CmdAdelante.BackColor = System.Drawing.Color.Transparent
        Me.CmdAdelante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdelante.Image = Global.LabSys.My.Resources.Resources.arrow_right
        Me.CmdAdelante.Location = New System.Drawing.Point(1200, 749)
        Me.CmdAdelante.Name = "CmdAdelante"
        Me.CmdAdelante.Size = New System.Drawing.Size(72, 25)
        Me.CmdAdelante.TabIndex = 13
        Me.CmdAdelante.TabStop = False
        Me.CmdAdelante.UseVisualStyleBackColor = False
        '
        'CmdAtras
        '
        Me.CmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.CmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAtras.Image = Global.LabSys.My.Resources.Resources.arrow_left
        Me.CmdAtras.Location = New System.Drawing.Point(666, 749)
        Me.CmdAtras.Name = "CmdAtras"
        Me.CmdAtras.Size = New System.Drawing.Size(72, 25)
        Me.CmdAtras.TabIndex = 12
        Me.CmdAtras.UseVisualStyleBackColor = False
        '
        'tx_NlabDesdeG
        '
        Me.tx_NlabDesdeG.Location = New System.Drawing.Point(995, 7)
        Me.tx_NlabDesdeG.Name = "tx_NlabDesdeG"
        Me.tx_NlabDesdeG.Size = New System.Drawing.Size(58, 20)
        Me.tx_NlabDesdeG.TabIndex = 59
        Me.tx_NlabDesdeG.Visible = False
        '
        'tx_NlabHastaG
        '
        Me.tx_NlabHastaG.Location = New System.Drawing.Point(1059, 7)
        Me.tx_NlabHastaG.Name = "tx_NlabHastaG"
        Me.tx_NlabHastaG.Size = New System.Drawing.Size(58, 20)
        Me.tx_NlabHastaG.TabIndex = 60
        Me.tx_NlabHastaG.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.arrow_refresh_small
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1123, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Autogenerar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Frm_Pantalla_Revision2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1276, 986)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tx_NlabHastaG)
        Me.Controls.Add(Me.tx_NlabDesdeG)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdAdelante)
        Me.Controls.Add(Me.CmdAtras)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTGenera)
        Me.Controls.Add(Me.TxtNLabH)
        Me.Controls.Add(Me.TxtNLabD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Pantalla_Revision2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Revisión"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnlImagen.ResumeLayout(False)
        Me.pnlImagen.PerformLayout()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGRevision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Crear_Tabla_Revision()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet

        Dim query, Union As String
        Dim Fila_Seleccion As DataRow
        custDS = New DataSet
        workTable = custDS.Tables.Add("TABLA_REVISION")
        'CREA TABLA_ELE ***************************************************************
        workTable.Columns.Add("OT_NUMERO", Type.GetType("System.String"))
        workTable.Columns.Add("MAS_ELEMENTOS", Type.GetType("System.String"))
        'workTable.Columns.Add("URGENCIA", Type.GetType("System.String"))
        workTable.Columns.Add("PRO_PRODUCTOR", Type.GetType("System.String"))
        workTable.Columns.Add("PREDIO", Type.GetType("System.String"))
        workTable.Columns.Add("REMITE", Type.GetType("System.String"))
        workTable.Columns.Add("LOCALIDAD", Type.GetType("System.String"))
        workTable.Columns.Add("CAMPO1", Type.GetType("System.String"))
        workTable.Columns.Add("CAMPO2", Type.GetType("System.String"))
        workTable.Columns.Add("CAMPO3", Type.GetType("System.String"))
        workTable.Columns.Add("CAMPO4", Type.GetType("System.String"))
        workTable.Columns.Add("IDENTIFICACION", Type.GetType("System.String"))
        workTable.Columns.Add("OT_NLAB", Type.GetType("System.Int32"))
        workTable.Columns.Add("MAS_OBSERVACIONES", Type.GetType("System.String"))
        workTable.Columns.Add("MARCA_DUPLICACION", Type.GetType("System.String"))
        workTable.Columns.Add("MARCA_REVISION", Type.GetType("System.String"))

        With SP
            .Inicializar()
            .AgregarParametro("@NLabDesde", CInt(TxtNLabD.Text), SqlDbType.Int)
            .AgregarParametro("@NLabHasta", CInt(TxtNLabH.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectRevisionElementos")
        End With

        For Each Fila_Seleccion In ds.Tables(0).Rows
            If Fila_Seleccion.Item(0) = "WTexBou+AreGyF" Or Fila_Seleccion.Item(0) = "WTexBouyouco" Then
                Cuenta_Elementos = Cuenta_Elementos + 1
                Union = "Arc"
                workTable.Columns.Add(Union, Type.GetType("System.Double"))
                MATRIZ_ELEMENTOS(Cuenta_Elementos) = "Arc"
                MATRIZ_ELEMENTOS_DESPLIEGUE(Cuenta_Elementos) = "Arc"
                MATRIZ_UNI(Cuenta_Elementos) = ""
            End If
            Cuenta_Elementos = Cuenta_Elementos + 1
            Union = Fila_Seleccion.Item(0)
            workTable.Columns.Add(Union, Type.GetType("System.Double"))
            MATRIZ_ELEMENTOS(Cuenta_Elementos) = Fila_Seleccion.Item(0)
            MATRIZ_ELEMENTOS_DESPLIEGUE(Cuenta_Elementos) = Fila_Seleccion.Item(1)
            MATRIZ_UNI(Cuenta_Elementos) = Fila_Seleccion.Item(3)
        Next

        Dim workCol As DataColumn = workTable.Columns.Add("FILA", Type.GetType("System.Int32"))
        workCol.AllowDBNull = False
        workCol.Unique = True

    End Sub
    Private Sub Crear_grillaNueva()
        'Definimos que fuente usar
        ' DataGridView1.Font = _
        'New Drawing.Font("Verdana", 7.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        With Me.DataGridView1

            .Columns.Add("OT_NUMERO", "N°" & vbCrLf & "OT")
            .Columns("OT_NUMERO").Width = 50
            .Columns("OT_NUMERO").DataPropertyName = "OT_NUMERO"

            .Columns.Add("MAS_ELEMENTOS", "+")
            .Columns("MAS_ELEMENTOS").Width = 20
            .Columns("MAS_ELEMENTOS").DataPropertyName = "MAS_ELEMENTOS"

            .Columns.Add("PRO_PRODUCTOR", "Productor")
            .Columns("PRO_PRODUCTOR").Width = 70
            .Columns("PRO_PRODUCTOR").DataPropertyName = "PRO_PRODUCTOR"

            .Columns.Add("PREDIO", "Predio")
            .Columns("PREDIO").Width = 70
            .Columns("PREDIO").DataPropertyName = "PREDIO"

            .Columns.Add("REMITE", "Remite")
            .Columns("REMITE").Width = 40
            .Columns("REMITE").DataPropertyName = "REMITE"

            .Columns.Add("LOCALIDAD", "Localidad")
            .Columns("LOCALIDAD").Width = 40
            .Columns("LOCALIDAD").DataPropertyName = "LOCALIDAD"

        End With


        Select Case CodMuestraRev
            Case 1000
                With Me.DataGridView1

                    .Columns.Add("CAMPO1", "Especie")
                    .Columns("CAMPO1").DataPropertyName = "CAMPO1"
                    .Columns("CAMPO1").Width = 50


                    .Columns.Add("CAMPO2", "Variedad")
                    .Columns("CAMPO2").DataPropertyName = "CAMPO2"
                    .Columns("CAMPO2").Width = 50


                    .Columns.Add("CAMPO3", "Tej")
                    .Columns("CAMPO3").DataPropertyName = "CAMPO3"
                    .Columns("CAMPO3").Width = 25


                    .Columns.Add("CAMPO4", "Ed")
                    .Columns("CAMPO4").DataPropertyName = "CAMPO4"
                    .Columns("CAMPO4").Width = 25

                End With
            Case 2000
                With Me.DataGridView1

                    .Columns.Add("CAMPO1", "Especie")
                    .Columns("CAMPO1").DataPropertyName = "CAMPO1"
                    .Columns("CAMPO1").Width = 50


                    .Columns.Add("CAMPO2", "Variedad")
                    .Columns("CAMPO2").DataPropertyName = "CAMPO2"
                    .Columns("CAMPO2").Width = 50


                    .Columns.Add("CAMPO3", "Tej")
                    .Columns("CAMPO3").DataPropertyName = "CAMPO3"
                    .Columns("CAMPO3").Width = 25


                    .Columns.Add("CAMPO4", "Ed")
                    .Columns("CAMPO4").DataPropertyName = "CAMPO4"
                    .Columns("CAMPO4").Width = 25

                End With
            Case 3000
                With Me.DataGridView1

                    .Columns.Add("CAMPO1", "Origen")
                    .Columns("CAMPO1").Width = 50
                    .Columns("CAMPO1").DataPropertyName = "CAMPO1"

                    .Columns.Add("CAMPO2", "Preserv.")
                    .Columns("CAMPO2").Width = 50

                    .Columns.Add("CAMPO3", "Hora")
                    .Columns("CAMPO3").Width = 50

                    .Columns.Add("CAMPO4", "Ing.")
                    .Columns("CAMPO4").Width = 50
                End With
            Case 4000
                With Me.DataGridView1
                    .Columns.Add("CAMPO1", "Cult.Ant.")
                    .Columns("CAMPO1").Width = 65
                    .Columns("CAMPO1").DataPropertyName = "CAMPO1"

                    .Columns.Add("CAMPO2", "Cult.Pro.")
                    .Columns("CAMPO2").Width = 65

                    .Columns.Add("CAMPO3", "Text")
                    .Columns("CAMPO3").Width = 25

                    .Columns.Add("CAMPO4", "Prof")
                    .Columns("CAMPO4").Width = 25
                End With
            Case 5000
                With Me.DataGridView1
                    .Columns.Add("CAMPO1", "Cult.Ant.")
                    .Columns("CAMPO1").Width = 65
                    .Columns("CAMPO1").DataPropertyName = "CAMPO1"

                    .Columns.Add("CAMPO2", "Cult.Pro.")
                    .Columns("CAMPO2").Width = 65

                    .Columns.Add("CAMPO3", "Text")
                    .Columns("CAMPO3").Width = 25

                    .Columns.Add("CAMPO4", "Prof")
                    .Columns("CAMPO4").Width = 25
                End With

            Case 6000
                With Me.DataGridView1
                    .Columns.Add("CAMPO1", "Tipo Fertilizante")
                    .Columns("CAMPO1").Width = 100
                    .Columns("CAMPO1").DataPropertyName = "CAMPO1"

                    .Columns.Add("CAMPO2", " ")
                    .Columns("CAMPO2").Width = 15

                    .Columns.Add("CAMPO3", " ")
                    .Columns("CAMPO3").Width = 15

                    .Columns.Add("CAMPO4", " ")
                    .Columns("CAMPO4").Width = 15
                End With

            Case Else

        End Select



        '3 parte grilla
        With Me.DataGridView1
            .Columns.Add("IDENTIFICACION", "Identificacion")
            .Columns("IDENTIFICACION").Width = 113
            .Columns("IDENTIFICACION").DataPropertyName = "IDENTIFICACION"

            .Columns.Add("OT_NLAB", "N° Lab.")
            .Columns("OT_NLAB").Width = 50
            .Columns("OT_NLAB").DataPropertyName = "OT_NLAB"

            .Columns.Add("MAS_OBSERVACIONES", "O")
            .Columns("MAS_OBSERVACIONES").Width = 20
            .Columns("MAS_OBSERVACIONES").DataPropertyName = "MAS_OBSERVACIONES"

            .Columns.Add("MARCA_DUPLICACION", "D")
            .Columns("MARCA_DUPLICACION").Width = 20
            .Columns("MARCA_DUPLICACION").DataPropertyName = "MARCA_DUPLICACION"

            .Columns.Add("MARCA_REVISION", "R")
            .Columns("MARCA_REVISION").Width = 20
            .Columns("MARCA_REVISION").DataPropertyName = "MARCA_REVISION"
        End With

        '4 PArte Grilla
        Dim hh, PosicionPintar As Integer
        For hh = Contador_De_Posicion To Cuenta_Elementos
            If MATRIZ_ELEMENTOS(hh) = "CE" Then PosicionMatriz(1) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "CIC_cmol" Then PosicionMatriz(1) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "CEe_sal" Then PosicionMatriz(1) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "Suma_Cat" Then PosicionMatriz(2) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "Suma_Ani" Then PosicionMatriz(3) = hh + 14
            Me.DataGridView1.Columns.Add(MATRIZ_ELEMENTOS(hh), MATRIZ_ELEMENTOS_DESPLIEGUE(hh) & vbCrLf & MATRIZ_UNI(hh))
            Me.DataGridView1.Columns(MATRIZ_ELEMENTOS(hh)).Width = 40
            DataGridView1.Columns(MATRIZ_ELEMENTOS(hh)).DataPropertyName = MATRIZ_ELEMENTOS(hh)
        Next
        Me.DataGridView1.Columns.Add("FILA", "FILA")
        Me.DataGridView1.Columns("FILA").Width = 3
        DataGridView1.Columns("FILA").DataPropertyName = "FILA"


    End Sub
    Private Sub Crear_Grilla_Revision()

        Try
            DTGRevision.TableStyles.Remove(DTGRevision.TableStyles(0))
        Catch ex As Exception
        End Try

        Dim hh, PosicionPintar As Integer
        Dim f As New System.Drawing.Font("Verdana", 7.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        DTGRevision.HeaderFont = f

        TS3 = New DataGridTableStyle
        TS3.MappingName = "TABLA_REVISION"
        '
        Dim elemento1 As New DataGridTextBoxColumn
        elemento1.MappingName = "OT_NUMERO"
        elemento1.HeaderText = "N°" & vbCrLf & "OT"
        elemento1.NullText = ""
        elemento1.Width = 50
        TS3.GridColumnStyles.Add(elemento1)

        Dim elemento3 As New DataGridTextBoxColumn
        elemento3.MappingName = "MAS_ELEMENTOS"
        elemento3.HeaderText = "+"
        elemento3.NullText = ""
        elemento3.Width = 13
        TS3.GridColumnStyles.Add(elemento3)

        'Dim elemento4 As New DataGridTextBoxColumn
        'elemento4.MappingName = "URGENCIA"
        'elemento4.HeaderText = "!"
        'elemento4.NullText = ""
        'elemento4.Width = 13
        'TS3.GridColumnStyles.Add(elemento4)

        Dim elemento5 As New DataGridTextBoxColumn
        elemento5.MappingName = "PRO_PRODUCTOR"
        elemento5.HeaderText = "Productor"
        elemento5.NullText = ""
        elemento5.Width = 70
        TS3.GridColumnStyles.Add(elemento5)

        Dim elemento6 As New DataGridTextBoxColumn
        elemento6.MappingName = "PREDIO"
        elemento6.HeaderText = "Predio"
        elemento6.NullText = ""
        elemento6.Width = 70
        TS3.GridColumnStyles.Add(elemento6)

        Dim elemento7 As New DataGridTextBoxColumn
        elemento7.MappingName = "REMITE"
        elemento7.HeaderText = "Remite"
        elemento7.NullText = ""
        elemento7.Width = 40
        TS3.GridColumnStyles.Add(elemento7)

        Dim elemento8 As New DataGridTextBoxColumn
        elemento8.MappingName = "LOCALIDAD"
        elemento8.HeaderText = "Localidad"
        elemento8.NullText = ""
        elemento8.Width = 40
        TS3.GridColumnStyles.Add(elemento8)

        If CodMuestraRev = 1000 Or CodMuestraRev = 2000 Then Call Columnas_Foliar_Tejidos(TS3)
        If CodMuestraRev = 3000 Then Call Columnas_Agua(TS3)
        If CodMuestraRev = 4000 Or CodMuestraRev = 4500 Then Call Columnas_Suelo(TS3)
        If CodMuestraRev = 5000 Then Call Columnas_FertOrg(TS3)
        If CodMuestraRev = 6000 Then Call Columnas_FertQui(TS3)

        Dim elemento14 As New DataGridTextBoxColumn
        elemento14.MappingName = "IDENTIFICACION"
        elemento14.HeaderText = "Identificación"
        elemento14.NullText = ""
        elemento14.Width = 113
        TS3.GridColumnStyles.Add(elemento14)

        Dim elemento15 As New DataGridTextBoxColumn
        elemento15.MappingName = "OT_NLAB"
        elemento15.HeaderText = "N° Lab."
        elemento15.NullText = ""
        elemento15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        elemento15.Width = 50
        TS3.GridColumnStyles.Add(elemento15)

        Dim elemento2 As New DataGridTextBoxColumn
        elemento2.MappingName = "MAS_OBSERVACIONES"
        elemento2.HeaderText = "O"
        elemento2.NullText = ""
        elemento2.Width = 13
        TS3.GridColumnStyles.Add(elemento2)

        Dim elemento16 As New DataGridTextBoxColumn
        elemento16.MappingName = "MARCA_DUPLICACION"
        elemento16.HeaderText = "D"
        elemento16.NullText = ""
        elemento16.Width = 13
        TS3.GridColumnStyles.Add(elemento16)

        Dim elemento17 As New DataGridTextBoxColumn
        elemento17.MappingName = "MARCA_REVISION"
        elemento17.HeaderText = "R"
        elemento17.NullText = ""
        elemento17.Width = 13
        TS3.GridColumnStyles.Add(elemento17)
        For hh = Contador_De_Posicion To Cuenta_Elementos
            If MATRIZ_ELEMENTOS(hh) = "CE" Then PosicionMatriz(1) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "CIC_cmol" Then PosicionMatriz(1) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "CEe_sal" Then PosicionMatriz(1) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "Suma_Cat" Then PosicionMatriz(2) = hh + 14
            If MATRIZ_ELEMENTOS(hh) = "Suma_Ani" Then PosicionMatriz(3) = hh + 14
            Dim elemento18 As New DataGridTextBoxColumn
            elemento18.MappingName = MATRIZ_ELEMENTOS(hh)
            elemento18.HeaderText = MATRIZ_ELEMENTOS_DESPLIEGUE(hh) & vbCrLf & MATRIZ_UNI(hh)
            elemento18.Width = 40
            elemento18.NullText = ""
            elemento18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
            TS3.GridColumnStyles.Add(elemento18)
        Next

        Dim elemento19 As New DataGridTextBoxColumn
        elemento19.MappingName = "FILA"
        elemento19.HeaderText = "FILA"
        elemento19.Width = 3
        TS3.GridColumnStyles.Add(elemento19)
        DTGRevision.TableStyles.Add(TS3)

    End Sub

    Private Sub Columnas_Foliar_Tejidos(ByRef TS As DataGridTableStyle)
        Dim elemento9 As New DataGridTextBoxColumn
        elemento9.MappingName = "CAMPO1"
        elemento9.HeaderText = "Especie"
        elemento9.NullText = ""
        elemento9.Width = 50
        TS.GridColumnStyles.Add(elemento9)

        Dim elemento10 As New DataGridTextBoxColumn
        elemento10.MappingName = "CAMPO2"
        elemento10.HeaderText = "Variedad"
        elemento10.NullText = ""
        elemento10.Width = 50
        TS.GridColumnStyles.Add(elemento10)


        Dim elemento11 As New DataGridTextBoxColumn
        elemento11.MappingName = "CAMPO3"
        elemento11.HeaderText = "Tej"
        elemento11.NullText = ""
        elemento11.Width = 25
        TS.GridColumnStyles.Add(elemento11)

        Dim elemento12 As New DataGridTextBoxColumn
        elemento12.MappingName = "CAMPO4"
        elemento12.HeaderText = "Ed"
        elemento12.NullText = ""
        elemento12.Width = 25
        elemento12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        TS.GridColumnStyles.Add(elemento12)
    End Sub

    Private Sub Columnas_Agua(ByRef TS As DataGridTableStyle)
        Dim elemento9 As New DataGridTextBoxColumn
        elemento9.MappingName = "CAMPO1"
        elemento9.HeaderText = "Origen"
        elemento9.NullText = ""
        elemento9.Width = 50
        TS.GridColumnStyles.Add(elemento9)


        Dim elemento10 As New DataGridTextBoxColumn
        elemento10.MappingName = "CAMPO2"
        elemento10.HeaderText = "Preserv."
        elemento10.NullText = ""
        elemento10.Width = 50
        TS.GridColumnStyles.Add(elemento10)


        Dim elemento11 As New DataGridTextBoxColumn
        elemento11.MappingName = "CAMPO3"
        elemento11.HeaderText = "Hora"
        elemento11.NullText = ""
        elemento11.Width = 50
        elemento11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        TS.GridColumnStyles.Add(elemento11)

        Dim elemento12 As New DataGridTextBoxColumn
        elemento12.MappingName = "CAMPO4"
        elemento12.HeaderText = "Ing."
        elemento12.NullText = ""
        elemento12.Width = 50
        elemento12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        TS.GridColumnStyles.Add(elemento12)

    End Sub

    Private Sub Columnas_Suelo(ByRef TS As DataGridTableStyle)
        Dim elemento9 As New DataGridTextBoxColumn
        elemento9.MappingName = "CAMPO1"
        elemento9.HeaderText = "Cult.Ant."
        elemento9.NullText = ""
        elemento9.Width = 65
        TS.GridColumnStyles.Add(elemento9)

        Dim elemento10 As New DataGridTextBoxColumn
        elemento10.MappingName = "CAMPO2"
        elemento10.HeaderText = "Cult.Pro."
        elemento10.NullText = ""
        elemento10.Width = 65
        TS.GridColumnStyles.Add(elemento10)

        Dim elemento11 As New DataGridTextBoxColumn
        elemento11.MappingName = "CAMPO3"
        elemento11.HeaderText = "Text"
        elemento11.NullText = ""
        elemento11.Width = 25
        TS.GridColumnStyles.Add(elemento11)

        Dim elemento12 As New DataGridTextBoxColumn
        elemento12.MappingName = "CAMPO4"
        elemento12.HeaderText = "Prof"
        elemento12.NullText = ""
        elemento12.Width = 25
        TS.GridColumnStyles.Add(elemento12)

    End Sub
    Private Sub Columnas_FertOrg(ByRef TS As DataGridTableStyle)
        Dim elemento9 As New DataGridTextBoxColumn
        elemento9.MappingName = "CAMPO1"
        elemento9.HeaderText = "Tipo Fertilizante"
        elemento9.NullText = ""
        elemento9.Width = 100
        TS.GridColumnStyles.Add(elemento9)

        Dim elemento10 As New DataGridTextBoxColumn
        elemento10.MappingName = "CAMPO2"
        elemento10.HeaderText = " "
        elemento10.NullText = ""
        elemento10.Width = 10
        TS.GridColumnStyles.Add(elemento10)

        Dim elemento11 As New DataGridTextBoxColumn
        elemento11.MappingName = "CAMPO3"
        elemento11.HeaderText = " "
        elemento11.NullText = ""
        elemento11.Width = 10
        TS.GridColumnStyles.Add(elemento11)

        Dim elemento12 As New DataGridTextBoxColumn
        elemento12.MappingName = "CAMPO4"
        elemento12.HeaderText = " "
        elemento12.NullText = ""
        elemento12.Width = 10
        TS.GridColumnStyles.Add(elemento12)

    End Sub
    Private Sub Columnas_FertQui(ByRef TS As DataGridTableStyle)
        Dim elemento9 As New DataGridTextBoxColumn
        elemento9.MappingName = "CAMPO1"
        elemento9.HeaderText = "Tipo Fertilizante"
        elemento9.NullText = ""
        elemento9.Width = 100
        TS.GridColumnStyles.Add(elemento9)

        Dim elemento10 As New DataGridTextBoxColumn
        elemento10.MappingName = "CAMPO2"
        elemento10.HeaderText = " "
        elemento10.NullText = ""
        elemento10.Width = 10
        TS.GridColumnStyles.Add(elemento10)

        Dim elemento11 As New DataGridTextBoxColumn
        elemento11.MappingName = "CAMPO3"
        elemento11.HeaderText = " "
        elemento11.NullText = ""
        elemento11.Width = 10
        TS.GridColumnStyles.Add(elemento11)

        Dim elemento12 As New DataGridTextBoxColumn
        elemento12.MappingName = "CAMPO4"
        elemento12.HeaderText = " "
        elemento12.NullText = ""
        elemento12.Width = 10
        TS.GridColumnStyles.Add(elemento12)

    End Sub


    Private Sub BTGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTGenera.Click
        Dim sMsg2 As String
        Dim Alto_Grillas, Ancho_Ele As Integer
        Dim frmEsp As New Frm_Espere
        Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Clear()
        Cjto_Tablas1.Tables("CICLO_NLAB1").Clear()
        DTGRevision.TableStyles.Clear()
        Me.DataGridView1.Columns.Clear()
        TS1.GridColumnStyles.Clear()
        TS2.GridColumnStyles.Clear()
        Cuenta_Elementos = 0
        ReDim MATRIZ_ELEMENTOS(100)
        ReDim MATRIZ_ELEMENTOS_DESPLIEGUE(100)
        ReDim MATRIZ_NLAB(1000)
        ReDim MATRIZ_OT(1000)
        ReDim MATRIZ_DUPLICADOS(1000)
        ReDim MATRIZ_NUMERODIGITACION(1000)

        'sMsg2 = "Rescatando Elementos segun rango Nº Laboratorios"
        'frmEsp.lblMsg2.Text = sMsg2
        'frmEsp.Show()
        'frmEsp.Refresh()

        Call Crear_Tabla_Revision()
        'Call Crear_grillaNueva()
        Call Crear_Grilla_Revision()
        Call Tabla_Grilla()

        AddCellFormattingColumnStyles(Me.DTGRevision, New FormatCellEventHandler(AddressOf FormatGridCells))
        'Formato_dato_Cabezera(Me.DTGRevision, New FormatCellEventHandler(AddressOf FormatGridCells))
        Call Llena_datos()
        'frmEsp.Close()
        TxtNLabDesdeRango.Focus()
    End Sub
    'Private Sub pintagrilla()
    '    Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
    '    Dim ds As DataSet = New DataSet

    '    With SP
    '        .Inicializar()
    '        .AgregarParametro("@NLabDesde", CInt(TxtNLabD.Text), SqlDbType.Int)
    '        .AgregarParametro("@NLabHasta", CInt(TxtNLabH.Text), SqlDbType.Int)
    '        .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
    '        ds = .EjecutarQuery("usp_SelectRevisionElementos")
    '    End With

    '    Select Case Me.DataGridView1.Columns(e.ColumnIndex).Name
    '        Case "Prioridad"
    '            If e.Value = "1" Then
    '                e.CellStyle.BackColor = Color.Red
    '            Else
    '            End If
    '    End Select
    'End Sub

    Private Sub Tabla_Grilla()
        DTGRevision.DataSource = custDS.Tables("TABLA_REVISION")
        'Me.DataGridView1.DataSource = custDS.Tables("TABLA_REVISION")
    End Sub

    Private Sub TxtNLabD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNLabD.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNLabH.Text = Me.TxtNLabD.Text
            tx_NlabDesdeG.Text = Me.TxtNLabD.Text
            TxtNLabH.Focus()
        End If
    End Sub

    Private Sub TxtNLabH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNLabH.KeyPress
        If e.KeyChar = Chr(13) Then
            tx_NlabHastaG.Text = Me.TxtNLabH.Text
            BTGenera.Focus()
        End If
    End Sub

    Private Sub AddCellFormattingColumnStyles(ByVal grid As DataGrid, ByVal handler As FormatCellEventHandler)
        Dim Colum As Integer
        Dim ts As DataGridTableStyle
        Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        Dim mydv As DataView = CType(mycm.List, DataView)
        ts = New DataGridTableStyle
        Dim dt As DataTable
        Dim row As DataRow
        Dim S As String
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j, fil As Integer
        j = 0
        fil = 0
        Dim numRows As Integer = grid.BindingContext(grid.DataSource, grid.DataMember).Count
        Try
            Do While (j < (dt.Columns.Count - Contador_De_Posicion) + 1)
                fil = fil + 1
                Dim cs As Fila_Normal_Revision
                cs = New Fila_Normal_Revision(j)
                cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs.grid = grid
                AddHandler cs.SetCellFormat, handler
                If j = dt.Columns.Count - Contador_De_Posicion Then
                    ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
                ElseIf j >= 15 Then
                    Dim cs2 As New Color_Revision(grid.TableStyles(0).GridColumnStyles(j).MappingName, j)
                    cs2.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                    cs2.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                    cs2.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                    cs2.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                    cs2.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                    cs2.grid = grid
                    AddHandler cs2.SetCellFormat, handler
                    ts.GridColumnStyles.Add(cs2)
                Else
                    ts.GridColumnStyles.Add(cs)
                End If
                j = (j + 1)
            Loop

        Catch ex As Exception

        End Try
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub


    Private Sub Formato_dato_Cabezera(ByVal grid As DataGrid, ByVal handler As FormatCellEventHandler)
        Dim ts As DataGridTableStyle
        Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        Dim mydv As DataView = CType(mycm.List, DataView)
        ts = New DataGridTableStyle
        Dim dt As DataTable
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j As Integer
        j = 0
        Do While (j < dt.Columns.Count - 1)
            Dim cs2 As New Fila_DatoEncabezado(grid.TableStyles(0).GridColumnStyles(j).MappingName, j)
            cs2.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
            cs2.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
            cs2.Width = grid.TableStyles(0).GridColumnStyles(j).Width
            cs2.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
            cs2.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
            cs2.grid = grid
            AddHandler cs2.SetCellFormat, handler
            ts.GridColumnStyles.Add(cs2)
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub

    Private Sub FormatGridCells(ByVal sender As Object, ByVal e As DataGridFormatCellEventArgs, ByVal grid As DataGrid)
        Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        Dim mydv As DataView = CType(mycm.List, DataView)
        Dim row As DataRow
        Dim j As Integer
        j = 0
        If (e.Column = PosicionMatriz(1) Or e.Column = PosicionMatriz(2) Or e.Column = PosicionMatriz(3)) And e.Column <> 0 Then
            e.BackBrush = Brushes.Orange
            'e.TextFont = New Font(e.TextFont.Name, 7, FontStyle.Bold)
        End If
    End Sub

    Private Sub Frm_Pantalla_Revision2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim retNumLab As Integer
        Contador_De_Posicion = 1
        Contador_Dup = 0
        AuxSD_Dup = "N"
        CAMPO1 = ""
        CAMPO2 = ""
        CAMPO3 = ""
        CAMPO4 = ""

        With SP
            .Inicializar()
            .EjecutarQuery("usp_DeleteModificaRevision")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
            retNumLab = .EjecutarEscalar("usp_SelectRevisionPrimerNLab")
            TxtNLabD.Text = retNumLab
        End With

        'por mientras se digita
        'If retNumLab < 179424 And CodMuestraRev = 1000 Then TxtNLabD.Text = 179424
        'If retNumLab < 109637 And CodMuestraRev = 4000 Then TxtNLabD.Text = 109637
        'If retNumLab < 109637 And CodMuestraRev = 4500 Then TxtNLabD.Text = 109637
        'If retNumLab < 8514 And CodMuestraRev = 2000 Then TxtNLabD.Text = 8514
        'If retNumLab < 10001 And CodMuestraRev = 5000 Then TxtNLabD.Text = 10001
        'If retNumLab < 15885 And CodMuestraRev = 3000 Then TxtNLabD.Text = 15885
        'If retNumLab < 17124 And CodMuestraRev = 6000 Then TxtNLabD.Text = 17124

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
            retNumLab = .EjecutarEscalar("usp_SelectRevisionUltimoNLab")
            TxtNLabH.Text = retNumLab
        End With
    End Sub

    Private Sub CmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAtras.Click
        Dim mycell As New DataGridCell
        Dim hh As Integer
        If Contador_De_Posicion > 1 Then
            Contador_De_Posicion = Contador_De_Posicion - 1

            hh = 14 + Contador_De_Posicion
            DTGRevision.TableStyles(0).GridColumnStyles(hh).Width = 40

            'Comentario JCruces
            'Call Crear_Grilla_Revision()
            ''AddCellFormattingColumnStyles(Me.DTGRevision, New FormatCellEventHandler(AddressOf FormatGridCells))
            'mycell.ColumnNumber = 12
            'mycell.RowNumber = Fila_Seleccion_Grilla
            'DTGRevision.CurrentCell = mycell
            'DTGRevision.Focus()
        End If
    End Sub

    Private Sub CmdAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdelante.Click
        Dim mycell As New DataGridCell
        Dim hh As Integer

        TS3 = New DataGridTableStyle
        TS3.MappingName = "TABLA_REVISION"

        If Contador_De_Posicion < Cuenta_Elementos Then

            Contador_De_Posicion = Contador_De_Posicion + 1

            hh = 13 + Contador_De_Posicion
            Try
                DTGRevision.TableStyles(0).GridColumnStyles(hh).Width = 2
            Catch ex As Exception
            End Try

            ' Comentario JCruces 
            'For hh = Contador_De_Posicion To Cuenta_Elementos
            '    Dim elemento18 As New DataGridTextBoxColumn
            '    elemento18.MappingName = MATRIZ_ELEMENTOS(hh)
            '    elemento18.HeaderText = MATRIZ_ELEMENTOS_DESPLIEGUE(hh) & vbCrLf & MATRIZ_UNI(hh)
            '    elemento18.Width = 40
            '    elemento18.NullText = ""
            '    elemento18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
            '    TS3.GridColumnStyles.Add(elemento18)
            'Next


            'Call Crear_Grilla_Revision() 
            'AddCellFormattingColumnStyles(Me.DTGRevision, New FormatCellEventHandler(AddressOf FormatGridCells))
            'mycell.ColumnNumber = 12
            'mycell.RowNumber = Fila_Seleccion_Grilla
            'DTGRevision.CurrentCell = mycell
            'DTGRevision.Focus()

        End If
    End Sub

    Private Sub Llena_datos()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim dsDecimal As DataSet = New DataSet
        Dim dsObs As DataSet = New DataSet
        Dim Fila_Grilla, Fila_Ciclo, Fila_Elementos, Fila_SelecElem, Fila_ElemPrio, Fila_EleDig, Fila_SelecArc As DataRow
        Dim Hay_Duplicado, Cuartel1, Cuartel2, query, Observaciones, Predio, Remite, Productor, Localidad, Especie, Variedad, Urgencia, Mas, Fecha, OT As String
        Dim HH, jj, Orden_Aux, Cuenta_l As Integer
        Dim dbman As DbManager
        Dim BusElem(1) As Object
        Dim Arcilla As Integer

        Try
            With SP
                .Inicializar()
                .AgregarParametro("@NLabDesde", CInt(TxtNLabD.Text), SqlDbType.Int)
                .AgregarParametro("@NLabHasta", CInt(TxtNLabH.Text), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectRevisionNLab", Cjto_Tablas1, "CICLO_NLAB1")
            End With

        Catch ex As Exception
            MsgBox("error en revision procedimiento")
        End Try

        Orden_Aux = 0
        Cuenta_l = 0
        For Each Fila_Ciclo In Cjto_Tablas1.Tables("CICLO_NLAB1").Rows
            Mas = " "
            Observaciones = " "
            Cuenta_l = Cuenta_l + 1
            Fila_Grilla = custDS.Tables("TABLA_REVISION").NewRow
            If Orden_Aux = 0 Or Orden_Aux <> Fila_Ciclo("OT_NUMERO") Then
                'DATOS DE ORDEN ************************
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", CInt(Fila_Ciclo("OT_NUMERO")), SqlDbType.Int)
                    ds = .EjecutarQuery("usp_SelectRevisionOrdenTrabajo")
                End With

                Try
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_NUMERO")) = False Then Fila_Grilla("OT_NUMERO") = CStr(ds.Tables(0).Rows(0).Item("OT_NUMERO")) Else OT = 0

                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_DESP_URGENTE")) = False Then
                        If ds.Tables(0).Rows(0).Item("OT_DESP_URGENTE") = True Then Fila_Grilla("OT_NUMERO") = Fila_Grilla("OT_NUMERO") & "U"
                    End If

                    With SP
                        .Inicializar()
                        .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                        .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                        dsObs = .EjecutarQuery("usp_SelectObservacionesAntecedentes")
                    End With

                    '********************* BUSCA IMAGEN ***************
                    'Dim sRutaFoto As String
                    'sRutaFoto = "F:\Mis documentos\" & Year(Today) & ".Foliar-Labsys Fotos"
                    'Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                    '' busca "Hola mundo" en un solo nivel ( SearchTopLevelOnly ) en el directorio c:   
                    'Archivo = My.Computer.FileSystem.GetFiles(sRutaFoto)

                    'Dim sImagen As String
                    'sImagen = sRutaFoto & "\Foliar " & CInt(Fila_Ciclo("OT_NLAB")) & ".jpg"
                    'For Each names As String In Archivo
                    '    If sImagen = names Then
                    '        Observaciones = "x"
                    '    End If
                    'Next

                    '****************************************
                    If IsDBNull(dsObs.Tables(0).Rows(0).Item("OBSERVACIONES")) = False Then
                        If Len(dsObs.Tables(0).Rows(0).Item("OBSERVACIONES")) <> 0 Then Observaciones = "x"
                    End If

                    Fila_Grilla("MAS_OBSERVACIONES") = Observaciones
                    'Fila_Grilla("URGENCIA") = ""
                    If IsDBNull(ds.Tables(0).Rows(0).Item("PRO_PRODUCTOR")) = False Then Fila_Grilla("PRO_PRODUCTOR") = ds.Tables(0).Rows(0).Item("PRO_PRODUCTOR") Else Fila_Grilla("PRO_PRODUCTOR") = ""
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_PREDIO")) = False Then Fila_Grilla("PREDIO") = ds.Tables(0).Rows(0).Item("OT_PREDIO") Else Fila_Grilla("PREDIO") = ""
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_REMITE")) = False Then Fila_Grilla("REMITE") = ds.Tables(0).Rows(0).Item("OT_REMITE") Else Fila_Grilla("REMITE") = ""
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_LOCALIDAD")) = False Then Fila_Grilla("LOCALIDAD") = ds.Tables(0).Rows(0).Item("OT_LOCALIDAD") Else Fila_Grilla("LOCALIDAD") = ""
                Catch ex As Exception
                End Try
            End If

            Orden_Aux = Fila_Ciclo("OT_NUMERO")


            Call LLeno_Antecedentes(Fila_Ciclo("OT_NUMERO"), Fila_Ciclo("OT_NLAB"), Fila_Grilla)

            Fila_Grilla("OT_NLAB") = Fila_Ciclo("OT_NLAB")
            Fila_Grilla("MARCA_DUPLICACION") = ""
            Fila_Grilla("MARCA_REVISION") = ""



            '**************************
            ' DIGITA_RESULTADOS 
            '**************************
            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(Fila_Ciclo("OT_NUMERO")), SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectRevisionElementoxNLab")
            End With


            'Revisa y autogenera elementos
            For Each Fila_EleDig In ds.Tables(0).Rows
                Try
                    If Fila_EleDig("ELE_CODIGO") = "%Piedra" Then GoTo SaltoxPiedra

                    If Fila_EleDig("ELE_PROCESO") = "Autogenerado" And Fila_EleDig("DIGRES_RESULTADO") = 0 Then
                        With SP
                            .Inicializar()
                            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                            .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                            .AgregarParametro("@EleCod", Fila_EleDig("ELE_CODIGO"), SqlDbType.NVarChar)
                            .EjecutarQuery("usp_UpdateElementoAutogenerado")
                        End With
                    End If
SaltoxPiedra:
                Catch ex As Exception
                    ' MsgBox("error Elemento : " & Fila_EleDig("ELE_CODIGO") & " Nº Lab : " & Fila_Ciclo("OT_NLAB"))
                End Try
            Next
            Try
                With SP
                    .Inicializar()
                    .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                    .AgregarParametro("@NumOt", CInt(Fila_Ciclo("OT_NUMERO")), SqlDbType.Int)
                    ds = .EjecutarQuery("usp_SelectRevisionElementoxNLab")
                End With

            Catch ex As Exception
                MsgBox("error en revision")
            End Try


            'Try
            For Each Fila_SelecElem In ds.Tables(0).Rows
                For HH = 1 To Cuenta_Elementos
                    If Fila_SelecElem("ELE_CODIGO") = "WTexBou+AreGyF" Or Fila_SelecElem("ELE_CODIGO") = "WTexBouyouco" Then
                        If MATRIZ_ELEMENTOS(HH) = "Arc" Then
                            With SP
                                .Inicializar()
                                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                                Arcilla = .EjecutarEscalar("usp_SelectArcillaTextura")
                            End With
                            Fila_Grilla(MATRIZ_ELEMENTOS(HH)) = Arcilla
                        End If
                    End If

                    If Fila_SelecElem("ELE_CODIGO") = MATRIZ_ELEMENTOS(HH) Then
                        With SP
                            .Inicializar()
                            .AgregarParametro("@CodEle", MATRIZ_ELEMENTOS(HH), SqlDbType.NVarChar)
                            .AgregarParametro("@CodUni", MATRIZ_UNI(HH), SqlDbType.NVarChar)
                            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                            dsDecimal = .EjecutarQuery("usp_SelectRevisionTipoMascara")
                        End With
                        If IsDBNull(Fila_SelecElem("DIGRES_RESULTADO")) = False Then

                            'Fila_Grilla(MATRIZ_ELEMENTOS(HH)) = CStr(CalculoDecimales(Fila_SelecElem("DIGRES_RESULTADO"), dsDecimal.Tables(0).Rows(0).Item("DECIMALES"))) : Exit For
                            Fila_Grilla(MATRIZ_ELEMENTOS(HH)) = CStr(CalculoDecimales(Fila_SelecElem("DIGRES_RESULTADO"), dsDecimal)) : Exit For
                        End If
                    End If
                Next
                BusElem(0) = CodMuestraRev
                BusElem(1) = Fila_SelecElem("ELE_CODIGO")
                Fila_ElemPrio = Cjto_Tablas1.Tables("ELEMENTO").Rows.Find(BusElem)
                If (Fila_ElemPrio Is Nothing) = False Then
                    If Fila_ElemPrio("ELE_FRECUENCIA") <> "FR" Then Mas = "x"
                End If
            Next
            'Catch ex As Exception
            'MsgBox("error en revision")
            'End Try

            Fila_Grilla("MAS_ELEMENTOS") = Mas
            Fila_Grilla("FILA") = Cuenta_l
            custDS.Tables("TABLA_REVISION").Rows.Add(Fila_Grilla)


            '**************************
            ' DUPLICA_RESULTADO 
            '**************************
            Hay_Duplicado = "N"
            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectRevisionDuplicados")
            End With
            Primera_Pasada = "S"
            Try
                For Each Fila_SelecElem In ds.Tables(0).Rows
                    For HH = 1 To Cuenta_Elementos
                        If Fila_SelecElem("ELE_CODIGO") = MATRIZ_ELEMENTOS(HH) Then
                            If IsDBNull(Fila_SelecElem("DIGRES_RESULTADO")) = False Then
                                If Primera_Pasada = "S" Then Fila_Grilla = custDS.Tables("TABLA_REVISION").NewRow
                                Hay_Duplicado = "S"
                                Fila_Grilla(MATRIZ_ELEMENTOS(HH)) = CStr(Fila_SelecElem("DIGRES_RESULTADO"))
                                Primera_Pasada = "N"
                                Exit For
                            End If
                        End If
                    Next
                    BusElem(0) = CodMuestraRev
                    BusElem(1) = Fila_SelecElem("ELE_CODIGO")
                    Fila_ElemPrio = Cjto_Tablas1.Tables("ELEMENTO").Rows.Find(BusElem)
                    If (Fila_ElemPrio Is Nothing) = False Then
                        If Fila_ElemPrio("ELE_FRECUENCIA") <> "FR" Then Mas = "x"
                    End If
                Next
            Catch ex As Exception
                MsgBox("Error en revision")
            End Try

            If Hay_Duplicado = "S" Then
                Cuenta_l = Cuenta_l + 1
                Fila_Grilla("OT_NLAB") = Fila_Ciclo("OT_NLAB")
                Fila_Grilla("PRO_PRODUCTOR") = ""
                Fila_Grilla("PREDIO") = ""
                Fila_Grilla("REMITE") = ""
                Fila_Grilla("LOCALIDAD") = ""
                Fila_Grilla("CAMPO1") = ""
                Fila_Grilla("CAMPO2") = ""
                Fila_Grilla("CAMPO3") = ""
                Fila_Grilla("CAMPO4") = ""
                Fila_Grilla("IDENTIFICACION") = "                              Dup."
                Fila_Grilla("MARCA_DUPLICACION") = ""
                Fila_Grilla("MARCA_REVISION") = ""
                Fila_Grilla("MAS_ELEMENTOS") = Mas
                Fila_Grilla("FILA") = Cuenta_l
                custDS.Tables("TABLA_REVISION").Rows.Add(Fila_Grilla)
            End If

            ' Lleno tabla TABLA_ESTADO PARA MANEJAR ESTADO TRANSACCIONALMENTE "NO GRABARLOS" EN FORMA INMEDIATA 
            'Try
            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectRevisionElementoEstados", Cjto_Tablas1, "TABLA_ESTADO")
            End With

            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectRevisionElementoEstadosDuplicados", Cjto_Tablas1, "TABLA_ESTADO_DUPLICADOS")
            End With
            'Catch ex As Exception
            '    MsgBox(ex)
            'End Try
        Next
        '        Alto_EncDato = Cuenta_l
    End Sub
    Private Sub Llena_datos_auto()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim dsDecimal As DataSet = New DataSet
        Dim dsObs As DataSet = New DataSet
        Dim Fila_Grilla, Fila_Ciclo, Fila_Elementos, Fila_SelecElem, Fila_ElemPrio, Fila_EleDig, Fila_SelecArc As DataRow
        Dim Hay_Duplicado, Cuartel1, Cuartel2, query, Observaciones, Predio, Remite, Productor, Localidad, Especie, Variedad, Urgencia, Mas, Fecha, OT As String
        Dim HH, jj, Orden_Aux, Cuenta_l As Integer
        Dim dbman As DbManager
        Dim BusElem(1) As Object
        Dim Arcilla As Integer

        Try
            With SP
                .Inicializar()
                .AgregarParametro("@NLabDesde", CInt(tx_NlabDesdeG.Text), SqlDbType.Int)
                .AgregarParametro("@NLabHasta", CInt(tx_NlabHastaG.Text), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectRevisionNLab", Cjto_Tablas1, "CICLO_NLAB1")
            End With

        Catch ex As Exception
            MsgBox("error en revision procedimiento")
        End Try

        Orden_Aux = 0
        Cuenta_l = 0
        For Each Fila_Ciclo In Cjto_Tablas1.Tables("CICLO_NLAB1").Rows


            '**************************
            ' DIGITA_RESULTADOS 
            '**************************
            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(Fila_Ciclo("OT_NUMERO")), SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectRevisionElementoxNLab")
            End With


            'Revisa y autogenera elementos
            For Each Fila_EleDig In ds.Tables(0).Rows
                Try
                    If Fila_EleDig("ELE_CODIGO") = "%Piedra" Then GoTo SaltoxPiedra

                    If Fila_EleDig("ELE_PROCESO") = "Autogenerado" Then
                        With SP
                            .Inicializar()
                            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                            .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                            .AgregarParametro("@EleCod", Fila_EleDig("ELE_CODIGO"), SqlDbType.NVarChar)
                            .EjecutarQuery("usp_UpdateElementoAutogenerado")
                        End With
                    End If
SaltoxPiedra:
                Catch ex As Exception
                    ' MsgBox("error Elemento : " & Fila_EleDig("ELE_CODIGO") & " Nº Lab : " & Fila_Ciclo("OT_NLAB"))
                End Try
            Next

        Next
        'MsgBox("Autogenerados con éxito, vuelva a revisar!")
        '        Alto_EncDato = Cuenta_l
    End Sub

    Private Function CalculoDecimales(ByVal ResDec As Double, ByVal dsDecimal As DataSet) As Double
        Dim ResFin As Double = ResDec
        Dim Fila_TMascara As DataRow
        Dim sDecimales As String = "00000"
        Dim CantDec As Integer = 0
        Dim Formateo As String = ""
        Dim sMascara1 As String = ""
        For Each Fila_TMascara In dsDecimal.Tables(0).Rows
            If Fila_TMascara("RANGO_DESDE") <= ResDec And ResDec <= Fila_TMascara("RANGO_HASTA") Then
                CantDec = Fila_TMascara("DECIMALES")
                If CantDec = 0 Then Formateo = "##0"
                If CantDec = 1 Then Formateo = "##0" & "." & Mid(sDecimales, 1, 1)
                If CantDec = 2 Then Formateo = "##0" & "." & Mid(sDecimales, 1, 2)
                If CantDec = 3 Then Formateo = "##0" & "." & Mid(sDecimales, 1, 3)
                'If CantDec > 0 Then Formateo = "##0" & "." & sMascara1
                ResFin = Format(ResDec, Formateo)
                Return ResFin
            End If
        Next
    End Function

    Private Sub LLeno_Antecedentes(ByVal OTN As Integer, ByVal OTNLAB As Integer, ByRef Fila_Grilla As DataRow)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Cuar1, Cuar2 As String
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", OTN, SqlDbType.Int)
            .AgregarParametro("@NLab", OTNLAB, SqlDbType.Int)
            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectRevisionLlenoAntecedentes")
        End With

        Try
            If IsDBNull(ds.Tables(0).Rows(0).Item("CAMPO1")) = False Then
                If CAMPO1 <> ds.Tables(0).Rows(0).Item("CAMPO1") Then Fila_Grilla("CAMPO1") = ds.Tables(0).Rows(0).Item("CAMPO1") : CAMPO1 = ds.Tables(0).Rows(0).Item("CAMPO1") Else Fila_Grilla("CAMPO1") = " "
            Else
                Fila_Grilla("CAMPO1") = " "
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("CAMPO2")) = False Then
                If CAMPO2 <> ds.Tables(0).Rows(0).Item("CAMPO2") Then Fila_Grilla("CAMPO2") = ds.Tables(0).Rows(0).Item("CAMPO2") : CAMPO2 = ds.Tables(0).Rows(0).Item("CAMPO2") Else Fila_Grilla("CAMPO2") = " "
            Else
                Fila_Grilla("CAMPO2") = " "
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("CAMPO3")) = False Then
                If CAMPO3 <> ds.Tables(0).Rows(0).Item("CAMPO3") Then Fila_Grilla("CAMPO3") = ds.Tables(0).Rows(0).Item("CAMPO3") : CAMPO3 = ds.Tables(0).Rows(0).Item("CAMPO3") Else Fila_Grilla("CAMPO3") = " "
            Else
                Fila_Grilla("CAMPO3") = " "
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("CAMPO4")) = False Then
                If CAMPO4 = "" Then CAMPO4 = "01-01-1900"
                If CAMPO4 <> ds.Tables(0).Rows(0).Item("CAMPO4") Then Fila_Grilla("CAMPO4") = ds.Tables(0).Rows(0).Item("CAMPO4") : CAMPO4 = ds.Tables(0).Rows(0).Item("CAMPO4") Else Fila_Grilla("CAMPO4") = " "
            Else
                Fila_Grilla("CAMPO4") = " "
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("IDENTIFICACION1")) = False Then Cuar1 = ds.Tables(0).Rows(0).Item("IDENTIFICACION1") Else Cuar1 = " "
            If IsDBNull(ds.Tables(0).Rows(0).Item("IDENTIFICACION2")) = False Then Cuar2 = ds.Tables(0).Rows(0).Item("IDENTIFICACION2") Else Cuar2 = " "

            Fila_Grilla("IDENTIFICACION") = Cuar1 & Cuar2

            '********************* BUSCA IMAGEN ***************
            Dim sRutaFoto As String
            If CodMuestraRev = 1000 Then
                sRutaFoto = "F:\Mis documentos\" & Year(Today) & ".Foliar-Labsys Fotos"
                Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                Archivo = My.Computer.FileSystem.GetFiles(sRutaFoto)

                Dim sImagen As String
                sImagen = sRutaFoto & "\Foliar " & OTNLAB & ".jpg"
                For Each names As String In Archivo
                    If sImagen = names Then
                        Fila_Grilla("MAS_OBSERVACIONES") = "x"
                    End If
                Next
            ElseIf CodMuestraRev = 2000 Then
                sRutaFoto = "F:\Mis documentos\" & Year(Today) & ".Frutos-Labsys Fotos"
                Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                Archivo = My.Computer.FileSystem.GetFiles(sRutaFoto)

                Dim sImagen As String
                sImagen = sRutaFoto & "\Fruto " & OTNLAB & ".jpg"
                For Each names As String In Archivo
                    If sImagen = names Then
                        Fila_Grilla("MAS_OBSERVACIONES") = "x"
                    End If
                Next
                sImagen = sRutaFoto & "\Fruto " & OTNLAB & " a.jpg"
                For Each names As String In Archivo
                    If sImagen = names Then
                        Fila_Grilla("MAS_OBSERVACIONES") = "x"
                    End If
                Next
                sImagen = sRutaFoto & "\Fruto " & OTNLAB & " b.jpg"
                For Each names As String In Archivo
                    If sImagen = names Then
                        Fila_Grilla("MAS_OBSERVACIONES") = "x"
                    End If
                Next
                sImagen = sRutaFoto & "\Fruto " & OTNLAB & " c.jpg"
                For Each names As String In Archivo
                    If sImagen = names Then
                        Fila_Grilla("MAS_OBSERVACIONES") = "x"
                    End If
                Next

            End If


            '****************************************
            If IsDBNull(ds.Tables(0).Rows(0).Item("OBSERVACIONES")) = False Then
                If Len(ds.Tables(0).Rows(0).Item("OBSERVACIONES")) <> 0 Then Fila_Grilla("MAS_OBSERVACIONES") = "x"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DTGRevision_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTGRevision.CurrentCellChanged
        Dim myGriC As DataGrid
        Dim mycell As New DataGridCell
        Dim query As String
        Dim codana As Double
        Dim BuscaEstado(3), BuscaEstadoDup(3) As Object
        Dim muestra As Boolean = False
        Dim Fila_Estado As DataRow
        myGriC = CType(sender, DataGrid)
        Try
            Fila_Seleccion_Grilla = myGriC.CurrentCell.RowNumber
            Columna_Seleccion_Grilla = myGriC.CurrentCell.ColumnNumber
            If IsDBNull(myGriC.Item(Fila_Seleccion_Grilla, 12)) Then
                GoTo SaltoNuloFila11
            Else
                If Columna_Seleccion_Grilla = 12 Then

                    '********************* BUSCA IMAGEN ********************
                    Dim sRutaFoto, sImagen1, sImagen2, sImagen3, sImagen4, simagenError As String
                    If CodMuestraRev = 1000 Then

                        sRutaFoto = "F:\Mis documentos\" & Year(Today) & ".Foliar-Labsys Fotos"
                        sImagen1 = sRutaFoto & "\Foliar " & myGriC.Item(Fila_Seleccion_Grilla, 11) & ".jpg"
                        sImagen2 = sRutaFoto & "\Foliar " & myGriC.Item(Fila_Seleccion_Grilla, 11) & " a.jpg"
                        sImagen3 = sRutaFoto & "\Foliar " & myGriC.Item(Fila_Seleccion_Grilla, 11) & " b.jpg"
                        sImagen4 = sRutaFoto & "\Foliar " & myGriC.Item(Fila_Seleccion_Grilla, 11) & " c.jpg"
                        simagenError = "F:\Archivos LabSys\Imagenes\no_disponible.png"

                        If My.Computer.FileSystem.FileExists(sImagen1) Then
                            Me.pBox.BackgroundImage = Image.FromFile(sImagen1)
                            Me.pb1.BackgroundImage = Image.FromFile(sImagen1)
                        Else
                            Me.pBox.BackgroundImage = Image.FromFile(simagenError)
                            Me.pb1.BackgroundImage = Image.FromFile(simagenError)
                        End If
                        If My.Computer.FileSystem.FileExists(sImagen2) Then
                            Me.pb2.BackgroundImage = Image.FromFile(sImagen2)
                        Else
                            Me.pb2.BackgroundImage = Image.FromFile(simagenError)
                        End If
                        If My.Computer.FileSystem.FileExists(sImagen3) Then
                            Me.pb3.BackgroundImage = Image.FromFile(sImagen3)
                        Else
                            Me.pb3.BackgroundImage = Image.FromFile(simagenError)
                        End If
                        If My.Computer.FileSystem.FileExists(sImagen4) Then
                            Me.pb4.BackgroundImage = Image.FromFile(sImagen4)
                        Else
                            Me.pb4.BackgroundImage = Image.FromFile(simagenError)
                        End If
                    ElseIf CodMuestraRev = 2000 Then
                        sRutaFoto = "F:\Mis documentos\" & Year(Today) & ".Frutos-Labsys Fotos"
                        sImagen1 = sRutaFoto & "\Fruto " & myGriC.Item(Fila_Seleccion_Grilla, 11) & ".jpg"
                        sImagen2 = sRutaFoto & "\Fruto " & myGriC.Item(Fila_Seleccion_Grilla, 11) & " a.jpg"
                        sImagen3 = sRutaFoto & "\Fruto " & myGriC.Item(Fila_Seleccion_Grilla, 11) & " b.jpg"
                        sImagen4 = sRutaFoto & "\Fruto " & myGriC.Item(Fila_Seleccion_Grilla, 11) & " c.jpg"
                        simagenError = "F:\Archivos LabSys\Imagenes\no_disponible.png"

                        If My.Computer.FileSystem.FileExists(sImagen1) Then
                            Me.pBox.BackgroundImage = Image.FromFile(sImagen1)
                            Me.pb1.BackgroundImage = Image.FromFile(sImagen1)
                        Else
                            Me.pBox.BackgroundImage = Image.FromFile(simagenError)
                            Me.pb1.BackgroundImage = Image.FromFile(simagenError)
                        End If
                        If My.Computer.FileSystem.FileExists(sImagen2) Then
                            Me.pb2.BackgroundImage = Image.FromFile(sImagen2)
                        Else
                            Me.pb2.BackgroundImage = Image.FromFile(simagenError)
                        End If
                        If My.Computer.FileSystem.FileExists(sImagen3) Then
                            Me.pb3.BackgroundImage = Image.FromFile(sImagen3)
                        Else
                            Me.pb3.BackgroundImage = Image.FromFile(simagenError)
                        End If
                        If My.Computer.FileSystem.FileExists(sImagen4) Then
                            Me.pb4.BackgroundImage = Image.FromFile(sImagen4)
                        Else
                            Me.pb4.BackgroundImage = Image.FromFile(simagenError)
                        End If

                    End If
                    




                    '********************* BUSCA OBSERVACION ***************
                    Dim sObservacion As String
                    Dim ds As DataSet = New DataSet
                    Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
                    With SP
                        .Inicializar()
                        .AgregarParametro("@NLab", myGriC.Item(Fila_Seleccion_Grilla, 11), SqlDbType.Int)
                        .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                        ds = .EjecutarQuery("usp_SelectObservacionesAntecedentes")
                    End With
                    If ds.Tables(0).Rows(0).Item(0) <> "" Then
                        sObservacion = ds.Tables(0).Rows(0).Item(0)
                        txtObs.Text = sObservacion
                    Else
                        txtObs.Text = ""
                    End If

                    Me.pnlImagen.Visible = True
                    '********************************************************
                End If



            End If
            If IsDBNull(myGriC.Item(Fila_Seleccion_Grilla, 11)) Then GoTo SaltoNuloFila11
            If myGriC.Item(Fila_Seleccion_Grilla, 10) = "                              Dup." And Columna_Seleccion_Grilla <= 14 Then Exit Sub
            If myGriC.Item(Fila_Seleccion_Grilla, 10) = "                              Dup." And Columna_Seleccion_Grilla > 14 Then Call Marca_DuplicadoRevisado(myGriC) : Exit Sub
SaltoNuloFila11:
            If Columna_Seleccion_Grilla = 13 Then Call Marca_Duplicacion(myGriC) : Exit Sub
            If Columna_Seleccion_Grilla = 14 Then Call Marca_Revision(myGriC) : Exit Sub
            If Columna_Seleccion_Grilla < 15 Then Exit Sub
            'If Columna_Seleccion_Grilla = (Cuenta_Elementos + 16 - (Contador_De_Posicion)) Then Exit Sub
            BuscaEstado(0) = CodMuestraRev
            BuscaEstado(1) = MATRIZ_NLAB(Fila_Seleccion_Grilla)
            BuscaEstado(2) = MATRIZ_ELEMENTOS(Columna_Seleccion_Grilla - 14)
            'BuscaEstado(2) = MATRIZ_ELEMENTOS(Columna_Seleccion_Grilla - (15 - Contador_De_Posicion))
            BuscaEstado(3) = MATRIZ_OT(Fila_Seleccion_Grilla)
            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
            If (Fila_Estado Is Nothing) = False Then
                If RDBDuplicacionxAnalizar.Checked = True Then Fila_Estado("ELE_ESTADO") = "DuxA" : Exit Sub
                If RDBxRevisar.Checked Then Fila_Estado("ELE_ESTADO") = "xR" : Exit Sub
                If RDBDuplicacionxAnalizar.Checked = True Then Fila_Estado("ELE_ESTADO") = "DuxA" : Exit Sub
                If RDBOtro.Checked = True Then Fila_Estado("ELE_ESTADO") = "Reot" : Call AutogeneraFila() : Exit Sub
                If RDBAcepto.Checked Then Fila_Estado("ELE_ESTADO") = "Re" : Call AutogeneraFila() : Exit Sub
            End If
        Catch ex As Exception
            MsgBox("error en grilla")
        End Try
    End Sub

    Private Sub AutogeneraFila()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim dsDecimal As DataSet = New DataSet

        Dim BuscaRevision As Object
        Dim Fila_Seleccion As DataRow
        Dim ColEle, FilCu, MasFila As Integer
        Dim ResultadoSelec, Retorno As Double
        Dim ElementoSelec, Retorno_Str As String

        ElementoSelec = MATRIZ_ELEMENTOS(Columna_Seleccion_Grilla - 14)
        ResultadoSelec = DTGRevision.Item(Fila_Seleccion_Grilla, Columna_Seleccion_Grilla)

        For ColEle = 1 To Cuenta_Elementos
            Try
                If MATRIZ_ELEMENTOS(ColEle) <> ElementoSelec Then
                    With SP
                        .Inicializar()
                        .AgregarParametro("@EleSelec", ElementoSelec, SqlDbType.NVarChar)
                        .AgregarParametro("@ResSelec", ResultadoSelec, SqlDbType.Float)
                        .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                        .AgregarParametro("@NLab", MATRIZ_NLAB(Fila_Seleccion_Grilla), SqlDbType.Int)
                        .AgregarParametro("@EleCod", MATRIZ_ELEMENTOS(ColEle), SqlDbType.NVarChar)
                        Retorno = .EjecutarEscalar2("usp_UpdateElementoAutogeneradoRevision")
                    End With
                    If Retorno <> 0 Then
                        With SP
                            .Inicializar()
                            .AgregarParametro("@CodEle", MATRIZ_ELEMENTOS(ColEle), SqlDbType.NVarChar)
                            .AgregarParametro("@CodUni", MATRIZ_UNI(ColEle), SqlDbType.NVarChar)
                            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                            dsDecimal = .EjecutarQuery("usp_SelectRevisionTipoMascara")
                        End With
                        Retorno_Str = CStr(CalculoDecimales(Retorno, dsDecimal))
                        DTGRevision.Item(Fila_Seleccion_Grilla, (ColEle + 14)) = Retorno_Str
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error en autogeneracion")
            End Try
        Next
    End Sub

    Private Sub Marca_DuplicadoRevisado(ByVal myGriC As DataGrid)
        Dim BuscaEstadoDup(3) As Object
        Dim Fila_Estado As DataRow
        Dim Con As Integer
        Dim SiglaEst As String
        If RDBAcepto.Checked Then
            BuscaEstadoDup(0) = CodMuestraRev
            BuscaEstadoDup(1) = MATRIZ_DUPLICADOS(Fila_Seleccion_Grilla)
            BuscaEstadoDup(2) = MATRIZ_ELEMENTOS(Columna_Seleccion_Grilla - 14)
            BuscaEstadoDup(3) = MATRIZ_NUMERODIGITACION(Fila_Seleccion_Grilla)
            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO_DUPLICADOS").Rows.Find(BuscaEstadoDup)
            If (Fila_Estado Is Nothing) = False Then
                Fila_Estado("ELE_ESTADO") = "DuRe"
            End If
        End If

        '            Try
        '                If myGriC.Item(Fila_Seleccion_Grilla - 1, 11) <> "                              Dup." And myGriC.Item(Fila_Seleccion_Grilla - 1, 13) = MATRIZ_NLAB(Fila_Seleccion_Grilla) Then
        '                    myGriC.Item(Fila_Seleccion_Grilla - 1, Columna_Seleccion_Grilla) = myGriC.Item(Fila_Seleccion_Grilla, Columna_Seleccion_Grilla) : GoTo SaltoxCambioRes
        '                End If
        '            Catch ex As Exception
        '                If myGriC.Item(Fila_Seleccion_Grilla - 1, 13) = MATRIZ_NLAB(Fila_Seleccion_Grilla) Then
        '                    myGriC.Item(Fila_Seleccion_Grilla - 1, Columna_Seleccion_Grilla) = myGriC.Item(Fila_Seleccion_Grilla, Columna_Seleccion_Grilla)
        '                    GoTo SaltoxCambioRes
        '                End If
        '            End Try

        '            Try
        '                If myGriC.Item(Fila_Seleccion_Grilla - 2, 11) <> "                              Dup." And myGriC.Item(Fila_Seleccion_Grilla - 2, 13) = MATRIZ_NLAB(Fila_Seleccion_Grilla) Then
        '                    myGriC.Item(Fila_Seleccion_Grilla - 2, Columna_Seleccion_Grilla) = myGriC.Item(Fila_Seleccion_Grilla, Columna_Seleccion_Grilla) : GoTo SaltoxCambioRes
        '                End If
        '            Catch ex As Exception
        '                If myGriC.Item(Fila_Seleccion_Grilla - 2, 13) = MATRIZ_NLAB(Fila_Seleccion_Grilla) Then
        '                    myGriC.Item(Fila_Seleccion_Grilla - 2, Columna_Seleccion_Grilla) = myGriC.Item(Fila_Seleccion_Grilla, Columna_Seleccion_Grilla)
        '                    GoTo SaltoxCambioRes
        '                End If
        '            End Try

        '            Try
        '                If myGriC.Item(Fila_Seleccion_Grilla - 3, 11) <> "                              Dup." And myGriC.Item(Fila_Seleccion_Grilla - 3, 13) = MATRIZ_NLAB(Fila_Seleccion_Grilla) Then
        '                    myGriC.Item(Fila_Seleccion_Grilla - 3, Columna_Seleccion_Grilla) = myGriC.Item(Fila_Seleccion_Grilla, Columna_Seleccion_Grilla) : GoTo SaltoxCambioRes
        '                End If
        '            Catch ex As Exception
        '                If myGriC.Item(Fila_Seleccion_Grilla - 3, 13) = MATRIZ_NLAB(Fila_Seleccion_Grilla) Then
        '                    myGriC.Item(Fila_Seleccion_Grilla - 3, Columna_Seleccion_Grilla) = myGriC.Item(Fila_Seleccion_Grilla, Columna_Seleccion_Grilla)
        '                    GoTo SaltoxCambioRes
        '                End If
        '            End Try
        'SaltoxCambioRes:
    End Sub
    Private Sub Marca_Duplicacion(ByVal myGriC As DataGrid)
        Dim BuscaEstado(2) As Object
        Dim Fila_Estado As DataRow
        Dim Con As Integer
        Dim SiglaEst As String
        Dim respuesta As MsgBoxResult
        'respuesta = MsgBox("Esta seguro de duplicar la muestra completa", MsgBoxStyle.YesNo)
        'If respuesta = MsgBoxResult.Yes Then
        If myGriC.Item(Fila_Seleccion_Grilla, 13) = "x" Then myGriC.Item(Fila_Seleccion_Grilla, 13) = "" : SiglaEst = "xR" : GoTo SaltoxFilaSelec
        If myGriC.Item(Fila_Seleccion_Grilla, 13) = "" Then myGriC.Item(Fila_Seleccion_Grilla, 13) = "x" : myGriC.Item(Fila_Seleccion_Grilla, 14) = "" : SiglaEst = "DuxA"
SaltoxFilaSelec:
        For Con = 1 To Cuenta_Elementos
            BuscaEstado(0) = CodMuestraRev
            BuscaEstado(1) = MATRIZ_NLAB(Fila_Seleccion_Grilla)
            BuscaEstado(2) = MATRIZ_ELEMENTOS(Con)
            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
            If (Fila_Estado Is Nothing) = False Then
                Fila_Estado("ELE_ESTADO") = SiglaEst
            End If
        Next
    End Sub

    Private Sub Marca_Revision(ByVal myGriC As DataGrid)
        Dim BuscaEstado(3) As Object
        Dim Fila_Estado As DataRow
        Dim Con As Integer
        Dim SiglaEst As String
        Dim respuesta As MsgBoxResult
        If myGriC.Item(Fila_Seleccion_Grilla, 14) = "x" Then myGriC.Item(Fila_Seleccion_Grilla, 14) = "" : SiglaEst = "xR" : GoTo SaltoxFilaSelec
        If myGriC.Item(Fila_Seleccion_Grilla, 14) = "" Then myGriC.Item(Fila_Seleccion_Grilla, 14) = "x" : myGriC.Item(Fila_Seleccion_Grilla, 13) = "" : SiglaEst = "Re"
SaltoxFilaSelec:
        'respuesta = MsgBox("Esta seguro de revisar la muestra completa", MsgBoxStyle.YesNo)
        'If respuesta = MsgBoxResult.Yes Then
        For Con = 1 To Cuenta_Elementos
            BuscaEstado(0) = CodMuestraRev
            BuscaEstado(1) = MATRIZ_NLAB(Fila_Seleccion_Grilla)
            BuscaEstado(2) = MATRIZ_ELEMENTOS(Con)
            BuscaEstado(3) = MATRIZ_OT(Fila_Seleccion_Grilla)
            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
            If (Fila_Estado Is Nothing) = False Then
                'Modificado el 14-04-2009 estos estados no se utilizan
                'If Fila_Estado("ELE_ESTADO") <> "DuxA" And Fila_Estado("ELE_ESTADO") <> "DuRe" And Fila_Estado("ELE_ESTADO") <> "Reot" Then Fila_Estado("ELE_ESTADO") = SiglaEst
                Fila_Estado("ELE_ESTADO") = SiglaEst
            End If
        Next
        'End If
    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()
    End Sub

    Private Function Revisa_DuplicadosRevisados(ByVal FilCu As Integer, ByVal ColEle As Integer) As Integer
        Dim BuscaEstado(3) As Object
        Dim Fila_Estado As DataRow
        Dim Con As Integer
        Dim SiglaEst As String
        Try
            For Con = 1 To 10
                If DTGRevision.Item(FilCu + Con, 11) <> "                              Dup." Then Exit For
                BuscaEstado(0) = CodMuestraRev
                BuscaEstado(1) = MATRIZ_DUPLICADOS(FilCu + Con)
                BuscaEstado(2) = MATRIZ_ELEMENTOS(ColEle)
                BuscaEstado(3) = MATRIZ_NUMERODIGITACION(FilCu + Con)
                Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO_DUPLICADOS").Rows.Find(BuscaEstado)
                If (Fila_Estado Is Nothing) = False Then
                    If Fila_Estado("ELE_ESTADO") = "DuRe" Then Return Con : Exit For
                End If
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Sub CmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabar.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Retorno As Integer
        Dim BuscaEstado(3) As Object
        Dim Fila_Estado As DataRow
        Dim FilCu, ColEle, MasFila As Integer
        Dim ResEle As Double
        Dim Tmarca, sMsg2 As String
        Dim frmEsp As New Frm_Espere
        If usuarioLG = "ESPIR" Or usuarioLG = "CRUCJ" Or usuarioLG = "Administrador" Then
            sMsg2 = "Grabando Nº Laboratorios marcados"
            frmEsp.lblMsg2.Text = sMsg2
            frmEsp.Show()
            frmEsp.Refresh()
            'Call Imprime_Revisa(DTGRevision, Cuenta_Elementos, MATRIZ_UNI)
            For FilCu = 0 To 1000
                Try
                    If DTGRevision.Item(FilCu, 13) = "x" Or DTGRevision.Item(FilCu, 14) = "x" Then
                        For ColEle = 1 To Cuenta_Elementos
                            Try
                                If IsDBNull(DTGRevision.Item(FilCu, 11)) Then Exit For
                                If DTGRevision.Item(FilCu, 11) = 0 Then Exit For
                                BuscaEstado(0) = CodMuestraRev
                                BuscaEstado(1) = MATRIZ_NLAB(FilCu)
                                BuscaEstado(2) = MATRIZ_ELEMENTOS(ColEle)
                                BuscaEstado(3) = MATRIZ_OT(FilCu)
                                Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
                                If (Fila_Estado Is Nothing) = False Then
                                    MasFila = 0
                                    MasFila = Revisa_DuplicadosRevisados(FilCu, ColEle)
                                    ResEle = DTGRevision.Item(FilCu + MasFila, (ColEle + 14))
                                    If MasFila > 0 Then Fila_Estado("ELE_ESTADO") = "DuRe"
                                    With SP
                                        .Inicializar()
                                        .AgregarParametro("@ResEle", ResEle, SqlDbType.Float)
                                        .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                                        .AgregarParametro("@NLab", MATRIZ_NLAB(FilCu), SqlDbType.Int)
                                        .AgregarParametro("@CodEle", MATRIZ_ELEMENTOS(ColEle), SqlDbType.NVarChar)
                                        .AgregarParametro("@EstEle", Fila_Estado("ELE_ESTADO"), SqlDbType.NVarChar)
                                        Retorno = .EjecutarEscalar("usp_UpdateRevisionElementos")
                                    End With
                                End If
                            Catch ex As Exception
                                Exit For
                            End Try
                        Next
                        With SP
                            .Inicializar()
                            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                            .AgregarParametro("@NLab", MATRIZ_NLAB(FilCu), SqlDbType.Int)
                            Retorno = .EjecutarEscalar("usp_UpdateRevisionAntecedentes")
                        End With
                        With SP
                            .Inicializar()
                            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                            .AgregarParametro("@NLab", MATRIZ_NLAB(FilCu), SqlDbType.Int)
                            Retorno = .EjecutarEscalar("usp_UpdateRevisionOrdenTrabajo")
                        End With
                    End If
                Catch ex As Exception
                    Exit For
                End Try
            Next
            frmEsp.Close()
            Me.Close()
        Else
            MsgBox("No tiene permisos para grabar......")
        End If
    End Sub

    Private Sub BTAntecedentesMuestras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAntecedentesMuestras.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim NumOT As Integer = 0
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim query As String
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
            .AgregarParametro("@NLab", MATRIZ_NLAB(Fila_Seleccion_Grilla), SqlDbType.Int)
            Orden_Trabajo_Bus = .EjecutarEscalar("usp_SelectRevisionOT")
        End With

        If Orden_Trabajo_Bus = 0 Then
            MsgBox("Orden : " & Orden_Trabajo & " no existe")
        Else
            Tipo_Ingreso_OT = "Consulta"
            Dim Form_Aux As New F_OrdenTrabajo : Form_Aux.ShowDialog()
            Form_Aux = Nothing
        End If

    End Sub

    Private Sub BTVerResAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTVerResAnt.Click
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim query As String
        NLabRevisionAnterior = 0
        NLabRevisionAnterior = MATRIZ_NLAB(Fila_Seleccion_Grilla)
        If NLabRevisionAnterior = 0 Then
            MsgBox("Nº Laboratorio : " & NLabRevisionAnterior & " no existe")
        Else
            Dim Form_Aux As New Frm_Resultados_Antiguos : Form_Aux.ShowDialog()
            Form_Aux = Nothing
        End If
    End Sub

    Private Sub CmdAceptaAprobacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptaAprobacion.Click
        Dim FilCu, ColEle As Integer
        Dim BuscaEstado(3) As Object
        Dim Fila_Estado As DataRow
        For FilCu = 0 To 1000
            Try
                If MATRIZ_NLAB(FilCu) > CInt(TxtNLabHastaRango.Text) Then Exit For
                If IsDBNull(DTGRevision.Item(FilCu, 11)) Then GoTo SaltoxNulo
                If CInt(TxtNLabDesdeRango.Text) <= MATRIZ_NLAB(FilCu) And MATRIZ_NLAB(FilCu) <= CInt(TxtNLabHastaRango.Text) And DTGRevision.Item(FilCu, 10) <> "                              Dup." Then
SaltoxNulo:
                    DTGRevision.Item(FilCu, 14) = "x"
                    For ColEle = 1 To Cuenta_Elementos
                        Try
                            BuscaEstado(0) = CodMuestraRev
                            BuscaEstado(1) = MATRIZ_NLAB(FilCu)
                            BuscaEstado(2) = MATRIZ_ELEMENTOS(ColEle)
                            BuscaEstado(3) = MATRIZ_OT(FilCu)
                            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
                            If (Fila_Estado Is Nothing) = False Then
                                If Fila_Estado("ELE_ESTADO") <> "DuxA" And Fila_Estado("ELE_ESTADO") <> "DuRe" And Fila_Estado("ELE_ESTADO") <> "Reot" Then Fila_Estado("ELE_ESTADO") = "Re"
                            End If
                        Catch ex As Exception
                            Exit For
                        End Try
                    Next
                End If
            Catch ex As Exception
                Exit For
            End Try
        Next
    End Sub

    Private Sub TxtNLabDesdeRango_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNLabDesdeRango.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNLabHastaRango.Focus()
        End If
    End Sub

    Private Sub TxtNLabHastaRango_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNLabHastaRango.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptaAprobacion.Focus()
        End If
    End Sub

    Private Sub CmdImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdImprimir.Click
        Call Imprime_Revisa_Total(DTGRevision, Cuenta_Elementos, MATRIZ_UNI)
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Me.Llena_datos_auto()
    'End Sub

    Private Sub tx_NlabDesdeG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_NlabDesdeG.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.tx_NlabHastaG.Text = Me.tx_NlabDesdeG.Text
        End If
    End Sub

    Private Sub tx_NlabHastaG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx_NlabHastaG.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Button1.Focus()
        End If
    End Sub

    Private Sub DTGRevision_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTGRevision.DoubleClick
        'If (cell.Value = "x") Then

        '    cell.Value = o
        'Else
        '    cell.Value = x
        'End If
        'MsgBox("doble")
    End Sub

    Private Sub DTGRevision1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myGriC As DataGrid
        Dim mycell As New DataGridCell
        Dim query As String
        Dim codana As Double
        Dim BuscaEstado(3), BuscaEstadoDup(3) As Object
        Dim muestra As Boolean = False
        Dim Fila_Estado As DataRow
        myGriC = CType(sender, DataGrid)
        Try
            Fila_Seleccion_Grilla = myGriC.CurrentCell.RowNumber
            Columna_Seleccion_Grilla = myGriC.CurrentCell.ColumnNumber
            If IsDBNull(myGriC.Item(Fila_Seleccion_Grilla, 11)) Then GoTo SaltoNuloFila11
            If myGriC.Item(Fila_Seleccion_Grilla, 10) = "                              Dup." And Columna_Seleccion_Grilla <= 14 Then Exit Sub
            If myGriC.Item(Fila_Seleccion_Grilla, 10) = "                              Dup." And Columna_Seleccion_Grilla > 14 Then Call Marca_DuplicadoRevisado(myGriC) : Exit Sub
SaltoNuloFila11:
            If Columna_Seleccion_Grilla = 13 Then Call Marca_Duplicacion(myGriC) : Exit Sub
            If Columna_Seleccion_Grilla = 14 Then Call Marca_Revision(myGriC) : Exit Sub
            If Columna_Seleccion_Grilla < 15 Then Exit Sub
            'If Columna_Seleccion_Grilla = (Cuenta_Elementos + 16 - (Contador_De_Posicion)) Then Exit Sub
            BuscaEstado(0) = CodMuestraRev
            BuscaEstado(1) = MATRIZ_NLAB(Fila_Seleccion_Grilla)
            BuscaEstado(2) = MATRIZ_ELEMENTOS(Columna_Seleccion_Grilla - 14)
            'BuscaEstado(2) = MATRIZ_ELEMENTOS(Columna_Seleccion_Grilla - (15 - Contador_De_Posicion))
            BuscaEstado(3) = MATRIZ_OT(Fila_Seleccion_Grilla)
            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
            If (Fila_Estado Is Nothing) = False Then
                If RDBDuplicacionxAnalizar.Checked = True Then Fila_Estado("ELE_ESTADO") = "DuxA" : Exit Sub
                If RDBxRevisar.Checked Then Fila_Estado("ELE_ESTADO") = "xR" : Exit Sub
                If RDBDuplicacionxAnalizar.Checked = True Then Fila_Estado("ELE_ESTADO") = "DuxA" : Exit Sub
                If RDBOtro.Checked = True Then Fila_Estado("ELE_ESTADO") = "Reot" : Call AutogeneraFila() : Exit Sub
                If RDBAcepto.Checked Then Fila_Estado("ELE_ESTADO") = "Re" : Call AutogeneraFila() : Exit Sub
            End If
        Catch ex As Exception
            MsgBox("error en grilla")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.pnlImagen.Visible = False
    End Sub


    Private Sub pb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1.Click
        Me.pBox.BackgroundImage = Me.pb1.BackgroundImage
    End Sub

    Private Sub pb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb2.Click
        Me.pBox.BackgroundImage = Me.pb2.BackgroundImage
    End Sub

    Private Sub pb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb3.Click
        Me.pBox.BackgroundImage = Me.pb3.BackgroundImage
    End Sub

    Private Sub pb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb4.Click
        Me.pBox.BackgroundImage = Me.pb4.BackgroundImage
    End Sub
End Class
