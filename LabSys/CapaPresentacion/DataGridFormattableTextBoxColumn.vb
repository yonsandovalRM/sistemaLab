Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class DataGridFormattableTextBoxColumn
    Inherits DataGridTextBoxColumn
    Private _col As Integer
    Public grid As DataGrid
    'Fields
    'Constructors
    'Events
    'Methods

    Public Sub New(ByVal col As Integer)
        MyBase.New()
        _col = col
    End Sub
    Public Event SetCellFormat As FormatCellEventHandler

    Protected Overloads Overrides Sub Paint(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal backBrush As Brush, ByVal foreBrush As Brush, ByVal alignToRight As Boolean)
        Dim e As DataGridFormatCellEventArgs
        Dim x As Integer
        Try

            e = New DataGridFormatCellEventArgs(rowNum, Me._col, Me.DataGridTableStyle.DataGrid.Font, backBrush, foreBrush)
            RaiseEvent SetCellFormat(Me, e, grid)
            If e.UseBaseClassDrawing Then
                MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)
            Else
                g.FillRectangle(e.BackBrush, bounds)
                g.DrawString(Me.GetColumnValueAtRow(source, rowNum).ToString, e.TextFont, e.ForeBrush, bounds.X, bounds.Y)
            End If
            If (e.TextFont Is Me.DataGridTableStyle.DataGrid.Font) = False Then
                e.TextFont.Dispose()
            End If
            If Es_Planificacion = "S" Then
                Select Case _col
                    Case 1
                        If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                            If Me.GetColumnValueAtRow(source, rowNum) <> "" Then Ot_Num = Me.GetColumnValueAtRow(source, rowNum)
                        End If
                    Case 7
                        If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                            If Me.GetColumnValueAtRow(source, rowNum) <> "" Then NumLab = Me.GetColumnValueAtRow(source, rowNum) : GoTo numlabListo
                        End If
                    Case 8
                        If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                            If Me.GetColumnValueAtRow(source, rowNum) <> "" Then NumLab = Me.GetColumnValueAtRow(source, rowNum) : GoTo numlabListo
                        End If
                    Case 9
                        If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                            If Me.GetColumnValueAtRow(source, rowNum) <> "" Then NumLab = Me.GetColumnValueAtRow(source, rowNum) : GoTo numlabListo
                        End If
                    Case 10
                        If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                            If Me.GetColumnValueAtRow(source, rowNum) <> "" Then NumLab = Me.GetColumnValueAtRow(source, rowNum) : GoTo numlabListo
                        End If
                    Case 11
                        If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then CodAnal = Me.GetColumnValueAtRow(source, rowNum)
                End Select
numlabListo:
            End If
        Catch ex As Exception
            MsgBox("error en columan no multilineas")
        End Try

    End Sub
    Protected Overloads Overrides Sub Edit(ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal bounds As Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        Dim columna As Integer
        'comment to make cells unable to become editable
        MyBase.Edit(source, rowNum, bounds, [readOnly], instantText, cellIsVisible)
    End Sub
End Class


