Public Class F_ListadoFacturas
    Dim ds As New DataSet

    Private Sub F_ListadoFacturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cd As New CapaDato
        Dim i, r, total As Integer
        i = 0
        Cjto_Tablas1.Tables("ListadoFactura").Clear()
        cd.Inicializar()
        ds = cd.EjecutarQuery("ls_ListadoFacturas")

        Me.dgFacturas.DataSource = ds.Tables(0)

        r = Me.ds.Tables(0).Rows.Count
        total = 0
        While i < r
            total = total + CInt(Me.ds.Tables(0).Rows.Item(i).Item(5).ToString)
            i = i + 1
        End While

        Me.txCantFactPend.Text = Format(r, "###,###,###")
        Me.txValorFact.Text = Format(total, "###,###,###")

    End Sub

    Private Sub btnGeneraReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraReporte.Click
        Try
            Dim rp As New ReporteListadoFacturas
            Dim i As Integer
            Dim frm As New R_GeneraReporte
            Cjto_Tablas1.Tables("ListadoFactura").Clear()
            Dim cd As New CapaDato

            cd.Inicializar()
            cd.EjecutarQueryDt("ls_ListadoFacturas", Cjto_Tablas1, "ListadoFactura")

            rp.SetDataSource(Cjto_Tablas1)
            frm.CrystalReportViewer1.ReportSource = rp
            frm.CrystalReportViewer1.Dock = DockStyle.Fill

            Dim frmReporte As New Form
            With frmReporte
                .Controls.Add(frm.CrystalReportViewer1)
                .Text = "Listado de Facturas Pendientes"
                .WindowState = FormWindowState.Maximized
                .ShowDialog()
            End With
        Catch ex As Exception
        end try

    End Sub

End Class