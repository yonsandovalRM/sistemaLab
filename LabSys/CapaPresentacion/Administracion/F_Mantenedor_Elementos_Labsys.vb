Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class F_Mantenedor_Elementos_Labsys
    Inherits System.Windows.Forms.Form
    Private Cod_Muestra As Integer
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    'Dim WithEvents oPDFmaker As PDFmaker.CreatePDF
    'Dim AppPath As String = Application.StartupPath

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents CBMuestra As ComboboxAutoCompletar.AutoCompletarComboBox
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
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DTGElemento As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TT As LabSys.Cjto_Tablas
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CBMuestra As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TT = New LabSys.Cjto_Tablas
        Me.DTGElemento = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.CBMuestra = New System.Windows.Forms.ComboBox
        CType(Me.TT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGElemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TT
        '
        Me.TT.DataSetName = "Cjto_Tablas"
        Me.TT.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTGElemento
        '
        Me.DTGElemento.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGElemento.CaptionVisible = False
        Me.DTGElemento.DataMember = "ELEMENTO_LABSYS"
        Me.DTGElemento.DataSource = Me.TT
        Me.DTGElemento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGElemento.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGElemento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTGElemento.Location = New System.Drawing.Point(8, 32)
        Me.DTGElemento.Name = "DTGElemento"
        Me.DTGElemento.Size = New System.Drawing.Size(1240, 896)
        Me.DTGElemento.TabIndex = 0
        Me.DTGElemento.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGElemento
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn24})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ELEMENTO_LABSYS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cod.Clave"
        Me.DataGridTextBoxColumn1.MappingName = "ELE_CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre Despliege"
        Me.DataGridTextBoxColumn2.MappingName = "ELE_NOMBRE"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 107
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Simbolo"
        Me.DataGridTextBoxColumn3.MappingName = "ELE_SIMBOLO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 45
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn4.MappingName = "ELE_UNIDAD"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Cod.Desplige"
        Me.DataGridTextBoxColumn5.MappingName = "ELE_COD_DES"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Priori"
        Me.DataGridTextBoxColumn15.MappingName = "ELE_PRIORIDAD"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Bla-Ent"
        Me.DataGridTextBoxColumn6.MappingName = "ELE_TAM_BLENTERO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 45
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Bla-Dec"
        Me.DataGridTextBoxColumn7.MappingName = "ELE_TAM_BLDECIMAL"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 45
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Fac-Ent"
        Me.DataGridTextBoxColumn8.MappingName = "ELE_TAM_FAENTERO"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 45
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Fac-Dec"
        Me.DataGridTextBoxColumn9.MappingName = "ELE_TAM_FADECIMAL"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 45
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Lec-Ent"
        Me.DataGridTextBoxColumn10.MappingName = "ELE_TAM_LEENTERO"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 45
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Lec-Dec"
        Me.DataGridTextBoxColumn11.MappingName = "ELE_TAM_LEDECIMAL"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 46
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Res-Ent"
        Me.DataGridTextBoxColumn12.MappingName = "ELE_TAM_REENTERO"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 45
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "T-Masc"
        Me.DataGridTextBoxColumn13.MappingName = "ELE_MASCARA"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 49
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Nombre Formula"
        Me.DataGridTextBoxColumn14.MappingName = "ELE_CAL_FORMULA"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 150
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "P.Atomico"
        Me.DataGridTextBoxColumn20.MappingName = "ELE_PESOATOMICO"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 50
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Priori2"
        Me.DataGridTextBoxColumn17.MappingName = "ELE_PRIORIDAD2"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 50
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Planilla Analista"
        Me.DataGridTextBoxColumn16.MappingName = "ELE_PLANILLA"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Nombre Formato Res."
        Me.DataGridTextBoxColumn18.MappingName = "ELE_FORMATO_RES"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 125
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Frec."
        Me.DataGridTextBoxColumn19.MappingName = "ELE_FRECUENCIA"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 50
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "SubTitulo Despliege"
        Me.DataGridTextBoxColumn21.MappingName = "ELE_TITULO_RES"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 150
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Calculo"
        Me.DataGridTextBoxColumn22.MappingName = "ELE_COMENTARIO"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 250
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Datos entrada calculo / Notas"
        Me.DataGridTextBoxColumn23.MappingName = "ELE_COMENTARIO1"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 700
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Formula Calculo Factor"
        Me.DataGridTextBoxColumn25.MappingName = "ELE_COMENTARIO2"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 550
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Lim.Detec"
        Me.DataGridTextBoxColumn24.MappingName = "ELE_LIMITE_DETEC"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 60
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1080, 952)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Eliminar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(904, 952)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Agregar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(816, 952)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Grabar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Muestra"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(992, 952)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Imprimir"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1168, 952)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 24)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Salir"
        '
        'CBMuestra
        '
        Me.CBMuestra.FormattingEnabled = True
        Me.CBMuestra.Location = New System.Drawing.Point(78, 6)
        Me.CBMuestra.Name = "CBMuestra"
        Me.CBMuestra.Size = New System.Drawing.Size(121, 21)
        Me.CBMuestra.TabIndex = 9
        '
        'F_Mantenedor_Elementos_Labsys
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.CBMuestra)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTGElemento)
        Me.Name = "F_Mantenedor_Elementos_Labsys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Mantenedor_Elementos_Labsys"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGElemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Mantenedor_Elementos_Labsys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fila As DataRow
        Call Anti_Elimina()
        For Each fila In Cjto_Tablas1.Tables("MUESTRA").Rows
            CBMuestra.Items.Add(fila("TMU_MUESTRA"))
        Next
        CBMuestra.Text = ""
    End Sub
    Private Sub Anti_Elimina()
        DTGElemento.DataSource = Cjto_Tablas1.Tables("ELEMENTO_LABSYS")
    End Sub

    Private Sub CBMuestra_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBMuestra.SelectedValueChanged
        Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Clear()
        If CBMuestra.Text = "FOLIAR" Then Cod_Muestra = 1000
        If CBMuestra.Text = "OTROS TEJIDOS" Then Cod_Muestra = 2000
        If CBMuestra.Text = "AGUA" Then Cod_Muestra = 3000
        If CBMuestra.Text = "SUELO" Then Cod_Muestra = 4000
        If CBMuestra.Text = "FERTILIZANTES QUIMICOS" Then Cod_Muestra = 5000
        If CBMuestra.Text = "FERTILIZANTES ORGANICOS" Then Cod_Muestra = 6000

        Dim Test1 As DbManager = New DbManager("ELEMENTO_LABSYS", Conexion1)
        Dim query1 As String = "Select * from ELEMENTO WHERE TMU_CODIGO=" & Cod_Muestra & " ORDER BY ELE_PRIORIDAD"
        Test1.Selecccionar(Cjto_Tablas1, query1)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DTGElemento.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DTGElemento.CurrentCell = mycell
    End Sub

    Private Sub Graba_Todas()
        Dim FILA_DATAROW, dr As DataRow
        Dim ana_codigo, ana_neto As Double
        Dim fila, tmu_codigo, sub_codigo As Integer
        Dim Tmu_Codigo_original, Costo, Factor As Integer
        Dim Ele_codigo_original As String
        Dim con As New SqlConnection(Conexion1)
        Dim consulta_nota, consulta_nota2 As String
        con.Open()
        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Rows
            If FILA_DATAROW("ELE_CODIGO") = "XXX" Then
                ana_codigo = 0
            End If
            If FILA_DATAROW.RowState = DataRowState.Added Then
                If IsDBNull(FILA_DATAROW("ELE_COSTO")) = True Then FILA_DATAROW("ELE_COSTO") = 0
                If IsDBNull(FILA_DATAROW("ELE_FACTOR_PROPU")) = True Then FILA_DATAROW("ELE_FACTOR_PROPU") = 0
                If IsDBNull(FILA_DATAROW("ELE_PESOATOMICO")) = True Then FILA_DATAROW("ELE_PESOATOMICO") = 0
                If IsDBNull(FILA_DATAROW("ELE_PRIORIDAD2")) = True Then FILA_DATAROW("ELE_PRIORIDAD2") = 0

                consulta_nota = "INSERT INTO ELEMENTO (TMU_CODIGO,ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD," & _
                                "ELE_COD_DES,ELE_TAM_BLENTERO,ELE_TAM_BLDECIMAL,ELE_TAM_FAENTERO,ELE_TAM_FADECIMAL," & _
                                "ELE_TAM_LEENTERO,ELE_TAM_LEDECIMAL,ELE_TAM_REENTERO,ELE_MASCARA,ELE_CAL_FORMULA," & _
                                "ELE_CAL_FACTOR,ELE_PRIORIDAD,ELE_COSTO,ELE_PLANILLA,ELE_PRIORIDAD2,ELE_FORMATO_RES," & _
                                "ELE_FRECUENCIA,ELE_PESOATOMICO,ELE_FACTOR_PROPU,ELE_TITULO_RES,ELE_COMENTARIO,ELE_COMENTARIO1,ELE_LIMITE_DETEC) VALUES (" & _
                                Cod_Muestra & ",'" & FILA_DATAROW("ELE_CODIGO") & "','" & _
                                FILA_DATAROW("ELE_NOMBRE") & "','" & FILA_DATAROW("ELE_SIMBOLO") & "','" & _
                                FILA_DATAROW("ELE_UNIDAD") & "','" & FILA_DATAROW("ELE_COD_DES") & "'," & _
                                FILA_DATAROW("ELE_TAM_BLENTERO") & "," & FILA_DATAROW("ELE_TAM_BLDECIMAL") & "," & _
                                FILA_DATAROW("ELE_TAM_FAENTERO") & "," & FILA_DATAROW("ELE_TAM_FADECIMAL") & "," & _
                                FILA_DATAROW("ELE_TAM_LEENTERO") & "," & FILA_DATAROW("ELE_TAM_LEDECIMAL") & "," & _
                                FILA_DATAROW("ELE_TAM_REENTERO") & "," & FILA_DATAROW("ELE_MASCARA") & ",'" & _
                                FILA_DATAROW("ELE_CAL_FORMULA") & "','" & FILA_DATAROW("ELE_CAL_FACTOR") & "'," & FILA_DATAROW("ELE_PRIORIDAD") & "," & _
                                FILA_DATAROW("ELE_COSTO") & ",'" & FILA_DATAROW("ELE_PLANILLA") & "'," & _
                                FILA_DATAROW("ELE_PRIORIDAD2") & ",'" & FILA_DATAROW("ELE_FORMATO_RES") & "','" & _
                                FILA_DATAROW("ELE_FRECUENCIA") & "'," & FILA_DATAROW("ELE_PESOATOMICO") & "," & _
                                FILA_DATAROW("ELE_FACTOR_PROPU") & ",'" & FILA_DATAROW("ELE_TITULO_RES") & "','" & _
                                FILA_DATAROW("ELE_COMENTARIO") & "','" & FILA_DATAROW("ELE_COMENTARIO1") & "','" & _
                                FILA_DATAROW("ELE_COMENTARIO2") & "','" & FILA_DATAROW("ELE_LIMITE_DETEC") & "')"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                Catch ex As Exception
                    MsgBox("Largo de Nombre Sobrepasa el Limite (35 caracteres) o falta ingresar campos númericos")
                End Try
            End If
        Next

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                Tmu_Codigo_original = FILA_DATAROW("TMU_CODIGO", DataRowVersion.Original)
                Ele_codigo_original = FILA_DATAROW("ELE_CODIGO", DataRowVersion.Original)
                If IsDBNull(FILA_DATAROW("ELE_COSTO")) = True Then FILA_DATAROW("ELE_COSTO") = 0
                If IsDBNull(FILA_DATAROW("ELE_FACTOR_PROPU")) = True Then FILA_DATAROW("ELE_FACTOR_PROPU") = 0
                If IsDBNull(FILA_DATAROW("ELE_PESOATOMICO")) = True Then FILA_DATAROW("ELE_PESOATOMICO") = 0
                If IsDBNull(FILA_DATAROW("ELE_PRIORIDAD2")) = True Then FILA_DATAROW("ELE_PRIORIDAD2") = 0
                If IsDBNull(FILA_DATAROW("ELE_NOMBRE")) = False Then
                    If Len(FILA_DATAROW("ELE_NOMBRE")) > 35 Then MsgBox("Largo de Nombre Sobrepasa el Limite (35 caracteres)") : GoTo SaltoxLimite
                End If
                consulta_nota = "UPDATE ELEMENTO SET TMU_CODIGO=" & Cod_Muestra & "," & _
                                "ELE_CODIGO=" & "'" & FILA_DATAROW("ELE_CODIGO") & "'," & _
                                "ELE_NOMBRE=" & "'" & FILA_DATAROW("ELE_NOMBRE") & "'," & _
                                "ELE_SIMBOLO=" & "'" & FILA_DATAROW("ELE_SIMBOLO") & "'," & _
                                "ELE_UNIDAD=" & "'" & FILA_DATAROW("ELE_UNIDAD") & "'," & _
                                "ELE_COD_DES=" & "'" & FILA_DATAROW("ELE_COD_DES") & "'," & _
                                "ELE_TAM_BLENTERO=" & FILA_DATAROW("ELE_TAM_BLENTERO") & "," & _
                                "ELE_TAM_BLDECIMAL=" & FILA_DATAROW("ELE_TAM_BLDECIMAL") & "," & _
                                "ELE_TAM_FAENTERO=" & FILA_DATAROW("ELE_TAM_FAENTERO") & "," & _
                                "ELE_TAM_FADECIMAL=" & FILA_DATAROW("ELE_TAM_FADECIMAL") & "," & _
                                "ELE_TAM_LEENTERO=" & FILA_DATAROW("ELE_TAM_LEENTERO") & "," & _
                                "ELE_TAM_LEDECIMAL=" & FILA_DATAROW("ELE_TAM_LEDECIMAL") & "," & _
                                "ELE_TAM_REENTERO=" & FILA_DATAROW("ELE_TAM_REENTERO") & "," & _
                                "ELE_MASCARA=" & FILA_DATAROW("ELE_MASCARA") & "," & _
                                "ELE_CAL_FORMULA=" & "'" & FILA_DATAROW("ELE_CAL_FORMULA") & "'," & _
                                "ELE_CAL_FACTOR=" & "'" & FILA_DATAROW("ELE_CAL_FACTOR") & "'," & _
                                "ELE_PRIORIDAD=" & FILA_DATAROW("ELE_PRIORIDAD") & "," & _
                                "ELE_COSTO=" & FILA_DATAROW("ELE_COSTO") & "," & _
                                "ELE_PLANILLA=" & "'" & FILA_DATAROW("ELE_PLANILLA") & "'," & _
                                "ELE_PRIORIDAD2=" & FILA_DATAROW("ELE_PRIORIDAD2") & "," & _
                                "ELE_FORMATO_RES=" & "'" & FILA_DATAROW("ELE_FORMATO_RES") & "'," & _
                                "ELE_FRECUENCIA=" & "'" & FILA_DATAROW("ELE_FRECUENCIA") & "'," & _
                                "ELE_PESOATOMICO=" & FILA_DATAROW("ELE_PESOATOMICO") & "," & _
                                "ELE_FACTOR_PROPU=" & FILA_DATAROW("ELE_FACTOR_PROPU") & "," & _
                                "ELE_TITULO_RES=" & "'" & FILA_DATAROW("ELE_TITULO_RES") & "'," & _
                                "ELE_COMENTARIO=" & "'" & FILA_DATAROW("ELE_COMENTARIO") & "'," & _
                                "ELE_COMENTARIO1=" & "'" & FILA_DATAROW("ELE_COMENTARIO1") & "'," & _
                                "ELE_COMENTARIO2=" & "'" & FILA_DATAROW("ELE_COMENTARIO2") & "'," & _
                                "ELE_LIMITE_DETEC=" & "'" & FILA_DATAROW("ELE_LIMITE_DETEC") & "'" & _
                                " WHERE TMU_CODIGO=" & Tmu_Codigo_original & " AND ELE_CODIGO='" & Ele_codigo_original & "'"

                Dim mycom As New SqlCommand(consulta_nota, con)
                mycom.ExecuteNonQuery()

                'consulta_nota2 = "UPDATE FORMATO_RESULTADO SET FOR_FREC=" & FILA_DATAROW("ELE_PRIORIDAD") & _
                '                " WHERE TMU_CODIGO=" & Tmu_Codigo_original & " AND ELE_CODIGO='" & FILA_DATAROW("ELE_CODIGO") & "'"

                'Dim mycom1 As New SqlCommand(consulta_nota2, con)
                'mycom1.ExecuteNonQuery()
