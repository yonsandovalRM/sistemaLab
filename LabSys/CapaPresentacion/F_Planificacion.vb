Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.SqlClient

Public Class F_Planificacion

    Public dataTableOT As New Data.DataTable
    Private Imprime_Plani As New Genera_Excel_B
    Private Posicion_EncDato, Codigo_NumLabDesde, NumLabDesde, NumLabDesde2, Posicion_ElemDatos, Valor_ScrollV, Valor_ScrollH, Fila_Grilla, Columna_Grilla, ffi, iPtr As Integer
    Private MM, MM2, TMU_CODI As String
    Private cFoliar1, cAgua1, cSuelo1, cOtros1, cPlani1, cTotal1, Mod_Cont, Cuenta_Elementos As Integer
    Private rFoliar1, rAgua1, rSuelo1, rOtros1 As Integer
    Private NLabD1, NLabD2, NLabD3, NLabD4, NLabD5, NLabD6 As Integer
    Private NLabH1, NLabH2, NLabH3, NLabH4, NLabH5, NLabH6 As Integer
    Private Primer1000, Primer2000, Primer3000, Primer4000, Primer5000, Primer6000, Primo, Primo2 As String
    Private GranuloSeccionDos As Boolean = False

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim DUrg, Empresa_aux, Remitente_Aux, Urgente_Aux, query, NumerosLab, Fecha_Ot, Fecha_Despacho, Primera, Orden_Aux As String
        Dim Linea, paso As Integer
        Dim dbman As DbManager
        Dim Fila_Consulta, Fila_Pla, FILA_TESTIGO, FILA_ESTANDAR As DataRow
        cFoliar1 = 0
        cAgua1 = 0
        cSuelo1 = 0
        cOtros1 = 0
        cPlani1 = 0
        cTotal1 = 0
        Mod_Cont = 1
        FilaMarcaX = "N"
        Es_Planificacion = "S"
        Codigo_NumLabDesde = 0

        Call Anti_Elimina_lineas()

        Dim cd As New CapaDato
        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectElemento", Cjto_Tablas1, "ELEMENTO")

        ' Call TransformaMultilinea(DG_Planificacion)
        Cjto_Tablas1.Tables("CONSULTA_OT_OTCOD").Clear()

        If Me.chFecha.Checked = True Then
            Dim arr, arr2 As Array
            Dim desde, hasta As String
            arr = Split(Me.dfDesde.Text, "-")
            arr2 = Split(Me.dfHasta.Text, "-")
            '2009-08-03'
            desde = arr(2).ToString & "-" & arr(0).ToString & "-" & arr(1).ToString
            hasta = arr2(2).ToString & "-" & arr2(0).ToString & "-" & arr2(1).ToString

            query = " execute ls_ObtieneDatosPlanificacion '" & Me.txNotDesde.Text & "','" & Me.txNotHasta.Text & "','" & Me.txProductor.Text & "','" & Me.txCodAnalisis.Text & "','" & Me.txAnalisis.Text & "','" & _
         Me.chFoliar.Checked & "','" & Me.chAgua.Checked & "','" & Me.chSuelo.Checked & "','" & Me.chOtros.Checked & "','" & desde & "','" & hasta & "','" & Me.chUrgente.Checked & "'"

        Else
            query = " execute ls_ObtieneDatosPlanificacion '" & Me.txNotDesde.Text & "','" & Me.txNotHasta.Text & "','" & Me.txProductor.Text & "','" & Me.txCodAnalisis.Text & "','" & Me.txAnalisis.Text & "','" & _
          Me.chFoliar.Checked & "','" & Me.chAgua.Checked & "','" & Me.chSuelo.Checked & "','" & Me.chOtros.Checked & "','','','" & Me.chUrgente.Checked & "'"
        End If


        dbman = New DbManager("CONSULTA_OT_OTCOD", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)
        Linea = 0 : Orden_Aux = 0 : Primera = "S" : DUrg = "N"
        Cjto_Tablas1.Tables("PLANIFICACION").Clear()

        For Each Fila_Consulta In Cjto_Tablas1.Tables("CONSULTA_OT_OTCOD").Rows
            Linea = Linea + 1
            NumerosLab = Fila_Consulta("OTC_NLAB_DESDE") & "-" & Mid(CStr(Fila_Consulta("OTC_NLAB_HASTA")), (Len(CStr(Fila_Consulta("OTC_NLAB_HASTA"))) - 2))
            Fecha_Ot = CStr(Fila_Consulta.Item("OT_FECHA_ORDEN"))
            Fecha_Ot = Mid(Fecha_Ot, 1, 2) & "/" & Mid(Fecha_Ot, 4, 2)

            Fecha_Despacho = CStr(Fila_Consulta.Item("OT_DESP_FECHA"))
            Fecha_Despacho = Mid(Fecha_Despacho, 1, 2) & "/" & Mid(Fecha_Despacho, 4, 2)
            Fila_Pla = Cjto_Tablas1.Tables("PLANIFICACION").NewRow
            Fila_Pla.BeginEdit()
            Fila_Pla.Item("MARCA") = ""

            If Primera = "S" Then
                If IsDBNull(Fila_Consulta.Item("OT_DESP_URGENTE")) = False Then
                    If Fila_Consulta.Item("OT_DESP_URGENTE") Then Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO")) & " U" Else Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO"))
                End If
                Fila_Pla.Item("PRO_PRODUCTOR") = Fila_Consulta.Item("PRO_PRODUCTOR")
                Fila_Pla.Item("OT_FECHA_ORDEN") = Fecha_Ot
                Fila_Pla.Item("OT_DESP_FECHA") = Fecha_Despacho
                Fila_Pla.Item("PRO_EMPRESA") = Fila_Consulta.Item("OT_EMPRESA")
                Fila_Pla.Item("PRO_REMITE") = Fila_Consulta.Item("OT_REMITE")
                Fila_Pla.Item("OT_LOCALIDAD") = Fila_Consulta.Item("OT_LOCALIDAD")
                GoTo primera
            End If

            If IsDBNull(Fila_Consulta.Item("OT_DESP_URGENTE")) = False Then
                If Fila_Consulta.Item("OT_DESP_URGENTE") Then Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO")) & " U" Else Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO"))
            End If
            Fila_Pla.Item("PRO_PRODUCTOR") = Fila_Consulta.Item("PRO_PRODUCTOR")
            Fila_Pla.Item("OT_FECHA_ORDEN") = Fecha_Ot
            Fila_Pla.Item("OT_DESP_FECHA") = Fecha_Despacho
            Fila_Pla.Item("OT_LOCALIDAD") = Fila_Consulta.Item("OT_LOCALIDAD")
            Fila_Pla.Item("PRO_EMPRESA") = Fila_Consulta.Item("OT_EMPRESA")
            Fila_Pla.Item("PRO_REMITE") = Fila_Consulta.Item("OT_REMITE")
primera:
            Primera = "N"
            Fila_Pla.Item("OTC_CANT_MUESTRAS") = Fila_Consulta.Item("OTC_CANT_MUESTRAS")
            If Mid(CStr(Fila_Consulta.Item("ANA_CODIGO")), 1, 1) = 1 Then
                Fila_Pla.Item("NUMLAB1") = NumerosLab
                Fila_Pla.Item("NUMLAB2") = ""
                Fila_Pla.Item("NUMLAB3") = ""
                Fila_Pla.Item("NUMLAB4") = "" : GoTo LABORATORIO
            Else
                Fila_Pla.Item("NUMLAB1") = ""
            End If
            If Mid(CStr(Fila_Consulta.Item("ANA_CODIGO")), 1, 1) = 3 Then
                Fila_Pla.Item("NUMLAB2") = NumerosLab
                Fila_Pla.Item("NUMLAB3") = ""
                Fila_Pla.Item("NUMLAB4") = "" : GoTo LABORATORIO
            Else
                Fila_Pla.Item("NUMLAB2") = ""
            End If
            If Mid(CStr(Fila_Consulta.Item("ANA_CODIGO")), 1, 1) = 4 Then
                Fila_Pla.Item("NUMLAB3") = NumerosLab
                Fila_Pla.Item("NUMLAB4") = "" : GoTo LABORATORIO
            Else
                Fila_Pla.Item("NUMLAB3") = ""
            End If
            Fila_Pla.Item("NUMLAB4") = NumerosLab
