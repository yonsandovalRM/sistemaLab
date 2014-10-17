Public Class F_Cuentas

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim rp As New ReporteCentroCostos
        Dim frm As New R_GeneraReporte
        Dim arr, arr2 As Array
        Dim desde, hasta, analisis, centroCosto As String
        Dim i, j, k, l, r, s, t, temp1, temp2, cantidad, totp, totr, codigo As Integer
        Dim cd As New CapaDato
        Dim fila As DataRow
        Dim dsN, dsF As New DataSet
        Dim dtN, dtF As New DataTable
        Dim dt As New DataTable
        Cjto_Tablas1.Clear()

        arr = Split(Me.dtDesde.Text, "-")
        desde = arr(2).ToString & "-" & arr(0).ToString & "-" & arr(1).ToString
        arr2 = Split(Me.dtHasta.Text, "-")
        hasta = arr2(2).ToString & "-" & arr2(0).ToString & "-" & arr2(1).ToString

        cd.Inicializar()
        cd.AgregarParametro("@f1", desde, SqlDbType.VarChar)
        cd.AgregarParametro("@f2", hasta, SqlDbType.VarChar)
        cd.AgregarParametro("@centro", 1000, SqlDbType.Int)
        cd.EjecutarQueryDt("ls_datosCentroCosto", Cjto_Tablas1, "CentroCosto")

        cd.Inicializar()
        cd.AgregarParametro("@f1", desde, SqlDbType.VarChar)
        cd.AgregarParametro("@f2", hasta, SqlDbType.VarChar)
        cd.AgregarParametro("@centro", 7000, SqlDbType.Int)
        cd.EjecutarQueryDt("ls_datosCentroCosto", Cjto_Tablas1, "CentroCosto")

        cd.Inicializar()
        cd.AgregarParametro("@f1", desde, SqlDbType.VarChar)
        cd.AgregarParametro("@f2", hasta, SqlDbType.VarChar)
        cd.AgregarParametro("@centro", 1000, SqlDbType.Int)
        dsN = cd.EjecutarQuery("ls_datosCentroPorAnalisis")

        cd.Inicializar()
        cd.AgregarParametro("@f1", desde, SqlDbType.VarChar)
        cd.AgregarParametro("@f2", hasta, SqlDbType.VarChar)
        cd.AgregarParametro("@centro", 7000, SqlDbType.Int)
        dsF = cd.EjecutarQuery("ls_datosCentroPorAnalisis")

        dtN = dsN.Tables(0)
        dtF = dsF.Tables(0)

        r = dtN.Rows.Count
        s = dtF.Rows.Count
        i = 0
        j = 0
        temp2 = 0
        While i < r
            j = l
            temp1 = dtN.Rows.Item(i).Item(1)
            If temp1 <> temp2 Then
                temp2 = temp1
                l = l + 1
            End If

            If temp1 = temp2 Then
                If j <> l Then
                    If i <> 0 Then
                        ' inserto en la tabla
                        codigo = dtN.Rows.Item(i - 1).Item(1)
                        analisis = dtN.Rows.Item(i - 1).Item(5)
                        centroCosto = dtN.Rows.Item(i - 1).Item(0).ToString
                        Cjto_Tablas1.Tables("CentroCostoAnalisis").Rows.Add(centroCosto, totp.ToString, cantidad.ToString, totr.ToString, codigo.ToString, analisis)

                        totp = 0
                        totr = 0
                        cantidad = 0
                    End If
                End If
                totp = totp + (dtN.Rows.Item(i).Item(3) * dtN.Rows.Item(i).Item(2))
                cantidad = cantidad + dtN.Rows.Item(i).Item(2)
                totr = totr + (dtN.Rows.Item(i).Item(4) * dtN.Rows.Item(i).Item(2))

            End If
            i = i + 1
        End While



        rp.SetDataSource(Cjto_Tablas1)
        frm.CrystalReportViewer1.ReportSource = rp
        frm.CrystalReportViewer1.Dock = DockStyle.Fill

        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(frm.CrystalReportViewer1)
            .Text = "Centros de costo"
            .WindowState = FormWindowState.Maximized
            .ShowDialog()
        End With


    End Sub

 
    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim rp As New ReporteCentroCostoDetalle
        Dim frm As New R_GeneraReporte
        Dim arr, arr2 As Array
        Dim desde, hasta, analisis, centroCosto As String
        Dim i, j, k, l, r, s, t, temp1, temp2, cantidad, totp, totr, codigo As Integer
        Dim cd As New CapaDato
        Dim fila As DataRow
        Dim dsN, dsF As New DataSet
        Dim dtN, dtF As New DataTable
        Dim dt As New DataTable
        Cjto_Tablas1.Clear()

        arr = Split(Me.dtDesde.Text, "-")
        desde = arr(2).ToString & "-" & arr(0).ToString & "-" & arr(1).ToString
        arr2 = Split(Me.dtHasta.Text, "-")
        hasta = arr2(2).ToString & "-" & arr2(0).ToString & "-" & arr2(1).ToString

        cd.Inicializar()
        cd.AgregarParametro("@f1", desde, SqlDbType.VarChar)
        cd.AgregarParametro("@f2", hasta, SqlDbType.VarChar)
        cd.AgregarParametro("@centro", 1000, SqlDbType.Int)
        dsN = cd.EjecutarQuery("ls_datosCentroPorAnalisis")

        cd.Inicializar()
        cd.AgregarParametro("@f1", desde, SqlDbType.VarChar)
        cd.AgregarParametro("@f2", hasta, SqlDbType.VarChar)
        cd.AgregarParametro("@centro", 7000, SqlDbType.Int)
        dsF = cd.EjecutarQuery("ls_datosCentroPorAnalisis")

        dtN = dsN.Tables(0)
        dtF = dsF.Tables(0)

        r = dtN.Rows.Count
        s = dtF.Rows.Count
        i = 0
        j = 0
        temp2 = 0
        While i < r
            j = l
            temp1 = dtN.Rows.Item(i).Item(1)
            If temp1 <> temp2 Then
                temp2 = temp1
                l = l + 1
            End If

            If temp1 = temp2 Then
                If j <> l Then
                    If i <> 0 Then
                        'inserto en la tabla
                        codigo = dtN.Rows.Item(i - 1).Item(1)
                        analisis = dtN.Rows.Item(i - 1).Item(5)
                        centroCosto = dtN.Rows.Item(i - 1).Item(0).ToString
                        Cjto_Tablas1.Tables("CentroCostoAnalisis").Rows.Add(centroCosto, totp.ToString, cantidad.ToString, totr.ToString, codigo.ToString, analisis)

                        totp = 0
                        totr = 0
                        cantidad = 0
                    End If
                End If
                totp = totp + (dtN.Rows.Item(i).Item(3) * dtN.Rows.Item(i).Item(2))
                cantidad = cantidad + dtN.Rows.Item(i).Item(2)
                totr = totr + (dtN.Rows.Item(i).Item(4) * dtN.Rows.Item(i).Item(2))

            End If
            i = i + 1
        End While
        i = 0
        j = 0
        l = 0

        While i < s
            j = l
            temp1 = dtF.Rows.Item(i).Item(1)
            If temp1 <> temp2 Then
                temp2 = temp1
                l = l + 1
            End If

            If temp1 = temp2 Then
                If j <> l Then
                    If i <> 0 Then
                        'inserto en la tabla
                        codigo = dtF.Rows.Item(i - 1).Item(1)
                        analisis = dtF.Rows.Item(i - 1).Item(5)
                        centroCosto = dtF.Rows.Item(i - 1).Item(0).ToString
                        Cjto_Tablas1.Tables("CentroCostoAnalisis").Rows.Add(centroCosto, totp.ToString, cantidad.ToString, totr.ToString, codigo.ToString, analisis)

                        totp = 0
                        totr = 0
                        cantidad = 0
                    End If
                End If
                totp = totp + (dtF.Rows.Item(i).Item(3) * dtF.Rows.Item(i).Item(2))
                cantidad = cantidad + dtF.Rows.Item(i).Item(2)
                totr = totr + (dtF.Rows.Item(i).Item(4) * dtF.Rows.Item(i).Item(2))

            End If
            i = i + 1
        End While


        rp.SetDataSource(Cjto_Tablas1)
        frm.CrystalReportViewer1.ReportSource = rp
        frm.CrystalReportViewer1.Dock = DockStyle.Fill

        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(frm.CrystalReportViewer1)
            .Text = "Centros de costo"
            .WindowState = FormWindowState.Maximized
            .ShowDialog()
        End With
    End Sub
End Class