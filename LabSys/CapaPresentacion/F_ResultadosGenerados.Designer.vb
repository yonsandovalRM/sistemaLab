<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ResultadosGenerados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ResultadosGenerados))
        Me.GrillaResultadosGenerados = New System.Windows.Forms.DataGridView
        Me.NOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nlab_desde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nlab_hasta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Productor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaResultado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.CmdOrdenTrabajo = New System.Windows.Forms.Button
        Me.lbx_lista = New System.Windows.Forms.ListBox
        Me.pnl_Rutas = New System.Windows.Forms.Panel
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Ana = New System.Windows.Forms.TextBox
        Me.txt_Pag = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Fac = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_ot = New System.Windows.Forms.Label
        CType(Me.GrillaResultadosGenerados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Rutas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaResultadosGenerados
        '
        Me.GrillaResultadosGenerados.AllowUserToAddRows = False
        Me.GrillaResultadosGenerados.AllowUserToDeleteRows = False
        Me.GrillaResultadosGenerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaResultadosGenerados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOrden, Me.nlab_desde, Me.nlab_hasta, Me.Productor, Me.FechaOrden, Me.FechaResultado, Me.Tipo})
        Me.GrillaResultadosGenerados.Location = New System.Drawing.Point(15, 57)
        Me.GrillaResultadosGenerados.Name = "GrillaResultadosGenerados"
        Me.GrillaResultadosGenerados.Size = New System.Drawing.Size(1061, 778)
        Me.GrillaResultadosGenerados.TabIndex = 0
        '
        'NOrden
        '
        Me.NOrden.DataPropertyName = "NOrden"
        Me.NOrden.HeaderText = "N. Orden"
        Me.NOrden.Name = "NOrden"
        '
        'nlab_desde
        '
        Me.nlab_desde.DataPropertyName = "Desde"
        Me.nlab_desde.HeaderText = "Desde"
        Me.nlab_desde.Name = "nlab_desde"
        '
        'nlab_hasta
        '
        Me.nlab_hasta.DataPropertyName = "Hasta"
        Me.nlab_hasta.HeaderText = "Hasta"
        Me.nlab_hasta.Name = "nlab_hasta"
        '
        'Productor
        '
        Me.Productor.DataPropertyName = "Productor"
        Me.Productor.HeaderText = "Productor"
        Me.Productor.Name = "Productor"
        Me.Productor.Width = 400
        '
        'FechaOrden
        '
        Me.FechaOrden.DataPropertyName = "FechaOrden"
        Me.FechaOrden.HeaderText = "Fecha Orden"
        Me.FechaOrden.Name = "FechaOrden"
        '
        'FechaResultado
        '
        Me.FechaResultado.DataPropertyName = "FechaResultado"
        Me.FechaResultado.HeaderText = "Fecha Resultado"
        Me.FechaResultado.Name = "FechaResultado"
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo Muestra"
        Me.Tipo.Name = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resultados Generados con estado ""xDe"""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1195, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1189, 841)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(1082, 207)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(191, 63)
        Me.Button6.TabIndex = 62
        Me.Button6.Text = "Enviar Resultado"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'CmdOrdenTrabajo
        '
        Me.CmdOrdenTrabajo.BackColor = System.Drawing.Color.Transparent
        Me.CmdOrdenTrabajo.Image = CType(resources.GetObject("CmdOrdenTrabajo.Image"), System.Drawing.Image)
        Me.CmdOrdenTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdOrdenTrabajo.Location = New System.Drawing.Point(1082, 138)
        Me.CmdOrdenTrabajo.Name = "CmdOrdenTrabajo"
        Me.CmdOrdenTrabajo.Size = New System.Drawing.Size(191, 63)
        Me.CmdOrdenTrabajo.TabIndex = 61
        Me.CmdOrdenTrabajo.Text = "Orden de Trabajo"
        Me.CmdOrdenTrabajo.UseVisualStyleBackColor = False
        '
        'lbx_lista
        '
        Me.lbx_lista.FormattingEnabled = True
        Me.lbx_lista.HorizontalScrollbar = True
        Me.lbx_lista.Location = New System.Drawing.Point(3, 3)
        Me.lbx_lista.Name = "lbx_lista"
        Me.lbx_lista.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbx_lista.Size = New System.Drawing.Size(185, 316)
        Me.lbx_lista.TabIndex = 63
        '
        'pnl_Rutas
        '
        Me.pnl_Rutas.Controls.Add(Me.Button8)
        Me.pnl_Rutas.Controls.Add(Me.lbx_lista)
        Me.pnl_Rutas.Controls.Add(Me.Button7)
        Me.pnl_Rutas.Location = New System.Drawing.Point(1082, 276)
        Me.pnl_Rutas.Name = "pnl_Rutas"
        Me.pnl_Rutas.Size = New System.Drawing.Size(191, 359)
        Me.pnl_Rutas.TabIndex = 64
        Me.pnl_Rutas.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(104, 324)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 68
        Me.Button8.Text = "Cerrar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(23, 324)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 67
        Me.Button7.Text = "Adjuntar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1092, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Análisis"
        '
        'txt_Ana
        '
        Me.txt_Ana.Location = New System.Drawing.Point(1095, 112)
        Me.txt_Ana.Name = "txt_Ana"
        Me.txt_Ana.Size = New System.Drawing.Size(50, 20)
        Me.txt_Ana.TabIndex = 66
        '
        'txt_Pag
        '
        Me.txt_Pag.Location = New System.Drawing.Point(1151, 112)
        Me.txt_Pag.Name = "txt_Pag"
        Me.txt_Pag.Size = New System.Drawing.Size(50, 20)
        Me.txt_Pag.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1148, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Pago"
        '
        'txt_Fac
        '
        Me.txt_Fac.Location = New System.Drawing.Point(1207, 112)
        Me.txt_Fac.Name = "txt_Fac"
        Me.txt_Fac.Size = New System.Drawing.Size(50, 20)
        Me.txt_Fac.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1204, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Factura"
        '
        'lbl_ot
        '
        Me.lbl_ot.AutoSize = True
        Me.lbl_ot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ot.Location = New System.Drawing.Point(1092, 57)
        Me.lbl_ot.Name = "lbl_ot"
        Me.lbl_ot.Size = New System.Drawing.Size(161, 16)
        Me.lbl_ot.TabIndex = 71
        Me.lbl_ot.Text = "ORDEN DE TRABAJO"
        '
        'F_ResultadosGenerados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 907)
        Me.Controls.Add(Me.lbl_ot)
        Me.Controls.Add(Me.txt_Fac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Pag)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Ana)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnl_Rutas)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.CmdOrdenTrabajo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaResultadosGenerados)
        Me.Name = "F_ResultadosGenerados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados Generados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrillaResultadosGenerados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Rutas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaResultadosGenerados As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nlab_desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nlab_hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Productor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaResultado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CmdOrdenTrabajo As System.Windows.Forms.Button
    Friend WithEvents lbx_lista As System.Windows.Forms.ListBox
    Friend WithEvents pnl_Rutas As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Ana As System.Windows.Forms.TextBox
    Friend WithEvents txt_Pag As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Fac As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_ot As System.Windows.Forms.Label
End Class
