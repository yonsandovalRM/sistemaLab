<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_OrdenesXFacturar
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
        Me.PanelCuentas = New System.Windows.Forms.Panel
        Me.btnDetalle = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtHasta = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtDesde = New System.Windows.Forms.DateTimePicker
        Me.PanelCuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCuentas
        '
        Me.PanelCuentas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelCuentas.Controls.Add(Me.btnDetalle)
        Me.PanelCuentas.Controls.Add(Me.Label2)
        Me.PanelCuentas.Controls.Add(Me.dtHasta)
        Me.PanelCuentas.Controls.Add(Me.Label1)
        Me.PanelCuentas.Controls.Add(Me.dtDesde)
        Me.PanelCuentas.Location = New System.Drawing.Point(-3, -1)
        Me.PanelCuentas.Name = "PanelCuentas"
        Me.PanelCuentas.Size = New System.Drawing.Size(509, 117)
        Me.PanelCuentas.TabIndex = 1
        '
        'btnDetalle
        '
        Me.btnDetalle.Image = Global.LabSys.My.Resources.Resources.application_view_list
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetalle.Location = New System.Drawing.Point(197, 62)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(108, 23)
        Me.btnDetalle.TabIndex = 7
        Me.btnDetalle.Text = "Generar"
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(311, 18)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(99, 20)
        Me.dtHasta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(107, 18)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(99, 20)
        Me.dtDesde.TabIndex = 0
        '
        'F_OrdenesXFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(508, 119)
        Me.Controls.Add(Me.PanelCuentas)
        Me.Name = "F_OrdenesXFacturar"
        Me.Text = "Ordenes  por Facturar"
        Me.PanelCuentas.ResumeLayout(False)
        Me.PanelCuentas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelCuentas As System.Windows.Forms.Panel
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
End Class
