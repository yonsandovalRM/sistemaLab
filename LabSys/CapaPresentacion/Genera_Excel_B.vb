Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class Genera_Excel_B
    Friend ExcelA As Excel.Application
    Friend LibroE As Excel.Workbook
    Friend HojaE As Excel.Worksheet
    Public Es_Textura As Boolean = False
    Public SumatoriaFilas, Pagina, NumPagina As Integer
    Private FilasHoja, MaxFilasImp, FilaInicial As Integer
    Private Fuente As String

#Region " Enumeradores "
    Public Enum Visibilidad_Libro
        Visible = True
        Invisible = False
    End Enum
#End Region

#Region " Propiedades "
    Public Property CFilaInicial() As Integer
        Get
            Return FilaInicial
        End Get
        Set(ByVal Value As Integer)
            FilaInicial = Value
        End Set
    End Property

    Public Property CPagina() As Integer
        Get
            Return Pagina
        End Get
        Set(ByVal Value As Integer)
            Pagina = Value
        End Set
    End Property

    Public Property CFilasHoja() As Integer
        Get
            Return FilasHoja
        End Get
        Set(ByVal Value As Integer)
            FilasHoja = Value
        End Set
    End Property

    Public Property CMaxFilasImp() As Integer
        Get
            Return MaxFilasImp
        End Get
        Set(ByVal Value As Integer)
            MaxFilasImp = Value
        End Set
    End Property

#End Region

    Public Sub New()

    End Sub

#Region " ------------------ Crea Libro y Hoja ---------------------- "
    Public Overridable Sub Crea_Excel(ByVal Origen As String, ByVal Destino As String)
        ExcelA = CreateObject("EXCEL.APPLICATION")
        Try
            FileCopy(Origen, Destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
        End Try
        LibroE = ExcelA.Workbooks.Open(Destino)
        ExcelA.Visible = True 'HACER INVISIBLE DESPUES DE LAS PRUEBAS
        HojaE = LibroE.Worksheets(1)
        HojaE.Visible = Excel.XlSheetVisibility.xlSheetVisible
        HojaE.Activate()
    End Sub

    Public Overloads Sub Crea_Hoja_Excel()
        HojaE = LibroE.Worksheets.Add()
        HojaE.Visible = Excel.XlSheetVisibility.xlSheetVisible
        HojaE.Activate()
    End Sub

    Public Overloads Sub Crea_Hoja_Excel(ByVal NomHo As String, ByVal AnchoColumna As Double, ByVal AltoFila As Double, ByVal MM As Integer)
        Try
            HojaE = LibroE.Worksheets.Add()
            HojaE.Name = CStr(MM) & " " & NomHo
            HojaE.Visible = Excel.XlSheetVisibility.xlSheetVisible
            HojaE.Activate()
            HojaE.Cells.Select()
            HojaE.Cells.ColumnWidth = AnchoColumna
            HojaE.Cells.RowHeight = AltoFila
            HojaE.Range("A1").Select()
            ExcelA.ActiveWindow.DisplayGridlines = False
            SumatoriaFilas = 0
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Cierra_Excel(ByVal Destino As String)
        Try
            HojaE.SaveAs(Destino)
        Catch ex As Exception
            LibroE.Close(False, , )
            ExcelA.Quit()
        End Try

    End Sub
    Public Sub Mata_Proceso()
        HojaE = Nothing
        LibroE = Nothing
        ExcelA = Nothing
    End Sub
#End Region

#Region " -------- Imprime Línea (se refiere a toda la fila) -------- "
    Public Sub Imprime_Linea(ByVal FilD As Integer, ByVal FilH As Integer, ByVal ColD As String, ByVal ColH As String, _
                            ByVal TamLet As Integer, ByVal AlinH As String, ByVal AlinV As String, ByVal Negrilla As Boolean, _
                            ByVal Mascara As String, ByVal Color As String, ByVal StrNom As String)
        'FilD = FilD + SumatoriaFilas
        'FilH = FilH + SumatoriaFilas
        HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Merge()

        Select Case AlinH
            Case "Left"
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            Case "Center"
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Case "Right"
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            Case "General"
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
            Case Else
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        End Select

        Select Case AlinV
            Case "Bottom"
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
            Case "Center"
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            Case "Top"
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            Case Else
                HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        End Select


        If Negrilla = True Then HojaE.Range(ColD & FilD.ToString).Font.Bold = True
        If Mascara <> "" Then HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).NumberFormat = Mascara
        If Color <> "" Then HojaE.Range(ColD & FilD.ToString).Font.Color = Color
        HojaE.Range(ColD & FilD.ToString).Value = StrNom
        HojaE.Range(ColD & FilD.ToString).Font.Size = TamLet
    End Sub
#End Region

