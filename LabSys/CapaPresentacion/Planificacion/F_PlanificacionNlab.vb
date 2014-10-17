Imports System.IO
Imports System
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp
Imports RtfWriter = iTextSharp.text.rtf.RtfWriter
Imports iTextSharp.text.Image

Public Class F_PlanificacionNlab

    Private Sub btnPlanificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanificar.Click
        GenerarPDF()
        ImprimirPLan(sender, e)
    End Sub

    Private Sub ImprimirPlan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '        Try
        '            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        '            ' Dim dbman As DbManager
        '            Dim MuestraPlani, Fuente, Destino, Formula, sRutaDest, sRutaDestino, LetraSpectro As String
        '            Dim CantBlancos, Tabla_Testigos, Tabla_Estandar, Tabla_Duplicados, query, Ele_Aux, ES_Primera, ColuD, ColuH, ColuD2, ColuH2, ColuD3, ColuH3, ColumnaFinal, Columna As String
        '            Dim Fila_TodosDuxA, Fila_Te, Fila_Es, Fila_EleLab, Fila_Con, Fila_Plan, Fila_Ele, Fila_NomPla, Fila_Elemento, Fila_Plani, Fila_TraspasoEle As DataRow
        '            Dim BuscaNomPla, BuscaEle(1), BuscaEleLab(1) As Object
        '            Dim Fila_Seleccion, Fila_Ordenada As DataRow()
        '            Dim ds As DataSet
        '            Dim sTmp, EleTemp, Acumula, NumLabEx, caracter As String 'Temporal para seguimiento de código.
        '            Dim BlancoText, IntNLab, xx As Integer
        '            EleTemp = ""

        '            '   Call Rescata_Testigo_Estandar_Cant()

        '            '********* Dim objHojaExcel, objHojaExcel1 As Excel.Worksheet
        '            '********* Dim m_Excel As Excel.Application
        '            Dim Priori, XCant, XC, XEstandar, XE, XTestigo, XT, PosGrupoCol, Mypos, Fil1, Fil2, Fil3, MaxFil, Fila, pos, Lab_Aux, Consulta_Orden, Orden_Auxiliar, NumDuplicacion, Consulta_Orden_Urgente, Orden_Auxiliar_Urgente As Integer
        '            Dim MyDate As Date, sAño, sMes As String

        '            MyDate = Today
        '            Select Case Month(Today)
        '                Case 1
        '                    sMes = "01 Enero"
        '                Case 2
        '                    sMes = "02 Febrero"
        '                Case 3
        '                    sMes = "03 Marzo"
        '                Case 4
        '                    sMes = "04 Abril"
        '                Case 5
        '                    sMes = "05 Mayo"
        '                Case 6
        '                    sMes = "06 Junio"
        '                Case 7
        '                    sMes = "07 Julio"
        '                Case 8
        '                    sMes = "08 Agosto"
        '                Case 9
        '                    sMes = "09 Septiembre"
        '                Case 10
        '                    sMes = "10 Octubre"
        '                Case 11
        '                    sMes = "11 Noviembre"
        '                Case 12
        '                    sMes = "12 Diciembre"
        '            End Select
        '            Ele_Aux = ""
        '            NumLabDesde = 0

        '            Cjto_Tablas1.Tables("PLANTI_ELE").Clear()
        '            Cjto_Tablas1.Tables("PLANTI_ELELAB").Clear()
        '            Cjto_Tablas1.Tables("PLANI_RESUMEN").Clear()
        '            Cjto_Tablas1.Tables("NO_PLANI_RESUMEN").Clear()
        '            Cjto_Tablas1.Tables("ANA_NLAB").Clear()

        '            ' ****************** Nueva seccion impresion ******************
        '            sAño = Year(Today)
        '            sRutaDestino = "F:\Archivos LabSys\Planificacion\Planificacion " & sAño

        '            Fuente = "F:\Archivos LabSys\Formatos Labsys\Formato Planificacion Resumen" & ".xls"

        '            If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
        '                MkDir(sRutaDestino)
        '            End If
        '            sRutaDest = sRutaDestino & "\" & sMes
        '            If Dir(sRutaDest, FileAttribute.Directory) = "" Then
        '                MkDir(sRutaDest)
        '            End If
        '            Destino = sRutaDest & "\" & MyDate & " Planificacion Diaria.xls"


        '            ' frmEspere.lblMsg2.Text = "Imprimiendo Planillas de Planificación y de Digitación de Resultados"
        '            ' frmEspere.Show()
        '            ' frmEspere.Refresh()
        '            Imprime_Plani.Crea_Excel(Fuente, Destino) 'CREA SOLAMENTE EL ARCHIVO
        '            'frmEspere.Select()


        '            '******************* fin nueva seccion *****************
        '            'frmEspere.lblMsg2.Text = "Imprimiendo Planilla de Planificación..."
        '            'frmEspere.Refresh()

        '            Call Imprime_Resumen_Planificacion()

        '            'Call Llena_Plani_Resumen(iPtr, Destino)
        '            For Each Fila_Plani In Cjto_Tablas1.Tables("PLANIFICACION").Rows
        '                If Fila_Plani("MARCA") = "x" Then
        '                    If Fila_Plani("NUMLAB1") <> "" Then
        '                        NumLabEx = Fila_Plani("NUMLAB1")
        '                    End If
        '                    If Fila_Plani("NUMLAB2") <> "" Then
        '                        NumLabEx = Fila_Plani("NUMLAB2")
        '                    End If
        '                    If Fila_Plani("NUMLAB3") <> "" Then
        '                        NumLabEx = Fila_Plani("NUMLAB3")
        '                    End If

        '                    If Fila_Plani("NUMLAB4") <> "" Then
        '                        NumLabEx = Fila_Plani("NUMLAB4")
        '                    End If
        '                    Exit For
        '                End If
        '            Next

        '            Acumula = ""
        '            For xx = 1 To Len(NumLabEx)
        '                caracter = Mid(NumLabEx, xx, 1)
        '                If caracter = "-" Then
        '                    IntNLab = CInt(Trim(Acumula))
        '                    Exit For
        '                End If
        '                Acumula = Acumula + caracter
        '            Next
        '            IntNLab = CInt(Acumula)

        '            Try
        '                With SP
        '                    .Inicializar()
        '                    .AgregarParametro("@FechaPlani", MyDate, SqlDbType.DateTime)
        '                    .AgregarParametro("@NLabDesde", IntNLab, SqlDbType.NVarChar)
        '                    .EjecutarQuery("usp_DeletePlanificacionPlani")
        '                End With
        '            Catch ex As Exception
        '                MsgBox("Error en consulta borrar planificacion")
        '            End Try


        '            For Each Fila_Plani In Cjto_Tablas1.Tables("PLANIFICACION").Rows
        '                'frmEspere.lblMsg2.Text = "Preparando Planillas de Digitación de Resultados..."
        '                'frmEspere.Refresh()
        '                If IsDBNull(Fila_Plani("ANA_CODIGO")) = True Then GoTo SALTOxNULO
        '                If Fila_Plani("MARCA") = "x" Then
        '                    MM = Mid(CStr(Fila_Plani("ANA_CODIGO")), 1, 1) & "000"
        '                    If Fila_Plani("OT_NUMERO") <> "" Then
        '                        sTmp = Fila_Plani("OT_NUMERO")
        '                        Mypos = InStr(Fila_Plani("OT_NUMERO"), "U")
        '                        If Mypos <> 0 Then
        '                            Consulta_Orden_Urgente = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1))
        '                        End If
        '                        If Mypos > 0 Then Consulta_Orden = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1)) Else Consulta_Orden = CInt(Fila_Plani("OT_NUMERO"))
        '                    Else
        '                        Consulta_Orden = Orden_Auxiliar
        '                    End If
        '                    Cjto_Tablas1.Tables("PLANTI_CODIGO").Clear()
        '                    Try
        '                        With SP
        '                            .Inicializar()
        '                            .AgregarParametro("@NumOt", Consulta_Orden, SqlDbType.Int)
        '                            .AgregarParametro("@CodAna", Fila_Plani("ANA_CODIGO"), SqlDbType.Float)
        '                            .EjecutarQueryDt("usp_SelectPlanificacionCodEle", Cjto_Tablas1, "PLANTI_CODIGO")
        '                        End With
        '                    Catch ex As Exception
        '                        MsgBox("Error en consulta")
        '                    End Try

        '                    For Each Fila_TraspasoEle In Cjto_Tablas1.Tables("PLANTI_CODIGO").Rows
        '                        Fila_Con = Cjto_Tablas1.Tables("PLANTI_ELE").NewRow
        '                        Fila_Con("ELE_CODIGO") = Fila_TraspasoEle("ELE_CODIGO")
        '                        Fila_Con("TMU_CODIGO") = Fila_TraspasoEle("TMU_CODIGO")
        '                        Fila_Con("ANA_CODIGO") = Fila_TraspasoEle("ANA_CODIGO")
        '                        Fila_Con("ELE_CAL_FORMULA") = Fila_TraspasoEle("ELE_CAL_FORMULA")
        '                        Fila_Con("ELE_PLANILLA") = Fila_TraspasoEle("ELE_PLANILLA")
        '                        Fila_Con("ELE_COMENTARIO") = Fila_TraspasoEle("ELE_COMENTARIO")
        '                        Fila_Con("ELE_NOMBRE") = Fila_TraspasoEle("ELE_NOMBRE")
        '                        Fila_Con("ELE_PRIORIDAD") = Fila_TraspasoEle("ELE_PRIORIDAD")
        '                        Fila_Con("ELE_PROCESO") = Fila_TraspasoEle("ELE_PROCESO")
        '                        Try
        '                            Cjto_Tablas1.Tables("PLANTI_ELE").Rows.Add(Fila_Con)
        '                        Catch ex As Exception
        '                        End Try
        '                    Next

        '                    Try
        '                        With SP
        '                            .Inicializar()
        '                            .AgregarParametro("@NumOt", Consulta_Orden, SqlDbType.Int)
        '                            .AgregarParametro("@CodAna", Fila_Plani("ANA_CODIGO"), SqlDbType.Float)
        '                            .EjecutarQueryDt("usp_SelectPlanificacionCodEleNLab", Cjto_Tablas1, "PLANTI_ELELAB")
        '                        End With
        '                    Catch ex As Exception
        '                        MsgBox("Error en consulta")
        '                    End Try
        '                End If

        'SALTOxNULO:
        '                If Fila_Plani("OT_NUMERO") <> "" And Fila_Plani("OT_NUMERO") <> "0" Then
        '                    Mypos = InStr(Fila_Plani("OT_NUMERO"), "U")
        '                    If Mypos <> 0 Then
        '                        Orden_Auxiliar_Urgente = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1))
        '                    End If
        '                    If Mypos > 0 Then Orden_Auxiliar = CInt(Mid(Fila_Plani("OT_NUMERO"), 1, Mypos - 1)) Else Orden_Auxiliar = CInt(Fila_Plani("OT_NUMERO"))
        '                End If
        '            Next

        '            Fila_Ordenada = Cjto_Tablas1.Tables("PLANTI_ELE").Select("", "ELE_PRIORIDAD ASC")

        '            Dim StrElementos As String
        '            For Each Fila_Ele In Fila_Ordenada
        '                If Fila_Ele("ELE_PROCESO") = "Autogenerado" And Fila_Ele("ELE_CODIGO") <> "%Piedra" Then GoTo SaltoxAutogenerado
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 1 Then MuestraPlani = "Foliar" : BlancoText = TxtCantBlancosFoliar.Text : Tabla_Testigos = "TESTIGO_PLANIFOLIAR" : Tabla_Estandar = "ESTANDAR_PLANIFOLIAR" : Tabla_Duplicados = "DUPLICA_PLANIFOLIAR" : MM = 1000
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 2 Then MuestraPlani = "Otros Tejidos" : BlancoText = TxtCantBlancosTejidos.Text : Tabla_Testigos = "TESTIGO_PLANITEJIDOS" : Tabla_Estandar = "ESTANDAR_PLANITEJIDOS" : Tabla_Duplicados = "DUPLICA_PLANITEJIDOS" : MM = 2000
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 3 Then MuestraPlani = "Agua" : BlancoText = TxtCantBlancosAgua.Text : Tabla_Testigos = "TESTIGO_PLANIAGUA" : Tabla_Estandar = "ESTANDAR_PLANIAGUA" : Tabla_Duplicados = "DUPLICA_PLANIAGUA" : MM = 3000
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 4 Then MuestraPlani = "Suelo" : BlancoText = TxtCantBlancosSuelo.Text : Tabla_Testigos = "TESTIGO_PLANISUELO" : Tabla_Estandar = "ESTANDAR_PLANISUELO" : Tabla_Duplicados = "DUPLICA_PLANISUELO" : MM = 4000
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 5 Then MuestraPlani = "Fertilizante Quimico" : BlancoText = TxtCantBlancosFertQui.Text : Tabla_Testigos = "TESTIGO_PLANIFERTQUI" : Tabla_Estandar = "ESTANDAR_PLANIFERTQUI" : Tabla_Duplicados = "DUPLICA_PLANIFERTQUI" : MM = 5000
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 6 Then MuestraPlani = "Fertilizante Organico" : BlancoText = TxtCantBlancosFertOrg.Text : Tabla_Testigos = "TESTIGO_PLANIFERTORG" : Tabla_Estandar = "ESTANDAR_PLANIFERTORG" : Tabla_Duplicados = "DUPLICA_PLANIFERTORG" : MM = 6000
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 7 Then MuestraPlani = "Otros Análisis" : BlancoText = TxtCantBlancosOtrosAnalisis.Text : Tabla_Testigos = "TESTIGO_PLANIOTROSANALISIS" : Tabla_Estandar = "ESTANDAR_PLANIOTROSANALISIS" : Tabla_Duplicados = "DUPLICA_PLANIOTROSANALISIS" : MM = 7000
        '                If Mid(Fila_Ele("ANA_CODIGO"), 1, 1) = 8 Then MuestraPlani = "Ventas" : BlancoText = TxtCantBlancosVentas.Text : Tabla_Testigos = "TESTIGO_PLANIVENTAS" : Tabla_Estandar = "ESTANDAR_PLANIVENTAS" : Tabla_Duplicados = "DUPLICA_PLANIVENTAS" : MM = 8000
        '                Imprime_Plani.Crea_Hoja_Excel(Fila_Ele("ELE_CODIGO"), 1, 18, MM)
        '                Imprime_Plani.SinCurva(Fila_Ele("ELE_NOMBRE"), MuestraPlani)
        '                Imprime_Plani.DatosI(MyDate, "Elemento", IntNLab)
        '                Primo = "S"
        '                TMU_CODI = ""
        '                ES_Primera = "S"
        '                pos = 1
        '                Lab_Aux = 1
        '                Priori = 0
        '                Columna = ""
        '                Imprime_Plani.CFilaInicial = 11
        '                Fila = Imprime_Plani.CFilaInicial
        '                Imprime_Plani.CPagina = 1
        '                Imprime_Plani.CFilasHoja = 42
        '                Imprime_Plani.CMaxFilasImp = 41

        '                Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Nº Lab")
        '                Imprime_Plani.BordesI(4, 1, Fila, Fila, "A", "F")
        '                Imprime_Plani.Imprime_Linea(Fila, Fila, "G", "L", 10, "Left", "Left", False, "", "", "Lectura")
        '                Imprime_Plani.BordesI(4, 1, Fila, Fila, "G", "L")

        '                'If TxtCantBlancosFoliar.Text = "" Then TxtCantBlancosFoliar.Text = 0

        '                If Fila_Ele("ELE_PROCESO") <> "SubAnalisis" And Fila_Ele("ELE_CODIGO") <> "%Piedra" And Fila_Ele("ELE_CODIGO") <> "Dap_terron" And Fila_Ele("ELE_CODIGO") <> "ArenaF" And Fila_Ele("ELE_CODIGO") <> "ArenaG" Then
        '                    If TxtCantBlancosFoliar.Text <> 0 Then
        '                        For XCant = 1 To BlancoText
        '                            Fila = Fila + 1
        '                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Blanco " & XCant)
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                            Priori = Priori + 1
        '                            Call Graba_Planilla_Plani("Blanco" & XCant, IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
        '                        Next
        '                    End If

        '                    If BlancoText > 1 Then
        '                        Fila = Fila + 1
        '                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "BLPromedio")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                        Priori = Priori + 1
        '                        Call Graba_Planilla_Plani("PromBlanco" & XCant, IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
        '                    End If

        '                    For Each Fila_Es In Cjto_Tablas1.Tables(Tabla_Estandar).Rows
        '                        Fila = Fila + 1
        '                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Es("OTC_NLAB") & "S1"))
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                        Priori = Priori + 1
        '                        Call Graba_Planilla_Plani((Fila_Es("OTC_NLAB") & "S1"), IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
        '                    Next

        '                    For Each Fila_Te In Cjto_Tablas1.Tables(Tabla_Testigos).Rows
        '                        Fila = Fila + 1
        '                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Te("OTC_NLAB") & "T1"))
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                        Priori = Priori + 1
        '                        Call Graba_Planilla_Plani(CStr(Fila_Te("OTC_NLAB") & "T1"), IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
        '                    Next

        '                End If

        '                Fila_Seleccion = Cjto_Tablas1.Tables("PLANTI_ELELAB").Select("", "")
        '                For Each Fila_Plan In Fila_Seleccion
        '                    If Fila_Plan("ELE_CODIGO") = Fila_Ele("ELE_CODIGO") And Fila_Plan("TMU_CODIGO") = Fila_Ele("TMU_CODIGO") Then
        '                        If Lab_Aux <> 1 And Fila_Plan("OT_NLAB") <> Lab_Aux Then Fila = Fila + 1
        '                        Fila = Fila + 1
        '                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & Fila_Plan("OT_NLAB"))
        '                        Imprime_Plani.BordesI(4, 2, Fila, Fila, "A", "F")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                        Priori = Priori + 1
        '                        LetraSpectro = ""
        '                        If Fila_Ele("ELE_CAL_FORMULA") = "EAA" Then
        '                            If InStr(Fila_Ele("ELE_CODIGO"), "_tot") > 0 Then LetraSpectro = "M"
        '                            If InStr(Fila_Ele("ELE_CODIGO"), "_sol") > 0 Then LetraSpectro = "H"
        '                            If InStr(Fila_Ele("ELE_CODIGO"), "CIC_cmol") > 0 Then LetraSpectro = "C"
        '                            If Fila_Ele("ELE_CODIGO") = "K_sol" Then LetraSpectro = "L"
        '                            If Fila_Ele("ELE_CODIGO") = "Al_ext" Then LetraSpectro = "E"
        '                        End If
        '                        Call Graba_Planilla_Plani(Fila_Plan("OT_NLAB") & LetraSpectro, IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
        '                        Call Graba_NLabPlanificado(Consulta_Orden, Fila_Plan("OT_NLAB"), MM)
        '                        Lab_Aux = Fila_Plan("OT_NLAB") + 1
        '                    End If
        '                Next

        '                '***********************************************************************
        '                ' GRABA DUPLICADOS DESDE GRILLA PLANIFICACION EN TABLA DUPLICA_RESULTADO
        '                '***********************************************************************

        '                Fila_Seleccion = Cjto_Tablas1.Tables("PLANTI_ELELAB").Select("", "")

        '                For Each Fila_Te In Cjto_Tablas1.Tables(Tabla_Duplicados).Rows
        '                    For Each Fila_Plan In Fila_Seleccion
        '                        If Fila_Plan("ELE_CODIGO") = Fila_Ele("ELE_CODIGO") And Fila_Te("OTC_NLAB") = Fila_Plan("OT_NLAB") Then
        '                            Call Graba_Planificacion_Tabla_Duplicados(CStr(Fila_Te("OTC_NLAB")), Fila_Ele("ELE_CODIGO"), Fila_Ele("ANA_CODIGO"), MM)
        '                        End If
        '                    Next
        '                Next

        '                '******************************************
        '                ' DUPLICADOS DESDE TABLA DUPLICA_RESULTADOS
        '                '******************************************
        '                With SP
        '                    .Inicializar()
        '                    .AgregarParametro("@CodEle", Fila_Ele("ELE_CODIGO"), SqlDbType.NVarChar)
        '                    ds = .EjecutarQuery("usp_SelectPlanificacionDuplicadosRevision")
        '                End With

        '                For Each Fila_Te In ds.Tables(0).Rows
        '                    If Fila_Te("NUMERO_DIGITACION") <> 0 Then
        '                        Fila = Fila + 1
        '                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Te("OT_NLAB")) & "D" & Fila_Te("NUMERO_DIGITACION"))
        '                        Imprime_Plani.BordesI(4, 2, Fila, Fila, "A", "F")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                        Priori = Priori + 1
        '                        Call Graba_Planilla_Plani(CStr(Fila_Te("OT_NLAB")) & "D" & Fila_Te("NUMERO_DIGITACION"), IntNLab, Fila_Ele("ELE_CODIGO"), Priori, MM)
        '                        StrElementos = StrElementos & "-" & Fila_Ele("ELE_CODIGO")
        '                    End If
        '                Next
        '                StrElementos = StrElementos & "-" & Fila_Ele("ELE_CODIGO")
        'SaltoxAutogenerado:
        '            Next

        '            '***************************************************************
        '            'SECCION PARA DUPLICADOS QUE NO ESTEN DENTRO DE LA PLANIFICACION
        '            '***************************************************************
        '            With SP
        '                .Inicializar()
        '                ds = .EjecutarQuery("usp_SelectPlanificacionTodosDuxA")
        '            End With

        '            For Each Fila_TodosDuxA In ds.Tables(0).Rows
        '                Priori = 0
        '                If InStr(StrElementos, "-" & Fila_TodosDuxA("ELE_CODIGO")) = 0 Then
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 1 Then MuestraPlani = "Foliar" : BlancoText = TxtCantBlancosFoliar.Text : Tabla_Testigos = "TESTIGO_PLANIFOLIAR" : Tabla_Estandar = "ESTANDAR_PLANIFOLIAR"
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 2 Then MuestraPlani = "Otros Tejidos" : BlancoText = TxtCantBlancosTejidos.Text : Tabla_Testigos = "TESTIGO_PLANITEJIDOS" : Tabla_Estandar = "ESTANDAR_PLANITEJIDOS"
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 3 Then MuestraPlani = "Agua" : BlancoText = TxtCantBlancosAgua.Text : Tabla_Testigos = "TESTIGO_PLANIAGUA" : Tabla_Estandar = "ESTANDAR_PLANIAGUA"
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 4 Then MuestraPlani = "Suelo" : BlancoText = TxtCantBlancosSuelo.Text : Tabla_Testigos = "TESTIGO_PLANISUELO" : Tabla_Estandar = "ESTANDAR_PLANISUELO"
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 5 Then MuestraPlani = "Fertilizante Quimico" : BlancoText = TxtCantBlancosFertQui.Text : Tabla_Testigos = "TESTIGO_PLANIFERTQUI" : Tabla_Estandar = "ESTANDAR_PLANIFERTQUI"
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 6 Then MuestraPlani = "Fertilizante Organico" : BlancoText = TxtCantBlancosFertOrg.Text : Tabla_Testigos = "TESTIGO_PLANIFERTORG" : Tabla_Estandar = "ESTANDAR_PLANIFERTORG"
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 7 Then MuestraPlani = "Otros Análisis" : BlancoText = TxtCantBlancosOtrosAnalisis.Text : Tabla_Testigos = "TESTIGO_PLANIOTROSANALISIS" : Tabla_Estandar = "ESTANDAR_PLANIOTROSANALISIS"
        '                    If Mid(Fila_TodosDuxA("ANA_CODIGO"), 1, 1) = 8 Then MuestraPlani = "Ventas" : BlancoText = TxtCantBlancosVentas.Text : Tabla_Testigos = "TESTIGO_PLANIVENTAS" : Tabla_Estandar = "ESTANDAR_PLANIVENTAS"
        '                    If EleTemp = "" Or EleTemp <> Fila_TodosDuxA("ELE_CODIGO") Then
        '                        Imprime_Plani.Crea_Hoja_Excel(Fila_TodosDuxA("ELE_CODIGO"), 1, 18, MM)
        '                        Imprime_Plani.SinCurva(Fila_TodosDuxA("ELE_CODIGO"), MuestraPlani)
        '                        Imprime_Plani.DatosI(MyDate, "Elemento", IntNLab)
        '                        Priori = 0
        '                        Fila = 11
        '                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Nº Lab")
        '                        Imprime_Plani.BordesI(4, 1, Fila, Fila, "A", "F")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                        If TxtCantBlancosFoliar.Text <> 0 Then
        '                            For XCant = 1 To BlancoText
        '                                Fila = Fila + 1
        '                                Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "Blanco " & XCant)
        '                                Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                                Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                                Priori = Priori + 1
        '                                Call Graba_Planilla_Plani("Blanco" & XCant, IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
        '                            Next
        '                        End If

        '                        If BlancoText > 1 Then
        '                            Fila = Fila + 1
        '                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "BLPromedio")
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                            Priori = Priori + 1
        '                            Call Graba_Planilla_Plani("PromBlanco" & XCant, IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
        '                        End If

        '                        For Each Fila_Es In Cjto_Tablas1.Tables(Tabla_Estandar).Rows
        '                            Fila = Fila + 1
        '                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Es("OTC_NLAB") & "S1"))
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                            Priori = Priori + 1
        '                            Call Graba_Planilla_Plani((Fila_Es("OTC_NLAB") & "S1"), IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
        '                        Next

        '                        For Each Fila_Te In Cjto_Tablas1.Tables(Tabla_Testigos).Rows
        '                            Fila = Fila + 1
        '                            Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_Te("OTC_NLAB") & "T1"))
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "A", "F")
        '                            Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                            Priori = Priori + 1

        '                            Call Graba_Planilla_Plani(CStr(Fila_Te("OTC_NLAB") & "T1"), IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
        '                        Next
        '                    End If
        '                    If Fila_TodosDuxA("NUMERO_DIGITACION") <> 0 Then
        '                        Fila = Fila + 1
        '                        Imprime_Plani.Imprime_Linea(Fila, Fila, "A", "F", 10, "Left", "Left", False, "", "", "'" & CStr(Fila_TodosDuxA("OT_NLAB")) & "D" & Fila_TodosDuxA("NUMERO_DIGITACION"))
        '                        Imprime_Plani.BordesI(4, 2, Fila, Fila, "A", "F")
        '                        Imprime_Plani.BordesI(3, 2, Fila, Fila, "G", "L")
        '                        Priori = Priori + 1
        '                        Call Graba_Planilla_Plani(CStr(Fila_TodosDuxA("OT_NLAB")) & "D" & Fila_TodosDuxA("NUMERO_DIGITACION"), IntNLab, Fila_TodosDuxA("ELE_CODIGO"), Priori, MM)
        '                    End If
        '                    EleTemp = Fila_TodosDuxA("ELE_CODIGO")
        '                End If
        '            Next

        '            'frmEspere.Close()
        '            Imprime_Plani.Cierra_Excel(Destino)
        '            Imprime_Plani.Mata_Proceso()
        '            'Me.Close()

        '        Catch ex As Exception
        '            MsgBox("error, contactese con el administrador, error en proc : btnImprimirPlan_Click, " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        '        End Try
    End Sub

    Private Sub GrabaPlanillaPlani(ByVal NlabD As String, ByVal nlabDesde As Integer, ByVal codEle As String, ByVal Priori As Integer, ByVal tmu As String)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim MyDate As Date
        Dim retorna As Integer = 0
        MyDate = Today
        Try
            With SP
                '.Inicializar()
                '.AgregarParametro("@TMuestra", tmu, SqlDbType.Int)
                '.AgregarParametro("@CodEle", codEle, SqlDbType.NVarChar)
                '.AgregarParametro("@NLabDesde", nlabDesde, SqlDbType.NVarChar)
                '.AgregarParametro("@FechaPlani", MyDate, SqlDbType.DateTime)
                '.AgregarParametro("@NLab", NlabD, SqlDbType.NVarChar)
                '.AgregarParametro("@Prioridad", Priori, SqlDbType.Int)
                'retorna = .EjecutarEscalar("usp_UpdatePlanificacionPlanillaPlani")
            End With
        Catch ex As Exception
            MsgBox("Error en consulta")
        End Try
    End Sub

    Private Sub GenerarPDF()
        Try

            Dim Documento As New Document(PageSize.A4.Rotate, 30, 30, 30, 30) 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo
            Dim imagendemo As iTextSharp.text.Image 'Declaracion de una imagen
            Dim tablaTitulo As New PdfPTable(12) 'declara la tabla con 12 columnas
            Dim tablaSubTitulo As New PdfPTable(6)
            Dim MyDate As Date, sAño, sMes, sRutaDest, sRutaDestino, destino, fuente As String
            Try

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

                sAño = Year(Today)
                sRutaDestino = "F:\Archivos LabSys\Planificacion\Planificacion " & sAño


                If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
                    MkDir(sRutaDestino)
                End If
                sRutaDest = sRutaDestino & "\" & sMes
                If Dir(sRutaDest, FileAttribute.Directory) = "" Then
                    MkDir(sRutaDest)
                End If


            Catch ex As Exception
                MsgBox("Error al crear el directorio, error: " & ex.Message.ToString, MsgBoxStyle.Information)
            End Try

            Dim NombreArchivo As String = sRutaDest.ToString & "\" & Date.Today.Day & Date.Today.Month & Date.Today.Year & "" & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & " Planificacion Diaria.pdf"
            Dim cd As New CapaDato
            Dim r, i, j, s, a, b, c, d, e, f As Integer
            Dim acumula As String
            Dim dsNlab, dsElemento, dsSTitulo, dsEleCom As New DataSet
            Dim writer As PdfWriter
            Try
                writer = pdf.PdfWriter.GetInstance(Documento, New FileStream(NombreArchivo, FileMode.Create)) 'Crea el archivo "DEMO.PDF
            Catch ex As Exception
                MsgBox("Error al crear el pdf, error: " & ex.Message.ToString, MsgBoxStyle.Information)
            End Try

            Documento.Open() 'Abre documento para su escritura
            parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
            parrafo.Font = FontFactory.GetFont("Arial", 10, ALIGN_CENTER) 'Asigan fuente
            parrafo.Add("Listado de Planificación Diaria") 'Texto que se insertara
            Documento.Add(parrafo) 'Agrega el parrafo al documento
            parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente


            parrafo.Alignment = Element.ALIGN_RIGHT
            parrafo.Font = FontFactory.GetFont("Arial", 10, ALIGN_CENTER) 'Asigan fuente
            parrafo.Add("" & Date.Now.Today.ToString) 'Texto que se insertara
            Documento.Add(parrafo) 'Agrega el parrafo al documento
            parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

            Try
                imagendemo = iTextSharp.text.Image.GetInstance("LogoAgro.jpg") 'Dirreccion a la imagen que se hace referencia
                imagendemo.SetAbsolutePosition(6, 550) 'Posicion en el eje cartesiano
                imagendemo.ScaleAbsoluteWidth(80) 'Ancho de la imagen
                imagendemo.ScaleAbsoluteHeight(40) 'Altura de la imagen
                Documento.Add(imagendemo) ' Agrega la imagen al documento
            Catch ex As Exception
                MsgBox("Error alcargar imagen, error: " & ex.Message.ToString, MsgBoxStyle.Information)
            End Try

            Dim widths(11) As Single
            widths(0) = 21
            widths(1) = 20
            widths(2) = 20
            widths(3) = 65
            widths(4) = 35
            widths(5) = 17
            widths(6) = 36
            widths(7) = 36
            widths(8) = 36
            widths(9) = 36
            widths(10) = 23
            widths(11) = 254

            Documento.Add(New Paragraph(" ")) 'Salto de linea

            tablaTitulo.SetWidthPercentage(widths, PageSize.A4) 'Ajusta el tamaño de cada columna
            tablaTitulo.AddCell(New Paragraph("N° OT", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("F.Ing", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("F.Des", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Productor", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Localidad", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Cant", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Foliar", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Agua", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Suelo", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Otros", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Código", FontFactory.GetFont("Arial", 8)))
            tablaTitulo.AddCell(New Paragraph("Descripción", FontFactory.GetFont("Arial", 8)))
            Documento.Add(tablaTitulo) ' Agrega la tabla al documento

            Dim widthsSub(5) As Single
            widthsSub(0) = 178
            widthsSub(1) = 36
            widthsSub(2) = 36
            widthsSub(3) = 36
            widthsSub(4) = 36
            widthsSub(5) = 277

            tablaSubTitulo.SetWidthPercentage(widthsSub, PageSize.A4) 'Ajusta el tamaño de cada columna
            tablaSubTitulo.AddCell(New Paragraph("", FontFactory.GetFont("Arial", 6)))
            tablaSubTitulo.AddCell(New Paragraph("Desde-Hasta", FontFactory.GetFont("Arial", 6)))
            tablaSubTitulo.AddCell(New Paragraph("Desde-Hasta", FontFactory.GetFont("Arial", 6)))
            tablaSubTitulo.AddCell(New Paragraph("Desde-Hasta", FontFactory.GetFont("Arial", 6)))
            tablaSubTitulo.AddCell(New Paragraph("Desde-Hasta", FontFactory.GetFont("Arial", 6)))
            tablaSubTitulo.AddCell(New Paragraph("", FontFactory.GetFont("Arial", 6)))
            Documento.Add(tablaSubTitulo) ' Agrega la tabla al documento


            If Me.chFoliar.Checked = True Then
                tmuAnalisis = 1000
            ElseIf Me.chFertQui.Checked = True Then
                tmuAnalisis = 5000
            ElseIf Me.chFertOrg.Checked = True Then
                tmuAnalisis = 6000
            ElseIf Me.chTejidos.Checked = True Then
                tmuAnalisis = 2000
            ElseIf Me.chSuelo.Checked = True Then
                tmuAnalisis = 4000
            Else
                MsgBox("Debe seleccionar un tipo de analisis.", MsgBoxStyle.Information)
                Documento.Close()
                Exit Sub
            End If

            r = Me.dgPlanNlab.Rows.Count - 1
            i = 0
            While i < r

                cd.Inicializar()
                cd.AgregarParametro("@desde", CInt(Me.dgPlanNlab.Rows.Item(i).Cells.Item(0).Value), SqlDbType.Int)
                cd.AgregarParametro("@hasta", CInt(Me.dgPlanNlab.Rows.Item(i).Cells.Item(1).Value), SqlDbType.Int)
                cd.AgregarParametro("@tmu", tmuAnalisis, SqlDbType.Int)
                dsNlab = cd.EjecutarQuery("ls_DatosOTconNlabPLani")

                Dim widthsOT(11) As Single
                widthsOT(0) = 21
                widthsOT(1) = 20
                widthsOT(2) = 20
                widthsOT(3) = 65
                widthsOT(4) = 35
                widthsOT(5) = 17
                widthsOT(6) = 36
                widthsOT(7) = 36
                widthsOT(8) = 36
                widthsOT(9) = 36
                widthsOT(10) = 23
                widthsOT(11) = 254
                s = dsNlab.Tables(0).Rows.Count
                j = 0
                While j < s
                    With dsNlab.Tables(0).Rows
                        Dim tablaOT As New PdfPTable(12)


                        tablaOT.SetWidthPercentage(widthsOT, PageSize.A4) 'Ajusta el tamaño de cada columna
                        tablaOT.AddCell(New Paragraph(.Item(j).Item(0).ToString, FontFactory.GetFont("Arial", 8)))
                        tablaOT.AddCell(New Paragraph(.Item(j).Item(1).ToString, FontFactory.GetFont("Arial", 8)))
                        tablaOT.AddCell(New Paragraph(.Item(j).Item(2).ToString, FontFactory.GetFont("Arial", 8)))
                        tablaOT.AddCell(New Paragraph(.Item(j).Item(3).ToString, FontFactory.GetFont("Arial", 8)))
                        tablaOT.AddCell(New Paragraph(.Item(j).Item(4).ToString, FontFactory.GetFont("Arial", 8)))
                        tablaOT.AddCell(New Paragraph(.Item(j).Item(5).ToString, FontFactory.GetFont("Arial", 8)))
                        If .Item(j).Item(8).ToString = 1000 Then
                            tablaOT.AddCell(New Paragraph(.Item(j).Item(6).ToString & "-" & Mid(CStr(.Item(j).Item(7).ToString), (Len(CStr(.Item(j).Item(7).ToString)) - 2)), FontFactory.GetFont("Arial", 8)))
                            c = c + CInt(.Item(j).Item(5).ToString)
                        Else
                            tablaOT.AddCell(New Paragraph("", FontFactory.GetFont("Arial", 8)))
                        End If
                        If .Item(j).Item(8).ToString = 3000 Then
                            tablaOT.AddCell(New Paragraph(.Item(j).Item(6).ToString & "-" & Mid(CStr(.Item(j).Item(7).ToString), (Len(CStr(.Item(j).Item(7).ToString)) - 2)), FontFactory.GetFont("Arial", 8)))
                            d = d + CInt(.Item(j).Item(5).ToString)
                        Else
                            tablaOT.AddCell(New Paragraph("", FontFactory.GetFont("Arial", 8)))
                        End If
                        If .Item(j).Item(8).ToString = 4000 Then
                            tablaOT.AddCell(New Paragraph(.Item(j).Item(6).ToString & "-" & Mid(CStr(.Item(j).Item(7).ToString), (Len(CStr(.Item(j).Item(7).ToString)) - 2)), FontFactory.GetFont("Arial", 8)))
                            e = e + CInt(.Item(j).Item(5).ToString)
                        Else
                            tablaOT.AddCell(New Paragraph("", FontFactory.GetFont("Arial", 8)))
                        End If
                        If .Item(j).Item(8).ToString <> 4000 And .Item(j).Item(8).ToString <> 3000 And .Item(j).Item(8).ToString <> 1000 Then
                            tablaOT.AddCell(New Paragraph(.Item(j).Item(6).ToString & "-" & Mid(CStr(.Item(j).Item(7).ToString), (Len(CStr(.Item(j).Item(7).ToString)) - 2)), FontFactory.GetFont("Arial", 8)))
                            f = f + CInt(.Item(j).Item(5).ToString)
                        Else
                            tablaOT.AddCell(New Paragraph("", FontFactory.GetFont("Arial", 8)))
                        End If
                        tablaOT.AddCell(New Paragraph(.Item(j).Item(9).ToString, FontFactory.GetFont("Arial", 8)))

                        Try

                            cd.Inicializar()
                            cd.AgregarParametro("@NumOt", CInt(.Item(j).Item(0).ToString), SqlDbType.Int)
                            cd.AgregarParametro("@NLab", CInt(.Item(j).Item(6).ToString), SqlDbType.Int)
                            cd.AgregarParametro("@CodAna", CInt(.Item(j).Item(9).ToString), SqlDbType.Float)
                            cd.AgregarParametro("@Tipo_Analisis", .Item(j).Item(11).ToString, SqlDbType.NVarChar)
                            cd.AgregarParametro("@TMuestra", CInt(.Item(j).Item(8).ToString), SqlDbType.Int)
                            dsElemento = cd.EjecutarQuery("usp_SelectPlanificacion")

                        Catch ex As Exception
                            MsgBox("Inconsistencia de datos , llame al Dep. Informatica")
                        End Try

                        Try

                            cd.Inicializar()
                            cd.AgregarParametro("@NumOt", CInt(.Item(j).Item(0).ToString), SqlDbType.Int)
                            cd.AgregarParametro("@TMuestra", CInt(.Item(j).Item(8).ToString), SqlDbType.Int)
                            dsEleCom = cd.EjecutarQuery("[usp_SelectPlanificacionElemento]")

                            cd.Inicializar()
                            cd.AgregarParametro("@TMuestra", CInt(.Item(j).Item(8).ToString), SqlDbType.Int)
                            cd.AgregarParametro("@NLabDesde", CInt(.Item(j).Item(6).ToString), SqlDbType.Int)
                            cd.AgregarParametro("@NLabHasta", CInt(.Item(j).Item(6).ToString), SqlDbType.Int)
                            dsSTitulo = cd.EjecutarQuery("usp_SelectPlanificacionSubTitulo")


                        Catch ex As Exception
                            MsgBox("Inconsistencia de datos , llame al Dep. Informatica")
                        End Try

                        If dsElemento.Tables(0).Rows.Count <> 0 Then

                            Try
                                If IsDBNull(dsElemento.Tables(0).Rows(0).Item("TITULO_FILA")) = False Then
                                    acumula = dsElemento.Tables(0).Rows(0).Item("TITULO_FILA").ToString & " "
                                Else
                                    acumula = ""

                                End If


                            Catch ex As Exception
                                '   MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
                            End Try

                            If dsSTitulo.Tables(0).Rows.Count <> 0 Then

                                Try

                                    If IsDBNull(dsSTitulo.Tables(0).Rows.Item(0).Item("TITULO")) = False And IsDBNull(dsSTitulo.Tables(0).Rows.Item(0).Item("OTRO_TITULO")) = False Then
                                        acumula = acumula & "  " & dsSTitulo.Tables(0).Rows.Item(0).Item("TITULO").ToString & " " & dsSTitulo.Tables(0).Rows.Item(0).Item("OTRO_TITULO").ToString & " : "
                                    ElseIf IsDBNull(dsSTitulo.Tables(0).Rows.Item(0).Item("TITULO")) = False Then
                                        acumula = acumula & " " & dsSTitulo.Tables(0).Rows.Item(0).Item("TITULO").ToString & " : "
                                    ElseIf IsDBNull(dsSTitulo.Tables(0).Rows.Item(0).Item("OTRO_TITULO")) = False Then
                                        acumula = acumula & " " & dsSTitulo.Tables(0).Rows.Item(0).Item("OTRO_TITULO").ToString & " : "
                                    Else
                                        acumula = acumula & " : "
                                    End If

                                Catch ex As Exception
                                    ' MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
                                End Try
                            End If
                        End If

                        If dsElemento.Tables(0).Rows.Count <> 0 Then

                            a = dsElemento.Tables(0).Rows.Count
                            b = 0
                            While b < a
                                With dsElemento.Tables(0).Rows
                                    If b + 1 = a Then
                                        acumula = acumula & .Item(b).Item("ELE_COD_DES").ToString
                                    ElseIf b <> a Then
                                        acumula = acumula & .Item(b).Item("ELE_COD_DES").ToString & "-"
                                    End If

                                End With
                                b = b + 1
                            End While
                        End If

                        tablaOT.AddCell(New Paragraph(acumula, FontFactory.GetFont("Arial", 8)))
                        Documento.Add(tablaOT) ' Agrega la tabla al documento


                    End With
                    j = j + 1
                End While
                i = i + 1
            End While

            Call imprimeEstadistica(Documento, c, d, e, f)

            Call imprimePlanillaDigitacion(Documento, writer)

            Documento.Close() 'Cierra el documento
            System.Diagnostics.Process.Start(NombreArchivo) 'Abre el archivo DEMO.PDF

        Catch ex As Exception
            MsgBox("Se ha roducido un error, contatese con su administrador. " & ex.Message.ToString, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub imprimeEstadistica(ByVal documento As Document, ByVal foliar As Integer, ByVal agua As Integer, ByVal suelo As Integer, ByVal otros As Integer)
        Dim tablaEstF As New PdfPTable(2)
        Dim tablaEstA As New PdfPTable(2)
        Dim tablaEstS As New PdfPTable(2)
        Dim tablaEstO As New PdfPTable(2)

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim widthsEst(1) As Single
        widthsEst(0) = 40
        widthsEst(1) = 40

        tablaEstF.HorizontalAlignment = ALIGN_LEFT

        tablaEstF.SetWidthPercentage(widthsEst, PageSize.A4) 'Ajusta el tamaño de cada columna
        tablaEstF.AddCell(New Paragraph("Total Foliar :", FontFactory.GetFont("Arial", 8)))
        tablaEstF.AddCell(New Paragraph(foliar.ToString, FontFactory.GetFont("Arial", 8)))
        documento.Add(tablaEstF) ' Agrega la tabla al documento

        tablaEstA.HorizontalAlignment = ALIGN_LEFT
        tablaEstA.SetWidthPercentage(widthsEst, PageSize.A4) 'Ajusta el tamaño de cada columna
        tablaEstA.AddCell(New Paragraph("Total Agua :", FontFactory.GetFont("Arial", 8)))
        tablaEstA.AddCell(New Paragraph(agua.ToString, FontFactory.GetFont("Arial", 8)))
        documento.Add(tablaEstA) ' Agrega la tabla al documento

        tablaEstS.HorizontalAlignment = ALIGN_LEFT
        tablaEstS.SetWidthPercentage(widthsEst, PageSize.A4) 'Ajusta el tamaño de cada columna
        tablaEstS.AddCell(New Paragraph("Total Suelo : ", FontFactory.GetFont("Arial", 8)))
        tablaEstS.AddCell(New Paragraph(suelo.ToString, FontFactory.GetFont("Arial", 8)))
        documento.Add(tablaEstS) ' Agrega la tabla al documento

        tablaEstO.HorizontalAlignment = ALIGN_LEFT
        tablaEstO.SetWidthPercentage(widthsEst, PageSize.A4) 'Ajusta el tamaño de cada columna
        tablaEstO.AddCell(New Paragraph("Total Otros :", FontFactory.GetFont("Arial", 8)))
        tablaEstO.AddCell(New Paragraph(otros.ToString, FontFactory.GetFont("Arial", 8)))
        documento.Add(tablaEstO) ' Agrega la tabla al documento

    End Sub

    Private Sub imprimePlanillaDigitacion(ByVal Documento As Document, ByVal writer As PdfWriter)

        Try

            Dim cd As New CapaDato
            Dim dsNlab As New DataSet
            Dim titulo As String
            Dim fila As DataRow
            Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
            Dim x, y, z, a, b, c As Integer
            Dim tablaDesc As New PdfPTable(7)
            Dim tablaEle As New PdfPTable(2)

            Cjto_Tablas1.Tables("PLANTI_ELELAB").Clear()
            Cjto_Tablas1.Tables("PLANTI_CODIGO").Clear()

            Try
                With cd
                    ' .Inicializar()
                    ' .AgregarParametro("@FechaPlani", Today, SqlDbType.DateTime)
                    ' .AgregarParametro("@NLabDesde", Me.dgPlanNlab.Rows.Item(y).Cells.Item(0).Value.ToString, SqlDbType.NVarChar)
                    '.EjecutarQuery("usp_DeletePlanificacionPlani")
                End With
            Catch ex As Exception
                MsgBox("Error en consulta borrar planificacion")
            End Try

            y = 0
            x = Me.dgPlanNlab.Rows.Count - 1

            While y < x

                Try
                    With cd
                        .Inicializar()
                        .AgregarParametro("@desde", CInt(Me.dgPlanNlab.Rows.Item(y).Cells.Item(0).Value), SqlDbType.Int)
                        .AgregarParametro("@hasta", CInt(Me.dgPlanNlab.Rows.Item(y).Cells.Item(1).Value), SqlDbType.Int)
                        .AgregarParametro("@tmu", CInt(tmuAnalisis), SqlDbType.Int)
                        dsNlab = .EjecutarQuery("ls_DatosOTconNlabPLani")

                    End With
                Catch ex As Exception
                    MsgBox("Error en consulta borrar planificacion")
                End Try
                b = 0
                c = 0
                b = dsNlab.Tables(0).Rows.Count
                While c < b

                    Try

                        With cd
                            .Inicializar()
                            .AgregarParametro("@NumOt", CInt(dsNlab.Tables(0).Rows.Item(c).Item(0)), SqlDbType.Int)
                            .AgregarParametro("@CodAna", CInt(dsNlab.Tables(0).Rows.Item(c).Item(9)), SqlDbType.Float)
                            .EjecutarQueryDt("usp_SelectPlanificacionCodEle", Cjto_Tablas1, "PLANTI_CODIGO")
                        End With


                    Catch ex As Exception
                        MsgBox("Error en consulta")
                    End Try
                    Try
                        With cd
                            .Inicializar()
                            .AgregarParametro("@CodAna", CInt(dsNlab.Tables(0).Rows.Item(c).Item(9)), SqlDbType.Float)
                            .AgregarParametro("@NlabD", CInt(Me.dgPlanNlab.Rows.Item(y).Cells.Item(0).Value), SqlDbType.Int)
                            .AgregarParametro("@NlabH", CInt(Me.dgPlanNlab.Rows.Item(y).Cells.Item(1).Value), SqlDbType.Int)
                            .EjecutarQueryDt("ls_SelectPlanificacionCodEleNLab", Cjto_Tablas1, "PLANTI_ELELAB")
                        End With
                    Catch ex As Exception
                        MsgBox("Error en consulta")
                    End Try
                    c = c + 1

                End While
                y = y + 1
            End While

            If tmuAnalisis = 1000 Then
                titulo = "Foliar"
            ElseIf tmuAnalisis = 2000 Then
                titulo = "Otros Tejidos"
            ElseIf tmuAnalisis = 4000 Then
                titulo = "Suelo"
            ElseIf tmuAnalisis = 5000 Then
                titulo = "Fertilizante Químico"
            ElseIf tmuAnalisis = 6000 Then
                titulo = "Fertilizante Orgánico"
            ElseIf tmuAnalisis = 7000 Then
                titulo = "Otros Análisis"
            ElseIf tmuAnalisis = 8000 Then
                titulo = "Ventas"
            End If


            Dim widthsDesc(6) As Single
            widthsDesc(0) = 80
            widthsDesc(1) = 80
            widthsDesc(2) = 80
            widthsDesc(3) = 80
            widthsDesc(4) = 80
            widthsDesc(5) = 80
            widthsDesc(6) = 80

            Dim widthsELE(3) As Single
            widthsELE(0) = 40
            widthsELE(1) = 40

            For Each fila In Cjto_Tablas1.Tables("PLANTI_CODIGO").Rows
                tablaDesc.Rows.Clear()
                tablaEle.Rows.Clear()

                If (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "B") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "P") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "B") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "B_sol") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "B_tot") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "MOrg") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "MOrg_Maff") Then
                    generaBFoliar(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "P_sol") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "P_tot") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "P") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "P_ByK1") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "P_ByK2") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "P_CaCl2") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "P_CNorte") Then
                    generaPSuelo(Documento, writer, fila, titulo)
                ElseIf ((tmuAnalisis = 6000 Or tmuAnalisis = 5000) And fila("ELE_CODIGO") = "P_sol") Or ((tmuAnalisis = 6000 Or tmuAnalisis = 5000) And fila("ELE_CODIGO") = "P_tot") Or ((tmuAnalisis = 6000 Or tmuAnalisis = 5000) And fila("ELE_CODIGO") = "P_dis") Then
                    generaBFoliar(Documento, writer, fila, titulo)
                ElseIf ((tmuAnalisis = 6000 Or tmuAnalisis = 5000) And fila("ELE_CODIGO") = "B_sol") Or ((tmuAnalisis = 6000 Or tmuAnalisis = 5000) And fila("ELE_CODIGO") = "B_tot") Or ((tmuAnalisis = 6000 Or tmuAnalisis = 5000) And fila("ELE_CODIGO") = "B_dis") Then
                    generaBFoliar(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "NNH4") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NNH4") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "N_tot") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Nt") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "Nt") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NH4_dis") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NO3_dis") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NH4_sol_meq") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NH4_sol_mg") Then
                    generaNNH4Foliar(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "NNO3") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "N") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NO3 sol_mg") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NO3_sol_meq") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "N_sol") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "NNO3") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "N_sol") Then
                    generaNNO3Foliar(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Cl") Then
                    generaCl(Documento, writer, fila, titulo)
                    'ElseIf (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "Cl_sol_meq") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "Cl_sol_mg") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "HCO3_sol_meq") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "HCO3_sol_mg") Then
                    '    generaClHC(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "S") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "SO4_sol_meq") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "S_ext") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "S_sol") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "S_tot") Then
                    generaS(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Arginina_TejSeco") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Arginina_TejHumedo") Then
                    generaArg(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "pH_CaCl2") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "pH_KCl") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "pH_fer") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "pHe_sal") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "pH_Maff") Then
                    generapH(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "CE_Maff") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "CE_sus") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "CEe_fer") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "CEe_sal") Then
                    generapH(Documento, writer, fila, titulo)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Ca") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Cu") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Fe") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "K") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Mg") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Mn") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Nmet") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Zn") Then
                    guardaNlabNoPlanificados(fila)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Al") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Almidon_TejSeco") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "As") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "As_Res") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "As_Sol") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Cd") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Cenizas") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Clorofila_a") Then
                    guardaNlabNoPlanificados(fila)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Clorofila_b") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Co_tot") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Color") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "COrg") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Cu_Res") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Cu_Sol") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Diametro") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Fe++") Then
                    guardaNlabNoPlanificados(fila)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Fe+++") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Hg") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Humedad") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "K_Res") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Largo") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Mo") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "MSeca") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Na") Then
                    guardaNlabNoPlanificados(fila)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "NH4_potmetrico") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Ni") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "P_Res") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Pb") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "PFresco") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "PProm_TejSeco") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Proteina_TejHumedo") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Proteina_TejSeco") Then
                    guardaNlabNoPlanificados(fila)
                ElseIf (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "PSeco") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Rel_C/N") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Se") Or (tmuAnalisis = 1000 And fila("ELE_CODIGO") = "Si") Then
                    guardaNlabNoPlanificados(fila)
                ElseIf (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "Cl_sol_meq") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "Cl_sol") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "HCO3_sol_meq") Then
                    generaCloruroAlca(Documento, writer, fila, titulo)

                ElseIf (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "CaCO3") Or (tmuAnalisis = 4000 And fila("ELE_CODIGO") = "CaCO3_tot") Then
                    generaCalizaActiva(Documento, writer, fila, titulo)
                Else
                    guardaNlabNoPlanificados(fila)
                End If

            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub generaCalizaActiva(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc, tablaCurva, tablaCurva2, tablaEle As New PdfPTable(2)
        Dim cell10, cell11 As New PdfPCell

        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : Determinación de " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell0 As New PdfPCell
        cell0.AddElement(New Chunk("Peso Muestra (gr)", FontFactory.GetFont("Arial", 11)))
        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Vol. Oxalato Amonio (ml)", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("N: KMnO4", FontFactory.GetFont("Arial", 11)))


        cell10.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

        tablaCurva.AddCell(cell0)
        tablaCurva.AddCell(cell10)
        tablaCurva.AddCell(cell)
        tablaCurva.AddCell(cell10)
        tablaCurva.AddCell(cell2)  '1
        tablaCurva.AddCell(cell10)  '1



        Dim cell21 As New PdfPCell
        cell21.AddElement(New Chunk("Nombre Analista:", FontFactory.GetFont("Arial", 11)))
        Dim cell22 As New PdfPCell
        cell22.AddElement(New Chunk("Fecha", FontFactory.GetFont("Arial", 11)))
        Dim cell221 As New PdfPCell
        cell221.AddElement(New Chunk("Digitados por:", FontFactory.GetFont("Arial", 11)))
        Dim cell23 As New PdfPCell
        cell23.AddElement(New Chunk("F.Plani", FontFactory.GetFont("Arial", 11)))
        Dim cell24 As New PdfPCell
        cell24.AddElement(New Chunk("Cod. Plani", FontFactory.GetFont("Arial", 11)))
        Dim cell25 As New PdfPCell
        cell25.AddElement(New Chunk("" & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value.ToString & "", FontFactory.GetFont("Arial", 11)))
        Dim cell26 As New PdfPCell
        cell26.AddElement(New Chunk("" & Date.Now.Today.ToString, FontFactory.GetFont("Arial", 11)))

        tablaCurva2.AddCell(cell21)
        tablaCurva2.AddCell(cell10)   '
        tablaCurva2.AddCell(cell22)  '
        tablaCurva2.AddCell(cell10)  '
        tablaCurva2.AddCell(cell221)  '
        tablaCurva2.AddCell(cell10)  '
        tablaCurva2.AddCell(cell23)  '1
        tablaCurva2.AddCell(cell26)  '1
        tablaCurva2.AddCell(cell24)  '1
        tablaCurva2.AddCell(cell25)  '1



        Dim columna01 As New ColumnText(writer.DirectContent)
        columna01.AddElement(tablaCurva)

        Dim columna02 As New ColumnText(writer.DirectContent)
        columna02.AddElement(tablaCurva2)

        columna01.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 270, Documento.Top - 25)
        columna01.Go()
        columna02.SetSimpleColumn(Documento.Left + 270, Documento.Bottom, Documento.Right + 10, Documento.Top - 25)
        columna02.Go()

        agregarNlabsCalizaActiva(Documento, writer, fila)


    End Sub

    Private Sub agregarNlabsCalizaActiva(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(5)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j As Integer
        Dim nlabCount As Integer

        Dim widthsNlab(4) As Single
        widthsNlab(0) = 105
        widthsNlab(1) = 100
        widthsNlab(2) = 110
        widthsNlab(3) = 100
        widthsNlab(4) = 105

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Gasto", FontFactory.GetFont("Arial", 11)))

        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Gasto - Blanco", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("CaO %", FontFactory.GetFont("Arial", 11)))


        Dim cell31 As New PdfPCell
        If filaLab("ELE_CODIGO") = "CaCO3_tot" Then
            cell31.AddElement(New Chunk("CaCO3 total %", FontFactory.GetFont("Arial", 11)))
        Else
            cell31.AddElement(New Chunk("CaCO3 Activo %", FontFactory.GetFont("Arial", 11)))
        End If



        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))



        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))


        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)
        tablaNlab.AddCell(cell31)
        tablaNlab.AddCell(cell4) '2
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)

        j = 4
        nlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada

            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 21 Then
                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            If i < 20 Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                nlabCount = 0
                                i = i + 1
                                GoTo l

                            End If
                        End If
                    End If

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))

                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                ElseIf i >= 21 And i < 45 Then
                    If i = 21 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)
                        tablaNlab2.AddCell(cell02)
                        tablaNlab2.AddCell(cell3)
                        tablaNlab2.AddCell(cell31)


                    End If

                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            If i < 44 Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)

                                nlabCount = 0
                                i = i + 1
                                GoTo l

                            End If
                        End If
                    End If

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 21 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 45 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 135)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 135)
        columna2.Go()


        If i >= 45 Then
            generaNlabInfinitoCalizaActiva(documento, writer, filaLab, j)

        End If

    End Sub 'listo

    Private Sub generaNlabInfinitoCalizaActiva(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(5)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0
        NlabCount = 0
        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim widthsNlab(4) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130
        widthsNlab(3) = 130
        widthsNlab(4) = 130

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)


        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Gasto", FontFactory.GetFont("Arial", 11)))

        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Gasto - Blanco", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("CaO %", FontFactory.GetFont("Arial", 11)))

        Dim cell31 As New PdfPCell
        cell31.AddElement(New Chunk("CaCO3 Activo %", FontFactory.GetFont("Arial", 11)))


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)
        tablaNlab.AddCell(cell31)

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada

            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then

                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 34 Then

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                i = i + 1
                                NlabCount = 0
                                GoTo l
                            End If
                        End If

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)

                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 34 And i < 68 Then
                        If i = 34 Then
                            tablaNlab2.AddCell(cell1)  '1
                            tablaNlab2.AddCell(cell2)
                            tablaNlab2.AddCell(cell02)
                            tablaNlab2.AddCell(cell3)
                            tablaNlab2.AddCell(cell31)
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                i = i + 1
                                NlabCount = 0
                                GoTo l
                            End If
                        End If

                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 34 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 68 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top)
        columna2.Go()


        If i >= 68 Then
            generaNlabInfinitopH(documento, writer, filaLab, j)
        End If



    End Sub

    Private Sub generaCloruroAlca(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc, tablaCurva, tablaCurva2, tablaEle As New PdfPTable(2)
        Dim cell10, cell11 As New PdfPCell

        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : Determinación de " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell0 As New PdfPCell
        cell0.AddElement(New Chunk("Muestra de", FontFactory.GetFont("Arial", 11)))
        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Alicuota Cloruro", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Alicuota HCO3", FontFactory.GetFont("Arial", 11)))
     

        cell10.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

        tablaCurva.AddCell(cell0)
        tablaCurva.AddCell(cell10)
        tablaCurva.AddCell(cell)
        tablaCurva.AddCell(cell10)
        tablaCurva.AddCell(cell2)  '1
        tablaCurva.AddCell(cell10)  '1
       


        Dim cell21 As New PdfPCell
        cell21.AddElement(New Chunk("Nombre", FontFactory.GetFont("Arial", 11)))
        Dim cell22 As New PdfPCell
        cell22.AddElement(New Chunk("Fecha", FontFactory.GetFont("Arial", 11)))
        Dim cell23 As New PdfPCell
        cell23.AddElement(New Chunk("F.Plani", FontFactory.GetFont("Arial", 11)))
        Dim cell24 As New PdfPCell
        cell24.AddElement(New Chunk("Cod. Plani", FontFactory.GetFont("Arial", 11)))
        Dim cell25 As New PdfPCell
        cell25.AddElement(New Chunk("" & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value.ToString & "", FontFactory.GetFont("Arial", 11)))
        Dim cell26 As New PdfPCell
        cell26.AddElement(New Chunk("" & Date.Now.Today.ToString, FontFactory.GetFont("Arial", 11)))

        tablaCurva2.AddCell(cell21)
        tablaCurva2.AddCell(cell10)   '
        tablaCurva2.AddCell(cell22)  '
        tablaCurva2.AddCell(cell10)  '
        tablaCurva2.AddCell(cell23)  '1
        tablaCurva2.AddCell(cell26)  '1
        tablaCurva2.AddCell(cell24)  '1
        tablaCurva2.AddCell(cell25)  '1



        Dim columna01 As New ColumnText(writer.DirectContent)
        columna01.AddElement(tablaCurva)

        Dim columna02 As New ColumnText(writer.DirectContent)
        columna02.AddElement(tablaCurva2)

        columna01.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 270, Documento.Top - 25)
        columna01.Go()
        columna02.SetSimpleColumn(Documento.Left + 270, Documento.Bottom, Documento.Right + 10, Documento.Top - 25)
        columna02.Go()

        agregarNlabsCloruroAlca(Documento, writer, fila)


    End Sub

    Private Sub agregarNlabsCloruroAlca(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(7)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j As Integer
        Dim nlabCount As Integer

        Dim widthsNlab(6) As Single
        widthsNlab(0) = 97
        widthsNlab(1) = 34
        widthsNlab(2) = 95
        widthsNlab(3) = 105
        widthsNlab(4) = 34
        widthsNlab(5) = 95
        widthsNlab(6) = 105

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Ali", FontFactory.GetFont("Arial", 11)))
        cell2.VerticalAlignment = Element.ALIGN_TOP

        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Gasto Cloruro", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Resultado Cloruro meq/Lt.", FontFactory.GetFont("Arial", 11)))

        Dim cell31 As New PdfPCell
        cell31.AddElement(New Chunk("Gasto HCO3", FontFactory.GetFont("Arial", 11)))
        Dim cell32 As New PdfPCell
        cell32.AddElement(New Chunk("Resultado HCO3 meq/Lt.", FontFactory.GetFont("Arial", 11)))

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))



        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))


        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell31)
        tablaNlab.AddCell(cell32)
        tablaNlab.AddCell(cell4) '2
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)

        j = 4
        nlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada

            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 21 Then
                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            If i < 20 Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                nlabCount = 0
                                i = i + 1
                                GoTo l

                            End If
                        End If
                    End If

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))

                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                ElseIf i >= 21 And i < 45 Then
                    If i = 21 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)
                        tablaNlab2.AddCell(cell02)
                        tablaNlab2.AddCell(cell3)
                        tablaNlab2.AddCell(cell2)
                        tablaNlab2.AddCell(cell31)
                        tablaNlab2.AddCell(cell32)


                    End If

                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            If i < 44 Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                nlabCount = 0

                                i = i + 1
                                GoTo l
                            End If
                        End If
                    End If

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 21 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 45 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 135)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 135)
        columna2.Go()


        If i >= 45 Then
            generaNlabInfinitoCloruroAlc(documento, writer, filaLab, j)

        End If

    End Sub 'listo

    Private Sub generaNlabInfinitoCloruroAlc(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(7)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0
        NlabCount = 0
        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim widthsNlab(6) As Single
        widthsNlab(0) = 97
        widthsNlab(1) = 34
        widthsNlab(2) = 95
        widthsNlab(3) = 105
        widthsNlab(4) = 34
        widthsNlab(5) = 95
        widthsNlab(6) = 105

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Ali", FontFactory.GetFont("Arial", 11)))

        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Gasto Cloruro", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Resultado Cloruro meq/Lt.", FontFactory.GetFont("Arial", 11)))

        Dim cell31 As New PdfPCell
        cell31.AddElement(New Chunk("Gasto HCO3", FontFactory.GetFont("Arial", 11)))
        Dim cell32 As New PdfPCell
        cell32.AddElement(New Chunk("Resultado HCO3 meq/Lt.", FontFactory.GetFont("Arial", 11)))



        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell31)
        tablaNlab.AddCell(cell32)

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada

            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then

                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 34 Then

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                i = i + 1
                                NlabCount = 0
                                GoTo l
                            End If
                        End If

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)

                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 34 And i < 68 Then
                        If i = 34 Then
                            tablaNlab2.AddCell(cell1)  '1
                            tablaNlab2.AddCell(cell2)
                            tablaNlab2.AddCell(cell02)
                            tablaNlab2.AddCell(cell3)
                            tablaNlab2.AddCell(cell2)
                            tablaNlab2.AddCell(cell31)
                            tablaNlab2.AddCell(cell32)
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                i = i + 1
                                NlabCount = 0
                                GoTo l
                            End If
                        End If

                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 34 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 68 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top)
        columna2.Go()


        If i >= 68 Then
            generaNlabInfinitopH(documento, writer, filaLab, j)
        End If



    End Sub

    Private Sub guardaNlabNoPlanificados(ByVal filaLab As DataRow)
        Dim filaOrdenada As DataRow()
        Dim filaEle As DataRow
        Dim letra As String
        Dim j As Integer
        filaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        letra = ""
        If filaLab("ELE_CODIGO") <> "WTexBouyouco" And filaLab("ELE_CODIGO") <> "WCCyPMP" And filaLab("ELE_CODIGO") <> "ArenaGyF" Then
            GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
            GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
            GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)

        End If
        j = 4
        If tmuAnalisis = 4000 Then
            If filaLab("ELE_CODIGO") = "K_sol_meq" Or filaLab("ELE_CODIGO") = "Ca_sol_meq" Or filaLab("ELE_CODIGO") = "Mg_sol_meq" _
            Or filaLab("ELE_CODIGO") = "Na_sol_meq" Or filaLab("ELE_CODIGO") = "Mo_sol" Or filaLab("ELE_CODIGO") = "Se_sol" _
            Or filaLab("ELE_CODIGO") = "Hg_sol" Or filaLab("ELE_CODIGO") = "Zn_sol" Or filaLab("ELE_CODIGO") = "Mn_sol" _
            Or filaLab("ELE_CODIGO") = "Fe_sol" Or filaLab("ELE_CODIGO") = "Cu_sol" Or filaLab("ELE_CODIGO") = "Al_sol" _
            Or filaLab("ELE_CODIGO") = "As_sol" Or filaLab("ELE_CODIGO") = "Ni_sol" Or filaLab("ELE_CODIGO") = "Co_sol" _
            Or filaLab("ELE_CODIGO") = "Cr_sol" Or filaLab("ELE_CODIGO") = "Cd_sol" Or filaLab("ELE_CODIGO") = "Pb_sol" Then
                letra = "H"

            ElseIf filaLab("ELE_CODIGO") = "K_sol" Then
                letra = "L"

            ElseIf filaLab("ELE_CODIGO") = "Al_ext" Then
                letra = "E"

            ElseIf filaLab("ELE_CODIGO") = "CIC_cmol" Then
                letra = "C"

            ElseIf filaLab("ELE_CODIGO") = "K_tot" Or filaLab("ELE_CODIGO") = "Ca_tot" Or filaLab("ELE_CODIGO") = "Mg_tot" _
            Or filaLab("ELE_CODIGO") = "Na_tot" Or filaLab("ELE_CODIGO") = "Mo_tot" Or filaLab("ELE_CODIGO") = "Se_tot" _
            Or filaLab("ELE_CODIGO") = "Hg_tot" Or filaLab("ELE_CODIGO") = "Zn_tot" Or filaLab("ELE_CODIGO") = "Mn_tot" _
            Or filaLab("ELE_CODIGO") = "Fe_tot" Or filaLab("ELE_CODIGO") = "Cu_tot" Or filaLab("ELE_CODIGO") = "Al_tot" _
            Or filaLab("ELE_CODIGO") = "As_tot" Or filaLab("ELE_CODIGO") = "Ni_tot" Or filaLab("ELE_CODIGO") = "Co_tot" _
            Or filaLab("ELE_CODIGO") = "Cr_tot" Or filaLab("ELE_CODIGO") = "Cd_tot" Or filaLab("ELE_CODIGO") = "Pb_tot" Then
                letra = "M"

            End If
        ElseIf tmuAnalisis = 6000 Then

            If filaLab("ELE_CODIGO") = "K_tot" Or filaLab("ELE_CODIGO") = "Ca_tot" Or filaLab("ELE_CODIGO") = "Mg_tot" _
            Or filaLab("ELE_CODIGO") = "Na_tot" Or filaLab("ELE_CODIGO") = "Mo_tot" Or filaLab("ELE_CODIGO") = "Se_tot" _
            Or filaLab("ELE_CODIGO") = "Hg_tot" Or filaLab("ELE_CODIGO") = "Zn_tot" Or filaLab("ELE_CODIGO") = "Mn_tot" _
            Or filaLab("ELE_CODIGO") = "Fe_tot" Or filaLab("ELE_CODIGO") = "Cu_tot" Or filaLab("ELE_CODIGO") = "Al_tot" _
            Or filaLab("ELE_CODIGO") = "As_tot" Or filaLab("ELE_CODIGO") = "Ni_tot" Or filaLab("ELE_CODIGO") = "Co_tot" _
            Or filaLab("ELE_CODIGO") = "Cr_tot" Or filaLab("ELE_CODIGO") = "Cd_tot" Or filaLab("ELE_CODIGO") = "Pb_tot" Then
                letra = "M"
            ElseIf filaLab("ELE_CODIGO") = "CIC_meq/100g" Or filaLab("ELE_CODIGO") = "CIC_meq/100ml" Or filaLab("ELE_CODIGO") = "CIC_cmol" Then
                letra = "C"
            End If

        ElseIf tmuAnalisis = 1000 Then
            If filaLab("ELE_CODIGO") = "Co_tot" Then
                letra = "M"
            End If
        ElseIf tmuAnalisis = 2000 Then
         
        ElseIf tmuAnalisis = 5000 Then
            If filaLab("ELE_CODIGO") = "K_tot" Or filaLab("ELE_CODIGO") = "Ca_tot" Or filaLab("ELE_CODIGO") = "Mg_tot" _
          Or filaLab("ELE_CODIGO") = "Na_tot" Or filaLab("ELE_CODIGO") = "Mo_tot" Or filaLab("ELE_CODIGO") = "Se_tot" _
          Or filaLab("ELE_CODIGO") = "Hg_tot" Or filaLab("ELE_CODIGO") = "Zn_tot_%" Or filaLab("ELE_CODIGO") = "Mn_tot_%" _
          Or filaLab("ELE_CODIGO") = "Fe_tot_%" Or filaLab("ELE_CODIGO") = "Cu_tot_%" Or filaLab("ELE_CODIGO") = "Al_tot" _
          Or filaLab("ELE_CODIGO") = "As_tot" Or filaLab("ELE_CODIGO") = "Ni_tot" Or filaLab("ELE_CODIGO") = "Co_tot" _
          Or filaLab("ELE_CODIGO") = "Cr_tot" Or filaLab("ELE_CODIGO") = "Cd_tot" Or filaLab("ELE_CODIGO") = "Pb_tot" _
          Or filaLab("ELE_CODIGO") = "Cu_tot_ppm" Or filaLab("ELE_CODIGO") = "Fe_tot_ppm" Or filaLab("ELE_CODIGO") = "Mn_tot_ppm" _
          Or filaLab("ELE_CODIGO") = "Zn_tot_ppm" Then
                letra = "M"
            End If
            End If


            For Each filaEle In filaOrdenada
                If filaEle("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                GrabaPlanillaPlani(filaEle("OT_NLAB").ToString & letra, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                End If
            Next
    End Sub 'listo

    Private Sub generaPSuelo(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc As New PdfPTable(2)
        Dim tablaEle As New PdfPTable(2)

        Dim widthsDesc(4) As Single
        widthsDesc(0) = 80
        widthsDesc(1) = 80
        widthsDesc(2) = 80
        widthsDesc(3) = 80


        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        '-------- Tabla de Curva Starndard ----------------
        '  tablaDesc.SetWidthPercentage(widthsDesc, PageSize.A4) 'Ajusta el tamaño de cada columna

        'tablaDesc.DefaultCell.BorderWidth = 1
        'tablaDesc.DefaultCell.Padding = 5
        'tablaDesc.DefaultCell.SpaceCharRatio = 5


        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Curva Standard", FontFactory.GetFont("Arial", 12)))
        cell.Colspan = 2
        tablaDesc.AddCell(cell)

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Concentración", FontFactory.GetFont("Arial", 9)))
        cell2.Colspan = 1
        cell2.Rowspan = 1
        tablaDesc.AddCell(cell2)

        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Lectura", FontFactory.GetFont("Arial", 9)))
        cell3.Colspan = 1
        cell3.Rowspan = 1
        tablaDesc.AddCell(cell3)

        tablaDesc.AddCell(" ") '1
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '2
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '3
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '4
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '5
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '6
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '7
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '8
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '9
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '10
        tablaDesc.AddCell(" ")

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("R:", FontFactory.GetFont("Arial", 8)))
        cell4.Colspan = 2
        cell4.Rowspan = 1
        tablaDesc.AddCell(cell4) '11

        '------- Tabla de datos -------
        Dim tablaDatos As New PdfPTable(1)

        tablaDatos.AddCell("Peso Muestra (gr):            ")  '1
        tablaDatos.AddCell("Volumen Aforo (ml):            ")  '2
        tablaDatos.AddCell("Dilución:            ")  '3
        tablaDatos.AddCell("Nombre Analista:            ")  '4
        tablaDatos.AddCell("Fecha:            ")  '5
        tablaDatos.AddCell("Digitados por:            ")  '6
        tablaDatos.AddCell("F. Planificación: " & Date.Now.Today)  '7
        tablaDatos.AddCell("Cod. Planificación: " & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value & "")  '8


        Dim tablaDatos2 As New PdfPTable(2)

        tablaDatos2.AddCell("OLSEN")  '1
        tablaDatos2.AddCell("K y BRAY 2")  '2
        tablaDatos2.AddCell(" ")  '3
        tablaDatos2.AddCell(" ")  '4
       

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaDesc)

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaDatos)

        Dim columna3 As New ColumnText(writer.DirectContent)
        columna3.AddElement(tablaDatos2)

        ' Dim width As Single = Documento.Right - Documento.Left

        columna1.SetSimpleColumn(Documento.Left - 4, Documento.Bottom, Documento.Right - 380, Documento.Top - 25)
        columna1.Go()
        columna2.SetSimpleColumn(Documento.Left + 310, Documento.Bottom, Documento.Right, Documento.Top - 100)
        columna2.Go()
        columna3.SetSimpleColumn(Documento.Left + 310, Documento.Bottom, Documento.Right, Documento.Top - 25)
        columna3.Go()


        agregarNlabsBSuelo(Documento, writer, fila)


    End Sub

    Private Sub generaArg(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc As New PdfPTable(2)
        Dim tablaEle As New PdfPTable(2)

        Dim widthsDesc(4) As Single
        widthsDesc(0) = 80
        widthsDesc(1) = 80
        widthsDesc(2) = 80
        widthsDesc(3) = 80


        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        '-------- Tabla de Curva Starndard ----------------
        '  tablaDesc.SetWidthPercentage(widthsDesc, PageSize.A4) 'Ajusta el tamaño de cada columna

        'tablaDesc.DefaultCell.BorderWidth = 1
        'tablaDesc.DefaultCell.Padding = 5
        'tablaDesc.DefaultCell.SpaceCharRatio = 5


        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Curva Standard", FontFactory.GetFont("Arial", 12)))
        cell.Colspan = 2
        tablaDesc.AddCell(cell)

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Concentración", FontFactory.GetFont("Arial", 9)))
        cell2.Colspan = 1
        cell2.Rowspan = 1
        tablaDesc.AddCell(cell2)

        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Lectura", FontFactory.GetFont("Arial", 9)))
        cell3.Colspan = 1
        cell3.Rowspan = 1
        tablaDesc.AddCell(cell3)

        tablaDesc.AddCell(" ") '1
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '2
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '3
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '4
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '5
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '6
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '7
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '8
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '9
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '10
        tablaDesc.AddCell(" ")

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("R:", FontFactory.GetFont("Arial", 8)))
        cell4.Colspan = 2
        cell4.Rowspan = 1
        tablaDesc.AddCell(cell4) '11

        '------- Tabla de datos -------
        Dim tablaDatos As New PdfPTable(1)

        tablaDatos.AddCell("Peso Muestra (gr):            ")  '1
        tablaDatos.AddCell("Volumen Aforo (ml):            ")  '2
        tablaDatos.AddCell("Dilución:            ")  '3
        tablaDatos.AddCell("Nombre Analista:            ")  '4
        tablaDatos.AddCell("Fecha:            ")  '5
        tablaDatos.AddCell("Digitados por:            ")  '6
        tablaDatos.AddCell("F. Planificación: " & Date.Now.Today)  '7
        tablaDatos.AddCell("Cod. Planificación: " & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value & "")  '8


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaDesc)

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaDatos)

        ' Dim width As Single = Documento.Right - Documento.Left

        columna1.SetSimpleColumn(Documento.Left - 4, Documento.Bottom, Documento.Right - 380, Documento.Top - 25)
        columna1.Go()
        columna2.SetSimpleColumn(Documento.Left + 310, Documento.Bottom, Documento.Right, Documento.Top - 25)
        columna2.Go()



        agregarNlabsArg(Documento, writer, fila)


    End Sub

    Private Sub generapH(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc, tablaCurva, tablaCurva2, tablaEle As New PdfPTable(2)
        Dim cell10, cell11 As New PdfPCell

        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : Determinación de " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell0 As New PdfPCell
        cell0.AddElement(New Chunk("Tipo de Muestra ", FontFactory.GetFont("Arial", 12)))
        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Relación Peso/Volumen", FontFactory.GetFont("Arial", 12)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Temperatura", FontFactory.GetFont("Arial", 9)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Factor", FontFactory.GetFont("Arial", 9)))

        cell10.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))

        tablaCurva.AddCell(cell0)
        tablaCurva.AddCell(cell10)
        tablaCurva.AddCell(cell)
        tablaCurva.AddCell(cell10)
        tablaCurva.AddCell(cell2)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell3)  '1
        tablaCurva.AddCell(cell10)  '1


        Dim cell21 As New PdfPCell
        cell21.AddElement(New Chunk("Nombre ", FontFactory.GetFont("Arial", 12)))
        Dim cell22 As New PdfPCell
        cell22.AddElement(New Chunk("Fecha", FontFactory.GetFont("Arial", 12)))
        Dim cell23 As New PdfPCell
        cell23.AddElement(New Chunk("F.Plani", FontFactory.GetFont("Arial", 9)))
        Dim cell24 As New PdfPCell
        cell24.AddElement(New Chunk("Cod. Plani", FontFactory.GetFont("Arial", 9)))
        Dim cell25 As New PdfPCell
        cell25.AddElement(New Chunk("" & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value.ToString & "", FontFactory.GetFont("Arial", 9)))
        Dim cell26 As New PdfPCell
        cell26.AddElement(New Chunk("" & Date.Now.Today.ToString, FontFactory.GetFont("Arial", 9)))

        tablaCurva2.AddCell(cell21)
        tablaCurva2.AddCell(cell10)   '
        tablaCurva2.AddCell(cell22)  '
        tablaCurva2.AddCell(cell10)  '
        tablaCurva2.AddCell(cell23)  '1
        tablaCurva2.AddCell(cell26)  '1
        tablaCurva2.AddCell(cell24)  '1
        tablaCurva2.AddCell(cell25)  '1

      

        Dim columna01 As New ColumnText(writer.DirectContent)
        columna01.AddElement(tablaCurva)

        Dim columna02 As New ColumnText(writer.DirectContent)
        columna02.AddElement(tablaCurva2)

        columna01.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 270, Documento.Top - 25)
        columna01.Go()
        columna02.SetSimpleColumn(Documento.Left + 270, Documento.Bottom, Documento.Right + 10, Documento.Top - 25)
        columna02.Go()

        agregarNlabspH(Documento, writer, fila)


    End Sub

    Private Sub agregarNlabspH(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j As Integer
        Dim nlabCount As Integer

        Dim widthsNlab(3) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130
        widthsNlab(3) = 130

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("pH", FontFactory.GetFont("Arial", 11)))

        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Lectura C.E.", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("C.E. mmhos/cm", FontFactory.GetFont("Arial", 11)))
       

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))



        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))


        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)
        tablaNlab.AddCell(cell4) '2
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        j = 4
        nlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada

            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 23 Then
                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            nlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))

                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                ElseIf i >= 23 And i < 49 Then
                    If i = 23 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)  '2
                        tablaNlab2.AddCell(cell02) '3 
                        tablaNlab2.AddCell(cell3) '3 

                    End If

                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            nlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 23 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 49 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 135)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 135)
        columna2.Go()


        If i >= 49 Then
            generaNlabInfinitopH(documento, writer, filaLab, j)

        End If

    End Sub 'listo

    Private Sub generaS(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc, tablaCurva, tablaCurva2, tablaEle As New PdfPTable(2)
        Dim cell10, cell11 As New PdfPCell
    
        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell0 As New PdfPCell
        cell0.AddElement(New Chunk("DETERM. DE: ", FontFactory.GetFont("Arial", 12)))
        cell0.Colspan = 2
        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Curva Standard", FontFactory.GetFont("Arial", 12)))
        cell.Colspan = 2
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Concentración", FontFactory.GetFont("Arial", 9)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Lectura", FontFactory.GetFont("Arial", 9)))

        cell10.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell11.AddElement(New Chunk("R:", FontFactory.GetFont("Arial", 8)))
        cell11.Colspan = 2

        tablaCurva.AddCell(cell0)
        tablaCurva.AddCell(cell)
        tablaCurva.AddCell(cell2)
        tablaCurva.AddCell(cell3)
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell11)  '1

        tablaCurva2.AddCell(cell0)
        tablaCurva2.AddCell(cell)   '
        tablaCurva2.AddCell(cell2)  '
        tablaCurva2.AddCell(cell3)  '
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell10)  '1
        tablaCurva2.AddCell(cell11)  '1


        '------- Tabla de datos -------
        Dim tablaDatos1 As New PdfPTable(1)
        tablaDatos1.AddCell("Muestra de:            ")  '1
        tablaDatos1.AddCell("Fecha:            ")  '2
        tablaDatos1.AddCell("Nombre Analista:            ")  '1


        '------- Tabla de datos -------
        Dim tablaDatos As New PdfPTable(1)
        tablaDatos.AddCell("Muestra de:           ")  '1
        tablaDatos.AddCell("Fecha:             ")  '2
        tablaDatos.AddCell("Nombre Analista:        ")  '1
        tablaDatos.AddCell("F. Planificación: " & Date.Now.Today)  '4
        tablaDatos.AddCell("Cod. Planificación: " & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value & "")  '5

        Dim columna01 As New ColumnText(writer.DirectContent)
        columna01.AddElement(tablaCurva)

        Dim columna02 As New ColumnText(writer.DirectContent)
        columna02.AddElement(tablaCurva2)

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaDatos1)

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaDatos)

        columna01.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 270, Documento.Top - 25)
        columna01.Go()
        columna02.SetSimpleColumn(Documento.Left + 270, Documento.Bottom, Documento.Right + 10, Documento.Top - 25)
        columna02.Go()

        columna1.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 260, Documento.Top - 254)
        columna1.Go()
        columna2.SetSimpleColumn(Documento.Left + 260, Documento.Bottom, Documento.Right + 10, Documento.Top - 254)
        columna2.Go()

        agregarNlabsS(Documento, writer, fila)


    End Sub

    Private Sub generaClHC(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc, tablaCurva, tablaCurva2, tablaEle As New PdfPTable(2)
        Dim cell10, cell11, cell12, cell13, cell14, cell15, cell16, cell17, cell18, cell19, cell20, cell21, cell22 As New PdfPCell
        Dim cell23, cell24, cell25, cell26, cell27, cell28, cell29, cell30, cell31, cell32, cell33, cell34, cell35, cell36, cell37, cell38, cell39, cell40, cell41 As New PdfPCell

        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Muestra de:", FontFactory.GetFont("Arial", 11)))

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Alicuota Cloruro:", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Alicuota HCO3:", FontFactory.GetFont("Arial", 11)))
        cell10.AddElement(New Chunk("Nombre:", FontFactory.GetFont("Arial", 11)))
        cell11.AddElement(New Chunk("Fecha:", FontFactory.GetFont("Arial", 11)))
        cell12.AddElement(New Chunk("F.Plani:", FontFactory.GetFont("Arial", 11)))
        cell13.AddElement(New Chunk("Cod.Plani:", FontFactory.GetFont("Arial", 11)))
        cell14.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


        cell15.AddElement(New Chunk("" & Date.Now.Today.ToString & "", FontFactory.GetFont("Arial", 11)))
        cell16.AddElement(New Chunk("" & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value.ToString & "", FontFactory.GetFont("Arial", 11)))


        tablaCurva.AddCell(cell)
        tablaCurva.AddCell(cell14)  '5
        tablaCurva.AddCell(cell2)
        tablaCurva.AddCell(cell14)  '5
        tablaCurva.AddCell(cell3)
        tablaCurva.AddCell(cell14)  '5

        tablaCurva2.AddCell(cell10) '1
        tablaCurva2.AddCell(cell14)
        tablaCurva2.AddCell(cell11)  '2
        tablaCurva2.AddCell(cell14)  '
        tablaCurva2.AddCell(cell12)  '3
        tablaCurva2.AddCell(cell15)  '
        tablaCurva2.AddCell(cell13)  '4
        tablaCurva2.AddCell(cell16)  '



        Dim columna01 As New ColumnText(writer.DirectContent)
        columna01.AddElement(tablaCurva)

        Dim columna02 As New ColumnText(writer.DirectContent)
        columna02.AddElement(tablaCurva2)

    
        columna01.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 270, Documento.Top - 25)
        columna01.Go()
        columna02.SetSimpleColumn(Documento.Left + 270, Documento.Bottom, Documento.Right + 10, Documento.Top - 25)
        columna02.Go()

     

        agregarNlabsClHC(Documento, writer, fila)


    End Sub

    Private Sub generaCl(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc, tablaCurva, tablaCurva2, tablaEle As New PdfPTable(2)
        Dim cell10, cell11, cell12, cell13, cell14, cell15, cell16, cell17, cell18, cell19, cell20, cell21, cell22 As New PdfPCell
        Dim cell23, cell24, cell25, cell26, cell27, cell28, cell29, cell30, cell31, cell32, cell33, cell34, cell35, cell36, cell37, cell38, cell39, cell40, cell41 As New PdfPCell

        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Curva Standard", FontFactory.GetFont("Arial", 12)))
        cell.Colspan = 2
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Concentración", FontFactory.GetFont("Arial", 9)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Lectura", FontFactory.GetFont("Arial", 9)))
        cell10.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell12.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell13.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell14.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell15.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell16.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell17.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell18.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell19.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell20.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell21.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell22.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell24.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell25.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell26.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell27.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell28.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))

        tablaCurva.AddCell(cell)
        tablaCurva.AddCell(cell2)
        tablaCurva.AddCell(cell3)
        tablaCurva.AddCell(cell10)  '1
        tablaCurva.AddCell(cell11)  '2
        tablaCurva.AddCell(cell12)  '3
        tablaCurva.AddCell(cell13)  '4
        tablaCurva.AddCell(cell14)  '5
        tablaCurva.AddCell(cell15)  '6
        tablaCurva.AddCell(cell16)  '7
        tablaCurva.AddCell(cell17)  '8
        tablaCurva.AddCell(cell18)  '9
        tablaCurva.AddCell(cell19)  '0
        tablaCurva.AddCell(cell20)  '1
        tablaCurva.AddCell(cell21)  '2
        tablaCurva.AddCell(cell22)  '3
        tablaCurva.AddCell(cell23)  '4
        tablaCurva.AddCell(cell24)  '5
        tablaCurva.AddCell(cell25)  '6
        tablaCurva.AddCell(cell26)  '7
        tablaCurva.AddCell(cell27)  '8
        tablaCurva.AddCell(cell28)  '9


        cell29.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell30.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell31.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell32.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell34.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell35.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell36.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell37.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell38.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell39.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell40.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))

        tablaCurva2.AddCell(cell)   '
        tablaCurva2.AddCell(cell2)  '
        tablaCurva2.AddCell(cell3)  '
        tablaCurva2.AddCell(cell29)  '0
        tablaCurva2.AddCell(cell30)  '1
        tablaCurva2.AddCell(cell31)  '2
        tablaCurva2.AddCell(cell32)  '3
        tablaCurva2.AddCell(cell33)  '4
        tablaCurva2.AddCell(cell34)  '5
        tablaCurva2.AddCell(cell35)  '6
        tablaCurva2.AddCell(cell36)  '7
        tablaCurva2.AddCell(cell37)  '8
        tablaCurva2.AddCell(cell38)  '9
        tablaCurva2.AddCell(cell39)  '0
        tablaCurva2.AddCell(cell40)  '1
        tablaCurva2.AddCell(cell33)  '4
        tablaCurva2.AddCell(cell34)  '5
        tablaCurva2.AddCell(cell35)  '6
        tablaCurva2.AddCell(cell36)  '7
        tablaCurva2.AddCell(cell37)  '8
        tablaCurva2.AddCell(cell38)  '9


        '------- Tabla de datos -------
        Dim tablaDatos1 As New PdfPTable(1)
        tablaDatos1.AddCell("Peso Muestra:            ")  '1
        tablaDatos1.AddCell("Potencial:            ")  '2
        tablaDatos1.AddCell("Gasto (ml):            ")  '1
        tablaDatos1.AddCell("Normalidad:            ")  '2
        tablaDatos1.AddCell("Nombre:            ")  '3
        tablaDatos1.AddCell("Fecha:            ")  '3

        '------- Tabla de datos -------
        Dim tablaDatos As New PdfPTable(1)
        tablaDatos.AddCell("Peso Muestra:            ")  '1
        tablaDatos.AddCell("Potencial:            ")  '2
        tablaDatos.AddCell("Gasto (ml):            ")  '1
        tablaDatos.AddCell("Normalidad:            ")  '2
        tablaDatos.AddCell("Nombre:            ")  '3
        tablaDatos.AddCell("Fecha:            ")  '3
        tablaDatos.AddCell("F. Planificación: " & Date.Now.Today)  '4
        tablaDatos.AddCell("Cod. Planificación: " & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value & "")  '5

        Dim columna01 As New ColumnText(writer.DirectContent)
        columna01.AddElement(tablaCurva)

        Dim columna02 As New ColumnText(writer.DirectContent)
        columna02.AddElement(tablaCurva2)

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaDatos1)

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaDatos)

        columna01.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 270, Documento.Top - 25)
        columna01.Go()
        columna02.SetSimpleColumn(Documento.Left + 270, Documento.Bottom, Documento.Right + 10, Documento.Top - 25)
        columna02.Go()

        columna1.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 270, Documento.Top - 220)
        columna1.Go()
        columna2.SetSimpleColumn(Documento.Left + 270, Documento.Bottom, Documento.Right + 10, Documento.Top - 220)
        columna2.Go()

        agregarNlabsCl(Documento, writer, fila)


    End Sub

    Private Sub generaNNO3Foliar(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc As New PdfPTable(4)
        Dim tablaEle As New PdfPTable(2)



        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Curva Standard", FontFactory.GetFont("Arial", 12)))
        cell.Colspan = 4
        tablaDesc.AddCell(cell)
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Concentración ppm", FontFactory.GetFont("Arial", 9)))
        tablaDesc.AddCell(cell2)

        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Lectura mV 1 T °C", FontFactory.GetFont("Arial", 9)))
        tablaDesc.AddCell(cell3)

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Lectura mV 2 T °C", FontFactory.GetFont("Arial", 9)))
        tablaDesc.AddCell(cell4)

        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("Lectura mV 3 T °C", FontFactory.GetFont("Arial", 9)))
        tablaDesc.AddCell(cell5)

        Dim cell6 As New PdfPCell
        cell6.AddElement(New Chunk("Blanco", FontFactory.GetFont("Arial", 8)))
        tablaDesc.AddCell(cell6)

        Dim cell10, cell11, cell12, cell13, cell14, cell15, cell16, cell17, cell18, cell19, cell20, cell21, cell22 As New PdfPCell
        Dim cell23, cell24, cell25, cell26, cell27, cell28, cell29, cell30, cell31, cell32, cell33, cell34, cell35, cell36, cell37, cell38, cell39, cell40, cell41 As New PdfPCell

        cell10.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell12.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell13.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell14.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell15.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell16.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell17.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell18.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell19.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell20.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell21.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell22.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell24.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell25.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell26.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell27.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell28.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell29.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell30.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell31.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell32.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell34.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell35.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell36.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell37.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell38.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell39.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))
        cell40.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 8)))

        tablaDesc.AddCell(cell10)  '1
        tablaDesc.AddCell(cell11)  '2
        tablaDesc.AddCell(cell12)  '3
        tablaDesc.AddCell(cell13)  '4
        tablaDesc.AddCell(cell14)  '5
        tablaDesc.AddCell(cell15)  '6
        tablaDesc.AddCell(cell16)  '7
        tablaDesc.AddCell(cell17)  '8
        tablaDesc.AddCell(cell18)  '9
        tablaDesc.AddCell(cell19)  '0
        tablaDesc.AddCell(cell20)  '1
        tablaDesc.AddCell(cell21)  '2
        tablaDesc.AddCell(cell22)  '3
        tablaDesc.AddCell(cell23)  '4
        tablaDesc.AddCell(cell24)  '5
        tablaDesc.AddCell(cell25)  '6
        tablaDesc.AddCell(cell26)  '7
        tablaDesc.AddCell(cell27)  '8
        tablaDesc.AddCell(cell28)  '9
        tablaDesc.AddCell(cell29)  '0
        tablaDesc.AddCell(cell30)  '1
        tablaDesc.AddCell(cell31)  '2
        tablaDesc.AddCell(cell32)  '3
        tablaDesc.AddCell(cell33)  '4
        tablaDesc.AddCell(cell34)  '5
        tablaDesc.AddCell(cell35)  '6
        tablaDesc.AddCell(cell36)  '7
        tablaDesc.AddCell(cell37)  '8
        tablaDesc.AddCell(cell38)  '9
        tablaDesc.AddCell(cell39)  '0
        tablaDesc.AddCell(cell40)  '1


        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("R", FontFactory.GetFont("Arial", 12)))
        cell7.Colspan = 4
        tablaDesc.AddCell(cell7)


        '------- Tabla de datos -------
        Dim tablaDatos As New PdfPTable(1)
        tablaDatos.AddCell("Peso Muestra (gr):            ")  '1
        tablaDatos.AddCell("Volumen Aforo (ml):            ")  '2
        tablaDatos.AddCell("Nombre Analista:            ")  '1
        tablaDatos.AddCell("Fecha:            ")  '2
        tablaDatos.AddCell("Digitados por:            ")  '3
        tablaDatos.AddCell("F. Planificación: " & Date.Now.Today)  '4
        tablaDatos.AddCell("Cod. Planificación: " & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value & "")  '5


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaDesc)

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaDatos)

        ' Dim width As Single = Documento.Right - Documento.Left

        columna1.SetSimpleColumn(Documento.Left - 20, Documento.Bottom, Documento.Right - 250, Documento.Top - 25)
        columna1.Go()
        columna2.SetSimpleColumn(Documento.Left + 285, Documento.Bottom, Documento.Right + 10, Documento.Top - 25)
        columna2.Go()

        agregarNlabsNNO3(Documento, writer, fila)


    End Sub

    Private Sub generaNNH4Foliar(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc As New PdfPTable(1)
        Dim tablaEle As New PdfPTable(2)



        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea


        tablaDesc.AddCell("Peso Muestra (gr):            ")  '1
        tablaDesc.AddCell("Normalidad H2SO4 :            ")  '2
        tablaDesc.AddCell("Chequeo N acido:            ")  '3
        tablaDesc.AddCell("N° Lote titrisol:            ")  '4


        '------- Tabla de datos -------
        Dim tablaDatos As New PdfPTable(1)

        tablaDatos.AddCell("Factor:            ")  '1
        tablaDatos.AddCell("Fecha:            ")  '2
        tablaDatos.AddCell("Analista:            ")  '3
        tablaDatos.AddCell("Digitados por:            ")  '4
        tablaDatos.AddCell("F. Planificación: " & Date.Now.Today)  '7
        tablaDatos.AddCell("Cod. Planificación: " & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value & "")  '8


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaDesc)

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaDatos)

        ' Dim width As Single = Documento.Right - Documento.Left

        columna1.SetSimpleColumn(Documento.Left, Documento.Bottom, Documento.Right - 250, Documento.Top - 25)
        columna1.Go()
        columna2.SetSimpleColumn(Documento.Left + 295, Documento.Bottom, Documento.Right, Documento.Top - 25)
        columna2.Go()

        agregarNlabsNNH4(Documento, writer, fila)


    End Sub

    Private Sub generaBFoliar(ByVal Documento As Document, ByVal writer As PdfWriter, ByVal fila As DataRow, ByVal titulo As String)
        Dim cd As New CapaDato
        Dim dsNlab As New DataSet
        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        Dim x, y, z, a, nlab As Integer
        Dim tablaDesc As New PdfPTable(2)
        Dim tablaEle As New PdfPTable(2)

        Dim widthsDesc(4) As Single
        widthsDesc(0) = 80
        widthsDesc(1) = 80
        widthsDesc(2) = 80
        widthsDesc(3) = 80


        Documento.SetPageSize(PageSize.LETTER)
        Documento.NewPage()

        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(titulo & " Elemento : " & fila("ELE_NOMBRE").ToString) 'Texto que se insertara
        Documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea
        Documento.Add(New Paragraph(" ")) 'Salto de linea

        '-------- Tabla de Curva Starndard ----------------
        '  tablaDesc.SetWidthPercentage(widthsDesc, PageSize.A4) 'Ajusta el tamaño de cada columna

        'tablaDesc.DefaultCell.BorderWidth = 1
        'tablaDesc.DefaultCell.Padding = 5
        'tablaDesc.DefaultCell.SpaceCharRatio = 5


        Dim cell As New PdfPCell
        cell.AddElement(New Chunk("Curva Standard", FontFactory.GetFont("Arial", 12)))
        cell.Colspan = 2
        tablaDesc.AddCell(cell)

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Concentración", FontFactory.GetFont("Arial", 9)))
        cell2.Colspan = 1
        cell2.Rowspan = 1
        tablaDesc.AddCell(cell2)

        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Lectura", FontFactory.GetFont("Arial", 9)))
        cell3.Colspan = 1
        cell3.Rowspan = 1
        tablaDesc.AddCell(cell3)

        tablaDesc.AddCell(" ") '1
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '2
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '3
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '4
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '5
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '6
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '7
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '8
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '9
        tablaDesc.AddCell(" ")
        tablaDesc.AddCell(" ") '10
        tablaDesc.AddCell(" ")

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("R:", FontFactory.GetFont("Arial", 8)))
        cell4.Colspan = 2
        cell4.Rowspan = 1
        tablaDesc.AddCell(cell4) '11

        '------- Tabla de datos -------
        Dim tablaDatos As New PdfPTable(1)

        tablaDatos.AddCell("Peso Muestra (gr):            ")  '1
        tablaDatos.AddCell("Volumen Aforo (ml):            ")  '2
        tablaDatos.AddCell("Dilución:            ")  '3
        tablaDatos.AddCell("Nombre Analista:            ")  '4
        tablaDatos.AddCell("Fecha:            ")  '5
        tablaDatos.AddCell("Digitados por:            ")  '6
        tablaDatos.AddCell("F. Planificación: " & Date.Now.Today)  '7
        tablaDatos.AddCell("Cod. Planificación: " & Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value & "")  '8


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaDesc)

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaDatos)

        ' Dim width As Single = Documento.Right - Documento.Left

        columna1.SetSimpleColumn(Documento.Left - 4, Documento.Bottom, Documento.Right - 380, Documento.Top - 25)
        columna1.Go()
        columna2.SetSimpleColumn(Documento.Left + 310, Documento.Bottom, Documento.Right, columna1.YLine + 218)
        columna2.Go()

        If tmuAnalisis = 4000 Then
            agregarNlabsBSuelo(Documento, writer, fila)
        ElseIf tmuAnalisis = 6000 Or tmuAnalisis = 7000 Then
            agregarNlabsBSuelo(Documento, writer, fila)

        ElseIf tmuAnalisis = 1000 Then
        agregarNlabs(Documento, writer, fila)
        End If



    End Sub

    Private Sub agregarNlabsBSuelo(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j As Integer
        Dim NlabCount As Integer

        Dim widthsNlab(3) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130
        widthsNlab(3) = 130

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        cell1.Rowspan = 2
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("% T", FontFactory.GetFont("Arial", 11)))
        cell2.Rowspan = 2
        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Interpolac.", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Resultados", FontFactory.GetFont("Arial", 11)))
        Dim cell03 As New PdfPCell
        cell03.AddElement(New Chunk("Curva ppm", FontFactory.GetFont("Arial", 11)))
        Dim cell031 As New PdfPCell
        If tmuAnalisis = 4000 Then
            cell031.AddElement(New Chunk("ppm", FontFactory.GetFont("Arial", 11)))
        ElseIf (tmuAnalisis = 6000 Or tmuAnalisis = 7000) And (filaLab("ELE_CODIGO") = "P_dis" Or filaLab("ELE_CODIGO") = "P_tot" Or filaLab("ELE_CODIGO") = "P_sol") Then
            cell031.AddElement(New Chunk("P", FontFactory.GetFont("Arial", 11)))
        Else
            cell031.AddElement(New Chunk("B", FontFactory.GetFont("Arial", 11)))
        End If
       

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))



        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))


        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell03)
        tablaNlab.AddCell(cell031)
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        j = 4
        NlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada
           
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 18 Then

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))



                ElseIf i >= 18 And i < 39 Then
                    If i = 18 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)  '2
                        tablaNlab2.AddCell(cell02) '3 
                        tablaNlab2.AddCell(cell3) '3 
                        tablaNlab2.AddCell(cell03) '3 
                        tablaNlab2.AddCell(cell031) '3 
                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            NlabCount = 0
                            i = i + 1
                            GoTo l

                        End If
                    End If

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 18 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 39 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 255)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 255)
        columna2.Go()


        If i >= 39 Then
            generaNlabInfinitoBSuelo(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub agregarNlabsArg(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j, NlabCount As Integer

        NlabCount = 0
        Dim widthsNlab(3) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130
        widthsNlab(3) = 130

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        cell1.Rowspan = 2
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("% T", FontFactory.GetFont("Arial", 11)))
        cell2.Rowspan = 2
        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Interpolac.", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Resultados", FontFactory.GetFont("Arial", 11)))
        Dim cell03 As New PdfPCell
        cell03.AddElement(New Chunk("Curva ppm", FontFactory.GetFont("Arial", 11)))
        Dim cell031 As New PdfPCell
        cell031.AddElement(New Chunk("gr/100gr", FontFactory.GetFont("Arial", 11)))

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))



        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))


        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell03)
        tablaNlab.AddCell(cell031)
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        j = 4

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada

            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If i < 18 Then
