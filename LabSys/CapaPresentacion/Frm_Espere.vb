Public Class Frm_Espere
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
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents lblMsg2 As System.Windows.Forms.Label
    'Friend WithEvents swfReloj As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents tmrLap As System.Windows.Forms.Timer
    Friend WithEvents lblLap As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Espere))
        Me.lblMsg1 = New System.Windows.Forms.Label
        Me.lblMsg2 = New System.Windows.Forms.Label
        'Me.swfReloj = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.tmrLap = New System.Windows.Forms.Timer(Me.components)
        Me.lblLap = New System.Windows.Forms.Label
        'CType(Me.swfReloj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMsg1
        '
        Me.lblMsg1.Location = New System.Drawing.Point(32, 16)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(288, 16)
        Me.lblMsg1.TabIndex = 0
        Me.lblMsg1.Text = "Espere un instante..."
        '
        'lblMsg2
        '
        Me.lblMsg2.Location = New System.Drawing.Point(32, 48)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(296, 32)
        Me.lblMsg2.TabIndex = 1
        Me.lblMsg2.Text = "Label2"
        '
        'swfReloj
        '
        'Me.swfReloj.Enabled = True
        'Me.swfReloj.Location = New System.Drawing.Point(144, 88)
        'Me.swfReloj.Name = "swfReloj"
        'Me.swfReloj.OcxState = CType(resources.GetObject("swfReloj.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.swfReloj.Size = New System.Drawing.Size(56, 48)
        'Me.swfReloj.TabIndex = 2
        '
        'tmrLap
        '
        '
        'lblLap
        '
        Me.lblLap.Location = New System.Drawing.Point(209, 117)
        Me.lblLap.Name = "lblLap"
        Me.lblLap.Size = New System.Drawing.Size(88, 16)
        Me.lblLap.TabIndex = 3
        Me.lblLap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_Espere
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLap)
        'Me.Controls.Add(Me.swfReloj)
        Me.Controls.Add(Me.lblMsg2)
        Me.Controls.Add(Me.lblMsg1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_Espere"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        ' CType(Me.swfReloj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dHoraIni, dHoraLap As Date
    Private Sub Frm_Espere_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim sRuta As String = System.Windows.Forms.Application.StartupPath
        '----------------------------------------------------
        'Ruta temporal para la carpeta de imágenes
        'sRuta = Mid(sRuta, 1, Len(sRuta) - 4)
        Dim sFolderImages As String = "C:\Archivos de programa\Agrolab Ltda\Instalador_LabSys\"

        '----------------------------------------------------
        ' swfReloj.Movie = sFolderImages + "Clock.swf"
        ' swfReloj.Play()
        dHoraIni = Now()
        tmrLap.Enabled = True
    End Sub

    Private Sub tmrLap_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLap.Tick
        dHoraLap = Now()
        lblLap.Text = Format(dHoraLap.ToOADate - dHoraIni.ToOADate, "HH:mm:ss")
        Me.lblLap.Refresh()
    End Sub
End Class