#Region " Bordes "
    Public Sub BordesI(ByVal TipoBorde As Integer, ByVal TipoLinea As Integer, ByVal FilD As Integer, _
                                  ByVal FilH As Integer, ByVal ColD As String, ByVal ColH As String)
        'FilH = FilH + SumatoriaFilas
        'FilD = FilD + SumatoriaFilas
        If TipoBorde = 1 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If
        If TipoBorde = 2 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If

        If TipoBorde = 3 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If
        If TipoBorde = 4 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If
        If TipoBorde = 5 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If

        If TipoBorde = 6 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If


        If TipoBorde = 7 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If

        If TipoBorde = 8 Then
            If TipoLinea = 1 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlThin
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
            If TipoLinea = 2 Then
                With HojaE.Range(ColD & FilD.ToString & ":" & ColH & FilH.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .Weight = Excel.XlBorderWeight.xlHairline
                    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                End With
            End If
        End If

    End Sub
#End Region

#Region " Saltos "
    Public Sub Salto_Grupo(ByRef PosGrupoMatriz As Integer, ByRef Fila As Integer, ByVal CodigoAnalisis As Integer, ByVal CalFormula As String)
        'NumPagina = Me.CPagina - 1
        If Fila > FilasHoja Then
            PosGrupoMatriz = PosGrupoMatriz + 1
            If PosGrupoMatriz > 3 Then
                Me.CPagina = Pagina + 1
                NumPagina = Me.CPagina - 1
            End If
            If PosGrupoMatriz > 1 And PosGrupoMatriz < 4 Then
                Call Me.Detalle(PosGrupoMatriz, CodigoAnalisis, CalFormula)
            End If
            Select Case CalFormula
                Case "Regresion"
                    If Matriz_Columnas(PosGrupoMatriz + 4, 1, 1) <> "" Then Fila = FilaInicial
                Case "RegresionNNO3"
                    If Matriz_Columnas(PosGrupoMatriz + 4, 1, 1) <> "" Then Fila = FilaInicial
                Case "Interpolacion"
                    If Matriz_Columnas(PosGrupoMatriz, 1, 1) <> "" Then Fila = FilaInicial
                Case "Gasto_Blanco_Factor"
                    If Matriz_Columnas(PosGrupoMatriz, 1, 1) <> "" Then Fila = FilaInicial
                Case "Lectura"
                    If Matriz_Columnas(PosGrupoMatriz + 4, 1, 1) <> "" Then Fila = FilaInicial
                Case "Lectura_Blanco"
                    If Matriz_Columnas(PosGrupoMatriz + 4, 1, 1) <> "" Then Fila = FilaInicial
            End Select
        End If
    End Sub

    Public Sub Salto_Grupo_Texturas(ByRef PosGrupoMatriz As Integer, ByRef Fila As Integer)
        If Fila > FilasHoja Then
            PosGrupoMatriz = PosGrupoMatriz + 1
            Fila = 9
            If PosGrupoMatriz >= 3 Then
                Me.CPagina = Pagina + 1
                NumPagina = Me.CPagina - 1
                Es_Textura = True
            End If
        End If
    End Sub

    Public Function Salto_Pagina(ByRef PosGrupoMatriz As Integer, ByRef Fila As Integer, ByVal Es_Primera As String, ByVal CalFormula As String) As Boolean
        Dim iPosGrupMatr As Integer
        Salto_Pagina = False
        Select Case CalFormula
            Case "Regresion"
                iPosGrupMatr = PosGrupoMatriz + 4
            Case "RegresionNNO3"
                iPosGrupMatr = PosGrupoMatriz + 4
            Case "Interpolacion"
                iPosGrupMatr = PosGrupoMatriz
            Case "Gasto_Blanco_Factor"
                iPosGrupMatr = PosGrupoMatriz
            Case "Lectura"
                iPosGrupMatr = PosGrupoMatriz + 4
            Case "Lectura_Gasto"
                iPosGrupMatr = PosGrupoMatriz + 4
        End Select
        If Fila > MaxFilasImp + SumatoriaFilas Or Es_Textura = True Then
            If Matriz_Columnas(iPosGrupMatr, 1, 1) = "" Then
                SumatoriaFilas = ((Me.NumPagina * MaxFilasImp) + 1)
                PosGrupoMatriz = 1
                Fila = FilaInicial + SumatoriaFilas
                FilasHoja = MaxFilasImp + SumatoriaFilas
                Salto_Pagina = True
                Es_Textura = False
            End If
        End If
        If Es_Primera = "S" Then Salto_Pagina = True
    End Function
#End Region

#Region " ---------- Encabezado ------------ "
    Public Overridable Sub Encabezado(ByVal Titulo As String, ByVal ColD As String, ByVal ColH As String, ByVal FilD As Integer, ByVal FilH As Integer, ByVal Negri As Boolean)
        Dim FilaD, FilaH As Integer
        FilaD = FilD + SumatoriaFilas
        FilaH = FilH + SumatoriaFilas
        Imprime_Linea(FilaD, FilaD, ColD, ColH, 12, "Center", "Center", Negri, "", "", Titulo)
    End Sub
#End Region

#Region " Especifica impresion con curva interpolada "
    Public Overridable Overloads Sub Interpolacion(ByVal ELE_CODIGO As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer
        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas

        Call Imprime_Linea(FilD, FilH, "A", "P", 10, "Center", "Center", False, "", "", "Curva Standar")
        Call BordesI(4, 1, FilD, FilH, "A", "P")

        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "H", 9, "Left", "Center", False, "", "", ELE_CODIGO & "(ppm)")
        Call BordesI(3, 1, FilD, FilH, "A", "H")

        Call Imprime_Linea(FilD, FilH, "I", "P", 9, "Left", "Center", False, "", "", "Tramitancia (%)")
        Call BordesI(3, 1, FilD, FilH, "I", "P")

        FilD = 4 + SumatoriaFilas
        FilH = 15 + SumatoriaFilas
        Call BordesI(4, 1, FilD, FilH, "A", "H")

        Call BordesI(4, 1, FilD, FilH, "I", "P")

        For XX = 6 To 14
            FilD = XX + SumatoriaFilas : FilH = XX + SumatoriaFilas
            Call BordesI(1, 2, FilD, FilH, "A", "P")
        Next
        FilD = 15 + SumatoriaFilas : FilH = 15 + SumatoriaFilas

        Call Imprime_Linea(FilD, FilH, "A", "H", 9, "Left", "Center", False, "", "", "R :")
    End Sub
#End Region

#Region " Especifica impresión con curva "
    Public Overridable Overloads Sub Curva(ByVal ELE_CODIGO As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer
        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas

        Call Imprime_Linea(FilD, FilH, "A", "P", 10, "Center", "Center", False, "", "", "Curva Standar")
        Call BordesI(4, 1, FilD, FilH, "A", "P")

        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "H", 9, "Left", "Center", False, "", "", ELE_CODIGO & "(ppm)")
        Call BordesI(3, 1, FilD, FilH, "A", "H")

        Call Imprime_Linea(FilD, FilH, "I", "P", 9, "Left", "Center", False, "", "", "Tramitancia (%)")
        Call BordesI(3, 1, FilD, FilH, "I", "P")

        FilD = 4 + SumatoriaFilas
        FilH = 15 + SumatoriaFilas
        Call BordesI(4, 1, FilD, FilH, "A", "H")

        Call BordesI(4, 1, FilD, FilH, "I", "P")

        For XX = 6 To 14
            FilD = XX + SumatoriaFilas : FilH = XX + SumatoriaFilas
            Call BordesI(1, 2, FilD, FilH, "A", "P")
        Next
        FilD = 15 + SumatoriaFilas : FilH = 15 + SumatoriaFilas

        Call Imprime_Linea(FilD, FilH, "A", "H", 9, "Left", "Center", False, "", "", "R :")

    End Sub
#End Region

#Region " Imprime la fórmula de los cálculos como guía referencial "
    Public Overridable Sub Factor(ByVal Formula As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer
        FilD = 9 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "AJ", 7, "Center", "Center", False, "", "", Formula)
    End Sub
#End Region

#Region " Especifica impresión de los pH "
    Public Overridable Overloads Sub Imprime_pH(ByVal ELE_CODIGO As String, ByVal Formula As String)
        Dim XX As Integer, sTexto As String
        Dim FilD, FilH As Integer
        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas

        Call Imprime_Linea(FilD, FilH, "A", "G", 8, "Left", "Center", False, "", "", "Temperatura")
        Call Imprime_Linea(FilD, FilH, "H", "J", 8, "Left", "Center", False, "", "", "(T°)")

        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "J", 8, "Left", "Center", False, "", "", "Relación Muestra / Agua")
        Call Imprime_Linea(FilD, FilH, "L", "L", 8, "Left", "Center", False, "", "", "'1/1")
        Call Imprime_Linea(FilD, FilH, "R", "R", 8, "Left", "Center", False, "", "", "'1/2,5")
        Call Imprime_Linea(FilD, FilH, "X", "X", 8, "Left", "Center", False, "", "", "'1,5")
        Call Imprime_Linea(FilD, FilH, "AD", "AD", 8, "Left", "Center", False, "", "", "Otro")

        FilD = 6 + SumatoriaFilas
        FilH = 6 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "J", 8, "Left", "Center", False, "", "", "Solución Buffer")
        Call Imprime_Linea(FilD, FilH, "L", "L", 8, "Left", "Center", False, "", "", "'4,0")
        Call Imprime_Linea(FilD, FilH, "R", "R", 8, "Left", "Center", False, "", "", "'7,0")
        Call Imprime_Linea(FilD, FilH, "X", "X", 8, "Left", "Center", False, "", "", "'9,0")
        Call Imprime_Linea(FilD, FilH, "AD", "AD", 8, "Left", "Center", False, "", "", "Otro")

        FilD = 7 + SumatoriaFilas
        FilH = 7 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "G", 8, "Left", "Center", False, "", "", "St. C. Eléctrica")
        Call Imprime_Linea(FilD, FilH, "H", "J", 8, "Left", "Center", False, "", "", "(dS/m)")
        Call Imprime_Linea(FilD, FilH, "L", "L", 8, "Left", "Center", False, "", "", "'0,7")
        Call Imprime_Linea(FilD, FilH, "R", "R", 8, "Left", "Center", False, "", "", "'1,4")
        Call Imprime_Linea(FilD, FilH, "X", "X", 8, "Left", "Center", False, "", "", "'2,0")
        Call Imprime_Linea(FilD, FilH, "AD", "AD", 8, "Left", "Center", False, "", "", "Otro")

        FilD = 8 + SumatoriaFilas
        FilH = 8 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "J", 8, "Left", "Center", False, "", "", "Agua Destilada")
        Call Imprime_Linea(FilD, FilH, "L", "L", 8, "Left", "Center", False, "", "", "pH")
        Call Imprime_Linea(FilD, FilH, "R", "R", 8, "Left", "Center", False, "", "", "C.E.")

        For XX = 4 To 8
            FilD = XX + SumatoriaFilas
            FilH = XX + SumatoriaFilas
            Call Imprime_Linea(FilD, FilH, "K", "K", 8, "Center", "Center", False, "", "", ":")
            If XX = 4 Then
                Call BordesI(1, 2, FilD, FilH, "L", "P")
            ElseIf XX = 8 Then
                Call BordesI(1, 2, FilD, FilH, "N", "P")
                Call BordesI(1, 2, FilD, FilH, "T", "V")
            Else
                Call BordesI(1, 2, FilD, FilH, "N", "P")
                Call BordesI(1, 2, FilD, FilH, "T", "V")
                Call BordesI(1, 2, FilD, FilH, "Z", "AB")
                Call BordesI(1, 2, FilD, FilH, "AG", "AI")
            End If
        Next

        FilD = 4 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        Call BordesI(4, 1, FilD, FilH, "A", "AJ")
        If Formula <> "" Then Factor(Formula)
    End Sub
