Imports System.Data.SqlClient
Public Class Notas_Listado
    Inherits System.Windows.Forms.Form
    Private SELECCION As String

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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Cjto_Nota_planilla1 As Cjto_Nota_planilla
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DG_Notas_Listado As System.Windows.Forms.DataGrid
    Friend WithEvents BTAgregar As System.Windows.Forms.Button
    Friend WithEvents RCTxtNotas As System.Windows.Forms.RichTextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Nota_Planilla As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BTEliminar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GrbAyuda As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Notas_Listado))
        Me.Cjto_Nota_planilla1 = New Cjto_Nota_planilla
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Button3 = New System.Windows.Forms.Button
        Me.DG_Notas_Listado = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.BTAgregar = New System.Windows.Forms.Button
        Me.RCTxtNotas = New System.Windows.Forms.RichTextBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Nota_Planilla = New System.Data.SqlClient.SqlDataAdapter
        Me.BTEliminar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GrbAyuda = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Cjto_Nota_planilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Notas_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbAyuda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cjto_Nota_planilla1
        '
        Me.Cjto_Nota_planilla1.DataSetName = "Cjto_Nota_planilla"
        Me.Cjto_Nota_planilla1.Locale = New System.Globalization.CultureInfo("es-CL")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SECREAGRO;packet size=4096;user id=sa;data source=AGROSERV;persist " & _
        "security info=True;initial catalog=AGROLAB;password=sa"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(658, 672)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Graba"
        '
        'DG_Notas_Listado
        '
        Me.DG_Notas_Listado.CaptionVisible = False
        Me.DG_Notas_Listado.DataMember = "NOTA_PLANILLA"
        Me.DG_Notas_Listado.DataSource = Me.Cjto_Nota_planilla1
        Me.DG_Notas_Listado.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_Notas_Listado.Location = New System.Drawing.Point(0, 8)
        Me.DG_Notas_Listado.Name = "DG_Notas_Listado"
        Me.DG_Notas_Listado.Size = New System.Drawing.Size(816, 632)
        Me.DG_Notas_Listado.TabIndex = 18
        Me.DG_Notas_Listado.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DG_Notas_Listado
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "NOTA_PLANILLA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Plantilla"
        Me.DataGridTextBoxColumn1.MappingName = "NPL_NOMBRE"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Carta"
        Me.DataGridTextBoxColumn2.MappingName = "NPL_OBSERVACION"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 650
        '
        'BTAgregar
        '
        Me.BTAgregar.Location = New System.Drawing.Point(578, 672)
        Me.BTAgregar.Name = "BTAgregar"
        Me.BTAgregar.Size = New System.Drawing.Size(56, 23)
        Me.BTAgregar.TabIndex = 19
        Me.BTAgregar.Text = "Nuevo"
        '
        'RCTxtNotas
        '
        Me.RCTxtNotas.Location = New System.Drawing.Point(0, 696)
        Me.RCTxtNotas.Name = "RCTxtNotas"
        Me.RCTxtNotas.Size = New System.Drawing.Size(800, 24)
        Me.RCTxtNotas.TabIndex = 20
        Me.RCTxtNotas.Text = ""
        Me.RCTxtNotas.Visible = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NPL_NOMBRE, NPL_OBSERVACION FROM NOTA_PLANILLA"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO NOTA_PLANILLA(NPL_NOMBRE, NPL_OBSERVACION) VALUES (@NPL_NOMBRE, @NPL_" & _
        "OBSERVACION); SELECT NPL_NOMBRE, NPL_OBSERVACION FROM NOTA_PLANILLA WHERE (NPL_N" & _
        "OMBRE = @NPL_NOMBRE)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NPL_NOMBRE", System.Data.SqlDbType.NVarChar, 50, "NPL_NOMBRE"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NPL_OBSERVACION", System.Data.SqlDbType.NVarChar, 2500, "NPL_OBSERVACION"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE NOTA_PLANILLA SET NPL_NOMBRE = @NPL_NOMBRE, NPL_OBSERVACION = @NPL_OBSERVA" & _
        "CION WHERE (NPL_NOMBRE = @Original_NPL_NOMBRE) AND (NPL_OBSERVACION = @Original_" & _
        "NPL_OBSERVACION OR @Original_NPL_OBSERVACION IS NULL AND NPL_OBSERVACION IS NULL" & _
        "); SELECT NPL_NOMBRE, NPL_OBSERVACION FROM NOTA_PLANILLA WHERE (NPL_NOMBRE = @NP" & _
        "L_NOMBRE)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NPL_NOMBRE", System.Data.SqlDbType.NVarChar, 50, "NPL_NOMBRE"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NPL_OBSERVACION", System.Data.SqlDbType.NVarChar, 2500, "NPL_OBSERVACION"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NPL_NOMBRE", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NPL_NOMBRE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NPL_OBSERVACION", System.Data.SqlDbType.NVarChar, 2500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NPL_OBSERVACION", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM NOTA_PLANILLA WHERE (NPL_NOMBRE = @Original_NPL_NOMBRE) AND (NPL_OBSE" & _
        "RVACION = @Original_NPL_OBSERVACION OR @Original_NPL_OBSERVACION IS NULL AND NPL" & _
        "_OBSERVACION IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NPL_NOMBRE", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NPL_NOMBRE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NPL_OBSERVACION", System.Data.SqlDbType.NVarChar, 2500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NPL_OBSERVACION", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adap_Nota_Planilla
        '
        Me.Adap_Nota_Planilla.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adap_Nota_Planilla.InsertCommand = Me.SqlInsertCommand1
        Me.Adap_Nota_Planilla.SelectCommand = Me.SqlSelectCommand1
        Me.Adap_Nota_Planilla.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NOTA_PLANILLA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NPL_NOMBRE", "NPL_NOMBRE"), New System.Data.Common.DataColumnMapping("NPL_OBSERVACION", "NPL_OBSERVACION")})})
        Me.Adap_Nota_Planilla.UpdateCommand = Me.SqlUpdateCommand1
        '
        'BTEliminar
        '
        Me.BTEliminar.Location = New System.Drawing.Point(738, 672)
        Me.BTEliminar.Name = "BTEliminar"
        Me.BTEliminar.Size = New System.Drawing.Size(56, 23)
        Me.BTEliminar.TabIndex = 22
        Me.BTEliminar.Text = "Eliminar"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 672)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "?"
        '
        'GrbAyuda
        '
        Me.GrbAyuda.Controls.Add(Me.Label18)
        Me.GrbAyuda.Controls.Add(Me.Label17)
        Me.GrbAyuda.Controls.Add(Me.Label19)
        Me.GrbAyuda.Controls.Add(Me.Label2)
        Me.GrbAyuda.Controls.Add(Me.Label10)
        Me.GrbAyuda.Controls.Add(Me.Label9)
        Me.GrbAyuda.Controls.Add(Me.Label8)
        Me.GrbAyuda.Controls.Add(Me.Label7)
        Me.GrbAyuda.Controls.Add(Me.Button2)
        Me.GrbAyuda.Controls.Add(Me.Label11)
        Me.GrbAyuda.Controls.Add(Me.Label12)
        Me.GrbAyuda.Controls.Add(Me.Label1)
        Me.GrbAyuda.Location = New System.Drawing.Point(0, 472)
        Me.GrbAyuda.Name = "GrbAyuda"
        Me.GrbAyuda.Size = New System.Drawing.Size(816, 168)
        Me.GrbAyuda.TabIndex = 24
        Me.GrbAyuda.TabStop = False
        Me.GrbAyuda.Visible = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(0, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(800, 16)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Ayuda"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(488, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 16)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = ") + Enter al mismo tiempo."
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Location = New System.Drawing.Point(472, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 16)
        Me.Label19.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(464, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "            Cuando desee separa un párrafo con un punto aparte, debe presionar Sh" & _
        "if ("
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(704, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "         Notas:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(704, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "         Finalmente dar click en boton ""Graba""."
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(704, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "         Digitar el nuevo nombre de la plantilla y el texto de la carta"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(704, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "         Dar Click en boton ""Nuevo"". El cursor se ubicará en la última fila."
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(800, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 16)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "X"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(704, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "        Realizar la modificación directamente en la grilla, luego dar click en el" & _
        " botón ""Graba""."
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(704, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Moficar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Carta"
        '
        'Notas_Listado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 717)
        Me.Controls.Add(Me.GrbAyuda)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTEliminar)
        Me.Controls.Add(Me.RCTxtNotas)
        Me.Controls.Add(Me.BTAgregar)
        Me.Controls.Add(Me.DG_Notas_Listado)
        Me.Controls.Add(Me.Button3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notas_Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas_Listado"
        CType(Me.Cjto_Nota_planilla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Notas_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbAyuda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Notas_Listado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.anti_elimina_lineas()
        Adap_Nota_Planilla.Fill(Cjto_Nota_planilla1, "NOTA_PLANILLA")
        Me.TransformaMultilinea(Me.DG_Notas_Listado)
        Me.BTAgregar_Click(sender, e)
    End Sub
    Private Sub GRABA_NOTA_PLA(ByVal texto As String, ByVal numero As Integer)
        Adap_Nota_Planilla.Update(Cjto_Nota_planilla1, "NOTA_PLANILLA")
    End Sub
    Private Sub anti_elimina_lineas()
        DG_Notas_Listado.DataSource = Me.Cjto_Nota_planilla1.Tables("NOTA_PLANILLA")
    End Sub
    Private Sub BTAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAgregar.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DG_Notas_Listado.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DG_Notas_Listado.CurrentCell = mycell
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
    Private Sub DG_Notas_Listado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Notas_Listado.DoubleClick
        Dim FILA As Integer
        Dim a As String
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        FILA = myGrid.CurrentCell.RowNumber
        RCTxtNotas.Text = DG_Notas_Listado.Item(FILA, 1)
        Npl1 = RCTxtNotas.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Adap_Nota_Planilla.Update(Cjto_Nota_planilla1, "NOTA_PLANILLA")
    End Sub
    Private Sub BTEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTEliminar.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As String
        Dim respuesta As MsgBoxResult
        cll = DG_Notas_Listado.CurrentCell.ColumnNumber
        fila = DG_Notas_Listado.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Nota_planilla1.Tables("NOTA_PLANILLA").Rows(fila)
        Cod_Ana = FILA_DATAROW("NPL_NOMBRE")
        respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Cjto_Nota_planilla1.Tables("NOTA_PLANILLA").Rows(fila).Delete()
        End If
    End Sub
    Private Sub BTSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GrbAyuda.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GrbAyuda.Visible = False
    End Sub

    Private Sub Notas_Listado_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        GrbAyuda.Visible = False
    End Sub
End Class
