Imports Microsoft.Office.Interop

Module Module_Imprime_Resultado_Agua
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
    Private RANGO_CE(3, 2) As Double

    Private ELEMENTO_POTABLE(4) As String
    Private NOTA_POTABLE(4) As String
    Private FILAS_POTABLE(4) As Integer

    Private ELEMENTO_SOLIDOS(4) As String
    Private NOTA_SOLIDOS(4) As String
    Private FILAS_SOLIDOS(4) As Integer

    Private EsPotable As Boolean

    Public Sub Genera_Impresion_Agua(ByVal OTResultado As Integer, ByVal NLabD As Integer, ByVal NLabH As Integer)
        Dim Fila_Ciclo, Fila_Identifica, Fila_Identifica2, Fila_SubTit, Fila_Seleccion As DataRow
        Dim MATRIZ_AUX(9), fuente, destino, PRO As String
        Dim SALTO_PAGINA, Ciclo_Inicial, Revisa_Filas As Boolean
        Dim sAño, sRutaDest As String
        Dim BuscaEle(0) As Object
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Retorno As Integer

        Dim objLibroExcel As Excel.Workbook
        Dim m_Excel As Excel.Application
        Dim Hoja_Excel As Excel.Worksheet
        Dim Fila_Ini, Fila_Fin, pagina, Fila, Cuenta_Columnas, Cuantas_Filas As Integer
        SALTO_PAGINA = False
        OrdenEnResulatdos = OTResultado
        Call Busca_Datos_orden()
        Call Busca_Datos_Configuracion()
        fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formatos Resultados.xls"
        NLabDesde = NLabD
        NLabHasta = NLabH
        Filas_Pagina = 65
        ReDim RANGO_CE(3, 2)
        NLAD = NLabDesde
        NLAH = "-" & Microsoft.VisualBasic.Right(CStr(NLabHasta), 3)
        If NLabDesde = NLabHasta Then NLAH = ""
        PRO = GProductor
        NOMBRE_PROD = GProductor
        sAño = CStr(Year(Now))
        If NLAH = "" Then NLAH = "       "

        Retorno = 1
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", NLabD, SqlDbType.Int)
            Retorno = .EjecutarEscalar("usp_SelectBuscaNLabOtrasOrden")
        End With

        If Retorno = 1 Then
            sRutaDest = "F:\Mis Documentos\" + sAño + ".Agua-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        Else
            sRutaDest = "F:\Mis Documentos\" + sAño + ".Agua-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & " NumOrden " & OrdenEnResulatdos & ".xls"
        End If

        'sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".Agua-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
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
        'Try
        For Each Fila_Ciclo In Cjto_Tablas1.Tables("TABLA_CICLO").Rows
            Retorno = 0
            With SP
                .Inicializar()
                .AgregarParametro("@NumLab", Fila_Ciclo("OT_NLAB"), SqlDbType.Int)
                .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
                Retorno = .EjecutarEscalar("usp_SelectBactexNLab2")
            End With

            'If Retorno = 1 Then GoTo SaltoxBacter

            Cuenta_Columnas = Cuenta_Columnas + 1
            If Cuenta_Columnas = 1 Then
                MATRIZ_DAT_ANT(1) = Fila_Ciclo("PREDIO")
                MATRIZ_DAT_ANT(2) = Fila_Ciclo("LOCALIDAD")
                MATRIZ_DAT_ANT(3) = Fila_Ciclo("FMUESTREO")
                MATRIZ_DAT_ANT(4) = Fila_Ciclo("MUESTREADOR")
                'MATRIZ_DAT_ANT(5) = Fila_Ciclo("CAMPO1")
                'MATRIZ_DAT_ANT(6) = Fila_Ciclo("CAMPO3")
            End If

            Call Revisa_Salto_Por_Encabezado(Fila_Ciclo, SALTO_PAGINA, Cuenta_Columnas)
            If Ciclo_Inicial = True Then Ciclo_Inicial = False : GoTo SaltoxCicloInicial
            If SALTO_PAGINA = True Or Cuenta_Columnas > Maximo_columnas Then
                Call Coloca_Columnas_Agua(Cuenta_Columnas)
                Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, Fila_Firma, OrdenEnResulatdos)
                Fila_Ini = Fila
                Call Imprime_Detalle(Hoja_Excel, Fila, m_Excel)
                Fila_Fin = Fila - 1
                Call Imprime_Marco(Hoja_Excel, Fila_Ini, Fila_Fin)
                Revisa_Filas = True
                pagina = pagina + 1
                Cuenta_Columnas = 1
                MATRIZ_DAT_ANT(1) = Fila_Ciclo("PREDIO")
                MATRIZ_DAT_ANT(2) = Fila_Ciclo("LOCALIDAD")
                MATRIZ_DAT_ANT(3) = Fila_Ciclo("FMUESTREO")
                MATRIZ_DAT_ANT(4) = Fila_Ciclo("MUESTREADOR")
                'MATRIZ_DAT_ANT(5) = Fila_Ciclo("CAMPO1")
                'MATRIZ_DAT_ANT(6) = Fila_Ciclo("CAMPO3")
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
            'Try
            Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows.Add(Fila_Identifica)
            Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows.Add(Fila_Identifica2)
            'Catch ex As Exception
            'End Try
            SALTO_PAGINA = False
