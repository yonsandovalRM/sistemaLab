Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class Frm_Yemas_Genera_Excel
    Inherits System.Windows.Forms.Form
    Public NYemas, TotalObs, TotalFru, numero_cargadores(20) As Integer
    Public nlab_inicial, nlab_final As String


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
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GRNotas As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Notas As System.Windows.Forms.DataGrid
    Friend WithEvents BTNBajo As System.Windows.Forms.Button
    Friend WithEvents RTxtNBajo As System.Windows.Forms.RichTextBox
    Friend WithEvents RTxtNMedio As System.Windows.Forms.RichTextBox
    Friend WithEvents BTNMedio As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtFechaInforme As System.Windows.Forms.TextBox
    Friend WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Friend WithEvents Odbc_Adapter_Myema As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTGenerar As System.Windows.Forms.Button
    Friend WithEvents TxtNIlab As System.Windows.Forms.TextBox
    Friend WithEvents TxtNFlab As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChBoxObs As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DGEstimado As System.Windows.Forms.DataGrid
    Friend WithEvents CC As LabSys.Cjto_Orden
    Friend WithEvents CmdGrabar As System.Windows.Forms.Button
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CC = New LabSys.Cjto_Orden
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtNIlab = New System.Windows.Forms.TextBox
        Me.TxtOrden = New System.Windows.Forms.TextBox
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtNFlab = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTGenerar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DGEstimado = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtFechaInforme = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GRNotas = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.CmdEliminar = New System.Windows.Forms.Button
        Me.CmdNuevo = New System.Windows.Forms.Button
        Me.CmdGrabar = New System.Windows.Forms.Button
        Me.DG_Notas = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.BTNBajo = New System.Windows.Forms.Button
        Me.RTxtNBajo = New System.Windows.Forms.RichTextBox
        Me.RTxtNMedio = New System.Windows.Forms.RichTextBox
        Me.BTNMedio = New System.Windows.Forms.Button
        Me.Odbc_Adapter_Myema = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.ChBoxObs = New System.Windows.Forms.CheckBox
        CType(Me.CC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGEstimado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRNotas.SuspendLayout()
        CType(Me.DG_Notas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CC
        '
        Me.CC.DataSetName = "Cjto_Orden"
        Me.CC.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº Laboratorio"
        '
        'TxtNIlab
        '
        Me.TxtNIlab.Location = New System.Drawing.Point(128, 48)
        Me.TxtNIlab.Name = "TxtNIlab"
        Me.TxtNIlab.Size = New System.Drawing.Size(64, 20)
        Me.TxtNIlab.TabIndex = 6
        '
        'TxtOrden
        '
        Me.TxtOrden.Location = New System.Drawing.Point(128, 16)
        Me.TxtOrden.Name = "TxtOrden"
        Me.TxtOrden.Size = New System.Drawing.Size(64, 20)
        Me.TxtOrden.TabIndex = 5
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=DESARROLLO;packet size=4096;user id=sa;data source=AGROSERV;persis" & _
            "t security info=True;initial catalog=AGROLAB_PRUEBA;password=sa"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nº Orden"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(96, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Del"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(200, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Al"
        '
        'TxtNFlab
        '
        Me.TxtNFlab.Location = New System.Drawing.Point(224, 48)
        Me.TxtNFlab.Name = "TxtNFlab"
        Me.TxtNFlab.Size = New System.Drawing.Size(64, 20)
        Me.TxtNFlab.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtOrden)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNIlab)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNFlab)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 160)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'BTGenerar
        '
        Me.BTGenerar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTGenerar.Location = New System.Drawing.Point(824, 128)
        Me.BTGenerar.Name = "BTGenerar"
        Me.BTGenerar.Size = New System.Drawing.Size(88, 23)
        Me.BTGenerar.TabIndex = 18
        Me.BTGenerar.Text = "Generar Excel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DGEstimado)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 160)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(224, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Largo Cargador"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(104, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nº Cargador"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGEstimado
        '
        Me.DGEstimado.CaptionVisible = False
        Me.DGEstimado.DataMember = ""
        Me.DGEstimado.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGEstimado.Location = New System.Drawing.Point(8, 40)
        Me.DGEstimado.Name = "DGEstimado"
        Me.DGEstimado.Size = New System.Drawing.Size(344, 112)
        Me.DGEstimado.TabIndex = 9
        Me.DGEstimado.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DGEstimado
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ESTIMADOBRO"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nº Lab"
        Me.DataGridTextBoxColumn4.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Desde Carg"
        Me.DataGridTextBoxColumn5.MappingName = "CARGADOR_DESDE"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Hasta Car"
        Me.DataGridTextBoxColumn6.MappingName = "CARGADOR_HASTA"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 60
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Desde Yem"
        Me.DataGridTextBoxColumn7.MappingName = "YEMA_DESDE"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 64
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Hasta Yem"
        Me.DataGridTextBoxColumn8.MappingName = "YEMA_HASTA"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 60
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(80, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "N° Estimado de Brotes con racimo/parra"
        '
        'TxtFechaInforme
        '
        Me.TxtFechaInforme.Location = New System.Drawing.Point(848, 16)
        Me.TxtFechaInforme.Name = "TxtFechaInforme"
        Me.TxtFechaInforme.Size = New System.Drawing.Size(64, 20)
        Me.TxtFechaInforme.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(768, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Fecha Informe"
        '
        'GRNotas
        '
        Me.GRNotas.Controls.Add(Me.Button2)
        Me.GRNotas.Controls.Add(Me.Button1)
        Me.GRNotas.Controls.Add(Me.CmdEliminar)
        Me.GRNotas.Controls.Add(Me.CmdNuevo)
        Me.GRNotas.Controls.Add(Me.CmdGrabar)
        Me.GRNotas.Controls.Add(Me.DG_Notas)
        Me.GRNotas.Controls.Add(Me.BTNBajo)
        Me.GRNotas.Controls.Add(Me.RTxtNBajo)
        Me.GRNotas.Controls.Add(Me.RTxtNMedio)
        Me.GRNotas.Controls.Add(Me.BTNMedio)
        Me.GRNotas.Location = New System.Drawing.Point(0, 160)
        Me.GRNotas.Name = "GRNotas"
        Me.GRNotas.Size = New System.Drawing.Size(920, 608)
        Me.GRNotas.TabIndex = 20
        Me.GRNotas.TabStop = False
        Me.GRNotas.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(8, 520)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Borra"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(8, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Borra"
        '
        'CmdEliminar
        '
        Me.CmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdEliminar.Location = New System.Drawing.Point(752, 336)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(72, 23)
        Me.CmdEliminar.TabIndex = 8
        Me.CmdEliminar.Text = "Eliminar"
        '
        'CmdNuevo
        '
        Me.CmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdNuevo.Location = New System.Drawing.Point(664, 336)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(72, 23)
        Me.CmdNuevo.TabIndex = 7
        Me.CmdNuevo.Text = "Nuevo"
        '
        'CmdGrabar
        '
        Me.CmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmdGrabar.Location = New System.Drawing.Point(840, 336)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.Size = New System.Drawing.Size(72, 23)
        Me.CmdGrabar.TabIndex = 6
        Me.CmdGrabar.Text = "Grabar"
        '
        'DG_Notas
        '
        Me.DG_Notas.CaptionVisible = False
        Me.DG_Notas.DataMember = "NOTA_YEMAS"
        Me.DG_Notas.DataSource = Me.CC
        Me.DG_Notas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_Notas.Location = New System.Drawing.Point(8, 8)
        Me.DG_Notas.Name = "DG_Notas"
        Me.DG_Notas.Size = New System.Drawing.Size(904, 320)
        Me.DG_Notas.TabIndex = 5
        Me.DG_Notas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DG_Notas
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn1})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "NOTA_YEMAS"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Código"
        Me.DataGridTextBoxColumn3.MappingName = "COD_NYEM"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "DES_NYEM"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 700
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nivel"
        Me.DataGridTextBoxColumn1.MappingName = "NIV_NYEM"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 40
        '
        'BTNBajo
        '
        Me.BTNBajo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNBajo.Location = New System.Drawing.Point(8, 488)
        Me.BTNBajo.Name = "BTNBajo"
        Me.BTNBajo.Size = New System.Drawing.Size(48, 23)
        Me.BTNBajo.TabIndex = 3
        Me.BTNBajo.Text = "Bajo"
        '
        'RTxtNBajo
        '
        Me.RTxtNBajo.Location = New System.Drawing.Point(56, 488)
        Me.RTxtNBajo.Name = "RTxtNBajo"
        Me.RTxtNBajo.Size = New System.Drawing.Size(856, 112)
        Me.RTxtNBajo.TabIndex = 2
        Me.RTxtNBajo.Text = ""
        '
        'RTxtNMedio
        '
        Me.RTxtNMedio.Location = New System.Drawing.Point(56, 368)
        Me.RTxtNMedio.Name = "RTxtNMedio"
        Me.RTxtNMedio.Size = New System.Drawing.Size(856, 120)
        Me.RTxtNMedio.TabIndex = 1
        Me.RTxtNMedio.Text = ""
        '
        'BTNMedio
        '
        Me.BTNMedio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNMedio.Location = New System.Drawing.Point(8, 368)
        Me.BTNMedio.Name = "BTNMedio"
        Me.BTNMedio.Size = New System.Drawing.Size(48, 23)
        Me.BTNMedio.TabIndex = 0
        Me.BTNMedio.Text = "Medio"
        '
        'Odbc_Adapter_Myema
        '
        Me.Odbc_Adapter_Myema.SelectCommand = Me.OdbcSelectCommand1
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "select * from MYEMA WHERE IORD=?"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("ORDEN", System.Data.Odbc.OdbcType.VarChar, 10, "IORD")})
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "MaxBufferSize=2048;FIL=dBase 5.0;DSN=PRUEBA_DBF;PageTimeout=5;DefaultDir=P:\APPS\" & _
            "SISTEMAS\AGROLAB;DBQ=P:\APPS\SISTEMAS\AGROLAB;DriverId=533"
        '
        'ChBoxObs
        '
        Me.ChBoxObs.Location = New System.Drawing.Point(792, 56)
        Me.ChBoxObs.Name = "ChBoxObs"
        Me.ChBoxObs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChBoxObs.Size = New System.Drawing.Size(120, 16)
        Me.ChBoxObs.TabIndex = 21
        Me.ChBoxObs.Text = "Observaciones"
        '
        'Frm_Yemas_Genera_Excel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(928, 773)
        Me.Controls.Add(Me.ChBoxObs)
        Me.Controls.Add(Me.GRNotas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTGenerar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtFechaInforme)
        Me.Name = "Frm_Yemas_Genera_Excel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Yemas_Genera_Excel"
        CType(Me.CC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGEstimado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRNotas.ResumeLayout(False)
        CType(Me.DG_Notas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub BTNMedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMedio.Click
        Dim Form_notas As New Notas
        boton_notas_yemas = 1
        Obs2 = RTxtNMedio.Text
        Cjto_Orden1.Tables("NOTA_YEMAS").Clear()
        Dim Test1 As DbManager = New DbManager("NOTA_YEMAS", Conexion1_Real)
        Dim query1 As String = "Select NIV_NYEM,COD_NYEM,DES_NYEM from NOTA_YEMAS"
        Test1.Selecccionar(Cjto_Orden1, query1)
        Me.TransformaMultilinea(Me.DG_Notas)
    End Sub
    Private Sub BTNBajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBajo.Click
        Dim Form_notas As New Notas
        boton_notas_yemas = 2
        Obs2 = RTxtNBajo.Text
        Cjto_Orden1.Tables("NOTA_YEMAS").Clear()
        Dim Test1 As DbManager = New DbManager("NOTA_YEMAS", Conexion1_Real)
        Dim query1 As String = "Select NIV_NYEM,COD_NYEM,DES_NYEM from NOTA_YEMAS"
        Test1.Selecccionar(Cjto_Orden1, query1)
        Me.TransformaMultilinea(Me.DG_Notas)
    End Sub
    Private Sub Anti_Elimina_lineas()
        Me.DG_Notas.DataSource = Cjto_Orden1.Tables("NOTA_YEMAS")
        Me.DGEstimado.DataSource = Cjto_Orden1.Tables("ESTIMADOBRO")
    End Sub
    Private Sub DG_Notas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DG_Notas.DoubleClick
        Dim FILA As Integer
        Dim a As String
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        FILA = myGrid.CurrentCell.RowNumber
        Select Case boton_notas_yemas
            Case 1
                If RTxtNMedio.Text <> "" Then
                    RTxtNMedio.Text = RTxtNMedio.Text & Chr(13) & Chr(13) & DG_Notas.Item(FILA, 1)
                Else
                    RTxtNMedio.Text = DG_Notas.Item(FILA, 1)
                End If
            Case 2
                If RTxtNBajo.Text <> "" Then
                    RTxtNBajo.Text = RTxtNBajo.Text & Chr(13) & Chr(13) & DG_Notas.Item(FILA, 1)
                Else
                    RTxtNBajo.Text = DG_Notas.Item(FILA, 1)
                End If
        End Select
    End Sub

    Private Sub TransformaMultilinea(ByVal grid As DataGrid)
        Dim ts As DataGridTableStyle
        ts = New DataGridTableStyle
        Dim dt As DataTable
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j As Integer
        j = 0
        Do While (j < dt.Columns.Count)
            Dim cs As New Multilinea(grid.TableStyles(0).GridColumnStyles(j).MappingName)
            cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
            cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
            ts.GridColumnStyles.Add(cs)
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub
    Private Sub BTGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTGenerar.Click
        Dim FILA_YEMAS, Fila_MYemas As DataRow
        Dim myselectquery, consulta_nota, carga1, Productor As String
        Dim estabien As Boolean = True
        Dim SwichNumeroYemas As Boolean = False
        Dim ULTIMA_COTIZACION As Double
        Dim ULT_MAS_UNA, numero_coti, cargador_formato, NumeroYemasMaximo As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Call Revisa_Cargadores20(estabien)
        If estabien = False Then GoTo nogenera
        Cjto_Orden1.Tables("MYEMA").Clear()


        ' ******************** Para sistema Labsys ***********************

        With SP
            .Inicializar()
            .AgregarParametro("@NumOT", CInt(TxtOrden.Text), SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectAntecedentesYemas", Cjto_Orden1, "MYEMA")
        End With

        '*****************************************************************

        'Me.OdbcSelectCommand1.Parameters("ORDEN").Value = TxtOrden.Text
        'Odbc_Adapter_Myema.Fill(Cjto_Orden1, "MYEMA")


        For Each Fila_MYemas In Cjto_Orden1.Tables("MYEMA").Rows
            Productor = Fila_MYemas("IPRO")
            If Productor <> "" Then Exit For
        Next
        cargador_formato = 0
        Call Calcular(cargador_formato, NumeroYemasMaximo)
        Call Genera_Excel(NumeroYemasMaximo, Productor, cargador_formato)
        TxtOrden.Text = ""
        TxtNIlab.Text = ""
        TxtNFlab.Text = ""
        Cjto_Orden1.Tables("MYEMA").Clear()
        Cjto_Orden1.Tables("DIG_YEMAS").Clear()
        Cjto_Orden1.Tables("ESTIMADOBRO").Clear()
        Cjto_Orden1.Tables("LARGO_CARGADOR").Clear()
        TxtOrden.Focus()
nogenera:
    End Sub
    Private Sub Llena_DIG_YEMA()
        Dim FILA_YEMAS, FILA_LARGO As DataRow
        Dim consulta_nota, Paso, carga1 As String
        Dim Yema_Desde, Yema_Hasta, Aux_NLab As Integer
        SqlConnection2.Open()
        consulta_nota = "select OT_NUMERO,OT_NLAB,YEM_YEMA,YEM_CARGADOR1,YEM_CARGADOR2,YEM_CARGADOR3,YEM_CARGADOR4,YEM_CARGADOR5,YEM_CARGADOR6," & _
        "YEM_CARGADOR7,YEM_CARGADOR8,YEM_CARGADOR9,YEM_CARGADOR10,YEM_CARGADOR11,YEM_CARGADOR12," & _
        "YEM_CARGADOR13,YEM_CARGADOR14,YEM_CARGADOR15,YEM_CARGADOR16,YEM_CARGADOR17," & _
        "YEM_CARGADOR18,YEM_CARGADOR19,YEM_CARGADOR20,YEM_CARGADOR21,YEM_CARGADOR22," & _
        "YEM_CARGADOR23,YEM_CARGADOR24,YEM_CARGADOR25,YEM_CARGADOR26,YEM_CARGADOR27," & _
        "YEM_CARGADOR28,YEM_CARGADOR29,YEM_CARGADOR30,YEM_CARGADOR31,YEM_CARGADOR32," & _
        "YEM_CARGADOR33,YEM_CARGADOR34,YEM_CARGADOR35,YEM_CARGADOR36,YEM_CARGADOR37," & _
        "YEM_CARGADOR38,YEM_CARGADOR39,YEM_CARGADOR40 FROM DIG_YEMAS WHERE OT_NUMERO=" & "'" & TxtOrden.Text & "' AND OT_NLAB BETWEEN '" & TxtNIlab.Text & "' AND '" & TxtNFlab.Text & "'"
        Dim myCommand2 As New SqlCommand(consulta_nota, SqlConnection2)
        Dim myReader2 As SqlDataReader = myCommand2.ExecuteReader()
        NYemas = 0
        Yema_Desde = 2 : Yema_Hasta = 0 : Aux_NLab = 0
        While myReader2.Read()
            Paso = "N"
            If myReader2.GetInt32(1) <> Aux_NLab And Aux_NLab <> 0 Then
                FILA_LARGO = Cjto_Orden1.Tables("LARGO_CARGADOR").NewRow
                FILA_LARGO("OT_NLAB") = Aux_NLab
                FILA_LARGO("YEMA_DESDE") = 2
                FILA_LARGO("YEMA_HASTA") = Yema_Hasta
                Try
                    Cjto_Orden1.Tables("LARGO_CARGADOR").Rows.Add(FILA_LARGO)
                Catch ex As Exception
                End Try
                Yema_Hasta = 0
            End If
            NYemas = NYemas + 1
            FILA_YEMAS = Cjto_Orden1.Tables("DIG_YEMAS").NewRow
            FILA_YEMAS("OT_NUMERO") = myReader2.GetInt32(0)
            FILA_YEMAS("OT_NLAB") = myReader2.GetInt32(1)
            FILA_YEMAS("YEM_YEMA") = myReader2.GetInt32(2)
            Aux_NLab = FILA_YEMAS("OT_NLAB")
            Try
                If IsDBNull(myReader2.GetValue(3)) = False Then FILA_YEMAS("YEM_CARGADOR1") = Trim(myReader2.GetValue(3)) : carga1 = myReader2.GetValue(3) Else FILA_YEMAS("YEM_CARGADOR1") = ""
                If IsDBNull(myReader2.GetValue(4)) = False Then FILA_YEMAS("YEM_CARGADOR2") = Trim(myReader2.GetValue(4)) Else FILA_YEMAS("YEM_CARGADOR2") = ""
                If IsDBNull(myReader2.GetValue(5)) = False Then FILA_YEMAS("YEM_CARGADOR3") = Trim(myReader2.GetValue(5)) Else FILA_YEMAS("YEM_CARGADOR3") = ""
                If IsDBNull(myReader2.GetValue(6)) = False Then FILA_YEMAS("YEM_CARGADOR4") = Trim(myReader2.GetValue(6)) Else FILA_YEMAS("YEM_CARGADOR4") = ""
                If IsDBNull(myReader2.GetValue(7)) = False Then FILA_YEMAS("YEM_CARGADOR5") = Trim(myReader2.GetValue(7)) Else FILA_YEMAS("YEM_CARGADOR5") = ""
                If IsDBNull(myReader2.GetValue(8)) = False Then FILA_YEMAS("YEM_CARGADOR6") = Trim(myReader2.GetValue(8)) Else FILA_YEMAS("YEM_CARGADOR6") = ""
                If IsDBNull(myReader2.GetValue(9)) = False Then FILA_YEMAS("YEM_CARGADOR7") = Trim(myReader2.GetValue(9)) Else FILA_YEMAS("YEM_CARGADOR7") = ""
                If IsDBNull(myReader2.GetValue(10)) = False Then FILA_YEMAS("YEM_CARGADOR8") = Trim(myReader2.GetValue(10)) Else FILA_YEMAS("YEM_CARGADOR8") = ""
                If IsDBNull(myReader2.GetValue(11)) = False Then FILA_YEMAS("YEM_CARGADOR9") = Trim(myReader2.GetValue(11)) Else FILA_YEMAS("YEM_CARGADOR9") = ""
                If IsDBNull(myReader2.GetValue(12)) = False Then FILA_YEMAS("YEM_CARGADOR10") = Trim(myReader2.GetValue(12)) Else FILA_YEMAS("YEM_CARGADOR10") = ""
                If IsDBNull(myReader2.GetValue(13)) = False Then FILA_YEMAS("YEM_CARGADOR11") = Trim(myReader2.GetValue(13)) Else FILA_YEMAS("YEM_CARGADOR11") = ""
                If IsDBNull(myReader2.GetValue(14)) = False Then FILA_YEMAS("YEM_CARGADOR12") = Trim(myReader2.GetValue(14)) Else FILA_YEMAS("YEM_CARGADOR12") = ""
                If IsDBNull(myReader2.GetValue(15)) = False Then FILA_YEMAS("YEM_CARGADOR13") = Trim(myReader2.GetValue(15)) Else FILA_YEMAS("YEM_CARGADOR13") = ""
                If IsDBNull(myReader2.GetValue(16)) = False Then FILA_YEMAS("YEM_CARGADOR14") = Trim(myReader2.GetValue(16)) Else FILA_YEMAS("YEM_CARGADOR14") = ""
                If IsDBNull(myReader2.GetValue(17)) = False Then FILA_YEMAS("YEM_CARGADOR15") = Trim(myReader2.GetValue(17)) Else FILA_YEMAS("YEM_CARGADOR15") = ""
                If IsDBNull(myReader2.GetValue(18)) = False Then FILA_YEMAS("YEM_CARGADOR16") = Trim(myReader2.GetValue(18)) Else FILA_YEMAS("YEM_CARGADOR16") = ""
                If IsDBNull(myReader2.GetValue(19)) = False Then FILA_YEMAS("YEM_CARGADOR17") = Trim(myReader2.GetValue(19)) Else FILA_YEMAS("YEM_CARGADOR17") = ""
                If IsDBNull(myReader2.GetValue(20)) = False Then FILA_YEMAS("YEM_CARGADOR18") = Trim(myReader2.GetValue(20)) Else FILA_YEMAS("YEM_CARGADOR18") = ""
                If IsDBNull(myReader2.GetValue(21)) = False Then FILA_YEMAS("YEM_CARGADOR19") = Trim(myReader2.GetValue(21)) Else FILA_YEMAS("YEM_CARGADOR19") = ""
                If IsDBNull(myReader2.GetValue(22)) = False Then FILA_YEMAS("YEM_CARGADOR20") = Trim(myReader2.GetValue(22)) Else FILA_YEMAS("YEM_CARGADOR20") = ""
                If IsDBNull(myReader2.GetValue(23)) = False Then FILA_YEMAS("YEM_CARGADOR21") = Trim(myReader2.GetValue(23)) Else FILA_YEMAS("YEM_CARGADOR21") = ""
                If IsDBNull(myReader2.GetValue(24)) = False Then FILA_YEMAS("YEM_CARGADOR22") = Trim(myReader2.GetValue(24)) Else FILA_YEMAS("YEM_CARGADOR22") = ""
                If IsDBNull(myReader2.GetValue(25)) = False Then FILA_YEMAS("YEM_CARGADOR23") = Trim(myReader2.GetValue(25)) Else FILA_YEMAS("YEM_CARGADOR23") = ""
                If IsDBNull(myReader2.GetValue(26)) = False Then FILA_YEMAS("YEM_CARGADOR24") = Trim(myReader2.GetValue(26)) Else FILA_YEMAS("YEM_CARGADOR24") = ""
                If IsDBNull(myReader2.GetValue(27)) = False Then FILA_YEMAS("YEM_CARGADOR25") = Trim(myReader2.GetValue(27)) Else FILA_YEMAS("YEM_CARGADOR25") = ""
                If IsDBNull(myReader2.GetValue(28)) = False Then FILA_YEMAS("YEM_CARGADOR26") = Trim(myReader2.GetValue(28)) Else FILA_YEMAS("YEM_CARGADOR26") = ""
                If IsDBNull(myReader2.GetValue(29)) = False Then FILA_YEMAS("YEM_CARGADOR27") = Trim(myReader2.GetValue(29)) Else FILA_YEMAS("YEM_CARGADOR27") = ""
                If IsDBNull(myReader2.GetValue(30)) = False Then FILA_YEMAS("YEM_CARGADOR28") = Trim(myReader2.GetValue(30)) Else FILA_YEMAS("YEM_CARGADOR28") = ""
                If IsDBNull(myReader2.GetValue(31)) = False Then FILA_YEMAS("YEM_CARGADOR29") = Trim(myReader2.GetValue(31)) Else FILA_YEMAS("YEM_CARGADOR29") = ""
                If IsDBNull(myReader2.GetValue(32)) = False Then FILA_YEMAS("YEM_CARGADOR30") = Trim(myReader2.GetValue(32)) Else FILA_YEMAS("YEM_CARGADOR30") = ""
                If IsDBNull(myReader2.GetValue(33)) = False Then FILA_YEMAS("YEM_CARGADOR31") = Trim(myReader2.GetValue(33)) Else FILA_YEMAS("YEM_CARGADOR31") = ""
                If IsDBNull(myReader2.GetValue(34)) = False Then FILA_YEMAS("YEM_CARGADOR32") = Trim(myReader2.GetValue(34)) Else FILA_YEMAS("YEM_CARGADOR32") = ""
                If IsDBNull(myReader2.GetValue(35)) = False Then FILA_YEMAS("YEM_CARGADOR33") = Trim(myReader2.GetValue(35)) Else FILA_YEMAS("YEM_CARGADOR33") = ""
                If IsDBNull(myReader2.GetValue(36)) = False Then FILA_YEMAS("YEM_CARGADOR34") = Trim(myReader2.GetValue(36)) Else FILA_YEMAS("YEM_CARGADOR34") = ""
                If IsDBNull(myReader2.GetValue(37)) = False Then FILA_YEMAS("YEM_CARGADOR35") = Trim(myReader2.GetValue(37)) Else FILA_YEMAS("YEM_CARGADOR35") = ""
                If IsDBNull(myReader2.GetValue(38)) = False Then FILA_YEMAS("YEM_CARGADOR36") = Trim(myReader2.GetValue(38)) Else FILA_YEMAS("YEM_CARGADOR36") = ""
                If IsDBNull(myReader2.GetValue(39)) = False Then FILA_YEMAS("YEM_CARGADOR37") = Trim(myReader2.GetValue(39)) Else FILA_YEMAS("YEM_CARGADOR37") = ""
                If IsDBNull(myReader2.GetValue(40)) = False Then FILA_YEMAS("YEM_CARGADOR38") = Trim(myReader2.GetValue(40)) Else FILA_YEMAS("YEM_CARGADOR38") = ""
                If IsDBNull(myReader2.GetValue(41)) = False Then FILA_YEMAS("YEM_CARGADOR39") = Trim(myReader2.GetValue(41)) Else FILA_YEMAS("YEM_CARGADOR39") = ""
                If IsDBNull(myReader2.GetValue(42)) = False Then FILA_YEMAS("YEM_CARGADOR40") = Trim(myReader2.GetValue(42)) Else FILA_YEMAS("YEM_CARGADOR40") = ""

                If FILA_YEMAS("YEM_CARGADOR1") <> "" Or FILA_YEMAS("YEM_CARGADOR2") <> "" Or FILA_YEMAS("YEM_CARGADOR3") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR4") <> "" Or FILA_YEMAS("YEM_CARGADOR5") <> "" Or FILA_YEMAS("YEM_CARGADOR6") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR6") <> "" Or FILA_YEMAS("YEM_CARGADOR7") <> "" Or FILA_YEMAS("YEM_CARGADOR8") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR9") <> "" Or FILA_YEMAS("YEM_CARGADOR10") <> "" Or FILA_YEMAS("YEM_CARGADOR11") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR12") <> "" Or FILA_YEMAS("YEM_CARGADOR13") <> "" Or FILA_YEMAS("YEM_CARGADOR14") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR15") <> "" Or FILA_YEMAS("YEM_CARGADOR16") <> "" Or FILA_YEMAS("YEM_CARGADOR17") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR18") <> "" Or FILA_YEMAS("YEM_CARGADOR19") <> "" Or FILA_YEMAS("YEM_CARGADOR20") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR21") <> "" Or FILA_YEMAS("YEM_CARGADOR22") <> "" Or FILA_YEMAS("YEM_CARGADOR23") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR24") <> "" Or FILA_YEMAS("YEM_CARGADOR25") <> "" Or FILA_YEMAS("YEM_CARGADOR26") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR27") <> "" Or FILA_YEMAS("YEM_CARGADOR28") <> "" Or FILA_YEMAS("YEM_CARGADOR29") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR30") <> "" Or FILA_YEMAS("YEM_CARGADOR31") <> "" Or FILA_YEMAS("YEM_CARGADOR32") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR33") <> "" Or FILA_YEMAS("YEM_CARGADOR34") <> "" Or FILA_YEMAS("YEM_CARGADOR35") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR36") <> "" Or FILA_YEMAS("YEM_CARGADOR37") <> "" Or FILA_YEMAS("YEM_CARGADOR38") <> "" Or _
                   FILA_YEMAS("YEM_CARGADOR39") <> "" Or FILA_YEMAS("YEM_CARGADOR40") <> "" Then
                    Paso = "S"
                Else
                    Paso = "N"
                End If
            Catch ex As Exception
            End Try
            Try
                If Paso = "S" Then Yema_Hasta = Yema_Hasta + 1
                Cjto_Orden1.Tables("DIG_YEMAS").Rows.Add(FILA_YEMAS)
            Catch ex As Exception
            End Try
        End While
        FILA_LARGO = Cjto_Orden1.Tables("LARGO_CARGADOR").NewRow
        FILA_LARGO("OT_NLAB") = Aux_NLab
        FILA_LARGO("YEMA_DESDE") = 2
        FILA_LARGO("YEMA_HASTA") = Yema_Hasta
        Try
            Cjto_Orden1.Tables("LARGO_CARGADOR").Rows.Add(FILA_LARGO)
        Catch ex As Exception
        End Try
        myReader2.Close()
        SqlConnection2.Close()
    End Sub

    Private Sub Genera_Excel(ByVal NumeroYemasMaximo As Integer, ByVal Productor As String, ByVal cargador_formato As Integer)
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel, objHojaExcel1, objHojaExcel2 As Excel.Worksheet
        Dim via, fuente, destino, nlab_descr As String
        Dim PUNTOS, PUNTOS_X, nomb, vv As String
        Dim num_ord, largo As Integer
        Dim FILA_IMP_REC As DataRow
        PUNTOS_X = "..........................................................................................................................................................................................."

        If cargador_formato <= 20 Then
            If NumeroYemasMaximo <= 10 Then
                If ChBoxObs.Checked = True Then
                    fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato 10 Yemas 20 Cargadores con Obs LabSys.xls" : GoTo Formato10Yemas
                Else
                    fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato 10 Yemas 20 Cargadores LabSys.xls" : GoTo Formato10Yemas
                End If
            End If
            If ChBoxObs.Checked = True Then
                fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato Yemas 20 Obs LabSys.xls"
            Else
                fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato Yemas 20 LabSys.xls"
            End If
        End If
        If cargador_formato > 20 Then
            If ChBoxObs.Checked = True Then
                fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato Yemas 30 Obs LabSys.xls"
            Else
                fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato Yemas 30 LabSys.xls"
            End If
        End If
