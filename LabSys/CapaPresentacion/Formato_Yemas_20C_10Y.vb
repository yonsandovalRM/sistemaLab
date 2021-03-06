Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module Formato_Yemas_20C_10Y
    Private numero_cargadores(20) As Integer

    Public Sub imprime_informe_Resultado10Yemas(ByVal NumeroYemasMaximo As Integer, ByVal Des1 As String, ByVal Des2 As String, ByVal FechaInforme As String, ByVal HOJA_EXCEL As Excel.Worksheet)
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
                fila = fila + 1
                Call Imprime_Simbologia_Resultado(fila, HOJA_EXCEL)
                Call imprime_informe_parra_10Yemas(lab_aux, fila, HOJA_EXCEL, Cuenta, NumeroYemasMaximo)
                'fila = fila + 1
                Call Imprime_ComFir_Resultado(Des1, Des2, orden_aux, lab_aux, Cuenta, fila, HOJA_EXCEL)
                fila = 1 + (69 * Cuenta)
                Call imprime_encabezado_Resultado(FechaInforme, Cuenta_Pag, Fila_Yemas("OT_NLAB"), Fila_Yemas("OT_NUMERO"), fila, HOJA_EXCEL)
                Call Imprime_Detalle_Resultado(fila, HOJA_EXCEL)
                fila_inicio_borde = fila
                Cuenta = Cuenta + 1 : Cuenta_Pag = Cuenta_Pag + 1
            End If
            If CInt(ValYem) > NumeroYemasMaximo Then GoTo SALTOX10YEMAS
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
            'Obs n�
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
SALTOX10YEMAS:
            lab_aux = Fila_Yemas("OT_NLAB") : orden_aux = Fila_Yemas("OT_NUMERO")
        Next
        Call Imprime_Totales_Resultado(TotalObs, TotalFrutal, fila_inicio_borde, fila, HOJA_EXCEL)
        fila = fila + 1
        Call Imprime_Simbologia_Resultado(fila, HOJA_EXCEL)
        Call imprime_informe_parra_10Yemas(lab_aux, fila, HOJA_EXCEL, Cuenta, NumeroYemasMaximo)

        'fila = fila + 5
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

        '************************************************
        '           para yemas LabSys 
        '************************************************
        'CLAVE(1) = CStr(NLab)
        '*************************************************

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


        HOJA_EXCEL.Range("BK" & fila.ToString).Value = "N� Orden:"
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
        ' Call control_nombre(vernom)
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
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "N� Lab."
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = Format(CInt(NLab), "###,###")
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'Resultado
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "1.- Resultados"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Bold = True
    End Sub

    Private Sub Imprime_Detalle_Resultado(ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        'TITULOS DEL DETALLE *****************
        fila = fila + 1
        'Yema
        HOJA_EXCEL.Range("A" & fila.ToString & ":E" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Yema"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":E" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'CARGADOR N�
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "C a r g a d o r   N�"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        HOJA_EXCEL.Range("F" & fila.ToString & ":CF" & fila.ToString).BorderAround()
        'N� Yemas
        HOJA_EXCEL.Range("CG" & fila.ToString & ":CR" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = "N� Yemas"
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
        'N�
        HOJA_EXCEL.Range("A" & fila.ToString & ":E" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "N�"
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
        'Obs n�
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


    Private Sub Imprime_Simbologia_Resultado(ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        'SIMBOLOGIA
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "SIMBOLOGIA"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'F
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "F : Yema Primaria Frutal"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MF
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AH" & fila.ToString).Value = "MF : Yema Primaria Muerta, Secundaria Frutal"
        HOJA_EXCEL.Range("AH" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MM
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CB" & fila.ToString).Value = "MM : Yema Primaria y Secundaria Muerta"
        HOJA_EXCEL.Range("CB" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'V
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "V : Yema Primaria Vegetal"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString & ":Y" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MV
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AH" & fila.ToString).Value = "MV : Yema Primaria Muerta, Secundaria Vegetal"
        HOJA_EXCEL.Range("AH" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("AH" & fila.ToString & ":BT" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'A
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CB" & fila.ToString).Value = "A    : Yema Ausente"
        HOJA_EXCEL.Range("CB" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CB" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
    End Sub

    Private Sub Imprime_ComFir_Resultado(ByVal Des1 As String, ByVal Des2 As String, ByVal orden_aux As Integer, ByVal lab_aux As Integer, ByVal cuenta_pag As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim fila_pie, fila_firma As Integer
        Dim CLAVE(1) As Object
        Dim fila_nota As DataRow
        'firma
        If cuenta_pag <> 1 Then
            fila_firma = 66 + ((cuenta_pag - 1) * 69)
        Else
            fila_firma = 66
        End If
        HOJA_EXCEL.Range("CK" & fila_firma.ToString & ":DK" & fila_firma.ToString).Merge()
        HOJA_EXCEL.Range("CK" & fila_firma.ToString).Value = "Rodrigo Millan Armijo"
        HOJA_EXCEL.Range("CK" & fila_firma.ToString & ":DK" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CK" & fila_firma.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CK" & (fila_firma + 1).ToString & ":DK" & (fila_firma + 1).ToString).Merge()
        HOJA_EXCEL.Range("CK" & (fila_firma + 1).ToString).Value = "Ingeniero Agr�nomo"
        HOJA_EXCEL.Range("CK" & (fila_firma + 1).ToString & ":DK" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("CK" & (fila_firma + 1).ToString).Font.Size = 9
        If cuenta_pag <> 1 Then
            fila_pie = 69 + ((cuenta_pag - 1) * 69)
        Else
            fila_pie = 69
        End If
        HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).Merge()
        HOJA_EXCEL.Range("A" & (fila_pie).ToString).Value = "Jos� Domingo Ca�as # 2914   -   Santiago   -   Tel�fono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
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


#Region "Parra para 10 yemas maximo"

    Public Sub imprime_informe_parra_10Yemas(ByVal lab_aux As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal Cuenta_Pag As Integer, ByVal NumeroYemasMaximo As Integer)
        Dim Fila_Yemas, FILA_ESTIMADO As DataRow
        Dim CLAVE As Object
        Dim ValYem, fcorta, fechaf As String
        Dim Cuenta, resultado, u, fila_inicio_borde, largo, fila_merge, carga, orden As Integer
        Dim CargadorI, CargadorF, YemaI, YemaF, ContadorYemas As Integer
        Dim MyDate As Date
        MyDate = Today
        Cuenta = 0 ': Cuenta_pag = 1
        ContadorYemas = 0

        CLAVE = lab_aux
        FILA_ESTIMADO = Cjto_Orden1.Tables("ESTIMADOBRO").Rows.Find(CLAVE)
        CargadorI = FILA_ESTIMADO("CARGADOR_DESDE")
        CargadorF = FILA_ESTIMADO("CARGADOR_HASTA")
        YemaI = FILA_ESTIMADO("YEMA_DESDE")
        YemaF = FILA_ESTIMADO("YEMA_HASTA")

        Call imprime_encabezado_parra(HOJA_EXCEL, fila)
        Call Imprime_Detalle_Parra(CargadorI, CargadorF, fila, HOJA_EXCEL)
        fila_inicio_borde = fila

        For Each Fila_Yemas In Cjto_Orden1.Tables("DIG_YEMAS").Rows
            If lab_aux = Fila_Yemas("OT_NLAB") Then
                ContadorYemas = ContadorYemas + 1
                If ContadorYemas > 11 Then Exit For
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
                orden = Fila_Yemas("OT_NUMERO")
            End If
        Next

        HOJA_EXCEL.Range("A" & fila_inicio_borde.ToString & ":DK" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("A" & fila_inicio_borde.ToString & ":H" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("I" & fila_inicio_borde.ToString & ":P" & fila.ToString).BorderAround()
        Call Notas_Fijas(HOJA_EXCEL, fila)
        Call imprime_informe_Grafico(Cuenta_Pag, orden, lab_aux, fila, HOJA_EXCEL, NumeroYemasMaximo)
        HOJA_EXCEL.Range("A11").Select()
    End Sub

    Private Sub Notas_Fijas(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef fila As Integer)
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString & ":G" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Notas :"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & fila.ToString & ":G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("H" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("H" & fila.ToString).Value = "En el c�lculo no se consider� las yemas MF (Primaria Muerta, Secundaria Frutal).Para decidir tipo y largo de poda es necesario"
        HOJA_EXCEL.Range("H" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("H" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        HOJA_EXCEL.Range("H" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("H" & fila.ToString).Value = "completar esta informaci�n con calidad y di�metro de los cargadores, estado nutricional, vigor de las plantas, etc."
        HOJA_EXCEL.Range("H" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("H" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
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
        'N� CARGADOR
        HOJA_EXCEL.Range("Q" & fila.ToString & ":DK" & (fila + 1).ToString).Merge()
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = "N�    d e    c a r g a d o r e s    p o r    p a r r a"
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
        '(N� yemas)
        HOJA_EXCEL.Range("A" & fila.ToString & ":H" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "(N� yemas)"
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
    Private Sub imprime_informe_Grafico(ByVal cuenta As Integer, ByVal orden As Integer, ByVal nlab As Integer, ByVal fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal NumeroYemasMaximo As Integer)
        Dim letra As String
        Dim fila_pie, fila_rango, pixeles, fila_inicio_borde, largo, fila_merge As Integer
        Dim xlCategory, xlPrimary, xlValue, xlCategory1, xlPrimary1, xlValue1 As Excel.Axes
        fila = fila + 1
        pixeles = fila * 12
        Call rescata_rangos(cuenta, letra, HOJA_EXCEL, orden, nlab)
        Dim Grafico As Excel.ChartObjects = HOJA_EXCEL.ChartObjects(Type.Missing)
        Dim chartObj As Excel.ChartObject
        If NumeroYemasMaximo >= 9 Then
            chartObj = Grafico.Add(2, pixeles, 515, 180)  ')anchog)
        Else
            chartObj = Grafico.Add(2, pixeles, 515, 210)  ')anchog)
        End If
        Dim chart As Excel.Chart = chartObj.Chart
        If cuenta <> 1 Then
            fila_rango = 50 + (cuenta * 69)
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
        chart.ChartTitle.Characters.Text = "3.- Gr�fico fertilidad de yemas frutales vs largo del cargador"
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
            xlCategory.Item(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Largo del cargador (N� de Yemas)"
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
        'If cuenta_pag <> 1 Then
        '    fila_pie = 69 + ((cuenta_pag - 2) * 69)
        'Else
        '    fila_pie = 69
        'End If
        'HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).Merge()
        'HOJA_EXCEL.Range("A" & (fila_pie).ToString).Value = "Jos� Domingo Ca�as # 2914   -   Santiago   -   Tel�fono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        'HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub
    Private Sub rescata_rangos(ByVal cuenta As Integer, ByRef letra As String, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal orden As Integer, ByVal nlab As Integer)
        Dim Fila_Yemas As DataRow
        Dim cuentaL, fila_grafico, X As Integer
        cuentaL = 64
        If cuenta <> 1 Then
            fila_grafico = 50 + (cuenta * 69)
        Else
            fila_grafico = 50
        End If
        For Each Fila_Yemas In Cjto_Orden1.Tables("DIG_YEMAS").Rows
            If Fila_Yemas("OT_NUMERO") = orden And Fila_Yemas("OT_NLAB") = nlab Then
                cuentaL = cuentaL + 1
                letra = Chr(cuentaL)
                HOJA_EXCEL.Range(letra & fila_grafico.ToString).Value = Fila_Yemas("YEM_YEMA")
                HOJA_EXCEL.Range(letra & (fila_grafico + 1).ToString).Value = Fila_Yemas("YEM_POROBSERVADAS")
                HOJA_EXCEL.Range(letra & (fila_grafico + 2).ToString).Value = Fila_Yemas("YEM_PORACUMULADA")
            End If
        Next
    End Sub
    Private Sub imprime_encabezado_parra(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef fila As Integer)
        'nota1
        fila = fila + 2
        'HOJA_EXCEL.Range("A" & fila.ToString & ":CT" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "2.- N�mero estimado de brotes con racimos (por parra) seg�n largo y n�mero de cargadores dejados en la poda"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
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





#End Region











End Module
