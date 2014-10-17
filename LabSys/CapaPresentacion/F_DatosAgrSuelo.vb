Public Class F_DatosAgrSuelo

    Private Sub F_DatosAgrSuelo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim nlabDesde, nlabHasta As String
        Dim i, r As Integer
        Dim cn As New CapaNegocio
        Dim dsArg As New DataSet
        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim Fila_Loc As DataRow

        Me.dgDatosArgonomicosSuelo.Rows.Clear()
        Me.txPredio.Text = orden.txPredio.Text

        i = 0
        r = orden.dgDatosAgronomicos.Rows.Count

        While i < r
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value > 4000 And orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(0).Value < 5000 Then


                nlabDesde = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(3).Value
                nlabHasta = orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(4).Value


                Dim desde As Integer = nlabDesde

                While desde <= nlabHasta


                    dsArg = cn.datosAntecedentes(analisisVar, orden.lblNot.Text, desde)

                    If Me.dgDatosArgonomicosSuelo.Rows.Count = 0 Then
                        If dsArg.Tables(0).Rows.Count = 0 Then

                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = desde
                            dgvRow.Cells.Add(dgvCell)
                            Me.dgDatosArgonomicosSuelo.Rows.Add(dgvRow)

                        Else
                            Dim dgvRow As New DataGridViewRow
                            Dim dgvCell As DataGridViewCell
                            'nlab
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                            dgvRow.Cells.Add(dgvCell)
                            'id1
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
                            'cul ante
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                            dgvRow.Cells.Add(dgvCell)
                            'rto ant
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                            dgvRow.Cells.Add(dgvCell)
                            'cant ant
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                            dgvRow.Cells.Add(dgvCell)
                            'uni ant
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                            dgvRow.Cells.Add(dgvCell)
                            'c prox
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                            dgvRow.Cells.Add(dgvCell)
                            'rto act
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                            dgvRow.Cells.Add(dgvCell)
                            'c act
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                            dgvRow.Cells.Add(dgvCell)
                            'uniact
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                            dgvRow.Cells.Add(dgvCell)
                            'fmuestreo
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                            dgvRow.Cells.Add(dgvCell)
                            'muestreador
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                            dgvRow.Cells.Add(dgvCell)
                            'textura
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                            dgvRow.Cells.Add(dgvCell)
                            'profudidad
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                            dgvRow.Cells.Add(dgvCell)
                            'riego
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                            dgvRow.Cells.Add(dgvCell)
                            'drenaje
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                            dgvRow.Cells.Add(dgvCell)
                            'observaciones
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(20)
                            dgvRow.Cells.Add(dgvCell)
                            'recomendaciones
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                            dgvRow.Cells.Add(dgvCell)
                            'region
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(23)
                            dgvRow.Cells.Add(dgvCell)
                            'profMuestra
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(24)
                            dgvRow.Cells.Add(dgvCell)
                            'estado
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(22)
                            dgvRow.Cells.Add(dgvCell)

                            Me.dgDatosArgonomicosSuelo.Rows.Add(dgvRow)
                        End If
                    Else
                        Dim t, s, u As Integer
                        t = Me.dgDatosArgonomicosSuelo.Rows.Count
                        u = 0
                        s = 0
                        While s < t
                            If Me.dgDatosArgonomicosSuelo.Rows.Item(s).Cells.Item(0).Value = desde Then
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
                                Me.dgDatosArgonomicosSuelo.Rows.Add(dgvRow)

                            Else
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell
                                'nlab
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(1)
                                dgvRow.Cells.Add(dgvCell)
                                'id1
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
                                'cul ante
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(8)
                                dgvRow.Cells.Add(dgvCell)
                                'rto ant
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(9)
                                dgvRow.Cells.Add(dgvCell)
                                'cant ant
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(10)
                                dgvRow.Cells.Add(dgvCell)
                                'uni ant
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(11)
                                dgvRow.Cells.Add(dgvCell)
                                'c prox
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(12)
                                dgvRow.Cells.Add(dgvCell)
                                'rto act
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(13)
                                dgvRow.Cells.Add(dgvCell)
                                'c act
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(14)
                                dgvRow.Cells.Add(dgvCell)
                                'uniact
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(15)
                                dgvRow.Cells.Add(dgvCell)
                                'fmuestreo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(3)
                                dgvRow.Cells.Add(dgvCell)
                                'muestreador
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(2)
                                dgvRow.Cells.Add(dgvCell)
                                'textura
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(16)
                                dgvRow.Cells.Add(dgvCell)
                                'profudidad
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(17)
                                dgvRow.Cells.Add(dgvCell)
                                'riego
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(19)
                                dgvRow.Cells.Add(dgvCell)
                                'drenaje
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(18)
                                dgvRow.Cells.Add(dgvCell)
                                'observaciones
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(20)
                                dgvRow.Cells.Add(dgvCell)
                                'recomendaciones
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(21)
                                dgvRow.Cells.Add(dgvCell)
                                'region
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(23)
                                dgvRow.Cells.Add(dgvCell)
                                'profMuestra
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(24)
                                dgvRow.Cells.Add(dgvCell)
                                'estado
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.Value = dsArg.Tables(0).Rows.Item(0).Item(22)
                                dgvRow.Cells.Add(dgvCell)


                                Me.dgDatosArgonomicosSuelo.Rows.Add(dgvRow)
                            End If

                        End If

                    End If


                    desde = desde + 1

                End While
            End If
            i = i + 1
        End While

        Dim cd As New CapaDato

        With cd
            .Inicializar()
            .EjecutarQueryDt("usp_SelectCultivo", Cjto_Tablas1, "CULTIVO")

            Me.cbCultivoAnterior.Items.Add("")
            For Each Fila_Loc In Cjto_Tablas1.Tables("CULTIVO").Rows
                Me.cbCultivoAnterior.Items.Add(Fila_Loc("CULTIVO"))
            Next

            Me.cbCultivoProximo.Items.Add("")
            For Each Fila_Loc In Cjto_Tablas1.Tables("CULTIVO").Rows
                Me.cbCultivoProximo.Items.Add(Fila_Loc("CULTIVO"))
            Next
        End With
        If Me.dgDatosArgonomicosSuelo.Rows.Count <> 0 Then
            Me.txNot.Text = Me.dgDatosArgonomicosSuelo.Rows.Item(0).Cells.Item(0).Value
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

    Private Sub btnAceptarSuelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarSuelo.Click

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
            If orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(1).Value.ToString = "Suelo" Then
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Style.BackColor = System.Drawing.Color.Blue
                orden.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Value = "C/DA"
            End If
            i = i + 1
        End While

        'orden.tbOT.SelectedTabPage = orden.tbOT.TabPages("tbDatosAgronomicos")


        If Tipo_Ingreso_OT = "Consulta" Then
            orden.tbOT.SelectedTab = orden.tbOT.TabPages(2)
        Else
            orden.tbOT.SelectedTab = orden.tbOT.TabPages(3)

        End If


        Me.Close()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If Trim(Me.txNot.Text) = "" Then
            MsgBox("Debe seleccionar un Numero de Laboratorio antes de asignarle valores.", MsgBoxStyle.Information)
            Exit Sub
        End If


        Dim i, r, j, nlab As Integer
        Dim rto, un, re, un2, tex, pro, ri, dr As String
        Dim cn As New CapaNegocio
        Dim orden As F_OrdenTrabajo = Me.Owner
        r = Me.dgDatosArgonomicosSuelo.Rows.Count
        i = 0

        While i < r
            nlab = Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(0).Value

            If nlab = Me.txNot.Text Then
                Exit While
            End If
            i = i + 1
        End While

        rto = ""
        un = ""
        re = ""
        un2 = ""
        tex = ""
        pro = ""
        ri = ""
        dr = ""

        Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(1).Value = Me.txIdentificacion1.Text
        Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(2).Value = Me.txIdentificacion2.Text
        Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(3).Value = Me.txPredio.Text
        Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(4).Value = Me.cbLocalidad.Text
        Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(5).Value = Me.cbCultivoAnterior.Text

        If Me.rbRABaja.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(6).Value = "B"
            rto = "B"
        ElseIf Me.rbRANorma.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(6).Value = "-N"
            rto = "-N"
        ElseIf Me.rbRANormal.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(6).Value = "N"
            rto = "N"
        ElseIf Me.rbRANormal2.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(6).Value = "+N"
            rto = "+N"
        ElseIf Me.rbRAAlto.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(6).Value = "A"
            rto = "A"
        ElseIf Me.rbRASA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows.Item(i).Cells.Item(6).Value = "s/a"
            rto = "s/a"
        End If

        'cantidad
        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(7).Value = Me.txCantidadRtAnterior.Text
        'unidad
        If Me.rbRAQQHA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(8).Value = "qq"
            un = "qq"
        ElseIf Me.rbRATONHA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(8).Value = "ton"
            un = "ton"
        ElseIf Me.rbRAUNHA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(8).Value = "un"
            un = "un"
        ElseIf Me.rbRAOtra.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(8).Value = "otr"
            un = "otr"
        End If

        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(9).Value = Me.cbCultivoProximo.Text

        'rto
        If Me.rbRESA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(10).Value = "s/a"
            re = "s/a"
        ElseIf Me.rbREBaja.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(10).Value = "B"
            re = "B"
        ElseIf Me.rbRENorma.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(10).Value = "-N"
            re = "-N"
        ElseIf Me.rbRENormal.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(10).Value = "N"
            re = "N"
        ElseIf Me.rbRENormal2.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(10).Value = "+N"
            re = "+N"
        ElseIf Me.rbREAlto.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(10).Value = "A"
            re = "A"
        End If

        'cantidad
        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(11).Value = Me.txCantidadRtEsperado.Text
        'unidad
        If Me.rbREQQHA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(12).Value = "qq"
            un2 = "qq"
        ElseIf Me.rbRETONHA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(12).Value = "ton"
            un2 = "ton"
        ElseIf Me.rbREUNHA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(12).Value = "un"
            un2 = "un"
        ElseIf Me.rbREOtra.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(12).Value = "otr"
            un2 = "otr"
        End If

        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(13).Value = Me.dtMuestreador.Text
        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(14).Value = Me.cbMuestreador.Text

        'textura
        If Me.rbtexSA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(15).Value = "s/a"
            tex = "s/a"
        ElseIf Me.rbtexArenosa.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(15).Value = "Arn"
            tex = "Arn"
        ElseIf Me.rbtexFcoArenosa.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(15).Value = "FAr"
            tex = "FAr"
        ElseIf Me.rbtexFranco.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(15).Value = "Frc"
            tex = "Frc"
        ElseIf Me.rbtexFcoArcillosa.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(15).Value = "Fll"
            tex = "Fll"
        ElseIf Me.rbtexArcillosa.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(15).Value = "Arc"
            tex = "Arc"
        End If

        'Profundidad
        If Me.rbPASA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(16).Value = "s/a"
            pro = "s/a"
        ElseIf Me.rbPADelgado.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(16).Value = "Del"
            pro = "Del"
        ElseIf Me.rbPAMedio.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(16).Value = "Med"
            pro = "Med"
        ElseIf Me.rbPAProfundo.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(16).Value = "Pro"
            pro = "Pro"
        End If

        'riego
        If Me.rbRISA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(17).Value = "s/a"
            ri = "s/a"
        ElseIf Me.rbRICon.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(17).Value = "Si"
            ri = "Si"
        ElseIf Me.rbRINo.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(17).Value = "No"
            ri = "No"
        End If

        'Drenaje
        If Me.rbDSA.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(18).Value = "s/a"
            dr = "s/a"
        ElseIf Me.rbDEscaso.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(18).Value = "Esc"
            dr = "Esc"
        ElseIf Me.rbDImprefecto.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(18).Value = "Imp"
            dr = "Imp"
        ElseIf Me.rbDBueno.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(18).Value = "Bue"
            dr = "Bue"
        ElseIf Me.rbDExcesivo.Checked = True Then
            Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(18).Value = "Exc"
            dr = "Exc"
        End If


        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(19).Value = Me.txObservacion.Text
        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(20).Value = ""
        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(21).Value = ""
        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(22).Value = Me.txProfundMuestreo.Text
        Me.dgDatosArgonomicosSuelo.Rows(i).Cells.Item(23).Value = "xA"


        Dim cd As New CapaDato

        With cd

            .Inicializar()
            .AgregarParametro("@NumOT", CInt(Orden_Trabajo), SqlDbType.Int)
            .AgregarParametro("@NumLab", CInt(Me.txNot.Text), SqlDbType.Int)
            .AgregarParametro("@Predio", Me.txPredio.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Localidad", Me.cbLocalidad.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion1", Me.txIdentificacion1.Text, SqlDbType.NVarChar)
            .AgregarParametro("@Identificacion2", Me.txIdentificacion2.Text, SqlDbType.NVarChar)
            .AgregarParametro("@ProfundidadMuestra", Me.txProfundMuestreo.Text, SqlDbType.NVarChar)
            .AgregarParametro("@CultivoAnt", Me.cbCultivoAnterior.Text, SqlDbType.NVarChar)
            .AgregarParametro("@RtoAnt", rto, SqlDbType.NVarChar)
            .AgregarParametro("@CantRtoAnt", Me.txCantidadRtAnterior.Text, SqlDbType.NVarChar)
            .AgregarParametro("@UnidadAnt", un, SqlDbType.NVarChar)
            .AgregarParametro("@CultivoPro", Me.cbCultivoProximo.Text, SqlDbType.NVarChar)
            .AgregarParametro("@RtoAct", re, SqlDbType.NVarChar)
            .AgregarParametro("@CantRtoAct", Me.txCantidadRtEsperado.Text, SqlDbType.NVarChar)
            .AgregarParametro("@UnidadAct", un2, SqlDbType.NVarChar)
            .AgregarParametro("@Textura", tex, SqlDbType.NVarChar)
            .AgregarParametro("@Profundidad", pro, SqlDbType.NVarChar)
            .AgregarParametro("@Drenaje", dr, SqlDbType.NVarChar)
            .AgregarParametro("@Riego", ri, SqlDbType.NVarChar)
            .AgregarParametro("@Observacion", Me.txObservacion.Text, SqlDbType.NVarChar)
            .AgregarParametro("@strReq", False, SqlDbType.Bit)
            .AgregarParametro("@Muestreador", Me.cbMuestreador.Text, SqlDbType.NVarChar)
            .AgregarParametro("@FechaIng", Me.dtMuestreador.Text, SqlDbType.DateTime)
            .EjecutarEscalar("ls_GrabaAntecedentesSuelo")

        End With


        If i + 1 < Me.dgDatosArgonomicosSuelo.Rows.Count Then
            Me.txNot.Text = Me.dgDatosArgonomicosSuelo.Rows.Item(i + 1).Cells.Item(0).Value

            '############################################ desde aki ################################################
            If Me.dgDatosArgonomicosSuelo.Rows.Item(i + 1).Cells.Item(1).Value <> "" Then

                ' Me.txNot.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(0).Value
                ' If Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(5).Value.ToString <> "" And Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(4).Value.ToString <> "" Then

                Me.txIdentificacion1.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(1).Value
                Me.txIdentificacion2.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(2).Value
                Me.txPredio.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(3).Value
                Me.cbLocalidad.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(4).Value
                Me.cbCultivoAnterior.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(5).Value

                'rto
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(6).Value = "s/a") Then
                    Me.rbRASA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(6).Value = "B") Then
                    Me.rbRABaja.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(6).Value = "-N") Then
                    Me.rbRANorma.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(6).Value = "N") Then
                    Me.rbRANormal.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(6).Value = "+N") Then
                    Me.rbRANormal2.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(6).Value = "A") Then
                    Me.rbRAAlto.Checked = True
                End If
                'cantidad
                Me.txCantidadRtAnterior.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(7).Value

                'unidad
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(8).Value = "qq") Then
                    Me.rbRAQQHA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(8).Value = "ton") Then
                    Me.rbRATONHA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(8).Value = "un") Then
                    Me.rbRAUNHA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(8).Value = "otr") Then
                    Me.rbRAOtra.Checked = True
                End If

                Me.cbCultivoProximo.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(9).Value

                'rto
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(10).Value = "s/a") Then
                    Me.rbRESA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(10).Value = "B") Then
                    Me.rbREBaja.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(10).Value = "-N") Then
                    Me.rbRENorma.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(10).Value = "N") Then
                    Me.rbRENormal.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(10).Value = "+N") Then
                    Me.rbRENormal2.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(10).Value = "A") Then
                    Me.rbREAlto.Checked = True
                End If
                'cantidad
                Me.txCantidadRtEsperado.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(11).Value

                'unidad
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(12).Value = "qq") Then
                    Me.rbREQQHA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(12).Value = "ton") Then
                    Me.rbRETONHA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(12).Value = "un") Then
                    Me.rbREUNHA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(12).Value = "otr") Then
                    Me.rbREOtra.Checked = True
                End If

                Me.dtMuestreador.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(13).Value
                Me.cbMuestreador.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(14).Value

                'textura
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(15).Value = "s/a") Then
                    Me.rbtexSA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(15).Value = "Arn") Then
                    Me.rbtexArenosa.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(15).Value = "FAr") Then
                    Me.rbtexFcoArenosa.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(15).Value = "Frc") Then
                    Me.rbtexFranco.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(15).Value = "Fll") Then
                    Me.rbtexFcoArcillosa.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(15).Value = "Arc") Then
                    Me.rbtexArcillosa.Checked = True
                End If

                'Profundidad
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(16).Value = "s/a") Then
                    Me.rbPASA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(16).Value = "Del") Then
                    Me.rbPADelgado.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(16).Value = "Med") Then
                    Me.rbPAMedio.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(16).Value = "Pro") Then
                    Me.rbPAProfundo.Checked = True
                End If

                'riego
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(17).Value = "s/a") Then
                    Me.rbRISA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(17).Value = "Si") Then
                    Me.rbRICon.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(17).Value = "No") Then
                    Me.rbRINo.Checked = True
                End If

                'Drenaje
                If (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(18).Value = "s/a") Then
                    Me.rbDSA.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(18).Value = "Esc") Then
                    Me.rbDEscaso.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(18).Value = "Imp") Then
                    Me.rbDImprefecto.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(18).Value = "Bue") Then
                    Me.rbDBueno.Checked = True
                ElseIf (Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(18).Value = "Exc") Then
                    Me.rbDExcesivo.Checked = True
                End If


                Me.txObservacion.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(19).Value
                Me.txProfundMuestreo.Text = Me.dgDatosArgonomicosSuelo.Rows(i + 1).Cells.Item(22).Value
                'End If
                '############################################ hasta aki ################################################
            End If

        End If



    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txCantidadRtAnterior.Text = ""
        Me.txCantidadRtEsperado.Text = ""
        Me.txIdentificacion1.Text = ""
        Me.txIdentificacion2.Text = ""
        Me.txMuestras.Text = ""
        Me.txNot.Text = ""
        Me.txObservacion.Text = ""
        Me.txPredio.Text = ""
        Me.txProfundMuestreo.Text = ""
        Me.cbCultivoAnterior.Text = ""
        Me.cbCultivoProximo.Text = ""
        Me.cbLocalidad.Text = ""
        Me.cbMuestreador.Text = ""
        Me.dtMuestreador.Text = ""
        Me.rbDBueno.Checked = False
        Me.rbDEscaso.Checked = False
        Me.rbDExcesivo.Checked = False
        Me.rbDImprefecto.Checked = False
        Me.rbDSA.Checked = False
        Me.rbPADelgado.Checked = False
        Me.rbPAMedio.Checked = False
        Me.rbPAProfundo.Checked = False
        Me.rbPASA.Checked = False
        Me.rbRAAlto.Checked = False
        Me.rbRABaja.Checked = False
        Me.rbRANorma.Checked = False
        Me.rbRANormal.Checked = False
        Me.rbRANormal2.Checked = False
        Me.rbRAOtra.Checked = False
        Me.rbRAQQHA.Checked = False
        Me.rbRASA.Checked = False
        Me.rbRATONHA.Checked = False
        Me.rbRAUNHA.Checked = False
        Me.rbREAlto.Checked = False
        Me.rbREBaja.Checked = False
        Me.rbRENorma.Checked = False
        Me.rbRENormal.Checked = False
        Me.rbRENormal2.Checked = False
        Me.rbREOtra.Checked = False
        Me.rbREQQHA.Checked = False
        Me.rbRESA.Checked = False
        Me.rbRETONHA.Checked = False
        Me.rbREUNHA.Checked = False
        Me.rbRICon.Checked = False
        Me.rbRINo.Checked = False
        Me.rbRISA.Checked = False
        Me.rbtexArcillosa.Checked = False
        Me.rbtexArenosa.Checked = False
        Me.rbtexFcoArcillosa.Checked = False
        Me.rbtexFcoArenosa.Checked = False
        Me.rbtexFranco.Checked = False
        Me.rbtexSA.Checked = False


    End Sub

    Private Sub dgDatosArgonomicosSuelo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosArgonomicosSuelo.CellClick
        Try
            Me.txNot.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(0).Value
            'If Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" Then  '############################################ desde aki ################################################

            Me.txIdentificacion1.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(1).Value
            Me.txIdentificacion2.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(2).Value
            Me.txPredio.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(3).Value
            Me.cbLocalidad.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(4).Value
            Me.cbCultivoAnterior.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(5).Value

            'rto
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "s/a") Then
                Me.rbRASA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "B") Then
                Me.rbRABaja.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "-N") Then
                Me.rbRANorma.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "N") Then
                Me.rbRANormal.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "+N") Then
                Me.rbRANormal2.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "A") Then
                Me.rbRAAlto.Checked = True
            End If
            'cantidad
            Me.txCantidadRtAnterior.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(7).Value

            'unidad
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "qq") Then
                Me.rbRAQQHA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "ton") Then
                Me.rbRATONHA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "un") Then
                Me.rbRAUNHA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "otr") Then
                Me.rbRAOtra.Checked = True
            End If

            Me.cbCultivoProximo.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(9).Value

            'rto
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "s/a") Then
                Me.rbRESA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "B") Then
                Me.rbREBaja.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "-N") Then
                Me.rbRENorma.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "N") Then
                Me.rbRENormal.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "+N") Then
                Me.rbRENormal2.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "A") Then
                Me.rbREAlto.Checked = True
            End If
            'cantidad
            Me.txCantidadRtEsperado.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(11).Value

            'unidad
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "qq") Then
                Me.rbREQQHA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "ton") Then
                Me.rbRETONHA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "un") Then
                Me.rbREUNHA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "otr") Then
                Me.rbREOtra.Checked = True
            End If

            Me.dtMuestreador.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(13).Value
            Me.cbMuestreador.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(14).Value

            'textura
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "s/a") Then
                Me.rbtexSA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Arn") Then
                Me.rbtexArenosa.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "FAr") Then
                Me.rbtexFcoArenosa.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Frc") Then
                Me.rbtexFranco.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Fll") Then
                Me.rbtexFcoArcillosa.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Arc") Then
                Me.rbtexArcillosa.Checked = True
            End If

            'Profundidad
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "s/a") Then
                Me.rbPASA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "Del") Then
                Me.rbPADelgado.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "Med") Then
                Me.rbPAMedio.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "Pro") Then
                Me.rbPAProfundo.Checked = True
            End If

            'riego
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(17).Value = "s/a") Then
                Me.rbRISA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(17).Value = "Si") Then
                Me.rbRICon.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(17).Value = "No") Then
                Me.rbRINo.Checked = True
            End If

            'Drenaje
            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "s/a") Then
                Me.rbDSA.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Esc") Then
                Me.rbDEscaso.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Imp") Then
                Me.rbDImprefecto.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Bue") Then
                Me.rbDBueno.Checked = True
            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Exc") Then
                Me.rbDExcesivo.Checked = True
            End If


            Me.txObservacion.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(19).Value
            Me.txProfundMuestreo.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(22).Value
            'End If


        Catch ex As Exception
        End Try
    End Sub

    'Private Sub dgDatosArgonomicosSuelo_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosArgonomicosSuelo.CellContentClick
    '    Try
    '        Me.txNot.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(0).Value
    '        If Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(1).Value.ToString <> "" And Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(2).Value.ToString <> "" Then

    '            Me.txIdentificacion1.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(1).Value
    '            Me.txIdentificacion2.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(2).Value
    '            Me.txPredio.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(3).Value
    '            Me.cbLocalidad.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(4).Value
    '            Me.cbCultivoAnterior.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(5).Value

    '            'rto
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "s/a") Then
    '                Me.rbRASA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "B") Then
    '                Me.rbRABaja.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "-N") Then
    '                Me.rbRANorma.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "N") Then
    '                Me.rbRANormal.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "+N") Then
    '                Me.rbRANormal2.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(6).Value = "A") Then
    '                Me.rbRAAlto.Checked = True
    '            End If
    '            'cantidad
    '            Me.txCantidadRtAnterior.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(7).Value

    '            'unidad
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "qq") Then
    '                Me.rbRAQQHA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "ton") Then
    '                Me.rbRATONHA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "un") Then
    '                Me.rbRAUNHA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(8).Value = "otr") Then
    '                Me.rbRAOtra.Checked = True
    '            End If

    '            Me.cbCultivoProximo.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(9).Value

    '            'rto
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "s/a") Then
    '                Me.rbRESA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "B") Then
    '                Me.rbREBaja.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "-N") Then
    '                Me.rbRENorma.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "N") Then
    '                Me.rbRENormal.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "+N") Then
    '                Me.rbRENormal2.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(10).Value = "A") Then
    '                Me.rbREAlto.Checked = True
    '            End If
    '            'cantidad
    '            Me.txCantidadRtEsperado.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(11).Value

    '            'unidad
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "qq") Then
    '                Me.rbREQQHA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "ton") Then
    '                Me.rbRETONHA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "un") Then
    '                Me.rbREUNHA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(12).Value = "otr") Then
    '                Me.rbREOtra.Checked = True
    '            End If

    '            Me.dtMuestreador.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(13).Value
    '            Me.cbMuestreador.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(14).Value

    '            'textura
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "s/a") Then
    '                Me.rbtexSA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Arn") Then
    '                Me.rbtexArenosa.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "FAr") Then
    '                Me.rbtexFcoArenosa.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Frc") Then
    '                Me.rbtexFranco.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Fll") Then
    '                Me.rbtexFcoArcillosa.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(15).Value = "Arc") Then
    '                Me.rbtexArcillosa.Checked = True
    '            End If

    '            'Profundidad
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "s/a") Then
    '                Me.rbPASA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "Del") Then
    '                Me.rbPADelgado.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "Med") Then
    '                Me.rbPAMedio.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(16).Value = "Pro") Then
    '                Me.rbPAProfundo.Checked = True
    '            End If

    '            'riego
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(17).Value = "s/a") Then
    '                Me.rbRISA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(17).Value = "Si") Then
    '                Me.rbRICon.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(17).Value = "No") Then
    '                Me.rbRINo.Checked = True
    '            End If

    '            'Drenaje
    '            If (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "s/a") Then
    '                Me.rbDSA.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Esc") Then
    '                Me.rbDEscaso.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Imp") Then
    '                Me.rbDImprefecto.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Bue") Then
    '                Me.rbDBueno.Checked = True
    '            ElseIf (Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(18).Value = "Exc") Then
    '                Me.rbDExcesivo.Checked = True
    '            End If


    '            Me.txObservacion.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(19).Value
    '            Me.txProfundMuestreo.Text = Me.dgDatosArgonomicosSuelo.Rows(e.RowIndex).Cells.Item(22).Value
    '        End If


    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub chSA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSA.CheckedChanged
        If Me.chSA.Checked = True Then


            Me.rbDSA.Checked = True
            Me.rbPASA.Checked = True
            Me.rbRAOtra.Checked = True
            Me.rbRASA.Checked = True
            Me.rbREOtra.Checked = True
            Me.rbRESA.Checked = True
            Me.rbRISA.Checked = True
            Me.rbtexSA.Checked = True

        Else
            Me.rbDSA.Checked = False
            Me.rbPASA.Checked = False
            Me.rbRAOtra.Checked = False
            Me.rbRASA.Checked = False
            Me.rbREOtra.Checked = False
            Me.rbRESA.Checked = False
            Me.rbRISA.Checked = False
            Me.rbtexSA.Checked = False

        End If

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
            Me.txProfundMuestreo.Focus()
        End If
    End Sub

    Private Sub txProfundMuestreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txProfundMuestreo.KeyPress
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
            Me.cbCultivoAnterior.Focus()
        End If
    End Sub

    Private Sub cbCultivoAnterior_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbCultivoAnterior.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.txCantidadRtAnterior.Focus()
        End If
    End Sub

    Private Sub txCantidadRtAnterior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCantidadRtAnterior.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbCultivoProximo.Focus()
        End If
    End Sub

    Private Sub cbCultivoProximo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbCultivoProximo.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.txCantidadRtEsperado.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As DataGridViewRow
        Dim etiqueta As New Etiquetas.Etiqueta
        For Each fila In Me.dgDatosArgonomicosSuelo.Rows

            etiqueta.Imprimir_Etiqueta1("192.168.0.69", "443", "Agrolab " & Today, "", "N: " & fila.Cells(0).Value.ToString, "") '"Origen: " & vaOrigen, fila.Cells(7).Value.ToString, , fila.Cells(0).Value.ToString)
            'MsgBox("NLab: " & fila.Cells(0).Value.ToString & " Tejido: " & fila.Cells(5).Value.ToString, MsgBoxStyle.Information, "Imprimiendo Etiquetas")
        Next

    End Sub
End Class