l:
                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            NlabCount = 0
                            i = i + 1
                            GoTo l

                        End If
                    End If

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                ElseIf i >= 18 And i < 39 Then

                    If i = 18 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)  '2
                        tablaNlab2.AddCell(cell02) '3 
                        tablaNlab2.AddCell(cell3) '3  
                        tablaNlab2.AddCell(cell03) '3 
                        tablaNlab2.AddCell(cell031) '3 
                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 18 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 39 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 255)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 255)
        columna2.Go()


        If i >= 39 Then
            generaNlabInfinitoArg(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub agregarNlabsS(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j, NlabCount As Integer


        Dim widthsNlab(3) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 105
        widthsNlab(2) = 120
        widthsNlab(3) = 150

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("ml Mx", FontFactory.GetFont("Arial", 11)))
        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Lectura", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Resultados ppm", FontFactory.GetFont("Arial", 11)))


        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))

        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        j = 4
        NlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 15 Then

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                ElseIf i >= 15 And i < 32 Then



                    If i = 15 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)  '2
                        tablaNlab2.AddCell(cell02) '3 
                        tablaNlab2.AddCell(cell3) '3 
                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 15 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 32 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left + 4, documento.Bottom, documento.Right - 290, documento.Top - 345)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 285, documento.Bottom, documento.Right, documento.Top - 345)
        columna2.Go()


        If i >= 32 Then
            generaNlabInfinitoS(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub generaNlabInfinitopH(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0
        NlabCount = 0
        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea


        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))

        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("pH", FontFactory.GetFont("Arial", 11)))

        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("Lectura C.E.", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("C.E. mmhos/cm", FontFactory.GetFont("Arial", 11)))


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)  '2
        tablaNlab.AddCell(cell02) '3 
        tablaNlab.AddCell(cell3) '4

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada

            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
           
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 32 And i < 64 Then
                        If i = 32 Then
                            tablaNlab2.AddCell(cell1)  '1
                            tablaNlab2.AddCell(cell2)  '2
                            tablaNlab2.AddCell(cell02) '3 
                            tablaNlab2.AddCell(cell3) '4
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If

                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 25)
        columna2.Go()


        If i >= 64 Then
            generaNlabInfinitopH(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub agregarNlabsClHC(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j, nlabCount As Integer


        Dim widthsNlab(3) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130
        widthsNlab(3) = 130

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("GASTO", FontFactory.GetFont("Arial", 11)))
        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("GASTO-BI", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("% CI", FontFactory.GetFont("Arial", 11)))

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))

        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        j = 4
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")
        nlabCount = 0

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 13 Then

                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            nlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    nlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                ElseIf i >= 13 And i < 29 Then

                    If i = 13 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)  '2
                        tablaNlab2.AddCell(cell02) '3 
                        tablaNlab2.AddCell(cell3) '3 
                    End If


                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            nlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    nlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next


        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 13 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 29 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 135)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 135)
        columna2.Go()


        If i >= 29 Then
            generaNlabInfinitoCl(documento, writer, filaLab, j)
        End If

    End Sub 'listo

    Private Sub agregarNlabsCl(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j, nlabCount As Integer


        Dim widthsNlab(3) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130
        widthsNlab(3) = 130

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("GASTO", FontFactory.GetFont("Arial", 11)))
        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk("GASTO-BI", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("% CI", FontFactory.GetFont("Arial", 11)))

        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
     
        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))

        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell04)
        j = 4
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 13 Then

                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)

                            nlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                ElseIf i >= 13 And i < 29 Then

                    If i = 13 Then
                        tablaNlab2.AddCell(cell1)  '1
                        tablaNlab2.AddCell(cell2)  '2
                        tablaNlab2.AddCell(cell02) '3 
                        tablaNlab2.AddCell(cell3) '3 
                    End If

                    If nlabCount <> 0 Then
                        If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)

                            nlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    nlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 13 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 29 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 360)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 360)
        columna2.Go()


        If i >= 29 Then
            generaNlabInfinitoCl(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub agregarNlabsNNO3(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(3)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j, NlabCount As Integer


        Dim widthsNlab(2) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130


        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)
        tablaNlab3.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("mV", FontFactory.GetFont("Arial", 11)))
        Dim cell02 As New PdfPCell
        cell02.AddElement(New Chunk(" Factor Dilución  ", FontFactory.GetFont("Arial", 11)))

        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell6 As New PdfPCell
        cell6.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell06 As New PdfPCell
        cell06.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))
        Dim cell8 As New PdfPCell
        cell8.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell08 As New PdfPCell
        cell08.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell6)
        tablaNlab.AddCell(cell06)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell8)
        tablaNlab.AddCell(cell08)
        j = 4
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")
        NlabCount = 0

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 19 Then

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                    Dim cell12 As New PdfPCell
                    cell12.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell12)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                ElseIf i >= 19 And i < 41 Then

                    If i = 19 Then
                        Dim cell20 As New PdfPCell
                        cell20.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                        Dim cell21 As New PdfPCell
                        cell21.AddElement(New Chunk("mV", FontFactory.GetFont("Arial", 11)))
                        Dim cell021 As New PdfPCell
                        cell021.AddElement(New Chunk("Factor Dilución", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell20)  '1
                        tablaNlab2.AddCell(cell21)  '2
                        tablaNlab2.AddCell(cell021) '3 

                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                    Dim cell24 As New PdfPCell
                    cell24.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell24)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                ElseIf i >= 41 And i < 63 Then



                    If i = 41 Then
                        Dim cell30 As New PdfPCell
                        cell30.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                        Dim cell31 As New PdfPCell
                        cell31.AddElement(New Chunk("mV", FontFactory.GetFont("Arial", 11)))
                        Dim cell031 As New PdfPCell
                        cell031.AddElement(New Chunk("Factor Dilución", FontFactory.GetFont("Arial", 11)))

                        tablaNlab3.AddCell(cell30)  '1
                        tablaNlab3.AddCell(cell31)  '2
                        tablaNlab3.AddCell(cell031) '3
                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab3.AddCell(cell56)
                            tablaNlab3.AddCell(cell56)
                            tablaNlab3.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell32 As New PdfPCell
                    cell32.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell33 As New PdfPCell
                    cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                    Dim cell34 As New PdfPCell
                    cell34.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    tablaNlab3.AddCell(cell32)  '1
                    tablaNlab3.AddCell(cell33)
                    tablaNlab3.AddCell(cell34)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next


        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 19 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 41 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            ElseIf i < 63 Then
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)

            End If
            i = i + 1
        End While


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 33, documento.Bottom, documento.Right - 327, documento.Top - 240)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 137, documento.Bottom, documento.Right - 139, documento.Top - 240)
        columna2.Go()

        Dim columna3 As New ColumnText(writer.DirectContent)
        columna3.AddElement(tablaNlab3)

        columna3.SetSimpleColumn(documento.Left + 325, documento.Bottom, documento.Right + 34, documento.Top - 240)
        columna3.Go()

        If i >= 63 Then
            generaNlabInfinitoNNO3(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub agregarNlabsNNH4(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)
        Dim tablaNlab, tablaNlab2, tablaNlab3 As New PdfPTable(3)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j, NlabCount As Integer


        Dim widthsNlab(2) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 150
        widthsNlab(2) = 110


        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)
        tablaNlab3.SetWidthPercentage(widthsNlab, PageSize.LETTER)

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Gasto (ml)", FontFactory.GetFont("Arial", 11)))

        Dim cell02 As New PdfPCell
        If filaLab("ELE_CODIGO") = "N" Then

            cell02.AddElement(New Chunk(" % ", FontFactory.GetFont("Arial", 11)))
        Else

            cell02.AddElement(New Chunk(" ppm ", FontFactory.GetFont("Arial", 11)))
        End If

        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell6 As New PdfPCell
        cell6.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell06 As New PdfPCell
        cell06.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))
        Dim cell8 As New PdfPCell
        cell8.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell08 As New PdfPCell
        cell08.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell02)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell04)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell6)
        tablaNlab.AddCell(cell06)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell8)
        tablaNlab.AddCell(cell08)
        j = 4
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")
        NlabCount = 0

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 24 Then

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                    Dim cell12 As New PdfPCell
                    cell12.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    tablaNlab.AddCell(cell12)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                ElseIf i >= 24 And i < 51 Then

                    If i = 24 Then
                        Dim cell20 As New PdfPCell
                        cell20.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                        Dim cell21 As New PdfPCell
                        cell21.AddElement(New Chunk("Gasto (ml)", FontFactory.GetFont("Arial", 11)))
                      

                        tablaNlab2.AddCell(cell20)  '1
                        tablaNlab2.AddCell(cell21)  '2
                        tablaNlab2.AddCell(cell02) '3 

                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                    Dim cell24 As New PdfPCell
                    cell24.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    tablaNlab2.AddCell(cell24)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                ElseIf i >= 51 And i < 78 Then

                    If i = 51 Then
                        Dim cell30 As New PdfPCell
                        cell30.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                        Dim cell31 As New PdfPCell
                        cell31.AddElement(New Chunk("Gasto (ml)", FontFactory.GetFont("Arial", 11)))
                   
                        tablaNlab3.AddCell(cell30)  '1
                        tablaNlab3.AddCell(cell31)  '2
                        tablaNlab3.AddCell(cell02) '3
                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab3.AddCell(cell56)
                            tablaNlab3.AddCell(cell56)
                            tablaNlab3.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If
                    NlabCount = CInt(filaELE("OT_NLAB"))


                    Dim cell32 As New PdfPCell
                    cell32.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell33 As New PdfPCell
                    cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                    Dim cell34 As New PdfPCell
                    cell34.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    tablaNlab3.AddCell(cell32)  '1
                    tablaNlab3.AddCell(cell33)
                    tablaNlab3.AddCell(cell34)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))
                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 24 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 51 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            ElseIf i < 78 Then
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)

            End If
            i = i + 1

            If i = 24 Then
                tablaNlab2.AddCell(cell1)  '1
                tablaNlab2.AddCell(cell2)
                tablaNlab2.AddCell(cell02)
            ElseIf i = 51 Then
                tablaNlab3.AddCell(cell1)  '1
                tablaNlab3.AddCell(cell2)
                tablaNlab3.AddCell(cell02)
            End If
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 33, documento.Bottom, documento.Right - 327, documento.Top - 140)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 137, documento.Bottom, documento.Right - 139, documento.Top - 140)
        columna2.Go()

        Dim columna3 As New ColumnText(writer.DirectContent)
        columna3.AddElement(tablaNlab3)

        columna3.SetSimpleColumn(documento.Left + 325, documento.Bottom, documento.Right + 34, documento.Top - 140)
        columna3.Go()

        If i >= 78 Then
            generaNlabInfinitoNNH4(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub agregarNlabs(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow)

        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(2)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, j, NlabCount As Integer

        NlabCount = 0
        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB. ", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("% T ", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Blanco1", FontFactory.GetFont("Arial", 11)))
        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell5 As New PdfPCell
        cell5.AddElement(New Chunk("100T1", FontFactory.GetFont("Arial", 11)))
        Dim cell6 As New PdfPCell
        cell6.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim cell7 As New PdfPCell
        cell7.AddElement(New Chunk("100S1", FontFactory.GetFont("Arial", 11)))
        Dim cell8 As New PdfPCell
        cell8.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


        GrabaPlanillaPlani("Blanco1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 1, tmuAnalisis)
        GrabaPlanillaPlani("100S1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 2, tmuAnalisis)
        GrabaPlanillaPlani("100T1", CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), 3, tmuAnalisis)

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)
        tablaNlab.AddCell(cell3)  '2
        tablaNlab.AddCell(cell4)
        tablaNlab.AddCell(cell5)  '3
        tablaNlab.AddCell(cell6)
        tablaNlab.AddCell(cell7)  '4
        tablaNlab.AddCell(cell8)

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")
        j = 4
        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
