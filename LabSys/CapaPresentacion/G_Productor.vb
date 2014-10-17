Imports System.Data
Imports System.Data.SqlClient

Public Class G_Productor

    Private Sub G_Productor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LabsysDataSet4.CIUDAD' Puede moverla o quitarla según sea necesario.
        'Me.CIUDADTableAdapter.Fill(Me.LabsysDataSet4.CIUDAD)
        Dim cd As New CapaDato
        Dim cn As New CapaNegocio
        Dim ds, dsAnalisis, dsDescripcion As New DataSet
        Dim i, x, y As Integer
        Dim orden As F_OrdenTrabajo = Me.Owner

        If cotiza = "S" Then
            cotiza = ""


            Me.dgProductor.Rows.Clear()

            dsProductor = cn.buscaProductor(dtCotiza.Rows.Item(0).Item(1), dtCotiza.Rows.Item(0).Item(0), "", "")

            For i = 0 To dsProductor.Tables(0).Rows.Count - 1
                dgProductor.Rows.Add(dsProductor.Tables(0).Rows(i).Item(76).ToString, dsProductor.Tables(0).Rows(i).Item(0).ToString, _
                dsProductor.Tables(0).Rows(i).Item(2).ToString, dsProductor.Tables(0).Rows(i).Item(3).ToString, _
               dsProductor.Tables(0).Rows(i).Item(18).ToString, dsProductor.Tables(0).Rows(i).Item(5).ToString, _
               dsProductor.Tables(0).Rows(i).Item(6).ToString, dsProductor.Tables(0).Rows(i).Item(1).ToString, _
               dsProductor.Tables(0).Rows(i).Item(36).ToString)

            Next

            dgProductor.Refresh()

          
            cd.Inicializar()
            cd.AgregarParametro("@cotizacion", CInt(dtAnalisis.Rows.Item(0).Item(0)), SqlDbType.Int)
            dsDescripcion = cd.EjecutarQuery("ls_obtieneDetalleCotizacion")

            y = 0
            x = dsDescripcion.Tables(0).Rows.Count
            While y < x




                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell


                Dim a, r As Integer
                Dim mensaje As String
                a = 0
                mensaje = "false"

                r = orden.dgAsignado.Rows.Count

                While a < r
                    Dim codigoAnalisis As String = orden.dgAsignado.Rows.Item(a).Cells.Item(0).Value
                    If codigoAnalisis = Nothing Then
                        Exit While
                    End If
                    cd.Inicializar()
                    cd.AgregarParametro("@codigoAnalisis", CInt(dsDescripcion.Tables(0).Rows.Item(y).Item(0)), SqlDbType.Int)
                    cd.AgregarParametro("@codigoAsignado", CInt(codigoAnalisis), SqlDbType.Int)
                    ds = cd.EjecutarQuery("ls_validaElementosAnalisis")


                    For Each dr As Data.DataRow In ds.Tables(0).Rows 'extraigo el primer campo

                        mensaje = dr("mensaje").ToString

                    Next
                    If mensaje = "true" Then
                        Dim valor As String = MsgBox(" existen elementos repetidos en los análisis, ¿Desea continuar?", MsgBoxStyle.YesNo)
                        If valor = MsgBoxResult.Yes Then
                            Exit While
                        ElseIf valor = MsgBoxResult.No Then
                            Me.Close()
                            Exit Sub
                        End If
                    End If
                    a = a + 1
                End While

                ''aqui llamo a proc para que me traiga la descripcion del analisis enviando solo el codigo
                cd.Inicializar()
                cd.AgregarParametro("@codigoAnalisis", CInt(dsDescripcion.Tables(0).Rows.Item(y).Item(0)), SqlDbType.Int)
                dsAnalisis = cd.EjecutarQuery("ls_DescripcionAnalisis")


                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dsDescripcion.Tables(0).Rows.Item(y).Item(0)
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dsAnalisis.Tables(0).Rows.Item(0).Item(0).ToString
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dsDescripcion.Tables(0).Rows.Item(y).Item(1)
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dsDescripcion.Tables(0).Rows.Item(y).Item(2)
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dsDescripcion.Tables(0).Rows.Item(y).Item(0)
                dgvRow.Cells.Add(dgvCell)

                orden.dgAsignado.Rows.Add(dgvRow)
                y = y + 1

            End While
        ElseIf orden.txRutProductor.Text <> "" Then
            Me.dgProductor.Rows.Clear()



            dsProductor = cn.buscaProductor(orden.txRutProductor.Text, "", "", "")

            For i = 0 To dsProductor.Tables(0).Rows.Count - 1
                dgProductor.Rows.Add(dsProductor.Tables(0).Rows(i).Item(76).ToString, dsProductor.Tables(0).Rows(i).Item(0).ToString, _
                dsProductor.Tables(0).Rows(i).Item(2).ToString, dsProductor.Tables(0).Rows(i).Item(3).ToString, _
               dsProductor.Tables(0).Rows(i).Item(18).ToString, dsProductor.Tables(0).Rows(i).Item(5).ToString, _
               dsProductor.Tables(0).Rows(i).Item(6).ToString, dsProductor.Tables(0).Rows(i).Item(1).ToString, _
               dsProductor.Tables(0).Rows(i).Item(36).ToString)

            Next

            dgProductor.Refresh()

        ElseIf orden.txRutFactura.Text <> "" Then
            Me.dgProductor.Rows.Clear()



            dsProductor = cn.buscaProductorporEmpresa(orden.txRutFactura.Text, "", "", "")

            For i = 0 To dsProductor.Tables(0).Rows.Count - 1
                dgProductor.Rows.Add(dsProductor.Tables(0).Rows(i).Item(76).ToString, dsProductor.Tables(0).Rows(i).Item(0).ToString, _
                dsProductor.Tables(0).Rows(i).Item(2).ToString, dsProductor.Tables(0).Rows(i).Item(3).ToString, _
               dsProductor.Tables(0).Rows(i).Item(18).ToString, dsProductor.Tables(0).Rows(i).Item(5).ToString, _
               dsProductor.Tables(0).Rows(i).Item(6).ToString, dsProductor.Tables(0).Rows(i).Item(1).ToString, _
               dsProductor.Tables(0).Rows(i).Item(36).ToString)

            Next

            dgProductor.Refresh()



        Else
            Me.dgProductor.Rows.Clear()



            'dsProductor = cn.buscaProductor(orden.txRutFactura.Text, "", "", "")

            ' For i = 0 To dsProductor.Tables(0).Rows.Count - 1
            ' dgProductor.Rows.Add(dsProductor.Tables(0).Rows(i).Item(76).ToString, dsProductor.Tables(0).Rows(i).Item(0).ToString, _
            ' dsProductor.Tables(0).Rows(i).Item(2).ToString, dsProductor.Tables(0).Rows(i).Item(3).ToString, _
            'dsProductor.Tables(0).Rows(i).Item(18).ToString, dsProductor.Tables(0).Rows(i).Item(5).ToString, _
            'dsProductor.Tables(0).Rows(i).Item(6).ToString, dsProductor.Tables(0).Rows(i).Item(1).ToString, _
            'dsProductor.Tables(0).Rows(i).Item(36).ToString)

            ' Next

            'dgProductor.Refresh()



        End If


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim cn As New CapaNegocio

        Dim i As Integer
        Me.dgProductor.Rows.Clear()

        dsProductor = cn.buscaProductor(Me.txRut.Text, Me.txNombre.Text, Me.txDireccion.Text, Me.cbCiudad.Text)

        For i = 0 To dsProductor.Tables(0).Rows.Count - 1
            dgProductor.Rows.Add(dsProductor.Tables(0).Rows(i).Item(76).ToString, dsProductor.Tables(0).Rows(i).Item(0).ToString, _
            dsProductor.Tables(0).Rows(i).Item(2).ToString, dsProductor.Tables(0).Rows(i).Item(3).ToString, _
           dsProductor.Tables(0).Rows(i).Item(18).ToString, dsProductor.Tables(0).Rows(i).Item(5).ToString, _
           dsProductor.Tables(0).Rows(i).Item(6).ToString, dsProductor.Tables(0).Rows(i).Item(1).ToString, _
           dsProductor.Tables(0).Rows(i).Item(36).ToString)

        Next

        dgProductor.Refresh()
    End Sub

    Private Sub BuscaFacturasPendientes(ByVal cadena As String)
        Dim F As F_OrdenTrabajo = Me.Owner
        Dim query, MM, TE As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        query = "select OT_ESTADO_ANA, OT_ESTADO_PAG, OT_ESTADO_FAC FROM ORDEN_TRABAJO WHERE OT_FAC_RUT='" & cadena & "'"
        Dim myCommand1 As New SqlCommand(query, con)
        Dim myReader1 As SqlDataReader
        myReader1 = myCommand1.ExecuteReader()
        While myReader1.Read
            Try
                If IsDBNull(myReader1.GetString(0)) = False And IsDBNull(myReader1.GetString(1)) = False And IsDBNull(myReader1.GetString(2)) = False Then
                    If myReader1.GetString(0) = "xDe" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "xF" Then F.btnFacPendiente.Visible = True : Exit While
                    If myReader1.GetString(0) = "xDe" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "Fac" Then F.btnFacPendiente.Visible = True : Exit While
                    If myReader1.GetString(0) = "De" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "xF" Then F.btnFacPendiente.Visible = True : Exit While
                    If myReader1.GetString(0) = "De" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "Fac" Then F.btnFacPendiente.Visible = True : Exit While
                End If
            Catch ex As Exception
            End Try
        End While
        con.Close()
        myReader1.Close()
    End Sub

  

    Private Sub txRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txRut.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnBuscar_Click(sender, e)
        End If

    End Sub


    Private Sub dgProductor_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProductor.CellDoubleClick

        Dim F As F_OrdenTrabajo = Me.Owner

        With F
            .txRutProductor.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(1).ToString
            .cbProductor.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(0).ToString
            .txDireccion.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(4).ToString
            .cbEmpresa.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(2).ToString
            .txPredio.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(3).ToString

            If dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString <> "" Then
                If dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "1" Then
                    .cbRegionN.Text = "I - Tarapaca"
                    .cbRegionN.SelectedValue = 1
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "2" Then
                    .cbRegionN.Text = "II - Antofagasta"
                    .cbRegionN.SelectedValue = 2
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "3" Then
                    .cbRegionN.Text = "III - Atacama"
                    .cbRegionN.SelectedValue = 3
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "4" Then
                    .cbRegionN.Text = "IV - Coquimbo"
                    .cbRegionN.SelectedValue = 4
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "5" Then
                    .cbRegionN.Text = "V - Valparaiso"
                    .cbRegionN.SelectedValue = 5
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "6" Then
                    .cbRegionN.Text = "VI - Gral.B.O`Higgins"
                    .cbRegionN.SelectedValue = 6
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "7" Then
                    .cbRegionN.Text = "VII - Maule"
                    .cbRegionN.SelectedValue = 7
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "8" Then
                    .cbRegionN.Text = "VIII - Biobio"
                    .cbRegionN.SelectedValue = 8
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "9" Then
                    .cbRegionN.Text = "IX - Araucania"
                    .cbRegionN.SelectedValue = 9
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "10" Then
                    .cbRegionN.Text = "X - De los Lagos"
                    .cbRegionN.SelectedValue = 10
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "11" Then
                    .cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)"
                    .cbRegionN.SelectedValue = 11
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "12" Then
                    .cbRegionN.Text = "XII - Magallanes Y Antartica Ch."
                    .cbRegionN.SelectedValue = 12
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "13" Then
                    .cbRegionN.Text = "XIII - Metropolitana"
                    .cbRegionN.SelectedValue = 13
                ElseIf dsProductor.Tables(0).Rows(e.RowIndex).Item(9).ToString = "0" Then
                    .cbRegionN.Text = "Seleccione Region"
                    .cbRegionN.SelectedValue = 0
                End If
            End If

            .cbLocalidad.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(5).ToString
            .cbCiudad.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(7).ToString
            .cbComuna.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(6).ToString
            .cbProvincia.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(8).ToString
            .txFono1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(10).ToString
            .txFono2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(11).ToString
            .txCelular1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(12).ToString
            .txCelular2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(13).ToString
            .txFax1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(14).ToString
            'ot.txFax2.Text = dr.Item(15).ToString
            .txEmail1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(16).ToString
            .txEmail2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(17).ToString
            .txSolicita.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(18).ToString
            .txFonoSolicita1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(19).ToString
            .txFonoSolicita2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(20).ToString
            .txCelularSolicita1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(21).ToString
            .txCelularSolicita2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(22).ToString
            .txFaxSolicita1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(23).ToString
            .txFaxSolicita2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(24).ToString
            .txEmailSolicita1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(25).ToString
            .txEmailSolicita2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(26).ToString
            .txRemite.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(27).ToString
            .txFonoRemite1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(28).ToString
            .txFonoRemite2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(29).ToString
            .txCelularRemite1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(30).ToString
            .txCelularRemite2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(31).ToString
            .txFaxRemite1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(32).ToString
            .txFaxRemite2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(33).ToString
            .txEmailRemite1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(34).ToString
            .txEmail2Re.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(35).ToString
            .txRutFactura.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(36).ToString
            .txRazonSocial.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(37).ToString
            .txFonoRS1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(38).ToString
            .txFonoRS2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(39).ToString
            .txGiro.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(40).ToString
            .txDireccionRS.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(41).ToString
            .cbComunaRS.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(42).ToString
            .cbCiudadRS.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(43).ToString
            .txEncargadoPago.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(44).ToString
            .txFonoPagoRS1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(45).ToString
            .txFonoPagoRS2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(46).ToString
            .txEmailRS1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(48).ToString
            .txEmailRS2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(49).ToString
            If (dsProductor.Tables(0).Rows(e.RowIndex).Item(51).ToString) = 0 Then
                .chRetiraLab.Checked = False
            Else
                .chRetiraLab.Checked = True
            End If

            If (dsProductor.Tables(0).Rows(e.RowIndex).Item(52).ToString) = 0 Then
                .chAvisaFono.Checked = False
            Else
                .chAvisaFono.Checked = True
            End If

            If (dsProductor.Tables(0).Rows(e.RowIndex).Item(53).ToString) = 0 Then
                .chFax.Checked = False
            Else
                .chFax.Checked = True
            End If

            If (dsProductor.Tables(0).Rows(e.RowIndex).Item(54).ToString) = 0 Then
                .chEmail.Checked = False
            Else
                .chEmail.Checked = True
            End If

            If (dsProductor.Tables(0).Rows(e.RowIndex).Item(55).ToString) = 0 Then
                .chCorreo.Checked = False
            Else
                .chCorreo.Checked = True
            End If

            If (dsProductor.Tables(0).Rows(e.RowIndex).Item(56).ToString) = 0 Then
                .chBus.Checked = False
            Else
                .chBus.Checked = True
            End If
            If (dsProductor.Tables(0).Rows(e.RowIndex).Item(57).ToString) = 0 Then
                .chOtro.Checked = False
            Else
                .chOtro.Checked = True
            End If

            .txOtroDespacho.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(58).ToString
            .txSenores.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(59).ToString
            .txAtencion.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(60).ToString
            .txDireccionDespacho.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(61).ToString
            .txCasilla.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(62).ToString
            .cbCiudadDespacho.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(64).ToString
            .cbComunaDespacho.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(63).ToString
            'ot.dtFechaDespacho.Text = dr.Item(66)
            .txFonoDespacho1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(66).ToString
            .txFonoDespacho2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(67).ToString
            .txFaxDespacho1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(70).ToString
            .txFaxDespacho2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(71).ToString
            .txCelularDespacho1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(68).ToString
            .txCelularDespacho2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(69).ToString
            .txEmailDespacho1.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(72).ToString
            .txEmailDespacho2.Text = dsProductor.Tables(0).Rows(e.RowIndex).Item(73).ToString
        End With
        Call BuscaFacturasPendientes(dsProductor.Tables(0).Rows(e.RowIndex).Item(1).ToString)

        Me.Close()
        F.Visible = True
    End Sub
End Class