#End Region

#Region " Especifica impresión de para lectura directa (sin proceso de cálculo) "
    Public Overridable Overloads Sub Solo_Lectura(ByVal Formula As String)
        Dim XX As Integer, sTexto As String
        Dim FilD, FilH As Integer

        FilD = 4 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        Call BordesI(4, 1, FilD, FilH, "A", "AJ")
        If Formula <> "" Then Factor(Formula)
    End Sub
#End Region

#Region " Datos I "
    Public Overloads Sub DatosI(ByVal MyFecha As String, ByVal MyEle As String, ByVal NumLabTanda As Integer)
        Dim XX As Integer
        Dim FilD, FilH As Integer

        FilD = 3 + SumatoriaFilas
        FilH = 3 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "F. Digitación")
        'Call Imprime_Linea(FilD, FilH, "AV", "BB", 10, "Left", "Center", False, "", "", MyFecha)

        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "Analista")

        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "Digitador")

        FilD = 6 + SumatoriaFilas
        FilH = 6 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "F. Análisis")

        FilD = 7 + SumatoriaFilas
        FilH = 7 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "Hr. Análisis")

        FilD = 8 + SumatoriaFilas
        FilH = 8 + SumatoriaFilas
        'Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "Fecha Tanda")
        Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "F.Planifica")

        Call Imprime_Linea(FilD, FilH, "AV", "BB", 9, "Left", "Center", False, "", "", MyFecha)

        FilD = 9 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        'Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "Nº Lab.Tanda")
        Call Imprime_Linea(FilD, FilH, "AN", "AT", 9, "Left", "Center", False, "", "", "Cod.Planifica")

        Call Imprime_Linea(FilD, FilH, "AV", "BB", 9, "Left", "Center", False, "", "", NumLabTanda)


        '****************************
        For XX = 3 To 9
            FilD = XX + SumatoriaFilas
            FilH = XX + SumatoriaFilas
            Call Imprime_Linea(FilD, FilH, "AU", "AU", 9, "Left", "Center", False, "", "", ":")
        Next
        '****************************

        For XX = 3 To 9
            FilD = XX + SumatoriaFilas : FilH = XX + SumatoriaFilas
            Call BordesI(1, 2, FilD, FilH, "AV", "BG")
        Next
        FilD = 3 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas

        Call BordesI(4, 1, FilD, FilH, "AN", "BG")
    End Sub
