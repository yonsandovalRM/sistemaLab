Public Class G_Empresa

    Private Sub G_Empresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim cd As New CapaDato
        Dim ds As New DataSet
        Dim i As Integer
        cd.Inicializar()
        cd.AgregarParametro("@Empresa", orden.cbEmpresa.Text, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_TraeDatosEmpresa")


        For i = 0 To ds.Tables(0).Rows.Count - 1
            Me.dgEmpresa.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, _
            ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, _
           ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
        Next

        Me.dgEmpresa.Refresh()


    End Sub

    Private Sub dgEmpresa_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEmpresa.CellDoubleClick
        Try
            Dim orden As F_OrdenTrabajo = Me.Owner

            Dim cd As New CapaDato
            Dim dsProductor As New DataSet
            cd.Inicializar()
            cd.AgregarParametro("@rut", dgEmpresa.Rows.Item(e.RowIndex).Cells.Item(1).Value, SqlDbType.VarChar)
            dsProductor = cd.EjecutarQuery("ls_TraeDatosProdConRUT")

            With orden
                .txRutProductor.Text = dsProductor.Tables(0).Rows(0).Item(1).ToString
                .cbProductor.Text = dsProductor.Tables(0).Rows(0).Item(0).ToString
                .txDireccion.Text = dsProductor.Tables(0).Rows(0).Item(4).ToString
                .cbEmpresa.Text = dsProductor.Tables(0).Rows(0).Item(2).ToString
                .txPredio.Text = dsProductor.Tables(0).Rows(0).Item(3).ToString

                If dsProductor.Tables(0).Rows(0).Item(9).ToString <> "" Then
                    If dsProductor.Tables(0).Rows(0).Item(9).ToString = "1" Then
                        .cbRegionN.Text = "I - Tarapaca "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "2" Then
                        .cbRegionN.Text = "II - Antofagasta "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "3" Then
                        .cbRegionN.Text = "III - Atacama "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "4" Then
                        .cbRegionN.Text = "IV - Coquimbo "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "5" Then
                        .cbRegionN.Text = "V - Valparaiso "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "6" Then
                        .cbRegionN.Text = "VI - Gral.B.O`Higgins "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "7" Then
                        .cbRegionN.Text = "VII - Maule "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "8" Then
                        .cbRegionN.Text = "VIII - Biobio "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "9" Then
                        .cbRegionN.Text = "IX - Araucania "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "10" Then
                        .cbRegionN.Text = "X - De los Lagos "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "11" Then
                        .cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez) "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "12" Then
                        .cbRegionN.Text = "XII - Magallanes Y Antartica Ch. "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "13" Then
                        .cbRegionN.Text = "XIII - Metropolitana "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "14" Then
                        .cbRegionN.Text = "XIV - Los Ríos "
                    ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "15" Then
                        .cbRegionN.Text = "XV - Arica y Parinacota "
                    End If
                End If

                .cbLocalidad.Text = dsProductor.Tables(0).Rows(0).Item(5).ToString
                .cbCiudad.Text = dsProductor.Tables(0).Rows(0).Item(7).ToString
                .cbComuna.Text = dsProductor.Tables(0).Rows(0).Item(6).ToString
                .cbProvincia.Text = dsProductor.Tables(0).Rows(0).Item(8).ToString
                .txFono1.Text = dsProductor.Tables(0).Rows(0).Item(10).ToString
                .txFono2.Text = dsProductor.Tables(0).Rows(0).Item(11).ToString
                .txCelular1.Text = dsProductor.Tables(0).Rows(0).Item(12).ToString
                .txCelular2.Text = dsProductor.Tables(0).Rows(0).Item(13).ToString
                .txFax1.Text = dsProductor.Tables(0).Rows(0).Item(14).ToString
                'ot.txFax2.Text = dr.Item(15).ToString
                .txEmail1.Text = dsProductor.Tables(0).Rows(0).Item(16).ToString
                .txEmail2.Text = dsProductor.Tables(0).Rows(0).Item(17).ToString
                .txSolicita.Text = dsProductor.Tables(0).Rows(0).Item(18).ToString
                .txFonoSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(19).ToString
                .txFonoSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(20).ToString
                .txCelularSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(21).ToString
                .txCelularSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(22).ToString
                .txFaxSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(23).ToString
                .txFaxSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(24).ToString
                .txEmailSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(25).ToString
                .txEmailSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(26).ToString
                .txRemite.Text = dsProductor.Tables(0).Rows(0).Item(27).ToString
                .txFonoRemite1.Text = dsProductor.Tables(0).Rows(0).Item(28).ToString
                .txFonoRemite2.Text = dsProductor.Tables(0).Rows(0).Item(29).ToString
                .txCelularRemite1.Text = dsProductor.Tables(0).Rows(0).Item(30).ToString
                .txCelularRemite2.Text = dsProductor.Tables(0).Rows(0).Item(31).ToString
                .txFaxRemite1.Text = dsProductor.Tables(0).Rows(0).Item(32).ToString
                .txFaxRemite2.Text = dsProductor.Tables(0).Rows(0).Item(33).ToString
                .txEmailRemite1.Text = dsProductor.Tables(0).Rows(0).Item(34).ToString
                .txEmail2Re.Text = dsProductor.Tables(0).Rows(0).Item(35).ToString
                .txRutFactura.Text = dsProductor.Tables(0).Rows(0).Item(36).ToString
                .txRazonSocial.Text = dsProductor.Tables(0).Rows(0).Item(37).ToString
                .txFonoRS1.Text = dsProductor.Tables(0).Rows(0).Item(38).ToString
                .txFonoRS2.Text = dsProductor.Tables(0).Rows(0).Item(39).ToString
                .txGiro.Text = dsProductor.Tables(0).Rows(0).Item(40).ToString
                .txDireccionRS.Text = dsProductor.Tables(0).Rows(0).Item(41).ToString
                .cbComunaRS.Text = dsProductor.Tables(0).Rows(0).Item(42).ToString
                .cbCiudadRS.Text = dsProductor.Tables(0).Rows(0).Item(43).ToString
                .txEncargadoPago.Text = dsProductor.Tables(0).Rows(0).Item(44).ToString
                .txFonoPagoRS1.Text = dsProductor.Tables(0).Rows(0).Item(45).ToString
                .txFonoPagoRS2.Text = dsProductor.Tables(0).Rows(0).Item(46).ToString
                .txEmailRS1.Text = dsProductor.Tables(0).Rows(0).Item(48).ToString
                .txEmailRS2.Text = dsProductor.Tables(0).Rows(0).Item(49).ToString
                If (dsProductor.Tables(0).Rows(0).Item(51).ToString) = 0 Then
                    .chRetiraLab.Checked = False
                Else
                    .chRetiraLab.Checked = True
                End If

                If (dsProductor.Tables(0).Rows(0).Item(52).ToString) = 0 Then
                    .chAvisaFono.Checked = False
                Else
                    .chAvisaFono.Checked = True
                End If

                If (dsProductor.Tables(0).Rows(0).Item(53).ToString) = 0 Then
                    .chFax.Checked = False
                Else
                    .chFax.Checked = True
                End If

                If (dsProductor.Tables(0).Rows(0).Item(54).ToString) = 0 Then
                    .chEmail.Checked = False
                Else
                    .chEmail.Checked = True
                End If

                If (dsProductor.Tables(0).Rows(0).Item(55).ToString) = 0 Then
                    .chCorreo.Checked = False
                Else
                    .chCorreo.Checked = True
                End If

                If (dsProductor.Tables(0).Rows(0).Item(56).ToString) = 0 Then
                    .chBus.Checked = False
                Else
                    .chBus.Checked = True
                End If
                If (dsProductor.Tables(0).Rows(0).Item(57).ToString) = 0 Then
                    .chOtro.Checked = False
                Else
                    .chOtro.Checked = True
                End If

                .txOtroDespacho.Text = dsProductor.Tables(0).Rows(0).Item(58).ToString
                .txSenores.Text = dsProductor.Tables(0).Rows(0).Item(59).ToString
                .txAtencion.Text = dsProductor.Tables(0).Rows(0).Item(60).ToString
                .txDireccionDespacho.Text = dsProductor.Tables(0).Rows(0).Item(61).ToString
                .txCasilla.Text = dsProductor.Tables(0).Rows(0).Item(62).ToString
                .cbCiudadDespacho.Text = dsProductor.Tables(0).Rows(0).Item(64).ToString
                .cbComunaDespacho.Text = dsProductor.Tables(0).Rows(0).Item(63).ToString
                'ot.dtFechaDespacho.Text = dr.Item(66)
                .txFonoDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(66).ToString
                .txFonoDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(67).ToString
                .txFaxDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(70).ToString
                .txFaxDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(71).ToString
                .txCelularDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(68).ToString
                .txCelularDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(69).ToString
                .txEmailDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(72).ToString
                .txEmailDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(73).ToString
            End With

            Me.Close()

        Catch ex As Exception

        End Try

    End Sub
End Class