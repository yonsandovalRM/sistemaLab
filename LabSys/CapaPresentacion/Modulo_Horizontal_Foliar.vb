Imports Microsoft.Office.Interop

Module Modulo_Horizontal_Foliar
    Private Fila_Logo As Integer

    Public Sub Genera_Impresion_Horizontal_Foliar(ByVal NomProductor As String, ByVal NumeroOT As Integer)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim MyDate As Date
        Dim PRIMERA As String = "S"
        MyDate = Today

        Dim Fila_Ciclo As DataRow
        Dim fuente, destino, VerNom As String

        Dim objLibroExcel As Excel.Workbook
        Dim m_Excel As Excel.Application
        Dim Hoja_Excel As Excel.Worksheet
        Dim pagina, Fila As Integer


        fuente = "F:\Archivos LabSys\Formatos Labsys\Formato EmisionHorizontal.xls"
        destino = "F:\Archivos LabSys\Resultados Horizontales\Emision Horizontal Foliar " & MyDate & ".xls"
        m_Excel = CreateObject("EXCEL.APPLICATION")
        FileCopy(fuente, destino)
        objLibroExcel = m_Excel.Workbooks.Open(destino)
        m_Excel.Visible = False 'Dejar en Falso
        Hoja_Excel = objLibroExcel.Worksheets(1)
        Hoja_Excel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        Hoja_Excel.Activate()
        Fila = Fila + 1
        pagina = 1

        NomProductor = "%" & NomProductor & "%"

        With SP
            .Inicializar()
            .AgregarParametro("@NomProductor", NomProductor, SqlDbType.NVarChar)
            .AgregarParametro("@NumOtPar", NumeroOT, SqlDbType.Int)
            .EjecutarQuery("usp_SelectFormatoHorizontal")
        End With


        With SP
            .Inicializar()
            ds = .EjecutarQuery("usp_SelectInformeFoliar")
        End With

        Call Imprime_Encabezado(Hoja_Excel, pagina, Fila)
        Fila = Fila + 1

        Try
            For Each Fila_Ciclo In ds.Tables(0).Rows
                Fila = Fila + 1
                If Fila = 53 Then
                    PRIMERA = "N"
                End If
                If PRIMERA <> "S" And (Fila Mod 53 = 0) Then
                    PRIMERA = "N"
                    pagina = pagina + 1
                    Fila = Fila + 1
                    Call Imprime_Encabezado(Hoja_Excel, pagina, Fila)
                    Fila = Fila + 2
                End If

                'Predio
                If IsDBNull(Fila_Ciclo("PREDIO")) = False Then
                    VerNom = Fila_Ciclo("PREDIO")
                    Call control_nombre(VerNom)
                    Hoja_Excel.Range("A" & Fila.ToString).Value = VerNom
                    Hoja_Excel.Range("A" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Localidad
                If IsDBNull(Fila_Ciclo("LOCALIDAD")) = False Then
                    VerNom = Fila_Ciclo("LOCALIDAD")
                    Call control_nombre(VerNom)
                    Hoja_Excel.Range("B" & Fila.ToString).Value = VerNom
                    Hoja_Excel.Range("B" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("B" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Remite
                If IsDBNull(Fila_Ciclo("REMITE")) = False Then
                    VerNom = Fila_Ciclo("REMITE")
                    Call control_nombre(VerNom)
                    Hoja_Excel.Range("C" & Fila.ToString).Value = VerNom
                    Hoja_Excel.Range("C" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("C" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Fecha Muestreo
                If IsDBNull(Fila_Ciclo("FECHA_MUESTREO")) = False Then
                    Hoja_Excel.Range("D" & Fila.ToString).Value = Fila_Ciclo("FECHA_MUESTREO")
                    Hoja_Excel.Range("D" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("D" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Num Orden
                If IsDBNull(Fila_Ciclo("OT_NUMERO")) = False Then
                    Hoja_Excel.Range("E" & Fila.ToString).Value = Fila_Ciclo("OT_NUMERO")
                    Hoja_Excel.Range("E" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("E" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Especie
                If IsDBNull(Fila_Ciclo("ESPECIE")) = False Then
                    VerNom = Fila_Ciclo("ESPECIE")
                    Call control_nombre(VerNom)
                    Hoja_Excel.Range("F" & Fila.ToString).Value = VerNom
                    Hoja_Excel.Range("F" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("F" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Tejido
                If IsDBNull(Fila_Ciclo("TEJIDO")) = False Then
                    VerNom = Fila_Ciclo("TEJIDO")
                    Call control_nombre(VerNom)
                    Hoja_Excel.Range("G" & Fila.ToString).Value = VerNom
                    Hoja_Excel.Range("G" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("G" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Cuartel
                If IsDBNull(Fila_Ciclo("CUARTEL")) = False Then
                    VerNom = Fila_Ciclo("CUARTEL")
                    Call control_nombre(VerNom)
                    Hoja_Excel.Range("H" & Fila.ToString).Value = VerNom
                    Hoja_Excel.Range("H" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("H" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Variedad
                If IsDBNull(Fila_Ciclo("VARIEDAD")) = False Then
                    VerNom = Fila_Ciclo("VARIEDAD")
                    Call control_nombre(VerNom)
                    Hoja_Excel.Range("I" & Fila.ToString).Value = VerNom
                    Hoja_Excel.Range("I" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If


                'Edad
                If IsDBNull(Fila_Ciclo("EDAD")) = False Then
                    Hoja_Excel.Range("J" & Fila.ToString).Value = Fila_Ciclo("EDAD")
                    Hoja_Excel.Range("J" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("J" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Num Lab
                If IsDBNull(Fila_Ciclo("OT_NLAB")) = False Then
                    Hoja_Excel.Range("K" & Fila.ToString).Value = Fila_Ciclo("OT_NLAB")
                    Hoja_Excel.Range("K" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'N%
                If IsDBNull(Fila_Ciclo("N")) = False Then
                    Hoja_Excel.Range("L" & Fila.ToString).Value = Fila_Ciclo("N")
                    Hoja_Excel.Range("L" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("L" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'NO3 ppm
                If IsDBNull(Fila_Ciclo("NO3")) = False Then
                    Hoja_Excel.Range("M" & Fila.ToString).Value = Fila_Ciclo("NO3")
                    Hoja_Excel.Range("M" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("M" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'P%
                If IsDBNull(Fila_Ciclo("P")) = False Then
                    Hoja_Excel.Range("N" & Fila.ToString).Value = Fila_Ciclo("P")
                    Hoja_Excel.Range("N" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("N" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'K%
                If IsDBNull(Fila_Ciclo("K")) = False Then
                    Hoja_Excel.Range("O" & Fila.ToString).Value = Fila_Ciclo("K")
                    Hoja_Excel.Range("O" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Ca%
                If IsDBNull(Fila_Ciclo("Ca")) = False Then
                    Hoja_Excel.Range("P" & Fila.ToString).Value = Fila_Ciclo("Ca")
                    Hoja_Excel.Range("P" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("P" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Mg %
                If IsDBNull(Fila_Ciclo("Mg")) = False Then
                    Hoja_Excel.Range("Q" & Fila.ToString).Value = Fila_Ciclo("Mg")
                    Hoja_Excel.Range("Q" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("Q" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Zn ppm
                If IsDBNull(Fila_Ciclo("Zn")) = False Then
                    Hoja_Excel.Range("R" & Fila.ToString).Value = Fila_Ciclo("Zn")
                    Hoja_Excel.Range("R" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("R" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Mn ppm
                If IsDBNull(Fila_Ciclo("Mn")) = False Then
                    Hoja_Excel.Range("S" & Fila.ToString).Value = Fila_Ciclo("Mn")
                    Hoja_Excel.Range("S" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("S" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Fe ppm
                If IsDBNull(Fila_Ciclo("Fe")) = False Then
                    Hoja_Excel.Range("T" & Fila.ToString).Value = Fila_Ciclo("Fe")
                    Hoja_Excel.Range("T" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("T" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'Cu ppm
                If IsDBNull(Fila_Ciclo("Cu")) = False Then
                    Hoja_Excel.Range("U" & Fila.ToString).Value = Fila_Ciclo("Cu")
                    Hoja_Excel.Range("U" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If

                'B ppm
                If IsDBNull(Fila_Ciclo("B")) = False Then
                    Hoja_Excel.Range("V" & Fila.ToString).Value = Fila_Ciclo("B")
                    Hoja_Excel.Range("V" & Fila.ToString).Font.Size = 7
                    Hoja_Excel.Range("V" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                End If
            Next
            Call IMPRIME_NUMERO_PAGINAS(Hoja_Excel, pagina)
            m_Excel.Visible = True
            Try
                Hoja_Excel.Range("A8").Select()
                Hoja_Excel.SaveAs(destino)
            Catch ex As Exception
                objLibroExcel.Close(False, , )
                Hoja_Excel.Quit()
            End Try
        Catch ex As Exception
            'MsgBox("Primero debe generar el archivo")
        End Try
    End Sub

    Private Sub Imprime_Encabezado(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pagina As Integer, ByRef fila As Integer)

        'If pagina <> 1 Then fila = ((pagina - 1) * Filas_Pagina) + 1


        If pagina <> 1 Then
            Fila_Logo = fila : HOJA_EXCEL.Range("A" & Fila_Logo.ToString).Select()
        Else
            Fila_Logo = 1 : HOJA_EXCEL.Range("A" & Fila_Logo.ToString).Select()
        End If



        HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\Logo  mediano Agro.jpg").Select()

        'pag
        HOJA_EXCEL.Range("U" & fila.ToString).Value = "Pág."
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("U" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        fila = fila + 1

        HOJA_EXCEL.Range("A" & fila.ToString & ":V" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Lista Resultados Análisis Foliares"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & fila.ToString & ":V" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString & ":V" & fila.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Predio : Todos"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 8
        HOJA_EXCEL.Range("A" & fila.ToString & ":V" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'PREDIO
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString & ":A" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Predio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("A" & fila.ToString & ":A" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("A" & fila.ToString & ":A" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'LOCALIDAD
        HOJA_EXCEL.Range("B" & fila.ToString & ":B" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("B" & fila.ToString).Value = "Localidad"
        HOJA_EXCEL.Range("B" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("B" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("B" & fila.ToString & ":B" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("B" & fila.ToString & ":B" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'REMITE
        HOJA_EXCEL.Range("C" & fila.ToString & ":C" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("C" & fila.ToString).Value = "Remite"
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("C" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("C" & fila.ToString & ":C" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("C" & fila.ToString & ":C" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'FECHA MUESTREO
        HOJA_EXCEL.Range("D" & fila.ToString).Value = "Fecha"
        HOJA_EXCEL.Range("D" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("D" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("D" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("D" & fila + 1.ToString).Value = "Muestra"
        HOJA_EXCEL.Range("D" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("D" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("D" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Nº ORDEN
        HOJA_EXCEL.Range("E" & fila.ToString).Value = "Nº"
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("E" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("E" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("E" & fila + 1.ToString).Value = "Orden"
        HOJA_EXCEL.Range("E" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("E" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("E" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'ESPECIE
        HOJA_EXCEL.Range("F" & fila.ToString & ":F" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Especie"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("F" & fila.ToString & ":F" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("F" & fila.ToString & ":F" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'TEJIDO
        HOJA_EXCEL.Range("G" & fila.ToString & ":G" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("G" & fila.ToString).Value = "Tej."
        HOJA_EXCEL.Range("G" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("G" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("G" & fila.ToString & ":G" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("G" & fila.ToString & ":G" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'CUARTEL
        HOJA_EXCEL.Range("H" & fila.ToString & ":H" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("H" & fila.ToString).Value = "Cuartel"
        HOJA_EXCEL.Range("H" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("H" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("H" & fila.ToString & ":H" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("H" & fila.ToString & ":H" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'VARIEDAD
        HOJA_EXCEL.Range("I" & fila.ToString & ":I" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("I" & fila.ToString).Value = "Variedad"
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("I" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("I" & fila.ToString & ":I" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("I" & fila.ToString & ":I" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'EDAD
        HOJA_EXCEL.Range("J" & fila.ToString & ":J" & fila + 1.ToString).Merge()
        HOJA_EXCEL.Range("J" & fila.ToString).Value = "Ed."
        HOJA_EXCEL.Range("J" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("J" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("J" & fila.ToString & ":J" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("J" & fila.ToString & ":J" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Nº LAB
        HOJA_EXCEL.Range("K" & fila.ToString).Value = "Nº"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("K" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("K" & fila + 1.ToString).Value = "Lab."
        HOJA_EXCEL.Range("K" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("K" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("K" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        'N %
        HOJA_EXCEL.Range("L" & fila.ToString).Value = "N"
        HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("L" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("L" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("L" & fila + 1.ToString).Value = "%"
        HOJA_EXCEL.Range("L" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("L" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("L" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'NO3
        HOJA_EXCEL.Range("M" & fila.ToString).Value = "NO3"
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("M" & fila + 1.ToString).Value = "ppm"
        HOJA_EXCEL.Range("M" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("M" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("M" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'P %
        HOJA_EXCEL.Range("N" & fila.ToString).Value = "P"
        HOJA_EXCEL.Range("N" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("N" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("N" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("N" & fila + 1.ToString).Value = "%"
        HOJA_EXCEL.Range("N" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("N" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("N" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'K %
        HOJA_EXCEL.Range("O" & fila.ToString).Value = "K"
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("O" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("O" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("O" & fila + 1.ToString).Value = "%"
        HOJA_EXCEL.Range("O" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("O" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("O" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Ca %
        HOJA_EXCEL.Range("P" & fila.ToString).Value = "Ca"
        HOJA_EXCEL.Range("P" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("P" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("P" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("P" & fila + 1.ToString).Value = "%"
        HOJA_EXCEL.Range("P" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("P" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("P" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Mg %
        HOJA_EXCEL.Range("Q" & fila.ToString).Value = "Mg"
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("Q" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("Q" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("Q" & fila + 1.ToString).Value = "%"
        HOJA_EXCEL.Range("Q" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("Q" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("Q" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Zn ppm
        HOJA_EXCEL.Range("R" & fila.ToString).Value = "Zn"
        HOJA_EXCEL.Range("R" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("R" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("R" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("R" & fila + 1.ToString).Value = "ppm"
        HOJA_EXCEL.Range("R" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("R" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("R" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Mn ppm
        HOJA_EXCEL.Range("S" & fila.ToString).Value = "Mn"
        HOJA_EXCEL.Range("S" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("S" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("S" & fila + 1.ToString).Value = "ppm"
        HOJA_EXCEL.Range("S" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("S" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("S" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Fe ppm
        HOJA_EXCEL.Range("T" & fila.ToString).Value = "Fe"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("T" & fila + 1.ToString).Value = "ppm"
        HOJA_EXCEL.Range("T" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("T" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("T" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Cu ppm
        HOJA_EXCEL.Range("U" & fila.ToString).Value = "Cu"
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("U" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("U" & fila + 1.ToString).Value = "ppm"
        HOJA_EXCEL.Range("U" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("U" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("U" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'B ppm
        HOJA_EXCEL.Range("V" & fila.ToString).Value = "B"
        HOJA_EXCEL.Range("V" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("V" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("V" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("V" & fila + 1.ToString).Value = "ppm"
        HOJA_EXCEL.Range("V" & fila + 1.ToString).Font.Size = 7
        HOJA_EXCEL.Range("V" & fila + 1.ToString).Font.Bold = True
        HOJA_EXCEL.Range("V" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        HOJA_EXCEL.Range("A" & fila.ToString & ":V" & fila + 1.ToString).BorderAround()

    End Sub

    Public Sub IMPRIME_NUMERO_PAGINAS(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pag As Integer)
        Dim NUM_PAG, TOT_PAG, jy, filP, ult_fin, pos_pag As Integer
        Dim junto As String
        ult_fin = pag - 1
        pos_pag = 1
        For jy = 1 To pag
            If jy = 1 Then filP = pos_pag
            If jy <> 1 Then filP = pos_pag + (53 * (jy - 1))
            junto = CStr(jy & "/" & pag)
            'HOJA_EXCEL.Range("DD" & filP.ToString & ":DF" & filP.ToString).NumberFormat = "Texto"
            HOJA_EXCEL.Range("V" & filP.ToString).Value = "'" & CStr(junto)
            HOJA_EXCEL.Range("V" & filP.ToString).Font.Size = 7
            HOJA_EXCEL.Range("V" & filP.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
            HOJA_EXCEL.Range("V" & filP.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Next
    End Sub

End Module
