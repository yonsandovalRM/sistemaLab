<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CotizaEmpresa
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dg_CotizaEmpresa = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.dg_CotizaEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.dg_CotizaEmpresa)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 432)
        Me.Panel1.TabIndex = 0
        '
        'dg_CotizaEmpresa
        '
        Me.dg_CotizaEmpresa.AllowUserToAddRows = False
        Me.dg_CotizaEmpresa.AllowUserToDeleteRows = False
        Me.dg_CotizaEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_CotizaEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_CotizaEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.dg_CotizaEmpresa.Name = "dg_CotizaEmpresa"
        Me.dg_CotizaEmpresa.ReadOnly = True
        Me.dg_CotizaEmpresa.Size = New System.Drawing.Size(690, 432)
        Me.dg_CotizaEmpresa.TabIndex = 0
        '
        'F_CotizaEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(689, 434)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_CotizaEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotización"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dg_CotizaEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dg_CotizaEmpresa As System.Windows.Forms.DataGridView
End Class
