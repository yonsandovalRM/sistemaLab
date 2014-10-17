Imports System.Data.SqlClient
Imports System.Data

Public Class CapaNegocio
    Public usuarioLabSys As String

    Public Function validar(ByVal usuario, ByVal clave)
        Dim cd, cd2 As New CapaDato
        Dim ds, ds2 As New Data.DataSet
        Dim claveDs As String = ""
        Dim mensaje As String = ""
       
        cd.Inicializar()
        cd.AgregarParametro("@usuario", usuario, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_validaUsuario")

        For Each dr As Data.DataRow In ds.Tables(0).Rows 'extraigo el primer campo

            claveDs = dr("PER_CLAVE").ToString
            sPermisos = dr("PER_PERMISO").ToString
            ViaImpresoraMatriz = dr("PER_IMPPUNTO").ToString
            ViaImpresoraLaser = dr("PER_IMPLASER").ToString
   
            If (clave = claveDs) Then
                F_Login.Hide()
                usuarioLabSys = usuario
                usuarioLG = usuario
                cd2.Inicializar()
                cd2.AgregarParametro("@usuario", usuarioLG, SqlDbType.VarChar)
                ds2 = cd2.EjecutarQuery("ys_DTE")



                papel = ds2.Tables(0).Rows(0).Item(0).ToString
                impresora_ot = ds2.Tables(0).Rows(0).Item(1).ToString


                F_Menu.ShowDialog()
            End If

        Next


        If claveDs = "" Then
            mensaje = "1"

        ElseIf clave <> claveDs Then
            mensaje = "2"

        End If

        Return mensaje

    End Function

    Public Function GuardaOT(ByVal Cotizacion As String, ByVal OCompra As String, ByVal FechaIngreso As DateTime, ByVal RutProductor As String, ByVal RutFactura As String, ByVal Productor As String, _
    ByVal Direccion As String, ByVal Empresa As String, ByVal Predio As String, ByVal Localidad As String, ByVal Comuna As String, ByVal Ciudad As String, _
    ByVal Provincia As String, ByVal Region As String, ByVal Fono1 As String, ByVal Fono2 As String, ByVal Celular1 As String, ByVal Celular2 As String, ByVal Fax1 As String, ByVal Fax2 As String, ByVal Email1 As String, _
    ByVal Email2 As String, ByVal Solicita As String, ByVal FonoSolicita1 As String, ByVal FonoSolicita2 As String, ByVal CelularSolicita1 As String, ByVal CelularSolicita2 As String, _
    ByVal FaxSolicita1 As String, ByVal FaxSolicita2 As String, ByVal EmailSolicita1 As String, ByVal EmailSolicita2 As String, ByVal Remite As String, ByVal FonoRemite1 As String, _
    ByVal FonoRemite2 As String, ByVal CelularRemite1 As String, ByVal CelularRemite2 As String, ByVal FaxRemite1 As String, ByVal FaxRemite2 As String, ByVal EmailRemite1 As String, _
    ByVal Email2Re As String, ByVal Senores As String, ByVal OtroDespacho As String, ByVal Casilla As String, ByVal FaxDespacho1 As String, ByVal FaxDespacho2 As String, ByVal Atencion As String, _
    ByVal CiudadDespacho As String, ByVal DireccionDespacho As String, ByVal FonoDespacho1 As String, ByVal FonoDespacho2 As String, ByVal EmailDespacho1 As String, ByVal EmailDespacho2 As String, _
    ByVal cbComunaDespacho As String, ByVal CelularDespacho1 As String, ByVal CelularDespacho2 As String, ByVal FechaDespacho As String, ByVal chRetiraLab As Boolean, _
    ByVal chAvisaFono As Boolean, ByVal chBus As Boolean, ByVal chCorreo As Boolean, ByVal chEmail As Boolean, ByVal chFax As Boolean, ByVal chOtro As Boolean, ByVal chUrgente As Boolean, _
    ByVal RazonSocial As String, ByVal FonoRS1 As String, ByVal FonoRS2 As String, ByVal EmailRS1 As String, ByVal EmailRS2 As String, ByVal Giro As String, ByVal DireccionRS As String, _
    ByVal CiudadRS As String, ByVal ComunaRS As String, ByVal EncargadoPago As String, ByVal FonoPagoRS1 As String, ByVal FonoPagoRS2 As String, ByVal ingreso As String)

        Dim cd As New CapaDato
        Dim retorno As Integer = 0
        Dim dsRetorno As New Data.DataSet
        With cd
            .Inicializar()

            Dim EstAna, EstPag, EstFac As String

            EstAna = "xA"
            EstPag = "Pte"
            EstFac = "xF"


            If Cotizacion = "" Then
                .AgregarParametro("@nCot", CDbl(0), SqlDbType.Float)
            Else

                .AgregarParametro("@nCot", CDbl(Cotizacion), SqlDbType.Float)
            End If

            .AgregarParametro("@Fingreso", FechaIngreso, SqlDbType.DateTime)
            .AgregarParametro("@RFacturacion", RutFactura, SqlDbType.NVarChar)
            'If (Me.TxtRutProd.Text) <> "" Then
            '    TxtRutProd.Text = Me.TxtRutProd.Text
            'Else
            '    TxtRutProd.Text = "1-9"
            'End If
            .AgregarParametro("@RutProd", RutProductor, SqlDbType.NVarChar)
            .AgregarParametro("@OTprod", Productor, SqlDbType.NVarChar)
            .AgregarParametro("@OTemp", Empresa, SqlDbType.NVarChar)
            .AgregarParametro("@OTpredio", Predio, SqlDbType.NVarChar)
            .AgregarParametro("@OTdireccion", Direccion, SqlDbType.NVarChar)
            .AgregarParametro("@OTlocalidad", Localidad, SqlDbType.NVarChar)
            .AgregarParametro("@OTcomuna", Comuna, SqlDbType.NVarChar)
            .AgregarParametro("@OTciudad", Ciudad, SqlDbType.NVarChar)
            .AgregarParametro("@OTprovincia", Provincia, SqlDbType.NVarChar)
            .AgregarParametro("@OTregion", Region, SqlDbType.NVarChar)
            .AgregarParametro("@OTf1", Fono1, SqlDbType.NVarChar)
            .AgregarParametro("@OTf2", Fono2, SqlDbType.NVarChar)
            .AgregarParametro("@OTcel1", Celular1, SqlDbType.NVarChar)
            .AgregarParametro("@OTcel2", Celular2, SqlDbType.NVarChar)
            .AgregarParametro("@OTfax1", Fax1, SqlDbType.NVarChar)
            .AgregarParametro("@OTfax2", Fax2, SqlDbType.NVarChar)
            .AgregarParametro("@OTem1", Email1, SqlDbType.NVarChar)
            .AgregarParametro("@OTem2", Email2, SqlDbType.NVarChar)

            'Ingreso parametros Remite
            .AgregarParametro("@Rem", Remite, SqlDbType.NVarChar)
            .AgregarParametro("@RemF1", FonoRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemF2", FonoRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemCel1", CelularRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemCel2", CelularRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemFax1", FaxRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemFax2", FaxRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemEm1", EmailRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemEm2", Email2Re, SqlDbType.NVarChar)

            'Ingreso Parametros Solicita
            .AgregarParametro("@Sol", Solicita, SqlDbType.NVarChar)
            .AgregarParametro("@SolF1", FonoSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolF2", FonoSolicita2, SqlDbType.NVarChar)
            .AgregarParametro("@SolCel1", CelularSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolCel2", CelularSolicita2, SqlDbType.NVarChar)
            .AgregarParametro("@SolFax1", FaxSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolFax2", FaxSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolEm1", EmailSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolEm2", EmailSolicita2, SqlDbType.NVarChar)

            'Ingreso Parametros Factura
            .AgregarParametro("@FacRSocial", RazonSocial, SqlDbType.NVarChar)
            .AgregarParametro("@FacF1", FonoRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacF2", FonoRS2, SqlDbType.NVarChar)
            .AgregarParametro("@FacGiro", Giro, SqlDbType.NVarChar)
            .AgregarParametro("@FacDireccion", DireccionRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacComuna", ComunaRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacCiudad", CiudadRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacEncPago", EncargadoPago, SqlDbType.NVarChar)
            .AgregarParametro("@FacF1Pago", FonoPagoRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacF2Pago", FonoPagoRS2, SqlDbType.NVarChar)
            .AgregarParametro("@FacObsPago", "", SqlDbType.NVarChar)
            .AgregarParametro("@FacEmail1", EmailRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacEmail2", EmailRS2, SqlDbType.NVarChar)
            '.AgregarParametro("@FacConPago", CBCond_Pago.Text, SqlDbType.NVarChar)

            'Parametros Despacho
            .AgregarParametro("@DespRetiraLab", chRetiraLab, SqlDbType.Bit)
            .AgregarParametro("@DespFono", chAvisaFono, SqlDbType.Bit)
            .AgregarParametro("@DespFax", chFax, SqlDbType.Bit)
            .AgregarParametro("@DespEmail", chEmail, SqlDbType.Bit)
            .AgregarParametro("@DespCorreo", chCorreo, SqlDbType.Bit)
            .AgregarParametro("@DespBus", chBus, SqlDbType.Bit)
            .AgregarParametro("@DespOtro", chOtro, SqlDbType.Bit)
            .AgregarParametro("@DespGlosa", OtroDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespSen", Senores, SqlDbType.NVarChar)
            .AgregarParametro("@DespAtencion", Atencion, SqlDbType.NVarChar)
            .AgregarParametro("@DespDireccion", DireccionDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespCasilla", Casilla, SqlDbType.NVarChar)
            .AgregarParametro("@DespComuna", cbComunaDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespCiudad", CiudadDespacho, SqlDbType.NVarChar)

            'If IsDBNull(TxtFechaDespacho.Text) = True Then TxtFechaDespacho.Text = ""
            'If TxtFechaDespacho.Text = "" Then TxtFechaDespacho.Text = "01-01-1901"
            .AgregarParametro("@DespFecha", FechaDespacho, SqlDbType.DateTime)
            .AgregarParametro("@DespF1", FonoDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespF2", FonoDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespCel1", CelularDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespCel2", CelularDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespFax1", FaxDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespFax2", FaxDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespEm1", EmailDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespEm2", EmailDespacho2, SqlDbType.NVarChar)

            'Parametros Observaciones
            'Parametros Valor OT
            .AgregarParametro("@DigPor", usuarioLG, SqlDbType.NVarChar)
            .AgregarParametro("@HoraIng", Date.Today, SqlDbType.DateTime)

            'estados

            .AgregarParametro("@DespUrg", chUrgente, SqlDbType.Bit)
            .AgregarParametro("@IngPor", ingreso, SqlDbType.NVarChar)
            .AgregarParametro("@EstAna", EstAna, SqlDbType.NVarChar)

            .AgregarParametro("@EstPag", EstPag, SqlDbType.NVarChar)
            .AgregarParametro("@EstFac", EstFac, SqlDbType.NVarChar)




            dsRetorno = .EjecutarQuery("ls_IngresoOrdenTrabajo")

        End With

        Return dsRetorno.Tables.Item(0).Rows.Item(0).ItemArray(0)
    End Function

    Public Function NumeroLaboratorio(ByVal analisis As String)
        Dim cd As New CapaDato
        Dim ds As New Data.DataSet
        Dim nLab As String = 0

        cd.Inicializar()
        cd.AgregarParametro("@TipoMuestra", analisis, SqlDbType.Int)
        nLab = cd.EjecutarEscalar("usp_SelectUltimoNlab")

        
        Return nLab
    End Function

    Public Function ReservaNlab(ByVal numeroOT As Integer, ByVal analisis As Integer, ByVal codigo As Integer, ByVal descripcion As String, _
    ByVal nLabDesde As String, ByVal nLabHasta As String, ByVal cantidad As Integer, ByVal valor As Integer, ByVal neto As Integer)
        Dim cd As New CapaDato
        Dim dsRetorno As Boolean
        Dim nLab As String = 0

        cd.Inicializar()
        cd.AgregarParametro("@numeroOT", numeroOT, SqlDbType.Int)
        cd.AgregarParametro("@analisis", analisis, SqlDbType.Int)
        cd.AgregarParametro("@codigo", codigo, SqlDbType.Float)
        cd.AgregarParametro("@descripcion", descripcion, SqlDbType.NVarChar)
        cd.AgregarParametro("@nLabDesde", nLabDesde, SqlDbType.Int)
        cd.AgregarParametro("@nLabHasta", nLabHasta, SqlDbType.Int)
        cd.AgregarParametro("@cantidad", cantidad, SqlDbType.Int)
        cd.AgregarParametro("@valor", valor, SqlDbType.Int)
        cd.AgregarParametro("@neto", neto, SqlDbType.Int)

        dsRetorno = cd.EjecutarAccion("ls_ingresoNlab")


        Return nLab
    End Function

    Public Function GrabaAntecedentesFoliar(ByVal Orden_Trabajo As Integer, ByVal NumUpLab As Integer, _
    ByVal Predio As String, ByVal localidad As String, ByVal especie As String, ByVal variedad As String, _
    ByVal tejido As String, ByVal edad As String, ByVal cuartel1 As String, ByVal cuartel2 As String, ByVal rto As String, _
    ByVal carga As String, ByVal vigor As String, ByVal densidad As String, ByVal apariencia As String, _
    ByVal observacion As String, ByVal recomendacion As Boolean, ByVal muestreador As String, ByVal fechaMuestreo As String)

        Dim cd As New CapaDato

        With cd

            .Inicializar()
            .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLabFoliar", NumUpLab, SqlDbType.Int)
            .AgregarParametro("@PredioFoliar", Predio, SqlDbType.NVarChar)
            .AgregarParametro("@LocFoliar", localidad, SqlDbType.NVarChar)
            .AgregarParametro("@EspFoliar", especie, SqlDbType.NVarChar)
            .AgregarParametro("@VarFoliar", variedad, SqlDbType.NVarChar)
            .AgregarParametro("@TejFoliar", tejido, SqlDbType.NVarChar)
            .AgregarParametro("@EdadFoliar", edad, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel1Foliar", cuartel1, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel2Foliar", cuartel2, SqlDbType.NVarChar)
            .AgregarParametro("@strRtoAnt", rto, SqlDbType.NVarChar)
            .AgregarParametro("@strCarga", carga, SqlDbType.NVarChar)
            .AgregarParametro("@strVigor", vigor, SqlDbType.NVarChar)
            .AgregarParametro("@strDensidad", densidad, SqlDbType.NVarChar)
            .AgregarParametro("@strApa", apariencia, SqlDbType.NVarChar)
            .AgregarParametro("@ObsFoliar", observacion, SqlDbType.NVarChar)
            .AgregarParametro("@strReq", recomendacion, SqlDbType.Bit)
            .AgregarParametro("@MuestreadorFoliar", muestreador, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreoFoliar", fechaMuestreo, SqlDbType.DateTime)
            .EjecutarEscalar("ls_GrabaAntecedentesFoliar")

        End With

        Return 0

    End Function

    Public Function GrabaAntecedentesTejidos(ByVal Orden_Trabajo As Integer, ByVal NumUpLab As Integer, _
ByVal Predio As String, ByVal localidad As String, ByVal especie As String, ByVal variedad As String, _
ByVal tejido As String, ByVal edad As String, ByVal cuartel1 As String, ByVal cuartel2 As String, ByVal rto As String, _
ByVal carga As String, ByVal vigor As String, ByVal densidad As String, ByVal apariencia As String, _
ByVal observacion As String, ByVal recomendacion As Boolean, ByVal muestreador As String, ByVal fechaMuestreo As String)

        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLab", NumUpLab, SqlDbType.Int)
            .AgregarParametro("@Predio", Predio, SqlDbType.NVarChar)
            .AgregarParametro("@Loc", localidad, SqlDbType.NVarChar)
            .AgregarParametro("@Esp", especie, SqlDbType.NVarChar)
            .AgregarParametro("@Var", variedad, SqlDbType.NVarChar)
            .AgregarParametro("@Tej", tejido, SqlDbType.NVarChar)
            .AgregarParametro("@Edad", edad, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel1", cuartel1, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel2", cuartel2, SqlDbType.NVarChar)
            .AgregarParametro("@strRtoAnt", rto, SqlDbType.NVarChar)
            .AgregarParametro("@strCarga", carga, SqlDbType.NVarChar)
            .AgregarParametro("@strVigor", vigor, SqlDbType.NVarChar)
            .AgregarParametro("@strDensidad", densidad, SqlDbType.NVarChar)
            .AgregarParametro("@strApa", apariencia, SqlDbType.NVarChar)
            .AgregarParametro("@Obs", observacion, SqlDbType.NVarChar)
            .AgregarParametro("@strReq", recomendacion, SqlDbType.Bit)
            .AgregarParametro("@Muestreador", muestreador, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreo", fechaMuestreo, SqlDbType.DateTime)
            .EjecutarEscalar("ls_GrabaAntecedentesTejidos")
        End With
        Return 0

    End Function

    Public Function GrabaAntecedentesFertOrg(ByVal Orden_Trabajo As Integer, ByVal NumUpLab As Integer, _
ByVal Predio As String, ByVal localidad As String, ByVal observacion As String, ByVal muestreador As String, _
 ByVal fechaMuestreo As String, ByVal id1 As String, ByVal id2 As String, ByVal tipoFert As String)

        Dim cd As New CapaDato

        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLab", NumUpLab, SqlDbType.Int)
            .AgregarParametro("@Predio", Predio, SqlDbType.NVarChar)
            .AgregarParametro("@Loc", localidad, SqlDbType.NVarChar)
            .AgregarParametro("@Obs", observacion, SqlDbType.NVarChar)
            .AgregarParametro("@Muestreador", muestreador, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreo", fechaMuestreo, SqlDbType.DateTime)
            .AgregarParametro("@id1", id1, SqlDbType.NVarChar)
            .AgregarParametro("@id2", id2, SqlDbType.NVarChar)
            .AgregarParametro("@tipoFert", tipoFert, SqlDbType.NVarChar)
            .EjecutarEscalar("ls_GrabaAntecedentesFertOrg")
        End With

        Return 0

    End Function

    Public Function GrabaAntecedentesFertQui(ByVal Orden_Trabajo As Integer, ByVal NumUpLab As Integer, _
ByVal Predio As String, ByVal localidad As String, ByVal observacion As String, ByVal muestreador As String, _
ByVal fechaMuestreo As String, ByVal id1 As String, ByVal id2 As String, ByVal tipoFert As String)

        Dim cd As New CapaDato

        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLab", NumUpLab, SqlDbType.Int)
            .AgregarParametro("@Predio", Predio, SqlDbType.NVarChar)
            .AgregarParametro("@Loc", localidad, SqlDbType.NVarChar)
            .AgregarParametro("@Obs", observacion, SqlDbType.NVarChar)
            .AgregarParametro("@Muestreador", muestreador, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreo", fechaMuestreo, SqlDbType.DateTime)
            .AgregarParametro("@id1", id1, SqlDbType.NVarChar)
            .AgregarParametro("@id2", id2, SqlDbType.NVarChar)
            .AgregarParametro("@tipoFert", tipoFert, SqlDbType.NVarChar)
            .EjecutarEscalar("ls_GrabaAntecedentesFertQui")
        End With

        Return 0

    End Function

    Public Function datosAntecedentes(ByVal tmu As Integer, ByVal numeroOT As Integer, ByVal nlab As Integer)

        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        cd.AgregarParametro("@not", numeroOT, SqlDbType.Int)
        cd.AgregarParametro("@tmu", tmu, SqlDbType.Int)
        cd.AgregarParametro("@nlab", nlab, SqlDbType.Int)
        ds = cd.EjecutarQuery("ls_datosAntecedentes")
        Return ds

    End Function

    Public Function ObtieneProductor()
        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        ds = cd.EjecutarQuery("ls_productor")

        Return ds

    End Function

    Public Function ObtieneEmpresa()
        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        ds = cd.EjecutarQuery("ls_empresa")

        Return ds

    End Function

    Public Function revisaDigitacionAntecedentes(ByVal numeroOT As Integer)
        Dim cd As New CapaDato
        Dim retorno As Integer

        With cd
            .Inicializar()
            .AgregarParametro("@NumOt", numeroOT, SqlDbType.Int)
            retorno = .EjecutarEscalar("usp_RevisaDigitacionAntecedentes")

        End With
        Return retorno

    End Function

    Public Function GuardaOTFinalInicio(ByVal numeroOT As Integer, ByVal Cotizacion As String, ByVal OCompra As String, ByVal FechaIngreso As DateTime, ByVal RutProductor As String, ByVal RutFactura As String, ByVal Productor As String, _
ByVal Direccion As String, ByVal Empresa As String, ByVal Predio As String, ByVal Localidad As String, ByVal Comuna As String, ByVal Ciudad As String, _
ByVal Provincia As String, ByVal Region As String, ByVal Fono1 As String, ByVal Fono2 As String, ByVal Celular1 As String, ByVal Celular2 As String, ByVal Fax1 As String, ByVal Fax2 As String, ByVal Email1 As String, _
ByVal Email2 As String, ByVal Solicita As String, ByVal FonoSolicita1 As String, ByVal FonoSolicita2 As String, ByVal CelularSolicita1 As String, ByVal CelularSolicita2 As String, _
ByVal FaxSolicita1 As String, ByVal FaxSolicita2 As String, ByVal EmailSolicita1 As String, ByVal EmailSolicita2 As String, ByVal Remite As String, ByVal FonoRemite1 As String, _
ByVal FonoRemite2 As String, ByVal CelularRemite1 As String, ByVal CelularRemite2 As String, ByVal FaxRemite1 As String, ByVal FaxRemite2 As String, ByVal EmailRemite1 As String, _
ByVal Email2Re As String, ByVal Senores As String, ByVal OtroDespacho As String, ByVal Casilla As String, ByVal FaxDespacho1 As String, ByVal FaxDespacho2 As String, ByVal Atencion As String, _
ByVal CiudadDespacho As String, ByVal DireccionDespacho As String, ByVal FonoDespacho1 As String, ByVal FonoDespacho2 As String, ByVal EmailDespacho1 As String, ByVal EmailDespacho2 As String, _
ByVal cbComunaDespacho As String, ByVal CelularDespacho1 As String, ByVal CelularDespacho2 As String, ByVal FechaDespacho As String, ByVal chRetiraLab As Boolean, _
ByVal chAvisaFono As Boolean, ByVal chBus As Boolean, ByVal chCorreo As Boolean, ByVal chEmail As Boolean, ByVal chFax As Boolean, ByVal chOtro As Boolean, ByVal chUrgente As Boolean, _
ByVal RazonSocial As String, ByVal FonoRS1 As String, ByVal FonoRS2 As String, ByVal EmailRS1 As String, ByVal EmailRS2 As String, ByVal Giro As String, ByVal DireccionRS As String, _
ByVal CiudadRS As String, ByVal ComunaRS As String, ByVal EncargadoPago As String, ByVal FonoPagoRS1 As String, ByVal FonoPagoRS2 As String, ByVal ingreso As String, _
ByVal Observaciones As String, ByVal Aviso As String, ByVal SubTotalRe As String, ByVal NetoRe As String, ByVal IvaRe As String, ByVal DescuentoRe As String, ByVal Peso As String, _
ByVal CantidadMuestreo As String, ByVal ValorRe As String, ByVal MuestreoRe As String, ByVal Abono As String, ByVal TotalRe As String, ByVal cheque As String, ByVal efectivo As String, _
ByVal condPago As String, ByVal EstAna As String, ByVal EstPag As String, ByVal EstFac As String)

        Dim cd As New CapaDato
        Dim retorno As Integer = 0
        Dim dsRetorno As New Data.DataSet
        With cd
            .Inicializar()



            .AgregarParametro("@numeroOt", CInt(numeroOT), SqlDbType.Int)

            If Cotizacion = "" Then
                .AgregarParametro("@nCot", CDbl(0), SqlDbType.Float)
            Else
                .AgregarParametro("@nCot", CDbl(Cotizacion), SqlDbType.Float)
            End If

            .AgregarParametro("@Fingreso", FechaIngreso, SqlDbType.DateTime)
            .AgregarParametro("@RFacturacion", RutFactura, SqlDbType.NVarChar)

            .AgregarParametro("@RutProd", RutProductor, SqlDbType.NVarChar)
            .AgregarParametro("@OTprod", Productor, SqlDbType.NVarChar)
            .AgregarParametro("@OTemp", Empresa, SqlDbType.NVarChar)
            .AgregarParametro("@OTpredio", Predio, SqlDbType.NVarChar)
            .AgregarParametro("@OTdireccion", Direccion, SqlDbType.NVarChar)
            .AgregarParametro("@OTlocalidad", Localidad, SqlDbType.NVarChar)
            .AgregarParametro("@OTcomuna", Comuna, SqlDbType.NVarChar)
            .AgregarParametro("@OTciudad", Ciudad, SqlDbType.NVarChar)
            .AgregarParametro("@OTprovincia", Provincia, SqlDbType.NVarChar)
            .AgregarParametro("@OTregion", Region, SqlDbType.NVarChar)
            .AgregarParametro("@OTf1", Fono1, SqlDbType.NVarChar)
            .AgregarParametro("@OTf2", Fono2, SqlDbType.NVarChar)
            .AgregarParametro("@OTcel1", Celular1, SqlDbType.NVarChar)
            .AgregarParametro("@OTcel2", Celular2, SqlDbType.NVarChar)
            .AgregarParametro("@OTfax1", Fax1, SqlDbType.NVarChar)
            .AgregarParametro("@OTfax2", Fax2, SqlDbType.NVarChar)
            .AgregarParametro("@OTem1", Email1, SqlDbType.NVarChar)
            .AgregarParametro("@OTem2", Email2, SqlDbType.NVarChar)

            'Ingreso parametros Remite
            .AgregarParametro("@Rem", Remite, SqlDbType.NVarChar)
            .AgregarParametro("@RemF1", FonoRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemF2", FonoRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemCel1", CelularRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemCel2", CelularRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemFax1", FaxRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemFax2", FaxRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemEm1", EmailRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemEm2", Email2Re, SqlDbType.NVarChar)

            'Ingreso Parametros Solicita
            .AgregarParametro("@Sol", Solicita, SqlDbType.NVarChar)
            .AgregarParametro("@SolF1", FonoSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolF2", FonoSolicita2, SqlDbType.NVarChar)
            .AgregarParametro("@SolCel1", CelularSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolCel2", CelularSolicita2, SqlDbType.NVarChar)
            .AgregarParametro("@SolFax1", FaxSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolFax2", FaxSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolEm1", EmailSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolEm2", EmailSolicita2, SqlDbType.NVarChar)

            'Ingreso Parametros Factura
            .AgregarParametro("@FacRSocial", RazonSocial, SqlDbType.NVarChar)
            .AgregarParametro("@FacF1", FonoRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacF2", FonoRS2, SqlDbType.NVarChar)
            .AgregarParametro("@FacGiro", Giro, SqlDbType.NVarChar)
            .AgregarParametro("@FacDireccion", DireccionRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacComuna", ComunaRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacCiudad", CiudadRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacEncPago", EncargadoPago, SqlDbType.NVarChar)
            .AgregarParametro("@FacF1Pago", FonoPagoRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacF2Pago", FonoPagoRS2, SqlDbType.NVarChar)
            .AgregarParametro("@FacObsPago", "", SqlDbType.NVarChar)
            .AgregarParametro("@FacEmail1", EmailRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacEmail2", EmailRS2, SqlDbType.NVarChar)
            '  .AgregarParametro("@FacConPago", condPago, SqlDbType.NVarChar)

            'Parametros Despacho
            .AgregarParametro("@DespRetiraLab", chRetiraLab, SqlDbType.Bit)
            .AgregarParametro("@DespFono", chAvisaFono, SqlDbType.Bit)
            .AgregarParametro("@DespFax", chFax, SqlDbType.Bit)
            .AgregarParametro("@DespEmail", chEmail, SqlDbType.Bit)
            .AgregarParametro("@DespCorreo", chCorreo, SqlDbType.Bit)
            .AgregarParametro("@DespBus", chBus, SqlDbType.Bit)
            .AgregarParametro("@DespOtro", chOtro, SqlDbType.Bit)
            .AgregarParametro("@DespGlosa", OtroDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespSen", Senores, SqlDbType.NVarChar)
            .AgregarParametro("@DespAtencion", Atencion, SqlDbType.NVarChar)
            .AgregarParametro("@DespDireccion", DireccionDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespCasilla", Casilla, SqlDbType.NVarChar)
            .AgregarParametro("@DespComuna", cbComunaDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespCiudad", CiudadDespacho, SqlDbType.NVarChar)

            If IsDBNull(FechaDespacho) = True Then FechaDespacho = ""
            If FechaDespacho = "" Then FechaDespacho = "01-01-1901"
            .AgregarParametro("@DespFecha", FechaDespacho, SqlDbType.DateTime)
            .AgregarParametro("@DespF1", FonoDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespF2", FonoDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespCel1", CelularDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespCel2", CelularDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespFax1", FaxDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespFax2", FaxDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespEm1", EmailDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespEm2", EmailDespacho2, SqlDbType.NVarChar)

            'Parametros Observaciones
            'Parametros Valor OT
            '  .AgregarParametro("@Observaciones", Observaciones, SqlDbType.NVarChar)
            ' 

            'Traer el usuario del sistema
            .AgregarParametro("@DigPor", usuarioLG, SqlDbType.NVarChar)
            .AgregarParametro("@HoraIng", Format(Date.Today, "hh:mm"), SqlDbType.DateTime)
            .AgregarParametro("@IngPor", ingreso, SqlDbType.NVarChar)
            If Aviso <> "" Then
                '    .AgregarParametro("@FactPend", 1, SqlDbType.Int)

            Else
                '   .AgregarParametro("@FactPend", 0, SqlDbType.Int)
            End If
            'ByVal Observaciones As String, ByVal Aviso As String

            'If SubTotalRe = "" Then SubTotalRe = 0
            'If NetoRe = "" Then NetoRe = 0
            'If IvaRe = "" Then IvaRe = 0
            'If DescuentoRe = "" Then DescuentoRe = 0
            'If Peso = "" Then Peso = 0
            'If CantidadMuestreo = "" Then CantidadMuestreo = 0
            'If ValorRe = "" Then ValorRe = 0
            'If MuestreoRe = "" Then MuestreoRe = 0
            'If Abono = "" Then Abono = 0
            'If TotalRe = "" Then TotalRe = 0
            '.AgregarParametro("@SubTotal", CInt(SubTotalRe), SqlDbType.Int)
            '.AgregarParametro("@Neto", CInt(NetoRe), SqlDbType.Int)
            '.AgregarParametro("@Iva", CInt(IvaRe), SqlDbType.Int)
            '.AgregarParametro("@DescuentoPor", CDbl(DescuentoRe), SqlDbType.Float)
            '.AgregarParametro("@DescuentoPesos", CInt(Peso), SqlDbType.Int)
            '.AgregarParametro("@MuestreoCant", CInt(CantidadMuestreo), SqlDbType.Int)
            '.AgregarParametro("@MuestreoPrecUni", CInt(ValorRe), SqlDbType.Int)
            '.AgregarParametro("@Muestreo", CInt(MuestreoRe), SqlDbType.Int)
            '.AgregarParametro("@Abono", CInt(Abono), SqlDbType.Int)
            'estados
            'If (cheque = "False" And efectivo = "False") Then .AgregarParametro("@AbonoCon", 0, SqlDbType.Int)
            'If efectivo = "True" Then .AgregarParametro("@AbonoCon", 2, SqlDbType.Int)
            'If cheque = "True" Then .AgregarParametro("@AbonoCon", 1, SqlDbType.Int)
            '.AgregarParametro("@Total", CInt(TotalRe), SqlDbType.Int)


            .AgregarParametro("@EstAna", EstAna, SqlDbType.NVarChar)
            .AgregarParametro("@EstPag", EstPag, SqlDbType.NVarChar)
            .AgregarParametro("@EstFac", EstFac, SqlDbType.NVarChar)
            '.AgregarParametro("@DespUrg", chUrgente, SqlDbType.Bit)

            If OCompra = "" Then OCompra = 0
            .AgregarParametro("@NOC", OCompra, SqlDbType.NVarChar)


            retorno = .EjecutarEscalar("ls_IngresoOrdenTrabajo")


        End With

        Return retorno

    End Function

    Public Function GuardaOTFinal(ByVal numeroOT As Integer, ByVal Cotizacion As String, ByVal OCompra As String, ByVal FechaIngreso As DateTime, ByVal RutProductor As String, ByVal RutFactura As String, ByVal Productor As String, _
ByVal Direccion As String, ByVal Empresa As String, ByVal Predio As String, ByVal Localidad As String, ByVal Comuna As String, ByVal Ciudad As String, _
ByVal Provincia As String, ByVal Region As String, ByVal Fono1 As String, ByVal Fono2 As String, ByVal Celular1 As String, ByVal Celular2 As String, ByVal Fax1 As String, ByVal Fax2 As String, ByVal Email1 As String, _
ByVal Email2 As String, ByVal Solicita As String, ByVal FonoSolicita1 As String, ByVal FonoSolicita2 As String, ByVal CelularSolicita1 As String, ByVal CelularSolicita2 As String, _
ByVal FaxSolicita1 As String, ByVal FaxSolicita2 As String, ByVal EmailSolicita1 As String, ByVal EmailSolicita2 As String, ByVal Remite As String, ByVal FonoRemite1 As String, _
ByVal FonoRemite2 As String, ByVal CelularRemite1 As String, ByVal CelularRemite2 As String, ByVal FaxRemite1 As String, ByVal FaxRemite2 As String, ByVal EmailRemite1 As String, _
ByVal Email2Re As String, ByVal Senores As String, ByVal OtroDespacho As String, ByVal Casilla As String, ByVal FaxDespacho1 As String, ByVal FaxDespacho2 As String, ByVal Atencion As String, _
ByVal CiudadDespacho As String, ByVal DireccionDespacho As String, ByVal FonoDespacho1 As String, ByVal FonoDespacho2 As String, ByVal EmailDespacho1 As String, ByVal EmailDespacho2 As String, _
ByVal cbComunaDespacho As String, ByVal CelularDespacho1 As String, ByVal CelularDespacho2 As String, ByVal FechaDespacho As String, ByVal chRetiraLab As Boolean, _
ByVal chAvisaFono As Boolean, ByVal chBus As Boolean, ByVal chCorreo As Boolean, ByVal chEmail As Boolean, ByVal chFax As Boolean, ByVal chOtro As Boolean, ByVal chUrgente As Boolean, _
ByVal RazonSocial As String, ByVal FonoRS1 As String, ByVal FonoRS2 As String, ByVal EmailRS1 As String, ByVal EmailRS2 As String, ByVal Giro As String, ByVal DireccionRS As String, _
ByVal CiudadRS As String, ByVal ComunaRS As String, ByVal EncargadoPago As String, ByVal FonoPagoRS1 As String, ByVal FonoPagoRS2 As String, ByVal ingreso As String, _
ByVal Observaciones As String, ByVal Aviso As String, ByVal SubTotalRe As String, ByVal NetoRe As String, ByVal IvaRe As String, ByVal DescuentoRe As String, ByVal Peso As String, _
ByVal CantidadMuestreo As String, ByVal ValorRe As String, ByVal MuestreoRe As String, ByVal Abono As String, ByVal TotalRe As String, ByVal cheque As String, ByVal efectivo As String, _
    ByVal condPago As String, ByVal EstAna As String, ByVal EstPag As String, ByVal EstFac As String)

        Dim cd As New CapaDato
        Dim retorno As Integer = 0
        Dim dsRetorno As New Data.DataSet
        With cd
            .Inicializar()



            .AgregarParametro("@nOt", CInt(numeroOT), SqlDbType.Int)

            If Cotizacion = "" Then
                .AgregarParametro("@nCot", CDbl(0), SqlDbType.Float)
            Else
                .AgregarParametro("@nCot", CDbl(Cotizacion), SqlDbType.Float)
            End If

            .AgregarParametro("@Fingreso", FechaIngreso, SqlDbType.DateTime)
            .AgregarParametro("@RFacturacion", RutFactura, SqlDbType.NVarChar)

            .AgregarParametro("@RutProd", RutProductor, SqlDbType.NVarChar)
            .AgregarParametro("@OTprod", Productor, SqlDbType.NVarChar)
            .AgregarParametro("@OTemp", Empresa, SqlDbType.NVarChar)
            .AgregarParametro("@OTpredio", Predio, SqlDbType.NVarChar)
            .AgregarParametro("@OTdireccion", Direccion, SqlDbType.NVarChar)
            .AgregarParametro("@OTlocalidad", Localidad, SqlDbType.NVarChar)
            .AgregarParametro("@OTcomuna", Comuna, SqlDbType.NVarChar)
            .AgregarParametro("@OTciudad", Ciudad, SqlDbType.NVarChar)
            .AgregarParametro("@OTprovincia", Provincia, SqlDbType.NVarChar)
            .AgregarParametro("@OTregion", Region, SqlDbType.NVarChar)
            .AgregarParametro("@OTf1", Fono1, SqlDbType.NVarChar)
            .AgregarParametro("@OTf2", Fono2, SqlDbType.NVarChar)
            .AgregarParametro("@OTcel1", Celular1, SqlDbType.NVarChar)
            .AgregarParametro("@OTcel2", Celular2, SqlDbType.NVarChar)
            .AgregarParametro("@OTfax1", Fax1, SqlDbType.NVarChar)
            .AgregarParametro("@OTfax2", Fax2, SqlDbType.NVarChar)
            .AgregarParametro("@OTem1", Email1, SqlDbType.NVarChar)
            .AgregarParametro("@OTem2", Email2, SqlDbType.NVarChar)

            'Ingreso parametros Remite
            .AgregarParametro("@Rem", Remite, SqlDbType.NVarChar)
            .AgregarParametro("@RemF1", FonoRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemF2", FonoRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemCel1", CelularRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemCel2", CelularRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemFax1", FaxRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemFax2", FaxRemite2, SqlDbType.NVarChar)
            .AgregarParametro("@RemEm1", EmailRemite1, SqlDbType.NVarChar)
            .AgregarParametro("@RemEm2", Email2Re, SqlDbType.NVarChar)

            'Ingreso Parametros Solicita
            .AgregarParametro("@Sol", Solicita, SqlDbType.NVarChar)
            .AgregarParametro("@SolF1", FonoSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolF2", FonoSolicita2, SqlDbType.NVarChar)
            .AgregarParametro("@SolCel1", CelularSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolCel2", CelularSolicita2, SqlDbType.NVarChar)
            .AgregarParametro("@SolFax1", FaxSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolFax2", FaxSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolEm1", EmailSolicita1, SqlDbType.NVarChar)
            .AgregarParametro("@SolEm2", EmailSolicita2, SqlDbType.NVarChar)

            'Ingreso Parametros Factura
            .AgregarParametro("@FacRSocial", RazonSocial, SqlDbType.NVarChar)
            .AgregarParametro("@FacF1", FonoRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacF2", FonoRS2, SqlDbType.NVarChar)
            .AgregarParametro("@FacGiro", Giro, SqlDbType.NVarChar)
            .AgregarParametro("@FacDireccion", DireccionRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacComuna", ComunaRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacCiudad", CiudadRS, SqlDbType.NVarChar)
            .AgregarParametro("@FacEncPago", EncargadoPago, SqlDbType.NVarChar)
            .AgregarParametro("@FacF1Pago", FonoPagoRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacF2Pago", FonoPagoRS2, SqlDbType.NVarChar)
            .AgregarParametro("@FacObsPago", "", SqlDbType.NVarChar)
            .AgregarParametro("@FacEmail1", EmailRS1, SqlDbType.NVarChar)
            .AgregarParametro("@FacEmail2", EmailRS2, SqlDbType.NVarChar)
            .AgregarParametro("@FacConPago", condPago, SqlDbType.NVarChar)

            'Parametros Despacho
            .AgregarParametro("@DespRetiraLab", chRetiraLab, SqlDbType.Bit)
            .AgregarParametro("@DespFono", chAvisaFono, SqlDbType.Bit)
            .AgregarParametro("@DespFax", chFax, SqlDbType.Bit)
            .AgregarParametro("@DespEmail", chEmail, SqlDbType.Bit)
            .AgregarParametro("@DespCorreo", chCorreo, SqlDbType.Bit)
            .AgregarParametro("@DespBus", chBus, SqlDbType.Bit)
            .AgregarParametro("@DespOtro", chOtro, SqlDbType.Bit)
            .AgregarParametro("@DespGlosa", OtroDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespSen", Senores, SqlDbType.NVarChar)
            .AgregarParametro("@DespAtencion", Atencion, SqlDbType.NVarChar)
            .AgregarParametro("@DespDireccion", DireccionDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespCasilla", Casilla, SqlDbType.NVarChar)
            .AgregarParametro("@DespComuna", cbComunaDespacho, SqlDbType.NVarChar)
            .AgregarParametro("@DespCiudad", CiudadDespacho, SqlDbType.NVarChar)

            If IsDBNull(FechaDespacho) = True Then FechaDespacho = ""
            If FechaDespacho = "" Then FechaDespacho = "01-01-1901"
            .AgregarParametro("@DespFecha", FechaDespacho, SqlDbType.DateTime)
            .AgregarParametro("@DespF1", FonoDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespF2", FonoDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespCel1", CelularDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespCel2", CelularDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespFax1", FaxDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespFax2", FaxDespacho2, SqlDbType.NVarChar)
            .AgregarParametro("@DespEm1", EmailDespacho1, SqlDbType.NVarChar)
            .AgregarParametro("@DespEm2", EmailDespacho2, SqlDbType.NVarChar)

            'Parametros Observaciones
            'Parametros Valor OT
            .AgregarParametro("@Observaciones", Observaciones, SqlDbType.NVarChar)
            .AgregarParametro("@IngPor", ingreso, SqlDbType.NVarChar)

            'Traer el usuario del sistema
            .AgregarParametro("@DigPor", usuarioLG, SqlDbType.NVarChar)
            .AgregarParametro("@HoraIng", Format(Date.Today, "hh:mm"), SqlDbType.DateTime)

            If Aviso <> "" Then
                .AgregarParametro("@FactPend", 1, SqlDbType.Int)

            Else
                .AgregarParametro("@FactPend", 0, SqlDbType.Int)
            End If
            'ByVal Observaciones As String, ByVal Aviso As String

            If SubTotalRe = "" Then SubTotalRe = 0
            If NetoRe = "" Then NetoRe = 0
            If IvaRe = "" Then IvaRe = 0
            If DescuentoRe = "" Then DescuentoRe = 0
            If Peso = "" Then Peso = 0
            If CantidadMuestreo = "" Then CantidadMuestreo = 0
            If ValorRe = "" Then ValorRe = 0
            If MuestreoRe = "" Then MuestreoRe = 0
            If Abono = "" Then Abono = 0
            If TotalRe = "" Then TotalRe = 0
            .AgregarParametro("@SubTotal", CInt(SubTotalRe), SqlDbType.Int)
            .AgregarParametro("@Neto", CInt(NetoRe), SqlDbType.Int)
            .AgregarParametro("@Iva", CInt(IvaRe), SqlDbType.Int)
            .AgregarParametro("@DescuentoPor", CDbl(DescuentoRe), SqlDbType.Float)
            .AgregarParametro("@DescuentoPesos", CInt(Peso), SqlDbType.Int)
            .AgregarParametro("@MuestreoCant", CInt(CantidadMuestreo), SqlDbType.Int)
            .AgregarParametro("@MuestreoPrecUni", CInt(ValorRe), SqlDbType.Int)
            .AgregarParametro("@Muestreo", CInt(MuestreoRe), SqlDbType.Int)
            .AgregarParametro("@Abono", CInt(Abono), SqlDbType.Int)
            'estados
            If (cheque = "False" And efectivo = "False") Then .AgregarParametro("@AbonoCon", 0, SqlDbType.Int)
            If efectivo = "True" Then .AgregarParametro("@AbonoCon", 2, SqlDbType.Int)
            If cheque = "True" Then .AgregarParametro("@AbonoCon", 1, SqlDbType.Int)
            .AgregarParametro("@Total", CInt(TotalRe), SqlDbType.Int)


            .AgregarParametro("@EstAna", EstAna, SqlDbType.NVarChar)
            .AgregarParametro("@EstPag", EstPag, SqlDbType.NVarChar)
            .AgregarParametro("@EstFac", EstFac, SqlDbType.NVarChar)
            .AgregarParametro("@DespUrg", chUrgente, SqlDbType.Bit)

            If OCompra = "" Then OCompra = 0
            .AgregarParametro("@OrdenCompra", OCompra, SqlDbType.NVarChar)


            retorno = .EjecutarEscalar("ls_GrabaOrdenFinal")


        End With

        Return retorno

    End Function

    Public Function buscaAnalisis(ByVal codigo As Integer, ByVal descripcion As String)
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.AgregarParametro("@codigo", codigo, SqlDbType.Int)
        cd.AgregarParametro("@descripcion", descripcion, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_BuscaAnalisis")
        Return ds

    End Function

    Public Function buscaProductor(ByVal rut As String, ByVal nombre As String, ByVal direccion As String, _
    ByVal ciudad As String)
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.AgregarParametro("@rut", rut, SqlDbType.VarChar)
        cd.AgregarParametro("@nombre", nombre, SqlDbType.VarChar)
        cd.AgregarParametro("@direccion", direccion, SqlDbType.VarChar)
        cd.AgregarParametro("@ciudad", ciudad, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_DatosProductor")
        Return ds

    End Function


    Public Function buscaProductorporEmpresa(ByVal rutEmpresa As String, ByVal nombre As String, ByVal direccion As String, _
ByVal ciudad As String)
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.AgregarParametro("@rut", rutEmpresa, SqlDbType.VarChar)
        cd.AgregarParametro("@nombre", nombre, SqlDbType.VarChar)
        cd.AgregarParametro("@direccion", direccion, SqlDbType.VarChar)
        cd.AgregarParametro("@ciudad", ciudad, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_DatosProductorporEmpresa")
        Return ds

    End Function

    Public Function datosMuestreadores()
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        ds = cd.EjecutarQuery("usp_SelectMuestreadores")
        Return ds

    End Function

    Public Function datosMicro()
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        ds = cd.EjecutarQuery("ls_micro")
        Return ds

    End Function

    Public Function datosFitoEspecie()
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        ds = cd.EjecutarQuery("ls_especie")
        Return ds

    End Function

    Public Function datosEspecie()
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        ds = cd.EjecutarQuery("usp_SelectEspecie")
        Return ds

    End Function

    Public Function datosTejido()
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        ds = cd.EjecutarQuery("usp_SelectTejido")
        Return ds

    End Function
    Public Function datosTejidoFrutos()
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        ds = cd.EjecutarQuery("usp_SelectTejidoOtro")
        Return ds

    End Function

    Public Function datosVariedad(ByVal especie As String)
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.AgregarParametro("@especie", especie, SqlDbType.VarChar)

        ds = cd.EjecutarQuery("usp_SelectVariedad")
        Return ds

    End Function

    Public Function datosLocalidad(ByVal id As Integer)
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.AgregarParametro("@TipoConsulta", id, SqlDbType.Int)
        ds = cd.EjecutarQuery("usp_SelectLocalidad")
        Return ds

    End Function

    Public Function datosLocalidad2(ByVal id As Integer, ByVal region As String, ByVal ciudad As String, ByVal comuna As String, _
    ByVal provincia As String)
        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.AgregarParametro("@region", region, SqlDbType.VarChar)
        cd.AgregarParametro("@provincia", provincia, SqlDbType.VarChar)
        cd.AgregarParametro("@ciudad", ciudad, SqlDbType.VarChar)
        cd.AgregarParametro("@comuna", comuna, SqlDbType.VarChar)
        cd.AgregarParametro("@TipoConsulta", id, SqlDbType.Int)
        ds = cd.EjecutarQuery("ls_SelectDirecciones")
        Return ds

    End Function

    Public Function obtieneDatosAnalisis(ByVal codigo As Integer, ByVal filtro As String)

        Dim ds As New DataSet
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.AgregarParametro("@codigo", codigo, SqlDbType.Int)
        cd.AgregarParametro("@filtro", filtro, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_ObtieneAnalisis")

        Return ds

    End Function


    Public Function obtieneProductorXML()

        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        ds = cd.EjecutarQuery("ls_obtieneProductorXML")

        Return ds

    End Function

    Public Function obtieneEmpresaXML()

        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        ds = cd.EjecutarQuery("ls_obtieneEmpresaXML")

        Return ds

    End Function


    Public Function obtieneBusquedaXML(ByVal rutProductor As String, ByVal productor As String, ByVal rutEmpresa As String, _
    ByVal empresa As String, ByVal numeroOT As Integer, ByVal NlabDesde As Integer, ByVal NlabHasta As Integer, ByVal folio As Integer)

        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        cd.AgregarParametro("@rutProductor", rutProductor, SqlDbType.VarChar)
        cd.AgregarParametro("@productor", productor, SqlDbType.VarChar)
        cd.AgregarParametro("@rutEmpresa", rutEmpresa, SqlDbType.VarChar)
        cd.AgregarParametro("@empresa", empresa, SqlDbType.VarChar)
        cd.AgregarParametro("@numeroOT", numeroOT, SqlDbType.Int)
        cd.AgregarParametro("@NlabDesde", NlabDesde, SqlDbType.Int)
        cd.AgregarParametro("@NlabHasta", NlabHasta, SqlDbType.Int)
        cd.AgregarParametro("@folio", folio, SqlDbType.Int)
        ds = cd.EjecutarQuery("ls_obtieneBusquedaXML")

        Return ds

    End Function


    Public Function obtieneFechaResultadoXML(ByVal numeroOT As String, ByVal nLab As String, ByVal folio As String, ByVal tmu As String)

        Dim cd As New CapaDato
        Dim ds As New DataSet
        Dim dt As New DataTable

        cd.Inicializar()
        cd.AgregarParametro("@numeroOT", numeroOT, SqlDbType.VarChar)
        cd.AgregarParametro("@nLab", nLab, SqlDbType.VarChar)
        cd.AgregarParametro("@folio", folio, SqlDbType.VarChar)
        cd.AgregarParametro("@tmu", tmu, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_ObtieneFechaResultado")

        dt = ds.Tables(0)

        Return dt.Rows.Item(0).Item(0).ToString()

    End Function

    Public Function obtieneElementosXML(ByVal numeroOT As String, ByVal nLab As String, ByVal folio As String, ByVal tmu As String)

        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        cd.AgregarParametro("@numeroOT", numeroOT, SqlDbType.VarChar)
        cd.AgregarParametro("@nLab", nLab, SqlDbType.VarChar)
        cd.AgregarParametro("@folio", folio, SqlDbType.VarChar)
        cd.AgregarParametro("@tmu", tmu, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_ObtieneResultadoXML")

        Return ds

    End Function


    Public Sub copiaDatosAgronomicos(ByVal tmu As Integer, ByVal ot As Integer, ByVal nlab As Integer)
        Dim cd As New CapaDato

        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", ot, SqlDbType.Int)
            .AgregarParametro("@nlab", nlab, SqlDbType.Int)
            .AgregarParametro("@tmu", tmu, SqlDbType.NVarChar)
            .EjecutarEscalar("ls_CopiaDatosAgronomicos")

        End With


    End Sub

    Public Sub reservaNlabDatoAgronomico(ByVal tmu As Integer, ByVal ot As Integer, ByVal nlab As Integer)
        Dim cd As New CapaDato

        If tmu = 1000 Then
            Try
                With cd

                    .Inicializar()
                    .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                    .AgregarParametro("@NumLabFoliar", nlab, SqlDbType.Int)
                    .AgregarParametro("@PredioFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@LocFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@EspFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@VarFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@TejFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@EdadFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@Cuartel1Foliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@Cuartel2Foliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@strRtoAnt", "", SqlDbType.NVarChar)
                    .AgregarParametro("@strCarga", "", SqlDbType.NVarChar)
                    .AgregarParametro("@strVigor", "", SqlDbType.NVarChar)
                    .AgregarParametro("@strDensidad", "", SqlDbType.NVarChar)
                    .AgregarParametro("@strApa", "", SqlDbType.NVarChar)
                    .AgregarParametro("@ObsFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@strReq", False, SqlDbType.Bit)
                    .AgregarParametro("@MuestreadorFoliar", "", SqlDbType.NVarChar)
                    .AgregarParametro("@FMuestreoFoliar", CDate(Date.Today), SqlDbType.DateTime)
                    .EjecutarEscalar("ls_GrabaAntecedentesFoliar")

                End With
            Catch ex As Exception

            End Try

        ElseIf tmu = 2000 Then

            With cd


                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@Predio", "", SqlDbType.NVarChar)
                .AgregarParametro("@Loc", "", SqlDbType.NVarChar)
                .AgregarParametro("@Esp", "", SqlDbType.NVarChar)
                .AgregarParametro("@Var", "", SqlDbType.NVarChar)
                .AgregarParametro("@Tej", "", SqlDbType.NVarChar)
                .AgregarParametro("@Edad", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel1", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel2", "", SqlDbType.NVarChar)
                .AgregarParametro("@strRtoAnt", "", SqlDbType.NVarChar)
                .AgregarParametro("@strCarga", "", SqlDbType.NVarChar)
                .AgregarParametro("@strVigor", "", SqlDbType.NVarChar)
                .AgregarParametro("@strDensidad", "", SqlDbType.NVarChar)
                .AgregarParametro("@strApa", "", SqlDbType.NVarChar)
                .AgregarParametro("@Obs", "", SqlDbType.NVarChar)
                .AgregarParametro("@strReq", False, SqlDbType.Bit)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreo", CDate(Date.Today), SqlDbType.DateTime)
                .EjecutarEscalar("ls_GrabaAntecedentesTejidos")

            End With
        ElseIf tmu = 3000 Then
            With cd
                .Inicializar()
                .AgregarParametro("@NumOt", CInt(ot), SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FechaMuestreo", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@HoraMuestreo", "00:00", SqlDbType.NVarChar)
                .AgregarParametro("@Predio", "", SqlDbType.NVarChar)
                .AgregarParametro("@Localidad", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion1", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion2", "", SqlDbType.NVarChar)
                .AgregarParametro("@Origen", "", SqlDbType.NVarChar)
                .AgregarParametro("@OrigenDescr", "", SqlDbType.NVarChar)
                .AgregarParametro("@TipoMuestreo", "", SqlDbType.NVarChar)
                .AgregarParametro("@OrigenMDescr", "", SqlDbType.NVarChar)
                .AgregarParametro("@TipoRecip", "", SqlDbType.NVarChar)
                .AgregarParametro("@Detalle", "", SqlDbType.NVarChar)
                .AgregarParametro("@VolumenMu", "", SqlDbType.NVarChar)
                .AgregarParametro("@Estado", "", SqlDbType.NVarChar)
                .AgregarParametro("@Preservantes", "", SqlDbType.NVarChar)
                .AgregarParametro("@FechaIngreso", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@HoraIngreso", "00:00", SqlDbType.NVarChar)
                .AgregarParametro("@Observaciones", "", SqlDbType.NVarChar)
                .EjecutarEscalar("ls_GrabaAntecedentesAgua")
            End With

        ElseIf tmu = 4000 Then
            With cd

                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@Predio", "", SqlDbType.NVarChar)
                .AgregarParametro("@Localidad", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion1", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion2", "", SqlDbType.NVarChar)
                .AgregarParametro("@ProfundidadMuestra", "", SqlDbType.NVarChar)
                .AgregarParametro("@CultivoAnt", "", SqlDbType.NVarChar)
                .AgregarParametro("@RtoAnt", "", SqlDbType.NVarChar)
                .AgregarParametro("@CantRtoAnt", "", SqlDbType.NVarChar)
                .AgregarParametro("@UnidadAnt", "", SqlDbType.NVarChar)
                .AgregarParametro("@CultivoPro", "", SqlDbType.NVarChar)
                .AgregarParametro("@RtoAct", "", SqlDbType.NVarChar)
                .AgregarParametro("@CantRtoAct", "", SqlDbType.NVarChar)
                .AgregarParametro("@UnidadAct", "", SqlDbType.NVarChar)
                .AgregarParametro("@Textura", "", SqlDbType.NVarChar)
                .AgregarParametro("@Profundidad", "", SqlDbType.NVarChar)
                .AgregarParametro("@Drenaje", "", SqlDbType.NVarChar)
                .AgregarParametro("@Riego", "", SqlDbType.NVarChar)
                .AgregarParametro("@Observacion", "", SqlDbType.NVarChar)
                .AgregarParametro("@strReq", False, SqlDbType.Bit)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FechaIng", CDate(Date.Today), SqlDbType.DateTime)
                .EjecutarEscalar("ls_GrabaAntecedentesSuelo")
            End With

        ElseIf tmu = 5000 Then

            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@Predio", "", SqlDbType.NVarChar)
                .AgregarParametro("@Loc", "", SqlDbType.NVarChar)
                .AgregarParametro("@Obs", "", SqlDbType.NVarChar)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreo", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@id1", "", SqlDbType.NVarChar)
                .AgregarParametro("@id2", "", SqlDbType.NVarChar)
                .AgregarParametro("@tipoFert", "", SqlDbType.NVarChar)
                .EjecutarEscalar("ls_GrabaAntecedentesFertQui")
            End With

        ElseIf tmu = 6000 Then

            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@Predio", "", SqlDbType.NVarChar)
                .AgregarParametro("@Loc", "", SqlDbType.NVarChar)
                .AgregarParametro("@Obs", "", SqlDbType.NVarChar)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreo", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@id1", "", SqlDbType.NVarChar)
                .AgregarParametro("@id2", "", SqlDbType.NVarChar)
                .AgregarParametro("@tipoFert", "", SqlDbType.NVarChar)
                .EjecutarEscalar("ls_GrabaAntecedentesFertOrg")
            End With

        ElseIf tmu = 7302 Then ' Ot_Fitopatologico_Antecedentes
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLabFitopatologia", nlab, SqlDbType.Int)
                .AgregarParametro("@PredioFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@LocFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@EspFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@VarFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@TejFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@EdadFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Sintomatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion1Fitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion2Fitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@ObsFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@MuestreadorFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreoFitopatologia", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@HMuestreoFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@IDEspecie", "", SqlDbType.NVarChar)
                .AgregarParametro("@RColonia", "", SqlDbType.NVarChar)
                .EjecutarEscalar("ls_GrabaAntecedentesFitopatologicos")
            End With
        ElseIf tmu = 7000 Then ' Ot_Fitopatologico_Antecedentes
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLabFitopatologia", nlab, SqlDbType.Int)
                .AgregarParametro("@PredioFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@LocFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@EspFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@VarFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@TejFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@EdadFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Sintomatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion1Fitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion2Fitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@ObsFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@MuestreadorFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreoFitopatologia", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@HMuestreoFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@IDEspecie", "", SqlDbType.NVarChar)
                .AgregarParametro("@RColonia", "", SqlDbType.NVarChar)
                .EjecutarEscalar("ls_GrabaAntecedentesFitopatologicos")
            End With
       
        ElseIf tmu = 7304 Then ' Ot_FitoResistencia_Antecedentes
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@NumProducto", 0, SqlDbType.Int)
                .AgregarParametro("@NumConcentracion", 0, SqlDbType.Int)
                .AgregarParametro("@NumMicro", 0, SqlDbType.Int)
                .AgregarParametro("@Identificacion1", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion2", "", SqlDbType.NVarChar)
                .AgregarParametro("@Obs", "", SqlDbType.NVarChar)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreo", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@Micro", "", SqlDbType.NVarChar)
                .AgregarParametro("@Especie", "", SqlDbType.NVarChar)
                .AgregarParametro("@PGuarda", "", SqlDbType.NVarChar)
                .AgregarParametro("@IngActivo", "", SqlDbType.NVarChar)
                .EjecutarEscalar("usp_GrabaAntecedentesFitoResistencia")
            End With
        ElseIf tmu = 7306 Then 'Ot_FitoEvaluacion_Antecedentes
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@Predio", "", SqlDbType.NVarChar)
                .AgregarParametro("@Esp", "", SqlDbType.NVarChar)
                .AgregarParametro("@Var", "", SqlDbType.NVarChar)
                .AgregarParametro("@Dist", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel1", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel2", "", SqlDbType.NVarChar)
                .AgregarParametro("@AnoPlanta", 0, SqlDbType.Int)
                .AgregarParametro("@NumTrata", 0, SqlDbType.Int)
                .AgregarParametro("@NumAplica", 0, SqlDbType.Int)
                .AgregarParametro("@DuraDesde", "", SqlDbType.NVarChar)
                .AgregarParametro("@DuraHasta", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cosecha", "", SqlDbType.NVarChar)
                .AgregarParametro("@FechaGuarda", "", SqlDbType.NVarChar)
                .AgregarParametro("@Loc", "", SqlDbType.NVarChar)
                .AgregarParametro("@Ensayo", "", SqlDbType.NVarChar)
                .AgregarParametro("@Obs", "", SqlDbType.NVarChar)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreo", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@FTERMINO", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@NENSAYO", "", SqlDbType.NVarChar)

                .EjecutarEscalar("usp_GrabaAntecedentesFitoEvaluacion")
            End With
        ElseIf tmu = 7308 Then 'Ot_FitoMonitoreo_Antecedentes
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLab", nlab, SqlDbType.Int)
                .AgregarParametro("@NumLineas", 0, SqlDbType.Int)
                .AgregarParametro("@NumCamaras", 0, SqlDbType.Int)
                .AgregarParametro("@Identificacion1", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion2", "", SqlDbType.NVarChar)
                .AgregarParametro("@Obs", "", SqlDbType.NVarChar)
                .AgregarParametro("@Muestreador", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreo", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@FIngreso", CDate(Date.Today), SqlDbType.DateTime)
                .AgregarParametro("@NTuneles", 0, SqlDbType.Int)
                .AgregarParametro("@ESPProcesada", "", SqlDbType.NVarChar)
                .AgregarParametro("@NPlacas1", 0, SqlDbType.Int)
                .AgregarParametro("@NPlacas2", 0, SqlDbType.Int)
                .AgregarParametro("@NPlacas3", 0, SqlDbType.Int)
                .AgregarParametro("@NAguas", 0, SqlDbType.Int)
                .AgregarParametro("@NDactilares", 0, SqlDbType.Int)
                .AgregarParametro("@Localidad", "", SqlDbType.NVarChar)

                .EjecutarEscalar("usp_GrabaAntecedentesFitoMonitoreo")
            End With
        ElseIf tmu = 8700 Then 'algo
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLabYemas", nlab, SqlDbType.Int)
                .AgregarParametro("@PredioYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@LocYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@EspYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@VarYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@TejYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@EdadYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel1Yemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel2Yemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@strRtoAnt", "", SqlDbType.NVarChar)
                .AgregarParametro("@strCarga", "", SqlDbType.NVarChar)
                .AgregarParametro("@strVigor", "", SqlDbType.NVarChar)
                .AgregarParametro("@strDensidad", "", SqlDbType.NVarChar)
                .AgregarParametro("@strApa", "", SqlDbType.NVarChar)
                .AgregarParametro("@NumCargadores", 0, SqlDbType.Int)
                .AgregarParametro("@NumYemas", 0, SqlDbType.Int)
                .AgregarParametro("@ObsYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@MuestreadorYemas", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreoYemas", CDate(Date.Today), SqlDbType.DateTime)

                .EjecutarEscalar("usp_GrabaAntecedentesYemas")
            End With
        ElseIf tmu = 8758 Then 'Nematodos
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLabNematodos", nlab, SqlDbType.Int)
                .AgregarParametro("@PredioNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@LocNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@EspNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@VarNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@TipNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@EdadNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@ProdAntNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@ProdActNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel1Nematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cuartel2Nematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@Cultivo", "", SqlDbType.NVarChar)
                .AgregarParametro("@strVigor", "", SqlDbType.NVarChar)
                .AgregarParametro("@ObsNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@MuestreadorNematodos", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreoNematodos", CDate(Date.Today), SqlDbType.DateTime)
                .EjecutarEscalar("usp_GrabaAntecedentesNematodos")
            End With
        ElseIf tmu = 7000 Then 'fitopatologia
            With cd
                .Inicializar()
                .AgregarParametro("@NumOT", ot, SqlDbType.Int)
                .AgregarParametro("@NumLabFitopatologia", nlab, SqlDbType.Int)
                .AgregarParametro("@PredioFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@LocFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@EspFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@VarFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@TejFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@EdadFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Sintomatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion1Fitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@Identificacion2Fitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@ObsFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@MuestreadorFitopatologia", "", SqlDbType.NVarChar)
                .AgregarParametro("@FMuestreoFitopatologia", "", SqlDbType.DateTime)
                .AgregarParametro("@HMuestreoFitopatologia", "", SqlDbType.NVarChar)
                .EjecutarEscalar("ls_GrabaAntecedentesFitopatologicos")
            End With

        ElseIf tmu = 8000 Then 'kit y otros

        End If
    End Sub

End Class


