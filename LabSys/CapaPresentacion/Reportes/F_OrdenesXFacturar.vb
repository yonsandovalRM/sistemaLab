Public Class F_OrdenesXFacturar

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim rp As New R_OrdenesXFacturar
        Dim frm As New R_GeneraReporte
        Dim arr, arr2 As Array
        Dim desde, hasta As String
        Dim i, r, temp2 As Integer
        Dim cd As New CapaDato
        Dim dsN As New DataSet
        Dim dtN As New DataTable
        Dim dt As New DataTable
        Cjto_Tablas1.Clear()

        arr = Split(Me.dtDesde.Text, "-")
        desde = arr(2).ToString & "-" & arr(0).ToString & "-" & arr(1).ToString
        arr2 = Split(Me.dtHasta.Text, "-")
        hasta = arr2(2).ToString & "-" & arr2(0).ToString & "-" & arr2(1).ToString

        cd.Inicializar()
        cd.AgregarParametro("@f1", desde, SqlDbType.VarChar)
        cd.AgregarParametro("@f2", hasta, SqlDbType.VarChar)
        dsN = cd.EjecutarQuery("ls_obtienexF2")



        dtN = dsN.Tables(0)

        r = dtN.Rows.Count
        i = 0
        temp2 = 0

        While i < r
            'inserto en la tabla
            Cjto_Tablas1.Tables("OrdenesxFacturar").Rows.Add(dtN.Rows.Item(i).Item(0), dtN.Rows.Item(i).Item(1), dtN.Rows.Item(i).Item(2), dtN.Rows.Item(i).Item(3), dtN.Rows.Item(i).Item(4), dtN.Rows.Item(i).Item(5), dtN.Rows.Item(i).Item(6), dtN.Rows.Item(i).Item(7))
            i = i + 1
        End While
    

        rp.SetDataSource(Cjto_Tablas1)
        frm.CrystalReportViewer1.ReportSource = rp
        frm.CrystalReportViewer1.Dock = DockStyle.Fill

        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(frm.CrystalReportViewer1)
            .Text = "Ordenes por Facturar"
            .WindowState = FormWindowState.Maximized
            .ShowDialog()
        End With
    End Sub
End Class