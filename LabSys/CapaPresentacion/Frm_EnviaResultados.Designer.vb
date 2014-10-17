<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EnviaResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EnviaResultados))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.n_OT = New System.Windows.Forms.TextBox
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_enviar = New System.Windows.Forms.Button
        Me.cb_anno = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grilla_resultados = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress
        Me.lbl_estado = New System.Windows.Forms.Label
        Me.RutaResultado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDF = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        CType(Me.grilla_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° OT"
        '
        'n_OT
        '
        Me.n_OT.Location = New System.Drawing.Point(54, 15)
        Me.n_OT.Name = "n_OT"
        Me.n_OT.Size = New System.Drawing.Size(69, 20)
        Me.n_OT.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(129, 41)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(133, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar Resultados"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_enviar
        '
        Me.btn_enviar.Image = CType(resources.GetObject("btn_enviar.Image"), System.Drawing.Image)
        Me.btn_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enviar.Location = New System.Drawing.Point(609, 271)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(147, 61)
        Me.btn_enviar.TabIndex = 4
        Me.btn_enviar.Text = "Adjuntar a Outlook"
        Me.btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enviar.UseVisualStyleBackColor = True
        '
        'cb_anno
        '
        Me.cb_anno.FormattingEnabled = True
        Me.cb_anno.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013"})
        Me.cb_anno.Location = New System.Drawing.Point(54, 41)
        Me.cb_anno.Name = "cb_anno"
        Me.cb_anno.Size = New System.Drawing.Size(69, 21)
        Me.cb_anno.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Año"
        '
        'grilla_resultados
        '
        Me.grilla_resultados.AllowUserToAddRows = False
        Me.grilla_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_resultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutaResultado, Me.PDF})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_resultados.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla_resultados.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.grilla_resultados.Location = New System.Drawing.Point(12, 80)
        Me.grilla_resultados.Name = "grilla_resultados"
        Me.grilla_resultados.Size = New System.Drawing.Size(744, 185)
        Me.grilla_resultados.TabIndex = 9
        '
        'CircularProgress1
        '
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.Class = ""
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(624, 56)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.Size = New System.Drawing.Size(75, 23)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 11
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(676, 62)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(78, 13)
        Me.lbl_estado.TabIndex = 12
        Me.lbl_estado.Text = "Convirtiendo ..."
        Me.lbl_estado.Visible = False
        '
        'RutaResultado
        '
        Me.RutaResultado.HeaderText = "Ruta Resultado"
        Me.RutaResultado.Name = "RutaResultado"
        Me.RutaResultado.Width = 600
        '
        'PDF
        '
        Me.PDF.HeaderText = "PDF"
        Me.PDF.Name = "PDF"
        Me.PDF.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PDF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black
        '
        'Frm_EnviaResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 345)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.grilla_resultados)
        Me.Controls.Add(Me.cb_anno)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.n_OT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Frm_EnviaResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envio de Resultados - Avanzado"
        CType(Me.grilla_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents n_OT As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_enviar As System.Windows.Forms.Button
    Friend WithEvents cb_anno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grilla_resultados As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents RutaResultado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDF As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class
