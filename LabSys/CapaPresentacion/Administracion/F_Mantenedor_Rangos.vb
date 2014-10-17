Imports Microsoft.Office.Interop

Public Class F_Mantenedor_Rangos
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
    Friend WithEvents DtgEspecies As System.Windows.Forms.DataGrid
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TxtEspecie As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DtgRangos As System.Windows.Forms.DataGrid
    Friend WithEvents CBMuestras As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(F_Mantenedor_Rangos))
        Me.DtgEspecies = New System.Windows.Forms.DataGrid
        Me.Button4 = New System.Windows.Forms.Button
        Me.TxtEspecie = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DtgRangos = New System.Windows.Forms.DataGrid
        Me.CBMuestras = New System.Windows.Forms.ComboBox
        CType(Me.DtgEspecies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgRangos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgEspecies
        '
        Me.DtgEspecies.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgEspecies.CaptionVisible = False
        Me.DtgEspecies.DataMember = ""
        Me.DtgEspecies.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgEspecies.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgEspecies.Location = New System.Drawing.Point(552, 128)
        Me.DtgEspecies.Name = "DtgEspecies"
        Me.DtgEspecies.Size = New System.Drawing.Size(192, 320)
        Me.DtgEspecies.TabIndex = 23
        Me.DtgEspecies.Visible = False
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(512, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 23)
        Me.Button4.TabIndex = 22
        '
        'TxtEspecie
        '
        Me.TxtEspecie.Location = New System.Drawing.Point(352, 94)
        Me.TxtEspecie.Name = "TxtEspecie"
        Me.TxtEspecie.Size = New System.Drawing.Size(160, 20)
        Me.TxtEspecie.TabIndex = 21
        Me.TxtEspecie.Text = ""
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(392, 456)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 32)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Imprimir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Grabar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Especie"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Muestra"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 494)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(640, 40)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = ""
        '
        'DtgRangos
        '
        Me.DtgRangos.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DtgRangos.CaptionVisible = False
        Me.DtgRangos.DataMember = ""
        Me.DtgRangos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgRangos.Location = New System.Drawing.Point(192, 126)
        Me.DtgRangos.Name = "DtgRangos"
        Me.DtgRangos.Size = New System.Drawing.Size(344, 320)
        Me.DtgRangos.TabIndex = 15
        '
        'CBMuestras
        '
        Me.CBMuestras.Location = New System.Drawing.Point(192, 94)
        Me.CBMuestras.Name = "CBMuestras"
        Me.CBMuestras.Size = New System.Drawing.Size(152, 21)
        Me.CBMuestras.TabIndex = 14
        '
        'Frm_Mantenedor_Rangos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 613)
        Me.Controls.Add(Me.DtgEspecies)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TxtEspecie)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DtgRangos)
        Me.Controls.Add(Me.CBMuestras)
        Me.Name = "Frm_Mantenedor_Rangos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Mantenedor_Rangos"
        CType(Me.DtgEspecies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgRangos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DtgEspecies.Visible = True
    End Sub

    Private Sub Frm_Mantenedor_Rangos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Fila_Muestras, Fila_Especie As DataRow
        Me.Anti_Elimina_lineas()

        CBMuestras.Items.Add("")
        For Each Fila_Muestras In Cjto_Tablas1.Tables("MUESTRA").Rows
            CBMuestras.Items.Add(Fila_Muestras("TMU_MUESTRA"))
        Next
        Call Crear_Formato_Grilla_Rango()
        Call Crear_Formato_Grilla_Especie()
    End Sub

    Private Sub Anti_Elimina_lineas()
        Me.DtgRangos.DataSource = Cjto_Tablas1.RANGO_DBF2
        Me.DtgEspecies.DataSource = Cjto_Tablas1.ESPECIE
    End Sub


    Private Sub Crear_Formato_Grilla_Rango()
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "RANGO_DBF2"
        Dim NumLabo As New DataGridTextBoxColumn
        NumLabo.MappingName = "COD_ELE_RANGO"
        NumLabo.HeaderText = "Elemento"
        NumLabo.Width = 60
        NumLabo.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(NumLabo)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "RANGO_DESDE"
        TextCol.HeaderText = "Rango Desde"
        TextCol.Width = 80
        TextCol.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "SIMBOLO"
        TextCol1.HeaderText = "Simbolo"
        TextCol1.Width = 80
        TextCol1.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "RANGO_HASTA"
        TextCol3.HeaderText = "Rango Hasta"
        TextCol3.Width = 80
        TextCol3.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol3)

        DtgRangos.TableStyles.Add(ts1)
    End Sub

    Private Sub Crear_Formato_Grilla_Especie()
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "ESPECIE"

        Dim esp As New DataGridTextBoxColumn
        esp.MappingName = "ESPECIE"
        esp.HeaderText = "Especie"
        esp.Width = 150
        esp.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(esp)

        DtgEspecies.TableStyles.Add(ts1)

    End Sub


    Private Sub Desplega_rangos()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Retorno_Nota As String = ""
        Dim CodMue As Integer
        Cjto_Tablas1.Tables("RANGO_DBF2").Clear()
        TextBox1.Text = ""



        Select Case CBMuestras.Text
            Case "FOLIAR"
                CodMue = 1000
            Case "TEJIDOS"
                CodMue = 2000
        End Select



        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", CodMue, SqlDbType.Int)
            .AgregarParametro("@Especie", TxtEspecie.Text, SqlDbType.NVarChar)
            .EjecutarQueryDt("usp_SelectRangos", Cjto_Tablas1, "RANGO_DBF2")
        End With


        With SP
            .Inicializar()
            .AgregarParametro("@Especie", TxtEspecie.Text, SqlDbType.NVarChar)
            Retorno_Nota = .EjecutarEscalar3("usp_SelectNotaAutoResultados")
            TextBox1.Text = Retorno_Nota
        End With


    End Sub

    Private Sub DtgEspecies_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgEspecies.DoubleClick
        Dim FILA As Integer
        Dim FILA_DATAROW As DataRow
        Dim MYGRID As DataGrid = CType(sender, DataGrid)
        FILA = MYGRID.CurrentCell.RowNumber()
        TxtEspecie.Text = MYGRID.Item(FILA, 0)
        DtgEspecies.Visible = False
        Call Desplega_rangos()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Hoja_Excel As Excel.Worksheet
        Hoja_Excel = Genera_Excel()
        Call Salto_De_Pagina(Hoja_Excel)
        Cjto_Tablas1.Tables("RANGO_DBF2").Clear()
    End Sub

    Function Genera_Excel() As Excel.Worksheet
        Dim fuente, destino As String
        Dim NumLab
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        Cjto_Tablas1.Tables("RANGO_DBF2").Clear()

        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_SelectRangosTodos", Cjto_Tablas1, "RANGO_DBF2")
        End With


        m_Excel = CreateObject("EXCEL.APPLICATION")
        fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato Rangos.xls"
        destino = "F:\Mis documentos\LabSys-Pruebas\Otros\Rangos Standar.xls"
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
        Return objHojaExcel
    End Function


    Private Sub Salto_De_Pagina(ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim fila_imp, fila_desde, fila_hasta As Integer
        Dim vernom As String
        Dim Esp_Aux As String
        Dim FILA_IMPR As DataRow
        Dim BOLA2(1) As Object
        Dim FILA_HOMO, FILA_RAN As DataRow
        HOJA_EXCEL.Range("BM1").Value = "LISTADO DE RANGOS - ESPECIES FOLIARES"
        HOJA_EXCEL.Range("BM1").Font.Size = 12
        HOJA_EXCEL.Range("BM1").Font.Bold = True
        fila_imp = 3
        HOJA_EXCEL.Range("A" & fila_imp.ToString & ":W" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila_imp.ToString).Value = "Especie"
        HOJA_EXCEL.Range("A" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & fila_imp.ToString & ":W" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("A" & fila_imp.ToString & ":W" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("X" & fila_imp.ToString & ":AG" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("X" & fila_imp.ToString).Value = "Nt"
        HOJA_EXCEL.Range("X" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("X" & fila_imp.ToString & ":AG" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("X" & fila_imp.ToString & ":AG" & fila_imp.ToString).BorderAround()


        HOJA_EXCEL.Range("AH" & fila_imp.ToString & ":AQ" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("AH" & fila_imp.ToString).Value = "NNO3"
        HOJA_EXCEL.Range("AH" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AH" & fila_imp.ToString & ":AQ" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AH" & fila_imp.ToString & ":AQ" & fila_imp.ToString).BorderAround()


        HOJA_EXCEL.Range("AR" & fila_imp.ToString & ":BA" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("AR" & fila_imp.ToString).Value = "NNH4"
        HOJA_EXCEL.Range("AR" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AR" & fila_imp.ToString & ":BA" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AR" & fila_imp.ToString & ":BA" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("BB" & fila_imp.ToString & ":BK" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("BB" & fila_imp.ToString).Value = "P"
        HOJA_EXCEL.Range("BB" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("BB" & fila_imp.ToString & ":BK" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BB" & fila_imp.ToString & ":BK" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("BL" & fila_imp.ToString & ":BU" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("BL" & fila_imp.ToString).Value = "K"
        HOJA_EXCEL.Range("BL" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("BL" & fila_imp.ToString & ":BU" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BL" & fila_imp.ToString & ":BU" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("BV" & fila_imp.ToString & ":CE" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("BV" & fila_imp.ToString).Value = "Ca"
        HOJA_EXCEL.Range("BV" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("BV" & fila_imp.ToString & ":CE" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BV" & fila_imp.ToString & ":CE" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("CF" & fila_imp.ToString & ":CO" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila_imp.ToString).Value = "Mg"
        HOJA_EXCEL.Range("CF" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CF" & fila_imp.ToString & ":CO" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CF" & fila_imp.ToString & ":CO" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("CP" & fila_imp.ToString & ":CY" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("CP" & fila_imp.ToString).Value = "Zn"
        HOJA_EXCEL.Range("CP" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CP" & fila_imp.ToString & ":CY" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CP" & fila_imp.ToString & ":CY" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("CZ" & fila_imp.ToString & ":DI" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("CZ" & fila_imp.ToString).Value = "Mn"
        HOJA_EXCEL.Range("CZ" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CZ" & fila_imp.ToString & ":DI" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CZ" & fila_imp.ToString & ":DI" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("DJ" & fila_imp.ToString & ":DS" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("DJ" & fila_imp.ToString).Value = "Fe"
        HOJA_EXCEL.Range("DJ" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("DJ" & fila_imp.ToString & ":DS" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("DJ" & fila_imp.ToString & ":DS" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("DT" & fila_imp.ToString & ":EC" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("DT" & fila_imp.ToString).Value = "Cu"
        HOJA_EXCEL.Range("DT" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("DT" & fila_imp.ToString & ":EC" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("DT" & fila_imp.ToString & ":EC" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("ED" & fila_imp.ToString & ":EM" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("ED" & fila_imp.ToString).Value = "B"
        HOJA_EXCEL.Range("ED" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("ED" & fila_imp.ToString & ":EM" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("ED" & fila_imp.ToString & ":EM" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("EN" & fila_imp.ToString & ":EW" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("EN" & fila_imp.ToString).Value = "Cl"
        HOJA_EXCEL.Range("EN" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("EN" & fila_imp.ToString & ":EW" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("EN" & fila_imp.ToString & ":EW" & fila_imp.ToString).BorderAround()

        HOJA_EXCEL.Range("EX" & fila_imp.ToString & ":FG" & fila_imp.ToString).Merge()
        HOJA_EXCEL.Range("EX" & fila_imp.ToString).Value = "Na"
        HOJA_EXCEL.Range("EX" & fila_imp.ToString).Font.Size = 8
        HOJA_EXCEL.Range("EX" & fila_imp.ToString & ":FG" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("EX" & fila_imp.ToString & ":FG" & fila_imp.ToString).BorderAround()

        fila_imp = 3
        fila_desde = 3
        For Each FILA_IMPR In Cjto_Tablas1.Tables("RANGO_DBF2").Rows
            If Esp_Aux <> FILA_IMPR("COD_ESP") Then fila_imp = fila_imp + 1
            HOJA_EXCEL.Range("A" & fila_imp.ToString & ":W" & fila_imp.ToString).Merge()
            HOJA_EXCEL.Range("A" & fila_imp.ToString).Value = FILA_IMPR("COD_ESP")
            HOJA_EXCEL.Range("A" & fila_imp.ToString).Font.Size = 8
            HOJA_EXCEL.Range("A" & fila_imp.ToString & ":W" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            If IsDBNull(FILA_IMPR("RANGO_DESDE")) = True Then FILA_IMPR("RANGO_DESDE") = 0
            If IsDBNull(FILA_IMPR("SIMBOLO")) = True Then FILA_IMPR("SIMBOLO") = ""
            If IsDBNull(FILA_IMPR("RANGO_HASTA")) = True Then FILA_IMPR("RANGO_HASTA") = 0
            '
            '****** COMIENZA ELEMENTOS ****************************
            '
            If FILA_IMPR("COD_ELE_RANGO") = "Nt" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("X" & fila_imp.ToString & ":AA" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("X" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("X" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("X" & fila_imp.ToString & ":AA" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("X" & fila_imp.ToString & ":AA" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("AB" & fila_imp.ToString & ":AC" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AB" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("AB" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AB" & fila_imp.ToString & ":AC" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AB" & fila_imp.ToString & ":AC" & fila_imp.ToString).ShrinkToFit() = True

                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("AD" & fila_imp.ToString & ":AG" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AD" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("AD" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AD" & fila_imp.ToString & ":AG" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AD" & fila_imp.ToString & ":AG" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If

            If FILA_IMPR("COD_ELE_RANGO") = "NNO3" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("AH" & fila_imp.ToString & ":AK" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AH" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("AH" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AH" & fila_imp.ToString & ":AK" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AH" & fila_imp.ToString & ":AK" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("AL" & fila_imp.ToString & ":AM" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AL" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("AL" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AL" & fila_imp.ToString & ":AM" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AL" & fila_imp.ToString & ":AM" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("AN" & fila_imp.ToString & ":AQ" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AN" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("AN" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AN" & fila_imp.ToString & ":AQ" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AN" & fila_imp.ToString & ":AQ" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If

            If FILA_IMPR("COD_ELE_RANGO") = "NNH4" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("AR" & fila_imp.ToString & ":AU" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AR" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("AR" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AR" & fila_imp.ToString & ":AU" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AR" & fila_imp.ToString & ":AU" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("AV" & fila_imp.ToString & ":AW" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AV" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("AV" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AV" & fila_imp.ToString & ":AW" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AV" & fila_imp.ToString & ":AW" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("AX" & fila_imp.ToString & ":BA" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("AX" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("AX" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("AX" & fila_imp.ToString & ":BA" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("AX" & fila_imp.ToString & ":BA" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "P" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("BB" & fila_imp.ToString & ":BE" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BB" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("BB" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BB" & fila_imp.ToString & ":BE" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BB" & fila_imp.ToString & ":BE" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("BF" & fila_imp.ToString & ":BG" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BF" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("BF" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BF" & fila_imp.ToString & ":BG" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BF" & fila_imp.ToString & ":BG" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("BH" & fila_imp.ToString & ":BK" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BH" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("BH" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BH" & fila_imp.ToString & ":BK" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BH" & fila_imp.ToString & ":BK" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "K" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("BL" & fila_imp.ToString & ":BO" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BL" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("BL" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BL" & fila_imp.ToString & ":BO" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BL" & fila_imp.ToString & ":BO" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("BP" & fila_imp.ToString & ":BQ" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BP" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("BP" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BP" & fila_imp.ToString & ":BQ" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BP" & fila_imp.ToString & ":BQ" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("BR" & fila_imp.ToString & ":BU" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BR" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("BR" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BR" & fila_imp.ToString & ":BU" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BR" & fila_imp.ToString & ":BU" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Ca" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("BV" & fila_imp.ToString & ":BY" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BV" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("BV" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BV" & fila_imp.ToString & ":BY" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BV" & fila_imp.ToString & ":BY" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("BZ" & fila_imp.ToString & ":CA" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("BZ" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("BZ" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("BZ" & fila_imp.ToString & ":CA" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("BZ" & fila_imp.ToString & ":CA" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("CB" & fila_imp.ToString & ":CE" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CB" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("CB" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CB" & fila_imp.ToString & ":CE" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CB" & fila_imp.ToString & ":CE" & fila_imp.ToString).ShrinkToFit() = True
                End If

            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Mg" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("CF" & fila_imp.ToString & ":CI" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CF" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("CF" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CF" & fila_imp.ToString & ":CI" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CF" & fila_imp.ToString & ":CI" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("CJ" & fila_imp.ToString & ":CK" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CJ" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("CJ" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CJ" & fila_imp.ToString & ":CK" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CJ" & fila_imp.ToString & ":CK" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("CL" & fila_imp.ToString & ":CO" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CL" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("CL" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CL" & fila_imp.ToString & ":CO" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CL" & fila_imp.ToString & ":CO" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Zn" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("CP" & fila_imp.ToString & ":CS" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CP" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("CP" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CP" & fila_imp.ToString & ":CS" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CP" & fila_imp.ToString & ":CS" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("CT" & fila_imp.ToString & ":CU" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CT" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("CT" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CT" & fila_imp.ToString & ":CU" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CT" & fila_imp.ToString & ":CU" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("CV" & fila_imp.ToString & ":CY" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CV" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("CV" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CV" & fila_imp.ToString & ":CY" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CV" & fila_imp.ToString & ":CY" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Mn" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("CZ" & fila_imp.ToString & ":DC" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("CZ" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("CZ" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("CZ" & fila_imp.ToString & ":DC" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("CZ" & fila_imp.ToString & ":DC" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("DD" & fila_imp.ToString & ":DE" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DD" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("DD" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DD" & fila_imp.ToString & ":DE" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DD" & fila_imp.ToString & ":DE" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("DF" & fila_imp.ToString & ":DI" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DF" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("DF" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DF" & fila_imp.ToString & ":DI" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DF" & fila_imp.ToString & ":DI" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Fe" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("DJ" & fila_imp.ToString & ":DM" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DJ" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("DJ" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DJ" & fila_imp.ToString & ":DM" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DJ" & fila_imp.ToString & ":DM" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("DN" & fila_imp.ToString & ":DO" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DN" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("DN" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DN" & fila_imp.ToString & ":DO" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DN" & fila_imp.ToString & ":DO" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("DP" & fila_imp.ToString & ":DS" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DP" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("DP" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DP" & fila_imp.ToString & ":DS" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DP" & fila_imp.ToString & ":DS" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Cu" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("DT" & fila_imp.ToString & ":DW" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DT" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("DT" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DT" & fila_imp.ToString & ":DW" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DT" & fila_imp.ToString & ":DW" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("DX" & fila_imp.ToString & ":DY" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DX" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("DX" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DX" & fila_imp.ToString & ":DY" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DX" & fila_imp.ToString & ":DY" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("DZ" & fila_imp.ToString & ":EC" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("DZ" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("DZ" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("DZ" & fila_imp.ToString & ":EC" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("DZ" & fila_imp.ToString & ":EC" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "B" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("ED" & fila_imp.ToString & ":EG" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("ED" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("ED" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("ED" & fila_imp.ToString & ":EG" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("ED" & fila_imp.ToString & ":EG" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("EH" & fila_imp.ToString & ":EI" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("EH" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("EH" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("EH" & fila_imp.ToString & ":EI" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("EH" & fila_imp.ToString & ":EI" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("EJ" & fila_imp.ToString & ":EM" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("EJ" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("EJ" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("EJ" & fila_imp.ToString & ":EM" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("EJ" & fila_imp.ToString & ":EM" & fila_imp.ToString).ShrinkToFit() = True
                End If

            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Cl" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("EN" & fila_imp.ToString & ":EQ" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("EN" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("EN" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("EN" & fila_imp.ToString & ":EQ" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("EN" & fila_imp.ToString & ":EQ" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("ER" & fila_imp.ToString & ":ES" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("ER" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("ER" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("ER" & fila_imp.ToString & ":ES" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("ER" & fila_imp.ToString & ":ES" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("ET" & fila_imp.ToString & ":EW" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("ET" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("ET" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("ET" & fila_imp.ToString & ":EW" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("ET" & fila_imp.ToString & ":EW" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            If FILA_IMPR("COD_ELE_RANGO") = "Na" Then
                If FILA_IMPR("RANGO_DESDE") <> "" Then
                    HOJA_EXCEL.Range("EX" & fila_imp.ToString & ":FA" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("EX" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_DESDE")
                    HOJA_EXCEL.Range("EX" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("EX" & fila_imp.ToString & ":FA" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("EX" & fila_imp.ToString & ":FA" & fila_imp.ToString).ShrinkToFit() = True

                End If
                If FILA_IMPR("SIMBOLO") <> "" Then
                    HOJA_EXCEL.Range("FB" & fila_imp.ToString & ":FC" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("FB" & fila_imp.ToString).Value = FILA_IMPR("SIMBOLO")
                    HOJA_EXCEL.Range("FB" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("FB" & fila_imp.ToString & ":FC" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("FB" & fila_imp.ToString & ":FC" & fila_imp.ToString).ShrinkToFit() = True
                End If
                If FILA_IMPR("RANGO_HASTA") <> "" Then
                    HOJA_EXCEL.Range("FD" & fila_imp.ToString & ":FG" & fila_imp.ToString).Merge()
                    HOJA_EXCEL.Range("FD" & fila_imp.ToString).Value = "'" & FILA_IMPR("RANGO_HASTA")
                    HOJA_EXCEL.Range("FD" & fila_imp.ToString).Font.Size = 7
                    HOJA_EXCEL.Range("FD" & fila_imp.ToString & ":FG" & fila_imp.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    HOJA_EXCEL.Range("FD" & fila_imp.ToString & ":FG" & fila_imp.ToString).ShrinkToFit() = True
                End If
            End If
            Esp_Aux = FILA_IMPR("COD_ESP")
        Next

        HOJA_EXCEL.Range("A" & fila_desde.ToString & ":W" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("X" & fila_desde.ToString & ":AG" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("AH" & fila_desde.ToString & ":AQ" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("AR" & fila_desde.ToString & ":BA" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("BB" & fila_desde.ToString & ":BK" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("BL" & fila_desde.ToString & ":BU" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("BV" & fila_desde.ToString & ":CE" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("CF" & fila_desde.ToString & ":CO" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("CP" & fila_desde.ToString & ":CY" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("CZ" & fila_desde.ToString & ":DI" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("DJ" & fila_desde.ToString & ":DS" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("DT" & fila_desde.ToString & ":EC" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("ED" & fila_desde.ToString & ":EM" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("EN" & fila_desde.ToString & ":EW" & fila_imp.ToString).BorderAround()
        HOJA_EXCEL.Range("EX" & fila_desde.ToString & ":FG" & fila_imp.ToString).BorderAround()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call graba_rango()
        Call graba_nota()
        MsgBox("Grabación de rangos Finalizada")
        Cjto_Tablas1.Tables("RANGO_DBF2").Clear()
        TextBox1.Text = ""
        TxtEspecie.Text = ""
    End Sub


    Private Sub graba_rango()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Rangos As DataRow

        For Each Fila_Rangos In Cjto_Tablas1.Tables("RANGO_DBF2").Rows
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
                .AgregarParametro("@Especie", TxtEspecie.Text, SqlDbType.NVarChar)
                .AgregarParametro("@CodEle", Fila_Rangos("COD_ELE_RANGO"), SqlDbType.NVarChar)
                .AgregarParametro("@Rango_Desde", Fila_Rangos("RANGO_DESDE"), SqlDbType.NVarChar)
                .AgregarParametro("@Simbolo", Fila_Rangos("SIMBOLO"), SqlDbType.NVarChar)
                .AgregarParametro("@Rango_Hasta", Fila_Rangos("RANGO_HASTA"), SqlDbType.NVarChar)
                .EjecutarQuery("usp_UpdateRangos")
            End With
        Next

    End Sub

    Private Sub graba_nota()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()
            .AgregarParametro("@Especie", TxtEspecie.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Descripcion", TextBox1.Text, SqlDbType.NVarChar)
            .EjecutarQuery("usp_UpdateNotaAutoResultados")
        End With
    End Sub

End Class
