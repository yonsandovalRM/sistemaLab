Imports Microsoft.Office.Interop

Public Class Frm_Carta_Despacho
    Inherits System.Windows.Forms.Form
    Private SELECCION As String


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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents panelPrincipal As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtAlOT As System.Windows.Forms.TextBox
    Friend WithEvents TxtDelOT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTFecha As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents BTAceptar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtNomina As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTGenera As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Rd_Ca_Planilla3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Ca_Planilla2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Ca_Planilla1 As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Ce_Planilla3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Ce_Planilla2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Ce_Planilla1 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtAl As System.Windows.Forms.TextBox
    Friend WithEvents TxtDel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TxtFirma4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota7 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNota6 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota2 As System.Windows.Forms.TextBox
    Friend WithEvents BTNueva As System.Windows.Forms.Button
    Friend WithEvents TxtNota1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents rbSoloFacCN As System.Windows.Forms.RadioButton
    Friend WithEvents rbSoloFacSN As System.Windows.Forms.RadioButton
    Friend WithEvents ElPanel2 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents ElPanel1 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents ElPanel3 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DtgCartaCobranza As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Carta_Despacho))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.panelPrincipal = New System.Windows.Forms.TabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtAlOT = New System.Windows.Forms.TextBox
        Me.TxtDelOT = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BTFecha = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtFecha = New System.Windows.Forms.TextBox
        Me.BTAceptar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtNomina = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTGenera = New System.Windows.Forms.Button
        Me.DtgCartaCobranza = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbSoloFacCN = New System.Windows.Forms.RadioButton
        Me.rbSoloFacSN = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Rd_Ca_Planilla3 = New System.Windows.Forms.RadioButton
        Me.Rd_Ca_Planilla2 = New System.Windows.Forms.RadioButton
        Me.Rd_Ca_Planilla1 = New System.Windows.Forms.RadioButton
        Me.Rd_Ce_Planilla3 = New System.Windows.Forms.RadioButton
        Me.Rd_Ce_Planilla2 = New System.Windows.Forms.RadioButton
        Me.Rd_Ce_Planilla1 = New System.Windows.Forms.RadioButton
        Me.TxtAl = New System.Windows.Forms.TextBox
        Me.TxtDel = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TxtFirma4 = New System.Windows.Forms.TextBox
        Me.TxtFirma3 = New System.Windows.Forms.TextBox
        Me.TxtFirma2 = New System.Windows.Forms.TextBox
        Me.TxtFirma1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtPlanilla = New System.Windows.Forms.TextBox
        Me.TxtNota7 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtNota6 = New System.Windows.Forms.TextBox
        Me.TxtNota5 = New System.Windows.Forms.TextBox
        Me.TxtNota4 = New System.Windows.Forms.TextBox
        Me.TxtNota3 = New System.Windows.Forms.TextBox
        Me.TxtNota2 = New System.Windows.Forms.TextBox
        Me.TxtNota1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.BTNueva = New System.Windows.Forms.Button
        Me.ElPanel1 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.ElPanel2 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.ElPanel3 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.panelPrincipal.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgCartaCobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel1.SuspendLayout()
        CType(Me.ElPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel2.SuspendLayout()
        CType(Me.ElPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.panelPrincipal)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1090, 654)
        Me.TabControl1.TabIndex = 1
        '
        'panelPrincipal
        '
        Me.panelPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.panelPrincipal.Controls.Add(Me.TxtAlOT)
        Me.panelPrincipal.Controls.Add(Me.TxtDelOT)
        Me.panelPrincipal.Controls.Add(Me.MonthCalendar1)
        Me.panelPrincipal.Controls.Add(Me.TxtAl)
        Me.panelPrincipal.Controls.Add(Me.TxtDel)
        Me.panelPrincipal.Controls.Add(Me.ElPanel2)
        Me.panelPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(1082, 628)
        Me.panelPrincipal.TabIndex = 0
        Me.panelPrincipal.Text = "Facturas"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(200, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Al"
        '
        'TxtAlOT
        '
        Me.TxtAlOT.Location = New System.Drawing.Point(222, 45)
        Me.TxtAlOT.Name = "TxtAlOT"
        Me.TxtAlOT.Size = New System.Drawing.Size(64, 20)
        Me.TxtAlOT.TabIndex = 12
        '
        'TxtDelOT
        '
        Me.TxtDelOT.Location = New System.Drawing.Point(130, 45)
        Me.TxtDelOT.Name = "TxtDelOT"
        Me.TxtDelOT.Size = New System.Drawing.Size(64, 20)
        Me.TxtDelOT.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(32, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Nº   OT           Del"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(715, 230)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 9
        Me.MonthCalendar1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BTFecha)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtFecha)
        Me.GroupBox2.Controls.Add(Me.BTAceptar)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtNomina)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 133)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'BTFecha
        '
        Me.BTFecha.Image = CType(resources.GetObject("BTFecha.Image"), System.Drawing.Image)
        Me.BTFecha.Location = New System.Drawing.Point(208, 52)
        Me.BTFecha.Name = "BTFecha"
        Me.BTFecha.Size = New System.Drawing.Size(32, 23)
        Me.BTFecha.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(42, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Fecha Nómina"
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(144, 52)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(64, 20)
        Me.TxtFecha.TabIndex = 3
        '
        'BTAceptar
        '
        Me.BTAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BTAceptar.Image = Global.LabSys.My.Resources.Resources.accept
        Me.BTAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTAceptar.Location = New System.Drawing.Point(102, 92)
        Me.BTAceptar.Name = "BTAceptar"
        Me.BTAceptar.Size = New System.Drawing.Size(72, 23)
        Me.BTAceptar.TabIndex = 2
        Me.BTAceptar.Text = "Aceptar"
        Me.BTAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTAceptar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(35, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nº Inicial Nomina"
        '
        'TxtNomina
        '
        Me.TxtNomina.Location = New System.Drawing.Point(144, 24)
        Me.TxtNomina.Name = "TxtNomina"
        Me.TxtNomina.Size = New System.Drawing.Size(64, 20)
        Me.TxtNomina.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(200, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Al"
        '
        'BTGenera
        '
        Me.BTGenera.BackColor = System.Drawing.Color.Transparent
        Me.BTGenera.Image = Global.LabSys.My.Resources.Resources.email1
        Me.BTGenera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTGenera.Location = New System.Drawing.Point(495, 574)
        Me.BTGenera.Name = "BTGenera"
        Me.BTGenera.Size = New System.Drawing.Size(85, 30)
        Me.BTGenera.TabIndex = 6
        Me.BTGenera.Text = "Generar"
        Me.BTGenera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTGenera.UseVisualStyleBackColor = False
        '
        'DtgCartaCobranza
        '
        Me.DtgCartaCobranza.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DtgCartaCobranza.CaptionVisible = False
        Me.DtgCartaCobranza.DataMember = ""
        Me.DtgCartaCobranza.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgCartaCobranza.Location = New System.Drawing.Point(7, 99)
        Me.DtgCartaCobranza.Name = "DtgCartaCobranza"
        Me.DtgCartaCobranza.Size = New System.Drawing.Size(1064, 456)
        Me.DtgCartaCobranza.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbSoloFacCN)
        Me.GroupBox1.Controls.Add(Me.rbSoloFacSN)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Rd_Ca_Planilla3)
        Me.GroupBox1.Controls.Add(Me.Rd_Ca_Planilla2)
        Me.GroupBox1.Controls.Add(Me.Rd_Ca_Planilla1)
        Me.GroupBox1.Controls.Add(Me.Rd_Ce_Planilla3)
        Me.GroupBox1.Controls.Add(Me.Rd_Ce_Planilla2)
        Me.GroupBox1.Controls.Add(Me.Rd_Ce_Planilla1)
        Me.GroupBox1.Location = New System.Drawing.Point(312, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 80)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'rbSoloFacCN
        '
        Me.rbSoloFacCN.Location = New System.Drawing.Point(460, 16)
        Me.rbSoloFacCN.Name = "rbSoloFacCN"
        Me.rbSoloFacCN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbSoloFacCN.Size = New System.Drawing.Size(72, 16)
        Me.rbSoloFacCN.TabIndex = 6
        Me.rbSoloFacCN.Text = "Solo Fac"
        '
        'rbSoloFacSN
        '
        Me.rbSoloFacSN.Location = New System.Drawing.Point(460, 48)
        Me.rbSoloFacSN.Name = "rbSoloFacSN"
        Me.rbSoloFacSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbSoloFacSN.Size = New System.Drawing.Size(72, 16)
        Me.rbSoloFacSN.TabIndex = 5
        Me.rbSoloFacSN.Text = "Solo Fac"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(24, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "S/Nómina Correo Cert."
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(24, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "C/Nómina Correo Cert."
        '
        'Rd_Ca_Planilla3
        '
        Me.Rd_Ca_Planilla3.Location = New System.Drawing.Point(368, 16)
        Me.Rd_Ca_Planilla3.Name = "Rd_Ca_Planilla3"
        Me.Rd_Ca_Planilla3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Rd_Ca_Planilla3.Size = New System.Drawing.Size(72, 16)
        Me.Rd_Ca_Planilla3.TabIndex = 2
        Me.Rd_Ca_Planilla3.Text = "Res Sólo"
        '
        'Rd_Ca_Planilla2
        '
        Me.Rd_Ca_Planilla2.Location = New System.Drawing.Point(256, 16)
        Me.Rd_Ca_Planilla2.Name = "Rd_Ca_Planilla2"
        Me.Rd_Ca_Planilla2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Rd_Ca_Planilla2.Size = New System.Drawing.Size(88, 16)
        Me.Rd_Ca_Planilla2.TabIndex = 1
        Me.Rd_Ca_Planilla2.Text = "Res Fac Can"
        '
        'Rd_Ca_Planilla1
        '
        Me.Rd_Ca_Planilla1.Location = New System.Drawing.Point(152, 16)
        Me.Rd_Ca_Planilla1.Name = "Rd_Ca_Planilla1"
        Me.Rd_Ca_Planilla1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Rd_Ca_Planilla1.Size = New System.Drawing.Size(88, 16)
        Me.Rd_Ca_Planilla1.TabIndex = 0
        Me.Rd_Ca_Planilla1.Text = "Res Fac Pte"
        '
        'Rd_Ce_Planilla3
        '
        Me.Rd_Ce_Planilla3.Location = New System.Drawing.Point(368, 48)
        Me.Rd_Ce_Planilla3.Name = "Rd_Ce_Planilla3"
        Me.Rd_Ce_Planilla3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Rd_Ce_Planilla3.Size = New System.Drawing.Size(72, 16)
        Me.Rd_Ce_Planilla3.TabIndex = 1
        Me.Rd_Ce_Planilla3.Text = "Res Sólo"
        '
        'Rd_Ce_Planilla2
        '
        Me.Rd_Ce_Planilla2.Location = New System.Drawing.Point(256, 48)
        Me.Rd_Ce_Planilla2.Name = "Rd_Ce_Planilla2"
        Me.Rd_Ce_Planilla2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Rd_Ce_Planilla2.Size = New System.Drawing.Size(88, 16)
        Me.Rd_Ce_Planilla2.TabIndex = 0
        Me.Rd_Ce_Planilla2.Text = "Res Fac Can"
        '
        'Rd_Ce_Planilla1
        '
        Me.Rd_Ce_Planilla1.Location = New System.Drawing.Point(152, 48)
        Me.Rd_Ce_Planilla1.Name = "Rd_Ce_Planilla1"
        Me.Rd_Ce_Planilla1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Rd_Ce_Planilla1.Size = New System.Drawing.Size(88, 16)
        Me.Rd_Ce_Planilla1.TabIndex = 2
        Me.Rd_Ce_Planilla1.Text = "Res Fac Pte"
        '
        'TxtAl
        '
        Me.TxtAl.Location = New System.Drawing.Point(222, 13)
        Me.TxtAl.Name = "TxtAl"
        Me.TxtAl.Size = New System.Drawing.Size(64, 20)
        Me.TxtAl.TabIndex = 2
        '
        'TxtDel
        '
        Me.TxtDel.Location = New System.Drawing.Point(128, 13)
        Me.TxtDel.Name = "TxtDel"
        Me.TxtDel.Size = New System.Drawing.Size(64, 20)
        Me.TxtDel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Factura      Del"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.TxtFirma4)
        Me.TabPage2.Controls.Add(Me.TxtFirma3)
        Me.TabPage2.Controls.Add(Me.TxtFirma2)
        Me.TabPage2.Controls.Add(Me.TxtFirma1)
        Me.TabPage2.Controls.Add(Me.TxtNota7)
        Me.TabPage2.Controls.Add(Me.TxtNota6)
        Me.TabPage2.Controls.Add(Me.TxtNota5)
        Me.TabPage2.Controls.Add(Me.TxtNota4)
        Me.TabPage2.Controls.Add(Me.TxtNota3)
        Me.TabPage2.Controls.Add(Me.TxtNota2)
        Me.TabPage2.Controls.Add(Me.TxtNota1)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.BTNueva)
        Me.TabPage2.Controls.Add(Me.ElPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1104, 678)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Plantillas"
        Me.TabPage2.Visible = False
        '
        'TxtFirma4
        '
        Me.TxtFirma4.Location = New System.Drawing.Point(337, 408)
        Me.TxtFirma4.Name = "TxtFirma4"
        Me.TxtFirma4.Size = New System.Drawing.Size(144, 20)
        Me.TxtFirma4.TabIndex = 17
        '
        'TxtFirma3
        '
        Me.TxtFirma3.Location = New System.Drawing.Point(337, 384)
        Me.TxtFirma3.Name = "TxtFirma3"
        Me.TxtFirma3.Size = New System.Drawing.Size(144, 20)
        Me.TxtFirma3.TabIndex = 16
        '
        'TxtFirma2
        '
        Me.TxtFirma2.Location = New System.Drawing.Point(57, 408)
        Me.TxtFirma2.Name = "TxtFirma2"
        Me.TxtFirma2.Size = New System.Drawing.Size(152, 20)
        Me.TxtFirma2.TabIndex = 15
        '
        'TxtFirma1
        '
        Me.TxtFirma1.Location = New System.Drawing.Point(57, 384)
        Me.TxtFirma1.Name = "TxtFirma1"
        Me.TxtFirma1.Size = New System.Drawing.Size(152, 20)
        Me.TxtFirma1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(54, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nivel Firmas"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TxtPlanilla)
        Me.GroupBox3.Location = New System.Drawing.Point(524, 443)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 56)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(144, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Graba"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtPlanilla
        '
        Me.TxtPlanilla.Location = New System.Drawing.Point(16, 24)
        Me.TxtPlanilla.Name = "TxtPlanilla"
        Me.TxtPlanilla.Size = New System.Drawing.Size(112, 20)
        Me.TxtPlanilla.TabIndex = 0
        Me.TxtPlanilla.Text = "Nombre Plantilla"
        '
        'TxtNota7
        '
        Me.TxtNota7.Location = New System.Drawing.Point(57, 304)
        Me.TxtNota7.Multiline = True
        Me.TxtNota7.Name = "TxtNota7"
        Me.TxtNota7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNota7.Size = New System.Drawing.Size(784, 32)
        Me.TxtNota7.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(54, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nivel Alto"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(54, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nivel Bajo"
        '
        'TxtNota6
        '
        Me.TxtNota6.Location = New System.Drawing.Point(57, 272)
        Me.TxtNota6.Multiline = True
        Me.TxtNota6.Name = "TxtNota6"
        Me.TxtNota6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNota6.Size = New System.Drawing.Size(784, 32)
        Me.TxtNota6.TabIndex = 8
        '
        'TxtNota5
        '
        Me.TxtNota5.Location = New System.Drawing.Point(57, 240)
        Me.TxtNota5.Multiline = True
        Me.TxtNota5.Name = "TxtNota5"
        Me.TxtNota5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNota5.Size = New System.Drawing.Size(784, 32)
        Me.TxtNota5.TabIndex = 7
        '
        'TxtNota4
        '
        Me.TxtNota4.Location = New System.Drawing.Point(57, 208)
        Me.TxtNota4.Multiline = True
        Me.TxtNota4.Name = "TxtNota4"
        Me.TxtNota4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNota4.Size = New System.Drawing.Size(784, 32)
        Me.TxtNota4.TabIndex = 6
        '
        'TxtNota3
        '
        Me.TxtNota3.Location = New System.Drawing.Point(57, 176)
        Me.TxtNota3.Multiline = True
        Me.TxtNota3.Name = "TxtNota3"
        Me.TxtNota3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNota3.Size = New System.Drawing.Size(784, 32)
        Me.TxtNota3.TabIndex = 5
        '
        'TxtNota2
        '
        Me.TxtNota2.Location = New System.Drawing.Point(57, 104)
        Me.TxtNota2.Multiline = True
        Me.TxtNota2.Name = "TxtNota2"
        Me.TxtNota2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNota2.Size = New System.Drawing.Size(784, 32)
        Me.TxtNota2.TabIndex = 4
        '
        'TxtNota1
        '
        Me.TxtNota1.Location = New System.Drawing.Point(57, 72)
        Me.TxtNota1.Multiline = True
        Me.TxtNota1.Name = "TxtNota1"
        Me.TxtNota1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNota1.Size = New System.Drawing.Size(784, 32)
        Me.TxtNota1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(334, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre Plantilla"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "PLANTILLA_DESPACHO.PLD_NOMBRE"
        Me.ComboBox1.Location = New System.Drawing.Point(441, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "PLANTILLA_DESPACHO.PLD_NOMBRE"
        '
        'BTNueva
        '
        Me.BTNueva.BackColor = System.Drawing.Color.Transparent
        Me.BTNueva.Image = Global.LabSys.My.Resources.Resources.email_edit
        Me.BTNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNueva.Location = New System.Drawing.Point(439, 464)
        Me.BTNueva.Name = "BTNueva"
        Me.BTNueva.Size = New System.Drawing.Size(75, 23)
        Me.BTNueva.TabIndex = 3
        Me.BTNueva.Text = "Nueva"
        Me.BTNueva.UseVisualStyleBackColor = False
        '
        'ElPanel1
        '
        Me.ElPanel1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel1.Controls.Add(Me.TabControl1)
        Me.ElPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel1.Name = "ElPanel1"
        Me.ElPanel1.Size = New System.Drawing.Size(1117, 681)
        Me.ElPanel1.TabIndex = 2
        '
        'ElPanel2
        '
        Me.ElPanel2.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel2.Controls.Add(Me.GroupBox2)
        Me.ElPanel2.Controls.Add(Me.Label11)
        Me.ElPanel2.Controls.Add(Me.GroupBox1)
        Me.ElPanel2.Controls.Add(Me.BTGenera)
        Me.ElPanel2.Controls.Add(Me.Label1)
        Me.ElPanel2.Controls.Add(Me.DtgCartaCobranza)
        Me.ElPanel2.Controls.Add(Me.Label12)
        Me.ElPanel2.Controls.Add(Me.Label2)
        Me.ElPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel2.Name = "ElPanel2"
        Me.ElPanel2.Size = New System.Drawing.Size(1082, 628)
        Me.ElPanel2.TabIndex = 14
        '
        'ElPanel3
        '
        Me.ElPanel3.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel3.Controls.Add(Me.GroupBox3)
        Me.ElPanel3.Controls.Add(Me.Label3)
        Me.ElPanel3.Controls.Add(Me.Label4)
        Me.ElPanel3.Controls.Add(Me.Label5)
        Me.ElPanel3.Controls.Add(Me.Label8)
        Me.ElPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel3.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel3.Name = "ElPanel3"
        Me.ElPanel3.Size = New System.Drawing.Size(1104, 678)
        Me.ElPanel3.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(238, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Frm_Carta_Despacho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1117, 681)
        Me.Controls.Add(Me.ElPanel1)
        Me.Name = "Frm_Carta_Despacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carta de Despacho"
        Me.TabControl1.ResumeLayout(False)
        Me.panelPrincipal.ResumeLayout(False)
        Me.panelPrincipal.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtgCartaCobranza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel1.ResumeLayout(False)
        CType(Me.ElPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel2.ResumeLayout(False)
        CType(Me.ElPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub PROCESO_CARGA()
        Try
            Dim FILA_FACT, FILA_FACT1, FILA_RAZON, FILA_BCAB, FILA_MICO, FILA_MFAC, FILA_MIMU, FILA_IMPCAB1, FILA_IMPCAB, FILA_IMPDET, FILA_REP As DataRow
            Dim Isre, Inlad, Inlah, Idird, Idip, Icip, Icod, Icid, Iate, Iord, Inladh, Infa, Ipla As String
            Dim Itot, Inan As Double
            Dim largo, facnul As Integer
            Dim Inlaa, Planillaca, Planillace As String
            Dim CLAVE, CLAVE1(2), CLAVE2, CLAVER, CLAVEF As Object
            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            Dim ds As DataSet = New DataSet

            facnul = 0
            'RESCATA LOS DATOS DE EL PRODUCTOR QUE ESTA ASOCIADO A LA ORDEN
            For Each FILA_MICO In Cjto_Tablas1.Tables("MICO2").Rows
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", CInt(FILA_MICO("IORD")), SqlDbType.Int)
                    .EjecutarQueryDt("usp_SelectMIMU", Cjto_Tablas1, "MIMU2")
                End With
            Next

            For Each FILA_MICO In Cjto_Tablas1.Tables("MICO2").Rows
                Idird = "" : Icid = "" : Iate = "" : Icod = ""
                Iord = FILA_MICO("IORD")
                Infa = FILA_MICO("INFA")
                Inan = FILA_MICO("INAN")
                Inlad = FILA_MICO("INLAD")
                Inlah = FILA_MICO("INLAH")
                largo = Len(Inlah)
                Inladh = Inlad & " - " & Mid(Inlah, (largo - 2))

                CLAVE = FILA_MICO("IORD")
                FILA_MIMU = Cjto_Tablas1.Tables("MIMU2").Rows.Find(CLAVE)

                If (FILA_MIMU Is Nothing) = False Then
                    Isre = FILA_MIMU("ISRE")
                    Idird = ""
                    If IsDBNull(FILA_MIMU("ICAS")) = False Then
                        If FILA_MIMU("ICAS") <> "" Then Idird = "Casilla Nº " & FILA_MIMU("ICAS")
                    End If
                    If Idird = "" Then
                        If IsDBNull(FILA_MIMU("IDIRD")) = False Then Idird = FILA_MIMU("IDIRD")
                    End If
                    If IsDBNull(FILA_MIMU("ICID")) = False Then Icid = FILA_MIMU("ICID") Else Icid = ""
                    If IsDBNull(FILA_MIMU("ICOD")) = False Then Icod = FILA_MIMU("ICOD") Else Icod = ""
                    If IsDBNull(FILA_MIMU("IATE")) = False Then Iate = FILA_MIMU("IATE") Else Iate = ""
                    If IsDBNull(FILA_MIMU("IREM")) = False Then
                        If Iate = "" Then Iate = FILA_MIMU("IREM")
                    End If
                    CLAVER = FILA_MICO("INFA")
                    FILA_RAZON = Cjto_Tablas1.Tables("RAZON_SOCIAL").Rows.Find(CLAVER)
                    If (FILA_RAZON Is Nothing) = False Then
                        If IsDBNull(FILA_RAZON("FAC_RSOCIAL")) = False Then
                            Isre = FILA_RAZON("FAC_RSOCIAL")
                        End If
                        If IsDBNull(FILA_RAZON("FAC_DIRECCION")) = False Then
                            If Trim(Idird) = "" Then Idird = FILA_RAZON("FAC_DIRECCION")
                        End If
                    End If
                End If
                CLAVE = FILA_MICO("INFA")
                FILA_MFAC = Cjto_Tablas1.Tables("MFAC").Rows.Find(CLAVE)
                If (FILA_MFAC Is Nothing) = False Then
                    Itot = FILA_MFAC("ITOT")
                Else
                    Itot = 0
                End If
                If Rd_Ca_Planilla1.Checked = True Then Planillace = "RFP" : GoTo saltaplanilla Else Planillace = ""
                If Rd_Ca_Planilla2.Checked = True Then Planillace = "RFC" : GoTo saltaplanilla Else Planillace = ""
                If Rd_Ca_Planilla3.Checked = True Then Planillace = "RES" : GoTo saltaplanilla Else Planillace = ""
                If Rd_Ce_Planilla1.Checked = True Then Planillaca = "RFP" : GoTo saltaplanilla Else Planillaca = ""
                If Rd_Ce_Planilla2.Checked = True Then Planillaca = "RFC" : GoTo saltaplanilla Else Planillaca = ""
                If Rd_Ce_Planilla3.Checked = True Then Planillaca = "RES" : GoTo saltaplanilla Else Planillaca = ""
                If Me.rbSoloFacCN.Checked = True Then Planillaca = "RFS" : GoTo saltaplanilla Else Planillaca = ""
                If Me.rbSoloFacSN.Checked = True Then Planillaca = "RFS" : GoTo saltaplanilla Else Planillaca = ""
saltaplanilla:
                CLAVE1(0) = Isre
                CLAVE1(1) = FILA_MICO("IORD")
                CLAVE1(2) = Inladh
                FILA_REP = Cjto_Tablas1.Tables("IMPCAB1").Rows.Find(CLAVE1)
                If (FILA_REP Is Nothing) = True Then
                    FILA_IMPCAB1 = Cjto_Tablas1.Tables("IMPCAB1").NewRow
                    FILA_IMPCAB1("SENORES") = Isre
                    FILA_IMPCAB1("IDIRD") = Idird
                    FILA_IMPCAB1("ICID") = Icid
                    FILA_IMPCAB1("IATE") = Iate
                    FILA_IMPCAB1("IORD") = Iord
                    FILA_IMPCAB1("INLADH") = Inladh
                    FILA_IMPCAB1("INAN") = Inan
                    FILA_IMPCAB1("INFA") = Infa
                    FILA_IMPCAB1("ITOT") = Itot
                    FILA_IMPCAB1("PLANILLACE") = Planillace
                    FILA_IMPCAB1("PLANILLACA") = Planillaca
                    FILA_IMPCAB1("ISRE") = Isre
                    FILA_IMPCAB1("INLAD") = Inlad
                    FILA_IMPCAB1("INLAH") = Inlah
                    FILA_IMPCAB1("ICOD") = Icod
                    Try
                        Cjto_Tablas1.Tables("IMPCAB1").Rows.Add(FILA_IMPCAB1)
                    Catch ex As Exception
                        MsgBox("Factura se encuentra cargada")
                    End Try
                End If
            Next
        Catch ex As Exception
            MsgBox("error:" & ex.Message.ToString)
        End Try

    End Sub

    Private Sub CARGA_PARA_IMPRESION()
        Dim CLAVE2(3) As Object
        Dim FILA_IMPCAB, FILA_IMPCAB1, FILA_IMPDET As DataRow
        Dim PLANILLA, Idid, Icid, Icod As String
        Dim tipopla As Integer
        Cjto_Tablas1.Tables("IMPCAB").Clear()
        Cjto_Tablas1.Tables("IMPDET").Clear()
        For Each FILA_IMPCAB1 In Cjto_Tablas1.Tables("IMPCAB1").Rows
            If FILA_IMPCAB1.RowState <> DataRowState.Deleted Then
                tipopla = 0
                If IsDBNull(FILA_IMPCAB1("PLANILLACE")) = False Then PLANILLA = FILA_IMPCAB1("PLANILLACE") : tipopla = 1
                If IsDBNull(FILA_IMPCAB1("PLANILLACA")) = False Then PLANILLA = FILA_IMPCAB1("PLANILLACA") : tipopla = 2
                CLAVE2(0) = FILA_IMPCAB1("SENORES")
                CLAVE2(1) = FILA_IMPCAB1("IATE")
                CLAVE2(2) = PLANILLA
                CLAVE2(3) = tipopla
                FILA_IMPCAB = Cjto_Tablas1.Tables("IMPCAB").Rows.Find(CLAVE2)
                If (FILA_IMPCAB Is Nothing) = True Then
                    FILA_IMPCAB = Cjto_Tablas1.Tables("IMPCAB").NewRow
                    FILA_IMPCAB("SENORES") = FILA_IMPCAB1("SENORES")
                    If IsDBNull(FILA_IMPCAB1("IDIRD")) = False Then Idid = FILA_IMPCAB1("IDIRD")
                    If IsDBNull(FILA_IMPCAB1("ICID")) = False Then Icid = FILA_IMPCAB1("ICID")
                    If IsDBNull(FILA_IMPCAB1("ICOD")) = False Then Icod = FILA_IMPCAB1("ICOD")

                    FILA_IMPCAB("IDIRD") = Idid
                    FILA_IMPCAB("ICID") = Icid
                    FILA_IMPCAB("IATE") = FILA_IMPCAB1("IATE")
                    FILA_IMPCAB("PLANILLA") = PLANILLA
                    FILA_IMPCAB("TIPOPLA") = tipopla
                    FILA_IMPCAB("ICOD") = Icod
                    Try
                        Cjto_Tablas1.Tables("IMPCAB").Rows.Add(FILA_IMPCAB)
                    Catch ex As Exception
                    End Try
                End If
                FILA_IMPDET = Cjto_Tablas1.Tables("IMPDET").NewRow
                FILA_IMPDET("SENORES") = FILA_IMPCAB1("SENORES")
                FILA_IMPDET("ISRE") = FILA_IMPCAB1("ISRE")
                FILA_IMPDET("INLADH") = FILA_IMPCAB1("INLADH")
                FILA_IMPDET("INAN") = FILA_IMPCAB1("INAN")
                FILA_IMPDET("INFA") = FILA_IMPCAB1("INFA")
                FILA_IMPDET("ITOT") = FILA_IMPCAB1("ITOT")
                FILA_IMPDET("INLAD") = FILA_IMPCAB1("INLAD")
                FILA_IMPDET("INLAH") = FILA_IMPCAB1("INLAH")
                FILA_IMPDET("PLANILLA") = PLANILLA
                FILA_IMPDET("TIPOPLA") = tipopla
                FILA_IMPDET("IATE") = FILA_IMPCAB1("IATE")
                Try
                    Cjto_Tablas1.Tables("IMPDET").Rows.Add(FILA_IMPDET)
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Private Sub TxtDel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDel.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAl.Text = TxtDel.Text
            TxtAl.Focus()
        End If
    End Sub

    Private Sub TxtDelOT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDelOT.KeyPress
        If e.KeyChar = Chr(13) Then
            'Rd_Ca_Planilla3.Checked = True
            TxtAlOT.Text = TxtDelOT.Text
            TxtAlOT.Focus()
        End If
    End Sub

    Private Sub Form_Carta_Despacho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyDate As Date
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        MyDate = Today
        TxtFecha.Text = MyDate
        TxtDel.Focus()
        Rd_Ca_Planilla1.Checked = True
        Call Anti_Elimina_lineas()
        Call Crear_Formato_Grilla()
        Cjto_Tablas1.Tables("IMPCAB1").Clear()
        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_SelectPlantilla_Despacho", Cjto_Tablas1, "PLANTILLA_DESPACHO")
            .EjecutarQueryDt("usp_SelectRazon_Social", Cjto_Tablas1, "RAZON_SOCIAL")
        End With
    End Sub

    Private Sub Anti_Elimina_lineas()
        Me.DtgCartaCobranza.DataSource = Cjto_Tablas1.Tables("IMPCAB1")
    End Sub

    Private Sub Crear_Formato_Grilla()
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "IMPCAB1"
        Dim NumLabo As New DataGridTextBoxColumn
        NumLabo.MappingName = "SENORES"
        NumLabo.HeaderText = "Señores"
        NumLabo.Width = 150
        NumLabo.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(NumLabo)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "IDIRD"
        TextCol.HeaderText = "Direccion/Casilla despacho"
        TextCol.Width = 150
        TextCol.NullText = ""
        TextCol.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol9 As New DataGridTextBoxColumn
        TextCol9.MappingName = "ICOD"
        TextCol9.HeaderText = "Comuna"
        TextCol9.Width = 60
        TextCol9.NullText = ""
        TextCol9.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol9)


        Dim TextCol16 As New DataGridTextBoxColumn
        TextCol16.MappingName = "ICID"
        TextCol16.HeaderText = "Ciudad"
        TextCol16.Width = 60
        TextCol16.NullText = ""
        TextCol16.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol16)

        Dim TextCol10 As New DataGridTextBoxColumn
        TextCol10.MappingName = "IATE"
        TextCol10.HeaderText = "Atención"
        TextCol10.Width = 150
        TextCol10.NullText = ""
        TextCol10.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol10)

        Dim TextCol18 As New DataGridTextBoxColumn
        TextCol18.MappingName = "ISRE"
        TextCol18.HeaderText = "Razón Social"
        TextCol18.Width = 150
        TextCol18.NullText = ""
        TextCol18.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol18)

        Dim TextCol17 As New DataGridTextBoxColumn
        TextCol17.MappingName = "INFA"
        TextCol17.HeaderText = "Factura"
        TextCol17.Width = 60
        TextCol17.NullText = ""
        TextCol17.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol17)


        Dim TextCol19 As New DataGridTextBoxColumn
        TextCol19.MappingName = "INLADH"
        TextCol19.HeaderText = "Nº laboratorio"
        TextCol19.Width = 75
        TextCol19.NullText = ""
        TextCol19.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol19)

        Dim TextCol11 As New DataGridTextBoxColumn
        TextCol11.MappingName = "INAN"
        TextCol11.HeaderText = "Cant."
        TextCol11.Width = 30
        TextCol11.NullText = ""
        TextCol11.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol11)

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "ITOT"
        TextCol1.HeaderText = "Total"
        TextCol1.Width = 50
        TextCol1.Format = "####,###"
        TextCol1.NullText = ""
        TextCol1.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol12 As New DataGridTextBoxColumn
        TextCol12.MappingName = "PLANILLACE"
        TextCol12.HeaderText = "C/Nóm"
        TextCol12.Width = 40
        TextCol12.NullText = ""
        TextCol12.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol12)

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "PLANILLACA"
        TextCol2.HeaderText = "S/Nóm"
        TextCol2.Width = 40
        TextCol2.NullText = ""
        TextCol2.Alignment = HorizontalAlignment.Left
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "IORD"
        TextCol3.HeaderText = "Orden"
        TextCol3.Width = 75
        TextCol3.NullText = ""
        TextCol3.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol3)

        DtgCartaCobranza.TableStyles.Add(ts1)
    End Sub

    Private Sub TxtAl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAl.KeyPress
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        If e.KeyChar = Chr(13) Then
            If TxtDel.Text = "" And TxtAl.Text = "" Then
                MsgBox("No se ha ingresado un número de factura. ", MsgBoxStyle.Information)
            End If
            If Rd_Ca_Planilla1.Checked = False And _
                   Rd_Ca_Planilla2.Checked = False And _
                   Rd_Ca_Planilla3.Checked = False And _
                   Rd_Ce_Planilla1.Checked = False And _
                   Rd_Ce_Planilla2.Checked = False And _
                   Rd_Ce_Planilla3.Checked = False Then
                MsgBox("Falta seleccionar plantilla")
                GoTo nogenera
            End If
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            Cjto_Tablas1.Tables("MICO2").Clear()
            Cjto_Tablas1.Tables("MIMU2").Clear()
            Cjto_Tablas1.Tables("MFAC").Clear()

            With SP
                .Inicializar()
                .AgregarParametro("@FacDesde", CInt(TxtDel.Text), SqlDbType.Int)
                .AgregarParametro("@FacHasta", CInt(TxtAl.Text), SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectMico", Cjto_Tablas1, "MICO2")
            End With

            With SP
                .Inicializar()
                .AgregarParametro("@FacDesde", CInt(TxtDel.Text), SqlDbType.Int)
                .AgregarParametro("@FacHasta", CInt(TxtAl.Text), SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectMFAC", Cjto_Tablas1, "MFAC")
            End With

            Call PROCESO_CARGA()
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            TxtDel.Text = ""
            TxtAl.Text = ""
            TxtDel.Focus()
nogenera:
        End If
    End Sub

    Private Sub TxtAlOT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAlOT.KeyPress
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            If e.KeyChar = Chr(13) Then
                If TxtDelOT.Text = "" And TxtAlOT.Text = "" Then
                    MsgBox("No se ha ingresado un número de Orden de Trabajo. ", MsgBoxStyle.Information)
                End If
                If Rd_Ca_Planilla1.Checked = False And _
                       Rd_Ca_Planilla2.Checked = False And _
                       Rd_Ca_Planilla3.Checked = False And _
                       Rd_Ce_Planilla1.Checked = False And _
                       Rd_Ce_Planilla2.Checked = False And _
                       Rd_Ce_Planilla3.Checked = False Then
                    MsgBox("Falta seleccionar plantilla")
                    GoTo nogenera
                End If
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                Cjto_Tablas1.Tables("MICO2").Clear()
                Cjto_Tablas1.Tables("MIMU2").Clear()
                Cjto_Tablas1.Tables("MFAC").Clear()

                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOtDesde", CInt(TxtDelOT.Text), SqlDbType.Int)
                    .AgregarParametro("@NumOtHasta", CInt(TxtAlOT.Text), SqlDbType.Int)
                    .EjecutarQueryDt("usp_SelectMico_Orden", Cjto_Tablas1, "MICO2")
                End With

                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOtDesde", CInt(TxtDelOT.Text), SqlDbType.Int)
                    .AgregarParametro("@NumOtHasta", CInt(TxtAlOT.Text), SqlDbType.Int)
                    .EjecutarQueryDt("usp_SelectMFAC_OT", Cjto_Tablas1, "MFAC")
                End With

                Call PROCESO_CARGA()
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                TxtDelOT.Text = ""
                TxtAlOT.Text = ""
                TxtDelOT.Focus()
nogenera:
            End If
        Catch ex As Exception
            MsgBox("error: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtgCartaCobranza.DoubleClick
        Dim FILA As Integer
        Dim FILA_DATAROW As DataRow
        Dim MYGRID As DataGrid = CType(sender, DataGrid)
        FILA = MYGRID.CurrentCell.RowNumber()
        FILA_DATAROW = Cjto_Tablas1.Tables("IMPCAB1").Rows(FILA)
        Cjto_Tablas1.Tables("IMPCAB1").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        SELECCION = ComboBox1.Text
        TxtNota1.Text = "" : TxtNota2.Text = "" : TxtNota3.Text = ""
        TxtNota4.Text = "" : TxtNota5.Text = "" : TxtNota6.Text = ""
        TxtNota7.Text = "" : TxtFirma1.Text = "" : TxtFirma2.Text = ""
        TxtFirma3.Text = "" : TxtFirma4.Text = ""
        Call ULTIMA_COTIZA_PLA()
    End Sub

    Private Sub ULTIMA_COTIZA_PLA()
        Dim FILA_NOTAS_R As DataRow
        Dim numero_coti As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet

        With SP
            .Inicializar()
            .AgregarParametro("@Seleccion", SELECCION, SqlDbType.NVarChar)
            ds = .EjecutarQuery("usp_SelectPlantilla_Despacho2")
        End With


        For Each FILA_NOTAS_R In ds.Tables(0).Rows
            numero_coti = FILA_NOTAS_R("PLD_NUMERO")
            Select Case numero_coti
                Case 1
                    TxtNota1.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 2
                    TxtNota2.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 3
                    TxtNota3.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 4
                    TxtNota4.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 5
                    TxtNota5.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 6
                    TxtNota6.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 7
                    TxtNota7.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 8
                    TxtFirma1.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 9
                    TxtFirma2.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 10
                    TxtFirma3.Text = FILA_NOTAS_R("PLD_NOTA")
                Case 11
                    TxtFirma4.Text = FILA_NOTAS_R("PLD_NOTA")
            End Select
        Next
    End Sub

    Private Sub BTNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNueva.Click
        GroupBox3.Visible = True
    End Sub

    Private Sub BTGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTGenera.Click
        GroupBox2.Visible = True
        TxtNomina.Focus()
    End Sub

    Private Sub IMPRIME_HOJA(ByVal excell As Excel.Application, ByVal sumador As Integer, ByVal FILA_IMPCAB As DataRow, ByVal HOJAEXCEL As Excel.Worksheet _
    , ByVal fila As Integer, ByVal SENORES As String, ByVal PLANILLA As String _
    , ByVal FCORTA As String _
        , ByVal nota1 As String, ByVal nota2 As String, ByVal nota3 As String, ByVal nota4 As String, ByVal nota5 As String, ByVal nota6 As String _
        , ByVal nota7 As String, ByVal Firma1 As String, ByVal Firma2 As String, ByVal Firma3 As String, ByVal Firma4 As String)
        Dim FILA_IMPDET As DataRow
        Dim fact_aux, connom, letpos As String
        Dim aux_ciucod, fila_firma, aux_total, filadet, largoco, varmer, k As Integer
        aux_ciucod = 0
        HOJAEXCEL.Range("V" & fila.ToString & ":AH" & fila.ToString).Merge()
        HOJAEXCEL.Range("V" & fila.ToString).Value = FCORTA
        HOJAEXCEL.Range("V" & fila.ToString).Font.Size = 10
        HOJAEXCEL.Range("V" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        fila = fila + 3
        HOJAEXCEL.Range("A" & fila.ToString).Value = "Sr.(es):"
        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
        fila = fila + 1
        HOJAEXCEL.Range("A" & fila.ToString).Value = FILA_IMPCAB("SENORES")
        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
        If FILA_IMPCAB("IDIRD") <> "" Then
            fila = fila + 1
            connom = FILA_IMPCAB("IDIRD")
            Call control_nombre(connom)
            HOJAEXCEL.Range("A" & fila.ToString).Value = connom
            HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
        End If
        If FILA_IMPCAB("ICOD") <> "" Then aux_ciucod = 1
        If FILA_IMPCAB("ICID") <> "" Then aux_ciucod = 2

        If FILA_IMPCAB("ICOD") <> "" Then
            fila = fila + 1
            connom = FILA_IMPCAB("ICOD")
            Call control_nombre(connom)
            HOJAEXCEL.Range("A" & fila.ToString).Value = connom
            HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
            If aux_ciucod = 1 Then HOJAEXCEL.Range("A" & fila.ToString).Font.Underline = True
        End If
        If FILA_IMPCAB("ICID") <> "" Then
            fila = fila + 1
            connom = FILA_IMPCAB("ICID")
            Call control_nombre(connom)
            HOJAEXCEL.Range("A" & fila.ToString).Value = connom
            HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
            HOJAEXCEL.Range("A" & fila.ToString).Font.Underline = True
        End If
        If FILA_IMPCAB("IATE") <> "" Then
            fila = fila + 2
            connom = FILA_IMPCAB("IATE")
            Call control_nombre(connom)
            HOJAEXCEL.Range("A" & fila.ToString).Value = "At.: " & connom
            HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
        End If
        fila = fila + 7
        HOJAEXCEL.Range("A" & fila.ToString).Value = "De nuestra consideración:"
        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
        fila = fila + 1
        If nota1 <> "" Then fila = fila + 1 : Call IMPRIME_NOTAS(excell, HOJAEXCEL, fila, nota1)
        If nota2 <> "" Then fila = fila + 1 : Call IMPRIME_NOTAS(excell, HOJAEXCEL, fila, nota2)
        fila = fila + 2
        If FILA_IMPCAB("PLANILLA") = "RES" Then
            HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).Merge()
            HOJAEXCEL.Range("D" & fila.ToString).Value = "PRODUCTOR"
            HOJAEXCEL.Range("D" & fila.ToString).Font.Size = 10
            HOJAEXCEL.Range("D" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).Merge()
            HOJAEXCEL.Range("S" & fila.ToString).Value = "N° LABORATORIO"
            HOJAEXCEL.Range("S" & fila.ToString).Font.Size = 8
            HOJAEXCEL.Range("S" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).Merge()
            HOJAEXCEL.Range("AA" & fila.ToString).Value = "CANT."
            HOJAEXCEL.Range("AA" & fila.ToString).Font.Size = 8
            HOJAEXCEL.Range("AA" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Else
            HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).Merge()
            HOJAEXCEL.Range("A" & fila.ToString).Value = "PRODUCTOR"
            HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
            HOJAEXCEL.Range("A" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


            HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).Merge()
            HOJAEXCEL.Range("P" & fila.ToString).Value = "N° LABORATORIO"
            HOJAEXCEL.Range("P" & fila.ToString).Font.Size = 8
            HOJAEXCEL.Range("P" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).Merge()
            HOJAEXCEL.Range("X" & fila.ToString).Value = "CANT."
            HOJAEXCEL.Range("X" & fila.ToString).Font.Size = 8
            HOJAEXCEL.Range("X" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        End If
        If FILA_IMPCAB("PLANILLA") = "RFP" Or FILA_IMPCAB("PLANILLA") = "RFC" Then
            HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).Merge()
            HOJAEXCEL.Range("AA" & fila.ToString).Value = "NºFACTURA"
            HOJAEXCEL.Range("AA" & fila.ToString).Font.Size = 8
            HOJAEXCEL.Range("AA" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).Merge()
            HOJAEXCEL.Range("AE" & fila.ToString).Value = "$ TOTAL"
            HOJAEXCEL.Range("AE" & fila.ToString).Font.Size = 8
            HOJAEXCEL.Range("AE" & fila.ToString).Font.Bold = True
            HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        If FILA_IMPCAB("PLANILLA") = "RES" Then
            HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).BorderAround()
            HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).BorderAround()
            HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).BorderAround()
        Else
            HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).BorderAround()
            HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).BorderAround()
            HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).BorderAround()
        End If
        If FILA_IMPCAB("PLANILLA") = "RFP" Or FILA_IMPCAB("PLANILLA") = "RFC" Then
            HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).BorderAround()
            HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).BorderAround()
        End If
        If FILA_IMPCAB("PLANILLA") = "RES" Then
            HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).Interior.Color = RGB(175, 238, 238)
            HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).Interior.Color = RGB(175, 238, 238)
            HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).Interior.Color = RGB(175, 238, 238)
        Else
            HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).Interior.Color = RGB(175, 238, 238)
            HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).Interior.Color = RGB(175, 238, 238)
            HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).Interior.Color = RGB(175, 238, 238)
        End If

        If FILA_IMPCAB("PLANILLA") = "RFP" Or FILA_IMPCAB("PLANILLA") = "RFC" Then
            HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).Interior.Color = RGB(175, 238, 238)
            HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).Interior.Color = RGB(175, 238, 238)
        End If
        filadet = 0 : aux_total = 0 : fact_aux = ""
        For Each FILA_IMPDET In Cjto_Tablas1.Tables("IMPDET").Rows
            If FILA_IMPDET("SENORES") = FILA_IMPCAB("SENORES") And FILA_IMPDET("PLANILLA") = FILA_IMPCAB("PLANILLA") And FILA_IMPDET("TIPOPLA") = FILA_IMPCAB("TIPOPLA") And FILA_IMPDET("IATE") = FILA_IMPCAB("IATE") Then
                If fact_aux <> "" And fact_aux <> FILA_IMPDET("INFA") Then
                    If FILA_IMPCAB("PLANILLA") = "RES" Then
                        With HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                        With HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                        With HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                    Else
                        With HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                        With HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                        With HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                    End If
                    If FILA_IMPCAB("PLANILLA") = "RFP" Or FILA_IMPCAB("PLANILLA") = "RFC" Then
                        With HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                        With HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlThin
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                    End If
                    aux_total = 0
                End If
                fact_aux = FILA_IMPDET("INFA")

                fila = fila + 1
                If aux_total = 0 Then
                    If FILA_IMPCAB("PLANILLA") = "RES" Then
                        HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).Merge()
                        HOJAEXCEL.Range("D" & fila.ToString).Value = FILA_IMPDET("ISRE")
                        HOJAEXCEL.Range("D" & fila.ToString).Font.Size = 10
                    Else
                        HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).Merge()
                        HOJAEXCEL.Range("A" & fila.ToString).Value = FILA_IMPDET("ISRE")
                        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10
                    End If
                End If

                If FILA_IMPCAB("PLANILLA") = "RES" Then
                    HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).Merge()
                    HOJAEXCEL.Range("S" & fila.ToString).Value = FILA_IMPDET("INLAD") & " - " & FILA_IMPDET("INLAH")
                    HOJAEXCEL.Range("S" & fila.ToString).Font.Size = 8
                    HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).Merge()
                    HOJAEXCEL.Range("AA" & fila.ToString).Value = FILA_IMPDET("INAN")
                    HOJAEXCEL.Range("AA" & fila.ToString).Font.Size = 8
                    HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Else
                    HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).Merge()
                    HOJAEXCEL.Range("P" & fila.ToString).Value = FILA_IMPDET("INLAD") & " - " & FILA_IMPDET("INLAH")
                    HOJAEXCEL.Range("P" & fila.ToString).Font.Size = 8
                    HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).Merge()
                    HOJAEXCEL.Range("X" & fila.ToString).Value = FILA_IMPDET("INAN")
                    HOJAEXCEL.Range("X" & fila.ToString).Font.Size = 8
                    HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                End If

                If FILA_IMPCAB("PLANILLA") = "RFP" Or FILA_IMPCAB("PLANILLA") = "RFC" Then
                    If aux_total = 0 Then
                        HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).Merge()
                        HOJAEXCEL.Range("AA" & fila.ToString).Value = FILA_IMPDET("INFA")
                        HOJAEXCEL.Range("AA" & fila.ToString).Font.Size = 8
                        HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                        HOJAEXCEL.Range("AE" & fila.ToString).Value = "$"
                        HOJAEXCEL.Range("AE" & fila.ToString).Font.Size = 8

                        HOJAEXCEL.Range("AF" & fila.ToString & ":AH" & fila.ToString).Merge()
                        HOJAEXCEL.Range("AF" & fila.ToString).Value = FILA_IMPDET("ITOT")
                        HOJAEXCEL.Range("AF" & fila.ToString).Font.Size = 8
                        HOJAEXCEL.Range("AF" & fila.ToString & ":AH" & fila.ToString).NumberFormat = "####.###"
                        HOJAEXCEL.Range("AF" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End If
                End If
                If FILA_IMPCAB("PLANILLA") = "RES" Then
                    With HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                Else
                    With HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                End If
                If FILA_IMPCAB("PLANILLA") = "RFP" Or FILA_IMPCAB("PLANILLA") = "RFC" Then
                    With HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With

                    With HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    With HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlThin
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                End If
                If aux_total = 0 Then aux_total = 1
                filadet = fila
            End If
        Next
        If FILA_IMPCAB("PLANILLA") = "RES" Then
            With HOJAEXCEL.Range("D" & fila.ToString & ":R" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJAEXCEL.Range("S" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJAEXCEL.Range("AA" & fila.ToString & ":AC" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
        Else

            With HOJAEXCEL.Range("A" & fila.ToString & ":O" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJAEXCEL.Range("P" & fila.ToString & ":W" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJAEXCEL.Range("X" & fila.ToString & ":Z" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

        End If
        If FILA_IMPCAB("PLANILLA") = "RFP" Or FILA_IMPCAB("PLANILLA") = "RFC" Then

            With HOJAEXCEL.Range("AA" & fila.ToString & ":AD" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJAEXCEL.Range("AE" & fila.ToString & ":AH" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlThin
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

        End If
        fila = fila + 2
        If nota3 <> "" Then fila = fila + 1 : Call IMPRIME_NOTAS(excell, HOJAEXCEL, fila, nota3)
        If nota4 <> "" Then fila = fila + 1 : Call IMPRIME_NOTAS(excell, HOJAEXCEL, fila, nota4)
        If nota5 <> "" Then fila = fila + 1 : Call IMPRIME_NOTAS(excell, HOJAEXCEL, fila, nota5)
        If nota6 <> "" Then fila = fila + 1 : Call IMPRIME_NOTAS(excell, HOJAEXCEL, fila, nota6)
        If nota7 <> "" Then fila = fila + 1 : Call IMPRIME_NOTAS(excell, HOJAEXCEL, fila, nota7)
        fila_firma = 55 + sumador
        If Firma1 <> "" Then
            HOJAEXCEL.Range("C" & fila_firma.ToString & ":I" & fila_firma.ToString).Merge()
            HOJAEXCEL.Range("C" & fila_firma.ToString).Value = Firma1
            HOJAEXCEL.Range("C" & fila_firma.ToString).Font.Size = 10
            HOJAEXCEL.Range("C" & fila_firma.ToString & ":I" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        If Firma2 <> "" Then
            HOJAEXCEL.Range("C" & (fila_firma + 1).ToString & ":I" & (fila_firma + 1).ToString).Merge()
            HOJAEXCEL.Range("C" & (fila_firma + 1).ToString).Value = Firma2
            HOJAEXCEL.Range("C" & (fila_firma + 1).ToString).Font.Size = 10
            HOJAEXCEL.Range("C" & (fila_firma + 1).ToString & ":I" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        If Firma3 <> "" Then
            HOJAEXCEL.Range("Z" & fila_firma.ToString & ":AF" & fila_firma.ToString).Merge()
            HOJAEXCEL.Range("Z" & fila_firma.ToString).Value = Firma3
            HOJAEXCEL.Range("Z" & fila_firma.ToString).Font.Size = 10
            HOJAEXCEL.Range("Z" & fila_firma.ToString & ":AF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        If Firma4 <> "" Then
            HOJAEXCEL.Range("Z" & (fila_firma + 1).ToString & ":AF" & (fila_firma + 1).ToString).Merge()
            HOJAEXCEL.Range("Z" & (fila_firma + 1).ToString).Value = Firma4
            HOJAEXCEL.Range("Z" & (fila_firma + 1).ToString).Font.Size = 10
            HOJAEXCEL.Range("Z" & (fila_firma + 1).ToString & ":AF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        With HOJAEXCEL.Range("Z" & (fila_firma - 1).ToString & ":AF" & (fila_firma - 1).ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        HOJAEXCEL.Range("Z" & (fila_firma + 3).ToString & ":AF" & (fila_firma + 3).ToString).Merge()
        HOJAEXCEL.Range("Z" & (fila_firma + 3).ToString).Value = "AGROLAB LTDA"
        HOJAEXCEL.Range("Z" & (fila_firma + 3).ToString).Font.Size = 10
        HOJAEXCEL.Range("Z" & (fila_firma + 3).ToString & ":AF" & (fila_firma + 3).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJAEXCEL.Range("A" & (fila_firma + 5).ToString).Value = "REA/ell"
        HOJAEXCEL.Range("A" & (fila_firma + 5).ToString).Font.Size = 10

    End Sub

    Private Sub IMPRIME_NOMINA(ByVal numnom As Integer, ByVal HOJAEXCEL As Excel.Worksheet, ByVal FCORTA1 As String, ByVal fila As Integer)
        Dim FILA_IMPCAB As DataRow
        Dim nomina As Integer
        Dim fact_aux As String
        Dim fila_firma, aux_total, filadet, largoco, varmer, k As Integer
        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & fila.ToString).Merge()
        HOJAEXCEL.Range("A" & fila.ToString).Value = "NOMINA CORREO"
        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 11
        HOJAEXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        fila = fila + 1
        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & fila.ToString).Merge()
        HOJAEXCEL.Range("A" & fila.ToString).Value = FCORTA1
        HOJAEXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 11
        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        fila = fila + 3
        HOJAEXCEL.Range("A" & fila.ToString & ":B" & fila.ToString).Merge()
        HOJAEXCEL.Range("A" & fila.ToString).Value = "Nº"
        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJAEXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJAEXCEL.Range("A" & fila.ToString & ":B" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Call BORDES(HOJAEXCEL, fila, "A", "B")
        HOJAEXCEL.Range("A" & fila.ToString & ":B" & fila.ToString).Interior.Color = RGB(175, 238, 238)

        HOJAEXCEL.Range("C" & fila.ToString & ":K" & fila.ToString).Merge()
        HOJAEXCEL.Range("C" & fila.ToString).Value = "EMPRESA"
        HOJAEXCEL.Range("C" & fila.ToString).Font.Size = 7
        HOJAEXCEL.Range("C" & fila.ToString).Font.Bold = True
        HOJAEXCEL.Range("C" & fila.ToString & ":K" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Call BORDES(HOJAEXCEL, fila, "C", "K")
        HOJAEXCEL.Range("C" & fila.ToString & ":K" & fila.ToString).Interior.Color = RGB(175, 238, 238)

        HOJAEXCEL.Range("L" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJAEXCEL.Range("L" & fila.ToString).Value = "DIRECCION"
        HOJAEXCEL.Range("L" & fila.ToString).Font.Size = 7
        HOJAEXCEL.Range("L" & fila.ToString).Font.Bold = True
        HOJAEXCEL.Range("L" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Call BORDES(HOJAEXCEL, fila, "L", "S")
        HOJAEXCEL.Range("L" & fila.ToString & ":S" & fila.ToString).Interior.Color = RGB(175, 238, 238)

        HOJAEXCEL.Range("T" & fila.ToString & ":Y" & fila.ToString).Merge()
        HOJAEXCEL.Range("T" & fila.ToString).Value = "CIUDAD"
        HOJAEXCEL.Range("T" & fila.ToString).Font.Size = 7
        HOJAEXCEL.Range("T" & fila.ToString).Font.Bold = True
        HOJAEXCEL.Range("T" & fila.ToString & ":Y" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Call BORDES(HOJAEXCEL, fila, "T", "Y")
        HOJAEXCEL.Range("T" & fila.ToString & ":Y" & fila.ToString).Interior.Color = RGB(175, 238, 238)

        HOJAEXCEL.Range("Z" & fila.ToString & ":AH" & fila.ToString).Merge()
        HOJAEXCEL.Range("Z" & fila.ToString).Value = "ATENCION"
        HOJAEXCEL.Range("Z" & fila.ToString).Font.Size = 7
        HOJAEXCEL.Range("Z" & fila.ToString).Font.Bold = True
        HOJAEXCEL.Range("Z" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Call BORDES(HOJAEXCEL, fila, "Z", "AH")
        HOJAEXCEL.Range("Z" & fila.ToString & ":AH" & fila.ToString).Interior.Color = RGB(175, 238, 238)

        nomina = numnom
        For Each FILA_IMPCAB In Cjto_Tablas1.Tables("IMPCAB").Rows
            If FILA_IMPCAB("TIPOPLA") = 1 Then
                fila = fila + 1
                HOJAEXCEL.Range("A" & fila.ToString & ":B" & fila.ToString).Merge()
                HOJAEXCEL.Range("A" & fila.ToString).Value = nomina
                HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 7
                HOJAEXCEL.Range("A" & fila.ToString & ":B" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                Call BORDES(HOJAEXCEL, fila, "A", "B")

                HOJAEXCEL.Range("C" & fila.ToString & ":K" & fila.ToString).Merge()
                HOJAEXCEL.Range("C" & fila.ToString).Value = FILA_IMPCAB("SENORES")
                HOJAEXCEL.Range("C" & fila.ToString).Font.Size = 7
                HOJAEXCEL.Range("C" & fila.ToString & ":K" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                Call BORDES(HOJAEXCEL, fila, "C", "K")

                HOJAEXCEL.Range("L" & fila.ToString & ":S" & fila.ToString).Merge()
                HOJAEXCEL.Range("L" & fila.ToString).Value = FILA_IMPCAB("IDIRD")
                HOJAEXCEL.Range("L" & fila.ToString).Font.Size = 7
                HOJAEXCEL.Range("L" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                Call BORDES(HOJAEXCEL, fila, "L", "S")

                HOJAEXCEL.Range("T" & fila.ToString & ":Y" & fila.ToString).Merge()
                HOJAEXCEL.Range("T" & fila.ToString).Value = FILA_IMPCAB("ICOD") & " ; " & FILA_IMPCAB("ICID")
                HOJAEXCEL.Range("T" & fila.ToString).Font.Size = 7
                HOJAEXCEL.Range("T" & fila.ToString & ":Y" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                Call BORDES(HOJAEXCEL, fila, "T", "Y")

                HOJAEXCEL.Range("Z" & fila.ToString & ":AH" & fila.ToString).Merge()
                HOJAEXCEL.Range("Z" & fila.ToString).Value = FILA_IMPCAB("IATE")
                HOJAEXCEL.Range("Z" & fila.ToString).Font.Size = 7
                HOJAEXCEL.Range("Z" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                Call BORDES(HOJAEXCEL, fila, "Z", "AH")
                nomina = nomina + 1
            End If
        Next
        HOJAEXCEL.PageSetup.PrintArea = "$A$1:$AH$" & fila
    End Sub

    Private Sub IMPRIME_NOTAS(ByVal excell As Excel.Application, ByVal HOJAEXCEL As Excel.Worksheet, ByRef fila As Integer, ByVal nota As String)
        Dim largoco, varmer, k As Integer
        largoco = Len(nota)
        varmer = CInt(largoco / 80)
        k = fila + varmer
        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & k.ToString).Merge()
        HOJAEXCEL.Range("A" & fila.ToString).Value = nota
        HOJAEXCEL.Range("A" & fila.ToString).Font.Size = 10

        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & k.ToString).WrapText = True
        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & k.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        HOJAEXCEL.Range("A" & fila.ToString & ":AH" & k.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        If Len(nota) = 285 Then
            HOJAEXCEL.Range("A" & fila.ToString & ":AH" & k.ToString).Select()
            excell.ActiveCell.FormulaR1C1 = nota
            With excell.ActiveCell.Characters(Start:=1, Length:=63).Font
                .Name = "Arial"
                .FontStyle = "Normal"
                .Size = 10
            End With
            'banco
            With excell.ActiveCell.Characters(Start:=58, Length:=15).Font
                .Name = "Arial"
                .FontStyle = "Negrita"
                .Size = 10
            End With
            With excell.ActiveCell.Characters(Start:=73, Length:=3).Font
                .Name = "Arial"
                .FontStyle = "Normal"
                .Size = 10
            End With
            'cuenta
            With excell.ActiveCell.Characters(Start:=75, Length:=25).Font
                .Name = "Arial"
                .FontStyle = "Negrita"
                .Size = 10
            End With
            With excell.ActiveCell.Characters(Start:=99, Length:=14).Font
                .Name = "Arial"
                .FontStyle = "Normal"
                .Size = 10
            End With
            'agrolab
            With excell.ActiveCell.Characters(Start:=112, Length:=13).Font
                .Name = "Arial"
                .FontStyle = "Negrita"
                .Size = 10
            End With
            With excell.ActiveCell.Characters(Start:=126, Length:=59).Font
                .Name = "Arial"
                .FontStyle = "Normal"
                .Size = 10
            End With
            'rut
            With excell.ActiveCell.Characters(Start:=180, Length:=3).Font
                .Name = "Arial"
                .FontStyle = "Negrita"
                .Size = 10
            End With
            With excell.ActiveCell.Characters(Start:=185, Length:=3).Font
                .Name = "Arial"
                .FontStyle = "Normal"
                .Size = 10
            End With
            '79.715...
            With excell.ActiveCell.Characters(Start:=188, Length:=12).Font
                .Name = "Arial"
                .FontStyle = "Negrita"
                .Size = 10
            End With
            With excell.ActiveCell.Characters(Start:=201, Length:=84).Font
                .Name = "Arial"
                .FontStyle = "Normal"
                .Size = 10
            End With
        End If
        fila = k + 1
    End Sub

    Private Sub CARGA_NOTAS(ByVal SELECCION As String, ByRef nota1 As String, ByRef nota2 As String, ByRef nota3 As String, ByRef nota4 As String, ByRef nota5 As String, ByRef nota6 As String, ByRef nota7 As String, ByRef Firma1 As String, ByRef Firma2 As String, ByRef Firma3 As String, ByRef Firma4 As String)
        Dim FILA_NOTAS_R As DataRow
        Dim myselectquery, consulta_nota As String
        Dim ULTIMA_COTIZACION As Double
        Dim ULT_MAS_UNA, numero_coti As Integer

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet

        With SP
            .Inicializar()
            .AgregarParametro("@Seleccion", SELECCION, SqlDbType.NVarChar)
            ds = .EjecutarQuery("usp_SelectPlantilla_Despacho2")
        End With


        For Each FILA_NOTAS_R In ds.Tables(0).Rows
            numero_coti = FILA_NOTAS_R("PLD_NUMERO")
            Select Case numero_coti
                Case 1
                    nota1 = FILA_NOTAS_R("PLD_NOTA")
                Case 2
                    nota2 = FILA_NOTAS_R("PLD_NOTA")
                Case 3
                    nota3 = FILA_NOTAS_R("PLD_NOTA")
                Case 4
                    nota4 = FILA_NOTAS_R("PLD_NOTA")
                Case 5
                    nota5 = FILA_NOTAS_R("PLD_NOTA")
                Case 6
                    nota6 = FILA_NOTAS_R("PLD_NOTA")
                Case 7
                    nota7 = FILA_NOTAS_R("PLD_NOTA")
                Case 8
                    Firma1 = FILA_NOTAS_R("PLD_NOTA")
                Case 9
                    Firma2 = FILA_NOTAS_R("PLD_NOTA")
                Case 10
                    Firma3 = FILA_NOTAS_R("PLD_NOTA")
                Case 11
                    Firma4 = FILA_NOTAS_R("PLD_NOTA")
            End Select
        Next
    End Sub

    Private Sub control_nombre(ByRef nomb As String)
        Dim lar, i, j As Integer
        Dim acumula As String
        lar = Len(nomb)
        acumula = "" : j = 0
        For i = 1 To lar
            If Mid(nomb, i, 4) = "S.A." Then acumula = acumula & "S.A." : Exit For
            If i = 1 Then acumula = UCase(Mid(nomb, 1, 1)) : GoTo continuar
            If j = 1 Then acumula = acumula & UCase(Mid(nomb, i, 1)) : j = 0 : GoTo continuar
            If Mid(nomb, i, 1) = " " Then acumula = acumula & " " : j = 1 : GoTo continuar
            If Mid(nomb, i, 1) = "." Then acumula = acumula & "." : j = 1 : GoTo continuar
            If Mid(nomb, i, 1) = "-" Then acumula = acumula & "-" : j = 1 : GoTo continuar
            acumula = acumula & LCase(Mid(nomb, i, 1))
continuar:
        Next
        nomb = acumula
    End Sub

    Private Sub BORDES(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila As Integer, ByVal Letra1 As String, ByVal Letra2 As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Private Sub BTAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAceptar.Click
        Try
            Dim fuente, destino, fechacc, fcorta, FCORTA1, PLANTILLA As String
            Dim nota1, nota2, nota3, nota4, nota5, nota6, nota7, Firma1, Firma2, Firma3, Firma4 As String
            Dim largo, numnom, fila, sumador As Integer
            Dim FILA_IMPCAB, FILA_IMPDET As DataRow
            Dim m_Excel As Excel.Application
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim MyDate As Date
            Call CARGA_PARA_IMPRESION()
            MyDate = TxtFecha.Text
            fechacc = Mid(MyDate, 4, 2) & "-" & Mid(MyDate, 1, 2)
            m_Excel = CreateObject("EXCEL.APPLICATION")
            fuente = "F:\Archivos LabSys\Formatos Labsys\Formato_Carta_Despacho.xls"
            destino = "F:\Archivos LabSys\Cartas\Despacho\Correo " & fechacc & " LabSys.xls"
            Try
                FileCopy(fuente, destino)
            Catch ex As Exception
                MsgBox("Documento Abierto")
                Exit Sub
            End Try
            objLibroExcel = m_Excel.Workbooks.Open(destino)
            m_Excel.Visible = True
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()
            fcorta = Format(MyDate, "dd MMMMMMMMMM yyyy")
            FCORTA1 = Format(MyDate, "dd MMMM yyyy")
            largo = Len(FCORTA1)
            FCORTA1 = Mid(FCORTA1, 1, 2) & " de " + Mid(FCORTA1, 4, (largo - 8)) & " de" & Mid(FCORTA1, (largo - 4))
            largo = Len(fcorta)
            fcorta = "Santiago , " & Mid(fcorta, 1, 2) & " de " + Mid(fcorta, 4, (largo - 8)) & " de" & Mid(fcorta, (largo - 4))
            sumador = 0
            For Each FILA_IMPCAB In Cjto_Tablas1.Tables("IMPCAB").Rows
                fila = 6 + sumador
                PLANTILLA = FILA_IMPCAB("PLANILLA")
                If PLANTILLA = "RFP" Then PLANTILLA = "Res Fac Pte"
                If PLANTILLA = "RFC" Then PLANTILLA = "Res Fac Can"
                If PLANTILLA = "RES" Then PLANTILLA = "Res Solo"
                If PLANTILLA = "RFS" Then PLANTILLA = "Fac Solo"
                Call CARGA_NOTAS(PLANTILLA, nota1, nota2, nota3, nota4, nota5, nota6, nota7, Firma1, Firma2, Firma3, Firma4)
                Call IMPRIME_HOJA(m_Excel, sumador, FILA_IMPCAB, objHojaExcel, fila, FILA_IMPCAB("SENORES"), PLANTILLA, fcorta, nota1, nota2, nota3, nota4, nota5, nota6, nota7, Firma1, Firma2, Firma3, Firma4)
                sumador = sumador + 62
            Next
            objHojaExcel.Range("A8").Select()
            fila = 6 + sumador
            numnom = CInt(TxtNomina.Text)
            Call IMPRIME_NOMINA(numnom, objHojaExcel, FCORTA1, fila)
            GroupBox2.Visible = False
        Catch ex As Exception
            MsgBox("error: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub TxtNomina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNomina.KeyPress
        If e.KeyChar = Chr(13) Then
            BTAceptar.Focus()
        End If
    End Sub

    Private Sub BTFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTFecha.Click
        Me.MonthCalendar1.Visible = True
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Me.MonthCalendar1.Visible = False
        Me.TxtFecha.Text = Me.MonthCalendar1.SelectionRange.Start
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.GroupBox2.Visible = False
    End Sub
End Class
