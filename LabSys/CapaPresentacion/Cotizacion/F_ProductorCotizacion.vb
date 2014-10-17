
Public Class F_ProductorCotizacion
  

    Private Sub F_ProductorCotizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cotiza As class_COTIZADOR = Me.Owner
        Dim cd As New CapaDato
        Dim ds As New DataSet
        Dim dt As New DataTable

        cd.Inicializar()
        cd.AgregarParametro("@pro_rut", cotiza.TextBox2.Text, SqlDbType.VarChar)
        cd.AgregarParametro("@pro_nombre", cotiza.TextBox2.Text, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_productorCotiza")
        dt = ds.Tables(0)

        Me.dg_CotizacionP.DataSource = dt



    End Sub
End Class