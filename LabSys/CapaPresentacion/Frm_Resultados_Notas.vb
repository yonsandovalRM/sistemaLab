Public Class Frm_Resultados_Notas
    Inherits System.Windows.Forms.Form
    Private Notas, FilaGrilla As Integer

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents CmdObs4 As System.Windows.Forms.Button
    Friend WithEvents CmdObs1 As System.Windows.Forms.Button
    Friend WithEvents CmdObs2 As System.Windows.Forms.Button
    Friend WithEvents CmdObs3 As System.Windows.Forms.Button
    Friend WithEvents CmdNota1 As System.Windows.Forms.Button
    Friend WithEvents CmdNota6 As System.Windows.Forms.Button
    Friend WithEvents CmdNota5 As System.Windows.Forms.Button
    Friend WithEvents CmdNota4 As System.Windows.Forms.Button
    Friend WithEvents CmdNota3 As System.Windows.Forms.Button
    Friend WithEvents CmdNota2 As System.Windows.Forms.Button
    Friend WithEvents TxtNota1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota10 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota9 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota8 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota7 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota6 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DGNotas As System.Windows.Forms.DataGrid
    Friend WithEvents CmdSalirNotas As System.Windows.Forms.Button
    Friend WithEvents CmdAgrega As System.Windows.Forms.Button
    Friend WithEvents CmdGrabaN As System.Windows.Forms.Button
    Friend WithEvents CmdGrabaNotasMuestras As System.Windows.Forms.Button
    Friend WithEvents CmdEliminaNotas As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtNota4 = New System.Windows.Forms.TextBox
        Me.CmdObs4 = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtNota1 = New System.Windows.Forms.TextBox
        Me.CmdObs1 = New System.Windows.Forms.Button
        Me.CmdObs2 = New System.Windows.Forms.Button
        Me.TxtNota2 = New System.Windows.Forms.TextBox
        Me.TxtNota3 = New System.Windows.Forms.TextBox
        Me.CmdObs3 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TxtNota10 = New System.Windows.Forms.TextBox
        Me.CmdNota6 = New System.Windows.Forms.Button
        Me.TxtNota9 = New System.Windows.Forms.TextBox
        Me.CmdNota5 = New System.Windows.Forms.Button
        Me.TxtNota8 = New System.Windows.Forms.TextBox
        Me.CmdNota4 = New System.Windows.Forms.Button
        Me.TxtNota7 = New System.Windows.Forms.TextBox
        Me.TxtNota6 = New System.Windows.Forms.TextBox
        Me.TxtNota5 = New System.Windows.Forms.TextBox
        Me.CmdNota3 = New System.Windows.Forms.Button
        Me.CmdNota2 = New System.Windows.Forms.Button
        Me.CmdNota1 = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CmdAgrega = New System.Windows.Forms.Button
        Me.CmdEliminaNotas = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.CmdGrabaN = New System.Windows.Forms.Button
        Me.DGNotas = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CmdGrabaNotasMuestras = New System.Windows.Forms.Button
        Me.CmdSalirNotas = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtNota4)
        Me.Panel1.Controls.Add(Me.CmdObs4)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.TxtNota1)
        Me.Panel1.Controls.Add(Me.CmdObs1)
        Me.Panel1.Controls.Add(Me.CmdObs2)
        Me.Panel1.Controls.Add(Me.TxtNota2)
        Me.Panel1.Controls.Add(Me.TxtNota3)
        Me.Panel1.Controls.Add(Me.CmdObs3)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 184)
        Me.Panel1.TabIndex = 1
        '
        'TxtNota4
        '
        Me.TxtNota4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota4.Location = New System.Drawing.Point(56, 144)
        Me.TxtNota4.Multiline = True
        Me.TxtNota4.Name = "TxtNota4"
        Me.TxtNota4.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota4.TabIndex = 6
        Me.TxtNota4.Text = ""
        '
        'CmdObs4
        '
        Me.CmdObs4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdObs4.Location = New System.Drawing.Point(8, 144)
        Me.CmdObs4.Name = "CmdObs4"
        Me.CmdObs4.Size = New System.Drawing.Size(40, 24)
        Me.CmdObs4.TabIndex = 5
        Me.CmdObs4.Text = "O-4"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(8, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 16)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Observaciones"
        '
        'TxtNota1
        '
        Me.TxtNota1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota1.Location = New System.Drawing.Point(56, 24)
        Me.TxtNota1.Multiline = True
        Me.TxtNota1.Name = "TxtNota1"
        Me.TxtNota1.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota1.TabIndex = 2
        Me.TxtNota1.Text = ""
        '
        'CmdObs1
        '
        Me.CmdObs1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdObs1.Location = New System.Drawing.Point(8, 24)
        Me.CmdObs1.Name = "CmdObs1"
        Me.CmdObs1.Size = New System.Drawing.Size(40, 24)
        Me.CmdObs1.TabIndex = 0
        Me.CmdObs1.Text = "O-1"
        '
        'CmdObs2
        '
        Me.CmdObs2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdObs2.Location = New System.Drawing.Point(8, 64)
        Me.CmdObs2.Name = "CmdObs2"
        Me.CmdObs2.Size = New System.Drawing.Size(40, 23)
        Me.CmdObs2.TabIndex = 0
        Me.CmdObs2.Text = "O-2"
        '
        'TxtNota2
        '
        Me.TxtNota2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota2.Location = New System.Drawing.Point(56, 64)
        Me.TxtNota2.Multiline = True
        Me.TxtNota2.Name = "TxtNota2"
        Me.TxtNota2.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota2.TabIndex = 3
        Me.TxtNota2.Text = ""
        '
        'TxtNota3
        '
        Me.TxtNota3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota3.Location = New System.Drawing.Point(56, 104)
        Me.TxtNota3.Multiline = True
        Me.TxtNota3.Name = "TxtNota3"
        Me.TxtNota3.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota3.TabIndex = 4
        Me.TxtNota3.Text = ""
        '
        'CmdObs3
        '
        Me.CmdObs3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdObs3.Location = New System.Drawing.Point(8, 104)
        Me.CmdObs3.Name = "CmdObs3"
        Me.CmdObs3.Size = New System.Drawing.Size(40, 24)
        Me.CmdObs3.TabIndex = 1
        Me.CmdObs3.Text = "O-3"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtNota10)
        Me.Panel3.Controls.Add(Me.CmdNota6)
        Me.Panel3.Controls.Add(Me.TxtNota9)
        Me.Panel3.Controls.Add(Me.CmdNota5)
        Me.Panel3.Controls.Add(Me.TxtNota8)
        Me.Panel3.Controls.Add(Me.CmdNota4)
        Me.Panel3.Controls.Add(Me.TxtNota7)
        Me.Panel3.Controls.Add(Me.TxtNota6)
        Me.Panel3.Controls.Add(Me.TxtNota5)
        Me.Panel3.Controls.Add(Me.CmdNota3)
        Me.Panel3.Controls.Add(Me.CmdNota2)
        Me.Panel3.Controls.Add(Me.CmdNota1)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Location = New System.Drawing.Point(8, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(752, 264)
        Me.Panel3.TabIndex = 3
        '
        'TxtNota10
        '
        Me.TxtNota10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota10.Location = New System.Drawing.Point(56, 224)
        Me.TxtNota10.Multiline = True
        Me.TxtNota10.Name = "TxtNota10"
        Me.TxtNota10.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota10.TabIndex = 12
        Me.TxtNota10.Text = ""
        '
        'CmdNota6
        '
        Me.CmdNota6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNota6.Location = New System.Drawing.Point(8, 224)
        Me.CmdNota6.Name = "CmdNota6"
        Me.CmdNota6.Size = New System.Drawing.Size(40, 23)
        Me.CmdNota6.TabIndex = 11
        Me.CmdNota6.Text = "N-6"
        '
        'TxtNota9
        '
        Me.TxtNota9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota9.Location = New System.Drawing.Point(56, 184)
        Me.TxtNota9.Multiline = True
        Me.TxtNota9.Name = "TxtNota9"
        Me.TxtNota9.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota9.TabIndex = 10
        Me.TxtNota9.Text = ""
        '
        'CmdNota5
        '
        Me.CmdNota5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNota5.Location = New System.Drawing.Point(8, 184)
        Me.CmdNota5.Name = "CmdNota5"
        Me.CmdNota5.Size = New System.Drawing.Size(40, 23)
        Me.CmdNota5.TabIndex = 9
        Me.CmdNota5.Text = "N-5"
        '
        'TxtNota8
        '
        Me.TxtNota8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota8.Location = New System.Drawing.Point(56, 144)
        Me.TxtNota8.Multiline = True
        Me.TxtNota8.Name = "TxtNota8"
        Me.TxtNota8.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota8.TabIndex = 8
        Me.TxtNota8.Text = ""
        '
        'CmdNota4
        '
        Me.CmdNota4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNota4.Location = New System.Drawing.Point(8, 144)
        Me.CmdNota4.Name = "CmdNota4"
        Me.CmdNota4.Size = New System.Drawing.Size(40, 23)
        Me.CmdNota4.TabIndex = 7
        Me.CmdNota4.Text = "N-4"
        '
        'TxtNota7
        '
        Me.TxtNota7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota7.Location = New System.Drawing.Point(56, 104)
        Me.TxtNota7.Multiline = True
        Me.TxtNota7.Name = "TxtNota7"
        Me.TxtNota7.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota7.TabIndex = 6
        Me.TxtNota7.Text = ""
        '
        'TxtNota6
        '
        Me.TxtNota6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota6.Location = New System.Drawing.Point(56, 64)
        Me.TxtNota6.Multiline = True
        Me.TxtNota6.Name = "TxtNota6"
        Me.TxtNota6.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota6.TabIndex = 5
        Me.TxtNota6.Text = ""
        '
        'TxtNota5
        '
        Me.TxtNota5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota5.Location = New System.Drawing.Point(56, 24)
        Me.TxtNota5.Multiline = True
        Me.TxtNota5.Name = "TxtNota5"
        Me.TxtNota5.Size = New System.Drawing.Size(688, 32)
        Me.TxtNota5.TabIndex = 4
        Me.TxtNota5.Text = ""
        '
        'CmdNota3
        '
        Me.CmdNota3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNota3.Location = New System.Drawing.Point(8, 104)
        Me.CmdNota3.Name = "CmdNota3"
        Me.CmdNota3.Size = New System.Drawing.Size(40, 23)
        Me.CmdNota3.TabIndex = 3
        Me.CmdNota3.Text = "N-3"
        '
        'CmdNota2
        '
        Me.CmdNota2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNota2.Location = New System.Drawing.Point(8, 64)
        Me.CmdNota2.Name = "CmdNota2"
        Me.CmdNota2.Size = New System.Drawing.Size(40, 23)
        Me.CmdNota2.TabIndex = 2
        Me.CmdNota2.Text = "N-2"
        '
        'CmdNota1
        '
        Me.CmdNota1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNota1.Location = New System.Drawing.Point(8, 24)
        Me.CmdNota1.Name = "CmdNota1"
        Me.CmdNota1.Size = New System.Drawing.Size(40, 24)
        Me.CmdNota1.TabIndex = 1
        Me.CmdNota1.Text = "N-1"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(8, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Notas"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.CmdAgrega)
        Me.GroupBox5.Controls.Add(Me.CmdEliminaNotas)
        Me.GroupBox5.Controls.Add(Me.Button12)
        Me.GroupBox5.Controls.Add(Me.CmdGrabaN)
        Me.GroupBox5.Controls.Add(Me.DGNotas)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(752, 488)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'CmdAgrega
        '
        Me.CmdAgrega.Location = New System.Drawing.Point(312, 416)
        Me.CmdAgrega.Name = "CmdAgrega"
        Me.CmdAgrega.Size = New System.Drawing.Size(80, 24)
        Me.CmdAgrega.TabIndex = 5
        Me.CmdAgrega.Text = "Agregar"
        '
        'CmdEliminaNotas
        '
        Me.CmdEliminaNotas.Location = New System.Drawing.Point(416, 416)
        Me.CmdEliminaNotas.Name = "CmdEliminaNotas"
        Me.CmdEliminaNotas.Size = New System.Drawing.Size(80, 24)
        Me.CmdEliminaNotas.TabIndex = 4
        Me.CmdEliminaNotas.Text = "Eliminar"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(512, 416)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(80, 24)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "Salir"
        '
        'CmdGrabaN
        '
        Me.CmdGrabaN.Location = New System.Drawing.Point(208, 416)
        Me.CmdGrabaN.Name = "CmdGrabaN"
        Me.CmdGrabaN.Size = New System.Drawing.Size(80, 24)
        Me.CmdGrabaN.TabIndex = 1
        Me.CmdGrabaN.Text = "Grabar"
        '
        'DGNotas
        '
        Me.DGNotas.CaptionVisible = False
        Me.DGNotas.DataMember = ""
        Me.DGNotas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGNotas.Location = New System.Drawing.Point(8, 24)
        Me.DGNotas.Name = "DGNotas"
        Me.DGNotas.Size = New System.Drawing.Size(736, 368)
        Me.DGNotas.TabIndex = 0
        Me.DGNotas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DGNotas
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "NOTA_RESULTADO"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Id"
        Me.DataGridTextBoxColumn1.MappingName = "NOTARES_ID"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "NOTARES_DESCRIPCION"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 550
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Frec"
        Me.DataGridTextBoxColumn3.MappingName = "NOTARES_FREC"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 40
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nivel"
        Me.DataGridTextBoxColumn4.MappingName = "NOTARES_NIVEL"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 40
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'CmdGrabaNotasMuestras
        '
        Me.CmdGrabaNotasMuestras.Location = New System.Drawing.Point(304, 472)
        Me.CmdGrabaNotasMuestras.Name = "CmdGrabaNotasMuestras"
        Me.CmdGrabaNotasMuestras.Size = New System.Drawing.Size(112, 24)
        Me.CmdGrabaNotasMuestras.TabIndex = 5
        Me.CmdGrabaNotasMuestras.Text = "Graba"
        '
        'CmdSalirNotas
        '
        Me.CmdSalirNotas.Location = New System.Drawing.Point(456, 472)
        Me.CmdSalirNotas.Name = "CmdSalirNotas"
        Me.CmdSalirNotas.Size = New System.Drawing.Size(112, 24)
        Me.CmdSalirNotas.TabIndex = 6
        Me.CmdSalirNotas.Text = "Salir"
        '
        'Frm_Resultados_Notas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 509)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdGrabaNotasMuestras)
        Me.Controls.Add(Me.CmdSalirNotas)
        Me.Name = "Frm_Resultados_Notas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Resultados_Notas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DGNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CmdObs1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdObs1.Click, CmdObs2.Click, CmdObs3.Click, _
                                                                                                  CmdObs4.Click, CmdNota1.Click, CmdNota2.Click, _
                                                                                                  CmdNota3.Click, CmdNota4.Click, CmdNota5.Click, _
                                                                                                  CmdNota6.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim FILA_NOTA As DataRow
        Dim Nivel As String

        If sender Is CmdObs1 Then Notas = 1 : Nivel = "O"
        If sender Is CmdObs2 Then Notas = 2 : Nivel = "O"
        If sender Is CmdObs3 Then Notas = 3 : Nivel = "O"
        If sender Is CmdObs4 Then Notas = 4 : Nivel = "O"
        If sender Is CmdNota1 Then Notas = 5 : Nivel = "N"
        If sender Is CmdNota2 Then Notas = 6 : Nivel = "N"
        If sender Is CmdNota3 Then Notas = 7 : Nivel = "N"
        If sender Is CmdNota4 Then Notas = 8 : Nivel = "N"
        If sender Is CmdNota5 Then Notas = 9 : Nivel = "N"
        If sender Is CmdNota6 Then Notas = 10 : Nivel = "N"

        Cjto_Resultados1.Tables("NOTA_RESULTADO").Clear()
        With SP
            .Inicializar()
            .AgregarParametro("@Nivel", Nivel, SqlDbType.NVarChar)
            .EjecutarQueryDt("usp_SelectResultadosNotas", Cjto_Resultados1, "NOTA_RESULTADO")
        End With
        GroupBox5.Visible = True
    End Sub

    Private Sub Frm_Resultados_Notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim FILA_NOTA As DataRow
        Call Anti_Elimina_lineas()
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectResultadosNotasMuestra")
        End With

        For Each FILA_NOTA In ds.Tables(0).Rows
            If IsDBNull(FILA_NOTA("NOTA_POS")) = False Then
                Select Case FILA_NOTA("NOTA_POS")
                    Case 1
                        TxtNota1.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 2
                        TxtNota2.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 3
                        TxtNota3.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 4
                        TxtNota4.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 5
                        TxtNota5.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 6
                        TxtNota6.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 7
                        TxtNota7.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 8
                        TxtNota8.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 9
                        TxtNota9.Text = FILA_NOTA("NOTA_DESCRIPCION")
                    Case 10
                        TxtNota10.Text = FILA_NOTA("NOTA_DESCRIPCION")
                End Select
            End If
        Next
    End Sub
    Private Sub Anti_Elimina_lineas()
        DGNotas.DataSource = Cjto_Resultados1.Tables("NOTA_RESULTADO")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        GroupBox5.Visible = False
    End Sub

    Private Sub DGNotas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGNotas.DoubleClick
        Dim Es_Combo As Boolean
        Dim fila_d As Integer
        Dim FILA_DATAROW As DataRow
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        fila_d = myGrid.CurrentCell.RowNumber
        If GroupBox5.Visible = True Then
            Try
                FILA_DATAROW = Cjto_Resultados1.Tables("NOTA_RESULTADO").Rows(fila_d)
                Select Case Notas
                    Case 1
                        TxtNota1.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 2
                        TxtNota2.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 3
                        TxtNota3.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 4
                        TxtNota4.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 5
                        TxtNota5.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 6
                        TxtNota6.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 7
                        TxtNota7.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 8
                        TxtNota8.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 9
                        TxtNota9.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                    Case 10
                        TxtNota10.Text = FILA_DATAROW("NOTARES_DESCRIPCION")
                End Select
            Catch ex As Exception
            End Try
        End If
        GroupBox5.Visible = False
    End Sub

    Private Sub CmdAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgrega.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DGNotas.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DGNotas.CurrentCell = mycell
    End Sub

    Private Sub CmdSalirNotas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdSalirNotas.Click
        Me.Close()
    End Sub

    
    Private Sub CmdGrabaNotasMuestras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabaNotasMuestras.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 1, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota1.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 2, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota2.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 3, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota3.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 4, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota4.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 5, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota5.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 6, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota6.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 7, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota7.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 8, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota8.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 9, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota9.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", ResultadosMuestrayOrden, SqlDbType.Int)
            .AgregarParametro("@Pos", 10, SqlDbType.Int)
            .AgregarParametro("@Descripcion", TxtNota10.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_GrabaResultadosNotasMuestras")
        End With

        MsgBox("Grabación finalizada", MsgBoxStyle.Exclamation)

    End Sub


    Private Sub CmdGrabaN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabaN.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Nota As DataRow
        For Each Fila_Nota In Cjto_Resultados1.Tables("NOTA_RESULTADO").Rows
            With SP
                .Inicializar()
                .AgregarParametro("@Id", Fila_Nota("NOTARES_ID"), SqlDbType.Char)
                .AgregarParametro("@Descripcion", Fila_Nota("NOTARES_DESCRIPCION"), SqlDbType.NVarChar)
                .AgregarParametro("@Frec", Fila_Nota("NOTARES_FREC"), SqlDbType.Char)
                .AgregarParametro("@Nivel", Fila_Nota("NOTARES_NIVEL"), SqlDbType.NVarChar)
                .EjecutarQuery("usp_GrabaResultadosNotas")
            End With
        Next

        GroupBox5.Visible = False

    End Sub

   
    Private Sub CmdEliminaNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminaNotas.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Nota As DataRow
        Dim respuesta As MsgBoxResult
        Dim IdElim As String
        FilaGrilla = DGNotas.CurrentCell.RowNumber()
        IdElim = DGNotas.Item(FilaGrilla, 0)
        respuesta = MsgBox("Esta seguro de eliminar el ID : " & IdElim, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            With SP
                .Inicializar()
                .AgregarParametro("@Id", IdElim, SqlDbType.Char)
                .EjecutarQuery("usp_DeleteResultadosNotas")
            End With
        End If
        GroupBox5.Visible = False
    End Sub
End Class
