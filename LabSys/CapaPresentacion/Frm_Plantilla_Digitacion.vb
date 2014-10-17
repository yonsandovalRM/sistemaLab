Public Class Frm_Plantilla_Digitacion
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdMuestra As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdElemento As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCelD1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtCelD2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtCelD3 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents TxtMaxLab3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtMaxLab2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtMaxLab1 As System.Windows.Forms.TextBox
    Friend WithEvents BtGraba As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTitulo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmdMuestra = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdElemento = New System.Windows.Forms.ComboBox
        Me.TxtCelD1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtTitulo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtNombreArchivo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtMaxLab3 = New System.Windows.Forms.TextBox
        Me.TxtCelD3 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtMaxLab2 = New System.Windows.Forms.TextBox
        Me.TxtCelD2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtMaxLab1 = New System.Windows.Forms.TextBox
        Me.BtGraba = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plantillas de Planificacion"
        '
        'CmdMuestra
        '
        Me.CmdMuestra.DisplayMember = "MUESTRA.TMU_CODIGO"
        Me.CmdMuestra.Location = New System.Drawing.Point(104, 72)
        Me.CmdMuestra.Name = "CmdMuestra"
        Me.CmdMuestra.Size = New System.Drawing.Size(176, 21)
        Me.CmdMuestra.TabIndex = 1
        Me.CmdMuestra.ValueMember = "MUESTRA.TMU_CODIGO"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Muestra"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(344, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Elemento"
        '
        'CmdElemento
        '
        Me.CmdElemento.DisplayMember = "ELEMENTO.ELE_CODIGO"
        Me.CmdElemento.Location = New System.Drawing.Point(408, 72)
        Me.CmdElemento.Name = "CmdElemento"
        Me.CmdElemento.Size = New System.Drawing.Size(176, 21)
        Me.CmdElemento.TabIndex = 3
        Me.CmdElemento.ValueMember = "ELEMENTO.ELE_CODIGO"
        '
        'TxtCelD1
        '
        Me.TxtCelD1.Location = New System.Drawing.Point(168, 40)
        Me.TxtCelD1.Name = "TxtCelD1"
        Me.TxtCelD1.Size = New System.Drawing.Size(32, 20)
        Me.TxtCelD1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(144, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Celda Inicial"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtTitulo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtNombreArchivo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtMaxLab3)
        Me.GroupBox1.Controls.Add(Me.TxtCelD3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtMaxLab2)
        Me.GroupBox1.Controls.Add(Me.TxtCelD2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtMaxLab1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCelD1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 248)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Titulo del Informe"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(152, 176)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(264, 20)
        Me.TxtTitulo.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(32, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 16)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Nombre Archivo"
        '
        'TxtNombreArchivo
        '
        Me.TxtNombreArchivo.Location = New System.Drawing.Point(152, 208)
        Me.TxtNombreArchivo.Name = "TxtNombreArchivo"
        Me.TxtNombreArchivo.Size = New System.Drawing.Size(264, 20)
        Me.TxtNombreArchivo.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(40, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "N° Lab 3    :"
        '
        'TxtMaxLab3
        '
        Me.TxtMaxLab3.Location = New System.Drawing.Point(296, 120)
        Me.TxtMaxLab3.Name = "TxtMaxLab3"
        Me.TxtMaxLab3.Size = New System.Drawing.Size(32, 20)
        Me.TxtMaxLab3.TabIndex = 29
        '
        'TxtCelD3
        '
        Me.TxtCelD3.Location = New System.Drawing.Point(168, 120)
        Me.TxtCelD3.Name = "TxtCelD3"
        Me.TxtCelD3.Size = New System.Drawing.Size(32, 20)
        Me.TxtCelD3.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(40, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "N° Lab 2    :"
        '
        'TxtMaxLab2
        '
        Me.TxtMaxLab2.Location = New System.Drawing.Point(296, 80)
        Me.TxtMaxLab2.Name = "TxtMaxLab2"
        Me.TxtMaxLab2.Size = New System.Drawing.Size(32, 20)
        Me.TxtMaxLab2.TabIndex = 22
        '
        'TxtCelD2
        '
        Me.TxtCelD2.Location = New System.Drawing.Point(168, 80)
        Me.TxtCelD2.Name = "TxtCelD2"
        Me.TxtCelD2.Size = New System.Drawing.Size(32, 20)
        Me.TxtCelD2.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(40, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "N° Lab 1    :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(280, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Maximo Lab."
        '
        'TxtMaxLab1
        '
        Me.TxtMaxLab1.Location = New System.Drawing.Point(296, 40)
        Me.TxtMaxLab1.Name = "TxtMaxLab1"
        Me.TxtMaxLab1.Size = New System.Drawing.Size(32, 20)
        Me.TxtMaxLab1.TabIndex = 14
        '
        'BtGraba
        '
        Me.BtGraba.BackColor = System.Drawing.Color.Transparent
        Me.BtGraba.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.BtGraba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtGraba.Location = New System.Drawing.Point(288, 392)
        Me.BtGraba.Name = "BtGraba"
        Me.BtGraba.Size = New System.Drawing.Size(66, 23)
        Me.BtGraba.TabIndex = 9
        Me.BtGraba.Text = "Graba"
        Me.BtGraba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtGraba.UseVisualStyleBackColor = False
        '
        'Frm_Plantilla_Digitacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(608, 469)
        Me.Controls.Add(Me.BtGraba)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdElemento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdMuestra)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Plantilla_Digitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantilla Digitación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub






#End Region

    Private Sub BtGraba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGraba.Click
        Dim Fila As DataRow
        Cjto_Tablas1.Tables("PLANTILLA_PLANIFICACION").Clear()
        Fila = Cjto_Tablas1.Tables("PLANTILLA_PLANIFICACION").NewRow
        Fila.Item("TMU_CODIGO") = CmdMuestra.SelectedValue
        Fila.Item("ELE_CODIGO") = CmdElemento.SelectedValue

        If TxtCelD1.Text <> "" Then
            Fila.Item("CELDA_DESDE1") = TxtCelD1.Text
            Fila.Item("MAXIMO_LAB1") = CInt(TxtMaxLab1.Text)
        End If

        If TxtCelD2.Text <> "" Then
            Fila.Item("CELDA_DESDE2") = TxtCelD2.Text
            Fila.Item("MAXIMO_LAB2") = CInt(TxtMaxLab2.Text)
        End If

        If TxtCelD3.Text <> "" Then
            Fila.Item("CELDA_DESDE3") = TxtCelD3.Text
            Fila.Item("MAXIMO_LAB3") = CInt(TxtMaxLab3.Text)
        End If

        Fila.Item("NOMBRE_ARC") = TxtNombreArchivo.Text

        Fila.Item("TITULO") = TxtTitulo.Text
        Try
            Cjto_Tablas1.Tables("PLANTILLA_PLANIFICACION").Rows.Add(Fila)
        Catch ex As Exception
        End Try

        Dim DbManOT As DbManager
        DbManOT = New DbManager("PLANTILLA_PLANIFICACION", Conexion1)
        Try
            DbManOT.Update(Cjto_Tablas1)
        Catch ex As Exception
            MsgBox("Error en Grabacion(PLANTILLA PLANIFICACION), Comuniquese con Informatica")
        End Try
        MsgBox("Grabación Finalizada")
    End Sub
    Private Sub Anti_Elimina_lineas()
        Me.CmdMuestra.DataSource = Cjto_Tablas1
        Me.CmdMuestra.DisplayMember = "MUESTRA.TMU_MUESTRA"
        Me.CmdMuestra.ValueMember = "MUESTRA.TMU_CODIGO"
        Me.CmdElemento.DataSource = Cjto_Tablas1
        Me.CmdElemento.DisplayMember = "ELEMENTO.ELE_CODIGO"
        Me.CmdElemento.ValueMember = "ELEMENTO.ELE_NOMBRE"
    End Sub
    Private Sub Frm_Plantilla_Digitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina_lineas()
        TxtTitulo.Text = ""
    End Sub
    Private Sub CmdMuestra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMuestra.SelectedIndexChanged
        TxtTitulo.Text = ""
        TxtTitulo.Text = CmdMuestra.Text
    End Sub
    Private Sub CmdElemento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdElemento.SelectedIndexChanged
        TxtTitulo.Text = TxtTitulo.Text & ": " & UCase(CmdElemento.SelectedValue)
    End Sub
End Class
