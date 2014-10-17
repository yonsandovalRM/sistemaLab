
Public Class Frm_Chequeo
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gbx_ChkNorm As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_ChkGasto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_NormVAlicuota As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NormGasto As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NormNormalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_NormResultado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Gbx_ChkNorm = New System.Windows.Forms.GroupBox
        Me.Txt_NormResultado = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_NormNormalidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_NormVAlicuota = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_NormGasto = New System.Windows.Forms.TextBox
        Me.Lb_ChkGasto = New System.Windows.Forms.Label
        Me.Gbx_ChkNorm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chequeo Normailidad = (Gasto x Normaildad NaOH) / Vol.Alicuota"
        '
        'Gbx_ChkNorm
        '
        Me.Gbx_ChkNorm.Controls.Add(Me.Txt_NormResultado)
        Me.Gbx_ChkNorm.Controls.Add(Me.Label7)
        Me.Gbx_ChkNorm.Controls.Add(Me.Label4)
        Me.Gbx_ChkNorm.Controls.Add(Me.TextBox4)
        Me.Gbx_ChkNorm.Controls.Add(Me.Label5)
        Me.Gbx_ChkNorm.Controls.Add(Me.TextBox5)
        Me.Gbx_ChkNorm.Controls.Add(Me.Label6)
        Me.Gbx_ChkNorm.Controls.Add(Me.Txt_NormNormalidad)
        Me.Gbx_ChkNorm.Controls.Add(Me.Label3)
        Me.Gbx_ChkNorm.Controls.Add(Me.Txt_NormVAlicuota)
        Me.Gbx_ChkNorm.Controls.Add(Me.Label2)
        Me.Gbx_ChkNorm.Controls.Add(Me.Txt_NormGasto)
        Me.Gbx_ChkNorm.Controls.Add(Me.Lb_ChkGasto)
        Me.Gbx_ChkNorm.Location = New System.Drawing.Point(0, 32)
        Me.Gbx_ChkNorm.Name = "Gbx_ChkNorm"
        Me.Gbx_ChkNorm.Size = New System.Drawing.Size(488, 243)
        Me.Gbx_ChkNorm.TabIndex = 1
        Me.Gbx_ChkNorm.TabStop = False
        '
        'Txt_NormResultado
        '
        Me.Txt_NormResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NormResultado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NormResultado.Location = New System.Drawing.Point(136, 102)
        Me.Txt_NormResultado.Name = "Txt_NormResultado"
        Me.Txt_NormResultado.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NormResultado.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 18)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Chequeo Normalidad"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Chequeo Normalidad NaOH"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(224, 200)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(72, 20)
        Me.TextBox4.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Normalidad NaOH"
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(224, 176)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(72, 20)
        Me.TextBox5.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Número de lote reactivos (Batch)"
        '
        'Txt_NormNormalidad
        '
        Me.Txt_NormNormalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NormNormalidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NormNormalidad.Location = New System.Drawing.Point(136, 72)
        Me.Txt_NormNormalidad.Name = "Txt_NormNormalidad"
        Me.Txt_NormNormalidad.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NormNormalidad.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Normalidad NaO4"
        '
        'Txt_NormVAlicuota
        '
        Me.Txt_NormVAlicuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NormVAlicuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NormVAlicuota.Location = New System.Drawing.Point(136, 48)
        Me.Txt_NormVAlicuota.Name = "Txt_NormVAlicuota"
        Me.Txt_NormVAlicuota.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NormVAlicuota.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Vol. Alicuota"
        '
        'Txt_NormGasto
        '
        Me.Txt_NormGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NormGasto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NormGasto.Location = New System.Drawing.Point(136, 24)
        Me.Txt_NormGasto.Name = "Txt_NormGasto"
        Me.Txt_NormGasto.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NormGasto.TabIndex = 10
        '
        'Lb_ChkGasto
        '
        Me.Lb_ChkGasto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_ChkGasto.ForeColor = System.Drawing.Color.Black
        Me.Lb_ChkGasto.Location = New System.Drawing.Point(8, 24)
        Me.Lb_ChkGasto.Name = "Lb_ChkGasto"
        Me.Lb_ChkGasto.Size = New System.Drawing.Size(112, 18)
        Me.Lb_ChkGasto.TabIndex = 0
        Me.Lb_ChkGasto.Text = "Gasto"
        '
        'Frm_Chequeo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(496, 283)
        Me.Controls.Add(Me.Gbx_ChkNorm)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Frm_Chequeo"
        Me.Text = "Chequeo"
        Me.Gbx_ChkNorm.ResumeLayout(False)
        Me.Gbx_ChkNorm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ChNorm As Double
    Public Sub Cal_Chequeo()
        Dim Gasto, Normalidad, VolAlicuota As Double
        Gasto = CDbl(Txt_NormGasto.Text)
        Normalidad = CDbl(Txt_NormNormalidad.Text)
        VolAlicuota = CDbl(Txt_NormVAlicuota.Text)
        ChNorm = (Gasto * Normalidad) / VolAlicuota
        Txt_NormResultado.Text = ChNorm

    End Sub

    Private Sub Txt_NormGasto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NormGasto.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_NormVAlicuota.Focus()
        End If
    End Sub

    Private Sub Txt_NormVAlicuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NormVAlicuota.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_NormNormalidad.Focus()
        End If
    End Sub

    Private Sub Txt_NormNormalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NormNormalidad.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Cal_Chequeo()
        End If
    End Sub
End Class