#End Region

#Region " Especifica impresión sin curva "
    Public Overridable Overloads Sub SinCurva(ByVal ELE_CODIGO As String, ByVal MuestraPlani As String)
        Dim XX As Integer, sTexto As String
        Dim FilD, FilH As Integer
        FilD = 1 + SumatoriaFilas
        FilH = 1 + SumatoriaFilas

        Call Imprime_Linea(FilD, FilH, "A", "BH", 14, "Center", "Center", True, "", "", MuestraPlani & "  Elemento : " & ELE_CODIGO)

        FilD = 3 + SumatoriaFilas
        FilH = 3 + SumatoriaFilas


        Call Imprime_Linea(FilD, FilH, "A", "K", 9, "Left", "Center", False, "", "", "Peso Muestra")
        Call Imprime_Linea(FilD, FilH, "T", "AC", 9, "Left", "Center", False, "", "", "Volumen aforo")
        Call BordesI(6, 1, FilD, FilH, "A", "K")
        Call BordesI(8, 1, FilD, FilH, "A", "K")


        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas

        Call Imprime_Linea(FilD, FilH, "A", "K", 9, "Left", "Center", False, "", "", "Alícuota")
        Call Imprime_Linea(FilD, FilH, "T", "AC", 9, "Left", "Center", False, "", "", "Dilución")
        Call BordesI(6, 1, FilD, FilH, "A", "K")


        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas

        Call BordesI(6, 1, FilD, FilH, "A", "K")


        For XX = 3 To 5
            FilD = XX + SumatoriaFilas
            FilH = XX + SumatoriaFilas
            Call Imprime_Linea(FilD, FilH, "M", "M", 9, "Center", "Center", False, "", "", ":")
            Call Imprime_Linea(FilD, FilH, "AE", "AE", 9, "Center", "Center", False, "", "", ":")
            Call BordesI(1, 2, FilD, FilH, "N", "R")
            Call BordesI(1, 2, FilD, FilH, "AF", "AJ")
        Next
        FilD = 3 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        Call BordesI(4, 1, FilD, FilH, "A", "AJ")

        'If Fórmula <> "" Then Factor(Fórmula)
    End Sub
