Imports System.Data.SqlClient
Public Class Frm_EliminaFactura

    Private Sub Frm_EliminaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        With SP
            .Inicializar()
            .AgregarParametro("@numero", CInt(Txtfactura.Text), SqlDbType.Int)

            .EjecutarQuery("ys_EliminaFactura")
        End With

        ' Call Graba_Historia_Estado(0, "NULL", "NULL", "NULL", CInt(Txtfactura.Text), NEstFactura, "Mantenedor de Factura")

        MsgBox("Grabación finalizada")
    End Sub
End Class