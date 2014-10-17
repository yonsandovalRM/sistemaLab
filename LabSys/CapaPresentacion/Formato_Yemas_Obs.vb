Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module Formato_Yemas_Obs
    Public Sub imprime_Informe_Observacion(ByVal Des1 As String, ByVal Des2 As String, ByVal orden As Integer, ByVal nlab As Integer, ByVal FechaInforme As String, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim R1 As Boolean = True
        Dim fila_yema As DataRow
        Dim CLAVE(2) As Object
        Dim fila As Integer = 1
        Dim FF As Integer
        Dim vernom, dremite, dprod, dpredio, dlocalidad, dempresa, dvariedad, dcuartel, dEdad, dmuestreo, dingreso As String
        CLAVE(0) = CStr(orden)
        CLAVE(1) = CStr(Format(nlab, "000000"))
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
        HOJA_EXCEL.Range("DE" & fila.ToString).Value = 1 'CUENTA_PAGINA
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


        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("BV" & fila.ToString).Value = Format(CInt(orden), "###,###")
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
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
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
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
        'Variedad
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Variedad"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        'vernom = dvariedad
        'Call control_nombre(vernom)
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
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
        'localidad
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Localidad"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = dlocalidad
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
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
        'F.Informe()
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
        fila = fila + 3
        'titulo OBSERVACIONES
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Observaciones"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        Call Imprime_Observaciones(Des1, Des2, fila, HOJA_EXCEL)
        HOJA_EXCEL.Range("A11").Select()
    End Sub
    Private Sub Imprime_Observaciones(ByVal Des1 As String, ByVal Des2 As String, ByRef fila As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim fila_pie, fila_firma As Integer
        Dim CLAVE(1) As Object
        Dim fila_nota As DataRow
        fila = fila + 1
        If Des1 <> "" Then Call impsep_notas(HOJA_EXCEL, fila, Des1) : fila = fila + 1
        If Des2 <> "" Then Call impsep_notas(HOJA_EXCEL, fila, Des2)
        'firma
        fila_firma = 63
        HOJA_EXCEL.Range("BV" & fila_firma.ToString & ":DH" & fila_firma.ToString).Merge()
        HOJA_EXCEL.Range("BV" & fila_firma.ToString).Value = "Rodrigo Millan Armijo"
        HOJA_EXCEL.Range("BV" & fila_firma.ToString & ":DH" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BV" & fila_firma.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString & ":DH" & (fila_firma + 1).ToString).Merge()
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString).Value = "Ingeniero Agrónomo"
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString & ":DH" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("BV" & (fila_firma + 1).ToString).Font.Size = 9
        fila_pie = 69
        HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).Merge()
        HOJA_EXCEL.Range("A" & (fila_pie).ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
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
    Private Sub impsep_notas(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef j As Integer, ByVal query As String)
        Dim temp, temp2, acumula As String
        Dim i, concar, fila_inicial, sw As Integer
        concar = 0
        sw = 0
        fila_inicial = j + 1
        temp2 = ""
        For i = 1 To query.Length
            temp = Mid(query, i, 1)
            If Asc(temp) = 10 Then
                HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":DG" & j.ToString).Merge()
                HOJA_EXCEL.Range("A" & fila_inicial.ToString).Value = temp2
                HOJA_EXCEL.Range("A" & fila_inicial.ToString).Font.Size = 10
                HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":DG" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                temp2 = ""
                j = j + 1
                fila_inicial = j
                sw = 0
            End If
            If concar = 80 Then
                j = j + 1
                concar = 0
                sw = 1
            End If
            concar = concar + 1
            temp2 = temp2 + temp
        Next
        HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":DG" & j.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila_inicial.ToString).Value = temp2
        HOJA_EXCEL.Range("A" & fila_inicial.ToString).Font.Size = 10
        HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":DG" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
    End Sub

End Module
