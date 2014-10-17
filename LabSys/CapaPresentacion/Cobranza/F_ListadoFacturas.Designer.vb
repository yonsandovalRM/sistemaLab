<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ListadoFacturas
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
        Me.dgFacturas = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txCantFactPend = New System.Windows.Forms.TextBox
        Me.txValorFact = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGeneraReporte = New System.Windows.Forms.Button
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgFacturas
        '
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturas.Location = New System.Drawing.Point(12, 12)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.Size = New System.Drawing.Size(1110, 768)
        Me.dgFacturas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 796)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de Facturas pendientes :"
        '
        'txCantFactPend
        '
        Me.txCantFactPend.BackColor = System.Drawing.Color.White
        Me.txCantFactPend.Location = New System.Drawing.Point(242, 793)
        Me.txCantFactPend.Name = "txCantFactPend"
        Me.txCantFactPend.ReadOnly = True
        Me.txCantFactPend.Size = New System.Drawing.Size(100, 20)
        Me.txCantFactPend.TabIndex = 2
        '
        'txValorFact
        '
        Me.txValorFact.BackColor = System.Drawing.Color.White
        Me.txValorFact.Location = New System.Drawing.Point(563, 793)
        Me.txValorFact.Name = "txValorFact"
        Me.txValorFact.ReadOnly = True
        Me.txValorFact.Size = New System.Drawing.Size(100, 20)
        Me.txValorFact.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 796)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor total Facturas pendientes :"
        '
        'btnGeneraReporte
        '
        Me.btnGeneraReporte.Image = Global.LabSys.My.Resources.Resources.report
        Me.btnGeneraReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneraReporte.Location = New System.Drawing.Point(774, 791)
        Me.btnGeneraReporte.Name = "btnGeneraReporte"
        Me.btnGeneraReporte.Size = New System.Drawing.Size(115, 23)
        Me.btnGeneraReporte.TabIndex = 3
        Me.btnGeneraReporte.Text = "Generar Reporte"
        Me.btnGeneraReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGeneraReporte.UseVisualStyleBackColor = True
        '
        'F_ListadoFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1134, 880)
        Me.Controls.Add(Me.txValorFact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGeneraReporte)
        Me.Controls.Add(Me.txCantFactPend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgFacturas)
        Me.Name = "F_ListadoFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Facturas"
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txCantFactPend As System.Windows.Forms.TextBox
    Friend WithEvents btnGeneraReporte As System.Windows.Forms.Button
    Friend WithEvents txValorFact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
