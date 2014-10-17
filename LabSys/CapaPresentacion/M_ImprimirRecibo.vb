Imports System.Math
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop


Module Modulo_Imprime_Recibo
    Private sRutaDest As String
    Public labsys As New LabsysDataSet8
    Private Sub Genera_Excel(ByRef HOJA_EXCEL As Microsoft.Office.Interop.Excel.Application, ByRef ObjExcelLibro As Microsoft.Office.Interop.Excel.Workbook, ByRef ObjExcelHoja As Microsoft.Office.Interop.Excel.Worksheet, ByVal numeroOT As Integer)
        Dim Via, Fuente, Destino, Formula, sRutaDestino As String
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
        sRutaDestino = "F:\Mis documentos\LabSys-Pruebas\Ordenes de Trabajo " & sAño

        Fuente = "F:\Archivos LabSys\Formatos Labsys\Formato OT.xls"

        If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
            MkDir(sRutaDestino)
        End If

        sRutaDest = sRutaDestino & "\" & sMes
        If Dir(sRutaDest, FileAttribute.Directory) = "" Then
            MkDir(sRutaDest)
        End If

        Destino = sRutaDest & "\OT " & CStr(numeroOT) & ".xls"

        HOJA_EXCEL = CreateObject("EXCEL.APPLICATION")
        'Try
        '    FileCopy(Fuente, Destino)
        'Catch ex As Exception
        '    MsgBox("Documento Abierto")
        'End Try
        ObjExcelLibro = HOJA_EXCEL.Workbooks.Open(Fuente)
        'HOJA_EXCEL.Visible = True
        ObjExcelHoja = ObjExcelLibro.Worksheets(1)
        'HOJA_EXCEL.Visible = Excel.XlSheetVisibility.xlSheetVisible
        ObjExcelHoja.Activate()

        ' ***************************************************************
    End Sub

    Private Sub Cabecera_Recibo(ByRef HOJA_EXCEL As Microsoft.Office.Interop.Excel.Application, ByRef Fila As Integer, _
                                ByVal Productor As String, ByVal Empresa As String, ByVal FechaIng As DateTime, ByVal FactRazonSocial As String, _
                                ByVal FactRut As String, ByVal FactDireccion As String, ByVal FactComuna As String, ByVal FactCiudad As String, _
                                ByVal FactGiro As String, ByVal FactFono As String, ByVal FactSolicitado As String, ByVal numeroOT As Integer)

        Dim VerNom As String

        'N° ORDEN

        'HOJA_EXCEL.Range("BU" & Fila.ToString & ":BY" & Fila.ToString).Merge()
        'HOJA_EXCEL.Range("BU" & Fila.ToString).Value = "Nº"
        'HOJA_EXCEL.Range("BU" & Fila.ToString).Font.Size = 14
        'HOJA_EXCEL.Range("BU" & Fila.ToString).Font.Bold = True
        'HOJA_EXCEL.Range("BU" & Fila.ToString & ":BY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'HOJA_EXCEL.Range("BU" & Fila.ToString & ":BY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        HOJA_EXCEL.Range("CD" & Fila.ToString & ":CP" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CD" & Fila.ToString).Value = numeroOT
        HOJA_EXCEL.Range("CD" & Fila.ToString).Font.Size = 14
        'HOJA_EXCEL.Range("CD" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CD" & Fila.ToString & ":CP" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CD" & Fila.ToString & ":CP" & Fila.ToString).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignTop
        'PRODUCTOR
        Fila = Fila + 1
        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Productor"
        HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("A" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("M" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(Productor) = False Then
            VerNom = Productor
            'Call control_nombre(vernom)
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("N" & Fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("N" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Value = "Empresa"
        'HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("BJ" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("BJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(Empresa) = False Then
            VerNom = Empresa
            If VerNom = "***" Then VerNom = ""
            'Call control_nombre(vernom)
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BK" & Fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("BK" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CS" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CJ" & Fila.ToString).Value = "F.Ingreso"
        HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CS" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CT" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CT" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter


        HOJA_EXCEL.Range("CU" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        'HOJA_EXCEL.Range("CU" & Fila.ToString & ":DJ" & Fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CU" & Fila.ToString).Value = "'" & FechaIng
        HOJA_EXCEL.Range("CU" & Fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("CU" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        Fila = Fila + 2

        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Facturar A"
        HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("A" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("M" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(FactRazonSocial) = False Then
            VerNom = FactRazonSocial
            If VerNom = "***" Then VerNom = ""
            'Call control_nombre(vernom)
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("N" & Fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("N" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Value = "R.U.T."
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("BJ" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("BJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter


        If IsDBNull(FactRut) = False Then
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BK" & Fila.ToString).Value = FactRut
            HOJA_EXCEL.Range("BK" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If


        Fila = Fila + 1

        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Dirección"
        HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("A" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("M" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(FactDireccion) = False Then
            VerNom = FactDireccion
            If VerNom = "***" Then VerNom = ""
            ' Call control_nombre(vernom)
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("N" & Fila.ToString).Value = FactDireccion
            HOJA_EXCEL.Range("N" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Value = "Comuna"
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("BJ" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("BJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(FactComuna) = False Then
            VerNom = FactComuna
            If VerNom = "***" Then VerNom = ""
            'Call control_nombre(vernom)
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BK" & Fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("BK" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CS" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CJ" & Fila.ToString).Value = "Ciudad"
        HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CS" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CT" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CT" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(FactCiudad) = False Then
            VerNom = FactCiudad
            If VerNom = "***" Then VerNom = ""
            'Call control_nombre(vernom)
            HOJA_EXCEL.Range("CU" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("CU" & Fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("CU" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CU" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        Fila = Fila + 1

        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Giro"
        HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("A" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & Fila.ToString & ":L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("M" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(FactGiro) = False Then
            VerNom = FactGiro
            If VerNom = "***" Then VerNom = ""
            'Call control_nombre(vernom)
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("N" & Fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("N" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("N" & Fila.ToString & ":AX" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Value = "Fono"
        HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AZ" & Fila.ToString & ":BI" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("BJ" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("BJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(FactGiro) = False Then
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BK" & Fila.ToString).Value = FactFono
            HOJA_EXCEL.Range("BK" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("BK" & Fila.ToString & ":CH" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CS" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CJ" & Fila.ToString).Value = "Solicita"
        HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Size = 8
        'HOJA_EXCEL.Range("CJ" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CJ" & Fila.ToString & ":CS" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CT" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CT" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If IsDBNull(FactSolicitado) = False Then
            VerNom = FactSolicitado
            If VerNom = "***" Then VerNom = ""
            'Call control_nombre(vernom)
            HOJA_EXCEL.Range("CU" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("CU" & Fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("CU" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CU" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If
    End Sub

    Public Sub Imprime_Recibo(ByVal HOJA_EXCEL As Microsoft.Office.Interop.Excel.Application, ByVal ObjExcelLibro As Microsoft.Office.Interop.Excel.Workbook, ByVal ObjExcelHoja As Microsoft.Office.Interop.Excel.Worksheet, _
                             ByVal Muestreo As Integer, ByVal Neto As Integer, ByVal Iva As Integer, _
                             ByVal Entrego As String, ByVal Total As Integer, _
                             ByVal Abono As Integer, ByVal Productor As String, ByVal Empresa As String, ByVal FechaIng As DateTime, ByVal FactRazonSocial As String, _
                             ByVal FactRut As String, ByVal FactDireccion As String, ByVal FactComuna As String, ByVal FactCiudad As String, ByVal FactGiro As String, _
                             ByVal FactFono As String, ByVal FactSolicitado As String, ByVal PorDescto As Integer, ByVal PesosDescto As Integer, ByVal numeroOT As Integer)
        Dim Via, Fuente, Destino, Formula As String
        Dim PUNTOS, PUNTOS_X, nomb, vv As String
        Dim Fila_Precios, i, Largo, Fila, Fila_Inicial, Fila_Borde, Fila_Final, Fila_Logo, Fila_Nota, Muestra_Aux, Saldo, Pag As Integer
        Dim Descripcion_Recibo, caracter, query, vernom, FechaI, CodMueC, NumLabo, Acumula As String
        Dim BUSCA, BusMue As Object
        Dim Fila_Orden, FILA_OT_COD, FILA_MUESTRA As DataRow
        ' *** Complemento a la generación de Libro Excel (09-11-2006) ***
        Dim MyDate As Date, sAño, sMes As String
        Dim ViaImpresoraMatriz As String
        Call Genera_Excel(HOJA_EXCEL, ObjExcelLibro, ObjExcelHoja, numeroOT)

        BUSCA = numeroOT
        Pag = 1
        Fila_Inicial = 1
        Fila_Final = 26
        Fila = Fila_Inicial
        PUNTOS_X = "..........................................................................................................................................................................................."

        HOJA_EXCEL.Range("A1").Select()

        'Encabezado
        Call Cabecera_Recibo(HOJA_EXCEL, Fila, Productor, Empresa, FechaIng, FactRazonSocial, FactRut, FactDireccion, FactComuna, FactCiudad, FactGiro, FactFono, FactSolicitado, numeroOT)

        labsys.Tables("OT_CODIFICACION_RECIBO").Rows.Clear()

        Dim sp As New CapaDato

        With sp
            .Inicializar()
            .AgregarParametro("@NumOT", CInt(numeroOT), SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectCodificacion", labsys, "OT_CODIFICACION_RECIBO")
        End With


        Fila = 9
        Muestra_Aux = 0
        For Each FILA_OT_COD In labsys.Tables("OT_CODIFICACION_RECIBO").Rows
            Fila = Fila
            'If Fila >= (Fila_Final - 5) Then
            '    Fila = Fila + 1
            '    Fila = (Fila_Final * Pag) + Fila_Inicial
            '    Pag = Pag + 1
            '    Fila_Final = Pag * 29
            '    Call Cabecera_Recibo(HOJA_EXCEL, Fila, Productor, Empresa, FechaIng, FactRazonSocial, FactRut, FactDireccion, FactComuna, FactCiudad, FactGiro, FactFono, FactSolicitado)
            '    Fila = Fila + 3
            'End If
            'CODIGO
            HOJA_EXCEL.Range("A" & Fila.ToString & ":F" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("A" & Fila.ToString).Value = FILA_OT_COD("ANA_CODIGO")
            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("A" & Fila.ToString & ":F" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            If Muestra_Aux = 0 Or Muestra_Aux <> CInt(Mid(CStr(FILA_OT_COD("ANA_CODIGO")), 1, 1) & "000") Then
                Descripcion_Recibo = FILA_OT_COD("MUESTRA") & ":  "
                'Nº LAB
                Largo = Len(CStr(FILA_OT_COD("OTC_NLAB_HASTA")))
                NumLabo = "Nº Laboratorio " & CStr(Format(FILA_OT_COD("OTC_NLAB_DESDE"), "###.###")) & "-" & Mid(CStr(FILA_OT_COD("OTC_NLAB_HASTA")), (Largo - 3))
                Descripcion_Recibo = Descripcion_Recibo & NumLabo

                HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).Merge()
                HOJA_EXCEL.Range("G" & Fila.ToString).Value = Descripcion_Recibo
                HOJA_EXCEL.Range("G" & Fila.ToString).Font.Size = 8
                HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                'CANTIDAD
                HOJA_EXCEL.Range("CO" & Fila.ToString & ":CR" & Fila.ToString).Merge()
                HOJA_EXCEL.Range("CO" & Fila.ToString).Value = FILA_OT_COD("OTC_CANT_MUESTRAS")
                HOJA_EXCEL.Range("CO" & Fila.ToString).Font.Size = 8
                HOJA_EXCEL.Range("CO" & Fila.ToString & ":CR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                'Precio Unitario
                HOJA_EXCEL.Range("CS" & Fila.ToString & ":DA" & Fila.ToString).Merge()
                HOJA_EXCEL.Range("CS" & Fila.ToString & ":DA" & Fila.ToString).NumberFormat = "###.###"
                HOJA_EXCEL.Range("CS" & Fila.ToString).Value = FILA_OT_COD("OTC_PRECIOUN")
                HOJA_EXCEL.Range("CS" & Fila.ToString).Font.Size = 8
                HOJA_EXCEL.Range("CS" & Fila.ToString & ":DA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                'Subtotal
                HOJA_EXCEL.Range("DB" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
                HOJA_EXCEL.Range("DB" & Fila.ToString & ":DJ" & Fila.ToString).NumberFormat = "#.###.###"
                HOJA_EXCEL.Range("DB" & Fila.ToString).Value = FILA_OT_COD("OTC_PRECIONET")
                HOJA_EXCEL.Range("DB" & Fila.ToString).Font.Size = 8
                HOJA_EXCEL.Range("DB" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                Fila = Fila + 1
                query = FILA_OT_COD("ANA_ANALISIS")
                Acumula = ""
                For i = 1 To query.Length
                    caracter = Mid(query, i, 1)
                    If Asc(caracter) = 13 Then caracter = " "
                    If Asc(caracter) = 10 Then
                        HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).Merge()
                        HOJA_EXCEL.Range("G" & Fila.ToString).Value = Acumula
                        HOJA_EXCEL.Range("G" & Fila.ToString).Font.Size = 8
                        HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        Fila = Fila + 1
                        Acumula = ""
                    Else
                        Acumula = Acumula + caracter
                    End If
                Next
                HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).Merge()
                HOJA_EXCEL.Range("G" & Fila.ToString).Value = Acumula
                HOJA_EXCEL.Range("G" & Fila.ToString).Font.Size = 8
                HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                GoTo saltoxmuestra
            End If
            'DESCRIPCION 
            query = FILA_OT_COD("ANA_ANALISIS")
            Acumula = ""
            For i = 1 To query.Length
                caracter = Mid(query, i, 1)
                If Asc(caracter) = 13 Then caracter = " "
                If Asc(caracter) = 10 Then
                    HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).Merge()
                    HOJA_EXCEL.Range("G" & Fila.ToString).Value = Acumula
                    HOJA_EXCEL.Range("G" & Fila.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Fila = Fila + 1
                    Acumula = ""
                Else
                    Acumula = Acumula + caracter
                End If
            Next
            HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("G" & Fila.ToString).Value = Acumula
            HOJA_EXCEL.Range("G" & Fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("G" & Fila.ToString & ":CN" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'Cantidad
            HOJA_EXCEL.Range("CO" & Fila.ToString & ":CR" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("CO" & Fila.ToString).Value = FILA_OT_COD("OTC_CANT_MUESTRAS")
            HOJA_EXCEL.Range("CO" & Fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CO" & Fila.ToString & ":CR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'Precio Unitario
            HOJA_EXCEL.Range("CS" & Fila.ToString & ":DA" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("CS" & Fila.ToString & ":DA" & Fila.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("CS" & Fila.ToString).Value = FILA_OT_COD("OTC_PRECIOUN")
            HOJA_EXCEL.Range("CS" & Fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CS" & Fila.ToString & ":DA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            'Subtotal
            HOJA_EXCEL.Range("DB" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("DB" & Fila.ToString & ":DJ" & Fila.ToString).NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("DB" & Fila.ToString).Value = FILA_OT_COD("OTC_PRECIONET")
            HOJA_EXCEL.Range("DB" & Fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("DB" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
SaltoxMuestra:
            Fila = Fila + 1
            Muestra_Aux = CInt(Mid(CStr(FILA_OT_COD("ANA_CODIGO")), 1, 1) & "000")
        Next
        Fila = 23
        HOJA_EXCEL.Range("A" & Fila.ToString).RowHeight = 12
        'MUESTREO
        If Muestreo <> 0 Then
            HOJA_EXCEL.Range("AO" & Fila.ToString & ":AY" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("AO" & Fila.ToString).Value = "Muestreo"
            HOJA_EXCEL.Range("AO" & Fila.ToString).Font.Size = 8
            'HOJA_EXCEL.Range("AO" & Fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("AO" & Fila.ToString & ":AY" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("AZ" & Fila.ToString).Value = ":"
            HOJA_EXCEL.Range("AZ" & Fila.ToString).Font.Size = 8

            HOJA_EXCEL.Range("BA" & Fila.ToString & ":BI" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BA" & Fila.ToString & ":BI" & Fila.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("BA" & Fila.ToString).Value = Muestreo
            HOJA_EXCEL.Range("BA" & Fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("BA" & Fila.ToString & ":BI" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        '% DESCTO
        If PorDescto <> 0 Then
            HOJA_EXCEL.Range("BO" & Fila.ToString & ":BQ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BO" & Fila.ToString).Value = PorDescto
            HOJA_EXCEL.Range("BO" & Fila.ToString).Font.Size = 8
            'HOJA_EXCEL.Range("BO" & Fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("BO" & Fila.ToString & ":BQ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("BR" & Fila.ToString & ":BY" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BR" & Fila.ToString).Value = "% Dscto"
            HOJA_EXCEL.Range("BR" & Fila.ToString).Font.Size = 8
            'HOJA_EXCEL.Range("BR" & Fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("BR" & Fila.ToString & ":BY" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("BZ" & Fila.ToString).Value = ":"
            HOJA_EXCEL.Range("BZ" & Fila.ToString).Font.Size = 8

            HOJA_EXCEL.Range("CA" & Fila.ToString & ":CJ" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("CA" & Fila.ToString & ":CJ" & Fila.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("CA" & Fila.ToString).Value = PesosDescto
            HOJA_EXCEL.Range("CA" & Fila.ToString).Font.Size = 8
            HOJA_EXCEL.Range("CA" & Fila.ToString & ":CJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        'Neto
        HOJA_EXCEL.Range("CT" & Fila.ToString & ":CY" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CT" & Fila.ToString).Value = "Neto"
        HOJA_EXCEL.Range("CT" & Fila.ToString).Font.Size = 9
        'HOJA_EXCEL.Range("CT" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CT" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight

        HOJA_EXCEL.Range("CZ" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CZ" & Fila.ToString).Font.Size = 9

        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).NumberFormat = "####.###"
        HOJA_EXCEL.Range("DA" & Fila.ToString).Value = Neto
        HOJA_EXCEL.Range("DA" & Fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight
        Fila = Fila + 1
        HOJA_EXCEL.Range("A" & Fila.ToString).RowHeight = 12
        If Abono <> 0 Then
            'abono
            Saldo = (Total - Abono) + Muestreo
            HOJA_EXCEL.Range("BS" & Fila.ToString & ":BX" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BS" & Fila.ToString).Value = "Abono"
            'HOJA_EXCEL.Range("BS" & Fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("BS" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("BS" & Fila.ToString & ":BX" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight

            HOJA_EXCEL.Range("BY" & Fila.ToString).Value = ":"
            HOJA_EXCEL.Range("BY" & Fila.ToString).Font.Size = 9

            HOJA_EXCEL.Range("BZ" & Fila.ToString & ":CG" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("BZ" & Fila.ToString & ":CG" & Fila.ToString).NumberFormat = "###.###"
            HOJA_EXCEL.Range("BZ" & Fila.ToString).Value = Abono
            HOJA_EXCEL.Range("BZ" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("BZ" & Fila.ToString & ":CG" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight
        End If
        'IVA (19 %)
        HOJA_EXCEL.Range("CP" & Fila.ToString & ":CS" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CP" & Fila.ToString).Value = "" & "%"
        'HOJA_EXCEL.Range("CP" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CP" & Fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("CP" & Fila.ToString & ":CS" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight

        HOJA_EXCEL.Range("CT" & Fila.ToString & ":CY" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CT" & Fila.ToString).Value = "IVA"
        'HOJA_EXCEL.Range("CT" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CT" & Fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("CT" & Fila.ToString & ":CY" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight

        HOJA_EXCEL.Range("CZ" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CZ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        'IVA (VALOR)
        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("DA" & Fila.ToString).Value = Iva
        HOJA_EXCEL.Range("DA" & Fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight

        Fila = Fila + 1
        HOJA_EXCEL.Range("A" & Fila.ToString).RowHeight = 12
        'INGRESADO POR
        HOJA_EXCEL.Range("A" & Fila.ToString & ":O" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & Fila.ToString).Value = "Ingresado por"
        HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & Fila.ToString & ":O" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight


        HOJA_EXCEL.Range("P" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("P" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        If Entrego <> "" Then
            HOJA_EXCEL.Range("Q" & Fila.ToString & ":BE" & Fila.ToString).Merge()
            HOJA_EXCEL.Range("Q" & Fila.ToString).Value = Entrego
            HOJA_EXCEL.Range("Q" & Fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("Q" & Fila.ToString & ":BE" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
        End If

        'If Saldo <> 0 Then
        '    HOJA_EXCEL.Range("BQ" & Fila.ToString & ":BY" & Fila.ToString).Merge()
        '    HOJA_EXCEL.Range("BQ" & Fila.ToString).Value = "SALDO"
        '    HOJA_EXCEL.Range("BQ" & Fila.ToString).Font.Size = 9
        '    HOJA_EXCEL.Range("BZ" & Fila.ToString).Value = ":"
        '    HOJA_EXCEL.Range("BZ" & Fila.ToString).Font.Size = 9

        '    HOJA_EXCEL.Range("CA" & Fila.ToString & ":CM" & Fila.ToString).Merge()
        '    HOJA_EXCEL.Range("CA" & Fila.ToString & ":CM" & Fila.ToString).NumberFormat = "###.###"
        '    HOJA_EXCEL.Range("CA" & Fila.ToString).Value = Saldo
        '    HOJA_EXCEL.Range("CA" & Fila.ToString).Font.Size = 8.5
        '    HOJA_EXCEL.Range("CA" & Fila.ToString & ":CM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        'End If

        HOJA_EXCEL.Range("CT" & Fila.ToString & ":CY" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("CT" & Fila.ToString).Value = "Total"
        HOJA_EXCEL.Range("CT" & Fila.ToString).Font.Size = 9
        'HOJA_EXCEL.Range("CT" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("CT" & Fila.ToString & ":CY" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight

        HOJA_EXCEL.Range("CZ" & Fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CZ" & Fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("CZ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).NumberFormat = "####.###"
        HOJA_EXCEL.Range("DA" & Fila.ToString).Value = Total
        HOJA_EXCEL.Range("DA" & Fila.ToString).Font.Size = 9
        'HOJA_EXCEL.Range("DA" & Fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("DA" & Fila.ToString & ":DJ" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight

        Fila = Fila + 3
        HOJA_EXCEL.Range("A1" & Fila.ToString).Select()

        ViaImpresoraMatriz = impresora_ot '"\\RECEPCION-HP\OKIDATA ML320/1 TURBO en Ne05:" '"Okidata ML 320 Turbo/D (IBM) en Ne00:" 		ViaImpresoraMatriz	"\\AGRO2\HP P2015 Sin Logo en Ne04:"	String


        HOJA_EXCEL.ActivePrinter = ViaImpresoraMatriz
        MsgBox("Impresora:'" & (ViaImpresoraMatriz) & "'")
        HOJA_EXCEL.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, ActivePrinter:=ViaImpresoraMatriz, Collate:=True)
        'ViaImpresoraMatriz = HOJA_EXCEL.ActivePrinter.ToString
        'HOJA_EXCEL.ActivePrinter = ViaImpresoraMatriz
        'HOJA_EXCEL.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, ActivePrinter:=ViaImpresoraMatriz, Collate:=True)

        'HOJA_EXCEL.ActivePrinter = "\\AGROSERV\HP LaserJet P2015 Series PCL 6(Sin Logo) en Ne02:"
        'HOJA_EXCEL.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, ActivePrinter:="\\AGROSERV\HP LaserJet P2015 Series PCL 6(Sin Logo) en Ne02:", Collate:=True)

        Try
            ObjExcelHoja.SaveAs(sRutaDest & "\OT " & CStr(numeroOT) & ".xls")
        Catch ex As Exception
            ObjExcelLibro.Close(False, , )
            HOJA_EXCEL.Quit()
        End Try
    End Sub

End Module
