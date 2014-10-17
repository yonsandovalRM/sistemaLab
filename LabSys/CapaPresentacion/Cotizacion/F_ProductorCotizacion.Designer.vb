<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ProductorCotizacion
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
        Me.dg_CotizacionP = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.dg_CotizacionP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.dg_CotizacionP)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 483)
        Me.Panel1.TabIndex = 0
        '
        'dg_CotizacionP
        '
        Me.dg_CotizacionP.AllowUserToAddRows = False
        Me.dg_CotizacionP.AllowUserToDeleteRows = False
        Me.dg_CotizacionP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_CotizacionP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_CotizacionP.Location = New System.Drawing.Point(0, 0)
        Me.dg_CotizacionP.Name = "dg_CotizacionP"
        Me.dg_CotizacionP.ReadOnly = True
        Me.dg_CotizacionP.Size = New System.Drawing.Size(790, 483)
        Me.dg_CotizacionP.TabIndex = 0
        '
        'F_ProductorCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(793, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_ProductorCotizacion"
        Me.Text = "Cotización"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dg_CotizacionP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dg_CotizacionP As System.Windows.Forms.DataGridView
End Class
