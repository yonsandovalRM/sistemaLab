Public Class F_Relacion_Factura_Orden
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
    Friend WithEvents DTPFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumOt As System.Windows.Forms.TextBox
    Friend WithEvents BTAcepta As System.Windows.Forms.Button
    Friend WithEvents BTSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPFechaFactura = New System.Windows.Forms.DateTimePicker
        Me.TxtNumFactura = New System.Windows.Forms.TextBox
        Me.TxtNumOt = New System.Windows.Forms.TextBox
        Me.BTAcepta = New System.Windows.Forms.Button
        Me.BTSalir = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RELACION ORDEN - FACTURA"
        '
        'DTPFechaFactura
        '
        Me.DTPFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPFechaFactura.Location = New System.Drawing.Point(136, 200)
        Me.DTPFechaFactura.Name = "DTPFechaFactura"
        Me.DTPFechaFactura.Size = New System.Drawing.Size(88, 20)
        Me.DTPFechaFactura.TabIndex = 4
        '
        'TxtNumFactura
        '
        Me.TxtNumFactura.Location = New System.Drawing.Point(136, 168)
        Me.TxtNumFactura.Name = "TxtNumFactura"
        Me.TxtNumFactura.Size = New System.Drawing.Size(88, 20)
        Me.TxtNumFactura.TabIndex = 2
        Me.TxtNumFactura.Text = ""
        '
        'TxtNumOt
        '
        Me.TxtNumOt.Location = New System.Drawing.Point(136, 96)
        Me.TxtNumOt.Name = "TxtNumOt"
        Me.TxtNumOt.Size = New System.Drawing.Size(88, 20)
        Me.TxtNumOt.TabIndex = 0
        Me.TxtNumOt.Text = ""
        '
        'BTAcepta
        '
        Me.BTAcepta.Location = New System.Drawing.Point(200, 288)
        Me.BTAcepta.Name = "BTAcepta"
        Me.BTAcepta.TabIndex = 5
        Me.BTAcepta.Text = "Acepta"
        '
        'BTSalir
        '
        Me.BTSalir.Location = New System.Drawing.Point(328, 288)
        Me.BTSalir.Name = "BTSalir"
        Me.BTSalir.TabIndex = 6
        Me.BTSalir.Text = "Salir"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(56, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "N° OT"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(56, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Factura"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(56, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "N° Factura"
        '
        'Frm_Relacion_Factura_Orden
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTSalir)
        Me.Controls.Add(Me.BTAcepta)
        Me.Controls.Add(Me.TxtNumOt)
        Me.Controls.Add(Me.TxtNumFactura)
        Me.Controls.Add(Me.DTPFechaFactura)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Relacion_Factura_Orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Relacion_Factura_Orden"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BTSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSalir.Click
        Me.Close()
    End Sub

    Private Sub BTAcepta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAcepta.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        If TxtNumFactura.Text <> "0" And TxtNumFactura.Text <> "" Then
            With SP
                .Inicializar()
                .AgregarParametro("@NumOt", TxtNumOt.Text, SqlDbType.Int)
                .AgregarParametro("@NumFac", TxtNumFactura.Text, SqlDbType.Int)
                .AgregarParametro("@FechaFactura", DTPFechaFactura.Text, SqlDbType.DateTime)
                .EjecutarQuery("usp_UpdateRelacion_OrdenFactura")
            End With
        Else
            MsgBox("N° de Factura incorrecto, imposible grabar")
        End If
        TxtNumOt.Text = ""
        TxtNumFactura.Text = ""
        TxtNumOt.Focus()
    End Sub

    Private Sub TxtNumOt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumOt.KeyPress
        Dim ds As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        If e.KeyChar = Chr(13) Then
            With SP
                .Inicializar()
                .AgregarParametro("@NumOt", TxtNumOt.Text, SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectRelacion_OrdenFactura")
                If IsDBNull(ds.Tables(0).Rows(0).Item("FAC_NUMERO")) = False Then TxtNumFactura.Text = ds.Tables(0).Rows(0).Item("FAC_NUMERO")
                If IsDBNull(ds.Tables(0).Rows(0).Item("FAC_FECHA")) = False Then DTPFechaFactura.Text = ds.Tables(0).Rows(0).Item("FAC_FECHA")
                If IsDBNull(ds.Tables(0).Rows(0).Item("OT_ESTADO_FAC")) = False Then
                    MsgBox("El Estado de la Factura es : " & ds.Tables(0).Rows(0).Item("OT_ESTADO_FAC"))
                End If
            End With
            TxtNumFactura.Focus()
        End If
    End Sub

End Class