LABORATORIO:

            'Empresa_aux = Fila_Consulta.Item("OT_EMPRESA")
            'Remitente_Aux = Fila_Consulta.Item("OT_REMITE")
            Fila_Pla.Item("ANA_CODIGO") = Fila_Consulta.Item("ANA_CODIGO")
            Fila_Pla.Item("ANA_ANALISIS") = Fila_Consulta.Item("ANA_ANALISIS")
            Fila_Pla.Item("OT_LINEA") = Linea
            Fila_Pla.EndEdit()
            Cjto_Tablas1.Tables("PLANIFICACION").Rows.Add(Fila_Pla)
            Orden_Aux = CStr(Fila_Consulta.Item("OT_NUMERO"))
        Next
        '''hasta aqui solamente le ha asignado los valores de la consulta a la tabla "Planificacion" que carga la grilla , nada de colores y otros
        ''' 
        Call Traspaso_Planificacion1()

        'Call lleno_filas_scroll(Linea)

        Dim Fila1 As DataRow
        Dim NumOT As String, CantMues As Integer
        For Each Fila1 In Cjto_Tablas1.Tables("PLANIFICACION").Rows
            NumOT = Fila1("OT_NUMERO")
            If IsDBNull(Fila1("OTC_CANT_MUESTRAS")) = False Then
                cTotal1 = cTotal1 + CInt(Fila1("OTC_CANT_MUESTRAS"))
                If Fila1("NUMLAB1") <> "" Then
                    cFoliar1 = cFoliar1 + CInt(Fila1("OTC_CANT_MUESTRAS"))
                End If
                If Fila1("NUMLAB2") <> "" Then
                    cAgua1 = cAgua1 + CInt(Fila1("OTC_CANT_MUESTRAS"))
                End If
                If Fila1("NUMLAB3") <> "" Then
                    cSuelo1 = cSuelo1 + CInt(Fila1("OTC_CANT_MUESTRAS"))
                End If
                If Fila1("NUMLAB4") <> "" Then
                    cOtros1 = cOtros1 + CInt(Fila1("OTC_CANT_MUESTRAS"))
                End If
            End If
        Next

        Me.txCantFoliar.Text = cFoliar1
        Me.txCantAgua.Text = cAgua1
        Me.txCantSuelo.Text = cSuelo1
        Me.txCantOtros.Text = cOtros1

        Me.txCantTotal.Text = cTotal1

        AddCellFormattingColumnStyles(Me.DG_Planificacion, New FormatCellEventHandler(AddressOf FormatGridCells))
        'Call Rescata_Testigo_Estandar_Cant()

    End Sub

    Private Sub Rescata_Testigo_Estandar_Cant()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANIFOLIAR")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANIFOLIAR")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
            Me.TxtCantBlancosFoliar.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
        '********************
        'TEJIDOS
        '********************
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANITEJIDOS")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANITEJIDOS")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
            Me.TxtCantBlancosTejidos.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
        '********************
        'AGUA
        '********************
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANIAGUA")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANIAGUA")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
            Me.TxtCantBlancosAgua.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
        '********************
        'SUELO
        '********************
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANISUELO")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANISUELO")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
            Me.TxtCantBlancosSuelo.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
        '********************
        'FERTQUI
        '********************
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANIFERTQUI")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANIFERTQUI")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
            Me.TxtCantBlancosFertQui.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
        '********************
        'FERTORG
        '********************
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANIFERTORG")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANIFERTORG")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
            Me.TxtCantBlancosFertOrg.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
        '********************
        'OTROSANALISIS
        '********************
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 7000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANIOTROSANALISIS")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 7000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANIOTROSANALISIS")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 7000, SqlDbType.Int)
            Me.TxtCantBlancosOtrosAnalisis.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
        '********************
        'VENTAS
        '********************
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "T", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 8000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "TESTIGO_PLANIVENTAS")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "E", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 8000, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectPlanificacionParametros", Cjto_Tablas1, "ESTANDAR_PLANIVENTAS")
        End With
        With SP
            .Inicializar()
            .AgregarParametro("@TipoParametro", "C", SqlDbType.NVarChar)
            .AgregarParametro("@TMuestra", 8000, SqlDbType.Int)
            Me.TxtCantBlancosVentas.Text = .EjecutarEscalar("usp_SelectPlanificacionParametros")
        End With
    End Sub

    Private Sub Traspaso_Planificacion1()
        Dim Fila1, Fila2 As DataRow
        Cjto_Tablas1.Tables("PLANIFICACION1").Clear()
        For Each Fila1 In Cjto_Tablas1.Tables("PLANIFICACION").Rows
            Fila2 = Cjto_Tablas1.Tables("PLANIFICACION1").NewRow
            Fila2.BeginEdit()
            Fila2.Item("MARCA") = Fila1.Item("MARCA")
            Fila2.Item("OT_NUMERO") = Fila1.Item("OT_NUMERO")
            Fila2.Item("PRO_PRODUCTOR") = Fila1.Item("PRO_PRODUCTOR")
            Fila2.Item("OT_FECHA_ORDEN") = Fila1.Item("OT_FECHA_ORDEN")
            Fila2.Item("OT_DESP_FECHA") = Fila1.Item("OT_DESP_FECHA")
            Fila2.Item("PRO_EMPRESA") = Fila1.Item("PRO_EMPRESA")
            Fila2.Item("PRO_REMITE") = Fila1.Item("PRO_REMITE")
            Fila2.Item("OT_LOCALIDAD") = Fila1.Item("OT_LOCALIDAD")
            Fila2.Item("OTC_CANT_MUESTRAS") = Fila1.Item("OTC_CANT_MUESTRAS")
            If IsDBNull(Fila1("NUMLAB1")) = False Then Fila2("NUMLAB1") = Fila1("NUMLAB1")
            If IsDBNull(Fila1("NUMLAB2")) = False Then Fila2("NUMLAB2") = Fila1("NUMLAB2")
            If IsDBNull(Fila1("NUMLAB3")) = False Then Fila2("NUMLAB3") = Fila1("NUMLAB3")
            If IsDBNull(Fila1("NUMLAB4")) = False Then Fila2("NUMLAB4") = Fila1("NUMLAB4")
            Fila2.Item("ANA_CODIGO") = Fila1.Item("ANA_CODIGO")
            Fila2.Item("ANA_ANALISIS") = Fila1.Item("ANA_ANALISIS")
            Fila2.Item("OT_LINEA") = Fila1.Item("OT_LINEA")
            Fila2.EndEdit()
            Cjto_Tablas1.Tables("PLANIFICACION1").Rows.Add(Fila2)
        Next
    End Sub

    Private Sub lleno_filas_scroll(ByVal linea As Integer)
        Dim Fila_Pla As DataRow
        Dim BuscaLinea As Object
        Dim nn As Integer
        For nn = (linea + 1) To linea + 1
            Fila_Pla = Cjto_Tablas1.Tables("PLANIFICACION").NewRow
            Fila_Pla.Item("MARCA") = ""
            Fila_Pla.Item("OT_NUMERO") = "0"
            Fila_Pla.Item("OT_FECHA_ORDEN") = "******"
            Fila_Pla.Item("OT_DESP_FECHA") = "******"
            Fila_Pla.Item("PRO_PRODUCTOR") = " ****  FINAL *****"
            Fila_Pla.Item("OTC_CANT_MUESTRAS") = "0"
            Fila_Pla.Item("NUMLAB1") = "*"
            Fila_Pla.Item("NUMLAB2") = "*"
            Fila_Pla.Item("NUMLAB3") = "*"
            Fila_Pla.Item("NUMLAB4") = "*"
            Fila_Pla.Item("ANA_CODIGO") = 0
            Fila_Pla.Item("ANA_ANALISIS") = "************************************ FINAL ****************************************"
            Fila_Pla.Item("OT_LOCALIDAD") = "**********"
            Fila_Pla.Item("PRO_EMPRESA") = "**********"
            Fila_Pla.Item("PRO_REMITE") = "**********"
            Fila_Pla.Item("OT_LINEA") = nn
            Cjto_Tablas1.Tables("PLANIFICACION").Rows.Add(Fila_Pla)
        Next
        'For nn = (linea + 1) To linea + 30
        '    BuscaLinea = nn
        '    Fila_Pla = Cjto_Tablas1.Tables("PLANIFICACION").Rows.Find(BuscaLinea)
        '    If Not (Fila_Pla Is Nothing) Then
        '        Cjto_Tablas1.Tables("PLANIFICACION").Rows.Remove(Fila_Pla)
        '    End If
        'Next
    End Sub

    Private Sub Anti_Elimina_lineas()
        DG_Planificacion.DataSource = Cjto_Tablas1.Tables("PLANIFICACION")
        DTGEstandarFoliar.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANIFOLIAR")
        DTGTestigoFoliar.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANIFOLIAR")
        DTGDuplicadosFoliar.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANIFOLIAR")

        DTGEstandarTejidos.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANITEJIDOS")
        DTGTestigoTejidos.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANITEJIDOS")
        DTGDuplicadosTejidos.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANITEJIDOS")

        DTGEstandarAgua.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANIAGUA")
        DTGTestigoAgua.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANIAGUA")
        DTGDuplicadosAgua.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANIAGUA")

        DTGEstandarSuelo.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANISUELO")
        DTGTestigoSuelo.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANISUELO")
        DTGDuplicadosSuelo.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANISUELO")

        DTGEstandarFertQui.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANIFERTQUI")
        DTGTestigoFertQui.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANIFERTQUI")
        DTGDuplicadosFertQui.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANIFERTQUI")

        DTGEstandarFertOrg.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANIFERTORG")
        DTGTestigoFertOrg.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANIFERTORG")
        DTGDuplicadosFertOrg.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANIFERTORG")

        DTGEstandarOtrosAnalisis.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANIOTROSANALISIS")
        DTGTestigoOtrosAnalisis.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANIOTROSANALISIS")
        DTGDuplicadosOtrosAnalisis.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANIOTROSANALISIS")

        DTGEstandarVentas.DataSource = Cjto_Tablas1.Tables("ESTANDAR_PLANIVENTAS")
        DTGTestigoVentas.DataSource = Cjto_Tablas1.Tables("TESTIGO_PLANIVENTAS")
        DTGDuplicadosVentas.DataSource = Cjto_Tablas1.Tables("DUPLICA_PLANIVENTAS")
    End Sub

    Private Sub AddCellFormattingColumnStyles(ByVal grid As DataGrid, ByVal handler As FormatCellEventHandler)
        Dim Colum As Integer
        Dim ts As DataGridTableStyle
        Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        Dim mydv As DataView = CType(mycm.List, DataView)
        ts = New DataGridTableStyle
        Dim dt As DataTable
        Dim row As DataRow
        Dim S As String
        dt = CType(grid.DataSource, DataTable)
        'FILA_DATAGRID4 = myGrid.CurrentCell.RowNumber
        'myGrid.Item(FILA_DATAGRID4, 1)
        ts.MappingName = dt.TableName
        Dim j, fil As Integer
        j = 0
        fil = 0

        'Dim x = ds.Tables(0).Rows.Count()
        'Dim mydatatable As DataTable = ds.Tables(0)

        'Dim mydataview As DataView = mydatatable.DefaultView
        '' mydataview.Sort = "Date Closed"  'sort table 
        'dgtabhistory.DataSource = mydataview 'binds data to grid 


        Dim numRows As Integer = grid.BindingContext(grid.DataSource, grid.DataMember).Count
        'txRecCountHistory.Text = "Count: " + CStr(numRows.ToString)


        Do While (j < dt.Columns.Count)
            fil = fil + 1
            Dim cs As DataGridFormattableTextBoxColumn

            cs = New DataGridFormattableTextBoxColumn(j)
            cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
            cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
            cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
            cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
            cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
            cs.grid = grid
            AddHandler cs.SetCellFormat, handler
            If j >= 13 Then
                ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
            ElseIf j = 12 Then
                Dim cs2 As New CGridMultiLineTextBoxStyle(grid.TableStyles(0).GridColumnStyles(j).MappingName, j)
                cs2.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs2.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs2.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs2.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs2.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs2.grid = grid
                AddHandler cs2.SetCellFormat, handler

                'If (grid.CurrentRowIndex < numRows) And (grid.CurrentRowIndex > -1) Then
                '    numRows()
                '    grid.CurrentRowIndex = 20 'numRows + 100
                '    'ContactHistoryActivityID = CStr(grid(grid.CurrentRowIndex, 13).ToString) 'store current activity id 
                'End If

                ts.GridColumnStyles.Add(cs2)
            Else
                ts.GridColumnStyles.Add(cs)
            End If
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub

    Private Sub FormatGridCells(ByVal sender As Object, ByVal e As DataGridFormatCellEventArgs, ByVal grid As DataGrid)
        'color row 1 red
        'color column 4 blue
        'Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        ' Retrieve the default DataView of the DataGrid
        'Dim mydv As DataView = CType(mycm.List, DataView)
        ' Use Currency Manager and DataView to retrieve the Current Row
        'Dim row As DataRow
        Dim j As Integer
        j = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFecha.CheckedChanged

        If Me.dfDesde.Enabled = False Then
            Me.dfDesde.Enabled = True
            Me.dfHasta.Enabled = True
        Else
            Me.dfDesde.Enabled = False
            Me.dfHasta.Enabled = False

        End If

    End Sub

    Private Sub dgPlanificar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        'Dim nLabArr As Array
        'Dim nLabDesde As String
        'Dim nLabHasta As String

        'Dim codigo As String = dgPlanificar.Rows(e.RowIndex).Cells(12).Value.ToString

        'If e.ColumnIndex = 0 Then
        '    If dgPlanificar.Rows(e.RowIndex).Cells(0).Value = True Then
        '        dgPlanificar.Rows(e.RowIndex).Cells(0).Value = False



        '    Else

        '        If codigo >= 1000 And codigo < 2000 Then

        '            dgPlanificar.Rows(e.RowIndex).Cells(0).Value = True
        '            nLabArr = Split(dgPlanificar.Rows(e.RowIndex).Cells(7).Value().ToString, "-")
        '            nLabDesde = nLabArr(0).ToString
        '            nLabHasta = nLabArr(1).ToString


        '        ElseIf codigo >= 3000 And codigo < 4000 Then

        '            dgPlanificar.Rows(e.RowIndex).Cells(0).Value = True
        '            nLabArr = Split(dgPlanificar.Rows(e.RowIndex).Cells(8).Value().ToString, "-")
        '            nLabDesde = nLabArr(0).ToString
        '            nLabHasta = nLabArr(1).ToString

        '        ElseIf codigo >= 4000 And codigo < 5000 Then

        '            dgPlanificar.Rows(e.RowIndex).Cells(0).Value = True
        '            nLabArr = Split(dgPlanificar.Rows(e.RowIndex).Cells(9).Value().ToString, "-")
        '            nLabDesde = nLabArr(0).ToString
        '            nLabHasta = nLabArr(1).ToString

        '        ElseIf codigo >= 2000 And codigo < 3000 Then

        '            dgPlanificar.Rows(e.RowIndex).Cells(0).Value = True
        '            nLabArr = Split(dgPlanificar.Rows(e.RowIndex).Cells(10).Value().ToString, "-")
        '            nLabDesde = nLabArr(0).ToString
        '            nLabHasta = nLabArr(1).ToString

        '        ElseIf codigo >= 5000 Then

        '            dgPlanificar.Rows(e.RowIndex).Cells(0).Value = True
        '            nLabArr = Split(dgPlanificar.Rows(e.RowIndex).Cells(10).Value().ToString, "-")
        '            nLabDesde = nLabArr(0).ToString
        '            nLabHasta = nLabArr(1).ToString
        '        End If


        '        Dim dr As DataRow
        '        dr = dataTableOT.NewRow()
        '        dr("nOT") = dgPlanificar.Rows(e.RowIndex).Cells(1).Value
        '        dr("codAnalisis") = dgPlanificar.Rows(e.RowIndex).Cells(12).Value
        '        dr("nLabDesde") = nLabDesde
        '        dr("nLabHasta") = nLabHasta
        '        dataTableOT.Rows.Add(dr)




        '    End If
        'End If


    End Sub

    Private Sub btnParametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParametros.Click
        Me.GrbParamatros.Visible = True
        CodMuestraRev = 1000
    End Sub

    Private Sub btnImprimirOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirOT.Click
        Dim PUNTOS, PUNTOS_X, nomb, vv As String
        Dim num_ord As Integer
        Dim FILA_IMP_REC As DataRow
        Dim frmEsp As New Frm_Espere

        GrpOrdenDesde.Visible = True

    End Sub

    Private Sub btnImprimirPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPlan.Click
        Try
            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            ' Dim dbman As DbManager
            Dim MuestraPlani, Fuente, Destino, Formula, sRutaDest, sRutaDestino, LetraSpectro As String
            Dim CantBlancos, Tabla_Testigos, Tabla_Estandar, Tabla_Duplicados, query, Ele_Aux, ES_Primera, ColuD, ColuH, ColuD2, ColuH2, ColuD3, ColuH3, ColumnaFinal, Columna As String
            Dim Fila_TodosDuxA, Fila_Te, Fila_Es, Fila_EleLab, Fila_Con, Fila_Plan, Fila_Ele, Fila_NomPla, Fila_Elemento, Fila_Plani, Fila_TraspasoEle As DataRow
            Dim BuscaNomPla, BuscaEle(1), BuscaEleLab(1) As Object
            Dim Fila_Seleccion, Fila_Ordenada As DataRow()
            Dim ds As DataSet
            Dim sTmp, EleTemp, Acumula, NumLabEx, caracter As String 'Temporal para seguimiento de código.
            Dim BlancoText, IntNLab, xx As Integer
            EleTemp = ""

            Call Rescata_Testigo_Estandar_Cant()

            '********* Dim objHojaExcel, objHojaExcel1 As Excel.Worksheet
            '********* Dim m_Excel As Excel.Application
            Dim Priori, XCant, XC, XEstandar, XE, XTestigo, XT, PosGrupoCol, Mypos, Fil1, Fil2, Fil3, MaxFil, Fila, pos, Lab_Aux, Consulta_Orden, Orden_Auxiliar, NumDuplicacion, Consulta_Orden_Urgente, Orden_Auxiliar_Urgente As Integer
            Dim MyDate As Date, sAño, sMes As String

            MyDate = Today
            Select Case Month(Today)
                Case 1
                    sMes = "01 Enero"
                Case 2
                    sMes = "02 Febrero"
                Case 3
                    sMes = "03 Marzo"
                Case 4
                    sMes = "04 Abril"
                Case 5
                    sMes = "05 Mayo"
                Case 6
                    sMes = "06 Junio"
                Case 7
                    sMes = "07 Julio"
                Case 8
                    sMes = "08 Agosto"
                Case 9
                    sMes = "09 Septiembre"
                Case 10
                    sMes = "10 Octubre"
                Case 11
                    sMes = "11 Noviembre"
                Case 12
                    sMes = "12 Diciembre"
            End Select
            Ele_Aux = ""
            NumLabDesde = 0

            Cjto_Tablas1.Tables("PLANTI_ELE").Clear()
            Cjto_Tablas1.Tables("PLANTI_ELELAB").Clear()
            Cjto_Tablas1.Tables("PLANI_RESUMEN").Clear()
            Cjto_Tablas1.Tables("NO_PLANI_RESUMEN").Clear()
            Cjto_Tablas1.Tables("ANA_NLAB").Clear()

            ' ****************** Nueva seccion impresion ******************
            sAño = Year(Today)
            sRutaDestino = "F:\Archivos LabSys\Planificacion\Planificacion " & sAño

            Fuente = "F:\Archivos LabSys\Formatos Labsys\Formato Planificacion Resumen" & ".xls"

            If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
                MkDir(sRutaDestino)
            End If
            sRutaDest = sRutaDestino & "\" & sMes
            If Dir(sRutaDest, FileAttribute.Directory) = "" Then
                MkDir(sRutaDest)
            End If
            Destino = sRutaDest & "\" & MyDate & " Planificacion Diaria.xls"


            ' frmEspere.lblMsg2.Text = "Imprimiendo Planillas de Planificación y de Digitación de Resultados"
            ' frmEspere.Show()
            ' frmEspere.Refresh()
            Imprime_Plani.Crea_Excel(Fuente, Destino) 'CREA SOLAMENTE EL ARCHIVO
            'frmEspere.Select()


            '******************* fin nueva seccion *****************
            'frmEspere.lblMsg2.Text = "Imprimiendo Planilla de Planificación..."
            'frmEspere.Refresh()

            Call Imprime_Resumen_Planificacion()

            'Call Llena_Plani_Resumen(iPtr, Destino)
            For Each Fila_Plani In Cjto_Tablas1.Tables("PLANIFICACION").Rows
                If Fila_Plani("MARCA") = "x" Then
                    If Fila_Plani("NUMLAB1") <> "" Then
                        NumLabEx = Fila_Plani("NUMLAB1")
                    End If
                    If Fila_Plani("NUMLAB2") <> "" Then
                        NumLabEx = Fila_Plani("NUMLAB2")
                    End If
                    If Fila_Plani("NUMLAB3") <> "" Then
                        NumLabEx = Fila_Plani("NUMLAB3")
                    End If

                    If Fila_Plani("NUMLAB4") <> "" Then
                        NumLabEx = Fila_Plani("NUMLAB4")
                    End If
                    Exit For
                End If
            Next

            Acumula = ""
            For xx = 1 To Len(NumLabEx)
                caracter = Mid(NumLabEx, xx, 1)
                If caracter = "-" Then
                    IntNLab = CInt(Trim(Acumula))
                    Exit For
                End If
                Acumula = Acumula + caracter
            Next
            IntNLab = CInt(Acumula)

            Try
                With SP
                    .Inicializar()
                    .AgregarParametro("@FechaPlani", MyDate, SqlDbType.DateTime)
                    .AgregarParametro("@NLabDesde", IntNLab, SqlDbType.NVarChar)
                    .EjecutarQuery("usp_DeletePlanificacionPlani")
                End With
            Catch ex As Exception
                MsgBox("Error en consulta borrar planificacion")
            End Try


            For Each Fila_Plani In Cjto_Tablas1.Tables("PLANIFICACION").Rows
                'frmEspere.lblMsg2.Text = "Preparando Planillas de Digitación de Resultados..."
                'frmEspere.Refresh()
                If IsDBNull(Fila_Plani("ANA_CODIGO")) = True Then GoTo SALTOxNULO
                If Fila_Plani("MARCA") = "x" Then
                    MM = Mid(CStr(Fila_Plani("ANA_CODIGO")), 1, 1) & "000"
                    If Fila_Plani("OT_NUMERO") <> "" Then
                        sTmp = Fila_Plani("OT_NUMERO")
                        Mypos = InStr(Fila_Plani("OT_NUMERO"), "U")
                        If Mypos <> 0 Then
                            Consulta_Orden_Urgente = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1))
                        End If
                        If Mypos > 0 Then Consulta_Orden = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1)) Else Consulta_Orden = CInt(Fila_Plani("OT_NUMERO"))
                    Else
                        Consulta_Orden = Orden_Auxiliar
                    End If
                    Cjto_Tablas1.Tables("PLANTI_CODIGO").Clear()
                    Try
                        With SP
                            .Inicializar()
                            .AgregarParametro("@NumOt", Consulta_Orden, SqlDbType.Int)
                            .AgregarParametro("@CodAna", Fila_Plani("ANA_CODIGO"), SqlDbType.Float)
                            .EjecutarQueryDt("usp_SelectPlanificacionCodEle", Cjto_Tablas1, "PLANTI_CODIGO")
                        End With
                    Catch ex As Exception
                        MsgBox("Error en consulta")
                    End Try

                    For Each Fila_TraspasoEle In Cjto_Tablas1.Tables("PLANTI_CODIGO").Rows
                        Fila_Con = Cjto_Tablas1.Tables("PLANTI_ELE").NewRow
                        Fila_Con("ELE_CODIGO") = Fila_TraspasoEle("ELE_CODIGO")
                        Fila_Con("TMU_CODIGO") = Fila_TraspasoEle("TMU_CODIGO")
                        Fila_Con("ANA_CODIGO") = Fila_TraspasoEle("ANA_CODIGO")
                        Fila_Con("ELE_CAL_FORMULA") = Fila_TraspasoEle("ELE_CAL_FORMULA")
                        Fila_Con("ELE_PLANILLA") = Fila_TraspasoEle("ELE_PLANILLA")
                        Fila_Con("ELE_COMENTARIO") = Fila_TraspasoEle("ELE_COMENTARIO")
                        Fila_Con("ELE_NOMBRE") = Fila_TraspasoEle("ELE_NOMBRE")
                        Fila_Con("ELE_PRIORIDAD") = Fila_TraspasoEle("ELE_PRIORIDAD")
                        Fila_Con("ELE_PROCESO") = Fila_TraspasoEle("ELE_PROCESO")
                        Try
                            Cjto_Tablas1.Tables("PLANTI_ELE").Rows.Add(Fila_Con)
                        Catch ex As Exception
                        End Try
                    Next

                    Try
                        With SP
                            .Inicializar()
                            .AgregarParametro("@NumOt", Consulta_Orden, SqlDbType.Int)
                            .AgregarParametro("@CodAna", Fila_Plani("ANA_CODIGO"), SqlDbType.Float)
                            .EjecutarQueryDt("usp_SelectPlanificacionCodEleNLab", Cjto_Tablas1, "PLANTI_ELELAB")
                        End With
                    Catch ex As Exception
                        MsgBox("Error en consulta")
                    End Try
                End If