#End Region

#Region " Datos II "
    Public Overloads Sub DatosII(ByVal MyFecha As String, ByVal Formula As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer

        '******
        ' Desde el Sub Factor...
        '*************************************
        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "U", "AB", 9, "Left", "Center", False, "", "", "Peso muestra")
        Call Imprime_Linea(FilD, FilH, "AC", "AD", 9, "Left", "Center", False, "", "", "(gr)")
        Call Imprime_Linea(FilD, FilH, "AE", "AE", 9, "Left", "Center", False, "", "", ":")
        Call BordesI(1, 2, FilD, FilH, "AF", "AJ")

        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "U", "AB", 9, "Left", "Center", False, "", "", "Volumen aforo")
        Call Imprime_Linea(FilD, FilH, "AC", "AD", 9, "Left", "Center", False, "", "", "(ml)")
        Call Imprime_Linea(FilD, FilH, "AE", "AE", 9, "Left", "Center", False, "", "", ":")
        Call BordesI(1, 2, FilD, FilH, "AF", "AJ")

        FilD = 6 + SumatoriaFilas
        FilH = 6 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "U", "AB", 9, "Left", "Center", False, "", "", "Volumen alícuota")
        Call Imprime_Linea(FilD, FilH, "AC", "AD", 9, "Left", "Center", False, "", "", "(ml)")
        Call Imprime_Linea(FilD, FilH, "AE", "AE", 9, "Left", "Center", False, "", "", ":")
        Call BordesI(1, 2, FilD, FilH, "AF", "AJ")

        FilD = 7 + SumatoriaFilas
        FilH = 7 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "U", "AB", 9, "Left", "Center", False, "", "", "Vol.aforo alícuota")
        Call Imprime_Linea(FilD, FilH, "AC", "AD", 9, "Left", "Center", False, "", "", "(ml)")
        Call Imprime_Linea(FilD, FilH, "AE", "AE", 9, "Left", "Center", False, "", "", ":")
        Call BordesI(1, 2, FilD, FilH, "AF", "AJ")

        FilD = 8 + SumatoriaFilas
        FilH = 8 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "U", "AB", 9, "Left", "Center", False, "", "", "Factor dilución")
        Call Imprime_Linea(FilD, FilH, "AC", "AD", 9, "Left", "Center", False, "", "", "(ml)")
        Call Imprime_Linea(FilD, FilH, "AE", "AE", 9, "Left", "Center", False, "", "", ":")
        Call BordesI(1, 2, FilD, FilH, "AF", "AJ")

        FilD = 9 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        'Call Imprime_Linea(FilD, FilH, "A", "AJ", 7, "Center", "Center", False, "", "", Formula)
        'Call BordesI(1, 2, FilD, FilH, "U", "AJ")

        FilD = 4 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        Call BordesI(4, 1, FilD, FilH, "U", "AJ")

        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AO", "AT", 9, "Left", "Center", False, "", "", "F.Digitación")
        Call Imprime_Linea(FilD, FilH, "AV", "BB", 10, "Left", "Center", False, "", "", MyFecha)

        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AO", "AT", 9, "Left", "Center", False, "", "", "Analista")

        FilD = 6 + SumatoriaFilas
        FilH = 6 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AO", "AT", 9, "Left", "Center", False, "", "", "Digitador")

        FilD = 7 + SumatoriaFilas
        FilH = 7 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AO", "AT", 9, "Left", "Center", False, "", "", "F.análisis")

        FilD = 8 + SumatoriaFilas
        FilH = 8 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AO", "AT", 9, "Left", "Center", False, "", "", "Hr.análisis")

        FilD = 9 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "AO", "BG", 8, "Left", "Center", False, "", "", Formula)  'MyEle & "(ppm) = Regresión x Factor dilución")

        For XX = 4 To 8
            FilD = XX + SumatoriaFilas
            FilH = XX + SumatoriaFilas
            Call Imprime_Linea(FilD, FilH, "AU", "AU", 9, "Left", "Center", False, "", "", ":")
        Next

        '****************************

        For XX = 4 To 8
            FilD = XX : FilH = XX
            Call BordesI(1, 2, FilD, FilH, "AV", "BG")
        Next
        FilD = 4 + SumatoriaFilas
        FilH = 9 + SumatoriaFilas

        Call BordesI(4, 1, FilD, FilH, "AO", "BG")
    End Sub
#End Region

