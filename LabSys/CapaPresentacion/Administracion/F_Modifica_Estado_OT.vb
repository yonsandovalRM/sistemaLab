Imports System.Data.SqlClient
Public Class F_Modifica_Estado_OT
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RDBAnaDex As System.Windows.Forms.RadioButton
    Friend WithEvents RDBAnaxA As System.Windows.Forms.RadioButton
    Friend WithEvents RDBAnaDe As System.Windows.Forms.RadioButton
    Friend WithEvents RDBAnaNula As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RDBAnaxDe As System.Windows.Forms.RadioButton
    Friend WithEvents TxtOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RDBPagsc As System.Windows.Forms.RadioButton
    Friend WithEvents RDBPagPte As System.Windows.Forms.RadioButton
    Friend WithEvents RDBPagAbo As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RDBPagCan As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RDBFacAgr As System.Windows.Forms.RadioButton
    Friend WithEvents RDBFacnoF As System.Windows.Forms.RadioButton
    Friend WithEvents RDBFacxF As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RDBFacnoR As System.Windows.Forms.RadioButton
    Friend WithEvents RDBFacFac As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ElPanel1 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RDBAnaDex = New System.Windows.Forms.RadioButton
        Me.RDBAnaxA = New System.Windows.Forms.RadioButton
        Me.RDBAnaDe = New System.Windows.Forms.RadioButton
        Me.RDBAnaNula = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.RDBAnaxDe = New System.Windows.Forms.RadioButton
        Me.TxtOrden = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RDBPagsc = New System.Windows.Forms.RadioButton
        Me.RDBPagPte = New System.Windows.Forms.RadioButton
        Me.RDBPagAbo = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.RDBPagCan = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RDBFacAgr = New System.Windows.Forms.RadioButton
        Me.RDBFacnoF = New System.Windows.Forms.RadioButton
        Me.RDBFacxF = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.RDBFacnoR = New System.Windows.Forms.RadioButton
        Me.RDBFacFac = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ElPanel1 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtOrden)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 280)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RDBAnaDex)
        Me.GroupBox2.Controls.Add(Me.RDBAnaxA)
        Me.GroupBox2.Controls.Add(Me.RDBAnaDe)
        Me.GroupBox2.Controls.Add(Me.RDBAnaNula)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.RDBAnaxDe)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 168)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'RDBAnaDex
        '
        Me.RDBAnaDex.Location = New System.Drawing.Point(56, 80)
        Me.RDBAnaDex.Name = "RDBAnaDex"
        Me.RDBAnaDex.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBAnaDex.Size = New System.Drawing.Size(96, 16)
        Me.RDBAnaDex.TabIndex = 42
        Me.RDBAnaDex.Text = "Desp.Parcial"
        '
        'RDBAnaxA
        '
        Me.RDBAnaxA.Location = New System.Drawing.Point(56, 32)
        Me.RDBAnaxA.Name = "RDBAnaxA"
        Me.RDBAnaxA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBAnaxA.Size = New System.Drawing.Size(96, 16)
        Me.RDBAnaxA.TabIndex = 43
        Me.RDBAnaxA.Text = "Por Análizar"
        '
        'RDBAnaDe
        '
        Me.RDBAnaDe.Location = New System.Drawing.Point(56, 104)
        Me.RDBAnaDe.Name = "RDBAnaDe"
        Me.RDBAnaDe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBAnaDe.Size = New System.Drawing.Size(96, 16)
        Me.RDBAnaDe.TabIndex = 45
        Me.RDBAnaDe.Text = "Despachada"
        '
        'RDBAnaNula
        '
        Me.RDBAnaNula.Enabled = False
        Me.RDBAnaNula.Location = New System.Drawing.Point(56, 128)
        Me.RDBAnaNula.Name = "RDBAnaNula"
        Me.RDBAnaNula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBAnaNula.Size = New System.Drawing.Size(96, 16)
        Me.RDBAnaNula.TabIndex = 46
        Me.RDBAnaNula.Text = "Nula"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(80, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Análisis"
        '
        'RDBAnaxDe
        '
        Me.RDBAnaxDe.Location = New System.Drawing.Point(48, 56)
        Me.RDBAnaxDe.Name = "RDBAnaxDe"
        Me.RDBAnaxDe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBAnaxDe.Size = New System.Drawing.Size(104, 16)
        Me.RDBAnaxDe.TabIndex = 44
        Me.RDBAnaxDe.Text = "Por Despachar"
        '
        'TxtOrden
        '
        Me.TxtOrden.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOrden.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrden.Location = New System.Drawing.Point(104, 16)
        Me.TxtOrden.Name = "TxtOrden"
        Me.TxtOrden.Size = New System.Drawing.Size(72, 21)
        Me.TxtOrden.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° OT"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RDBPagsc)
        Me.GroupBox3.Controls.Add(Me.RDBPagPte)
        Me.GroupBox3.Controls.Add(Me.RDBPagAbo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.RDBPagCan)
        Me.GroupBox3.Location = New System.Drawing.Point(264, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 168)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        '
        'RDBPagsc
        '
        Me.RDBPagsc.Location = New System.Drawing.Point(56, 120)
        Me.RDBPagsc.Name = "RDBPagsc"
        Me.RDBPagsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBPagsc.Size = New System.Drawing.Size(96, 16)
        Me.RDBPagsc.TabIndex = 50
        Me.RDBPagsc.Text = "s/costo"
        '
        'RDBPagPte
        '
        Me.RDBPagPte.Location = New System.Drawing.Point(56, 48)
        Me.RDBPagPte.Name = "RDBPagPte"
        Me.RDBPagPte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBPagPte.Size = New System.Drawing.Size(96, 16)
        Me.RDBPagPte.TabIndex = 47
        Me.RDBPagPte.Text = "Por Cancelar"
        '
        'RDBPagAbo
        '
        Me.RDBPagAbo.Location = New System.Drawing.Point(56, 72)
        Me.RDBPagAbo.Name = "RDBPagAbo"
        Me.RDBPagAbo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBPagAbo.Size = New System.Drawing.Size(96, 16)
        Me.RDBPagAbo.TabIndex = 48
        Me.RDBPagAbo.Text = "Con Abono"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(88, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Pago"
        '
        'RDBPagCan
        '
        Me.RDBPagCan.Location = New System.Drawing.Point(56, 96)
        Me.RDBPagCan.Name = "RDBPagCan"
        Me.RDBPagCan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBPagCan.Size = New System.Drawing.Size(96, 16)
        Me.RDBPagCan.TabIndex = 49
        Me.RDBPagCan.Text = "Cancelada"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RDBFacAgr)
        Me.GroupBox4.Controls.Add(Me.RDBFacnoF)
        Me.GroupBox4.Controls.Add(Me.RDBFacxF)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.RDBFacnoR)
        Me.GroupBox4.Controls.Add(Me.RDBFacFac)
        Me.GroupBox4.Location = New System.Drawing.Point(528, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 168)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        '
        'RDBFacAgr
        '
        Me.RDBFacAgr.Location = New System.Drawing.Point(56, 144)
        Me.RDBFacAgr.Name = "RDBFacAgr"
        Me.RDBFacAgr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBFacAgr.Size = New System.Drawing.Size(96, 16)
        Me.RDBFacAgr.TabIndex = 55
        Me.RDBFacAgr.Text = "Ensayo Agro"
        '
        'RDBFacnoF
        '
        Me.RDBFacnoF.Location = New System.Drawing.Point(56, 96)
        Me.RDBFacnoF.Name = "RDBFacnoF"
        Me.RDBFacnoF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBFacnoF.Size = New System.Drawing.Size(96, 16)
        Me.RDBFacnoF.TabIndex = 53
        Me.RDBFacnoF.Text = "s/Facturar"
        '
        'RDBFacxF
        '
        Me.RDBFacxF.Location = New System.Drawing.Point(56, 48)
        Me.RDBFacxF.Name = "RDBFacxF"
        Me.RDBFacxF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBFacxF.Size = New System.Drawing.Size(96, 16)
        Me.RDBFacxF.TabIndex = 51
        Me.RDBFacxF.Text = "Por Facturar"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(80, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Facturación"
        '
        'RDBFacnoR
        '
        Me.RDBFacnoR.Location = New System.Drawing.Point(56, 120)
        Me.RDBFacnoR.Name = "RDBFacnoR"
        Me.RDBFacnoR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBFacnoR.Size = New System.Drawing.Size(96, 16)
        Me.RDBFacnoR.TabIndex = 54
        Me.RDBFacnoR.Text = "No Retirada"
        '
        'RDBFacFac
        '
        Me.RDBFacFac.Location = New System.Drawing.Point(56, 72)
        Me.RDBFacFac.Name = "RDBFacFac"
        Me.RDBFacFac.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RDBFacFac.Size = New System.Drawing.Size(96, 16)
        Me.RDBFacFac.TabIndex = 52
        Me.RDBFacFac.Text = "Facturada"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(479, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Salir"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Grabar"
        '
        'ElPanel1
        '
        Me.ElPanel1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel1.Controls.Add(Me.GroupBox1)
        Me.ElPanel1.Controls.Add(Me.Button3)
        Me.ElPanel1.Controls.Add(Me.Button2)
        Me.ElPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel1.Name = "ElPanel1"
        Me.ElPanel1.Size = New System.Drawing.Size(832, 461)
        Me.ElPanel1.TabIndex = 62
        '
        'F_Modifica_Estado_OT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 461)
        Me.Controls.Add(Me.ElPanel1)
        Me.Name = "F_Modifica_Estado_OT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Estado OT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Modifica_Estado_OT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtOrden.Focus()
    End Sub
    Private Sub RescataDatosOT()
        Dim query As String
        Dim reader As SqlDataReader
        Dim Fila, FILA_ANA As DataRow
        Dim BusAna As Object
        Dim con As New SqlConnection(Conexion1)

        query = "Select OT_ESTADO_ANA,OT_ESTADO_PAG,OT_ESTADO_FAC from ORDEN_TRABAJO where OT_NUMERO = " & CInt(TxtOrden.Text)
        Dim command As New SqlCommand(query, con)
        con.Open()
        reader = command.ExecuteReader
        Try
            reader.Read()
            If IsDBNull(reader.GetString(0)) = False Then
                Select Case reader.GetString(0)
                    Case "xA"
                        RDBAnaxA.Checked = True
                    Case "xDe"
                        RDBAnaxDe.Checked = True
                    Case "Dex"
                        RDBAnaDex.Checked = True
                    Case "De"
                        RDBAnaDe.Checked = True
                    Case "Nula"
                        RDBAnaNula.Checked = True
                End Select
            End If

            If IsDBNull(reader.GetString(1)) = False Then
                Select Case reader.GetString(1)
                    Case "Pte"
                        RDBPagPte.Checked = True
                    Case "Abo"
                        RDBPagAbo.Checked = True
                    Case "Can"
                        RDBPagCan.Checked = True
                    Case "s/c"
                        RDBPagsc.Checked = True
                End Select
            End If

            If IsDBNull(reader.GetString(2)) = False Then
                Select Case reader.GetString(2)
                    Case "xF"
                        RDBFacxF.Checked = True
                    Case "Fac"
                        RDBFacFac.Checked = True
                    Case "noF"
                        RDBFacnoF.Checked = True
                    Case "noR"
                        RDBFacnoR.Checked = True
                    Case "Agr"
                        RDBFacAgr.Checked = True
                End Select
            End If
        Catch ex As Exception
        End Try
        reader.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim query, NEstOT, NEstPago, NEstFac, NEstFactura, Estado_original As String
        Dim con As New SqlConnection(Conexion1)
        Dim UltNumDup, MCod As Integer
        Dim Fila_Ele As DataRow
        Dim Mydate As Date
        Mydate = Today
        con.Open()

        '*******************  Graba nuevos estados en OT  ***************
        NEstOT = ""
        NEstPago = ""
        NEstFac = ""

        If RDBAnaxA.Checked = True Then NEstOT = "xA"
        If RDBAnaxDe.Checked = True Then NEstOT = "xDe"
        If RDBAnaDex.Checked = True Then NEstOT = "Dex"
        If RDBAnaDe.Checked = True Then NEstOT = "De"
        If RDBAnaNula.Checked = True Then NEstOT = "Nula"

        If RDBPagPte.Checked = True Then NEstPago = "Pte"
        If RDBPagAbo.Checked = True Then NEstPago = "Abo"
        If RDBPagCan.Checked = True Then NEstPago = "Can"
        If RDBPagsc.Checked = True Then NEstPago = "s/c"

        If RDBFacxF.Checked = True Then NEstFac = "xF"
        If RDBFacFac.Checked = True Then NEstFac = "Fac"
        If RDBFacnoF.Checked = True Then NEstFac = "noF"
        If RDBFacnoR.Checked = True Then NEstFac = "noR"
        If RDBFacAgr.Checked = True Then NEstFac = "Agr"

        query = "UPDATE ORDEN_TRABAJO SET  OT_ESTADO_ANA='" & NEstOT & "',OT_ESTADO_PAG='" & NEstPago & "'," & _
                                           "OT_ESTADO_FAC='" & NEstFac & "' WHERE OT_NUMERO=" & CInt(TxtOrden.Text)
        Dim myCommand6 As New SqlCommand(query, con)
        Dim myReader6 As SqlDataReader
        Try
            myReader6 = myCommand6.ExecuteReader()
            myReader6.Close()
        Catch ex As Exception

        End Try

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP

            .Inicializar()
            .AgregarParametro("@ot", TxtOrden.Text, SqlDbType.Int)
            .AgregarParametro("@estado", NEstOT, SqlDbType.NVarChar)
            .EjecutarQuery("ls_actualizaEstadoOtDesp2")

        End With
        ' ***************** Fin Grabacion de estados OT *******************

        ' Call Graba_Historia_Estado(CInt(TxtOrden.Text), NEstOT, NEstPago, NEstFac, 0, "NULL", "Mantenedor de OT")


        con.Close()
        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TxtOrden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOrden.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtOrden.Text <> "" Then
                Call RescataDatosOT()
            End If
        End If
    End Sub


End Class