SALTOxNULO:
                If Fila_Plani("OT_NUMERO") <> "" And Fila_Plani("OT_NUMERO") <> "0" Then
                    Mypos = InStr(Fila_Plani("OT_NUMERO"), "U")
                    If Mypos <> 0 Then
                        Orden_Auxiliar_Urgente = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1))
                    End If
                    If Mypos > 0 Then Orden_Auxiliar = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1)) Else Orden_Auxiliar = CInt(Fila_Plani("OT_NUMERO"))
                End If
            Next

            Fila_Ordenada = Cjto_Tablas1.Tables("PLANTI_ELE").Select("", "ELE_PRIORIDAD ASC")

            Dim StrElementos As String
            For Each Fila_Ele In Fila_Ordenada
                If Fila_Ele("ELE_PROCESO") = "Autogenerado" And Fila_Ele("ELE_CODIGO") <> "%Piedra" Then GoTo SaltoxAutogenerado
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 1 Then MuestraPlani = "Foliar" : BlancoText = TxtCantBlancosFoliar.Text : Tabla_Testigos = "TESTIGO_PLANIFOLIAR" : Tabla_Estandar = "ESTANDAR_PLANIFOLIAR" : Tabla_Duplicados = "DUPLICA_PLANIFOLIAR" : MM = 1000
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 2 Then MuestraPlani = "Otros Tejidos" : BlancoText = TxtCantBlancosTejidos.Text : Tabla_Testigos = "TESTIGO_PLANITEJIDOS" : Tabla_Estandar = "ESTANDAR_PLANITEJIDOS" : Tabla_Duplicados = "DUPLICA_PLANITEJIDOS" : MM = 2000
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 3 Then MuestraPlani = "Agua" : BlancoText = TxtCantBlancosAgua.Text : Tabla_Testigos = "TESTIGO_PLANIAGUA" : Tabla_Estandar = "ESTANDAR_PLANIAGUA" : Tabla_Duplicados = "DUPLICA_PLANIAGUA" : MM = 3000
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 4 Then MuestraPlani = "Suelo" : BlancoText = TxtCantBlancosSuelo.Text : Tabla_Testigos = "TESTIGO_PLANISUELO" : Tabla_Estandar = "ESTANDAR_PLANISUELO" : Tabla_Duplicados = "DUPLICA_PLANISUELO" : MM = 4000
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 5 Then MuestraPlani = "Fertilizante Quimico" : BlancoText = TxtCantBlancosFertQui.Text : Tabla_Testigos = "TESTIGO_PLANIFERTQUI" : Tabla_Estandar = "ESTANDAR_PLANIFERTQUI" : Tabla_Duplicados = "DUPLICA_PLANIFERTQUI" : MM = 5000
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 6 Then MuestraPlani = "Fertilizante Organico" : BlancoText = TxtCantBlancosFertOrg.Text : Tabla_Testigos = "TESTIGO_PLANIFERTORG" : Tabla_Estandar = "ESTANDAR_PLANIFERTORG" : Tabla_Duplicados = "DUPLICA_PLANIFERTORG" : MM = 6000
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 7 Then MuestraPlani = "Otros Análisis" : BlancoText = TxtCantBlancosOtrosAnalisis.Text : Tabla_Testigos = "TESTIGO_PLANIOTROSANALISIS" : Tabla_Estandar = "ESTANDAR_PLANIOTROSANALISIS" : Tabla_Duplicados = "DUPLICA_PLANIOTROSANALISIS" : MM = 7000
                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 8 Then MuestraPlani = "Ventas" : BlancoText = TxtCantBlancosVentas.Text : Tabla_Testigos = "TESTIGO_PLANIVENTAS" : Tabla_Estandar = "ESTANDAR_PLANIVENTAS" : Tabla_Duplicados = "DUPLICA_PLANIVENTAS" : MM = 8000
                Imprime_Plani.Crea_Hoja_Excel(Fila_Ele("ELE_CODIGO"), 1, 18, MM)
                Imprime_Plani.SinCurva(Fila_Ele("ELE_NOMBRE"), MuestraPlani)
                Imprime_Plani.DatosI(MyDate, "Elemento", IntNLab)
                Primo = "S"
                TMU_CODI = ""
                ES_Primera = "S"
                pos = 1
                Lab_Aux = 1
                Priori = 0
                Columna = ""
                Imprime_Plani.CFilaInicial = 11
                Fila = Imprime_Plani.CFilaInicial
                Imprime_Plani.CPagina = 1
                Imprime_Plani.CFilasHoja = 42
                Imprime_Plani.CMaxFilasImp = 41

                Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Nº Lab")
                Imprime_Plani.BordesI(4, 1, Fila, Fila, "A", "F")
                Imprime_Plani.Imprime_Linea(Fila, Fila, "G", "L", 10, "Left", "Left", False, "", "", "Lectura")
                Imprime_Plani.BordesI(4, 1, Fila, Fila, "G", "L")

                'If TxtCantBlancosFoliar.Text = "" Then TxtCantBlancosFoliar.Text = 0

                If Fila_Ele("ELE_PROCESO") <> "SubAnalisis" And Fila_Ele("ELE_CODIGO") <> "%Piedra" And Fila_Ele("ELE_CODIGO") <> "Dap_terron" And Fila_Ele("ELE_CODIGO") <> "ArenaF" And Fila_Ele("ELE_CODIGO") <> "ArenaG" Then
                    If TxtCantBlancosFoliar.Text <> 0 Then
                        For XCant = 1 To BlancoText
                            Fila = Fila + 1
                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Blanco " & XCant)
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                            Priori = Priori + 1
                            Call Graba_Planilla_Plani("Blanco" & XCant, IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
                        Next
                    End If

                    If BlancoText > 1 Then
                        Fila = Fila + 1
                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "BLPromedio")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                        Priori = Priori + 1
                        Call Graba_Planilla_Plani("PromBlanco" & XCant, IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
                    End If

                    For Each Fila_Es In Cjto_Tablas1.Tables(Tabla_Estandar).Rows
                        Fila = Fila + 1
                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Es("OTC_NLAB") & "S1"))
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                        Priori = Priori + 1
                        Call Graba_Planilla_Plani((Fila_Es("OTC_NLAB") & "S1"), IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
                    Next

                    For Each Fila_Te In Cjto_Tablas1.Tables(Tabla_Testigos).Rows
                        Fila = Fila + 1
                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Te("OTC_NLAB") & "T1"))
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                        Priori = Priori + 1
                        Call Graba_Planilla_Plani(CStr(Fila_Te("OTC_NLAB") & "T1"), IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
                    Next

                End If

                Fila_Seleccion = Cjto_Tablas1.Tables("PLANTI_ELELAB").Select("", "")
                For Each Fila_Plan In Fila_Seleccion
                    If Fila_Plan("ELE_CODIGO") = Fila_Ele("ELE_CODIGO") And Fila_Plan("TMU_CODIGO") = Fila_Ele("TMU_CODIGO") Then
                        If Lab_Aux <> 1 And Fila_Plan("OT_NLAB") <> Lab_Aux Then Fila = Fila + 1
                        Fila = Fila + 1
                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & Fila_Plan("OT_NLAB"))
                        Imprime_Plani.BordesI(4, 2, Fila, Fila, "A", "F")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                        Priori = Priori + 1
                        LetraSpectro = ""
                        If Fila_Ele("ELE_CAL_FORMULA") = "EAA" Then
                            If InStr(Fila_Ele("ELE_CODIGO"), "_tot") > 0 Then LetraSpectro = "M"
                            If InStr(Fila_Ele("ELE_CODIGO"), "_sol") > 0 Then LetraSpectro = "H"
                            If InStr(Fila_Ele("ELE_CODIGO"), "CIC_cmol") > 0 Then LetraSpectro = "C"
                            If Fila_Ele("ELE_CODIGO") = "K_sol" Then LetraSpectro = "L"
                            If Fila_Ele("ELE_CODIGO") = "Al_ext" Then LetraSpectro = "E"
                        End If
                        Call Graba_Planilla_Plani(Fila_Plan("OT_NLAB") & LetraSpectro, IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
                        Call Graba_NLabPlanificado(Consulta_Orden, Fila_Plan("OT_NLAB"), MM)
                        Lab_Aux = Fila_Plan("OT_NLAB") + 1
                    End If
                Next

                '***********************************************************************
                ' GRABA DUPLICADOS DESDE GRILLA PLANIFICACION EN TABLA DUPLICA_RESULTADO
                '***********************************************************************

                Fila_Seleccion = Cjto_Tablas1.Tables("PLANTI_ELELAB").Select("", "")

                For Each Fila_Te In Cjto_Tablas1.Tables(Tabla_Duplicados).Rows
                    For Each Fila_Plan In Fila_Seleccion
                        If Fila_Plan("ELE_CODIGO") = Fila_Ele("ELE_CODIGO") And Fila_Te("OTC_NLAB") = Fila_Plan("OT_NLAB") Then
                            Call Graba_Planificacion_Tabla_Duplicados(CStr(Fila_Te("OTC_NLAB")), Fila_Ele("ELE_CODIGO"), Fila_Ele("ANA_CODIGO"), MM)
                        End If
                    Next
                Next

                '******************************************
                ' DUPLICADOS DESDE TABLA DUPLICA_RESULTADOS
                '******************************************
                With SP
                    .Inicializar()
                    .AgregarParametro("@CodEle", Fila_Ele("ELE_CODIGO"), SqlDbType.NVarChar)
                    ds = .EjecutarQuery("usp_SelectPlanificacionDuplicadosRevision")
                End With

                For Each Fila_Te In ds.Tables(0).Rows
                    If Fila_Te("NUMERO_DIGITACION") <> 0 Then
                        Fila = Fila + 1
                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Te("OT_NLAB")) & "D" & Fila_Te("NUMERO_DIGITACION"))
                        Imprime_Plani.BordesI(4, 2, Fila, Fila, "A", "F")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                        Priori = Priori + 1
                        Call Graba_Planilla_Plani(CStr(Fila_Te("OT_NLAB")) & "D" & Fila_Te("NUMERO_DIGITACION"), IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
                        StrElementos = StrElementos & "-" & Fila_Ele("ELE_CODIGO")
                    End If
                Next
                StrElementos = StrElementos & "-" & Fila_Ele("ELE_CODIGO")
SaltoxAutogenerado:
            Next

            '***************************************************************
            'SECCION PARA DUPLICADOS QUE NO ESTEN DENTRO DE LA PLANIFICACION
            '***************************************************************
            With SP
                .Inicializar()
                ds = .EjecutarQuery("usp_SelectPlanificacionTodosDuxA")
            End With

            For Each Fila_TodosDuxA In ds.Tables(0).Rows
                Priori = 0
                If InStr(StrElementos, "-" & Fila_TodosDuxA("ELE_CODIGO")) = 0 Then
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 1 Then MuestraPlani = "Foliar" : BlancoText = TxtCantBlancosFoliar.Text : Tabla_Testigos = "TESTIGO_PLANIFOLIAR" : Tabla_Estandar = "ESTANDAR_PLANIFOLIAR"
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 2 Then MuestraPlani = "Otros Tejidos" : BlancoText = TxtCantBlancosTejidos.Text : Tabla_Testigos = "TESTIGO_PLANITEJIDOS" : Tabla_Estandar = "ESTANDAR_PLANITEJIDOS"
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 3 Then MuestraPlani = "Agua" : BlancoText = TxtCantBlancosAgua.Text : Tabla_Testigos = "TESTIGO_PLANIAGUA" : Tabla_Estandar = "ESTANDAR_PLANIAGUA"
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 4 Then MuestraPlani = "Suelo" : BlancoText = TxtCantBlancosSuelo.Text : Tabla_Testigos = "TESTIGO_PLANISUELO" : Tabla_Estandar = "ESTANDAR_PLANISUELO"
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 5 Then MuestraPlani = "Fertilizante Quimico" : BlancoText = TxtCantBlancosFertQui.Text : Tabla_Testigos = "TESTIGO_PLANIFERTQUI" : Tabla_Estandar = "ESTANDAR_PLANIFERTQUI"
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 6 Then MuestraPlani = "Fertilizante Organico" : BlancoText = TxtCantBlancosFertOrg.Text : Tabla_Testigos = "TESTIGO_PLANIFERTORG" : Tabla_Estandar = "ESTANDAR_PLANIFERTORG"
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 7 Then MuestraPlani = "Otros Análisis" : BlancoText = TxtCantBlancosOtrosAnalisis.Text : Tabla_Testigos = "TESTIGO_PLANIOTROSANALISIS" : Tabla_Estandar = "ESTANDAR_PLANIOTROSANALISIS"
                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 8 Then MuestraPlani = "Ventas" : BlancoText = TxtCantBlancosVentas.Text : Tabla_Testigos = "TESTIGO_PLANIVENTAS" : Tabla_Estandar = "ESTANDAR_PLANIVENTAS"
                    If EleTemp = "" Or EleTemp <> Fila_TodosDuxA("ELE_CODIGO") Then
                        Imprime_Plani.Crea_Hoja_Excel(Fila_TodosDuxA("ELE_CODIGO"), 1, 18, MM)
                        Imprime_Plani.SinCurva(Fila_TodosDuxA("ELE_CODIGO"), MuestraPlani)
                        Imprime_Plani.DatosI(MyDate, "Elemento", IntNLab)
                        Priori = 0
                        Fila = 11
                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Nº Lab")
                        Imprime_Plani.BordesI(4, 1, Fila, Fila, "A", "F")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                        If TxtCantBlancosFoliar.Text <> 0 Then
                            For XCant = 1 To BlancoText
                                Fila = Fila + 1
                                Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Blanco " & XCant)
                                Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                                Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                                Priori = Priori + 1
                                Call Graba_Planilla_Plani("Blanco" & XCant, IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
                            Next
                        End If

                        If BlancoText > 1 Then
                            Fila = Fila + 1
                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "BLPromedio")
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                            Priori = Priori + 1
                            Call Graba_Planilla_Plani("PromBlanco" & XCant, IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
                        End If

                        For Each Fila_Es In Cjto_Tablas1.Tables(Tabla_Estandar).Rows
                            Fila = Fila + 1
                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Es("OTC_NLAB") & "S1"))
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                            Priori = Priori + 1
                            Call Graba_Planilla_Plani((Fila_Es("OTC_NLAB") & "S1"), IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
                        Next

                        For Each Fila_Te In Cjto_Tablas1.Tables(Tabla_Testigos).Rows
                            Fila = Fila + 1
                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Te("OTC_NLAB") & "T1"))
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                            Priori = Priori + 1

                            Call Graba_Planilla_Plani(CStr(Fila_Te("OTC_NLAB") & "T1"), IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
                        Next
                    End If
                    If Fila_TodosDuxA("NUMERO_DIGITACION") <> 0 Then
                        Fila = Fila + 1
                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_TodosDuxA("OT_NLAB")) & "D" & Fila_TodosDuxA("NUMERO_DIGITACION"))
                        Imprime_Plani.BordesI(4, 2, Fila, Fila, "A", "F")
                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
                        Priori = Priori + 1
                        Call Graba_Planilla_Plani(CStr(Fila_TodosDuxA("OT_NLAB")) & "D" & Fila_TodosDuxA("NUMERO_DIGITACION"), IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
                    End If
                    EleTemp = Fila_TodosDuxA("ELE_CODIGO")
                End If
            Next

            'frmEspere.Close()
            Imprime_Plani.Cierra_Excel(Destino)
            Imprime_Plani.Mata_Proceso()
            'Me.Close()

        Catch ex As Exception
            MsgBox("error, contactese con el administrador, error en proc : btnImprimirPlan_Click, " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Imprime_Resumen_Planificacion()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim SwEmpresa, ll, SwGuion, Fila_Descripcion, Ultima_Fila, IntMuestra, IntSub, IntNLab, xx, CodAnalEx, NumeroDeOt, Fila_Combo, i, Largo, fila, fila_pie, fila_logo, fila_nota, ContFila, Muestra_Aux As Integer
        Dim EmpPro, RemPro, NomPro, FechaOT, FechaDesp, Ot_NumEx, SubMuestra, Tipo_Analisis, StrEle, EleUlt, NumLabEx, swich, Empr, Reme, EmpRem, NumLab, caracter, query, vernom, FechaI, CodMueC, NumLabo, Acumula, Espacios As String
        Dim BuscaSub, BUSCA, BusMue, BuscaAna As Object
        Dim Fila_Sub, FILA_OTEST_ELEMENTO, Fila_Orden, FILA_PLANIFICACION, FILA_MUESTRA, Fila_Analisis, Fila_Ultima As DataRow
        Dim FechaDia As Date
        Dim Ot_Num_Mom, MyPos, Lpag, Lcont, Fila_Titulo, Cantidad_de_Muestras As Integer
        'Dim DBMan1 As DbManager
        Dim ds As DataSet = New DataSet
        Dim DesCodPla As Boolean

        Espacios = "            "
        FechaDia = Now
        BUSCA = Orden_Trabajo
        fila = 2 : Lpag = 1
        'HOJA_EXCEL.Range("A1").Select()
        Fila_Orden = Cjto_Orden1.Tables("ORDEN_TRABAJO").Rows.Find(BUSCA)

        'ORDEN
        Call Encabezado_Listado(fila, FechaDia, "Listado de Planificacion Diaria")

        Muestra_Aux = 0
        ContFila = 0
        rFoliar1 = 0
        rAgua1 = 0
        rSuelo1 = 0
        rOtros1 = 0
        swich = "S" : SwEmpresa = 0 : Ot_NumEx = "0" : Lcont = 50

        For Each FILA_PLANIFICACION In Cjto_Tablas1.Tables("PLANIFICACION").Rows
            If FILA_PLANIFICACION("MARCA") = "x" Then
                If IsDBNull(FILA_PLANIFICACION("PRO_PRODUCTOR")) = False Then
                    If FILA_PLANIFICACION("PRO_PRODUCTOR") = " ****  FINAL *****" Then Exit For
                End If
                fila = fila + 1
                If Ot_NumEx <> "0" And Ot_NumEx <> FILA_PLANIFICACION("OT_NUMERO") Then
                    Call BORDES_FILA_LADOS(fila)
                    'If ContFila = 1 Then fila = fila + 1
                    With Imprime_Plani.HojaE.Range("A" & fila.ToString & ":GQ" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
                        .LineStyle = Excel.XlLineStyle.xlContinuous
                        .Weight = Excel.XlBorderWeight.xlHairline
                        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    End With
                    swich = "S"
                    ContFila = 0
                End If
                'OT
                MyPos = 0
                Call Busca_Salto_Pagina(Imprime_Plani.HojaE, FechaDia, FILA_PLANIFICACION("OT_NUMERO"), fila, Lpag)
                MyPos = InStr(FILA_PLANIFICACION("OT_NUMERO"), "U")
                If MyPos > 0 Then Ot_Num_Mom = Mid(FILA_PLANIFICACION("OT_NUMERO"), 1, MyPos - 1) Else Ot_Num_Mom = FILA_PLANIFICACION("OT_NUMERO")
                Imprime_Plani.Imprime_Linea(fila, fila, "A", "G", 8, "Center", "Center", False, "", "", "'" & FILA_PLANIFICACION("OT_NUMERO"))
                'Ot_NumEx = FILA_PLANIFICACION("OT_NUMERO")
                'FECHA ING
                If IsDBNull(FILA_PLANIFICACION("OT_FECHA_ORDEN")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "H", "L", 6, "Center", "Center", False, "dd/mm", "", FILA_PLANIFICACION("OT_FECHA_ORDEN"))
                End If
                'FECHA DESPACHO
                If IsDBNull(FILA_PLANIFICACION("OT_FECHA_ORDEN")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "M", "Q", 6, "Center", "Center", False, "dd/mm", "", FILA_PLANIFICACION("OT_DESP_FECHA"))
                End If
                'PRODUCTOR
                If IsDBNull(FILA_PLANIFICACION("PRO_PRODUCTOR")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "R", "AN", 7, "Left", "Center", False, "", "", FILA_PLANIFICACION("PRO_PRODUCTOR"))
                End If

                'LOCALIDAD
                If IsDBNull(FILA_PLANIFICACION("OT_LOCALIDAD")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "AO", "AX", 7, "Left", "Center", False, "", "", FILA_PLANIFICACION("OT_LOCALIDAD"))
                End If


                If IsDBNull(FILA_PLANIFICACION("NUMLAB1")) = True And IsDBNull(FILA_PLANIFICACION("NUMLAB2")) = True And IsDBNull(FILA_PLANIFICACION("NUMLAB3")) = True Then
                    Call BORDES_FILA_LADOS(fila)
                End If

                'CANT
                If IsDBNull(FILA_PLANIFICACION("OTC_CANT_MUESTRAS")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "AY", "BB", 7, "Center", "Center", False, "", "", FILA_PLANIFICACION("OTC_CANT_MUESTRAS"))
                    Cantidad_de_Muestras = FILA_PLANIFICACION("OTC_CANT_MUESTRAS")
                End If

                If IsDBNull(FILA_PLANIFICACION("NUMLAB1")) = True Then FILA_PLANIFICACION("NUMLAB1") = ""
                If IsDBNull(FILA_PLANIFICACION("NUMLAB2")) = True Then FILA_PLANIFICACION("NUMLAB2") = ""
                If IsDBNull(FILA_PLANIFICACION("NUMLAB3")) = True Then FILA_PLANIFICACION("NUMLAB3") = ""
                If IsDBNull(FILA_PLANIFICACION("NUMLAB4")) = True Then FILA_PLANIFICACION("NUMLAB4") = ""

                If FILA_PLANIFICACION("NUMLAB1") <> "" Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "BC", "BL", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB1"))
                    NumLabEx = FILA_PLANIFICACION("NUMLAB1")
                    rFoliar1 = rFoliar1 + Cantidad_de_Muestras
                End If

                If FILA_PLANIFICACION("NUMLAB2") <> "" Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "BM", "BV", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB2"))
                    NumLabEx = FILA_PLANIFICACION("NUMLAB2")
                    rAgua1 = rAgua1 + Cantidad_de_Muestras
                End If

                If FILA_PLANIFICACION("NUMLAB3") <> "" Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "BW", "CF", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB3"))
                    NumLabEx = FILA_PLANIFICACION("NUMLAB3")
                    rSuelo1 = rSuelo1 + Cantidad_de_Muestras
                End If

                If FILA_PLANIFICACION("NUMLAB4") <> "" Then

                    Imprime_Plani.Imprime_Linea(fila, fila, "CG", "CP", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB4"))
                    NumLabEx = FILA_PLANIFICACION("NUMLAB4")
                    rOtros1 = rOtros1 + Cantidad_de_Muestras
                End If

                If DesCodPla = True Then
                    Imprime_Plani.Imprime_Linea(4, 4, "DV", "EP", 8, "Left", "Center", False, "", "", "Codigo Planificacion")
                    Imprime_Plani.Imprime_Linea(4, 4, "EQ", "FA", 8, "Left", "Center", False, "", "", NumLabEx)
                    DesCodPla = False
                End If

                'CODIGO
                If IsDBNull(FILA_PLANIFICACION("ANA_CODIGO")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "CQ", "CV", 7, "Center", "Center", False, "####", "", FILA_PLANIFICACION("ANA_CODIGO"))
                    CodAnalEx = FILA_PLANIFICACION("ANA_CODIGO")
                    ContFila = ContFila + 1
                End If
                'DESCRIPCION 
                'Consulta Otest_Elemento
                Acumula = ""
                For xx = 1 To Len(NumLabEx)
                    caracter = Mid(NumLabEx, xx, 1)
                    If caracter = "-" Then
                        IntNLab = CInt(Trim(Acumula))
                        Exit For
                    End If
                    Acumula = Acumula + caracter
                Next
                IntNLab = CInt(Acumula)

                BuscaAna = CodAnalEx
                Fila_Analisis = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaAna)
                IntMuestra = Fila_Analisis("TMU_CODIGO")
                IntSub = Fila_Analisis("SUB_CODIGO")

                Tipo_Analisis = Fila_Analisis("TIPO_COD")

                BuscaSub = IntSub
                Fila_Sub = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaSub)
                If Not (Fila_Sub Is Nothing) = True Then SubMuestra = Fila_Sub("ANA_ANALISIS") Else SubMuestra = ""


                Cjto_Tablas1.Tables("OTEST_ELEMENTO").Clear()
                Cjto_Tablas1.Tables("OTEST_ELEMENTO_COMP").Clear()


                If IsDBNull(FILA_PLANIFICACION("ANA_CODIGO")) = False Then
                    Try
                        With SP
                            .Inicializar()
                            .AgregarParametro("@NumOt", Ot_Num_Mom, SqlDbType.Int)
                            .AgregarParametro("@NLab", IntNLab, SqlDbType.Int)
                            .AgregarParametro("@CodAna", CodAnalEx, SqlDbType.Float)
                            .AgregarParametro("@Tipo_Analisis", Tipo_Analisis, SqlDbType.NVarChar)
                            .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                            .EjecutarQueryDt("usp_SelectPlanificacion", Cjto_Tablas1, "OTEST_ELEMENTO")
                        End With
                    Catch ex As Exception
                        MsgBox("Inconsistencia de datos , llame al Dep. Informatica")
                    End Try

                    Try
                        With SP
                            .Inicializar()
                            .AgregarParametro("@NumOt", Ot_Num_Mom, SqlDbType.Int)
                            .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                            .EjecutarQueryDt("[usp_SelectPlanificacionElemento]", Cjto_Tablas1, "OTEST_ELEMENTO_COMP")
                        End With
                        With SP
                            .Inicializar()
                            .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                            .AgregarParametro("@NLabDesde", IntNLab, SqlDbType.Int)
                            .AgregarParametro("@NLabHasta", IntNLab, SqlDbType.Int)
                            ds = .EjecutarQuery("usp_SelectPlanificacionSubTitulo")
                        End With

                    Catch ex As Exception
                        MsgBox("Inconsistencia de datos , llame al Dep. Informatica")
                    End Try


                    'If SubMuestra <> "" Then Acumula = SubMuestra & ":" Else Acumula = ""
                    Acumula = "            "
                    Largo = 0 : SwGuion = 0 : Fila_Descripcion = 1 : Fila_Titulo = 1

                    For Each FILA_OTEST_ELEMENTO In Cjto_Tablas1.Tables("OTEST_ELEMENTO").Rows
                        ll = 0
                        If Tipo_Analisis <> "JA" And Fila_Descripcion <> CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1)) Then
                            Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).Merge()
                            Acumula = Mid(Acumula, 1, Len(Acumula) - 1)
                            Imprime_Plani.HojaE.Range("CW" & fila.ToString).Value = Acumula
                            Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Size = 8
                            Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Bold = False
                            Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.ColorIndex = 3

                            Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Name = "Courier New"
                            Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            Imprime_Plani.Imprime_Linea(fila, fila, "CW", "GQ", 8, "Left", "Center", False, "", "", Acumula)
                            Call Control_Letra(Imprime_Plani.HojaE, Imprime_Plani.ExcelA, Acumula, fila, Ot_Num_Mom, CodAnalEx, NumLabEx, 13, Fila_Descripcion)
                            Call BORDES_FILA_LADOS(fila)
                            ContFila = ContFila + 1
                            fila = fila + 1
                            Acumula = ""
                            ll = 0
                            StrEle = FILA_OTEST_ELEMENTO("ELE_COD_DES")
                            If IsDBNull(FILA_OTEST_ELEMENTO("TITULO_FILA")) = False Then
                                If Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) > 0 Then
                                    Acumula = FILA_OTEST_ELEMENTO("TITULO_FILA") & Mid(Espacios, Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) + 1)
                                    If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":" & StrEle & "-"
                                    ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":" & StrEle & "-"
                                    Else
                                        Acumula = Acumula & "             " & ":" & StrEle & "-"
                                    End If
                                Else
                                    Acumula = "             " '& StrEle & "-"
                                    If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":" & StrEle & "-"
                                    ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":" & StrEle & "-"
                                    Else
                                        Acumula = Acumula & "            " & ":" & StrEle & "-"
                                    End If
                                End If
                            Else
                                Acumula = "             "
                                If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":" & StrEle & "-"
                                ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":" & StrEle & "-"
                                Else
                                    Acumula = Acumula & "            " & ":" & StrEle & "-"
                                End If
                            End If
                            Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
                        Else
                            If CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1)) = 1 And SwGuion = 0 Then
                                If IsDBNull(FILA_OTEST_ELEMENTO("TITULO_FILA")) = False Then
                                    If Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) > 0 Then
                                        Acumula = FILA_OTEST_ELEMENTO("TITULO_FILA") & Mid(Espacios, Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) + 1)
                                        If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                            Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":"
                                        ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                            Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":"
                                        Else
                                            Acumula = Acumula & "             " & ":"
                                        End If
                                    Else
                                        Acumula = "             "
                                        If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                            Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":"
                                        ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                            Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":"
                                        Else
                                            Acumula = Acumula & "             " & ":"
                                        End If
                                    End If
                                    SwGuion = 1
                                Else
                                    Acumula = "            "
                                    If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":"
                                    ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":"
                                    Else
                                        Acumula = Acumula & "             " & ":"
                                    End If
                                    SwGuion = 1
                                End If
                            End If
                            If Tipo_Analisis = "JA" Then
                                StrEle = FILA_OTEST_ELEMENTO("ELE_COD_DES")
                                Acumula = Acumula & StrEle & "-"
                                Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
                                GoTo SaltoeleJocker2
                            End If

                            If IsDBNull(FILA_OTEST_ELEMENTO("TITULO_FILA")) = False Then
                                If FILA_OTEST_ELEMENTO("TITULO_FILA") <> "NoDespliegaPlan" Then
                                    StrEle = FILA_OTEST_ELEMENTO("ELE_COD_DES")
                                    Acumula = Acumula & StrEle & "-"
                                    Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
                                End If
                            End If
