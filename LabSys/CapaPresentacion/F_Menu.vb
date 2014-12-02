Imports LabSys.class_COTIZADOR
Public Class F_Menu

    Dim carpeta As String

    Private Sub F_Menu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ancho As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim alto As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim iX, iNumMenu As Integer

        If alto < 1024 Or ancho < 1280 Then
            MsgBox("La resolucion de tu pantalla es " & ancho & " x " & alto & " " & vbCr & _
                   " y la resolucion minima requerida por LabSys es de ancho 1280 por alto 1024," & vbCr & _
                   "Comuníquese con el Administrador de Sistema para resolver su caso")

        End If

        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .EjecutarQueryDt("usp_SelectCondPago", Cjto_Tablas1, "CONDICION_PAGO")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectIngresadores", Cjto_Tablas1, "INGRESADORES")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectTipoMascara", Cjto_Tablas1, "TIPO_MASCARA")

            .Inicializar()
            .AgregarParametro("@TipoConsulta", 3, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "LOCALIDAD")

            .Inicializar()
            .AgregarParametro("@TipoConsulta", 1, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "COMUNA")


            .Inicializar()
            .AgregarParametro("@TipoConsulta", 2, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "CIUDAD")




            'nuevas cargas



            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectEspecie", Cjto_Tablas1, "ESPECIE")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectTejido", Cjto_Tablas1, "TEJIDO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectTejidoOtro", Cjto_Tablas1, "TEJIDO_OTRO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectFito_TMuestra", Cjto_Tablas1, "FITO_TMUESTRA")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectFito_NomEnsayo", Cjto_Tablas1, "FITO_NOMENSAYO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectMuestras", Cjto_Tablas1, "MUESTRA")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectCultivo", Cjto_Tablas1, "CULTIVO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectTipoFertilizanteQuimico", Cjto_Tablas1, "TIPO_FERTILIZANTE_QUIMICO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectTipoFertilizanteOrganico", Cjto_Tablas1, "TIPO_FERTILIZANTE_ORGANICO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectAnalisis", Cjto_Tablas1, "ANALISIS")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectResultadosRangoFertilidad", Cjto_Resultados1, "RANGO_FERTILIDAD")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectResultadosRangoFertOrg", Cjto_Resultados1, "RANGO_FERTORG")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectResultadosRangoSuelo", Cjto_Resultados1, "RANGO_SUELO")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectResultadosRangoAgua", Cjto_Tablas1, "RANGO_MUESTRA")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectResultadosRangoCE", Cjto_Resultados1, "RANGO_AGUA_CE")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectFacturaPaso", Cjto_Tablas1, "FACTURA_PASO")

            'Dim Test10 As DbManager = New DbManager("COMBO_ANALISIS", Conexion1)
            'Dim query10 As String = "Select * from COMBO_ANALISIS"
            'Test10.Selecccionar(Cjto_Tablas1, query10)

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectSubmuestra", Cjto_Tablas1, "SUBMUESTRA")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 1, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectProductor", Cjto_Tablas1, "PRODUCTOR_AUTOCOMPLETA")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 2, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectProductor", Cjto_Tablas1, "PRODUCTOR_EMPRESA")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 3, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "LOCALIDAD")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 1, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "COMUNA")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 2, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "CIUDAD")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 4, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "PROVINCIA")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 5, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "REGION")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectElemento", Cjto_Tablas1, "ELEMENTO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectCondPago", Cjto_Tablas1, "CONDICION_PAGO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectCondPago", Cjto_Tablas1, "CONDICION_PAGO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectHomoElemento", Cjto_Tablas1, "HOMOLOGA_ELEMENTO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectFormatoPladig", Cjto_Tablas1, "FORMATO_PLADIG")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 1, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectTestigoEstandar", Cjto_Tablas1, "TESTIGO")

            '.Inicializar()
            '.AgregarParametro("@TipoConsulta", 2, SqlDbType.Int)
            '.EjecutarQueryDt("usp_SelectTestigoEstandar", Cjto_Tablas1, "ESTANDAR")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectAnalista_Elemento", Cjto_Tablas1, "ANALISTA_ELEMENTO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectPersonal", Cjto_Tablas1, "PERSONAL")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectDiccionario", Cjto_Tablas1, "DICCIONARIO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectTipoMascara", Cjto_Tablas1, "TIPO_MASCARA")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectOrdenTrabajoPaso", Cjto_Tablas1, "ORDEN_TRABAJO_PASO")

            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectMuestreadores", Cjto_Tablas1, "MUESTREADORES")


            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectRecipiente", Cjto_Tablas1, "RECIPIENTE")


            .Inicializar()
            .EjecutarQueryDt("usp_SelectPreservantes", Cjto_Tablas1, "PRESERVANTES")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectEstado", Cjto_Tablas1, "ESTADO")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectConsultaFactura", Cjto_Tablas1, "CONSULTA_FACTURA")


            .Inicializar()
            .EjecutarQueryDt("usp_SelectCodArea", Cjto_Tablas1, "area1")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectIngresadores", Cjto_Tablas1, "INGRESADORES")

            .Inicializar()
            .AgregarParametro("@Tipo", 1, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectFirma", Cjto_Resultados1, "FIRMA_NOMBRE")

            .Inicializar()
            .AgregarParametro("@Tipo", 2, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectFirma", Cjto_Resultados1, "FIRMA_CARGO")

            .Inicializar()
            .EjecutarQueryDt("usp_CargaProductorLabsys", Cjto_Tablas1, "PRODUCTOR_LABSYS")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectNotaAutoResultadosTotal", Cjto_Tablas1, "NOTA_AUTO_RESULTADOS")



            '.Inicializar()
            '.EjecutarQueryDt("usp_SelectOrdenTrabajoPaso", Cjto_Tablas1, "ORDEN_TRABAJO_PASO")

        End With


        'If Len(sPermisos) > 0 Then
        '    For iX = 1 To Len(sPermisos) Step 2
        '        iNumMenu = CInt(Mid(sPermisos, iX, 2))
        '        Select Case iNumMenu
        '            Case 1
        '                Me.CotizaciónToolStripMenuItem.Enabled = True
        '            Case 2
        '                Me.IngresoOTToolStripMenuItem.Enabled = True
        '            Case 3
        '                Me.ConsultaToolStripMenuItem.Enabled = True
        '            Case 4
        '                ' Me.ConsultaOTHistoricaToolStripMenuItem.Enabled = True
        '            Case 5
        '                Me.PlanificaciónToolStripMenuItem.Enabled = True
        '            Case 6
        '                Me.DigitaciónToolStripMenuItem.Enabled = True
        '            Case 7
        '                Me.RevisiónToolStripMenuItem.Enabled = True
        '            Case 8
        '                Me.ResultadosToolStripMenuItem.Enabled = True
        '            Case 9
        '                Me.DespachoToolStripMenuItem.Enabled = True
        '            Case 10
        '                Me.CobranzaToolStripMenuItem.Enabled = True
        '            Case 11
        '                Me.AdministraciónToolStripMenuItem.Enabled = True
        '            Case 12
        '                Me.FoliarToolStripMenuItem.Enabled = True
        '            Case 13
        '                Me.TejidoToolStripMenuItem.Enabled = True
        '            Case 14
        '                Me.AguaToolStripMenuItem.Enabled = True
        '            Case 15
        '                Me.SueloToolStripMenuItem.Enabled = True
        '            Case 16
        '                Me.DFertilizantesToolStripMenuItem.Enabled = True
        '            Case 17
        '                Me.DFertilizantesOrgánicosToolStripMenuItem.Enabled = True
        '            Case 18
        '                Me.DKitYOtrosToolStripMenuItem.Enabled = True
        '            Case 19
        '                Me.ConsultaCodPlanToolStripMenuItem.Enabled = True
        '            Case 20
        '                Me.YemasToolStripMenuItem.Enabled = True
        '            Case 21
        '                Me.TraspasoToolStripMenuItem.Enabled = True
        '            Case 22
        '                Me.MantenciónToolStripMenuItem.Enabled = True
        '            Case 23
        '                Me.RFoliarToolStripMenuItem1.Enabled = True
        '            Case 24
        '                Me.RTejidosToolStripMenuItem2.Enabled = True
        '            Case 25
        '                Me.RAguaToolStripMenuItem1.Enabled = True
        '            Case 26
        '                Me.RSueloToolStripMenuItem3.Enabled = True
        '            Case 27
        '                Me.RFertQuimicosToolStripMenuItem4.Enabled = True
        '            Case 28
        '                Me.RFertilizantesOrgánicosToolStripMenuItem.Enabled = True
        '            Case 29
        '                Me.OtrosAnálisisToolStripMenuItem.Enabled = True
        '            Case 30
        '                Me.ListadoInscripcionesToolStripMenuItem.Enabled = True
        '            Case 31
        '                Me.EmisiónDeResultadosToolStripMenuItem.Enabled = True
        '            Case 32
        '                Me.EmisiónDeYemasToolStripMenuItem.Enabled = True
        '            Case 33
        '                Me.HorizontalFoliarToolStripMenuItem.Enabled = True
        '            Case 34
        '                Me.ModuloDespachoToolStripMenuItem.Enabled = True
        '            Case 35
        '                Me.ModuloCartaDespachoToolStripMenuItem.Enabled = True
        '            Case 36
        '                Me.CancelaciónFacturasToolStripMenuItem.Enabled = True
        '            Case 37
        '                Me.LibroDeVentasToolStripMenuItem.Enabled = True
        '            Case 38
        '                Me.TablasToolStripMenuItem.Enabled = True
        '            Case 39
        '                Me.MantenedorEstadosToolStripMenuItem.Enabled = True
        '            Case 40
        '                Me.TraspasoAHistoricosToolStripMenuItem.Enabled = True
        '            Case 41
        '                Me.EliminaOTToolStripMenuItem.Enabled = True
        '            Case 42
        '                Me.ListadosToolStripMenuItem.Enabled = True
        '            Case 43
        '                Me.CentroDeCostosToolStripMenuItem.Enabled = True
        '            Case 44
        '                Me.CodigoElementosToolStripMenuItem.Enabled = True
        '            Case 45
        '                Me.TipoToolStripMenuItem.Enabled = True
        '            Case 46
        '                Me.RelacionOtFacturaToolStripMenuItem.Enabled = True
        '            Case 47
        '                Me.EspecieVariedadToolStripMenuItem.Enabled = True
        '            Case 48
        '                Me.CondiciónDePagoToolStripMenuItem.Enabled = True
        '            Case 49
        '                Me.MuestreadoresToolStripMenuItem.Enabled = True
        '            Case 50
        '                Me.LocalidadToolStripMenuItem.Enabled = True
        '            Case 51
        '                Me.ElementoToolStripMenuItem.Enabled = True
        '            Case 52
        '                Me.MTejidoToolStripMenuItem1.Enabled = True
        '            Case 53
        '                Me.ProductorToolStripMenuItem.Enabled = True
        '            Case 54
        '                Me.RangosToolStripMenuItem.Enabled = True
        '            Case 55
        '                Me.PersonalToolStripMenuItem.Enabled = True
        '            Case 56
        '                Me.FertilidadToolStripMenuItem.Enabled = True
        '            Case 57
        '                Me.SalinidadToolStripMenuItem.Enabled = True
        '            Case 58
        '                Me.OrdenDeTrabajoToolStripMenuItem.Enabled = True
        '            Case 59
        '                Me.FacturaToolStripMenuItem.Enabled = True
        '            Case 60
        '                Me.NºLaboratorioToolStripMenuItem.Enabled = True
        '            Case 61
        '                Me.ElementosToolStripMenuItem.Enabled = True
        '            Case 62
        '                Me.DespachaRangoOTToolStripMenuItem.Enabled = True
        '            Case 63
        '                Me.TraspasosDbfToolStripMenuItem.Enabled = True
        '            Case 64
        '                Me.GeneraXMLToolStripMenuItem.Enabled = True
        '            Case 65
        '                Me.CobranzaToolStripMenuItem1.Enabled = True
        '        End Select
        '    Next
        'End If

       
    End Sub

    Private Sub OTPorAnalizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OTPorAnalizarToolStripMenuItem.Click
        Dim planificacion As New F_Planificacion
        planificacion.MdiParent = Me
        planificacion.Show()

    End Sub

    Private Sub CotizaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizaciónToolStripMenuItem.Click
        'Dim cotizador As New class_COTIZADOR
        'cotizador.MdiParent = Me
        'cotizador.Show()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Dim localidad As New frm_localidad
        localidad.Mdiparent = Me
        localidad.Show()
    End Sub

    Private Sub ElementoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElementoToolStripMenuItem.Click
        Dim elemento As New F_Mantenedor_Elementos_Labsys
        elemento.MdiParent = Me
        elemento.Show()
    End Sub

    Private Sub EspecieVariedadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecieVariedadToolStripMenuItem.Click
        Dim espVar As New Frm_Mant_Especie_Variedad
        espVar.MdiParent = Me
        espVar.Show()
    End Sub

    Private Sub CodigoElementosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoElementosToolStripMenuItem.Click
        Dim codEle As New F_Maestro_Codigo_Elemento
        codEle.MdiParent = Me
        codEle.Show()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        Dim personal As New Frm_Personal
        personal.MdiParent = Me
        personal.Show()
    End Sub

    Private Sub TipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoToolStripMenuItem.Click
        Dim mascara As New F_Mantenedor_Mascaras
        mascara.MdiParent = Me
        mascara.Show()
    End Sub

    Private Sub TejidoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTejidoToolStripMenuItem1.Click
        Dim tejido As New F_Mant_Tejidos
        tejido.MdiParent = Me
        tejido.Show()
    End Sub

    Private Sub MuestreadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuestreadoresToolStripMenuItem.Click
        Dim muestreador As New F_Muestreador
        muestreador.MdiParent = Me
        muestreador.Show()
    End Sub

    Private Sub CondiciónDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CondiciónDePagoToolStripMenuItem.Click
        Dim cond As New F_Condicion_de_Pago
        cond.MdiParent = Me
        cond.Show()
    End Sub

    Private Sub ProductorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductorToolStripMenuItem.Click
        Dim productor As New F_MantenedorProductor
        productor.MdiParent = Me
        productor.Show()
    End Sub

    Private Sub RangosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RangosToolStripMenuItem.Click
        Dim rengos As New F_Mantenedor_Rangos
        rengos.MdiParent = Me
        rengos.Show()
    End Sub

    Private Sub RelacionOtFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionOtFacturaToolStripMenuItem.Click
        Dim facOrd As New F_Relacion_Factura_Orden
        facOrd.MdiParent = Me
        facOrd.Show()
    End Sub

    Private Sub TraspasosDbfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraspasosDbfToolStripMenuItem.Click
        Dim traspaso As New F_Traspaso_Dbf
        traspaso.MdiParent = Me
        traspaso.Show()
    End Sub

    Private Sub OrdenDeTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeTrabajoToolStripMenuItem.Click
        Dim modOT As New F_Modifica_Estado_OT
        modOT.MdiParent = Me
        modOT.Show()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        Dim fac As New Frm_Modifica_Estado_Factura
        fac.MdiParent = Me
        fac.Show()
    End Sub

    Private Sub NºLaboratorioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NºLaboratorioToolStripMenuItem.Click
        Dim nLab As New F_Modifica_Estado_Nlab
        nLab.MdiParent = Me
        nLab.Show()
    End Sub

    Private Sub ElementosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElementosToolStripMenuItem.Click
        Dim est As New Frm_Modificacion_Estados
        est.MdiParent = Me
        est.Show()
    End Sub

    Private Sub DespachaRangoOTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespachaRangoOTToolStripMenuItem.Click
        Dim des As New F_Despacha_x_RangoOT
        des.MdiParent = Me
        des.Show()
    End Sub

    Private Sub TraspasoAHistoricosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraspasoAHistoricosToolStripMenuItem.Click
        Dim dis As New F_Traspaso_DigitacionHistorica
        dis.MdiParent = Me
        dis.Show()
    End Sub

    Private Sub EliminaOTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim eOT As New F_EliminaOT
        eOT.MdiParent = Me
        eOT.Show()
    End Sub




    Private Sub LocalidadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem1.Click
        Dim iloc As New Frm_I_Localidad
        iloc.MdiParent = Me
        iloc.Show()
    End Sub

    Private Sub CentroDeCostosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentroDeCostosToolStripMenuItem.Click
        Dim centro As New F_Cuentas
        centro.MdiParent = Me
        centro.Show()

    End Sub

    Private Sub ModuloCartaDespachoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloCartaDespachoToolStripMenuItem.Click
        Dim carta As New Frm_Carta_Despacho
        carta.MdiParent = Me
        carta.Show()
    End Sub

    Private Sub ModuloDespachoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloDespachoToolStripMenuItem.Click
        Dim des As New Frm_Despacho
        des.MdiParent = Me
        des.Show()
    End Sub

    Private Sub FoliarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoliarToolStripMenuItem.Click
        CodAna = 1000
        Dim fol As New F_DigitaResultado
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub TejidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TejidoToolStripMenuItem.Click
        CodAna = 2000
        Dim tej As New F_DigitaResultado
        tej.MdiParent = Me
        tej.Show()
    End Sub

    Private Sub AguaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AguaToolStripMenuItem.Click
        CodAna = 3000
        Dim fol As New F_DigitaResultado
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub SueloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SueloToolStripMenuItem.Click
        CodAna = 4000
        Dim fol As New F_DigitaResultado
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub KitYOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DKitYOtrosToolStripMenuItem.Click
        CodAna = 8000
        Dim fol As New F_DigitaResultado
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub FoliarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RFoliarToolStripMenuItem1.Click
        CodMuestraRev = 1000
        Dim fol As New Frm_Pantalla_Revision2
        fol.MdiParent = Me
        fol.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTejidosToolStripMenuItem2.Click
        CodMuestraRev = 2000
        Dim fol As New Frm_Pantalla_Revision2
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub AguaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAguaToolStripMenuItem1.Click
        CodMuestraRev = 3000
        Dim fol As New Frm_Pantalla_Revision2
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub FertilidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SanidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RFertQuimicosToolStripMenuItem4.Click
        CodMuestraRev = 5000
        Dim fol As New Frm_Pantalla_Revision2
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub FertilizantesOrgánicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RFertilizantesOrgánicosToolStripMenuItem.Click
        CodMuestraRev = 6000
        Dim fol As New Frm_Pantalla_Revision2
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub OtrosAnálisisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrosAnálisisToolStripMenuItem.Click
        MsgBox("no esta disponible, estamos trabajado para usted", MsgBoxStyle.Information)
    End Sub

    Private Sub ListadoInscripcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoInscripcionesToolStripMenuItem.Click
        Dim fol As New Frm_Inscripciones
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub EmisiónDeResultadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmisiónDeResultadosToolStripMenuItem.Click
        Dim fol As New Frm_Emision_Resultados
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub FertilizantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DFertilizantesToolStripMenuItem.Click
        CodAna = 5000
        Dim fol As New F_DigitaResultado
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub FertilizantesOrgánicosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DFertilizantesOrgánicosToolStripMenuItem.Click
        CodAna = 6000
        Dim fol As New F_DigitaResultado
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub HorizontalFoliarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizontalFoliarToolStripMenuItem.Click
        Dim fol As New Frm_InformesHorizontales
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub EmisiónDeYemasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmisiónDeYemasToolStripMenuItem.Click
        Dim fol As New Frm_Yemas_Genera_Excel
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub GeneraXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneraXMLToolStripMenuItem.Click
        Dim fol As New F_GeneradorXml
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub TraspasoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraspasoToolStripMenuItem.Click
        Dim fol As New F_TraspasoYemas
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub CancelaciónFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónFacturasToolStripMenuItem.Click
        Dim fol As New F_CancelacionFactura
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub CobranzaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CobranzaToolStripMenuItem1.Click
        Dim fol As New Form1
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub ListaddoDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaddoDeFacturasToolStripMenuItem.Click
        Dim fol As New F_ListadoFacturas
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub ConsultaCodPlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCodPlanToolStripMenuItem.Click
        Dim fol As New Frm_CodigoPlanificacion
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub PlanificaPorNlabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanificaPorNlabToolStripMenuItem.Click
        Dim fol As New F_PlanificacionNlab
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub IngresoDeFotosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeFotosToolStripMenuItem.Click

    End Sub

    Private Sub OrdenesPorFacturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesPorFacturarToolStripMenuItem.Click

        Dim otpfac As New F_OrdenesPorFacturar
        otpfac.MdiParent = Me
        otpfac.Show()


    End Sub

    Private Sub OrdenesPorFacturarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesPorFacturarToolStripMenuItem1.Click
        Dim otpfac As New F_OrdenesXFacturar
        otpfac.MdiParent = Me
        otpfac.Show()
    End Sub

    Private Sub BuscarDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarDocumentosToolStripMenuItem.Click
        Dim otpfac As New F_BuscaDocumentos
        otpfac.MdiParent = Me
        otpfac.Show()

    End Sub

    Private Sub IngresoOTToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoOTToolStripMenuItem.Click
        F_OrdenTrabajo.Refresh()
        F_OrdenTrabajo.ResetText()
        Dim ordenTrabajo As New F_OrdenTrabajo
        Tipo_Ingreso_OT = "Normal"
        ordenTrabajo.MdiParent = Me
        ordenTrabajo.Show()
    End Sub

    

    Private Sub ConsultaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        Dim modificaOT As New F_ModificaOT
        Tipo_Ingreso_OT = "Manual"
        modificaOT.MdiParent = Me
        modificaOT.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Realmente Desea Salir?", MsgBoxStyle.OkCancel, "Cerrando...") = MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub EliminarOTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaOTToolStripMenuItem.Click
        Dim eOT As New F_EliminaOT
        eOT.MdiParent = Me
        eOT.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If MsgBox("¿Realmente Desea Salir?", MsgBoxStyle.OkCancel, "Cerrando...") = MsgBoxResult.Ok Then
            End
        End If


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim modificaOT As New F_ModificaOT
        Tipo_Ingreso_OT = "Manual"
        modificaOT.MdiParent = Me
        modificaOT.Show()
    End Sub
    Sub abrir_carpeta()
        If carpeta = "yemas2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Yemas-LabSys", vbNormalFocus)
        ElseIf carpeta = "yemas2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Yemas-LabSys", vbNormalFocus)
        ElseIf carpeta = "yemas2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Yemas-LabSys", vbNormalFocus)
        ElseIf carpeta = "yemas2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Yemas-LabSys", vbNormalFocus)
        ElseIf carpeta = "yemas2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Yemas-LabSys", vbNormalFocus)

        ElseIf carpeta = "suelos2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Suelo-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Suelo-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Suelo-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Suelo-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Suelo-Labsys", vbNormalFocus)

        ElseIf carpeta = "fito2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010 Fitopatologicos", vbNormalFocus)
        ElseIf carpeta = "fito2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011 Fitopatologicos", vbNormalFocus)
        ElseIf carpeta = "fito2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012 Fitopatologicos", vbNormalFocus)
        ElseIf carpeta = "fito2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013 Fitopatologicos", vbNormalFocus)
        ElseIf carpeta = "fito2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014 Fitopatologicos", vbNormalFocus)

        ElseIf carpeta = "aguas2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Agua-Labsys", vbNormalFocus)
        ElseIf carpeta = "aguas2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Agua-Labsys", vbNormalFocus)
        ElseIf carpeta = "aguas2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Agua-Labsys", vbNormalFocus)
        ElseIf carpeta = "aguas2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Agua-Labsys", vbNormalFocus)
        ElseIf carpeta = "aguas2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Agua-Labsys", vbNormalFocus)


        ElseIf carpeta = "bac2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Bactereologicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "bac2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Bactereologicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "bac2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Bactereologicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "bac2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Bactereologicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "bac2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Bactereologicos-Labsys", vbNormalFocus)

        ElseIf carpeta = "quimicos2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.FertQimicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "quimicos2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.FertQimicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "quimicos2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.FertQimicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "quimicos2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.FertQimicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "quimicos2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.FertQimicos-Labsys", vbNormalFocus)


        ElseIf carpeta = "fitopdf2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010 Fitopatologicos PDF", vbNormalFocus)
        ElseIf carpeta = "fitopdf2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011 Fitopatologicos PDF", vbNormalFocus)
        ElseIf carpeta = "fitopdf2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012 Fitopatologicos PDF", vbNormalFocus)
        ElseIf carpeta = "fitopdf2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013 Fitopatologicos PDF", vbNormalFocus)
        ElseIf carpeta = "fitopdf2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014 Fitopatologicos PDF", vbNormalFocus)

        ElseIf carpeta = "organicos2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.FertOrganicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "organicos2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.FertOrganicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "organicos2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.FertOrganicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "organicos2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.FertOrganicos-Labsys", vbNormalFocus)
        ElseIf carpeta = "organicos2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.FertOrganicos-Labsys", vbNormalFocus)

        ElseIf carpeta = "foliar2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Foliar-Labsys", vbNormalFocus)
        ElseIf carpeta = "foliar2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Foliar-Labsys", vbNormalFocus)
        ElseIf carpeta = "foliar2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Foliar-Labsys", vbNormalFocus)
        ElseIf carpeta = "foliar2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Foliar-Labsys", vbNormalFocus)
        ElseIf carpeta = "foliar2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Foliar-Labsys", vbNormalFocus)




        ElseIf carpeta = "frutos2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Frutos-Labsys", vbNormalFocus)
        ElseIf carpeta = "frutos2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Frutos-Labsys", vbNormalFocus)
        ElseIf carpeta = "frutos2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Frutos-Labsys", vbNormalFocus)
        ElseIf carpeta = "frutos2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Frutos-Labsys", vbNormalFocus)
        ElseIf carpeta = "frutos2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Frutos-Labsys", vbNormalFocus)


        ElseIf carpeta = "nema2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Nematodos-Labsys", vbNormalFocus)
        ElseIf carpeta = "nema2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Nematodos-Labsys", vbNormalFocus)
        ElseIf carpeta = "nema2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Nematodos-Labsys", vbNormalFocus)
        ElseIf carpeta = "nema2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Nematodos-Labsys", vbNormalFocus)
        ElseIf carpeta = "nema2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Nematodos-Labsys", vbNormalFocus)


        ElseIf carpeta = "guano2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Guanos Bacteriologicos", vbNormalFocus)
        ElseIf carpeta = "guano2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011 Guanos Bacteriologicos", vbNormalFocus)
        ElseIf carpeta = "guano2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012 Guanos Bacteriologicos", vbNormalFocus)
        ElseIf carpeta = "guano2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013 Guanos Bacteriologicos", vbNormalFocus)
        ElseIf carpeta = "guano2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014 Guanos Bacteriologicos", vbNormalFocus)

        ElseIf carpeta = "suelos2010" Then
            Shell("explorer.exe root = F:\Mis documentos\2010.Suelos-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2011" Then
            Shell("explorer.exe root = F:\Mis documentos\2011.Suelos-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2012" Then
            Shell("explorer.exe root = F:\Mis documentos\2012.Suelos-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2013" Then
            Shell("explorer.exe root = F:\Mis documentos\2013.Suelos-Labsys", vbNormalFocus)
        ElseIf carpeta = "suelos2014" Then
            Shell("explorer.exe root = F:\Mis documentos\2014.Suelos-Labsys", vbNormalFocus)

        ElseIf carpeta = "otPDF" Then
            Shell("explorer.exe root = F:\Mis documentos\OT", vbNormalFocus)

        ElseIf carpeta = "facturas2007" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2007", vbNormalFocus)
        ElseIf carpeta = "facturas2008" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2008", vbNormalFocus)
        ElseIf carpeta = "facturas2009" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2009", vbNormalFocus)
        ElseIf carpeta = "facturas2010" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2010", vbNormalFocus)
        ElseIf carpeta = "facturas2011" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2011", vbNormalFocus)
        ElseIf carpeta = "facturas2012" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2012", vbNormalFocus)
        ElseIf carpeta = "facturas2013" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2013", vbNormalFocus)
        ElseIf carpeta = "facturas2014" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Facturas 2014", vbNormalFocus)


        ElseIf carpeta = "ot2010" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Ordenes de Trabajo 2010", vbNormalFocus)
        ElseIf carpeta = "ot2011" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Ordenes de Trabajo 2011", vbNormalFocus)
        ElseIf carpeta = "ot2012" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Ordenes de Trabajo 2012", vbNormalFocus)
        ElseIf carpeta = "ot2013" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Ordenes de Trabajo 2013", vbNormalFocus)
        ElseIf carpeta = "ot2014" Then
            Shell("explorer.exe root = F:\Mis documentos\LabSys-Pruebas\Ordenes de Trabajo 2014", vbNormalFocus)


        ElseIf carpeta = "cartas" Then
            Shell("explorer.exe root =  F:\Mis documentos\Cartas", vbNormalFocus)

        ElseIf carpeta = "escaneadas2012" Then
            Shell("explorer.exe root =    F:\Mis documentos\Facturas Scaneadas 2012", vbNormalFocus)
        ElseIf carpeta = "escaneadas2013" Then
            Shell("explorer.exe root =    F:\Mis documentos\Facturas Scaneadas 2013", vbNormalFocus)
        ElseIf carpeta = "escaneadas2014" Then
            Shell("explorer.exe root =    F:\Mis documentos\Facturas Scaneadas 2014", vbNormalFocus)
        End If


    End Sub


 
    Private Sub yemas2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yemas2010.Click
        carpeta = "yemas2010"
        abrir_carpeta()
    End Sub

    Private Sub yemas2011_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yemas2011.Click
        carpeta = "yemas2011"
        abrir_carpeta()
    End Sub

    Private Sub yemas2012_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yemas2012.Click
        carpeta = "yemas2012"
        abrir_carpeta()
    End Sub

    Private Sub yemas2013_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yemas2013.Click
        carpeta = "yemas2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem72.Click
        carpeta = "yemas2014"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        carpeta = "fito2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        carpeta = "fito2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem39.Click
        carpeta = "fito2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem40.Click
        carpeta = "fito2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem62.Click
        carpeta = "fito2014"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem33.Click
        carpeta = "aguas2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        carpeta = "aguas2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        carpeta = "aguas2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem36.Click
        carpeta = "aguas2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem63.Click
        carpeta = "aguas2014"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        carpeta = "bac2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        carpeta = "bac2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        carpeta = "bac2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
        carpeta = "bac2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem64.Click
        carpeta = "bac2014"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        carpeta = "quimicos2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click
        carpeta = "quimicos2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        carpeta = "quimicos2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        carpeta = "quimicos2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem65.Click
        carpeta = "quimicos2014"
        abrir_carpeta()
    End Sub


    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        carpeta = "organicos2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        carpeta = "organicos2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        carpeta = "organicos2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        carpeta = "organicos2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem66.Click
        carpeta = "organicos2014"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        carpeta = "foliar2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        carpeta = "foliar2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        carpeta = "foliar2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        carpeta = "foliar2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem68.Click
        carpeta = "foliar2014"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        carpeta = "frutos2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        carpeta = "frutos2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        carpeta = "frutos2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        carpeta = "frutos2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem69.Click
        carpeta = "frutos2014"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        carpeta = "nema2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        carpeta = "nema2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        carpeta = "nema2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        carpeta = "nema2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem70.Click
        carpeta = "nema2014"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        carpeta = "suelos2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        carpeta = "suelos2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        carpeta = "suelos2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        carpeta = "suelos2013"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem71.Click
        carpeta = "suelos2014"
        abrir_carpeta()
    End Sub



    Private Sub ToolStripMenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem41.Click
        carpeta = "facturas2007"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem42.Click
        carpeta = "facturas2008"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem43.Click
        carpeta = "facturas2009"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem44.Click
        carpeta = "facturas2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem45.Click
        carpeta = "facturas2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem46.Click
        carpeta = "facturas2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem47.Click
        carpeta = "facturas2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem73.Click
        carpeta = "facturas2014"
        abrir_carpeta()
    End Sub
    Private Sub OrdenEnPDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenEnPDFToolStripMenuItem.Click
        carpeta = "otPDF"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        carpeta = "ot2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem49.Click
        carpeta = "ot2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem50.Click
        carpeta = "ot2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem51.Click
        carpeta = "ot2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem74.Click
        carpeta = "ot2014"
        abrir_carpeta()
    End Sub
    Private Sub CartasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartasToolStripMenuItem.Click
        carpeta = "cartas"
        abrir_carpeta()
    End Sub




    Private Sub MantenedorDeEstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenedorDeEstadosToolStripMenuItem.Click

    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem1.Click
        Dim fac As New Frm_Modifica_Estado_Factura
        fac.MdiParent = Me
        fac.Show()
    End Sub

    Private Sub ÓrdenesDeTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÓrdenesDeTrabajoToolStripMenuItem.Click
        Dim pantalla As New F_Modifica_Estado_OT
        pantalla.MdiParent = Me
        pantalla.Show()
    End Sub

    Private Sub NLaboratoriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NLaboratoriosToolStripMenuItem.Click
        Dim nLab As New F_Modifica_Estado_Nlab
        nLab.MdiParent = Me
        nLab.Show()
    End Sub

    Private Sub ManualDeUsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsoToolStripMenuItem.Click
        MsgBox("Aún no está disponible, Versión 11.14", MsgBoxStyle.Information, "LabSys")
    End Sub

    Private Sub ToolStripMenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem52.Click
        carpeta = "escaneadas2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem53.Click
        carpeta = "escaneadas2013"
        abrir_carpeta()
    End Sub


    Private Sub NegroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ToolStrip1.BackColor = Color.Black
    End Sub

    Private Sub BlancoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ToolStrip1.BackColor = Color.White
    End Sub

    Private Sub AzulPredeterminadoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToolStrip1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub ToolStripMenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem54.Click
        carpeta = "guano2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem55.Click
        carpeta = "guano2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem56.Click
        carpeta = "guano2013"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem67.Click
        carpeta = "guano2014"
        abrir_carpeta()
    End Sub
    Private Sub ToolStripMenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem57.Click
        carpeta = "guano2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem58.Click
        carpeta = "fitopdf2010"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem59.Click
        carpeta = "fitopdf2011"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem60.Click
        carpeta = "fitopdf2012"
        abrir_carpeta()
    End Sub

    Private Sub ToolStripMenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem61.Click
        carpeta = "fitopdf2013"
        abrir_carpeta()
    End Sub

    Private Sub LibroVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibroVentasToolStripMenuItem.Click
        Dim fac As New F_LibroVentas
        fac.MdiParent = Me
        fac.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim resul As New Frm_EnviaResultados
        resul.MdiParent = Me
        resul.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resul As New Frm_EliminaFactura
        resul.MdiParent = Me
        resul.Show()
    End Sub

    Private Sub ToolStripButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim resul As New FRM_COM
        resul.MdiParent = Me
        resul.Show()
    End Sub

    Private Sub ResultadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultadosToolStripMenuItem1.Click
        Dim resul As New FRM_ESTADO_RESULTADOS
        resul.MdiParent = Me
        resul.Show()
    End Sub

    Private Sub F_Menu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown


        If e.KeyCode = 116 Then
            Dim resul As New FRM_COM
            resul.MdiParent = Me
            resul.Show()

        End If


        If e.KeyCode = 115 Then
            F_OrdenTrabajo.Refresh()
            F_OrdenTrabajo.ResetText()
            Dim ordenTrabajo As New F_OrdenTrabajo
            Tipo_Ingreso_OT = "Normal"
            ordenTrabajo.MdiParent = Me
            ordenTrabajo.Show()

        End If
    End Sub



    Private Sub ReajusteDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReajusteDePreciosToolStripMenuItem.Click
        Dim resul As New Frm_Reajuste_Precios
        resul.MdiParent = Me
        resul.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim resul As New Form_Pruebas
        resul.MdiParent = Me
        resul.Show()
    End Sub




    Private Sub ToolStripMenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem75.Click
        MsgBox("Obtener desde PROFACTURA")
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim resul As New F_ResultadosGenerados
        resul.MdiParent = Me
        resul.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim resul As New F_Despachados_xFacturar
        resul.MdiParent = Me
        resul.Show()
    End Sub

    Private Sub SueloFertilidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SueloFertilidadToolStripMenuItem.Click
        CodMuestraRev = 4000
        Dim fol As New Frm_Pantalla_Revision2
        fol.MdiParent = Me
        fol.Show()
    End Sub

    Private Sub RSueloToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RSueloToolStripMenuItem3.Click
        CodMuestraRev = 4500
        Dim fol As New Frm_Pantalla_Revision2
        fol.MdiParent = Me
        fol.Show()
    End Sub


    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click

        Dim resul As New F_TraspasoYemas
        resul.MdiParent = Me
        resul.Show()
    End Sub
End Class