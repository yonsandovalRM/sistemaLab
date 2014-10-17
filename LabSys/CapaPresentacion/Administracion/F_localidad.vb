Imports System.Data.SqlClient
Public Class frm_localidad
    Inherits System.Windows.Forms.Form
    Dim fila_combo, le As Integer
    Friend WithEvents Label69 As System.Windows.Forms.Label

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
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents dtg_localidad As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dtg_localida As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dtg_comuna As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dtg_ciudad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dtg_provincia As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dtg_region As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dtg_regnom As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BuscarNombre As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TxtAyuda As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtg_localidad = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dtg_localida = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dtg_comuna = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dtg_ciudad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dtg_provincia = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dtg_region = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dtg_regnom = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BuscarNombre = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtAyuda = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Label69 = New System.Windows.Forms.Label
        CType(Me.dtg_localidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtg_localidad
        '
        Me.dtg_localidad.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg_localidad.CaptionVisible = False
        Me.dtg_localidad.DataMember = ""
        Me.dtg_localidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg_localidad.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtg_localidad.Location = New System.Drawing.Point(20, 8)
        Me.dtg_localidad.Name = "dtg_localidad"
        Me.dtg_localidad.PreferredColumnWidth = 150
        Me.dtg_localidad.Size = New System.Drawing.Size(1011, 664)
        Me.dtg_localidad.TabIndex = 34
        Me.dtg_localidad.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dtg_localidad
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dtg_localida, Me.dtg_comuna, Me.dtg_ciudad, Me.dtg_provincia, Me.dtg_region, Me.dtg_regnom, Me.DataGridTextBoxColumn1})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "LOCALIDAD_LABSYS"
        '
        'dtg_localida
        '
        Me.dtg_localida.Format = ""
        Me.dtg_localida.FormatInfo = Nothing
        Me.dtg_localida.HeaderText = "Localidad"
        Me.dtg_localida.MappingName = "LOCALIDAD"
        Me.dtg_localida.NullText = ""
        Me.dtg_localida.Width = 160
        '
        'dtg_comuna
        '
        Me.dtg_comuna.Format = ""
        Me.dtg_comuna.FormatInfo = Nothing
        Me.dtg_comuna.HeaderText = "Comuna"
        Me.dtg_comuna.MappingName = "COMUNA"
        Me.dtg_comuna.NullText = ""
        Me.dtg_comuna.Width = 160
        '
        'dtg_ciudad
        '
        Me.dtg_ciudad.Format = ""
        Me.dtg_ciudad.FormatInfo = Nothing
        Me.dtg_ciudad.HeaderText = "Ciudad"
        Me.dtg_ciudad.MappingName = "CIUDAD"
        Me.dtg_ciudad.NullText = ""
        Me.dtg_ciudad.Width = 160
        '
        'dtg_provincia
        '
        Me.dtg_provincia.Format = ""
        Me.dtg_provincia.FormatInfo = Nothing
        Me.dtg_provincia.HeaderText = "Provincia"
        Me.dtg_provincia.MappingName = "PROVINCIA"
        Me.dtg_provincia.NullText = ""
        Me.dtg_provincia.Width = 160
        '
        'dtg_region
        '
        Me.dtg_region.Format = ""
        Me.dtg_region.FormatInfo = Nothing
        Me.dtg_region.HeaderText = "Región"
        Me.dtg_region.MappingName = "REGION"
        Me.dtg_region.NullText = ""
        Me.dtg_region.Width = 70
        '
        'dtg_regnom
        '
        Me.dtg_regnom.Format = ""
        Me.dtg_regnom.FormatInfo = Nothing
        Me.dtg_regnom.HeaderText = "Nombre Región"
        Me.dtg_regnom.MappingName = "REG_NOMBRE"
        Me.dtg_regnom.NullText = ""
        Me.dtg_regnom.Width = 180
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cod.Area"
        Me.DataGridTextBoxColumn1.MappingName = "COD_AREA"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 40
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Label69)
        Me.GroupBox3.Controls.Add(Me.BuscarNombre)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(100, -8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(824, 56)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'BuscarNombre
        '
        Me.BuscarNombre.BackColor = System.Drawing.Color.Transparent
        Me.BuscarNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarNombre.Image = Global.LabSys.My.Resources.Resources.find
        Me.BuscarNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarNombre.Location = New System.Drawing.Point(614, 27)
        Me.BuscarNombre.Name = "BuscarNombre"
        Me.BuscarNombre.Size = New System.Drawing.Size(115, 24)
        Me.BuscarNombre.TabIndex = 3
        Me.BuscarNombre.Text = "Buscar Siguiente"
        Me.BuscarNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarNombre.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button9.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(805, 8)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(19, 16)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "X"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(64, 28)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(544, 20)
        Me.TextBox3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buscar:"
        '
        'TxtAyuda
        '
        Me.TxtAyuda.BackColor = System.Drawing.Color.Transparent
        Me.TxtAyuda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAyuda.Location = New System.Drawing.Point(8, 680)
        Me.TxtAyuda.Name = "TxtAyuda"
        Me.TxtAyuda.Size = New System.Drawing.Size(24, 22)
        Me.TxtAyuda.TabIndex = 37
        Me.TxtAyuda.Text = "?"
        Me.TxtAyuda.UseVisualStyleBackColor = False
        Me.TxtAyuda.Visible = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = Global.LabSys.My.Resources.Resources.find
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button11.Location = New System.Drawing.Point(40, 680)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(24, 22)
        Me.Button11.TabIndex = 36
        Me.Button11.UseVisualStyleBackColor = False
        Me.Button11.Visible = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Transparent
        Me.Button20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button20.Location = New System.Drawing.Point(656, 680)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(80, 24)
        Me.Button20.TabIndex = 31
        Me.Button20.Text = "Grabar"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.Transparent
        Me.Button27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Image = Global.LabSys.My.Resources.Resources.add
        Me.Button27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button27.Location = New System.Drawing.Point(744, 680)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(80, 24)
        Me.Button27.TabIndex = 32
        Me.Button27.Text = "Agregar"
        Me.Button27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.Transparent
        Me.Button29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Image = Global.LabSys.My.Resources.Resources.cancel
        Me.Button29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button29.Location = New System.Drawing.Point(832, 680)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(80, 24)
        Me.Button29.TabIndex = 33
        Me.Button29.Text = "Eliminar"
        Me.Button29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label69.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label69.Location = New System.Drawing.Point(2, 8)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(822, 17)
        Me.Label69.TabIndex = 15
        Me.Label69.Text = "Busca Nombre"
        '
        'frm_localidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1048, 713)
        Me.Controls.Add(Me.TxtAyuda)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.dtg_localidad)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button29)
        Me.Name = "frm_localidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor Localidad"
        CType(Me.dtg_localidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frm_localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call anti_elimina_lineas()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Cjto_Tablas1.Tables("LOCALIDAD_LABSYS").Clear()
        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_SelectLocalidadesxLocalidad", Cjto_Tablas1, "LOCALIDAD_LABSYS")
        End With
    End Sub
    Private Sub anti_elimina_lineas()
        Me.dtg_localidad.DataSource = Cjto_Tablas1.Tables("LOCALIDAD_LABSYS")
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Grilla As Integer
        Dim Loca, Comu As String
        Dim respuesta As MsgBoxResult
        Fila_Grilla = dtg_localidad.CurrentCell.RowNumber()
        Loca = dtg_localidad.Item(Fila_Grilla, 0)
        Comu = dtg_localidad.Item(Fila_Grilla, 1)

        respuesta = MsgBox("Esta seguro la localidad : " & Loca & " Comuna : " & Comu, MsgBoxStyle.YesNo)

        If respuesta = MsgBoxResult.Yes Then
            With SP
                .Inicializar()
                .AgregarParametro("@Loca", Loca, SqlDbType.NVarChar)
                .AgregarParametro("@Comu", Comu, SqlDbType.NVarChar)
                .EjecutarQuery("usp_DeleteLocalidad")
            End With
        End If
        Cjto_Tablas1.Tables("LOCALIDAD_LABSYS").Clear()
        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_SelectLocalidadesxLocalidad", Cjto_Tablas1, "LOCALIDAD_LABSYS")
        End With
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Call Graba_Todas()
        Cjto_Tablas1.Tables("LOCALIDAD_LABSYS").Clear()
        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_SelectLocalidadesxLocalidad", Cjto_Tablas1, "LOCALIDAD_LABSYS")
        End With
        MsgBox("Grabacion finalizada")
    End Sub
    Private Sub Graba_Todas()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim FILA_DATAROW, dr As DataRow
        Dim fila, tmu_codigo, sub_codigo As Integer
        For Each FILA_DATAROW In Cjto_Tablas1.Tables("LOCALIDAD_LABSYS").Rows
            With SP
                .Inicializar()
                .AgregarParametro("@Localidad", FILA_DATAROW("LOCALIDAD"), SqlDbType.NVarChar)
                .AgregarParametro("@Comuna", FILA_DATAROW("COMUNA"), SqlDbType.NVarChar)
                .AgregarParametro("@Ciudad", FILA_DATAROW("CIUDAD"), SqlDbType.NVarChar)
                .AgregarParametro("@Provincia", FILA_DATAROW("PROVINCIA"), SqlDbType.NVarChar)
                .AgregarParametro("@Region", FILA_DATAROW("REGION"), SqlDbType.Int)
                .AgregarParametro("@Reg_Nombre", FILA_DATAROW("REG_NOMBRE"), SqlDbType.NVarChar)
                .AgregarParametro("@Cod_Area", FILA_DATAROW("COD_AREA"), SqlDbType.NVarChar)
                .EjecutarQuery("usp_UpdateLocalidades")
            End With
        Next
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = dtg_localidad.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        dtg_localidad.CurrentCell = mycell
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        GroupBox3.Visible = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        GroupBox3.Visible = True
        TextBox3.Focus()
        le = 0
    End Sub

    Private Sub BuscarNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarNombre.Click
        Dim yll, texto, buscat As String
        Dim av, MyPos, filmax As Integer
        Dim FILA_DATAROW As DataRow
        Dim mycell As New DataGridCell
        texto = TextBox3.Text
        av = 0
        For Each FILA_DATAROW In Cjto_Tablas1.Tables("LOCALIDAD_LABSYS").Rows
            buscat = UCase(FILA_DATAROW("LOCALIDAD"))
            MyPos = InStr(buscat, UCase(texto))
            If MyPos > 0 Then GoTo SaltoEnc
            buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
            MyPos = InStr(buscat, UCase(texto))
            If MyPos > 0 Then GoTo SaltoEnc
            buscat = UCase(FILA_DATAROW("COMUNA"))
            MyPos = InStr(buscat, UCase(texto))
            If MyPos > 0 Then GoTo SaltoEnc
            buscat = UCase(FILA_DATAROW("CIUDAD"))
            MyPos = InStr(buscat, UCase(texto))
            If MyPos > 0 Then GoTo SaltoEnc
            buscat = UCase(FILA_DATAROW("PROVINCIA"))
            MyPos = InStr(buscat, UCase(texto))
            If MyPos > 0 Then GoTo SaltoEnc
            buscat = UCase(FILA_DATAROW("REGION"))
            MyPos = InStr(buscat, UCase(texto))
            If MyPos > 0 Then GoTo SaltoEnc
            buscat = UCase(FILA_DATAROW("REG_NOMBRE"))
            MyPos = InStr(buscat, UCase(texto))
SaltoEnc:
            If MyPos > 0 And av > le Then
                mycell.ColumnNumber = 1
                mycell.RowNumber = av
                dtg_localidad.CurrentCell = mycell
                dtg_localidad.Focus()
                filmax = 1
                Exit For
            End If
            av = av + 1
        Next
        If filmax = 0 Then MsgBox("Busqueda Finalizada")
        le = av
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Button1.Click
        Me.Close()
    End Sub
End Class
