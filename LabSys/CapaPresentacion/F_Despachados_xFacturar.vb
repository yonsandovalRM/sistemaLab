Public Class F_Despachados_xFacturar
    Private Sub F_Despachados_xFacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()

        dsInicial = cd.EjecutarQuery("ys_ObtienePorFacturar")
        dt = dsInicial.Tables(0)


        Me.grillaDespachadosxFac.DataSource = dt
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()

        dsInicial = cd.EjecutarQuery("ys_ObtienePorFacturar")
        dt = dsInicial.Tables(0)


        Me.grillaDespachadosxFac.DataSource = dt
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDGV.Print_DataGridView(grillaDespachadosxFac)
    End Sub


End Class