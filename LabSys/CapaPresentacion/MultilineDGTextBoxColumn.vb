Imports System.Reflection
Imports System.Data.SqlClient

Public Class CGridMultiLineTextBoxStyle
    Inherits DataGridTextBoxColumn

    ' This class creates and handles the MultiLine
    ' textbox column, no scroll bars, column height
    ' grows as text increases

    'This class has several known issues.
    'It is provided AS-IS and should be used 
    'with caution.  It has issues with painting
    'rows in the wrong place when a DataGrid 
    'allows new rows to be added.  It also will fail
    'to size the rows properly unless the Multiline 
    'column is visible when the grid is displayed.

    Private HAlignment As HorizontalAlignment
    Private DrawFormat As New StringFormat
    Private AdjustHeight As Boolean = True
    Private dg As DataGrid
    Private Heights As ArrayList
    Private _col As Integer
    Public grid As DataGrid


    Public Property DataAlignment() As HorizontalAlignment
        Get
            Return HAlignment
        End Get
        Set(ByVal Value As HorizontalAlignment)
            HAlignment = Value
            If HAlignment = HorizontalAlignment.Center Then
                DrawFormat.Alignment = StringAlignment.Center
            ElseIf HAlignment = HorizontalAlignment.Right Then
                DrawFormat.Alignment = StringAlignment.Far
            Else
                DrawFormat.Alignment = StringAlignment.Near
            End If
        End Set
    End Property
    Public Property AutoAdjustHeight() As Boolean
        Get
            Return AdjustHeight
        End Get
        Set(ByVal Value As Boolean)
            AdjustHeight = Value
            dg.Invalidate()
        End Set
    End Property

    Public Sub New(ByVal MappingName As String, ByVal col As Integer)
        MyBase.new()
        Me.MappingName = MappingName
        HAlignment = HorizontalAlignment.Left
        DrawFormat.Alignment = StringAlignment.Near
        MyBase.TextBox.TextAlign = HAlignment
        MyBase.TextBox.Multiline = AdjustHeight
        _col = col
    End Sub
    Public Sub New(ByVal MappingName As String)
        MyBase.new()
        Me.MappingName = MappingName
        HAlignment = HorizontalAlignment.Left
        DrawFormat.Alignment = StringAlignment.Near
        MyBase.TextBox.TextAlign = HAlignment
        MyBase.TextBox.Multiline = AdjustHeight
    End Sub

    Public Sub New(ByVal MappingName As String, _
                   ByVal Width As Integer, _
                   ByVal Alignment As HorizontalAlignment, _
                   ByVal [ReadOnly] As Boolean, _
                   ByVal HeaderText As String, _
                   ByVal NullText As String)
        Me.New(MappingName)
        Me.Alignment = Alignment
        Me.Width = Width
        Me.ReadOnly = [ReadOnly]
        Me.HeaderText = HeaderText
        Me.NullText = NullText
    End Sub
    Public Event SetCellFormat As FormatCellEventHandler


    Private Sub FillHeightArrayList()
        Dim mi As MethodInfo = _
           dg.GetType().GetMethod("get_DataGridRows", _
           BindingFlags.FlattenHierarchy Or _
           BindingFlags.IgnoreCase Or _
           BindingFlags.Instance Or _
           BindingFlags.NonPublic Or _
           BindingFlags.Public Or _
           BindingFlags.Static)
        Dim dgRowArray As Array = CType(mi.Invoke(Me.dg, Nothing), Array)
        Heights = New ArrayList
        Dim dgRowHeight As Object
        For Each dgRowHeight In dgRowArray
            If dgRowHeight.ToString().EndsWith _
            ("DataGridRelationshipRow") = True _
            Then
                Heights.Add(dgRowHeight)
            End If
        Next
    End Sub

    Protected Overloads Overrides Sub Edit(ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, _
                                           ByVal bounds As System.Drawing.Rectangle, _
                                           ByVal [readOnly] As Boolean, _
                                           ByVal instantText As String, _
                                           ByVal cellIsVisible As Boolean)

        MyBase.Edit(source, rowNum, bounds, [readOnly], instantText, cellIsVisible)
        MyBase.TextBox.TextAlign = HAlignment
        MyBase.TextBox.Multiline = AdjustHeight

    End Sub

    Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, _
                                            ByVal bounds As System.Drawing.Rectangle, _
                                            ByVal source As System.Windows.Forms.CurrencyManager, _
                                            ByVal rowNum As Integer, ByVal backBrush As System.Drawing.Brush, _
                                            ByVal foreBrush As System.Drawing.Brush, _
                                            ByVal alignToRight As Boolean)
        Dim MyPos As Integer
        Dim Fondo As New Font("Courier New", 8)
        Dim aaa As Integer
        Static bPainted As Boolean = False
        If Not bPainted Then
            dg = Me.DataGridTableStyle.DataGrid
            FillHeightArrayList()
        End If


        'clear the cell
        g.FillRectangle(backBrush, bounds)

        'draw the value
        Dim o As Object = Me.GetColumnValueAtRow([source], rowNum)
        Dim s As String

        If IsDBNull(o) Then
            s = Me.NullText
        Else
            If Es_Planificacion = "S" And s = "************************************ FINAL ****************************************" Then
                Call Cuenta_Filas(s)
            Else
                s = CStr(Me.GetColumnValueAtRow([source], rowNum))
            End If
        End If

        Dim r As New RectangleF(bounds.X, bounds.Y, bounds.Width, bounds.Height)

        r.Inflate(0, -1)

        ' get the height column should be
        Dim sDraw As SizeF = g.MeasureString(s, Me.TextBox.Font, Me.Width, DrawFormat)
        Dim h As Integer = CInt(sDraw.Height + 2)

        If AdjustHeight Then

            FillHeightArrayList()

            Dim pi As PropertyInfo = Heights(rowNum).GetType().GetProperty("Height")
            Dim curHeight As Integer = CInt(pi.GetValue(Heights(rowNum), Nothing))

            If h > curHeight Then
                pi.SetValue(Heights(rowNum), h, Nothing)
            End If

        End If

        g.DrawString(s, MyBase.TextBox.Font, foreBrush, r, DrawFormat)

        bPainted = True

        Dim e As DataGridFormatCellEventArgs
        e = New DataGridFormatCellEventArgs(rowNum, Me._col, Me.DataGridTableStyle.DataGrid.Font, backBrush, foreBrush)

        RaiseEvent SetCellFormat(Me, e, grid)
        If e.UseBaseClassDrawing Then
            MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)
        Else
            g.FillRectangle(e.BackBrush, bounds)

            If Es_Planificacion = "S" Then
                If s = "************************************ FINAL ****************************************" Then g.DrawString(Me.GetColumnValueAtRow(source, rowNum).ToString, e.TextFont, e.ForeBrush, bounds.X, bounds.Y) : GoTo Fin
                If s <> "" Then
                    Call Control_Letra_Parentesis(bounds, e, g, Fondo, s)
                End If
