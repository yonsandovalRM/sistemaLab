Public Class F_DatosAgrFitoMonitoreo

    Private Sub F_DatosAgrFitoMonitoreo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       

        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim cd As New CapaDato
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow

        Me.dgDatArgMonitoreo.Rows.Clear()
        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value = 7308 Then


                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)

                    If Me.dgDatArgMonitoreo.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatArgMonitoreo.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'id 1
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                            dgvRow.Cells.Add(dgvCell)
                            'loc
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                            dgvRow.Cells.Add(dgvCell)
                            'nlineas
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'ncamaras
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'ntuneles
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                            dgvRow.Cells.Add(dgvCell)
                            'especie procesada
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'n p1
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'np2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                            dgvRow.Cells.Add(dgvCell)
                            'np3
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                            dgvRow.Cells.Add(dgvCell)
                            'naguas
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                            dgvRow.Cells.Add(dgvCell)
                            'nd dactilares
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                            dgvRow.Cells.Add(dgvCell)
                            'observacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                            dgvRow.Cells.Add(dgvCell)
                            'f. muestreo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'f.ingreso
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)
                            'identificiacion2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                            dgvRow.Cells.Add(dgvCell)



                            Me.dgDatArgMonitoreo.Rows.Add(dgvRow)
                        End If
                    Else
                        Dim t, s, u As Integer
                        t = Me.dgDatArgMonitoreo.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatArgMonitoreo.Rows.Item(s).Cells.Item(0).Value = desde Then
                                u = 1
                            End If
                            s = s + 1
                        End While

                        If u = 0 Then

                            If dsArg.Tables(0).Rows.Count = 0 Then

                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = desde
                                dgvRow.Cells.Add(dgvCell)
                                Me.dgDatArgMonitoreo.Rows.Add(dgvRow)

                            Else
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'id 1
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                                dgvRow.Cells.Add(dgvCell)
                                'loc
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                                dgvRow.Cells.Add(dgvCell)
                                'nlineas
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'ncamaras
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'ntuneles
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                                dgvRow.Cells.Add(dgvCell)
                                'especie procesada
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'n p1
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'np2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                                dgvRow.Cells.Add(dgvCell)
                                'np3
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                                dgvRow.Cells.Add(dgvCell)
                                'naguas
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                                dgvRow.Cells.Add(dgvCell)
                                'nd dactilares
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                                dgvRow.Cells.Add(dgvCell)
                                'observacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                                dgvRow.Cells.Add(dgvCell)
                                'f. muestreo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'f.ingreso
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)
                                'identificiacion2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                                dgvRow.Cells.Add(dgvCell)



                                Me.dgDatArgMonitoreo.Rows.Add(dgvRow)
                            End If

                        End If
                    End If

                    desde = desde + 1

                End While

            End If
            i = i + 1
        End While

        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectTipoFertilizanteOrganico", Cjto_Tablas1, "TIPO_FERTILIZANTE_ORGANICO")

        If Me.dgDatArgMonitoreo.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatArgMonitoreo.Rows.Item(0).Cells.Item(0).Value
        End If

        Call llenaMuestreadores()
        Call llenaLocalidad()
        Me.cbLocalidad.Text = orden.cbLocalidad.Text

    End Sub

    Private Sub llenaMuestreadores()

        Dim cn As New CapaNegocio
        Dim dt As New DataTable
        Dim dsTemp As New Data.DataSet
        dsTemp = cn.datosMuestreadores()
        dt = dsTemp.Tables(0)

        Me.cbMuestreador.DataSource = dt
        Me.cbMuestreador.DisplayMember = "MUE_NOMBRE"
        Me.cbMuestreador.ValueMember = "MUE_NOMBRE"

    End Sub

    Private Sub llenaLocalidad()

        Dim cn As New CapaNegocio
        Dim dt As New DataTable
        Dim dsTemp As New Data.DataSet
        dsTemp = cn.datosLocalidad(3)
        dt = dsTemp.Tables(0)

        Me.cbLocalidad.DataSource = dt
        Me.cbLocalidad.DisplayMember = "LOCALIDAD"
        Me.cbLocalidad.ValueMember = "LOCALIDAD"

    End Sub

    Private Sub dgDatArgMonitoreo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgMonitoreo.CellClick
        Try

            Me.txNlab.Text = Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(0).Value
            'If Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

            Me.txIdentificacion1.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(1).Value
            Me.cbLocalidad.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(2).Value
            Me.txNLineas.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(3).Value
            Me.txNCamaras.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(4).Value
            Me.txNtuneles.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(5).Value
            Me.txEspProcesada.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(6).Value
            Me.txNplacas1.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(7).Value
            Me.txNplacas2.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(8).Value
            Me.txNplacas3.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(9).Value

            Me.txNaguas.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(10).Value
            Me.txNMDactilares.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(11).Value
            Me.txObservacion.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(12).Value
            Me.dtMuestreador.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(13).Value
            Me.cbMuestreador.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(14).Value
            Me.dtIngreso.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(15).Value

            'End If

        Catch ex As Exception
        End Try
    End Sub

    'Private Sub dgDatArgTejidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgMonitoreo.CellContentClick
    '    Try

    '        Me.txNlab.Text = Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgMonitoreo.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

    '            Me.txIdentificacion1.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(1).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(2).Value
    '            Me.txNLineas.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(3).Value
    '            Me.txNCamaras.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(4).Value
    '            Me.txNtuneles.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(5).Value
    '            Me.txEspProcesada.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(6).Value
    '            Me.txNplacas1.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(7).Value
    '            Me.txNplacas2.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(8).Value
    '            Me.txNplacas3.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(9).Value

    '            Me.txNaguas.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(10).Value
    '            Me.txNMDactilares.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(11).Value
    '            Me.txObservacion.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(12).Value
    '            Me.dtMuestreador.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(13).Value
    '            Me.cbMuestreador.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(14).Value
    '            Me.dtIngreso.Text = Me.dgDatArgMonitoreo.Rows.Item(e.RowIndex).Cells.Item(15).Value

    '        End If

    '    Catch ex As Exception
    '    End Try

    'End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim ds As New DataSet
        Dim a, b, i, j, k, sumaValores As Integer
        a = 0
        i = 0
        j = 0
        k = 0
        sumaValores = 0
        a = orden.dgDetalle.Rows.Count
        b = orden.dgRecibo.Rows.Count

        Dim h, p As Integer

        p = orden.dgDatosAgronomicos.Rows.Count

        While h < p
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(1).Value.ToString = "Monitoreo" Then
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Style.BackColor = System.Drawing.Color.Blue
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Value = "C/DA"
            End If
            h = h + 1
        End While


        While i < a

            While k < b

                If orden.dgDetalle.Rows.Item(i).Cells.Item(0).Value = orden.dgRecibo.Rows.Item(k).Cells.Item(0).Value Then
                    MsgBox("Se han guardado los datos Argonómicos " & vbCr & _
                    "El análisis N°: " & orden.dgRecibo.Rows.Item(k).Cells.Item(0).Value & ",Ya estaba asignado, por lo que no se volverá a agregar. ", MsgBoxStyle.Information)
                    orden.tbOT.SelectedTab = orden.tbOT.TabPages(3)
                    Me.Close()
                    Exit Sub
                End If
                k = k + 1
            End While
            k = 0

            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            'codigo
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(0).Value()
            dgvRow.Cells.Add(dgvCell)

            'muestra
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(1).Value()
            dgvRow.Cells.Add(dgvCell)

            'descripcion
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(2).Value()
            dgvRow.Cells.Add(dgvCell)

            'lab-desde
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(3).Value()
            dgvRow.Cells.Add(dgvCell)

            'lab-hasta
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(4).Value()
            dgvRow.Cells.Add(dgvCell)

            'cantidad
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(5).Value()
            dgvRow.Cells.Add(dgvCell)

            'valor
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(6).Value()
            dgvRow.Cells.Add(dgvCell)

            sumaValores = sumaValores + (orden.dgDetalle.Rows.Item(i).Cells.Item(5).Value() * orden.dgDetalle.Rows.Item(i).Cells.Item(6).Value())

            'neto
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(7).Value()
            dgvRow.Cells.Add(dgvCell)

            orden.dgRecibo.Rows.Add(dgvRow)

            i = i + 1

        End While

        Dim t, l, subtotal As Integer
        l = 0
        subtotal = 0
        t = orden.dgRecibo.Rows.Count

        While l < t
            subtotal = CInt(subtotal) + CInt(orden.dgRecibo.Rows.Item(l).Cells.Item(7).Value)
            l = l + 1
        End While

        orden.txSubTotalRe.Text = subtotal
        orden.txNetoRe.Text = subtotal + CInt(orden.txMuestreoRe.Text) - CInt(orden.txPorcentajeDescuentoTotalRe.Text)
        orden.txIvaRe.Text = CInt(orden.txNetoRe.Text) * 0.19

        Dim f, g As Decimal
        f = orden.txNetoRe.Text
        g = orden.txIvaRe.Text
        orden.txTotalRe.Text = f + g
        If Tipo_Ingreso_OT = "Consulta" Then
            orden.tbOT.SelectedTab = orden.tbOT.TabPages(3)


        End If

        Me.Close()

    End Sub

    Private Sub btnAceptarOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarOK.Click

        If Trim(Me.txNlab.Text) = "" Then
            MsgBox("Debe seleccionar un Numero de Laboratorio antes de asignarle valores.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim i, r, j, nlab As Integer
        Dim cn As New CapaNegocio
        Dim orden As F_OrdenTrabajo = Me.Owner
        r = Me.dgDatArgMonitoreo.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(1).Value = Me.txIdentificacion1.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(2).Value = Me.cbLocalidad.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(3).Value = Me.txNLineas.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(4).Value = Me.txNCamaras.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(5).Value = Me.txNtuneles.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(6).Value = Me.txEspProcesada.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(7).Value = Me.txNplacas1.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(8).Value = Me.txNplacas2.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(9).Value = Me.txNplacas3.Text

        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(10).Value = Me.txNaguas.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(11).Value = Me.txNMDactilares.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(12).Value = Me.txObservacion.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(13).Value = Me.dtMuestreador.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(14).Value = Me.cbMuestreador.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(15).Value = Me.dtIngreso.Text
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(16).Value = "xA"
        Me.dgDatArgMonitoreo.Rows.Item(i).Cells.Item(17).Value = ""


        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLab", CInt(Me.txNlab.Text), SqlDbType.Int)
            .AgregarParametro("@NumLineas", CInt(Me.txNLineas.Text), SqlDbType.Int)
            .AgregarParametro("@NumCamaras", CInt(Me.txNCamaras.Text), SqlDbType.Int)
            .AgregarParametro("@Identificacion1", Me.txIdentificacion1.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Obs", Me.txObservacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Muestreador", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreo", Me.dtMuestreador.Text, SqlDbType.DateTime)
            .AgregarParametro("@FIngreso", Me.dtIngreso.Text, SqlDbType.DateTime)
            .AgregarParametro("@NTuneles", CInt(Me.txNtuneles.Text), SqlDbType.Int)
            .AgregarParametro("@ESPProcesada", Me.txEspProcesada.Text, SqlDbType.NVarChar)
            .AgregarParametro("@NPlacas1", CInt(Me.txNplacas1.Text), SqlDbType.Int)
            .AgregarParametro("@NPlacas2", CInt(Me.txNplacas2.Text), SqlDbType.Int)
            .AgregarParametro("@NPlacas3", CInt(Me.txNplacas3.Text), SqlDbType.Int)
            .AgregarParametro("@NAguas", CInt(Me.txNaguas.Text), SqlDbType.Int)
            .AgregarParametro("@NDactilares", CInt(Me.txNMDactilares.Text), SqlDbType.Int)
            .AgregarParametro("@Localidad", Me.cbLocalidad.Text, SqlDbType.NVarChar)

            .EjecutarEscalar("usp_GrabaAntecedentesFitoMonitoreo")
        End With

        If i + 1 < Me.dgDatArgMonitoreo.Rows.Count Then
            Me.txNlab.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(0).Value
            If Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then

                Me.txIdentificacion1.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(1).Value
                Me.cbLocalidad.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(2).Value
                Me.txNLineas.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(3).Value
                Me.txNCamaras.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(4).Value
                Me.txNtuneles.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(5).Value
                Me.txEspProcesada.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(6).Value
                Me.txNplacas1.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(7).Value
                Me.txNplacas2.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(8).Value
                Me.txNplacas3.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(9).Value

                Me.txNaguas.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(10).Value
                Me.txNMDactilares.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(11).Value
                Me.txObservacion.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(12).Value
                Me.dtMuestreador.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(13).Value
                Me.cbMuestreador.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(14).Value
                Me.dtIngreso.Text = Me.dgDatArgMonitoreo.Rows.Item(i + 1).Cells.Item(15).Value
            End If

        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click


        Me.cbMuestreador.Text = ""
        Me.cbLocalidad.Text = ""
        Me.txNLineas.Text = ""
        Me.txNlab.Text = ""
        Me.txObservacion.Text = ""

        Me.txIdentificacion1.Text = ""

    End Sub

    Private Sub txNLineas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNLineas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNCamaras.Focus()
        End If
    End Sub

    Private Sub txNCamaras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNCamaras.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNtuneles.Focus()
        End If
    End Sub

    Private Sub txNtuneles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNtuneles.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEspProcesada.Focus()
        End If
    End Sub

    Private Sub txEspProcesada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEspProcesada.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNplacas1.Focus()
        End If
    End Sub

    Private Sub txNplacas1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNplacas1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNplacas2.Focus()
        End If
    End Sub

    Private Sub txNplacas2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNplacas2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNplacas3.Focus()
        End If
    End Sub

    Private Sub txNplacas3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNplacas3.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNaguas.Focus()
        End If
    End Sub

    Private Sub txNaguas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNaguas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNMDactilares.Focus()
        End If
    End Sub

    Private Sub txNMDactilares_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNMDactilares.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbLocalidad.Focus()
        End If
    End Sub


    Private Sub cbLocalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbLocalidad.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.txIdentificacion1.Focus()
        End If
    End Sub

    Private Sub txIdentificacion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIdentificacion1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txObservacion.Focus()
        End If
    End Sub
End Class