#Region " Especifica impresión de textura sin granulometría "
#Region " --Textura()-- "

    Public Overridable Overloads Sub Textura() '(ByVal ELE_CODIGO As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer
        FilD = 2 + SumatoriaFilas
        FilH = 2 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "BE", 14, "Center", "Center", True, "", "", "SUELO: Análisis de Textura")

        FilD = 7 + SumatoriaFilas
        FilH = 7 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "L", "P", 5, "Center", "Bottom", False, "", "", "DISPERSIÓN")
        Call Imprime_Linea(FilD, FilH, "Q", "Z", 9, "Center", "Bottom", False, "", "", "AGITACIÓN")
        Call Imprime_Linea(FilD, FilH, "AA", "AO", 9, "Center", "Bottom", False, "", "", "1° LECTURA")
        Call Imprime_Linea(FilD, FilH, "AP", "BD", 9, "Center", "Bottom", False, "", "", "2° LECTURA")
        Call BordesI(4, 2, FilD, FilH, "L", "P")
        Call BordesI(4, 2, FilD, FilH, "Q", "Z")
        Call BordesI(4, 2, FilD, FilH, "AA", "AO")
        Call BordesI(4, 2, FilD, FilH, "AP", "BD")

        FilD = 7 + SumatoriaFilas
        FilH = 8 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "B", "F", 9, "Center", "Bottom", False, "", "", "N° LAB")
        Call Imprime_Linea(FilD, FilH, "G", "K", 9, "Center", "Bottom", False, "", "", "N° PR")
        Call BordesI(4, 2, FilD, FilH, "B", "F")
        Call BordesI(4, 2, FilD, FilH, "G", "K")

        FilD = 8 + SumatoriaFilas
        FilH = 8 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "L", "P", 9, "Center", "Bottom", False, "", "", "H.I.")
        Call Imprime_Linea(FilD, FilH, "Q", "U", 9, "Center", "Bottom", False, "", "", "H.I.")
        Call Imprime_Linea(FilD, FilH, "V", "Z", 9, "Center", "Bottom", False, "", "", "H.F.")
        Call Imprime_Linea(FilD, FilH, "AA", "AE", 9, "Center", "Bottom", False, "", "", "HORA")
        Call Imprime_Linea(FilD, FilH, "AF", "AJ", 9, "Center", "Bottom", False, "", "", "LECT")
        Call Imprime_Linea(FilD, FilH, "AK", "AO", 9, "Center", "Bottom", False, "", "", "T°")
        Call Imprime_Linea(FilD, FilH, "AP", "AT", 9, "Center", "Bottom", False, "", "", "HORA")
        Call Imprime_Linea(FilD, FilH, "AU", "AY", 9, "Center", "Bottom", False, "", "", "LECT")
        Call Imprime_Linea(FilD, FilH, "AZ", "BD", 9, "Center", "Bottom", False, "", "", "T°")
        Call BordesI(4, 2, FilD, FilH, "L", "P")
        Call BordesI(4, 2, FilD, FilH, "Q", "U")
        Call BordesI(4, 2, FilD, FilH, "V", "Z")
        Call BordesI(4, 2, FilD, FilH, "AA", "AE")
        Call BordesI(4, 2, FilD, FilH, "AF", "AJ")
        Call BordesI(4, 2, FilD, FilH, "AK", "AO")
        Call BordesI(4, 2, FilD, FilH, "AP", "AT")
        Call BordesI(4, 2, FilD, FilH, "AU", "AY")
        Call BordesI(4, 2, FilD, FilH, "AZ", "BD")

        For XX = 9 To 40
            FilD = XX + SumatoriaFilas
            FilH = XX + SumatoriaFilas
            Call BordesI(4, 2, FilD, FilH, "B", "F")
            Call BordesI(4, 2, FilD, FilH, "G", "K")
            Call BordesI(4, 2, FilD, FilH, "L", "P")
            Call BordesI(4, 2, FilD, FilH, "Q", "U")
            Call BordesI(4, 2, FilD, FilH, "V", "Z")
            Call BordesI(4, 2, FilD, FilH, "AA", "AE")
            Call BordesI(4, 2, FilD, FilH, "AF", "AJ")
            Call BordesI(4, 2, FilD, FilH, "AK", "AO")
            Call BordesI(4, 2, FilD, FilH, "AP", "AT")
            Call BordesI(4, 2, FilD, FilH, "AU", "AY")
            Call BordesI(4, 2, FilD, FilH, "AZ", "BD")
        Next
    End Sub
#End Region