SaltoeleJocker2:
                        End If
                    Next
                    If ll > 0 Then fila = fila - 1
                    Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).Merge()
                    Acumula = Mid(Acumula, 1, Len(Acumula) - 1)
                    Imprime_Plani.HojaE.Range("CW" & fila.ToString).Value = Acumula
                    Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Size = 8
                    Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Bold = False
                    Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Name = "Courier New"
                    Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.ColorIndex = 3

                    Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Imprime_Plani.Imprime_Linea(fila, fila, "CW", "GQ", 8, "Left", "Center", False, "", "", Acumula)
                    Call Control_Letra(Imprime_Plani.HojaE, Imprime_Plani.ExcelA, Acumula, fila, Ot_Num_Mom, CodAnalEx, NumLabEx, 26, Fila_Descripcion)
                    Call BORDES_FILA_LADOS(fila)
                    'If ContFila = 0 And Fila_Combo = 0 Then ContFila = 1 : fila = fila + 1
                End If
                Ot_NumEx = FILA_PLANIFICACION("OT_NUMERO")
            End If
            'FechaOT = FILA_PLANIFICACION("OT_FECHA_ORDEN")
            'FechaDesp = FILA_PLANIFICACION("OT_DESP_FECHA")
            'NomPro = FILA_PLANIFICACION("PRO_PRODUCTOR")
            'EmpPro = FILA_PLANIFICACION("PRO_EMPRESA")
            'RemPro = FILA_PLANIFICACION("PRO_REMITE")
        Next
        fila = fila + 1
        Imprime_Plani.BordesI(4, 2, fila, fila, "A", "GQ")
        Call Imprime_estadistica(fila)
        Call IMPRIME_NUMERO_PAGINAS(Lpag)
        fila = 28
        fila = fila + 1
    End Sub

    Public Sub IMPRIME_NUMERO_PAGINAS(ByVal pag As Integer)
        Dim NUM_PAG, TOT_PAG, jy, filP, ult_fin, pos_pag As Integer
        Dim junto As String
        ult_fin = pag - 1
        For jy = 1 To pag
            If jy = 1 Then filP = 4
            If jy <> 1 Then filP = 3 + (50 * (jy - 1))
            junto = CStr(jy & "/" & pag)

            Imprime_Plani.Imprime_Linea(filP, filP, "FX", "GB", 7, "General", "Center", False, "", "", "'" & CStr(junto))

        Next
    End Sub

    Private Sub Imprime_estadistica(ByVal fila As Integer)
        fila = fila + 2
        Imprime_Plani.BordesI(4, 1, fila, fila + 4, "A", "AK")
        fila = fila + 1
        Imprime_Plani.Imprime_Linea(fila, fila, "A", "A", 8, "Left", "Center", False, "", "", "Total Foliar :")
        Imprime_Plani.Imprime_Linea(fila, fila, "T", "AA", 8, "Left", "Center", False, "", "", rFoliar1)
        fila = fila + 1

        Imprime_Plani.Imprime_Linea(fila, fila, "A", "A", 8, "Left", "Center", False, "", "", "Total Agua :")
        Imprime_Plani.Imprime_Linea(fila, fila, "T", "AA", 8, "Left", "Center", False, "", "", rAgua1)
        fila = fila + 1

        Imprime_Plani.Imprime_Linea(fila, fila, "A", "A", 8, "Left", "Center", False, "", "", "Total Suelo :")
        Imprime_Plani.Imprime_Linea(fila, fila, "T", "AA", 8, "Left", "Center", False, "", "", rSuelo1)
        fila = fila + 1

        Imprime_Plani.Imprime_Linea(fila, fila, "A", "A", 8, "Left", "Center", False, "", "", "Total Otros :")
        Imprime_Plani.Imprime_Linea(fila, fila, "T", "AA", 8, "Left", "Center", False, "", "", rOtros1)

    End Sub

    Private Sub Graba_Planilla_Plani(ByVal NlabD As String, ByVal Codigo_NumLabDesde As Integer, ByVal ELEC As String, ByVal Priori As Integer, ByVal MM As String)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim MyDate As Date
        Dim retorna As Integer = 0
        MyDate = Today
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", MM, SqlDbType.Int)
                .AgregarParametro("@CodEle", ELEC, SqlDbType.NVarChar)
                .AgregarParametro("@NLabDesde", Codigo_NumLabDesde, SqlDbType.NVarChar)
                .AgregarParametro("@FechaPlani", MyDate, SqlDbType.DateTime)
                .AgregarParametro("@NLab", NlabD, SqlDbType.NVarChar)
                .AgregarParametro("@Prioridad", Priori, SqlDbType.Int)
                retorna = .EjecutarEscalar("usp_UpdatePlanificacionPlanillaPlani")
            End With
        Catch ex As Exception
            MsgBox("Error en consulta")
        End Try
    End Sub

    Private Sub Graba_NLabPlanificado(ByVal OTNum As Integer, ByVal NLab As String, ByVal MM As Integer)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim MyDate As Date
        MyDate = Today
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@OTNum", OTNum, SqlDbType.Int)
                .AgregarParametro("@NLab", NLab, SqlDbType.Int)
                .AgregarParametro("@FechaPlani", MyDate, SqlDbType.DateTime)
                .AgregarParametro("@TMuestra", MM, SqlDbType.Int)
                .AgregarParametro("@Usuario", usuarioLG, SqlDbType.NVarChar)
                .EjecutarQuery("usp_GrabaNLabPlanificado")
            End With
        Catch ex As Exception
            MsgBox("Error al grabar NLab_Planificado")
        End Try
    End Sub

    Private Sub Graba_Planificacion_Tabla_Duplicados(ByVal NlabD As String, ByVal ELEC As String, ByVal CodAnaPla As Double, ByVal MM As String)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim MyDate As Date
        Dim retorna As Integer = 0
        MyDate = Today
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@CodEle", ELEC, SqlDbType.NVarChar)
                .AgregarParametro("@NLab", NlabD, SqlDbType.Int)
                .AgregarParametro("@TMuestra", MM, SqlDbType.Int)
                .AgregarParametro("@CodAna", CodAnaPla, SqlDbType.Float)
                retorna = .EjecutarEscalar("usp_UpdatePlanificacionTablaDuplicados")
            End With
        Catch ex As Exception
            MsgBox("Error en consulta")
        End Try
    End Sub

    Private Sub Encabezado_Listado(ByRef fila As Integer, ByVal FechaDia As Date, ByVal TituloListado As String)
        Dim fila_bi As Integer

        Imprime_Plani.Imprime_Linea(fila, fila, "FR", "FV", 8, "Center", "Center", False, "", "", "Fecha")
        Imprime_Plani.Imprime_Linea(fila, fila, "FW", "FW", 8, "Center", "Center", False, "", "", ":")
        Imprime_Plani.Imprime_Linea(fila, fila, "FX", "GF", 7, "Left", "Center", False, "", "", Format(FechaDia, "dd-MM-yyyy"))

        fila = fila + 1

        Imprime_Plani.Imprime_Linea(fila, fila, "BY", "DA", 9, "Center", "Center", True, "", "", TituloListado)

        Imprime_Plani.Imprime_Linea(fila, fila, "FS", "FV", 8, "Center", "Center", False, "", "", "Hora")
        Imprime_Plani.Imprime_Linea(fila, fila, "FW", "FW", 8, "Center", "Center", False, "", "", ":")
        Imprime_Plani.Imprime_Linea(fila, fila, "FX", "GF", 7, "Center", "Center", False, "", "", Format(FechaDia, "HH:mm"))

        fila = fila + 1

        Imprime_Plani.Imprime_Linea(fila, fila, "FS", "FV", 8, "Center", "Center", False, "", "", "Pag.")
        Imprime_Plani.Imprime_Linea(fila, fila, "FW", "FW", 8, "Center", "Center", False, "", "", ":")


        fila = fila + 1
        fila_bi = fila

        Imprime_Plani.BordesI(4, 1, fila, fila + 1, "A", "GQ")

        Imprime_Plani.Imprime_Linea(fila, fila, "A", "G", 8, "Center", "Center", False, "", "", "N° OT")
        Imprime_Plani.Imprime_Linea(fila, fila, "H", "L", 6, "Center", "Center", False, "", "", "F.Ing")
        Imprime_Plani.Imprime_Linea(fila, fila, "M", "Q", 6, "Center", "Center", False, "", "", "F.Des")
        Imprime_Plani.Imprime_Linea(fila, fila, "R", "AN", 8, "Left", "Center", False, "", "", "Productor")
        Imprime_Plani.Imprime_Linea(fila, fila, "AO", "AX", 8, "Left", "Center", False, "", "", "Localidad")
        Imprime_Plani.Imprime_Linea(fila, fila, "AY", "BB", 7, "Center", "Center", False, "", "", "Cant")
        Imprime_Plani.Imprime_Linea(fila, fila, "BC", "BL", 8, "Center", "Center", False, "", "", "Foliar")
        Imprime_Plani.Imprime_Linea(fila, fila, "BM", "BV", 8, "Center", "Center", False, "", "", "Agua")
        Imprime_Plani.Imprime_Linea(fila, fila, "BW", "CF", 8, "Center", "Center", False, "", "", "Suelo")
        Imprime_Plani.Imprime_Linea(fila, fila, "CG", "CP", 8, "Center", "Center", False, "", "", "Otros")

        Imprime_Plani.Imprime_Linea(fila, fila, "CQ", "CV", 8, "Center", "Center", False, "", "", "Cod.")
        Imprime_Plani.Imprime_Linea(fila, fila, "CW", "GQ", 8, "Left", "Center", False, "", "", "Descripción")

        Call BORDES_FILA_LADOS(fila)

        Imprime_Plani.BordesI(1, 2, fila, fila, "A", "GQ")

        fila = fila + 1

        'Imprime_Plani.Imprime_Linea(fila, fila, "G", "K", 6, "Center", "Center", False, "", "", "Priorid")

        'Imprime_Plani.Imprime_Linea(fila, fila, "M", "AN", 6, "Left", "Center", False, "", "", "Empresa/Remite")

        Imprime_Plani.Imprime_Linea(fila, fila, "AY", "BB", 6, "Left", "Center", False, "", "", "")

        Imprime_Plani.Imprime_Linea(fila, fila, "BC", "BL", 6, "Center", "Center", False, "", "", "Desde - Hasta")

        Imprime_Plani.Imprime_Linea(fila, fila, "BM", "BV", 6, "Center", "Center", False, "", "", "Desde - Hasta")

        Imprime_Plani.Imprime_Linea(fila, fila, "BW", "CF", 6, "Center", "Center", False, "", "", "Desde - Hasta")

        Imprime_Plani.Imprime_Linea(fila, fila, "CG", "CP", 6, "Center", "Center", False, "", "", "Desde - Hasta")


        Call BORDES_FILA_LADOS(fila)

        'Imprime_Plani.BordesI(7, 2, fila, fila, "A", "GG")


    End Sub

    Public Sub BORDES_FILA_LADOS(ByVal IB As Integer)
        Imprime_Plani.BordesI(7, 2, IB, IB, "BB", "BB")
        Imprime_Plani.BordesI(7, 2, IB, IB, "BL", "BL")
        Imprime_Plani.BordesI(7, 2, IB, IB, "BV", "BV")
        Imprime_Plani.BordesI(7, 2, IB, IB, "CF", "CF")
        Imprime_Plani.BordesI(7, 2, IB, IB, "CP", "CP")
    End Sub

    Private Sub Busca_Salto_Pagina(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal FechaDia As Date, ByVal BOrden As String, ByRef FILA As Integer, ByRef Lpag As Integer)
        Try
            Dim FILA_PLANIFICACION1, FILA_OTEST_ELEMENTO As DataRow
            Dim Fila_Analisis As DataRow
            Dim BuscaAna As Object
            Dim DBMan1 As DbManager
            Dim xx, Intnlab, IntMuestra, Mypos, Fila_Descripcion, Cuento_Filas, Suma_de_Filas, Lcont, Dif_Filas, Orden_Sinu As Integer
            Dim NumLabEx, Acumula, caracter, query, Orden_Aux, JL As String

            For Each FILA_PLANIFICACION1 In Cjto_Tablas1.Tables("PLANIFICACION1").Rows
                JL = FILA_PLANIFICACION1("OT_NUMERO")
                If FILA_PLANIFICACION1("OT_NUMERO") <> "" And BOrden <> FILA_PLANIFICACION1("OT_NUMERO") Then GoTo SALTONOES
                If FILA_PLANIFICACION1("OT_NUMERO") = "" Then FILA_PLANIFICACION1("OT_NUMERO") = Orden_Aux
                If BOrden = FILA_PLANIFICACION1("OT_NUMERO") Then
                    Cjto_Tablas1.Tables("OTEST_ELEMENTO1").Clear()
                    DBMan1 = New DbManager("OTEST_ELEMENTO1", Conexion1)

                    If IsDBNull(FILA_PLANIFICACION1("NUMLAB1")) = True Then FILA_PLANIFICACION1("NUMLAB1") = ""
                    If IsDBNull(FILA_PLANIFICACION1("NUMLAB2")) = True Then FILA_PLANIFICACION1("NUMLAB2") = ""
                    If IsDBNull(FILA_PLANIFICACION1("NUMLAB3")) = True Then FILA_PLANIFICACION1("NUMLAB3") = ""

                    If FILA_PLANIFICACION1("NUMLAB1") <> "" Then
                        NumLabEx = FILA_PLANIFICACION1("NUMLAB1")
                    End If
                    If FILA_PLANIFICACION1("NUMLAB2") <> "" Then
                        NumLabEx = FILA_PLANIFICACION1("NUMLAB2")
                    End If
                    If FILA_PLANIFICACION1("NUMLAB3") <> "" Then
                        NumLabEx = FILA_PLANIFICACION1("NUMLAB3")
                    End If

                    Acumula = ""
                    If Not IsNothing(NumLabEx) Then
                        For xx = 1 To Len(NumLabEx)
                            caracter = Mid(NumLabEx, xx, 1)
                            If caracter = "-" Then
                                Intnlab = CInt(Trim(Acumula))
                                Exit For
                            End If
                            Acumula = Acumula + caracter
                        Next
                    End If
                    If Acumula <> "" Then
                        Intnlab = CInt(Acumula)
                    Else
                        Intnlab = 0
                    End If
                    Fila_Descripcion = 1
                    BuscaAna = FILA_PLANIFICACION1("ANA_CODIGO")
                    Fila_Analisis = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaAna)
                    IntMuestra = Fila_Analisis("TMU_CODIGO")
                    Mypos = InStr(FILA_PLANIFICACION1("OT_NUMERO"), "U")
                    If Mypos > 0 Then Orden_Sinu = Mid(FILA_PLANIFICACION1("OT_NUMERO"), 1, Mypos - 1) Else Orden_Sinu = FILA_PLANIFICACION1("OT_NUMERO")
                    If Fila_Analisis("TIPO_COD") = "JA" Then Cuento_Filas = Cuento_Filas + 1 : GoTo SALTONOES
                    query = "SELECT OT_NUMERO,DIGITA_RESULTADOS.TMU_CODIGO,OT_NLAB,DIGITA_RESULTADOS.ELE_CODIGO," & _
                                     "ANALISIS_ELEMENTOS.ELE_PRIORIDAD,ELE_ESTADO,ELEMENTO.ELE_COD_DES,ANALISIS_ELEMENTOS.TITULO_FILA FROM (DIGITA_RESULTADOS LEFT JOIN ANALISIS_ELEMENTOS ON " & _
                                     "DIGITA_RESULTADOS.ELE_CODIGO=" & _
                                     "ANALISIS_ELEMENTOS.ELE_CODIGO AND ANALISIS_ELEMENTOS.ANA_CODIGO=DIGITA_RESULTADOS.ANA_CODIGO) " & _
                                     "LEFT JOIN ELEMENTO ON DIGITA_RESULTADOS.ELE_CODIGO=ELEMENTO.ELE_CODIGO AND DIGITA_RESULTADOS.TMU_CODIGO=ELEMENTO.TMU_CODIGO " & _
                                     "WHERE DIGITA_RESULTADOS.OT_NUMERO = " & Orden_Sinu & _
                                     " AND DIGITA_RESULTADOS.TMU_CODIGO=" & IntMuestra & " AND DIGITA_RESULTADOS.OT_NLAB=" & _
                                     Intnlab & " AND DIGITA_RESULTADOS.ANA_CODIGO=" & FILA_PLANIFICACION1("ANA_CODIGO") & " ORDER BY ANALISIS_ELEMENTOS.ELE_PRIORIDAD"
                    DBMan1.Selecccionar(Cjto_Tablas1, query)

                    Cuento_Filas = Cuento_Filas + 1
                    For Each FILA_OTEST_ELEMENTO In Cjto_Tablas1.Tables("OTEST_ELEMENTO1").Rows
                        If Fila_Descripcion <> CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1)) Then
                            Cuento_Filas = Cuento_Filas + 1
                        End If
                        Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
                    Next
                    Orden_Aux = FILA_PLANIFICACION1("OT_NUMERO")
                End If
            Next
