Imports Microsoft.Office.Interop

Public Class Frm_Imprimir
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Public j, pag, cont, ll, ES_SIMPLE As Integer
    Public pix, suma_pixeles As Double
    Public fechaf As String
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Cjto_Imprimir1 As Cjto_Imprimir
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Imp_Combo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Imp_Lista As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Submuestra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Muestra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox25 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox26 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox27 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox28 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CheckBox29 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox30 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox31 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox32 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox15 = New System.Windows.Forms.CheckBox
        Me.CheckBox16 = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Cjto_Imprimir1 = New Cjto_Imprimir
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Imp_Combo = New System.Data.SqlClient.SqlDataAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Imp_Lista = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Submuestra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Muestra = New System.Data.SqlClient.SqlDataAdapter
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CheckBox17 = New System.Windows.Forms.CheckBox
        Me.CheckBox18 = New System.Windows.Forms.CheckBox
        Me.CheckBox19 = New System.Windows.Forms.CheckBox
        Me.CheckBox20 = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CheckBox21 = New System.Windows.Forms.CheckBox
        Me.CheckBox22 = New System.Windows.Forms.CheckBox
        Me.CheckBox23 = New System.Windows.Forms.CheckBox
        Me.CheckBox24 = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CheckBox25 = New System.Windows.Forms.CheckBox
        Me.CheckBox26 = New System.Windows.Forms.CheckBox
        Me.CheckBox27 = New System.Windows.Forms.CheckBox
        Me.CheckBox28 = New System.Windows.Forms.CheckBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.CheckBox29 = New System.Windows.Forms.CheckBox
        Me.CheckBox30 = New System.Windows.Forms.CheckBox
        Me.CheckBox31 = New System.Windows.Forms.CheckBox
        Me.CheckBox32 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Cjto_Imprimir1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "1.- Foliar"
        '
        'CheckBox4
        '
        Me.CheckBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox4.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox4.TabIndex = 3
        '
        'CheckBox3
        '
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox3.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox3.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox2.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox2.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox1.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.CheckBox7)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox2.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "2.- +Tejidos"
        '
        'CheckBox5
        '
        Me.CheckBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox5.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox5.TabIndex = 3
        '
        'CheckBox6
        '
        Me.CheckBox6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox6.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox6.TabIndex = 2
        '
        'CheckBox7
        '
        Me.CheckBox7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox7.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox7.TabIndex = 1
        '
        'CheckBox8
        '
        Me.CheckBox8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox8.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox8.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.CheckBox9)
        Me.GroupBox3.Controls.Add(Me.CheckBox10)
        Me.GroupBox3.Controls.Add(Me.CheckBox11)
        Me.GroupBox3.Controls.Add(Me.CheckBox12)
        Me.GroupBox3.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "3.- Agua"
        '
        'CheckBox9
        '
        Me.CheckBox9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox9.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox9.TabIndex = 3
        '
        'CheckBox10
        '
        Me.CheckBox10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox10.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox10.TabIndex = 2
        '
        'CheckBox11
        '
        Me.CheckBox11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox11.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox11.TabIndex = 1
        '
        'CheckBox12
        '
        Me.CheckBox12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox12.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox12.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.CheckBox13)
        Me.GroupBox4.Controls.Add(Me.CheckBox14)
        Me.GroupBox4.Controls.Add(Me.CheckBox15)
        Me.GroupBox4.Controls.Add(Me.CheckBox16)
        Me.GroupBox4.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox4.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "4.- Suelo"
        '
        'CheckBox13
        '
        Me.CheckBox13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox13.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox13.TabIndex = 3
        '
        'CheckBox14
        '
        Me.CheckBox14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox14.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox14.TabIndex = 2
        '
        'CheckBox15
        '
        Me.CheckBox15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox15.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox15.TabIndex = 1
        '
        'CheckBox16
        '
        Me.CheckBox16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox16.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox16.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Excel"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SECREAGRO;packet size=4096;user id=sa;data source=AGROSERV;persist " & _
        "security info=True;initial catalog=AGROLAB;password=sa"
        '
        'Cjto_Imprimir1
        '
        Me.Cjto_Imprimir1.DataSetName = "Cjto_Imprimir"
        Me.Cjto_Imprimir1.Locale = New System.Globalization.CultureInfo("es-CL")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT COMBO_ANALISIS.COB_CODIGO, COMBO_ANALISIS.ANA_CODIGO, ANALISIS.ANA_ANALISI" & _
        "S FROM COMBO_ANALISIS,ANALISIS WHERE COMBO_ANALISIS.ANA_CODIGO=ANALISIS.ANA_CODI" & _
        "GO"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Adap_Imp_Combo
        '
        Me.Adap_Imp_Combo.SelectCommand = Me.SqlSelectCommand2
        Me.Adap_Imp_Combo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COMBO_ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COB_CODIGO", "COB_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS"), New System.Data.Common.DataColumnMapping("IMP_COTIZA", "IMP_COTIZA")})})
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(136, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cliente 1"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(264, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cliente 2"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(376, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cliente 3"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(472, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, ANA_NETO, ANA_NIVEL_PREC" & _
        "IO, CLIENTE1, CLIENTE2, CLIENTE3, CLIENTET,TIPO_COD FROM ANALISIS"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO ANALISIS(ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, ANA_NETO, " & _
        "ANA_NIVEL_PRECIO, CLIENTE1, CLIENTE2, CLIENTE3, CLIENTET) VALUES (@ANA_CODIGO, @" & _
        "ANA_ANALISIS, @TMU_CODIGO, @SUB_CODIGO, @ANA_NETO, @ANA_NIVEL_PRECIO, @CLIENTE1," & _
        " @CLIENTE2, @CLIENTE3, @CLIENTET); SELECT ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, " & _
        "SUB_CODIGO, ANA_NETO, ANA_NIVEL_PRECIO, CLIENTE1, CLIENTE2, CLIENTE3, CLIENTET F" & _
        "ROM ANALISIS WHERE (ANA_CODIGO = @ANA_CODIGO)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_CODIGO", System.Data.SqlDbType.Float, 8, "ANA_CODIGO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.NVarChar, 110, "ANA_ANALISIS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NETO", System.Data.SqlDbType.Float, 8, "ANA_NETO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, "ANA_NIVEL_PRECIO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE1", System.Data.SqlDbType.NVarChar, 1, "CLIENTE1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE2", System.Data.SqlDbType.NVarChar, 1, "CLIENTE2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE3", System.Data.SqlDbType.NVarChar, 1, "CLIENTE3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTET", System.Data.SqlDbType.NVarChar, 1, "CLIENTET"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE ANALISIS SET ANA_CODIGO = @ANA_CODIGO, ANA_ANALISIS = @ANA_ANALISIS, TMU_C" & _
        "ODIGO = @TMU_CODIGO, SUB_CODIGO = @SUB_CODIGO, ANA_NETO = @ANA_NETO, ANA_NIVEL_P" & _
        "RECIO = @ANA_NIVEL_PRECIO, CLIENTE1 = @CLIENTE1, CLIENTE2 = @CLIENTE2, CLIENTE3 " & _
        "= @CLIENTE3, CLIENTET = @CLIENTET WHERE (ANA_CODIGO = @Original_ANA_CODIGO) AND " & _
        "(ANA_ANALISIS = @Original_ANA_ANALISIS OR @Original_ANA_ANALISIS IS NULL AND ANA" & _
        "_ANALISIS IS NULL) AND (ANA_NETO = @Original_ANA_NETO OR @Original_ANA_NETO IS N" & _
        "ULL AND ANA_NETO IS NULL) AND (ANA_NIVEL_PRECIO = @Original_ANA_NIVEL_PRECIO OR " & _
        "@Original_ANA_NIVEL_PRECIO IS NULL AND ANA_NIVEL_PRECIO IS NULL) AND (CLIENTE1 =" & _
        " @Original_CLIENTE1 OR @Original_CLIENTE1 IS NULL AND CLIENTE1 IS NULL) AND (CLI" & _
        "ENTE2 = @Original_CLIENTE2 OR @Original_CLIENTE2 IS NULL AND CLIENTE2 IS NULL) A" & _
        "ND (CLIENTE3 = @Original_CLIENTE3 OR @Original_CLIENTE3 IS NULL AND CLIENTE3 IS " & _
        "NULL) AND (CLIENTET = @Original_CLIENTET OR @Original_CLIENTET IS NULL AND CLIEN" & _
        "TET IS NULL) AND (SUB_CODIGO = @Original_SUB_CODIGO OR @Original_SUB_CODIGO IS N" & _
        "ULL AND SUB_CODIGO IS NULL) AND (TMU_CODIGO = @Original_TMU_CODIGO OR @Original_" & _
        "TMU_CODIGO IS NULL AND TMU_CODIGO IS NULL); SELECT ANA_CODIGO, ANA_ANALISIS, TMU" & _
        "_CODIGO, SUB_CODIGO, ANA_NETO, ANA_NIVEL_PRECIO, CLIENTE1, CLIENTE2, CLIENTE3, C" & _
        "LIENTET FROM ANALISIS WHERE (ANA_CODIGO = @ANA_CODIGO)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_CODIGO", System.Data.SqlDbType.Float, 8, "ANA_CODIGO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.NVarChar, 110, "ANA_ANALISIS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NETO", System.Data.SqlDbType.Float, 8, "ANA_NETO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, "ANA_NIVEL_PRECIO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE1", System.Data.SqlDbType.NVarChar, 1, "CLIENTE1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE2", System.Data.SqlDbType.NVarChar, 1, "CLIENTE2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE3", System.Data.SqlDbType.NVarChar, 1, "CLIENTE3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTET", System.Data.SqlDbType.NVarChar, 1, "CLIENTET"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.NVarChar, 110, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NETO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NETO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NIVEL_PRECIO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE1", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE2", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE3", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTET", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTET", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM ANALISIS WHERE (ANA_CODIGO = @Original_ANA_CODIGO) AND (ANA_ANALISIS " & _
        "= @Original_ANA_ANALISIS OR @Original_ANA_ANALISIS IS NULL AND ANA_ANALISIS IS N" & _
        "ULL) AND (ANA_NETO = @Original_ANA_NETO OR @Original_ANA_NETO IS NULL AND ANA_NE" & _
        "TO IS NULL) AND (ANA_NIVEL_PRECIO = @Original_ANA_NIVEL_PRECIO OR @Original_ANA_" & _
        "NIVEL_PRECIO IS NULL AND ANA_NIVEL_PRECIO IS NULL) AND (CLIENTE1 = @Original_CLI" & _
        "ENTE1 OR @Original_CLIENTE1 IS NULL AND CLIENTE1 IS NULL) AND (CLIENTE2 = @Origi" & _
        "nal_CLIENTE2 OR @Original_CLIENTE2 IS NULL AND CLIENTE2 IS NULL) AND (CLIENTE3 =" & _
        " @Original_CLIENTE3 OR @Original_CLIENTE3 IS NULL AND CLIENTE3 IS NULL) AND (CLI" & _
        "ENTET = @Original_CLIENTET OR @Original_CLIENTET IS NULL AND CLIENTET IS NULL) A" & _
        "ND (SUB_CODIGO = @Original_SUB_CODIGO OR @Original_SUB_CODIGO IS NULL AND SUB_CO" & _
        "DIGO IS NULL) AND (TMU_CODIGO = @Original_TMU_CODIGO OR @Original_TMU_CODIGO IS " & _
        "NULL AND TMU_CODIGO IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.NVarChar, 110, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NETO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NETO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NIVEL_PRECIO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE1", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE2", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE3", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTET", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTET", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adap_Imp_Lista
        '
        Me.Adap_Imp_Lista.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adap_Imp_Lista.InsertCommand = Me.SqlInsertCommand1
        Me.Adap_Imp_Lista.SelectCommand = Me.SqlSelectCommand1
        Me.Adap_Imp_Lista.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO"), New System.Data.Common.DataColumnMapping("SUB_CODIGO", "SUB_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_NETO", "ANA_NETO"), New System.Data.Common.DataColumnMapping("ANA_NIVEL_PRECIO", "ANA_NIVEL_PRECIO"), New System.Data.Common.DataColumnMapping("CLIENTE1", "CLIENTE1"), New System.Data.Common.DataColumnMapping("CLIENTE2", "CLIENTE2"), New System.Data.Common.DataColumnMapping("CLIENTE3", "CLIENTE3"), New System.Data.Common.DataColumnMapping("CLIENTET", "CLIENTET")})})
        Me.Adap_Imp_Lista.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT SUB_CODIGO, SUB_DESCRIPCION, TMU_CODIGO FROM SUBMUESTRA"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO SUBMUESTRA(SUB_CODIGO, SUB_DESCRIPCION, TMU_CODIGO) VALUES (@SUB_CODI" & _
        "GO, @SUB_DESCRIPCION, @TMU_CODIGO); SELECT SUB_CODIGO, SUB_DESCRIPCION, TMU_CODI" & _
        "GO FROM SUBMUESTRA WHERE (SUB_CODIGO = @SUB_CODIGO)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, "SUB_DESCRIPCION"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE SUBMUESTRA SET SUB_CODIGO = @SUB_CODIGO, SUB_DESCRIPCION = @SUB_DESCRIPCIO" & _
        "N, TMU_CODIGO = @TMU_CODIGO WHERE (SUB_CODIGO = @Original_SUB_CODIGO) AND (SUB_D" & _
        "ESCRIPCION = @Original_SUB_DESCRIPCION OR @Original_SUB_DESCRIPCION IS NULL AND " & _
        "SUB_DESCRIPCION IS NULL) AND (TMU_CODIGO = @Original_TMU_CODIGO OR @Original_TMU" & _
        "_CODIGO IS NULL AND TMU_CODIGO IS NULL); SELECT SUB_CODIGO, SUB_DESCRIPCION, TMU" & _
        "_CODIGO FROM SUBMUESTRA WHERE (SUB_CODIGO = @SUB_CODIGO)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, "SUB_DESCRIPCION"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM SUBMUESTRA WHERE (SUB_CODIGO = @Original_SUB_CODIGO) AND (SUB_DESCRIP" & _
        "CION = @Original_SUB_DESCRIPCION OR @Original_SUB_DESCRIPCION IS NULL AND SUB_DE" & _
        "SCRIPCION IS NULL) AND (TMU_CODIGO = @Original_TMU_CODIGO OR @Original_TMU_CODIG" & _
        "O IS NULL AND TMU_CODIGO IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adap_Submuestra
        '
        Me.Adap_Submuestra.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adap_Submuestra.InsertCommand = Me.SqlInsertCommand3
        Me.Adap_Submuestra.SelectCommand = Me.SqlSelectCommand3
        Me.Adap_Submuestra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SUBMUESTRA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SUB_CODIGO", "SUB_CODIGO"), New System.Data.Common.DataColumnMapping("SUB_DESCRIPCION", "SUB_DESCRIPCION"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO")})})
        Me.Adap_Submuestra.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT TMU_CODIGO, TMU_MUESTRA FROM MUESTRA"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO MUESTRA(TMU_CODIGO, TMU_MUESTRA) VALUES (@TMU_CODIGO, @TMU_MUESTRA); " & _
        "SELECT TMU_CODIGO, TMU_MUESTRA FROM MUESTRA WHERE (TMU_CODIGO = @TMU_CODIGO)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Float, 8, "TMU_CODIGO"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, "TMU_MUESTRA"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE MUESTRA SET TMU_CODIGO = @TMU_CODIGO, TMU_MUESTRA = @TMU_MUESTRA WHERE (TM" & _
        "U_CODIGO = @Original_TMU_CODIGO) AND (TMU_MUESTRA = @Original_TMU_MUESTRA OR @Or" & _
        "iginal_TMU_MUESTRA IS NULL AND TMU_MUESTRA IS NULL); SELECT TMU_CODIGO, TMU_MUES" & _
        "TRA FROM MUESTRA WHERE (TMU_CODIGO = @TMU_CODIGO)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Float, 8, "TMU_CODIGO"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, "TMU_MUESTRA"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM MUESTRA WHERE (TMU_CODIGO = @Original_TMU_CODIGO) AND (TMU_MUESTRA = " & _
        "@Original_TMU_MUESTRA OR @Original_TMU_MUESTRA IS NULL AND TMU_MUESTRA IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adap_Muestra
        '
        Me.Adap_Muestra.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adap_Muestra.InsertCommand = Me.SqlInsertCommand4
        Me.Adap_Muestra.SelectCommand = Me.SqlSelectCommand4
        Me.Adap_Muestra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MUESTRA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO"), New System.Data.Common.DataColumnMapping("TMU_MUESTRA", "TMU_MUESTRA")})})
        Me.Adap_Muestra.UpdateCommand = Me.SqlUpdateCommand4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.CheckBox17)
        Me.GroupBox5.Controls.Add(Me.CheckBox18)
        Me.GroupBox5.Controls.Add(Me.CheckBox19)
        Me.GroupBox5.Controls.Add(Me.CheckBox20)
        Me.GroupBox5.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox5.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "5.- Fert-Qui"
        '
        'CheckBox17
        '
        Me.CheckBox17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox17.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox17.TabIndex = 3
        '
        'CheckBox18
        '
        Me.CheckBox18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox18.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox18.TabIndex = 2
        '
        'CheckBox19
        '
        Me.CheckBox19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox19.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox19.TabIndex = 1
        '
        'CheckBox20
        '
        Me.CheckBox20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox20.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox20.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.CheckBox21)
        Me.GroupBox6.Controls.Add(Me.CheckBox22)
        Me.GroupBox6.Controls.Add(Me.CheckBox23)
        Me.GroupBox6.Controls.Add(Me.CheckBox24)
        Me.GroupBox6.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox6.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "6.- Fert-Org"
        '
        'CheckBox21
        '
        Me.CheckBox21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox21.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox21.TabIndex = 3
        '
        'CheckBox22
        '
        Me.CheckBox22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox22.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox22.TabIndex = 2
        '
        'CheckBox23
        '
        Me.CheckBox23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox23.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox23.TabIndex = 1
        '
        'CheckBox24
        '
        Me.CheckBox24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox24.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox24.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.CheckBox25)
        Me.GroupBox7.Controls.Add(Me.CheckBox26)
        Me.GroupBox7.Controls.Add(Me.CheckBox27)
        Me.GroupBox7.Controls.Add(Me.CheckBox28)
        Me.GroupBox7.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox7.Location = New System.Drawing.Point(8, 224)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "7.-+Análisis"
        '
        'CheckBox25
        '
        Me.CheckBox25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox25.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox25.TabIndex = 3
        '
        'CheckBox26
        '
        Me.CheckBox26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox26.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox26.TabIndex = 2
        '
        'CheckBox27
        '
        Me.CheckBox27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox27.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox27.TabIndex = 1
        '
        'CheckBox28
        '
        Me.CheckBox28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox28.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox28.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.CheckBox29)
        Me.GroupBox8.Controls.Add(Me.CheckBox30)
        Me.GroupBox8.Controls.Add(Me.CheckBox31)
        Me.GroupBox8.Controls.Add(Me.CheckBox32)
        Me.GroupBox8.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox8.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "8.-Kit,Otros"
        '
        'CheckBox29
        '
        Me.CheckBox29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox29.Location = New System.Drawing.Point(472, 16)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox29.TabIndex = 3
        '
        'CheckBox30
        '
        Me.CheckBox30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox30.Location = New System.Drawing.Point(384, 16)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox30.TabIndex = 2
        '
        'CheckBox31
        '
        Me.CheckBox31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox31.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox31.TabIndex = 1
        '
        'CheckBox32
        '
        Me.CheckBox32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox32.Location = New System.Drawing.Point(144, 16)
        Me.CheckBox32.Name = "CheckBox32"
        Me.CheckBox32.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox32.TabIndex = 0
        '
        'Frm_Imprimir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 335)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_Imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Imprimir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Cjto_Imprimir1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fuente, destino, fcorta, fecha_alreves As String
        Dim largo As Integer
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim via As String
        Dim MyDate As Date
        cont = 0
        pix = 12.75
        MyDate = Today
        fecha_alreves = Mid(MyDate, 7, 4) & "-" & Mid(MyDate, 4, 2) & "-" & Mid(MyDate, 1, 2)
        fuente = "F:\Cotizacion\Formato_Impresion.xls"
        destino = "F:\Cotizacion\Lista de Precio " & fecha_alreves & ".xls"
        m_Excel = CreateObject("EXCEL.APPLICATION")
        Try
            FileCopy(fuente, destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
            GoTo noimprime
        End Try
        objLibroExcel = m_Excel.Workbooks.Open(destino)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()
        If Npl1 <> "" Then Call pagina_notas(objHojaExcel)
        Try
            fcorta = Format(MyDate, "dd MMMMMMMMMM yyyy")
            largo = Len(fcorta)
            fechaf = Mid(fcorta, 1, 2) & " de " + Mid(fcorta, 4, (largo - 8)) & " de" & Mid(fcorta, (largo - 4))
            objHojaExcel.Range("X2").Value = fechaf
            objHojaExcel.Range("X2").Font.Size = 8

        Catch ex As Exception

        End Try
        pag = 1
        objHojaExcel.Range("AE4").Value = "Pag : " & pag
        objHojaExcel.Range("AE4").Font.Size = 8


        If CheckBox4.Checked = True Or CheckBox5.Checked = True _
        Or CheckBox9.Checked = True Or CheckBox13.Checked = True _
        Or CheckBox17.Checked = True Or CheckBox21.Checked = True _
        Or CheckBox25.Checked = True Or CheckBox29.Checked = True Then
            objHojaExcel.Range("K5").Value = "LISTADO DE ANALISIS"
            objHojaExcel.Range("K5").Font.Size = 14
            objHojaExcel.Range("K5").Font.Bold = True

            objHojaExcel.Range("A7:B7").Merge()
            objHojaExcel.Range("A7").Value = "Cód."
            objHojaExcel.Range("A7").Font.Bold = True
            objHojaExcel.Range("A7").Font.Size = 10
            objHojaExcel.Range("A7:B7" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            objHojaExcel.Range("C7:AD7").Merge()
            objHojaExcel.Range("C7").Value = "Análisis"
            objHojaExcel.Range("C7").Font.Bold = True
            objHojaExcel.Range("C7").Font.Size = 10
            objHojaExcel.Range("C7:AD7" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            objHojaExcel.Range("AE7:AH7").Merge()
            objHojaExcel.Range("AE7").Value = "Valor Neto"
            objHojaExcel.Range("AE7").Font.Bold = True
            objHojaExcel.Range("AE7").Font.Size = 8
            objHojaExcel.Range("AE7:AH7" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        Else
            If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True _
            Or CheckBox8.Checked = True Or CheckBox7.Checked = True Or CheckBox6.Checked = True _
            Or CheckBox12.Checked = True Or CheckBox11.Checked = True Or CheckBox10.Checked = True _
            Or CheckBox16.Checked = True Or CheckBox15.Checked = True Or CheckBox14.Checked = True _
            Or CheckBox20.Checked = True Or CheckBox19.Checked = True Or CheckBox18.Checked = True _
            Or CheckBox24.Checked = True Or CheckBox23.Checked = True Or CheckBox22.Checked = True _
            Or CheckBox28.Checked = True Or CheckBox27.Checked = True Or CheckBox26.Checked = True _
            Or CheckBox32.Checked = True Or CheckBox31.Checked = True Or CheckBox30.Checked = True Then
                objHojaExcel.Range("K5").Value = "LISTADO PRECIOS DE ANALISIS"
                objHojaExcel.Range("K5").Font.Size = 14
                objHojaExcel.Range("K5").Font.Bold = True

                objHojaExcel.Range("AE7:AH7").Merge()
                objHojaExcel.Range("AE7").Value = "$ Valor Neto"
                objHojaExcel.Range("AE7").Font.Bold = True
                objHojaExcel.Range("AE7").Font.Size = 9
                objHojaExcel.Range("AE7:AH7" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
        End If
        j = 7 : ll = 7
        suma_pixeles = 94.5
        If CheckBox4.Checked = True Then
            Call listado_codigo(1000, 2000, objHojaExcel)
        Else
            If CheckBox1.Checked = True Then
                Call listado_cliente(1000, 2000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox2.Checked = True Then
                Call listado_cliente(1000, 2000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox3.Checked = True Then
                Call listado_cliente(1000, 2000, objHojaExcel, "CLIENTE3")
            End If
        End If


        If CheckBox5.Checked = True Then
            Call listado_codigo(2000, 3000, objHojaExcel)
        Else
            If CheckBox8.Checked = True Then
                Call listado_cliente(2000, 3000, objHojaExcel, "CLIENTE1")
            End If
            If CheckBox7.Checked = True Then
                Call listado_cliente(2000, 3000, objHojaExcel, "CLIENTE2")
            End If
            If CheckBox6.Checked = True Then
                Call listado_cliente(2000, 3000, objHojaExcel, "CLIENTE3")
            End If
        End If



        If CheckBox9.Checked = True Then
            Call listado_codigo(3000, 4000, objHojaExcel)
        Else
            If CheckBox12.Checked = True Then
                Call listado_cliente(3000, 4000, objHojaExcel, "CLIENTE1")
            End If
            If CheckBox11.Checked = True Then
                Call listado_cliente(3000, 4000, objHojaExcel, "CLIENTE2")
            End If
            If CheckBox10.Checked = True Then
                Call listado_cliente(3000, 4000, objHojaExcel, "CLIENTE3")
            End If
        End If


        If CheckBox13.Checked = True Then
            Call listado_codigo(4000, 5000, objHojaExcel)
        Else
            If CheckBox16.Checked = True Then
                Call listado_cliente(4000, 5000, objHojaExcel, "CLIENTE1")
            End If
            If CheckBox15.Checked = True Then
                Call listado_cliente(4000, 5000, objHojaExcel, "CLIENTE2")
            End If
            If CheckBox14.Checked = True Then
                Call listado_cliente(4000, 5000, objHojaExcel, "CLIENTE3")
            End If
        End If

        If CheckBox17.Checked = True Then
            Call listado_codigo(5000, 6000, objHojaExcel)
        Else
            If CheckBox20.Checked = True Then
                Call listado_cliente(5000, 6000, objHojaExcel, "CLIENTE1")
            End If
            If CheckBox19.Checked = True Then
                Call listado_cliente(5000, 6000, objHojaExcel, "CLIENTE2")
            End If
            If CheckBox18.Checked = True Then
                Call listado_cliente(5000, 6000, objHojaExcel, "CLIENTE3")
            End If
        End If

        If CheckBox21.Checked = True Then
            Call listado_codigo(6000, 7000, objHojaExcel)
        Else
            If CheckBox24.Checked = True Then
                Call listado_cliente(6000, 7000, objHojaExcel, "CLIENTE1")
            End If
            If CheckBox23.Checked = True Then
                Call listado_cliente(6000, 7000, objHojaExcel, "CLIENTE2")
            End If
            If CheckBox22.Checked = True Then
                Call listado_cliente(6000, 7000, objHojaExcel, "CLIENTE3")
            End If
        End If
        If CheckBox25.Checked = True Then
            Call listado_codigo(7000, 8000, objHojaExcel)
        Else
            If CheckBox28.Checked = True Then
                Call listado_cliente(7000, 8000, objHojaExcel, "CLIENTE1")
            End If
            If CheckBox27.Checked = True Then
                Call listado_cliente(7000, 8000, objHojaExcel, "CLIENTE2")
            End If
            If CheckBox26.Checked = True Then
                Call listado_cliente(7000, 8000, objHojaExcel, "CLIENTE3")
            End If
        End If
        If CheckBox29.Checked = True Then
            Call listado_codigo(8000, 9000, objHojaExcel)
        Else
            If CheckBox32.Checked = True Then
                Call listado_cliente(8000, 9000, objHojaExcel, "CLIENTE1")
            End If
            If CheckBox31.Checked = True Then
                Call listado_cliente(8000, 9000, objHojaExcel, "CLIENTE2")
            End If
            If CheckBox30.Checked = True Then
                Call listado_cliente(8000, 9000, objHojaExcel, "CLIENTE3")
            End If
        End If
noimprime:
        Me.Close()
    End Sub
    Private Sub CAMBIA_HOJA(ByVal HOJA_EXCEL As Excel.Worksheet)
        HOJA_EXCEL.Range("AE" & j.ToString & ":AH" & j.ToString).Merge()
        HOJA_EXCEL.Range("AE" & j.ToString).Value = "Pag : " & pag
        HOJA_EXCEL.Range("AE" & j.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AE" & j.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        j = j + 1
        ll = ll + 1
        HOJA_EXCEL.Range("L" & j.ToString).Value = "LISTADO DE ANALISIS"
        HOJA_EXCEL.Range("L" & j.ToString).Font.Size = 14
        HOJA_EXCEL.Range("L" & j.ToString).Font.Bold = True
        j = j + 2
    End Sub
    Private Sub Frm_Imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cjto_Imprimir1.Tables("ANALISIS").Clear()
        Cjto_Imprimir1.Tables("COMBO_ANALISIS").Clear()
        Adap_Imp_Lista.Fill(Cjto_Imprimir1, "ANALISIS")
        Adap_Imp_Combo.Fill(Cjto_Imprimir1, "COMBO_ANALISIS")
        Adap_Submuestra.Fill(Cjto_Imprimir1, "SUBMUESTRA")
        Adap_Muestra.Fill(Cjto_Imprimir1, "MUESTRA")
    End Sub
    Public Sub BORDES(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal IB As Integer)
        Dim LIN As Integer
        'HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).BorderAround()
        With HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub
    Public Sub listado_cliente(ByVal DESDE As Double, ByVal HASTA As Double, _
    ByVal HOJA_EXCEL As Excel.Worksheet, ByVal CLIENTE As String)
        Dim A, fila_llave, FILA_PARA_PRECIO As Integer
        Dim FILA_IMPRIME, FILA_RANGO, fila_combo As DataRow
        Dim BOLA As Object
        Dim puntosx As String
        Dim suma_pix As Double
        Dim prim As Integer
        ES_SIMPLE = 0
        puntosx = "................................................................" & _
        "........................................................................" & _
        "........................................................................"

        For Each FILA_IMPRIME In Cjto_Imprimir1.Tables("ANALISIS").Rows
            If IsDBNull(FILA_IMPRIME("CLIENTE1")) = True Then FILA_IMPRIME("CLIENTE1") = ""
            If IsDBNull(FILA_IMPRIME("CLIENTE2")) = True Then FILA_IMPRIME("CLIENTE2") = ""
            If IsDBNull(FILA_IMPRIME("CLIENTE3")) = True Then FILA_IMPRIME("CLIENTE3") = ""
            If FILA_IMPRIME("ANA_CODIGO") >= DESDE And FILA_IMPRIME("ANA_CODIGO") < HASTA And _
                   FILA_IMPRIME(CLIENTE) = "x" Then
                If pag = 1 And (j Mod 59) = 0 Then
                    cont = cont + 1
                    pag = pag + 1
                    j = j + 3 : ll = ll + 3
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                    suma_pixeles = suma_pixeles + (pix * 5)
                End If
                Try
                    BOLA = FILA_IMPRIME("ANA_CODIGO")
                    FILA_RANGO = Cjto_Imprimir1.Tables("MUESTRA").Rows.Find(BOLA)
                    If Not (FILA_RANGO Is Nothing) Then
                        If j = 8 Then j = j + 1 : ll = ll + 1 : suma_pixeles = suma_pixeles + pix Else j = j + 2 : suma_pixeles = suma_pixeles + (pix * 2) : ll = ll + 2
                        If pag = 1 And (j Mod 59) = 0 Then
                            cont = cont + 1
                            pag = pag + 1
                            j = j + 3 : ll = ll + 3
                            Call CAMBIA_HOJA(HOJA_EXCEL)
                            suma_pixeles = suma_pixeles + (pix * 5)
                        End If
                        HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).Merge()
                        HOJA_EXCEL.Range("A" & j.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                        HOJA_EXCEL.Range("A" & j.ToString).Font.Size = 9
                        HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        HOJA_EXCEL.Range("A" & j.ToString).Font.Bold = True
                        GoTo sub14
                    End If
                Catch ex As Exception
                End Try
                If FILA_IMPRIME("TIPO_COD") = "CO" Then
                    A = 0
                    If ll > 54 Then
                        cont = cont + 1
                        pag = pag + 1
                        j = j + 6 : ll = 4
                        suma_pixeles = suma_pixeles + (pix * 8) + 18
                        Call CAMBIA_HOJA(HOJA_EXCEL)
                    End If
                Else
                    Try
                        BOLA = FILA_IMPRIME("ANA_CODIGO")
                        FILA_RANGO = Cjto_Imprimir1.Tables("SUBMUESTRA").Rows.Find(BOLA)
                        If Not (FILA_RANGO Is Nothing) Then
                            j = j + 1 : ll = ll + 1
                            suma_pixeles = suma_pixeles + pix
                            If pag = 1 And (j Mod 59) = 0 Then
                                cont = cont + 1
                                pag = pag + 1
                                j = j + 3 : ll = ll + 3
                                Call CAMBIA_HOJA(HOJA_EXCEL)
                                suma_pixeles = suma_pixeles + (pix * 5)
                            End If
                            HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).Merge()
                            HOJA_EXCEL.Range("A" & j.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                            HOJA_EXCEL.Range("A" & j.ToString).Font.Size = 9
                            HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            HOJA_EXCEL.Range("A" & j.ToString).Font.Bold = True
                            GoTo sub14
                        End If
                    Catch ex As Exception
                    End Try
                    j = j + 1 : ll = ll + 1
                    suma_pixeles = suma_pixeles + pix
                    If pag = 1 And (j Mod 59) = 0 Then
                        cont = cont + 1
                        pag = pag + 1
                        j = j + 3 : ll = ll + 3
                        Call CAMBIA_HOJA(HOJA_EXCEL)
                        suma_pixeles = suma_pixeles + (pix * 6)
                    End If
                    HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).Merge()
                    HOJA_EXCEL.Range("A" & j.ToString).Value = "  " & FILA_IMPRIME("ANA_ANALISIS") & puntosx
                    HOJA_EXCEL.Range("A" & j.ToString).Font.Size = 9
                    HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    HOJA_EXCEL.Range("AE" & j.ToString).Value = "$ "
                    HOJA_EXCEL.Range("AE" & j.ToString).Font.Size = 9
                    HOJA_EXCEL.Range("AF" & j.ToString & ":AH" & j.ToString).Merge()
                    HOJA_EXCEL.Range("AF" & j.ToString).Value = FILA_IMPRIME("ANA_NETO")
                    HOJA_EXCEL.Range("AF" & j.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    HOJA_EXCEL.Range("AF" & j.ToString).Font.Size = 9
                    ES_SIMPLE = 1
                End If
                fila_llave = 0
                FILA_PARA_PRECIO = j + 1
                suma_pix = 0 : prim = 0
                For Each fila_combo In Cjto_Imprimir1.Tables("COMBO_ANALISIS").Rows
                    If fila_combo("COB_CODIGO") = FILA_IMPRIME("ANA_CODIGO") Then
                        fila_llave = fila_llave + 1
                        A = 1
                        If ES_SIMPLE = 1 Then
                            FILA_PARA_PRECIO = FILA_PARA_PRECIO + 1
                            If prim = 0 Then suma_pix = suma_pixeles + pix : prim = 1
                            j = j + 2 : ll = ll + 2 : suma_pixeles = suma_pixeles + (pix * 2)
                        Else
                            If prim = 0 Then suma_pix = suma_pixeles : prim = 1
                            j = j + 1 : ll = ll + 1 : suma_pixeles = suma_pixeles + pix
                        End If
                        HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).Merge()
                        HOJA_EXCEL.Range("A" & j.ToString).Value = "  " & fila_combo("ANA_ANALISIS") & puntosx
                        HOJA_EXCEL.Range("A" & j.ToString).Font.Size = 9
                        HOJA_EXCEL.Range("A" & j.ToString & ":AD" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        ES_SIMPLE = 0
                    End If
                Next
                If fila_llave > 1 Then HOJA_EXCEL.Shapes.AddShape(32, 428.25, suma_pix, 5, ((fila_llave) * 12))
                If A = 1 Then
                    HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString & ":AE" & j.ToString).Merge()
                    HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString).Value = "$"
                    HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString & ":AE" & j.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString & ":AH" & j.ToString).Merge()
                    HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString & ":AH" & j.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("ANA_NETO")
                    HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Font.Size = 9
                    j = j + 1 : ll = ll + 1
                    suma_pixeles = suma_pixeles + pix
                End If
sub14:
                fila_llave = 0
                A = 0
            End If
        Next

    End Sub

    Public Sub listado_codigo(ByVal desde As Integer, ByVal hasta As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim FILA_IMPRIME, FILA_RANGO As DataRow
        Dim A As Integer
        Dim BOLA As Object
        For Each FILA_IMPRIME In Cjto_Imprimir1.Tables("ANALISIS").Rows
            If IsDBNull(FILA_IMPRIME("CLIENTET")) = True Then FILA_IMPRIME("CLIENTET") = ""
            If FILA_IMPRIME("ANA_CODIGO") >= desde And FILA_IMPRIME("ANA_CODIGO") < hasta _
            And FILA_IMPRIME("CLIENTET") = "x" Then
                If pag = 1 And (j Mod 59) = 0 Then
                    cont = cont + 1
                    pag = pag + 1
                    j = j + 3
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                End If
                If pag <> 1 And (j Mod ((60 * pag) + cont)) = 0 Then
                    cont = cont + 1
                    pag = pag + 1
                    j = j + 2
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                End If
                Try
                    BOLA = FILA_IMPRIME("ANA_CODIGO")
                    FILA_RANGO = Cjto_Imprimir1.Tables("MUESTRA").Rows.Find(BOLA)
                    If Not (FILA_RANGO Is Nothing) Then
                        j = j + 1
                        If pag = 1 And (j Mod 59) = 0 Then
                            cont = cont + 1
                            pag = pag + 1
                            j = j + 3
                            Call CAMBIA_HOJA(HOJA_EXCEL)
                        End If
                        If pag <> 1 And (j Mod ((60 * pag) + cont)) = 0 Then
                            cont = cont + 1
                            pag = pag + 1
                            j = j + 2
                            Call CAMBIA_HOJA(HOJA_EXCEL)
                        End If
                        j = j + 1
                        If pag = 1 And (j Mod 59) = 0 Then
                            cont = cont + 1
                            pag = pag + 1
                            j = j + 3
                            Call CAMBIA_HOJA(HOJA_EXCEL)
                        End If
                        If pag <> 1 And (j Mod ((60 * pag) + cont)) = 0 Then
                            cont = cont + 1
                            pag = pag + 1
                            j = j + 2
                            Call CAMBIA_HOJA(HOJA_EXCEL)
                        End If
                        HOJA_EXCEL.Range("A" & j.ToString & ":AE" & j.ToString).Merge()
                        HOJA_EXCEL.Range("A" & j.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                        HOJA_EXCEL.Range("A" & j.ToString).Font.Size = 9
                        HOJA_EXCEL.Range("A" & j.ToString).Font.Bold = True
                        HOJA_EXCEL.Range("A" & j.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        Call BORDES(HOJA_EXCEL, j)
                        GoTo sub13
                    End If
                Catch ex As Exception
                End Try

                Try
                    BOLA = FILA_IMPRIME("ANA_CODIGO")
                    FILA_RANGO = Cjto_Imprimir1.Tables("SUBMUESTRA").Rows.Find(BOLA)
                    If Not (FILA_RANGO Is Nothing) Then
                        j = j + 1
                        If pag = 1 And (j Mod 59) = 0 Then
                            cont = cont + 1
                            pag = pag + 1
                            j = j + 3
                            Call CAMBIA_HOJA(HOJA_EXCEL)
                        End If
                        If pag <> 1 And (j Mod ((60 * pag) + cont)) = 0 Then
                            cont = cont + 1
                            pag = pag + 1
                            j = j + 2
                            Call CAMBIA_HOJA(HOJA_EXCEL)
                        End If
                        HOJA_EXCEL.Range("A" & j.ToString & ":AE" & j.ToString).Merge()
                        HOJA_EXCEL.Range("A" & j.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                        HOJA_EXCEL.Range("A" & j.ToString).Font.Size = 9
                        HOJA_EXCEL.Range("A" & j.ToString).Font.Bold = True
                        HOJA_EXCEL.Range("A" & j.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        Call BORDES(HOJA_EXCEL, j)
                        GoTo sub13
                    End If
                Catch ex As Exception
                End Try

                j = j + 1
                HOJA_EXCEL.Range("A" & j.ToString & ":B" & j.ToString).Merge()
                HOJA_EXCEL.Range("A" & j.ToString).Value = FILA_IMPRIME("ANA_CODIGO")
                HOJA_EXCEL.Range("A" & j.ToString).Font.Size = 9
                HOJA_EXCEL.Range("A" & j.ToString & ":B" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


                HOJA_EXCEL.Range("C" & j.ToString & ":AE" & j.ToString).Merge()
                HOJA_EXCEL.Range("C" & j.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                HOJA_EXCEL.Range("C" & j.ToString).Font.Size = 9
                HOJA_EXCEL.Range("C" & j.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


                HOJA_EXCEL.Range("AF" & j.ToString & ":AH" & j.ToString).Merge()
                HOJA_EXCEL.Range("AF" & j.ToString).Value = FILA_IMPRIME("ANA_NETO")
                HOJA_EXCEL.Range("AF" & j.ToString).Font.Size = 9
                HOJA_EXCEL.Range("AF" & j.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                Call BORDES(HOJA_EXCEL, j)
            End If
sub13:
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Form_Notas_Listado As New Notas_Listado
        Form_Notas_Listado.Show()
    End Sub

    Private Sub pagina_notas(ByVal objHojaExcel As Excel.Worksheet)
        Dim fcorta, largoco, MAIL2, CEL, RCOMUNA, RCIUDAD, nomb, varmer As String
        Dim largo, k, fila As Integer
        Dim cnvn As New Coversion1
        objHojaExcel.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\Logo  mediano Agro.jpg").Select()
        Try
            fcorta = Format(LFecha, "dd MMMMMMMMMM yyyy")
            largo = Len(fcorta)
            fechaf = Mid(fcorta, 1, 2) & " de " + Mid(fcorta, 4, (largo - 8)) & " de" & Mid(fcorta, (largo - 4))
            objHojaExcel.Range("X2").Value = fechaf
            objHojaExcel.Range("X2").Font.Size = 10

        Catch ex As Exception

        End Try
        objHojaExcel.Range("A6").Value = "Señor(es):"
        Try
            If LNombre <> "" Then
                objHojaExcel.Range("A7").Value = LEmpresa
                objHojaExcel.Range("A7").Font.Bold = True
                objHojaExcel.Range("A7").Font.Size = 10
                GoTo nopodu
            End If
            objHojaExcel.Range("A7").Value = LEmpresa
            objHojaExcel.Range("A7").Font.Bold = True
            objHojaExcel.Range("A7").Font.Size = 10
        Catch ex As Exception
        End Try
nopodu:
        fila = 6
        MAIL2 = ""
        Try
            If LEmail2 <> "" And IsDBNull(LEmail2) = False Then
                MAIL2 = LEmail2
                MAIL2 = " ; " & MAIL2
            End If
        Catch ex As Exception

        End Try


        Try
            If IsDBNull(LEmail) = False And LEmail <> "" Then
                fila = fila + 1
                objHojaExcel.Range("D" & fila.ToString).Value = ": " & LEmail & MAIL2
                objHojaExcel.Range("D" & fila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & fila.ToString).Value = "e-mail"
                objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            End If

        Catch ex As Exception

        End Try
        Try
            CEL = LCelular
            CEL = " /" & CEL
        Catch ex As Exception
        End Try
        If CEL = " /" Then CEL = ""
        Try
            If IsDBNull(LFono) = False And LFono <> "" Then
                fila = fila + 1
                objHojaExcel.Range("D" & fila.ToString).Value = ": " & LFono & CEL
                objHojaExcel.Range("D" & fila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & fila.ToString).Value = "Fono"
                objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            End If
        Catch ex As Exception
        End Try

        Try
            If IsDBNull(LFax) = False And LFax <> "" Then
                fila = fila + 1
                objHojaExcel.Range("D" & fila.ToString).Value = ": " & LFax
                objHojaExcel.Range("D" & fila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & fila.ToString).Value = "Fax"
                objHojaExcel.Range("A" & fila.ToString).Font.Size = 10

            End If

        Catch ex As Exception
        End Try


        Try
            RCIUDAD = LCiudad
        Catch ex As Exception
        End Try


        Try
            RCOMUNA = LComuna
        Catch ex As Exception
        End Try


        Try
            If IsDBNull(LDireccion) = False And LDireccion <> "" Then
                fila = fila + 1
                If RCOMUNA <> "" And RCOMUNA <> RCIUDAD And RCIUDAD <> "" Then
                    nomb = LComuna : cnvn.Minuscula(nomb)
                    objHojaExcel.Range("A" & fila.ToString).Value = LDireccion & ", " & nomb
                Else
                    objHojaExcel.Range("A" & fila.ToString).Value = LDireccion
                End If
                objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            End If
        Catch ex As Exception

        End Try

        Try
            If RCIUDAD = RCOMUNA Or RCIUDAD = "" Then
                RCOMUNA = LComuna
                fila = fila + 1
                nomb = LComuna
                cnvn.Minuscula(nomb)
                objHojaExcel.Range("A" & fila.ToString).Value = nomb
                objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & fila.ToString).Font.Underline = True
            Else
                RCIUDAD = LCiudad
                fila = fila + 1
                nomb = LCiudad
                cnvn.Minuscula(nomb)
                objHojaExcel.Range("A" & fila.ToString).Value = nomb
                objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & fila.ToString).Font.Underline = True
            End If
        Catch ex As Exception
        End Try

        Try

            nomb = LAtencion
            If nomb <> "" Then
                Call control_nombre(nomb)
                objHojaExcel.Range("W" & fila.ToString & ":AH" & fila.ToString).Merge()
                objHojaExcel.Range("W" & fila.ToString).Value = "At. : " & nomb
                objHojaExcel.Range("W" & fila.ToString).Font.Size = 10
                objHojaExcel.Range("W" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
        Catch ex As Exception

        End Try
        objHojaExcel.Range("A" & fila.ToString).Value = "De nuestra consideracion:"
        objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
        fila = fila + 1
        If Npl1 <> "" Then
            largoco = Npl1
            varmer = CInt(largoco / 125)
            k = fila + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl1
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        If Npl2 <> "" Then
            largoco = Npl2
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl2
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl3 <> "" Then
            largoco = Npl3
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl3
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl4 <> "" Then
            largoco = Npl4
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl4
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl5 <> "" Then
            largoco = Npl5
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl5
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl6 <> "" Then
            largoco = Npl6
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl6
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl7 <> "" Then
            largoco = Npl7
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl7
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl8 <> "" Then
            largoco = Npl8
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl8
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl9 <> "" Then
            largoco = Npl9
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl9
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl10 <> "" Then
            largoco = Npl10
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl10
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        If Npl11 <> "" Then
            largoco = Npl11
            varmer = CInt(largoco / 125)
            k = j + varmer
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
            objHojaExcel.Range("A" & fila.ToString).Value = Npl11
            objHojaExcel.Range("A" & fila.ToString).Font.Size = 10
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            objHojaExcel.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If


        objHojaExcel.Range("A62:DF62").Merge()
        objHojaExcel.Range("A62").Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        objHojaExcel.Range("A62").Font.Size = 9
        objHojaExcel.Range("A62").Font.Color = RGB(0, 0, 128)
        objHojaExcel.Range("A62:DF62").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
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
            acumula = acumula & LCase(Mid(nomb, i, 1))
continuar:
        Next
        nomb = acumula
    End Sub

End Class