#Region " --Granulometría Arenas-- "
    Public Overridable Overloads Sub Granulometria() '(ByVal ELE_CODIGO As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer
        FilD = 2 + SumatoriaFilas
        FilH = 2 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "BG", 14, "Center", "Center", True, "", "", "SUELO: Granulometría Arenas")

        FilD = 4 + SumatoriaFilas
        FilH = 4 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "A", 9, "Left", "Center", False, "", "", "Arena")
        Call Imprime_Linea(FilD, FilH, "G", "G", 10, "Left", "Center", True, "", "", "Sist. USDA")
        Call Imprime_Linea(FilD, FilH, "Q", "Q", 8, "Left", "Center", False, "", "", "Sist. Internacional")

        FilD = 5 + SumatoriaFilas
        FilH = 5 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "A", 9, "Left", "Center", False, "", "", "Gruesa")
        Call Imprime_Linea(FilD, FilH, "G", "G", 9, "Left", "Center", True, "", "", "'0,5")
        Call Imprime_Linea(FilD, FilH, "J", "J", 9, "Left", "Center", True, "", "", "'-")
        Call Imprime_Linea(FilD, FilH, "K", "K", 9, "Left", "Center", True, "", "", "'2,0")
        Call Imprime_Linea(FilD, FilH, "M", "M", 9, "Left", "Center", True, "", "", "mm.")
        Call Imprime_Linea(FilD, FilH, "Q", "Q", 8, "Left", "Center", False, "", "", "'0,2")
        Call Imprime_Linea(FilD, FilH, "S", "S", 8, "Left", "Center", False, "", "", "'-")
        Call Imprime_Linea(FilD, FilH, "T", "T", 8, "Left", "Center", False, "", "", "'2,0")
        Call Imprime_Linea(FilD, FilH, "V", "V", 8, "Left", "Center", False, "", "", "mm.")
        Call Imprime_Linea(FilD, FilH, "AR", "AR", 9, "Left", "Center", False, "", "", "Fecha análisis:")
        Call Imprime_Linea(FilD, FilH, "BA", "BF", 9, "Center", "Center", False, "", "", Format(Now(), "dd-MM-yyyy"))

        FilD = 6 + SumatoriaFilas
        FilH = 6 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "A", 9, "Left", "Center", False, "", "", "Fina")
        Call Imprime_Linea(FilD, FilH, "G", "G", 9, "Left", "Center", True, "", "", "'0,05")
        Call Imprime_Linea(FilD, FilH, "J", "J", 9, "Left", "Center", True, "", "", "'-")
        Call Imprime_Linea(FilD, FilH, "K", "K", 9, "Left", "Center", True, "", "", "'0,5")
        Call Imprime_Linea(FilD, FilH, "M", "M", 9, "Left", "Center", True, "", "", "mm.")
        Call Imprime_Linea(FilD, FilH, "Q", "Q", 8, "Left", "Center", False, "", "", "'0,02")
        Call Imprime_Linea(FilD, FilH, "S", "S", 8, "Left", "Center", False, "", "", "'-")
        Call Imprime_Linea(FilD, FilH, "T", "T", 8, "Left", "Center", False, "", "", "'0,2")
        Call Imprime_Linea(FilD, FilH, "V", "V", 8, "Left", "Center", False, "", "", "mm.")

        FilD = 7 + SumatoriaFilas
        FilH = 8 + SumatoriaFilas
        Call Imprime_Linea(FilD, FilH, "A", "E", 9, "Center", "Bottom", False, "", "", "N° LAB")
        Call Imprime_Linea(FilD, FilH, "F", "I", 9, "Center", "Bottom", False, "", "", "N° PROB")
        Call Imprime_Linea(FilD, FilH, "J", "M", 9, "Center", "Bottom", False, "", "", "CAP.")
        Call Imprime_Linea(FilD, FilH, "N", "S", 9, "Center", "Bottom", False, "", "", "TAMIZ ARENA")
        Call Imprime_Linea(FilD, FilH, "T", "X", 9, "Center", "Bottom", False, "", "", "TARA CÁPSULA")
        Call Imprime_Linea(FilD, FilH, "Y", "AC", 8, "Center", "Bottom", False, "", "", "PESO CAP. +MUESTRA SECA")
        Call Imprime_Linea(FilD, FilH, "AE", "AI", 9, "Center", "Bottom", False, "", "", "N° LAB")
        Call Imprime_Linea(FilD, FilH, "AJ", "AM", 9, "Center", "Bottom", False, "", "", "N° PROB")
        Call Imprime_Linea(FilD, FilH, "AN", "AQ", 9, "Center", "Bottom", False, "", "", "CAP.")
        Call Imprime_Linea(FilD, FilH, "AR", "AW", 9, "Center", "Bottom", False, "", "", "TAMIZ ARENA")
        Call Imprime_Linea(FilD, FilH, "AX", "BB", 9, "Center", "Bottom", False, "", "", "TARA CÁPSULA")
        Call Imprime_Linea(FilD, FilH, "BC", "BG", 8, "Center", "Bottom", False, "", "", "PESO CAP. +MUESTRA SECA")
        Me.HojaE.Range("A" + FilD.ToString + ":E" + FilH.ToString).WrapText = True
        Me.HojaE.Range("F" + FilD.ToString + ":I" + FilH.ToString).WrapText = True
        Me.HojaE.Range("J" + FilD.ToString + ":M" + FilH.ToString).WrapText = True
        Me.HojaE.Range("N" + FilD.ToString + ":S" + FilH.ToString).WrapText = True
        Me.HojaE.Range("T" + FilD.ToString + ":X" + FilH.ToString).WrapText = True
        Me.HojaE.Range("Y" + FilD.ToString + ":AC" + FilH.ToString).WrapText = True
        Me.HojaE.Range("AE" + FilD.ToString + ":AI" + FilH.ToString).WrapText = True
        Me.HojaE.Range("AJ" + FilD.ToString + ":AM" + FilH.ToString).WrapText = True
        Me.HojaE.Range("AN" + FilD.ToString + ":AQ" + FilH.ToString).WrapText = True
        Me.HojaE.Range("AR" + FilD.ToString + ":AW" + FilH.ToString).WrapText = True
        Me.HojaE.Range("AX" + FilD.ToString + ":BB" + FilH.ToString).WrapText = True
        Me.HojaE.Range("BC" + FilD.ToString + ":BG" + FilH.ToString).WrapText = True
        Call BordesI(7, 2, FilD, FilH, "E", "E")
        Call BordesI(7, 2, FilD, FilH, "I", "I")
        Call BordesI(7, 2, FilD, FilH, "M", "M")
        Call BordesI(7, 2, FilD, FilH, "S", "S")
        Call BordesI(7, 2, FilD, FilH, "X", "X")
        Call BordesI(7, 2, FilD, FilH, "AI", "AI")
        Call BordesI(7, 2, FilD, FilH, "AM", "AM")
        Call BordesI(7, 2, FilD, FilH, "AQ", "AQ")
        Call BordesI(7, 2, FilD, FilH, "AW", "AW")
        Call BordesI(7, 2, FilD, FilH, "BB", "BB")
        Call BordesI(4, 2, FilD, FilH, "A", "AC")
        Call BordesI(4, 2, FilD, FilH, "AE", "BG")

        For XX = 9 To 40
            FilD = XX + SumatoriaFilas
            FilH = XX + SumatoriaFilas
            Call BordesI(7, 2, FilD, FilH, "E", "E")
            Call BordesI(7, 2, FilD, FilH, "I", "I")
            Call BordesI(7, 2, FilD, FilH, "M", "M")
            Call BordesI(7, 2, FilD, FilH, "S", "S")
            Call BordesI(7, 2, FilD, FilH, "X", "X")
            Call BordesI(7, 2, FilD, FilH, "AI", "AI")
            Call BordesI(7, 2, FilD, FilH, "AM", "AM")
            Call BordesI(7, 2, FilD, FilH, "AQ", "AQ")
            Call BordesI(7, 2, FilD, FilH, "AW", "AW")
            Call BordesI(7, 2, FilD, FilH, "BB", "BB")
        Next
        FilD = 9 + SumatoriaFilas
        FilH = 40 + SumatoriaFilas
        Call BordesI(4, 2, FilD, FilH, "A", "AC")
        Call BordesI(4, 2, FilD, FilH, "AE", "BG")
    End Sub
