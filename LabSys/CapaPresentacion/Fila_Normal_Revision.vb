Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class Fila_Normal_Revision
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
            'If rowNum = 201 Then
            '    Orden_Trabajo = 0
            'End If
            Select Case _col
                Case 0
                    If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                        If MATRIZ_OT(rowNum) = 0 Then
                            MATRIZ_OT(rowNum) = Me.GetColumnValueAtRow(source, rowNum)
                            Auxiliar_OT = Me.GetColumnValueAtRow(source, rowNum)
                        End If
                    Else
                        If MATRIZ_OT(rowNum) = 0 Then MATRIZ_OT(rowNum) = Auxiliar_OT
                    End If
                Case 10
                    If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                        If MATRIZ_DUPLICADOS(rowNum) = 0 And Me.GetColumnValueAtRow(source, rowNum) = "                              Dup." Then
                            AuxSD_Dup = "S"
                            GoTo numlabListo
                        Else
                            Auxiliar_Dup = 0
                            Contador_Dup = 0
                            GoTo numlabListo
                        End If
                    End If
                Case 11
                    If IsDBNull(Me.GetColumnValueAtRow(source, rowNum)) = False Then
                        If MATRIZ_NLAB(rowNum) = 0 Then
                            MATRIZ_NLAB(rowNum) = Me.GetColumnValueAtRow(source, rowNum)
                            If AuxSD_Dup = "S" Then
                                MATRIZ_DUPLICADOS(rowNum) = MATRIZ_NLAB(rowNum)
                                If Auxiliar_Dup = MATRIZ_DUPLICADOS(rowNum) Or Auxiliar_Dup = 0 Then
                                    MATRIZ_NUMERODIGITACION(rowNum) = Contador_Dup + 1
                                    Auxiliar_Dup = MATRIZ_DUPLICADOS(rowNum)
                                Else
                                    Contador_Dup = 0
                                    Auxiliar_Dup = 0
                                End If
                            End If
                            AuxSD_Dup = "N"
                            GoTo numlabListo
                        End If
                    End If
            End Select
numlabListo:
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
