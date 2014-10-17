Public Class F_DatosAgrBioForest

    Private Sub F_DatosAgrBioForest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''TODO: esta línea de código carga datos en la tabla 'LabsysDataSet8.TEJIDO' Puede moverla o quitarla según sea necesario.
        'Me.TEJIDOTableAdapter.Fill(Me.LabsysDataSet8.TEJIDO)
        ''TODO: esta línea de código carga datos en la tabla 'LabsysDataSet8.ESPECIE' Puede moverla o quitarla según sea necesario.
        'Me.ESPECIETableAdapter1.Fill(Me.LabsysDataSet8.ESPECIE)
        ''TODO: esta línea de código carga datos en la tabla 'LabsysDataSet7.LOCALIDAD' Puede moverla o quitarla según sea necesario.
        'Me.LOCALIDADTableAdapter.Fill(Me.LabsysDataSet7.LOCALIDAD)
        ''TODO: esta línea de código carga datos en la tabla 'LabsysDataSet6.ESPECIE' Puede moverla o quitarla según sea necesario.
        'Me.ESPECIETableAdapter.Fill(Me.LabsysDataSet6.ESPECIE)
        ''TODO: esta línea de código carga datos en la tabla 'LabsysDataSet3.MUESTREADORES' Puede moverla o quitarla según sea necesario.
        'Me.MUESTREADORESTableAdapter.Fill(Me.LabsysDataSet3.MUESTREADORES)

        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim cd As New CapaDato
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow

        Me.dgDatArgFertOrg.Rows.Clear()

        i = 0
        r = orden.dgDetalle.Rows.Count

        While i < r

            nlabDesde = orden.dgDetalle.Rows.Item(i).Cells.Item(3).Value
            nlabHasta = orden.dgDetalle.Rows.Item(i).Cells.Item(4).Value

            Dim desde As Integer = nlabDesde

            While desde <= nlabHasta

                dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)
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
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(0)
                    dgvRow.Cells.Add(dgvCell)
                    'cuartel 1
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                    dgvRow.Cells.Add(dgvCell)
                    'cuartel 2
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                    dgvRow.Cells.Add(dgvCell)
                    'tejido
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                    dgvRow.Cells.Add(dgvCell)
                    'especie
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                    dgvRow.Cells.Add(dgvCell)
                    'variedad
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                    dgvRow.Cells.Add(dgvCell)
                    'edad
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                    dgvRow.Cells.Add(dgvCell)
                    'rto
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                    dgvRow.Cells.Add(dgvCell)
                    'car
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                    dgvRow.Cells.Add(dgvCell)
                    'vig
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                    dgvRow.Cells.Add(dgvCell)
                    'dens
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                    dgvRow.Cells.Add(dgvCell)
                    'apariencia
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                    dgvRow.Cells.Add(dgvCell)
                    'f1
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                    dgvRow.Cells.Add(dgvCell)
                    'f2
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                    dgvRow.Cells.Add(dgvCell)
                    'observaciones
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                    dgvRow.Cells.Add(dgvCell)
                    'muestreador
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                    dgvRow.Cells.Add(dgvCell)
                    'fecha
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                    dgvRow.Cells.Add(dgvCell)
                    'predio
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                    dgvRow.Cells.Add(dgvCell)
                    'localidad
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                    dgvRow.Cells.Add(dgvCell)
                    ''estado
                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                    'dgvRow.Cells.Add(dgvCell)


                    Me.dgDatArgFertOrg.Rows.Add(dgvRow)
                End If
                desde = desde + 1

            End While
            i = i + 1
        End While

        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectTipoFertilizanteOrganico", Cjto_Tablas1, "TIPO_FERTILIZANTE_ORGANICO")

        Me.cbTeipoFert.Items.Add("")
        For Each Fila_Loc In Cjto_Tablas1.Tables("TIPO_FERTILIZANTE_ORGANICO").Rows
            Me.cbTeipoFert.Items.Add(Fila_Loc("TIPO_FERTI"))
        Next

        If Me.dgDatArgFertOrg.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatArgFertOrg.Rows.Item(0).Cells.Item(0).Value()
        End If

        Call llenaMuestreadores()
        Call llenaLocalidad()

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

            Me.cbMuestreador.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(1).Value
            Me.dtMuestreador.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(2).Value
            Me.txPredio.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(3).Value
            Me.cbLocalidad.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(4).Value
            Me.txIdentificacion1.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(5).Value
            Me.txIdentificacion2.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(6).Value
            Me.cbTeipoFert.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(7).Value
            Me.txObservacion.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(8).Value

            ' End If

        Catch ex As Exception
        End Try
    End Sub


    'Private Sub dgDatArgTejidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgFertOrg.CellContentClick
    '    Try

    '        Me.txNlab.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

    '            Me.cbMuestreador.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(1).Value
    '            Me.dtMuestreador.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(2).Value
    '            Me.txPredio.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(3).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(4).Value
    '            Me.txIdentificacion1.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(5).Value
    '            Me.txIdentificacion2.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(6).Value
    '            Me.cbTeipoFert.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(7).Value
    '            Me.txObservacion.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(8).Value

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

        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(1).Value = Me.cbMuestreador.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(2).Value = Me.dtMuestreador.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(3).Value = Me.txPredio.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(4).Value = Me.cbLocalidad.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(5).Value = Me.txIdentificacion1.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(6).Value = Me.txIdentificacion2.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(7).Value = Me.cbTeipoFert.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(8).Value = Me.txObservacion.Text
        Me.dgDatArgFertOrg.Rows.Item(i).Cells.Item(9).Value = "xA"

        cn.GrabaAntecedentesFertOrg(orden.lblNot.Text, Me.txNlab.Text, Me.txPredio.Text, Me.cbLocalidad.Text, _
               Me.txObservacion.Text, Me.cbMuestreador.Text, Me.dtMuestreador.Text, Me.txIdentificacion1.Text, _
               Me.txIdentificacion2.Text, Me.cbTeipoFert.Text)

        If i + 1 < Me.dgDatArgFertOrg.Rows.Count Then
            Me.txNlab.Text = Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(0).Value
            If Me.dgDatArgFertOrg.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then
                'Me.txNlab.Text = Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(0).Value
                'If Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(3).Value.ToString <> "" And Me.dgDatArgFertOrg.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

                Me.cbMuestreador.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(1).Value
                Me.dtMuestreador.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(2).Value
                Me.txPredio.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(3).Value
                Me.cbLocalidad.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(4).Value
                Me.txIdentificacion1.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(5).Value
                Me.txIdentificacion2.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(6).Value
                Me.cbTeipoFert.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(7).Value
                Me.txObservacion.Text = Me.dgDatArgFertOrg.Rows(i + 1).Cells.Item(8).Value

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


    Private Sub txIdentificacion1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIdentificacion1.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txIdentificacion1.Text
            Call control_nombre(NOMBREX)
            Me.txIdentificacion1.Text = NOMBREX
            Me.txIdentificacion2.Focus()
        End If
    End Sub

    Private Sub txIdentificacion2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txIdentificacion2.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txIdentificacion2.Text
            Call control_nombre(NOMBREX)
            Me.txIdentificacion2.Text = NOMBREX
            Me.txObservacion.Focus()
        End If
    End Sub
End Class