Public Class Parametro
    Public Nombre As String
    Public Valor As String
    Public NombreCabecera As String
    Public ValorCabecera As String
    Public NombreDetalle As String
    Public ValorDetalle As String
    Public NombreElemento As String
    Public ValorElemento As String

    Public Sub New(ByVal Nombre As String, ByVal Valor As String)
        MyBase.New()
        Me.Nombre = Nombre
        Me.Valor = Valor
    End Sub

End Class

