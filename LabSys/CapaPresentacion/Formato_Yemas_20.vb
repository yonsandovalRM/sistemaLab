Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module Formato_Yemas_20
    Public Sub imprime_informe_Resultado(ByVal NumeroYemasMaximo As Integer, ByVal Des1 As String, ByVal Des2 As String, ByVal FechaInforme As String, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim Fila_Yemas As DataRow
        Dim ValYem, fcorta, fechaf As String
        Dim orden_aux, TotalObs, TotalFrutal, lab_aux, Cuenta_Pag, Cuenta, fila, fila_inicio_borde, largo, fila_merge As Integer
        Dim MyDate As Date
        MyDate = Today
        fila = fila + 1
        fila_inicio_borde = fila + 1
        lab_aux = 0
        Cuenta = 0 : Cuenta_Pag = 1
        TotalObs = 0 : TotalFrutal = 0
        For Each Fila_Yemas In Cjto_Orden1.Tables("DIG_YEMAS").Rows
            ValYem = Fila_Yemas("YEM_YEMA")
            If lab_aux = 0 Then
                Call imprime_encabezado_Resultado(FechaInforme, Cuenta_Pag, Fila_Yemas("OT_NLAB"), Fila_Yemas("OT_NUMERO"), fila, HOJA_EXCEL)
                Call Imprime_Detalle_Resultado(fila, HOJA_EXCEL)
                fila_inicio_borde = fila
                Cuenta = 1 : Cuenta_Pag = 2
            End If
            If lab_aux <> Fila_Yemas("OT_NLAB") And lab_aux <> 0 Then
                Call Imprime_Totales_Resultado(TotalObs, TotalFrutal, fila_inicio_borde, fila, HOJA_EXCEL)
                TotalObs = 0 : TotalFrutal = 0
                fila = fila + 2
                Call Imprime_Simbologia_Resultado(fila, HOJA_EXCEL)
                fila = fila + 5
                Call Imprime_ComFir_Resultado(Des1, Des2, orden_aux, lab_aux, Cuenta, fila, HOJA_EXCEL)
                fila = 1 + (69 * Cuenta)
                Call imprime_encabezado_Resultado(FechaInforme, Cuenta_Pag, Fila_Yemas("OT_NLAB"), Fila_Yemas("OT_NUMERO"), fila, HOJA_EXCEL)
                Call Imprime_Detalle_Resultado(fila, HOJA_EXCEL)
                fila_inicio_borde = fila
                Cuenta = Cuenta + 1 : Cuenta_Pag = Cuenta_Pag + 1
            End If
            If CInt(ValYem) > NumeroYemasMaximo Then GoTo SaltoxYemas
            fila = fila + 1
            Call COLUMNA_DETALLE(HOJA_EXCEL, ValYem, "A", "E", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR1")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR1"), "F", "H", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR2")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR2"), "J", "L", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR3")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR3"), "N", "P", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR4")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR4"), "R", "T", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR5")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR5"), "V", "X", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR6")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR6"), "Z", "AB", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR7")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR7"), "AD", "AF", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR8")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR8"), "AH", "AJ", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR9")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR9"), "AL", "AN", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR10")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR10"), "AP", "AR", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR11")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR11"), "AT", "AV", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR12")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR12"), "AX", "AZ", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR13")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR13"), "BB", "BD", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR14")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR14"), "BF", "BH", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR15")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR15"), "BJ", "BL", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR16")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR16"), "BN", "BP", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR17")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR17"), "BR", "BT", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR18")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR18"), "BV", "BX", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR19")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR19"), "BZ", "CB", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR20")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR20"), "CD", "CF", fila)
            'Obs nº
            HOJA_EXCEL.Range("CG" & fila.ToString & ":CL" & fila.ToString).Merge()
            If IsDBNull(Fila_Yemas("YEM_OBSERVADAS")) = False Then
                HOJA_EXCEL.Range("CG" & fila.ToString).Value = Fila_Yemas("YEM_OBSERVADAS")
                TotalObs = TotalObs + Fila_Yemas("YEM_OBSERVADAS")
            End If
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CG" & fila.ToString & ":CL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'Frutal
            HOJA_EXCEL.Range("CM" & fila.ToString & ":CR" & fila.ToString).Merge()
            If IsDBNull(Fila_Yemas("YEM_FRUTALES")) = False Then
                HOJA_EXCEL.Range("CM" & fila.ToString).Value = Fila_Yemas("YEM_FRUTALES")
                TotalFrutal = TotalFrutal + Fila_Yemas("YEM_FRUTALES")
            End If

            HOJA_EXCEL.Range("CM" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CM" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'Obs.
            HOJA_EXCEL.Range("CS" & fila.ToString & ":CX" & fila.ToString).Merge()
            If IsDBNull(Fila_Yemas("YEM_POROBSERVADAS")) = False Then
                If Fila_Yemas("YEM_POROBSERVADAS") = 0 Then
                    HOJA_EXCEL.Range("CS" & fila.ToString).Value = 0
                Else
                    HOJA_EXCEL.Range("CS" & fila.ToString & ":CX" & fila.ToString).NumberFormat = "#0,0"
                    HOJA_EXCEL.Range("CS" & fila.ToString).Value = Format(CDbl(Fila_Yemas("YEM_POROBSERVADAS")), "#0.0")
                End If
            End If
            HOJA_EXCEL.Range("CS" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CS" & fila.ToString & ":CX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'Acumulado
            HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).Merge()
            If IsDBNull(Fila_Yemas("YEM_PORACUMULADA")) = False Then
                If Fila_Yemas("YEM_PORACUMULADA") = 0 Then
                    HOJA_EXCEL.Range("CY" & fila.ToString).Value = 0
                Else
                    HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).NumberFormat = "#0,0"
                    HOJA_EXCEL.Range("CY" & fila.ToString).Value = Format(CDbl(Fila_Yemas("YEM_PORACUMULADA")), "#0.0")
                End If
            End If
            HOJA_EXCEL.Range("CY" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
SaltoxYemas:
            lab_aux = Fila_Yemas("OT_NLAB") : orden_aux = Fila_Yemas("OT_NUMERO")
        Next
        Call Imprime_Totales_Resultado(TotalObs, TotalFrutal, fila_inicio_borde, fila, HOJA_EXCEL)
        fila = fila + 2
        Call Imprime_Simbologia_Resultado(fila, HOJA_EXCEL)
        fila = fila + 5
        Call Imprime_ComFir_Resultado(Des1, Des2, Fila_Yemas("OT_NUMERO"), Fila_Yemas("OT_NLAB"), Cuenta, fila, HOJA_EXCEL)
        HOJA_EXCEL.Range("A11").Select()
    End Sub

    Private Sub imprime_encabezado_Resultado(ByVal FechaInforme As String, ByVal CUENTA_PAGINA As Integer, ByVal NLab As Integer, ByVal orden As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim fila_yema As DataRow
        Dim CLAVE(2) As Object
        Dim FF As Integer
        Dim R1 As Boolean = True
        Dim vernom, dremite, dprod, dpredio, dlocalidad, dempresa, dvariedad, dcuartel, dedad, dmuestreo, dingreso As String
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
                If IsDBNull(fila_yema("IEDA")) = False Then dedad = fila_yema("IEDA")
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
        'Especie
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Especie"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        vernom = "Vid"
        'Call control_nombre(vernom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
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
        'Variedad
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Variedad"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        vernom = dvariedad
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'EMPRESA
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Empresa"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = dempresa
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'Remite
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Remite"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        vernom = dremite
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'localidad
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Localidad"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = dlocalidad
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
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
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = dmuestreo
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'F.Ingreso
        HOJA_EXCEL.Range("CP" & fila.ToString).Value = "F.Ingreso"
        HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CY" & fila.ToString).Value = dingreso
        HOJA_EXCEL.Range("CY" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'F.Informe
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "F.del informe"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = FechaInforme
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
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
    End Sub

    Private Sub Imprime_Detalle_Resultado(ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        'TITULOS DEL DETALLE *****************
        fila = fila + 1
        'Yema
        HOJA_EXCEL.Range("A" & fila.ToString & ":E" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Yema"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":E" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'CARGADOR Nº
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "C a r g a d o r   Nº"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).BorderAround()
        'Nº Yemas
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CR" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = "Nº Yemas"
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CR" & fila.ToString).BorderAround()
        '% Yemas Frutales
        HOJA_EXCEL.Range("CS" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CS" & fila.ToString).Value = "% Yemas Frutales"
        HOJA_EXCEL.Range("CS" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CS" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CS" & fila.ToString & ":DG" & fila.ToString).BorderAround()

        fila = fila + 1
        'Nº
        HOJA_EXCEL.Range("A" & fila.ToString & ":E" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Nº"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":E" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        Call COLUMNA_DETALLE(HOJA_EXCEL, "1", "F", "H", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "2", "J", "L", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "3", "N", "P", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "4", "R", "T", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "5", "V", "X", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "6", "Z", "AB", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "7", "AD", "AF", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "8", "AH", "AJ", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "9", "AL", "AN", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "10", "AP", "AR", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "11", "AT", "AV", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "12", "AX", "AZ", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "13", "BB", "BD", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "14", "BF", "BH", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "15", "BJ", "BL", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "16", "BN", "BP", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "17", "BR", "BT", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "18", "BV", "BX", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "19", "BZ", "CB", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "20", "CD", "CF", fila)
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).BorderAround()
        'Obs nº
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CL" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = "Obs."
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CL" & fila.ToString).BorderAround()

        'Frutal
        HOJA_EXCEL.Range("CM" & fila.ToString & ":CR" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CM" & fila.ToString).Value = "Frutal"
        HOJA_EXCEL.Range("CM" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CM" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CM" & fila.ToString & ":CR" & fila.ToString).BorderAround()
        'Obs.
        HOJA_EXCEL.Range("CS" & fila.ToString & ":CX" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CS" & fila.ToString).Value = "Obs."
        HOJA_EXCEL.Range("CS" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CS" & fila.ToString & ":CX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CS" & fila.ToString & ":CX" & fila.ToString).BorderAround()
        'Acumulado
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CY" & fila.ToString).Value = "Acumulado"
        HOJA_EXCEL.Range("CY" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).BorderAround()
        'bordes
        HOJA_EXCEL.Range("A" & (fila - 1).ToString & ":E" & fila.ToString).BorderAround()
    End Sub

    Public Sub Imprime_Totales_Resultado(ByVal TotalObs As Integer, ByVal TotalFrutal As Integer, ByVal fila_inicio_borde As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        HOJA_EXCEL.Range("A" & fila_inicio_borde.ToString & ":E" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("F" & fila_inicio_borde.ToString & ":CF" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("CG" & fila_inicio_borde.ToString & ":CL" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("CM" & fila_inicio_borde.ToString & ":CR" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("CS" & fila_inicio_borde.ToString & ":CX" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("CY" & fila_inicio_borde.ToString & ":DG" & fila.ToString).BorderAround()
        fila = fila + 1
        'TOTAL YEMAS OBS
        HOJA_EXCEL.Range("BM" & fila.ToString).Value = "Total Yemas Observadas"
        HOJA_EXCEL.Range("BM" & fila.ToString).Font.Size = 8
        'Total Obs
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CL" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = TotalObs
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CG" & fila_inicio_borde.ToString & ":CL" & fila.ToString).BorderAround()
        'Total Frutal
        HOJA_EXCEL.Range("CM" & fila.ToString & ":CR" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CM" & fila.ToString).Value = TotalFrutal
        HOJA_EXCEL.Range("CM" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CM" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CM" & fila_inicio_borde.ToString & ":CR" & fila.ToString).BorderAround()
    End Sub

    Private Sub COLUMNA_DETALLE(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal valor As String, ByVal col1 As String, ByVal col2 As String, ByVal fila As Integer)
        If valor <> "0" Then
            HOJA_EXCEL.Range(col1 & fila.ToString & ":" & col2 & fila.ToString).Merge()
            HOJA_EXCEL.Range(col1 & fila.ToString).Value = valor
            HOJA_EXCEL.Range(col1 & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range(col1 & fila.ToString & ":" & col2 & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
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

    Private Sub Imprime_Simbologia_Resultado(ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        'SIMBOLOGIA
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "SIMBOLOGIA"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'F
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "F : Yema Primaria Frutal"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MF
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AH" & fila.ToString).Value = "MF : Yema Primaria Muerta, Secundaria Frutal"
        HOJA_EXCEL.Range("AH" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MM
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CB" & fila.ToString).Value = "MM : Yema Primaria y Secundaria Muerta"
        HOJA_EXCEL.Range("CB" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'V
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "V : Yema Primaria Vegetal"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MV
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AH" & fila.ToString).Value = "MV : Yema Primaria Muerta, Secundaria Vegetal"
        HOJA_EXCEL.Range("AH" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'A
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CB" & fila.ToString).Value = "A    : Yema Ausente"
        HOJA_EXCEL.Range("CB" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
    End Sub

    Private Sub Imprime_ComFir_Resultado(ByVal Des1 As String, ByVal Des2 As String, ByVal orden_aux As Integer, ByVal lab_aux As Integer, ByVal cuenta_pag As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim fila_pie, fila_firma As Integer
        Dim CLAVE(1) As Object
        Dim fila_nota As DataRow
        'firma
        If cuenta_pag <> 1 Then
            fila_firma = 63 + ((cuenta_pag - 1) * 69)
        Else
            fila_firma = 63
        End If
        HOJA_EXCEL.Range("BV" & fila_firma.ToString & ":DH" & fila_firma.ToString).Merge()
        HOJA_EXCEL.Range("BV" & fila_firma.ToString).Value = "Rodrigo Millan Armijo"
        HOJA_EXCEL.Range("BV" & fila_firma.ToString & ":DH" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BV" & fila_firma.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString & ":DH" & (fila_firma + 1).ToString).Merge()
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString).Value = "Ingeniero Agrónomo"
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString & ":DH" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString).Font.Size = 9
        If cuenta_pag <> 1 Then
            fila_pie = 69 + ((cuenta_pag - 1) * 69)
        Else
            fila_pie = 69
        End If
        HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).Merge()
        HOJA_EXCEL.Range("A" & (fila_pie).ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub
    Private Sub impsep_notas(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef j As Integer, ByVal query As String)
        Dim temp, temp2, acumula As String
        Dim i, concar, fila_inicial As Integer
        concar = 0
        fila_inicial = j
        For i = 1 To query.Length
            temp = Mid(query, i, 1)
            If Asc(temp) = 10 Or concar = 110 Then
                j = j + 1
                concar = 0
            End If
            concar = concar + 1
        Next
        HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":DG" & j.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila_inicial.ToString).Value = query
        HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":DG" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
    End Sub

End Module
