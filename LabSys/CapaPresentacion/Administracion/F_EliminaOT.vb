Public Class F_EliminaOT
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
    Friend WithEvents TxtEliminaOT As System.Windows.Forms.TextBox
    Friend WithEvents ElPanel1 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtEliminaOT = New System.Windows.Forms.TextBox
        Me.CmdAceptar = New System.Windows.Forms.Button
        Me.ElPanel1 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero OT"
        '
        'TxtEliminaOT
        '
        Me.TxtEliminaOT.Location = New System.Drawing.Point(134, 28)
        Me.TxtEliminaOT.Name = "TxtEliminaOT"
        Me.TxtEliminaOT.Size = New System.Drawing.Size(100, 20)
        Me.TxtEliminaOT.TabIndex = 1
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Location = New System.Drawing.Point(147, 66)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.CmdAceptar.TabIndex = 2
        Me.CmdAceptar.Text = "Aceptar"
        '
        'ElPanel1
        '
        Me.ElPanel1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel1.Controls.Add(Me.TxtEliminaOT)
        Me.ElPanel1.Controls.Add(Me.CmdAceptar)
        Me.ElPanel1.Controls.Add(Me.Label1)
        Me.ElPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel1.Name = "ElPanel1"
        Me.ElPanel1.Size = New System.Drawing.Size(374, 123)
        Me.ElPanel1.TabIndex = 3
        '
        'F_EliminaOT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(374, 123)
        Me.Controls.Add(Me.ElPanel1)
        Me.Name = "F_EliminaOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Orden de Trabajo"
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel1.ResumeLayout(False)
        Me.ElPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim respuesta As MsgBoxResult
        Try
            respuesta = MsgBox("Esta seguro de Eliminar OT : " & TxtEliminaOT.Text, MsgBoxStyle.YesNo)
            If respuesta = MsgBoxResult.Yes Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", TxtEliminaOT.Text, SqlDbType.Int)
                    .EjecutarQuery("usp_EliminaxOrden")
                End With
            End If
        Catch ex As Exception
            MsgBox("Debe ingresar la OT")
        End Try
        Me.Close()
    End Sub

End Class
