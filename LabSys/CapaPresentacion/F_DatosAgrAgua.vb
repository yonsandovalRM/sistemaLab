Public Class F_DatosAgrAgua

    Private Sub F_DatosAgrAgua_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow

        Me.dgDArgonomicoAgua.Rows.Clear()

        Me.txPredio.Text = orden.txPredio.Text

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value > 3000 And orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value < 4000 Then

                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)

                    If Me.dgDArgonomicoAgua.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDArgonomicoAgua.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'id
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                            dgvRow.Cells.Add(dgvCell)
                            'id2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                            dgvRow.Cells.Add(dgvCell)
                            'predio
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                            dgvRow.Cells.Add(dgvCell)
                            'localidad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                            dgvRow.Cells.Add(dgvCell)
                            'fmuestreo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'hmuestreo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                            dgvRow.Cells.Add(dgvCell)
                            'origen 
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)
                            'ord desc
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'carga actual
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                            dgvRow.Cells.Add(dgvCell)
                            'ca desc
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)
                            'tipo recip
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                            dgvRow.Cells.Add(dgvCell)
                            'det
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'vol
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'esta
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                            dgvRow.Cells.Add(dgvCell)
                            'pres
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                            dgvRow.Cells.Add(dgvCell)
                            'fing
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                            dgvRow.Cells.Add(dgvCell)
                            'hing
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                            dgvRow.Cells.Add(dgvCell)
                            'observ
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(20)
                            dgvRow.Cells.Add(dgvCell)
                            'reg
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(22)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                            dgvRow.Cells.Add(dgvCell)

                            Me.dgDArgonomicoAgua.Rows.Add(dgvRow)
                        End If
                    Else

                        Dim t, s, u As Integer
                        t = Me.dgDArgonomicoAgua.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDArgonomicoAgua.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDArgonomicoAgua.Rows.Add(dgvRow)

                            Else
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'id
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                                dgvRow.Cells.Add(dgvCell)
                                'id2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                                dgvRow.Cells.Add(dgvCell)
                                'predio
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                                dgvRow.Cells.Add(dgvCell)
                                'localidad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                                dgvRow.Cells.Add(dgvCell)
                                'fmuestreo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'hmuestreo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                                dgvRow.Cells.Add(dgvCell)
                                'origen 
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)
                                'ord desc
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'carga actual
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                                dgvRow.Cells.Add(dgvCell)
                                'ca desc
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)
                                'tipo recip
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                                dgvRow.Cells.Add(dgvCell)
                                'det
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'vol
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'esta
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                                dgvRow.Cells.Add(dgvCell)
                                'pres
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                                dgvRow.Cells.Add(dgvCell)
                                'fing
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                                dgvRow.Cells.Add(dgvCell)
                                'hing
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                                dgvRow.Cells.Add(dgvCell)
                                'observ
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(20)
                                dgvRow.Cells.Add(dgvCell)
                                'reg
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(22)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                                dgvRow.Cells.Add(dgvCell)

                                Me.dgDArgonomicoAgua.Rows.Add(dgvRow)

                            End If
                        End If
                    End If

                    desde = desde + 1

                End While
            End If
            i = i + 1
        End While


        Dim cd As New CapaDato
        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectRecipiente", Cjto_Tablas1, "RECIPIENTE")


        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectPreservantes", Cjto_Tablas1, "PRESERVANTES")

        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectEstado", Cjto_Tablas1, "ESTADO")

        Me.cbPreservante.Items.Add("")
        For Each Fila_Loc In Cjto_Tablas1.Tables("PRESERVANTES").Rows
            Me.cbPreservante.Items.Add(Fila_Loc("PRESERVANTES"))
        Next

        Me.cbTipoRecipiente.Items.Add("")
        For Each Fila_Loc In Cjto_Tablas1.Tables("RECIPIENTE").Rows
            Me.cbTipoRecipiente.Items.Add(Fila_Loc("RECIPIENTE"))
        Next

        Me.cbEstado.Items.Add("")
        For Each Fila_Loc In Cjto_Tablas1.Tables("ESTADO").Rows
            Me.cbEstado.Items.Add(Fila_Loc("ESTADO"))
        Next

        If Me.dgDArgonomicoAgua.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDArgonomicoAgua.Rows.Item(0).Cells.Item(0).Value
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

    Private Sub dgDArgonomicoAgua_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDArgonomicoAgua.CellClick
        Try
            Me.txNlab.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(0).Value
            Me.txIdentificacion1.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(1).Value
            Me.txIdentificacion2.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(2).Value
            Me.txPredio.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(3).Value
            Me.cbLocalidad.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(4).Value
            Me.dtFechaMuestreo.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(5).Value
            Me.txHoraMuestreo.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(6).Value

            'origen
            If (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Rio") Then
                Me.rbORio.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Can") Then
                Me.rbOCanal.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Poz") Then
                Me.rbOPozo.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Pot") Then
                Me.rbOPotable.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "s/a") Then
                Me.rbOSa.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Otro") Then
                Me.rbOOtro.Checked = True
            End If
            'origen otro
            Me.txOOtro.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(8).Value
            Me.cbMuestreador.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(9).Value

            'carga actual
            If (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "puntual") Then
                Me.rbCAPuntual.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "compuesta") Then
                Me.rbCACompuesta.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "s/a") Then
                Me.rbCASa.Checked = True
            ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "Otro") Then
                Me.rbCAOtro.Checked = True
            End If

            'canal actual otro
            Me.txCAOtro.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(11).Value

            Me.cbTipoRecipiente.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(12).Value
            Me.txDetalle.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(13).Value
            Me.txVolumen.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(14).Value
            Me.cbEstado.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(15).Value
            Me.cbPreservante.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(16).Value
            Me.dtFechaIngreso.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(17).Value
            Me.txHoraIngreso.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(18).Value
            Me.txObservacion.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(19).Value

        Catch ex As Exception
        End Try

    End Sub

    'Private Sub dgDArgonomicoAgua_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDArgonomicoAgua.CellContentClick

    '    Try
    '        Me.txNlab.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(0).Value
    '        Me.txIdentificacion1.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(1).Value
    '        Me.txIdentificacion2.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(2).Value
    '        Me.txPredio.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(3).Value
    '        Me.cbLocalidad.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(4).Value
    '        Me.dtFechaMuestreo.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(5).Value
    '        Me.txHoraMuestreo.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(6).Value

    '        'origen
    '        If (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Rio") Then
    '            Me.rbORio.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Can") Then
    '            Me.rbOCanal.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Poz") Then
    '            Me.rbOPozo.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Pot") Then
    '            Me.rbOPotable.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "s/a") Then
    '            Me.rbOSa.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(7).Value = "Otro") Then
    '            Me.rbOOtro.Checked = True
    '        End If
    '        'origen otro
    '        Me.txOOtro.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(8).Value
    '        Me.cbMuestreador.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(9).Value

    '        'carga actual
    '        If (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "puntual") Then
    '            Me.rbCAPuntual.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "compuesta") Then
    '            Me.rbCACompuesta.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "s/a") Then
    '            Me.rbCASa.Checked = True
    '        ElseIf (Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(10).Value = "Otro") Then
    '            Me.rbCAOtro.Checked = True
    '        End If

    '        'canal actual otro
    '        Me.txCAOtro.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(11).Value

    '        Me.cbTipoRecipiente.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(12).Value
    '        Me.txDetalle.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(13).Value
    '        Me.txVolumen.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(14).Value
    '        Me.cbEstado.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(15).Value
    '        Me.cbPreservante.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(16).Value
    '        Me.dtFechaIngreso.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(17).Value
    '        Me.txHoraIngreso.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(18).Value
    '        Me.txObservacion.Text = Me.dgDArgonomicoAgua.Rows(e.RowIndex).Cells.Item(19).Value

    '    Catch ex As Exception
    '    End Try

    'End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If Trim(Me.txNlab.Text) = "" Then
            MsgBox("Debe seleccionar un Numero de Laboratorio antes de asignarle valores.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim i, r, j, nlab As Integer
        Dim origen, carga As String
        Dim cn As New CapaNegocio
        Dim orden As F_OrdenTrabajo = Me.Owner
        r = Me.dgDArgonomicoAgua.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDArgonomicoAgua.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

        origen = ""
        carga = ""


        Me.dgDArgonomicoAgua.Rows.Item(i).Cells.Item(1).Value = Me.txIdentificacion1.Text
        Me.dgDArgonomicoAgua.Rows.Item(i).Cells.Item(2).Value = Me.txIdentificacion2.Text
        Me.dgDArgonomicoAgua.Rows.Item(i).Cells.Item(3).Value = Me.txPredio.Text
        Me.dgDArgonomicoAgua.Rows.Item(i).Cells.Item(4).Value = Me.cbLocalidad.Text
        Me.dgDArgonomicoAgua.Rows.Item(i).Cells.Item(5).Value = Me.dtFechaMuestreo.Text
        Me.dgDArgonomicoAgua.Rows.Item(i).Cells.Item(6).Value = Me.txHoraMuestreo.Text


        'origen
        If Me.rbORio.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(7).Value = "Rio"
            origen = "Rio"
        ElseIf Me.rbOCanal.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(7).Value = "Can"
            origen = "Can"
        ElseIf Me.rbOPozo.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(7).Value = "Poz"
            origen = "Poz"
        ElseIf Me.rbOPotable.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(7).Value = "Pot"
            origen = "Pot"
        ElseIf Me.rbOSa.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(7).Value = "s/a"
            origen = "s/a"
        ElseIf Me.rbOOtro.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(7).Value = "Otro"
            origen = "Otro"
        End If

        'origen otro
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(8).Value = Me.txOOtro.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(9).Value = Me.cbMuestreador.Text


        'carga actual
        If Me.rbCAPuntual.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(10).Value = "puntual"
            carga = "puntual"
        ElseIf Me.rbCACompuesta.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(10).Value = "compuesta"
            carga = "compuesta"
        ElseIf Me.rbCASa.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(10).Value = "s/a"
            carga = "s/a"
        ElseIf Me.rbCAOtro.Checked = True Then
            Me.dgDArgonomicoAgua.Rows(i).Cells.Item(10).Value = "Otro"
            carga = "Otro"
        End If

        'canal actual otro
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(11).Value = Me.txCAOtro.Text


        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(12).Value = Me.cbTipoRecipiente.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(13).Value = Me.txDetalle.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(14).Value = Me.txVolumen.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(15).Value = Me.cbEstado.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(16).Value = Me.cbPreservante.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(17).Value = Me.dtFechaIngreso.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(18).Value = Me.txHoraIngreso.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(19).Value = Me.txObservacion.Text
        Me.dgDArgonomicoAgua.Rows(i).Cells.Item(20).Value = ""
   
        Dim cd As New CapaDato

        With cd

            .Inicializar()
            .AgregarParametro("@NumOt", Orden_Trabajo, SqlDbType.Int)
            .AgregarParametro("@NumLab", CInt(Me.txNlab.Text), SqlDbType.Int)
            .AgregarParametro("@Muestreador", Me.cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FechaMuestreo", Me.dtFechaMuestreo.Text, SqlDbType.DateTime)
            If Me.txHoraMuestreo.Text = "" Then Me.txHoraMuestreo.Text = "00:00"
            .AgregarParametro("@HoraMuestreo", Me.txHoraMuestreo.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Predio", Me.txPredio.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Localidad", Me.cbLocalidad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion1", Me.txIdentificacion1.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion2", Me.txIdentificacion2.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Origen", origen, SqlDbType.NVarChar)
            .AgregarParametro("@OrigenDescr", Me.txOOtro.Text, SqlDbType.NVarChar)
            .AgregarParametro("@TipoMuestreo", carga, SqlDbType.NVarChar)
            .AgregarParametro("@OrigenMDescr", Me.txCAOtro.Text, SqlDbType.NVarChar)
            .AgregarParametro("@TipoRecip", Me.cbTipoRecipiente.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Detalle", Me.txDetalle.Text, SqlDbType.NVarChar)
            .AgregarParametro("@VolumenMu", Me.txVolumen.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Estado", Me.cbEstado.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Preservantes", Me.cbPreservante.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FechaIngreso", CDate(Me.dtFechaIngreso.Text), SqlDbType.DateTime)
            If txHoraIngreso.Text = "" Then Me.txHoraIngreso.Text = "00:00"
            .AgregarParametro("@HoraIngreso", txHoraIngreso.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Observaciones", txObservacion.Text, SqlDbType.NVarChar)
            .EjecutarEscalar("ls_GrabaAntecedentesAgua")

        End With

        If i + 1 < Me.dgDArgonomicoAgua.Rows.Count Then
            Me.txNlab.Text = Me.dgDArgonomicoAgua.Rows.Item(i + 1).Cells.Item(0).Value

            If Me.dgDArgonomicoAgua.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then

                'Me.txNlab.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(0).Value
                Me.txIdentificacion1.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(1).Value
                Me.txIdentificacion2.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(2).Value
                Me.txPredio.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(3).Value
                Me.cbLocalidad.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(4).Value
                Me.dtFechaMuestreo.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(5).Value
                Me.txHoraMuestreo.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(6).Value

                'origen
                If (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(7).Value = "Rio") Then
                    Me.rbORio.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(7).Value = "Can") Then
                    Me.rbOCanal.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(7).Value = "Poz") Then
                    Me.rbOPozo.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(7).Value = "Pot") Then
                    Me.rbOPotable.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(7).Value = "s/a") Then
                    Me.rbOSa.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(7).Value = "Otro") Then
                    Me.rbOOtro.Checked = True
                End If
                'origen otro
                Me.txOOtro.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(8).Value
                Me.cbMuestreador.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(9).Value

                'carga actual
                If (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(10).Value = "puntual") Then
                    Me.rbCAPuntual.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(10).Value = "compuesta") Then
                    Me.rbCACompuesta.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(10).Value = "s/a") Then
                    Me.rbCASa.Checked = True
                ElseIf (Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(10).Value = "Otro") Then
                    Me.rbCAOtro.Checked = True
                End If

                'canal actual otro
                Me.txCAOtro.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(11).Value

                Me.cbTipoRecipiente.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(12).Value
                Me.txDetalle.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(13).Value
                Me.txVolumen.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(14).Value
                Me.cbEstado.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(15).Value
                Me.cbPreservante.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(16).Value
                Me.dtFechaIngreso.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(17).Value
                Me.txHoraIngreso.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(18).Value
                Me.txObservacion.Text = Me.dgDArgonomicoAgua.Rows(i + 1).Cells.Item(19).Value
            End If

        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim orden As F_OrdenTrabajo = Me.Owner
        'Dim ds As New DataSet
        'Dim a, b, i, j, k, sumaValores As Integer
        'a = 0
        'i = 0
        'j = 0
        'k = 0
        'sumaValores = 0
        'a = orden.dgDetalle.Rows.Count
        'b = orden.dgRecibo.Rows.Count



        'While i < a

        '    While k < b

        '        If orden.dgDetalle.Rows.Item(i).Cells.Item(0).Value = orden.dgRecibo.Rows.Item(k).Cells.Item(0).Value Then
        '            MsgBox("Se han guardado los datos Argonómicos " & vbCr & _
        '            "El análisis N°: " & orden.dgRecibo.Rows.Item(k).Cells.Item(0).Value & ",Ya estaba asignado, por lo que no se volverá a agregar. ", MsgBoxStyle.Information)
        '            orden.tbOT.SelectTab("tbRecibo")
        '            Me.Close()
        '            Exit Sub
        '        End If
        '        k = k + 1
        '    End While
        '    k = 0

        '    Dim dgvRow As New DataGridViewRow
        '    Dim dgvCell As DataGridViewCell

        '    'codigo
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(0).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    'muestra
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(1).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    'descripcion
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(2).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    'lab-desde
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(3).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    'lab-hasta
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(4).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    'cantidad
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(5).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    'valor
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(6).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    sumaValores = sumaValores + (orden.dgDetalle.Rows.Item(i).Cells.Item(5).Value() * orden.dgDetalle.Rows.Item(i).Cells.Item(6).Value())

        '    'neto
        '    dgvCell = New DataGridViewTextBoxCell()
        '    dgvCell.Value = orden.dgDetalle.Rows.Item(i).Cells.Item(7).Value()
        '    dgvRow.Cells.Add(dgvCell)

        '    orden.dgRecibo.Rows.Add(dgvRow)

        '    i = i + 1

        'End While

        'Dim t, l, subtotal As Integer
        'l = 0
        'subtotal = 0
        't = orden.dgRecibo.Rows.Count



        'While l < t
        '    subtotal = subtotal + CInt(orden.dgRecibo.Rows.Item(l).Cells.Item(7).Value)
        '    l = l + 1
        'End While

        'orden.txSubTotalRe.Text = subtotal
        'orden.txNetoRe.Text = subtotal + CInt(orden.txMuestreoRe.Text) - CInt(orden.txPorcentajeDescuentoTotalRe.Text)
        'orden.txIvaRe.Text = CInt(orden.txNetoRe.Text) * 0.19

        'Dim f, g As Decimal
        'f = orden.txNetoRe.Text
        'g = orden.txIvaRe.Text
        'orden.txTotalRe.Text = f + g

        Dim i, j As Integer

        j = orden.dgDatosAgronomicos.Rows.Count

        While i < j
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(1).Value.ToString = "Agua" Then
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Style.BackColor = System.Drawing.Color.Blue
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Value = "C/DA"
            End If
            i = i + 1
        End While
        orden.tbOT.SelectedTab = orden.tbOT.TabPages(3)
        Me.Close()
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
            Me.txIdentificacion1.Focus()
        End If
    End Sub

    Private Sub txIdentificacion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIdentificacion1.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txIdentificacion1.Text
            Call control_nombre(NOMBREX)
            Me.txIdentificacion1.Text = NOMBREX
            Me.txIdentificacion2.Focus()
        End If
    End Sub

    Private Sub txIdentificacion2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIdentificacion2.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txIdentificacion2.Text
            Call control_nombre(NOMBREX)
            Me.txIdentificacion2.Text = NOMBREX
            Me.txObservacion.Focus()
        End If
    End Sub

    Private Sub txObservacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txObservacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtFechaMuestreo.Focus()
        End If
    End Sub

    Private Sub txHoraMuestreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txHoraMuestreo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbTipoRecipiente.Focus()
        End If
    End Sub

    Private Sub cbTipoRecipiente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTipoRecipiente.KeyDown
        If e.KeyData = Keys.Enter Then

            Me.txDetalle.Focus()

        End If
    End Sub

  

    Private Sub txDetalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txDetalle.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtFechaIngreso.Focus()
        End If
    End Sub

    Private Sub txHoraIngreso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txHoraIngreso.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txVolumen.Focus()
        End If
    End Sub

    Private Sub txVolumen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txVolumen.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbEstado.Focus()
        End If
    End Sub

    Private Sub cbEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbEstado.KeyDown
        If e.KeyData = Keys.Enter Then

            Me.cbPreservante.Focus()

        End If
    End Sub

  
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As DataGridViewRow
        Dim vaOrigen As String
        Dim etiqueta As New Etiquetas.Etiqueta
        For Each fila In Me.dgDArgonomicoAgua.Rows
            If fila.Cells(7).Value.ToString = "Pot" Then
                vaOrigen = "Potable"
            ElseIf fila.Cells(7).Value.ToString = "Can" Then
                vaOrigen = "Canal"
            ElseIf fila.Cells(7).Value.ToString = "Poz" Then
                vaOrigen = "Pozo"
            ElseIf fila.Cells(7).Value.ToString = "Rio" Then
                vaOrigen = "Rio"
            ElseIf fila.Cells(7).Value.ToString = "Otro" Then
                vaOrigen = fila.Cells(8).Value.ToString
            End If
            etiqueta.Imprimir_Etiqueta1("192.168.0.69", "443", "Agrolab " & Today, "", "N: " & fila.Cells(0).Value.ToString, "Origen: " & vaOrigen) '"Origen: " & vaOrigen, fila.Cells(7).Value.ToString, , fila.Cells(0).Value.ToString)
            'MsgBox("NLab: " & fila.Cells(0).Value.ToString & " Tejido: " & fila.Cells(5).Value.ToString, MsgBoxStyle.Information, "Imprimiendo Etiquetas")
        Next

    End Sub
End Class