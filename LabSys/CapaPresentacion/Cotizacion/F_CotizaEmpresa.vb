Public Class F_CotizaEmpresa


    Private Sub F_CotizaEmpresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cotiza As class_COTIZADOR = Me.Owner
        Dim cd As New CapaDato
        Dim ds As New DataSet
        Dim dt As New DataTable

        cd.Inicializar()
        cd.AgregarParametro("@rut", cotiza.TextBox2.Text, SqlDbType.VarChar)
        cd.AgregarParametro("@nombre", cotiza.TextBox2.Text, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_DatosCotiza")
        dt = ds.Tables(0)

        Me.dg_CotizaEmpresa.DataSource = dt

    End Sub
End Class