
Imports Microsoft.Office.Interop


Module Modulo_Imprime_Nematodos
    Private OrdenEnResulatdos As Integer
    Private NOMBRE_PROD, NLAD, NLAH, ES_NOTA As String
    Private MATRIZ_AUX(6), MATRIZ_DAT_ANT(6), NomTdato, NomTIden, GProductor, GEmpresa, GFechaIngreso, GRemite, GLocalidad, GProvincia, GComuna, sTab As String
    Private Filas_Pagina, Maximo_columnas, notas, NLabDesde, NLabHasta As Integer
    Private Fila_Firma As Integer
    Private Fila_Merge As Integer
    Private Fila_Borde As Integer
    Private Fila_Pie As Integer
    Private Fila_Logo As Integer
    Private Fila_Nota As Integer
    Private IncFil As Integer
    Private Notas_Si As String
    Private FilaCua As Integer
    Private FilaVar As Integer
    Private FilaEdad As Integer
    Private FilaCAnt As Integer
    Private FilaCProx As Integer
    Private FilaCAct As Integer
    Private Fecha_Informe, Fecha_Ingreso, Fecha_Analisis, Fecha_Termino As Date
    Private Firma_Cargo1, Firma_Cargo2, Firma_Nombre1, Firma_Nombre2 As String
    Private Rango_Interpreta As Boolean = True
    Private RANGO_NEMA(4, 2) As String

    Public Sub Genera_Impresion_Nematodos(ByVal OTResultado As Integer, ByVal NLabD As Integer, ByVal NLabH As Integer)
        Dim Fila_Ciclo, Fila_Identifica, Fila_Identifica2, Fila_SubTit, Fila_Seleccion As DataRow
        Dim MATRIZ_AUX(9), fuente, destino, PRO As String
        Dim SALTO_PAGINA, Ciclo_Inicial, Revisa_Filas As Boolean
        Dim sAño, sRutaDest As String
        Dim BuscaEle(0) As Object

        Dim objLibroExcel As Excel.Workbook
        Dim m_Excel As Excel.Application
        Dim Hoja_Excel As Excel.Worksheet
        Dim Fila_Ini, Fila_Fin, pagina, Fila, Cuenta_Columnas, Cuantas_Filas As Integer
        OrdenEnResulatdos = OTResultado
        SALTO_PAGINA = False
        Call Busca_Datos_orden()
        Call Busca_Datos_Configuracion()
        fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formatos Resultados.xls"
        NLabDesde = NLabD
        NLabHasta = NLabH
        Filas_Pagina = 65

        NLAD = NLabDesde
        NLAH = "-" & Microsoft.VisualBasic.Right(CStr(NLabHasta), 3)
        If NLabDesde = NLabHasta Then NLAH = ""
        PRO = GProductor
        NOMBRE_PROD = GProductor
        sAño = CStr(Year(Now))
        If NLAH = "" Then NLAH = "       "
        sRutaDest = "F:\Mis Documentos\" + sAño + ".Nematodos-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        'sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".Nematodos-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"

        If Dir(sRutaDest, FileAttribute.Directory) = "" Then
            MkDir(sRutaDest)
        End If
        m_Excel = CreateObject("EXCEL.APPLICATION")
        'FileCopy(fuente, destino)
        objLibroExcel = m_Excel.Workbooks.Open(fuente)
        m_Excel.Visible = False 'Dejar en Falso
        Hoja_Excel = objLibroExcel.Worksheets(1)
        Hoja_Excel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        Hoja_Excel.Activate()
        Fila = Fila + 1
        pagina = 1
        Ciclo_Inicial = True
        Revisa_Filas = False
        Cuenta_Columnas = 0
        Cjto_Tablas1.Tables("NLAB_COLUMNAS_NEMA").Rows.Clear()
        Try
            For Each Fila_Ciclo In Cjto_Tablas1.Tables("TABLA_CICLO").Rows
                Cuenta_Columnas = Cuenta_Columnas + 1
                If Cuenta_Columnas = 1 Then
                    MATRIZ_DAT_ANT(1) = Fila_Ciclo("PREDIO")
                    MATRIZ_DAT_ANT(2) = Fila_Ciclo("LOCALIDAD")
                    MATRIZ_DAT_ANT(3) = Fila_Ciclo("FMUESTREO")
                    MATRIZ_DAT_ANT(4) = Fila_Ciclo("MUESTREADOR")
                End If
                'Call Revisa_Salto_Por_Encabezado(Fila_Ciclo, SALTO_PAGINA, Cuenta_Columnas)
                If Ciclo_Inicial = True Then Ciclo_Inicial = False : GoTo SaltoxCicloInicial
                'If SALTO_PAGINA = True Or Cuenta_Columnas > Maximo_columnas Then
                'Call Coloca_Columnas_Nematodos(Cuenta_Columnas)
                Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, Fila_Firma, OrdenEnResulatdos)
                Fila_Ini = Fila
                Call Imprime_Detalle(Hoja_Excel, Fila, m_Excel)
                Fila_Fin = Fila
                Call Imprime_Marco(Hoja_Excel, Fila_Ini, Fila_Fin)
                Revisa_Filas = True
                pagina = pagina + 1
                Cuenta_Columnas = 1
                MATRIZ_DAT_ANT(1) = Fila_Ciclo("PREDIO")
                MATRIZ_DAT_ANT(2) = Fila_Ciclo("LOCALIDAD")
                MATRIZ_DAT_ANT(3) = Fila_Ciclo("FMUESTREO")
                MATRIZ_DAT_ANT(4) = Fila_Ciclo("MUESTREADOR")
                Cjto_Tablas1.Tables("NLAB_COLUMNAS_NEMA").Rows.Clear()
                'End If
