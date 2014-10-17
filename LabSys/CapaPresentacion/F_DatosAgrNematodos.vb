Public Class F_DatosAgrNematodos

    Private Sub F_DatosAgrNematodos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner

        Me.txPredio.Text = orden.txPredio.Text



        Me.dgDatArgNematodos.Rows.Clear()

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value = 8758 Then

                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)

                    If Me.dgDatArgNematodos.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatArgNematodos.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'cuartel 1
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'cuartel 2
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                            dgvRow.Cells.Add(dgvCell)
                            'predio
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'localidad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                            dgvRow.Cells.Add(dgvCell)
                            'prod anterior
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'prod Actual
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                            dgvRow.Cells.Add(dgvCell)
                            'tipo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'especie
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                            dgvRow.Cells.Add(dgvCell)
                            'variedad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                            dgvRow.Cells.Add(dgvCell)
                            'edad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)
                            'vigor
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'cultivo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                            dgvRow.Cells.Add(dgvCell)
                            'observacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                            dgvRow.Cells.Add(dgvCell)
                            'f. muestreo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                            dgvRow.Cells.Add(dgvCell)

                            Me.dgDatArgNematodos.Rows.Add(dgvRow)
                        End If
                    Else

                        Dim t, s, u As Integer
                        t = Me.dgDatArgNematodos.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatArgNematodos.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDatArgNematodos.Rows.Add(dgvRow)

                            Else
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'cuartel 1
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'cuartel 2
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(4)
                                dgvRow.Cells.Add(dgvCell)
                                'predio
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'localidad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                                dgvRow.Cells.Add(dgvCell)
                                'prod anterior
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'prod Actual
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                                dgvRow.Cells.Add(dgvCell)
                                'tipo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'especie
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(5)
                                dgvRow.Cells.Add(dgvCell)
                                'variedad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
                                dgvRow.Cells.Add(dgvCell)
                                'edad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)
                                'vigor
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'cultivo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                                dgvRow.Cells.Add(dgvCell)
                                'observacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                                dgvRow.Cells.Add(dgvCell)
                                'f. muestreo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                                dgvRow.Cells.Add(dgvCell)


                                Me.dgDatArgNematodos.Rows.Add(dgvRow)
                            End If

                        End If
                    End If

                    desde = desde + 1

                End While

            End If
            i = i + 1
        End While

        If Me.dgDatArgNematodos.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatArgNematodos.Rows.Item(0).Cells.Item(0).Value
        End If


        Call llenaEspecie()

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
            Me.txTipo.Focus()
        End If
    End Sub

    Private Sub txTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txTipo.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txTipo.Text
            Call control_nombre(NOMBREX)
            txTipo.Text = NOMBREX
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
            Me.txPAnterior.Focus()
        End If
    End Sub

    Private Sub txCuartel1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCuartel1.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txCuartel1.Text
            Call control_nombre(NOMBREX)
            txCuartel1.Text = NOMBREX
            Me.txCuartel2.Focus()
        End If
 
    End Sub

    Private Sub txCuartel2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCuartel2.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txCuartel2.Text
            Call control_nombre(NOMBREX)
            txCuartel2.Text = NOMBREX
            Me.txObservacion.Focus()
        End If
    
    End Sub

    Private Sub txCultivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCultivo.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txCultivo.Text
            Call control_nombre(NOMBREX)
            txCultivo.Text = NOMBREX
            Me.txCuartel1.Focus()
        End If
    End Sub

    Private Sub txPAnterior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPAnterior.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txPAnterior.Text
            Call control_nombre(NOMBREX)
            txPAnterior.Text = NOMBREX
            Me.txPActual.Focus()
        End If
    End Sub


    Private Sub txPActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPActual.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = txPActual.Text
            Call control_nombre(NOMBREX)
            txPActual.Text = NOMBREX
            Me.txCultivo.Focus()
        End If
    End Sub

    Private Sub btnAceptarOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarOK.Click
        If Trim(Me.txNlab.Text) = "" Then
            MsgBox("Debe seleccionar un Numero de Laboratorio antes de asignarle valores.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim i, r, j, nlab As Integer
        Dim rto, car, vig, den, apa As String
        Dim cn As New CapaNegocio
        Dim orden As F_OrdenTrabajo = Me.Owner
        r = Me.dgDatArgNematodos.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

       
        vig = ""
        

        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(1).Value = Me.txCuartel1.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(2).Value = Me.txCuartel2.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(3).Value = Me.txPredio.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(4).Value = Me.cbLocalidad.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(5).Value = Me.txPAnterior.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(6).Value = Me.txPActual.Text

        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(7).Value = Me.txTipo.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(8).Value = Me.cbEspecie.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(9).Value = Me.cbVariedad.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(10).Value = Me.txEdad.Text

        If Me.rbVigBajo.Checked = True Then
            Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(11).Value = "Bajo"
            vig = "Bajo"
        ElseIf Me.rbVigNorma.Checked = True Then
            Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(11).Value = "Norma"
            vig = "Norma"
        ElseIf Me.rbVigNormal.Checked = True Then
            Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(11).Value = "Normal"
            vig = "Normal"
        ElseIf Me.rbVigNormal2.Checked = True Then
            Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(11).Value = "+Normal"
            vig = "+Normal"
        ElseIf Me.rbVigAlto.Checked = True Then
            Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(11).Value = "Alto"
            vig = "Alto"
        ElseIf Me.rbVigSA.Checked = True Then
            Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(11).Value = "s/a"
            vig = "s/a"
        End If

        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(12).Value = Me.txCultivo.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(13).Value = Me.txObservacion.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(14).Value = Me.cbMuestreador.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(15).Value = Me.dtMuestreador.Text
        Me.dgDatArgNematodos.Rows.Item(i).Cells.Item(16).Value = "xA"

     

        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", orden.lblNot.Text, SqlDbType.Int)
            .AgregarParametro("@NumLabNematodos", CInt(Me.txNlab.Text), SqlDbType.Int)
            .AgregarParametro("@PredioNematodos", txPredio.Text, SqlDbType.NVarChar)
            .AgregarParametro("@LocNematodos", cbLocalidad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@EspNematodos", cbEspecie.Text, SqlDbType.NVarChar)
            .AgregarParametro("@VarNematodos", cbVariedad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@TipNematodos", Me.txTipo.Text, SqlDbType.NVarChar)
            .AgregarParametro("@EdadNematodos", txEdad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@ProdAntNematodos", Me.txPAnterior.Text, SqlDbType.NVarChar)
            .AgregarParametro("@ProdActNematodos", Me.txPActual.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel1Nematodos", txCuartel1.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel2Nematodos", txCuartel2.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cultivo", Me.txCultivo.Text, SqlDbType.NVarChar)
            .AgregarParametro("@strVigor", vig, SqlDbType.NVarChar)
            .AgregarParametro("@ObsNematodos", txObservacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@MuestreadorNematodos", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreoNematodos", Me.dtMuestreador.Text, SqlDbType.DateTime)

            .EjecutarEscalar("usp_GrabaAntecedentesNematodos")
        End With

        If i + 1 < Me.dgDatArgNematodos.Rows.Count Then
            Me.txNlab.Text = Me.dgDatArgNematodos.Rows.Item(i + 1).Cells.Item(0).Value

            If Me.dgDatArgNematodos.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then
                Me.txCuartel1.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(1).Value
                Me.txCuartel2.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(2).Value
                Me.txPredio.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(3).Value
                Me.cbLocalidad.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(4).Value
                Me.txPAnterior.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(5).Value
                Me.txPActual.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(6).Value
                Me.txTipo.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(7).Value

                Me.cbEspecie.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(8).Value
                Me.cbVariedad.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(9).Value
                Me.txEdad.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(10).Value


                'vig
                If (Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(11).Value = "s/a") Then
                    Me.rbVigSA.Checked = True
                ElseIf (Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(11).Value = "Bajo") Then
                    Me.rbVigBajo.Checked = True
                ElseIf (Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(11).Value = "Norma") Then
                    Me.rbVigNorma.Checked = True
                ElseIf (Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(11).Value = "Normal") Then
                    Me.rbVigNormal.Checked = True
                ElseIf (Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(11).Value = "+Normal") Then
                    Me.rbVigNormal2.Checked = True
                ElseIf (Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(11).Value = "Alto") Then
                    Me.rbVigAlto.Checked = True
                End If


                Me.txCultivo.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(12).Value
                Me.txObservacion.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(13).Value
                Me.cbMuestreador.Text = Me.dgDatArgNematodos.Rows(i + 1).Cells.Item(14).Value
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.cbVariedad.Text = ""
        Me.txTipo.Text = ""
        Me.txCultivo.Text = ""
        Me.cbMuestreador.Text = ""
        Me.cbLocalidad.Text = ""
        Me.cbEspecie.Text = ""
        Me.txPredio.Text = ""
        Me.txNlab.Text = ""
        Me.txObservacion.Text = ""
        Me.txMuestras.Text = ""
        Me.txEdad.Text = ""
        Me.txCuartel2.Text = ""
        Me.txCuartel1.Text = ""
        Me.txPActual.Text = ""
        Me.txPAnterior.Text = ""
        Me.rbVigAlto.Checked = False
        Me.rbVigBajo.Checked = False
        Me.rbVigNorma.Checked = False
        Me.rbVigNormal.Checked = False
        Me.rbVigNormal2.Checked = False
        Me.rbVigSA.Checked = False

    End Sub

    Private Sub dgDatArgNematodos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgNematodos.CellClick
        Try

            Me.txNlab.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(0).Value()
            ' If Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" Then

            Me.txCuartel1.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(1).Value
            Me.txCuartel2.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(2).Value
            Me.txPredio.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(3).Value
            Me.cbLocalidad.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(4).Value
            Me.txPAnterior.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(5).Value
            Me.txPActual.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(6).Value
            Me.txTipo.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(7).Value

            Me.cbEspecie.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(8).Value
            Me.cbVariedad.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(9).Value
            Me.txEdad.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(10).Value


            'vig
            If (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "s/a") Then
                Me.rbVigSA.Checked = True
            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Bajo") Then
                Me.rbVigBajo.Checked = True
            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Norma") Then
                Me.rbVigNorma.Checked = True
            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Normal") Then
                Me.rbVigNormal.Checked = True
            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "+Normal") Then
                Me.rbVigNormal2.Checked = True
            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Alto") Then
                Me.rbVigAlto.Checked = True
            End If


            Me.txCultivo.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(12).Value
            Me.txObservacion.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(13).Value
            Me.cbMuestreador.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(14).Value
            ' End If

        Catch ex As Exception
        End Try

    End Sub


    'Private Sub dgDatArgNematodos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgNematodos.CellContentClick

    '    Try

    '        Me.txNlab.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(0).Value()
    '        If Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" Then

    '            Me.txCuartel1.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(1).Value
    '            Me.txCuartel2.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(2).Value
    '            Me.txPredio.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(3).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(4).Value
    '            Me.txPAnterior.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(5).Value
    '            Me.txPActual.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(6).Value
    '            Me.txTipo.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(7).Value

    '            Me.cbEspecie.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(8).Value
    '            Me.cbVariedad.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(9).Value
    '            Me.txEdad.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(10).Value


    '            'vig
    '            If (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "s/a") Then
    '                Me.rbVigSA.Checked = True
    '            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Bajo") Then
    '                Me.rbVigBajo.Checked = True
    '            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Norma") Then
    '                Me.rbVigNorma.Checked = True
    '            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Normal") Then
    '                Me.rbVigNormal.Checked = True
    '            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "+Normal") Then
    '                Me.rbVigNormal2.Checked = True
    '            ElseIf (Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(11).Value = "Alto") Then
    '                Me.rbVigAlto.Checked = True
    '            End If


    '            Me.txCultivo.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(12).Value
    '            Me.txObservacion.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(13).Value
    '            Me.cbMuestreador.Text = Me.dgDatArgNematodos.Rows(e.RowIndex).Cells.Item(14).Value
    '        End If

    '    Catch ex As Exception
    '    End Try

    'End Sub

    Private Sub cbEspecie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEspecie.SelectedIndexChanged

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

   
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'Call Revisa_NLab_Nulos()
        Me.Close()
    End Sub


    'Private Sub Revisa_NLab_Nulos()
    '    Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
    '    Dim claves(1) As Object
    '    Dim Fila_Ant As DataRow
    '    Dim Fila_Codificacion As DataRow
    '    Dim PrecioNeto, Retorno, C, OrTr, Rango1, Rango2, CantMuestras, CantNoNulas As Integer

    '    For Each Fila_Codificacion In Cjto_Orden1.Tables("OT_CODIFICACION_RECIBO").Rows
    '        CantMuestras = Fila_Codificacion("OTC_CANT_MUESTRAS")
    '        Rango1 = Fila_Codificacion("OTC_NLAB_DESDE")
    '        Rango2 = Fila_Codificacion("OTC_NLAB_HASTA")
    '        CantNoNulas = 0
    '        OrTr = Fila_Codificacion("OT_NUMERO")
    '        For C = Rango1 To Rango2
    '            claves(0) = OrTr
    '            claves(1) = C
    '            Fila_Ant = Cjto_Orden1.Tables("OT_NEMATODOS_ANTECEDENTES").Rows.Find(claves)
    '            If Not (Fila_Ant Is Nothing) Then
    '                If IsDBNull(Fila_Ant("NLAB_ESTADO")) = False Then
    '                    If Fila_Ant("NLAB_ESTADO") <> "Nula" Then CantNoNulas = CantNoNulas + 1
    '                End If
    '            End If
    '        Next
    '        If CantNoNulas = 0 Then CantNoNulas = CantMuestras
    '        PrecioNeto = CInt(Fila_Codificacion("OTC_PRECIOUN")) * CantNoNulas

    '        '-----------------------  GRABA OT_CODIFICACION CON POSIBLES CAMBIOS EN CANTIDAD Y VALOR PRECIONETO ---------------------------

    '        With SP
    '            .Inicializar()
    '            .AgregarParametro("@NumOT", Fila_Codificacion("OT_NUMERO"), SqlDbType.Int)
    '            .AgregarParametro("@TMuestra", 7000, SqlDbType.Int)
    '            .AgregarParametro("@NLabDesde", Fila_Codificacion("OTC_NLAB_DESDE"), SqlDbType.Int)
    '            .AgregarParametro("@AnaCod", Fila_Codificacion("ANA_CODIGO"), SqlDbType.Int)
    '            .AgregarParametro("@CantidadMuestras", CantNoNulas, SqlDbType.Int)
    '            .AgregarParametro("@PrecioNet", PrecioNeto, SqlDbType.Int)
    '            Retorno = .EjecutarEscalar("usp_UpdateCodificacion")
    '        End With
    '    Next

    '    Cjto_Orden1.Tables("OT_CODIFICACION").Clear()
    '    Cjto_Orden1.Tables("OT_CODIFICACION_RECIBO").Clear()

    '    With SP
    '        .Inicializar()
    '        .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
    '        .EjecutarQueryDt("usp_SelectCodificacion", Cjto_Orden1, "OT_CODIFICACION")

    '        .Inicializar()
    '        .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
    '        .EjecutarQueryDt("usp_SelectCodificacion", Cjto_Orden1, "OT_CODIFICACION_RECIBO")
    '    End With
    'End Sub
    Private Sub cbEspecie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbEspecie.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = cbEspecie.Text
            Call control_nombre(NOMBREX)
            cbEspecie.Text = NOMBREX
            Me.cbVariedad.Focus()
        End If
    End Sub

    Private Sub cbVariedad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbVariedad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = cbVariedad.Text
            Call control_nombre(NOMBREX)
            cbVariedad.Text = NOMBREX
            Me.txEdad.Focus()
        End If
    End Sub

    Private Sub cbLocalidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbLocalidad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = cbLocalidad.Text
            Call control_nombre(NOMBREX)
            cbLocalidad.Text = NOMBREX
            'Me.txEdad.Focus()
        End If
    End Sub
End Class