SALTONOES:
            Suma_de_Filas = Cuento_Filas + FILA
            Lcont = Lpag * 50
            Dif_Filas = Lcont - FILA
            If Suma_de_Filas >= Lcont - 2 Then
                With HOJA_EXCEL.Range("A" & FILA.ToString & ":GG" & FILA.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                Lpag = Lpag + 1
                If Dif_Filas < 0 Then Dif_Filas = (Dif_Filas * -1)
                FILA = FILA + 1 + Dif_Filas
                Call Encabezado_Listado(FILA, FechaDia, "Listado de Planificacion Diaria")
                FILA = FILA + 1
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Control_Letra(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal excell As Excel.Application, ByVal elemento As String, ByVal fila As Integer, ByVal Ot_NumEx As Integer, ByVal CodAnalEx As Integer, ByVal NumLabEx As String, ByVal Largo_Ini As Integer, ByVal Fila_Descripcion As Integer)
        Dim Fila_Analisis, FILA_BUSOTEST As DataRow
        Dim Busca_Ele, BuscaAna As Object
        Dim largo_StrEle, ColorLetra, xx, ij, largo, largo_pos, fila_mas, IntSub, IntMuestra, IntNLab, CarIni, CarFin, LargoRestante As Integer
        Dim Fondo, StrDPar, StrEle, StrCodigo, caracter, query, Acumula As String
        'Dim dbman As DbManager
        Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GB" & fila.ToString).Merge()
        Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GB" & fila.ToString).Select()
        'excell.ActiveCell.FormulaR1C1 = elemento

        BuscaAna = CodAnalEx
        Fila_Analisis = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaAna)
        IntMuestra = Fila_Analisis("TMU_CODIGO")
        IntSub = Fila_Analisis("SUB_CODIGO")

        For xx = 1 To Len(NumLabEx)
            caracter = Mid(NumLabEx, xx, 1)
            If caracter = "-" Then
                IntNLab = CInt(Trim(Acumula))
                Exit For
            End If
            Acumula = Acumula + caracter
        Next
        IntNLab = CInt(Acumula)


        largo = Len(elemento)
        fila_mas = 0
        CarIni = Largo_Ini + 1
        For Each FILA_BUSOTEST In Cjto_Tablas1.Tables("OTEST_ELEMENTO").Rows
            ColorLetra = 3
            Fondo = "Normal"
            If Fila_Descripcion = CInt(Mid(CStr(FILA_BUSOTEST("ELE_PRIORIDAD")), 1, 1)) Then
                StrEle = FILA_BUSOTEST("ELE_COD_DES")
                StrCodigo = FILA_BUSOTEST("ELE_CODIGO")
                Call ColorEstado(StrCodigo, Fondo, IntMuestra, IntNLab, ColorLetra, Ot_NumEx)
                largo_StrEle = Len(StrEle)
                With Imprime_Plani.ExcelA.ActiveCell.Characters(Start:=CarIni, Length:=Len(StrEle)).Font
                    .ColorIndex = ColorLetra
                    .Name = "Courier New"
                    .FontStyle = Fondo
                    .Size = 8
                End With
                CarIni = CarIni + largo_StrEle + 1
            End If
        Next
