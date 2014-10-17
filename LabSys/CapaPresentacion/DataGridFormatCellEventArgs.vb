Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Public Class DataGridFormatCellEventArgs
    Inherits EventArgs
    Private _column As Integer
    Private _row As Integer
    Private _font As Font
    Private _backBrush As Brush
    Private _foreBrush As Brush
    Private _useBaseClassDrawing As Boolean
    'Fields
    'Constructors
    'Methods

    Public Sub New(ByVal row As Integer, ByVal col As Integer, ByVal font1 As Font, ByVal backBrush As Brush, ByVal foreBrush As Brush)
        MyBase.New()
        _row = row
        _column = col
        _font = font1
        _backBrush = backBrush
        _foreBrush = foreBrush
        _useBaseClassDrawing = False
    End Sub

    Public Property Column() As Integer
        Get
            Return _column
        End Get
        Set(ByVal Value As Integer)
            _column = Value
        End Set
    End Property

    Public Property Row() As Integer
        Get
            Return _row
        End Get
        Set(ByVal Value As Integer)
            _row = Value
        End Set
    End Property

    Public Property TextFont() As Font
        Get
            Return _font
        End Get
        Set(ByVal Value As Font)
            _font = Value
        End Set
    End Property

    Public Property BackBrush() As Brush
        Get
            Return _backBrush
        End Get
        Set(ByVal Value As Brush)
            _backBrush = Value
        End Set
    End Property

    Public Property ForeBrush() As Brush
        Get
            Return _foreBrush
        End Get
        Set(ByVal Value As Brush)
            _foreBrush = Value
        End Set
    End Property

    Public Property UseBaseClassDrawing() As Boolean
        Get
            Return _useBaseClassDrawing
        End Get
        Set(ByVal Value As Boolean)
            _useBaseClassDrawing = Value
        End Set
    End Property

End Class

