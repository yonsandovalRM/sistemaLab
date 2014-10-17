<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PlanificacionNlab
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chFertOrg = New System.Windows.Forms.CheckBox
        Me.chSuelo = New System.Windows.Forms.CheckBox
        Me.chFertQui = New System.Windows.Forms.CheckBox
        Me.chTejidos = New System.Windows.Forms.CheckBox
        Me.chFoliar = New System.Windows.Forms.CheckBox
        Me.dgPlanNlab = New System.Windows.Forms.DataGridView
        Me.txCDesde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txCHasta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnPlanificar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPlanNlab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chFertOrg)
        Me.GroupBox1.Controls.Add(Me.chSuelo)
        Me.GroupBox1.Controls.Add(Me.chFertQui)
        Me.GroupBox1.Controls.Add(Me.chTejidos)
        Me.GroupBox1.Controls.Add(Me.chFoliar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un tipo de Análisis a Planificar"
        '
        'chFertOrg
        '
        Me.chFertOrg.AutoSize = True
        Me.chFertOrg.Location = New System.Drawing.Point(37, 62)
        Me.chFertOrg.Name = "chFertOrg"
        Me.chFertOrg.Size = New System.Drawing.Size(73, 19)
        Me.chFertOrg.TabIndex = 4
        Me.chFertOrg.Text = "Fert. Org"
        Me.chFertOrg.UseVisualStyleBackColor = True
        '
        'chSuelo
        '
        Me.chSuelo.AutoSize = True
        Me.chSuelo.Location = New System.Drawing.Point(38, 41)
        Me.chSuelo.Name = "chSuelo"
        Me.chSuelo.Size = New System.Drawing.Size(58, 19)
        Me.chSuelo.TabIndex = 3
        Me.chSuelo.Text = "Suelo"
        Me.chSuelo.UseVisualStyleBackColor = True
        '
        'chFertQui
        '
        Me.chFertQui.AutoSize = True
        Me.chFertQui.Location = New System.Drawing.Point(137, 42)
        Me.chFertQui.Name = "chFertQui"
        Me.chFertQui.Size = New System.Drawing.Size(72, 19)
        Me.chFertQui.TabIndex = 2
        Me.chFertQui.Text = "Fert. Qui"
        Me.chFertQui.UseVisualStyleBackColor = True
        '
        'chTejidos
        '
        Me.chTejidos.AutoSize = True
        Me.chTejidos.Location = New System.Drawing.Point(137, 20)
        Me.chTejidos.Name = "chTejidos"
        Me.chTejidos.Size = New System.Drawing.Size(60, 19)
        Me.chTejidos.TabIndex = 1
        Me.chTejidos.Text = "Tejido"
        Me.chTejidos.UseVisualStyleBackColor = True
        '
        'chFoliar
        '
        Me.chFoliar.AutoSize = True
        Me.chFoliar.Location = New System.Drawing.Point(38, 19)
        Me.chFoliar.Name = "chFoliar"
        Me.chFoliar.Size = New System.Drawing.Size(57, 19)
        Me.chFoliar.TabIndex = 0
        Me.chFoliar.Text = "Foliar"
        Me.chFoliar.UseVisualStyleBackColor = True
        '
        'dgPlanNlab
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPlanNlab.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPlanNlab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPlanNlab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txCDesde, Me.txCHasta})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPlanNlab.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgPlanNlab.Location = New System.Drawing.Point(31, 107)
        Me.dgPlanNlab.Name = "dgPlanNlab"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPlanNlab.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgPlanNlab.Size = New System.Drawing.Size(267, 178)
        Me.dgPlanNlab.TabIndex = 1
        '
        'txCDesde
        '
        Me.txCDesde.HeaderText = "Desde"
        Me.txCDesde.Name = "txCDesde"
        '
        'txCHasta
        '
        Me.txCHasta.HeaderText = "Hasta"
        Me.txCHasta.Name = "txCHasta"
        '
        'btnPlanificar
        '
        Me.btnPlanificar.Image = Global.LabSys.My.Resources.Resources.accept
        Me.btnPlanificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlanificar.Location = New System.Drawing.Point(76, 309)
        Me.btnPlanificar.Name = "btnPlanificar"
        Me.btnPlanificar.Size = New System.Drawing.Size(75, 23)
        Me.btnPlanificar.TabIndex = 2
        Me.btnPlanificar.Text = "Planificar"
        Me.btnPlanificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlanificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(174, 309)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'F_PlanificacionNlab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(345, 380)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPlanificar)
        Me.Controls.Add(Me.dgPlanNlab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_PlanificacionNlab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planificación N° Lab"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgPlanNlab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chSuelo As System.Windows.Forms.CheckBox
    Friend WithEvents chFertQui As System.Windows.Forms.CheckBox
    Friend WithEvents chTejidos As System.Windows.Forms.CheckBox
    Friend WithEvents chFoliar As System.Windows.Forms.CheckBox
    Friend WithEvents dgPlanNlab As System.Windows.Forms.DataGridView
    Friend WithEvents txCDesde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txCHasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPlanificar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents chFertOrg As System.Windows.Forms.CheckBox
End Class
