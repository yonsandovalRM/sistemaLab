Imports Microsoft.Office.Interop

Module Modulo_Imprime_Bactereologicos
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
    Private FilaOri As Integer
    Private FilaEdad As Integer
    Private Fecha_Informe, Fecha_Ingreso, Fecha_Analisis, Fecha_Termino As Date
    Private Firma_Cargo1, Firma_Cargo2, Firma_Nombre1, Firma_Nombre2 As String
    Private Rango_Interpreta As Boolean = True

    Public Sub Genera_Impresion_Bactereologicos(ByVal OTResultado As Integer, ByVal NLabD As Integer, ByVal NLabH As Integer)
        Dim Fila_Ciclo, Fila_Identifica, Fila_Identifica2, Fila_SubTit, Fila_Seleccion As DataRow
        Dim MATRIZ_AUX(9), fuente, destino, PRO As String
        Dim SALTO_PAGINA, Ciclo_Inicial, Revisa_Filas As Boolean
        Dim sA�o, sRutaDest As String
        Dim BuscaEle(0) As Object
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Retorno As Integer


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
        sA�o = CStr(Year(Now))
        If NLAH = "" Then NLAH = "       "
        Retorno = 1
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", NLabD, SqlDbType.Int)
            Retorno = .EjecutarEscalar("usp_SelectBuscaNLabOtrasOrden")
        End With
        If Retorno = 1 Then
            sRutaDest = "F:\Mis Documentos\" + sA�o + ".Bactereologicos-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        Else
            sRutaDest = "F:\Mis Documentos\" + sA�o + ".Bactereologicos-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & " NumOrden " & OrdenEnResulatdos & ".xls"
        End If
        'sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sA�o + ".Bactereologicos-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"

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
        Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows.Clear()
        Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows.Clear()
        Try
            For Each Fila_Ciclo In Cjto_Tablas1.Tables("TABLA_CICLO").Rows
                Cuenta_Columnas = Cuenta_Columnas + 1
                If Cuenta_Columnas = 1 Then
                    MATRIZ_DAT_ANT(1) = Fila_Ciclo("PREDIO")
                    MATRIZ_DAT_ANT(2) = Fila_Ciclo("LOCALIDAD")
                    MATRIZ_DAT_ANT(3) = Fila_Ciclo("FMUESTREO")
                    MATRIZ_DAT_ANT(4) = Fila_Ciclo("MUESTREADOR")
                    MATRIZ_DAT_ANT(5) = Fila_Ciclo("CAMPO1")
                End If
                Call Revisa_Salto_Por_Encabezado(Fila_Ciclo, SALTO_PAGINA)
                If Ciclo_Inicial = True Then Ciclo_Inicial = False : GoTo SaltoxCicloInicial
                If SALTO_PAGINA = True Or Cuenta_Columnas > Maximo_columnas Then
                    Call Coloca_Columnas_Bactereologicos(Cuenta_Columnas)
                    Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, Fila_Firma, OrdenEnResulatdos)
                    Fila_Ini = Fila
                    Call Imprime_Detalle(Hoja_Excel, Fila, m_Excel, OTResultado)
                    Fila_Fin = Fila - 1
                    Call Imprime_Marco(Hoja_Excel, Fila_Ini, Fila_Fin)
                    Revisa_Filas = True
                    pagina = pagina + 1
                    Cuenta_Columnas = 1
                    MATRIZ_DAT_ANT(1) = Fila_Ciclo("PREDIO")
                    MATRIZ_DAT_ANT(2) = Fila_Ciclo("LOCALIDAD")
                    MATRIZ_DAT_ANT(3) = Fila_Ciclo("FMUESTREO")
                    MATRIZ_DAT_ANT(4) = Fila_Ciclo("MUESTREADOR")
                    MATRIZ_DAT_ANT(5) = Fila_Ciclo("CAMPO1")
                    Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows.Clear()
                    Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows.Clear()
                End If