congpe:
        'Call ColorEstado(StrCodigo, Fondo, IntMuestra, IntNLab, ColorLetra, Ot_NumEx)
        'With Imprime_Plani.ExcelA.ActiveCell.Characters(Start:=CarIni, Length:=Len(StrEle)).Font
        '    .Color = ColorLetra
        '    .Name = "Courier New"
        '    .FontStyle = Fondo
        '    .Size = 8
        'End With
    End Sub

    Private Sub ColorEstado(ByVal StrEle As String, ByRef Fondo As String, ByVal IntMuestra As Integer, ByVal IntNLab As Integer, ByRef ColorLetra As Integer, ByVal Ot_NumEx As Integer)
        Dim BuscaEle(1), BuscaOtEsE(3) As Object
        Dim ll, xx, IntPrio, NlabD, NlabH As Integer
        Dim Fila_Elemento, Fila_Analisis, Fila_OtestE As DataRow
        Dim caracter, Acumula, query, EstadoEs As String
        Try

            Dim SqlConn As New SqlConnection
            SqlConn = New SqlConnection(Conexion1)
            query = "select OT_NUMERO,TMU_CODIGO,OTC_NLAB_DESDE,OTC_NLAB_HASTA FROM OT_CODIFICACION WHERE OT_NUMERO=" & Ot_NumEx & " AND TMU_CODIGO=" & IntMuestra & " AND OTC_NLAB_DESDE=" & IntNLab
            Dim myCommand As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            NlabD = myReader.GetInt32(2)
            NlabH = myReader.GetInt32(3)
            myReader.Close()
            SqlConn.Close()

            For ll = NlabD To NlabH
                BuscaOtEsE(0) = Ot_NumEx
                BuscaOtEsE(1) = IntMuestra
                BuscaOtEsE(2) = ll
                BuscaOtEsE(3) = Trim(StrEle)
                Fila_OtestE = Cjto_Tablas1.Tables("OTEST_ELEMENTO_COMP").Rows.Find(BuscaOtEsE)
                If (Fila_OtestE Is Nothing) = False Then
                    '
                    'repeticiones
                    '
                    If Fila_OtestE("ELE_ESTADO") = "DuxA" Then
                        EstadoEs = "DuxA"
                        Exit For
                    End If

                    If Fila_OtestE("ELE_ESTADO") = "DuxR" Then
                        EstadoEs = "DuxR"
                    End If

                    If Fila_OtestE("ELE_ESTADO") = "DuRe" Then
                        If EstadoEs = "DuxR" Then Exit For
                        EstadoEs = "DuRe"
                    End If

                    'Normales

                    If Fila_OtestE("ELE_ESTADO") = "xA" Then
                        If EstadoEs = "DuxR" Or EstadoEs = "DuxA" Then Exit For
                        EstadoEs = "xA"
                        Exit For
                    End If
                    If Fila_OtestE("ELE_ESTADO") = "xR" Then
                        If EstadoEs = "DuxR" Or EstadoEs = "DuxA" Then Exit For
                        EstadoEs = "xR"
                    End If
                    If Fila_OtestE("ELE_ESTADO") = "Nulo" Then
                        If EstadoEs = "xR" Or EstadoEs = "xA" Or EstadoEs = "Re" Then Exit For
                        If EstadoEs = "DuxA" Or EstadoEs = "DuxR" Or EstadoEs = "DuRe" Then Exit For
                        EstadoEs = "Nulo"
                    End If

                    If Fila_OtestE("ELE_ESTADO") = "Re" Then
                        If EstadoEs = "xR" Then Exit For
                        EstadoEs = "Re"
                    End If
                End If
            Next
            ColorLetra = 3 : Fondo = "Normal"
            If EstadoEs = "DuxA" Then ColorLetra = 7 : Fondo = "Normal"
            If EstadoEs = "DuxR" Then ColorLetra = 13 : Fondo = "Normal"
            If EstadoEs = "DuRe" Then ColorLetra = 1 : Fondo = "Normal"
            If EstadoEs = "Nula" Then ColorLetra = 38 : Fondo = "Normal"


            If EstadoEs = "xA" Then ColorLetra = 3 : Fondo = "Normal"
            If EstadoEs = "xR" Then ColorLetra = 5 : Fondo = "Normal"
            If EstadoEs = "Re" Then ColorLetra = 1 : Fondo = "Normal"
            If EstadoEs = "Reot" Then ColorLetra = 45 : Fondo = "Normal"

        Catch ex As Exception
            ColorLetra = 3
        End Try
    End Sub

    Private Sub DG_Planificacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Planificacion.Click
        Try
            Dim f As Integer
            Mod_Cont = 0
            f = DG_Planificacion.CurrentCell.RowNumber
            If DG_Planificacion.Item(f, 0) = "" Then
                DG_Planificacion.Item(f, 0) = "x"
            Else
                DG_Planificacion.Item(f, 0) = ""
            End If
        Catch ex As Exception
            MsgBox("error: " & ex.Message.ToString)
        End Try
    End Sub
    'Dim cn As New CapaNegocio
    'Dim dt As New Data.DataTable
    'Dim f As DataRow
    'Dim i, a, b, c, d As Integer
    'i = 0
    'a = 0
    'b = 0
    'c = 0
    'd = 0

    ''     AddCellFormattingColumnStyles(Me.dgPlanificar, New FormatCellEventHandler(AddressOf FormatGridCells))


    ''Le creo las columnas al datatable
    'dataTableOT = New DataTable("Tabla")

    'dataTableOT.Columns.Add("nOT")
    'dataTableOT.Columns.Add("codAnalisis")
    'dataTableOT.Columns.Add("nLabDesde")
    'dataTableOT.Columns.Add("nLabHasta")


    'If Me.chFecha.Checked = True Then
    '    dt = Me.Ls_ObtieneDatosPlanificacionTableAdapter.GetData(Me.txNot.Text, Me.txProductor.Text, Me.txCodAnalisis.Text, Me.txAnalisis.Text, _
    '                Me.chFoliar.Checked, Me.chAgua.Checked, Me.chSuelo.Checked, Me.chOtros.Checked, Me.dfDesde.Text, Me.dfHasta.Text, Me.chUrgente.Checked)

    'Else
    '    dt = Me.Ls_ObtieneDatosPlanificacionTableAdapter.GetData(Me.txNot.Text, Me.txProductor.Text, Me.txCodAnalisis.Text, Me.txAnalisis.Text, _
    '                          Me.chFoliar.Checked, Me.chAgua.Checked, Me.chSuelo.Checked, Me.chOtros.Checked, "", "", Me.chUrgente.Checked)
    'End If

    'Me.dgPlanificar.Rows.Clear()
    'Me.dgPlanificar.Refresh()

    'For Each f In dt.Rows
    '    i = i + 1

    '    Dim dgvRow As New DataGridViewRow
    '    Dim dgvCell As DataGridViewCell
    '    'M:
    '    dgvCell = New DataGridViewCheckBoxCell()
    '    dgvCell.Value = False
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("OT_NUMERO")
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("OT_FECHA_ORDEN")
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("OT_DESP_FECHA")
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("PRO_PRODUCTOR")
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("OT_LOCALIDAD")
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewCheckBoxCell()
    '    dgvCell.Value = f("OT_DESP_URGENTE")
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("OTC_CANT_MUESTRAS")
    '    dgvRow.Cells.Add(dgvCell)

    '    'N LAB para Foliar
    '    If f("ANA_CODIGO") >= 1000 And f("ANA_CODIGO") < 2000 Then

    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = f("OTC_NLAB_DESDE") & "-" & f("OTC_NLAB_HASTA")
    '        dgvRow.Cells.Add(dgvCell)
    '        a = a + 1
    '    Else
    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = ""
    '        dgvRow.Cells.Add(dgvCell)
    '    End If

    '    'N LAB para Agua

    '    If f("ANA_CODIGO") >= 3000 And f("ANA_CODIGO") < 4000 Then

    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = f("OTC_NLAB_DESDE") & "-" & f("OTC_NLAB_HASTA")
    '        dgvRow.Cells.Add(dgvCell)
    '        b = b + 1
    '    Else
    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = ""
    '        dgvRow.Cells.Add(dgvCell)
    '    End If

    '    'N LAB para Suelo

    '    If f("ANA_CODIGO") >= 4000 And f("ANA_CODIGO") < 5000 Then

    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = f("OTC_NLAB_DESDE") & "-" & f("OTC_NLAB_HASTA")
    '        dgvRow.Cells.Add(dgvCell)
    '        c = c + 1
    '    Else
    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = ""
    '        dgvRow.Cells.Add(dgvCell)
    '    End If

    '    'N LAB para Otros

    '    If f("ANA_CODIGO") >= 2000 And f("ANA_CODIGO") < 3000 Then

    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = f("OTC_NLAB_DESDE") & "-" & f("OTC_NLAB_HASTA")
    '        dgvRow.Cells.Add(dgvCell)
    '        d = d + 1

    '    ElseIf f("ANA_CODIGO") >= 5000 Then

    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = f("OTC_NLAB_DESDE") & "-" & f("OTC_NLAB_HASTA")
    '        dgvRow.Cells.Add(dgvCell)
    '        d = d + 1
    '    Else
    '        dgvCell = New DataGridViewTextBoxCell()
    '        dgvCell.Value = ""
    '        dgvRow.Cells.Add(dgvCell)
    '    End If

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("ANA_CODIGO")
    '    dgvRow.Cells.Add(dgvCell)

    '    Dim s As New Label
    '    Dim sa As New Label
    '    Dim sb As New Label
    '    s.Text = "hola"
    '    sa.Text = "estoy"
    '    sb.Text = "probando"
    '    s.ForeColor = System.Drawing.Color.Maroon
    '    sa.ForeColor = System.Drawing.Color.Orange
    '    sb.ForeColor = System.Drawing.Color.Purple


    '    Dim dgvCell2 As New DataGridViewTextBoxEditingControl
    '    dgvCell2.ContainsFocus
    '    dgvCell2()
    '    dgvCell.DataGridView.Rows.Add(dgvCell2)
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("OT_EMPRESA")
    '    dgvRow.Cells.Add(dgvCell)

    '    dgvCell = New DataGridViewTextBoxCell()
    '    dgvCell.Value = f("OT_REMITE")
    '    dgvRow.Cells.Add(dgvCell)

    '    Me.dgPlanificar.Rows.Add(dgvRow)

    'Next

    'Me.txCantFoliar.Text = a.ToString
    'Me.txCantAgua.Text = b.ToString
    'Me.txCantSuelo.Text = c.ToString
    'Me.txCantOtros.Text = d.ToString
    'Me.txCantTotal.Text = i.ToString


    Private Sub F_Planificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cd As New CapaDato

        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectAnalisis", Cjto_Tablas1, "ANALISIS")

    End Sub

    Private Sub BTCerrarJocker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCerrarJocker.Click
        Me.GrbParamatros.Visible = False
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click

        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim via, fuente, destino, sMsg2 As String
        Dim MyDate As Date, sAño, sMes As String
        MyDate = Today
        Dim DUrg, Empresa_aux, Remitente_Aux, Urgente_Aux, query, NumerosLab, Fecha_Ot, Fecha_Despacho, Primera, Orden_Aux As String
        Dim Linea As Integer
        Dim dbman As DbManager
        FilaMarcaX = "N"
        Es_Planificacion = "S"
        Codigo_NumLabDesde = 0
        Cjto_Tablas1.Tables("CONSULTA_OT_OTCOD").Clear()

        Dim Fila_Consulta, Fila_Pla, FILA_TESTIGO, FILA_ESTANDAR As DataRow
        query = " execute ls_ObtieneDatosPlanificacionXAnalizar '" & Me.TxtOrdenDesde.Text & "'"

        dbman = New DbManager("CONSULTA_OT_OTCOD", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)
        Linea = 0 : Orden_Aux = 0 : Primera = "S" : DUrg = "N"
        Cjto_Tablas1.Tables("PLANIFICACION").Clear()

        For Each Fila_Consulta In Cjto_Tablas1.Tables("CONSULTA_OT_OTCOD").Rows
            Linea = Linea + 1
            NumerosLab = Fila_Consulta("OTC_NLAB_DESDE") & "-" & Mid(CStr(Fila_Consulta("OTC_NLAB_HASTA")), (Len(CStr(Fila_Consulta("OTC_NLAB_HASTA"))) - 2))
            Fecha_Ot = CStr(Fila_Consulta.Item("OT_FECHA_ORDEN"))
            Fecha_Ot = Mid(Fecha_Ot, 1, 2) & "/" & Mid(Fecha_Ot, 4, 2)

            Fecha_Despacho = CStr(Fila_Consulta.Item("OT_DESP_FECHA"))
            Fecha_Despacho = Mid(Fecha_Despacho, 1, 2) & "/" & Mid(Fecha_Despacho, 4, 2)
            Fila_Pla = Cjto_Tablas1.Tables("PLANIFICACION").NewRow
            Fila_Pla.BeginEdit()
            Fila_Pla.Item("MARCA") = ""

            If Primera = "S" Then
                If IsDBNull(Fila_Consulta.Item("OT_DESP_URGENTE")) = False Then
                    If Fila_Consulta.Item("OT_DESP_URGENTE") Then Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO")) & " U" Else Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO"))
                End If
                Fila_Pla.Item("PRO_PRODUCTOR") = Fila_Consulta.Item("PRO_PRODUCTOR")
                Fila_Pla.Item("OT_FECHA_ORDEN") = Fecha_Ot
                Fila_Pla.Item("OT_DESP_FECHA") = Fecha_Despacho
                Fila_Pla.Item("PRO_EMPRESA") = Fila_Consulta.Item("OT_EMPRESA")
                Fila_Pla.Item("PRO_REMITE") = Fila_Consulta.Item("OT_REMITE")
                Fila_Pla.Item("OT_LOCALIDAD") = Fila_Consulta.Item("OT_LOCALIDAD")
                GoTo primera
            End If

            If IsDBNull(Fila_Consulta.Item("OT_DESP_URGENTE")) = False Then
                If Fila_Consulta.Item("OT_DESP_URGENTE") Then Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO")) & " U" Else Fila_Pla.Item("OT_NUMERO") = CStr(Fila_Consulta.Item("OT_NUMERO"))
            End If
            Fila_Pla.Item("PRO_PRODUCTOR") = Fila_Consulta.Item("PRO_PRODUCTOR")
            Fila_Pla.Item("OT_FECHA_ORDEN") = Fecha_Ot
            Fila_Pla.Item("OT_DESP_FECHA") = Fecha_Despacho
            Fila_Pla.Item("OT_LOCALIDAD") = Fila_Consulta.Item("OT_LOCALIDAD")
            Fila_Pla.Item("PRO_EMPRESA") = Fila_Consulta.Item("OT_EMPRESA")
            Fila_Pla.Item("PRO_REMITE") = Fila_Consulta.Item("OT_REMITE")
