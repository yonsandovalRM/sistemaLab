Public Class G_FacturaPendiente


    Private Sub G_FacturaPendiente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim F As F_OrdenTrabajo = Me.Owner
        Dim Fila_Consulta As DataRow
        Dim cd As New CapaDato
        Dim i As Integer

        Cjto_Tablas1.Tables("CLIENTE_PAGO_PENDIENTE").Clear()
        With cd
            .Inicializar()
            .AgregarParametro("@RutFactura", F.txRutFactura.Text, SqlDbType.NVarChar)
            .EjecutarQueryDt("ls_SelectOTPagoPendiente", Cjto_Tablas1, "CLIENTE_PAGO_PENDIENTE")
        End With

        Me.dgPendiente.DataSource = Cjto_Tablas1.Tables("CLIENTE_PAGO_PENDIENTE")


    End Sub
End Class