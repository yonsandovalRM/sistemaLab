Imports System.Data.SqlClient
Public Class Frm_Modificacion_Estados
    Inherits System.Windows.Forms.Form
    Private ffi As Integer

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
    Friend WithEvents TxtOrden As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents RDBEleRe As System.Windows.Forms.RadioButton
    Friend WithEvents RDBElexA As System.Windows.Forms.RadioButton
    Friend WithEvents RDBEleNulo As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RDBElexR As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RDBDupxR As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RDBDupRe As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblNLab As System.Windows.Forms.Label
    Friend WithEvents LblCodAna As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DTGDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents DTGElementos As System.Windows.Forms.DataGrid
    Friend WithEvents RDBDupxA As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ElPanel1 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents RdbEleOtro As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtOrden = New System.Windows.Forms.TextBox
        Me.DTGDetalle = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DTGElementos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.RdbEleOtro = New System.Windows.Forms.RadioButton
        Me.RDBDupRe = New System.Windows.Forms.RadioButton
        Me.RDBDupxA = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.RDBEleRe = New System.Windows.Forms.RadioButton
        Me.RDBElexA = New System.Windows.Forms.RadioButton
        Me.RDBEleNulo = New System.Windows.Forms.RadioButton
        Me.RDBDupxR = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.RDBElexR = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblNLab = New System.Windows.Forms.Label
        Me.LblCodAna = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ElPanel1 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        CType(Me.DTGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° OT"
        '
        'TxtOrden
        '
        Me.TxtOrden.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOrden.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrden.Location = New System.Drawing.Point(72, 24)
        Me.TxtOrden.Name = "TxtOrden"
        Me.TxtOrden.Size = New System.Drawing.Size(72, 21)
        Me.TxtOrden.TabIndex = 1
        '
        'DTGDetalle
        '
        Me.DTGDetalle.CaptionVisible = False
        Me.DTGDetalle.DataMember = ""
        Me.DTGDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGDetalle.Location = New System.Drawing.Point(8, 96)
        Me.DTGDetalle.Name = "DTGDetalle"
        Me.DTGDetalle.Size = New System.Drawing.Size(800, 448)
        Me.DTGDetalle.TabIndex = 43
        Me.DTGDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGDetalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MDETORD"
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "T.Muestra"
        Me.DataGridTextBoxColumn7.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 70
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "N° Lab"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Cod.Ana"
        Me.DataGridTextBoxColumn2.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 60
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn3.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 500
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Estado"
        Me.DataGridTextBoxColumn8.MappingName = "NLAB_ESTADO"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 60
        '
        'DTGElementos
        '
        Me.DTGElementos.CaptionVisible = False
        Me.DTGElementos.DataMember = ""
        Me.DTGElementos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGElementos.Location = New System.Drawing.Point(824, 96)
        Me.DTGElementos.Name = "DTGElementos"
        Me.DTGElementos.Size = New System.Drawing.Size(240, 448)
        Me.DTGElementos.TabIndex = 44
        Me.DTGElementos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DTGElementos
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "MESTELE"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Cod.Ele."
        Me.DataGridTextBoxColumn4.MappingName = "ELE_CODIGO"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn5.MappingName = "ELE_NOMBRE"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Estado"
        Me.DataGridTextBoxColumn6.MappingName = "ELE_ESTADO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 60
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.RdbEleOtro)
        Me.GroupBox7.Controls.Add(Me.RDBDupRe)
        Me.GroupBox7.Controls.Add(Me.RDBDupxA)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.RDBEleRe)
        Me.GroupBox7.Controls.Add(Me.RDBElexA)
        Me.GroupBox7.Controls.Add(Me.RDBEleNulo)
        Me.GroupBox7.Controls.Add(Me.RDBDupxR)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.RDBElexR)
        Me.GroupBox7.Location = New System.Drawing.Point(1092, 96)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(168, 344)
        Me.GroupBox7.TabIndex = 57
        Me.GroupBox7.TabStop = False
        '
        'RdbEleOtro
        '
        Me.RdbEleOtro.Location = New System.Drawing.Point(8, 128)
        Me.RdbEleOtro.Name = "RdbEleOtro"
        Me.RdbEleOtro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbEleOtro.Size = New System.Drawing.Size(128, 16)
        Me.RdbEleOtro.TabIndex = 51
        Me.RdbEleOtro.Text = "Otro prom,mejoras...)"
        '
        'RDBDupRe
        '
        Me.RDBDupRe.Location = New System.Drawing.Point(16, 240)
        Me.RDBDupRe.Name = "RDBDupRe"
        Me.RDBDupRe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBDupRe.Size = New System.Drawing.Size(120, 16)
        Me.RDBDupRe.TabIndex = 50
        Me.RDBDupRe.Text = "(Revisado (DuRe"
        '
        'RDBDupxA
        '
        Me.RDBDupxA.Location = New System.Drawing.Point(8, 192)
        Me.RDBDupxA.Name = "RDBDupxA"
        Me.RDBDupxA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBDupxA.Size = New System.Drawing.Size(128, 16)
        Me.RDBDupxA.TabIndex = 49
        Me.RDBDupxA.Text = "(Por Análizar (DuxA"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label8.Location = New System.Drawing.Point(56, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Duplicado"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Modificar Todos"
        '
        'RDBEleRe
        '
        Me.RDBEleRe.Location = New System.Drawing.Point(24, 80)
        Me.RDBEleRe.Name = "RDBEleRe"
        Me.RDBEleRe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBEleRe.Size = New System.Drawing.Size(112, 16)
        Me.RDBEleRe.TabIndex = 42
        Me.RDBEleRe.Text = "(Revisado (Re"
        '
        'RDBElexA
        '
        Me.RDBElexA.Location = New System.Drawing.Point(24, 32)
        Me.RDBElexA.Name = "RDBElexA"
        Me.RDBElexA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBElexA.Size = New System.Drawing.Size(112, 16)
        Me.RDBElexA.TabIndex = 43
        Me.RDBElexA.Text = "(Por Análizar (xA"
        '
        'RDBEleNulo
        '
        Me.RDBEleNulo.Location = New System.Drawing.Point(40, 104)
        Me.RDBEleNulo.Name = "RDBEleNulo"
        Me.RDBEleNulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBEleNulo.Size = New System.Drawing.Size(96, 16)
        Me.RDBEleNulo.TabIndex = 45
        Me.RDBEleNulo.Text = "Nula"
        '
        'RDBDupxR
        '
        Me.RDBDupxR.Location = New System.Drawing.Point(16, 216)
        Me.RDBDupxR.Name = "RDBDupxR"
        Me.RDBDupxR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBDupxR.Size = New System.Drawing.Size(120, 16)
        Me.RDBDupxR.TabIndex = 46
        Me.RDBDupxR.Text = "(Por Revisar (DuxR"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label7.Location = New System.Drawing.Point(32, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Estado Elementos"
        '
        'RDBElexR
        '
        Me.RDBElexR.Location = New System.Drawing.Point(16, 56)
        Me.RDBElexR.Name = "RDBElexR"
        Me.RDBElexR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBElexR.Size = New System.Drawing.Size(120, 16)
        Me.RDBElexR.TabIndex = 44
        Me.RDBElexR.Text = "(Por Revisar (xR"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 608)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Grabar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(640, 608)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "Salir"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Nº Laboratorios"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(814, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "N° Lab :"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(942, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Cod.Ana :"
        '
        'LblNLab
        '
        Me.LblNLab.BackColor = System.Drawing.SystemColors.Info
        Me.LblNLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNLab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNLab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNLab.Location = New System.Drawing.Point(872, 72)
        Me.LblNLab.Name = "LblNLab"
        Me.LblNLab.Size = New System.Drawing.Size(64, 16)
        Me.LblNLab.TabIndex = 63
        '
        'LblCodAna
        '
        Me.LblCodAna.BackColor = System.Drawing.SystemColors.Info
        Me.LblCodAna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodAna.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodAna.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCodAna.Location = New System.Drawing.Point(1008, 72)
        Me.LblCodAna.Name = "LblCodAna"
        Me.LblCodAna.Size = New System.Drawing.Size(48, 16)
        Me.LblCodAna.TabIndex = 64
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"xA", "xR", "Re", "Nula", "DuxA", "DuxR", "DuRe", "Reot"})
        Me.ComboBox1.Location = New System.Drawing.Point(832, 344)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 65
        Me.ComboBox1.Visible = False
        '
        'ElPanel1
        '
        Me.ElPanel1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel1.Controls.Add(Me.GroupBox7)
        Me.ElPanel1.Controls.Add(Me.Label1)
        Me.ElPanel1.Controls.Add(Me.Label9)
        Me.ElPanel1.Controls.Add(Me.Label11)
        Me.ElPanel1.Controls.Add(Me.Label10)
        Me.ElPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel1.Name = "ElPanel1"
        Me.ElPanel1.Size = New System.Drawing.Size(1272, 677)
        Me.ElPanel1.TabIndex = 66
        '
        'Frm_Modificacion_Estados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1272, 677)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblCodAna)
        Me.Controls.Add(Me.LblNLab)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DTGElementos)
        Me.Controls.Add(Me.DTGDetalle)
        Me.Controls.Add(Me.TxtOrden)
        Me.Controls.Add(Me.ElPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Modificacion_Estados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion de Estados"
        CType(Me.DTGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub DTGElementos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGElementos.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim Fila_Grilla_C As Integer
        Dim muestra As Boolean = False
        Dim myGriC As DataGrid
        myGriC = CType(sender, DataGrid)
        ffi = myGriC.CurrentCell.RowNumber
        If ComboBox1.Visible = True Then ComboBox1.Visible = False
        If myGriC.CurrentCell.ColumnNumber <> 2 Then Exit Sub
        Dim CeldaAlto As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).X + myGriC.Left
        Dim Posiciony As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Y + myGriC.Top
        ComboBox1.Left = Posicionx
        ComboBox1.Top = Posiciony
        ComboBox1.Height = CeldaAlto
        ComboBox1.Width = CeldaAncho
        ComboBox1.Visible = True
        ComboBox1.Text = ""
        ComboBox1.Enabled = True
        ComboBox1.Focus()
        ComboBox1.SelectionStart = 1
        Try
            If IsDBNull(myGriC.Item(ffi, 2)) = False Then ComboBox1.Text = myGriC.Item(ffi, 2)
        Catch ex As Exception
        End Try
yam:
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If ComboBox1.Text <> "" Then
                DTGElementos.Item(ffi, 2) = ComboBox1.Text
                mycell.ColumnNumber = 1
                mycell.RowNumber = ffi
                DTGElementos.CurrentCell = mycell
            End If
        End If
    End Sub

    Private Sub Frm_Modificacion_Estados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cjto_Tablas1.Tables("MDETORD").Clear()
        Cjto_Tablas1.Tables("MESTELE").Clear()
        Call Anti_Elimina_lineas()
    End Sub
    Private Sub Anti_Elimina_lineas()
        Me.DTGDetalle.DataSource = Cjto_Tablas1.Tables("MDETORD")
        Me.DTGElementos.DataSource = Cjto_Tablas1.Tables("MESTELE")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DTGDetalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGDetalle.Click
        Dim query As String
        Dim MCod As Integer
        Dim BusEle(1) As Object
        Dim Fila, Fila_Ele As DataRow
        Dim con As New SqlConnection(Conexion1)
        Dim numFila, MNLab As Integer
        Dim DbMan As DbManager
        numFila = Me.DTGDetalle.CurrentCell.RowNumber
        Try
            MNLab = DTGDetalle.Item(numFila, 1)
        Catch ex As Exception
            GoTo NADA
        End Try
        MCod = CDbl(Mid(DTGDetalle.Item(numFila, 2), 1, 1) & "000")
        Me.LblNLab.Text = MNLab
        Me.LblCodAna.Text = DTGDetalle.Item(numFila, 2)
        Cjto_Tablas1.Tables("MESTELE").Clear()
        con.Open()
        query = "Select ELE_CODIGO,ELE_ESTADO from DIGITA_RESULTADOS where OT_NUMERO = " & CInt(TxtOrden.Text) & " AND OT_NLAB=" & MNLab
        Dim reader1 As SqlDataReader
        Dim command1 As New SqlCommand(query, con)
        reader1 = command1.ExecuteReader
        While reader1.Read()
            Fila = Cjto_Tablas1.Tables("MESTELE").NewRow
            Fila("ELE_CODIGO") = reader1.GetString(0)

            BusEle(0) = MCod
            BusEle(1) = reader1.GetString(0)
            Fila_Ele = Cjto_Tablas1.Tables("ELEMENTO").Rows.Find(BusEle)

            Fila("ELE_NOMBRE") = Fila_Ele("ELE_NOMBRE")

            Fila("ELE_ESTADO") = reader1.GetString(1)

            Try
                Cjto_Tablas1.Tables("MESTELE").Rows.Add(Fila)
            Catch ex As Exception
            End Try
        End While
        con.Close()
        Cjto_Tablas1.Tables("MESTELE").AcceptChanges()
NADA:
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Fila_Ele As DataRow
        Dim EstNue As String
        EstNue = ""
        If RDBElexA.Checked = True Then EstNue = "xA"
        If RDBElexR.Checked = True Then EstNue = "xR"
        If RDBEleRe.Checked = True Then EstNue = "Re"
        If RDBEleNulo.Checked = True Then EstNue = "Nula"
        If RDBDupxA.Checked = True Then EstNue = "DuxA"
        If RDBDupxR.Checked = True Then EstNue = "DuxR"
        If RDBDupRe.Checked = True Then EstNue = "DuRe"
        If RdbEleOtro.Checked = True Then EstNue = "Reot"

        If EstNue <> "" Then
            For Each Fila_Ele In Cjto_Tablas1.Tables("MESTELE").Rows
                Fila_Ele("ELE_ESTADO") = EstNue
            Next
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim MCod As Integer
        Dim Fila_Ele As DataRow
        Dim Estado_Original As String

        MCod = 0
        If Me.LblCodAna.Text <> "" Then
            MCod = CInt(Mid(LblCodAna.Text, 1, 1) & "000")
        End If

        For Each Fila_Ele In Cjto_Tablas1.Tables("MESTELE").Rows
            Estado_Original = Fila_Ele("ELE_ESTADO", DataRowVersion.Original)
            If Fila_Ele("ELE_ESTADO") <> Estado_Original Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@TMuestra", MCod, SqlDbType.Int)
                    .AgregarParametro("@NLab", CInt(Me.LblNLab.Text), SqlDbType.Int)
                    .AgregarParametro("@CodEle", Fila_Ele("ELE_CODIGO"), SqlDbType.NVarChar)
                    .AgregarParametro("@EstEle", Fila_Ele("ELE_ESTADO"), SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateModificaEstadoElementos")
                End With
            End If
        Next
        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub TxtOrden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOrden.KeyPress
        If e.KeyChar = Chr(13) Then
            Cjto_Tablas1.Tables("MDETORD").Clear()
            Cjto_Tablas1.Tables("MESTELE").Clear()
            If TxtOrden.Text <> "" Then Call CargaNLab()
        End If
    End Sub
    Private Sub CargaNLab()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Fila_Mod, Fila_Data As DataRow

        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
    End Sub

    Private Sub CargaTabla(ByVal SP As Procedimiento_Almacenado, ByVal ds As DataSet)
        Dim Fila_Mod, Fila_Data As DataRow
        For Each Fila_Mod In ds.Tables(0).Rows
            Fila_Data = Cjto_Tablas1.Tables("MDETORD").NewRow
            Fila_Data.Item("TMU_CODIGO") = Fila_Mod("TMU_CODIGO")
            Fila_Data.Item("OT_NLAB") = Fila_Mod("OT_NLAB")
            With SP
                .Inicializar()
                .AgregarParametro("@CodAna", Fila_Mod("ANA_CODIGO"), SqlDbType.Float)
                ds = .EjecutarQuery("usp_SelectModificaAna_Analisis")
            End With
            Fila_Data.Item("ANA_CODIGO") = Fila_Mod("ANA_CODIGO")

            If IsDBNull(ds.Tables(0).Rows(0).Item("ANA_ANALISIS")) = False Then
                Fila_Data.Item("ANA_ANALISIS") = ds.Tables(0).Rows(0).Item("ANA_ANALISIS")
            Else
                Fila_Data.Item("ANA_ANALISIS") = ""
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("TIPO_COD")) = False Then
                If ds.Tables(0).Rows(0).Item("TIPO_COD") = "JA" Then
                    Fila_Data.Item("ANA_ANALISIS") = BuscaDescripcionJocker(Fila_Data.Item("ANA_CODIGO"), Fila_Data.Item("TMU_CODIGO"), Fila_Data.Item("OT_NLAB"))
                End If
            End If

            Fila_Data.Item("NLAB_ESTADO") = Fila_Mod("NLAB_ESTADO")
            Try
                Cjto_Tablas1.Tables("MDETORD").Rows.Add(Fila_Data)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Function BuscaDescripcionJocker(ByVal AnaCod As Double, ByVal TMuestra As Integer, ByVal NLab As Integer) As String
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        With SP
            .Inicializar()
            .AgregarParametro("@CodAna", AnaCod, SqlDbType.Float)
            .AgregarParametro("@TMuestra", TMuestra, SqlDbType.Int)
            .AgregarParametro("@NLab", NLab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaJocker")
        End With

        If IsDBNull(ds.Tables(0).Rows(0).Item("ANA_ANALISIS")) = False Then
            Return ds.Tables(0).Rows(0).Item("ANA_ANALISIS")
        Else
            Return ""
        End If

    End Function
End Class
