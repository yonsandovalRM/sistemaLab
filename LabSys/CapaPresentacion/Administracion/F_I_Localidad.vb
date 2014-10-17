Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_I_Localidad
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    'Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_I_Localidad))
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(489, 673)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cerrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_I_Localidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1048, 717)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_I_Localidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localidades"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_I_Localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim sqlConn As SqlConnection
        'Dim sqlDaProd As SqlDataAdapter
        'Dim sqlDaCate As SqlDataAdapter
        'Dim Analisis1 As New Analisis
        'Dim strConn As String = "workstation id=sa;packet size=4096;user id=sa;data source=AGROSERV;persist security info=True;initial catalog=AGROLAB_PRUEBA;password=sa"
        'Dim StrCommCate As String = "Select * From ANALISIS"


        '    'Crear los DataAdapters
        '    sqlConn = New SqlConnection(strConn)
        '    sqlDaCate = New SqlDataAdapter(StrCommCate, sqlConn)

        '    'Poblar las tablas del dataset desde los dataAdaperts
        'sqlDaCate.Fill(Analisis, "ANALISIS")


        'Dim info As New Reporte_Analisis
        'info.SetDataSource(Cjto_Tablas1)

        'CrystalReportViewer1.ReportSource = info
        'Me.CrystalReportViewer1.Zoom(100)
    End Sub
End Class