SaltoxCicloInicial:
                Fila_Identifica = Cjto_Tablas1.Tables("NLAB_COLUMNAS").NewRow
                Fila_Identifica.Item("OT_NLAB") = Fila_Ciclo("OT_NLAB")
                Fila_Identifica.Item("COLUMNAD") = ""
                Fila_Identifica.Item("COLUMNAH") = ""
                Fila_Identifica2 = Cjto_Resultados1.Tables("NLAB_COLUMNAS").NewRow
                Fila_Identifica2.Item("OT_NLAB") = Fila_Ciclo("OT_NLAB")
                Fila_Identifica2.Item("COLUMNAD_ENT") = ""
                Fila_Identifica2.Item("COLUMNAH_ENT") = ""
                Fila_Identifica2.Item("COLUMNA_COMA") = ""
                Fila_Identifica2.Item("COLUMNAD_DEC") = ""
                Fila_Identifica2.Item("COLUMNAH_DEC") = ""
                Try
                    Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows.Add(Fila_Identifica)
                    Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows.Add(Fila_Identifica2)
                Catch ex As Exception
                End Try
                SALTO_PAGINA = False
            Next

            Call Coloca_Columnas_Bactereologicos(Cuenta_Columnas)
            '*************************
            SALTO_PAGINA = True
            Call Revisa_Salto_Por_Encabezado(Fila_Ciclo, SALTO_PAGINA)
            Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, Fila_Firma, OrdenEnResulatdos)
            Fila_Ini = Fila
            Call Imprime_Detalle(Hoja_Excel, Fila, m_Excel, OTResultado)
            Fila_Fin = Fila - 1
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
            .AgregarParametro("@TMuestra", 3600, SqlDbType.Int)
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

    Public Sub Revisa_Salto_Por_Encabezado(ByVal FILA_SET As DataRow, ByRef SALTO_PAGINA As Boolean)

        If IsDBNull(FILA_SET("PREDIO")) Then FILA_SET("PREDIO") = ""
        If IsDBNull(FILA_SET("LOCALIDAD")) Then FILA_SET("LOCALIDAD") = ""
        If IsDBNull(FILA_SET("FMUESTREO")) Then FILA_SET("FMUESTREO") = ""
        If IsDBNull(FILA_SET("MUESTREADOR")) Then FILA_SET("MUESTREADOR") = ""
        If IsDBNull(FILA_SET("CAMPO1")) Then FILA_SET("CAMPO1") = ""

        If FILA_SET("PREDIO") <> MATRIZ_AUX(1) Then SALTO_PAGINA = True
        If FILA_SET("LOCALIDAD") <> MATRIZ_AUX(2) Then SALTO_PAGINA = True
        If FILA_SET("FMUESTREO") <> MATRIZ_AUX(3) Then SALTO_PAGINA = True
        If FILA_SET("MUESTREADOR") <> MATRIZ_AUX(4) Then SALTO_PAGINA = True
        If FILA_SET("CAMPO1") <> MATRIZ_AUX(5) Then SALTO_PAGINA = True


        If SALTO_PAGINA = True Then
            MATRIZ_DAT_ANT(1) = MATRIZ_AUX(1)
            MATRIZ_DAT_ANT(2) = MATRIZ_AUX(2)
            MATRIZ_DAT_ANT(3) = MATRIZ_AUX(3)
            MATRIZ_DAT_ANT(4) = MATRIZ_AUX(4)
            MATRIZ_DAT_ANT(5) = MATRIZ_AUX(5)
        End If


        MATRIZ_AUX(1) = FILA_SET("PREDIO")
        MATRIZ_AUX(2) = FILA_SET("LOCALIDAD")
        MATRIZ_AUX(3) = FILA_SET("FMUESTREO")
        MATRIZ_AUX(4) = FILA_SET("MUESTREADOR")
        MATRIZ_AUX(5) = FILA_SET("CAMPO1")

    End Sub


    Private Sub Coloca_Columnas_Bactereologicos(ByVal cuenord As Integer)
        Dim FILA_REC, FILA_REC2 As DataRow
        Dim CUFI As Integer = 1
        For Each FILA_REC In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
            If cuenord < 2 Then
                Select Case CUFI
                    Case 1
                        FILA_REC("COLUMNAD") = "BD"
                        FILA_REC("COLUMNAH") = "BS"
                    Case 2
                        FILA_REC("COLUMNAD") = "BV"
                        FILA_REC("COLUMNAH") = "CK"
                End Select
            Else
                Select Case CUFI
                    Case 1
                        FILA_REC("COLUMNAD") = "AL"
                        FILA_REC("COLUMNAH") = "BA"
                    Case 2
                        FILA_REC("COLUMNAD") = "BD"
                        FILA_REC("COLUMNAH") = "BS"
                    Case 3
                        FILA_REC("COLUMNAD") = "BV"
                        FILA_REC("COLUMNAH") = "CK"
                    Case 4
                        FILA_REC("COLUMNAD") = "CN"
                        FILA_REC("COLUMNAH") = "DC"
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
            Fila_Firma = 55 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Firma = 55
        End If

        If pagina <> 1 Then
            Fila_Nota = 58 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Nota = 58
        End If
        IncFil = 0

        With SP
            .Inicializar()
            .AgregarParametro("@Tmuestra", 3600, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectResultadosNotasxMuestra")
        End With

        For Each Fila_Notas In ds.Tables(0).Rows
            If Fila_Notas.Item("NOTA_POS") = "5" Then N1 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "6" Then N2 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "7" Then N3 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "8" Then N4 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "9" Then N5 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "10" Then N6 = Fila_Notas.Item("NOTA_DESCRIPCION")
        Next

        '*********************************************************************************

        If N1 <> "" Or N2 <> "" Or N3 <> "" Or N4 <> "" Or N5 <> "" Or N6 <> "" Then
            HOJA_EXCEL.Range("A" & Fila_Nota.ToString).Value = "Notas:"
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
        HOJA_EXCEL.Range("A" & (Fila_Pie).ToString).Value = "Jos� Domingo Ca�as # 2914   -   Santiago   -   Tel�fono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
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


        HOJA_EXCEL.Range("BK" & fila.ToString).Value = "N� Orden:"
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
        HOJA_EXCEL.Range("AF" & fila.ToString & ":CB" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AF" & fila.ToString).Value = "ANALISIS BACTERIOLOGICO"
        HOJA_EXCEL.Range("AF" & fila.ToString).Font.Size = 14
        HOJA_EXCEL.Range("AF" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AF" & fila.ToString & ":CB" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AF" & fila.ToString & ":CB" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        fila = Fila_Merge
        'PRODUCTOR
        fila = fila + 3
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Productor"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = GProductor
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("L" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 10
        'EMPRESA
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Empresa"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        VerNom = GEmpresa
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("CE" & fila.ToString).Font.Size = 10
        'Predio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Predio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = MATRIZ_DAT_ANT(1)
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("L" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 10
        'Remite
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Remite"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        VerNom = GRemite
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("CE" & fila.ToString).Font.Size = 10
        'PROVINCIA
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Provincia"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = GProvincia
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("L" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 10
        'Muestraedor
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Muestreador"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CE" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = MATRIZ_DAT_ANT(4)
        HOJA_EXCEL.Range("CE" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CE" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString & ":DF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'COMUNA
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Comuna"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = GComuna
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("L" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("L" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        HOJA_EXCEL.Range("L" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Muestreo
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha muestreo"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = MATRIZ_DAT_ANT(3)
        HOJA_EXCEL.Range("CE" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Ingreso
        HOJA_EXCEL.Range("CO" & fila.ToString).Value = "F.ingreso"
        HOJA_EXCEL.Range("CO" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CO" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

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
        HOJA_EXCEL.Range("L" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("L" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        HOJA_EXCEL.Range("L" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Analisis
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha an�lisis"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = Fecha_Analisis
        HOJA_EXCEL.Range("CE" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString & ":CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Informe
        HOJA_EXCEL.Range("CO" & fila.ToString).Value = "F.informe"
        HOJA_EXCEL.Range("CO" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CO" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CX" & fila.ToString).Value = Fecha_Informe
        HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'Tipo de Muestra
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Tipo de Muestra"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("R" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("R" & fila.ToString).Font.Size = 10

        HOJA_EXCEL.Range("T" & fila.ToString).Value = "Agua"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        HOJA_EXCEL.Range("T" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'pag
        HOJA_EXCEL.Range("CY" & fila.ToString).Value = "P�g."
        HOJA_EXCEL.Range("CY" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CY" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        fila = fila + 1 : FilaCua = fila
        Fila_Borde = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Identificaci�n muestra"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'If Rango_Interpreta = True Then
        '    HOJA_EXCEL.Range("CJ" & fila.ToString & ":CU" & fila.ToString).Merge()
        '    HOJA_EXCEL.Range("CJ" & fila.ToString).Value = "Interpretaci�n"
        '    HOJA_EXCEL.Range("CJ" & fila.ToString).Font.Size = 8
        '    HOJA_EXCEL.Range("CJ" & fila.ToString & ":CU" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("CJ" & fila.ToString & ":CU" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '    HOJA_EXCEL.Range("CJ" & (fila + 1).ToString & ":CU" & (fila + 1).ToString).Merge()
        '    HOJA_EXCEL.Range("CJ" & (fila + 1).ToString).Value = "NCh409"
        '    HOJA_EXCEL.Range("CJ" & (fila + 1).ToString).Font.Size = 7
        '    HOJA_EXCEL.Range("CJ" & (fila + 1).ToString & ":CU" & (fila + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("CJ" & (fila + 1).ToString & ":CU" & (fila + 1).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '    HOJA_EXCEL.Range("CJ" & (fila + 2).ToString & ":CU" & (fila + 2).ToString).Merge()
        '    HOJA_EXCEL.Range("CJ" & (fila + 2).ToString).Value = "Limite m�ximo"
        '    HOJA_EXCEL.Range("CJ" & (fila + 2).ToString).Font.Size = 7
        '    HOJA_EXCEL.Range("CJ" & (fila + 2).ToString & ":CU" & (fila + 2).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("CJ" & (fila + 2).ToString & ":CU" & (fila + 2).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '    HOJA_EXCEL.Range("CJ" & (fila + 3).ToString & ":CU" & (fila + 3).ToString).Merge()
        '    HOJA_EXCEL.Range("CJ" & (fila + 3).ToString).Value = "'" & "(1)"
        '    HOJA_EXCEL.Range("CJ" & (fila + 3).ToString).Font.Size = 7
        '    HOJA_EXCEL.Range("CJ" & (fila + 3).ToString & ":CU" & (fila + 3).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("CJ" & (fila + 3).ToString & ":CU" & (fila + 3).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '    HOJA_EXCEL.Range("CV" & (fila).ToString & ":DF" & (fila + 3).ToString).Merge()
        '    HOJA_EXCEL.Range("CV" & (fila).ToString).Value = "M�todo"
        '    HOJA_EXCEL.Range("CV" & (fila).ToString).Font.Size = 8
        '    HOJA_EXCEL.Range("CV" & (fila).ToString & ":DF" & (fila + 3).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("CV" & (fila).ToString & ":DF" & (fila + 3).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '    With HOJA_EXCEL.Range("CJ" & (fila).ToString & ":CU" & (fila + 3).ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
        '        .LineStyle = Excel.XlLineStyle.xlContinuous
        '        .Weight = Excel.XlBorderWeight.xlHairline
        '        .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        '    End With

        'End If
        'Origen
        fila = fila + 2 : FilaOri = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Origen"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'n�laboratorio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "N� de Laboratorio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        ' imprime identificacion *************

        For Each Fila_NColumnas In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
            ColD = Fila_NColumnas("COLUMNAD")
            ColH = Fila_NColumnas("COLUMNAH")
            BusIden = Fila_NColumnas("OT_NLAB")
            Fila_Iden = Cjto_Tablas1.Tables("TABLA_CICLO").Rows.Find(BusIden)
            CuartelTotal = Fila_Iden("IDENTIFICACION1") & " " & Fila_Iden("IDENTIFICACION2")

            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).Merge()
            HOJA_EXCEL.Range(ColD & FilaCua.ToString).Value = CuartelTotal
            HOJA_EXCEL.Range(ColD & FilaCua.ToString).Font.Size = 8
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).WrapText = True

            HOJA_EXCEL.Range(ColD & FilaOri.ToString & ":" & ColH & FilaOri.ToString).Merge()
            HOJA_EXCEL.Range(ColD & FilaOri.ToString).Value = Fila_Iden("CAMPO1")
            HOJA_EXCEL.Range(ColD & FilaOri.ToString).Font.Size = 8
            HOJA_EXCEL.Range(ColD & FilaOri.ToString & ":" & ColH & FilaOri.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & FilaOri.ToString & ":" & ColH & FilaOri.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).Merge()
            HOJA_EXCEL.Range(ColD & fila.ToString).Value = Fila_NColumnas("OT_NLAB")
            HOJA_EXCEL.Range(ColD & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Next
        HOJA_EXCEL.Range("A" & Fila_Borde.ToString & ":DF" & fila.ToString).BorderAround()
        fila = fila + 1
    End Sub

    Private Sub Imprime_Detalle(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef Fila As Integer, ByVal ExcelA As Excel.Application, ByVal OTResultado As Integer)
        Dim Fila_DigRes, Fila_Elemento, Fila_Nlab, Fila_Rango, Fila_SubTit As DataRow
        Dim Encontro As Boolean
        Dim BusDig(1), BusRango(2) As Object
        Dim COLD, COLH, Masd, Mascara, sQuery, sSubTit_Comp As String
        Dim COLD_ENT, COLH_ENT, COL_COMA, COLD_DEC, COLH_DEC As String
        Dim peq, CDecimales, Fila_Ini, PosicionParen As Integer
        Dim Resultado As String
        Dim dsDecimal As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        Masd = "0000"
        sSubTit_Comp = ""
        Fila = Fila + 1
        Fila_Ini = Fila
        peq = 0

        For Each Fila_Elemento In Cjto_Tablas1.Tables("ELEMENTO_PRIORIDAD").Rows
            Encontro = False
            'For Each Fila_Nlab In Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows
            For Each Fila_Nlab In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
                COLD = Fila_Nlab("COLUMNAD")
                COLH = Fila_Nlab("COLUMNAH")
                BusDig(0) = Fila_Nlab("OT_NLAB")
                BusDig(1) = Fila_Elemento("ELE_CODIGO")
                Fila_DigRes = Cjto_Tablas1.Tables("TABLA_DIGRES").Rows.Find(BusDig)
                If (Fila_DigRes Is Nothing) = False Then
                    If peq <> Mid(Fila_Elemento("ELE_PRIORIDAD"), 1, 1) And peq <> 0 Then Fila = Fila + 1
                    peq = Mid(Fila_Elemento("ELE_PRIORIDAD"), 1, 1)
                    'HOJA_EXCEL.Range("A" & Fila.ToString & ":R" & Fila.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Fila.ToString).Value = Fila_Elemento("ELE_NOMBRE")
                    HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9

                    PosicionParen = InStr(Fila_Elemento("ELE_NOMBRE"), "(")
                    If PosicionParen > 0 Then Call CambioLetra(ExcelA, Fila_Elemento("ELE_NOMBRE"), PosicionParen, HOJA_EXCEL, Fila)

                    If Fila_Elemento("ELE_UNIDAD") <> "-" Then
                        HOJA_EXCEL.Range("AC" & Fila.ToString & ":AJ" & Fila.ToString).Merge()
                        HOJA_EXCEL.Range("AC" & Fila.ToString).Value = "'" & Fila_Elemento("ELE_UNIDAD")
                        HOJA_EXCEL.Range("AC" & Fila.ToString).Font.Size = 7
                        HOJA_EXCEL.Range("AC" & Fila.ToString & ":AJ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    End If
                    If IsDBNull(Fila_DigRes("OBSERVACION")) = False Then
                        HOJA_EXCEL.Range(COLD & Fila.ToString & ":" & COLH & Fila.ToString).Merge()
                        HOJA_EXCEL.Range(COLD & Fila.ToString).Value = Fila_DigRes("OBSERVACION")
                        HOJA_EXCEL.Range(COLD & Fila.ToString).Font.Size = 9
                        HOJA_EXCEL.Range(COLD & Fila.ToString & ":" & COLH & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End If
                    'If Rango_Interpreta = True Then
                    '    BusRango(0) = 3600
                    '    BusRango(1) = "Bactereologicos"
                    '    BusRango(2) = Fila_Elemento("ELE_CODIGO")
                    '    Fila_Rango = Cjto_Tablas1.Tables("RANGO_DBF").Rows.Find(BusRango)
                    '    If (Fila_Rango Is Nothing) = False Then
                    '        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CU" & Fila.ToString).Merge()
                    '        HOJA_EXCEL.Range("CJ" & Fila.ToString).Value = Fila_Rango("RANGO_DESDE")
                    '        HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Size = 8
                    '        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    '        HOJA_EXCEL.Range("CV" & Fila.ToString & ":DF" & Fila.ToString).Merge()
                    '        HOJA_EXCEL.Range("CV" & Fila.ToString).Value = Fila_Rango("RANGO_HASTA")
                    '        HOJA_EXCEL.Range("CV" & Fila.ToString).Font.Size = 6
                    '        HOJA_EXCEL.Range("CV" & Fila.ToString & ":DF" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    '    End If
                    'End If
                    Encontro = True
                End If
            Next
            If Encontro Then
                Fila = Fila + 1
            End If
        Next

        'If Rango_Interpreta = True Then
        '    HOJA_EXCEL.Range("CJ" & (Fila_Ini - 5).ToString & ":DF" & (Fila - 1).ToString).Interior.Color = RGB(175, 238, 238)
        '    HOJA_EXCEL.Range("CJ" & (Fila_Ini - 5).ToString & ":DF" & (Fila - 1).ToString).BorderAround()
        'End If

        'Fila = Fila + 1
        Call Notas_Automaticas(OTResultado, HOJA_EXCEL, Fila)
        Call Imprime_Firmas(HOJA_EXCEL, Fila_Firma)

    End Sub

    Public Sub Notas_Automaticas(ByVal OTResultado As String, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal Fila_Fin As Integer)
        Dim FILA_ELEBAC, FILA_NOTA, FILA_HOMO As DataRow
        Dim BOLA, BOLA1 As Object
        Dim varmer, largoco, k As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim ds1 As DataSet = New DataSet
        Dim Fila_Notas As DataRow
        Dim O1, O2, O3, O4 As String
        With SP
            .Inicializar()
            .AgregarParametro("@Tmuestra", 3600, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectResultadosNotasxMuestra")
        End With

        For Each Fila_Notas In ds.Tables(0).Rows
            If Fila_Notas.Item("NOTA_POS") = "1" Then O1 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "2" Then O2 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "3" Then O3 = Fila_Notas.Item("NOTA_DESCRIPCION")
            If Fila_Notas.Item("NOTA_POS") = "4" Then O4 = Fila_Notas.Item("NOTA_DESCRIPCION")
        Next

        If O1 <> "" Then
            largoco = Len(O1)
            varmer = CInt(largoco / 110)
            varmer = varmer - 1
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O1
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 8
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        Fila_Fin = Fila_Fin + 1 + varmer


        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", OTResultado, SqlDbType.Int)
            ds1 = .EjecutarQuery("usp_SelectElementosBactereologicos")
        End With

        For Each FILA_ELEBAC In ds1.Tables(0).Rows
            BOLA = FILA_ELEBAC("ELE_CODIGO")
            FILA_NOTA = Cjto_Tablas1.Tables("NOTA_AUTO_RESULTADOS").Rows.Find(BOLA)
            varmer = 0
            If Not (FILA_NOTA Is Nothing) Then
                If IsDBNull(FILA_NOTA("DESCRIPCION")) = False Then
                    If FILA_NOTA("DESCRIPCION") <> "" Then
                        largoco = Len(FILA_NOTA("DESCRIPCION"))
                        varmer = CInt(largoco / 110)
                        varmer = varmer - 1
                        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin) + varmer.ToString).Merge()
                        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Value = FILA_NOTA("DESCRIPCION")
                        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString).Font.Size = 7
                        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin) + varmer.ToString).WrapText = True
                        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                        HOJA_EXCEL.Range("A" & (Fila_Fin).ToString & ":DF" & (Fila_Fin) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        Fila_Fin = Fila_Fin + 1 + varmer
                    End If
                End If
            End If
        Next

        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = "Par�metros en que la NCh409 no se�ala l�mites m�ximos no se encuentran regulados en la norma."
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        Fila_Fin = Fila_Fin + 2

        If O2 <> "" Then
            largoco = Len(O2)
            varmer = CInt(largoco / 110)
            varmer = varmer - 1
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O2
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 8
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        Fila_Fin = Fila_Fin + 1 + varmer

        If O3 <> "" Then
            largoco = Len(O3)
            varmer = CInt(largoco / 110)
            varmer = varmer - 1
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O3
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 8
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        Fila_Fin = Fila_Fin + 1 + varmer

        If O4 <> "" Then
            largoco = Len(O4)
            varmer = CInt(largoco / 110)
            varmer = varmer - 1
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O4
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 8
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        Fila_Fin = Fila_Fin + 2 + varmer

        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = "- Analisis realizados de acuerdo a la norma NCh17025 en laboratorio Cesmec Ltda., laboratorio con acreditaci�n INN LE 076 y LE 189."
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        Fila_Fin = Fila_Fin + 1

        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = "  informe de ensayo"
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

    End Sub


    Private Sub Imprime_Marco(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal Fila_Ini As Integer, ByVal Fila_Fin As Integer)
        'With HOJA_EXCEL.Range("CJ" & (Fila_Ini).ToString & ":CU" & (Fila_Fin).ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
        '    .LineStyle = Excel.XlLineStyle.xlContinuous
        '    .Weight = Excel.XlBorderWeight.xlHairline
        '    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        'End With
        HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
        'HOJA_EXCEL.Range("CJ" & (Fila_Ini - 4).ToString & ":DF" & (Fila_Fin).ToString).Interior.Color = RGB(175, 238, 238)
        'HOJA_EXCEL.Range("CJ" & (Fila_Ini - 4).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()

        'Call Notas_Automaticas(MATRIZ_AUX(2), HOJA_EXCEL, Fila_Fin)
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
            fila_firma = fila_firma - 4
            HOJA_EXCEL.Range("BJ" & fila_firma.ToString).Select()
            HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\firma_resultado.jpg").Select()
            fila_firma = fila_firma + 4
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
        HOJA_EXCEL.Range("BG" & fila_firma.ToString).Value = Firma_Nombre1
        HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BG" & fila_firma.ToString).Font.Size = 9

        HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).Merge()
        HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Value = Firma_Cargo1
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
