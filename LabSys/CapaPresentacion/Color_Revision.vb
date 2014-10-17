Imports System.Reflection
Imports System.Data.SqlClient

Public Class Color_Revision
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
            s = CStr(Me.GetColumnValueAtRow([source], rowNum))
        End If

        Dim r As New RectangleF(bounds.X, bounds.Y, bounds.Width, bounds.Height)

        r.Inflate(0, -1)

        ' get the height column should be
        Dim sDraw As SizeF = g.MeasureString(s, Me.TextBox.Font, Me.Width, DrawFormat)
        Dim h As Integer = CInt(sDraw.Height)

        If AdjustHeight Then

            FillHeightArrayList()

            Dim pi As PropertyInfo = Heights(rowNum).GetType().GetProperty("Height")
            Dim curHeight As Integer = CInt(pi.GetValue(Heights(rowNum), Nothing))

            'If h > curHeight Then
            '    pi.SetValue(Heights(rowNum), h, Nothing)
            'End If

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
            If s <> "" Then Call ColorEstado(bounds, e, g, Fondo, s, rowNum)
        End If
        If (e.TextFont Is Me.DataGridTableStyle.DataGrid.Font) = False Then
            e.TextFont.Dispose()
        End If
    End Sub

    Private Sub ColorEstado(ByVal bounds As System.Drawing.Rectangle, ByVal e As DataGridFormatCellEventArgs, ByVal g As System.Drawing.Graphics, ByRef fondo As Font, ByVal ResultadoE As String, ByVal RowNum As Integer)
        Dim query, EstadoEs As String
        Dim BuscaEstado(3), BuscaEstadoDup(3) As Object
        Dim Fila_Estado As DataRow
        Dim Color_Estado As Brush
        Try
            If Contador_De_Posicion = 1 And MATRIZ_OT(RowNum) = 62130 Then
                query = ""
            End If
            If MATRIZ_NLAB(RowNum) = MATRIZ_DUPLICADOS(RowNum) Then
                BuscaEstadoDup(0) = CodMuestraRev
                BuscaEstadoDup(1) = MATRIZ_DUPLICADOS(RowNum)
                BuscaEstadoDup(2) = MATRIZ_ELEMENTOS(Me._col - 14)
                BuscaEstadoDup(3) = MATRIZ_NUMERODIGITACION(RowNum)
                Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO_DUPLICADOS").Rows.Find(BuscaEstadoDup)
            Else
                BuscaEstado(0) = CodMuestraRev
                BuscaEstado(1) = MATRIZ_NLAB(RowNum)
                'BuscaEstado(2) = MATRIZ_ELEMENTOS(Me._col - (15 - Contador_De_Posicion))
                BuscaEstado(2) = MATRIZ_ELEMENTOS(Me._col - 14)

                BuscaEstado(3) = MATRIZ_OT(RowNum)
                Fila_Estado = Cjto_Tablas1.Tables("TABLA_ESTADO").Rows.Find(BuscaEstado)
            End If
            If (Fila_Estado Is Nothing) = False Then
                EstadoEs = Fila_Estado("ELE_ESTADO")
            Else
                EstadoEs = "xA"
            End If
            Color_Estado = New SolidBrush(Color.Black)
            fondo = New Font("Arial", 8)
            If EstadoEs = "DuxA" Then Color_Estado = New SolidBrush(Color.Magenta) : fondo = New Font("Arial", 8)
            If EstadoEs = "DuxR" Then Color_Estado = New SolidBrush(Color.DarkViolet) : fondo = New Font("Arial", 8) ': EsNegrilla = "S"
            If EstadoEs = "DuRe" Then Color_Estado = New SolidBrush(Color.Silver) : fondo = New Font("Arial", 8) ': EsNegrilla = "S"

            If EstadoEs = "xA" Then Color_Estado = New SolidBrush(Color.Red) : fondo = New Font("Arial", 8)
            If EstadoEs = "xR" Then Color_Estado = New SolidBrush(Color.Blue) : fondo = New Font("Arial", 8)
            If EstadoEs = "Re" Then Color_Estado = New SolidBrush(Color.Black) : fondo = New Font("Arial", 8)
            If EstadoEs = "Reot" Then Color_Estado = New SolidBrush(Color.Coral) : fondo = New Font("Arial", 8)
            If EstadoEs = "Nula" Then Color_Estado = New SolidBrush(Color.MistyRose) : fondo = New Font("Arial", 8)
            g.DrawString(ResultadoE, fondo, Color_Estado, bounds.X, bounds.Y)
        Catch ex As Exception
            MsgBox("Error en color grilla revision")
        End Try

    End Sub
End Class
