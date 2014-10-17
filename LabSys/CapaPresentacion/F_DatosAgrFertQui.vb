Public Class F_DatosAgrFertQui


    Private Sub F_DatosAgrFoliares_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim cd As New CapaDato
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow

        Me.dgDatArgFertQui.Rows.Clear()
        Me.txPredio.Text = orden.cbLocalidad.Text

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value > 5000 And orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value < 6000 Then


                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)

                    If Me.dgDatArgFertQui.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatArgFertQui.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'id 1
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                            dgvRow.Cells.Add(dgvCell)
                            'id 2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)
                            'predio
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                            dgvRow.Cells.Add(dgvCell)
                            'localidad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                            dgvRow.Cells.Add(dgvCell)
                            'tipo mues
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'mues
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'fmuest
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'obser
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)


                            Me.dgDatArgFertQui.Rows.Add(dgvRow)
                        End If
                    Else

                        Dim t, s, u As Integer
                        t = Me.dgDatArgFertQui.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatArgFertQui.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDatArgFertQui.Rows.Add(dgvRow)

                            Else
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'id 1
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                                dgvRow.Cells.Add(dgvCell)
                                'id 2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)
                                'predio
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                                dgvRow.Cells.Add(dgvCell)
                                'localidad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                                dgvRow.Cells.Add(dgvCell)
                                'tipo mues
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'mues
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'fmuest
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'obser
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)


                                Me.dgDatArgFertQui.Rows.Add(dgvRow)
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

        ' Me.cbTeipoFert.Items.Add("")
        'For Each Fila_Loc In Cjto_Tablas1.Tables("TIPO_FERTILIZANTE_ORGANICO").Rows
        ' Me.cbTeipoFert.Items.Add(Fila_Loc("TIPO_FERTI"))
        'Next

        If Me.dgDatArgFertQui.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatArgFertQui.Rows.Item(0).Cells.Item(0).Value
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

    Private Sub dgDatArgFertQui_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgFertQui.CellClick
        Try

            Me.txNlab.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(0).Value
            ' If Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

            Me.txIdentificacion1.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(1).Value
            Me.txIdentificacion2.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(2).Value
            Me.txPredio.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(3).Value
            Me.cbMuestreador.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(6).Value
            Me.dtMuestreador.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(7).Value
            Me.cbLocalidad.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(4).Value
            Me.cbTeipoFert.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(5).Value
            Me.txObservacion.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(8).Value

            ' End If

        Catch ex As Exception
        End Try
    End Sub

    'Private Sub dgDatArgTejidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgFertQui.CellContentClick
    '    Try

    '        Me.txNlab.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

    '            Me.txIdentificacion1.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(1).Value
    '            Me.txIdentificacion2.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(2).Value
    '            Me.txPredio.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(3).Value
    '            Me.cbMuestreador.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(6).Value
    '            Me.dtMuestreador.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(7).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(4).Value
    '            Me.cbTeipoFert.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(5).Value
    '            Me.txObservacion.Text = Me.dgDatArgFertQui.Rows(e.RowIndex).Cells.Item(8).Value

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
                    orden.tbOT.SelectedTab = orden.tbOT.TabPages(4)
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
        r = Me.dgDatArgFertQui.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(1).Value = Me.txIdentificacion1.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(2).Value = Me.txIdentificacion2.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(3).Value = Me.txPredio.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(6).Value = Me.cbMuestreador.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(7).Value = Me.dtMuestreador.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(4).Value = Me.cbLocalidad.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(5).Value = Me.cbTeipoFert.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(8).Value = Me.txObservacion.Text
        Me.dgDatArgFertQui.Rows.Item(i).Cells.Item(9).Value = "xA"


        cn.GrabaAntecedentesFertQui(orden.lblNot.Text, Me.txNlab.Text, Me.txPredio.Text, Me.cbLocalidad.Text, _
               Me.txObservacion.Text, Me.cbMuestreador.Text, Me.dtMuestreador.Text, Me.txIdentificacion1.Text, _
               Me.txIdentificacion2.Text, Me.cbTeipoFert.Text)

        If i + 1 < Me.dgDatArgFertQui.Rows.Count Then
            Me.txNlab.Text = Me.dgDatArgFertQui.Rows.Item(i + 1).Cells.Item(0).Value

            If Me.dgDatArgFertQui.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then
                Me.txIdentificacion1.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(1).Value
                Me.txIdentificacion2.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(2).Value
                Me.txPredio.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(3).Value
                Me.cbMuestreador.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(6).Value
                Me.dtMuestreador.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(7).Value
                Me.cbLocalidad.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(4).Value
                Me.cbTeipoFert.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(5).Value
                Me.txObservacion.Text = Me.dgDatArgFertQui.Rows(i + 1).Cells.Item(8).Value
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

        Me.cbTeipoFert.Text = ""
        Me.cbMuestreador.Text = ""
        Me.cbLocalidad.Text = ""
        Me.txPredio.Text = ""
        Me.txNlab.Text = ""
        Me.txObservacion.Text = ""
        Me.txMuestras.Text = ""
        Me.txIdentificacion2.Text = ""
        Me.txIdentificacion1.Text = ""

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
            Me.cbTeipoFert.Focus()
        End If
    End Sub

    Private Sub cbTeipoFert_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTeipoFert.KeyDown
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As DataGridViewRow
        Dim etiqueta As New Etiquetas.Etiqueta
        For Each fila In Me.dgDatArgFertQui.Rows
            etiqueta.Imprimir_Etiqueta1("192.168.0.69", "443", "Tipo Fert: " & fila.Cells(5).Value.ToString, "", "N: " & fila.Cells(0).Value.ToString, "Agrolab " & Today)
        Next

    End Sub
End Class