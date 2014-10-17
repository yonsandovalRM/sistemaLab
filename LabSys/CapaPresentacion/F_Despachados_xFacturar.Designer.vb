<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Despachados_xFacturar
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
        Me.grillaDespachadosxFac = New System.Windows.Forms.DataGridView
        Me.OT_NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ot_fac_rsocial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OT_FAC_RUT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OT_FAC_FONO1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OT_FAC_ENCPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OT_FAC_F1PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OT_FAC_EMAIL1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OT_FAC_GIRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.grillaDespachadosxFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grillaDespachadosxFac
        '
        Me.grillaDespachadosxFac.AllowUserToAddRows = False
        Me.grillaDespachadosxFac.AllowUserToDeleteRows = False
        Me.grillaDespachadosxFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaDespachadosxFac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OT_NUMERO, Me.ot_fac_rsocial, Me.OT_FAC_RUT, Me.OT_FAC_FONO1, Me.OT_FAC_ENCPAGO, Me.OT_FAC_F1PAGO, Me.OT_FAC_EMAIL1, Me.OT_FAC_GIRO})
        Me.grillaDespachadosxFac.Location = New System.Drawing.Point(13, 51)
        Me.grillaDespachadosxFac.Name = "grillaDespachadosxFac"
        Me.grillaDespachadosxFac.Size = New System.Drawing.Size(1251, 777)
        Me.grillaDespachadosxFac.TabIndex = 0
        '
        'OT_NUMERO
        '
        Me.OT_NUMERO.DataPropertyName = "OT_NUMERO"
        Me.OT_NUMERO.HeaderText = "N. Orden"
        Me.OT_NUMERO.Name = "OT_NUMERO"
        Me.OT_NUMERO.Width = 90
        '
        'ot_fac_rsocial
        '
        Me.ot_fac_rsocial.DataPropertyName = "ot_fac_rsocial"
        Me.ot_fac_rsocial.HeaderText = "RSocial"
        Me.ot_fac_rsocial.Name = "ot_fac_rsocial"
        Me.ot_fac_rsocial.Width = 250
        '
        'OT_FAC_RUT
        '
        Me.OT_FAC_RUT.DataPropertyName = "OT_FAC_RUT"
        Me.OT_FAC_RUT.HeaderText = "Rut Factura"
        Me.OT_FAC_RUT.Name = "OT_FAC_RUT"
        '
        'OT_FAC_FONO1
        '
        Me.OT_FAC_FONO1.DataPropertyName = "OT_FAC_FONO1"
        Me.OT_FAC_FONO1.HeaderText = "Fono Fac"
        Me.OT_FAC_FONO1.Name = "OT_FAC_FONO1"
        '
        'OT_FAC_ENCPAGO
        '
        Me.OT_FAC_ENCPAGO.DataPropertyName = "OT_FAC_ENCPAGO"
        Me.OT_FAC_ENCPAGO.HeaderText = "Enc. Pago"
        Me.OT_FAC_ENCPAGO.Name = "OT_FAC_ENCPAGO"
        Me.OT_FAC_ENCPAGO.Width = 200
        '
        'OT_FAC_F1PAGO
        '
        Me.OT_FAC_F1PAGO.DataPropertyName = "OT_FAC_F1PAGO"
        Me.OT_FAC_F1PAGO.HeaderText = "Fono Pago"
        Me.OT_FAC_F1PAGO.Name = "OT_FAC_F1PAGO"
        '
        'OT_FAC_EMAIL1
        '
        Me.OT_FAC_EMAIL1.DataPropertyName = "OT_FAC_EMAIL1"
        Me.OT_FAC_EMAIL1.HeaderText = "Email Fac"
        Me.OT_FAC_EMAIL1.Name = "OT_FAC_EMAIL1"
        Me.OT_FAC_EMAIL1.Width = 200
        '
        'OT_FAC_GIRO
        '
        Me.OT_FAC_GIRO.DataPropertyName = "OT_FAC_GIRO"
        Me.OT_FAC_GIRO.HeaderText = "Giro"
        Me.OT_FAC_GIRO.Name = "OT_FAC_GIRO"
        Me.OT_FAC_GIRO.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resultados despachados por facturar de los últimos 60 días"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1152, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.printer1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(1172, 845)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_Despachados_xFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 916)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grillaDespachadosxFac)
        Me.Name = "F_Despachados_xFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Despachados_xFacturar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grillaDespachadosxFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grillaDespachadosxFac As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OT_NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ot_fac_rsocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OT_FAC_RUT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OT_FAC_FONO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OT_FAC_ENCPAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OT_FAC_F1PAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OT_FAC_EMAIL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OT_FAC_GIRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
