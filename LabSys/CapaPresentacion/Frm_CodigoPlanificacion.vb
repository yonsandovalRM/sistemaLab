Public Class Frm_CodigoPlanificacion
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
    Friend WithEvents TxtNLab As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodPlani As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaPlani As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents cbTipoAnalisis As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtNLab = New System.Windows.Forms.TextBox
        Me.TxtCodPlani = New System.Windows.Forms.TextBox
        Me.TxtFechaPlani = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmdSalir = New System.Windows.Forms.Button
        Me.CmdAceptar = New System.Windows.Forms.Button
        Me.cbTipoAnalisis = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TxtNLab
        '
        Me.TxtNLab.Location = New System.Drawing.Point(165, 72)
        Me.TxtNLab.Name = "TxtNLab"
        Me.TxtNLab.Size = New System.Drawing.Size(100, 20)
        Me.TxtNLab.TabIndex = 0
        '
        'TxtCodPlani
        '
        Me.TxtCodPlani.Location = New System.Drawing.Point(165, 98)
        Me.TxtCodPlani.Name = "TxtCodPlani"
        Me.TxtCodPlani.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodPlani.TabIndex = 1
        '
        'TxtFechaPlani
        '
        Me.TxtFechaPlani.Location = New System.Drawing.Point(165, 124)
        Me.TxtFechaPlani.Name = "TxtFechaPlani"
        Me.TxtFechaPlani.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaPlani.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(51, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número Laboratorio :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(51, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código Planificación :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(51, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Planificación :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Busca código de planificación"
        '
        'CmdSalir
        '
        Me.CmdSalir.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalir.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalir.Location = New System.Drawing.Point(151, 168)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(64, 23)
        Me.CmdSalir.TabIndex = 8
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSalir.UseVisualStyleBackColor = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.Color.Transparent
        Me.CmdAceptar.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAceptar.Location = New System.Drawing.Point(271, 70)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(69, 23)
        Me.CmdAceptar.TabIndex = 6
        Me.CmdAceptar.Text = "Buscar"
        Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'cbTipoAnalisis
        '
        Me.cbTipoAnalisis.FormattingEnabled = True
        Me.cbTipoAnalisis.Location = New System.Drawing.Point(165, 46)
        Me.cbTipoAnalisis.Name = "cbTipoAnalisis"
        Me.cbTipoAnalisis.Size = New System.Drawing.Size(175, 21)
        Me.cbTipoAnalisis.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(51, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo de Analisis :"
        '
        'Frm_CodigoPlanificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(370, 224)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbTipoAnalisis)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFechaPlani)
        Me.Controls.Add(Me.TxtCodPlani)
        Me.Controls.Add(Me.TxtNLab)
        Me.Name = "Frm_CodigoPlanificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Código Planificacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim fecpla As Date

        Try
            With SP
                .Inicializar()
                .AgregarParametro("@CodMue", CInt(Me.cbTipoAnalisis.SelectedValue), SqlDbType.Int)
                .AgregarParametro("@NLab", CStr(TxtNLab.Text), SqlDbType.NVarChar)
                ds = .EjecutarQuery("usp_SelectCodigoPlanificacion")
            End With
            TxtCodPlani.Text = ds.Tables(0).Rows(0).Item("OTC_NLAB_DESDED")
            fecpla = ds.Tables(0).Rows(0).Item("OTC_FECHA_PLANI")
            TxtFechaPlani.Text = fecpla
        Catch ex As Exception
        End Try

    End Sub

    Private Sub TxtNLab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNLab.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub

    Private Sub Frm_CodigoPlanificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = "0"
        dr("Descripcion") = ""
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "1000"
        dr("Descripcion") = "Foliar "
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "2000"
        dr("Descripcion") = "Otros Tejidos "
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "3000"
        dr("Descripcion") = "Agua "
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "4000"
        dr("Descripcion") = "Suelo "
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "5000"
        dr("Descripcion") = "Fertilizantes Quimicos"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "6000"
        dr("Descripcion") = "Fertilizantes Organicos"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "7000"
        dr("Descripcion") = "Fitopatologicos "
        dt.Rows.Add(dr)


        Me.cbTipoAnalisis.DataSource = dt
        Me.cbTipoAnalisis.ValueMember = "Codigo"
        Me.cbTipoAnalisis.DisplayMember = "Descripcion"
    End Sub
End Class
