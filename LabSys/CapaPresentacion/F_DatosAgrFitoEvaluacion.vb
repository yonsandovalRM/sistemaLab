Public Class F_DatosAgrFitoEvaluacion

    Private Sub F_DatosAgrFitoEvaluacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim cd As New CapaDato
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow

        Me.dgDatArgFertOrg.Rows.Clear()
        Me.txPredio.Text = orden.txPredio.Text

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value = 7306 Then




                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)
                    If Me.dgDatArgFertOrg.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatArgFertOrg.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'cuartel 1
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                            dgvRow.Cells.Add(dgvCell)
                            'ensayo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                            dgvRow.Cells.Add(dgvCell)
                            'Localidad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                            dgvRow.Cells.Add(dgvCell)
                            'especie
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'variedad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                            dgvRow.Cells.Add(dgvCell)
                            'predio
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'dplantacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                            dgvRow.Cells.Add(dgvCell)
                            'ntratamiento
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                            dgvRow.Cells.Add(dgvCell)
                            'ano plant
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'naplicacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)
                            'desde
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                            dgvRow.Cells.Add(dgvCell)
                            'hasta
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'f_cosecha
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'fingreso
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                            dgvRow.Cells.Add(dgvCell)
                            'ftermino
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                            dgvRow.Cells.Add(dgvCell)
                            'f guarda
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                            dgvRow.Cells.Add(dgvCell)
                            'n ensayo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(22)
                            dgvRow.Cells.Add(dgvCell)
                            'observacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                            dgvRow.Cells.Add(dgvCell)
                            'cuartel 2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)


                            Me.dgDatArgFertOrg.Rows.Add(dgvRow)
                        End If
                    Else

                        Dim t, s, u As Integer
                        t = Me.dgDatArgFertOrg.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatArgFertOrg.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDatArgFertOrg.Rows.Add(dgvRow)

                            Else
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'cuartel 1
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                                dgvRow.Cells.Add(dgvCell)
                                'ensayo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                                dgvRow.Cells.Add(dgvCell)
                                'Localidad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                                dgvRow.Cells.Add(dgvCell)
                                'especie
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'variedad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                                dgvRow.Cells.Add(dgvCell)
                                'predio
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'dplantacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                                dgvRow.Cells.Add(dgvCell)
                                'ntratamiento
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                                dgvRow.Cells.Add(dgvCell)
                                'ano plant
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'naplicacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)
                                'desde
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                                dgvRow.Cells.Add(dgvCell)
                                'hasta
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'f_cosecha
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'fingreso
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                                dgvRow.Cells.Add(dgvCell)
                                'ftermino
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                                dgvRow.Cells.Add(dgvCell)
                                'f guarda
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                                dgvRow.Cells.Add(dgvCell)
                                'n ensayo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(22)
                                dgvRow.Cells.Add(dgvCell)
                                'observacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                                dgvRow.Cells.Add(dgvCell)
                                'cuartel 2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)


                                Me.dgDatArgFertOrg.Rows.Add(dgvRow)
                            End If

                        End If
                    End If

                    desde = desde + 1

                End While
            End If
            i = i + 1
        End While

        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectFito_NomEnsayo", Cjto_Tablas1, "FITO_NOMENSAYO")

        Me.cbNomEnsayo.Items.Add("")
        For Each Fila_Loc In Cjto_Tablas1.Tables("FITO_NOMENSAYO").Rows
            Me.cbNomEnsayo.Items.Add(Fila_Loc("FITO_NOMENSAYO"))
        Next

        If Me.dgDatArgFertOrg.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatArgFertOrg.Rows.Item(0).Cells.Item(0).Value
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

    Private Sub dgDatArgFertOrg_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgFertOrg.CellClick
        Try

            Me.txNlab.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(0).Value
            'If Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

            Me.txCuartel.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(1).Value
            Me.cbNomEnsayo.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(2).Value
            Me.cbLocalidad.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(3).Value
            Me.cbEspecie.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(4).Value
            Me.cbVariedad.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(5).Value
            Me.txPredio.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(6).Value
            Me.txDisPlantacion.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(7).Value
            Me.txNtratamiento.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(8).Value
            Me.txAnoPlantacion.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(9).Value
            Me.txNAplicaciones.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(10).Value
            Me.txDesde.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(11).Value
            Me.txHasta.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(12).Value
            Me.txFechaCosecha.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(13).Value
            Me.dtInicio.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(14).Value
            Me.dtTermino.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(15).Value
            Me.txFechaGuarda.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(16).Value
            Me.cbMuestreador.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(17).Value
            Me.txNEnsayo.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(18).Value
            Me.txObservacion.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(19).Value

            ' End If

        Catch ex As Exception
        End Try
    End Sub

    'Private Sub dgDatArgTejidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgFertOrg.CellContentClick
    '    Try

    '        Me.txNlab.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

    '            Me.txCuartel.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(1).Value
    '            Me.cbNomEnsayo.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(2).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(3).Value
    '            Me.cbEspecie.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(4).Value
    '            Me.cbVariedad.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(5).Value
    '            Me.txPredio.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(6).Value
    '            Me.txDisPlantacion.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(7).Value
    '            Me.txNtratamiento.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(8).Value
    '            Me.txAnoPlantacion.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(9).Value
    '            Me.txNAplicaciones.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(10).Value
    '            Me.txDesde.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(11).Value
    '            Me.txHasta.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(12).Value
    '            Me.txFechaCosecha.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(13).Value
    '            Me.dtInicio.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(14).Value
    '            Me.dtTermino.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(15).Value
    '            Me.txFechaGuarda.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(16).Value
    '            Me.cbMuestreador.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(17).Value
    '            Me.txNEnsayo.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(18).Value
    '            Me.txObservacion.Text = Me.dgDatArgFertOrg.Rows.Item(e.RowIndex).Cells.Item(19).Value

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

        orden.tbOT.SelectedTab = orden.tbOT.TabPages(4)
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
        r = Me.dgDatArgFertOrg.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(1).Value = Me.txCuartel.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(2).Value = Me.cbNomEnsayo.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(3).Value = Me.cbLocalidad.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(4).Value = Me.cbEspecie.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(5).Value = Me.cbVariedad.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(6).Value = Me.txPredio.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(7).Value = Me.txDisPlantacion.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(8).Value = Me.txNtratamiento.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(9).Value = Me.txAnoPlantacion.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(10).Value = Me.txNAplicaciones.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(11).Value = Me.txDesde.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(12).Value = Me.txHasta.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(13).Value = Me.txFechaCosecha.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(14).Value = Me.dtInicio.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(15).Value = Me.dtTermino.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(16).Value = Me.txFechaGuarda.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(17).Value = Me.cbMuestreador.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(18).Value = Me.txNEnsayo.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(19).Value = Me.txObservacion.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(20).Value = "xA"
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(21).Value = ""

        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLab", CInt(Me.txNlab.Text), SqlDbType.Int)
            .AgregarParametro("@Predio", Me.txPredio.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Esp", cbEspecie.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Var", cbVariedad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Dist", Me.txDisPlantacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel1", Me.txCuartel.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel2", "", SqlDbType.NVarChar)
            .AgregarParametro("@AnoPlanta", Me.txAnoPlantacion.Text, SqlDbType.Int)
            .AgregarParametro("@NumTrata", Me.txNtratamiento.Text, SqlDbType.Int)
            .AgregarParametro("@NumAplica", Me.txNAplicaciones.Text, SqlDbType.Int)
            .AgregarParametro("@DuraDesde", Me.txDesde.Text, SqlDbType.NVarChar)
            .AgregarParametro("@DuraHasta", Me.txHasta.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cosecha", Me.txFechaCosecha.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FechaGuarda", Me.txFechaGuarda.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Loc", cbLocalidad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Ensayo", Me.cbNomEnsayo.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Obs", txObservacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Muestreador", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreo", Me.dtInicio.Text, SqlDbType.DateTime)
            .AgregarParametro("@FTERMINO", Me.dtTermino.Text, SqlDbType.DateTime)
            .AgregarParametro("@NENSAYO", Me.txNEnsayo.Text, SqlDbType.NVarChar)

            .EjecutarEscalar("usp_GrabaAntecedentesFitoEvaluacion")
        End With

        If i + 1 < Me.dgDatArgFertOrg.Rows.Count Then
            Me.txNlab.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(0).Value

            If Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then

                Me.txCuartel.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(1).Value
                Me.cbNomEnsayo.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(2).Value
                Me.cbLocalidad.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(3).Value
                Me.cbEspecie.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(4).Value
                Me.cbVariedad.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(5).Value
                Me.txPredio.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(6).Value
                Me.txDisPlantacion.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(7).Value
                Me.txNtratamiento.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(8).Value
                Me.txAnoPlantacion.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(9).Value
                Me.txNAplicaciones.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(10).Value
                Me.txDesde.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(11).Value
                Me.txHasta.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(12).Value
                Me.txFechaCosecha.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(13).Value
                Me.dtInicio.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(14).Value
                Me.dtTermino.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(15).Value
                Me.txFechaGuarda.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(16).Value
                Me.cbMuestreador.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(17).Value
                Me.txNEnsayo.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(18).Value
                Me.txObservacion.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(19).Value


            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

        Me.cbNomEnsayo.Text = ""
        Me.cbMuestreador.Text = ""
        Me.cbLocalidad.Text = ""
        Me.txPredio.Text = ""
        Me.txNlab.Text = ""
        Me.txObservacion.Text = ""
        Me.txNtratamiento.Text = ""

    End Sub



  
    Private Sub txPredio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPredio.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txPredio.Text
            Call control_nombre(NOMBREX)
            txPredio.Text = NOMBREX
            cbLocalidad.Focus()
        End If
    End Sub



    Private Sub cbLocalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbLocalidad.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbNomEnsayo.Focus()
        End If
    End Sub


    Private Sub cbNomEnsayo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbNomEnsayo.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbEspecie.Focus()
        End If
    End Sub

    Private Sub cbEspecie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbEspecie.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbVariedad.Focus()
        End If
    End Sub

    Private Sub cbVariedad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbVariedad.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.txDisPlantacion.Focus()
        End If
    End Sub

    Private Sub txDisPlantacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txDisPlantacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNtratamiento.Focus()
        End If
    End Sub

    Private Sub txNtratamiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNtratamiento.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txAnoPlantacion.Focus()
        End If
    End Sub

    Private Sub txAnoPlantacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txAnoPlantacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNAplicaciones.Focus()
        End If
    End Sub

    Private Sub txNAplicaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNAplicaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txDesde.Focus()
        End If
    End Sub

    Private Sub txDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txHasta.Focus()
        End If
    End Sub

    Private Sub txHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txHasta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCuartel.Focus()
        End If
    End Sub

    Private Sub txCuartel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCuartel.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txCuartel.Text
            Call control_nombre(NOMBREX)
            txCuartel.Text = NOMBREX
            Me.txObservacion.Focus()
        End If
    End Sub
End Class