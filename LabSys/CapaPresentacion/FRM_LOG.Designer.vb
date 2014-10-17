<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_LOG
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOG))
        Me.grilla = New System.Windows.Forms.DataGridView
        Me.IdauditoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudinordenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudirsocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudifechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AuditipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudiusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudihostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AudiaplicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AUDITORIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGROLAB_PRUEBADataSet1 = New LabSys.AGROLAB_PRUEBADataSet1
        Me.AUDITORIATableAdapter = New LabSys.AGROLAB_PRUEBADataSet1TableAdapters.AUDITORIATableAdapter
        Me.txt_desde = New System.Windows.Forms.DateTimePicker
        Me.txt_hasta = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_buscar = New System.Windows.Forms.Button
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUDITORIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGROLAB_PRUEBADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AutoGenerateColumns = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdauditoriaDataGridViewTextBoxColumn, Me.AudinordenDataGridViewTextBoxColumn, Me.AudirsocialDataGridViewTextBoxColumn, Me.AudifechaDataGridViewTextBoxColumn, Me.AuditipoDataGridViewTextBoxColumn, Me.AudiusuarioDataGridViewTextBoxColumn, Me.AudihostDataGridViewTextBoxColumn, Me.AudiaplicacionDataGridViewTextBoxColumn})
        Me.grilla.DataSource = Me.AUDITORIABindingSource
        Me.grilla.Location = New System.Drawing.Point(12, 50)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(860, 453)
        Me.grilla.TabIndex = 0
        '
        'IdauditoriaDataGridViewTextBoxColumn
        '
        Me.IdauditoriaDataGridViewTextBoxColumn.DataPropertyName = "id_auditoria"
        Me.IdauditoriaDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdauditoriaDataGridViewTextBoxColumn.Name = "IdauditoriaDataGridViewTextBoxColumn"
        Me.IdauditoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AudinordenDataGridViewTextBoxColumn
        '
        Me.AudinordenDataGridViewTextBoxColumn.DataPropertyName = "audi_norden"
        Me.AudinordenDataGridViewTextBoxColumn.HeaderText = "OT"
        Me.AudinordenDataGridViewTextBoxColumn.Name = "AudinordenDataGridViewTextBoxColumn"
        Me.AudinordenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AudirsocialDataGridViewTextBoxColumn
        '
        Me.AudirsocialDataGridViewTextBoxColumn.DataPropertyName = "audi_rsocial"
        Me.AudirsocialDataGridViewTextBoxColumn.HeaderText = "RSOCIAL"
        Me.AudirsocialDataGridViewTextBoxColumn.Name = "AudirsocialDataGridViewTextBoxColumn"
        Me.AudirsocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AudifechaDataGridViewTextBoxColumn
        '
        Me.AudifechaDataGridViewTextBoxColumn.DataPropertyName = "audi_fecha"
        Me.AudifechaDataGridViewTextBoxColumn.HeaderText = "FECHA AUDITORIA"
        Me.AudifechaDataGridViewTextBoxColumn.Name = "AudifechaDataGridViewTextBoxColumn"
        Me.AudifechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuditipoDataGridViewTextBoxColumn
        '
        Me.AuditipoDataGridViewTextBoxColumn.DataPropertyName = "audi_tipo"
        Me.AuditipoDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.AuditipoDataGridViewTextBoxColumn.Name = "AuditipoDataGridViewTextBoxColumn"
        Me.AuditipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AudiusuarioDataGridViewTextBoxColumn
        '
        Me.AudiusuarioDataGridViewTextBoxColumn.DataPropertyName = "audi_usuario"
        Me.AudiusuarioDataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.AudiusuarioDataGridViewTextBoxColumn.Name = "AudiusuarioDataGridViewTextBoxColumn"
        Me.AudiusuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AudihostDataGridViewTextBoxColumn
        '
        Me.AudihostDataGridViewTextBoxColumn.DataPropertyName = "audi_host"
        Me.AudihostDataGridViewTextBoxColumn.HeaderText = "PC USUARIO"
        Me.AudihostDataGridViewTextBoxColumn.Name = "AudihostDataGridViewTextBoxColumn"
        Me.AudihostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AudiaplicacionDataGridViewTextBoxColumn
        '
        Me.AudiaplicacionDataGridViewTextBoxColumn.DataPropertyName = "audi_aplicacion"
        Me.AudiaplicacionDataGridViewTextBoxColumn.HeaderText = "APLICACION"
        Me.AudiaplicacionDataGridViewTextBoxColumn.Name = "AudiaplicacionDataGridViewTextBoxColumn"
        Me.AudiaplicacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUDITORIABindingSource
        '
        Me.AUDITORIABindingSource.DataMember = "AUDITORIA"
        Me.AUDITORIABindingSource.DataSource = Me.AGROLAB_PRUEBADataSet1
        '
        'AGROLAB_PRUEBADataSet1
        '
        Me.AGROLAB_PRUEBADataSet1.DataSetName = "AGROLAB_PRUEBADataSet1"
        Me.AGROLAB_PRUEBADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AUDITORIATableAdapter
        '
        Me.AUDITORIATableAdapter.ClearBeforeFill = True
        '
        'txt_desde
        '
        Me.txt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_desde.Location = New System.Drawing.Point(62, 16)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(85, 20)
        Me.txt_desde.TabIndex = 1
        '
        'txt_hasta
        '
        Me.txt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_hasta.Location = New System.Drawing.Point(214, 16)
        Me.txt_hasta.Name = "txt_hasta"
        Me.txt_hasta.Size = New System.Drawing.Size(85, 20)
        Me.txt_hasta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(167, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta :"
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(315, 9)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(58, 34)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'FRM_LOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(884, 531)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_hasta)
        Me.Controls.Add(Me.txt_desde)
        Me.Controls.Add(Me.grilla)
        Me.Name = "FRM_LOG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoria de la Tabla orden_trabajo"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUDITORIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGROLAB_PRUEBADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents AGROLAB_PRUEBADataSet1 As LabSys.AGROLAB_PRUEBADataSet1
    Friend WithEvents AUDITORIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AUDITORIATableAdapter As LabSys.AGROLAB_PRUEBADataSet1TableAdapters.AUDITORIATableAdapter
    Friend WithEvents IdauditoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudinordenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudirsocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudifechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuditipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudiusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudihostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudiaplicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
End Class