SaltoxCicloInicial:
                Fila_Identifica = Cjto_Tablas1.Tables("NLAB_COLUMNAS_NEMA").NewRow
                Fila_Identifica.Item("OT_NLAB") = Fila_Ciclo("OT_NLAB")
                Fila_Identifica.Item("COLUMNAD") = ""
                Fila_Identifica.Item("COLUMNAH") = ""
                Fila_Identifica.Item("COLUMNARD") = ""
                Fila_Identifica.Item("COLUMNARH") = ""
                Try
                    Cjto_Tablas1.Tables("NLAB_COLUMNAS_NEMA").Rows.Add(Fila_Identifica)
                Catch ex As Exception
                End Try
                SALTO_PAGINA = False
            Next

            Call Coloca_Columnas_Nematodos(Cuenta_Columnas)
            '*************************
            SALTO_PAGINA = True
            'Call Revisa_Salto_Por_Encabezado(Fila_Ciclo, SALTO_PAGINA, Cuenta_Columnas)
            Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, Fila_Firma, OrdenEnResulatdos)
            Fila_Ini = Fila
            Call Imprime_Detalle(Hoja_Excel, Fila, m_Excel)
            Fila_Fin = Fila
            Call Imprime_Marco(Hoja_Excel, Fila_Ini, Fila_Fin)
            Call Imprime_Firmas(Hoja_Excel, Fila_Firma)

            Call IMPRIME_NUMERO_PAGINAS(Hoja_Excel, pagina)
            m_Excel.Visible = True

            Try
                Hoja_Excel.Range("A8").Select()
                Hoja_Excel.SaveAs(destino)
            Catch ex As Exception
                objLibroExcel.Close(False, , )
                Hoja_Excel.Quit()
                m_Excel = Nothing
            End Try
        Catch ex As Exception
            'MsgBox("Primero debe generar el archivo")
        End Try
    End Sub

    Private Sub Busca_Datos_orden()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", OrdenEnResulatdos, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectOrden")
        End With

        Try
            If IsDBNull(ds.Tables(0).Rows(0).Item("PRO_PRODUCTOR")) = False Then
                GProductor = ds.Tables(0).Rows(0).Item("PRO_PRODUCTOR")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_EMPRESA")) = False Then
                GEmpresa = ds.Tables(0).Rows(0).Item("OT_EMPRESA")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_REMITE")) = False Then
                GRemite = ds.Tables(0).Rows(0).Item("OT_REMITE")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_PROVINCIA")) = False Then
                GProvincia = ds.Tables(0).Rows(0).Item("OT_PROVINCIA")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_COMUNA")) = False Then
                GComuna = ds.Tables(0).Rows(0).Item("OT_COMUNA")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Busca_Datos_Configuracion()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 8758, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectResultadosConfiguracion")
        End With

        Try
            If IsDBNull(ds.Tables(0).Rows(0).Item("RANGO")) = False Then
                If ds.Tables(0).Rows(0).Item("RANGO") = "1" Then
                    Rango_Interpreta = True
                Else
                    Rango_Interpreta = False
                End If
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE1")) = False Then
                Firma_Nombre1 = ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE1")
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE2")) = False Then
                Firma_Nombre2 = ds.Tables(0).Rows(0).Item("FIRMA_NOMBRE2")
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("FIRMA_CARGO1")) = False Then
                Firma_Cargo1 = ds.Tables(0).Rows(0).Item("FIRMA_CARGO1")
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("FIRMA_CARGO2")) = False Then
                Firma_Cargo2 = ds.Tables(0).Rows(0).Item("FIRMA_CARGO2")
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_INFORME")) = False Then
                Fecha_Informe = ds.Tables(0).Rows(0).Item("FECHA_INFORME")
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_INGRESO")) = False Then
                Fecha_Ingreso = ds.Tables(0).Rows(0).Item("FECHA_INGRESO")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_ANALISIS")) = False Then
                Fecha_Analisis = ds.Tables(0).Rows(0).Item("FECHA_ANALISIS")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("MUESTRA_PAGINA")) = False Then
                Maximo_columnas = ds.Tables(0).Rows(0).Item("MUESTRA_PAGINA")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Revisa_Salto_Por_Encabezado(ByVal FILA_SET As DataRow, ByRef SALTO_PAGINA As Boolean, ByVal CuentaC As Integer)

        If IsDBNull(FILA_SET("PREDIO")) Then FILA_SET("PREDIO") = ""
        If IsDBNull(FILA_SET("LOCALIDAD")) Then FILA_SET("LOCALIDAD") = ""
        If IsDBNull(FILA_SET("FMUESTREO")) Then FILA_SET("FMUESTREO") = ""
        If IsDBNull(FILA_SET("MUESTREADOR")) Then FILA_SET("MUESTREADOR") = ""

        If FILA_SET("PREDIO") <> MATRIZ_AUX(1) Then SALTO_PAGINA = True
        If FILA_SET("LOCALIDAD") <> MATRIZ_AUX(2) Then SALTO_PAGINA = True
        If FILA_SET("FMUESTREO") <> MATRIZ_AUX(3) Then SALTO_PAGINA = True
        If FILA_SET("MUESTREADOR") <> MATRIZ_AUX(4) Then SALTO_PAGINA = True

        If SALTO_PAGINA = True And CuentaC <> 1 Then
            MATRIZ_DAT_ANT(1) = MATRIZ_AUX(1)
            MATRIZ_DAT_ANT(2) = MATRIZ_AUX(2)
            MATRIZ_DAT_ANT(3) = MATRIZ_AUX(3)
            MATRIZ_DAT_ANT(4) = MATRIZ_AUX(4)
        End If


        MATRIZ_AUX(1) = FILA_SET("PREDIO")
        MATRIZ_AUX(2) = FILA_SET("LOCALIDAD")
        MATRIZ_AUX(3) = FILA_SET("FMUESTREO")
        MATRIZ_AUX(4) = FILA_SET("MUESTREADOR")
    End Sub


    Private Sub Coloca_Columnas_Nematodos(ByVal cuenord As Integer)
        Dim FILA_REC, FILA_REC2 As DataRow
        Dim CUFI As Integer = 1
        For Each FILA_REC In Cjto_Tablas1.Tables("NLAB_COLUMNAS_NEMA").Rows
            If cuenord < 3 Then
                Select Case CUFI
                    Case 1
                        FILA_REC("COLUMNAD") = "BD"
                        FILA_REC("COLUMNAH") = "BO"
                        FILA_REC("COLUMNARD") = "BP"
                        FILA_REC("COLUMNARH") = "BS"
                    Case 2
                        FILA_REC("COLUMNAD") = "BV"
                        FILA_REC("COLUMNAH") = "CG"
                        FILA_REC("COLUMNARD") = "CH"
                        FILA_REC("COLUMNARH") = "CK"
                End Select
            Else
                Select Case CUFI
                    Case 1
                        FILA_REC("COLUMNAD") = "AL"
                        FILA_REC("COLUMNAH") = "AW"
                        FILA_REC("COLUMNARD") = "AX"
                        FILA_REC("COLUMNARH") = "BA"
                    Case 2
                        FILA_REC("COLUMNAD") = "BD"
                        FILA_REC("COLUMNAH") = "BO"
                        FILA_REC("COLUMNARD") = "BP"
                        FILA_REC("COLUMNARH") = "BS"

                    Case 3
                        FILA_REC("COLUMNAD") = "BV"
                        FILA_REC("COLUMNAH") = "CG"
                        FILA_REC("COLUMNARD") = "CH"
                        FILA_REC("COLUMNARH") = "CK"

                    Case 4
                        FILA_REC("COLUMNAD") = "CN"
                        FILA_REC("COLUMNAH") = "CY"
                        FILA_REC("COLUMNARD") = "CZ"
                        FILA_REC("COLUMNARH") = "DC"

                End Select
            End If
            CUFI = CUFI + 1
        Next

        CUFI = 1
        For Each FILA_REC2 In Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows
            If cuenord < 3 Then
                Select Case CUFI
                    Case 1
                        'FILA_REC2("COLUMNAD_ENT") = "AW"
                        'FILA_REC2("COLUMNAH_ENT") = "BC"
                        'FILA_REC2("COLUMNA_COMA") = "BD"
                        'FILA_REC2("COLUMNAD_DEC") = "BE"
                        'FILA_REC2("COLUMNAH_DEC") = "BL"
                    Case 2
                        'FILA_REC2("COLUMNAD_ENT") = "BM"
                        'FILA_REC2("COLUMNAH_ENT") = "BS"
                        'FILA_REC2("COLUMNA_COMA") = "BT"
                        'FILA_REC2("COLUMNAD_DEC") = "BU"
                        'FILA_REC2("COLUMNAH_DEC") = "CB"
                End Select
            Else
                Select Case CUFI
                    Case 1
                        FILA_REC2("COLUMNAD_ENT") = "AG"
                        FILA_REC2("COLUMNAH_ENT") = "AM"
                        FILA_REC2("COLUMNA_COMA") = "AN"
                        FILA_REC2("COLUMNAD_DEC") = "AO"
                        FILA_REC2("COLUMNAH_DEC") = "AV"
                    Case 2
                        FILA_REC2("COLUMNAD_ENT") = "AW"
                        FILA_REC2("COLUMNAH_ENT") = "BC"
                        FILA_REC2("COLUMNA_COMA") = "BD"
                        FILA_REC2("COLUMNAD_DEC") = "BE"
                        FILA_REC2("COLUMNAH_DEC") = "BL"
                    Case 3
                        FILA_REC2("COLUMNAD_ENT") = "BM"
                        FILA_REC2("COLUMNAH_ENT") = "BS"
                        FILA_REC2("COLUMNA_COMA") = "BT"
                        FILA_REC2("COLUMNAD_DEC") = "BU"
                        FILA_REC2("COLUMNAH_DEC") = "CB"
                    Case 4
                        FILA_REC2("COLUMNAD_ENT") = "CC"
                        FILA_REC2("COLUMNAH_ENT") = "CI"
                        FILA_REC2("COLUMNA_COMA") = "CJ"
                        FILA_REC2("COLUMNAD_DEC") = "CK"
                        FILA_REC2("COLUMNAH_DEC") = "CR"
                End Select
            End If
            CUFI = CUFI + 1
        Next
    End Sub

    Private Sub Imprime_Encabezado(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pagina As Integer, ByRef fila As Integer, ByRef Fila_Firma As Integer, ByVal OTResultado As Integer)
        Dim VerNom, ColD, ColH, CuartelTotal, N1, N2, N3, N4, N5, N6 As String
        Dim BOLA2, BusIden As Object
        Dim FILA_HOMO, Fila_NColumnas, Fila_Iden As DataRow
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Fila_Notas As DataRow

        If pagina <> 1 Then
            Fila_Firma = 56 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Firma = 56
        End If

        If pagina <> 1 Then
            Fila_Nota = 58 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Nota = 58
        End If
        IncFil = 0

        With SP
            .Inicializar()
            .AgregarParametro("@Tmuestra", 8758, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectResultadosNotasxMuestra")
        End With

        For Each Fila_Notas In ds.Tables(0).Rows
            If Fila_Notas.Item("NOTA_POS") = "5" Then N1 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "6" Then N2 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "7" Then N3 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "8" Then N4 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "9" Then N5 = Fila_Notas.Item("NOTA_DESCRIPCION")
            'If Fila_Notas.Item("NOTA_POS") = "10" Then N6 = Fila_Notas.Item("NOTA_DESCRIPCION")
        Next

        '*********************************************************************************
        If MATRIZ_DAT_ANT(4) = "Muestra ingresada por cliente" Then
            N6 = "- Los resultados son válidos sólo para las muestras analizadas las cuales fueron proporcionadas por el cliente"
        Else
            N6 = "- Muestras ingresadas por el servicio de muestreo de Agrolab"
        End If

        If N1 <> "" Or N2 <> "" Or N3 <> "" Or N4 <> "" Or N5 <> "" Or N6 <> "" Then
            HOJA_EXCEL.Range("A" & Fila_Nota.ToString).Value = "Notas:"
            HOJA_EXCEL.Range("A" & Fila_Nota.ToString).Font.Bold = True
            HOJA_EXCEL.Range("A" & Fila_Nota.ToString).Font.Size = 9
            IncFil = IncFil + 1
        End If
        If N1 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = N1
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If N2 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = N2
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If N3 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = N3
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If N4 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = N4
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If N5 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = N5
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If N6 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = N6
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If

        '*********************************************************************************

        If pagina <> 1 Then
            Fila_Pie = Filas_Pagina + ((pagina - 1) * Filas_Pagina)
        Else
            Fila_Pie = Filas_Pagina
        End If
        HOJA_EXCEL.Range("A" & (Fila_Pie).ToString & ":DF" & (Fila_Pie).ToString).Merge()
        HOJA_EXCEL.Range("A" & (Fila_Pie).ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        HOJA_EXCEL.Range("A" & (Fila_Pie).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & (Fila_Pie).ToString).Font.Color = RGB(0, 0, 128)
        HOJA_EXCEL.Range("A" & (Fila_Pie).ToString & ":DF" & (Fila_Pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        If pagina <> 1 Then fila = ((pagina - 1) * Filas_Pagina) + 1

        If pagina <> 1 Then
            Fila_Logo = fila : HOJA_EXCEL.Range("A" & Fila_Logo.ToString).Select()
        Else
            Fila_Logo = 1 : HOJA_EXCEL.Range("A" & Fila_Logo.ToString).Select()
        End If

        HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\Logo  mediano Agro.jpg").Select()
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = "LABORATORIO AGRICOLA"
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        fila = fila + 1
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = "ANALISIS DE SUELO - FOLIAR - AGUA"
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 6
        'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        fila = fila + 2
        Fila_Merge = fila + 1
        HOJA_EXCEL.Range("AE" & fila.ToString).Value = "INFORME DE RESULTADOS  -"
        HOJA_EXCEL.Range("AE" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("AE" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AE" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        HOJA_EXCEL.Range("BK" & fila.ToString).Value = "Nº Orden:"
        HOJA_EXCEL.Range("BK" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BK" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        HOJA_EXCEL.Range("BV" & fila.ToString & ":CD" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CD" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("BV" & fila.ToString).Value = Format(CInt(OTResultado), "###,###")
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CD" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        fila = fila + 1
        HOJA_EXCEL.Range("AH" & fila.ToString & ":CA" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AH" & fila.ToString).Value = "ANALISIS NEMATOLOGICO"
        HOJA_EXCEL.Range("AH" & fila.ToString).Font.Size = 14
        HOJA_EXCEL.Range("AH" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AH" & fila.ToString & ":CA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AH" & fila.ToString & ":CA" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        fila = Fila_Merge
        'PRODUCTOR
        fila = fila + 3
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Productor"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = GProductor
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'EMPRESA
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Empresa"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        VerNom = GEmpresa
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'Predio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Predio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = MATRIZ_DAT_ANT(1)
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'Remite
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Remite"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        VerNom = GRemite
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'PROVINCIA
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Provincia"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = GProvincia
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        ''Muestraedor
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Muestreador"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CF" & fila.ToString & ":DF" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = MATRIZ_DAT_ANT(4)
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":DF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'COMUNA
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Comuna"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = GComuna
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        HOJA_EXCEL.Range("M" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Muestreo
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha muestreo"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = MATRIZ_DAT_ANT(3)
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Ingreso
        HOJA_EXCEL.Range("CP" & fila.ToString).Value = "F.ingreso"
        HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CX" & fila.ToString).Value = Fecha_Ingreso
        HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'Localidad
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Localidad"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = MATRIZ_DAT_ANT(2)
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        HOJA_EXCEL.Range("M" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Analisis
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha análisis"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = Fecha_Analisis
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Informe
        HOJA_EXCEL.Range("CP" & fila.ToString).Value = "F.informe"
        HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CX" & fila.ToString).Value = Fecha_Informe
        HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'pag
        fila = fila + 1
        HOJA_EXCEL.Range("CY" & fila.ToString).Value = "Pág."
        HOJA_EXCEL.Range("CY" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CY" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        'CUARTEL
        fila = fila + 1 : FilaCua = fila
        Fila_Borde = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Identificación Cuartel"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Cultivo anterior
        fila = fila + 2 : FilaCAnt = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Cultivo anterior"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Cultivo actual
        FilaCAct = fila
        HOJA_EXCEL.Range("AX" & fila.ToString).Value = "Cultivo actual"
        HOJA_EXCEL.Range("AX" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BL" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("BL" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("BL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Cultivo proximo
        fila = fila + 1 : FilaCProx = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Cultivo próximo"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        ''Variedad
        'fila = fila + 1 : FilaVar = fila
        'HOJA_EXCEL.Range("H" & fila.ToString).Value = "Variedad"
        'HOJA_EXCEL.Range("H" & fila.ToString).Font.Size = 9
        'HOJA_EXCEL.Range("H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        'HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'EDAD
        FilaEdad = fila
        HOJA_EXCEL.Range("AX" & fila.ToString).Value = "Edad"
        HOJA_EXCEL.Range("AX" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BL" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("BL" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("BL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'n°laboratorio
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "N° de Laboratorio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        ' imprime identificacion *************

        For Each Fila_NColumnas In Cjto_Tablas1.Tables("NLAB_COLUMNAS_NEMA").Rows
            ColD = Fila_NColumnas("COLUMNAD")
            ColH = Fila_NColumnas("COLUMNAH")
            BusIden = Fila_NColumnas("OT_NLAB")
            Fila_Iden = Cjto_Tablas1.Tables("TABLA_CICLO").Rows.Find(BusIden)
            CuartelTotal = Fila_Iden("IDENTIFICACION1") & " " & Fila_Iden("IDENTIFICACION2")
            'HOJA_EXCEL.Range("AC" & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).Merge()
            HOJA_EXCEL.Range("AC" & FilaCua.ToString).Value = CuartelTotal
            HOJA_EXCEL.Range("AC" & FilaCua.ToString).Font.Size = 8
            HOJA_EXCEL.Range("AC" & FilaCua.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'HOJA_EXCEL.Range("AC" & FilaCAnt.ToString & ":" & ColH & FilaCAnt.ToString).Merge()
            HOJA_EXCEL.Range("AC" & FilaCAnt.ToString).Value = Fila_Iden("CAMPO1")
            HOJA_EXCEL.Range("AC" & FilaCAnt.ToString).Font.Size = 8
            HOJA_EXCEL.Range("AC" & FilaCAnt.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'HOJA_EXCEL.Range("BM" & FilaCAct.ToString & ":" & ColH & FilaCAct.ToString).Merge()
            HOJA_EXCEL.Range("BM" & FilaCAct.ToString).Value = Fila_Iden("CAMPO2")
            HOJA_EXCEL.Range("BM" & FilaCAct.ToString).Font.Size = 8
            HOJA_EXCEL.Range("BM" & FilaCAct.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'HOJA_EXCEL.Range("AC" & FilaCProx.ToString & ":" & ColH & FilaEdad.ToString).Merge()
            HOJA_EXCEL.Range("AC" & FilaCProx.ToString).Value = Fila_Iden("CAMPO3")
            HOJA_EXCEL.Range("AC" & FilaCProx.ToString).Font.Size = 8
            HOJA_EXCEL.Range("AC" & FilaCProx.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'HOJA_EXCEL.Range(ColD & FilaVar.ToString & ":" & ColH & FilaVar.ToString).Merge()
            'HOJA_EXCEL.Range(ColD & FilaVar.ToString).Value = Fila_Iden("CAMPO4")
            'HOJA_EXCEL.Range(ColD & FilaVar.ToString).Font.Size = 8
            'HOJA_EXCEL.Range(ColD & FilaVar.ToString & ":" & ColH & FilaVar.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'HOJA_EXCEL.Range(ColD & FilaVar.ToString & ":" & ColH & FilaVar.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            'HOJA_EXCEL.Range("BM" & FilaEdad.ToString & ":" & ColH & FilaEdad.ToString).Merge()
            HOJA_EXCEL.Range("BM" & FilaEdad.ToString).Value = Fila_Iden("CAMPO5")
            HOJA_EXCEL.Range("BM" & FilaEdad.ToString).Font.Size = 8
            HOJA_EXCEL.Range("BM" & FilaEdad.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("AC" & fila.ToString & ":AJ" & fila.ToString).Merge()
            HOJA_EXCEL.Range("AC" & fila.ToString).Value = Fila_NColumnas("OT_NLAB")
            HOJA_EXCEL.Range("AC" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        Next
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "1.- EN SUELO : Género y/o especie de nemátodos en el suelo   (N° ejemplares / 250 g suelo )"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("A" & fila.ToString & ":DF" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("A" & fila.ToString & ":DF" & fila.ToString).Interior.Color = RGB(192, 192, 192)

        HOJA_EXCEL.Range("A" & Fila_Borde.ToString & ":DF" & fila.ToString).BorderAround()
        fila = fila + 1
    End Sub

    Private Sub Imprime_Detalle(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef Fila As Integer, ByVal ExcelA As Excel.Application)
        Dim Fila_Nema, Fila_Nlab As DataRow
        Dim Encontro As Boolean
        Dim COLD, COLH, COLRD, COLRH, Masd, Mascara, sQuery, sSubTit_Comp As String
        Dim COLD_ENT, COLH_ENT, COL_COMA, COLD_DEC, COLH_DEC As String
        Dim peq, CDecimales, Fila_Ini, PosicionParen As Integer
        Dim CONTADOR_NEMA As Integer = 0

        Dim Resultado, Nivel As String
        Dim ds As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        ReDim RANGO_NEMA(4, 2)
        Masd = "0000"
        sSubTit_Comp = ""
        Fila_Ini = Fila
        peq = 0

        For Each Fila_Nlab In Cjto_Tablas1.Tables("NLAB_COLUMNAS_NEMA").Rows
            Fila = Fila_Ini
            COLD = Fila_Nlab("COLUMNAD")
            COLH = Fila_Nlab("COLUMNAH")
            COLRD = Fila_Nlab("COLUMNARD")
            COLRH = Fila_Nlab("COLUMNARH")

            CONTADOR_NEMA = CONTADOR_NEMA + 1

            With SP
                .Inicializar()
                .AgregarParametro("@NLab", Fila_Nlab("OT_NLAB"), SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectNematodos")
            End With

            'Fila_Nema = ds.Tables(0).Rows(0)

            'If IsDBNull(Fila_Nema("OBSERVACION")) = False Then
            'RANGO_NEMA(CONTADOR_NEMA, 1) = CStr(Fila_Nlab("OT_NLAB"))
            'RANGO_NEMA(CONTADOR_NEMA, 2) = CStr(Fila_Nema("OBSERVACION"))
            'Else
            RANGO_NEMA(CONTADOR_NEMA, 1) = CStr(Fila_Nlab("OT_NLAB"))
            RANGO_NEMA(CONTADOR_NEMA, 2) = ""
            'End If

            'Fila = Fila + 1

            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Anguina tritici"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Meloidogyne (larvas)"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Aphelenchus"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Mesocriconema"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Aphelenchoides"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Paratylenchus"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Criconema"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Pratylenchus"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Diphtherophora"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Radopholus similis"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Ditylenchus destructor"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Rotylenchus"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Ditylenchus dipsaci"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Trichodorus"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Globodera (larvas, quistes)"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Tylenchorhynchus"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Helicotylenchus"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Tylenchulus semipenetrans"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Hemicycliophora"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Tylenchus "
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Heterodera"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Xiphinema americanum"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Hoplolaimus"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Xiphinema index"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Longidorus"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Otros"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '------------
            Fila = Fila + 1
            With HOJA_EXCEL.Range("A" & Fila.ToString & ":DF" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Saprófitos"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            With HOJA_EXCEL.Range("A" & Fila.ToString & ":DF" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With


            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":DF" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "2.- EN RAÍCES, BULBOS, TUBERCULOS, ETC: Género y/o especie de nemátodos (N° ejemplares / 10 g material vegetal)"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("A" & Fila.ToString & ":DF" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            HOJA_EXCEL.Range("A" & Fila.ToString & ":DF" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            HOJA_EXCEL.Range("A" & Fila.ToString & ":DF" & Fila.ToString).BorderAround()
            HOJA_EXCEL.Range("A" & Fila.ToString & ":DF" & Fila.ToString).Interior.Color = RGB(192, 192, 192)

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Anguina tritici"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Heterodera (larvas, quistes)"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()


            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Aphelenchoides"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Meloidogyne (larvas o hembras)"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Aphelenchus"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Pratylenchus"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Ditylenchus destructor"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Radopholus similis"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Ditylenchus dipsaci"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Tylenchulus semipenetrans"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.FontStyle = "Cursiva"
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            '--------------------
            Fila = Fila + 1
            HOJA_EXCEL.Range("A" & Fila.ToString & ":" & "AI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Globodera (larvas, quistes)"
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            Call Imprime_Borde(HOJA_EXCEL, Fila)
            HOJA_EXCEL.Range("AK" & Fila.ToString & ":" & "AQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AR" & Fila.ToString & ":" & "AV" & Fila.ToString).Merge()

            HOJA_EXCEL.Range("AX" & Fila.ToString & ":" & "CS" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AX" & Fila.ToString).Value = "Otros"
            HOJA_EXCEL.Range("AX" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CT" & Fila.ToString & ":" & "CZ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DA" & Fila.ToString & ":" & "DE" & Fila.ToString).Merge()

            Exit For
        Next
        Call Notas_Automaticas(HOJA_EXCEL, Fila)
        Call Imprime_Firmas(HOJA_EXCEL, Fila_Firma)
    End Sub

    Public Sub Notas_Automaticas(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal Fila_Fin As Integer)
        Dim FILA_NOTA, FILA_HOMO As DataRow
        Dim BOLA, BOLA1 As Object
        Dim varmer, largoco, k, NumNota As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Fila_Notas As DataRow
        Dim O1, O2, O3, O4 As String

        'With SP
        '    .Inicializar()
        '    .AgregarParametro("@Tmuestra", 8000, SqlDbType.Int)
        '    ds = .EjecutarQuery("usp_SelectResultadosNotasxMuestra")
        'End With

        'For Each Fila_Notas In ds.Tables(0).Rows
        '    If Fila_Notas.Item("NOTA_POS") = "1" Then O1 = Fila_Notas.Item("NOTA_DESCRIPCION")
        '    If Fila_Notas.Item("NOTA_POS") = "2" Then O2 = Fila_Notas.Item("NOTA_DESCRIPCION")
        '    If Fila_Notas.Item("NOTA_POS") = "3" Then O3 = Fila_Notas.Item("NOTA_DESCRIPCION")
        '    If Fila_Notas.Item("NOTA_POS") = "4" Then O4 = Fila_Notas.Item("NOTA_DESCRIPCION")
        'Next

        'Fila_Fin = Fila_Fin + 1

        'HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin).ToString).Merge()
        'HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Value = "Nivel de infestación del nemátodo:                        B = Bajo                        M = Medio                        A = Alto"
        'HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        'HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        varmer = 0

        Fila_Fin = Fila_Fin + 2

        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Value = "Interpretación de resultados"
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        Fila_Fin = Fila_Fin + 2

        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":AK" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Value = "1.- En Suelo :"
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":AK" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString & ":AP" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString).Value = "Leve"
        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString & ":AP" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        Call Imprime_Subraya(HOJA_EXCEL, Fila_Fin, "AR", "AZ")

        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString & ":BI" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString).Value = "Medio"
        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString & ":BI" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        Call Imprime_Subraya(HOJA_EXCEL, Fila_Fin, "BK", "BS")

        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString & ":CB" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString).Value = "Severo"
        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString & ":CB" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        Call Imprime_Subraya(HOJA_EXCEL, Fila_Fin, "CD", "CL")


        Fila_Fin = Fila_Fin + 2

        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":AK" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Value = "2.- En raíces, bulbos, tubérculos, etc :"
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":AK" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString & ":AP" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString).Value = "Leve"
        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("AL" & (Fila_Fin).ToString & ":AP" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        Call Imprime_Subraya(HOJA_EXCEL, Fila_Fin, "AR", "AZ")

        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString & ":BI" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString).Value = "Medio"
        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("BD" & (Fila_Fin).ToString & ":BI" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        Call Imprime_Subraya(HOJA_EXCEL, Fila_Fin, "BK", "BS")

        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString & ":CB" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString).Value = "Severo"
        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("BV" & (Fila_Fin).ToString & ":CB" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        Call Imprime_Subraya(HOJA_EXCEL, Fila_Fin, "CD", "CL")


        Fila_Fin = Fila_Fin + 2

        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":AK" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Value = "Observaciones"
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":AK" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


    End Sub
    Private Function RescataNivel(ByVal NombreNema As String, ByVal ResulNema As Double) As String
        Dim ds As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Nema As DataRow
        Dim NivelNema As String = ""

        With SP
            .Inicializar()
            .AgregarParametro("@NombreNema", NombreNema, SqlDbType.NVarChar)
            ds = .EjecutarQuery("usp_SelectNivelNematodos")
        End With

        For Each Fila_Nema In ds.Tables(0).Rows
            If (ResulNema >= Fila_Nema("NEMANT_DESDE")) And (ResulNema <= Fila_Nema("NEMANT_HASTA")) Then
                NivelNema = Fila_Nema("NEMANT_NIVEL")
                Exit For
            End If
        Next

        Return NivelNema

    End Function

    Private Sub Imprime_Marco(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal Fila_Ini As Integer, ByVal Fila_Fin As Integer)
        HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
    End Sub
    Private Sub Imprime_Borde(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal FilaB As Integer)
        With HOJA_EXCEL.Range("AW" & FilaB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlThin
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        With HOJA_EXCEL.Range("AW" & FilaB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlThin
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & FilaB.ToString & ":DF" & FilaB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Private Sub Imprime_Subraya(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal FilaB As Integer, ByVal Col1 As String, ByVal Col2 As String)
        With HOJA_EXCEL.Range(Col1 & FilaB.ToString & ":" & Col2 & FilaB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlThin
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Public Sub IMPRIME_NUMERO_PAGINAS(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pag As Integer)
        Dim NUM_PAG, TOT_PAG, jy, filP, ult_fin, pos_pag As Integer
        Dim junto As String
        ult_fin = pag - 1
        pos_pag = 14
        For jy = 1 To pag
            If jy = 1 Then filP = pos_pag
            If jy <> 1 Then filP = pos_pag + (Filas_Pagina * (jy - 1))
            junto = CStr(jy & "/" & pag)
            'HOJA_EXCEL.Range("DD" & filP.ToString & ":DF" & filP.ToString).NumberFormat = "Texto"
            HOJA_EXCEL.Range("DC" & filP.ToString).Value = "'" & CStr(junto)
            HOJA_EXCEL.Range("DC" & filP.ToString).Font.Size = 7
            HOJA_EXCEL.Range("DC" & filP.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
            HOJA_EXCEL.Range("DC" & filP.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Next
    End Sub

    Private Sub Imprime_Firmas(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila_firma As Integer)
        If Firma_Nombre2 <> "" Then
            Fila_Firma = Fila_Firma - 4
            HOJA_EXCEL.Range("BJ" & Fila_Firma.ToString).Select()
            HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\firma_resultado.jpg").Select()
            Fila_Firma = Fila_Firma + 4
            HOJA_EXCEL.Range("G" & fila_firma.ToString & ":BF" & fila_firma.ToString).Merge()
            HOJA_EXCEL.Range("G" & fila_firma.ToString).Value = Firma_Nombre2
            HOJA_EXCEL.Range("G" & fila_firma.ToString & ":BF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("G" & fila_firma.ToString).Font.Size = 9

            HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString & ":BF" & (fila_firma + 1).ToString).Merge()
            HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString).Value = Firma_Cargo2
            HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString & ":BF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString).Font.Size = 9

            HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).Merge()
            HOJA_EXCEL.Range("BG" & fila_firma.ToString).Value = Firma_Nombre1
            HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("BG" & fila_firma.ToString).Font.Size = 9

            HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).Merge()
            HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Value = Firma_Cargo1
            HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Font.Size = 9

        End If
        fila_firma = fila_firma - 4
        HOJA_EXCEL.Range("BJ" & fila_firma.ToString).Select()
        HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\firma_resultado.jpg").Select()
        fila_firma = fila_firma + 4
        HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).Merge()
        HOJA_EXCEL.Range("BG" & fila_firma.ToString).Value = "Héctor González Rodriguez"
        HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BG" & fila_firma.ToString).Font.Size = 9

        HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).Merge()
        HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Value = "Ingeniero Agrónomo Nematólogo"
        HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Font.Size = 9
    End Sub

    Private Sub CambioLetra(ByVal ExcelA As Excel.Application, ByVal Nombre As String, ByVal PoscicionParen As Integer, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal filaCambio As Integer)
        HOJA_EXCEL.Range("A" & filaCambio.ToString).Select()
        With ExcelA.ActiveCell.Characters(Start:=PoscicionParen, Length:=Len(Nombre)).Font
            .ColorIndex = 1
            .Name = "Courier New"
            .FontStyle = "Normal"
            .Size = 7
        End With
    End Sub


End Module
