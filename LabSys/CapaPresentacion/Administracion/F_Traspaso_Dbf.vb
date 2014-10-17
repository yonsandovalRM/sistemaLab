Imports System.Data.SqlClient
Public Class F_Traspaso_Dbf
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Llena datos Factura con Cliente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Llena datos Ordenes con Cliente"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(224, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Llena Productor con Orden_trabajo sql"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(224, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Llena Ot_Codificacion"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(264, 104)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Revisa Campo Localidad en OT y Productor"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(16, 184)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(224, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Boton Momentaneo"
        '
        'Frm_Traspaso_Dbf
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 273)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Traspaso_Dbf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Traspaso_Dbf"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Traspaso_Dbf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim acufon, query, consulta_nota, razon, Direccion, Empresa, Ciudad, Comuna, Giro, Fono1, Fono2, RutFact, Fonos As String
        Dim mc, t, NumOt, numFila, NlabDesde, NlabHasta, CantMuestras, Descuento As Integer
        Dim Muestrasp As Integer = 1000
        Dim fila As DataRow
        Dim con As New SqlConnection(Conexion1)
        DbMan = New DbManager("FACTURA", Conexion1)
        Try
            query = "Select * from FACTURA"
            DbMan.Selecccionar(datos, query)
        Catch ex As Exception
        End Try
        CantMuestras = 0 : NumOt = 0
        con.Open()
        For Each fila In datos.Tables("FACTURA").Rows
            t = 0
            If IsDBNull(fila("FAC_RUT")) = False Then RutFact = fila("FAC_RUT") Else RutFact = ""
            If RutFact <> "" Then
                consulta_nota = "SELECT IRAZ,IDES,IDIR,ICIU,ICOM,IFOF,IEMP,IREM,IGIR FROM TABLA_CLIENTES_DBF WHERE IRUT='" & fila("FAC_RUT") & "'"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Read()
                    razon = "" : Direccion = "" : Descuento = 0 : Ciudad = "" : Comuna = "" : Fonos = "" : Empresa = "" : Giro = ""
                    Try
                        If IsDBNull(myReader3.GetString(0)) = False Then razon = myReader3.GetString(0)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetDouble(1)) = False Then Descuento = myReader3.GetDouble(1)
                    Catch ex As Exception
                    End Try


                    Try
                        If IsDBNull(myReader3.GetString(2)) = False Then Direccion = myReader3.GetString(2)
                    Catch ex As Exception
                    End Try


                    Try
                        If IsDBNull(myReader3.GetString(3)) = True Then Ciudad = myReader3.GetString(3)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(4)) = False Then Comuna = myReader3.GetString(4)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(5)) = False Then Fonos = myReader3.GetString(5)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(6)) = False Then Empresa = myReader3.GetString(6)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(8)) = False Then Giro = myReader3.GetString(8)
                    Catch ex As Exception
                    End Try
                    myReader3.Close()

                    Fono1 = "" : Fono2 = ""
                    If Fonos <> "" Then
                        acufon = ""
                        For mc = 1 To Len(Fonos)
                            If mc > 3 And (Mid(Fonos, mc, 1) = "-" Or Mid(Fonos, mc, 1) = "/") Then
                                Fono1 = acufon
                                acufon = ""
                            End If
                            acufon = acufon & Mid(Fonos, mc, 1)
                        Next
                        If Fono1 <> "" Then Fono2 = Mid(acufon, 2) Else Fono1 = acufon
                    End If
                    consulta_nota = "UPDATE FACTURA SET FAC_RSOCIAL='" & connomt(razon) & "'," & _
                                                                            "FAC_EMPRESA='" & connomt(Empresa) & "'," & _
                                                                            "FAC_DIRECCION='" & connomt(Direccion) & "'," & _
                                                                            "FAC_CIUDAD='" & connomt(Ciudad) & "'," & _
                                                                            "FAC_GIRO='" & connomt(Giro) & "'," & _
                                                                            "FAC_COMUNA='" & connomt(Comuna) & "'," & _
                                                                            "FAC_FONO1='" & Fono1 & "'," & _
                                                                            "FAC_FONO2='" & Fono2 & "'," & _
                                                                            "FAC_DESCUENTOPOR=" & Descuento & _
                                                                            " WHERE FAC_NUMERO=" & fila("FAC_NUMERO")
                    Dim mycom As New SqlCommand(consulta_nota, con)
                    Dim myReader4 As SqlDataReader
                    myReader4 = mycom.ExecuteReader()
                    myReader4.Close()

                Catch ex As Exception
                End Try
            End If
        Next
        con.Close()
        MsgBox("Terminado el traspaso")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim acufon, query, consulta_nota, razon, Direccion, Empresa, Ciudad, Comuna, Giro, Fono1, Fono2, RutFact, Fonos As String
        Dim Productor, EmpresaP, PredioP, DireccionP, LocalidadP, ComunaP, CiudadP, Remite, SenoresD, AtencionD, DireccionD, ComunaD, CiudadD, Entrego As String
        Dim mc, t, NumOt, numFila, NlabDesde, NlabHasta, CantMuestras, Descuento As Integer
        Dim FechaFac As String
        Dim Muestrasp As Integer = 1000
        Dim fila As DataRow
        Dim con As New SqlConnection(Conexion1)
        DbMan = New DbManager("ORDEN_TRABAJO", Conexion1)
        Try
            query = "Select * from ORDEN_TRABAJO"
            DbMan.Selecccionar(datos, query)
        Catch ex As Exception
        End Try
        CantMuestras = 0 : NumOt = 0
        con.Open()
        For Each fila In datos.Tables("ORDEN_TRABAJO").Rows
            t = 0
            If IsDBNull(fila("OT_FAC_RUT")) = False Then RutFact = fila("OT_FAC_RUT") Else RutFact = ""
            If RutFact <> "" Then
                consulta_nota = "SELECT IRAZ,IDES,IDIR,ICIU,ICOM,IFOF,IEMP,IREM,IGIR FROM TABLA_CLIENTES_DBF WHERE IRUT='" & fila("OT_FAC_RUT") & "'"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Read()
                    razon = "" : Direccion = "" : Descuento = 0 : Ciudad = "" : Comuna = "" : Fonos = "" : Empresa = "" : Giro = ""
                    Try
                        If IsDBNull(myReader3.GetString(0)) = False Then razon = myReader3.GetString(0)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetDouble(1)) = False Then Descuento = myReader3.GetDouble(1)
                    Catch ex As Exception
                    End Try


                    Try
                        If IsDBNull(myReader3.GetString(2)) = False Then Direccion = myReader3.GetString(2)
                    Catch ex As Exception
                    End Try


                    Try
                        If IsDBNull(myReader3.GetString(3)) = True Then Ciudad = myReader3.GetString(3)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(4)) = False Then Comuna = myReader3.GetString(4)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(5)) = False Then Fonos = myReader3.GetString(5)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(6)) = False Then Empresa = myReader3.GetString(6)
                    Catch ex As Exception
                    End Try

                    Try
                        If IsDBNull(myReader3.GetString(8)) = False Then Giro = myReader3.GetString(8)
                    Catch ex As Exception
                    End Try
                    myReader3.Close()

                    Fono1 = "" : Fono2 = ""
                    If Fonos <> "" Then
                        acufon = ""
                        For mc = 1 To Len(Fonos)
                            If mc > 3 And (Mid(Fonos, mc, 1) = "-" Or Mid(Fonos, mc, 1) = "/") Then
                                Fono1 = acufon
                                acufon = ""
                            End If
                            acufon = acufon & Mid(Fonos, mc, 1)
                        Next
                        If Fono1 <> "" Then Fono2 = Mid(acufon, 2) Else Fono1 = acufon
                    End If
                    If IsDBNull(fila("PRO_PRODUCTOR")) = False Then Productor = fila("PRO_PRODUCTOR") Else Productor = ""
                    If IsDBNull(fila("OT_EMPRESA")) = False Then EmpresaP = fila("OT_EMPRESA") Else EmpresaP = ""
                    If IsDBNull(fila("OT_PREDIO")) = False Then PredioP = fila("OT_PREDIO") Else PredioP = ""
                    If IsDBNull(fila("OT_DIRECCION")) = False Then DireccionP = fila("OT_DIRECCION") Else DireccionP = ""
                    If IsDBNull(fila("OT_LOCALIDAD")) = False Then LocalidadP = fila("OT_LOCALIDAD") Else LocalidadP = ""
                    If IsDBNull(fila("OT_COMUNA")) = False Then ComunaP = fila("OT_COMUNA") Else ComunaP = ""
                    If IsDBNull(fila("OT_CIUDAD")) = False Then CiudadP = fila("OT_CIUDAD") Else CiudadP = ""
                    If IsDBNull(fila("OT_SOL_NOMBRE")) = False Then Remite = fila("OT_SOL_NOMBRE") Else Remite = ""
                    If IsDBNull(fila("OT_DESP_SENORES")) = False Then SenoresD = fila("OT_DESP_SENORES") Else SenoresD = ""
                    If IsDBNull(fila("OT_DESP_ATENCION")) = False Then AtencionD = fila("OT_DESP_ATENCION") Else AtencionD = ""
                    If IsDBNull(fila("OT_DESP_DIRECCION")) = False Then DireccionD = fila("OT_DESP_DIRECCION") Else DireccionD = ""
                    If IsDBNull(fila("OT_DESP_COMUNA")) = False Then ComunaD = fila("OT_DESP_COMUNA") Else ComunaD = ""
                    If IsDBNull(fila("OT_DESP_CIUDAD")) = False Then CiudadD = fila("OT_DESP_CIUDAD") Else CiudadD = ""
                    If IsDBNull(fila("OT_ENTREGO")) = False Then Entrego = fila("OT_ENTREGO") Else Entrego = ""
                    FechaFac = ""
                    If IsDBNull(fila("FAC_NUMERO")) = False Then
                        consulta_nota = "SELECT FAC_FECHA_EMISION FROM FACTURA WHERE FAC_NUMERO=" & fila("FAC_NUMERO")
                        Dim myCommand5 As New SqlCommand(consulta_nota, con)
                        Dim myReader5 As SqlDataReader
                        Try
                            myReader5 = myCommand5.ExecuteReader()
                            myReader5.Read()
                            FechaFac = myReader5.GetDateTime(0)
                            myReader5.Close()
                        Catch ex As Exception

                        End Try

                    End If


                    consulta_nota = "UPDATE ORDEN_TRABAJO SET PRO_RUT='" & RutFact & "'," & _
                                                                    "PRO_PRODUCTOR='" & connomt(Productor) & "'," & _
                                                                    "OT_EMPRESA='" & connomt(EmpresaP) & "'," & _
                                                                    "OT_PREDIO='" & connomt(PredioP) & "'," & _
                                                                    "OT_DIRECCION='" & connomt(DireccionP) & "'," & _
                                                                    "OT_LOCALIDAD='" & connomt(LocalidadP) & "'," & _
                                                                    "OT_COMUNA='" & connomt(ComunaP) & "'," & _
                                                                    "OT_CIUDAD='" & connomt(CiudadP) & "'," & _
                                                                    "OT_SOL_NOMBRE='" & connomt(Remite) & "'," & _
                                                                    "OT_DESP_SENORES='" & connomt(SenoresD) & "'," & _
                                                                    "OT_DESP_ATENCION='" & connomt(AtencionD) & "'," & _
                                                                    "OT_DESP_DIRECCION='" & connomt(DireccionD) & "'," & _
                                                                    "OT_DESP_COMUNA='" & connomt(ComunaD) & "'," & _
                                                                    "OT_DESP_CIUDAD='" & connomt(CiudadD) & "'," & _
                                                                    "OT_ENTREGO='" & connomt(Entrego) & "'," & _
                                                                    "OT_FAC_RSOCIAL='" & connomt(razon) & "'," & _
                                                                                                "OT_FAC_DIRECCION='" & connomt(Direccion) & "'," & _
                                                                                                "OT_FAC_CIUDAD='" & connomt(Ciudad) & "'," & _
                                                                                                "OT_FAC_GIRO='" & connomt(Giro) & "'," & _
                                                                                                "OT_FAC_COMUNA='" & connomt(Comuna) & "'," & _
                                                                                                "OT_FAC_FONO1='" & Fono1 & "'," & _
                                                                                                "OT_FAC_FONO2='" & Fono2 & "'," & _
                                                                                                "FAC_FECHA='" & FechaFac & "'" & _
                                                                                                " WHERE OT_NUMERO=" & fila("OT_NUMERO")
                    Dim mycom As New SqlCommand(consulta_nota, con)
                    Dim myReader4 As SqlDataReader
                    myReader4 = mycom.ExecuteReader()
                    myReader4.Close()

                Catch ex As Exception
                End Try
            End If
        Next
        con.Close()
        MsgBox("Terminado el traspaso")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim acufon, query, consulta_nota, razon, Direccion, Empresa, Ciudad, Comuna, Giro, Fono1, Fono2, RutProd, Fonos As String
        Dim mc, t, NumOt, numFila, NlabDesde, NlabHasta, CantMuestras, Descuento As Integer
        Dim Productor, Predio, DireccionP, ComunaP, CiudadP, RegionP, Fono1P, Fono2P, Fax1P, Fax2P, Remite As String
        Dim Fono1F, Fono2F, DireccionF, ComunaF, CiudadF, Encarg, F1Cob, F2Cob, RetiraxD, FonoxD, FaxxD, CorreoxD As String
        Dim BusxD, OtroxD, senores, atencion, DireccionD, CasillaD, ComunaD, CiudadD, FechaD, Fono1D, Fono2D, Fax1D, Ot_Entrego As String
        Dim Muestrasp As Integer = 1000
        Dim fila As DataRow
        Dim con As New SqlConnection(Conexion1)
        DbMan = New DbManager("ORDEN_TRABAJO", Conexion1)
        Try
            query = "Select * from ORDEN_TRABAJO"
            DbMan.Selecccionar(datos, query)
        Catch ex As Exception
        End Try
        CantMuestras = 0 : NumOt = 0
        con.Open()
        For Each fila In datos.Tables("ORDEN_TRABAJO").Rows
            t = 0
            If IsDBNull(fila("OT_FAC_RUT")) = False Then RutProd = fila("OT_FAC_RUT") Else RutProd = ""
            If Len(RutProd) > 2 Then
                If IsDBNull(fila("PRO_PRODUCTOR")) = False Then Productor = CaracSql(fila("PRO_PRODUCTOR")) Else Productor = ""
                If IsDBNull(fila("OT_FAC_RUT")) = False Then RutProd = fila("OT_FAC_RUT") Else RutProd = ""
                If IsDBNull(fila("OT_EMPRESA")) = False Then Empresa = CaracSql(fila("OT_EMPRESA")) Else Empresa = ""
                If IsDBNull(fila("OT_PREDIO")) = False Then Predio = CaracSql(fila("OT_PREDIO")) Else Predio = ""
                If IsDBNull(fila("OT_DIRECCION")) = False Then DireccionP = CaracSql(fila("OT_DIRECCION")) Else DireccionP = ""
                If IsDBNull(fila("OT_COMUNA")) = False Then ComunaP = CaracSql(fila("OT_COMUNA")) Else ComunaP = ""
                If IsDBNull(fila("OT_CIUDAD")) = False Then CiudadP = CaracSql(fila("OT_CIUDAD")) Else CiudadP = ""
                If IsDBNull(fila("OT_REGION")) = False Then RegionP = fila("OT_REGION") Else RegionP = ""
                If IsDBNull(fila("OT_FONO1")) = False Then Fono1P = fila("OT_FONO1") Else Fono1P = ""
                If IsDBNull(fila("OT_FONO2")) = False Then Fono2P = fila("OT_FONO2") Else Fono2P = ""
                If IsDBNull(fila("OT_FAX1")) = False Then Fax1P = fila("OT_FAX1") Else Fax1P = ""
                If IsDBNull(fila("OT_FAX2")) = False Then Fax2P = fila("OT_FAX2") Else Fax2P = ""
                If IsDBNull(fila("OT_REMITE")) = False Then Remite = CaracSql(fila("OT_REMITE")) Else Remite = ""
                If IsDBNull(fila("OT_FAC_RSOCIAL")) = False Then razon = CaracSql(fila("OT_FAC_RSOCIAL")) Else razon = ""
                If IsDBNull(fila("OT_FAC_FONO1")) = False Then Fono1F = fila("OT_FAC_FONO1") Else Fono1F = ""
                If IsDBNull(fila("OT_FAC_FONO2")) = False Then Fono2F = fila("OT_FAC_FONO2") Else Fono2F = ""
                If IsDBNull(fila("OT_FAC_GIRO")) = False Then Giro = CaracSql(fila("OT_FAC_GIRO")) Else Giro = ""
                If IsDBNull(fila("OT_FAC_DIRECCION")) = False Then DireccionF = CaracSql(fila("OT_FAC_DIRECCION")) Else DireccionF = ""
                If IsDBNull(fila("OT_FAC_COMUNA")) = False Then ComunaF = CaracSql(fila("OT_FAC_COMUNA")) Else ComunaF = ""
                If IsDBNull(fila("OT_FAC_CIUDAD")) = False Then CiudadF = CaracSql(fila("OT_FAC_CIUDAD")) Else CiudadF = ""
                If IsDBNull(fila("OT_FAC_ENCPAGO")) = False Then Encarg = CaracSql(fila("OT_FAC_ENCPAGO")) Else Encarg = ""
                If IsDBNull(fila("OT_FAC_F1PAGO")) = False Then F1Cob = fila("OT_FAC_F1PAGO") Else F1Cob = ""
                If IsDBNull(fila("OT_FAC_F2PAGO")) = False Then F2Cob = fila("OT_FAC_F2PAGO") Else F2Cob = ""
                If IsDBNull(fila("OT_DESP_POR_RETIRALAB")) = False Then RetiraxD = fila("OT_DESP_POR_RETIRALAB") Else RetiraxD = 0
                If IsDBNull(fila("OT_DESP_POR_FONO")) = False Then FonoxD = fila("OT_DESP_POR_FONO") Else FonoxD = 0
                If IsDBNull(fila("OT_DESP_POR_FAX")) = False Then FaxxD = fila("OT_DESP_POR_FAX") Else FaxxD = 0
                If IsDBNull(fila("OT_DESP_POR_CORREO")) = False Then CorreoxD = fila("OT_DESP_POR_CORREO") Else CorreoxD = 0
                If IsDBNull(fila("OT_DESP_POR_BUS")) = False Then BusxD = fila("OT_DESP_POR_BUS") Else BusxD = 0
                If IsDBNull(fila("OT_DESP_POR_OTRO")) = False Then OtroxD = fila("OT_DESP_POR_OTRO") Else OtroxD = 0
                If IsDBNull(fila("OT_DESP_SENORES")) = False Then senores = CaracSql(fila("OT_DESP_SENORES")) Else senores = ""
                If IsDBNull(fila("OT_DESP_ATENCION")) = False Then atencion = CaracSql(fila("OT_DESP_ATENCION")) Else atencion = ""
                If IsDBNull(fila("OT_DESP_DIRECCION")) = False Then DireccionD = CaracSql(fila("OT_DESP_DIRECCION")) Else DireccionD = ""
                If IsDBNull(fila("OT_DESP_CASILLA")) = False Then CasillaD = CaracSql(fila("OT_DESP_CASILLA")) Else CasillaD = ""
                If IsDBNull(fila("OT_DESP_COMUNA")) = False Then ComunaD = CaracSql(fila("OT_DESP_COMUNA")) Else ComunaD = ""
                If IsDBNull(fila("OT_DESP_CIUDAD")) = False Then CiudadD = CaracSql(fila("OT_DESP_CIUDAD")) Else CiudadD = ""
                If IsDBNull(fila("OT_DESP_FECHA")) = False Then FechaD = fila("OT_DESP_FECHA") Else FechaD = ""
                If IsDBNull(fila("OT_DESP_FONO1")) = False Then Fono1D = fila("OT_DESP_FONO1") Else Fono1D = ""
                If IsDBNull(fila("OT_DESP_FONO2")) = False Then Fono2D = fila("OT_DESP_FONO2") Else Fono2D = ""
                If IsDBNull(fila("OT_DESP_FAX1")) = False Then Fax1D = fila("OT_DESP_FAX1") Else Fax1D = ""
                If IsDBNull(fila("OT_ENTREGO")) = False Then Ot_Entrego = CaracSql(fila("OT_ENTREGO")) Else Ot_Entrego = ""


                consulta_nota = "INSERT INTO PRODUCTOR_LABSYS (PRO_PRODUCTOR,PRO_RUT,PRO_EMPRESA,PRO_PREDIO,PRO_DIRECCION,PRO_COMUNA," & _
                                                               "PRO_CIUDAD,PRO_REGION,PRO_FONO1,PRO_FONO2,PRO_FAX1,PRO_REMITE," & _
                                                               "PRO_FAC_RSOCIAL,PRO_FAC_FONO1,PRO_FAC_FONO2,PRO_FAC_GIRO,PRO_FAC_DIRECCION," & _
                                                               "PRO_FAC_COMUNA,PRO_FAC_CIUDAD,PRO_FAC_ENCPAGO,PRO_FAC_F1PAGO,PRO_FAC_F2PAGO," & _
                                                               "PRO_DESP_POR_RETIRALAB,PRO_DESP_POR_FONO,PRO_DESP_POR_FAX," & _
                                                               "PRO_DESP_POR_CORREO,PRO_DESP_POR_BUS,PRO_DESP_POR_OTRO,PRO_DESP_SENORES," & _
                                                               "PRO_DESP_ATENCION,PRO_DESP_DIRECCION,PRO_DESP_CASILLA,PRO_DESP_COMUNA," & _
                                                               "PRO_DESP_CIUDAD,PRO_DESP_FECHA,PRO_DESP_FONO1,PRO_DESP_FONO2,PRO_DESP_FAX1,OT_ENTREGO,ULTIMA_OT) " & _
                                                              "VALUES ('" & connomt(Productor) & "','" & RutProd & "','" & connomt(Empresa) & "','" & _
                                                              connomt(Predio) & "','" & connomt(DireccionP) & "','" & connomt(ComunaP) & "','" & connomt(CiudadP) & "','" & _
                                                              RegionP & "','" & Fono1P & "','" & Fono2P & "','" & Fax1P & "','" & _
                                                              connomt(Remite) & "','" & connomt(razon) & "','" & Fono1F & "','" & Fono2F & "','" & _
                                                              Giro & "','" & DireccionF & "','" & ComunaF & "','" & CiudadF & "','" & _
                                                              connomt(Encarg) & "','" & F1Cob & "','" & F2Cob & "'," & RetiraxD & "," & _
                                                              FonoxD & "," & FaxxD & "," & CorreoxD & "," & BusxD & "," & OtroxD & ",'" & _
                                                              connomt(senores) & "','" & connomt(atencion) & "','" & connomt(DireccionD) & "','" & CasillaD & "','" & _
                                                              connomt(ComunaD) & "','" & connomt(CiudadD) & "','" & FechaD & "','" & Fono1D & "','" & _
                                                              Fono2D & "','" & Fax1D & "','" & Ot_Entrego & "'," & fila("OT_NUMERO") & ")"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                Catch ex As Exception
                    consulta_nota = "UPDATE PRODUCTOR_LABSYS SET PRO_PRODUCTOR='" & connomt(Productor) & "'," & _
                                                                                "PRO_RUT='" & RutProd & "'," & _
                                                                                "PRO_EMPRESA='" & connomt(Empresa) & "'," & _
                                                                                "PRO_PREDIO='" & connomt(Predio) & "'," & _
                                                                                "PRO_DIRECCION='" & connomt(DireccionP) & "'," & _
                                                                                "PRO_COMUNA='" & connomt(ComunaP) & "'," & _
                                                                                "PRO_CIUDAD='" & connomt(CiudadP) & "'," & _
                                                                                "PRO_REGION='" & RegionP & "'," & _
                                                                                "PRO_FONO1='" & Fono1P & "'," & _
                                                                                "PRO_FONO2='" & Fono2P & "'," & _
                                                                                "PRO_FAX1='" & Fax1P & "'," & _
                                                                                "PRO_FAX2='" & Fax2P & "'," & _
                                                                                "PRO_REMITE='" & connomt(Remite) & "'," & _
                                                                                "PRO_FAC_RSOCIAL='" & connomt(razon) & "'," & _
                                                                                "PRO_FAC_FONO1='" & Fono1F & "'," & _
                                                                                "PRO_FAC_FONO2='" & Fono2F & "'," & _
                                                                                "PRO_FAC_GIRO='" & connomt(Giro) & "'," & _
                                                                                "PRO_FAC_DIRECCION='" & connomt(DireccionF) & "'," & _
                                                                                "PRO_FAC_COMUNA='" & connomt(ComunaF) & "'," & _
                                                                                "PRO_FAC_CIUDAD='" & connomt(CiudadF) & "'," & _
                                                                                "PRO_FAC_ENCPAGO='" & connomt(Encarg) & "'," & _
                                                                                "PRO_FAC_F1PAGO='" & F1Cob & "'," & _
                                                                                "PRO_FAC_F2PAGO='" & F2Cob & "'," & _
                                                                                "PRO_DESP_POR_RETIRALAB=" & RetiraxD & "," & _
                                                                                "PRO_DESP_POR_FONO=" & FonoxD & "," & _
                                                                                "PRO_DESP_POR_FAX=" & FaxxD & "," & _
                                                                                "PRO_DESP_POR_CORREO=" & CorreoxD & "," & _
                                                                                "PRO_DESP_POR_BUS=" & BusxD & "," & _
                                                                                "PRO_DESP_POR_OTRO=" & OtroxD & "," & _
                                                                                "PRO_DESP_SENORES='" & connomt(senores) & "'," & _
                                                                                "PRO_DESP_ATENCION='" & connomt(atencion) & "'," & _
                                                                                "PRO_DESP_DIRECCION='" & connomt(DireccionD) & "'," & _
                                                                                "PRO_DESP_CASILLA='" & CasillaD & "'," & _
                                                                                "PRO_DESP_COMUNA='" & connomt(ComunaD) & "'," & _
                                                                                "PRO_DESP_CIUDAD='" & connomt(CiudadD) & "'," & _
                                                                                "PRO_DESP_FECHA='" & FechaD & "'," & _
                                                                                "PRO_DESP_FONO1='" & Fono1D & "'," & _
                                                                                "PRO_DESP_FONO2='" & Fono2D & "'," & _
                                                                                "PRO_DESP_FAX1='" & Fax1D & "'," & _
                                                                                "OT_ENTREGO='" & connomt(Ot_Entrego) & "'," & _
                                                                                "ULTIMA_OT=" & fila("OT_NUMERO") & _
                                                                                " WHERE PRO_PRODUCTOR='" & connomt(Productor) & "' and PRO_RUT='" & RutProd & "'"
                    Dim mycom As New SqlCommand(consulta_nota, con)
                    Dim myReader4 As SqlDataReader
                    myReader4 = mycom.ExecuteReader()
                    myReader4.Close()
                End Try
            End If
        Next
        con.Close()
        MsgBox("Terminado el traspaso")
    End Sub

    Private Function CaracSql(ByVal Texto As String) As String
        Dim g As Integer
        For g = 1 To Len(Texto)
            If Mid(Texto, g, 1) = "'" Or Mid(Texto, g, 1) = "," Then
                Mid(Texto, g, 1) = " "
            End If
        Next
        Return Texto
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim Muestrap As Integer = 4000
        Dim NumOt, CantMuestras, NumLabDes, NumLabHas As Integer
        Dim query As String
        Dim fila As DataRow
        Dim con As New SqlConnection(Conexion1)
        DbMan = New DbManager("TABLA_PARA_OT_CODIFICACION", Conexion1)
        Try
            query = "Select * from TABLA_PARA_OT_CODIFICACION"
            DbMan.Selecccionar(datos, query)
        Catch ex As Exception
        End Try
        CantMuestras = 0 : NumOt = 0
        con.Open()
        For Each fila In datos.Tables("TABLA_PARA_OT_CODIFICACION").Rows
            If NumOt <> 0 And NumOt <> fila("OT_NUMERO") Then
                query = "INSERT INTO OT_CODIFICACION (OT_NUMERO,TMU_CODIGO,OTC_NLAB_DESDE,ANA_CODIGO,ANA_ANALISIS," & _
                                            "OTC_CANT_MUESTRAS,OTC_NLAB_HASTA,OTC_PRECIOUN,OTC_PRECIONET) VALUES ( " & _
                            NumOt & "," & Muestrap & "," & NumLabDes & ",9999" & "," & _
                            "''," & CantMuestras & "," & NumLabHas & ",0,0)"

                Dim myCommand4 As New SqlCommand(query, con)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                Catch ex As Exception
                    MsgBox("Error en grabacion de Detalle (OT_Codificacion")
                End Try
                CantMuestras = 0
            End If
            NumOt = fila("OT_NUMERO")
            If CantMuestras = 0 Then NumLabDes = fila("NLAB")
            NumLabHas = fila("NLAB")
            CantMuestras = CantMuestras + 1
        Next
        con.Close()
        MsgBox("Terminado el traspaso")
    End Sub


    Private Function connomt(ByRef nomb As String) As String
        Dim lar, i, j As Integer
        Dim acumula As String
        lar = Len(nomb)
        acumula = "" : j = 0
        For i = 1 To lar
            If Mid(nomb, i, 4) = "S.A." Then acumula = acumula & "S.A." : Exit For
            If i = 1 Then acumula = UCase(Mid(nomb, 1, 1)) : GoTo continuar
            If j = 1 Then acumula = acumula & UCase(Mid(nomb, i, 1)) : j = 0 : GoTo continuar
            If Mid(nomb, i, 1) = " " Then acumula = acumula & " " : j = 1 : GoTo continuar
            acumula = acumula & LCase(Mid(nomb, i, 1))
