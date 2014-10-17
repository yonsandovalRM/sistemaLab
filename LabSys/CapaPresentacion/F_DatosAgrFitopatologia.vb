Public Class F_DatosAgrFitopatologia

    Private Sub F_DatosAgrFitopatologia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim cd As New CapaDato
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow

        Me.txPredio.Text = orden.txPredio.Text

        Me.dgDatArgFitopatologia.Rows.Clear()

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value = 7302 Or 7314 Or 7316 Then

                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)
                    If Me.dgDatArgFitopatologia.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatArgFitopatologia.Rows.Add(dgvRow)

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
                            'predio
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'localidad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'tejido
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                            dgvRow.Cells.Add(dgvCell)
                            'especie
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                            dgvRow.Cells.Add(dgvCell)
                            'variedad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)
                            'edad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'sintomatologia
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                            dgvRow.Cells.Add(dgvCell)
                            'observacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'fmuestreo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'id especie
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                            dgvRow.Cells.Add(dgvCell)
                            'rec colonia
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                            dgvRow.Cells.Add(dgvCell)
                            'id2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)
                            'tipo muestra
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                            dgvRow.Cells.Add(dgvCell)


                            Me.dgDatArgFitopatologia.Rows.Add(dgvRow)
                        End If
                    Else
                        Dim t, s, u As Integer
                        t = Me.dgDatArgFitopatologia.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatArgFitopatologia.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDatArgFitopatologia.Rows.Add(dgvRow)

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
                                'predio
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'localidad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'tejido
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                                dgvRow.Cells.Add(dgvCell)
                                'especie
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                                dgvRow.Cells.Add(dgvCell)
                                'variedad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)
                                'edad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'sintomatologia
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                                dgvRow.Cells.Add(dgvCell)
                                'observacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'fmuestreo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'id especie
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                                dgvRow.Cells.Add(dgvCell)
                                'rec colonia
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                                dgvRow.Cells.Add(dgvCell)
                                'id2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)
                                'tipo muestra
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                                dgvRow.Cells.Add(dgvCell)



                                Me.dgDatArgFitopatologia.Rows.Add(dgvRow)
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

        ' Me.cbtejido.Items.Add("")
        ' For Each Fila_Loc In Cjto_Tablas1.Tables("TIPO_FERTILIZANTE_ORGANICO").Rows
        'Me.cbtejido.Items.Add(Fila_Loc("TIPO_FERTI"))
        ' Next
        Call llenaTejido()
        Call llenaEspecie()
        Call llenaMuestreadores()
        Call llenaLocalidad()

        Me.cbLocalidad.Text = orden.cbLocalidad.Text

        If Me.dgDatArgFitopatologia.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatArgFitopatologia.Rows.Item(0).Cells.Item(0).Value
        End If


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

    Private Sub llenaTejido()

        Dim cn As New CapaNegocio
        Dim dt As New DataTable
        Dim dsTemp As New Data.DataSet
        dsTemp = cn.datosTejido()
        dt = dsTemp.Tables(0)

        Me.cbTejido.DataSource = dt
        Me.cbTejido.DisplayMember = "TEJIDO"
        Me.cbTejido.ValueMember = "TEJIDO"

    End Sub

    Private Sub llenaEspecie()

        Dim cn As New CapaNegocio
        Dim dt As New DataTable
        Dim dsTemp As New Data.DataSet
        dsTemp = cn.datosEspecie()
        dt = dsTemp.Tables(0)

        Me.cbEspecie.DataSource = dt
        Me.cbEspecie.DisplayMember = "ESPECIE"
        Me.cbEspecie.ValueMember = "ESPECIE"

    End Sub

    Private Sub cbEspecie_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEspecie.SelectedIndexChanged

        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable

        If Me.cbEspecie.Text <> "System.Data.DataRowView" Then

            If Me.cbEspecie.Text <> "" Then

                ds = cn.datosVariedad(Me.cbEspecie.Text)

                dt = ds.Tables(0)

                Me.cbVariedad.DataSource = dt
                Me.cbVariedad.DisplayMember = "VARIEDAD"
                Me.cbVariedad.ValueMember = "VARIEDAD"
            End If

        End If
    End Sub

    Private Sub dgDatArgFitopatologia_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgFitopatologia.CellClick
        Try
            Dim idEspecie, rcolonia As String
            Me.txNlab.Text = Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(0).Value
            'If Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then


            Me.txIdentificacion1.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(1).Value
            Me.txPredio.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(2).Value
            Me.cbLocalidad.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(3).Value
            Me.cbtejido.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(4).Value
            Me.cbEspecie.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(5).Value
            Me.cbVariedad.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(6).Value
            Me.txEdad.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(7).Value
            Me.txSintomatologia.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(8).Value
            Me.txObservacion.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(9).Value
            Me.cbMuestreador.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(10).Value
            Me.dtMuestreador.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(11).Value

            idEspecie = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(12).Value
            rcolonia = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(13).Value

            If idEspecie = 0 Then
                Me.rbIdNo.Checked = True
                Me.rbIDSi.Checked = False
            Else
                Me.rbIdNo.Checked = False
                Me.rbIDSi.Checked = True
            End If


            If rcolonia = 0 Then
                Me.rbRCNo.Checked = True
                Me.rbRCSi.Checked = False
            Else
                Me.rbRCNo.Checked = False
                Me.rbRCSi.Checked = True
            End If

            'End If

        Catch ex As Exception
        End Try
    End Sub

    'Private Sub dgDatArgTejidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgFitopatologia.CellContentClick
    '    Try
    '        Dim idEspecie, rcolonia As String
    '        Me.txNlab.Text = Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then


    '            Me.txIdentificacion1.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(1).Value
    '            Me.txPredio.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(2).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(3).Value
    '            Me.cbtejido.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(4).Value
    '            Me.cbEspecie.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(5).Value
    '            Me.cbVariedad.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(6).Value
    '            Me.txEdad.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(7).Value
    '            Me.txSintomatologia.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(8).Value
    '            Me.txObservacion.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(9).Value
    '            Me.cbMuestreador.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(10).Value
    '            Me.dtMuestreador.Text = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(11).Value

    '            idEspecie = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(12).Value
    '            rcolonia = Me.dgDatArgFitopatologia.Rows.Item(e.RowIndex).Cells.Item(13).Value

    '            If idEspecie = 0 Then
    '                Me.rbIdNo.Checked = True
    '                Me.rbIDSi.Checked = False
    '            Else
    '                Me.rbIdNo.Checked = False
    '                Me.rbIDSi.Checked = True
    '            End If


    '            If rcolonia = 0 Then
    '                Me.rbRCNo.Checked = True
    '                Me.rbRCSi.Checked = False
    '            Else
    '                Me.rbRCNo.Checked = False
    '                Me.rbRCSi.Checked = True
    '            End If

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
        r = Me.dgDatArgFitopatologia.Rows.Count
        Dim cd As New CapaDato
        Dim idespecie, rcolonia As String
        i = 0

        While i < r
            nlab = Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

        If Me.rbIdNo.Checked = True Then
            idespecie = "0"
        Else
            idespecie = "1"
        End If

        If Me.rbRCNo.Checked = True Then
            rcolonia = "0"
        Else
            rcolonia = "1"
        End If



        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(1).Value = Me.txIdentificacion1.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(2).Value = Me.txPredio.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(3).Value = Me.cbLocalidad.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(4).Value = Me.cbtejido.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(5).Value = Me.cbEspecie.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(6).Value = Me.cbVariedad.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(7).Value = Me.txEdad.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(8).Value = Me.txSintomatologia.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(9).Value = Me.txObservacion.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(10).Value = Me.cbMuestreador.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(11).Value = Me.dtMuestreador.Text
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(12).Value = idespecie
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(13).Value = rcolonia
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(14).Value = "xA"
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(15).Value = ""
        Me.dgDatArgFitopatologia.Rows.Item(i).Cells.Item(16).Value = "Fito"

        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", CInt(orden.lblNot.Text), SqlDbType.Int)
            .AgregarParametro("@NumLabFitopatologia", CInt(Me.txNlab.Text), SqlDbType.Int)
            .AgregarParametro("@PredioFitopatologia", Me.txPredio.Text, SqlDbType.NVarChar)
            .AgregarParametro("@LocFitopatologia", Me.cbLocalidad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@EspFitopatologia", Me.cbEspecie.Text, SqlDbType.NVarChar)
            .AgregarParametro("@VarFitopatologia", Me.cbVariedad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@TejFitopatologia", Me.cbtejido.Text, SqlDbType.NVarChar)
            .AgregarParametro("@EdadFitopatologia", Me.txEdad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Sintomatologia", Me.txSintomatologia.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion1Fitopatologia", Me.txIdentificacion1.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion2Fitopatologia", "", SqlDbType.NVarChar)
            .AgregarParametro("@ObsFitopatologia", Me.txObservacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@MuestreadorFitopatologia", Me.cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreoFitopatologia", Me.dtMuestreador.Text, SqlDbType.DateTime)
            .AgregarParametro("@HMuestreoFitopatologia", "", SqlDbType.NVarChar)
            .AgregarParametro("@IDEspecie", idespecie, SqlDbType.NVarChar)
            .AgregarParametro("@RColonia", rcolonia, SqlDbType.NVarChar)
            .EjecutarEscalar("ls_GrabaAntecedentesFitopatologicos")
        End With

        If i + 1 < Me.dgDatArgFitopatologia.Rows.Count Then
            Me.txNlab.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(0).Value

            If Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then

                'Me.txNlab.Text = Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(0).Value
                'If Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFitopatologia.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then


                Me.txIdentificacion1.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(1).Value
                Me.txPredio.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(2).Value
                Me.cbLocalidad.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(3).Value
                Me.cbtejido.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(4).Value
                Me.cbEspecie.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(5).Value
                Me.cbVariedad.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(6).Value
                Me.txEdad.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(7).Value
                Me.txSintomatologia.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(8).Value
                Me.txObservacion.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(9).Value
                Me.cbMuestreador.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(10).Value
                Me.dtMuestreador.Text = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(11).Value

                idEspecie = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(12).Value
                rcolonia = Me.dgDatArgFitopatologia.Rows.Item(i + 1).Cells.Item(13).Value

                If idEspecie = 0 Then
                    Me.rbIdNo.Checked = True
                    Me.rbIDSi.Checked = False
                Else
                    Me.rbIdNo.Checked = False
                    Me.rbIDSi.Checked = True
                End If


                If rcolonia = 0 Then
                    Me.rbRCNo.Checked = True
                    Me.rbRCSi.Checked = False
                Else
                    Me.rbRCNo.Checked = False
                    Me.rbRCSi.Checked = True
                End If

            End If
        End If


    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txPredio.Text = ""
        Me.cbtejido.Text = ""
        Me.cbMuestreador.Text = ""
        Me.cbLocalidad.Text = ""
        Me.cbEspecie.Text = ""
        Me.txNlab.Text = ""
        Me.cbVariedad.Text = ""
        Me.txObservacion.Text = ""
        Me.txMuestras.Text = ""
        Me.txIdentificacion1.Text = ""
        ''Me.txIdentificacion2.Text = ""
        Me.txEdad.Text = ""
        Me.txSintomatologia.Text = ""
        ''Me.txHoraMuestreo.Text = ""

        Me.rbIdNo.Checked = False
        Me.rbIDSi.Checked = False
        Me.rbRCNo.Checked = False
        Me.rbRCSi.Checked = False

    End Sub


    Private Sub txPredio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPredio.KeyPress
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
            Me.cbtejido.Focus()
        End If
    End Sub

    Private Sub cbtejido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbtejido.KeyDown
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
            Me.txEdad.Focus()
        End If
    End Sub

    Private Sub txEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEdad.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txSintomatologia.Focus()
        End If
    End Sub
  
    Private Sub txSintomatologia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txSintomatologia.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txIdentificacion1.Focus()
        End If
    End Sub


    Private Sub txIdentificacion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIdentificacion1.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txIdentificacion1.Text
            Call control_nombre(NOMBREX)
            txIdentificacion1.Text = NOMBREX
            Me.txObservacion.Focus()
        End If

       
    End Sub

    Private Sub cbVariedad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbVariedad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = cbVariedad.Text
            Call control_nombre(NOMBREX)
            cbVariedad.Text = NOMBREX
            'cbLocalidad.Focus()
        End If
    End Sub

    Private Sub cbtejido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbtejido.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = cbtejido.Text
            Call control_nombre(NOMBREX)
            cbtejido.Text = NOMBREX
            'cbLocalidad.Focus()
        End If
    End Sub

    Private Sub cbLocalidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbLocalidad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = cbLocalidad.Text
            Call control_nombre(NOMBREX)
            cbLocalidad.Text = NOMBREX
            'cbLocalidad.Focus()
        End If
    End Sub

    Private Sub cbEspecie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbEspecie.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = cbEspecie.Text
            Call control_nombre(NOMBREX)
            cbEspecie.Text = NOMBREX
            'cbLocalidad.Focus()
        End If
    End Sub
End Class