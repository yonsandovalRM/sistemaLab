Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module Formato_Yemas_Parra
    Private numero_cargadores(20) As Integer
    Public Sub imprime_informe_parra(ByVal FechaInforme As String, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim Fila_Yemas, FILA_ESTIMADO As DataRow
        Dim CLAVE As Object
        Dim ValYem, fcorta, fechaf As String
        Dim lab_aux, Cuenta, Cuenta_pag, fila, resultado, u, fila_inicio_borde, largo, fila_merge, carga, orden As Integer
        Dim CargadorI, CargadorF, YemaI, YemaF As Integer
        Dim MyDate As Date
        MyDate = Today
        Cuenta = 0 : Cuenta_pag = 1
        lab_aux = 0
        For Each Fila_Yemas In Cjto_Orden1.Tables("DIG_YEMAS").Rows
            CLAVE = Fila_Yemas("OT_NLAB")
            FILA_ESTIMADO = Cjto_Orden1.Tables("ESTIMADOBRO").Rows.Find(CLAVE)
            CargadorI = FILA_ESTIMADO("CARGADOR_DESDE")
            CargadorF = FILA_ESTIMADO("CARGADOR_HASTA")
            YemaI = FILA_ESTIMADO("YEMA_DESDE")
            YemaF = FILA_ESTIMADO("YEMA_HASTA")
            If lab_aux = 0 Or lab_aux <> Fila_Yemas("OT_NLAB") Then
                If lab_aux <> 0 Then
                    HOJA_EXCEL.Range("A" & fila_inicio_borde.ToString & ":DK" & fila.ToString).BorderAround()
                    HOJA_EXCEL.Range("A" & fila_inicio_borde.ToString & ":H" & fila.ToString).BorderAround()
                    HOJA_EXCEL.Range("I" & fila_inicio_borde.ToString & ":P" & fila.ToString).BorderAround()
                    Call Notas_Fijas(HOJA_EXCEL, fila)
                    Call imprime_informe_Grafico(Cuenta_pag, orden, lab_aux, fila, HOJA_EXCEL)
                End If
                fila = 1 + (69 * Cuenta)
                Call imprime_encabezado_parra(FechaInforme, Cuenta_pag, Fila_Yemas("OT_NLAB"), Fila_Yemas("OT_NUMERO"), fila, HOJA_EXCEL)
                Call Imprime_Detalle_Parra(CargadorI, CargadorF, fila, HOJA_EXCEL)
                fila_inicio_borde = fila
                Cuenta = Cuenta + 1 : Cuenta_pag = Cuenta_pag + 1
            End If
            If Fila_Yemas("YEM_YEMA") >= YemaI And Fila_Yemas("YEM_YEMA") <= YemaF Then
                fila = fila + 1
                HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).Merge()
                HOJA_EXCEL.Range("A" & fila.ToString).Value = Fila_Yemas("YEM_YEMA")
                HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 8
                HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).Merge()
                If IsDBNull(Fila_Yemas("YEM_PORACUMULADA")) = False Then
                    If Fila_Yemas("YEM_PORACUMULADA") = 0 Then
                        HOJA_EXCEL.Range("I" & fila.ToString).Value = 0
                    Else
                        HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).NumberFormat = "#0,0"
                        HOJA_EXCEL.Range("I" & fila.ToString).Value = Format(CDbl(Fila_Yemas("YEM_PORACUMULADA")), "#0.0")
                    End If

                    HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 8
                End If
                HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                For u = 1 To 20
                    If IsDBNull(numero_cargadores) = False And IsDBNull(Fila_Yemas("YEM_PORACUMULADA")) = False Then
                        carga = (CInt(Fila_Yemas("YEM_YEMA")) * Fila_Yemas("YEM_PORACUMULADA") * numero_cargadores(u)) / 100
                        If u = 1 Then Call imprime_cargador("Q", "T", HOJA_EXCEL, carga, fila)
                        If u = 2 Then Call imprime_cargador("V", "Y", HOJA_EXCEL, carga, fila)
                        If u = 3 Then Call imprime_cargador("AA", "AD", HOJA_EXCEL, carga, fila)
                        If u = 4 Then Call imprime_cargador("AF", "AI", HOJA_EXCEL, carga, fila)
                        If u = 5 Then Call imprime_cargador("AK", "AN", HOJA_EXCEL, carga, fila)
                        If u = 6 Then Call imprime_cargador("AP", "AS", HOJA_EXCEL, carga, fila)
                        If u = 7 Then Call imprime_cargador("AU", "AX", HOJA_EXCEL, carga, fila)
                        If u = 8 Then Call imprime_cargador("AZ", "BC", HOJA_EXCEL, carga, fila)
                        If u = 9 Then Call imprime_cargador("BE", "BH", HOJA_EXCEL, carga, fila)
                        If u = 10 Then Call imprime_cargador("BJ", "BM", HOJA_EXCEL, carga, fila)
                        If u = 11 Then Call imprime_cargador("BO", "BR", HOJA_EXCEL, carga, fila)
                        If u = 12 Then Call imprime_cargador("BT", "BW", HOJA_EXCEL, carga, fila)
                        If u = 13 Then Call imprime_cargador("BY", "CB", HOJA_EXCEL, carga, fila)
                        If u = 14 Then Call imprime_cargador("CD", "CG", HOJA_EXCEL, carga, fila)
                        If u = 15 Then Call imprime_cargador("CI", "CL", HOJA_EXCEL, carga, fila)
                        If u = 16 Then Call imprime_cargador("CN", "CQ", HOJA_EXCEL, carga, fila)
                        If u = 17 Then Call imprime_cargador("CS", "CV", HOJA_EXCEL, carga, fila)
                        If u = 18 Then Call imprime_cargador("CX", "DA", HOJA_EXCEL, carga, fila)
                        If u = 19 Then Call imprime_cargador("DC", "DF", HOJA_EXCEL, carga, fila)
                        If u = 20 Then Call imprime_cargador("DH", "DK", HOJA_EXCEL, carga, fila)
                    End If
                Next
            End If
            lab_aux = Fila_Yemas("OT_NLAB") : orden = Fila_Yemas("OT_NUMERO")

        Next
        HOJA_EXCEL.Range("A" & fila_inicio_borde.ToString & ":DK" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("A" & fila_inicio_borde.ToString & ":H" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("I" & fila_inicio_borde.ToString & ":P" & fila.ToString).BorderAround()
        Call Notas_Fijas(HOJA_EXCEL, fila)
        Call imprime_informe_Grafico(Cuenta_pag, orden, lab_aux, fila, HOJA_EXCEL)
        HOJA_EXCEL.Range("A11").Select()
    End Sub
    Private Sub Notas_Fijas(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef fila As Integer)
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString & ":M" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Notas :"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString & ":M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "- En el cálculo no se consideró las yemas MF (Primaria Muerta, Secundaria Frutal)."
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "- Para decidir tipo y largo de poda es necesario completar esta información con calidad y diametro de los cargadores, estado"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "  nutricional, vigor de las plantas, etc."
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
    End Sub
    Private Sub Imprime_Detalle_Parra(ByVal CargadorI As Integer, ByVal CargadorF As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        'TITULOS DEL DETALLE *****************
        fila = fila + 1
        'largo del
        HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Largo"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'fertilidad
        HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).Merge()
        HOJA_EXCEL.Range("I" & fila.ToString).Value = "Fertilidad"
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'Nº CARGADOR
        HOJA_EXCEL.Range("Q" & fila.ToString & ":DK" & (fila + 1).ToString).Merge()
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = "Nº    d e    c a r g a d o r e s    p o r    p a r r a"
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("Q" & fila.ToString & ":DK" & (fila + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("Q" & fila.ToString & ":DK" & (fila + 1).ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        fila = fila + 1
        'cargador
        HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Cargador"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'acumulado
        HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).Merge()
        HOJA_EXCEL.Range("I" & fila.ToString).Value = "Acumulada"
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        fila = fila + 1
        '(Nº yemas)
        HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "(Nº yemas)"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '(%)
        HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).Merge()
        HOJA_EXCEL.Range("I" & fila.ToString).Value = "(%)"
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("I" & fila.ToString & ":P" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Call Proceso_cargadores(CargadorI, CargadorF, HOJA_EXCEL, fila)
        HOJA_EXCEL.Range("A" & (fila - 2).ToString & ":H" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("I" & (fila - 2).ToString & ":P" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("Q" & (fila - 2).ToString & ":DK" & (fila - 1).ToString).BorderAround()
        HOJA_EXCEL.Range("Q" & fila.ToString & ":DK" & fila.ToString).BorderAround()
    End Sub

    Private Sub Proceso_cargadores(ByVal CargadorI As Integer, ByVal CargadorF As Integer, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila As Integer)
        Dim u, ini, fin, cont As Integer
        ini = CargadorI
        fin = CargadorF
        cont = 0
        For u = ini To fin
            cont = cont + 1
            If cont = 1 Then Call imprime_cargador("Q", "T", HOJA_EXCEL, u, fila)
            If cont = 2 Then Call imprime_cargador("V", "Y", HOJA_EXCEL, u, fila)
            If cont = 3 Then Call imprime_cargador("AA", "AD", HOJA_EXCEL, u, fila)
            If cont = 4 Then Call imprime_cargador("AF", "AI", HOJA_EXCEL, u, fila)
            If cont = 5 Then Call imprime_cargador("AK", "AN", HOJA_EXCEL, u, fila)
            If cont = 6 Then Call imprime_cargador("AP", "AS", HOJA_EXCEL, u, fila)
            If cont = 7 Then Call imprime_cargador("AU", "AX", HOJA_EXCEL, u, fila)
            If cont = 8 Then Call imprime_cargador("AZ", "BC", HOJA_EXCEL, u, fila)
            If cont = 9 Then Call imprime_cargador("BE", "BH", HOJA_EXCEL, u, fila)
            If cont = 10 Then Call imprime_cargador("BJ", "BM", HOJA_EXCEL, u, fila)
            If cont = 11 Then Call imprime_cargador("BO", "BR", HOJA_EXCEL, u, fila)
            If cont = 12 Then Call imprime_cargador("BT", "BW", HOJA_EXCEL, u, fila)
            If cont = 13 Then Call imprime_cargador("BY", "CB", HOJA_EXCEL, u, fila)
            If cont = 14 Then Call imprime_cargador("CD", "CG", HOJA_EXCEL, u, fila)
            If cont = 15 Then Call imprime_cargador("CI", "CL", HOJA_EXCEL, u, fila)
            If cont = 16 Then Call imprime_cargador("CN", "CQ", HOJA_EXCEL, u, fila)
            If cont = 17 Then Call imprime_cargador("CS", "CV", HOJA_EXCEL, u, fila)
            If cont = 18 Then Call imprime_cargador("CX", "DA", HOJA_EXCEL, u, fila)
            If cont = 19 Then Call imprime_cargador("DC", "DF", HOJA_EXCEL, u, fila)
            If cont = 20 Then Call imprime_cargador("DH", "DK", HOJA_EXCEL, u, fila)
            numero_cargadores(cont) = u
        Next
    End Sub
    Private Sub imprime_cargador(ByVal col1 As String, ByVal col2 As String, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal numcar As Integer, ByVal fila As Integer)
        HOJA_EXCEL.Range(col1 & fila.ToString & ":" & col2 & fila.ToString).Merge()
        If numcar = 0 Then
            HOJA_EXCEL.Range(col1 & fila.ToString).Value = 0
        Else
            HOJA_EXCEL.Range(col1 & fila.ToString & ":" & col2 & fila.ToString).NumberFormat = "##"
            HOJA_EXCEL.Range(col1 & fila.ToString).Value = Format(CInt(numcar), "##")
        End If
        HOJA_EXCEL.Range(col1 & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range(col1 & fila.ToString & ":" & col2 & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub
    Private Sub imprime_informe_Grafico(ByVal cuenta_pag As Integer, ByVal orden As Integer, ByVal nlab As Integer, ByVal fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim letra As String
        Dim fila_pie, fila_rango, pixeles, fila_inicio_borde, largo, fila_merge As Integer
        Dim xlCategory, xlPrimary, xlValue, xlCategory1, xlPrimary1, xlValue1 As Excel.Axes
        fila = fila + 1
        pixeles = fila * 12
        Call rescata_rangos(cuenta_pag, letra, HOJA_EXCEL, orden, nlab)
        Dim Grafico As Excel.ChartObjects = HOJA_EXCEL.ChartObjects(Type.Missing)
        Dim chartObj As Excel.ChartObject = Grafico.Add(2, pixeles, 515, 300) ')anchog)
        Dim chart As Excel.Chart = chartObj.Chart
        If cuenta_pag <> 1 Then
            fila_rango = 50 + ((cuenta_pag - 2) * 69)
        Else
            fila_rango = 50
        End If
        Dim chartRange As Excel.Range = HOJA_EXCEL.Range("A" & fila_rango.ToString, letra & (fila_rango + 2).ToString)
        Dim rango As Excel.Range
        Dim ValYem, fcorta, fechaf As String
        Dim MyDate As Date
        MyDate = Today
        chart.SetSourceData(chartRange, Type.Missing)
        chart.ChartType = Excel.XlChartType.xlLineMarkers
        chart.SetSourceData(chartRange, Type.Missing)
        chart.HasTitle = True
        chart.ChartTitle.Characters.Text = "GRAFICO PORCENTAJE DE FERTILIDAD YEMAS FRUTALES"
        chart.ChartTitle.Characters.Font.Size = 9

        chart.PlotArea.Interior.ColorIndex = 0
        Try
            chart.PlotArea.Top = 18
            chart.PlotArea.Height = 260
            chart.PlotArea.Width = 365
            chart.PlotArea.Left = 55
        Catch ex As Exception

        End Try

        With chart
            xlCategory = .Axes(, Excel.XlAxisGroup.xlPrimary)
            xlCategory.Item(Excel.XlAxisType.xlCategory).HasTitle = True
            xlCategory.Item(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Largo del cargador (Nº de Yemas)"
            xlCategory.Item(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Font.Size = 8
            'xlCategory.Item(Excel.XlAxisType.xlCategory).HasMajorGridlines = True
            'xlCategory.Item(Excel.XlAxisType.xlCategory).HasMinorGridlines = False
            xlValue = .Axes(, Excel.XlAxisGroup.xlPrimary)
            xlValue.Item(Excel.XlAxisType.xlValue).HasTitle = True
            xlValue.Item(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "% Fertilidad"
            xlValue.Item(Excel.XlAxisType.xlValue).AxisTitle.Characters.Font.Size = 8

            xlValue.Item(Excel.XlAxisType.xlValue).AxisTitle.Orientation = Excel.XlOrientation.xlHorizontal
            xlValue.Item(Excel.XlAxisType.xlValue).HasMajorGridlines = True
            xlValue.Item(Excel.XlAxisType.xlValue).MaximumScale = 100
        End With
        Dim seriesCollection As Excel.SeriesCollection = chart.SeriesCollection(Type.Missing)
        Dim series1 As Excel.Series = seriesCollection.Item(1)
        Dim series2 As Excel.Series = seriesCollection.Item(2)
        Dim series3 As Excel.Series = seriesCollection.Item(3)

        series1.Delete()
        series3.MarkerBackgroundColor = 5
        series3.MarkerForegroundColor = 5
        series3.Border.ColorIndex = 1
        series2.Name = "% Observado"
        series3.Name = "% Acumulado"
        chart.Legend.Font.Size = 8
        If cuenta_pag <> 1 Then
            fila_pie = 69 + ((cuenta_pag - 2) * 69)
        Else
            fila_pie = 69
        End If
        HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).Merge()
        HOJA_EXCEL.Range("A" & (fila_pie).ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub
    Private Sub rescata_rangos(ByVal cuenta_pag As Integer, ByRef letra As String, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal orden As Integer, ByVal nlab As Integer)
        Dim Fila_Yemas As DataRow
        Dim cuenta, fila_grafico, X As Integer
        cuenta = 64
        If cuenta_pag <> 1 Then
            fila_grafico = 50 + ((cuenta_pag - 2) * 69)
        Else
            fila_grafico = 50
        End If
        For Each Fila_Yemas In Cjto_Orden1.Tables("DIG_YEMAS").Rows
            If Fila_Yemas("OT_NUMERO") = orden And Fila_Yemas("OT_NLAB") = nlab Then
                cuenta = cuenta + 1
                letra = Chr(cuenta)
                HOJA_EXCEL.Range(letra & fila_grafico.ToString).Value = Fila_Yemas("YEM_YEMA")
                HOJA_EXCEL.Range(letra & (fila_grafico + 1).ToString).Value = Fila_Yemas("YEM_POROBSERVADAS")
                HOJA_EXCEL.Range(letra & (fila_grafico + 2).ToString).Value = Fila_Yemas("YEM_PORACUMULADA")
            End If
        Next
    End Sub
    Private Sub imprime_encabezado_parra(ByVal FechaInforme As String, ByVal CUENTA_PAGINA As Integer, ByVal NLab As Integer, ByVal orden As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim R1 As Boolean = True
        Dim FF As Integer
        Dim fila_yema As DataRow
        Dim CLAVE(2) As Object
        Dim vernom, dremite, dprod, dpredio, dlocalidad, dempresa, dvariedad, dcuartel, dEdad, dmuestreo, dingreso As String
        CLAVE(0) = CStr(orden)
        CLAVE(1) = CStr(NLab)
        For FF = 0 To 20
            CLAVE(2) = CDbl(FF)
            fila_yema = Cjto_Orden1.Tables("MYEMA").Rows.Find(CLAVE)
            If (fila_yema Is Nothing) = False Then
                If IsDBNull(fila_yema("IPRO")) = False Then dprod = fila_yema("IPRO")
                If IsDBNull(fila_yema("IREM")) = False Then dremite = fila_yema("IREM")
                If IsDBNull(fila_yema("IPRE")) = False Then dpredio = fila_yema("IPRE")
                If IsDBNull(fila_yema("ILOC")) = False Then dlocalidad = fila_yema("ILOC")
                If IsDBNull(fila_yema("IEMP")) = False Then dempresa = fila_yema("IEMP")
                If IsDBNull(fila_yema("IVAR")) = False Then dvariedad = fila_yema("IVAR")
                If IsDBNull(fila_yema("ICUA")) = False Then dcuartel = fila_yema("ICUA")
                If IsDBNull(fila_yema("IEDA")) = False Then dEdad = fila_yema("IEDA")
                If IsDBNull(fila_yema("IFEM")) = False Then dmuestreo = fila_yema("IFEM")
                If IsDBNull(fila_yema("IFEI")) = False Then dingreso = fila_yema("IFEI")
                Exit For
            End If
        Next
        HOJA_EXCEL.Range("A" & fila.ToString).Select()

        If R1 = True Then
            HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\Logo  mediano Agro.jpg").Select()
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = "LABORATORIO AGRICOLA"
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 7
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 1
        If R1 = True Then
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = "ANALISIS DE SUELO - FOLIAR - AGUA"
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 6
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 2
        'PAG
        HOJA_EXCEL.Range("DA" & fila.ToString).Value = "Pag."
        HOJA_EXCEL.Range("DA" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("DA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("DE" & fila.ToString & ":DH" & fila.ToString).Merge()
        HOJA_EXCEL.Range("DE" & fila.ToString).Value = CUENTA_PAGINA
        HOJA_EXCEL.Range("DE" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("DE" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1

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
        HOJA_EXCEL.Range("BV" & fila.ToString).Value = Format(CInt(orden), "###,###")
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CD" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        fila = fila + 1
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS DE YEMAS"
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Size = 14
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        'PRODUCTOR
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Productor"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = dprod
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'Especie
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Especie"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        vernom = "Vid"
        'Call control_nombre(vernom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'predio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Predio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = dpredio
        'Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'Variedad
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Variedad"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        vernom = dvariedad
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'EMPRESA
        'fila = fila + 1
        'HOJA_EXCEL.Range("A" & fila.ToString).Value = "Empresa"
        'HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        'vernom = dempresa
        'Call control_nombre(vernom)
        'HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        'HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'Edad()
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Edad"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        'vernom = "'" & dEdad
        'Call control_nombre(vernom, DICC)
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'fila = fila + 1
        'Remite
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Remite"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        'vernom = dremite
        'Call control_nombre(vernom)
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        ''localidad
        'fila = fila + 2
        'HOJA_EXCEL.Range("A" & fila.ToString).Value = "Localidad"
        'HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        'vernom = dlocalidad
        'Call control_nombre(vernom)
        'HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        'HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        ''F.Muestreo
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha muestreo"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = dmuestreo
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        ''F.Ingreso
        'HOJA_EXCEL.Range("CP" & fila.ToString).Value = "F.Ingreso"
        'HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CW" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        'HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("CY" & fila.ToString).Value = dingreso
        'HOJA_EXCEL.Range("CY" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'fila = fila + 1
        ''F.Informe()
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "F.del informe"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = FechaInforme
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'Cuartel
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Cuartel"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = dcuartel
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'N Lab
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Nº Lab."
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = Format(CInt(NLab), "###,###")
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'nota1
        fila = fila + 2
        HOJA_EXCEL.Range("U" & fila.ToString & ":CT" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = "NUMERO  ESTIMADO  DE  BROTES  CON  RACIMOS  (POR PARRA)   SEGÚN  LARGO"
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("U" & fila.ToString & ":CT" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'nota1
        fila = fila + 1
        HOJA_EXCEL.Range("U" & fila.ToString & ":CT" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = "Y  NUMERO  DE CARGADORES  DEJADOS  EN  LA  PODA"
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("U" & fila.ToString & ":CT" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

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

End Module