continuar:
        Next
        nomb = acumula
        Return nomb
    End Function

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim query, Localidad, Comuna, Ciudad, Provincia, Region, Nombre_region As String
        Dim fila As DataRow
        Dim con As New SqlConnection(Conexion1)
        Dim con2 As New SqlConnection(Conexion1)

        DbMan = New DbManager("ORDEN_TRABAJO", Conexion1)
        Try
            query = "Select * from ORDEN_TRABAJO"
            DbMan.Selecccionar(datos, query)
        Catch ex As Exception
        End Try
        con.Open()
        con2.Open()
        'For Each fila In datos.Tables("ORDEN_TRABAJO").Rows
        '    If fila("OT_CIUDAD") = "" Then
        '        If fila("OT_COMUNA") <> "" And fila("OT_LOCALIDAD") = "" Then
        '            query = "Select LOCALIDAD,COMUNA,CIUDAD,PROVINCIA,REGION,REG_NOMBRE from LOCALIDAD where LOCALIDAD='" & CaracSql(fila("OT_COMUNA")) & "' AND REGION='" & CStr(CInt(fila("OT_REGION"))) & "'"
        '            Dim mycom As New SqlCommand(query, con)
        '            Dim myReader4 As SqlDataReader
        '            myReader4 = mycom.ExecuteReader()
        '            Try
        '                myReader4.Read()
        '                Localidad = myReader4.GetString(0)
        '                Comuna = myReader4.GetString(1)
        '                Ciudad = myReader4.GetString(2)
        '                Provincia = myreader4.GetString(3)
        '                myReader4.Close()
        '                query = "UPDATE ORDEN_TRABAJO SET OT_LOCALIDAD='" & Localidad & "'," & _
        '                                                  "OT_COMUNA='" & Comuna & "'," & _
        '                                                  "OT_CIUDAD='" & Ciudad & "'," & _
        '                                                  "OT_PROVINCIA='" & Provincia & "'" & _
        '                                                  " WHERE OT_NUMERO=" & fila("OT_NUMERO")
        '                Dim mycom2 As New SqlCommand(query, con2)
        '                mycom2.ExecuteNonQuery()

        '            Catch ex As Exception
        '                myReader4.Close()
        '            End Try

        '        End If
        '    End If
        'Next

        DbMan = New DbManager("PRODUCTOR_LABSYS", Conexion1)
        Try
            query = "Select * from PRODUCTOR_LABSYS"
            DbMan.Selecccionar(datos, query)
        Catch ex As Exception
        End Try
        For Each fila In datos.Tables("PRODUCTOR_LABSYS").Rows
            If fila("PRO_CIUDAD") = "" Then
                If fila("PRO_COMUNA") <> "" And fila("PRO_LOCALIDAD") = "" Then
                    query = "Select LOCALIDAD,COMUNA,CIUDAD,PROVINCIA,REGION,REG_NOMBRE from LOCALIDAD where LOCALIDAD='" & CaracSql(fila("PRO_COMUNA")) & "' AND REGION='" & CStr(CInt(fila("PRO_REGION"))) & "'"
                    Dim mycom As New SqlCommand(query, con)
                    Dim myReader4 As SqlDataReader
                    Try
                        myReader4 = mycom.ExecuteReader()
                    Catch ex As Exception
                    End Try

                    Try
                        myReader4.Read()
                        Localidad = myReader4.GetString(0)
                        Comuna = myReader4.GetString(1)
                        Ciudad = myReader4.GetString(2)
                        Provincia = myReader4.GetString(3)
                        myReader4.Close()
                        query = "UPDATE PRODUCTOR_LABSYS SET PRO_LOCALIDAD='" & Localidad & "'," & _
                                                          "PRO_COMUNA='" & Comuna & "'," & _
                                                          "PRO_CIUDAD='" & Ciudad & "'," & _
                                                          "PRO_PROVINCIA='" & Provincia & "'" & _
                                                          " WHERE PRO_PRODUCTOR='" & fila("PRO_PRODUCTOR") & "' AND PRO_RUT='" & fila("PRO_RUT") & "'"
                        Dim mycom2 As New SqlCommand(query, con2)
                        mycom2.ExecuteNonQuery()

                    Catch ex As Exception
                        myReader4.Close()
                    End Try
                End If
            End If
        Next

        con.Close()
        con2.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim query As String
        Dim DbMan As DbManager
        Dim datos As New DataSet
        Dim fila, filaM As DataRow
        Dim OO As Object

        DbMan = New DbManager("MFAC", Conexion1)
        query = "Select * from MFAC"
        DbMan.Selecccionar(datos, query)

        DbMan = New DbManager("MICO", Conexion1)
        query = "Select INFA from MICO"
        DbMan.Selecccionar(Cjto_Tablas1, query)

        For Each fila In datos.Tables("MFAC").Rows
            OO = fila("INFA")
            filaM = Cjto_Tablas1.Tables("MICO").Rows.Find(OO)
            If (filaM Is Nothing) = True Then
                MsgBox(fila("INFA"))
            End If
        Next
    End Sub
End Class