l:
                If i < 19 Then
                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab.AddCell(cell56)
                            tablaNlab.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell10 As New PdfPCell
                    cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell11 As New PdfPCell
                    cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab.AddCell(cell10)  '1
                    tablaNlab.AddCell(cell11)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                ElseIf i >= 19 And i < 41 Then

                    If i = 19 Then
                        Dim cell20 As New PdfPCell
                        cell20.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                        Dim cell21 As New PdfPCell
                        cell21.AddElement(New Chunk(" % T ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell20)  '1
                        tablaNlab2.AddCell(cell21)  '2
                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab2.AddCell(cell56)
                            tablaNlab2.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If

                    Dim cell22 As New PdfPCell
                    cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell23 As New PdfPCell
                    cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab2.AddCell(cell22)  '1
                    tablaNlab2.AddCell(cell23)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                ElseIf i >= 41 And i < 63 Then

                    If i = 41 Then
                        Dim cell30 As New PdfPCell
                        cell30.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                        Dim cell31 As New PdfPCell
                        cell31.AddElement(New Chunk(" % T ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab3.AddCell(cell30)  '1
                        tablaNlab3.AddCell(cell31)  '2
                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab3.AddCell(cell56)
                            tablaNlab3.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If


                    Dim cell32 As New PdfPCell
                    cell32.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell33 As New PdfPCell
                    cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab3.AddCell(cell32)  '1
                    tablaNlab3.AddCell(cell33)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))


                ElseIf i >= 63 And i < 85 Then

               
                    If i = 63 Then
                        Dim cell40 As New PdfPCell
                        cell40.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                        Dim cell41 As New PdfPCell
                        cell41.AddElement(New Chunk(" % T ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab4.AddCell(cell40)  '1
                        tablaNlab4.AddCell(cell41)  '2

                    End If

                    If NlabCount <> 0 Then
                        If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                            Dim cell56 As New PdfPCell
                            cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                            tablaNlab4.AddCell(cell56)
                            tablaNlab4.AddCell(cell56)

                            NlabCount = 0
                            i = i + 1
                            GoTo l
                        End If
                    End If


                    Dim cell42 As New PdfPCell
                    cell42.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                    Dim cell43 As New PdfPCell
                    cell43.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                    NlabCount = CInt(filaELE("OT_NLAB"))
                    tablaNlab4.AddCell(cell42)  '1
                    tablaNlab4.AddCell(cell43)
                    ultimoNlab = CInt(filaELE("OT_Nlab"))

                Else
                    Exit For
                End If
                GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                j = j + 1
                i = i + 1
            End If
        Next


        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 19 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 41 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            ElseIf i < 63 Then
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)
            ElseIf i < 85 Then
                tablaNlab4.AddCell(cell57)
                tablaNlab4.AddCell(cell57)
            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left, documento.Bottom, documento.Right - 420, documento.Top - 253)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 140, documento.Bottom, documento.Right - 282, documento.Top - 253)
        columna2.Go()

        Dim columna3 As New ColumnText(writer.DirectContent)
        columna3.AddElement(tablaNlab3)

        columna3.SetSimpleColumn(documento.Left + 280, documento.Bottom, documento.Right - 142, documento.Top - 253)
        columna3.Go()

        Dim columna4 As New ColumnText(writer.DirectContent)
        columna4.AddElement(tablaNlab4)

        columna4.SetSimpleColumn(documento.Left + 420, documento.Bottom, documento.Right, documento.Top - 253)
        columna4.Go()

        If i >= 85 Then
            generaNlabInfinito(documento, writer, filaLab, j)
        End If




    End Sub 'listo

    Private Sub generaNlabInfinitoBSuelo(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0

        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()


        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        cell1.Rowspan = 2
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("% T", FontFactory.GetFont("Arial", 11)))
        cell2.Rowspan = 2
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Interpolac.", FontFactory.GetFont("Arial", 11)))
        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Resultados", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk("Curva ppm", FontFactory.GetFont("Arial", 11)))
        Dim cell041 As New PdfPCell
        cell041.AddElement(New Chunk("ppm", FontFactory.GetFont("Arial", 11)))

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)  '2
        tablaNlab.AddCell(cell3) '3 
        tablaNlab.AddCell(cell4) '4
        tablaNlab.AddCell(cell04) '4
        tablaNlab.AddCell(cell041) '4

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")
        NlabCount = 0

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then
                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 32 And i < 64 Then


                        If i = 32 Then
                            tablaNlab2.AddCell(cell1)  '1
                            tablaNlab2.AddCell(cell2)  '2
                            tablaNlab2.AddCell(cell3) '3 
                            tablaNlab2.AddCell(cell4) '4 
                            tablaNlab2.AddCell(cell04) '4
                            tablaNlab2.AddCell(cell041) '4
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If


                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        NlabCount = CInt(filaELE("OT_NLAB"))
                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)


            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 13, documento.Top - 25)
        columna2.Go()


        If i >= 64 Then
            generaNlabInfinitoBSuelo(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub generaNlabInfinitoArg(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0

        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        cell1.Rowspan = 2
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("% T", FontFactory.GetFont("Arial", 11)))
        cell2.Rowspan = 2
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Interpolac.", FontFactory.GetFont("Arial", 11)))
        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk("Resultados", FontFactory.GetFont("Arial", 11)))
        Dim cell04 As New PdfPCell
        cell04.AddElement(New Chunk("Curva ppm", FontFactory.GetFont("Arial", 11)))
        Dim cell041 As New PdfPCell
        cell041.AddElement(New Chunk("gr/100gr", FontFactory.GetFont("Arial", 11)))

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)  '2
        tablaNlab.AddCell(cell3) '3 
        tablaNlab.AddCell(cell4) '4
        tablaNlab.AddCell(cell04) '4
        tablaNlab.AddCell(cell041) '4

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")
        NlabCount = 0

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 32 And i < 64 Then

                        If i = 32 Then
                            tablaNlab2.AddCell(cell1)  '1
                            tablaNlab2.AddCell(cell2)  '2
                            tablaNlab2.AddCell(cell3) '3 
                            tablaNlab2.AddCell(cell4) '4 
                            tablaNlab2.AddCell(cell04) '4
                            tablaNlab2.AddCell(cell041) '4
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 25)
        columna2.Go()


        If i >= 64 Then
            generaNlabInfinitoArg(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub generaNlabInfinitoS(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, nlabcount As Integer
        i = 0

        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB.", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("ml Mx", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Lectura", FontFactory.GetFont("Arial", 11)))
        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk(" Resultados ppm", FontFactory.GetFont("Arial", 11)))
     
        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)  '2
        tablaNlab.AddCell(cell3) '3 
        tablaNlab.AddCell(cell4) '4

        nlabcount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then

                        If nlabcount <> 0 Then
                            If (nlabcount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                nlabcount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        nlabcount = CInt(filaELE("OT_NLAB"))

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 32 And i < 64 Then

                        If i = 32 Then
                            tablaNlab2.AddCell(cell1)  '1
                            tablaNlab2.AddCell(cell2)  '2
                            tablaNlab2.AddCell(cell3) '3 
                            tablaNlab2.AddCell(cell4) '4 
                        End If

                        If nlabcount <> 0 Then
                            If (nlabcount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                nlabcount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        nlabcount = CInt(filaELE("OT_NLAB"))


                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left, documento.Bottom, documento.Right - 325, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 149, documento.Bottom, documento.Right - 149, documento.Top - 25)
        columna2.Go()


        If i >= 64 Then
            generaNlabInfinitoS(documento, writer, filaLab, j)
        End If

    End Sub 'listo

    Private Sub generaNlabInfinitoCl(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(4)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0

        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("  GASTO", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("GASTO-BI", FontFactory.GetFont("Arial", 11)))
        Dim cell4 As New PdfPCell
        cell4.AddElement(New Chunk(" % CI", FontFactory.GetFont("Arial", 11)))

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)  '2
        tablaNlab.AddCell(cell3) '3 
        tablaNlab.AddCell(cell4) '4

        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")
        NlabCount = 0
        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then
                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))


                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell11)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    ElseIf i >= 32 And i < 64 Then

                        If i = 32 Then
                            tablaNlab2.AddCell(cell1)  '1
                            tablaNlab2.AddCell(cell2)  '2
                            tablaNlab2.AddCell(cell3) '3 
                            tablaNlab2.AddCell(cell4) '4 
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 20, documento.Bottom, documento.Right - 270, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 270, documento.Bottom, documento.Right + 10, documento.Top - 25)
        columna2.Go()


        If i >= 64 Then
            generaNlabInfinitoCl(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub generaNlabInfinitoNNO3(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(3)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, nlabCount As Integer
        i = 0

        Dim widthsNlab(2) As Single
        widthsNlab(0) = 130
        widthsNlab(1) = 130
        widthsNlab(2) = 130

        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        tablaNlab.SetWidthPercentage(widthsNlab, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaNlab2.SetWidthPercentage(widthsNlab, PageSize.LETTER)
        tablaNlab3.SetWidthPercentage(widthsNlab, PageSize.LETTER)


        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("mV", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        cell3.AddElement(New Chunk("Factor Dilución", FontFactory.GetFont("Arial", 11)))

        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)  '2
        tablaNlab.AddCell(cell3) '3 

        nlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then

                        If nlabCount <> 0 Then
                            If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)

                                nlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        nlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                        Dim cell12 As New PdfPCell
                        cell12.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell12)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 32 And i < 64 Then

                        If i = 32 Then
                            Dim cell20 As New PdfPCell
                            cell20.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                            Dim cell21 As New PdfPCell
                            cell21.AddElement(New Chunk("mV", FontFactory.GetFont("Arial", 11)))
                            Dim cell021 As New PdfPCell
                            cell021.AddElement(New Chunk("Factor Dilución", FontFactory.GetFont("Arial", 11)))

                            tablaNlab2.AddCell(cell20)  '1
                            tablaNlab2.AddCell(cell21)  '2
                            tablaNlab2.AddCell(cell021) '3 
                        End If

                        If nlabCount <> 0 Then
                            If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)

                                nlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        nlabCount = CInt(filaELE("OT_NLAB"))


                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 64 And i < 96 Then


                        If i = 96 Then
                            Dim cell30 As New PdfPCell
                            cell30.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                            Dim cell31 As New PdfPCell
                            cell31.AddElement(New Chunk("mV", FontFactory.GetFont("Arial", 11)))
                            Dim cell031 As New PdfPCell
                            cell031.AddElement(New Chunk("Factor Dilución", FontFactory.GetFont("Arial", 11)))

                            tablaNlab3.AddCell(cell30)  '1
                            tablaNlab3.AddCell(cell31)  '2
                            tablaNlab3.AddCell(cell031) '3

                        End If

                        If nlabCount <> 0 Then
                            If (nlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab3.AddCell(cell56)
                                tablaNlab3.AddCell(cell56)
                                tablaNlab3.AddCell(cell56)

                                nlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        nlabCount = CInt(filaELE("OT_NLAB"))


                        Dim cell32 As New PdfPCell
                        cell32.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell33 As New PdfPCell
                        cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                        Dim cell34 As New PdfPCell
                        cell34.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab3.AddCell(cell32)  '1
                        tablaNlab3.AddCell(cell33)
                        tablaNlab3.AddCell(cell34)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))


                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            ElseIf i < 96 Then
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)

            End If
            i = i + 1
        End While


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 33, documento.Bottom, documento.Right - 327, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 137, documento.Bottom, documento.Right - 139, documento.Top - 25)
        columna2.Go()

        Dim columna3 As New ColumnText(writer.DirectContent)
        columna3.AddElement(tablaNlab3)

        columna3.SetSimpleColumn(documento.Left + 325, documento.Bottom, documento.Right + 34, documento.Top - 25)
        columna3.Go()


        If i >= 96 Then
            generaNlabInfinitoNNO3(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub generaNlabInfinitoNNH4(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(3)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0

        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("Gasto (ml)", FontFactory.GetFont("Arial", 11)))
        Dim cell3 As New PdfPCell
        If filaLab("ele_codigo") = "Nt" Then
            cell3.AddElement(New Chunk(" % ", FontFactory.GetFont("Arial", 11)))
        Else
            cell3.AddElement(New Chunk(" ppm ", FontFactory.GetFont("Arial", 11)))
        End If


        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)  '2
        tablaNlab.AddCell(cell3)  '3 

        NlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                        Dim cell12 As New PdfPCell
                        cell12.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        tablaNlab.AddCell(cell12)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 32 And i < 64 Then

                        If i = 32 Then
                            Dim cell20 As New PdfPCell
                            cell20.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                            Dim cell21 As New PdfPCell
                            cell21.AddElement(New Chunk("Gasto (ml)", FontFactory.GetFont("Arial", 11)))
                            Dim cell021 As New PdfPCell
                            cell021.AddElement(New Chunk(" % ", FontFactory.GetFont("Arial", 11)))

                            tablaNlab2.AddCell(cell20)  '1
                            tablaNlab2.AddCell(cell21)  '2
                            tablaNlab2.AddCell(cell3) '3 
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 64 And i < 96 Then

                        If i = 64 Then
                            Dim cell30 As New PdfPCell
                            cell30.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                            Dim cell31 As New PdfPCell
                            cell31.AddElement(New Chunk("Gasto (ml)", FontFactory.GetFont("Arial", 11)))
                            Dim cell031 As New PdfPCell
                            cell031.AddElement(New Chunk(" % ", FontFactory.GetFont("Arial", 11)))

                            tablaNlab3.AddCell(cell30)  '1
                            tablaNlab3.AddCell(cell31)  '2
                            tablaNlab3.AddCell(cell3) '3

                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab3.AddCell(cell56)
                                tablaNlab3.AddCell(cell56)
                                tablaNlab3.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell32 As New PdfPCell
                        cell32.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell33 As New PdfPCell
                        cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                        Dim cell34 As New PdfPCell
                        cell34.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab3.AddCell(cell32)  '1
                        tablaNlab3.AddCell(cell33)
                        tablaNlab3.AddCell(cell34)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))


                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            ElseIf i < 96 Then
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)

            End If
            i = i + 1
        End While

        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left - 25, documento.Bottom, documento.Right - 360, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 155, documento.Bottom, documento.Right - 165, documento.Top - 25)
        columna2.Go()

        Dim columna3 As New ColumnText(writer.DirectContent)
        columna3.AddElement(tablaNlab3)

        columna3.SetSimpleColumn(documento.Left + 350, documento.Bottom, documento.Right + 20, documento.Top - 25)
        columna3.Go()



        If i >= 96 Then
            generaNlabInfinitoNNH4(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub generaNlabInfinito(ByVal documento As Document, ByVal writer As PdfWriter, ByVal filaLab As DataRow, ByVal j As Integer)
        Dim tablaNlab, tablaNlab2, tablaNlab3, tablaNlab4 As New PdfPTable(2)
        Dim FilaOrdenada As DataRow()
        Dim filaELE As DataRow
        Dim i, NlabCount As Integer
        i = 0

        documento.SetPageSize(PageSize.LETTER)
        documento.NewPage()

        Dim parrafoTitulo As New Paragraph ' Declaracion de un parrafo
        parrafoTitulo.Alignment = ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafoTitulo.Font = FontFactory.GetFont("Arial", 14, ALIGN_CENTER) 'Asigan fuente
        parrafoTitulo.Add(" Elemento : " & filaLab("ELE_NOMBRE").ToString) 'Texto que se insertara
        documento.Add(parrafoTitulo) 'Agrega el parrafo al documento
        parrafoTitulo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        documento.Add(New Paragraph(" ")) 'Salto de linea
        documento.Add(New Paragraph(" ")) 'Salto de linea

        Dim cell1 As New PdfPCell
        cell1.AddElement(New Chunk("N° LAB. ", FontFactory.GetFont("Arial", 11)))
        Dim cell2 As New PdfPCell
        cell2.AddElement(New Chunk("% T ", FontFactory.GetFont("Arial", 11)))
        tablaNlab.AddCell(cell1)  '1
        tablaNlab.AddCell(cell2)

        NlabCount = 0
        FilaOrdenada = Cjto_Tablas1.Tables("PLANTI_ELElab").Select("", "OT_NLAB ASC")

        For Each filaELE In FilaOrdenada
            If filaELE("ELE_CODIGO") = filaLab("ELE_CODIGO") Then
                If CInt(filaELE("OT_Nlab")) > ultimoNlab Then
l:
                    If i < 32 Then

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab.AddCell(cell56)
                                tablaNlab.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell10 As New PdfPCell
                        cell10.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell11 As New PdfPCell
                        cell11.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                        tablaNlab.AddCell(cell10)  '1
                        tablaNlab.AddCell(cell11)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 32 And i < 64 Then


                        If i = 32 Then
                            Dim cell20 As New PdfPCell
                            cell20.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                            Dim cell21 As New PdfPCell
                            cell21.AddElement(New Chunk(" % T ", FontFactory.GetFont("Arial", 11)))

                            tablaNlab2.AddCell(cell20)  '1
                            tablaNlab2.AddCell(cell21)  '2
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab2.AddCell(cell56)
                                tablaNlab2.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))


                        Dim cell22 As New PdfPCell
                        cell22.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell23 As New PdfPCell
                        cell23.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab2.AddCell(cell22)  '1
                        tablaNlab2.AddCell(cell23)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))
                    ElseIf i >= 64 And i < 96 Then

                        If i = 64 Then
                            Dim cell30 As New PdfPCell
                            cell30.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                            Dim cell31 As New PdfPCell
                            cell31.AddElement(New Chunk(" % T ", FontFactory.GetFont("Arial", 11)))

                            tablaNlab3.AddCell(cell30)  '1
                            tablaNlab3.AddCell(cell31)  '2
                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab3.AddCell(cell56)
                                tablaNlab3.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))

                        Dim cell32 As New PdfPCell
                        cell32.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell33 As New PdfPCell
                        cell33.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab3.AddCell(cell32)  '1
                        tablaNlab3.AddCell(cell33)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    ElseIf i >= 96 And i < 128 Then


                        If i = 96 Then
                            Dim cell40 As New PdfPCell
                            cell40.AddElement(New Chunk(" N° LAB. ", FontFactory.GetFont("Arial", 11)))
                            Dim cell41 As New PdfPCell
                            cell41.AddElement(New Chunk(" % T ", FontFactory.GetFont("Arial", 11)))

                            tablaNlab4.AddCell(cell40)  '1
                            tablaNlab4.AddCell(cell41)  '2

                        End If

                        If NlabCount <> 0 Then
                            If (NlabCount + 1) <> CInt(filaELE("OT_NLAB")) Then
                                Dim cell56 As New PdfPCell
                                cell56.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
                                tablaNlab4.AddCell(cell56)
                                tablaNlab4.AddCell(cell56)

                                NlabCount = 0
                                i = i + 1
                                GoTo l
                            End If
                        End If
                        NlabCount = CInt(filaELE("OT_NLAB"))


                        Dim cell42 As New PdfPCell
                        cell42.AddElement(New Chunk("" & filaELE("OT_NLAB").ToString & "", FontFactory.GetFont("Arial", 11)))
                        Dim cell43 As New PdfPCell
                        cell43.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))

                        tablaNlab4.AddCell(cell42)  '1
                        tablaNlab4.AddCell(cell43)
                        ultimoNlab = CInt(filaELE("OT_Nlab"))

                    Else
                        Exit For
                    End If
                    GrabaPlanillaPlani(filaELE("OT_NLAB").ToString, CInt(Me.dgPlanNlab.Rows.Item(0).Cells.Item(0).Value), filaLab("Ele_codigo"), j, tmuAnalisis)
                    j = j + 1
                    i = i + 1
                End If
            End If
        Next

        Dim cell57 As New PdfPCell
        cell57.AddElement(New Chunk(" ", FontFactory.GetFont("Arial", 11)))
        Dim a As Integer
        a = i + 6

        While i < a
            If i < 32 Then
                tablaNlab.AddCell(cell57)
                tablaNlab.AddCell(cell57)

            ElseIf i < 64 Then
                tablaNlab2.AddCell(cell57)
                tablaNlab2.AddCell(cell57)

            ElseIf i < 96 Then
                tablaNlab3.AddCell(cell57)
                tablaNlab3.AddCell(cell57)

            ElseIf i < 128 Then
                tablaNlab4.AddCell(cell57)
                tablaNlab4.AddCell(cell57)

            End If
            i = i + 1
        End While


        Dim columna1 As New ColumnText(writer.DirectContent)
        columna1.AddElement(tablaNlab)

        columna1.SetSimpleColumn(documento.Left, documento.Bottom, documento.Right - 420, documento.Top - 25)
        columna1.Go()

        Dim columna2 As New ColumnText(writer.DirectContent)
        columna2.AddElement(tablaNlab2)

        columna2.SetSimpleColumn(documento.Left + 140, documento.Bottom, documento.Right - 282, documento.Top - 25)
        columna2.Go()

        Dim columna3 As New ColumnText(writer.DirectContent)
        columna3.AddElement(tablaNlab3)

        columna3.SetSimpleColumn(documento.Left + 280, documento.Bottom, documento.Right - 142, documento.Top - 25)
        columna3.Go()

        Dim columna4 As New ColumnText(writer.DirectContent)
        columna4.AddElement(tablaNlab4)

        columna4.SetSimpleColumn(documento.Left + 420, documento.Bottom, documento.Right, documento.Top - 25)
        columna4.Go()

        If i >= 128 Then
            generaNlabInfinito(documento, writer, filaLab, j)
        End If



    End Sub 'listo

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class


