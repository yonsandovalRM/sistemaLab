Imports System.Math
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop


Module M_ImprimeFactura
    Public Sub Imprime_Fact(ByVal HOJA_EXCEL As Excel.Application, ByVal objexcellibro As Excel.Workbook, _
    ByVal objHojaExcel As Excel.Worksheet, ByVal NombreRetira As String, ByVal RutRetira As String, _
    ByVal FechaRetira As String, ByVal RecintoRetira As String, ByVal FechaCancelacion As String, _
    ByVal Abono As Integer, ByVal Saldo As Integer, ByVal CantidadMu As Integer, ByVal ValorU As Integer, _
    ByVal DesctPesos As Integer, ByVal Subtotal As Integer, ByVal Muestreo As Integer, ByVal Netof As Integer, _
    ByVal Ivaf As Integer, ByVal Totalf As Integer, ByVal txtfactura As Integer, ByVal RSocial As String, _
    ByVal FechaIng As String, ByVal Direccion As String, ByVal CondicionPago As String, ByVal comuna As String, _
    ByVal Ciudad As String, ByVal OrdenCompra As Integer, ByVal rutfactura As String, ByVal obspago As String, _
    ByVal giro As String, ByVal fono1 As String, ByVal empresa As String, ByVal dscto As Integer, ByVal SolicitadoPor As String)

        Dim Total_Muestreo, Fila_Precios, i, Largo, fila, fila_merge, fila_borde, fila_pie, fila_logo, fila_nota, Muestra_Aux, Total_SF As Integer
        Dim Palabra_Valor, DIA, MES, ANO, Descripcion_Recibo, caracter, query, vernom, FechaI, CodMueC, NumLabo, Acumula As String
        Dim BUSCA, BusMue As Object
        Dim Fila_Orden, FILA_FAC_DET, FILA_MUESTRA As DataRow
        Dim fuente, destino As String
        Dim objLibroExcel As Excel.Workbook
        Dim Fdet As Integer
        Dim Via, Formula, sRutaDestino, sRutaDest As String
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
        ' ****************** Nueva sección impresión ******************
        sAño = Year(Today)
        sRutaDestino = "F:\Mis Documentos\LabSys-Pruebas\Facturas " & sAño
        If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
            MkDir(sRutaDestino)
        End If
        sRutaDest = sRutaDestino & "\" & sMes
        If Dir(sRutaDest, FileAttribute.Directory) = "" Then
            MkDir(sRutaDest)
        End If
        destino = sRutaDest & "\OT " & CStr(txtfactura) & ".xls"

        fuente = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2005\Formatos Bases\Imprimir Factura.xls"
        HOJA_EXCEL = CreateObject("EXCEL.APPLICATION")
        objLibroExcel = HOJA_EXCEL.Workbooks.Open(fuente)
        'HOJA_EXCEL.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        'objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()

        fila = 3
        HOJA_EXCEL.Range("A1").Select()
        'PRODUCTOR
        fila = fila + 2
        'numero
        HOJA_EXCEL.Range("CI" & fila.ToString & ":CS" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CI" & fila.ToString).Value = CInt(txtfactura)
        HOJA_EXCEL.Range("CI" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CI" & fila.ToString & ":CS" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        FechaI = Format(CDate(FechaIng), "dd MMMMMM yyyy")
        DIA = Mid(FechaI, 1, 2)
        MES = Trim(Mid(FechaI, 3, Len(FechaI) - 6))
        ANO = Trim(Mid(FechaI, Len(FechaI) - 4))
        fila = fila + 5
        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 13
        fila = fila + 1
        'rsocial
        HOJA_EXCEL.Range("C" & fila.ToString & ":BK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("C" & fila.ToString).Value = RSocial
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("C" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("C" & fila.ToString & ":BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'fecha dia
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BN" & fila.ToString).Value = "Fecha"
        HOJA_EXCEL.Range("BN" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = DIA & " de " & MES & " de " & ANO
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'direccion
        HOJA_EXCEL.Range("C" & fila.ToString & ":BK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("C" & fila.ToString).Value = Direccion
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("C" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("C" & fila.ToString & ":BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'comuna
        HOJA_EXCEL.Range("C" & fila.ToString & ":BK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("C" & fila.ToString).Value = comuna & ", " & Ciudad
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("C" & fila.ToString & ":BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'ciudad
        'condicion de pago
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BN" & fila.ToString).Value = "Cond.de pago"
        HOJA_EXCEL.Range("BN" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = CondicionPago
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        'rut
        HOJA_EXCEL.Range("C" & fila.ToString & ":G" & fila.ToString).Merge()
        HOJA_EXCEL.Range("C" & fila.ToString).Value = "Rut"
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("C" & fila.ToString & ":G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("H" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("I" & fila.ToString & ":BK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("I" & fila.ToString).Value = rutfactura
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("I" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("I" & fila.ToString & ":BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'orden de compra
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BN" & fila.ToString).Value = "Orden de compra"
        HOJA_EXCEL.Range("BN" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = OrdenCompra
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1
        'giro
        HOJA_EXCEL.Range("C" & fila.ToString & ":G" & fila.ToString).Merge()
        HOJA_EXCEL.Range("C" & fila.ToString).Value = "Giro"
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("C" & fila.ToString & ":G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("H" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("I" & fila.ToString & ":BK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("I" & fila.ToString).Value = giro
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("I" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("I" & fila.ToString & ":BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'orden de compra
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BN" & fila.ToString).Value = "Solicitado por"
        HOJA_EXCEL.Range("BN" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = SolicitadoPor
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1
        'fono
        HOJA_EXCEL.Range("C" & fila.ToString & ":G" & fila.ToString).Merge()
        HOJA_EXCEL.Range("C" & fila.ToString).Value = "Fono"
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("C" & fila.ToString & ":G" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("H" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("H" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("I" & fila.ToString & ":BK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("I" & fila.ToString).Value = fono1
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 10
        'HOJA_EXCEL.Range("I" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("I" & fila.ToString & ":BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'observaciones de pago
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BN" & fila.ToString).Value = "Observaciones"
        HOJA_EXCEL.Range("BN" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("BN" & fila.ToString & ":CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CE" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = obspago
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 5
        Dim Almac As Integer
        Almac = fila
        Muestra_Aux = 0
        Dim CONT As Integer
        If BanderaImprime = 1 Then
            For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE_PASO").Rows
                fila = fila + 1
                'CODIGO
                ''DESCRIPCION 
                Fila_Precios = fila
                query = FILA_FAC_DET("DET_DETALLE")
                Acumula = ""
                For i = 1 To query.Length
                    caracter = Mid(query, i, 1)
                    If Asc(caracter) = 13 Then caracter = " "
                    If Asc(caracter) = 10 Then
                        fila = fila + 1
                        Acumula = ""
                    Else
                        Acumula = Acumula + caracter
                    End If
                Next
            Next
        End If
        If fila <= 43 Then
            fila = Almac
            If BanderaImprime = 1 Then
                For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE_PASO").Rows
                    fila = fila + 1
                    'CODIGO
                    HOJA_EXCEL.Range("F" & fila.ToString & ":J" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("F" & fila.ToString).Value = FILA_FAC_DET("DET_CODIGO")
                    HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("F" & fila.ToString & ":J" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    'DESCRIPCION 
                    Fila_Precios = fila
                    query = FILA_FAC_DET("DET_DETALLE")
                    Acumula = ""
                    For i = 1 To query.Length
                        caracter = Mid(query, i, 1)
                        If Asc(caracter) = 13 Then caracter = " "
                        If Asc(caracter) = 10 Then
                            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
                            HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
                            HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8
                            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            fila = fila + 1
                            Acumula = ""
                        Else
                            Acumula = Acumula + caracter
                        End If

                    Next
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
                    HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    'CANTIDAD
                    HOJA_EXCEL.Range("CM" & fila.ToString & ":CO" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("CM" & fila.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
                    HOJA_EXCEL.Range("CM" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("CM" & fila.ToString & ":CO" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    'Precio Unitario
                    HOJA_EXCEL.Range("CP" & fila.ToString & ":CW" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("CP" & fila.ToString & ":CW" & fila.ToString).NumberFormat = "###.###"
                    HOJA_EXCEL.Range("CP" & fila.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
                    HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("CP" & fila.ToString & ":CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    'total
                    HOJA_EXCEL.Range("CX" & fila.ToString & ":DG" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("CX" & fila.ToString & ":DG" & fila.ToString).NumberFormat = "#.###.###"
                    HOJA_EXCEL.Range("CX" & fila.ToString).Value = FILA_FAC_DET("DET_TOTAL")
                    HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("CX" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    ' HOJA_EXCEL.Range("DE" & fila.ToString & ":DJ" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                Next
            End If
        Else
            Fdet = fila
            fila = Almac
            fila = fila + 2
            HOJA_EXCEL.Range("L" & fila.ToString & ":CL" & fila.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila.ToString).Value = "SEGUN DETALLE ADJUNTO"
            HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("L" & fila.ToString & ":CL" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            GoTo salto
salto2:
            MsgBox("Inserte Nueva Hoja")
            Call Detalle()
            GoTo salto3
        End If


        If BanderaImprime = 2 Then
            For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE2").Rows
                fila = fila + 1
                'CODIGO
                'HOJA_EXCEL.Range("F" & fila.ToString & ":J" & fila.ToString).Merge()
                'HOJA_EXCEL.Range("F" & fila.ToString).Value = FILA_FAC_DET("DET_CODIGO")
                'HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8
                'HOJA_EXCEL.Range("F" & fila.ToString & ":J" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                'DESCRIPCION 
                Fila_Precios = fila
                query = FILA_FAC_DET("DET_DETALLE")
                Acumula = ""
                For i = 1 To query.Length
                    caracter = Mid(query, i, 1)
                    If Asc(caracter) = 13 Then caracter = " "
                    If Asc(caracter) = 10 Then
                        'HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
                        'HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
                        'HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8
                        'HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        fila = fila + 1
                        Acumula = ""
                    Else
                        Acumula = Acumula + caracter
                    End If
                Next
            Next
        End If

        If BanderaImprime = 2 Then
            If fila <= 43 Then
                fila = Almac
                For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE2").Rows
                    fila = fila + 1
                    'CODIGO
                    HOJA_EXCEL.Range("F" & fila.ToString & ":J" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("F" & fila.ToString).Value = FILA_FAC_DET("DET_CODIGO")
                    HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("F" & fila.ToString & ":J" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    'DESCRIPCION 
                    Fila_Precios = fila
                    query = FILA_FAC_DET("DET_DETALLE")
                    Acumula = ""
                    For i = 1 To query.Length
                        caracter = Mid(query, i, 1)
                        If Asc(caracter) = 13 Then caracter = " "
                        If Asc(caracter) = 10 Then
                            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
                            HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
                            HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8
                            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            fila = fila + 1
                            Acumula = ""
                        Else
                            Acumula = Acumula + caracter
                        End If

                    Next
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
                    HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    'CANTIDAD
                    HOJA_EXCEL.Range("CM" & fila.ToString & ":CO" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("CM" & fila.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
                    HOJA_EXCEL.Range("CM" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("CM" & fila.ToString & ":CO" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    'Precio Unitario
                    HOJA_EXCEL.Range("CP" & fila.ToString & ":CW" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("CP" & fila.ToString & ":CW" & fila.ToString).NumberFormat = "###.###"
                    HOJA_EXCEL.Range("CP" & fila.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
                    HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("CP" & fila.ToString & ":CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                    'total
                    HOJA_EXCEL.Range("CX" & fila.ToString & ":DG" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("CX" & fila.ToString & ":DG" & fila.ToString).NumberFormat = "#.###.###"
                    HOJA_EXCEL.Range("CX" & fila.ToString).Value = FILA_FAC_DET("DET_TOTAL")
                    HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("CX" & fila.ToString & ":DG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                Next
            End If
        Else

        End If
        If DesctPesos <> 0 Then
            fila = fila + 2
            ' HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).BorderAround()

            HOJA_EXCEL.Range("BU" & fila.ToString & ":CJ" & fila.ToString).Merge()
            HOJA_EXCEL.Range("BU" & fila.ToString).Value = "SubTotal"
            HOJA_EXCEL.Range("BU" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("BU" & fila.ToString & ":CJ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CU" & fila.ToString & ":CV" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CU" & fila.ToString).Value = "$"
            HOJA_EXCEL.Range("CU" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CU" & fila.ToString & ":CV" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'Subtotal para descuento

            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("CW" & fila.ToString).Value = Subtotal
            HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

            fila = fila + 1

            HOJA_EXCEL.Range("BU" & fila.ToString & ":CJ" & fila.ToString).Merge()
            HOJA_EXCEL.Range("BU" & fila.ToString).Value = "Descuento" & " " & dscto & " %"
            HOJA_EXCEL.Range("BU" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("BU" & fila.ToString & ":CJ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("CU" & fila.ToString & ":CV" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CU" & fila.ToString).Value = "$"
            HOJA_EXCEL.Range("CU" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CU" & fila.ToString & ":CV" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


            'Descuento
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("CW" & fila.ToString).Value = CInt(DesctPesos) * -1
            HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            fila = fila + 1
        End If

        Total_Muestreo = 0
        If CInt(Muestreo) <> 0 Then
            fila = fila + 2
            'CANTIDAD MUESTREO
            HOJA_EXCEL.Range("CL" & fila.ToString & ":CM" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CL" & fila.ToString).Value = CantidadMu
            HOJA_EXCEL.Range("CL" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CL" & fila.ToString & ":CM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila.ToString).Value = "Servicio de Muestreo"
            HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'Precio Unitario
            HOJA_EXCEL.Range("CO" & fila.ToString & ":CU" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CO" & fila.ToString & ":CU" & fila.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("CO" & fila.ToString).Value = ValorU
            HOJA_EXCEL.Range("CO" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CO" & fila.ToString & ":CU" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            'total
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("CW" & fila.ToString).Value = Muestreo
            HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("CW" & fila.ToString & ":DC" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If
        'CALL VALOR_A_CIFRAS()
        Total_SF = Format(CInt(Totalf), "#######")
        Palabra_Valor = Letras(CStr(Total_SF))
        HOJA_EXCEL.Range("L49:CU49").Merge()
        HOJA_EXCEL.Range("L49").Value = "Son : " & UCase(Mid(Palabra_Valor, 1, 1)) & Mid(Palabra_Valor, 2) & "  pesos"
        HOJA_EXCEL.Range("L49").Font.Size = 9
        HOJA_EXCEL.Range("L49:CU49").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("L49:CU49").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        If FechaCancelacion <> "" Then
            FechaI = Format(CDate(FechaCancelacion), "dd MMMMMM yyyy")
            DIA = Mid(FechaI, 1, 2)
            MES = Trim(Mid(FechaI, 3, Len(FechaI) - 6))
            ANO = Trim(Mid(FechaI, Len(FechaI) - 1))

            'fecha dia
            HOJA_EXCEL.Range("AE48:AG48").Merge()
            HOJA_EXCEL.Range("AE48").Value = DIA
            HOJA_EXCEL.Range("AE48").Font.Size = 8
            HOJA_EXCEL.Range("AE48").Font.Bold = False
            HOJA_EXCEL.Range("AE48:AG48").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'fecha mes
            HOJA_EXCEL.Range("AN48:AX48").Merge()
            HOJA_EXCEL.Range("AN48").Value = MES
            HOJA_EXCEL.Range("AN48").Font.Size = 8
            HOJA_EXCEL.Range("AN48").Font.Bold = False
            HOJA_EXCEL.Range("AN48:AX48").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'fecha ano
            HOJA_EXCEL.Range("BD48:BF48").Merge()
            HOJA_EXCEL.Range("BD48").Value = ANO
            HOJA_EXCEL.Range("BD48").Font.Size = 8
            HOJA_EXCEL.Range("BD48").Font.Bold = False
            HOJA_EXCEL.Range("BD48:BF48").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        End If
        ' HOJA_EXCEL.Range("A52").RowHeight = 8

        'nombre retira
        HOJA_EXCEL.Range("N51:BL51").Merge()
        HOJA_EXCEL.Range("N51").Value = NombreRetira
        HOJA_EXCEL.Range("N51").Font.Size = 8
        HOJA_EXCEL.Range("N51:BL51").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("N51:BL51").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        'rut retira
        HOJA_EXCEL.Range("BP51:CC51").Merge()
        HOJA_EXCEL.Range("BP51").Value = RutRetira
        HOJA_EXCEL.Range("BP51").Font.Size = 8
        HOJA_EXCEL.Range("BP51:CC51").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BP51:CC51").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        If FechaRetira <> "" Then
            'Fecha retira
            FechaI = Format(CDate(FechaRetira), "dd MMMMMM yyyy")
            DIA = Mid(FechaI, 1, 2)
            MES = Trim(Mid(FechaI, 3, Len(FechaI) - 6))
            ANO = Trim(Mid(FechaI, Len(FechaI) - 4))
            'fecha dia
            HOJA_EXCEL.Range("N55:P55").Merge()
            HOJA_EXCEL.Range("N55").Value = DIA
            HOJA_EXCEL.Range("N55").Font.Size = 8
            HOJA_EXCEL.Range("N55").Font.Bold = False
            HOJA_EXCEL.Range("N55:P55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'fecha mes
            HOJA_EXCEL.Range("R55:U55").Merge()
            HOJA_EXCEL.Range("R55").Value = MES
            HOJA_EXCEL.Range("R55").Font.Size = 8
            HOJA_EXCEL.Range("R55").Font.Bold = False
            HOJA_EXCEL.Range("R55:U55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'fecha ano
            HOJA_EXCEL.Range("W55:AA55").Merge()
            HOJA_EXCEL.Range("W55").Value = ANO
            HOJA_EXCEL.Range("W55").Font.Size = 8
            HOJA_EXCEL.Range("W55").Font.Bold = False
            HOJA_EXCEL.Range("W55:AA55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        End If
salto:
        'Recinto
        HOJA_EXCEL.Range("AL55:BI55").Merge()
        HOJA_EXCEL.Range("AL55").Value = RecintoRetira
        HOJA_EXCEL.Range("AL55").Font.Size = 8
        HOJA_EXCEL.Range("AL55:BI55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AL55:BI55").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        'NETO
        'HOJA_EXCEL.Range("A56").RowHeight = 15
        HOJA_EXCEL.Range("CX53:DG53").Merge()
        HOJA_EXCEL.Range("CX53:DG53").NumberFormat = "###.###"
        HOJA_EXCEL.Range("CX53").Value = Netof
        HOJA_EXCEL.Range("CX53").Font.Size = 9
        HOJA_EXCEL.Range("CX53:DG53").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        'IVA (19 %)
        'HOJA_EXCEL.Range("A44").RowHeight = 15
        HOJA_EXCEL.Range("CM55:CP55").Merge()
        HOJA_EXCEL.Range("CM55").Value = "19"
        HOJA_EXCEL.Range("CM55").Font.Size = 9

        'INGRESADO POR
        'HOJA_EXCEL.Range("P44").Value = TxtNombreRetira.Text
        'HOJA_EXCEL.Range("P44").Font.Size = 9

        'IVA (VALOR)
        HOJA_EXCEL.Range("CX55:DG55").Merge()
        HOJA_EXCEL.Range("CX55:DG55").NumberFormat = "###.###"
        HOJA_EXCEL.Range("CX55").Value = Ivaf
        HOJA_EXCEL.Range("CX55").Font.Size = 9
        HOJA_EXCEL.Range("CX55:DG55").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        'TOTAL
        'HOJA_EXCEL.Range("A45").RowHeight = 15
        HOJA_EXCEL.Range("CX57:DG57").Merge()
        HOJA_EXCEL.Range("CX57:DG57").NumberFormat = "#.###.###"
        HOJA_EXCEL.Range("CX57").Value = Totalf
        HOJA_EXCEL.Range("CX57").Font.Size = 9
        HOJA_EXCEL.Range("CX57:DG57").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("A1").Select()

        HOJA_EXCEL.ActivePrinter = "OKIDATA ML320/1 TURBO en LPT1:"
        HOJA_EXCEL.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, ActivePrinter:="OKIDATA ML320/1 TURBO en LPT1:", Collate:=True)

        Try
            objHojaExcel.SaveAs(sRutaDest & "\Factura " & CStr(txtfactura) & ".xls")
        Catch ex As Exception
            objexcellibro.Close(False, , )
            HOJA_EXCEL.Quit()
        End Try

        If Fdet >= 44 Then GoTo salto2
salto3:
    End Sub

    Private Sub Detalle()
        Dim FILA_FAC_DET As DataRow
        Dim FILA As Integer
        Dim HOJA_EXCEL As Excel.Application
        Dim Acumula, Caracter, query As String
        Dim Fila_Precios, i As Integer
        Dim fuente, destino As String
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        fuente = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2005\Formatos Bases\Imprimir Detalle.xls"
        destino = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2005\Formatos Bases\Detalle.xls"
        HOJA_EXCEL = CreateObject("EXCEL.APPLICATION")
        objLibroExcel = HOJA_EXCEL.Workbooks.Open(destino)
        HOJA_EXCEL.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()

        FILA = 3
        For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE_PASO").Rows
            FILA = FILA + 1
            'CODIGO
            HOJA_EXCEL.Range("F" & FILA.ToString & ":J" & FILA.ToString).Merge()
            HOJA_EXCEL.Range("F" & FILA.ToString).Value = FILA_FAC_DET("DET_CODIGO")
            HOJA_EXCEL.Range("F" & FILA.ToString).Font.Size = 8
            HOJA_EXCEL.Range("F" & FILA.ToString & ":J" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'DESCRIPCION 
            Fila_Precios = FILA
            query = FILA_FAC_DET("DET_DETALLE")
            Acumula = ""
            For i = 1 To query.Length
                Caracter = Mid(query, i, 1)
                If Asc(Caracter) = 13 Then Caracter = " "
                If Asc(Caracter) = 10 Then
                    HOJA_EXCEL.Range("L" & FILA.ToString & ":CG" & FILA.ToString).Merge()
                    HOJA_EXCEL.Range("L" & FILA.ToString).Value = Acumula
                    HOJA_EXCEL.Range("L" & FILA.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("L" & FILA.ToString & ":CG" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    FILA = FILA + 1
                    Acumula = ""
                Else
                    Acumula = Acumula + Caracter
                End If
            Next
            HOJA_EXCEL.Range("L" & FILA.ToString & ":CG" & FILA.ToString).Merge()
            HOJA_EXCEL.Range("L" & FILA.ToString).Value = Acumula
            HOJA_EXCEL.Range("L" & FILA.ToString).Font.Size = 8
            HOJA_EXCEL.Range("L" & FILA.ToString & ":CG" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'CANTIDAD
            HOJA_EXCEL.Range("CP" & FILA.ToString & ":CR" & FILA.ToString).Merge()
            HOJA_EXCEL.Range("CP" & FILA.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
            HOJA_EXCEL.Range("CP" & FILA.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CP" & FILA.ToString & ":CR" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'Precio Unitario
            HOJA_EXCEL.Range("CU" & FILA.ToString & ":DA" & FILA.ToString).Merge()
            HOJA_EXCEL.Range("CU" & FILA.ToString & ":DA" & FILA.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("CU" & FILA.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
            HOJA_EXCEL.Range("CU" & FILA.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CU" & FILA.ToString & ":DA" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            'total
            HOJA_EXCEL.Range("DC" & FILA.ToString & ":DK" & FILA.ToString).Merge()
            HOJA_EXCEL.Range("DC" & FILA.ToString & ":DK" & FILA.ToString).NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("DC" & FILA.ToString).Value = FILA_FAC_DET("DET_TOTAL")
            HOJA_EXCEL.Range("DC" & FILA.ToString).Font.Size = 8
            HOJA_EXCEL.Range("DC" & FILA.ToString & ":DK" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            ' HOJA_EXCEL.Range("DE" & fila.ToString & ":DJ" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        Next

    End Sub
End Module
