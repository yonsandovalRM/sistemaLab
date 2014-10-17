Imports Microsoft.Office.Interop

Module Modulo_Imprime_Revisa_Total

    Private ExcelRev As Excel.Application
    Private LibroRev As Excel.Workbook
    Private HojaRev As Excel.Worksheet
    Private sRutaDestino As String
    Private sFecha, sHora, sAño As String


    Public Sub Imprime_Revisa_Total(ByVal Grilla As DataGrid, ByVal cuenta_elementos As Integer, ByVal matriz_uni() As String)
        Dim RangoIni, RangoFin, EsMarca, sDuplicado As String
        Dim con2, IniL1, IniL2, FinL1, Finl2, NumOT_Aux As Integer
        Dim Fila_Precios, FilCu, ColEle, Largo, Fila, Fila_Inicial, Fila_Borde, Fila_Final, Fila_Logo, Fila_Nota, Muestra_Aux, Saldo, Pag As Integer

        Call Genera_Excel()

        Fila_Inicial = 2

        ExcelRev.Range("A1").Select()

        'Encabezado
        Call Cabecera_Recibo(Fila_Inicial, cuenta_elementos, matriz_uni)
        Fila = Fila_Inicial
        Try
            EsMarca = "N"
            NumOT_Aux = 0
            For FilCu = 0 To 1000
                If CodMuestraRev = 3000 Then

                End If
                sDuplicado = "N"
                If IsDBNull(Grilla.Item(FilCu, 11)) Then Exit For
                If Grilla.Item(FilCu, 11) = 0 Then Exit For
                If IsDBNull(Grilla.Item(FilCu, 10)) Then GoTo SaltoxNuloIdenti
                If Grilla.Item(FilCu, 10) = "                              Dup." And EsMarca = "S" Then EsMarca = "N" : sDuplicado = "S" : Grilla.Item(FilCu, 15) = "x"
