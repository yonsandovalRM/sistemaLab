Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module Formato_Yemas_40
    Public Sub imprime_informe_Resultado_40(ByVal HOJA_EXCEL As Excel.Worksheet)
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
            If lab_aux = 0 Then
                Call imprime_encabezado_Resultado_40(Cuenta_Pag, Fila_Yemas("OT_NLAB"), Fila_Yemas("OT_NUMERO"), fila, HOJA_EXCEL)
                Call Imprime_Detalle_Resultado_40(fila, HOJA_EXCEL)
                fila_inicio_borde = fila
                Cuenta = 1 : Cuenta_Pag = 2
            End If
            If lab_aux <> Fila_Yemas("OT_NLAB") And lab_aux <> 0 Then
                Call Imprime_Totales_Resultado_40(TotalObs, TotalFrutal, fila_inicio_borde, fila, HOJA_EXCEL)
                TotalObs = 0 : TotalFrutal = 0
                fila = fila + 2
                Call Imprime_Simbologia_Resultado_40(fila, HOJA_EXCEL)
                fila = fila + 2
                Call Imprime_ComFir_Resultado_40(orden_aux, lab_aux, Cuenta, fila, HOJA_EXCEL)
                fila = 1 + (52 * Cuenta)
                Call imprime_encabezado_Resultado_40(Cuenta_Pag, Fila_Yemas("OT_NLAB"), Fila_Yemas("OT_NUMERO"), fila, HOJA_EXCEL)
                Call Imprime_Detalle_Resultado_40(fila, HOJA_EXCEL)
                fila_inicio_borde = fila
                Cuenta = Cuenta + 1 : Cuenta_Pag = Cuenta_Pag + 1
            End If
            fila = fila + 1
            ValYem = Fila_Yemas("YEM_YEMA")
            Call COLUMNA_DETALLE(HOJA_EXCEL, ValYem, "E", "I", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR1")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR1"), "J", "L", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR2")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR2"), "M", "O", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR3")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR3"), "P", "R", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR4")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR4"), "S", "U", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR5")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR5"), "V", "X", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR6")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR6"), "Y", "AA", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR7")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR7"), "AB", "AD", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR8")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR8"), "AE", "AG", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR9")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR9"), "AH", "AJ", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR10")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR10"), "AK", "AM", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR11")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR11"), "AN", "AP", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR12")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR12"), "AQ", "AS", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR13")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR13"), "AT", "AV", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR14")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR14"), "AW", "AY", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR15")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR15"), "AZ", "BB", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR16")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR16"), "BC", "BE", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR17")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR17"), "BF", "BH", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR18")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR18"), "BI", "BK", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR19")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR19"), "BL", "BN", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR20")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR20"), "BO", "BQ", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR21")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR21"), "BR", "BT", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR22")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR22"), "BU", "BW", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR23")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR23"), "BX", "BZ", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR24")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR24"), "CA", "CC", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR25")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR25"), "CD", "CF", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR26")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR26"), "CG", "CI", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR27")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR27"), "CJ", "CL", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR28")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR28"), "CM", "CO", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR29")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR29"), "CP", "CR", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR30")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR30"), "CS", "CU", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR31")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR31"), "CV", "CX", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR32")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR32"), "CY", "DA", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR33")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR33"), "DB", "DD", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR34")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR34"), "DE", "DG", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR35")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR35"), "DH", "DJ", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR36")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR36"), "DK", "DM", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR37")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR37"), "DN", "DP", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR38")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR38"), "DQ", "DS", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR39")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR39"), "DT", "DV", fila)
            If IsDBNull(Fila_Yemas("YEM_CARGADOR40")) = False Then Call COLUMNA_DETALLE(HOJA_EXCEL, Fila_Yemas("YEM_CARGADOR40"), "DW", "DY", fila)
            'Obs nº
            HOJA_EXCEL.Range("DZ" & fila.ToString & ":EE" & fila.ToString).Merge()
            HOJA_EXCEL.Range("DZ" & fila.ToString).Value = Fila_Yemas("YEM_OBSERVADAS")
            HOJA_EXCEL.Range("DZ" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("DZ" & fila.ToString & ":EE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            If IsDBNull(Fila_Yemas("YEM_OBSERVADAS")) = False Then TotalObs = TotalObs + Fila_Yemas("YEM_OBSERVADAS")
            'Frutal
            HOJA_EXCEL.Range("EF" & fila.ToString & ":EK" & fila.ToString).Merge()
            HOJA_EXCEL.Range("EF" & fila.ToString).Value = Fila_Yemas("YEM_FRUTALES")
            HOJA_EXCEL.Range("EF" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("EF" & fila.ToString & ":EK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            If IsDBNull(Fila_Yemas("YEM_FRUTALES")) = False Then TotalFrutal = TotalFrutal + Fila_Yemas("YEM_FRUTALES")
            'Obs.
            HOJA_EXCEL.Range("EL" & fila.ToString & ":EQ" & fila.ToString).Merge()
            If IsDBNull(Fila_Yemas("YEM_POROBSERVADAS")) = False Then
                If Fila_Yemas("YEM_POROBSERVADAS") = 0 Then
                    HOJA_EXCEL.Range("EL" & fila.ToString).Value = 0
                Else
                    HOJA_EXCEL.Range("EL" & fila.ToString & ":EQ" & fila.ToString).NumberFormat = "#0,0"
                    HOJA_EXCEL.Range("EL" & fila.ToString).Value = Format(CDbl(Fila_Yemas("YEM_POROBSERVADAS")), "#0.0")
                End If

                HOJA_EXCEL.Range("EL" & fila.ToString).Font.Size = 8
                HOJA_EXCEL.Range("EL" & fila.ToString & ":EQ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End If
            'Acumulado
            HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).Merge()
            If IsDBNull(Fila_Yemas("YEM_PORACUMULADA")) = False Then
                If Fila_Yemas("YEM_PORACUMULADA") = 0 Then
                    HOJA_EXCEL.Range("ER" & fila.ToString).Value = 0
                Else
                    HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).NumberFormat = "#0,0"
                    HOJA_EXCEL.Range("ER" & fila.ToString).Value = Format(CDbl(Fila_Yemas("YEM_PORACUMULADA")), "#0.0")
                End If
                HOJA_EXCEL.Range("ER" & fila.ToString).Font.Size = 8
            End If
            HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            lab_aux = Fila_Yemas("OT_NLAB") : orden_aux = Fila_Yemas("OT_NUMERO")
        Next
        Call Imprime_Totales_Resultado_40(TotalObs, TotalFrutal, fila_inicio_borde, fila, HOJA_EXCEL)
        fila = fila + 2
        Call Imprime_Simbologia_Resultado_40(fila, HOJA_EXCEL)
        fila = fila + 2
        Call Imprime_ComFir_Resultado_40(Fila_Yemas("OT_NUMERO"), Fila_Yemas("OT_NLAB"), Cuenta, fila, HOJA_EXCEL)
        HOJA_EXCEL.Range("A11").Select()
    End Sub
    Private Sub Imprime_ComFir_Resultado_40(ByVal orden_aux As Integer, ByVal lab_aux As Integer, ByVal cuenta_pag As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim fila_pie, fila_firma As Integer
        Dim CLAVE(1) As Object
        Dim Des1, Des2 As String
        Dim fila_nota As DataRow
        'firma
        If cuenta_pag <> 1 Then
            fila_firma = 48 + ((cuenta_pag - 1) * 52)
        Else
            fila_firma = 48
        End If
        HOJA_EXCEL.Range("DV" & fila_firma.ToString & ":FH" & fila_firma.ToString).Merge()
        HOJA_EXCEL.Range("DV" & fila_firma.ToString).Value = "Rodrigo Millan Armijo"
        HOJA_EXCEL.Range("DV" & fila_firma.ToString & ":FH" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("DV" & fila_firma.ToString).Font.Size = 10
        HOJA_EXCEL.Range("DV" & (fila_firma + 1).ToString & ":FH" & (fila_firma + 1).ToString).Merge()
        HOJA_EXCEL.Range("DV" & (fila_firma + 1).ToString).Value = "Ingeniero Agrónomo"
        HOJA_EXCEL.Range("DV" & (fila_firma + 1).ToString & ":FH" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("DV" & (fila_firma + 1).ToString).Font.Size = 9
        If cuenta_pag <> 1 Then
            fila_pie = 52 + ((cuenta_pag - 1) * 52)
        Else
            fila_pie = 52
        End If
        HOJA_EXCEL.Range("E" & (fila_pie).ToString & ":EZ" & (fila_pie).ToString).Merge()
        HOJA_EXCEL.Range("E" & (fila_pie).ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        HOJA_EXCEL.Range("E" & (fila_pie).ToString).Font.Size = 9
        HOJA_EXCEL.Range("E" & (fila_pie).ToString & ":EZ" & (fila_pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Private Sub Imprime_Totales_Resultado_40(ByVal TotalObs As Integer, ByVal TotalFrutal As Integer, ByVal fila_inicio_borde As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        HOJA_EXCEL.Range("E" & fila_inicio_borde.ToString & ":I" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("J" & fila_inicio_borde.ToString & ":DY" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("DZ" & fila_inicio_borde.ToString & ":EE" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("EF" & fila_inicio_borde.ToString & ":EK" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("EL" & fila_inicio_borde.ToString & ":EQ" & fila.ToString).BorderAround()
        HOJA_EXCEL.Range("ER" & fila_inicio_borde.ToString & ":EZ" & fila.ToString).BorderAround()
        fila = fila + 1
        'TOTAL YEMAS OBS
        HOJA_EXCEL.Range("DE" & fila.ToString).Value = "Total Yemas Observadas"
        HOJA_EXCEL.Range("DE" & fila.ToString).Font.Size = 8
        'Total Obs
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("DZ" & fila.ToString).Value = TotalObs
        HOJA_EXCEL.Range("DZ" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("DZ" & fila_inicio_borde.ToString & ":EE" & fila.ToString).BorderAround()
        'Total Frutal
        HOJA_EXCEL.Range("EF" & fila.ToString & ":EK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("EF" & fila.ToString).Value = TotalFrutal
        HOJA_EXCEL.Range("EF" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("EF" & fila.ToString & ":EK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("EF" & fila_inicio_borde.ToString & ":EK" & fila.ToString).BorderAround()
    End Sub


    Private Sub Imprime_Simbologia_Resultado_40(ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        'SIMBOLOGIA
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "SIMBOLOGIA"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("E" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'F
        HOJA_EXCEL.Range("E" & fila.ToString & ":AC" & fila.ToString).Merge()
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "F : Yema Primaria Frutal"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("E" & fila.ToString & ":AC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MF
        HOJA_EXCEL.Range("AL" & fila.ToString & ":BX" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AL" & fila.ToString).Value = "MF : Yema Primaria Muerta, Secundaria Frutal"
        HOJA_EXCEL.Range("AL" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AL" & fila.ToString & ":BX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MM
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DL" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = "MM : Yema Primaria y Secundaria Muerta"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'V
        HOJA_EXCEL.Range("E" & fila.ToString & ":AC" & fila.ToString).Merge()
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "V : Yema Primaria Vegetal"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("E" & fila.ToString & ":AC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'MV
        HOJA_EXCEL.Range("AL" & fila.ToString & ":BX" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AL" & fila.ToString).Value = "MV : Yema Primaria Muerta, Secundaria Vegetal"
        HOJA_EXCEL.Range("AL" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AL" & fila.ToString & ":BX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'A
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DL" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = "A    : Yema Ausente"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
    End Sub


    Private Sub Imprime_Detalle_Resultado_40(ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        'TITULOS DEL DETALLE *****************
        fila = fila + 1
        'Yema
        HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).Merge()
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Yema"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'CARGADOR Nº
        HOJA_EXCEL.Range("J" & fila.ToString & ":DY" & fila.ToString).Merge()
        HOJA_EXCEL.Range("J" & fila.ToString).Value = "C a r g a d o r   Nº"
        HOJA_EXCEL.Range("J" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("J" & fila.ToString & ":DY" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("J" & fila.ToString & ":DY" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        HOJA_EXCEL.Range("J" & fila.ToString & ":DY" & fila.ToString).BorderAround()
        'Nº Yemas
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("DZ" & fila.ToString).Value = "Nº Yemas"
        HOJA_EXCEL.Range("DZ" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EK" & fila.ToString).BorderAround()
        '% Yemas Frutales
        HOJA_EXCEL.Range("EL" & fila.ToString & ":EZ" & fila.ToString).Merge()
        HOJA_EXCEL.Range("EL" & fila.ToString).Value = "% Yemas Frutales"
        HOJA_EXCEL.Range("EL" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("EL" & fila.ToString & ":EZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("EL" & fila.ToString & ":EZ" & fila.ToString).BorderAround()

        fila = fila + 1
        'Nº
        HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).Merge()
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Nº"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        Call COLUMNA_DETALLE(HOJA_EXCEL, "1", "J", "L", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "2", "M", "O", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "3", "P", "R", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "4", "S", "U", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "5", "V", "X", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "6", "Y", "AA", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "7", "AB", "AD", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "8", "AE", "AG", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "9", "AH", "AJ", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "10", "AK", "AM", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "11", "AN", "AP", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "12", "AQ", "AS", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "13", "AT", "AV", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "14", "AW", "AY", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "15", "AZ", "BB", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "16", "BC", "BE", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "17", "BF", "BH", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "18", "BI", "BK", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "19", "BL", "BN", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "20", "BO", "BQ", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "21", "BR", "BT", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "22", "BU", "BW", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "23", "BX", "BZ", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "24", "CA", "CC", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "25", "CD", "CF", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "26", "CG", "CI", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "27", "CJ", "CL", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "28", "CM", "CO", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "29", "CP", "CR", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "30", "CS", "CU", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "31", "CV", "CX", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "32", "CY", "DA", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "33", "DB", "DD", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "34", "DE", "DG", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "35", "DH", "DJ", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "36", "DK", "DM", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "37", "DN", "DP", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "38", "DQ", "DS", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "39", "DT", "DV", fila)
        Call COLUMNA_DETALLE(HOJA_EXCEL, "40", "DW", "DY", fila)

        HOJA_EXCEL.Range("J" & fila.ToString & ":DY" & fila.ToString).BorderAround()
        'Obs nº
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("DZ" & fila.ToString).Value = "Obs."
        HOJA_EXCEL.Range("DZ" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("DZ" & fila.ToString & ":EE" & fila.ToString).BorderAround()

        'Frutal
        HOJA_EXCEL.Range("EF" & fila.ToString & ":EK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("EF" & fila.ToString).Value = "Frutal"
        HOJA_EXCEL.Range("EF" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("EF" & fila.ToString & ":EK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("EF" & fila.ToString & ":EK" & fila.ToString).BorderAround()
        'Obs.
        HOJA_EXCEL.Range("EL" & fila.ToString & ":EQ" & fila.ToString).Merge()
        HOJA_EXCEL.Range("EL" & fila.ToString).Value = "Obs."
        HOJA_EXCEL.Range("EL" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("EL" & fila.ToString & ":EQ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("EL" & fila.ToString & ":EQ" & fila.ToString).BorderAround()
        'Acumulado
        HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).Merge()
        HOJA_EXCEL.Range("ER" & fila.ToString).Value = "Acumulado"
        HOJA_EXCEL.Range("ER" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).BorderAround()
        'bordes
        HOJA_EXCEL.Range("E" & (fila - 1).ToString & ":I" & fila.ToString).BorderAround()
    End Sub


    Private Sub imprime_encabezado_Resultado_40(ByVal CUENTA_PAGINA As Integer, ByVal NLab As Integer, ByVal orden As Integer, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim R1 As Boolean = True
        Dim FF As Integer
        Dim fila_yema As DataRow
        Dim CLAVE(2) As Object
        Dim vernom, dcuartel, dvariedad, dedad, dprod, dremite, dpredio, dlocalidad, dempresa, dmuestreo, dingreso As String
        HOJA_EXCEL.Range("D" & fila.ToString).Select()
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
            HOJA_EXCEL.Range("EB" & fila.ToString & ":FC" & fila.ToString).Merge()
            HOJA_EXCEL.Range("EB" & fila.ToString).Value = "LABORATORIO AGRICOLA"
            HOJA_EXCEL.Range("EB" & fila.ToString).Font.Size = 7
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("EB" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("EB" & fila.ToString & ":FC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 1
        If R1 = True Then
            HOJA_EXCEL.Range("EB" & fila.ToString & ":FC" & fila.ToString).Merge()
            HOJA_EXCEL.Range("EB" & fila.ToString).Value = "ANALISIS DE SUELO - FOLIAR - AGUA"
            HOJA_EXCEL.Range("EB" & fila.ToString).Font.Size = 6
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("EB" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("EB" & fila.ToString & ":FC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 3
        'PAG
        HOJA_EXCEL.Range("ET" & fila.ToString).Value = "Pag."
        HOJA_EXCEL.Range("ET" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("ET" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("EX" & fila.ToString & ":EZ" & fila.ToString).Merge()
        HOJA_EXCEL.Range("EX" & fila.ToString).Value = CUENTA_PAGINA
        HOJA_EXCEL.Range("EX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("EX" & fila.ToString & ":EZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'fila = fila + 1
        HOJA_EXCEL.Range("BH" & fila.ToString).Value = "INFORME DE RESULTADOS  -"
        HOJA_EXCEL.Range("BH" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BH" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BH" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        HOJA_EXCEL.Range("CN" & fila.ToString).Value = "Nº Orden:"
        HOJA_EXCEL.Range("CN" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CN" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("CY" & fila.ToString).Value = Format(CInt(orden), "###,###")
        HOJA_EXCEL.Range("CY" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CY" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CY" & fila.ToString & ":DG" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        fila = fila + 1
        HOJA_EXCEL.Range("BM" & fila.ToString & ":CZ" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BM" & fila.ToString).Value = "ANALISIS DE YEMAS"
        HOJA_EXCEL.Range("BM" & fila.ToString).Font.Size = 14
        HOJA_EXCEL.Range("BM" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BM" & fila.ToString & ":CZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BM" & fila.ToString & ":CZ" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        'PRODUCTOR
        fila = fila + 2
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Productor"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("O" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Size = 10
        vernom = dprod
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 10
        'Especie
        HOJA_EXCEL.Range("DK" & fila.ToString).Value = "Especie"
        HOJA_EXCEL.Range("DK" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("DW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("DW" & fila.ToString).Font.Size = 10
        vernom = "Vid"
        'Call control_nombre(vernom)
        HOJA_EXCEL.Range("DY" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("DY" & fila.ToString).Font.Size = 10
        'predio
        fila = fila + 1
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Predio"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("O" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Size = 10
        vernom = dpredio
        'Call control_nombre(vernom)
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 10
        'Variedad
        HOJA_EXCEL.Range("DK" & fila.ToString).Value = "Variedad"
        HOJA_EXCEL.Range("DK" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("DW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("DW" & fila.ToString).Font.Size = 10
        vernom = dvariedad
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("DY" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("DY" & fila.ToString).Font.Size = 10
        'EMPRESA
        fila = fila + 1
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Empresa"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("O" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Size = 10
        vernom = dempresa
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 10
        'Edad
        HOJA_EXCEL.Range("DK" & fila.ToString).Value = "Edad"
        HOJA_EXCEL.Range("DK" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("DW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("DW" & fila.ToString).Font.Size = 10
        vernom = "'" & dedad
        'Call control_nombre(vernom, DICC)
        HOJA_EXCEL.Range("DY" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("DY" & fila.ToString).Font.Size = 10
        fila = fila + 1
        'Remite
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Remite"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("O" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Size = 10
        vernom = dremite
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 10
        'localidad
        fila = fila + 2
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Localidad"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("O" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Size = 10
        vernom = dlocalidad
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 10
        'F.Muestreo
        HOJA_EXCEL.Range("DK" & fila.ToString).Value = "Fecha muestreo"
        HOJA_EXCEL.Range("DK" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("DW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("DW" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("DW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("DY" & fila.ToString).Value = dmuestreo
        HOJA_EXCEL.Range("DY" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'F.Ingreso
        HOJA_EXCEL.Range("EI" & fila.ToString).Value = "F.Ingreso"
        HOJA_EXCEL.Range("EI" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("EI" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("EP" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("EP" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("EP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).Merge()
        HOJA_EXCEL.Range("ER" & fila.ToString).Value = dingreso
        HOJA_EXCEL.Range("ER" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("ER" & fila.ToString & ":EZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'fila = fila + 1
        'F.Informe()
        'HOJA_EXCEL.Range("DK" & fila.ToString).Value = "F.del informe"
        'HOJA_EXCEL.Range("DK" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        'HOJA_EXCEL.Range("DW" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("DW" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("DW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        'HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        'HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("DY" & fila.ToString).Value = "24/05/2005"
        'HOJA_EXCEL.Range("DY" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Cuartel
        fila = fila + 2
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Cuartel"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("O" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Size = 10
        vernom = dcuartel
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 10
        'N Lab
        HOJA_EXCEL.Range("DK" & fila.ToString).Value = "Nº Lab."
        HOJA_EXCEL.Range("DK" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("DW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("DW" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("DY" & fila.ToString).Value = Format(CInt(NLab), "###,###")
        HOJA_EXCEL.Range("DY" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("DY" & fila.ToString & ":EG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
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


    Private Sub impsep_notas_40(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef j As Integer, ByVal query As String)
        Dim temp, temp2, acumula As String
        Dim i, concar, fila_inicial As Integer
        concar = 0
        fila_inicial = j
        For i = 1 To query.Length
            temp = Mid(query, i, 1)
            If Asc(temp) = 10 Or concar = 160 Then
                j = j + 1
                concar = 0
            End If
            concar = concar + 1
        Next
        HOJA_EXCEL.Range("E" & fila_inicial.ToString & ":EZ" & j.ToString).Merge()
        HOJA_EXCEL.Range("E" & fila_inicial.ToString).Value = query
        HOJA_EXCEL.Range("E" & fila_inicial.ToString & ":EZ" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
    End Sub

End Module