fin:        Else
                g.DrawString(Me.GetColumnValueAtRow(source, rowNum).ToString, e.TextFont, e.ForeBrush, bounds.X, bounds.Y)
            End If
        End If
SaltoxMarca:
        If (e.TextFont Is Me.DataGridTableStyle.DataGrid.Font) = False Then
            e.TextFont.Dispose()
        End If
    End Sub
    Private Sub Cuenta_Filas(ByRef StrFila As String)
        Dim Prioridad_Aux As Integer
        Dim query As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        query = "Select ELE_PRIORIDAD FROM ANALISIS_ELEMENTOS WHERE ANA_CODIGO=" & CodAnal & " order by ELE_PRIORIDAD"
        Dim myCommand5 As New SqlCommand(query, con)
        Dim myReader5 As SqlDataReader
        myReader5 = myCommand5.ExecuteReader()
        Try
            Prioridad_Aux = 1 : StrFila = " "
            While myReader5.Read()
                If Prioridad_Aux <> CInt(Mid(CStr(myReader5.GetInt32(0)), 1, 1)) Then
                    StrFila = StrFila & vbCrLf & " "
                End If
                Prioridad_Aux = CInt(Mid(CStr(myReader5.GetInt32(0)), 1, 1))
            End While
            myReader5.Close()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub

    Private Sub Control_Letra_Parentesis(ByVal bounds As System.Drawing.Rectangle, ByVal e As DataGridFormatCellEventArgs, ByVal g As System.Drawing.Graphics, ByRef fondo As Font, ByVal elemento As String)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Sub, Fila_Ultima, Fila_Analisis, FILA_OTEST_ELEMENTO As DataRow
        Dim BuscaSub, Busca_Ele, BuscaAna As Object
        Dim ColorLetra As Brush
        Dim Ot_Num_Mom, MyPos, Fila_Descripcion, Ultima_Fila, NlabD, NlabH, xx, ij, largo_codigo, largo_pos, fila_mas, IntSub, IntMuestra, IntNLab As Integer
        Dim Tipo_Analisis, SubMuestra, EleUlt, StrDPar, StrEle, caracter, query, Acumula, EsNegrilla As String
        'Dim dbman, Dbman1 As DbManager
        Dim datos As New DataSet
        Dim largoSub, numFila, SwGuion As Integer
        Dim largo, Espacios, pix As Double
        Dim ds As DataSet = New DataSet
        Try
            'If Ot_Num = "" Then Ot_Num = "0"

            'If CodAnal = 6250 Then
            '    xx = 0
            'End If

            MyPos = InStr(Ot_Num, "U")

            If MyPos > 0 Then Ot_Num_Mom = CInt(Mid(Ot_Num, 1, MyPos - 1)) Else Ot_Num_Mom = CInt(Ot_Num)



            For xx = 1 To Len(NumLab)
                caracter = Mid(NumLab, xx, 1)
                If caracter = "-" Then
                    IntNLab = CInt(Trim(Acumula))
                    Exit For
                End If
                Acumula = Acumula + caracter
            Next

            IntNLab = CInt(Acumula)

            BuscaAna = CodAnal
            Fila_Analisis = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaAna)
            IntMuestra = Fila_Analisis("TMU_CODIGO")
            IntSub = Fila_Analisis("SUB_CODIGO")
            Tipo_Analisis = Fila_Analisis("TIPO_COD")

            'If Ot_Num_Mom = 63960 Then
            '    xx = 0
            'End If


            BuscaSub = IntSub
            Fila_Sub = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaSub)
            If Not (Fila_Sub Is Nothing) = True Then SubMuestra = Fila_Sub("ANA_ANALISIS") Else SubMuestra = ""

            Try
                Dim SqlConn As New SqlConnection
                SqlConn = New SqlConnection(Conexion1)
                query = "select OT_NUMERO,TMU_CODIGO,OTC_NLAB_DESDE,OTC_NLAB_HASTA FROM OT_CODIFICACION WHERE OT_NUMERO=" & Ot_Num_Mom & " AND TMU_CODIGO=" & IntMuestra & " AND OTC_NLAB_DESDE=" & IntNLab
                Dim myCommand As New SqlCommand(query, SqlConn)
                SqlConn.Open()
                Dim myReader As SqlDataReader = myCommand.ExecuteReader()
                myReader.Read()
                NlabD = myReader.GetInt32(2)
                NlabH = myReader.GetInt32(3)
                myReader.Close()
                SqlConn.Close()
            Catch ex As Exception
            End Try
            Cjto_Tablas1.Tables("OTEST_ELEMENTO").Clear()
            Cjto_Tablas1.Tables("OTEST_ELEMENTO_COMP").Clear()
            Try
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", Ot_Num_Mom, SqlDbType.Int)
                    .AgregarParametro("@NLab", IntNLab, SqlDbType.Int)
                    .AgregarParametro("@CodAna", CodAnal, SqlDbType.Float)
                    .AgregarParametro("@Tipo_Analisis", Tipo_Analisis, SqlDbType.NVarChar)
                    .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                    .EjecutarQueryDt("usp_SelectPlanificacion", Cjto_Tablas1, "OTEST_ELEMENTO")
                End With
            Catch ex As Exception
                'MsgBox("Error en consulta")
            End Try


            Ultima_Fila = Cjto_Tablas1.Tables("OTEST_ELEMENTO").Rows.Count
            EleUlt = ""
            If Ultima_Fila <> 0 Then
                Fila_Ultima = Cjto_Tablas1.Tables("OTEST_ELEMENTO").Rows(Ultima_Fila - 1)
                EleUlt = Fila_Ultima("ELE_CODIGO")
            End If

            Try
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", Ot_Num_Mom, SqlDbType.Int)
                    .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                    .EjecutarQueryDt("usp_SelectPlanificacionElemento", Cjto_Tablas1, "OTEST_ELEMENTO_COMP")
                End With
                With SP
                    .Inicializar()
                    .AgregarParametro("@TMuestra", IntMuestra, SqlDbType.Int)
                    .AgregarParametro("@NLabDesde", NlabD, SqlDbType.Int)
                    .AgregarParametro("@NLabHasta", NlabH, SqlDbType.Int)
                    ds = .EjecutarQuery("usp_SelectPlanificacionSubTitulo")
                End With
            Catch ex As Exception
                MsgBox("Error en OT : " & Ot_Num_Mom)
            End Try

            largo = 0
            pix = 6
            fila_mas = -12 : Fila_Descripcion = 0 : SwGuion = 0
            fondo = New Font("Courier New", 8)
            ColorLetra = New SolidBrush(Color.Red)
            EsNegrilla = "N"

            'If SubMuestra <> "" Then
            '    g.DrawString(SubMuestra, fondo, ColorLetra, bounds.X, bounds.Y)
            '    largo = Examina_Espacios(SubMuestra, pix) + pix
            '    largoSub = largo
            '    g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y)
            '    largo = largo + pix
            'End If
            If FilaMarcaX = "S" Then GoTo SALTOXMARCAX
            For Each FILA_OTEST_ELEMENTO In Cjto_Tablas1.Tables("OTEST_ELEMENTO").Rows
                Try
                    If Tipo_Analisis = "JA" And Fila_Descripcion = 0 Then fila_mas = fila_mas + 12 : largo = 72 + pix : largo = largo + pix : GoTo SaltoxJocker
                    If Tipo_Analisis <> "JA" And Fila_Descripcion <> CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1)) Then
                        fila_mas = fila_mas + 12 : largo = 0
                        'If (FILA_OTEST_ELEMENTO("TMU_CODIGO")) = 3000 Then GoTo SaltoxAgua
                        If IsDBNull(FILA_OTEST_ELEMENTO("TITULO_FILA")) = False Then
                            g.DrawString(FILA_OTEST_ELEMENTO("TITULO_FILA"), fondo, ColorLetra, bounds.X, bounds.Y + fila_mas)
                            largo = 72 + pix
                            'g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + pix
                        Else
                            largo = 72 + pix : largo = largo + pix
                        End If