primera:
            Primera = "N"
            Fila_Pla.Item("OTC_CANT_MUESTRAS") = Fila_Consulta.Item("OTC_CANT_MUESTRAS")
            If Mid(CStr(Fila_Consulta.Item("ANA_CODIGO")), 1, 1) = 1 Then
                Fila_Pla.Item("NUMLAB1") = NumerosLab
                Fila_Pla.Item("NUMLAB2") = ""
                Fila_Pla.Item("NUMLAB3") = ""
                Fila_Pla.Item("NUMLAB4") = "" : GoTo LABORATORIO
            Else
                Fila_Pla.Item("NUMLAB1") = ""
            End If
            If Mid(CStr(Fila_Consulta.Item("ANA_CODIGO")), 1, 1) = 3 Then
                Fila_Pla.Item("NUMLAB2") = NumerosLab
                Fila_Pla.Item("NUMLAB3") = ""
                Fila_Pla.Item("NUMLAB4") = "" : GoTo LABORATORIO
            Else
                Fila_Pla.Item("NUMLAB2") = ""
            End If
            If Mid(CStr(Fila_Consulta.Item("ANA_CODIGO")), 1, 1) = 4 Then
                Fila_Pla.Item("NUMLAB3") = NumerosLab
                Fila_Pla.Item("NUMLAB4") = "" : GoTo LABORATORIO
            Else
                Fila_Pla.Item("NUMLAB3") = ""
            End If
            Fila_Pla.Item("NUMLAB4") = NumerosLab
