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

    End Sub

    Protected Overloads Overrides Sub Edit(ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal bounds As Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)

        'comment to make cells unable to become editable
        MyBase.Edit(source, rowNum, bounds, [ReadOnly], instantText, cellIsVisible)

    End Sub
End Class

