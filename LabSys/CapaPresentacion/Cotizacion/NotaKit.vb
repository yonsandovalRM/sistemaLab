Public Class NotaKit
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents DG_Notas As System.Windows.Forms.DataGrid
    Friend WithEvents GrbAyuda As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Cjto_NotaKit1 As Cjto_NotaKit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_NotaKit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NotaKit))
        Me.DG_Notas = New System.Windows.Forms.DataGrid
        Me.Cjto_NotaKit1 = New Cjto_NotaKit
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GrbAyuda = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adap_NotaKit = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.DG_Notas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cjto_NotaKit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbAyuda.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Notas
        '
        Me.DG_Notas.CaptionVisible = False
        Me.DG_Notas.DataMember = "NOTA_KITS"
        Me.DG_Notas.DataSource = Me.Cjto_NotaKit1
        Me.DG_Notas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_Notas.Location = New System.Drawing.Point(8, 8)
        Me.DG_Notas.Name = "DG_Notas"
        Me.DG_Notas.Size = New System.Drawing.Size(808, 664)
        Me.DG_Notas.TabIndex = 1
        Me.DG_Notas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Cjto_NotaKit1
        '
        Me.Cjto_NotaKit1.DataSetName = "Cjto_NotaKit"
        Me.Cjto_NotaKit1.Locale = New System.Globalization.CultureInfo("es-CL")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DG_Notas
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "NOTA_KITS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Tipo Nota"
        Me.DataGridTextBoxColumn1.MappingName = "NOTA_COT_TIPO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nota Descripci�n"
        Me.DataGridTextBoxColumn2.MappingName = "NOTA_COT_DESCRIPCION"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 610
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "N�"
        Me.DataGridTextBoxColumn3.MappingName = "NOTA_COD_ID"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 30
        '
        'GrbAyuda
        '
        Me.GrbAyuda.Controls.Add(Me.Label16)
        Me.GrbAyuda.Controls.Add(Me.Label14)
        Me.GrbAyuda.Controls.Add(Me.Label15)
        Me.GrbAyuda.Controls.Add(Me.Label18)
        Me.GrbAyuda.Controls.Add(Me.Label17)
        Me.GrbAyuda.Controls.Add(Me.Label19)
        Me.GrbAyuda.Controls.Add(Me.Label5)
        Me.GrbAyuda.Controls.Add(Me.Label10)
        Me.GrbAyuda.Controls.Add(Me.Label9)
        Me.GrbAyuda.Controls.Add(Me.Label8)
        Me.GrbAyuda.Controls.Add(Me.Label7)
        Me.GrbAyuda.Controls.Add(Me.Button7)
        Me.GrbAyuda.Controls.Add(Me.Label11)
        Me.GrbAyuda.Controls.Add(Me.Label12)
        Me.GrbAyuda.Controls.Add(Me.Label6)
        Me.GrbAyuda.Location = New System.Drawing.Point(9, 456)
        Me.GrbAyuda.Name = "GrbAyuda"
        Me.GrbAyuda.Size = New System.Drawing.Size(814, 216)
        Me.GrbAyuda.TabIndex = 26
        Me.GrbAyuda.TabStop = False
        Me.GrbAyuda.Visible = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(704, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "          Dar click en boton ""Elimina""  y  luego en boton ""Graba"""
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(704, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "          Posicionarse en la fila de la nota que se desea eliminar."
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(704, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Eliminar nota:"
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
        Me.Label17.Location = New System.Drawing.Point(568, 104)
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
        Me.Label19.Location = New System.Drawing.Point(552, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 16)
        Me.Label19.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(544, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "            Si la nueva nota ocupa m�s de una l�nea : Posicionese al final de la " & _
        "fila y presione shif ("
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
        Me.Label8.Text = "         Digitar el nuevo c�digo y descripci�n"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(704, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "         Dar Click en boton ""Nuevo"". El cursor se ubicar� en la �ltima fila."
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button7.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(800, 8)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(16, 16)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "X"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(704, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "        Realizar la modificaci�n directamente en la grilla, luego dar click en el" & _
        " bot�n ""Graba""."
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(704, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Moficar texto:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(704, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nuevo texto:"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(19, 688)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 23)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "?"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(739, 688)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Elimina"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(635, 688)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Modifica"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(427, 688)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Nuevo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 688)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Graba"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SECREAGRO;packet size=4096;user id=sa;data source=AGROSERV;persist " & _
        "security info=True;initial catalog=AGROLAB;password=sa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(760, 88)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(720, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(32, 20)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "TextBox4"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(128, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(592, 20)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "TextBox3"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(64, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "TextBox2"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(720, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Niv"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(128, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(592, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nota Descripci�n"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(64, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Nota"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(336, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Graba"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(32, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TextBox1"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "N�"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NOTA_COD_ID, NOTA_COT_DESCRIPCION, NOTA_COT_TIPO, NOTA_FRECUENCIA FROM NOT" & _
        "A_KITS WHERE NOTA_COD_ID BETWEEN @NOTA_COD_ID1 AND @NOTA_COD_ID2 ORDER BY NOTA_C" & _
        "OD_ID"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COD_ID1", System.Data.SqlDbType.Int, 4, "NOTA_COD_ID"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COD_ID2", System.Data.SqlDbType.Int, 4, "NOTA_COD_ID"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO NOTA_KITS(NOTA_COD_ID, NOTA_COT_DESCRIPCION, NOTA_COT_TIPO, NOTA_FREC" & _
        "UENCIA) VALUES (@NOTA_COD_ID, @NOTA_COT_DESCRIPCION, @NOTA_COT_TIPO, @NOTA_FRECU" & _
        "ENCIA); SELECT NOTA_COD_ID, NOTA_COT_DESCRIPCION, NOTA_COT_TIPO, NOTA_FRECUENCIA" & _
        " FROM NOTA_KITS WHERE (NOTA_COD_ID = @NOTA_COD_ID)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COD_ID", System.Data.SqlDbType.Int, 4, "NOTA_COD_ID"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COT_DESCRIPCION", System.Data.SqlDbType.NVarChar, 2500, "NOTA_COT_DESCRIPCION"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, "NOTA_COT_TIPO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_FRECUENCIA", System.Data.SqlDbType.NVarChar, 10, "NOTA_FRECUENCIA"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE NOTA_KITS SET NOTA_COD_ID = @NOTA_COD_ID, NOTA_COT_DESCRIPCION = @NOTA_COT" & _
        "_DESCRIPCION, NOTA_COT_TIPO = @NOTA_COT_TIPO, NOTA_FRECUENCIA = @NOTA_FRECUENCIA" & _
        " WHERE (NOTA_COD_ID = @Original_NOTA_COD_ID) AND (NOTA_COT_DESCRIPCION = @Origin" & _
        "al_NOTA_COT_DESCRIPCION OR @Original_NOTA_COT_DESCRIPCION IS NULL AND NOTA_COT_D" & _
        "ESCRIPCION IS NULL) AND (NOTA_COT_TIPO = @Original_NOTA_COT_TIPO OR @Original_NO" & _
        "TA_COT_TIPO IS NULL AND NOTA_COT_TIPO IS NULL) AND (NOTA_FRECUENCIA = @Original_" & _
        "NOTA_FRECUENCIA OR @Original_NOTA_FRECUENCIA IS NULL AND NOTA_FRECUENCIA IS NULL" & _
        "); SELECT NOTA_COD_ID, NOTA_COT_DESCRIPCION, NOTA_COT_TIPO, NOTA_FRECUENCIA FROM" & _
        " NOTA_KITS WHERE (NOTA_COD_ID = @NOTA_COD_ID)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COD_ID", System.Data.SqlDbType.Int, 4, "NOTA_COD_ID"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COT_DESCRIPCION", System.Data.SqlDbType.NVarChar, 2500, "NOTA_COT_DESCRIPCION"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, "NOTA_COT_TIPO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NOTA_FRECUENCIA", System.Data.SqlDbType.NVarChar, 10, "NOTA_FRECUENCIA"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_COD_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COD_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_COT_DESCRIPCION", System.Data.SqlDbType.NVarChar, 2500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COT_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COT_TIPO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_FRECUENCIA", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_FRECUENCIA", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM NOTA_KITS WHERE (NOTA_COD_ID = @Original_NOTA_COD_ID) AND (NOTA_COT_D" & _
        "ESCRIPCION = @Original_NOTA_COT_DESCRIPCION OR @Original_NOTA_COT_DESCRIPCION IS" & _
        " NULL AND NOTA_COT_DESCRIPCION IS NULL) AND (NOTA_COT_TIPO = @Original_NOTA_COT_" & _
        "TIPO OR @Original_NOTA_COT_TIPO IS NULL AND NOTA_COT_TIPO IS NULL) AND (NOTA_FRE" & _
        "CUENCIA = @Original_NOTA_FRECUENCIA OR @Original_NOTA_FRECUENCIA IS NULL AND NOT" & _
        "A_FRECUENCIA IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_COD_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COD_ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_COT_DESCRIPCION", System.Data.SqlDbType.NVarChar, 2500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COT_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COT_TIPO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NOTA_FRECUENCIA", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_FRECUENCIA", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adap_NotaKit
        '
        Me.Adap_NotaKit.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adap_NotaKit.InsertCommand = Me.SqlInsertCommand1
        Me.Adap_NotaKit.SelectCommand = Me.SqlSelectCommand1
        Me.Adap_NotaKit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NOTA_KITS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NOTA_COD_ID", "NOTA_COD_ID"), New System.Data.Common.DataColumnMapping("NOTA_COT_DESCRIPCION", "NOTA_COT_DESCRIPCION"), New System.Data.Common.DataColumnMapping("NOTA_COT_TIPO", "NOTA_COT_TIPO"), New System.Data.Common.DataColumnMapping("NOTA_FRECUENCIA", "NOTA_FRECUENCIA")})})
        Me.Adap_NotaKit.UpdateCommand = Me.SqlUpdateCommand1
        '
        'NotaKit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 725)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrbAyuda)
        Me.Controls.Add(Me.DG_Notas)
        Me.Name = "NotaKit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NotaKit"
        CType(Me.DG_Notas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cjto_NotaKit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbAyuda.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Notas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DesdeId, HastaId As Integer
        Me.anti_elimina_lineas()
        DesdeId = CInt(seccion & "00")
        HastaId = CInt(seccion & "00") + 99
        Me.SqlSelectCommand1.Parameters("@NOTA_COD_ID1").Value = DesdeId
        Me.SqlSelectCommand1.Parameters("@NOTA_COD_ID2").Value = HastaId
        Adap_NotaKit.Fill(Cjto_NotaKit1, "NOTA_KITS")
seccionv:
        Me.TransformaMultilinea(Me.DG_Notas)
        Me.Button2_Click(sender, e)
    End Sub
    Private Sub anti_elimina_lineas()
        Me.DG_Notas.DataSource = Me.Cjto_NotaKit1.Tables("NOTA_KITS")
    End Sub
    Private Sub TransformaMultilinea(ByVal grid As DataGrid)
        Dim ts As DataGridTableStyle
        ts = New DataGridTableStyle
        Dim dt As DataTable
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j As Integer
        j = 0
        Do While (j < 3)
            Dim cs As New Multilinea(grid.TableStyles(0).GridColumnStyles(j).MappingName)
            cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
            cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
            ts.GridColumnStyles.Add(cs)
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub
    Private Sub DG_Notas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Notas.DoubleClick
        Dim cot As class_COTIZADOR = Me.Owner
        Dim FILA As Integer
        Dim a As String
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        FILA = myGrid.CurrentCell.RowNumber
        Select Case boton_notasK
            Case 1
                If obsK1 <> "" Then
                    obsK1 = obsK1 & Chr(13) & DG_Notas.Item(FILA, 1)
                    cot.RichTextBox1.Text = obsK1.ToString
                Else
                    obsK1 = DG_Notas.Item(FILA, 1)
                    cot.RichTextBox1.Text = obsK1.ToString
                End If
            Case 2
                If obsK2 <> "" Then
                    obsK2 = obsK2 & Chr(13) & DG_Notas.Item(FILA, 1)

                Else
                    obsK2 = DG_Notas.Item(FILA, 1)
                End If
            Case 3
                If obsK3 <> "" Then
                    obsK3 = obsK3 & Chr(13) & DG_Notas.Item(FILA, 1)
                    cot.RichTextBox3.Text = obsK3.ToString
                Else
                    obsK3 = DG_Notas.Item(FILA, 1)
                    cot.RichTextBox3.Text = obsK3.ToString
                End If
        End Select
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Adap_NotaKit.Update(Cjto_NotaKit1, "NOTA_KITS")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DG_Notas.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DG_Notas.CurrentCell = mycell
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As Integer
        Dim respuesta As MsgBoxResult
        cll = DG_Notas.CurrentCell.ColumnNumber
        fila = DG_Notas.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_NotaKit1.Tables("NOTA_KITS").Rows(fila)
        Cod_Ana = FILA_DATAROW("NOTA_COD_ID")
        respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Cjto_NotaKit1.Tables("NOTA_KITS").Rows(fila).Delete()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim FILA_DATAROW, dr As DataRow
        Dim fila As Integer
        fila = DG_Notas.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_NotaKit1.Tables("NOTA_KITS").Rows(fila)
        Try
            TextBox1.Text = FILA_DATAROW("NOTA_COD_ID")
            TextBox2.Text = FILA_DATAROW("NOTA_COT_TIPO")
            TextBox3.Text = FILA_DATAROW("NOTA_COT_DESCRIPCION")
            TextBox4.Text = FILA_DATAROW("NOTA_FRECUENCIA")
            Cjto_NotaKit1.Tables("NOTA_KITS").Rows(fila).Delete()
            Adap_NotaKit.Update(Cjto_NotaKit1, "NOTA_KITS")
            Adap_NotaKit.Fill(Cjto_NotaKit1, "NOTA_KITS")
            GroupBox1.Visible = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dr As DataRow
        dr = Cjto_NotaKit1.Tables("NOTA_KITS").NewRow
        dr.BeginEdit()
        dr.Item("NOTA_COD_ID") = CInt(TextBox1.Text)
        dr.Item("NOTA_COT_TIPO") = TextBox2.Text
        dr.Item("NOTA_COT_DESCRIPCION") = TextBox3.Text
        dr.Item("NOTA_FRECUENCIA") = TextBox4.Text
        dr.EndEdit()
        Try
            Cjto_NotaKit1.Tables("NOTA_KITS").Rows.Add(dr)
            Adap_NotaKit.Update(Cjto_NotaKit1, "NOTA_KITS")
            Adap_NotaKit.Fill(Cjto_NotaKit1, "NOTA_KITS")
        Catch ex As Exception
            MsgBox("Nota ya fue creada")
        End Try
        GroupBox1.Visible = False
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GrbAyuda.Visible = True
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        GrbAyuda.Visible = False
    End Sub
End Class
