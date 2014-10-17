Imports System.Data.SqlClient
Public Class Frm_Modifica_Estado_Factura
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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RDBEFacNC As System.Windows.Forms.RadioButton
    Friend WithEvents RDBEFacAbo As System.Windows.Forms.RadioButton
    Friend WithEvents RDBEFacPte As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RDBEFacCan As System.Windows.Forms.RadioButton
    Friend WithEvents RDBEFacNula As System.Windows.Forms.RadioButton
    Friend WithEvents Txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ElPanel1 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents RdbMoroso As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.RdbMoroso = New System.Windows.Forms.RadioButton
        Me.RDBEFacNC = New System.Windows.Forms.RadioButton
        Me.RDBEFacAbo = New System.Windows.Forms.RadioButton
        Me.RDBEFacPte = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.RDBEFacCan = New System.Windows.Forms.RadioButton
        Me.RDBEFacNula = New System.Windows.Forms.RadioButton
        Me.Txtfactura = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ElPanel1 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.GroupBox6.SuspendLayout()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.RdbMoroso)
        Me.GroupBox6.Controls.Add(Me.RDBEFacNC)
        Me.GroupBox6.Controls.Add(Me.RDBEFacAbo)
        Me.GroupBox6.Controls.Add(Me.RDBEFacPte)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.RDBEFacCan)
        Me.GroupBox6.Controls.Add(Me.RDBEFacNula)
        Me.GroupBox6.Location = New System.Drawing.Point(67, 65)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(240, 192)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'RdbMoroso
        '
        Me.RdbMoroso.Location = New System.Drawing.Point(72, 168)
        Me.RdbMoroso.Name = "RdbMoroso"
        Me.RdbMoroso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbMoroso.Size = New System.Drawing.Size(96, 16)
        Me.RdbMoroso.TabIndex = 57
        Me.RdbMoroso.Text = "Moroso"
        '
        'RDBEFacNC
        '
        Me.RDBEFacNC.Location = New System.Drawing.Point(72, 144)
        Me.RDBEFacNC.Name = "RDBEFacNC"
        Me.RDBEFacNC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBEFacNC.Size = New System.Drawing.Size(96, 16)
        Me.RDBEFacNC.TabIndex = 56
        Me.RDBEFacNC.Text = "c/NC"
        '
        'RDBEFacAbo
        '
        Me.RDBEFacAbo.Location = New System.Drawing.Point(48, 72)
        Me.RDBEFacAbo.Name = "RDBEFacAbo"
        Me.RDBEFacAbo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBEFacAbo.Size = New System.Drawing.Size(120, 16)
        Me.RDBEFacAbo.TabIndex = 53
        Me.RDBEFacAbo.Text = "Cancelada Parcial"
        '
        'RDBEFacPte
        '
        Me.RDBEFacPte.Location = New System.Drawing.Point(72, 48)
        Me.RDBEFacPte.Name = "RDBEFacPte"
        Me.RDBEFacPte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBEFacPte.Size = New System.Drawing.Size(96, 16)
        Me.RDBEFacPte.TabIndex = 52
        Me.RDBEFacPte.Text = "Pendiente"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(96, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Factura"
        '
        'RDBEFacCan
        '
        Me.RDBEFacCan.Location = New System.Drawing.Point(72, 96)
        Me.RDBEFacCan.Name = "RDBEFacCan"
        Me.RDBEFacCan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBEFacCan.Size = New System.Drawing.Size(96, 16)
        Me.RDBEFacCan.TabIndex = 54
        Me.RDBEFacCan.Text = "Cancelada"
        '
        'RDBEFacNula
        '
        Me.RDBEFacNula.Location = New System.Drawing.Point(72, 120)
        Me.RDBEFacNula.Name = "RDBEFacNula"
        Me.RDBEFacNula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBEFacNula.Size = New System.Drawing.Size(96, 16)
        Me.RDBEFacNula.TabIndex = 55
        Me.RDBEFacNula.Text = "Nula"
        '
        'Txtfactura
        '
        Me.Txtfactura.BackColor = System.Drawing.SystemColors.Info
        Me.Txtfactura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfactura.Location = New System.Drawing.Point(174, 15)
        Me.Txtfactura.Name = "Txtfactura"
        Me.Txtfactura.Size = New System.Drawing.Size(72, 21)
        Me.Txtfactura.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(88, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° Factura"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Salir"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Grabar"
        '
        'ElPanel1
        '
        Me.ElPanel1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel1.Controls.Add(Me.GroupBox6)
        Me.ElPanel1.Controls.Add(Me.Label2)
        Me.ElPanel1.Controls.Add(Me.Txtfactura)
        Me.ElPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel1.Name = "ElPanel1"
        Me.ElPanel1.Size = New System.Drawing.Size(400, 333)
        Me.ElPanel1.TabIndex = 62
        '
        'Frm_Modifica_Estado_Factura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 333)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ElPanel1)
        Me.Name = "Frm_Modifica_Estado_Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Estado Factura"
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel1.ResumeLayout(False)
        Me.ElPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim NEstFactura As String

        NEstFactura = ""
        If RDBEFacPte.Checked = True Then NEstFactura = "Pte"
        If RDBEFacAbo.Checked = True Then NEstFactura = "Abo"
        If RDBEFacCan.Checked = True Then NEstFactura = "Can"
        If RDBEFacNula.Checked = True Then NEstFactura = "Nula"
        If RDBEFacNC.Checked = True Then NEstFactura = "NC"
        If RdbMoroso.Checked = True Then NEstFactura = "Mor"

        With SP
            .Inicializar()
            .AgregarParametro("@NumFact", CInt(Txtfactura.Text), SqlDbType.Int)
            .AgregarParametro("@EstFact", NEstFactura, SqlDbType.NVarChar)
            .EjecutarQuery("usp_UpdateEstadoFactura")
        End With

        ' Call Graba_Historia_Estado(0, "NULL", "NULL", "NULL", CInt(Txtfactura.Text), NEstFactura, "Mantenedor de Factura")

        MsgBox("Grabación finalizada")
    End Sub

    Private Sub Frm_Modifica_Estado_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txtfactura.Focus()
    End Sub
    Private Sub RescataEstadoFactura()
        Dim query As String
        Dim reader As SqlDataReader
        Dim Fila As DataRow
        Dim con As New SqlConnection(Conexion1)

        query = "Select FAC_ESTADO from FACTURA where FAC_NUMERO = " & CInt(Txtfactura.Text)
        Dim command As New SqlCommand(query, con)
        con.Open()
        reader = command.ExecuteReader
        Try
            reader.Read()
            If IsDBNull(reader.GetString(0)) = False Then
                Select Case reader.GetString(0)
                    Case "Pte"
                        RDBEFacPte.Checked = True
                    Case "Abo"
                        RDBEFacAbo.Checked = True
                    Case "Can"
                        RDBEFacCan.Checked = True
                    Case "Nula"
                        RDBEFacNula.Checked = True
                    Case "NC"
                        RDBEFacNC.Checked = True
                    Case "Mor"
                        RdbMoroso.Checked = True
                End Select
            End If
        Catch ex As Exception
        End Try
        con.Close()
    End Sub

    Private Sub Txtfactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfactura.KeyPress
        If e.KeyChar = Chr(13) Then
            Call RescataEstadoFactura()
        End If
    End Sub
End Class
