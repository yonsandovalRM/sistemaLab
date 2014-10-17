<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_Localidad
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
        Me.dgUbicacion = New System.Windows.Forms.DataGridView
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comuna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Region = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgUbicacion
        '
        Me.dgUbicacion.AllowUserToAddRows = False
        Me.dgUbicacion.AllowUserToDeleteRows = False
        Me.dgUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUbicacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.localidad, Me.comuna, Me.ciudad, Me.Provincia, Me.Region})
        Me.dgUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUbicacion.Location = New System.Drawing.Point(0, 0)
        Me.dgUbicacion.Name = "dgUbicacion"
        Me.dgUbicacion.ReadOnly = True
        Me.dgUbicacion.Size = New System.Drawing.Size(857, 277)
        Me.dgUbicacion.TabIndex = 0
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Width = 180
        '
        'comuna
        '
        Me.comuna.HeaderText = "Comuna"
        Me.comuna.Name = "comuna"
        Me.comuna.ReadOnly = True
        Me.comuna.Width = 150
        '
        'ciudad
        '
        Me.ciudad.HeaderText = "Ciudad"
        Me.ciudad.Name = "ciudad"
        Me.ciudad.ReadOnly = True
        Me.ciudad.Width = 150
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        Me.Provincia.Width = 150
        '
        'Region
        '
        Me.Region.HeaderText = "Región"
        Me.Region.Name = "Region"
        Me.Region.ReadOnly = True
        Me.Region.Width = 180
        '
        'G_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 277)
        Me.Controls.Add(Me.dgUbicacion)
        Me.Name = "G_Localidad"
        Me.Text = "Ubicación Geográfica"
        CType(Me.dgUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgUbicacion As System.Windows.Forms.DataGridView
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comuna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ciudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Region As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
