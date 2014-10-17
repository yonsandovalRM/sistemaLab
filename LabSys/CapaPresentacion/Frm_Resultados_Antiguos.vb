Public Class Frm_Resultados_Antiguos
    Inherits System.Windows.Forms.Form
    Private CAMPO1, CAMPO2, CAMPO3, CAMPO4, MATRIZ_UNI2(50), Primera_Pasada As String
    Private custDS As DataSet
    Private workTable, workTable1 As DataTable
    Private TS1, TS2, TS3 As New DataGridTableStyle
    Private Cuenta_Elementos, Fila_Seleccion_Grilla, Columna_Seleccion_Grilla As Integer


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdAtras As System.Windows.Forms.Button
    Friend WithEvents DTGRevision As System.Windows.Forms.DataGrid
    Friend WithEvents CmdAdelante As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DTGRevision = New System.Windows.Forms.DataGrid
        Me.CmdAtras = New System.Windows.Forms.Button
        Me.CmdAdelante = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.DTGRevision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DTGRevision)
        Me.Panel1.Location = New System.Drawing.Point(0, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 336)
        Me.Panel1.TabIndex = 0
        '
        'DTGRevision
        '
        Me.DTGRevision.CaptionVisible = False
        Me.DTGRevision.DataMember = ""
        Me.DTGRevision.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGRevision.Location = New System.Drawing.Point(8, 8)
        Me.DTGRevision.Name = "DTGRevision"
        Me.DTGRevision.Size = New System.Drawing.Size(1264, 344)
        Me.DTGRevision.TabIndex = 0
        '
        'CmdAtras
        '
        Me.CmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.CmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAtras.Image = Global.LabSys.My.Resources.Resources.arrow_left
        Me.CmdAtras.Location = New System.Drawing.Point(728, 344)
        Me.CmdAtras.Name = "CmdAtras"
        Me.CmdAtras.Size = New System.Drawing.Size(80, 25)
        Me.CmdAtras.TabIndex = 1
        Me.CmdAtras.UseVisualStyleBackColor = False
        '
        'CmdAdelante
        '
        Me.CmdAdelante.BackColor = System.Drawing.Color.Transparent
        Me.CmdAdelante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdelante.Image = Global.LabSys.My.Resources.Resources.arrow_right
        Me.CmdAdelante.Location = New System.Drawing.Point(1192, 344)
        Me.CmdAdelante.Name = "CmdAdelante"
        Me.CmdAdelante.Size = New System.Drawing.Size(80, 25)
        Me.CmdAdelante.TabIndex = 2
        Me.CmdAdelante.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(808, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 25)
        Me.Label1.TabIndex = 3
        '
        'Frm_Resultados_Antiguos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1284, 373)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdAdelante)
        Me.Controls.Add(Me.CmdAtras)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Resultados_Antiguos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Resultados Anteriores"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DTGRevision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Crear_Tabla_Revision()
        Try

            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            Dim ds As DataSet = New DataSet
            Dim query, Union As String
            Dim Fila_Seleccion As DataRow
            custDS = New DataSet
            workTable = custDS.Tables.Add("TABLA_REVISION2")
            'CREA TABLA_ELE ***************************************************************
            workTable.Columns.Add("OT_NUMERO", Type.GetType("System.String"))
            workTable.Columns.Add("MAS_OBSERVACIONES", Type.GetType("System.String"))
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

            With SP
                .Inicializar()
                .AgregarParametro("@NLab", NLabRevisionAnterior, SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectRevisionElementosAntiguos")
            End With

            For Each Fila_Seleccion In ds.Tables(0).Rows
                Cuenta_Elementos = Cuenta_Elementos + 1
                Union = Fila_Seleccion.Item(0)
                workTable.Columns.Add(Union, Type.GetType("System.Double"))
                MATRIZ_ELEMENTOS2(Cuenta_Elementos) = Fila_Seleccion.Item(0)
                MATRIZ_ELEMENTOS_DESPLIEGUE2(Cuenta_Elementos) = Fila_Seleccion.Item(1)
                MATRIZ_UNI2(Cuenta_Elementos) = Fila_Seleccion.Item(3)
            Next

            Dim workCol As DataColumn = workTable.Columns.Add("FILA", Type.GetType("System.Int32"))
            workCol.AllowDBNull = False
            workCol.Unique = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Crear_Grilla_Revision()
        Try
            DTGRevision.TableStyles.Remove(DTGRevision.TableStyles(0))
        Catch ex As Exception
        End Try

        Dim hh As Integer
        Dim f As New System.Drawing.Font("Verdana", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        DTGRevision.HeaderFont = f

        TS3 = New DataGridTableStyle
        TS3.MappingName = "TABLA_REVISION2"
        '
        Dim elemento1 As New DataGridTextBoxColumn
        elemento1.MappingName = "OT_NUMERO"
        elemento1.HeaderText = "N°" & vbCrLf & "OT"
        elemento1.NullText = ""
        elemento1.Width = 50
        TS3.GridColumnStyles.Add(elemento1)

        Dim elemento2 As New DataGridTextBoxColumn
        elemento2.MappingName = "MAS_OBSERVACIONES"
        elemento2.HeaderText = "O"
        elemento2.NullText = ""
        elemento2.Width = 13
        TS3.GridColumnStyles.Add(elemento2)

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
        If CodMuestraRev = 4000 Then Call Columnas_Suelo(TS3)
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

        For hh = Contador_De_Posicion To Cuenta_Elementos
            Dim elemento18 As New DataGridTextBoxColumn
            elemento18.MappingName = MATRIZ_ELEMENTOS2(hh)
            elemento18.HeaderText = MATRIZ_ELEMENTOS_DESPLIEGUE2(hh) & vbCrLf & MATRIZ_UNI2(hh)
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

    Private Sub Frm_Resultados_Antiguos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg2 As String
        Dim Alto_Grillas, Ancho_Ele As Integer
        Dim frmEsp As New Frm_Espere
        Cjto_Tablas1.Tables("TABLA_ESTADO2").Rows.Clear()
        Cjto_Tablas1.Tables("CICLO_NLAB2").Clear()
        Cjto_Tablas1.Tables("TABLA_ESTADO_DUPLICADOS2").Rows.Clear()
        DTGRevision.TableStyles.Clear()
        TS1.GridColumnStyles.Clear()
        TS2.GridColumnStyles.Clear()
        Cuenta_Elementos = 0
        ReDim MATRIZ_ELEMENTOS2(100)
        ReDim MATRIZ_ELEMENTOS_DESPLIEGUE2(100)
        ReDim MATRIZ_NLAB2(200)
        sMsg2 = "Rescatando Elementos Antiguos segun productor seleccionado"
        frmEsp.lblMsg2.Text = sMsg2
        frmEsp.Show()
        frmEsp.Refresh()
        Call Crear_Tabla_Revision()
        Call Crear_Grilla_Revision()
        Call Tabla_Grilla()
        AddCellFormattingColumnStyles(Me.DTGRevision, New FormatCellEventHandler(AddressOf FormatGridCells))
        Call Llena_datos()
        frmEsp.Close()
    End Sub
    Private Sub Tabla_Grilla()
        DTGRevision.DataSource = custDS.Tables("TABLA_REVISION2")
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
                Dim cs2 As New Color_Revision2(grid.TableStyles(0).GridColumnStyles(j).MappingName, j)
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
    End Sub

    Private Sub Llena_datos()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Fila_Grilla, Fila_Ciclo, Fila_Elementos, Fila_SelecElem, Fila_ElemPrio As DataRow
        Dim Hay_Duplicado, Cuartel1, Cuartel2, query, Observaciones, Predio, Remite, Productor, Localidad, Especie, Variedad, Urgencia, Mas, Fecha, OT As String
        Dim HH, jj, Orden_Aux, Cuenta_l As Integer
        Dim dbman As DbManager
        Dim BusElem(1) As Object

        With SP
            .Inicializar()
            .AgregarParametro("@NLab", NLabRevisionAnterior, SqlDbType.Int)
            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectRevisionNLabAnteriores", Cjto_Tablas1, "CICLO_NLAB2")
        End With

        Orden_Aux = 0
        Cuenta_l = 0
        For Each Fila_Ciclo In Cjto_Tablas1.Tables("CICLO_NLAB2").Rows
            Mas = " "
            Observaciones = " "
            Cuenta_l = Cuenta_l + 1
            Fila_Grilla = custDS.Tables("TABLA_REVISION2").NewRow
            If Orden_Aux = 0 Or Orden_Aux <> Fila_Ciclo("OT_NUMERO") Then

                'DATOS DE ORDEN ************************

                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", CInt(Fila_Ciclo("OT_NUMERO")), SqlDbType.Int)
                    ds = .EjecutarQuery("usp_SelectRevisionOrdenTrabajoHistorico")
                End With
                Try
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_NUMERO")) = False Then Fila_Grilla("OT_NUMERO") = ds.Tables(0).Rows(0).Item("OT_NUMERO") Else OT = 0
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_DESP_URGENTE")) = False Then
                        If ds.Tables(0).Rows(0).Item("OT_DESP_URGENTE") = True Then Fila_Grilla("OT_NUMERO") = Fila_Grilla("OT_NUMERO") & "u"
                    End If
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_OBSERVACIONES")) = False Then
                        If Len(ds.Tables(0).Rows(0).Item("OT_OBSERVACIONES")) <> 0 Then Observaciones = "x"
                    End If
                    Fila_Grilla("MAS_OBSERVACIONES") = Observaciones
                    'Fila_Grilla("URGENCIA") = ""

                    'If IsDBNull(ds.Tables(0).Rows(0).Item("OT_DESP_URGENTE")) = False Then
                    '    If ds.Tables(0).Rows(0).Item("OT_DESP_URGENTE") = True Then Fila_Grilla("URGENCIA") = "u"
                    'End If

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


            '**************************
            ' DIGITA_RESULTADOS 
            '**************************
            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectRevisionElementoxNLabHistorico")
            End With
            Try
                For Each Fila_SelecElem In ds.Tables(0).Rows
                    For HH = 1 To Cuenta_Elementos
                        If Fila_SelecElem("ELE_CODIGO") = MATRIZ_ELEMENTOS2(HH) Then
                            If IsDBNull(Fila_SelecElem("DIGRES_RESULTADO")) = False Then Fila_Grilla(MATRIZ_ELEMENTOS2(HH)) = CStr(Fila_SelecElem("DIGRES_RESULTADO")) : Exit For
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
            End Try

            Fila_Grilla("MAS_ELEMENTOS") = Mas
            Fila_Grilla("FILA") = Cuenta_l
            custDS.Tables("TABLA_REVISION2").Rows.Add(Fila_Grilla)

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
                        If Fila_SelecElem("ELE_CODIGO") = MATRIZ_ELEMENTOS2(HH) Then
                            If IsDBNull(Fila_SelecElem("DIGRES_RESULTADO")) = False Then
                                If Primera_Pasada = "S" Then Fila_Grilla = custDS.Tables("TABLA_REVISION").NewRow
                                Hay_Duplicado = "S"
                                Fila_Grilla(MATRIZ_ELEMENTOS2(HH)) = CStr(Fila_SelecElem("DIGRES_RESULTADO"))
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
                custDS.Tables("TABLA_REVISION2").Rows.Add(Fila_Grilla)
            End If

            ' Lleno tabla TABLA_ESTADO PARA MANEJAR ESTADO TRANSACCIONALMENTE "NO GRABARLOS" EN FORMA INMEDIATA 

            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectRevisionElementoEstados", Cjto_Tablas1, "TABLA_ESTADO2")
            End With
            With SP
                .Inicializar()
                .AgregarParametro("@NLab", CInt(Fila_Ciclo("OT_NLAB")), SqlDbType.Int)
                .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectRevisionElementoEstadosDuplicados", Cjto_Tablas1, "TABLA_ESTADO_DUPLICADOS2")
            End With
        Next
        '        Alto_EncDato = Cuenta_l
    End Sub

    Private Sub LLeno_Antecedentes(ByVal OTN As Integer, ByVal OTNLAB As Integer, ByRef Fila_Grilla As DataRow)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Cuar1, Cuar2 As String
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", OTN, SqlDbType.Int)
            .AgregarParametro("@NLab", OTNLAB, SqlDbType.Int)
            .AgregarParametro("@TMuestra", CodMuestraRev, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectRevisionLlenoAntecedentesHistorico")
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
                If CAMPO4 <> ds.Tables(0).Rows(0).Item("CAMPO4") Then Fila_Grilla("CAMPO4") = ds.Tables(0).Rows(0).Item("CAMPO4") : CAMPO4 = ds.Tables(0).Rows(0).Item("CAMPO4") Else Fila_Grilla("CAMPO4") = " "
            Else
                Fila_Grilla("CAMPO4") = " "
            End If


            If IsDBNull(ds.Tables(0).Rows(0).Item("IDENTIFICACION1")) = False Then Cuar1 = ds.Tables(0).Rows(0).Item("IDENTIFICACION1") Else Cuar1 = " "
            If IsDBNull(ds.Tables(0).Rows(0).Item("IDENTIFICACION2")) = False Then Cuar2 = ds.Tables(0).Rows(0).Item("IDENTIFICACION2") Else Cuar2 = " "

            Fila_Grilla("IDENTIFICACION") = Cuar1 & Cuar2

            If IsDBNull(ds.Tables(0).Rows(0).Item("OBSERVACIONES")) = False Then Fila_Grilla("MAS_OBSERVACIONES") = "O"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub CmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAtras.Click
        Dim mycell As New DataGridCell
        If Contador_De_Posicion2 > 1 Then
            Contador_De_Posicion2 = Contador_De_Posicion2 - 1
            Call Crear_Grilla_Revision()
            AddCellFormattingColumnStyles(Me.DTGRevision, New FormatCellEventHandler(AddressOf FormatGridCells))
            mycell.ColumnNumber = 12
            mycell.RowNumber = Fila_Seleccion_Grilla
            DTGRevision.CurrentCell = mycell
            DTGRevision.Focus()
        End If
    End Sub

    Private Sub CmdAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdelante.Click
        Dim mycell As New DataGridCell
        If Contador_De_Posicion2 < Cuenta_Elementos Then
            Contador_De_Posicion2 = Contador_De_Posicion2 + 1
            Call Crear_Grilla_Revision()
            AddCellFormattingColumnStyles(Me.DTGRevision, New FormatCellEventHandler(AddressOf FormatGridCells))
            mycell.ColumnNumber = 12
            mycell.RowNumber = Fila_Seleccion_Grilla
            DTGRevision.CurrentCell = mycell
            DTGRevision.Focus()
        End If
    End Sub

End Class