SaltoxBacter:
        Next

        Call Coloca_Columnas_Agua(Cuenta_Columnas + 1)
        '*************************
        SALTO_PAGINA = True
        Call Revisa_Salto_Por_Encabezado(Fila_Ciclo, SALTO_PAGINA, Cuenta_Columnas)
        Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, Fila_Firma, OrdenEnResulatdos)
        Fila_Ini = Fila
        Call Imprime_Detalle(Hoja_Excel, Fila, m_Excel)
        Fila_Fin = Fila - 1
        Call Imprime_Marco(Hoja_Excel, Fila_Ini, Fila_Fin)
        'Call Imprime_Firmas(Hoja_Excel, Fila_Firma)

        Call IMPRIME_NUMERO_PAGINAS(Hoja_Excel, pagina)
        m_Excel.Visible = True

        Try
            Hoja_Excel.Range("A5").Select()
            Hoja_Excel.SaveAs(destino)
        Catch ex As Exception
            objLibroExcel.Close(False, , )
            Hoja_Excel.Quit()
            m_Excel = Nothing
        End Try
        'Catch ex As Exception
        'MsgBox("Primero debe generar el archivo")
        'End Try
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
            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
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
            If IsDBNull(ds.Tables(0).Rows(0).Item("FECHA_TERMINO")) = False Then
                Fecha_Termino = ds.Tables(0).Rows(0).Item("FECHA_TERMINO")
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
        'If IsDBNull(FILA_SET("CAMPO1")) Then FILA_SET("CAMPO1") = ""
        'If IsDBNull(FILA_SET("CAMPO3")) Then FILA_SET("CAMPO3") = ""

        If FILA_SET("PREDIO") <> MATRIZ_AUX(1) Then SALTO_PAGINA = True
        If FILA_SET("LOCALIDAD") <> MATRIZ_AUX(2) Then SALTO_PAGINA = True
        If FILA_SET("FMUESTREO") <> MATRIZ_AUX(3) Then SALTO_PAGINA = True
        If FILA_SET("MUESTREADOR") <> MATRIZ_AUX(4) Then SALTO_PAGINA = True
        'If FILA_SET("CAMPO1") <> MATRIZ_AUX(5) Then SALTO_PAGINA = True
        'If FILA_SET("CAMPO3") <> MATRIZ_AUX(6) Then SALTO_PAGINA = True

        If SALTO_PAGINA = True And CuentaC <> 1 Then
            MATRIZ_DAT_ANT(1) = MATRIZ_AUX(1)
            MATRIZ_DAT_ANT(2) = MATRIZ_AUX(2)
            MATRIZ_DAT_ANT(3) = MATRIZ_AUX(3)
            MATRIZ_DAT_ANT(4) = MATRIZ_AUX(4)
            'MATRIZ_DAT_ANT(5) = MATRIZ_AUX(5)
            'MATRIZ_DAT_ANT(6) = MATRIZ_AUX(6)
        End If

        MATRIZ_AUX(1) = FILA_SET("PREDIO")
        MATRIZ_AUX(2) = FILA_SET("LOCALIDAD")
        MATRIZ_AUX(3) = FILA_SET("FMUESTREO")
        MATRIZ_AUX(4) = FILA_SET("MUESTREADOR")
        'MATRIZ_AUX(5) = FILA_SET("CAMPO1")
        'MATRIZ_AUX(6) = FILA_SET("CAMPO3")

    End Sub


    Private Sub Coloca_Columnas_Agua(ByVal cuenord As Integer)
        Dim FILA_REC, FILA_REC2 As DataRow
        Dim CUFI As Integer = 1
        For Each FILA_REC In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
            If cuenord <= 2 Then
                Select Case CUFI
                    Case 1
                        FILA_REC("COLUMNAD") = "BC"
                        FILA_REC("COLUMNAH") = "BR"
                    Case 2
                        FILA_REC("COLUMNAD") = "BT"
                        FILA_REC("COLUMNAH") = "CI"
                End Select
            Else
                Select Case CUFI
                    Case 1
                        FILA_REC("COLUMNAD") = "AL"
                        FILA_REC("COLUMNAH") = "BA"
                    Case 2
                        FILA_REC("COLUMNAD") = "BC"
                        FILA_REC("COLUMNAH") = "BR"
                    Case 3
                        FILA_REC("COLUMNAD") = "BT"
                        FILA_REC("COLUMNAH") = "CI"
                End Select
            End If
            CUFI = CUFI + 1
        Next
    End Sub

    Private Sub Imprime_Encabezado(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pagina As Integer, ByRef fila As Integer, ByRef Fila_Firma As Integer, ByVal OTResultado As Integer)
        Dim VerNom, ColD, ColH, CuartelTotal, N1, N2, N3, N4, N5, N6, Aux_Origen As String
        Dim BOLA2, BusIden As Object
        Dim FILA_HOMO, Fila_NColumnas, Fila_Iden As DataRow
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Fila_Notas As DataRow

        If pagina <> 1 Then
            Fila_Firma = 60 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Firma = 60
        End If

        If pagina <> 1 Then
            Fila_Nota = 61 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Nota = 61
        End If
        IncFil = 0

        With SP
            .Inicializar()
            .AgregarParametro("@Tmuestra", 3000, SqlDbType.Int)
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
        If MATRIZ_DAT_ANT(4) = "Muestra ingresada por cliente" Then
            N6 = "- Los resultados son válidos sólo para las muestras analizadas las cuales fueron proporcionadas por el cliente"
        Else
            N6 = "- Muestras ingresadas por el servicio de muestreo de Agrolab"
        End If

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
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS AGUA"
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Size = 14
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
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
        'Especie
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

        ''Muestraedor
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Muestreador"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CF" & fila.ToString & ":DF" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = MATRIZ_AUX(4)
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
        'F.Termino
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
        'fila = fila + 1
        ''F.Informe
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha informe"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = Fecha_Informe
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

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
        'pag
        fila = fila + 1
        HOJA_EXCEL.Range("CX" & fila.ToString).Value = "Pag."
        HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        fila = fila + 1 : FilaCua = fila
        Fila_Borde = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Identificación muestra"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", OrdenEnResulatdos, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectOrigenAgua")
        End With

        EsPotable = False
        If ds.Tables(0).Rows(0).Item("AGUANT_ORIGEN") = "Pot" Then EsPotable = True

        If Rango_Interpreta = True And EsPotable = True Then
            HOJA_EXCEL.Range("CM" & fila.ToString & ":DF" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CM" & fila.ToString).Value = "Interpretación"
            HOJA_EXCEL.Range("CM" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CM" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CM" & fila + 1.ToString & ":CV" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CM" & fila + 1.ToString).Value = "NCh1333"
            HOJA_EXCEL.Range("CM" & fila + 1.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CM" & fila + 1.ToString & ":CV" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CW" & fila + 1.ToString & ":DF" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CW" & fila + 1.ToString).Value = "NCh409"
            HOJA_EXCEL.Range("CW" & fila + 1.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CW" & fila + 1.ToString & ":DF" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CM" & fila + 2.ToString & ":CV" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("CM" & fila + 2.ToString).Value = "Limite máx"
            HOJA_EXCEL.Range("CM" & fila + 2.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CM" & fila + 2.ToString & ":CV" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CW" & fila + 2.ToString & ":DF" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("CW" & fila + 2.ToString).Value = "Limite máx"
            HOJA_EXCEL.Range("CW" & fila + 2.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CW" & fila + 2.ToString & ":DF" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CM" & fila + 3.ToString & ":CV" & fila + 3.ToString).Merge()
            HOJA_EXCEL.Range("CM" & fila + 3.ToString).Value = "'(1)"
            HOJA_EXCEL.Range("CM" & fila + 3.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CM" & fila + 3.ToString & ":CV" & fila + 3.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CW" & fila + 3.ToString & ":DF" & fila + 3.ToString).Merge()
            HOJA_EXCEL.Range("CW" & fila + 3.ToString).Value = "'(2)"
            HOJA_EXCEL.Range("CW" & fila + 3.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CW" & fila + 3.ToString & ":DF" & fila + 3.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If Rango_Interpreta = True And EsPotable = False Then
            HOJA_EXCEL.Range("CJ" & fila.ToString & ":DF" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CJ" & fila.ToString).Value = "Interpretación para Riego"
            HOJA_EXCEL.Range("CJ" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CJ" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CJ" & fila + 1.ToString & ":CR" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CJ" & fila + 1.ToString).Value = "Nch1333"
            HOJA_EXCEL.Range("CJ" & fila + 1.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CJ" & fila + 1.ToString & ":CR" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":DF" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila + 1.ToString).Value = "Agrónomico"
            HOJA_EXCEL.Range("CS" & fila + 1.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":DF" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CJ" & fila + 2.ToString & ":CR" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("CJ" & fila + 2.ToString).Value = "Limite máx"
            HOJA_EXCEL.Range("CJ" & fila + 2.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CJ" & fila + 2.ToString & ":CR" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CS" & fila + 2.ToString & ":DF" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila + 2.ToString).Value = "Riesgo de uso"
            HOJA_EXCEL.Range("CS" & fila + 2.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CS" & fila + 2.ToString & ":DF" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CJ" & fila + 3.ToString & ":CR" & fila + 3.ToString).Merge()
            HOJA_EXCEL.Range("CJ" & fila + 3.ToString).Value = "'(1)"
            HOJA_EXCEL.Range("CJ" & fila + 3.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CJ" & fila + 3.ToString & ":CR" & fila + 3.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CS" & fila + 3.ToString & ":CY" & fila + 3.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila + 3.ToString).Value = "Ninguno"
            HOJA_EXCEL.Range("CS" & fila + 3.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CS" & fila + 3.ToString & ":CY" & fila + 3.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("CZ" & fila + 3.ToString & ":DF" & fila + 3.ToString).Merge()
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString).Value = "Alto"
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString & ":DF" & fila + 3.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString & ":DF" & fila + 3.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        End If
        'Origen
        fila = fila + 2 : FilaOri = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Origen"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'n°laboratorio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "N° de Laboratorio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        ' imprime identificacion *************

        For Each Fila_NColumnas In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
            ColD = Fila_NColumnas("COLUMNAD")
            ColH = Fila_NColumnas("COLUMNAH")
            BusIden = Fila_NColumnas("OT_NLAB")
            Aux_Origen = ""
            Fila_Iden = Cjto_Tablas1.Tables("TABLA_CICLO").Rows.Find(BusIden)
            CuartelTotal = Fila_Iden("IDENTIFICACION1") & " " & Fila_Iden("IDENTIFICACION2")

            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).Merge()
            HOJA_EXCEL.Range(ColD & FilaCua.ToString).Value = CuartelTotal
            HOJA_EXCEL.Range(ColD & FilaCua.ToString).Font.Size = 9
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).WrapText = True

            If Fila_Iden("CAMPO1") = "Rio" Then Aux_Origen = "Río"
            If Fila_Iden("CAMPO1") = "Can" Then Aux_Origen = "Canal"
            If Fila_Iden("CAMPO1") = "Poz" Then Aux_Origen = "Pozo"
            If Fila_Iden("CAMPO1") = "Pot" Then Aux_Origen = "Potable"

            HOJA_EXCEL.Range(ColD & FilaOri.ToString & ":" & ColH & FilaOri.ToString).Merge()
            HOJA_EXCEL.Range(ColD & FilaOri.ToString).Value = Aux_Origen
            HOJA_EXCEL.Range(ColD & FilaOri.ToString).Font.Size = 9
            HOJA_EXCEL.Range(ColD & FilaOri.ToString & ":" & ColH & FilaOri.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & FilaOri.ToString & ":" & ColH & FilaOri.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).Merge()
            HOJA_EXCEL.Range(ColD & fila.ToString).Value = Fila_NColumnas("OT_NLAB")
            HOJA_EXCEL.Range(ColD & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Next
        Call Bordes_Rangos(HOJA_EXCEL, fila)
        HOJA_EXCEL.Range("A" & Fila_Borde.ToString & ":DF" & fila.ToString).BorderAround()
        fila = fila + 1

    End Sub

    Private Sub Imprime_Detalle(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef Fila As Integer, ByVal ExcelA As Excel.Application)
        Dim Fila_DigRes, Fila_Elemento, Fila_Nlab, Fila_Rango, Fila_SubTit As DataRow
        Dim Encontro As Boolean
        Dim BusDig(1), BusRango(1) As Object
        Dim COLD, COLH, Masd, Mascara, sQuery, sSubTit_Comp As String
        Dim COLD_ENT, COLH_ENT, COL_COMA, COLD_DEC, COLH_DEC As String
        Dim peq, CDecimales, Fila_Ini, PosicionParen, Fila_Agua As Integer
        Dim Resultado As String
        Dim dsDecimal As DataSet = New DataSet
        Dim dsPotable As DataSet = New DataSet
        Dim dsSolidos As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim SubTitulo_Aux As String
        Dim CONTADOR_NLA As Integer = 0
        Dim CONTADOR_POTABLE As Integer = 0
        Dim CONTADOR_SOLIDOS As Integer = 0
        ReDim RANGO_CE(3, 2)

        Masd = "0000"
        sSubTit_Comp = ""
        'Fila = Fila + 1
        Fila_Ini = Fila
        peq = 1
        SubTitulo_Aux = "1"
        For Each Fila_Elemento In Cjto_Tablas1.Tables("ELEMENTO_PRIORIDAD").Rows
            If Fila_Elemento("ELE_CODIGO") = "Suma_Cat" Or Fila_Elemento("ELE_CODIGO") = "Suma_Ani" Or _
               Fila_Elemento("ELE_CODIGO") = "Coli_Fecales" Or Fila_Elemento("ELE_CODIGO") = "Coli_Totales" Or _
               Fila_Elemento("ELE_CODIGO") = "EColi" Or Fila_Elemento("ELE_CODIGO") = "Clostridios" Or _
               Fila_Elemento("ELE_CODIGO") = "Pseudomonas" Then GoTo SaltoxBacter
            Encontro = False
            CONTADOR_NLA = 0
            'For Each Fila_Nlab In Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows
            For Each Fila_Nlab In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
                COLD = Fila_Nlab("COLUMNAD")
                COLH = Fila_Nlab("COLUMNAH")
                CONTADOR_NLA = CONTADOR_NLA + 1
                BusDig(0) = Fila_Nlab("OT_NLAB")
                BusDig(1) = Fila_Elemento("ELE_CODIGO")
                Fila_DigRes = Cjto_Tablas1.Tables("TABLA_DIGRES").Rows.Find(BusDig)
                If (Fila_DigRes Is Nothing) = False Then
                    'If peq <> Mid(Fila_Elemento("ELE_PRIORIDAD"), 1, 1) Then Fila = Fila + 1 : peq = Mid(Fila_Elemento("ELE_PRIORIDAD"), 1, 1)

                    'With SP
                    '    .Inicializar()
                    '    .AgregarParametro("@CodEle", Fila_Elemento("ELE_CODIGO"), SqlDbType.NVarChar)
                    '    dsPotable = .EjecutarQuery("usp_SelectAguaPotable")
                    'End With

                    'If IsDBNull(dsPotable.Tables(0).Rows(0).Item("NOTA")) = False Then
                    '    ELEMENTO_POTABLE(CONTADOR_POTABLE) = Fila_Elemento("ELE_CODIGO")
                    '    NOTA_POTABLE(CONTADOR_POTABLE) = dsPotable.Tables(0).Rows(0).Item("NOTA")
                    '    FILAS_POTABLE(CONTADOR_POTABLE) = dsPotable.Tables(0).Rows(0).Item("FILAS")
                    'End If

                    'With SP
                    '    .Inicializar()
                    '    .AgregarParametro("@CodEle", Fila_Elemento("ELE_CODIGO"), SqlDbType.NVarChar)
                    '    dsSolidos = .EjecutarQuery("usp_SelectAguaSolidos")
                    'End With

                    'If IsDBNull(dsSolidos.Tables(0).Rows(0).Item("NOTA")) = False Then
                    '    ELEMENTO_SOLIDOS(CONTADOR_SOLIDOS) = Fila_Elemento("ELE_CODIGO")
                    '    NOTA_SOLIDOS(CONTADOR_SOLIDOS) = dsSolidos.Tables(0).Rows(0).Item("NOTA")
                    '    FILAS_SOLIDOS(CONTADOR_SOLIDOS) = dsSolidos.Tables(0).Rows(0).Item("FILAS")
                    'End If

                    If Fila_Elemento("ELE_CODIGO") = "CE" Then
                        If IsDBNull(Fila_DigRes("DIGRES_RESULTADO")) = False Then RANGO_CE(CONTADOR_NLA, 1) = Fila_Nlab("OT_NLAB") : RANGO_CE(CONTADOR_NLA, 2) = Fila_DigRes("DIGRES_RESULTADO") Else RANGO_CE(CONTADOR_NLA, 1) = Fila_Nlab("OT_NLAB") : RANGO_CE(CONTADOR_NLA, 2) = 0
                    End If
                    'Call Revisa_Codigos_Mg(Fila_Elemento("ELE_CODIGO"), Fila_Nlab("OT_NLAB"), Fila_DigRes("DIGRES_RESULTADO"))

                    If SubTitulo_Aux <> Fila_Elemento("ELE_TITULO_RES") Then
                        HOJA_EXCEL.Range("A" & (Fila).ToString).Value = Fila_Elemento("ELE_TITULO_RES")
                        HOJA_EXCEL.Range("A" & (Fila).ToString).Font.Size = 9
                        HOJA_EXCEL.Range("A" & (Fila).ToString).Font.Bold = True

                        If EsPotable = True Then
                            With HOJA_EXCEL.Range("CM" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With

                            With HOJA_EXCEL.Range("CV" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With
                            Fila = Fila + 1
                            With HOJA_EXCEL.Range("CM" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With

                            With HOJA_EXCEL.Range("CV" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With
                        Else
                            With HOJA_EXCEL.Range("CJ" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With

                            With HOJA_EXCEL.Range("CR" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With
                            Fila = Fila + 1
                            With HOJA_EXCEL.Range("CJ" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With

                            With HOJA_EXCEL.Range("CR" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                                .LineStyle = Excel.XlLineStyle.xlContinuous
                                .Weight = Excel.XlBorderWeight.xlHairline
                                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                            End With
                        End If
                    End If

                    SubTitulo_Aux = Fila_Elemento("ELE_TITULO_RES")

                    'Subanalisis
                    If Fila_Elemento("ELE_PROCESO") = "SubAnálisis" Then
                        Fila_Agua = Fila
                        'If Fila_Elemento("ELE_CODIGO") = "WTexBouyouco" Then Call Imprime_SubAnalisis_Textura(ExcelA, HOJA_EXCEL, Fila_Agua, Fila_Nlab("OT_NLAB"), COLDR, COLHR, COLDC, COLHC, COLDS, COLHS)
                        'If Fila_Elemento("ELE_CODIGO") = "WTexBouyouco+AreFyG" Then Call Imprime_SubAnalisis_TexturaAreFyG(ExcelA, HOJA_EXCEL, Fila_Textura, Fila_Nlab("OT_NLAB"), COLDR, COLHR, COLDC, COLHC, COLDS, COLHS)
                        'If Fila_Elemento("ELE_CODIGO") = "WCCyPMP" Then Call Imprime_SubAnalisis_RetencionHum(ExcelA, HOJA_EXCEL, Fila_Agua, Fila_Nlab("OT_NLAB"), COLDR, COLHR, COLDC, COLHC, COLDS, COLHS)
                        'If Fila_Elemento("ELE_CODIGO") = "WGran 9tamizes" Then Call Imprime_SubAnalisis_Granulometria9Tamices(ExcelA, HOJA_EXCEL, Fila_Textura, Fila_Nlab("OT_NLAB"), COLDR, COLHR, COLDC, COLHC, COLDS, COLHS)
                        SubTitulo_Aux = ""
                        GoTo SaltoxSubAnalisis
                    End If

                    HOJA_EXCEL.Range("A" & Fila.ToString & ":R" & Fila.ToString).Merge()

                    If Fila_Elemento("ELE_SIMBOLO") = "" Or Fila_Elemento("ELE_UNIDAD") = "" Then
                        If Fila_Elemento("ELE_SIMBOLO") = "" Then HOJA_EXCEL.Range("A" & Fila.ToString & ":Y" & Fila.ToString).Merge()
                        If Fila_Elemento("ELE_UNIDAD") = "" Then HOJA_EXCEL.Range("A" & Fila.ToString & ":AF" & Fila.ToString).Merge()
                    End If

                    HOJA_EXCEL.Range("A" & Fila.ToString).Value = Fila_Elemento("ELE_NOMBRE")
                    HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9

                    PosicionParen = InStr(Fila_Elemento("ELE_NOMBRE"), "(")
                    If PosicionParen > 0 Then Call CambioLetra(ExcelA, Fila_Elemento("ELE_NOMBRE"), PosicionParen, HOJA_EXCEL, Fila)


                    If Fila_Elemento("ELE_SIMBOLO") <> "" Then
                        If IsDBNull(Fila_Elemento("ELE_SIMBOLO")) = False Or Fila_Elemento("ELE_SIMBOLO") <> "" Then
                            HOJA_EXCEL.Range("S" & Fila.ToString & ":Y" & Fila.ToString).Merge()
                            HOJA_EXCEL.Range("S" & Fila.ToString).Value = "(" & Fila_Elemento("ELE_SIMBOLO") & ")"
                            HOJA_EXCEL.Range("S" & Fila.ToString).Font.Size = 8
                            HOJA_EXCEL.Range("S" & Fila.ToString & ":Y" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        End If
                    End If

                    If IsDBNull(Fila_Elemento("ELE_UNIDAD")) = False Or Fila_Elemento("ELE_UNIDAD") <> "" Then
                        HOJA_EXCEL.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).Merge()
                        HOJA_EXCEL.Range("AA" & Fila.ToString).Value = "'" & Fila_Elemento("ELE_UNIDAD")
                        HOJA_EXCEL.Range("AA" & Fila.ToString).Font.Size = 7
                        HOJA_EXCEL.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    End If

                    If IsDBNull(Fila_DigRes("DIGRES_RESULTADO")) = False Then
                        With SP
                            .Inicializar()
                            .AgregarParametro("@CodEle", Fila_Elemento("ELE_CODIGO"), SqlDbType.NVarChar)
                            .AgregarParametro("@CodUni", Fila_Elemento("ELE_UNIDAD"), SqlDbType.NVarChar)
                            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
                            dsDecimal = .EjecutarQuery("usp_SelectRevisionTipoMascara")
                        End With
                        Resultado = FormatoDecimales(Fila_DigRes("DIGRES_RESULTADO"), dsDecimal)

                        'Sector Cambio de 0 a < 0,01 o 0,001
                        If (Fila_Elemento("ELE_CODIGO") = "B" Or Fila_Elemento("ELE_CODIGO") = "P_mg" Or _
                            Fila_Elemento("ELE_CODIGO") = "Zn" Or Fila_Elemento("ELE_CODIGO") = "Cu" Or _
                            Fila_Elemento("ELE_CODIGO") = "Mn" Or Fila_Elemento("ELE_CODIGO") = "Fe" Or _
                            Fila_Elemento("ELE_CODIGO") = "As" Or Fila_Elemento("ELE_CODIGO") = "Cd" Or _
                            Fila_Elemento("ELE_CODIGO") = "Zn" Or Fila_Elemento("ELE_CODIGO") = "Pb" Or _
                            Fila_Elemento("ELE_CODIGO") = "Hg" Or Fila_Elemento("ELE_CODIGO") = "Be" Or _
                            Fila_Elemento("ELE_CODIGO") = "Ba" Or Fila_Elemento("ELE_CODIGO") = "V" Or _
                            Fila_Elemento("ELE_CODIGO") = "Ag" Or Fila_Elemento("ELE_CODIGO") = "Se" Or _
                            Fila_Elemento("ELE_CODIGO") = "CN" Or Fila_Elemento("ELE_CODIGO") = "Co" Or _
                            Fila_Elemento("ELE_CODIGO") = "Cr" Or Fila_Elemento("ELE_CODIGO") = "Cr_Hexavalente" Or _
                            Fila_Elemento("ELE_CODIGO") = "Ni" Or Fila_Elemento("ELE_CODIGO") = "Mo" Or _
                            Fila_Elemento("ELE_CODIGO") = "NO2") And Fila_DigRes("ELE_ESTADO") <> "xA" Then
                            If Resultado = "0" Or Resultado = "0,00" Then Resultado = "< 0,01"
                            If Fila_Elemento("ELE_CODIGO") = "Hg" And Resultado = "0" Then Resultado = "< 0,001"
                        End If

                        HOJA_EXCEL.Range(COLD & Fila.ToString & ":" & COLH & Fila.ToString).Merge()
                        HOJA_EXCEL.Range(COLD & Fila.ToString).Value = "'" & Resultado
                        HOJA_EXCEL.Range(COLD & Fila.ToString).Font.Size = 9
                        HOJA_EXCEL.Range(COLD & Fila.ToString & ":" & COLH & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End If

                    If Rango_Interpreta = True Then
                        BusRango(0) = 3000
                        BusRango(1) = Fila_Elemento("ELE_CODIGO")
                        Fila_Rango = Cjto_Tablas1.Tables("RANGO_MUESTRA").Rows.Find(BusRango)
                        If (Fila_Rango Is Nothing) = False Then
                            If EsPotable = True Then
                                HOJA_EXCEL.Range("CM" & Fila.ToString & ":CV" & Fila.ToString).Merge()
                                HOJA_EXCEL.Range("CM" & Fila.ToString).Value = "'" & Fila_Rango("RANGO1")
                                HOJA_EXCEL.Range("CM" & Fila.ToString).Font.Size = 7
                                HOJA_EXCEL.Range("CM" & Fila.ToString & ":CV" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                                HOJA_EXCEL.Range("CW" & Fila.ToString & ":DF" & Fila.ToString).Merge()
                                HOJA_EXCEL.Range("CW" & Fila.ToString).Value = "'" & Fila_Rango("RANGO4")
                                HOJA_EXCEL.Range("CW" & Fila.ToString).Font.Size = 7
                                HOJA_EXCEL.Range("CW" & Fila.ToString & ":DF" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            Else
                                HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CR" & Fila.ToString).Merge()
                                HOJA_EXCEL.Range("CJ" & Fila.ToString).Value = "'" & Fila_Rango("RANGO1")
                                HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Size = 7
                                HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                                HOJA_EXCEL.Range("CS" & Fila.ToString & ":CY" & Fila.ToString).Merge()
                                HOJA_EXCEL.Range("CS" & Fila.ToString).Value = "'" & Fila_Rango("RANGO2")
                                HOJA_EXCEL.Range("CS" & Fila.ToString).Font.Size = 7
                                HOJA_EXCEL.Range("CS" & Fila.ToString & ":CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                                HOJA_EXCEL.Range("CZ" & Fila.ToString & ":DF" & Fila.ToString).Merge()
                                HOJA_EXCEL.Range("CZ" & Fila.ToString).Value = "'" & Fila_Rango("RANGO3")
                                HOJA_EXCEL.Range("CZ" & Fila.ToString).Font.Size = 7
                                HOJA_EXCEL.Range("CZ" & Fila.ToString & ":DF" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            End If
                        End If
                    End If
                    If EsPotable = True Then
                        With HOJA_EXCEL.Range("CM" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlHairline
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With

                        With HOJA_EXCEL.Range("CV" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlHairline
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                    Else
                        With HOJA_EXCEL.Range("CJ" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlHairline
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With

                        With HOJA_EXCEL.Range("CR" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                            .LineStyle = Excel.XlLineStyle.xlContinuous
                            .Weight = Excel.XlBorderWeight.xlHairline
                            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                        End With
                    End If
                    Encontro = True
SaltoxSubAnalisis:
                End If
            Next
            If Encontro Then
                Fila = Fila + 1
            End If
SaltoxBacter:
        Next

        If EsPotable = True Then
            With HOJA_EXCEL.Range("CM" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJA_EXCEL.Range("CV" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
        Else
            With HOJA_EXCEL.Range("CJ" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJA_EXCEL.Range("CR" & Fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
        End If

        If Rango_Interpreta = True Then
            If EsPotable = True Then
                HOJA_EXCEL.Range("CM" & (Fila_Ini - 4).ToString & ":DF" & (Fila).ToString).Interior.Color = RGB(175, 238, 238)
            Else
                HOJA_EXCEL.Range("CJ" & (Fila_Ini - 4).ToString & ":DF" & (Fila).ToString).Interior.Color = RGB(175, 238, 238)
            End If
        End If
        Fila = Fila + 1
        Fila_Ini = Fila
        Call Notas_Automaticas(HOJA_EXCEL, Fila)
        Fila = Fila + 2
        Call Imprime_Firmas(HOJA_EXCEL)
        Fila = Fila_Ini
       
    End Sub

    Public Sub Notas_Automaticas(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef Fila_Fin As Integer)
        Dim FILA_NOTA, FILA_HOMO As DataRow
        Dim BUSCA As Object
        Dim largoco, k, ii, fila_ce As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Fila_Notas, Fila_AguaCe As DataRow
        Dim O1, O2, O3, O4 As String
        Dim varmer, RangoD, RangoH As Double
        With SP
            .Inicializar()
            .AgregarParametro("@Tmuestra", 3000, SqlDbType.Int)
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
            varmer = CDbl(largoco / 250)
            If varmer < 1 Then varmer = 0
            varmer = CInt(varmer)
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O1
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 7
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        'Fila_Fin = Fila_Fin + 1 + varmer

        If O2 <> "" Then
            largoco = Len(O2)
            varmer = CDbl(largoco / 250)
            If varmer < 1 Then varmer = 0
            varmer = CInt(varmer) - 1
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O2
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 7
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        'Fila_Fin = Fila_Fin + 1 + varmer

        If O3 <> "" Then
            largoco = Len(O3)
            varmer = CDbl(largoco / 250)
            If varmer < 1 Then varmer = 0
            varmer = CInt(varmer)
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O3
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 7
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        Fila_Fin = Fila_Fin + 2

        If O4 <> "" Then
            largoco = Len(O4)
            varmer = CDbl(largoco / 250) - 1
            If varmer < 1 Then varmer = 0
            varmer = CInt(varmer)
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = O4
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 7
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).WrapText = True
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
            HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & (Fila_Fin + varmer).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        'Fila_Fin = Fila_Fin + 1

        For ii = 1 To 3
            If RANGO_CE(ii, 2) <> 0 Then
                Fila_Fin = Fila_Fin + 1
                For fila_ce = 1 To 4
                    BUSCA = fila_ce
                    Fila_AguaCe = Cjto_Resultados1.Tables("RANGO_AGUA_CE").Rows.Find(BUSCA)
                    RangoD = Fila_AguaCe("RANGO_DESDE")
                    RangoH = Fila_AguaCe("RANGO_HASTA")
                    If RANGO_CE(ii, 2) > RangoD And RANGO_CE(ii, 2) < RangoH Then
                        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & Fila_Fin.ToString).Merge()
                        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Value = "    N° Lab. " & RANGO_CE(ii, 1) & " : " & Fila_AguaCe("NOTA")
                        HOJA_EXCEL.Range("A" & Fila_Fin.ToString).Font.Size = 7
                        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & Fila_Fin.ToString).WrapText = True
                        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & Fila_Fin.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        HOJA_EXCEL.Range("A" & Fila_Fin.ToString & ":DF" & Fila_Fin.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub Imprime_Marco(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal Fila_Ini As Integer, ByVal Fila_Fin As Integer)
        HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
        If EsPotable = True Then
            HOJA_EXCEL.Range("CM" & (Fila_Ini - 4).ToString & ":DF" & (Fila_Fin).ToString).Interior.Color = RGB(175, 238, 238)
        Else
            HOJA_EXCEL.Range("CL" & (Fila_Ini - 4).ToString & ":DF" & (Fila_Fin).ToString).Interior.Color = RGB(175, 238, 238)
        End If
        'HOJA_EXCEL.Range("CL" & (Fila_Ini - 4).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
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

    Private Sub Imprime_Firmas(ByVal HOJA_EXCEL As Excel.Worksheet)
        If Firma_Nombre2 <> "" Then
            Fila_Firma = Fila_Firma - 4
            HOJA_EXCEL.Range("BJ" & Fila_Firma.ToString).Select()
            HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\firma_resultado.jpg").Select()
            Fila_Firma = Fila_Firma + 4
            HOJA_EXCEL.Range("G" & Fila_Firma.ToString & ":BF" & Fila_Firma.ToString).Merge()
            HOJA_EXCEL.Range("G" & Fila_Firma.ToString).Value = Firma_Nombre2
            HOJA_EXCEL.Range("G" & Fila_Firma.ToString & ":BF" & Fila_Firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("G" & Fila_Firma.ToString).Font.Size = 9

            HOJA_EXCEL.Range("G" & (Fila_Firma + 1).ToString & ":BF" & (Fila_Firma + 1).ToString).Merge()
            HOJA_EXCEL.Range("G" & (Fila_Firma + 1).ToString).Value = Firma_Cargo2
            HOJA_EXCEL.Range("G" & (Fila_Firma + 1).ToString & ":BF" & (Fila_Firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("G" & (Fila_Firma + 1).ToString).Font.Size = 9

            HOJA_EXCEL.Range("BG" & Fila_Firma.ToString & ":DF" & Fila_Firma.ToString).Merge()
            HOJA_EXCEL.Range("BG" & Fila_Firma.ToString).Value = Firma_Nombre1
            HOJA_EXCEL.Range("BG" & Fila_Firma.ToString & ":DF" & Fila_Firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("BG" & Fila_Firma.ToString).Font.Size = 9

            HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString & ":DF" & (Fila_Firma + 1).ToString).Merge()
            HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString).Value = Firma_Cargo1
            HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString & ":DF" & (Fila_Firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString).Font.Size = 9

        End If
        Fila_Firma = Fila_Firma - 4
        HOJA_EXCEL.Range("BJ" & Fila_Firma.ToString).Select()
        HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\firma_resultado.jpg").Select()
        Fila_Firma = Fila_Firma + 4
        HOJA_EXCEL.Range("BG" & Fila_Firma.ToString & ":DF" & Fila_Firma.ToString).Merge()
        HOJA_EXCEL.Range("BG" & Fila_Firma.ToString).Value = HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\firma_resultado.jpg").Select() & Firma_Nombre1
        HOJA_EXCEL.Range("BG" & Fila_Firma.ToString & ":DF" & Fila_Firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BG" & Fila_Firma.ToString).Font.Size = 9

        HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString & ":DF" & (Fila_Firma + 1).ToString).Merge()
        HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString).Value = Firma_Cargo1
        HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString & ":DF" & (Fila_Firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BG" & (Fila_Firma + 1).ToString).Font.Size = 9
    End Sub



    Private Sub Bordes_Rangos(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila As Integer)

        If EsPotable = True Then

            'Interpretacion
            With HOJA_EXCEL.Range("CM" & fila - 3.ToString & ":DF" & fila - 3.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CM" & fila - 3.ToString & ":DF" & fila - 3.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            'NCh1333    
            With HOJA_EXCEL.Range("CM" & fila - 2.ToString & ":CV" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CM" & fila - 2.ToString & ":CV" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            'NCh409
            With HOJA_EXCEL.Range("CW" & fila - 2.ToString & ":DF" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CW" & fila - 2.ToString & ":DF" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            'Limite máx
            With HOJA_EXCEL.Range("CM" & fila - 1.ToString & ":CV" & fila - 1.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With


            'Limite máx
            With HOJA_EXCEL.Range("CW" & fila - 1.ToString & ":DF" & fila - 1.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            '(1)
            With HOJA_EXCEL.Range("CM" & fila.ToString & ":CV" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJA_EXCEL.Range("CM" & fila.ToString & ":CV" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            '(2)
            With HOJA_EXCEL.Range("CW" & fila.ToString & ":DF" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJA_EXCEL.Range("CW" & fila.ToString & ":DF" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
        Else

            'Interpretacion
            With HOJA_EXCEL.Range("CJ" & fila - 3.ToString & ":DF" & fila - 3.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CJ" & fila - 3.ToString & ":DF" & fila - 3.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            'NCh1333    
            With HOJA_EXCEL.Range("CJ" & fila - 2.ToString & ":CR" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CJ" & fila - 2.ToString & ":CR" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            'Agronómico
            With HOJA_EXCEL.Range("CS" & fila - 2.ToString & ":DF" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CS" & fila - 2.ToString & ":DF" & fila - 2.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            'Limite máx
            With HOJA_EXCEL.Range("CJ" & fila - 1.ToString & ":CR" & fila - 1.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With


            'Riesgo de uso
            With HOJA_EXCEL.Range("CS" & fila - 1.ToString & ":DF" & fila - 1.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CS" & fila - 1.ToString & ":DF" & fila - 1.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            '(1)
            With HOJA_EXCEL.Range("CJ" & fila.ToString & ":CR" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            With HOJA_EXCEL.Range("CS" & fila.ToString & ":CY" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("CZ" & fila.ToString & ":DF" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
        End If

    End Sub

    Private Sub Revisa_Codigos_Mg(ByVal ELEMENTO As String, ByVal OtNLab As Integer, ByVal ResDig As Double)
        Dim multipli, res_dup As Double
        Dim HY As Integer
        Dim BOLA(2) As Object
        Dim FILA_ELE As DataRow
        Dim sim As String
        multipli = 0
        If ELEMENTO = "Ca_meq" Then sim = "Ca_mg" : multipli = 20
        If ELEMENTO = "Mg_meq" Then sim = "Mg_mg" : multipli = 12.15
        If ELEMENTO = "Na_meq" Then sim = "Na_mg" : multipli = 23
        If ELEMENTO = "K_meq" Then sim = "K_mg" : multipli = 39.1
        If ELEMENTO = "Cl_meq" Then sim = "Cl_mg" : multipli = 35.45
        If ELEMENTO = "SO4_meq" Then sim = "SO4_mg" : multipli = 48
        If ELEMENTO = "HCO3_meq" Then sim = "HCO3_mg" : multipli = 61
        If multipli <> 0 Then
            res_dup = ResDig * multipli
            FILA_ELE = Cjto_Tablas1.Tables("TABLA_DIGRES").NewRow
            FILA_ELE.Item("OT_NLAB") = OtNLab
            FILA_ELE.Item("ELE_CODIGO") = sim
            FILA_ELE.Item("DIGRES_RESULTADO") = res_dup
            FILA_ELE.Item("ELE_ESTADO") = "Re"
            Try
                Cjto_Tablas1.Tables("TABLA_DIGRES").Rows.Add(FILA_ELE)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub CambioLetra(ByVal ExcelA As Excel.Application, ByVal Nombre As String, ByVal PoscicionParen As Integer, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal filaCambio As Integer)
        HOJA_EXCEL.Range("A" & filaCambio.ToString).Select()
        With ExcelA.ActiveCell.Characters(Start:=PoscicionParen, Length:=Len(Nombre)).Font
            .ColorIndex = 1
            .Name = "Arial"
            .FontStyle = "Normal"
            .Size = 7
        End With
    End Sub
End Module
