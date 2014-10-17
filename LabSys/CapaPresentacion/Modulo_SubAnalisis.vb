Imports Microsoft.Office.Interop

Module Modulo_SubAnalisis
    Public Sub Imprime_SubAnalisis_Textura(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                           ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                           ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Arena, ArenaParentesis, Limo, LimoParentesis, Arcilla, ArcillaParentesis, Clase As String

        Arena = "Arena                (2,00 - 0,05 mm)"
        ArenaParentesis = "(2,00 - 0,05 mm)"
        Limo = "Limo                 (0,05 - 0,002 mm)"
        LimoParentesis = "(0,05 - 0,002 mm)"
        Arcilla = "Arcilla               (<  0,002 mm)"
        ArcillaParentesis = "(<  0,002 mm)"
        Fila_textura = Fila_Tex
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectTextura")
        End With


        'Arena

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Arena
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        PosicionParen = InStr(Arena, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, ArenaParentesis, PosicionParen, Arena, Fila_textura)


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("ARENA")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        'Limo
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Limo
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        PosicionParen = InStr(Limo, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, LimoParentesis, PosicionParen, Limo, Fila_textura)

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("LIMO")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        'Arcilla

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Arcilla
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(Arcilla, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, ArcillaParentesis, PosicionParen, Arcilla, Fila_textura)

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("ARC")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Clase Textural

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = "Clase Textural"
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDC & Fila_textura.ToString & ":" & COLHC & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDC & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("CLASE_TEXTURAL")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDC & Fila_textura.ToString).Font.Size = 8
        HOJA_EXCEL.Range(COLDC & Fila_textura.ToString & ":" & COLHC & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

    End Sub

    Public Sub Imprime_SubAnalisis_TexturaAreFyG(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                  ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                  ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                  ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Arena, ArenaParentesis, ArenaGruesa, ArenaFina, Limo, LimoParentesis, Arcilla, ArcillaParentesis, Clase As String

        Arena = "Arena                (2,00 - 0,05 mm)"
        ArenaParentesis = "(2,00 - 0,05 mm)"
        ArenaGruesa = "   Arena gruesa         (2,00 - 0,50 mm)"
        ArenaFina = "   Arena fina              (0,50 - 0,05 mm)"
        Limo = "Limo                 (0,05 - 0,002 mm)"
        LimoParentesis = "(0,05 - 0,002 mm)"
        Arcilla = "Arcilla               (<  0,002 mm)"
        ArcillaParentesis = "(<  0,002 mm)"
        Fila_textura = Fila_Tex
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectTextura")
        End With

        'Arena

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Arena
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        PosicionParen = InStr(Arena, "(")

        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, ArenaParentesis, PosicionParen, Arena, Fila_textura)

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("ARENA")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        'Arena Gruesa
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = ArenaGruesa
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDS & Fila_textura.ToString & ":" & COLHS & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDS & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_ARENA")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDS & Fila_textura.ToString).Font.Size = 7
        HOJA_EXCEL.Range(COLDS & Fila_textura.ToString & ":" & COLHS & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        'Arena Fina

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = ArenaFina
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDS & Fila_textura.ToString & ":" & COLHS & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDS & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_ARENA2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDS & Fila_textura.ToString).Font.Size = 7
        HOJA_EXCEL.Range(COLDS & Fila_textura.ToString & ":" & COLHS & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        'Limo
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Limo
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(Limo, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, LimoParentesis, PosicionParen, Limo, Fila_textura)

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("LIMO")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Arcilla

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Arcilla
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(Arcilla, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, ArcillaParentesis, PosicionParen, Arcilla, Fila_textura)

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("ARC")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Clase Textural

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = "Clase Textural"
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDC & Fila_textura.ToString & ":" & COLHC & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDC & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("CLASE_TEXTURAL")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDC & Fila_textura.ToString).Font.Size = 8
        HOJA_EXCEL.Range(COLDC & Fila_textura.ToString & ":" & COLHC & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

    End Sub
    Public Sub Imprime_SubAnalisis_AreGyF(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                  ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                  ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                  ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim ArenaGruesa, ArenaGruesaParentesis, ArenaFina, ArenaFinaParentesis, Clase As String

        ArenaGruesa = "Arena gruesa      (2,00 - 0,50 mm)"
        ArenaFina = "Arena fina           (0,50 - 0,05 mm)"
        ArenaGruesaParentesis = "(2,00 - 0,50 mm)"
        ArenaFinaParentesis = "(0,50 - 0,05 mm)"
        Fila_textura = Fila_Tex
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectTextura")
        End With

        'Arena Gruesa

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = ArenaGruesa
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(ArenaGruesa, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, ArenaGruesaParentesis, PosicionParen, ArenaGruesa, Fila_textura)



        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_ARENA")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHS & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        'Arena Fina

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = ArenaFina
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(ArenaFina, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, ArenaFinaParentesis, PosicionParen, ArenaFina, Fila_textura)


        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_ARENA2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


    End Sub

    Public Sub Imprime_SubAnalisis_RetencionHum(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                     ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                     ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                     ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Fila_Densidad As DataRow
        Dim BusDen(1) As Object
        Dim Retencion1, Retencion1Paren, Retencion2, Retencion2Paren, HumPeso, HumPesoParen, HumVol, HumVolParen, HumLam, HumLamParen As String
        Dim HumApro, PromRes33, PromRes15 As Double

        Retencion1 = "  0,3 bar (Capacidad de Campo)"
        Retencion1Paren = "(Capacidad de Campo)"
        Retencion2 = "15,0 bar (Pto.Marchitez Permanente)"
        Retencion2Paren = "(Pto.Marchitez Permanente)"
        HumPeso = "Humedad aprovechable (peso)"
        HumPesoParen = "(peso)"
        HumVol = "Humedad aprovechable (volumen)"
        HumVolParen = "(volumen)"
        HumLam = "Humedad aprovechable (lámina)"
        HumLamParen = "(lámina)"
        Fila_textura = Fila_Tex
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectRetencionHumedad")
        End With

        Try
            PromRes33 = (ds.Tables(0).Rows(0).Item("RESULTADO33") + ds.Tables(0).Rows(1).Item("RESULTADO33")) / 2
            PromRes15 = (ds.Tables(0).Rows(0).Item("RESULTADO15") + ds.Tables(0).Rows(1).Item("RESULTADO15")) / 2
        Catch ex As Exception
            PromRes33 = 0
            PromRes15 = 0
        End Try


        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Value = "Retención de humedad"
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Retencion 0,3 bar
        'Fila_Textura = Fila_Textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Retencion1
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(Retencion1, "(")
        Try
            If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, Retencion1Paren, PosicionParen, Retencion1, Fila_textura)

        Catch ex As Exception
            MsgBox(ex)
        End Try

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = Format(PromRes33, "##.##")
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Retencion 15,0 bar

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Retencion2
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(Retencion2, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, Retencion2Paren, PosicionParen, Retencion2, Fila_textura)

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = Format(PromRes15, "##.##")
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        'Humedad aprovechable (peso)

        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = HumPeso
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        PosicionParen = InStr(Retencion2, "(")
        If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, Retencion2Paren, PosicionParen, HumPeso, Fila_textura)

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = Format(ds.Tables(0).Rows(0).Item("HUM_APRO"), "##.##")
        Catch ex As Exception
        End Try

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        Try
            HumApro = ds.Tables(0).Rows(0).Item("HUM_APRO")
        Catch ex As Exception
        End Try

        BusDen(0) = Ot_Nlab
        BusDen(1) = "Dap_terron"
        Fila_Densidad = Cjto_Tablas1.Tables("TABLA_DIGRES").Rows.Find(BusDen)

        '****************** COMENTARIO PARA CUANDO EL CLIENTE LA PIDA 06/02/2009  *********************
        'If (Fila_Densidad Is Nothing) = False Then

        '    'Humedad aprovechable (volumen)

        '    Fila_textura = Fila_textura + 1

        '    HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = HumVol
        '    HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 8.5
        '    HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        '    PosicionParen = InStr(HumVol, "(")
        '    If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, HumVolParen, PosicionParen, HumVol, Fila_textura)

        '    HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        '    HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        '    HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        '    HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = Format((HumApro * Fila_Densidad("DIGRES_RESULTADO")), "##,##")
        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        '    'Humedad aprovechable (lámina)

        '    Fila_textura = Fila_textura + 1

        '    HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = HumLam
        '    HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 8.5
        '    HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        '    PosicionParen = InStr(HumLam, "(")
        '    If PosicionParen > 0 Then Call CambioLetra(HOJA_EXCEL, ExcelA, HumLamParen, PosicionParen, HumLam, Fila_textura)

        '    HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        '    HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        '    HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        '    HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = Format((HumApro * Fila_Densidad("DIGRES_RESULTADO")), "##,##")
        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        '    HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'End If
    End Sub


    Public Sub Imprime_SubAnalisis_Granulometria9Tamices(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                    ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                    ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                    ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz16, Tamiz8, Tamiz4, Tamiz2, Tamiz1, Tamiz05, Tamiz025, Tamiz010, Tamiz005 As String

        Tamiz16 = "              > 16,0  mm"
        Tamiz8 = "     16,0  -   8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Tamiz1 = "       2,0  -   1,0   mm"
        Tamiz05 = "       1,0  -   0,5   mm"
        Tamiz025 = "      0,50  -   0,25 mm"
        Tamiz010 = "      0,25  -   0,10 mm"
        Tamiz005 = "      0,10  -   0,05 mm"
        Fila_textura = Fila_Tex
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With


        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Value = "Granulometría (16 al 0,05)"
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft



        'Tamiz16

        'Fila_Textura = Fila_Textura + 1


        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz16
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_16")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz8
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception
        End Try

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz1
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz1
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_1")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz05
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz05
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_05")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz025
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz025
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_025")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz010
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz010
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_01")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz005
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz005
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_005")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    End Sub

    Public Sub Imprime_SubAnalisis_Granulometria5Tamices(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                        ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                        ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                        ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz8, Tamiz4, Tamiz2, Tamiz1, Tamiz05 As String

        Tamiz8 = "            >  8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Tamiz1 = "       2,0  -   1,0   mm"
        Tamiz05 = "       1,0  -   0,5   mm"
        Fila_textura = Fila_Tex

        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With

        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Value = "Granulometría (8 al 0,50)"
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Tamiz8
        'Fila_Textura = Fila_Textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz1
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz1
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_1")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz05
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz05
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_05")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub


    Public Sub Imprime_SubAnalisis_Granulometria4Tamices(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                        ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                        ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                        ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz16, Tamiz8, Tamiz4, Tamiz2 As String

        Tamiz16 = "              > 16,0  mm"
        Tamiz8 = "     16,0  -   8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Fila_textura = Fila_Tex
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With

        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Value = "Granulometría (16 al 2 mm)"
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Tamiz16
        'Fila_Textura = Fila_Textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz16
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_16")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz8
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


    End Sub


    Public Sub Imprime_SubAnalisis_Granulometria6Tamices(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                            ByVal Fila_Tex As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                            ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                            ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz16, Tamiz8, Tamiz4, Tamiz2, Tamiz1, Tamiz05 As String

        Tamiz16 = "              > 16,0  mm"
        Tamiz8 = "     16,0  -   8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Tamiz1 = "       2,0  -   1,0   mm"
        Tamiz05 = "       1,0  -   0,5   mm"
        Fila_textura = Fila_Tex

        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With

        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Value = "Granulometría (16 al 0,05)"
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_Textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Tamiz16
        'Fila_Textura = Fila_Textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz16
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_16")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz8
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz1
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz1
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_1")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz05
        Fila_textura = Fila_textura + 1

        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Value = Tamiz05
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).Merge()

        Try
            HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_05")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_textura.ToString & ":" & COLHR & Fila_textura.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Public Sub Imprime_SubAnalisis_Granulometria9TamicesQuiOrg(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                        ByVal Fila_QO As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                        ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                        ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz16, Tamiz8, Tamiz4, Tamiz2, Tamiz1, Tamiz05, Tamiz025, Tamiz010, Tamiz005 As String

        Tamiz16 = "              > 16,0  mm"
        Tamiz8 = "     16,0  -   8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Tamiz1 = "       2,0  -   1,0   mm"
        Tamiz05 = "       1,0  -   0,5   mm"
        Tamiz025 = "      0,50  -   0,25 mm"
        Tamiz010 = "      0,25  -   0,10 mm"
        Tamiz005 = "      0,10  -   0,05 mm"
        Fila_QuiOrg = Fila_QO
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With

        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = "Granulometría (16 al 0,05)"
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Tamiz16
        'Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz16
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_16")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz8
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz1
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz1
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_1")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz05
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz05
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_05")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz025
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz025
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_025")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz010
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz010
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_01")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz005
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz005
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_textura.ToString & ":AI" & Fila_textura.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_textura).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_005")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Public Sub Imprime_SubAnalisis_Granulometria5TamicesQuiOrg(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                        ByVal Fila_QO As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                        ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                        ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz8, Tamiz4, Tamiz2, Tamiz1, Tamiz05 As String

        Tamiz8 = "            >  8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Tamiz1 = "       2,0  -   1,0   mm"
        Tamiz05 = "       1,0  -   0,5   mm"
        Fila_QuiOrg = Fila_QO

        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With

        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = "Granulometría (8 al 0,50)"
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Tamiz8
        'Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz1
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz1
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_1")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz05
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz05
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_05")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

    End Sub




    Public Sub Imprime_SubAnalisis_Granulometria4TamicesQuiOrg(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                        ByVal Fila_QO As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                        ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                        ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz16, Tamiz8, Tamiz4, Tamiz2 As String

        Tamiz16 = "              > 16,0  mm"
        Tamiz8 = "     16,0  -   8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Fila_QuiOrg = Fila_QO
        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With

        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = "Granulometría (16 al 2 mm)"
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Tamiz16
        'Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz16
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_16")
        Catch ex As Exception

        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz8
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception
        End Try

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


    End Sub


    Public Sub Imprime_SubAnalisis_Granulometria6TamicesQuiOrg(ByVal ExcelA As Excel.Application, ByVal HOJA_EXCEL As Excel.Worksheet, _
                                                            ByVal Fila_QO As Integer, ByVal Ot_Nlab As Integer, ByVal COLDR As String, _
                                                            ByVal COLHR As String, ByVal COLDC As String, ByVal COLHC As String, _
                                                            ByVal COLDS As String, ByVal COLHS As String)

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim PosicionParen As Integer
        Dim Tamiz16, Tamiz8, Tamiz4, Tamiz2, Tamiz1, Tamiz05 As String

        Tamiz16 = "              > 16,0  mm"
        Tamiz8 = "     16,0  -   8,0   mm"
        Tamiz4 = "       8,0  -   4,0   mm"
        Tamiz2 = "       4,0  -   2,0   mm"
        Tamiz1 = "       2,0  -   1,0   mm"
        Tamiz05 = "       1,0  -   0,5   mm"
        Fila_QuiOrg = Fila_QO

        With SP
            .Inicializar()
            .AgregarParametro("@NLab", Ot_Nlab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectGranulometria")
        End With

        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = "Granulometría (16 al 0,05)"
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Bold = True
        'HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Tamiz16
        'Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz16
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_16")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz8
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz8
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_8")
        Catch ex As Exception

        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz4
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz4
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_4")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz2
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz2
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_2")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz1
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz1
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_1")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        'Tamiz05
        Fila_QuiOrg = Fila_QuiOrg + 1

        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Value = Tamiz05
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AB" & Fila_QuiOrg.ToString & ":AI" & Fila_QuiOrg.ToString).Merge()
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Value = "%"
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).Font.Size = 7
        HOJA_EXCEL.Range("AB" & (Fila_QuiOrg).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).Merge()
        Try
            HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Value = ds.Tables(0).Rows(0).Item("PORC_05")
        Catch ex As Exception
        End Try
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString).Font.Size = 9
        HOJA_EXCEL.Range(COLDR & Fila_QuiOrg.ToString & ":" & COLHR & Fila_QuiOrg.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Private Sub CambioLetra(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal ExcelA As Excel.Application, ByVal Nombre As String, ByVal PoscicionParen As Integer, ByVal NombreCompleto As String, ByVal Fila_Texutura As Integer)
        HOJA_EXCEL.Range("A" & Fila_Texutura.ToString).Select()
        ExcelA.ActiveCell.FormulaR1C1 = NombreCompleto

        With ExcelA.ActiveCell.Characters(Start:=PoscicionParen, Length:=Len(Nombre)).Font
            .ColorIndex = 1
            .Name = "Arial"
            .FontStyle = "Normal"
            .Size = 7
        End With
    End Sub

End Module
