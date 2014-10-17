Public Class F_Despacha_x_RangoOT
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
    Friend WithEvents TxtDesde As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasta As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDesde = New System.Windows.Forms.TextBox
        Me.TxtHasta = New System.Windows.Forms.TextBox
        Me.CmdAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cambio Estado a Despachado ('De')"
        '
        'TxtDesde
        '
        Me.TxtDesde.Location = New System.Drawing.Point(136, 80)
        Me.TxtDesde.Name = "TxtDesde"
        Me.TxtDesde.Size = New System.Drawing.Size(72, 20)
        Me.TxtDesde.TabIndex = 1
        Me.TxtDesde.Text = ""
        '
        'TxtHasta
        '
        Me.TxtHasta.Location = New System.Drawing.Point(136, 128)
        Me.TxtHasta.Name = "TxtHasta"
        Me.TxtHasta.Size = New System.Drawing.Size(72, 20)
        Me.TxtHasta.TabIndex = 2
        Me.TxtHasta.Text = ""
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Location = New System.Drawing.Point(216, 200)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.TabIndex = 3
        Me.CmdAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(72, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OT Desde :"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(72, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "OT Hasta :"
        '
        'Frm_Despacha_x_RangoOT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 273)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.TxtHasta)
        Me.Controls.Add(Me.TxtDesde)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Despacha_x_RangoOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Despacha_x_RangoOT"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim xx, RESTA As Integer
        If CInt(TxtHasta.Text) - CInt(TxtDesde.Text) > 10 Then MsgBox("Sobrepasa Rango maximo") : GoTo nograba
        For xx = CInt(TxtDesde.Text) To CInt(TxtHasta.Text)
            With SP
                .Inicializar()
                .AgregarParametro("@NumOt", xx, SqlDbType.Int)
                .EjecutarQuery("usp_UpdateEstadoDespachado")
            End With
        Next
nograba:
        TxtHasta.Text = ""
        TxtDesde.Text = ""
        TxtDesde.Focus()
    End Sub

    Private Sub TxtDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHasta.Text = TxtDesde.Text
            TxtHasta.Focus()
        End If
    End Sub

    Private Sub TxtHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHasta.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptar.Focus()
        End If
    End Sub
End Class