LABORATORIO:

            'Empresa_aux = Fila_Consulta.Item("OT_EMPRESA")
            'Remitente_Aux = Fila_Consulta.Item("OT_REMITE")
            Fila_Pla.Item("ANA_CODIGO") = Fila_Consulta.Item("ANA_CODIGO")
            Fila_Pla.Item("ANA_ANALISIS") = Fila_Consulta.Item("ANA_ANALISIS")
            Fila_Pla.Item("OT_LINEA") = Linea
            Fila_Pla.EndEdit()
            Cjto_Tablas1.Tables("PLANIFICACION").Rows.Add(Fila_Pla)
            Orden_Aux = CStr(Fila_Consulta.Item("OT_NUMERO"))
        Next
        '''hasta aqui solamente le ha asignado los valores de la consulta a la tabla "Planificacion" que carga la grilla , nada de colores y otros
        ''' 
        Call Traspaso_Planificacion1()


        fuente = "F:\Archivos LabSys\Formatos Labsys\Formato Lista OT x Analizar.xls"
        destino = "F:\Archivos LabSys\Planificacion\OT x Analizar\" & TxtOrdenDesde.Text & " " & MyDate & " Listado OT x Analizar.xls"

        Imprime_Plani.Crea_Excel(fuente, destino)
        Call Imprime_ListadoOT(objHojaExcel, m_Excel, destino)
        GrpOrdenDesde.Visible = False
        Me.Close()

    End Sub

    Private Sub Imprime_ListadoOT(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal excell As Excel.Application, ByVal destino As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim SwEmpresa, ll, SwGuion, Fila_Descripcion, Ultima_Fila, IntMuestra, IntSub, IntNLab, xx, CodAnalEx, NumeroDeOt, Fila_Combo, i, Largo, fila, fila_pie, fila_logo, fila_nota, ContFila, Muestra_Aux As Integer
        Dim Ot_NumEx, SubMuestra, Tipo_Analisis, StrEle, EleUlt, NumLabEx, swich, Empr, Reme, EmpRem, NumLab, caracter, query, vernom, FechaI, CodMueC, NumLabo, Acumula, Espacios As String
        Dim BuscaSub, BUSCA, BusMue, BuscaAna As Object
        Dim Fila_Sub, FILA_OTEST_ELEMENTO, Fila_Orden, FILA_PLANIFICACION, FILA_MUESTRA, Fila_Analisis, Fila_Ultima As DataRow
        Dim FechaDia As Date
        Dim Ot_Num_Mom, Maneja_Ot, MyPos, Lpag, Lcont, Fila_Titulo As Integer
        Dim DBMan1 As DbManager
        Dim ds As DataSet = New DataSet
        Espacios = "            "
        FechaDia = Now
        BUSCA = Orden_Trabajo
        fila = 2 : Lpag = 1
        'HOJA_EXCEL.Range("A1").Select()
        Fila_Orden = Cjto_Orden1.Tables("ORDEN_TRABAJO").Rows.Find(BUSCA)
        'ORDEN
        Call Encabezado_Listado(fila, FechaDia, "LISTADO OT POR ANALIZAR")
        Muestra_Aux = 0
        ContFila = 0
        swich = "S" : SwEmpresa = 0 : Ot_NumEx = "0" : Lcont = 50

        For Each FILA_PLANIFICACION In Cjto_Tablas1.Tables("PLANIFICACION").Rows
            MyPos = InStr(FILA_PLANIFICACION("OT_NUMERO"), "u")
            If MyPos > 0 Then Maneja_Ot = Mid(FILA_PLANIFICACION("OT_NUMERO"), 1, MyPos - 1) Else Maneja_Ot = FILA_PLANIFICACION("OT_NUMERO")
            If Maneja_Ot < TxtOrdenDesde.Text Then GoTo SaltoxRango

            If IsDBNull(FILA_PLANIFICACION("PRO_PRODUCTOR")) = False Then
                If FILA_PLANIFICACION("PRO_PRODUCTOR") = " ****  FINAL *****" Then Exit For
            End If
            fila = fila + 1
            If FILA_PLANIFICACION("OT_NUMERO") = "" Then
                FILA_PLANIFICACION("OT_NUMERO") = Ot_NumEx
            End If
            If Ot_NumEx <> "0" And Ot_NumEx <> FILA_PLANIFICACION("OT_NUMERO") Then
                Call BORDES_FILA_LADOS(fila)
                'If ContFila = 1 Then fila = fila + 1
                With Imprime_Plani.HojaE.Range("A" & fila.ToString & ":GQ" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                swich = "S"
                ContFila = 0
            End If
            'OT
            MyPos = 0
            If FILA_PLANIFICACION("OT_NUMERO") <> Ot_NumEx Then
                Call Busca_Salto_Pagina(Imprime_Plani.HojaE, FechaDia, FILA_PLANIFICACION("OT_NUMERO"), fila, Lpag)
                MyPos = InStr(FILA_PLANIFICACION("OT_NUMERO"), "u")
                If MyPos > 0 Then Ot_Num_Mom = Mid(FILA_PLANIFICACION("OT_NUMERO"), 1, MyPos - 1) Else Ot_Num_Mom = FILA_PLANIFICACION("OT_NUMERO")
                Imprime_Plani.Imprime_Linea(fila, fila, "A", "G", 8, "Center", "Center", False, "", "", "'" & FILA_PLANIFICACION("OT_NUMERO"))
                Ot_NumEx = FILA_PLANIFICACION("OT_NUMERO")
                'FECHA ING
                If IsDBNull(FILA_PLANIFICACION("OT_FECHA_ORDEN")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "H", "L", 6, "Center", "Center", False, "dd/mm", "", FILA_PLANIFICACION("OT_FECHA_ORDEN"))
                End If
                'FECHA DESP.
                If IsDBNull(FILA_PLANIFICACION("OT_DESP_FECHA")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "M", "Q", 6, "Center", "Center", False, "dd/mm", "", FILA_PLANIFICACION("OT_DESP_FECHA"))
                End If
                'PRODUCTOR
                If IsDBNull(FILA_PLANIFICACION("PRO_PRODUCTOR")) = False Then
                    Imprime_Plani.Imprime_Linea(fila, fila, "R", "AN", 7, "Left", "Center", False, "", "", FILA_PLANIFICACION("PRO_PRODUCTOR"))
                End If
            End If

            'If swich = "S" Then
            '    If IsDBNull(FILA_PLANIFICACION("PRO_EMPRESA")) = True Then FILA_PLANIFICACION("PRO_EMPRESA") = ""
            '    If IsDBNull(FILA_PLANIFICACION("PRO_REMITE")) = True Then FILA_PLANIFICACION("PRO_REMITE") = ""
            '    Imprime_Plani.Imprime_Linea(fila + 1, fila + 1, "L", "AN", 7, "Left", "Center", False, "", "", FILA_PLANIFICACION("PRO_EMPRESA") & " / " & FILA_PLANIFICACION("PRO_REMITE"))
            '    Empr = FILA_PLANIFICACION("PRO_EMPRESA")
            '    Reme = FILA_PLANIFICACION("PRO_REMITE")
            '    'If MyPos > 0 Then
            '    'Imprime_Plani.Imprime_Linea(fila + 1, fila + 1, "G", "K", 6, "Center", "Center", False, "", "", "Urg")
            '    'End If
            'swich = "N"
            'End If

            'LOCALIDAD
            If IsDBNull(FILA_PLANIFICACION("OT_LOCALIDAD")) = False Then
                Imprime_Plani.Imprime_Linea(fila, fila, "AO", "AX", 7, "Left", "Center", False, "", "", FILA_PLANIFICACION("OT_LOCALIDAD"))
            End If


            If IsDBNull(FILA_PLANIFICACION("NUMLAB1")) = True And IsDBNull(FILA_PLANIFICACION("NUMLAB2")) = True And IsDBNull(FILA_PLANIFICACION("NUMLAB3")) = True Then
                Call BORDES_FILA_LADOS(fila)
            End If

            'CANT
            If IsDBNull(FILA_PLANIFICACION("OTC_CANT_MUESTRAS")) = False Then
                Imprime_Plani.Imprime_Linea(fila, fila, "AY", "BB", 7, "Center", "Center", False, "", "", FILA_PLANIFICACION("OTC_CANT_MUESTRAS"))
            End If

            If IsDBNull(FILA_PLANIFICACION("NUMLAB1")) = True Then FILA_PLANIFICACION("NUMLAB1") = ""
            If IsDBNull(FILA_PLANIFICACION("NUMLAB2")) = True Then FILA_PLANIFICACION("NUMLAB2") = ""
            If IsDBNull(FILA_PLANIFICACION("NUMLAB3")) = True Then FILA_PLANIFICACION("NUMLAB3") = ""
            If IsDBNull(FILA_PLANIFICACION("NUMLAB4")) = True Then FILA_PLANIFICACION("NUMLAB4") = ""

            If FILA_PLANIFICACION("NUMLAB1") <> "" Then
                Imprime_Plani.Imprime_Linea(fila, fila, "BC", "BL", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB1"))
                NumLabEx = FILA_PLANIFICACION("NUMLAB1")
            End If
            If FILA_PLANIFICACION("NUMLAB2") <> "" Then
                Imprime_Plani.Imprime_Linea(fila, fila, "BM", "BV", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB2"))
                NumLabEx = FILA_PLANIFICACION("NUMLAB2")
            End If
            If FILA_PLANIFICACION("NUMLAB3") <> "" Then
                Imprime_Plani.Imprime_Linea(fila, fila, "BW", "CF", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB3"))
                NumLabEx = FILA_PLANIFICACION("NUMLAB3")
            End If

            If FILA_PLANIFICACION("NUMLAB4") <> "" Then
                Imprime_Plani.Imprime_Linea(fila, fila, "CG", "CP", 8, "Center", "Center", False, "", "", FILA_PLANIFICACION("NUMLAB4"))
                NumLabEx = FILA_PLANIFICACION("NUMLAB4")
            End If

            'CODIGO
            If IsDBNull(FILA_PLANIFICACION("ANA_CODIGO")) = False Then
                Imprime_Plani.Imprime_Linea(fila, fila, "CQ", "CV", 7, "Center", "Center", False, "####", "", FILA_PLANIFICACION("ANA_CODIGO"))
                CodAnalEx = FILA_PLANIFICACION("ANA_CODIGO")
                ContFila = ContFila + 1
            End If
            'DESCRIPCION 
            'Consulta Otest_Elemento
            Acumula = ""
            For xx = 1 To Len(NumLabEx)
                caracter = Mid(NumLabEx, xx, 1)
                If caracter = "-" Then
                    IntNLab = CInt(Trim(Acumula))
                    Exit For
                End If
                Acumula = Acumula + caracter
            Next
            IntNLab = CInt(Acumula)

            BuscaAna = CodAnalEx
            Fila_Analisis = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaAna)
            IntMuestra = Fila_Analisis("TMU_CODIGO")
            IntSub = Fila_Analisis("SUB_CODIGO")

            Tipo_Analisis = Fila_Analisis("TIPO_COD")

            BuscaSub = IntSub
            Fila_Sub = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaSub)
            If Not (Fila_Sub Is Nothing) = True Then SubMuestra = Fila_Sub("ANA_ANALISIS") Else SubMuestra = ""


            Cjto_Tablas1.Tables("OTEST_ELEMENTO").Clear()
            Cjto_Tablas1.Tables("OTEST_ELEMENTO_COMP").Clear()


            If IsDBNull(FILA_PLANIFICACION("ANA_CODIGO")) = False Then
                Try
                    With SP
                        .Inicializar()
                        .AgregarParametro("@NumOt", Ot_Num_Mom, SqlDbType.Int)
                        .AgregarParametro("@NLab", IntNLab, SqlDbType.Int)
                        .AgregarParametro("@CodAna", CodAnalEx, SqlDbType.Float)
                        .AgregarParametro("@Tipo_Analisis", Tipo_Analisis, SqlDbType.NVarChar)
                        .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                        .EjecutarQueryDt("usp_SelectPlanificacion", Cjto_Tablas1, "OTEST_ELEMENTO")
                    End With
                Catch ex As Exception
                    MsgBox("Error en consulta")
                End Try

                Try
                    With SP
                        .Inicializar()
                        .AgregarParametro("@NumOt", Ot_Num_Mom, SqlDbType.Int)
                        .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                        .EjecutarQueryDt("usp_SelectPlanificacionElemento", Cjto_Tablas1, "OTEST_ELEMENTO_COMP")
                    End With

                    With SP
                        .Inicializar()
                        .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                        .AgregarParametro("@NLabDesde", IntNLab, SqlDbType.Int)
                        .AgregarParametro("@NLabHasta", IntNLab, SqlDbType.Int)
                        ds = .EjecutarQuery("usp_SelectPlanificacionSubTitulo")
                    End With

                Catch ex As Exception
                    MsgBox("Error en consulta")
                End Try


                'If SubMuestra <> "" Then Acumula = SubMuestra & ":" Else Acumula = ""
                Acumula = "            "
                Largo = 0 : SwGuion = 0 : Fila_Descripcion = 1 : Fila_Titulo = 1

                For Each FILA_OTEST_ELEMENTO In Cjto_Tablas1.Tables("OTEST_ELEMENTO").Rows
                    ll = 0
                    If Tipo_Analisis <> "JA" And Fila_Descripcion <> CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1)) Then
                        Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).Merge()
                        Acumula = Mid(Acumula, 1, Len(Acumula) - 1)
                        Imprime_Plani.HojaE.Range("CW" & fila.ToString).Value = Acumula
                        Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Size = 8
                        Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Bold = False
                        Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.ColorIndex = 1

                        Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Name = "Courier New"
                        Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        'Imprime_Plani.Imprime_Linea(fila, fila, "CW", "GB", 8, "Left", "Center", False, "", "", Acumula)
                        'Call Control_Letra(HOJA_EXCEL, excell, Acumula, fila, Ot_Num_Mom, CodAnalEx, NumLabEx, 13, Fila_Descripcion)
                        Call BORDES_FILA_LADOS(fila)
                        ContFila = ContFila + 1
                        fila = fila + 1
                        Acumula = ""
                        ll = 0
                        StrEle = FILA_OTEST_ELEMENTO("ELE_COD_DES")
                        If IsDBNull(FILA_OTEST_ELEMENTO("TITULO_FILA")) = False Then
                            If Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) > 0 Then
                                Acumula = FILA_OTEST_ELEMENTO("TITULO_FILA") & Mid(Espacios, Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) + 1)
                                If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":" & StrEle & "-"
                                ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":" & StrEle & "-"
                                Else
                                    Acumula = Acumula & "             " & ":" & StrEle & "-"
                                End If
                            Else
                                Acumula = "            " '& StrEle & "-"
                                If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":" & StrEle & "-"
                                ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":" & StrEle & "-"
                                Else
                                    Acumula = Acumula & "            " & ":" & StrEle & "-"
                                End If
                            End If
                        Else
                            Acumula = "             "
                            If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":" & StrEle & "-"
                            ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":" & StrEle & "-"
                            Else
                                Acumula = Acumula & "            " & ":" & StrEle & "-"
                            End If
                        End If
                        Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
                    Else
                        If CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1)) = 1 And SwGuion = 0 Then
                            If IsDBNull(FILA_OTEST_ELEMENTO("TITULO_FILA")) = False Then
                                If Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) > 0 Then
                                    Acumula = FILA_OTEST_ELEMENTO("TITULO_FILA") & Mid(Espacios, Len(FILA_OTEST_ELEMENTO("TITULO_FILA")) + 1)
                                    If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":"
                                    ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":"
                                    Else
                                        Acumula = Acumula & "             " & ":"
                                    End If
                                Else
                                    Acumula = "            "
                                    If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":"
                                    ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                        Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":"
                                    Else
                                        Acumula = Acumula & "             " & ":"
                                    End If
                                End If
                                SwGuion = 1
                            Else
                                Acumula = "            "
                                If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("OTRO_TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("OTRO_TITULO")) + 1) & ":"
                                ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                                    Acumula = Acumula & " " & ds.Tables(0).Rows(0).Item("TITULO") & Mid(Espacios, Len(ds.Tables(0).Rows(0).Item("TITULO")) + 1) & ":"
                                Else
                                    Acumula = Acumula & "             " & ":"
                                End If
                                SwGuion = 1
                            End If
                        End If
                        If Tipo_Analisis = "JA" Then
                            StrEle = FILA_OTEST_ELEMENTO("ELE_COD_DES")
                            Acumula = Acumula & StrEle & "-"
                            Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
                            GoTo SaltoeleJocker2
                        End If

                        If IsDBNull(FILA_OTEST_ELEMENTO("TITULO_FILA")) = False Then
                            If FILA_OTEST_ELEMENTO("TITULO_FILA") <> "NoDespliegaPlan" Then
                                StrEle = FILA_OTEST_ELEMENTO("ELE_COD_DES")
                                Acumula = Acumula & StrEle & "-"
                                Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
                            End If
                        End If
SaltoeleJocker2:
                    End If
                Next
                If ll > 0 Then fila = fila - 1
                Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).Merge()
                Acumula = Mid(Acumula, 1, Len(Acumula) - 1)
                Imprime_Plani.HojaE.Range("CW" & fila.ToString).Value = Acumula
                Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Size = 8
                Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Bold = False
                Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.Name = "Courier New"
                Imprime_Plani.HojaE.Range("CW" & fila.ToString).Font.ColorIndex = 1

                Imprime_Plani.HojaE.Range("CW" & fila.ToString & ":GQ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                'Imprime_Plani.Imprime_Linea(fila, fila, "CW", "GB", 8, "Left", "Center", False, "", "", Acumula)
                'Call Control_Letra(Imprime_Plani.HojaE, excell, Acumula, fila, Ot_Num_Mom, CodAnalEx, NumLabEx, 26, Fila_Descripcion)
                Call BORDES_FILA_LADOS(fila)
                'If ContFila = 0 And Fila_Combo = 0 Then ContFila = 1 : fila = fila + 1
            End If
SaltoxRango:
        Next
        fila = fila + 1
        Imprime_Plani.BordesI(1, 2, fila, fila, "A", "GQ")
        Call IMPRIME_NUMERO_PAGINAS(Lpag)
        fila = 24
        fila = fila + 1

        Imprime_Plani.Cierra_Excel(destino)

        '      Imprime_Plani.HojaE.PrintOut()
        '      Imprime_Plani.ExcelA.Workbooks(1).Save()
        '      Imprime_Plani.ExcelA.Workbooks.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.GrpOrdenDesde.Visible = False

    End Sub
   
    Private Sub TxtOrdenDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOrdenDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.CmdAceptar_Click(sender, e)
        End If

    End Sub

    Private Sub txNotDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNotDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNotHasta.Text = Me.txNotDesde.Text
            Me.txNotHasta.Focus()
        End If
    End Sub

    Private Sub txNotHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNotHasta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnBuscar_Click(sender, e)
        End If
    End Sub

End Class