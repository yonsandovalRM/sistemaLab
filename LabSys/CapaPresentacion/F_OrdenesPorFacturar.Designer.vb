<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_OrdenesPorFacturar
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
        Me.dtDesde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtHasta = New System.Windows.Forms.DateTimePicker
        Me.btnGeneraPDF = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(102, 22)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(93, 20)
        Me.dtDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta:"
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(281, 22)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(93, 20)
        Me.dtHasta.TabIndex = 2
        '
        'btnGeneraPDF
        '
        Me.btnGeneraPDF.Image = Global.LabSys.My.Resources.Resources.page_white_acrobat
        Me.btnGeneraPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneraPDF.Location = New System.Drawing.Point(166, 68)
        Me.btnGeneraPDF.Name = "btnGeneraPDF"
        Me.btnGeneraPDF.Size = New System.Drawing.Size(102, 23)
        Me.btnGeneraPDF.TabIndex = 4
        Me.btnGeneraPDF.Text = "Generar PDF"
        Me.btnGeneraPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGeneraPDF.UseVisualStyleBackColor = True
        '
        'F_OrdenesPorFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(440, 128)
        Me.Controls.Add(Me.btnGeneraPDF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtDesde)
        Me.Name = "F_OrdenesPorFacturar"
        Me.Text = "F_OrdenesPorFacturar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGeneraPDF As System.Windows.Forms.Button
End Class
