Public Class F_DatosAgrFitoRes

    Private Sub F_DatosAgrFoliares_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim cd As New CapaDato
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow


        Me.dgDatFitoResistencia.Rows.Clear()

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value = 7304 Then

                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)

                    If Me.dgDatFitoResistencia.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatFitoResistencia.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'id 1
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                            dgvRow.Cells.Add(dgvCell)
                            'n producto
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'n micro
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                            dgvRow.Cells.Add(dgvCell)
                            'n concent
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'especie
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'p guarda
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'ing activo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                            dgvRow.Cells.Add(dgvCell)
                            'f ingreso
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                            dgvRow.Cells.Add(dgvCell)
                            'observacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'id 2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)




                            Me.dgDatFitoResistencia.Rows.Add(dgvRow)
                        End If
                    Else
                        Dim t, s, u As Integer
                        t = Me.dgDatFitoResistencia.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatFitoResistencia.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDatFitoResistencia.Rows.Add(dgvRow)

                            Else

                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'id 1
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                                dgvRow.Cells.Add(dgvCell)
                                'n producto
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'n micro
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                                dgvRow.Cells.Add(dgvCell)
                                'n concent
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'especie
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'p guarda
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'ing activo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                                dgvRow.Cells.Add(dgvCell)
                                'f ingreso
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                                dgvRow.Cells.Add(dgvCell)
                                'observacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'id 2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)



                                Me.dgDatFitoResistencia.Rows.Add(dgvRow)
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

        Me.cbEspecie.Items.Add("")
        For Each Fila_Loc In Cjto_Tablas1.Tables("TIPO_FERTILIZANTE_ORGANICO").Rows
            Me.cbEspecie.Items.Add(Fila_Loc("TIPO_FERTI"))
        Next


        If Me.dgDatFitoResistencia.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatFitoResistencia.Rows.Item(0).Cells.Item(0).Value
        End If

        Call llenaMuestreadores()
        Call llenaMicro()
        Call llenaEspecie()


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

    Private Sub llenaMicro()

        Dim cn As New CapaNegocio
        Dim dt As New DataTable
        Dim dsTemp As New Data.DataSet
        dsTemp = cn.datosMicro()
        dt = dsTemp.Tables(0)

        Me.cbMicroorganismo.DataSource = dt
        Me.cbMicroorganismo.DisplayMember = "Descripcion"
        Me.cbMicroorganismo.ValueMember = "Descripcion"

    End Sub

    Private Sub llenaEspecie()

        Dim cn As New CapaNegocio
        Dim dt As New DataTable
        Dim dsTemp As New Data.DataSet
        dsTemp = cn.datosFitoEspecie()
        dt = dsTemp.Tables(0)

        Me.cbEspecie.DataSource = dt
        Me.cbEspecie.DisplayMember = "descripcion"
        Me.cbEspecie.ValueMember = "descripcion"

    End Sub

    Private Sub dgDatFitoResistencia_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatFitoResistencia.CellClick
        Try

            Me.txNlab.Text = Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(0).Value
            'If Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

            Me.txIdentificacion1.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(1).Value
            Me.txNproducto.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(2).Value
            Me.txNMicroorganismos.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(3).Value
            Me.txNconcentraciones.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(4).Value
            Me.cbMicroorganismo.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(5).Value
            Me.cbEspecie.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(6).Value
            Me.txPGuarda.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(7).Value
            Me.txIngActivo.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(8).Value
            Me.dtFingreso.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(9).Value
            Me.cbMuestreador.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(10).Value
            Me.txObservacion.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(11).Value

            'End If

        Catch ex As Exception
        End Try
    End Sub

   

    'Private Sub dgDatArgTejidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatFitoResistencia.CellContentClick
    '    Try

    '        Me.txNlab.Text = Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatFitoResistencia.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

    '            Me.txIdentificacion1.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(1).Value
    '            Me.txNproducto.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(2).Value
    '            Me.txNMicroorganismos.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(3).Value
    '            Me.txNconcentraciones.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(4).Value
    '            Me.cbMicroorganismo.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(5).Value
    '            Me.cbEspecie.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(6).Value
    '            Me.txPGuarda.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(7).Value
    '            Me.txIngActivo.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(8).Value
    '            Me.dtFingreso.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(9).Value
    '            Me.cbMuestreador.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(10).Value
    '            Me.txObservacion.Text = Me.dgDatFitoResistencia.Rows.Item(e.RowIndex).Cells.Item(11).Value

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
        r = Me.dgDatFitoResistencia.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(1).Value = Me.txIdentificacion1.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(2).Value = Me.txNproducto.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(3).Value = Me.txNMicroorganismos.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(4).Value = Me.txNconcentraciones.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(5).Value = Me.cbMicroorganismo.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(6).Value = Me.cbEspecie.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(7).Value = Me.txPGuarda.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(8).Value = Me.txIngActivo.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(9).Value = Me.dtFingreso.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(10).Value = Me.cbMuestreador.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(11).Value = Me.txObservacion.Text
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(12).Value = "xA"
        Me.dgDatFitoResistencia.Rows.Item(i).Cells.Item(13).Value = ""

        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLab", CInt(Me.txNlab.Text), SqlDbType.Int)
            .AgregarParametro("@NumProducto", CInt(Me.txNproducto.Text), SqlDbType.Int)
            .AgregarParametro("@NumConcentracion", CInt(Me.txNconcentraciones.Text), SqlDbType.Int)
            .AgregarParametro("@NumMicro", CInt(Me.txNMicroorganismos.Text), SqlDbType.Int)
            .AgregarParametro("@Identificacion1", Me.txIdentificacion1.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Obs", Me.txObservacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Muestreador", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreo", Me.dtFingreso.Text, SqlDbType.DateTime)
            .AgregarParametro("@Micro", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Especie", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@PGuarda", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@IngActivo", cbMuestreador.Text, SqlDbType.NVarChar)

            .EjecutarEscalar("usp_GrabaAntecedentesFitoResistencia")
        End With

        If i + 1 < Me.dgDatFitoResistencia.Rows.Count Then
            Me.txNlab.Text = Me.dgDatFitoResistencia.Rows.Item(i + 1).Cells.Item(0).Value
        End If


    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

        Me.cbEspecie.Text = ""
        Me.cbMuestreador.Text = ""
        Me.cbMicroorganismo.Text = ""
        Me.txNproducto.Text = ""
        Me.txNlab.Text = ""
        Me.txObservacion.Text = ""
        Me.txMuestras.Text = ""
        '   Me.txIdentificacion2.Text = ""
        Me.txIdentificacion1.Text = ""

    End Sub

    Private Sub txNproducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNproducto.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNconcentraciones.Focus()
        End If
    End Sub


  
    Private Sub txNconcentraciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNconcentraciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNMicroorganismos.Focus()
        End If
    End Sub



    Private Sub txNMicroorganismos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNMicroorganismos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txPGuarda.Focus()
        End If
    End Sub

    Private Sub txPGuarda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPGuarda.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbMicroorganismo.Focus()
        End If
    End Sub


    Private Sub cbMicroorganismo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMicroorganismo.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbEspecie.Focus()
        End If
    End Sub

    Private Sub cbEspecie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbEspecie.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.txIngActivo.Focus()
        End If
    End Sub


    Private Sub txIngActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIngActivo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txIdentificacion1.Focus()
        End If
    End Sub

    Private Sub txIdentificacion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIdentificacion1.KeyPress

        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txIdentificacion1.Text
            Call control_nombre(NOMBREX)
            Me.txIdentificacion1.Text = NOMBREX
            Me.txObservacion.Focus()
        End If
    End Sub
End Class