SaltoxNuloIdenti:
                EsMarca = "S"
                Fila = Fila + 1
                If IsDBNull(Grilla.Item(FilCu, 0)) = False Then
                    If NumOT_Aux = 0 Or NumOT_Aux <> Grilla.Item(FilCu, 0) Then
                        NumOT_Aux = Grilla.Item(FilCu, 0)
                    End If
                End If
                Call Imprime_Datos_Encabezado(Grilla.Item(FilCu, 11), Fila, sDuplicado, NumOT_Aux)
                IniL1 = 65
                IniL2 = 65
                FinL1 = 65
                Finl2 = 70
                RangoIni = "AA"
                RangoFin = "AF"
                For ColEle = 1 To cuenta_elementos
                    If CodMuestraRev = 3000 And (MATRIZ_ELEMENTOS(ColEle) = "pH" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "CE" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "Ca_meq" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "Mg_meq" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "Na_meq" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "K_meq" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "Suma_Cat" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "Cl_meq" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "SO4_meq" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "HCO3_meq" Or _
                                                             MATRIZ_ELEMENTOS(ColEle) = "Suma_Ani") _
                                                        And (matriz_uni(ColEle) = "dS/m" Or _
                                                             matriz_uni(ColEle) = "meq/l" Or _
                                                             matriz_uni(ColEle) = "Cat" Or _
                                                             matriz_uni(ColEle) = "" Or _
                                                             matriz_uni(ColEle) = "Ani") Then
                        ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).Merge()
                        ExcelRev.Range(RangoIni & Fila.ToString).Value = Grilla.Item(FilCu, ColEle + 14)
                        ExcelRev.Range(RangoIni & Fila.ToString).Font.Size = 7
                        'ExcelRev.Range(RangoIni & Fila.ToString).Font.ColorIndex = ColorLetra(FilCu, ColEle)
                        ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        For con2 = 1 To 6
                            IniL2 = IniL2 + 1
                            If IniL2 = 90 Then IniL1 = IniL1 + 1 : IniL2 = 65
                        Next
                        For con2 = 1 To 6
                            Finl2 = Finl2 + 1
                            If Finl2 = 90 Then FinL1 = FinL1 + 1 : Finl2 = 65
                        Next
                        RangoIni = Chr(IniL1) & Chr(IniL2)
                        RangoFin = Chr(FinL1) & Chr(Finl2)
                    ElseIf CodMuestraRev <> 3000 Then
                        ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).Merge()
                        ExcelRev.Range(RangoIni & Fila.ToString).Value = Grilla.Item(FilCu, ColEle + 14)
                        ExcelRev.Range(RangoIni & Fila.ToString).Font.Size = 7
                        'ExcelRev.Range(RangoIni & Fila.ToString).Font.ColorIndex = ColorLetra(FilCu, ColEle)
                        ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        For con2 = 1 To 6
                            IniL2 = IniL2 + 1
                            If IniL2 = 90 Then IniL1 = IniL1 + 1 : IniL2 = 65
                        Next
                        For con2 = 1 To 6
                            Finl2 = Finl2 + 1
                            If Finl2 = 90 Then FinL1 = FinL1 + 1 : Finl2 = 65
                        Next
                        RangoIni = Chr(IniL1) & Chr(IniL2)
                        RangoFin = Chr(FinL1) & Chr(Finl2)
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
        Try
            HojaRev.SaveAs(sRutaDestino & "\Revision Total" & sFecha & " " & sHora & ".xls")
        Catch ex As Exception
            LibroRev.Close(False, , )
            ExcelRev.Quit()
        End Try
        HojaRev = Nothing
        LibroRev = Nothing
        ExcelRev = Nothing
    End Sub
    Private Sub Imprime_Datos_Encabezado(ByVal NumLabo As Integer, ByVal Fila As Integer, ByVal sDuplicado As String, ByVal NumeroOt As Integer)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Identificacion, Ident1, Ident2 As String
        Dim Productor As String
        Dim FechaIngreso As Date
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@NumOt", NumeroOt, SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectFechaIngreso")
            End With
            FechaIngreso = ds.Tables(0).Rows(0).Item("OT_FECHA_ORDEN")
        Catch ex As Exception
        End Try

        'OT
        ExcelRev.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
        ExcelRev.Range("A" & Fila.ToString).Value = NumeroOt
        ExcelRev.Range("A" & Fila.ToString).Font.Size = 8
        ExcelRev.Range("A" & Fila.ToString & ":H" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        'F.Ingreso
        ExcelRev.Range("I" & Fila.ToString & ":R" & Fila.ToString).Merge()
        ExcelRev.Range("I" & Fila.ToString).Value = FechaIngreso
        ExcelRev.Range("I" & Fila.ToString).Font.Size = 7
        ExcelRev.Range("I" & Fila.ToString & ":R" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

        'Nº Laboratorio
        ExcelRev.Range("S" & Fila.ToString & ":Z" & Fila.ToString).Merge()
        ExcelRev.Range("S" & Fila.ToString).Value = NumLabo
        ExcelRev.Range("S" & Fila.ToString).Font.Size = 8
        ExcelRev.Range("S" & Fila.ToString & ":Z" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight


    End Sub
    Private Sub Genera_Excel()
        Dim Via, Fuente, Destino, Formula As String
        Dim MyDate As Date
        Dim MyTime As Date
        MyTime = Now
        MyDate = Today
        ' ****************** Nueva sección impresión ******************
        sAño = Year(Today)
        sRutaDestino = "F:\Archivos LabSys\Revisiones\Revisiones " & sAño

        Fuente = "F:\Archivos LabSys\Formatos Labsys\Formato Revision" & ".xls"

        If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
            MkDir(sRutaDestino)
        End If
        sFecha = Format(MyDate, "ddMMyyyy")
        sHora = Format(MyTime, "hhmm")

        Destino = sRutaDestino & "\Revision Total" & sFecha & " " & sHora & ".xls"

        ExcelRev = CreateObject("EXCEL.APPLICATION")
        Try
            FileCopy(Fuente, Destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
        End Try
        LibroRev = ExcelRev.Workbooks.Open(Destino)
        ExcelRev.Visible = True
        HojaRev = LibroRev.Worksheets(1)
        HojaRev.Visible = Excel.XlSheetVisibility.xlSheetVisible
        HojaRev.Activate()
        ' ***************************************************************
    End Sub

    Private Sub Cabecera_Recibo(ByRef Fila As Integer, ByVal cuenta_elementos As Integer, ByVal matriz_uni() As String)
        Dim VerNom, RangoIni, RangoFin As String
        Dim Con, con2, IniL1, IniL2, FinL1, Finl2 As Integer
        'Titulo
        ExcelRev.Range("BA" & Fila.ToString & ":CS" & Fila.ToString).Merge()
        ExcelRev.Range("BA" & Fila.ToString).Value = "Revisión Elementos (Pantalla)"
        ExcelRev.Range("BA" & Fila.ToString).Font.Size = 14
        ExcelRev.Range("BA" & Fila.ToString).Font.Bold = True
        ExcelRev.Range("BA" & Fila.ToString & ":CS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        ExcelRev.Range("BA" & Fila.ToString & ":CS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 2
        'OT
        ExcelRev.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
        ExcelRev.Range("A" & Fila.ToString).Value = "OT"
        ExcelRev.Range("A" & Fila.ToString).Font.Size = 8

        'Fecha Ingreso
        ExcelRev.Range("I" & Fila.ToString & ":R" & Fila.ToString).Merge()
        ExcelRev.Range("I" & Fila.ToString).Value = "F.Ingreso"
        ExcelRev.Range("I" & Fila.ToString).Font.Size = 8

        'Nº Laboratorio
        ExcelRev.Range("S" & Fila.ToString & ":Z" & Fila.ToString).Merge()
        ExcelRev.Range("S" & Fila.ToString).Value = "Nº Lab"
        ExcelRev.Range("S" & Fila.ToString).Font.Size = 8


        'ELEMENTOS
        IniL1 = 65
        IniL2 = 65
        FinL1 = 65
        Finl2 = 70
        RangoIni = "AA"
        RangoFin = "AF"
        For Con = 1 To cuenta_elementos
            If CodMuestraRev = 3000 And (MATRIZ_ELEMENTOS(Con) = "pH" Or _
                                         MATRIZ_ELEMENTOS(Con) = "CE" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Ca_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Mg_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Na_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "K_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Suma_Cat" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Cl_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "SO4_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "HCO3_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Suma_Ani") _
                                    And (matriz_uni(Con) = "dS/m" Or _
                                         matriz_uni(Con) = "meq/l" Or _
                                         matriz_uni(Con) = "Cat" Or _
                                         matriz_uni(Con) = "" Or _
                                         matriz_uni(Con) = "Ani") Then
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).Merge()
                ExcelRev.Range(RangoIni & Fila.ToString).Value = MATRIZ_ELEMENTOS(Con)
                ExcelRev.Range(RangoIni & Fila.ToString).Font.Size = 7
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                For con2 = 1 To 6
                    IniL2 = IniL2 + 1
                    If IniL2 = 90 Then IniL1 = IniL1 + 1 : IniL2 = 65
                Next
                For con2 = 1 To 6
                    Finl2 = Finl2 + 1
                    If Finl2 = 90 Then FinL1 = FinL1 + 1 : Finl2 = 65
                Next
                RangoIni = Chr(IniL1) & Chr(IniL2)
                RangoFin = Chr(FinL1) & Chr(Finl2)
            ElseIf CodMuestraRev <> 3000 Then
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).Merge()
                ExcelRev.Range(RangoIni & Fila.ToString).Value = MATRIZ_ELEMENTOS(Con)
                ExcelRev.Range(RangoIni & Fila.ToString).Font.Size = 7
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                For con2 = 1 To 6
                    IniL2 = IniL2 + 1
                    If IniL2 = 90 Then IniL1 = IniL1 + 1 : IniL2 = 65
                Next
                For con2 = 1 To 6
                    Finl2 = Finl2 + 1
                    If Finl2 = 90 Then FinL1 = FinL1 + 1 : Finl2 = 65
                Next
                RangoIni = Chr(IniL1) & Chr(IniL2)
                RangoFin = Chr(FinL1) & Chr(Finl2)



            End If
        Next
        Fila = Fila + 1
        IniL1 = 65
        IniL2 = 65
        FinL1 = 65
        Finl2 = 70
        RangoIni = "AA"
        RangoFin = "AF"
        For Con = 1 To cuenta_elementos
            If CodMuestraRev = 3000 And (MATRIZ_ELEMENTOS(Con) = "pH" Or _
                                         MATRIZ_ELEMENTOS(Con) = "CE" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Ca_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Mg_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Na_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "K_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Suma_Cat" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Cl_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "SO4_meq" Or _
                                         MATRIZ_ELEMENTOS(Con) = "HCO_meq3" Or _
                                         MATRIZ_ELEMENTOS(Con) = "Suma_Ani") _
                                    And (matriz_uni(Con) = "dS/m" Or _
                                         matriz_uni(Con) = "meq/l" Or _
                                         matriz_uni(Con) = "Cat" Or _
                                         matriz_uni(Con) = "" Or _
                                         matriz_uni(Con) = "Ani") Then
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).Merge()
                ExcelRev.Range(RangoIni & Fila.ToString).Value = matriz_uni(Con)
                ExcelRev.Range(RangoIni & Fila.ToString).Font.Size = 7
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                For con2 = 1 To 6
                    IniL2 = IniL2 + 1
                    If IniL2 = 90 Then IniL1 = IniL1 + 1 : IniL2 = 65
                Next
                For con2 = 1 To 6
                    Finl2 = Finl2 + 1
                    If Finl2 = 90 Then FinL1 = FinL1 + 1 : Finl2 = 65
                Next
                RangoIni = Chr(IniL1) & Chr(IniL2)
                RangoFin = Chr(FinL1) & Chr(Finl2)
            ElseIf CodMuestraRev <> 3000 Then
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).Merge()
                ExcelRev.Range(RangoIni & Fila.ToString).Value = matriz_uni(Con)
                ExcelRev.Range(RangoIni & Fila.ToString).Font.Size = 7
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                ExcelRev.Range(RangoIni & Fila.ToString & ":" & RangoFin & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                For con2 = 1 To 6
                    IniL2 = IniL2 + 1
                    If IniL2 = 90 Then IniL1 = IniL1 + 1 : IniL2 = 65
                Next
                For con2 = 1 To 6
                    Finl2 = Finl2 + 1
                    If Finl2 = 90 Then FinL1 = FinL1 + 1 : Finl2 = 65
                Next
                RangoIni = Chr(IniL1) & Chr(IniL2)
                RangoFin = Chr(FinL1) & Chr(Finl2)
            End If





        Next
        ExcelRev.Range("A" & (Fila - 1).ToString & ":" & RangoFin & Fila.ToString).BorderAround()
    End Sub

    Private Function ColorLetra(ByVal RowNum As Integer, ByVal ColEle As Integer) As Integer
        Dim EstadoEs As String
        Dim BuscaEstado(3), BuscaEstadoDup(3) As Object
        Dim Fila_Estado As DataRow
        If MATRIZ_NLAB(RowNum) = MATRIZ_DUPLICADOS(RowNum) Then
            BuscaEstadoDup(0) = CodMuestraRev
            BuscaEstadoDup(1) = MATRIZ_DUPLICADOS(RowNum)
            BuscaEstadoDup(2) = MATRIZ_ELEMENTOS(ColEle)
            BuscaEstadoDup(3) = MATRIZ_NUMERODIGITACION(RowNum)
            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO_DUPLICADOS").Rows.Find(BuscaEstadoDup)
        Else
            BuscaEstado(0) = CodMuestraRev
            BuscaEstado(1) = MATRIZ_NLAB(RowNum)
            BuscaEstado(2) = MATRIZ_ELEMENTOS(ColEle)
            BuscaEstado(3) = MATRIZ_OT(RowNum)
            Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
        End If
        If (Fila_Estado Is Nothing) = False Then
            EstadoEs = Fila_Estado("ELE_ESTADO")
        Else
            EstadoEs = "xA"
        End If
        If EstadoEs = "DuxA" Then Return 7
        If EstadoEs = "DuxR" Then Return 13
        If EstadoEs = "DuRe" Then Return 16

        If EstadoEs = "xA" Then Return 3
        If EstadoEs = "xR" Then Return 5
        If EstadoEs = "Re" Then Return 54
        If EstadoEs = "Reot" Then Return 45
        If EstadoEs = "Nula" Then Return 38
    End Function


End Module