SaltoxAgua:
                        If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                            g.DrawString(ds.Tables(0).Rows(0).Item("OTRO_TITULO"), fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + (72 + pix)
                            g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + pix
                        ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                            g.DrawString(ds.Tables(0).Rows(0).Item("TITULO"), fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + (72 + pix)
                            g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + pix
                        Else
                            largo = largo + (72 + pix)
                            g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + pix
                        End If
                    End If

                    If SwGuion = 1 And Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1)) Then
                        g.DrawString("-", fondo, e.ForeBrush, bounds.X + largo, bounds.Y + fila_mas)
                        largo = largo + pix
                    End If
SaltoxJocker:
                    If Tipo_Analisis = "JA" And Fila_Descripcion = 0 Then
                        If ds.Tables(0).Rows(0).Item("OTRO_TITULO") <> "" Then
                            g.DrawString(ds.Tables(0).Rows(0).Item("OTRO_TITULO"), fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + (72 + pix)
                            g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + pix
                        ElseIf ds.Tables(0).Rows(0).Item("TITULO") <> "" Then
                            g.DrawString(ds.Tables(0).Rows(0).Item("TITULO"), fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + (72 + pix)
                            g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + pix
                        Else
                            largo = largo + (72 + pix)
                            g.DrawString(":", fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            largo = largo + pix
                        End If
                    End If

                    StrEle = FILA_OTEST_ELEMENTO("ELE_CODIGO")
                    ColorLetra = ColorEstado(EsNegrilla, NlabD, NlabH, StrEle, fondo, IntMuestra, IntSub, IntNLab)
                    StrEle = FILA_OTEST_ELEMENTO("ELE_COD_DES")

                    If Tipo_Analisis = "JA" Then
                        largo = largo + pix
                        g.DrawString(StrEle, fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                        Espacios = Examina_Espacios(StrEle, pix)
                        If EsNegrilla = "N" Then largo = largo + Espacios
                        largo = largo + pix
                        GoTo SaltoEleJocker
                    End If


                    If IsDBNull(FILA_OTEST_ELEMENTO("ELE_PROCESO")) = False Then
                        If FILA_OTEST_ELEMENTO("ELE_PROCESO") <> "Autogenerado" Then
                            largo = largo + pix
                            g.DrawString(StrEle, fondo, ColorLetra, bounds.X + largo, bounds.Y + fila_mas)
                            Espacios = Examina_Espacios(StrEle, pix)
                            If EsNegrilla = "N" Then largo = largo + Espacios
                            largo = largo + pix
                        Else
                            largo = largo - pix
                        End If
                    End If
SaltoEleJocker:
                    If EleUlt = StrEle Then GoTo SALTOGUION
                    If largo > 3500 And Tipo_Analisis = "JA" Then fila_mas = fila_mas + 12 : largo = 0
                    StrEle = "" : SwGuion = 1
                    Fila_Descripcion = CInt(Mid(CStr(FILA_OTEST_ELEMENTO("ELE_PRIORIDAD")), 1, 1))
SALTOGUION:
                Catch ex As Exception
                    MsgBox("Error en OT : " & Ot_Num_Mom)
                End Try
            Next
        Catch ex As Exception
            MsgBox("Error en OT : " & Ot_Num_Mom)
        End Try
SALTOXMARCAX:
    End Sub

    Private Function Examina_Espacios(ByVal EleStr As String, ByVal pix As Double) As Double
        Dim ii, Cuenta As Double
        Dim letra As String
        Try
            Cuenta = 0
            For ii = 1 To Len(EleStr)
                letra = Mid(EleStr, ii, 1)
                'If letra > Chr(65) And letra < Chr(90) Then Cuenta = Cuenta + 7 : GoTo enc 'mayuscula
                'If letra > Chr(97) And letra < Chr(122) Then Cuenta = Cuenta + 7 : GoTo enc 'minuscula
                'If letra > Chr(48) And letra < Chr(57) Then Cuenta = Cuenta + 7 : GoTo enc 'numero
                Cuenta = Cuenta + pix
enc:
            Next
            Examina_Espacios = Cuenta
            Return Examina_Espacios
        Catch ex As Exception
            MsgBox("error en examina espacios ")
        End Try

    End Function


    Private Function ColorEstado(ByRef EsNegrilla As String, ByVal NlabD As Integer, ByVal NlabH As Integer, ByVal StrEle As String, ByRef fondo As Font, ByVal IntMuestra As Integer, ByVal IntSub As Integer, ByVal IntNLab As Integer) As Brush
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim BuscaEle(1), BuscaOtEsE(3) As Object
        Dim ll, xx, IntPrio, Mypos, Ot_Num_Mom As Integer
        Dim Fila_Elemento, Fila_Analisis, Fila_OtestE As DataRow
        Dim caracter, Acumula, query, EstadoEs As String
        Dim Retorno As Integer = 0


        Try
            fondo = New Font("Courier New", 8)
            EsNegrilla = "N"
            Try
                BuscaEle(0) = IntMuestra
                BuscaEle(1) = Trim(StrEle)
                Fila_Elemento = Cjto_Tablas1.Tables("ELEMENTO").Rows.Find(BuscaEle)
                IntPrio = Fila_Elemento("ELE_PRIORIDAD")

                For ll = NlabD To NlabH
                    Retorno = 0
                    Mypos = InStr(Ot_Num, "U")
                    If Mypos > 0 Then Ot_Num_Mom = Mid(Ot_Num, 1, Mypos - 1) Else Ot_Num_Mom = Ot_Num
                    BuscaOtEsE(0) = Ot_Num_Mom
                    BuscaOtEsE(1) = IntMuestra
                    BuscaOtEsE(2) = ll
                    BuscaOtEsE(3) = Trim(StrEle)
                    Fila_OtestE = Cjto_Tablas1.Tables("OTEST_ELEMENTO_COMP").Rows.Find(BuscaOtEsE)

                    Try
                        With SP
                            .Inicializar()
                            .AgregarParametro("@OTNum", Ot_Num_Mom, SqlDbType.Int)
                            .AgregarParametro("@NLab", ll, SqlDbType.Int)
                            Retorno = .EjecutarEscalar("usp_SelectNLabPlanificado")
                        End With
                    Catch ex As Exception
                        MsgBox("Error al rescatar no planificado")
                    End Try


                    If (Fila_OtestE Is Nothing) = False Then
                        '
                        'repeticiones
                        '
                        If Fila_OtestE("ELE_ESTADO") = "DuxA" Then
                            EstadoEs = "DuxA"
                            Exit For
                        End If

                        If Fila_OtestE("ELE_ESTADO") = "DuxR" Then
                            EstadoEs = "DuxR"
                        End If

                        If Fila_OtestE("ELE_ESTADO") = "DuRe" Then
                            If EstadoEs = "DuxR" Then Exit For
                            EstadoEs = "DuRe"
                        End If

                        'Normales

                        If Fila_OtestE("ELE_ESTADO") = "xA" Then
                            If EstadoEs = "DuxR" Or EstadoEs = "DuxA" Then Exit For
                            EstadoEs = "xA"
                            Exit For
                        End If
                        If Fila_OtestE("ELE_ESTADO") = "xR" Then
                            If EstadoEs = "DuxR" Or EstadoEs = "DuxA" Then Exit For
                            EstadoEs = "xR"
                        End If
                        If Fila_OtestE("ELE_ESTADO") = "Nulo" Then
                            If EstadoEs = "xR" Or EstadoEs = "xA" Or EstadoEs = "Re" Then Exit For
                            If EstadoEs = "DuxA" Or EstadoEs = "DuxR" Or EstadoEs = "DuRe" Then Exit For
                            EstadoEs = "Nulo"
                        End If

                        If Fila_OtestE("ELE_ESTADO") = "Re" Then
                            If EstadoEs = "xR" Then Exit For
                            EstadoEs = "Re"
                        End If
                    End If
                Next
                ColorEstado = New SolidBrush(Color.Red)
                If EstadoEs = "DuxA" Then ColorEstado = New SolidBrush(Color.Magenta) : fondo = New Font("Courier New", 8)
                If EstadoEs = "DuxR" Then ColorEstado = New SolidBrush(Color.DarkViolet) : fondo = New Font("Courier New", 8) ': EsNegrilla = "S"
                If EstadoEs = "DuRe" Then ColorEstado = New SolidBrush(Color.Gray) : fondo = New Font("Courier New", 8) ': EsNegrilla = "S"

                If EstadoEs = "xA" And Retorno = 0 Then ColorEstado = New SolidBrush(Color.Red) : fondo = New Font("Courier New", 8)
                If EstadoEs = "xA" And Retorno > 0 Then ColorEstado = New SolidBrush(Color.Red) : fondo = New Font("Courier New", 8, FontStyle.Bold)

                If EstadoEs = "xR" Then ColorEstado = New SolidBrush(Color.Blue) : fondo = New Font("Courier New", 8)
                If EstadoEs = "Re" Then ColorEstado = New SolidBrush(Color.Black) : fondo = New Font("Courier New", 8)
                If EstadoEs = "Nula" Then ColorEstado = New SolidBrush(Color.MistyRose) : fondo = New Font("Courier New", 8)
                If EstadoEs = "Reot" Then ColorEstado = New SolidBrush(Color.Coral) : fondo = New Font("Courier New", 8)

            Catch ex As Exception
                ColorEstado = New SolidBrush(Color.Red)
            End Try
        Catch ex As Exception
            MsgBox("error en color estado")
        End Try
    End Function
End Class