#End Region
#End Region

#Region " Especifica impresión de textura con granulometría "

#End Region

#Region " ---------- Detalle de las columnas ---------- "
    Public Sub Detalle(ByVal PosGrupoCol As Integer, ByVal CodigoAnalisis As Integer, ByVal CalFormula As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer
        Dim ColD, ColH As String

        FilD = 17 + SumatoriaFilas
        FilH = 17 + SumatoriaFilas
        Select Case CodigoAnalisis
            Case 1000
                Select Case CalFormula
                    Case "Regresion"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "RegresionNNO3"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Interpolacion"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Int. Curva")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "M.O.(ppm)")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Gasto_Blanco_Factor"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Peso M")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Gasto.")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura_Blanco"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Gasto")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                End Select
            Case 2000
                Select Case CalFormula
                    Case "Regresion"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "RegresionNNO3"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Interpolacion"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Int. Curva")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "M.O.(ppm)")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Gasto_Blanco_Factor"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Peso M")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Gasto.")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura_Blanco"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Gasto")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                End Select
            Case 3000
                Select Case CalFormula
                    Case "Regresion"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "RegresionNNO3"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Interpolacion"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Int. Curva")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "M.O.(ppm)")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Gasto_Blanco_Factor"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Peso M")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Gasto.")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura_Blanco"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Gasto")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                End Select
            Case 4000
                Select Case CalFormula
                    Case "Regresion"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "RegresionNNO3"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Interpolacion"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Int. Curva")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "M.O.(ppm)")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Gasto_Blanco_Factor"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Peso M")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Gasto.")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura_Blanco"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Gasto")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                End Select
            Case 5000
                Select Case CalFormula
                    Case "Regresion"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "RegresionNNO3"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Interpolacion"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Int. Curva")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "M.O.(ppm)")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Gasto_Blanco_Factor"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Peso M")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Gasto.")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura_Blanco"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Gasto")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                End Select
            Case 6000
                Select Case CalFormula
                    Case "Regresion"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "RegresionNNO3"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Interpolacion"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "T (%)")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Int. Curva")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "M.O.(ppm)")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Gasto_Blanco_Factor"
                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Peso M")

                        ColD = Matriz_Columnas(PosGrupoCol, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Gasto.")

                        ColD = Matriz_Columnas(PosGrupoCol, 4, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 9, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol, 4, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                    Case "Lectura_Blanco"
                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Lectura")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Gasto")

                        ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                        Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                End Select
        End Select
    End Sub
#End Region

#Region "----------- Detalle de las texturas ---------- "
    Public Sub DetalleTextura(ByVal PosGrupoCol As Integer, ByVal Codigo_Elemento As String, ByVal Formula As String)
        Dim XX As Integer
        Dim FilD, FilH As Integer
        Dim ColD, ColH As String

        FilD = 7 + SumatoriaFilas
        FilH = 7 + SumatoriaFilas
        Select Case Codigo_Elemento
            Case ""
            Case "WTexBou+AreFyG"
                If PosGrupoCol = 1 Then
                    ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 1, 2)
                    Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "N° Lab")

                    ColD = Matriz_Columnas(PosGrupoCol + 4, 2, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 2, 2)
                    Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "T (%)")

                    ColD = Matriz_Columnas(PosGrupoCol + 4, 3, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                    Call Imprime_Linea(FilD, FilH, ColD, ColH, 10, "Left", "Center", False, "", "", "Obs.")

                    ColD = Matriz_Columnas(PosGrupoCol + 4, 1, 1) : ColH = Matriz_Columnas(PosGrupoCol + 4, 3, 2)
                    Call BordesI(4, 1, FilD, FilH, ColD, ColH)
                Else
                End If
            Case "WArenaFyG"
        End Select
    End Sub
#End Region

#Region "----------- Cierra Libro --------------------- "
    Public Sub CierraExcel()
        LibroE.Save()
        LibroE.Close()
        ExcelA.Quit()
    End Sub
#End Region

End Class