SaltoxLimite:
            End If
        Next

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Rows
            If FILA_DATAROW.RowState = DataRowState.Deleted Then
                consulta_nota = "DELETE FROM ELEMENTO WHERE TMU_CODIGO=" & FILA_DATAROW("TMU_CODIGO") & " AND ELE_CODIGO='" & FILA_DATAROW("ELE_CODIGO") & "'"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next
        con.Close()
        Cjto_Tablas1.Tables("ELEMENTO_LABSYS").AcceptChanges()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_ele As String
        Dim respuesta As MsgBoxResult
        cll = DTGElemento.CurrentCell.ColumnNumber
        fila = DTGElemento.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Rows(fila)
        Cod_ele = FILA_DATAROW("ELE_CODIGO")
        respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_ele, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Call elimina_fila_grilla(Cod_ele, FILA_DATAROW)
        End If
    End Sub
    Private Sub elimina_fila_grilla(ByVal COD_ELE As String, ByVal FILA_DATAROW As DataRow)
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        consulta_nota = "DELETE FROM ELEMENTO WHERE TMU_CODIGO=" & Cod_Muestra & " AND ELE_CODIGO='" & COD_ELE & "'"
        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        con.Close()
        Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Graba_Todas()
        Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Clear()
        Dim Test1 As DbManager = New DbManager("ELEMENTO_LABSYS", Conexion1)
        Dim query1 As String = "Select * from ELEMENTO WHERE TMU_CODIGO=" & Cod_Muestra & " ORDER BY ELE_PRIORIDAD"
        Test1.Selecccionar(Cjto_Tablas1, query1)
        MsgBox("Grabación finalizada")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Call Convierte_PDF()

        Dim fuente, destino, fechacc, fcorta, FCORTA1 As String
        Dim largo, numnom, fila, sumador, pag, Orden_Aux As Integer
        Dim FILA_ELEMENTO As DataRow
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel, objHojaExcel1 As Excel.Worksheet
        Dim MyDate As Date

        MyDate = Today
        fechacc = Mid(MyDate, 4, 2) & "-" & Mid(MyDate, 1, 2)
        m_Excel = CreateObject("EXCEL.APPLICATION")
        fuente = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2005\Formatos Bases\Formato Listado Elemento.xls"
        destino = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2005\Formatos Bases\Listado Elementos " & CBMuestra.Text & " " & fechacc & ".xls"
        Try
            FileCopy(fuente, destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
        End Try
        objLibroExcel = m_Excel.Workbooks.Open(destino)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()

        fila = 0
        pag = 0
        For Each FILA_ELEMENTO In Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Rows
            fila = fila + 1
            If (fila Mod 58) = 0 Or fila = 1 Then
                fila = fila + 1
                Call Imprime_Encabezado(fila, objHojaExcel)
                pag = pag + 1
                fila = fila + 1
            End If
            objHojaExcel.Range("A" & fila.ToString).Value = FILA_ELEMENTO("ELE_NOMBRE")
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("A" & fila.ToString & ":A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("A" & fila.ToString & ":A" & fila.ToString).BorderAround()

            objHojaExcel.Range("B" & fila.ToString).Value = FILA_ELEMENTO("ELE_SIMBOLO")
            objHojaExcel.Range("B" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("B" & fila.ToString & ":B" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("B" & fila.ToString & ":B" & fila.ToString).BorderAround()

            objHojaExcel.Range("C" & fila.ToString).Value = FILA_ELEMENTO("ELE_UNIDAD")
            objHojaExcel.Range("C" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("C" & fila.ToString & ":C" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("C" & fila.ToString & ":C" & fila.ToString).BorderAround()

            objHojaExcel.Range("D" & fila.ToString).Value = FILA_ELEMENTO("ELE_CODIGO")
            objHojaExcel.Range("D" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("D" & fila.ToString & ":D" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("D" & fila.ToString & ":D" & fila.ToString).BorderAround()

            objHojaExcel.Range("E" & fila.ToString).Value = FILA_ELEMENTO("ELE_COD_DES")
            objHojaExcel.Range("E" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("E" & fila.ToString & ":E" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("E" & fila.ToString & ":E" & fila.ToString).BorderAround()

            'objHojaExcel.Range("F" & fila.ToString).Value = FILA_ELEMENTO("ELE_TMASCARA")
            'objHojaExcel.Range("F" & fila.ToString).Font.Size = 8
            'objHojaExcel.Range("F" & fila.ToString & ":F" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'objHojaExcel.Range("F" & fila.ToString & ":F" & fila.ToString).BorderAround()

            objHojaExcel.Range("F" & fila.ToString).Value = FILA_ELEMENTO("ELE_TAM_BLENTERO")
            objHojaExcel.Range("F" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("F" & fila.ToString & ":F" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("F" & fila.ToString & ":F" & fila.ToString).BorderAround()

            objHojaExcel.Range("G" & fila.ToString).Value = FILA_ELEMENTO("ELE_TAM_BLDECIMAL")
            objHojaExcel.Range("G" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("G" & fila.ToString & ":G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("G" & fila.ToString & ":G" & fila.ToString).BorderAround()

            objHojaExcel.Range("H" & fila.ToString).Value = FILA_ELEMENTO("ELE_TAM_FAENTERO")
            objHojaExcel.Range("H" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("H" & fila.ToString & ":H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("H" & fila.ToString & ":H" & fila.ToString).BorderAround()

            objHojaExcel.Range("I" & fila.ToString).Value = FILA_ELEMENTO("ELE_TAM_FADECIMAL")
            objHojaExcel.Range("I" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("I" & fila.ToString & ":I" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("I" & fila.ToString & ":I" & fila.ToString).BorderAround()

            objHojaExcel.Range("J" & fila.ToString).Value = FILA_ELEMENTO("ELE_TAM_LEENTERO")
            objHojaExcel.Range("J" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("J" & fila.ToString & ":J" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("J" & fila.ToString & ":J" & fila.ToString).BorderAround()

            objHojaExcel.Range("K" & fila.ToString).Value = FILA_ELEMENTO("ELE_TAM_LEDECIMAL")
            objHojaExcel.Range("K" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("K" & fila.ToString & ":K" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("K" & fila.ToString & ":K" & fila.ToString).BorderAround()

            objHojaExcel.Range("L" & fila.ToString).Value = FILA_ELEMENTO("ELE_TAM_REENTERO")
            objHojaExcel.Range("L" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("L" & fila.ToString & ":L" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("L" & fila.ToString & ":L" & fila.ToString).BorderAround()


            objHojaExcel.Range("M" & fila.ToString).Value = FILA_ELEMENTO("ELE_MASCARA")
            objHojaExcel.Range("M" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("M" & fila.ToString & ":M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("M" & fila.ToString & ":M" & fila.ToString).BorderAround()


            objHojaExcel.Range("N" & fila.ToString).Value = FILA_ELEMENTO("ELE_CAL_FORMULA")
            objHojaExcel.Range("N" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("N" & fila.ToString & ":N" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("N" & fila.ToString & ":N" & fila.ToString).BorderAround()


            objHojaExcel.Range("O" & fila.ToString).Value = FILA_ELEMENTO("ELE_CAL_FACTOR")
            objHojaExcel.Range("O" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("O" & fila.ToString & ":O" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("O" & fila.ToString & ":O" & fila.ToString).BorderAround()


            objHojaExcel.Range("P" & fila.ToString).Value = FILA_ELEMENTO("ELE_PRIORIDAD")
            objHojaExcel.Range("P" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("P" & fila.ToString & ":P" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("P" & fila.ToString & ":P" & fila.ToString).BorderAround()


            objHojaExcel.Range("Q" & fila.ToString).Value = FILA_ELEMENTO("ELE_PRIORIDAD2")
            objHojaExcel.Range("Q" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("Q" & fila.ToString & ":Q" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("Q" & fila.ToString & ":Q" & fila.ToString).BorderAround()


            objHojaExcel.Range("R" & fila.ToString).Value = FILA_ELEMENTO("ELE_FRECUENCIA")
            objHojaExcel.Range("R" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("R" & fila.ToString & ":R" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("R" & fila.ToString & ":R" & fila.ToString).BorderAround()


            objHojaExcel.Range("S" & fila.ToString).Value = FILA_ELEMENTO("ELE_FORMATO_RES")
            objHojaExcel.Range("S" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("S" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("S" & fila.ToString & ":S" & fila.ToString).BorderAround()


            objHojaExcel.Range("T" & fila.ToString).Value = FILA_ELEMENTO("ELE_PLANILLA")
            objHojaExcel.Range("T" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("T" & fila.ToString & ":T" & fila.ToString).BorderAround()


            objHojaExcel.Range("U" & fila.ToString).Value = FILA_ELEMENTO("ELE_PESOATOMICO")
            objHojaExcel.Range("U" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("U" & fila.ToString & ":U" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("U" & fila.ToString & ":U" & fila.ToString).BorderAround()


            objHojaExcel.Range("V" & fila.ToString).Value = FILA_ELEMENTO("ELE_FACTOR_PROPU")
            objHojaExcel.Range("V" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("V" & fila.ToString & ":V" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("V" & fila.ToString & ":V" & fila.ToString).BorderAround()


            objHojaExcel.Range("W" & fila.ToString).Value = FILA_ELEMENTO("ELE_TITULO_RES")
            objHojaExcel.Range("W" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("W" & fila.ToString & ":W" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("W" & fila.ToString & ":W" & fila.ToString).BorderAround()
        Next

        'Segunda Pagina calculos


        objHojaExcel1 = objLibroExcel.Worksheets(2)
        objHojaExcel1.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel1.Activate()


        fila = 0
        pag = 0
        For Each FILA_ELEMENTO In Cjto_Tablas1.Tables("ELEMENTO_LABSYS").Rows
            fila = fila + 1
            If (fila Mod 58) = 0 Or fila = 1 Then
                fila = fila + 1
                Call Imprime_Encabezado_Cal(fila, objHojaExcel1)
                pag = pag + 1
                fila = fila + 1
            End If
            objHojaExcel1.Range("A" & fila.ToString).Value = FILA_ELEMENTO("ELE_NOMBRE")
            objHojaExcel1.Range("A" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("A" & fila.ToString & ":A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel1.Range("A" & fila.ToString & ":A" & fila.ToString).BorderAround()

            objHojaExcel1.Range("B" & fila.ToString).Value = FILA_ELEMENTO("ELE_SIMBOLO")
            objHojaExcel1.Range("B" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("B" & fila.ToString & ":B" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel1.Range("B" & fila.ToString & ":B" & fila.ToString).BorderAround()

            objHojaExcel1.Range("C" & fila.ToString).Value = FILA_ELEMENTO("ELE_UNIDAD")
            objHojaExcel1.Range("C" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("C" & fila.ToString & ":C" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel1.Range("C" & fila.ToString & ":C" & fila.ToString).BorderAround()

            objHojaExcel1.Range("D" & fila.ToString).Value = FILA_ELEMENTO("ELE_CODIGO")
            objHojaExcel1.Range("D" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("D" & fila.ToString & ":D" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel1.Range("D" & fila.ToString & ":D" & fila.ToString).BorderAround()

            objHojaExcel1.Range("E" & fila.ToString).Value = FILA_ELEMENTO("ELE_COMENTARIO")
            objHojaExcel1.Range("E" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("E" & fila.ToString & ":E" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel1.Range("E" & fila.ToString & ":E" & fila.ToString).BorderAround()

            objHojaExcel1.Range("F" & fila.ToString).Value = FILA_ELEMENTO("ELE_COMENTARIO1")
            objHojaExcel1.Range("F" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("F" & fila.ToString & ":F" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel1.Range("F" & fila.ToString & ":F" & fila.ToString).BorderAround()

            objHojaExcel1.Range("G" & fila.ToString).Value = FILA_ELEMENTO("ELE_COMENTARIO2")
            objHojaExcel1.Range("G" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("G" & fila.ToString & ":F" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel1.Range("G" & fila.ToString & ":F" & fila.ToString).BorderAround()


            objHojaExcel1.Range("H" & fila.ToString).Value = FILA_ELEMENTO("ELE_LIMITE_DETEC")
            objHojaExcel1.Range("H" & fila.ToString).Font.Size = 8
            objHojaExcel1.Range("H" & fila.ToString & ":G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel1.Range("H" & fila.ToString & ":G" & fila.ToString).BorderAround()
        Next
        fila = fila + 1
        'objHojaExcel.Range("A" & fila.ToString & ":AH" & fila.ToString).BorderAround()
        'Call IMPRIME_NUMERO_PAGINAS(objHojaExcel, pag)
        objHojaExcel1.Range("A8").Select()

    End Sub
    Private Sub Convierte_PDF()
        Dim strPDF As String = "E:\Informatica Local\aa.pdf"
        Dim strexcel As String
        Dim strRange As String
        Dim strPassword As String

        strexcel = "F:\Mis documentos\Traspaso Archivos entre PCs\1.  Sistema LabSys 2005\Formatos Bases\RME-FolB.xls"
        'strexcel = "D:\Informatica Local\documentoTOPdf.doc"

        strRange = "A1:E20"
        'oPDFmaker = New PDFmaker.CreatePDF     'create instance of object

        'oPDFmaker.CloseAcrobat()
        'oPDFmaker.CreatePDFfromExcel(strPDF, strexcel, 1, strRange, , , , , "Page &P", 1, "&D &T", 0, 0.0#, 0.0#, 0.0#, 0.0#)

        MsgBox("Paso")


    End Sub
    Private Sub Imprime_Encabezado(ByRef FILA As Integer, ByVal HOJAEXCEL As Excel.Worksheet)
        HOJAEXCEL.Range("A" & FILA.ToString).Value = "ANALISIS " & Me.CBMuestra.Text & ": Elementos,tamaño campos"
        HOJAEXCEL.Range("A" & FILA.ToString).Font.Size = 11
        HOJAEXCEL.Range("A" & FILA.ToString).Font.Bold = True
        HOJAEXCEL.Range("A" & FILA.ToString & ":A" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        FILA = FILA + 1
        HOJAEXCEL.Range("F" & FILA.ToString & ":M" & FILA.ToString).Merge()
        HOJAEXCEL.Range("F" & FILA.ToString).Value = "Tamaño campos"
        HOJAEXCEL.Range("F" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("F" & FILA.ToString & ":M" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("F" & FILA.ToString & ":M" & FILA.ToString).BorderAround()

        FILA = FILA + 1
        HOJAEXCEL.Range("A" & FILA.ToString).Value = "Elemento"
        HOJAEXCEL.Range("A" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("A" & FILA.ToString & ":A" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("A" & FILA.ToString & ":A" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("B" & FILA.ToString).Value = "Símbolo"
        HOJAEXCEL.Range("B" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("B" & FILA.ToString & ":B" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("B" & FILA.ToString & ":B" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("C" & FILA.ToString).Value = "Unidad"
        HOJAEXCEL.Range("C" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("C" & FILA.ToString & ":C" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("C" & FILA.ToString & ":C" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("D" & FILA.ToString).Value = "CodEle"
        HOJAEXCEL.Range("D" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("D" & FILA.ToString & ":D" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("D" & FILA.ToString & ":D" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("E" & FILA.ToString).Value = "CodEle"
        HOJAEXCEL.Range("E" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("E" & FILA.ToString & ":E" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("E" & FILA.ToString & ":E" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("F" & FILA.ToString & ":G" & FILA.ToString).Merge()
        HOJAEXCEL.Range("F" & FILA.ToString).Value = "Blanco"
        HOJAEXCEL.Range("F" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("F" & FILA.ToString & ":G" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("F" & FILA.ToString & ":G" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("H" & FILA.ToString & ":I" & FILA.ToString).Merge()
        HOJAEXCEL.Range("H" & FILA.ToString).Value = "Factor"
        HOJAEXCEL.Range("H" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("H" & FILA.ToString & ":I" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("H" & FILA.ToString & ":I" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("J" & FILA.ToString & ":K" & FILA.ToString).Merge()
        HOJAEXCEL.Range("J" & FILA.ToString).Value = "Lectura"
        HOJAEXCEL.Range("J" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("J" & FILA.ToString & ":K" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("J" & FILA.ToString & ":K" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("L" & FILA.ToString & ":M" & FILA.ToString).Merge()
        HOJAEXCEL.Range("L" & FILA.ToString).Value = "Result."
        HOJAEXCEL.Range("L" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("L" & FILA.ToString & ":M" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("L" & FILA.ToString & ":M" & FILA.ToString).BorderAround()


        FILA = FILA + 1

        HOJAEXCEL.Range("E" & FILA.ToString).Value = "Despliegue"
        HOJAEXCEL.Range("E" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("E" & FILA.ToString & ":E" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("E" & FILA.ToString & ":E" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("F" & FILA.ToString).Value = "ent"
        HOJAEXCEL.Range("F" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("F" & FILA.ToString & ":F" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("F" & FILA.ToString & ":F" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("G" & FILA.ToString).Value = "dec"
        HOJAEXCEL.Range("G" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("G" & FILA.ToString & ":G" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("G" & FILA.ToString & ":G" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("H" & FILA.ToString).Value = "ent"
        HOJAEXCEL.Range("H" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("H" & FILA.ToString & ":H" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("H" & FILA.ToString & ":H" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("I" & FILA.ToString).Value = "dec"
        HOJAEXCEL.Range("I" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("I" & FILA.ToString & ":I" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("I" & FILA.ToString & ":I" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("J" & FILA.ToString).Value = "ent"
        HOJAEXCEL.Range("J" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("J" & FILA.ToString & ":J" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("J" & FILA.ToString & ":J" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("K" & FILA.ToString).Value = "dec"
        HOJAEXCEL.Range("K" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("K" & FILA.ToString & ":K" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("K" & FILA.ToString & ":K" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("L" & FILA.ToString).Value = "ent"
        HOJAEXCEL.Range("L" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("L" & FILA.ToString & ":L" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("L" & FILA.ToString & ":L" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("M" & FILA.ToString).Value = "Tmas"
        HOJAEXCEL.Range("M" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("M" & FILA.ToString & ":M" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("M" & FILA.ToString & ":M" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("N" & FILA.ToString).Value = "Calculo Formula"
        HOJAEXCEL.Range("N" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("N" & FILA.ToString & ":N" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("N" & FILA.ToString & ":N" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("O" & FILA.ToString).Value = "Calculo Factor"
        HOJAEXCEL.Range("O" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("O" & FILA.ToString & ":O" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("O" & FILA.ToString & ":O" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("P" & FILA.ToString).Value = "Priori1"
        HOJAEXCEL.Range("P" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("P" & FILA.ToString & ":P" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("P" & FILA.ToString & ":P" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("Q" & FILA.ToString).Value = "Priori2"
        HOJAEXCEL.Range("Q" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("Q" & FILA.ToString & ":Q" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("Q" & FILA.ToString & ":Q" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("R" & FILA.ToString).Value = "Frec"
        HOJAEXCEL.Range("R" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("R" & FILA.ToString & ":R" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("R" & FILA.ToString & ":R" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("S" & FILA.ToString).Value = "Plani Resulta"
        HOJAEXCEL.Range("S" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("S" & FILA.ToString & ":S" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("S" & FILA.ToString & ":S" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("T" & FILA.ToString).Value = "Plani Analista"
        HOJAEXCEL.Range("T" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("T" & FILA.ToString & ":T" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("T" & FILA.ToString & ":T" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("U" & FILA.ToString).Value = "P.Atom"
        HOJAEXCEL.Range("U" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("U" & FILA.ToString & ":U" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("U" & FILA.ToString & ":U" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("V" & FILA.ToString).Value = "Fac.Prop"
        HOJAEXCEL.Range("V" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("V" & FILA.ToString & ":V" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("V" & FILA.ToString & ":V" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("W" & FILA.ToString).Value = "Subtitulo"
        HOJAEXCEL.Range("W" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("W" & FILA.ToString & ":W" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("W" & FILA.ToString & ":W" & FILA.ToString).BorderAround()
    End Sub

    Private Sub Imprime_Encabezado_Cal(ByRef FILA As Integer, ByVal HOJAEXCEL As Excel.Worksheet)
        HOJAEXCEL.Range("A" & FILA.ToString).Value = "ANALISIS " & Me.CBMuestra.Text & ": Calculo"
        HOJAEXCEL.Range("A" & FILA.ToString).Font.Size = 11
        HOJAEXCEL.Range("A" & FILA.ToString).Font.Bold = True
        HOJAEXCEL.Range("A" & FILA.ToString & ":A" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        FILA = FILA + 1
        HOJAEXCEL.Range("A" & FILA.ToString).Value = "Elemento"
        HOJAEXCEL.Range("A" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("A" & FILA.ToString & ":A" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("A" & FILA.ToString & ":A" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("B" & FILA.ToString).Value = "Símbolo"
        HOJAEXCEL.Range("B" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("B" & FILA.ToString & ":B" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("B" & FILA.ToString & ":B" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("C" & FILA.ToString).Value = "Unidad"
        HOJAEXCEL.Range("C" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("C" & FILA.ToString & ":C" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("C" & FILA.ToString & ":C" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("D" & FILA.ToString).Value = "CodEle"
        HOJAEXCEL.Range("D" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("D" & FILA.ToString & ":D" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("D" & FILA.ToString & ":D" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("E" & FILA.ToString).Value = "Calculo"
        HOJAEXCEL.Range("E" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("E" & FILA.ToString & ":E" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("E" & FILA.ToString & ":E" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("F" & FILA.ToString).Value = "Datos entrada calculo/Notas"
        HOJAEXCEL.Range("F" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("F" & FILA.ToString & ":F" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("F" & FILA.ToString & ":F" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("G" & FILA.ToString).Value = "Formula Calculo Factor"
        HOJAEXCEL.Range("G" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("G" & FILA.ToString & ":G" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("G" & FILA.ToString & ":G" & FILA.ToString).BorderAround()


        HOJAEXCEL.Range("H" & FILA.ToString).Value = "Limite Deteccion"
        HOJAEXCEL.Range("H" & FILA.ToString).Font.Size = 8
        HOJAEXCEL.Range("H" & FILA.ToString & ":H" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("H" & FILA.ToString & ":H" & FILA.ToString).BorderAround()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
