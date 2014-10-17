<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_Empresa
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
        Me.dgEmpresa = New System.Windows.Forms.DataGridView
        Me.RutProd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.predio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comuna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rsocial = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgEmpresa
        '
        Me.dgEmpresa.AllowUserToAddRows = False
        Me.dgEmpresa.AllowUserToDeleteRows = False
        Me.dgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutProd, Me.prod, Me.empresa, Me.predio, Me.localidad, Me.comuna, Me.Rsocial})
        Me.dgEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.dgEmpresa.Name = "dgEmpresa"
        Me.dgEmpresa.ReadOnly = True
        Me.dgEmpresa.Size = New System.Drawing.Size(914, 371)
        Me.dgEmpresa.TabIndex = 0
        '
        'RutProd
        '
        Me.RutProd.HeaderText = "Rut Productor"
        Me.RutProd.Name = "RutProd"
        Me.RutProd.ReadOnly = True
        '
        'prod
        '
        Me.prod.HeaderText = "Productor"
        Me.prod.Name = "prod"
        Me.prod.ReadOnly = True
        Me.prod.Width = 150
        '
        'empresa
        '
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        '
        'predio
        '
        Me.predio.HeaderText = "Predio"
        Me.predio.Name = "predio"
        Me.predio.ReadOnly = True
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        '
        'comuna
        '
        Me.comuna.HeaderText = "Comuna"
        Me.comuna.Name = "comuna"
        Me.comuna.ReadOnly = True
        '
        'Rsocial
        '
        Me.Rsocial.HeaderText = "Razón Social"
        Me.Rsocial.Name = "Rsocial"
        Me.Rsocial.ReadOnly = True
        Me.Rsocial.Width = 200
        '
        'G_Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 371)
        Me.Controls.Add(Me.dgEmpresa)
        Me.Name = "G_Empresa"
        Me.Text = "Empresa"
        CType(Me.dgEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgEmpresa As System.Windows.Forms.DataGridView
    Friend WithEvents RutProd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents predio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comuna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rsocial As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
