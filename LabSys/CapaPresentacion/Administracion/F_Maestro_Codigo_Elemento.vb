Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class F_Maestro_Codigo_Elemento
    Inherits System.Windows.Forms.Form
    Private Imprime_Plani As New Genera_Excel_B
    Private cmuestra As Integer


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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTGCodigos As System.Windows.Forms.DataGrid
    Friend WithEvents DTGElementosMuestra As System.Windows.Forms.DataGrid
    Friend WithEvents DTGElementosCodigo As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents BTCopiarElementos As System.Windows.Forms.Button
    Friend WithEvents TxtCopiarCod As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TT As LabSys.Cjto_Tablas
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPlanificacion As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TT = New LabSys.Cjto_Tablas
        Me.DTGCodigos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DTGElementosMuestra = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DTGElementosCodigo = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTCopiarElementos = New System.Windows.Forms.Button
        Me.TxtCopiarCod = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPlanificacion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.TT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGCodigos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGElementosMuestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGElementosCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TT
        '
        Me.TT.DataSetName = "Cjto_Tablas"
        Me.TT.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DTGCodigos
        '
        Me.DTGCodigos.CaptionFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGCodigos.CaptionVisible = False
        Me.DTGCodigos.DataMember = ""
        Me.DTGCodigos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGCodigos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGCodigos.Location = New System.Drawing.Point(144, 8)
        Me.DTGCodigos.Name = "DTGCodigos"
        Me.DTGCodigos.ReadOnly = True
        Me.DTGCodigos.Size = New System.Drawing.Size(864, 312)
        Me.DTGCodigos.TabIndex = 0
        Me.DTGCodigos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGCodigos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ANALISIS_MANTENEDOR"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 730
        '
        'DTGElementosMuestra
        '
        Me.DTGElementosMuestra.CaptionVisible = False
        Me.DTGElementosMuestra.DataMember = "ELEMENTOS_MUESTRA"
        Me.DTGElementosMuestra.DataSource = Me.TT
        Me.DTGElementosMuestra.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGElementosMuestra.Location = New System.Drawing.Point(152, 432)
        Me.DTGElementosMuestra.Name = "DTGElementosMuestra"
        Me.DTGElementosMuestra.ReadOnly = True
        Me.DTGElementosMuestra.Size = New System.Drawing.Size(480, 528)
        Me.DTGElementosMuestra.TabIndex = 1
        Me.DTGElementosMuestra.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DTGElementosMuestra
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ELEMENTOS_MUESTRA"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Código"
        Me.DataGridTextBoxColumn3.MappingName = "ELE_CODIGO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 80
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn4.MappingName = "ELE_NOMBRE"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Proceso"
        Me.DataGridTextBoxColumn5.MappingName = "ELE_PROCESO"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn9.MappingName = "ELE_UNIDAD"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 60
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Nombre Planificacion"
        Me.DataGridTextBoxColumn11.MappingName = "ELE_COD_DES"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 115
        '
        'DTGElementosCodigo
        '
        Me.DTGElementosCodigo.CaptionVisible = False
        Me.DTGElementosCodigo.DataMember = "ELEMENTOS_CODIGO"
        Me.DTGElementosCodigo.DataSource = Me.TT
        Me.DTGElementosCodigo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGElementosCodigo.Location = New System.Drawing.Point(792, 432)
        Me.DTGElementosCodigo.Name = "DTGElementosCodigo"
        Me.DTGElementosCodigo.Size = New System.Drawing.Size(408, 488)
        Me.DTGElementosCodigo.TabIndex = 2
        Me.DTGElementosCodigo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.DTGElementosCodigo
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "ELEMENTOS_CODIGO"
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Código"
        Me.DataGridTextBoxColumn6.MappingName = "ELE_CODIGO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 80
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Cod.Planificacion"
        Me.DataGridTextBoxColumn12.MappingName = "ELE_COD_DES"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Fila/Prio"
        Me.DataGridTextBoxColumn7.MappingName = "ELE_PRIORIDAD"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 45
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Titulo Fila"
        Me.DataGridTextBoxColumn8.MappingName = "TITULO_FILA"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 140
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(864, 936)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Grabar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(960, 936)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Eliminar"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1056, 936)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(664, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Elementos Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(56, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Elementos Muestra"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BTCopiarElementos
        '
        Me.BTCopiarElementos.Location = New System.Drawing.Point(664, 480)
        Me.BTCopiarElementos.Name = "BTCopiarElementos"
        Me.BTCopiarElementos.Size = New System.Drawing.Size(104, 23)
        Me.BTCopiarElementos.TabIndex = 11
        Me.BTCopiarElementos.Text = "Copiar Elementos"
        '
        'TxtCopiarCod
        '
        Me.TxtCopiarCod.Location = New System.Drawing.Point(720, 512)
        Me.TxtCopiarCod.Name = "TxtCopiarCod"
        Me.TxtCopiarCod.Size = New System.Drawing.Size(51, 20)
        Me.TxtCopiarCod.TabIndex = 12
        Me.TxtCopiarCod.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(664, 520)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cod.Ana"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(40, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 32)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Selección de análisis"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtPlanificacion
        '
        Me.TxtPlanificacion.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlanificacion.Location = New System.Drawing.Point(328, 328)
        Me.TxtPlanificacion.Multiline = True
        Me.TxtPlanificacion.Name = "TxtPlanificacion"
        Me.TxtPlanificacion.Size = New System.Drawing.Size(616, 88)
        Me.TxtPlanificacion.TabIndex = 15
        Me.TxtPlanificacion.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(1136, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(208, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Presentacion en planificación"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frm_Maestro_Codigo_Elemento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPlanificacion)
        Me.Controls.Add(Me.TxtCopiarCod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTCopiarElementos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTGElementosCodigo)
        Me.Controls.Add(Me.DTGElementosMuestra)
        Me.Controls.Add(Me.DTGCodigos)
        Me.Name = "Frm_Maestro_Codigo_Elemento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Maestro_Codigo_Elemento"
        CType(Me.TT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGCodigos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGElementosMuestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGElementosCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Maestro_Codigo_Elemento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Es_Planificacion = "N"
        Call Anti_Elimina_lineas()
        Cjto_Tablas1.Tables("ELEMENTOS_MUESTRA").Clear()
        Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Clear()

        AddCellFormattingColumnStyles(Me.DTGCodigos)

        Dim Test1 As DbManager = New DbManager("ANALISIS_MANTENEDOR", Conexion1)
        Dim query1 As String = "Select ANA_CODIGO,ANA_ANALISIS from ANALISIS ORDER BY ANA_CODIGO"
        Test1.Selecccionar(Cjto_Tablas1, query1)

    End Sub
    Private Sub Anti_Elimina_lineas()
        DTGCodigos.DataSource = Cjto_Tablas1.Tables("ANALISIS_MANTENEDOR")
        DTGElementosMuestra.DataSource = Cjto_Tablas1.Tables("ELEMENTOS_MUESTRA")
        DTGElementosCodigo.DataSource = Cjto_Tablas1.Tables("ELEMENTOS_CODIGO")
    End Sub

    Private Sub AddCellFormattingColumnStyles(ByVal grid As DataGrid)
        Dim ts As DataGridTableStyle
        ts = New DataGridTableStyle
        Dim dt As DataTable
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j As Integer
        j = 0
        Do While (j < dt.Columns.Count)
            Dim cs As DataGridFormattableTextBoxColumn
            Try
                cs = New DataGridFormattableTextBoxColumn(j)
                cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs.grid = grid

            Catch ex As Exception
                Exit Do
            End Try
            'AddHandler cs.SetCellFormat, handler
            If j >= 2 Then
                ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
            ElseIf j = 1 Then
                Dim cs2 As New CGridMultiLineTextBoxStyle(grid.TableStyles(0).GridColumnStyles(j).MappingName, j)
                cs2.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs2.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs2.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs2.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs2.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs2.grid = grid
                'AddHandler cs2.SetCellFormat, handler
                ts.GridColumnStyles.Add(cs2)
            Else
                ts.GridColumnStyles.Add(cs)
            End If
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub

    Private Sub DTGCodigos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGCodigos.Click
        Dim Fila_Num, PrioFil As Integer
        Dim Acumula As String
        Dim FILA_PLANI As DataRow

        Dim CCod As Double

        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Fila_Num = myGrid.CurrentCell.RowNumber
        TxtPlanificacion.Text = ""
        CCod = myGrid.Item(Fila_Num, 0)
        Label3.Text = CCod
        cmuestra = myGrid.Item(Fila_Num, 0)

        cmuestra = CInt(Mid(CStr(cmuestra), 1, 1) & "000")

        Cjto_Tablas1.Tables("ELEMENTOS_MUESTRA").Clear()
        Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Clear()

        Dim Test1 As DbManager = New DbManager("ELEMENTOS_MUESTRA", Conexion1)
        Dim query1 As String = "Select ELE_CODIGO,ELE_NOMBRE,ELE_PROCESO,ELE_SIMBOLO,ELE_UNIDAD,ELE_COD_DES FROM ELEMENTO WHERE TMU_CODIGO=" & cmuestra & " ORDER BY ELE_PRIORIDAD"
        Test1.Selecccionar(Cjto_Tablas1, query1)

        Dim Test2 As DbManager = New DbManager("ELEMENTOS_CODIGO", Conexion1)
        Dim query2 As String = "Select ELE_CODIGO,ELE_PRIORIDAD,TITULO_FILA,ELE_COD_DES FROM ANALISIS_ELEMENTOS WHERE ANA_CODIGO=" & CCod & " ORDER BY ELE_PRIORIDAD"
        Test2.Selecccionar(Cjto_Tablas1, query2)

        PrioFil = 100
        Acumula = ""
        For Each FILA_PLANI In Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Rows
            If PrioFil = 100 Then Acumula = CStr(FILA_PLANI("TITULO_FILA")).PadRight(26) & ":"
            If Mid(CStr(FILA_PLANI("ELE_PRIORIDAD")), 1, 1) <> Mid(CStr(PrioFil), 1, 1) Then
                Acumula = Mid(Acumula, 1, Len(Acumula) - 1) & Chr(13) & Chr(10)
                Acumula = Acumula & CStr(FILA_PLANI("TITULO_FILA")).PadRight(26) & ":"
                Acumula = Acumula & FILA_PLANI("ELE_COD_DES") & "-"
                PrioFil = FILA_PLANI("ELE_PRIORIDAD")
            Else
                Acumula = Acumula & FILA_PLANI("ELE_COD_DES") & "-"
                PrioFil = FILA_PLANI("ELE_PRIORIDAD")
            End If
        Next
        If Len(Acumula) > 0 Then TxtPlanificacion.Text = Mid(Acumula, 1, Len(Acumula) - 1)
    End Sub

    Private Sub DTGElementosMuestra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGElementosMuestra.DoubleClick
        Dim Fila_Num As Integer
        Dim ELEM, codPlani As String
        Dim Fila_Elementos As DataRow
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Fila_Num = myGrid.CurrentCell.RowNumber
        ELEM = myGrid.Item(Fila_Num, 0)
        codPlani = myGrid.Item(Fila_Num, 4)
        Fila_Elementos = Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").NewRow
        Fila_Elementos("ELE_CODIGO") = ELEM
        Fila_Elementos("ELE_COD_DES") = codPlani
        Try
            Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Rows.Add(Fila_Elementos)
        Catch ex As Exception
            MsgBox("Código ya existe")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Elemento As String
        Dim respuesta As MsgBoxResult
        Dim mycell As New DataGridCell
        cll = DTGElementosCodigo.CurrentCell.ColumnNumber
        fila = DTGElementosCodigo.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Rows(fila)
        Cod_Elemento = FILA_DATAROW("ELE_CODIGO")
        respuesta = MsgBox("Esta seguro de eliminar : " & Cod_Elemento, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Call elimina_fila_grilla_ELE(Cod_Elemento, FILA_DATAROW)
            mycell.ColumnNumber = 0
            mycell.RowNumber = fila + 1
            DTGElementosCodigo.CurrentCell = mycell
        End If
    End Sub

    Private Sub elimina_fila_grilla_ELE(ByVal COD_ELEMENTO As String, ByVal FILA_DATAROW As DataRow)
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        consulta_nota = "DELETE FROM ANALISIS_ELEMENTOS WHERE ANA_CODIGO=" & CDbl(Label3.Text) & " AND ELE_CODIGO=" & "'" & COD_ELEMENTO & "'"
        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        con.Close()
        Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub Graba_Todas()
        Dim FILA_DATAROW, dr As DataRow
        Dim Elemento_original As String
        Dim con As New SqlConnection(Conexion1)
        Dim consulta_nota, consulta_nota2 As String
        con.Open()

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Rows
            If IsDBNull(FILA_DATAROW("ELE_PRIORIDAD")) = True Then FILA_DATAROW("ELE_PRIORIDAD") = 0

            Try
                consulta_nota = "INSERT INTO ANALISIS_ELEMENTOS (TMU_CODIGO,ANA_CODIGO,ELE_CODIGO,ELE_PRIORIDAD,TITULO_FILA,ELE_COD_DES) VALUES (" & _
                            cmuestra & "," & CDbl(Label3.Text) & ",'" & FILA_DATAROW("ELE_CODIGO") & "'," & FILA_DATAROW("ELE_PRIORIDAD") & ",'" & FILA_DATAROW("TITULO_FILA") & "','" & FILA_DATAROW("ELE_COD_DES") & "')"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            Catch ex As Exception
                consulta_nota = "UPDATE ANALISIS_ELEMENTOS SET ELE_PRIORIDAD=" & _
                                FILA_DATAROW("ELE_PRIORIDAD") & ",TITULO_FILA='" & FILA_DATAROW("TITULO_FILA") & "',ELE_COD_DES='" & FILA_DATAROW("ELE_COD_DES") & "' WHERE ANA_CODIGO=" & CDbl(Label3.Text) & " AND ELE_CODIGO='" & FILA_DATAROW("ELE_CODIGO") & "'"

                Dim myCommand5 As New SqlCommand(consulta_nota, con)
                Dim myReader5 As SqlDataReader
                myReader5 = myCommand5.ExecuteReader()
                myReader5.Close()
            End Try
        Next
        con.Close()
        Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").AcceptChanges()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Graba_Todas()
        MsgBox("Grabación finalizada")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DTGElementosCodigo.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DTGElementosCodigo.CurrentCell = mycell
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub BTCopiarElementos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCopiarElementos.Click
        If TxtCopiarCod.Text <> "" Then
            Cjto_Tablas1.Tables("ELEMENTOS_CODIGO").Clear()
            Dim Test2 As DbManager = New DbManager("ELEMENTOS_CODIGO", Conexion1)
            Dim query2 As String = "Select ELE_CODIGO,ELE_PRIORIDAD,TITULO_FILA,ELE_COD_DES FROM ANALISIS_ELEMENTOS WHERE ANA_CODIGO=" & Me.TxtCopiarCod.Text & " ORDER BY ELE_PRIORIDAD"
            Test2.Selecccionar(Cjto_Tablas1, query2)
        End If
    End Sub

    Private Sub BTImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim via, fuente, destino, sMsg2 As String
        Dim PUNTOS, PUNTOS_X, nomb, vv As String
        Dim num_ord As Integer
        Dim FILA_IMP_REC As DataRow

        fuente = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2007\Formatos Bases\Formato Lista OT x Analizar.xls"
        destino = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2007\Formatos Bases\Listado Codigos Elementos.xls"
        Imprime_Plani.Crea_Excel(fuente, destino)
        Call Imprime_ListadoCodEle(objHojaExcel, m_Excel, destino)
        Me.Close()
pormientras:
    End Sub


    Private Sub Imprime_ListadoCodEle(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal excell As Excel.Application, ByVal destino As String)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim SwEmpresa, ll, SwGuion, Fila_Descripcion, Ultima_Fila, IntMuestra, IntSub, IntNLab, xx, CodAnalEx, NumeroDeOt, Fila_Combo, i, Largo, fila, fila_pie, fila_logo, fila_nota, ContFila, Muestra_Aux As Integer
        Dim Paso, caracter, query, vernom, FechaI, CodMueC, NumLabo, Acumula, Acumula1, Espacios, StrEle As String
        Dim BuscaSub, BUSCA, BusMue, BuscaAna As Object
        Dim FILA_ANALISIS, Fila_Orden, FILA_CODELE, FILA_MUESTRA, Fila_Ultima As DataRow
        Dim FechaDia As Date
        Dim Fila_CodEleDes, Fila_top, Ot_Num_Mom, MyPos, Lpag, Lcont, Fila_Titulo, TMuestra As Integer
        Dim DBMan1 As DbManager
        Dim ds As DataSet = New DataSet
        Espacios = "             "
        FechaDia = Now
        fila = 2 : Lpag = 1
        Call Encabezado_Listado(fila, FechaDia)
        Muestra_Aux = 0
        ContFila = 0
        For Each FILA_ANALISIS In Cjto_Tablas1.Tables("ANALISIS_MANTENEDOR").Rows
            fila = fila + 1
            Imprime_Plani.HojaE.Range("A" & fila.ToString & ":F" & fila.ToString).Merge()
            Imprime_Plani.HojaE.Range("A" & fila.ToString).Font.Size = 8
            Imprime_Plani.HojaE.Range("A" & fila.ToString).NumberFormat = "0000"
            Imprime_Plani.HojaE.Range("A" & fila.ToString).Value = FILA_ANALISIS("ANA_CODIGO")
            Imprime_Plani.HojaE.Range("A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            Paso = "N"
            SwGuion = 0
            TMuestra = CInt(Mid(FILA_ANALISIS("ANA_CODIGO"), 1, 1) & "000")
            If FILA_ANALISIS("ANA_CODIGO") = 1704 Then
                SwGuion = 0
            End If

            ' IMPRIME CODIGO ANA_ANALISIS
            query = FILA_ANALISIS("ANA_ANALISIS")
            Fila_CodEleDes = fila
            Fila_top = fila
            Acumula = ""
            For i = 1 To query.Length
                caracter = Mid(query, i, 1)
                If Asc(caracter) = 13 Then caracter = " "
                If Asc(caracter) = 10 Then
                    Imprime_Plani.HojaE.Range("G" & fila.ToString).Font.Size = 8
                    Imprime_Plani.HojaE.Range("G" & fila.ToString).Value = Acumula
                    Imprime_Plani.HojaE.Range("G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    fila = fila + 1
                    Acumula = ""
                Else
                    Acumula = Acumula + caracter
                End If
            Next
            Imprime_Plani.HojaE.Range("G" & fila.ToString).Font.Size = 8
            Imprime_Plani.HojaE.Range("G" & fila.ToString).Value = Acumula
            Imprime_Plani.HojaE.Range("G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'FIN IMPRIME CODIGO ANA_ANALISIS

            With SP
                .Inicializar()
                .AgregarParametro("@CodAna", FILA_ANALISIS("ANA_CODIGO"), SqlDbType.Float)
                .AgregarParametro("@TMuestra", TMuestra, SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectAnalisisElemento")
            End With

            For Each FILA_CODELE In ds.Tables(0).Rows
                Fila_Descripcion = Mid(CStr(FILA_CODELE("ELE_PRIORIDAD")), 1, 1)
                Exit For
            Next

            Acumula1 = "             " & "             " & ":"
            For Each FILA_CODELE In ds.Tables(0).Rows
                ll = 0
                If Fila_Descripcion <> CInt(Mid(CStr(FILA_CODELE("ELE_PRIORIDAD")), 1, 1)) Then
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString & ":FJ" & Fila_CodEleDes.ToString).Merge()
                    Acumula1 = Mid(Acumula1, 1, Len(Acumula1) - 1)
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Value = Acumula1
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.Size = 8
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.Bold = False
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.ColorIndex = 3
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.Name = "Courier New"
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString & ":FJ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    'Call BORDES_FILA_LADOS(fila)
                    ContFila = ContFila + 1
                    Fila_CodEleDes = Fila_CodEleDes + 1
                    Acumula1 = "             " & "             " & ":"
                    ll = 0
                    StrEle = FILA_CODELE("ELE_COD_DES")
                    If IsDBNull(FILA_CODELE("TITULO_FILA")) = False Then
                        If Len(FILA_CODELE("TITULO_FILA")) > 0 Then
                            Acumula1 = FILA_CODELE("TITULO_FILA") & Mid(Espacios, Len(FILA_CODELE("TITULO_FILA")) + 1)
                            Acumula1 = Acumula1 & "             " & ":" & StrEle & "-"
                        Else
                            Acumula1 = "             "
                            Acumula1 = Acumula1 & "             " & ":" & StrEle & "-"
                        End If
                    End If
                    Fila_Descripcion = CInt(Mid(CStr(FILA_CODELE("ELE_PRIORIDAD")), 1, 1))
                Else
                    If IsDBNull(FILA_CODELE("TITULO_FILA")) = False And SwGuion = 0 Then
                        If Len(FILA_CODELE("TITULO_FILA")) > 0 Then
                            Acumula1 = FILA_CODELE("TITULO_FILA") & Mid(Espacios, Len(FILA_CODELE("TITULO_FILA")) + 1)
                            Acumula1 = Acumula1 & "             " & ":"
                        Else
                            Acumula1 = "             "
                            Acumula1 = Acumula1 & "             " & ":"
                        End If
                        SwGuion = 1
                    End If
                    Try
                        StrEle = FILA_CODELE("ELE_COD_DES")
                        Acumula1 = Acumula1 & StrEle & "-"
                        Fila_Descripcion = CInt(Mid(CStr(FILA_CODELE("ELE_PRIORIDAD")), 1, 1))
                        Paso = "S"
                    Catch ex As Exception
                    End Try
                End If
            Next
            Try
                If Paso = "S" Then
                    If ll > 0 Then Fila_CodEleDes = Fila_CodEleDes - 1
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString & ":FJ" & Fila_CodEleDes.ToString).Merge()
                    Acumula1 = Mid(Acumula1, 1, Len(Acumula1) - 1)
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Value = Acumula1
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.Size = 8
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.Bold = False
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.Name = "Courier New"
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString).Font.ColorIndex = 3
                    Imprime_Plani.HojaE.Range("CH" & Fila_CodEleDes.ToString & ":FJ" & Fila_CodEleDes.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Imprime_Plani.BordesI(4, 2, Fila_CodEleDes, Fila_top, "A", "FJ")
                End If
            Catch ex As Exception
            End Try
        Next
        fila = fila + 1
        '        Call IMPRIME_NUMERO_PAGINAS(Lpag)
        fila = 24
        fila = fila + 1
        Imprime_Plani.Cierra_Excel(destino)
    End Sub

    Private Sub Encabezado_Listado(ByRef fila As Integer, ByVal FechaDia As Date)
        Dim fila_bi As Integer

        Imprime_Plani.Imprime_Linea(fila, fila, "EI", "EP", 8, "Center", "Center", False, "", "", "Fecha")
        Imprime_Plani.Imprime_Linea(fila, fila, "EQ", "EQ", 8, "Center", "Center", False, "", "", ":")
        Imprime_Plani.Imprime_Linea(fila, fila, "ER", "EZ", 7, "Left", "Center", False, "", "", Format(FechaDia, "dd-MM-yyyy"))

        fila = fila + 1

        Imprime_Plani.Imprime_Linea(fila, fila, "A", "FD", 9, "Center", "Center", True, "", "", "LISTADO ANALISIS ELEMENTO")

        fila = fila + 2
        Imprime_Plani.Imprime_Linea(fila, fila, "A", "F", 8, "Center", "Center", False, "", "", "COD.")
        Imprime_Plani.Imprime_Linea(fila, fila, "G", "CG", 8, "Center", "Center", False, "", "", "ANALISIS")
        Imprime_Plani.Imprime_Linea(fila, fila, "CH", "FJ", 8, "Center", "Center", False, "", "", "DESCOMPOSICION ELEMENTO")

        Imprime_Plani.BordesI(4, 1, fila, fila, "A", "FJ")

    End Sub

    Public Sub IMPRIME_NUMERO_PAGINAS_RESUMEN_ESTADISTICO(ByVal pag As Integer)
        Dim NUM_PAG, TOT_PAG, jy, filP, ult_fin, pos_pag As Integer
        Dim junto As String
        ult_fin = pag - 1
        pos_pag = 4
        For jy = 1 To pag
            If jy = 1 Then filP = pos_pag
            If jy <> 1 Then filP = pos_pag + (30 * (jy - 1))
            junto = CStr(jy & "/" & pag)
            Imprime_Plani.Imprime_Linea(filP, filP, "DA", "DJ", 7, "General", "Center", False, "", "", "'" & CStr(junto))
        Next
    End Sub

    Public Sub BORDES_FILA_LADOS(ByVal IB As Integer)
        Imprime_Plani.BordesI(7, 2, IB, IB, "BB", "BB")
        Imprime_Plani.BordesI(7, 2, IB, IB, "BL", "BL")
        Imprime_Plani.BordesI(7, 2, IB, IB, "BV", "BV")
        Imprime_Plani.BordesI(7, 2, IB, IB, "CF", "CF")
        Imprime_Plani.BordesI(7, 2, IB, IB, "CP", "CP")
    End Sub

    Private Sub DTGCodigos_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DTGCodigos.Navigate

    End Sub
End Class
