<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Oferta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_cotizacion = New System.Windows.Forms.TextBox
        Me.btn_generar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_cotizacion
        '
        Me.txt_cotizacion.Location = New System.Drawing.Point(52, 50)
        Me.txt_cotizacion.Name = "txt_cotizacion"
        Me.txt_cotizacion.Size = New System.Drawing.Size(100, 20)
        Me.txt_cotizacion.TabIndex = 0
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(158, 47)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 1
        Me.btn_generar.Text = "Button1"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'Oferta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 151)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.txt_cotizacion)
        Me.Name = "Oferta"
        Me.Text = "Oferta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cotizacion As System.Windows.Forms.TextBox
    Friend WithEvents btn_generar As System.Windows.Forms.Button
End Class
