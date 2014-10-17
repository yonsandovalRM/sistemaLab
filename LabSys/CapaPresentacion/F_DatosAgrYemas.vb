Public Class F_DatosAgrYemas

    Private Sub F_DatosAgrYemas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner

        Me.txPredio.Text = orden.txPredio.Text



        Me.dgDatArgYemas.Rows.Clear()

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value > 8700 And orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value < 8720 Then

                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value

                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta

                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)

                    If Me.dgDatArgYemas.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatArgYemas.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'cuartel 1
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'cuartel 2
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
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
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
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                            dgvRow.Cells.Add(dgvCell)
                            'rto
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)
                            'car
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                            dgvRow.Cells.Add(dgvCell)
                            'vig
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'den
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'apa
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                            dgvRow.Cells.Add(dgvCell)
                            'n cargas
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                            dgvRow.Cells.Add(dgvCell)
                            'n yemas
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                            dgvRow.Cells.Add(dgvCell)
                            'observacion
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                            dgvRow.Cells.Add(dgvCell)
                            'f muestreo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(20)
                            dgvRow.Cells.Add(dgvCell)


                            Me.dgDatArgYemas.Rows.Add(dgvRow)
                        End If
                    Else

                        Dim t, s, u As Integer
                        t = Me.dgDatArgYemas.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatArgYemas.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDatArgYemas.Rows.Add(dgvRow)

                            Else
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'cuartel 1
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'cuartel 2
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
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(6)
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
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(7)
                                dgvRow.Cells.Add(dgvCell)
                                'rto
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)
                                'car
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                                dgvRow.Cells.Add(dgvCell)
                                'vig
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'den
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'apa
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                                dgvRow.Cells.Add(dgvCell)
                                'n cargas
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                                dgvRow.Cells.Add(dgvCell)
                                'n yemas
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                                dgvRow.Cells.Add(dgvCell)
                                'observacion
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                                dgvRow.Cells.Add(dgvCell)
                                'f muestreo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(20)
                                dgvRow.Cells.Add(dgvCell)

                                Me.dgDatArgYemas.Rows.Add(dgvRow)
                            End If

                        End If
                    End If

                    desde = desde + 1

                End While

            End If
            i = i + 1
        End While

        If Me.dgDatArgYemas.Rows.Count <> 0 Then
            Me.txNlab.Text = Me.dgDatArgYemas.Rows.Item(0).Cells.Item(0).Value
        End If

        Call llenaTejido()
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
            Me.cbTejido.Focus()
        End If
    End Sub

    Private Sub cbTejido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTejido.KeyDown
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
            Me.txCuartel1.Focus()
        End If
    End Sub

    Private Sub txCuartel1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCuartel1.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txCuartel1.Text
            Call control_nombre(NOMBREX)
            Me.txCuartel1.Text = NOMBREX
            Me.txCuartel2.Focus()
        End If
    End Sub

    Private Sub txCuartel2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCuartel2.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txCuartel2.Text
            Call control_nombre(NOMBREX)
            Me.txCuartel2.Text = NOMBREX
            Me.txObservacion.Focus()
        End If
    End Sub

    Private Sub txNcargas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNcargas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txNyemas.Focus()
        End If
    End Sub

    Private Sub txNyemas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txNyemas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txObservacion.Focus()
        End If
    End Sub

    Private Sub chSA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSA.CheckedChanged

        If (Me.chSA.Checked = True) Then
            Me.rbRtoSA.Checked = True
            Me.rbCarSA.Checked = True
            Me.rbVigSA.Checked = True
            Me.rbDenSA.Checked = True
            Me.rbApaSA.Checked = True
        Else
            Me.rbRtoSA.Checked = False
            Me.rbCarSA.Checked = False
            Me.rbVigSA.Checked = False
            Me.rbDenSA.Checked = False
            Me.rbApaSA.Checked = False

        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.cbVariedad.Text = ""
        Me.cbTejido.Text = ""
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
        Me.txNyemas.Text = ""
        Me.txNcargas.Text = ""

        Me.rbApaAnormal.Checked = False
        Me.rbApaNormal.Checked = False
        Me.rbApaSA.Checked = False
        Me.rbCarAlto.Checked = False
        Me.rbCarBajo.Checked = False
        Me.rbCarNorma.Checked = False
        Me.rbCarNormal.Checked = False
        Me.rbCarNormal2.Checked = False
        Me.rbCarSA.Checked = False
        Me.rbDenAlta.Checked = False
        Me.rbDenBaja.Checked = False
        Me.rbDenSA.Checked = False
        Me.rbDenTradicional.Checked = False
        Me.rbRtoAlto.Checked = False
        Me.rbRtoBajo.Checked = False
        Me.rbRtoNorma.Checked = False
        Me.rbRtoNormal.Checked = False
        Me.rbRtoNormal2.Checked = False
        Me.rbRtoSA.Checked = False
        Me.rbRtoSA.Checked = False
        Me.rbRtoSA.Checked = False
        Me.rbVigAlto.Checked = False
        Me.rbVigBajo.Checked = False
        Me.rbVigNorma.Checked = False
        Me.rbVigNormal.Checked = False
        Me.rbVigNormal2.Checked = False
        Me.rbVigSA.Checked = False
        Me.chSA.Checked = False
    End Sub

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
        Dim orden As F_OrdenTrabajo = Me.Owner

        Dim i, j As Integer

        j = orden.dgDatosAgronomicos.Rows.Count

        While i < j
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(1).Value.ToString = "Foliar" Then
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Style.BackColor = System.Drawing.Color.Blue
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Value = "C/DA"
            End If
            i = i + 1
        End While

        ' orden.tbOT.SelectedTabPage = orden.tbOT.TabPages("tbDatosAgronomicos")
        Me.Close()
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
        r = Me.dgDatArgYemas.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDatArgYemas.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNlab.Text Then
                Exit While
            End If
            i = i + 1
        End While

        rto = ""
        car = ""
        vig = ""
        den = ""
        apa = ""

        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(1).Value = Me.txCuartel1.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(2).Value = Me.txCuartel2.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(3).Value = Me.txPredio.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(4).Value = Me.cbLocalidad.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(5).Value = Me.cbTejido.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(6).Value = Me.cbEspecie.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(7).Value = Me.cbVariedad.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(8).Value = Me.txEdad.Text

        If rbRtoBajo.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(9).Value = "Bajo"
            rto = "Bajo"
        ElseIf Me.rbRtoNorma.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(9).Value = "Norma"
            rto = "Norma"
        ElseIf Me.rbRtoNormal.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(9).Value = "Normal"
            rto = "Normal"
        ElseIf Me.rbRtoNormal2.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(9).Value = "+Normal"
            rto = "+Normal"
        ElseIf Me.rbRtoAlto.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(9).Value = "Alto"
            rto = "Alto"
        ElseIf Me.rbRtoSA.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(9).Value = "s/a"
            rto = "s/a"
        End If

        If Me.rbCarBajo.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(10).Value = "Bajo"
            car = "Bajo"
        ElseIf Me.rbCarNorma.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(10).Value = "Norma"
            car = "Norma"
        ElseIf Me.rbCarNormal.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(10).Value = "Normal"
            car = "Normal"
        ElseIf Me.rbCarNormal2.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(10).Value = "+Normal"
            car = "+Normal"
        ElseIf Me.rbCarAlto.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(10).Value = "Alto"
            car = "Alto"
        ElseIf Me.rbCarSA.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(10).Value = "s/a"
            car = "s/a"
        End If

        If Me.rbVigBajo.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(11).Value = "Bajo"
            vig = "Bajo"
        ElseIf Me.rbVigNorma.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(11).Value = "Norma"
            vig = "Norma"
        ElseIf Me.rbVigNormal.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(11).Value = "Normal"
            vig = "Normal"
        ElseIf Me.rbVigNormal2.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(11).Value = "+Normal"
            vig = "+Normal"
        ElseIf Me.rbVigAlto.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(11).Value = "Alto"
            vig = "Alto"
        ElseIf Me.rbVigSA.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(11).Value = "s/a"
            vig = "s/a"
        End If

        If Me.rbDenBaja.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(12).Value = "Baja"
            den = "Baja"
        ElseIf Me.rbDenTradicional.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(12).Value = "Tradicional"
            den = "Tradicional"
        ElseIf Me.rbDenAlta.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(12).Value = "Alta"
            den = "Alta"
        ElseIf Me.rbDenSA.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(12).Value = "s/a"
            den = "s/a"
        End If

        If Me.rbApaAnormal.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(13).Value = "Anormal"
            apa = "Anormal"
        ElseIf Me.rbApaNormal.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(13).Value = "Normal"
            apa = "Normal"
        ElseIf Me.rbApaSA.Checked = True Then
            Me.dgDatArgYemas.Rows.Item(i).Cells.Item(13).Value = "s/a"
            apa = "s/a"
        End If

        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(14).Value = Me.txNcargas.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(15).Value = Me.txNyemas.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(16).Value = Me.txObservacion.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(17).Value = Me.cbMuestreador.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(18).Value = Me.dtMuestreador.Text
        Me.dgDatArgYemas.Rows.Item(i).Cells.Item(19).Value = "xA"

        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@NumOT", orden.lblNot.Text, SqlDbType.Int)
            .AgregarParametro("@NumLabYemas", CInt(Me.txNlab.Text), SqlDbType.Int)
            .AgregarParametro("@PredioYemas", txPredio.Text, SqlDbType.NVarChar)
            .AgregarParametro("@LocYemas", cbLocalidad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@EspYemas", cbEspecie.Text, SqlDbType.NVarChar)
            .AgregarParametro("@VarYemas", cbVariedad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@TejYemas", cbTejido.Text, SqlDbType.NVarChar)
            .AgregarParametro("@EdadYemas", txEdad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel1Yemas", txCuartel1.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Cuartel2Yemas", txCuartel2.Text, SqlDbType.NVarChar)
            .AgregarParametro("@strRtoAnt", rto, SqlDbType.NVarChar)
            .AgregarParametro("@strCarga", car, SqlDbType.NVarChar)
            .AgregarParametro("@strVigor", vig, SqlDbType.NVarChar)
            .AgregarParametro("@strDensidad", den, SqlDbType.NVarChar)
            .AgregarParametro("@strApa", apa, SqlDbType.NVarChar)
            .AgregarParametro("@NumCargadores", CInt(Me.txNcargas.Text), SqlDbType.Int)
            .AgregarParametro("@NumYemas", CInt(txNyemas.Text), SqlDbType.Int)
            .AgregarParametro("@ObsYemas", txObservacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@MuestreadorYemas", cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FMuestreoYemas", Me.dtMuestreador.Text, SqlDbType.DateTime)

            .EjecutarEscalar("usp_GrabaAntecedentesYemas")
        End With

        If i + 1 < Me.dgDatArgYemas.Rows.Count Then
            Me.txNlab.Text = Me.dgDatArgYemas.Rows.Item(i + 1).Cells.Item(0).Value
            If Me.dgDatArgYemas.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then

                Me.txCuartel1.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(1).Value
                Me.txCuartel2.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(2).Value
                Me.txPredio.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(3).Value
                Me.cbLocalidad.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(4).Value
                Me.cbTejido.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(5).Value
                Me.cbEspecie.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(6).Value
                'rto
                If (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(9).Value = "s/a") Then
                    Me.rbRtoSA.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(9).Value = "Bajo") Then
                    Me.rbRtoBajo.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(9).Value = "Norma") Then
                    Me.rbRtoNorma.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(9).Value = "Normal") Then
                    Me.rbRtoNormal.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(9).Value = "+Normal") Then
                    Me.rbRtoNormal2.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(9).Value = "Alto") Then
                    Me.rbRtoAlto.Checked = True
                End If
                'carga
                If (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(10).Value = "s/a") Then
                    Me.rbCarSA.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(10).Value = "Bajo") Then
                    Me.rbCarBajo.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(10).Value = "Norma") Then
                    Me.rbCarNorma.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(10).Value = "Normal") Then
                    Me.rbCarNormal.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(10).Value = "+Normal") Then
                    Me.rbCarNormal2.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(10).Value = "Alto") Then
                    Me.rbCarAlto.Checked = True
                End If
                'vig
                If (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(11).Value = "s/a") Then
                    Me.rbVigSA.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(11).Value = "Bajo") Then
                    Me.rbVigBajo.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(11).Value = "Norma") Then
                    Me.rbVigNorma.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(11).Value = "Normal") Then
                    Me.rbVigNormal.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(11).Value = "+Normal") Then
                    Me.rbVigNormal2.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(11).Value = "Alto") Then
                    Me.rbVigAlto.Checked = True
                End If
                'den
                If (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(12).Value = "s/a") Then
                    Me.rbDenSA.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(12).Value = "Baja") Then
                    Me.rbDenBaja.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(10).Value = "Tradicional") Then
                    Me.rbDenTradicional.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(12).Value = "Alta") Then
                    Me.rbDenAlta.Checked = True
                End If
                'apa
                If (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(13).Value = "s/a") Then
                    Me.rbApaSA.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(13).Value = "Anormal") Then
                    Me.rbApaAnormal.Checked = True
                ElseIf (Me.dgDatArgYemas.Rows(i + 1).Cells.Item(13).Value = "Normal") Then
                    Me.rbApaNormal.Checked = True
                End If

                Me.txNcargas.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(14).Value
                Me.txNyemas.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(15).Value
                Me.txObservacion.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(16).Value
                Me.cbMuestreador.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(17).Value
                Me.dtMuestreador.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(18).Value
                Me.cbVariedad.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(7).Value
                Me.txEdad.Text = Me.dgDatArgYemas.Rows(i + 1).Cells.Item(8).Value
            End If
        End If

    End Sub

    Private Sub dgDatArgYemas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgYemas.CellClick
        Try

            Me.txNlab.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(0).Value
            'If Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" Then

            Me.txCuartel1.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(1).Value
            Me.txCuartel2.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(2).Value
            Me.txPredio.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(3).Value
            Me.cbLocalidad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(4).Value
            Me.cbTejido.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(5).Value
            Me.cbEspecie.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(6).Value
            Me.cbVariedad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value
            Me.txEdad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value

            'rto
            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "s/a") Then
                Me.rbRtoSA.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Bajo") Then
                Me.rbRtoBajo.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Norma") Then
                Me.rbRtoNorma.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Normal") Then
                Me.rbRtoNormal.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "+Normal") Then
                Me.rbRtoNormal2.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Alto") Then
                Me.rbRtoAlto.Checked = True
            End If
            'carga
            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "s/a") Then
                Me.rbCarSA.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Bajo") Then
                Me.rbCarBajo.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Norma") Then
                Me.rbCarNorma.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Normal") Then
                Me.rbCarNormal.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "+Normal") Then
                Me.rbCarNormal2.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Alto") Then
                Me.rbCarAlto.Checked = True
            End If
            'vig
            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "s/a") Then
                Me.rbVigSA.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Bajo") Then
                Me.rbVigBajo.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Norma") Then
                Me.rbVigNorma.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Normal") Then
                Me.rbVigNormal.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "+Normal") Then
                Me.rbVigNormal2.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Alto") Then
                Me.rbVigAlto.Checked = True
            End If
            'den
            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "s/a") Then
                Me.rbDenSA.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "Baja") Then
                Me.rbDenBaja.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "Tradicional") Then
                Me.rbDenTradicional.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "Alta") Then
                Me.rbDenAlta.Checked = True
            End If
            'apa
            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(13).Value = "s/a") Then
                Me.rbApaSA.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(13).Value = "Anormal") Then
                Me.rbApaAnormal.Checked = True
            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(13).Value = "Normal") Then
                Me.rbApaNormal.Checked = True
            End If

            Me.txNcargas.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(14).Value
            Me.txNyemas.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(15).Value
            Me.txObservacion.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(16).Value
            Me.cbMuestreador.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(17).Value
            Me.dtMuestreador.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(18).Value
            'End If

        Catch ex As Exception
        End Try
    End Sub

    'Private Sub dgDatArgYemas_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgYemas.CellContentClick
    '    Try

    '        Me.txNlab.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" Then

    '            Me.txCuartel1.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(1).Value
    '            Me.txCuartel2.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(2).Value
    '            Me.txPredio.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(3).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(4).Value
    '            Me.cbTejido.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(5).Value
    '            Me.cbEspecie.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(6).Value
    '            Me.cbVariedad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value
    '            Me.txEdad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value

    '            'rto
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "s/a") Then
    '                Me.rbRtoSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Bajo") Then
    '                Me.rbRtoBajo.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Norma") Then
    '                Me.rbRtoNorma.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Normal") Then
    '                Me.rbRtoNormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "+Normal") Then
    '                Me.rbRtoNormal2.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Alto") Then
    '                Me.rbRtoAlto.Checked = True
    '            End If
    '            'carga
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "s/a") Then
    '                Me.rbCarSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Bajo") Then
    '                Me.rbCarBajo.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Norma") Then
    '                Me.rbCarNorma.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Normal") Then
    '                Me.rbCarNormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "+Normal") Then
    '                Me.rbCarNormal2.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Alto") Then
    '                Me.rbCarAlto.Checked = True
    '            End If
    '            'vig
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "s/a") Then
    '                Me.rbVigSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Bajo") Then
    '                Me.rbVigBajo.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Norma") Then
    '                Me.rbVigNorma.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Normal") Then
    '                Me.rbVigNormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "+Normal") Then
    '                Me.rbVigNormal2.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Alto") Then
    '                Me.rbVigAlto.Checked = True
    '            End If
    '            'den
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "s/a") Then
    '                Me.rbDenSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "Baja") Then
    '                Me.rbDenBaja.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "Tradicional") Then
    '                Me.rbDenTradicional.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value = "Alta") Then
    '                Me.rbDenAlta.Checked = True
    '            End If
    '            'apa
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(13).Value = "s/a") Then
    '                Me.rbApaSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(13).Value = "Anormal") Then
    '                Me.rbApaAnormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(13).Value = "Normal") Then
    '                Me.rbApaNormal.Checked = True
    '            End If

    '            Me.txNcargas.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(14).Value
    '            Me.txNyemas.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(15).Value
    '            Me.txObservacion.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(16).Value
    '            Me.cbMuestreador.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(17).Value
    '            Me.dtMuestreador.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(18).Value
    '        End If

    '    Catch ex As Exception
    '    End Try

    'End Sub

    'Private Sub dgDatArgYemas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatArgYemas.CellDoubleClick
    '    Try

    '        Me.txNlab.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" Then

    '            Me.txCuartel1.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(1).Value
    '            Me.txCuartel2.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(2).Value
    '            Me.cbTejido.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(3).Value
    '            Me.cbEspecie.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(4).Value
    '            Me.cbVariedad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(5).Value
    '            Me.txEdad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(6).Value
    '            'rto
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value = "s/a") Then
    '                Me.rbRtoSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value = "Bajo") Then
    '                Me.rbRtoBajo.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value = "Norma") Then
    '                Me.rbRtoNorma.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value = "Normal") Then
    '                Me.rbRtoNormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value = "+Normal") Then
    '                Me.rbRtoNormal2.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(7).Value = "Alto") Then
    '                Me.rbRtoAlto.Checked = True
    '            End If
    '            'carga
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value = "s/a") Then
    '                Me.rbCarSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value = "Bajo") Then
    '                Me.rbCarBajo.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value = "Norma") Then
    '                Me.rbCarNorma.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value = "Normal") Then
    '                Me.rbCarNormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value = "+Normal") Then
    '                Me.rbCarNormal2.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(8).Value = "Alto") Then
    '                Me.rbCarAlto.Checked = True
    '            End If
    '            'vig
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "s/a") Then
    '                Me.rbVigSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Bajo") Then
    '                Me.rbVigBajo.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Norma") Then
    '                Me.rbVigNorma.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Normal") Then
    '                Me.rbVigNormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "+Normal") Then
    '                Me.rbVigNormal2.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(9).Value = "Alto") Then
    '                Me.rbVigAlto.Checked = True
    '            End If
    '            'den
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "s/a") Then
    '                Me.rbDenSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Baja") Then
    '                Me.rbDenBaja.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Tradicional") Then
    '                Me.rbDenTradicional.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(10).Value = "Alta") Then
    '                Me.rbDenAlta.Checked = True
    '            End If
    '            'apa
    '            If (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "s/a") Then
    '                Me.rbApaSA.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Anormal") Then
    '                Me.rbApaAnormal.Checked = True
    '            ElseIf (Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(11).Value = "Normal") Then
    '                Me.rbApaNormal.Checked = True
    '            End If

    '            Me.txNcargas.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(12).Value
    '            Me.txNyemas.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(13).Value
    '            Me.txObservacion.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(14).Value
    '            Me.cbMuestreador.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(15).Value
    '            Me.dtMuestreador.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(16).Value
    '            Me.txPredio.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(17).Value
    '            Me.cbLocalidad.Text = Me.dgDatArgYemas.Rows(e.RowIndex).Cells.Item(18).Value
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim fila As DataGridViewRow
        'Dim vaOrigen As String
        'Dim etiqueta As New Etiquetas.Etiqueta
        'For Each fila In Me.dgDArgonomicoAgua.Rows
        '    If fila.Cells(7).Value.ToString = "Pot" Then
        '        vaOrigen = "Potable"
        '    ElseIf fila.Cells(7).Value.ToString = "Can" Then
        '        vaOrigen = "Canal"
        '    ElseIf fila.Cells(7).Value.ToString = "Poz" Then
        '        vaOrigen = "Pozo"
        '    ElseIf fila.Cells(7).Value.ToString = "Rio" Then
        '        vaOrigen = "Rio"
        '    End If
        '    etiqueta.Imprimir_Etiqueta1("192.168.0.69", "443", "Agrolab " & Today, fila.Cells(0).Value.ToString, "N. Lab. : " & fila.Cells(0).Value.ToString, "Origen: " & vaOrigen) '"Origen: " & vaOrigen, fila.Cells(7).Value.ToString, , fila.Cells(0).Value.ToString)
        '    'MsgBox("NLab: " & fila.Cells(0).Value.ToString & " Tejido: " & fila.Cells(5).Value.ToString, MsgBoxStyle.Information, "Imprimiendo Etiquetas")
        'Next



    End Sub
End Class