Formato10Yemas:
        largo = Len(TxtNFlab.Text)
        nlab_descr = TxtNIlab.Text & "-" & Mid(TxtNFlab.Text, (largo - 2))
        control_nombre(Productor)
        If TxtNIlab.Text = TxtNFlab.Text Then nlab_descr = TxtNIlab.Text
        destino = "F:\Mis documentos\" & Year(Today) & ".Yemas-LabSys\" & nlab_descr & "   " & Productor & ".xls"
        m_Excel = CreateObject("EXCEL.APPLICATION")
        Try
            FileCopy(fuente, destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
            'GoTo noimprime
        End Try
        objLibroExcel = m_Excel.Workbooks.Open(destino)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()
        If cargador_formato <= 20 And NumeroYemasMaximo <= 10 Then Call imprime_informe_Resultado10Yemas(NumeroYemasMaximo, RTxtNMedio.Text, RTxtNBajo.Text, TxtFechaInforme.Text, objHojaExcel) : GoTo Salto10Yemas
        If cargador_formato <= 20 Then Call imprime_informe_Resultado(NumeroYemasMaximo, RTxtNMedio.Text, RTxtNBajo.Text, TxtFechaInforme.Text, objHojaExcel)
        If cargador_formato > 20 And cargador_formato <= 30 Then Call imprime_informe_Resultado_30(objHojaExcel)
        If cargador_formato > 30 Then Call imprime_informe_Resultado_40(objHojaExcel)
        objHojaExcel1 = objLibroExcel.Worksheets(2)
        objHojaExcel1.Activate()
        Call imprime_informe_parra(TxtFechaInforme.Text, objHojaExcel1)
Salto10Yemas:
        If ChBoxObs.Checked = True Then
            If NumeroYemasMaximo <= 10 Then
                objHojaExcel2 = objLibroExcel.Worksheets(2)
            Else
                objHojaExcel2 = objLibroExcel.Worksheets(3)
            End If
            objHojaExcel2.Activate()
            Call imprime_Informe_Observacion(RTxtNMedio.Text, RTxtNBajo.Text, TxtOrden.Text, TxtNIlab.Text, TxtFechaInforme.Text, objHojaExcel2)
        End If
        m_Excel.Visible = True
            'm_Excel.Quit()
salto:
    End Sub
    Private Sub Revisa_Cargadores20(ByRef estabien As Boolean)
        Dim Fila_Estimado As DataRow
        For Each Fila_Estimado In Cjto_Orden1.Tables("ESTIMADOBRO").Rows
            If (Fila_Estimado("CARGADOR_HASTA") - Fila_Estimado("CARGADOR_DESDE")) <> 19 Then
                MsgBox("Error en largo de cargadores deberia ser 20")
                estabien = False
            End If
        Next
    End Sub

    Private Sub Calcular(ByRef cargador_formato As Integer, ByRef NumeroYemasMaximo As Integer)
        Dim Fila_yemas As DataRow
        Dim NLab_Aux, Ye, Car, observadas, frutales, PorAcu, Suma_Obs, Suma_Frutal, YemasAct As Integer
        Dim PorObs, acumulado As Double
        Dim str_Cargador As String
        acumulado = 0 : Suma_Obs = 0 : Suma_Frutal = 0
        NLab_Aux = 0
        NumeroYemasMaximo = 0
        For Each Fila_yemas In Cjto_Orden1.Tables("DIG_YEMAS").Rows
            observadas = 0 : frutales = 0
            If Fila_yemas("OT_NLAB") <> NLab_Aux Then
                acumulado = 0 : Suma_Obs = 0 : Suma_Frutal = 0
            End If

            '*************************
            'Cantidad de Yemas maximas 
            '*************************
            YemasAct = 0
            For Car = 1 To 40
                str_Cargador = "YEM_CARGADOR" & Car
                If IsDBNull(Fila_yemas(str_Cargador)) = False Then
                    If Fila_yemas(str_Cargador) <> "" Then YemasAct = 1 : Exit For
                End If
            Next
            If YemasAct > 0 Then
                If NumeroYemasMaximo < Fila_yemas("YEM_YEMA") Then
                    NumeroYemasMaximo = Fila_yemas("YEM_YEMA")
                End If
            End If
            '************************

            For Car = 1 To 40
                str_Cargador = "YEM_CARGADOR" & Car
                If IsDBNull(Fila_yemas(str_Cargador)) = False Then
                    If Fila_yemas(str_Cargador) <> "" Then observadas = observadas + 1
                    If Fila_yemas(str_Cargador) = "F" Then frutales = frutales + 1
                End If
            Next
            If cargador_formato < observadas Then cargador_formato = observadas
            If observadas <> 0 Then
                Fila_yemas("YEM_OBSERVADAS") = observadas
                Fila_yemas("YEM_FRUTALES") = frutales
                Suma_Obs = Suma_Obs + observadas : Suma_Frutal = Suma_Frutal + frutales
                If observadas <> 0 Then PorObs = (frutales / observadas) * 100
                If PorObs = 0 Then
                    Fila_yemas("YEM_POROBSERVADAS") = 0
                Else
                    Fila_yemas("YEM_POROBSERVADAS") = Format(PorObs, "##.##")
                End If
                acumulado = (Suma_Frutal / Suma_Obs) * 100
                If acumulado = 0 Then
                    Fila_yemas("YEM_PORACUMULADA") = 0
                Else
                    Fila_yemas("YEM_PORACUMULADA") = Format(acumulado, "##.##")
                End If
                NLab_Aux = Fila_yemas("OT_NLAB")
            End If
        Next
    End Sub
    Private Sub Frm_Yemas_Genera_Excel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyDate As Date
        MyDate = Today
        TxtFechaInforme.Text = MyDate
        Call Anti_Elimina_lineas()
        TxtOrden.Focus()
        Cjto_Orden1.Tables("NOTA_YEMAS").Clear()
    End Sub
    Private Sub ChBoxObs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBoxObs.CheckedChanged
        If ChBoxObs.Checked = True Then
            GRNotas.Visible = True
        End If
        If ChBoxObs.Checked = False Then
            GRNotas.Visible = False
        End If
    End Sub
    Private Sub control_nombre(ByRef nomb As String)
        Dim lar, i, j As Integer
        Dim acumula As String
        lar = Len(nomb)
        acumula = "" : j = 0
        For i = 1 To lar
            If Mid(nomb, i, 4) = "S.A." Then acumula = acumula & "S.A." : Exit For
            If i = 1 Then acumula = UCase(Mid(nomb, 1, 1)) : GoTo continuar
            If j = 1 Then acumula = acumula & UCase(Mid(nomb, i, 1)) : j = 0 : GoTo continuar
            If Mid(nomb, i, 1) = " " Then acumula = acumula & " " : j = 1 : GoTo continuar
            If Mid(nomb, i, 1) = "." Then acumula = acumula & "." : j = 1 : GoTo continuar
            If Mid(nomb, i, 1) = "-" Then acumula = acumula & "-" : j = 1 : GoTo continuar
            acumula = acumula & LCase(Mid(nomb, i, 1))
continuar:
        Next
        nomb = acumula
    End Sub

    Private Sub TxtOrden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOrden.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNIlab.Focus()
        End If
    End Sub

    Private Sub TxtNIlab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNIlab.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNFlab.Focus()
        End If
    End Sub

    Private Sub TxtNFlab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNFlab.KeyPress
        Dim FILA_ESTIMADO, FILA_LARGO As DataRow
        Dim CLAVE As Object
        Dim FF As Integer
        If e.KeyChar = Chr(13) Then
            Cjto_Orden1.Tables("DIG_YEMAS").Clear()
            Call Llena_DIG_YEMA()
            For FF = TxtNIlab.Text To TxtNFlab.Text
                FILA_ESTIMADO = Cjto_Orden1.Tables("ESTIMADOBRO").NewRow
                FILA_ESTIMADO("OT_NLAB") = FF
                FILA_ESTIMADO("CARGADOR_DESDE") = 21
                FILA_ESTIMADO("CARGADOR_HASTA") = 40
                CLAVE = FF
                FILA_LARGO = Cjto_Orden1.Tables("LARGO_CARGADOR").Rows.Find(CLAVE)
                FILA_ESTIMADO("YEMA_DESDE") = 2
                Try
                    FILA_ESTIMADO("YEMA_HASTA") = FILA_LARGO("YEMA_HASTA")
                    Cjto_Orden1.Tables("ESTIMADOBRO").Rows.Add(FILA_ESTIMADO)
                Catch ex As Exception
                End Try
            Next

        End If
    End Sub

    Private Sub CmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabar.Click
        Dim Fila_Yemas As DataRow
        Dim Graba_Yemas As DbManager = New DbManager("NOTA_YEMAS", Conexion1)
        Graba_Yemas.Update(Cjto_Orden1)
        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminar.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As String
        Dim respuesta As MsgBoxResult
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1_Real)
        cll = DG_Notas.CurrentCell.ColumnNumber
        fila = DG_Notas.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Orden1.Tables("NOTA_YEMAS").Rows(fila)
        Cod_Ana = FILA_DATAROW("NIV_NYEM")
        respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            con.Open()
            consulta_nota = "DELETE FROM NOTA_YEMAS WHERE NIV_NYEM=" & Cod_Ana
            Dim myCommand3 As New SqlCommand(consulta_nota, con)
            Dim myReader2 As SqlDataReader
            myReader2 = myCommand3.ExecuteReader()
            myReader2.Close()
            con.Close()
            Cjto_Orden1.Tables("NOTA_YEMAS").Rows.Remove(FILA_DATAROW)
        End If
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DG_Notas.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DG_Notas.CurrentCell = mycell
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.RTxtNMedio.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.RTxtNBajo.Clear()
    End Sub
End Class
