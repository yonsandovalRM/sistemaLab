Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Imports System.IO

Public Class F_OrdenTrabajo
    Dim arregloDatosRS(15) As String
    Dim arregloDatosDespacho(30) As String
    Dim vaDato As String
    Dim vaCodigo As Integer
    Dim bandera As Integer
    Dim guardaRegion As String
    Dim XcargoP, XcargoE, XcargoR, XcargoL, XcargoC As String
    Dim DesAna1, DesAna2, DesAna3 As String
    Dim PreAna1, PreAna2, PreAna3 As Integer
    Private Fila_ant As Integer


    Dim con As New SqlConnection(Conexion1)

    Private Sub F_OrdenTrabajo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Tipo_Ingreso_OT = ""
        paso = 0
        Me.Close()
    End Sub

    Private Sub F_OrdenTrabajo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        XcargoP = ""
        XcargoE = ""
        XcargoR = ""
        XcargoL = ""
        XcargoC = ""

        Dim ancho As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim alto As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim nuevoWidth As Integer
        Dim wOT As Integer
        Dim wLOT As Integer
        Dim wNOT As Integer
        Dim fila As DataRow
        reg = 0
        provincia = 0
        comuna = 0
        ciudad = 0
        unir = False
        guardadosAna = ""

        If ancho <> 1280 Then
            wLOT = Me.tbOT.Location.X.ToString
            Me.Width = ancho
            wOT = Me.tbOT.Width
            nuevoWidth = (ancho / 2) - (wOT / 2)
            wLOT = wLOT - nuevoWidth
            wNOT = Me.lblN.Location.X.ToString - wLOT
            ' wLOT = Me.lblLaboratorio.Location.X.ToString - wLOT
            Me.lblN.Location = New System.Drawing.Point(wLOT, 5)
            'Me.lblLaboratorio.Location = New System.Drawing.Point(wNOT, 16)
            Me.tbOT.Location = New System.Drawing.Point(nuevoWidth, 12)

        End If

        If alto <> 1024 Then
            Me.Height = alto
        End If

        Me.lblUsuario.Text = usuarioLG
        lbl_actualizado.Text = usuarioLG

        'llena combo box con regiones
        If Tipo_Ingreso_OT <> "Consulta" Then

            'Call llenaCBRegiones()

            'Call llenaCBProductor()
            'Call llenaCBEmpresa()

            Me.cbIngreso.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("INGRESADORES").Rows
                cbIngreso.Items.Add(fila("ING_NOMBRE"))
            Next

            Me.cbCondPago.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("CONDICION_PAGO").Rows
                Me.cbCondPago.Items.Add(fila("CONP_CODIGO"))
            Next

            '    Me.cbLocalidad.Items.Add("")
            '    For Each fila In Cjto_Tablas1.Tables("LOCALIDAD").Rows
            '        Me.cbLocalidad.Items.Add(fila("LOCALIDAD"))
            '    Next

            '    Me.cbCiudadDespacho.Items.Add("")
            '    For Each fila In Cjto_Tablas1.Tables("CIUDAD").Rows
            '        Me.cbCiudadDespacho.Items.Add(fila("CIUDAD"))
            '    Next

            '    Me.cbCiudadRS.Items.Add("")
            '    For Each fila In Cjto_Tablas1.Tables("CIUDAD").Rows
            '        Me.cbCiudadRS.Items.Add(fila("CIUDAD"))
            '    Next

            '    Me.cbComunaDespacho.Items.Add("")
            '    For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
            '        Me.cbComunaDespacho.Items.Add(fila("COMUNA"))
            '    Next

            '    Me.cbComunaRS.Items.Add("")
            '    For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
            '        Me.cbComunaRS.Items.Add(fila("COMUNA"))
            '    Next

        End If





        If Tipo_Ingreso_OT = "Consulta" Then
            btn_DAOK.Visible = False
            btnIngresaDatAgronomico.Text = "Ver Datos Agronómicos"
            btnIngMuestraDT.Visible = False
            Me.btnGuardar.Visible = True
            Me.btnLimpiaGeneral.Visible = True
            Me.btnIngMuestraDT.Visible = False
            Me.btnAgregaAnalisis.Visible = False
            Me.btnEliminaAnalisis.Visible = True
            Me.btnLimpiarRS.Visible = True
            Me.btnLimpiarDespacho.Visible = True
            Me.btnRestaurarDespacho.Visible = True
            Me.btnRestaurarRS.Visible = True
            Me.btnProductor.Enabled = True
            Me.btnFactura.Enabled = True
            Me.btnCargaProductor.Enabled = True
            Me.btnEmpresaCarga.Enabled = True
            Me.btnBuscaLocalidad.Enabled = True
            Me.btnComunaBusca.Enabled = True
            Me.btnGrabarRe.Enabled = True
            Me.btnAceptarDet.Enabled = True
            Me.btnIrRecibo.Enabled = True

            Me.tbOT.Controls.Remove(Me.tbCodificacion)
            'Me.tbOT.Controls.Remove(Me.tbDetalle)
            Me.Text = "Consulta OT"
            Call llenaOT(Orden_Trabajo_Bus)

        ElseIf Tipo_Ingreso_OT = "Agrega" Then

            Me.Text = "Agrega Análisis OT"
            Me.btnIngMuestraDT.Visible = False
            Creada = 0
            Me.tbOT.Controls.Remove(Me.tbDatosAgronomicos)
            Call llenaOT(Orden_Trabajo_Bus)
            dtFechaIngreso.Text = Today
            Me.tbOT.SelectedTab = tbDetalle

        ElseIf Tipo_Ingreso_OT = "Elimina" Then
            Call llenaOT(Orden_Trabajo_Bus)
        End If

        'Me.tbDatosProductor.Text = "N° OT:  " & Format(lblNot.Text, "##,###") & "    Datos Productor"
        Me.dgFoliar.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(1000, "CFR")

        ' Determinamos el alto de las filas
        dgFoliar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim col As DataGridViewColumn = dgFoliar.Columns(1)
        ' Ajustamos la celda a su contenido.
        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgAgua.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(3000, "CFR")
        ' Determinamos el alto de las filas
        dgAgua.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colAg As DataGridViewColumn = dgAgua.Columns(1)
        ' Ajustamos la celda a su contenido.
        colAg.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colAg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgTejido.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(2000, "CFR")
        ' Determinamos el alto de las filas
        dgTejido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colTej As DataGridViewColumn = dgTejido.Columns(1)
        ' Ajustamos la celda a su contenido.
        colTej.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colTej.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgSuelo.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(4000, "CFR")
        ' Determinamos el alto de las filas
        dgSuelo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim col2 As DataGridViewColumn = dgSuelo.Columns(1)
        ' Ajustamos la celda a su contenido.
        col2.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgKitOtros.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(8000, "CFR")
        ' Determinamos el alto de las filas
        dgKitOtros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colKO As DataGridViewColumn = dgKitOtros.Columns(1)
        ' Ajustamos la celda a su contenido.
        colKO.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colKO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        Me.dgFitopatologia.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(7000, "CFR")
        ' Determinamos el alto de las filas
        dgFitopatologia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colF As DataGridViewColumn = dgFitopatologia.Columns(1)
        ' Ajustamos la celda a su contenido.
        colF.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgFertQui.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(5000, "CFR")
        ' Determinamos el alto de las filas
        dgFertQui.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colFertQ As DataGridViewColumn = dgFertQui.Columns(1)
        ' Ajustamos la celda a su contenido.
        colFertQ.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colFertQ.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgFertOrg.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(6000, "CFR")
        ' Determinamos el alto de las filas
        dgFertOrg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colFertOR As DataGridViewColumn = dgFertOrg.Columns(1)
        ' Ajustamos la celda a su contenido.
        colFertOR.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colFertOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Me.dgUnir.Rows.Clear()
        ' Determinamos el alto de las filas
        dgUnir.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colG As DataGridViewColumn = dgUnir.Columns(1)
        ' Ajustamos la celda a su contenido.
        colG.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        'Me.dgDetalle.Rows.Clear()
        ' Determinamos el alto de las filas
        dgDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colh As DataGridViewColumn = dgDetalle.Columns(1)
        ' Ajustamos la celda a su contenido.
        colh.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        'Me.dgDatosAgronomicos.Rows.Clear()
        ' Determinamos el alto de las filas
        dgDatosAgronomicos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colj As DataGridViewColumn = dgDatosAgronomicos.Columns(1)
        ' Ajustamos la celda a su contenido.
        colj.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        'Me.dgRecibo.Rows.Clear()
        ' Determinamos el alto de las filas
        dgRecibo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim coli As DataGridViewColumn = dgRecibo.Columns(1)
        ' Ajustamos la celda a su contenido.
        coli.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        coli.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill




    End Sub

    Private Sub llenaOT(ByVal orden)
        Try
            Dim cd, cd2 As New CapaDato
            Dim dsOrden, dsorden2 As New DataSet
            Dim dt, dt2 As New DataTable

            cd.Inicializar()
            cd.AgregarParametro("@ot_numero", orden, SqlDbType.Int)
            dsOrden = cd.EjecutarQuery("ls_obtieneDatosOrden")
            dt = dsOrden.Tables(0)

            Try
                cd2.Inicializar()
                cd2.AgregarParametro("@orden", orden, SqlDbType.Int)
                dsorden2 = cd2.EjecutarQuery("ys_ObtieneIngresadoPor")
                dt2 = dsorden2.Tables(0)
            Catch ex As Exception
                Me.lbl_ingresado.Text = "Desconocido"
            End Try


            If dt2.Rows.Count <> 0 Then

                If dt2.Rows(0).Item(0).ToString = "RECEPCION-HP" Then
                    Me.lbl_ingresado.Text = "Constanza S."
                ElseIf dt2.Rows(0).Item(0).ToString = "RECEPCION2-HP" Then
                    Me.lbl_ingresado.Text = "Paola O."
                ElseIf dt2.Rows(0).Item(0).ToString = "HP_ORD_LLANE" Then
                    Me.lbl_ingresado.Text = "Eddy Ll."
                ElseIf dt2.Rows(0).Item(0).ToString = "AGROSERV" Then
                    Me.lbl_ingresado.Text = "Servidor"
                ElseIf dt2.Rows(0).Item(0).ToString = "HPSANDY" Then
                    Me.lbl_ingresado.Text = "Administrador"
                ElseIf dt2.Rows(0).Item(0).ToString = "HP-SR-ROSITA" Then
                    Me.lbl_ingresado.Text = "Sra. Rosita"
                ElseIf dt2.Rows(0).Item(0).ToString = "HP_FIN_CORVR" Then
                    Me.lbl_ingresado.Text = "Rosita C."
                ElseIf dt2.Rows(0).Item(0).ToString = "DESARROLLO" Then
                    Me.lbl_ingresado.Text = "Desarrollo"
                ElseIf dt2.Rows(0).Item(0).ToString = "HP-GER-ESPIA" Then
                    Me.lbl_ingresado.Text = "Antonio E."
                ElseIf dt2.Rows(0).Item(0).ToString = "HP-INFO-SANDY" Then
                    Me.lbl_ingresado.Text = "Administrador"
                End If

            Else
                Me.lbl_ingresado.Text = "Desconocido"
            End If




            Me.lbl_actualizado.Text = dt.Rows(0).Item("digitado").ToString

            Me.lblNot.Text = dt.Rows(0).Item(0).ToString
            Me.tbDatosProductor.Text = "N° OT:  " & lblNot.Text & "    Datos Productor"
            Me.txCotizacion.Text = dt.Rows(0).Item(1).ToString
            Me.dtFechaIngreso.Text = dt.Rows(0).Item(2).ToString
            Me.txRutFactura.Text = dt.Rows(0).Item(3).ToString
            Me.cbProductor.Text = dt.Rows(0).Item(4).ToString
            Me.cbEmpresa.Text = dt.Rows(0).Item(5).ToString
            Me.txPredio.Text = dt.Rows(0).Item(6).ToString
            Me.txDireccion.Text = dt.Rows(0).Item(7).ToString
            Me.cbLocalidad.Text = dt.Rows(0).Item(8).ToString
            Me.cbComuna.Text = dt.Rows(0).Item(9).ToString
            Me.cbCiudad.Text = dt.Rows(0).Item(10).ToString



            If dt.Rows(0).Item(12).ToString <> "" Then
                If dt.Rows(0).Item(12).ToString = "1" Then
                    Me.cbRegionN.Text = "I - Tarapaca"
                    Me.cbRegionN.SelectedValue = 1
                ElseIf dt.Rows(0).Item(12).ToString = "2" Then
                    Me.cbRegionN.Text = "II - Antofagasta"
                    Me.cbRegionN.SelectedValue = 2
                ElseIf dt.Rows(0).Item(12).ToString = "3" Then
                    Me.cbRegionN.Text = "III - Atacama"
                    Me.cbRegionN.SelectedValue = 3
                ElseIf dt.Rows(0).Item(12).ToString = "4" Then
                    Me.cbRegionN.Text = "IV - Coquimbo"
                    Me.cbRegionN.SelectedValue = 4
                ElseIf dt.Rows(0).Item(12).ToString = "5" Then
                    Me.cbRegionN.Text = "V - Valparaiso"
                    Me.cbRegionN.SelectedValue = 5
                ElseIf dt.Rows(0).Item(12).ToString = "6" Then
                    Me.cbRegionN.Text = "VI - Gral.B.O`Higgins"
                    Me.cbRegionN.SelectedValue = 6
                ElseIf dt.Rows(0).Item(12).ToString = "7" Then
                    Me.cbRegionN.Text = "VII - Maule"
                    Me.cbRegionN.SelectedValue = 7
                ElseIf dt.Rows(0).Item(12).ToString = "8" Then
                    Me.cbRegionN.Text = "VIII - Biobio"
                    Me.cbRegionN.SelectedValue = 8
                ElseIf dt.Rows(0).Item(12).ToString = "9" Then
                    Me.cbRegionN.Text = "IX - Araucania"
                    Me.cbRegionN.SelectedValue = 9
                ElseIf dt.Rows(0).Item(12).ToString = "10" Then
                    Me.cbRegionN.Text = "X - De los Lagos"
                    Me.cbRegionN.SelectedValue = 10
                ElseIf dt.Rows(0).Item(12).ToString = "11" Then
                    Me.cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)"
                    Me.cbRegionN.SelectedValue = 11
                ElseIf dt.Rows(0).Item(12).ToString = "12" Then
                    Me.cbRegionN.Text = "XII - Magallanes Y Antartica Ch."
                    Me.cbRegionN.SelectedValue = 12
                ElseIf dt.Rows(0).Item(12).ToString = "13" Then
                    Me.cbRegionN.Text = "XIII - Metropolitana"
                    Me.cbRegionN.SelectedValue = 13
                Else
                    Me.cbRegionN.Text = "Seleccione Region"
                    Me.cbRegionN.SelectedValue = 0

                End If
            End If

            Me.cbProvincia.Text = dt.Rows(0).Item(11).ToString
            Me.txFono1.Text = dt.Rows(0).Item(13).ToString
            Me.txFono2.Text = dt.Rows(0).Item(14).ToString
            Me.txCelular1.Text = dt.Rows(0).Item(15).ToString
            Me.txCelular2.Text = dt.Rows(0).Item(16).ToString
            Me.txFax1.Text = dt.Rows(0).Item(17).ToString
            Me.txFax2.Text = dt.Rows(0).Item(18).ToString
            Me.txEmail1.Text = dt.Rows(0).Item(19).ToString
            Me.txEmail2.Text = dt.Rows(0).Item(20).ToString
            Me.txRutProductor.Text = dt.Rows(0).Item(21).ToString
            Me.txNOC.Text = dt.Rows(0).Item(99).ToString


            Me.txRemite.Text = dt.Rows(0).Item(22).ToString
            Me.txFonoRemite1.Text = dt.Rows(0).Item(23).ToString
            Me.txFonoRemite2.Text = dt.Rows(0).Item(24).ToString
            Me.txCelularRemite1.Text = dt.Rows(0).Item(25).ToString
            Me.txCelularRemite2.Text = dt.Rows(0).Item(26).ToString
            Me.txFaxRemite1.Text = dt.Rows(0).Item(27).ToString
            Me.txFaxRemite2.Text = dt.Rows(0).Item(28).ToString
            Me.txEmailRemite1.Text = dt.Rows(0).Item(29).ToString
            Me.txEmail2Re.Text = dt.Rows(0).Item(30).ToString

            Me.txSolicita.Text = dt.Rows(0).Item(31).ToString
            Me.txFonoSolicita1.Text = dt.Rows(0).Item(32).ToString
            Me.txFonoSolicita2.Text = dt.Rows(0).Item(33).ToString
            Me.txCelularSolicita1.Text = dt.Rows(0).Item(34).ToString
            Me.txCelularSolicita2.Text = dt.Rows(0).Item(35).ToString
            Me.txFaxSolicita1.Text = dt.Rows(0).Item(36).ToString
            Me.txFaxSolicita2.Text = dt.Rows(0).Item(37).ToString
            Me.txEmailSolicita1.Text = dt.Rows(0).Item(38).ToString
            Me.txEmailSolicita2.Text = dt.Rows(0).Item(39).ToString

            Me.txRazonSocial.Text = dt.Rows(0).Item(40).ToString
            Me.txFonoRS1.Text = dt.Rows(0).Item(41).ToString
            Me.txFonoRS2.Text = dt.Rows(0).Item(42).ToString
            Me.txGiro.Text = dt.Rows(0).Item(43).ToString
            Me.txDireccionRS.Text = dt.Rows(0).Item(44).ToString
            Me.cbComunaRS.Text = dt.Rows(0).Item(45).ToString
            Me.cbCiudadRS.Text = dt.Rows(0).Item(46).ToString
            Me.txEncargadoPago.Text = dt.Rows(0).Item(47).ToString
            Me.txFonoPagoRS1.Text = dt.Rows(0).Item(48).ToString
            Me.txFonoPagoRS2.Text = dt.Rows(0).Item(49).ToString
            'Me.txobservacionPago.Text = dt.Rows(0).Item(50).ToString
            Me.txEmailRS1.Text = dt.Rows(0).Item(51).ToString
            Me.txEmailRS2.Text = dt.Rows(0).Item(52).ToString

            If dt.Rows(0).Item(53).ToString = "null" Then
                Me.cbCondPago.Text = ""
            Else
                Me.cbCondPago.Text = dt.Rows(0).Item(53).ToString
            End If

            If dt.Rows(0).Item(54).ToString = "False" Then
                Me.chRetiraLab.Checked = False
            Else
                Me.chRetiraLab.Checked = True
            End If

            If dt.Rows(0).Item(55).ToString = "False" Then
                Me.chAvisaFono.Checked = False
            Else
                Me.chAvisaFono.Checked = True
            End If

            If dt.Rows(0).Item(56).ToString = "False" Then
                Me.chFax.Checked = False
            Else
                Me.chFax.Checked = True
            End If

            If dt.Rows(0).Item(57).ToString = "False" Then
                Me.chEmail.Checked = False
            Else
                Me.chEmail.Checked = True
            End If

            If dt.Rows(0).Item(58).ToString = "False" Then
                Me.chCorreo.Checked = False
            Else
                Me.chCorreo.Checked = True
            End If

            If dt.Rows(0).Item(59).ToString = "False" Then
                Me.chBus.Checked = False
            Else
                Me.chBus.Checked = True
            End If

            If dt.Rows(0).Item(60).ToString = "False" Then
                Me.chOtro.Checked = False
            Else
                Me.chOtro.Checked = True
            End If

            Me.txOtroDespacho.Text = dt.Rows(0).Item(61).ToString

            Me.txSenores.Text = dt.Rows(0).Item(62).ToString
            Me.txAtencion.Text = dt.Rows(0).Item(63).ToString
            Me.txDireccionDespacho.Text = dt.Rows(0).Item(64).ToString
            Me.txCasilla.Text = dt.Rows(0).Item(65).ToString
            Me.cbComunaDespacho.Text = dt.Rows(0).Item(66).ToString
            Me.cbCiudadDespacho.Text = dt.Rows(0).Item(67).ToString
            Me.dtFechaDespacho.Text = dt.Rows(0).Item(68).ToString
            Me.txFonoDespacho1.Text = dt.Rows(0).Item(69).ToString
            Me.txFonoDespacho2.Text = dt.Rows(0).Item(70).ToString

            Me.txCelularDespacho1.Text = dt.Rows(0).Item(71).ToString

            Me.txCelularDespacho2.Text = dt.Rows(0).Item(72).ToString
            Me.txFaxDespacho1.Text = dt.Rows(0).Item(73).ToString
            Me.txFaxDespacho2.Text = dt.Rows(0).Item(74).ToString
            Me.txEmailDespacho1.Text = dt.Rows(0).Item(75).ToString
            Me.txEmailDespacho2.Text = dt.Rows(0).Item(76).ToString
            Me.txObservaciones.Text = dt.Rows(0).Item(77).ToString
            Me.cbIngreso.Text = dt.Rows(0).Item(78).ToString


            Dim dsCod As New DataSet
            Dim dtCod As New DataTable
            Dim muestra As Integer
            Dim tipo As String
            Dim a As Integer
            a = 0

            cd.Inicializar()
            cd.AgregarParametro("@ot_numero", orden, SqlDbType.Int)
            dsCod = cd.EjecutarQuery("ls_obtieneDatosCodificacion")
            dtCod = dsCod.Tables(0)

            Dim c As Integer = dtCod.Rows.Count

            While a < c

                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'codigo
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dtCod.Rows(a).Item(3)
                dgvRow.Cells.Add(dgvCell)

                'muestra
                muestra = dtCod.Rows(a).Item(1)

                If muestra >= 1000 And muestra < 2000 Then
                    tipo = "Foliar"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Foliar"
                    dgvRow.Cells.Add(dgvCell)

                ElseIf muestra >= 2000 And muestra < 3000 Then
                    tipo = "Otros Tejidos"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Otros Tejidos"
                    dgvRow.Cells.Add(dgvCell)

                ElseIf muestra >= 3000 And muestra < 4000 Then
                    tipo = "Agua"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Agua"
                    dgvRow.Cells.Add(dgvCell)

                ElseIf muestra >= 4000 And muestra < 5000 Then
                    tipo = "Suelo"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Suelo"
                    dgvRow.Cells.Add(dgvCell)

                ElseIf muestra >= 5000 And muestra < 6000 Then
                    tipo = "Ferti-Qui"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Ferti-Qui"
                    dgvRow.Cells.Add(dgvCell)

                ElseIf muestra >= 6000 And muestra < 7000 Then
                    tipo = "Ferti-Org"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Ferti-Org"
                    dgvRow.Cells.Add(dgvCell)

                ElseIf muestra >= 7000 And muestra < 8000 Then
                    tipo = "Fitopatologia"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Fitopatologia"
                    dgvRow.Cells.Add(dgvCell)

                ElseIf muestra >= 8000 And muestra < 9000 Then
                    tipo = "Kit,Otros"
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Kit,Otros"
                    dgvRow.Cells.Add(dgvCell)


                End If


                'descripcion
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dtCod.Rows(a).Item(4)
                dgvRow.Cells.Add(dgvCell)

                'lab-desde
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dtCod.Rows(a).Item(2)
                dgvRow.Cells.Add(dgvCell)

                'lab-hasta
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dtCod.Rows(a).Item(6)
                dgvRow.Cells.Add(dgvCell)

                If Tipo_Ingreso_OT = "Consulta" Then
                    Dim dgvRow2 As New DataGridViewRow
                    Dim dgvCell2 As DataGridViewCell

                    'Codigo
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(3)
                    dgvRow2.Cells.Add(dgvCell2)

                    'Tipo
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = tipo.ToString
                    dgvRow2.Cells.Add(dgvCell2)

                    'Descripcion
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(4)
                    dgvRow2.Cells.Add(dgvCell2)

                    'nlabdesde
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(2)
                    dgvRow2.Cells.Add(dgvCell2)

                    'nlabHasta
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(6)
                    dgvRow2.Cells.Add(dgvCell2)

                    'cantidad
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(5)
                    dgvRow2.Cells.Add(dgvCell2)

                    'Estado
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = "C/DA"
                    dgvRow2.Cells.Add(dgvCell2)

                    Me.dgDatosAgronomicos.Rows.Add(dgvRow2)

                    Me.dgDatosAgronomicos.Rows.Item(a).Cells.Item(6).Style.BackColor = System.Drawing.Color.Green

                End If

                If Tipo_Ingreso_OT = "Agrega" Then
                    Dim dgvRow2 As New DataGridViewRow
                    Dim dgvCell2 As DataGridViewCell

                    'Codigo
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(3)
                    dgvRow2.Cells.Add(dgvCell2)

                    'Tipo
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = tipo.ToString
                    dgvRow2.Cells.Add(dgvCell2)

                    'Descripcion
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(4)
                    dgvRow2.Cells.Add(dgvCell2)

                    'nlabdesde
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(2)
                    dgvRow2.Cells.Add(dgvCell2)

                    'nlabHasta
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(6)
                    dgvRow2.Cells.Add(dgvCell2)

                    'cantidad
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = dtCod.Rows(a).Item(5)
                    dgvRow2.Cells.Add(dgvCell2)

                    'Estado
                    dgvCell2 = New DataGridViewTextBoxCell()
                    dgvCell2.Value = "C/DA"
                    dgvRow2.Cells.Add(dgvCell2)

                    Me.dgDatosAgronomicos.Rows.Add(dgvRow2)

                    Me.dgDatosAgronomicos.Rows.Item(a).Cells.Item(6).Style.BackColor = System.Drawing.Color.Green

                    Dim dgvRow3 As New DataGridViewRow
                    Dim dgvCell3 As DataGridViewCell


                    'codigo
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = dtCod.Rows(a).Item(3)
                    dgvRow3.Cells.Add(dgvCell3)

                    'Tipo
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = tipo.ToString
                    dgvRow3.Cells.Add(dgvCell3)

                    'descripcion
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = dtCod.Rows(a).Item(4)
                    dgvRow3.Cells.Add(dgvCell3)

                    'lab-desde
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = dtCod.Rows(a).Item(2)
                    dgvRow3.Cells.Add(dgvCell3)

                    'lab-hasta
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = dtCod.Rows(a).Item(6)
                    dgvRow3.Cells.Add(dgvCell3)

                    'cantidad
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = dtCod.Rows(a).Item(5)
                    dgvRow3.Cells.Add(dgvCell3)

                    'valor
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = dtCod.Rows(a).Item(7)
                    dgvRow3.Cells.Add(dgvCell3)

                    'neto
                    dgvCell3 = New DataGridViewTextBoxCell()
                    dgvCell3.Value = dtCod.Rows(a).Item(8)
                    dgvRow3.Cells.Add(dgvCell3)

                    Me.dgDetalle.Rows.Add(dgvRow3)
                    ' Me.dgDatosAgronomicos.Rows.Add(dgvRow3) '########################3



                End If

                'cantidad
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dtCod.Rows(a).Item(5)
                dgvRow.Cells.Add(dgvCell)

                'valor
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dtCod.Rows(a).Item(7)
                dgvRow.Cells.Add(dgvCell)


                'neto
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = dtCod.Rows(a).Item(8)
                dgvRow.Cells.Add(dgvCell)


                Me.dgRecibo.Rows.Add(dgvRow)

                If Tipo_Ingreso_OT = "Consulta" Then
                    Dim dgvRow6 As New DataGridViewRow
                    Dim dgvCell6 As DataGridViewCell

                    'codigo
                    dgvCell6 = New DataGridViewTextBoxCell()
                    dgvCell6.Value = dtCod.Rows(a).Item(3)
                    dgvRow6.Cells.Add(dgvCell6)

                    'muestra
                    muestra = dtCod.Rows(a).Item(1)

                    If muestra >= 1000 And muestra < 2000 Then
                        tipo = "Foliar"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Foliar"
                        dgvRow6.Cells.Add(dgvCell6)

                    ElseIf muestra >= 2000 And muestra < 3000 Then
                        tipo = "Otros Tejidos"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Otros Tejidos"
                        dgvRow6.Cells.Add(dgvCell6)

                    ElseIf muestra >= 3000 And muestra < 4000 Then
                        tipo = "Agua"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Agua"
                        dgvRow6.Cells.Add(dgvCell6)

                    ElseIf muestra >= 4000 And muestra < 5000 Then
                        tipo = "Suelo"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Suelo"
                        dgvRow6.Cells.Add(dgvCell6)

                    ElseIf muestra >= 5000 And muestra < 6000 Then
                        tipo = "Ferti-Qui"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Ferti-Qui"
                        dgvRow6.Cells.Add(dgvCell6)

                    ElseIf muestra >= 6000 And muestra < 7000 Then
                        tipo = "Ferti-Org"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Ferti-Org"
                        dgvRow6.Cells.Add(dgvCell6)

                    ElseIf muestra >= 7000 And muestra < 8000 Then
                        tipo = "Fitopatologia"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Fitopatologia"
                        dgvRow6.Cells.Add(dgvCell6)

                    ElseIf muestra >= 8000 And muestra < 9000 Then
                        tipo = "Kit,Otros"
                        dgvCell6 = New DataGridViewTextBoxCell()
                        dgvCell6.Value = "Kit,Otros"
                        dgvRow6.Cells.Add(dgvCell6)


                    End If


                    'descripcion
                    dgvCell6 = New DataGridViewTextBoxCell()
                    dgvCell6.Value = dtCod.Rows(a).Item(4)
                    dgvRow6.Cells.Add(dgvCell6)

                    'lab-desde
                    dgvCell6 = New DataGridViewTextBoxCell()
                    dgvCell6.Value = dtCod.Rows(a).Item(2)
                    dgvRow6.Cells.Add(dgvCell6)

                    'lab-hasta
                    dgvCell6 = New DataGridViewTextBoxCell()
                    dgvCell6.Value = dtCod.Rows(a).Item(6)
                    dgvRow6.Cells.Add(dgvCell6)



                    'cantidad
                    dgvCell6 = New DataGridViewTextBoxCell()
                    dgvCell6.Value = dtCod.Rows(a).Item(5)
                    dgvRow6.Cells.Add(dgvCell6)

                    'valor
                    dgvCell6 = New DataGridViewTextBoxCell()
                    dgvCell6.Value = dtCod.Rows(a).Item(7)
                    dgvRow6.Cells.Add(dgvCell6)


                    'neto
                    dgvCell6 = New DataGridViewTextBoxCell()
                    dgvCell6.Value = dtCod.Rows(a).Item(8)
                    dgvRow6.Cells.Add(dgvCell6)

                    Me.dgDetalle.Rows.Add(dgvRow6)
                End If
                a = a + 1
            End While

            Dim t, l, subtotal As Integer
            l = 0
            subtotal = 0
            t = Me.dgRecibo.Rows.Count



            While l < t
                subtotal = CInt(subtotal) + CInt(Me.dgRecibo.Rows.Item(l).Cells.Item(7).Value)
                l = l + 1
            End While
            Me.txAbono.Text = dt.Rows(0).Item("OT_ABONO").ToString

            Me.cbCondPago.Text = dt.Rows(0).Item("OT_FAC_CONDICION_PAGO").ToString

            If dt.Rows(0).Item("OT_ABONOCON").ToString = 2 Then
                Me.chEfectivoRe.Checked = True
            ElseIf dt.Rows(0).Item("OT_ABONOCON").ToString = 1 Then
                Me.chCheque.Checked = True
            End If



            'Me.txSubTotalRe.Text = subtotal
            'Me.txNetoRe.Text = CInt(subtotal + CInt(Me.txMuestreoRe.Text) - CInt(Me.txPorcentajeDescuentoTotalRe.Text))
            'Me.txIvaRe.Text = CInt(CInt(Me.txNetoRe.Text) * 0.19)

            'Dim f, g As Decimal
            'f = Me.txNetoRe.Text
            'g = Me.txIvaRe.Text
            'Me.txTotalRe.Text = f + g

            Me.txSaldo.Text = CInt(Me.txTotalRe.Text) - CInt(Me.txAbono.Text)

            If dt.Rows(0).Item("OT_ESTADO_PAG").ToString = "Can" Then
                Me.chCancelada.Checked = True
                Me.dtCancelada.Text = dt.Rows(0).Item("OT_FECHA_CANCELADA").ToString
                Me.dtCancelada.Visible = True
                Me.dtCancelada.Enabled = False
                Me.txSaldo.Text = "0"
            End If

            txPorcentajeDetalle.Text = dt.Rows(0).Item("OT_DESCUENTOPOR").ToString


            Call BuscaFacturasPendientes(dt.Rows(0).Item(3).ToString)


            Me.txCantidadMuestreo.Text = dt.Rows(0).Item(87).ToString
            Me.txValorMuestreo.Text = dt.Rows(0).Item(88).ToString

            Dim xx, subtotalDetalle As Integer

            xx = 0
            subtotalDetalle = 0

            While xx < Me.dgDetalle.RowCount

                subtotalDetalle = subtotalDetalle + Me.dgDetalle.Rows.Item(xx).Cells.Item(7).Value

                xx = xx + 1
            End While

            Me.txSubTotal.Text = subtotalDetalle

            Me.txMuestreoDet.Text = CInt(Me.txCantidadMuestreo.Text) * CInt(Me.txValorMuestreo.Text)

            Me.txNetoDet.Text = CInt(Me.txSubTotal.Text) + CInt(Me.txMuestreoDet.Text)
            Me.txIvaDet.Text = CInt(CInt(Me.txNetoDet.Text) * 0.19)
            Me.txTotalDet.Text = CInt(Me.txNetoDet.Text) + CInt(Me.txIvaDet.Text)

            If txPorcentajeDetalle.Text <> 0 Then



            End If
            'If Me.txPorcentajeDescuentoRe.Text <> "0" Then
            '    Me.txPorcentajeDescuentoTotalRe.Text = CInt((CInt(Me.txSubTotalRe.Text)) * (CInt(Me.txPorcentajeDescuentoRe.Text) / 100))
            '    Me.txNetoRe.Text = CInt(Me.txMuestreoRe.Text) + CInt(Me.txSubTotalRe.Text) - CInt(Me.txPorcentajeDescuentoTotalRe.Text)
            '    Me.txIvaRe.Text = CInt(CInt(Me.txNetoRe.Text) * 0.19)
            '    Me.txTotalRe.Text = CInt(Me.txNetoRe.Text) + CInt(Me.txIvaRe.Text)
            'Else
            '    Me.txMuestreoRe.Text = CInt(Me.txCantidadRe.Text) * CInt(Me.txValorUnitRe.Text)
            '    Me.txPorcentajeDescuentoRe.Text = Me.txPorcentajeDetalle.Text
            '    Me.txPorcentajeDescuentoTotalRe.Text = Me.txPorcentajeDetalleTotal.Text
            '    Me.txSubTotalRe.Text = txSubTotal.Text
            '    Me.txNetoRe.Text = txNetoDet.Text
            '    Me.txIvaRe.Text = txIvaDet.Text
            '    Me.txTotalRe.Text = txTotalDet.Text
            'End If



            ' RECIBO
            If txPorcentajeDescuentoRe.Text = "" Then
                Me.txPorcentajeDescuentoRe.Text = 0
            Else
                Me.txPorcentajeDescuentoRe.Text = dt.Rows(0).Item("ot_descuentopor").ToString
            End If

            If txSubTotalRe.Text = "" Then
                Me.txSubTotalRe.Text = 0
            Else
                Me.txSubTotalRe.Text = dt.Rows(0).Item("OT_SUBTOTAL").ToString
            End If

            If Me.txCantidadRe.Text = "" Then
                Me.txCantidadRe.Text = 0
            Else
                Me.txCantidadRe.Text = dt.Rows(0).Item("OT_MUESTREO_CANT").ToString
            End If

            If Me.txValorUnitRe.Text = "" Then
                Me.txValorUnitRe.Text = 0
            Else
                Me.txValorUnitRe.Text = dt.Rows(0).Item("OT_MUESTREO_PRECIOUN").ToString
            End If

            If Me.txPorcentajeDescuentoTotalRe.Text = "" Then
                Me.txPorcentajeDescuentoTotalRe.Text = 0
            Else
                Me.txPorcentajeDescuentoTotalRe.Text = dt.Rows(0).Item("OT_DESCUENTOPESOS").ToString
            End If

            If Me.txIvaRe.Text = "" Then
                Me.txIvaRe.Text = 0
            Else
                Me.txIvaRe.Text = dt.Rows(0).Item("OT_IVA").ToString
            End If


            If Me.txNetoRe.Text = "" Then
                Me.txNetoRe.Text = 0
            Else
                Me.txNetoRe.Text = dt.Rows(0).Item("OT_NETO").ToString
            End If

            If Me.txTotalRe.Text = "" Then
                Me.txTotalRe.Text = 0
            Else
                Me.txTotalRe.Text = dt.Rows(0).Item("OT_TOTAL").ToString
            End If
            If Me.txMuestreoRe.Text = "" Then
                Me.txMuestreoRe.Text = 0
            Else
                Me.txMuestreoRe.Text = dt.Rows(0).Item("OT_MUESTREO").ToString
            End If

            ' FIN RECIBO

        Catch ex As Exception
            MsgBox("Se ha producido un error en el sub 'LLenaOT', error: " & ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub BuscaFacturasPendientes(ByVal cadena As String)
        Try
            Dim query, MM, TE As String
            Dim con As New SqlConnection(Conexion1)
            con.Open()
            query = "select OT_ESTADO_ANA, OT_ESTADO_PAG, OT_ESTADO_FAC FROM ORDEN_TRABAJO WHERE OT_FAC_RUT='" & cadena & "'"
            Dim myCommand1 As New SqlCommand(query, con)
            Dim myReader1 As SqlDataReader
            myReader1 = myCommand1.ExecuteReader()
            While myReader1.Read
                Try
                    If IsDBNull(myReader1.GetString(0)) = False And IsDBNull(myReader1.GetString(1)) = False And IsDBNull(myReader1.GetString(2)) = False Then
                        If myReader1.GetString(0) = "xDe" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "xF" Then Me.btnFacPendiente.Visible = True : Exit While
                        If myReader1.GetString(0) = "xDe" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "Fac" Then Me.btnFacPendiente.Visible = True : Exit While
                        If myReader1.GetString(0) = "De" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "xF" Then Me.btnFacPendiente.Visible = True : Exit While
                        If myReader1.GetString(0) = "De" And myReader1.GetString(1) = "Pte" And myReader1.GetString(2) = "Fac" Then Me.btnFacPendiente.Visible = True : Exit While
                    End If
                Catch ex As Exception
                End Try
            End While
            con.Close()
            myReader1.Close()
        Catch ex As Exception
            MsgBox("Se ha producido un error en el sub 'BuscaFacturasPendientes', error: ", ex.Message)
        End Try
    End Sub

    Private Sub llenaCBProductor()
        Try
            Dim cn As New CapaNegocio
            Dim ds As New DataSet
            Dim dt As New DataTable

            ds = cn.ObtieneProductor()
            dt = ds.Tables(0)

            Me.cbProductor.DataSource = dt
            Me.cbProductor.DisplayMember = "nombre"
            Me.cbProductor.ValueMember = "rut"
        Catch ex As Exception
            MsgBox("Se ha producido un error en el sub 'llenaCBProductor', error: ", ex.Message)
        End Try

    End Sub

    Private Sub llenaCBEmpresa()
        Try
            Dim cn As New CapaNegocio
            Dim ds As New DataSet
            Dim dt As New DataTable
            dt.Columns.Add("empresa")
            Dim dr As DataRow

            dr = dt.NewRow()
            dr("empresa") = "Seleccionar Empresa"
            dt.Rows.Add(dr)


            ds = cn.ObtieneEmpresa()
            dt = ds.Tables(0)

            Me.cbEmpresa.DataSource = dt
            Me.cbEmpresa.DisplayMember = "empresa"
            Me.cbEmpresa.ValueMember = "empresa"

        Catch ex As Exception
            MsgBox("Se ha producido un error en el sub 'llenaCBEmpresa', error: ", ex.Message)
        End Try

    End Sub

    Private Sub llenaCBRegiones()

        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = "0"
        dr("Descripcion") = "Seleccione Region "
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "1"
        dr("Descripcion") = "I - Tarapaca"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "2"
        dr("Descripcion") = "II - Antofagasta"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "3"
        dr("Descripcion") = "III - Atacama"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "4"
        dr("Descripcion") = "IV - Coquimbo"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "5"
        dr("Descripcion") = "V - Valparaiso"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "6"
        dr("Descripcion") = "VI - Gral.B.O`Higgins"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "7"
        dr("Descripcion") = "VII - Maule"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "8"
        dr("Descripcion") = "VIII - Biobio"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "9"
        dr("Descripcion") = "IX - Araucania"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "10"
        dr("Descripcion") = "X - De los Lagos"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "11"
        dr("Descripcion") = "XI - Aisen(Gral.C.Ibañez)"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "12"
        dr("Descripcion") = "XII - Magallanes Y Antartica Ch."
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = "13"
        dr("Descripcion") = "XIII - Metropolitana"
        dt.Rows.Add(dr)

        Me.cbRegionN.DataSource = dt
        Me.cbRegionN.ValueMember = "Codigo"
        Me.cbRegionN.DisplayMember = "Descripcion"

        reg = 1

    End Sub

    'Private Sub dgFoliar_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFoliar.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1600") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 1001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 1002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 1003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 1600
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgAgua_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAgua.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3004") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 3001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 3002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 3003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 3004
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgFertOrg_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFertOrg.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6004") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 6001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 6002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 6003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 6004
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgFertQui_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFertQui.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5004") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 5001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 5002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 5003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 5004
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgFitopatologia_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFitopatologia.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7004") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 7001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 7002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 7003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 7004
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgKitOtros_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgKitOtros.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8004") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 8001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 8002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 8003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 8004
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgSuelo_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSuelo.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4004") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 4001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 4002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 4003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 4004
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgTejido_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTejido.CellContentDoubleClick
    '    Try
    '        Dim dg As New DataGridView
    '        Dim dt As New Data.DataTable
    '        Dim dr As Data.DataRow
    '        Dim arr, arr2 As Array
    '        Dim a, b, c, d, i, j, k, l, m, r, s As Integer

    '        Dim descripcion, codigoVar As String
    '        i = 0
    '        j = 0
    '        m = 0
    '        dg = sender
    '        dt = dg.DataSource
    '        dr = dt.Rows(e.RowIndex)

    '        If unir = True Then

    '            If existeFila = False Then

    '                r = Me.dgAsignado.Rows.Count - 1
    '                s = 0
    '                While s < r
    '                    If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2001") Then
    '                        a = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2002") Then
    '                        b = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2003") Then
    '                        c = 1
    '                    ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2004") Then
    '                        d = 1
    '                    End If
    '                    s = s + 1
    '                End While


    '                If a <> 1 Then
    '                    codigoVar = 2001
    '                ElseIf b <> 1 Then
    '                    codigoVar = 2002
    '                ElseIf c <> 1 Then
    '                    codigoVar = 2003
    '                ElseIf d <> 1 Then
    '                    codigoVar = 2004
    '                End If

    '                Dim dgvRow As New DataGridViewRow
    '                Dim dgvCell As DataGridViewCell

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = codigoVar.ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(1).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = ""
    '                dgvRow.Cells.Add(dgvCell)

    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(2).ToString
    '                dgvRow.Cells.Add(dgvCell)


    '                dgvCell = New DataGridViewTextBoxCell()
    '                dgvCell.Value = dr.Item(0).ToString
    '                dgvRow.Cells.Add(dgvCell)

    '                Me.dgUnir.Rows.Add(dgvRow)

    '                existeFila = True

    '            Else
    '                arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
    '                arr2 = Split(dr.Item(1).ToString, "-")
    '                k = arr.Length
    '                l = arr2.Length

    '                While i < l
    '                    While j < k
    '                        If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
    '                            m = 1
    '                            Exit While
    '                        End If
    '                        j = j + 1
    '                    End While
    '                    If m = 0 Then
    '                        descripcion = descripcion & "-" & Trim(arr2(i).ToString)
    '                    End If
    '                    m = 0
    '                    j = 0
    '                    i = i + 1
    '                End While

    '                Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
    '                Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
    '                Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

    '            End If

    '        Else
    '            Dim asigna As New F_AsignaAnalisis
    '            asigna.Owner = Me
    '            asigna.txCodigo.Text = dr.Item(0).ToString
    '            asigna.txDescripcion.Text = dr.Item(1).ToString
    '            asigna.txValor.Text = dr.Item(2).ToString
    '            asigna.txCantidad.Focus()
    '            If Tipo_Ingreso_OT = "Agrega" Then
    '                asigna.txCantidad.Text = cantChKl.ToString
    '                asigna.txCantidad.ReadOnly = True
    '            End If
    '            asigna.Show()
    '        End If

    '    Catch ex As Exception
    '    End Try

    'End Sub

    'Private Sub dgBusqueda_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBusqueda.CellContentDoubleClick
    '    Try

    '        Dim asigna As New F_AsignaAnalisis
    '        asigna.Owner = Me
    '        asigna.txCodigo.Text = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(0).Value
    '        asigna.txDescripcion.Text = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(1).Value
    '        asigna.txValor.Text = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(2).Value
    '        asigna.txCantidad.Focus()
    '        If Tipo_Ingreso_OT = "Agrega" Then
    '            asigna.txCantidad.Text = cantChKl.ToString
    '            asigna.txCantidad.ReadOnly = True
    '        End If
    '        asigna.Show()

    '    Catch ex As Exception
    '    End Try
    'End Sub
    Sub defineDatos()

        If vaDato = "Todos" Then
            Me.dgFoliar.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(1000, "todos")
            Me.dgTejido.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(2000, "todos")
            Me.dgAgua.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(3000, "todos")
            Me.dgSuelo.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(4000, "todos")
            Me.dgFertQui.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(5000, "todos")
            Me.dgFertOrg.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(6000, "todos")
            Me.dgFitopatologia.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(7000, "todos")
            Me.dgKitOtros.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(8000, "todos")
        ElseIf vaDato = "CFR" Then
            Me.dgFoliar.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(1000, "CFR")
            Me.dgTejido.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(2000, "CFR")
            Me.dgAgua.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(3000, "CFR")
            Me.dgSuelo.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(4000, "CFR")
            Me.dgFertQui.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(5000, "CFR")
            Me.dgFertOrg.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(6000, "CFR")
            Me.dgFitopatologia.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(7000, "CFR")
            Me.dgKitOtros.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(8000, "CFR")
        ElseIf vaDato = "CFRCOC" Then
            Me.dgFoliar.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(1000, "CFRCOC")
            Me.dgTejido.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(2000, "CFRCOC")
            Me.dgAgua.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(3000, "CFRCOC")
            Me.dgSuelo.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(4000, "CFRCOC")
            Me.dgFertQui.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(5000, "CFRCOC")
            Me.dgFertOrg.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(6000, "CFRCOC")
            Me.dgFitopatologia.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(7000, "CFRCOC")
            Me.dgKitOtros.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(8000, "CFRCOC")
        ElseIf vaDato = "IFRIOC" Then
            Me.dgFoliar.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(1000, "IFRIOC")
            Me.dgTejido.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(2000, "IFRIOC")
            Me.dgAgua.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(3000, "IFRIOC")
            Me.dgSuelo.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(4000, "IFRIOC")
            Me.dgFertQui.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(5000, "IFRIOC")
            Me.dgFertOrg.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(6000, "IFRIOC")
            Me.dgFitopatologia.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(7000, "IFRIOC")
            Me.dgKitOtros.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(8000, "IFRIOC")
        ElseIf vaDato = "IFR" Then
            Me.dgFoliar.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(1000, "IFR")
            Me.dgTejido.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(2000, "IFR")
            Me.dgAgua.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(3000, "IFR")
            Me.dgSuelo.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(4000, "IFR")
            Me.dgFertQui.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(5000, "IFR")
            Me.dgFertOrg.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(6000, "IFR")
            Me.dgFitopatologia.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(7000, "IFR")
            Me.dgKitOtros.DataSource = Me.Ls_ObtieneAnalisisTableAdapter.GetData(8000, "IFR")
        End If

    End Sub
    Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTodos.CheckedChanged
        vaDato = "Todos"
        defineDatos()

    End Sub

    Private Sub rbCFR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCFR.CheckedChanged
        vaDato = "CFR"
        defineDatos()

    End Sub

    Private Sub rbCFRCOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCFRCOC.CheckedChanged
        vaDato = "CFRCOC"
        defineDatos()
    End Sub

    Private Sub rbIFR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIFR.CheckedChanged
        vaDato = "IFR"
        defineDatos()

    End Sub

    Private Sub rbIFRIOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIFRIOC.CheckedChanged
        vaDato = "IFRIOC"
        defineDatos()

    End Sub

    Private Sub btnBuscarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAnalisis.Click

        Dim codigo As Integer

        If Me.txCodigoB.Text = "" Then
            codigo = 0
        Else
            codigo = Convert.ToInt16(Me.txCodigoB.Text)
        End If

        Me.dgBusqueda.DataSource = Me.Ls_BuscaAnalisisTableAdapter.GetData(codigo, Me.txDescripcionB.Text)

    End Sub

    Private Sub btnProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductor.Click

        Dim productor As New G_Productor
        productor.Owner = Me
        productor.Show()

    End Sub

    Private Sub btnLimpiarRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarRS.Click

        Me.arregloDatosRS(0) = Me.txRazonSocial.Text
        Me.arregloDatosRS(1) = Me.txFonoRS1.Text
        Me.arregloDatosRS(2) = Me.txFonoRS2.Text
        Me.arregloDatosRS(3) = Me.txEmailRS1.Text
        Me.arregloDatosRS(4) = Me.txEmailRS2.Text
        Me.arregloDatosRS(5) = Me.txGiro.Text
        Me.arregloDatosRS(6) = Me.txDireccionRS.Text
        Me.arregloDatosRS(7) = Me.cbCiudadRS.Text
        Me.arregloDatosRS(8) = Me.cbComunaRS.Text
        Me.arregloDatosRS(9) = Me.txEncargadoPago.Text
        Me.arregloDatosRS(10) = Me.txFonoPagoRS1.Text
        Me.arregloDatosRS(11) = Me.txFonoPagoRS2.Text

        Me.txRazonSocial.Clear()
        Me.txFonoRS1.Clear()
        Me.txFonoRS2.Clear()
        Me.txEmailRS1.Clear()
        Me.txEmailRS2.Clear()
        Me.txGiro.Clear()
        Me.txDireccionRS.Clear()
        Me.cbCiudadRS.Text = ""
        Me.cbComunaRS.Text = ""
        Me.txEncargadoPago.Clear()
        Me.txFonoPagoRS1.Clear()
        Me.txFonoPagoRS2.Clear()

    End Sub

    Private Sub btnRestaurarRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurarRS.Click

        If Me.arregloDatosRS(0) <> Nothing Or Me.arregloDatosRS(1) <> Nothing Then
            Me.txRazonSocial.Text = Me.arregloDatosRS(0)
            Me.txFonoRS1.Text = Me.arregloDatosRS(1)
            Me.txFonoRS2.Text = Me.arregloDatosRS(2)
            Me.txEmailRS1.Text = Me.arregloDatosRS(3)
            Me.txEmailRS2.Text = Me.arregloDatosRS(4)
            Me.txGiro.Text = Me.arregloDatosRS(5)
            Me.txDireccionRS.Text = Me.arregloDatosRS(6)
            Me.cbCiudadRS.Text = Me.arregloDatosRS(7)
            Me.cbComunaRS.Text = Me.arregloDatosRS(8)
            Me.txEncargadoPago.Text = Me.arregloDatosRS(9)
            Me.txFonoPagoRS1.Text = Me.arregloDatosRS(10)
            Me.txFonoPagoRS2.Text = Me.arregloDatosRS(11)
        End If

    End Sub

    Private Sub btnLimpiarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarDespacho.Click

        Me.arregloDatosDespacho(0) = Me.txSenores.Text
        Me.arregloDatosDespacho(1) = Me.txOtroDespacho.Text
        Me.arregloDatosDespacho(2) = Me.txCasilla.Text
        Me.arregloDatosDespacho(3) = Me.txFaxDespacho1.Text
        Me.arregloDatosDespacho(4) = Me.txFaxDespacho2.Text
        Me.arregloDatosDespacho(5) = Me.txAtencion.Text
        Me.arregloDatosDespacho(6) = Me.cbCiudadDespacho.Text
        Me.arregloDatosDespacho(7) = Me.txDireccionDespacho.Text
        Me.arregloDatosDespacho(8) = Me.txFonoDespacho1.Text
        Me.arregloDatosDespacho(9) = Me.txFonoDespacho2.Text
        Me.arregloDatosDespacho(10) = Me.txEmailDespacho1.Text
        Me.arregloDatosDespacho(11) = Me.txEmailDespacho2.Text
        Me.arregloDatosDespacho(12) = Me.cbComunaDespacho.Text
        Me.arregloDatosDespacho(13) = Me.txCelularDespacho1.Text
        Me.arregloDatosDespacho(14) = Me.txCelularDespacho2.Text
        Me.arregloDatosDespacho(15) = Me.dtFechaDespacho.Text
        Me.arregloDatosDespacho(16) = Me.chRetiraLab.Checked
        Me.arregloDatosDespacho(17) = Me.chAvisaFono.Checked
        Me.arregloDatosDespacho(18) = Me.chBus.Checked
        Me.arregloDatosDespacho(19) = Me.chCorreo.Checked
        Me.arregloDatosDespacho(20) = Me.chEmail.Checked
        Me.arregloDatosDespacho(21) = Me.chFax.Checked
        Me.arregloDatosDespacho(22) = Me.chOtro.Checked
        Me.arregloDatosDespacho(23) = Me.chUrgente.Checked

        Me.txSenores.Clear()
        Me.txOtroDespacho.Clear()
        Me.txCasilla.Clear()
        Me.txFaxDespacho1.Clear()
        Me.txFaxDespacho2.Clear()
        Me.txAtencion.Clear()
        Me.cbCiudadDespacho.Text = ""
        Me.txDireccionDespacho.Clear()
        Me.txFonoDespacho1.Clear()
        Me.txFonoDespacho2.Clear()
        Me.txEmailDespacho1.Clear()
        Me.txEmailDespacho2.Clear()
        Me.cbComunaDespacho.Text = ""
        Me.txCelularDespacho1.Clear()
        Me.txCelularDespacho2.Clear()
        Me.dtFechaDespacho.Text = ""

        Me.chRetiraLab.Checked = False
        Me.chAvisaFono.Checked = False
        Me.chBus.Checked = False
        Me.chCorreo.Checked = False
        Me.chEmail.Checked = False
        Me.chFax.Checked = False
        Me.chOtro.Checked = False
        Me.chUrgente.Checked = False

    End Sub

    Private Sub btnRestaurarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurarDespacho.Click

        If Me.arregloDatosDespacho(0) <> Nothing Or Me.arregloDatosDespacho(1) <> Nothing Then

            Me.txSenores.Text = Me.arregloDatosDespacho(0)
            Me.txOtroDespacho.Text = Me.arregloDatosDespacho(1)
            Me.txCasilla.Text = Me.arregloDatosDespacho(2)
            Me.txFaxDespacho1.Text = Me.arregloDatosDespacho(3)
            Me.txFaxDespacho2.Text = Me.arregloDatosDespacho(4)
            Me.txAtencion.Text = Me.arregloDatosDespacho(5)
            Me.cbCiudadDespacho.Text = Me.arregloDatosDespacho(6)
            Me.txDireccionDespacho.Text = Me.arregloDatosDespacho(7)
            Me.txFonoDespacho1.Text = Me.arregloDatosDespacho(8)
            Me.txFonoDespacho2.Text = Me.arregloDatosDespacho(9)
            Me.txEmailDespacho1.Text = Me.arregloDatosDespacho(10)
            Me.txEmailDespacho2.Text = Me.arregloDatosDespacho(11)
            Me.cbComunaDespacho.Text = Me.arregloDatosDespacho(12)
            Me.txCelularDespacho1.Text = Me.arregloDatosDespacho(13)
            Me.txCelularDespacho2.Text = Me.arregloDatosDespacho(14)
            Me.dtFechaDespacho.Text = Me.arregloDatosDespacho(15)
            Me.chRetiraLab.Checked = Me.arregloDatosDespacho(16)
            Me.chAvisaFono.Checked = Me.arregloDatosDespacho(17)
            Me.chBus.Checked = Me.arregloDatosDespacho(18)
            Me.chCorreo.Checked = Me.arregloDatosDespacho(19)
            Me.chEmail.Checked = Me.arregloDatosDespacho(20)
            Me.chFax.Checked = Me.arregloDatosDespacho(21)
            Me.chOtro.Checked = Me.arregloDatosDespacho(22)
            Me.chUrgente.Checked = Me.arregloDatosDespacho(23)
        End If
    End Sub

    Private Sub btnLimpiaGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiaGeneral.Click
        Dim i = 0
        While i < 25
            arregloDatosDespacho(i) = ""

            If i < 15 Then
                arregloDatosRS(i) = ""
            End If
            i = i + 1
        End While

        'limpiar controles de productor
        Me.txRutProductor.Clear()
        Me.cbProductor.Text = ""
        Me.txDireccion.Clear()
        Me.cbEmpresa.Text = ""
        Me.txPredio.Clear()
        Me.cbLocalidad.Text = ""
        Me.cbComuna.Text = ""
        Me.cbCiudad.Text = ""
        Me.cbProvincia.Text = ""
        Me.cbRegionN.Text = ""
        Me.txFono1.Clear()
        Me.txFono2.Clear()
        Me.txCelular1.Clear()
        Me.txCelular2.Clear()
        Me.txFax1.Clear()
        'ot.txFax2.Text = dr.Item(15).ToString
        Me.txEmail1.Clear()
        Me.txEmail2.Clear()
        Me.txSolicita.Clear()
        Me.txFonoSolicita1.Clear()
        Me.txFonoSolicita2.Clear()
        Me.txCelularSolicita1.Clear()
        Me.txCelularSolicita2.Clear()
        Me.txFaxSolicita1.Clear()
        Me.txFaxSolicita2.Clear()
        Me.txEmailSolicita1.Clear()
        Me.txEmailSolicita2.Clear()
        Me.txRemite.Clear()
        Me.txFonoRemite1.Clear()
        Me.txFonoRemite2.Clear()
        Me.txCelularRemite1.Clear()
        Me.txCelularRemite2.Clear()
        Me.txFaxRemite1.Clear()
        Me.txFaxRemite2.Clear()
        Me.txEmailRemite1.Clear()
        Me.txEmail2Re.Clear()
        Me.txRutFactura.Clear()

        'limpiar controles de razon social

        Me.txRazonSocial.Clear()
        Me.txFonoRS1.Clear()
        Me.txFonoRS2.Clear()
        Me.txEmailRS1.Clear()
        Me.txEmailRS2.Clear()
        Me.txGiro.Clear()
        Me.txDireccionRS.Clear()
        Me.cbCiudadRS.Text = ""
        Me.cbComunaRS.Text = ""
        Me.txEncargadoPago.Clear()
        Me.txFonoPagoRS1.Clear()
        Me.txFonoPagoRS2.Clear()

        'limpiar controles de despacho

        Me.txSenores.Clear()
        Me.txOtroDespacho.Clear()
        Me.txCasilla.Clear()
        Me.txFaxDespacho1.Clear()
        Me.txFaxDespacho2.Clear()
        Me.txAtencion.Clear()
        Me.cbCiudadDespacho.Text = ""
        Me.txDireccionDespacho.Clear()
        Me.txFonoDespacho1.Clear()
        Me.txFonoDespacho2.Clear()
        Me.txEmailDespacho1.Clear()
        Me.txEmailDespacho2.Clear()

        Me.cbComunaDespacho.Text = ""
        Me.txCelularDespacho1.Clear()
        Me.txCelularDespacho2.Clear()
        Me.dtFechaDespacho.Text = ""

        Me.chRetiraLab.Checked = False
        Me.chAvisaFono.Checked = False
        Me.chBus.Checked = False
        Me.chCorreo.Checked = False
        Me.chEmail.Checked = False
        Me.chFax.Checked = False
        Me.chOtro.Checked = False
        Me.chUrgente.Checked = False

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ' Try
        Dim cn As New CapaNegocio
        Dim numeroOT As String
        Dim ordenTrabajoD As Integer
        Dim i As Integer
        i = 0
        Dim cd As New CapaDato
        Dim dsFac As New DataSet

        cd.Inicializar()
        cd.AgregarParametro("@rut", Me.txRutFactura.Text, SqlDbType.NVarChar)
        dsFac = cd.EjecutarQuery("ls_obtieneFacPendienteProd")
        If dsFac.Tables(0).Rows.Count <> 0 Then
            Me.btnFacPendiente.Visible = True
        End If

        If Tipo_Ingreso_OT = "Agrega" Then
            GoTo agrega
        End If
        If Me.cbProductor.Text = "Seleccione" Then
            Me.ErrorNCotizacion.SetError(Me.cbProductor, "Debe seleccionar o digitar un productor")
            i = i + 1
        ElseIf Trim(Me.cbProductor.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbProductor, "Debe seleccionar o digitar un productor")
            i = i + 1
        Else
            Me.ErrorNCotizacion.SetError(Me.cbProductor, Nothing)
        End If
        '-----------------------------------------------------------------------
        If Me.cbLocalidad.Text = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbLocalidad, "Debe seleccionar una localidad")
            i = i + 1
        ElseIf Trim(Me.cbLocalidad.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbLocalidad, "Debe seleccionar una localidad")
            i = i + 1
        Else
            Me.ErrorNCotizacion.SetError(Me.cbLocalidad, Nothing)
        End If
        '-----------------------------------------------------------------------
        If Me.cbComuna.Text = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbComuna, "Debe seleccionar una comuna")
            i = i + 1
        ElseIf Trim(Me.cbComuna.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbComuna, "Debe seleccionar una comuna")
            i = i + 1
        Else
            Me.ErrorNCotizacion.SetError(Me.cbComuna, Nothing)
        End If
        '-----------------------------------------------------------------------
        'If Me.cbCiudad.Text = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.cbCiudad, "Debe seleccionar una ciudad")
        '    i = i + 1
        'ElseIf Trim(Me.cbCiudad.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.cbCiudad, "Debe seleccionar una ciudad")
        '    i = i + 1
        'Else
        '    Me.ErrorNCotizacion.SetError(Me.cbCiudad, Nothing)
        'End If
        '-----------------------------------------------------------------------
        If Me.cbProvincia.Text = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbProvincia, "Debe seleccionar una ciudad")
            i = i + 1
        ElseIf Trim(Me.cbProvincia.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbProvincia, "Debe seleccionar una provincia")
            i = i + 1
        Else
            Me.ErrorNCotizacion.SetError(Me.cbProvincia, Nothing)
        End If

        '-----------------------------------------------------------------------

        'If Trim(Me.cbEmpresa.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.cbEmpresa, "Debe seleccionar o digitar una empresa")
        '    i = i + 1
        'Else
        '    Me.ErrorNCotizacion.SetError(Me.cbEmpresa, Nothing)
        'End If

        If Trim(Me.txRutProductor.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txRutProductor, "Debe ingresar el rut del productor")
            i = i + 1
        Else
            Me.ErrorNCotizacion.SetError(Me.txRutProductor, Nothing)
        End If
        '-----------------------------------------------------------------------
        If Trim(Me.txRutProductor.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txRutProductor, "Debe ingresar el rut del productor")
            i = i + 1
        Else
            Me.ErrorNCotizacion.SetError(Me.txRutProductor, Nothing)
        End If
        '_______________________________________________________________________
        'If Trim(Me.txEmail1.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.txEmail1, "Debe ingresar un email para el productor ")
        '    i = i + 1
        'Else
        '    Me.ErrorNCotizacion.SetError(Me.txEmail1, Nothing)
        'End If
        '______________________________________________________________________

        '______________________________________________________________________

        'If Trim(Me.txCelular1.Text) = "" And Trim(Me.txFono1.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.txCelular1, "Debe ingresar un Número de celular o fax para el productor ")
        '    Me.ErrorNCotizacion.SetError(Me.txFono1, "Debe ingresar un Número de Fax o celular para el productor ")
        '    i = i + 1
        '    'ElseIf Not IsNumeric(Me.txCelular1.Text) Then
        '    '    Me.ErrorNCotizacion.SetError(Me.txCelular1, "Debe digitar un valor numerico")
        '    '    i = i + 1
        'Else
        '    Me.ErrorNCotizacion.SetError(Me.txCelular1, Nothing)
        '    Me.ErrorNCotizacion.SetError(Me.txFono1, Nothing)
        'End If
        '_____________________________________________________________________________

        'If Trim(Me.txFax1.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.txFax1, "Debe ingresar una Número de fax para el productor ")
        '    i = i + 1
        '    'ElseIf Not IsNumeric(Me.txFax1.Text) Then
        '    '    Me.ErrorNCotizacion.SetError(Me.txFax1, "Debe digitar un valor numerico")
        '    '    i = i + 1
        'Else
        '    Me.ErrorNCotizacion.SetError(Me.txFax1, Nothing)
        'End If
        '________________________________________________________________________________________

        If Trim(Me.txSolicita.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txSolicita, "Debe ingresar el nombre de quien solicita el análisis ")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.txSolicita, Nothing)
        End If
        '_____________________________________________________________________

        'If Trim(Me.txEmailSolicita1.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.txEmailSolicita1, "Debe ingresar un E-mail ")
        '    i = i + 1

        'Else
        '    Me.ErrorNCotizacion.SetError(Me.txEmailSolicita1, Nothing)
        'End If
        ''_______________________________________________________________________

        If Trim(Me.txRemite.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txRemite, "Debe ingresar el remitente que envio el análisis ")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.txRemite, Nothing)
        End If
        '_______________________________________________________________________

        'If Trim(Me.txEmailRemite1.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.txEmailRemite1, "Debe ingresar un E-mail ")
        '    i = i + 1

        'Else
        '    Me.ErrorNCotizacion.SetError(Me.txEmailRemite1, Nothing)
        'End If
        '_______________________________________________________________________

        If Trim(Me.txRazonSocial.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txRazonSocial, "Debe ingresar una razón social ")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.txRazonSocial, Nothing)
        End If
        '_______________________________________________________________________

        'If Trim(Me.cbCiudadRS.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.cbCiudadRS, "Debe seleccionar o digitar una ciudad ")
        '    i = i + 1

        'Else
        '    Me.ErrorNCotizacion.SetError(Me.cbCiudadRS, Nothing)
        'End If
        ''_______________________________________________________________________

        If Trim(Me.cbComuna.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbComuna, "Debe seleccionar o digitar una comuna")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.cbComuna, Nothing)
        End If
        '_______________________________________________________________________

        If Trim(Me.txSenores.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txSenores, "Debe ingresar un nombre ")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.txSenores, Nothing)
        End If
        '_______________________________________________________________________

        If Trim(Me.cbComunaDespacho.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.cbComunaDespacho, "Debe seleccionar o digitar una comuna")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.cbComunaDespacho, Nothing)
        End If
        ' _______________________________________________________________________()

        'If Trim(Me.cbCiudadDespacho.Text) = "" Then
        '    Me.ErrorNCotizacion.SetError(Me.cbCiudadDespacho, "Debe seleccionar o digitar una ciudad")
        '    i = i + 1
        'Else
        '    Me.ErrorNCotizacion.SetError(Me.cbCiudadDespacho, Nothing)
        'End If
        '_______________________________________________________________________

        If Trim(Me.cbRegionN.Text) = "Seleccione Region" Then
            Me.ErrorNCotizacion.SetError(Me.cbRegionN, "Debe seleccionar una región válida")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.cbRegionN, Nothing)
        End If
        '_______________________________________________________________________

        If Trim(Me.txGiro.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txGiro, "Debe ingresar el giro de la empresa")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.txGiro, Nothing)
        End If
        '_______________________________________________________________________

        If Trim(Me.txEmailDespacho1.Text) = "" Then
            Me.ErrorNCotizacion.SetError(Me.txEmailDespacho1, "Debe ingresar un E-mail para el despacho")
            i = i + 1

        Else
            Me.ErrorNCotizacion.SetError(Me.txEmailDespacho1, Nothing)
        End If
        '_______________________________________________________________________

        If i = 0 Then

agrega:
            Dim chRet, chFax, chAF, chEmail, chOtro, chCorreo, chBus, chUrgente As String

            If Me.chRetiraLab.Checked = False Then
                chRet = "0"
            Else
                chRet = "1"
            End If
            If Me.chUrgente.Checked = False Then
                chUrgente = "0"
            Else
                chUrgente = "1"
            End If
            If Me.chOtro.Checked = False Then
                chOtro = "0"
            Else
                chOtro = "1"
            End If
            If Me.chFax.Checked = False Then
                chFax = "0"
            Else
                chFax = "1"
            End If
            If Me.chEmail.Checked = False Then
                chEmail = "0"
            Else
                chEmail = "1"
            End If
            If Me.chCorreo.Checked = False Then
                chCorreo = "0"
            Else
                chCorreo = "1"
            End If
            If Me.chBus.Checked = False Then
                chBus = "0"
            Else
                chBus = "1"
            End If
            If Me.chAvisaFono.Checked = False Then
                chAF = "0"
            Else
                chAF = "1"
            End If

            If Me.lblNot.Text = "No Asignada" Then
                ordenTrabajoD = 0
            Else
                ordenTrabajoD = CInt(Me.lblNot.Text)
                Me.tbDatosProductor.Text = "N° OT:  " & lblNot.Text & "    Datos Productor"
            End If

            Dim SP As New CapaDato
            Dim ds As DataSet = New DataSet
            Dim EstAna, EstPag, EstFac As String

            'EstAna = "xA"
            'EstPag = "Pte"
            'EstFac = "xF"

            ' Dim cd As New CapaDato
            With SP
                .AgregarParametro("@NumOt", CInt(ordenTrabajoD), SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectEstadosOrden")
                Try
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_ESTADO_ANA")) = False Then
                        EstAna = ds.Tables(0).Rows(0).Item("OT_ESTADO_ANA")
                    Else
                        EstAna = "xA"
                    End If
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_ESTADO_PAG")) = False Then
                        EstPag = ds.Tables(0).Rows(0).Item("OT_ESTADO_PAG")
                    Else
                        EstPag = "Pte"
                    End If
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_ESTADO_FAC")) = False Then
                        EstFac = ds.Tables(0).Rows(0).Item("OT_ESTADO_FAC")
                    Else
                        EstFac = "xF"
                    End If

                    If EstAna = "" Then
                        EstAna = "xA"
                    End If

                    If EstPag = "" Then
                        EstPag = "Pte"
                    End If
                    If EstFac = "" Then
                        EstFac = "xF"
                    End If
                Catch ex As Exception
                    EstAna = "xA"
                    EstPag = "Pte"
                    EstFac = "xF"
                End Try

            End With

            'If EstAna = "Ing" Then EstAna = "xA"
            'If EstPag = "Ing" Then EstPag = "Pte"
            'If EstFac = "Ing" Then EstFac = "xF"


            If txAbono.Text <> 0 Then
                If EstPag = "Pte" Then
                    If Me.txTotalRe.Text = txAbono.Text Then
                        EstPag = "Can"
                    Else
                        EstPag = "Abo"
                    End If
                Else
                    EstPag = "Pte"
                End If
            End If

            If Me.chCancelada.Checked = True Then
                EstPag = "Can"
            End If




            Dim query, estn As String
            Dim BB As Boolean
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            ' MsgBox("La region es " & Me.cbRegionN.SelectedValue)
            'Dim guardaRegion As String
            If cbRegionN.Text = "I - Tarapaca" Then
                guardaRegion = 1
            ElseIf cbRegionN.Text = "II - Antofagasta" Then
                guardaRegion = 2
            ElseIf cbRegionN.Text = "III - Atacama" Then
                guardaRegion = 3
            ElseIf cbRegionN.Text = "IV - Coquimbo" Then
                guardaRegion = 4
            ElseIf cbRegionN.Text = "V - Valparaiso" Then
                guardaRegion = 5
            ElseIf cbRegionN.Text = "VI - Gral.B.O`Higgins" Then
                guardaRegion = 6
            ElseIf cbRegionN.Text = "VII - Maule" Then
                guardaRegion = 7
            ElseIf cbRegionN.Text = "VIII - Biobio" Then
                guardaRegion = 8
            ElseIf cbRegionN.Text = "IX - Araucania" Then
                guardaRegion = 9
            ElseIf cbRegionN.Text = "X - De los Lagos" Then
                guardaRegion = 10
            ElseIf cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)" Then
                guardaRegion = 11
            ElseIf cbRegionN.Text = "XII - Magallanes Y Antartica Ch." Then
                guardaRegion = 12
            ElseIf cbRegionN.Text = "XIII - Metropolitana" Then
                guardaRegion = 13
            ElseIf cbRegionN.Text = "Seleccione Region" Then
                guardaRegion = 0
            End If

            Dim vaProvincia, vaRegion As String
            Dim ds2 As DataSet = New DataSet
            vaProvincia = Me.cbProvincia.Text

            Dim SP2 As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP2
                .Inicializar()
                .AgregarParametro("@provincia", vaProvincia, SqlDbType.NVarChar)
                ds2 = .EjecutarQuery("ys_ValidaProvincia")
            End With


            If ds2.Tables(0).Rows(0).Item(0).ToString <> guardaRegion Then
                MsgBox("La provincia no corresponde a la región seleccionada")
            Else






                'MsgBox(Me.cbEmpresa.Text)
                numeroOT = cn.GuardaOTFinalInicio(ordenTrabajoD, Me.txCotizacion.Text, txNOC.Text, Me.dtFechaIngreso.Text, Me.txRutProductor.Text, Me.txRutFactura.Text, Me.cbProductor.Text, _
                     Me.txDireccion.Text, Me.cbEmpresa.Text, Me.txPredio.Text, Me.cbLocalidad.Text, Me.cbComuna.Text, Me.cbCiudad.Text, _
                     Me.cbProvincia.Text, guardaRegion, Me.txFono1.Text, Me.txFono2.Text, Me.txCelular1.Text, Me.txCelular2.Text, Me.txFax1.Text, Me.txFax2.Text, Me.txEmail1.Text, _
                     Me.txEmail2.Text, Me.txSolicita.Text, Me.txFonoSolicita1.Text, Me.txFonoSolicita2.Text, Me.txCelularSolicita1.Text, Me.txCelularSolicita2.Text, _
                     Me.txFaxSolicita1.Text, Me.txFaxSolicita2.Text, Me.txEmailSolicita1.Text, Me.txEmailSolicita2.Text, Me.txRemite.Text, Me.txFonoRemite1.Text, _
                     Me.txFonoRemite2.Text, Me.txCelularRemite1.Text, Me.txCelularRemite2.Text, Me.txFaxRemite1.Text, Me.txFaxRemite2.Text, Me.txEmailRemite1.Text, _
                     Me.txEmail2Re.Text, Me.txSenores.Text, Me.txOtroDespacho.Text, Me.txCasilla.Text, Me.txFaxDespacho1.Text, Me.txFaxDespacho2.Text, Me.txAtencion.Text, _
                     Me.cbCiudadDespacho.Text, Me.txDireccionDespacho.Text, Me.txFonoDespacho1.Text, Me.txFonoDespacho2.Text, Me.txEmailDespacho1.Text, Me.txEmailDespacho2.Text, _
                     Me.cbComunaDespacho.Text, Me.txCelularDespacho1.Text, Me.txCelularDespacho2.Text, Me.dtFechaDespacho.Text, Me.chRetiraLab.Checked, _
                     Me.chAvisaFono.Checked, Me.chBus.Checked, Me.chCorreo.Checked, Me.chEmail.Checked, Me.chFax.Checked, Me.chOtro.Checked, Me.chUrgente.Checked, _
                     Me.txRazonSocial.Text, Me.txFonoRS1.Text, Me.txFonoRS2.Text, Me.txEmailRS1.Text, Me.txEmailRS2.Text, Me.txGiro.Text, Me.txDireccionRS.Text, _
                     Me.cbCiudadRS.Text, Me.cbComunaRS.Text, Me.txEncargadoPago.Text, Me.txFonoPagoRS1.Text, Me.txFonoPagoRS2.Text, Me.cbIngreso.Text, _
                     Me.txObservaciones.Text, Me.lblAviso.Text, Me.txSubTotalRe.Text, Me.txNetoRe.Text, Me.txIvaRe.Text, _
                     Me.txPorcentajeDescuentoRe.Text, Me.txPorcentajeDescuentoTotalRe.Text, Me.txCantidadMuestreo.Text, Me.txValorUnitRe.Text, Me.txMuestreoRe.Text, _
                     Me.txAbono.Text, Me.txTotalRe.Text, Me.chCheque.Checked, Me.chEfectivoRe.Checked, Me.cbCondPago.Text, EstAna, EstPag, EstFac)


                '            query = "execute ls_IngresoOrdenTrabajo '" & ordenTrabajoD & "','" & Me.txCotizacion.Text & "','" & Me.dtFechaIngreso.Text & "','" & Me.txRutFactura.Text & "','" & Me.txRutProductor.Text & "','" & Me.cbProductor.Text & "','" & _
                '                   Me.cbEmpresa.Text & "','" & Me.txPredio.Text & "','" & Me.txDireccion.Text & "','" & Me.cbLocalidad.Text & "','" & Me.cbComuna.Text & "','" & Me.cbCiudad.Text & "','" & _
                '                  Me.cbProvincia.Text & "','" & Me.cbRegionN.SelectedValue & "','" & Me.txFono1.Text & "','" & Me.txFono2.Text & "','" & Me.txCelular1.Text & "','" & Me.txCelular2.Text & "','" & Me.txFax1.Text & "','" & Me.txFax2.Text & "','" & Me.txEmail1.Text & "','" & _
                '                  Me.txEmail2.Text & "','" & Me.txRemite.Text & "','" & Me.txFonoRemite1.Text & "','" & Me.txFonoRemite2.Text & "','" & Me.txCelularRemite1.Text & "','" & Me.txCelularRemite2.Text & "','" & Me.txFaxRemite1.Text & "','" & Me.txFaxRemite2.Text & "','" & Me.txEmailRemite1.Text & "','" & _
                '                  Me.txEmail2Re.Text & "','" & Me.txSolicita.Text & "','" & Me.txFonoSolicita1.Text & "','" & Me.txFonoSolicita2.Text & "','" & Me.txCelularSolicita1.Text & "','" & Me.txCelularSolicita2.Text & "','" & _
                '                  Me.txFaxSolicita1.Text & "','" & Me.txFaxSolicita2.Text & "','" & Me.txEmailSolicita1.Text & "','" & Me.txEmailSolicita2.Text & "','" & _
                '                  Me.txRazonSocial.Text & "','" & Me.txFonoRS1.Text & "','" & Me.txFonoRS2.Text & "','" & Me.txGiro.Text & "','" & Me.txDireccionRS.Text & "','" & _
                '                  Me.cbComunaRS.Text & "','" & Me.cbCiudadRS.Text & "','" & Me.txEncargadoPago.Text & "','" & Me.txFonoPagoRS1.Text & "','" & Me.txFonoPagoRS2.Text & "','" & Me.txObservaciones.Text & "','" & Me.txEmailRS1.Text & "','" & Me.txEmailRS2.Text & "','" & _
                'chRet & "','" & chAF & "','" & chFax & "','" & chEmail & "','" & chCorreo & "','" & chBus & "','" & chOtro & "','" & _
                'Me.txOtroDespacho.Text & "','" & Me.txSenores.Text & "','" & Me.txAtencion.Text & "','" & Me.txDireccionDespacho.Text & "','" & Me.txCasilla.Text & "','" & _
                'Me.cbComunaDespacho.Text & "','" & Me.cbCiudadDespacho.Text & "','" & Me.dtFechaDespacho.Text & "','" & Me.txFonoDespacho1.Text & "','" & Me.txFonoDespacho2.Text & "','" & _
                'Me.txCelularDespacho1.Text & "','" & Me.txCelularDespacho2.Text & "','" & Me.txFaxDespacho1.Text & "','" & Me.txFaxDespacho2.Text & "','" & _
                '  Me.txEmailDespacho1.Text & "','" & Me.txEmailDespacho2.Text & "','" & usuarioLG & "','" & Date.Today & "','" & _
                ' chUrgente & "','" & Me.cbIngreso.Text & "','xA','Pte','xF','" & Me.txNOC.Text & "'"
                '            Dim myCommand7 As New SqlCommand(query, con)
                '            Dim myReader7 As SqlDataReader

                '            myReader7 = myCommand7.ExecuteReader()
                '            myReader7.Read()
                '            numeroOT = myReader7.Item(0).ToString
                '            myReader7.Close()
                '            con.Close()
                If Me.lblNot.Text = "No Asignada" Then
                    Me.lblNot.Text = numeroOT.ToString()
                    Orden_Trabajo = numeroOT
                    MsgBox("Orden Grabada : " & numeroOT.ToString & "", MsgBoxStyle.Information)
                    Me.tbDatosProductor.Text = "N° OT:  " & lblNot.Text & "    Datos Productor"
                    Me.tbOT.SelectedTab = tbOT.TabPages(0)
                Else
                    MsgBox("Orden Grabada ", MsgBoxStyle.Information)
                    Me.tbDatosProductor.Text = "N° OT:  " & lblNot.Text & "    Datos Productor"
                    Me.tbOT.SelectedTab = tbOT.TabPages(1)
                End If
                If Me.btnFacPendiente.Visible = False Then
                    Me.tbOT.SelectedTab = tbOT.TabPages(1)
                End If

            End If ' fin del if region no pertenece a comuna

        ElseIf i <> 0 Then
            If MsgBox("¿Desea generar N° de Orden sin completar los datos requeridos?", MsgBoxStyle.YesNo, "Generando...") = MsgBoxResult.Yes Then
                GoTo agrega
            End If

        End If

        ' Catch ex As Exception
        'con.Close()
        '  MsgBox("Se ha producido un error en el sub 'GuardaOT', error: " & ex.Message, MsgBoxStyle.Information)

        '   End Try

    End Sub

    Private Sub tbDatosAgronomicos_Enter(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim i, j As Integer

        j = Me.dgDatosAgronomicos.Rows.Count

        While i < j
            If Me.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Value.ToString = "S/DA" Then
                Me.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Style.BackColor = System.Drawing.Color.Red
            Else
                Me.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Style.BackColor = System.Drawing.Color.Blue
            End If
            i = i + 1
        End While

    End Sub

    Private Sub btnAceptarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarAnalisis.Click

        ' Determinamos el alto de las filas
        dgRecibo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colF As DataGridViewColumn = dgRecibo.Columns(1)
        ' Ajustamos la celda a su contenido.
        colF.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' Determinamos el alto de las filas
        dgDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colD As DataGridViewColumn = dgDetalle.Columns(1)
        ' Ajustamos la celda a su contenido.
        colD.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill





        'Try
        Dim dsAnalisis As New Data.DataSet
        Dim i, r, a, j, k, sumaValores, b, entraAnalisis As Integer
        Dim ind, anacod As String
        Dim cd As New CapaDato
        Dim nueva As Integer

        nueva = 0

        entraAnalisis = 0

        If Trim(Me.lblNot.Text) = "No Asignada" Then
            MsgBox("Debe ingresar un productor para generar el Numero de OT.", MsgBoxStyle.Information)
            tbOT.SelectedTab = tbOT.TabPages(0)
            Exit Sub
        Else
            '    cd.Inicializar()
            '   cd.AgregarParametro("@ot", CInt(Me.lblNot.Text), SqlDbType.Int)
            '  cd.EjecutarQuery("ls_borraNlabsGenera")

        End If

        ind = ""
        j = 0
        k = 0
        a = Me.dgAsignado.Rows.Count - 1
        'While (j < a)
        '    While (k < a)
        '        If Mid(Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value, 1, 1) <> Mid(Me.dgAsignado.Rows.Item(k).Cells.Item(0).Value, 1, 1) Then
        '            MsgBox("No se pueden generar los N° de laboratorio para dos análisis de distinto tipo.", MsgBoxStyle.Critical)
        '            Exit Sub

        '        End If
        '        k = k + 1
        '    End While
        '    k = 0
        '    j = j + 1
        'End While

        Dim nLab, nLabDesde, nLabHasta, cantidad, valor, neto, codigo As Integer
        Dim descripcion As String

        While j < a

            codigo = Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value

            If codigo >= 1000 And codigo < 2000 Then
                analisisVar = 1000
            ElseIf codigo >= 2000 And codigo < 3000 Then
                analisisVar = 2000
            ElseIf codigo >= 3000 And codigo < 4000 Then
                analisisVar = 3000
            ElseIf codigo >= 4000 And codigo < 5000 Then
                analisisVar = 4000
            ElseIf codigo >= 5000 And codigo < 6000 Then
                analisisVar = 5000
            ElseIf codigo >= 6000 And codigo < 7000 Then
                analisisVar = 6000
            ElseIf codigo = 7302 Then
                analisisVar = 7302
            ElseIf codigo = 7304 Then
                analisisVar = 7304
            ElseIf codigo = 7306 Then
                analisisVar = 7306
            ElseIf codigo = 7308 Then
                analisisVar = 7308
                'ElseIf codigo = 7314 Then
                '    analisisVar = 7314
                'ElseIf codigo = 7316 Then
                '    analisisVar = 7316
            ElseIf codigo = 8758 Then
                analisisVar = 8758
            ElseIf codigo = 8702 Or codigo = 8704 Or codigo = 8706 Or codigo = 8710 Then
                analisisVar = 8700
            ElseIf codigo >= 7000 And codigo < 8000 Then
                analisisVar = 7000
            ElseIf codigo >= 8000 And codigo < 9000 Then
                analisisVar = 8000
            End If




            ' el ultimo numero ingresado en la tabla le agrego 1 mas
            Dim cn As New CapaNegocio
            Dim x, entrada, countAgrega As Integer
            countAgrega = 0

            If Tipo_Ingreso_OT = "Agrega" Then

                'If entraAnalisis = 0 Then
                '    Me.dgRecibo.Rows.Clear()
                '    entraAnalisis = 1
                'End If

                'entrada = 0
                'For x = 0 To chListaDeNlab.Items.Count - 1
                '    If entrada = 0 And chListaDeNlab.GetItemCheckState(x) = CheckState.Checked Then
                '        Ant_NLabDesde = CInt(Mid(chListaDeNlab.Items(x), 21, 6).TrimEnd(" "))
                '        entrada = 1
                '    End If
                '    If chListaDeNlab.GetItemCheckState(x) = CheckState.Checked Then countAgrega = countAgrega + 1
                '    Ant_NLabHasta = CInt(Mid(chListaDeNlab.Items(x), 21, 6).TrimEnd(" "))
                '    If chListaDeNlab.GetItemCheckState(x) = CheckState.Unchecked And entrada = 1 Then
                '        entrada = 0
                '        TxtLabD1.Text = Ant_NLabDesde
                '        TxtLabH1.Text = Ant_NLabHasta - 1
                '        'txtCant1.Text = CStr(countAgrega)
                '        Call GrabaOTCodificacion()
                '        Call GrabaDigitaResultados()
                '        Call GrabaPlanillaPlani()
                '        Call GrabaAntecedentesAnteriores()
                '        countAgrega = 0
                '    End If
                'Next
                'If entrada = 1 Then
                '    TxtLabD1.Text = Ant_NLabDesde
                '    TxtLabH1.Text = Ant_NLabHasta
                '    txtCant1.Text = CStr(countAgrega)
                '    Call GrabaOTCodificacion()
                '    Call GrabaDigitaResultados()
                '    Call GrabaPlanillaPlani()
                '    Call GrabaAntecedentesAnteriores()
                'End If
                ''txtCant1.Text = CStr(CantReal)
                'MsgBox("Los datos fueron cargados al Recibo")


                If entraAnalisis = 0 Then
                    Me.dgRecibo.Rows.Clear()
                    entraAnalisis = 1
                End If


                For x = 0 To Me.chListaDeNlab.Items.Count - 1
                    If entrada = 0 And chListaDeNlab.GetItemCheckState(x) = CheckState.Checked Then
                        nLabDesde = CInt(Mid(chListaDeNlab.Items(x), 1, 7).TrimEnd(" "))
                        entrada = 0




                        countAgrega = countAgrega + 1

                    End If
                    Me.agregaAnalisis(codigo, nLabDesde, j)
                Next

                GoTo fin

                cn.reservaNlabDatoAgronomico(CInt(analisisVar), CInt(Me.lblNot.Text), CInt(i))

            Else

                Dim dsNl As New DataSet
                cd.Inicializar()
                cd.AgregarParametro("@ot", CInt(Me.lblNot.Text), SqlDbType.Int)
                cd.AgregarParametro("@tmu", analisisVar, SqlDbType.Int)
                dsNl = cd.EjecutarQuery("ls_selectNlabsGenera")

                If dsNl.Tables(0).Rows.Count = 0 Then
                    nLab = cn.NumeroLaboratorio(analisisVar)
                    nLabDesde = nLab + 1

                    cd.Inicializar()
                    cd.AgregarParametro("@ot", CInt(Me.lblNot.Text), SqlDbType.Int)
                    cd.AgregarParametro("@tmu", analisisVar, SqlDbType.Int)
                    cd.AgregarParametro("@desde", nLabDesde, SqlDbType.Int)
                    cd.AgregarParametro("@cantidad", CInt(Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value), SqlDbType.Int)
                    cd.EjecutarQuery("ls_ingresaNlabsGenera")

                    nueva = 1

                Else
                    Dim cuenta As Integer
                    Dim Xhasta As Integer

                    If nueva = 0 Then

                        cuenta = 0
                        nLab = cn.NumeroLaboratorio(analisisVar)



                        'r = Me.dgDetalle.Rows.Count
                        'While cuenta < r

                        '    Xhasta = CInt(Me.dgDetalle.Rows.Item(cuenta).Cells.Item(4).Value)
                        '    If Xhasta > nLab Then
                        '        nLab = Xhasta
                        '    End If
                        '    cuenta = cuenta + 1
                        'End While
                        ''nLab = cn.NumeroLaboratorio(analisisVar)

                        nLabDesde = nLab + 1

                        cd.Inicializar()
                        cd.AgregarParametro("@ot", CInt(Me.lblNot.Text), SqlDbType.Int)
                        cd.AgregarParametro("@tmu", analisisVar, SqlDbType.Int)
                        cd.AgregarParametro("@desde", nLabDesde, SqlDbType.Int)
                        cd.AgregarParametro("@cantidad", CInt(Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value), SqlDbType.Int)
                        cd.EjecutarQuery("ls_ingresaNlabsGenera")
                        nueva = 1
                    Else

                        'nLabDesde = CInt(dsNl.Tables(0).Rows.Item(0).Item(2))
                    End If
                    ' nLabDesde = CInt(dsNl.Tables(0).Rows.Item(0).Item(2))


                End If

            End If


            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value
            dgvRow.Cells.Add(dgvCell)

            If codigo >= 1000 And codigo < 2000 Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Foliar"
                dgvRow.Cells.Add(dgvCell)
                ' analisisVar = 1000

            ElseIf codigo >= 2000 And codigo < 3000 Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Otros Tejidos"
                dgvRow.Cells.Add(dgvCell)
                ' analisisVar = 2000

            ElseIf codigo >= 3000 And codigo < 4000 Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Agua"
                dgvRow.Cells.Add(dgvCell)
                '  analisisVar = 3000

            ElseIf codigo >= 4000 And codigo < 5000 Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Suelo"
                dgvRow.Cells.Add(dgvCell)
                ' analisisVar = 4000

            ElseIf codigo >= 5000 And codigo < 6000 Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Ferti-Qui"
                dgvRow.Cells.Add(dgvCell)
                'analisisVar = 5000

            ElseIf codigo >= 6000 And codigo < 7000 Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Ferti-Org"
                dgvRow.Cells.Add(dgvCell)
                ' analisisVar = 6000

            ElseIf codigo >= 7000 And codigo < 8000 Then

                If (codigo = 7302) Then
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Fitopatologia"
                    dgvRow.Cells.Add(dgvCell)
                ElseIf (codigo = 7304) Then
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Resistencia"
                    dgvRow.Cells.Add(dgvCell)
                ElseIf (codigo = 7306) Then
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Evaluación"
                    dgvRow.Cells.Add(dgvCell)
                ElseIf (codigo = 7314) Then
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Fitopatologia"
                    dgvRow.Cells.Add(dgvCell)
                ElseIf (codigo = 7316) Then
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Fitopatologia"
                    dgvRow.Cells.Add(dgvCell)
                ElseIf (codigo = 7308) Then
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Monitoreo"
                    dgvRow.Cells.Add(dgvCell)
                End If

            ElseIf codigo >= 8000 And codigo < 9000 Then

                If (codigo = 8700) Then 'yemas
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Yemas"
                    dgvRow.Cells.Add(dgvCell)
                ElseIf (codigo = 8758) Then 'nematodos
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Nematodos"
                    dgvRow.Cells.Add(dgvCell)
                Else
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "Kit,Otros"
                    dgvRow.Cells.Add(dgvCell)
                End If




            End If

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgAsignado.Rows.Item(j).Cells.Item(1).Value
            dgvRow.Cells.Add(dgvCell)


            'la cantidad + el valor del lab inicio
            nLabHasta = (nLabDesde - 1) + Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = nLabDesde
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = nLabHasta
            dgvRow.Cells.Add(dgvCell)

            descripcion = Me.dgAsignado.Rows.Item(j).Cells.Item(1).Value
            cantidad = Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value
            valor = Me.dgAsignado.Rows.Item(j).Cells.Item(3).Value
            neto = Me.dgAsignado.Rows.Item(j).Cells.Item(3).Value * Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgAsignado.Rows.Item(j).Cells.Item(3).Value
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value * Me.dgAsignado.Rows.Item(j).Cells.Item(3).Value
            dgvRow.Cells.Add(dgvCell)

            sumaValores = sumaValores + (Me.dgAsignado.Rows.Item(j).Cells.Item(3).Value * Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value)

            If Tipo_Ingreso_OT = "Agrega" Then
                Me.dgRecibo.Rows.Add(dgvRow)
            Else
                Me.dgDetalle.Rows.Add(dgvRow)
            End If

            cn.ReservaNlab(Me.lblNot.Text, analisisVar, codigo, descripcion, nLabDesde, nLabHasta, cantidad, valor, neto)
            Call GrabaDigitaResultados(CInt(Me.lblNot.Text), CInt(nLabDesde), CInt(nLabHasta), Me.dgAsignado.Rows.Item(j).Cells.Item(4).Value.ToString, Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value.ToString)
            If analisisVar = 3000 Then
                Call GrabaPlanillaPlani(CInt(Me.lblNot.Text), CInt(nLabDesde), CInt(nLabHasta), Me.dgAsignado.Rows.Item(j).Cells.Item(4).Value.ToString, Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value.ToString)
            End If

            i = nLabDesde
            While i < nLabHasta + 1

                cn.reservaNlabDatoAgronomico(CInt(analisisVar), CInt(Me.lblNot.Text), CInt(i))
                i = i + 1
            End While


fin:

            j = j + 1

        End While


        Dim cns As New CapaNegocio
        Dim xs, entradas As Integer
        If Tipo_Ingreso_OT = "Agrega" Then
            For xs = 0 To Me.chListaDeNlab.Items.Count - 1
                If chListaDeNlab.GetItemCheckState(xs) = CheckState.Checked Then
                    nLabDesde = CInt(Mid(chListaDeNlab.Items(xs), 1, 7).TrimEnd(" "))
                    cns.copiaDatosAgronomicos(CInt(analisisVar), CInt(Me.lblNot.Text), nLabDesde)

                End If

            Next
        End If

        ' Me.nLabDesde.Text = nLab + 1
        'Me.nLabHasta.Text = nLabHasta

        Me.txPorcentajeDetalleTotal.Text = 0
        Me.txSubTotal.Text = sumaValores
        Me.txMuestreoDet.Text = 0
        Me.txNetoDet.Text = sumaValores + CInt(Me.txMuestreoDet.Text) - CInt(Me.txPorcentajeDetalleTotal.Text)
        Me.txIvaDet.Text = CInt(CInt(Me.txNetoDet.Text) * 0.19)

        Dim f, g As Decimal
        f = Me.txNetoDet.Text
        g = Me.txIvaDet.Text
        Me.txTotalDet.Text = CInt(f + g)

        If codigo >= 8000 And codigo < 9000 Then

            If (codigo = 8700) Then 'yemas

            ElseIf (codigo = 8758) Then 'nematodos

            Else
                'aqui
                Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
                Dim Nu As Integer
                For Nu = nLabDesde To nLabHasta
                    With SP
                        .Inicializar()
                        .AgregarParametro("@TMuestra", 8000, SqlDbType.Int)
                        .AgregarParametro("@NumOT", Orden_Trabajo, SqlDbType.Int)
                        .AgregarParametro("@NumLab", Nu, SqlDbType.Int)
                        .EjecutarEscalar("usp_GrabaAntecedentes")
                    End With
                Next
            End If
        End If

        '#########################RECALCULA
        Dim suma, p As Integer

        p = 0
        suma = 0
        r = Me.dgDetalle.Rows.Count
        While p < r

            suma = suma + CInt(Me.dgDetalle.Rows.Item(p).Cells.Item(7).Value)
            p = p + 1
        End While

        Me.txSubTotal.Text = suma
        Me.txPorcentajeDetalleTotal.Text = CInt((CInt(Me.txSubTotal.Text)) * (CInt(Me.txPorcentajeDetalle.Text) / 100))
        Me.txNetoDet.Text = CInt(Me.txSubTotal.Text) + CInt(Me.txMuestreoDet.Text) - CInt(Me.txPorcentajeDetalleTotal.Text)
        Me.txIvaDet.Text = CInt(CInt(Me.txNetoDet.Text) * 0.19)
        Me.txTotalDet.Text = CInt(Me.txNetoDet.Text) + CInt(Me.txIvaDet.Text)
        '#########################RECALCULA


        dgAsignado.Rows.Clear()
        If Tipo_Ingreso_OT = "Agrega" Then
            tbOT.SelectedTab = tbOT.TabPages(3)

        Else
            tbOT.SelectedTab = tbOT.TabPages(2)


        End If

        'btnAceptarDet_Click(sender, e)



        'Catch ex As Exception
        '    'MsgBox("Se ha producido un error al generar el número de laboratorio', error: ", ex.Message, MsgBoxStyle.Information)
        'End Try


    End Sub
    Private Sub GrabaDigitaResultados()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()
            .AgregarParametro("@NumOT", lblNot.Text, SqlDbType.Int)
            .AgregarParametro("@NlabDesde", CInt(TxtLabD1.Text), SqlDbType.Int)
            .AgregarParametro("@NlabHasta", CInt(TxtLabH1.Text), SqlDbType.Int)
            .AgregarParametro("@CMuestra1", CDbl(Txt1Muestra1.Text), SqlDbType.Float)
            .AgregarParametro("@CMuestra2", CDbl(Txt2Muestra1.Text), SqlDbType.Float)
            .AgregarParametro("@CMuestra3", CDbl(Txt3Muestra1.Text), SqlDbType.Float)
            .AgregarParametro("@JoCodigos1", "", SqlDbType.NVarChar)
            .AgregarParametro("@JoCodigos2", "", SqlDbType.NVarChar)
            .AgregarParametro("@JoCodigos3", "", SqlDbType.NVarChar)
            .EjecutarEscalar("usp_GrabaDigitaResultados")
        End With
    End Sub 'este
    Private Sub GrabaAntecedentesAnteriores()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", Muestra, SqlDbType.Int)
            .AgregarParametro("@NumOTSeleccionada", Orden_Trabajo_Bus, SqlDbType.Int)
            .AgregarParametro("@NumOTNueva", Me.lblNot.Text, SqlDbType.Int)
            .AgregarParametro("@NlabDesde", CInt(TxtLabD1.Text), SqlDbType.Int)
            .AgregarParametro("@NlabHasta", CInt(TxtLabH1.Text), SqlDbType.Int)
            .EjecutarEscalar("usp_GrabaAntecedentesAnteriores")
        End With
    End Sub 'este
    Private Sub GrabaPlanillaPlani()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        If Mid(CStr(Txt1Muestra1.Text), 1, 1) = "3" Then
            With SP
                .Inicializar()
                .AgregarParametro("@NumOT", lblNot.Text, SqlDbType.Int)
                .AgregarParametro("@NlabDesde", CInt(TxtLabD1.Text), SqlDbType.Int)
                .AgregarParametro("@NlabHasta", CInt(TxtLabH1.Text), SqlDbType.Int)
                .AgregarParametro("@CMuestra1", CDbl(Txt1Muestra1.Text), SqlDbType.Float)
                .AgregarParametro("@CMuestra2", CDbl(Txt2Muestra1.Text), SqlDbType.Float)
                .AgregarParametro("@CMuestra3", CDbl(Txt3Muestra1.Text), SqlDbType.Float)
                .AgregarParametro("@JoCodigos1", "", SqlDbType.NVarChar)
                .AgregarParametro("@JoCodigos2", "", SqlDbType.NVarChar)
                .AgregarParametro("@JoCodigos3", "", SqlDbType.NVarChar)
                .EjecutarEscalar("usp_GrabaPlanillaPlani")
            End With
        End If
    End Sub 'este
    Private Sub GrabaOTCodificacion()
        Dim Neto1, Neto2, Neto3, Retorno As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim fila As DataRow
        Retorno = 0

        If Txt1Muestra1.Text = "" Then
            Txt1Muestra1.Text = 0
            DesAna1 = ""
            PreAna1 = 0
        End If

        If Txt2Muestra1.Text = "" Then
            Txt2Muestra1.Text = 0
            DesAna2 = ""
            PreAna2 = 0
        End If

        If Txt3Muestra1.Text = "" Then
            Txt3Muestra1.Text = 0
            DesAna3 = ""
            PreAna3 = 0
        End If

        Neto1 = PreAna1 * CInt(txtCant1.Text)
        Neto2 = PreAna2 * CInt(txtCant1.Text)
        Neto3 = PreAna3 * CInt(txtCant1.Text)

        With SP
            .Inicializar()
            .AgregarParametro("@NumOT", CInt(lblNot.Text), SqlDbType.Int)
            .AgregarParametro("@CAnalisis", Muestra, SqlDbType.Int)
            .AgregarParametro("@NlabDesde", CInt(TxtLabD1.Text), SqlDbType.Int)
            .AgregarParametro("@NlabHasta", CInt(TxtLabH1.Text), SqlDbType.Int)
            .AgregarParametro("@Analisis1", DesAna1, SqlDbType.Text)
            .AgregarParametro("@Analisis2", DesAna2, SqlDbType.Text)
            .AgregarParametro("@Analisis3", DesAna3, SqlDbType.Text)
            .AgregarParametro("@Cantidad", CInt(txtCant1.Text), SqlDbType.Int)
            .AgregarParametro("@PrecioUni1", CInt(PreAna1), SqlDbType.Int)
            .AgregarParametro("@PrecioUni2", CInt(PreAna2), SqlDbType.Int)
            .AgregarParametro("@PrecioUni3", CInt(PreAna3), SqlDbType.Int)
            .AgregarParametro("@PrecioNet1", Neto1, SqlDbType.Int)
            .AgregarParametro("@PrecioNet2", Neto2, SqlDbType.Int)
            .AgregarParametro("@PrecioNet3", Neto3, SqlDbType.Int)
            .AgregarParametro("@CMuestra1", CDbl(Txt1Muestra1.Text), SqlDbType.Float)
            .AgregarParametro("@CMuestra2", CDbl(Txt2Muestra1.Text), SqlDbType.Float)
            .AgregarParametro("@CMuestra3", CDbl(Txt3Muestra1.Text), SqlDbType.Float)
            Retorno = .EjecutarEscalar("usp_GrabaCodificacion")

            If Tipo_Ingreso_OT <> "Agrega" Then Cjto_Orden1.Tables("OT_CODIFICACION").Clear()

            .Inicializar()
            .AgregarParametro("@NumOT", CInt(lblNot.Text), SqlDbType.Int)

            If Tipo_Ingreso_OT <> "Agrega" Then
                .EjecutarQueryDt("usp_SelectCodificacion", Cjto_Orden1, "OT_CODIFICACION")
                Call Calcula_Valores_Detalle()
            Else
                .EjecutarQueryDt("usp_SelectCodificacion", Cjto_Orden1, "OT_CODIFICACION_RECIBO")
                Call Calcula_Valores_Recibo()
            End If

        End With

    End Sub 'este
    Private Sub Calcula_Valores_Detalle()
        Dim ObjSum As Object
        Dim SubTotal As Integer
        Dim RESTA, Csubtotal, TotalDesct, CNeto, CMuestreo, Cabono, CDesctPesos, CSaldo, CDesct As Integer
        Dim Cdescuento, RestaSub As Double
        ObjSum = Cjto_Orden1.Tables("OT_CODIFICACION").Compute("Sum(OTC_PRECIONET)", "OTC_PRECIONET > 0")
        Try
            SubTotal = CInt(ObjSum)
        Catch ex As Exception

        End Try


        If txMuestreoDet.Text <> "" Then CMuestreo = CInt(txMuestreoDet.Text) Else CMuestreo = 0
        SubTotal = SubTotal

        If txPorcentajeDetalle.Text <> "" Then Cdescuento = CDbl(Me.txPorcentajeDetalle.Text) Else Cdescuento = 0
        If txPorcentajeDetalleTotal.Text <> "" Then CDesctPesos = CDbl(Me.txPorcentajeDetalleTotal.Text) Else CDesctPesos = 0

        If CDesctPesos <> 0 And Cdescuento = 0 Then
            If SubTotal <> 0 Then
                RestaSub = CDesctPesos / SubTotal
                Cdescuento = Format((RestaSub * 100), "##.##")
                txPorcentajeDetalleTotal.Text = Format(CInt(CDesctPesos), "###,###")
                txPorcentajeDetalle.Text = Format(Cdescuento, "##.##")
            End If
        End If

        If CDesctPesos = 0 And Cdescuento <> 0 Then
            txPorcentajeDetalle.Text = Format(Cdescuento, "##.##")
            CDesctPesos = (SubTotal * CDbl(Cdescuento / 100))
            txPorcentajeDetalleTotal.Text = Format(CInt(CDesctPesos), "###,###")
        End If

        txMuestreoDet.Text = Format(CMuestreo, "####,##0")
        CNeto = SubTotal - CDesctPesos + CMuestreo

        txSubTotal.Text = Format(SubTotal, "####,##0")
        txNetoDet.Text = Format(CNeto, "####,##0")
        txIvaDet.Text = Format((CNeto * (Pa_Iva / 100)), "####,##0")
        txTotalDet.Text = Format(CNeto + CInt(txIvaDet.Text), "####,##0")
    End Sub 'este
    Private Sub Calcula_Valores_Recibo()
        Dim ObjSum As Object
        Dim SubTotal As Integer
        Dim RESTA, Csubtotal, TotalDesct, CNeto, CMuestreo, Cabono, CDesctPesos, CSaldo, CDesct As Integer
        Dim Cdescuento, RestaSub As Double

        ObjSum = Cjto_Orden1.Tables("OT_CODIFICACION_RECIBO").Compute("Sum(OTC_PRECIONET)", "OTC_PRECIONET > 0")

        Try
            SubTotal = CInt(ObjSum)
        Catch ex As Exception
        End Try

        If txMuestreoRe.Text <> "" Then CMuestreo = CInt(txMuestreoRe.Text) Else CMuestreo = 0
        SubTotal = SubTotal
        If txAbono.Text <> "" Then Cabono = CDbl(Me.txAbono.Text) Else Cabono = 0

        If txPorcentajeDescuentoRe.Text <> "" Then Cdescuento = CDbl(Me.txPorcentajeDescuentoRe.Text) Else Cdescuento = 0
        If txPorcentajeDescuentoTotalRe.Text <> "" Then CDesctPesos = CDbl(Me.txPorcentajeDescuentoTotalRe.Text) Else CDesctPesos = 0

        If CDesctPesos <> 0 And Cdescuento = 0 Then
            If SubTotal <> 0 Then
                RestaSub = CDesctPesos / SubTotal
                Cdescuento = Format((RestaSub * 100), "##.##")
                txPorcentajeDescuentoTotalRe.Text = Format(CInt(CDesctPesos), "###,###")
                txPorcentajeDescuentoRe.Text = Format(Cdescuento, "##.##")
            End If
        End If

        If CDesctPesos = 0 And Cdescuento <> 0 Then
            txPorcentajeDescuentoRe.Text = Format(Cdescuento, "##.##")
            CDesctPesos = (SubTotal * CDbl(Cdescuento / 100))
            txPorcentajeDescuentoTotalRe.Text = Format(CInt(CDesctPesos), "###,###")
        End If

        txAbono.Text = Format(Cabono, "####,##0")
        txMuestreoRe.Text = Format(CMuestreo, "####,##0")
        CNeto = SubTotal - CDesctPesos + CMuestreo

        txSubTotalRe.Text = Format(SubTotal, "####,##0")
        txNetoRe.Text = Format(CNeto, "####,##0")
        txIvaRe.Text = Format((CNeto * (Pa_Iva / 100)), "####,##0")
        txTotalRe.Text = Format(CNeto + CInt(txIvaRe.Text), "####,##0")
        CSaldo = CInt(txTotalRe.Text) - CInt(txAbono.Text)
        txSaldo.Text = Format(CSaldo, "####,##0")
    End Sub 'este

    Public Sub agregaAnalisis(ByVal codigo As Integer, ByVal nlab As Integer, ByVal j As Integer)

        Dim cn As New CapaNegocio
        Dim descripcion As String
        Dim valorA, netoA As Integer


        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value
        dgvRow.Cells.Add(dgvCell)

        If codigo >= 1000 And codigo < 2000 Then
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "Foliar"
            dgvRow.Cells.Add(dgvCell)
            ' analisisVar = 1000

        ElseIf codigo >= 2000 And codigo < 3000 Then
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "Otros Tejidos"
            dgvRow.Cells.Add(dgvCell)
            ' analisisVar = 2000

        ElseIf codigo >= 3000 And codigo < 4000 Then
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "Agua"
            dgvRow.Cells.Add(dgvCell)
            '  analisisVar = 3000

        ElseIf codigo >= 4000 And codigo < 5000 Then
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "Suelo"
            dgvRow.Cells.Add(dgvCell)
            ' analisisVar = 4000

        ElseIf codigo >= 5000 And codigo < 6000 Then
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "Ferti-Qui"
            dgvRow.Cells.Add(dgvCell)
            'analisisVar = 5000

        ElseIf codigo >= 6000 And codigo < 7000 Then
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "Ferti-Org"
            dgvRow.Cells.Add(dgvCell)
            ' analisisVar = 6000

        ElseIf codigo >= 7000 And codigo < 8000 Then

            If (codigo = 7302) Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Fitopatologia"
                dgvRow.Cells.Add(dgvCell)
            ElseIf (codigo = 7304) Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Resistencia"
                dgvRow.Cells.Add(dgvCell)
            ElseIf (codigo = 7306) Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Evaluación"
                dgvRow.Cells.Add(dgvCell)
            ElseIf (codigo = 7308) Then
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Monitoreo"
                dgvRow.Cells.Add(dgvCell)
            End If

        ElseIf codigo >= 8000 And codigo < 9000 Then

            If (codigo = 8700) Then 'yemas
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Yemas"
                dgvRow.Cells.Add(dgvCell)
            ElseIf (codigo = 8758) Then 'nematodos
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Nematodos"
                dgvRow.Cells.Add(dgvCell)
            Else
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Kit,Otros"
                dgvRow.Cells.Add(dgvCell)
            End If




        End If

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgAsignado.Rows.Item(j).Cells.Item(1).Value
        dgvRow.Cells.Add(dgvCell)

        descripcion = Me.dgAsignado.Rows.Item(j).Cells.Item(1).Value
        'la cantidad + el valor del lab inicio

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = nlab
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = nlab
        dgvRow.Cells.Add(dgvCell)

        descripcion = Me.dgAsignado.Rows.Item(j).Cells.Item(1).Value

        Dim cd As New CapaDato
        Dim ds As New DataSet
        cd.Inicializar()
        cd.AgregarParametro("@codigo", codigo.ToString, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_traeValorNeto")


        If ds.Tables(0).Rows.Count <> 0 Then
            valorA = ds.Tables(0).Rows.Item(0).Item(0).ToString
            netoA = ds.Tables(0).Rows.Item(0).Item(0).ToString
        Else
            valorA = 0
            netoA = 0
        End If

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = "1"
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = valorA
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = netoA
        dgvRow.Cells.Add(dgvCell)

        'sumaValores = sumaValores + (Me.dgAsignado.Rows.Item(j).Cells.Item(3).Value * Me.dgAsignado.Rows.Item(j).Cells.Item(2).Value)

        If Tipo_Ingreso_OT = "Agrega" Then
            Me.dgRecibo.Rows.Add(dgvRow)

        End If

        cn.ReservaNlab(Me.lblNot.Text, analisisVar, codigo, descripcion, nlab, nlab, 1, valorA, netoA)
        Call GrabaDigitaResultados(CInt(Me.lblNot.Text), CInt(nlab), CInt(nlab), Me.dgAsignado.Rows.Item(j).Cells.Item(4).Value.ToString, Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value.ToString)
        If analisisVar = 3000 Then
            Call GrabaPlanillaPlani(CInt(Me.lblNot.Text), CInt(nlab), CInt(nlab), Me.dgAsignado.Rows.Item(j).Cells.Item(4).Value.ToString, Me.dgAsignado.Rows.Item(j).Cells.Item(0).Value.ToString)
        End If



    End Sub

    Private Sub GrabaDigitaResultados(ByVal numOT As Integer, ByVal desde As Integer, ByVal hasta As Integer, ByVal codigoA As String, ByVal codana As String)
        Try
            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP
                .Inicializar()
                .AgregarParametro("@NumOT", CInt(numOT), SqlDbType.Int)
                .AgregarParametro("@NlabDesde", CInt(desde), SqlDbType.Int)
                .AgregarParametro("@NlabHasta", CInt(hasta), SqlDbType.Int)
                .AgregarParametro("@CMuestra", codigoA, SqlDbType.VarChar)
                .AgregarParametro("@codigo", CInt(codana), SqlDbType.Int)
                .EjecutarEscalar("ls_GrabaDigitaResultados")


            End With
        Catch ex As Exception
            MsgBox("Se ha producido un error al generar el número de laboratorio', error: " & ex.Message)
        End Try
    End Sub

    Private Sub GrabaPlanillaPlani(ByVal numOT As Integer, ByVal desde As Integer, ByVal hasta As Integer, ByVal codigoA As String, ByVal codana As String)
        Try
            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP
                .Inicializar()
                .AgregarParametro("@NumOT", CInt(numOT), SqlDbType.Int)
                .AgregarParametro("@NlabDesde", CInt(desde), SqlDbType.Int)
                .AgregarParametro("@NlabHasta", CInt(hasta), SqlDbType.Int)
                .AgregarParametro("@CMuestra", codigoA, SqlDbType.VarChar)
                .AgregarParametro("@codigo", CInt(codana), SqlDbType.Int)
                .EjecutarEscalar("ls_GrabaPlanillaPlani")


            End With
        Catch ex As Exception
            MsgBox("Se ha producido un error al generar el número de laboratorio', error: " & ex.Message)
        End Try
    End Sub

    Private Sub txCantidadMuestreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCantidadMuestreo.KeyPress

        If e.KeyChar = Chr(13) Then
            Me.txValorMuestreo.Focus()
        End If

    End Sub

    Private Sub txCantidadRe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCantidadRe.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txValorUnitRe.Focus()
        End If

    End Sub

    Private Sub txValorUnitRe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txValorUnitRe.KeyPress

        If e.KeyChar = Chr(13) Then
            Try

                Me.txMuestreoRe.Text = CInt(Me.txValorUnitRe.Text) * CInt(Me.txCantidadRe.Text)
                Me.txPorcentajeDescuentoTotalRe.Text = CInt((CInt(Me.txSubTotalRe.Text)) * (CInt(Me.txPorcentajeDescuentoRe.Text) / 100))
                Me.txNetoRe.Text = CInt(Me.txSubTotalRe.Text) + CInt(Me.txMuestreoRe.Text) - CInt(Me.txPorcentajeDescuentoTotalRe.Text)
                Me.txIvaRe.Text = CInt(CInt(Me.txNetoRe.Text) * 0.19)
                Me.txTotalRe.Text = CInt(Me.txNetoRe.Text) + CInt(Me.txIvaRe.Text)
            Catch ex As Exception
                MsgBox("Existen Campos vacios, por lo que no se puede hacer ningún cálculo", MsgBoxStyle.Information)
            End Try

        End If

    End Sub

    Private Sub txPorcentajeDescuentoRe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPorcentajeDescuentoRe.KeyPress

        If e.KeyChar = Chr(13) Then
            Try
                Me.txPorcentajeDescuentoTotalRe.Text = CInt((CInt(Me.txSubTotalRe.Text)) * (CInt(Me.txPorcentajeDescuentoRe.Text) / 100))
                Me.txNetoRe.Text = CInt(Me.txMuestreoRe.Text) + CInt(Me.txSubTotalRe.Text) - CInt(Me.txPorcentajeDescuentoTotalRe.Text)
                Me.txIvaRe.Text = CInt(CInt(Me.txNetoRe.Text) * 0.19)
                Me.txTotalRe.Text = CInt(Me.txNetoRe.Text) + CInt(Me.txIvaRe.Text)
            Catch ex As Exception
                MsgBox("Existen Campos vacios, por lo que no se puede hacer ningún cálculo", MsgBoxStyle.Information)
            End Try

        End If

    End Sub

    Private Sub txPorcentajeDetalleTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPorcentajeDetalleTotal.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Dim arr As Array
                Me.txPorcentajeDetalle.Text = CInt((CInt(Me.txPorcentajeDetalleTotal.Text) * 100) / CInt(Me.txSubTotal.Text))
                arr = Split(Me.txPorcentajeDetalle.Text, ",")
                Me.txPorcentajeDetalle.Text = CInt(arr(0).ToString & "," & Mid(arr(1).ToString, 1, 1))
                Me.txNetoDet.Text = CInt(Me.txMuestreoDet.Text) + CInt(Me.txSubTotal.Text) - CInt(Me.txPorcentajeDetalleTotal.Text)
                Me.txIvaDet.Text = CInt(CInt(Me.txNetoDet.Text) * 0.19)
                Me.txTotalDet.Text = CInt(Me.txNetoDet.Text) + CInt(Me.txIvaDet.Text)
            Catch ex As Exception
                MsgBox("Existen Campos vacios, por lo que no se puede hacer ningún cálculo", MsgBoxStyle.Information)
            End Try

        End If
    End Sub

    Private Sub txPorcentajeDescuentoTotalRe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPorcentajeDescuentoTotalRe.KeyPress
        If e.KeyChar = Chr(13) Then

            Try
                Dim arr As Array
                Me.txPorcentajeDescuentoRe.Text = CInt((CInt(Me.txPorcentajeDescuentoTotalRe.Text) * 100) / CInt(Me.txSubTotalRe.Text))
                arr = Split(Me.txPorcentajeDescuentoRe.Text, ",")
                Me.txPorcentajeDescuentoRe.Text = CInt(arr(0).ToString & "," & Mid(arr(1).ToString, 1, 1))
                Me.txNetoRe.Text = CInt(CInt(Me.txMuestreoRe.Text) + CInt(Me.txSubTotalRe.Text) - CInt(Me.txPorcentajeDescuentoTotalRe.Text))
                Me.txIvaRe.Text = CInt(CInt(Me.txNetoRe.Text) * 0.19)
                Me.txTotalRe.Text = CInt(CInt(Me.txNetoRe.Text) + CInt(Me.txIvaRe.Text))
            Catch ex As Exception
                MsgBox("Existen Campos vacios, por lo que no se puede hacer ningún cálculo", MsgBoxStyle.Information)
            End Try

        End If
    End Sub

    Private Sub txPorcentajeDetalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPorcentajeDetalle.KeyPress

        If e.KeyChar = Chr(13) Then
            Try
                Me.txPorcentajeDetalleTotal.Text = CInt((CInt(Me.txSubTotal.Text)) * (CInt(Me.txPorcentajeDetalle.Text) / 100))
                Me.txNetoDet.Text = (CInt(Me.txSubTotal.Text) + CInt(Me.txMuestreoDet.Text)) - CInt(Me.txPorcentajeDetalleTotal.Text)
                Me.txIvaDet.Text = CInt(CInt(Me.txNetoDet.Text) * 0.19)
                Me.txTotalDet.Text = CInt(Me.txNetoDet.Text) + CInt(Me.txIvaDet.Text)

            Catch ex As Exception
                MsgBox("Existen Campos vacios, por lo que no se puede hacer ningún cálculo", MsgBoxStyle.Information)
            End Try
        End If

    End Sub

    Private Sub txValorMuestreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txValorMuestreo.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                Dim subtotal As Integer = Me.txSubTotal.Text
                Dim valorMuestreo As Integer = Me.txValorMuestreo.Text
                Dim cantidadMuestreo As Integer = Me.txCantidadMuestreo.Text
                If (valorMuestreo = 0 And cantidadMuestreo = 0) Then
                    Dim muestreo As Integer = 0
                    Me.txMuestreoDet.Text = muestreo
                    Dim neto As Integer = (muestreo + subtotal) - CInt(Me.txPorcentajeDetalleTotal.Text)
                    Me.txNetoDet.Text = neto
                    Dim iva As Integer = neto * 0.19
                    Me.txIvaDet.Text = iva
                    Me.txTotalDet.Text = neto + iva

                Else
                    Dim muestreo As Integer = valorMuestreo * cantidadMuestreo
                    Me.txMuestreoDet.Text = muestreo
                    Me.txPorcentajeDetalleTotal.Text = (muestreo + subtotal) * (CInt(Me.txPorcentajeDetalle.Text) / 100)
                    Dim neto As Integer = (muestreo + subtotal) - CInt(Me.txPorcentajeDetalleTotal.Text)
                    Me.txNetoDet.Text = neto
                    Dim iva As Integer = CInt(neto * 0.19)
                    Me.txIvaDet.Text = iva
                    Me.txTotalDet.Text = neto + iva
                End If

            Catch ex As Exception
                MsgBox("Existen Campos vacios, por lo que no se puede hacer ningún cálculo", MsgBoxStyle.Information)
            End Try

        End If

    End Sub

    Private Sub btnBuscaProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim productor As New G_Productor
        productor.Owner = Me
        productor.Show()
    End Sub

    Private Sub btnAceptarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarDet.Click
        Dim a, b, c, d As Integer
        Dim cd As New CapaDato
        dgDatosAgronomicos.Rows.Clear()
        b = 0
        a = Me.dgDetalle.Rows.Count
        d = Me.dgDatosAgronomicos.Rows.Count

        While b < a

            Try

                ' While c < d
                'If Me.dgDetalle.Rows.Item(b).Cells.Item(0).Value = Me.dgDatosAgronomicos.Rows.Item(c).Cells.Item(0).Value Then
                'MsgBox(" Análisis repetidos, solo se agregaran los no repetidos.", MsgBoxStyle.Information)
                'GoTo repetido
                'End If
                'c = c + 1
                'End While
                If Tipo_Ingreso_OT <> "Consulta" Then

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Me.dgDetalle.Rows.Item(b).Cells.Item(0).Value
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Me.dgDetalle.Rows.Item(b).Cells.Item(1).Value
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Me.dgDetalle.Rows.Item(b).Cells.Item(2).Value
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Me.dgDetalle.Rows.Item(b).Cells.Item(3).Value
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Me.dgDetalle.Rows.Item(b).Cells.Item(4).Value
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Me.dgDetalle.Rows.Item(b).Cells.Item(5).Value
                    dgvRow.Cells.Add(dgvCell)

                    If Me.dgDetalle.Rows.Item(b).Cells.Item(0).Value > 8000 And Me.dgDetalle.Rows.Item(b).Cells.Item(0).Value < 9000 Then
                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = "C/DA"
                        dgvRow.Cells.Add(dgvCell)
                    Else
                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = "S/DA"
                        dgvRow.Cells.Add(dgvCell)
                    End If



                    Me.dgDatosAgronomicos.Rows.Add(dgvRow)

                End If
                If Tipo_Ingreso_OT = "Consulta" Or Tipo_Ingreso_OT = "Normal" Then
                    Dim cn As New CapaNegocio
                    Dim codigo As Integer

                    codigo = Me.dgDetalle.Rows.Item(b).Cells.Item(0).Value

                    If codigo >= 1000 And codigo < 2000 Then
                        analisisVar = 1000
                    ElseIf codigo >= 2000 And codigo < 3000 Then
                        analisisVar = 2000
                    ElseIf codigo >= 3000 And codigo < 4000 Then
                        analisisVar = 3000
                    ElseIf codigo >= 4000 And codigo < 5000 Then
                        analisisVar = 4000
                    ElseIf codigo >= 5000 And codigo < 6000 Then
                        analisisVar = 5000
                    ElseIf codigo >= 6000 And codigo < 7000 Then
                        analisisVar = 6000
                    ElseIf codigo = 7302 Then
                        analisisVar = 7302
                    ElseIf codigo = 7304 Then
                        analisisVar = 7304
                    ElseIf codigo = 7306 Then
                        analisisVar = 7306
                    ElseIf codigo = 7308 Then
                        analisisVar = 7308
                    ElseIf codigo = 8758 Then
                        analisisVar = 8758
                    ElseIf codigo = 8702 Or codigo = 8704 Or codigo = 8706 Or codigo = 8710 Then
                        analisisVar = 8700
                    ElseIf codigo >= 7000 And codigo < 8000 Then
                        analisisVar = 7000
                    ElseIf codigo >= 8000 And codigo < 9000 Then
                        analisisVar = 8000
                    End If
                    cn.ReservaNlab(Me.lblNot.Text, analisisVar, codigo, Me.dgDetalle.Rows.Item(b).Cells.Item(2).Value, CInt(Me.dgDetalle.Rows.Item(b).Cells.Item(3).Value), CInt(Me.dgDetalle.Rows.Item(b).Cells.Item(4).Value), CInt(Me.dgDetalle.Rows.Item(b).Cells.Item(5).Value), CInt(Me.dgDetalle.Rows.Item(b).Cells.Item(6).Value), CInt(Me.dgDetalle.Rows.Item(b).Cells.Item(7).Value))


                End If

                'repetido:
            Catch ex As Exception
            End Try

            b = b + 1
        End While

        If Tipo_Ingreso_OT = "Consulta" Then
            Button1_Click_1(sender, e)
            Call GrabaOrden()
            Exit Sub
            'ElseIf Tipo_Ingreso_OT = "Normal" Then
            '    'Call GrabaOrden()
        End If

    


        'If Tipo_Ingreso_OT = "Consulta" Then

        '    tbOT.SelectedTab = tbOT.TabPages(3)
        'Else
        '    If Tipo_Ingreso_OT = "Normal" Then
        tbOT.SelectedTab = tbOT.TabPages(3)
        'End If


        'End If



    End Sub



    Sub pintaCeldas()

        'Try

        Dim i, r As Integer
        r = Me.dgFoliar.Rows.Count

        While i < r
            If CInt(Me.dgFoliar.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgFoliar.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then

                If Me.dgFoliar.Rows.Item(i).Cells.Item(0).Value <> 1202 Then
                    Me.dgFoliar.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                End If
            End If
            i = i + 1
        End While

        i = 0
        r = Me.dgAgua.Rows.Count

        While i < r
            If CInt(Me.dgAgua.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgAgua.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then
                Me.dgAgua.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            End If
            i = i + 1
        End While

        i = 0
        r = Me.dgTejido.Rows.Count

        While i < r
            If CInt(Me.dgSuelo.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgSuelo.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then
                Me.dgSuelo.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            End If
            i = i + 1
        End While

        i = 0
        r = Me.dgTejido.Rows.Count

        While i < r
            If CInt(Me.dgTejido.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgTejido.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then
                Me.dgTejido.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            End If
            i = i + 1
        End While

        i = 0
        r = Me.dgKitOtros.Rows.Count

        While i < r
            If CInt(Me.dgKitOtros.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgKitOtros.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then
                Me.dgKitOtros.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            End If
            i = i + 1
        End While

        i = 0
        r = Me.dgFitopatologia.Rows.Count

        While i < r
            If CInt(Me.dgFitopatologia.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgFitopatologia.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then
                Me.dgFitopatologia.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            End If
            i = i + 1
        End While

        i = 0
        r = Me.dgFertQui.Rows.Count

        While i < r
            If CInt(Me.dgFertQui.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgFertQui.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then
                Me.dgFertQui.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            End If
            i = i + 1
        End While

        i = 0
        r = Me.dgFertOrg.Rows.Count

        While i < r
            If CInt(Me.dgFertOrg.Rows.Item(i).Cells.Item(2).Value) = 0 Or Me.dgFertOrg.Rows.Item(i).Cells.Item(2).Value.ToString = "" Then
                Me.dgFertOrg.Rows.Item(i).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            End If
            i = i + 1
        End While

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub tbFoliar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbFoliar.Enter

        codigoAnalisis = 1000
    End Sub

    Private Sub tbAgua_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAgua.Enter
        codigoAnalisis = 3000

    End Sub

    Private Sub tbTejidos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTejidos.Enter
        codigoAnalisis = 2000

    End Sub

    Private Sub tbSuelo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSuelo.Enter
        codigoAnalisis = 4000

    End Sub

    Private Sub tbKitOtros_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbKitOtros.Enter
        codigoAnalisis = 8000

    End Sub

    Private Sub tbFitopatologia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbFitopatologia.Enter
        codigoAnalisis = 7000

    End Sub

    Private Sub tbFertQui_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbFertQui.Enter
        codigoAnalisis = 5000

    End Sub

    Private Sub tbFertOrg_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbFertOrg.Enter
        codigoAnalisis = 6000

    End Sub

    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        Dim productor As New G_Productor
        productor.Owner = Me
        productor.Show()
    End Sub

    Private Sub btnIngresarNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarNueva.Click

        Me.dgAsignado.Rows.Clear()
        Me.dgDetalle.Rows.Clear()
        'Me.nLabDesde.Text = ""
        ' Me.nLabHasta.Text = ""
        analisisVar = 0

    End Sub

    Private Sub btnIngMuestraDT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngMuestraDT.Click

        'Me.dgAsignado.Rows.Clear()
        'Me.dgDetalle.Rows.Clear()
        '' Me.nLabDesde.Text = ""
        '' Me.nLabHasta.Text = ""
        'analisisVar = 0

        If Me.tbAnalisis.Visible = True Then
            tbOT.SelectedTab = tbOT.TabPages(1)


        End If



    End Sub

    Private Sub btnImprimirRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirRe.Click
        Try
            Dim m_Excel As Excel.Application
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim num_ord As Integer
            Dim FILA_IMP_REC As DataRow
            Dim sp As New CapaDato

            If (Me.txTotalRe.Text) = "" Then
                MsgBox("ERROR... Falta Generar el número de Orden de Trabajo")
                Exit Sub
            End If
            Call GrabaOrden()
            LabsysDataSet8.Tables("OT_CODIFICACION_RECIBO").Rows.Clear()

            With sp
                .Inicializar()
                .AgregarParametro("@NumOT", CInt(Me.lblNot.Text), SqlDbType.Int)
                .EjecutarQueryDt("usp_SelectCodificacion", LabsysDataSet8, "OT_CODIFICACION_RECIBO")
            End With

            Dim Retorno As Integer = 0

            Dim cn As New CapaNegocio
            Retorno = cn.revisaDigitacionAntecedentes(Me.lblNot.Text)



            If Retorno = 1 Then
                MsgBox("ERROR .... Falta Ingresar Datos agronomicos")
                Exit Sub
            End If
            If (Me.txTotalRe.Text) = "" Then
                MsgBox("ERROR .... Falta Ingresar Datos agronomicos")
                Exit Sub
            End If
            Dim muestreo As Integer = CInt(Me.txMuestreoRe.Text)
            Dim neto As Integer = CInt(Me.txNetoRe.Text)
            Dim iva As Integer = CInt(Me.txIvaRe.Text)
            Dim total As Integer = CInt(Me.txTotalRe.Text)
            Dim abono As Integer = CInt(Me.txAbono.Text)
            Dim descuento As Integer = CInt(txPorcentajeDescuentoRe.Text)
            Dim peso As Integer = CInt(Me.txPorcentajeDescuentoTotalRe.Text)
            Dim ot As Integer = CInt(Me.lblNot.Text)

            Call Imprime_Recibo(m_Excel, objLibroExcel, objHojaExcel, muestreo, neto, iva, Me.cbIngreso.Text, _
                                total, abono, cbProductor.Text, cbEmpresa.Text, Me.dtFechaIngreso.Text, Me.txRazonSocial.Text, Me.txRutFactura.Text, _
                                Me.txDireccionRS.Text, Me.cbComunaRS.Text, Me.cbCiudadRS.Text, Me.txGiro.Text, Me.txFonoRS1.Text, Me.txSolicita.Text, _
                                descuento, peso, ot)
            Try
                m_Excel.Quit()
            Catch ex As Exception
            End Try
            'Call GrabaOrden()
            '       TipoSalida = "Grabar"
            m_Excel = Nothing
            Me.Close()
        Catch ex As Exception
            MsgBox("Se ha producido un error al generar el excel, error: " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    '    Private Sub btnFacturarRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturarRe.Click
    '        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
    '        Dim m_Excel As Excel.Application
    '        Dim objLibroExcel As Excel.Workbook
    '        Dim objHojaExcel As Excel.Worksheet
    '        Dim via, fuente, destino As String
    '        Dim PUNTOS, PUNTOS_X, nomb, vv As String
    '        Dim num_ord, Fila_Lect As Integer
    '        Dim FILA_IMP_REC, FilaDes As DataRow
    '        If TxtAbono.Text <> 0 And (CBCond_Pago.Text = "") Then MsgBox("Falta ingresar forma de pago del abono") : GoTo FaltaFormadePagoAbono

    '        If TxtRutFact.Text <> "" Then
    '            If TxtMuestreo2.Text = "" Then
    '                TxtMuestreo2.Text = 0
    '            End If
    '            If TxtNeto.Text = "" Then
    '                TxtNeto.Text = 0
    '            End If
    '            If TxtIva.Text = "" Then
    '                TxtIva.Text = 0
    '            End If
    '            If TxtTotal.Text = "" Then
    '                TxtTotal.Text = 0
    '            End If
    '            If TxtAbono.Text = "" Then
    '                TxtAbono.Text = 0
    '            End If

    '            'Call Imprime_Recibo(m_Excel, objLibroExcel, objHojaExcel, TxtMuestreo2.Text, TxtNeto2.Text, TxtIva2.Text, CBEntrego.Text, _
    '            '                 TxtTotal2.Text, TxtAbono.Text, CBProductor.Text, CBEmpresa.Text, DTPFechaIng.Text, TxtRazonSocial.Text, TxtRutFact.Text, _
    '            '                 TxtFactDireccion.Text, CBFactComuna.Text, CBFactCiudad.Text, TxtGiro.Text, TxtFactFono1.Text, TxtSolicita.Text)

    '            Call GrabaOrden()
    'pormientras:
    '            TipoFacturacion = "DesdeOrden"
    '            TipoSalida = "Grabar"
    '            Aux_Rut_Facturacion = TxtRutFact.Text
    '            Dim Form_Despacho As New Frm_Despacho
    '            Form_Despacho.ShowDialog()
    '            Me.Close()
    '            TipoFacturacion = ""
    '        Else
    '            MsgBox("Ingrese Rut a Facturar")
    '        End If
    'FaltaFormadePagoAbono:
    '    End Sub

    Private Sub txCotizacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCotizacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                If Not IsNumeric(Me.txCotizacion.Text) Then
                    Me.ErrorNCotizacion.SetError(Me.txCotizacion, "Debe digitar un valor numerico")
                Else
                    '-------
                    Me.ErrorNCotizacion.SetError(Me.txCotizacion, Nothing)
                    Dim cd As New CapaDato
                    Dim dsCot, dsB1, dsB2 As New DataSet
                    Dim dtCot, dtB1, dtB2 As New DataTable
                    Dim respuesta As Boolean
                    cd.Inicializar()
                    cd.AgregarParametro("@cotizacion", CInt(Me.txCotizacion.Text), SqlDbType.Int)
                    dsCot = cd.EjecutarQuery("ls_obtieneProductorCotizacion")
                    dtCot = dsCot.Tables(0)
                    dtAnalisis = dtCot

                    If dtCot.Rows.Count = 0 Then
                        MsgBox("El Número de cotización no existe", MsgBoxStyle.Information)

                    ElseIf dtCot.Rows.Item(0).Item(1) <> "" Then

                        cd.Inicializar()
                        cd.AgregarParametro("@rut", dtCot.Rows.Item(0).Item(1), SqlDbType.VarChar)
                        cd.AgregarParametro("@empresa", "", SqlDbType.VarChar)
                        dsB1 = cd.EjecutarQuery("ls_BuscarProductorCotizacion")

                        dtB1 = dsB1.Tables(0)

                        If (dtB1.Rows.Count = 0) Then 'inicio consulta 1
                            cd.Inicializar()
                            cd.AgregarParametro("@rut", dtCot.Rows.Item(0).Item(1), SqlDbType.VarChar)
                            cd.AgregarParametro("@empresa", "", SqlDbType.VarChar)
                            dsB2 = cd.EjecutarQuery("ls_BuscarEmpresaCotizacion")

                            dtB2 = dsB2.Tables(0)

                            If (dtB2.Rows.Count = 0) Then 'inicio consulta 2
                                respuesta = MsgBox("El Productor no existe" & vbCr & _
                                "¿Desea agregar los datos asociados a la cotización " & vbCr & _
                                "en este formulario? ", MsgBoxStyle.YesNo)
                                If (respuesta = MsgBoxResult.Yes) Then 'inicio if respuesta
                                    'hacer algo con los datos obtenidos de la consulta 1

                                    Me.txRutFactura.Text = dtCot.Rows.Item(0).Item(1).ToString
                                    Me.txRutProductor.Text = dtCot.Rows.Item(0).Item(1).ToString
                                    Me.cbProductor.Text = dtCot.Rows.Item(0).Item(2).ToString
                                    Me.cbEmpresa.Text = dtCot.Rows.Item(0).Item(3).ToString
                                    Me.cbComuna.Text = dtCot.Rows.Item(0).Item(7).ToString
                                    Me.cbCiudad.Text = dtCot.Rows.Item(0).Item(8).ToString
                                    Me.txEmail1.Text = dtCot.Rows.Item(0).Item(9).ToString
                                    Me.txEmailRemite1.Text = dtCot.Rows.Item(0).Item(9).ToString
                                    Me.txSolicita.Text = dtCot.Rows.Item(0).Item(4).ToString
                                    Me.txEmailSolicita1.Text = dtCot.Rows.Item(0).Item(9).ToString
                                    Me.txCelular1.Text = dtCot.Rows.Item(0).Item(10).ToString
                                    Me.txFono1.Text = dtCot.Rows.Item(0).Item(11).ToString
                                    Me.txFax1.Text = dtCot.Rows.Item(0).Item(12).ToString

                                Else 'inicio si es no la respuesta
                                    Exit Sub
                                End If 'fin respuesta
                                '---------
                            Else
                                'hacer algo con el g_productor
                                dtCotiza = dtB2
                                cotiza = "S"
                                Dim productor As New G_Productor
                                productor.Owner = Me
                                productor.Show()

                            End If 'fin consulta 2
                        Else
                            'hacer algo con el g_productor
                            dtCotiza = dtB1
                            cotiza = "S"
                            Dim productor As New G_Productor
                            productor.Owner = Me
                            productor.Show()

                        End If 'fin consulta 1

                    ElseIf dtCot.Rows.Item(0).Item(1) = "" Then 'inicio


                        cd.Inicializar()
                        cd.AgregarParametro("@rut", "", SqlDbType.VarChar)
                        cd.AgregarParametro("@empresa", dtCot.Rows.Item(0).Item(3), SqlDbType.VarChar)
                        dsB1 = cd.EjecutarQuery("ls_BuscarProductorCotizacion")

                        dtB1 = dsB1.Tables(0)

                        If (dtB1.Rows.Count = 0) Then 'inicio cons 1
                            cd.Inicializar()
                            cd.AgregarParametro("@rut", "", SqlDbType.VarChar)
                            cd.AgregarParametro("@empresa", dtCot.Rows.Item(0).Item(3), SqlDbType.VarChar)
                            dsB2 = cd.EjecutarQuery("ls_BuscarEmpresaCotizacion")

                            dtB2 = dsB2.Tables(0)

                            If (dtB2.Rows.Count = 0) Then 'inicio con 2
                                respuesta = MsgBox("El Productor no existe" & vbCr & _
                                "¿Desea agregar los datos asociados a la cotización " & vbCr & _
                                "en este formulario? ", MsgBoxStyle.YesNo)
                                If (respuesta = True) Then 'inicio preg
                                    'hacer algo con los datos obtenidos de la consulta 1

                                    Me.txRutFactura.Text = dtCot.Rows.Item(0).Item(1).ToString
                                    Me.txRutProductor.Text = dtCot.Rows.Item(0).Item(1).ToString
                                    Me.cbProductor.Text = dtCot.Rows.Item(0).Item(2).ToString
                                    Me.cbEmpresa.Text = dtCot.Rows.Item(0).Item(3).ToString
                                    Me.cbComuna.Text = dtCot.Rows.Item(0).Item(7).ToString
                                    Me.cbCiudad.Text = dtCot.Rows.Item(0).Item(8).ToString
                                    Me.txEmail1.Text = dtCot.Rows.Item(0).Item(9).ToString
                                    Me.txEmailRemite1.Text = dtCot.Rows.Item(0).Item(9).ToString
                                    Me.txSolicita.Text = dtCot.Rows.Item(0).Item(4).ToString
                                    Me.txEmailSolicita1.Text = dtCot.Rows.Item(0).Item(9).ToString
                                    Me.txCelular1.Text = dtCot.Rows.Item(0).Item(10).ToString
                                    Me.txFono1.Text = dtCot.Rows.Item(0).Item(11).ToString
                                    Me.txFax1.Text = dtCot.Rows.Item(0).Item(12).ToString

                                Else
                                    Exit Sub
                                End If 'fin preg
                            Else
                                'hacer algo con el g_productor
                                dtCotiza = dtB2
                                cotiza = "S"
                                Dim productor As New G_Productor
                                productor.Owner = Me
                                productor.Show()

                            End If 'fin cons 2
                        Else
                            'hacer algo con el g_productor
                            dtCotiza = dtB1
                            cotiza = "S"
                            Dim productor As New G_Productor
                            productor.Owner = Me
                            productor.Show()

                        End If 'fin consulta 1


                    End If
                End If
            Catch ex As Exception
                MsgBox("Se ha generado un error, favor comuniquese con el administrador, error :" & ex.Message, MsgBoxStyle.Information)
            End Try

        End If

    End Sub

    Private Sub txRutProductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txRutProductor.KeyPress
        Try

            If e.KeyChar = Chr(13) Then

                If ValidaRut(Me.txRutProductor.Text) = False Then
                    MsgBox("Rut de Productor Inválido")
                    GoTo salirxrut
                End If
                Dim dsProductor As New DataSet
                Dim cn As New CapaNegocio
                dsProductor = cn.buscaProductor(Me.txRutProductor.Text, "", "", "")
                If dsProductor.Tables(0).Rows.Count <> 0 Then
                    btnProductor_Click(sender, e)
                Else
                    MsgBox("El usuario no existe", MsgBoxStyle.Information)
                End If
salirxrut:
                Me.txRutFactura.Focus()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txOCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Chr(13) Then
            'If Not IsNumeric(Me.txOCompra.Text) Then
            '    Me.ErrorNCotizacion.SetError(Me.txOCompra, "Debe digitar un valor numerico")
            'Else
            '    Me.ErrorNCotizacion.SetError(Me.txOCompra, Nothing)
            'End If

        End If

    End Sub

    Private Sub chOtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chOtro.CheckedChanged

        If Me.chOtro.Checked = True Then
            Me.txOtroDespacho.ReadOnly = False
        Else
            Me.txOtroDespacho.ReadOnly = True
        End If

    End Sub

    Private Sub btnGrabarRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarRe.Click
        Try
            Dim cd As New CapaDato

            Dim Retorno As Integer = 0

            If Me.txAbono.Text <> 0 And (Me.cbCondPago.Text = "") Then
                MsgBox("Falta ingresar forma de pago del abono")
                Exit Sub
            End If
            If Me.lblNot.Text = "" Then
                MsgBox("Debe Ingresar un Productor, y generar un Numero de OT")
                Exit Sub
            End If
            With cd
                .Inicializar()
                .AgregarParametro("@NumOt", CInt(Me.lblNot.Text), SqlDbType.Int)
                Retorno = .EjecutarEscalar("usp_RevisaDigitacionAntecedentes")
            End With


            If Retorno = 1 Then
                MsgBox("ERROR... Falta Ingresar Datos agronomicos")
                Exit Sub
            End If

            'If cbRegionN.Text <> "" Then
            '    If Me.cbRegionN.Text = "I - Tarapaca" Then
            '        cbRegionN.Text = 1

            '    ElseIf Me.cbRegionN.Text = "II - Antofagasta" Then
            '        cbRegionN.Text = 2
            '    ElseIf Me.cbRegionN.Text = "III - Atacama" Then
            '        cbRegionN.Text = 3
            '    ElseIf Me.cbRegionN.Text = "IV - Coquimbo" Then
            '        cbRegionN.Text = 4
            '    ElseIf Me.cbRegionN.Text = "V - Valparaiso" Then
            '        cbRegionN.Text = 5
            '    ElseIf Me.cbRegionN.Text = "VI - Gral.B.O`Higgins" Then
            '        cbRegionN.Text = 6
            '    ElseIf Me.cbRegionN.Text = "VII - Maule" Then
            '        cbRegionN.Text = 7
            '    ElseIf Me.cbRegionN.Text = "VIII - Biobio" Then
            '        cbRegionN.Text = 8
            '    ElseIf Me.cbRegionN.Text = "IX - Araucania" Then
            '        cbRegionN.Text = 9
            '    ElseIf Me.cbRegionN.Text = "X - De los Lagos" Then
            '        cbRegionN.Text = 10
            '    ElseIf Me.cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)" Then
            '        cbRegionN.Text = 11
            '    ElseIf Me.cbRegionN.Text = "XII - Magallanes Y Antartica Ch." Then
            '        cbRegionN.Text = 12
            '    ElseIf Me.cbRegionN.Text = "XIII - Metropolitana" Then
            '        cbRegionN.Text = 13
            '    End If
            'End If

            Call GrabaOrden()

            'Me.Close()
            '  MsgBox("Orden Grabada", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GrabaOrden() '#########################################################################################################################
        Try
            Dim cn As New CapaNegocio
            Dim numeroOT As Integer
            Dim i As Integer
            i = 0
            Dim ds As DataSet = New DataSet
            Dim EstAna, EstPag, EstFac As String

            'EstAna = "xA"
            'EstPag = "Pte"
            'EstFac = "xF"
            Dim cd As New CapaDato
            With cd
                .AgregarParametro("@NumOt", CInt(Me.lblNot.Text), SqlDbType.Int)
                ds = .EjecutarQuery("usp_SelectEstadosOrden")
                Try
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_ESTADO_ANA")) = False Then
                        EstAna = ds.Tables(0).Rows(0).Item("OT_ESTADO_ANA")
                    Else
                        EstAna = "xA"
                    End If
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_ESTADO_PAG")) = False Then
                        EstPag = ds.Tables(0).Rows(0).Item("OT_ESTADO_PAG")
                    Else
                        EstPag = "Pte"
                    End If
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OT_ESTADO_FAC")) = False Then
                        EstFac = ds.Tables(0).Rows(0).Item("OT_ESTADO_FAC")

                    Else
                        EstFac = "xF"
                    End If

                    If EstAna = "" Then
                        EstAna = "xA"
                    End If

                    If EstPag = "" Then
                        EstPag = "Pte"
                    End If
                    If EstFac = "" Then
                        EstFac = "xF"
                    End If
                Catch ex As Exception
                    EstAna = "xA"
                    EstPag = "Pte"
                    EstFac = "xF"
                End Try

            End With

            If EstAna = "Ing" Then EstAna = "xA"
            If EstPag = "Ing" Then EstPag = "Pte"
            If EstFac = "Ing" Then EstFac = "xF"


            If txAbono.Text <> 0 Then
                If EstPag = "Pte" Then
                    If Me.txTotalRe.Text = txAbono.Text Then
                        EstPag = "Can"
                    Else
                        EstPag = "Abo"
                    End If
                Else
                    EstPag = "Pte"
                End If
            End If

            If Me.chCancelada.Checked = True Then
                EstPag = "Can"
            End If



            If cbRegionN.Text = "I - Tarapaca" Then
                guardaRegion = 1
            ElseIf cbRegionN.Text = "II - Antofagasta" Then
                guardaRegion = 2
            ElseIf cbRegionN.Text = "III - Atacama" Then
                guardaRegion = 3
            ElseIf cbRegionN.Text = "IV - Coquimbo" Then
                guardaRegion = 4
            ElseIf cbRegionN.Text = "V - Valparaiso" Then
                guardaRegion = 5
            ElseIf cbRegionN.Text = "VI - Gral.B.O`Higgins" Then
                guardaRegion = 6
            ElseIf cbRegionN.Text = "VII - Maule" Then
                guardaRegion = 7
            ElseIf cbRegionN.Text = "VIII - Biobio" Then
                guardaRegion = 8
            ElseIf cbRegionN.Text = "IX - Araucania" Then
                guardaRegion = 9
            ElseIf cbRegionN.Text = "X - De los Lagos" Then
                guardaRegion = 10
            ElseIf cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)" Then
                guardaRegion = 11
            ElseIf cbRegionN.Text = "XII - Magallanes Y Antartica Ch." Then
                guardaRegion = 12
            ElseIf cbRegionN.Text = "XIII - Metropolitana" Then
                guardaRegion = 13
            ElseIf cbRegionN.Text = "Seleccione Region" Then
                guardaRegion = 0
            End If

            ''_______________________________________________________________________

            If i = 0 Then
                numeroOT = cn.GuardaOTFinal(Me.lblNot.Text, Me.txCotizacion.Text, Me.txNOC.Text, Me.dtFechaIngreso.Text, Me.txRutProductor.Text, Me.txRutFactura.Text, Me.cbProductor.Text, _
                      Me.txDireccion.Text, Me.cbEmpresa.Text, Me.txPredio.Text, Me.cbLocalidad.Text, Me.cbComuna.Text, Me.cbCiudad.Text, _
                      Me.cbProvincia.Text, guardaRegion, Me.txFono1.Text, Me.txFono2.Text, Me.txCelular1.Text, Me.txCelular2.Text, Me.txFax1.Text, Me.txFax2.Text, Me.txEmail1.Text, _
                      Me.txEmail2.Text, Me.txSolicita.Text, Me.txFonoSolicita1.Text, Me.txFonoSolicita2.Text, Me.txCelularSolicita1.Text, Me.txCelularSolicita2.Text, _
                      Me.txFaxSolicita1.Text, Me.txFaxSolicita2.Text, Me.txEmailSolicita1.Text, Me.txEmailSolicita2.Text, Me.txRemite.Text, Me.txFonoRemite1.Text, _
                      Me.txFonoRemite2.Text, Me.txCelularRemite1.Text, Me.txCelularRemite2.Text, Me.txFaxRemite1.Text, Me.txFaxRemite2.Text, Me.txEmailRemite1.Text, _
                      Me.txEmail2Re.Text, Me.txSenores.Text, Me.txOtroDespacho.Text, Me.txCasilla.Text, Me.txFaxDespacho1.Text, Me.txFaxDespacho2.Text, Me.txAtencion.Text, _
                      Me.cbCiudadDespacho.Text, Me.txDireccionDespacho.Text, Me.txFonoDespacho1.Text, Me.txFonoDespacho2.Text, Me.txEmailDespacho1.Text, Me.txEmailDespacho2.Text, _
                      Me.cbComunaDespacho.Text, Me.txCelularDespacho1.Text, Me.txCelularDespacho2.Text, Me.dtFechaDespacho.Text, Me.chRetiraLab.Checked, _
                      Me.chAvisaFono.Checked, Me.chBus.Checked, Me.chCorreo.Checked, Me.chEmail.Checked, Me.chFax.Checked, Me.chOtro.Checked, Me.chUrgente.Checked, _
                      Me.txRazonSocial.Text, Me.txFonoRS1.Text, Me.txFonoRS2.Text, Me.txEmailRS1.Text, Me.txEmailRS2.Text, Me.txGiro.Text, Me.txDireccionRS.Text, _
                      Me.cbCiudadRS.Text, Me.cbComunaRS.Text, Me.txEncargadoPago.Text, Me.txFonoPagoRS1.Text, Me.txFonoPagoRS2.Text, Me.cbIngreso.Text, _
                      Me.txObservaciones.Text, Me.lblAviso.Text, Me.txSubTotalRe.Text, Me.txNetoRe.Text, Me.txIvaRe.Text, _
                      Me.txPorcentajeDescuentoRe.Text, Me.txPorcentajeDescuentoTotalRe.Text, Me.txCantidadMuestreo.Text, Me.txValorUnitRe.Text, Me.txMuestreoRe.Text, _
                      Me.txAbono.Text, Me.txTotalRe.Text, Me.chCheque.Checked, Me.chEfectivoRe.Checked, Me.cbCondPago.Text, EstAna, EstPag, EstFac)

                Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

                If chCancelada.Checked = True Then
                    With SP
                        .Inicializar()
                        .AgregarParametro("@NumOT", lblNot.Text, SqlDbType.Int)
                        .AgregarParametro("@fecha", Me.dtCancelada.Text, SqlDbType.DateTime)
                        .EjecutarEscalar("ys_GrabaFechaCancelacion")
                    End With
                End If




                MsgBox("Orden Grabada", MsgBoxStyle.Information)

            End If
        Catch ex As Exception
            MsgBox("Se ha producido un error al grabar la orden de trabajo, error: ", ex.Message)
        End Try
    End Sub

    Private Sub btnFacturarRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturarRe.Click
        Try
            Dim SP As New CapaDato
            Dim m_Excel As Excel.Application
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim via, fuente, destino As String
            Dim PUNTOS, PUNTOS_X, nomb, vv As String
            Dim num_ord, Fila_Lect As Integer
            Dim FILA_IMP_REC, FilaDes As DataRow



            If (Me.txTotalRe.Text) = "" Then
                MsgBox("ERROR... Falta Generar el número de Orden de Trabajo")
                Exit Sub
            End If
            If Me.lblNot.Text <> "No Asignada" Then

                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOT", CInt(Me.lblNot.Text), SqlDbType.Int)
                    .EjecutarQueryDt("usp_SelectCodificacion", LabsysDataSet8, "OT_CODIFICACION_RECIBO")
                End With

            End If

            Dim Retorno As Integer = 0

            Dim cn As New CapaNegocio
            Retorno = cn.revisaDigitacionAntecedentes(Me.lblNot.Text)



            If Retorno = 1 Then
                MsgBox("ERROR .... Falta Ingresar Datos agronomicos", MsgBoxStyle.Information)
                Exit Sub
            End If
            If (Me.txTotalRe.Text) = "" Then
                MsgBox("ERROR .... Falta Ingresar Datos agronomicos", MsgBoxStyle.Information)
                Exit Sub
            End If

            If txAbono.Text <> 0 And (cbCondPago.Text = "") Then MsgBox("Falta ingresar forma de pago del abono", MsgBoxStyle.Information) : GoTo FaltaFormadePagoAbono

            If txRutFactura.Text <> "" Then
                If txMuestreoRe.Text = "" Then
                    txMuestreoRe.Text = 0
                End If
                If txNetoRe.Text = "" Then
                    txNetoRe.Text = 0
                End If
                If txIvaRe.Text = "" Then
                    txIvaRe.Text = 0
                End If
                If txTotalRe.Text = "" Then
                    txTotalRe.Text = 0
                End If
                If txAbono.Text = "" Then
                    txAbono.Text = 0
                End If

                'Call Imprime_Recibo(m_Excel, objLibroExcel, objHojaExcel, TxtMuestreo2.Text, TxtNeto2.Text, TxtIva2.Text, CBEntrego.Text, _
                '                 TxtTotal2.Text, TxtAbono.Text, CBProductor.Text, CBEmpresa.Text, DTPFechaIng.Text, TxtRazonSocial.Text, TxtRutFact.Text, _
                '                 TxtFactDireccion.Text, CBFactComuna.Text, CBFactCiudad.Text, TxtGiro.Text, TxtFactFono1.Text, TxtSolicita.Text)

                Call GrabaOrden()

pormientras:
                TipoFacturacion = "DesdeOrden"
                TipoSalida = "Grabar"
                Aux_Rut_Facturacion = txRutFactura.Text
                Dim Form_Despacho As New Frm_Despacho
                Form_Despacho.ShowDialog()
                TipoFacturacion = ""
            Else
                MsgBox("Ingrese Rut a Facturar")
            End If
FaltaFormadePagoAbono:
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txCodigoB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCodigoB.KeyPress

        If e.KeyChar = Chr(13) Then
            btnBuscarAnalisis_Click(sender, e)
        End If

    End Sub

    Private Sub cbRegionN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbRegionN.TextChanged

        'Dim cn As New CapaNegocio
        'Dim ds As New DataSet
        'Dim dt As New DataTable
        'If reg = 1 Then


        '    ds = cn.datosLocalidad2(4, Me.cbRegionN.SelectedValue, "", "", "")

        '    dt = ds.Tables(0)

        '    Me.cbProvincia.DataSource = dt
        '    Me.cbProvincia.DisplayMember = "PROVINCIA"
        '    Me.cbProvincia.ValueMember = "PROVINCIA"

        '    provincia = 1
        '    ciudad = 0
        '    comuna = 0
        'End If

    End Sub

    Private Sub cbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProvincia.SelectedIndexChanged

        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable
        If provincia = 1 Then

            ds = cn.datosLocalidad2(2, "", "", "", Me.cbProvincia.SelectedValue)

            dt = ds.Tables(0)

            Me.cbCiudad.DataSource = dt
            Me.cbCiudad.DisplayMember = "CIUDAD"
            Me.cbCiudad.ValueMember = "CIUDAD"

            ciudad = 1
            comuna = 0
        End If

    End Sub

    Private Sub cbCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable
        If ciudad = 1 Then



            If Me.cbCiudad.SelectedValue <> "System.DBNull" Then

                ds = cn.datosLocalidad2(1, "", Me.cbCiudad.SelectedValue, "", "")

                dt = ds.Tables(0)

                Me.cbComuna.DataSource = dt
                Me.cbComuna.DisplayMember = "COMUNA"
                Me.cbComuna.ValueMember = "COMUNA"


                comuna = 1

            End If
        End If

    End Sub

    Private Sub cbComuna_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbComuna.SelectedIndexChanged

        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable
        If comuna = 1 Then

            ds = cn.datosLocalidad2(3, "", "", Me.cbComuna.SelectedValue, "")

            dt = ds.Tables(0)

            Me.cbLocalidad.DataSource = dt
            Me.cbLocalidad.DisplayMember = "LOCALIDAD"
            Me.cbLocalidad.ValueMember = "LOCALIDAD"

        End If

    End Sub

    Private Sub cbCiudadRS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCiudadRS.SelectedIndexChanged

        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable
        If ciudad = 1 Then
            If Me.cbCiudadRS.SelectedValue <> "System.DBNull" Then


                ds = cn.datosLocalidad2(1, "", Me.cbCiudadRS.SelectedValue, "", "")

                dt = ds.Tables(0)

                Me.cbComunaRS.DataSource = dt
                Me.cbCiudadRS.DisplayMember = "COMUNA"
                Me.cbComunaRS.ValueMember = "COMUNA"

                comuna = 1
            End If
        End If

    End Sub

    Private Sub cbCiudadDespacho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCiudadDespacho.SelectedIndexChanged
        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable
        If ciudad = 1 Then
            If Me.cbCiudadDespacho.SelectedValue <> "System.DBNull" Then


                ds = cn.datosLocalidad2(1, "", Me.cbCiudadDespacho.SelectedValue, "", "")

                dt = ds.Tables(0)

                Me.cbComunaDespacho.DataSource = dt
                Me.cbCiudadDespacho.DisplayMember = "COMUNA"
                Me.cbComunaDespacho.ValueMember = "COMUNA"


                comuna = 1
            End If
        End If

    End Sub

    Private Sub btnFacPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacPendiente.Click

        Dim pendiente As New G_FacturaPendiente
        pendiente.Owner = Me
        pendiente.Show()

    End Sub

    Private Sub dgDetalle_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellClick
        Try
            guardaIndice = e.RowIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgDetalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellDoubleClick

        If Tipo_Ingreso_OT = "Agrega" Then
            Dim cd As New CapaDato
            Dim numl, muestra, codAna As Integer
            Dim ds As New DataSet
            Dim frase As String
            Dim Fila_Cod, Fila_Cuartel As DataRow
            Dim ObjSum As Object
            Dim MYGRID As DataGridView = CType(sender, DataGridView)
            Me.chListaDeNlab.Items.Clear()


            cantChKl = 0
            Me.gbNlabs.Visible = True
            muestra = CInt(Mid(CStr(MYGRID.Rows.Item(e.RowIndex).Cells.Item(0).Value), 1, 1) & "000")
            codAna = CInt(MYGRID.Rows.Item(e.RowIndex).Cells.Item(0).Value)

            For numl = CInt(Me.dgDetalle.Rows.Item(e.RowIndex).Cells.Item(3).Value) To CInt(Me.dgDetalle.Rows.Item(e.RowIndex).Cells.Item(4).Value)
                cantChKl = cantChKl + 1
                Try

                    With cd
                        .Inicializar()
                        .AgregarParametro("@TMuestra", muestra, SqlDbType.Int)
                        .AgregarParametro("@NumOt", Orden_Trabajo_Bus, SqlDbType.Int)
                        .AgregarParametro("@NLab", numl, SqlDbType.Int)
                        ds = .EjecutarQuery("usp_SelectIdentificacion")
                        Fila_Cuartel = ds.Tables(0).Rows(0)
                        frase = CStr(numl).PadLeft(6) & Space(1) & Fila_Cuartel("IDENTIFICACION1") & Fila_Cuartel("IDENTIFICACION2")
                        Me.chListaDeNlab.Items.Add(frase, CheckState.Checked)

                    End With

                Catch ex As Exception

                End Try
            Next

            tbOT.SelectedTab = tbOT.TabPages(1)

            If Creada = 0 Then
                Me.lblNot.Text = "No Asignada"
                Creada = 1
            End If


            If paso = 0 Then
                Me.dgRecibo.Rows.Clear()
                paso = 1
            End If
            Call GrabaOrden()
            'Call btnGuardar_Click(sender, e)



        End If


    End Sub

    Private Sub dgDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellEndEdit
        Try
            Dim cd As New CapaDato
            Dim r, j, suma As Integer
            Dim grid As New DataGridView

            grid = sender

            If grid.Rows.Item(e.RowIndex).Cells.Item(6).Value.ToString <> "" Then
                grid.Rows.Item(e.RowIndex).Cells.Item(7).Value = CInt(grid.Rows.Item(e.RowIndex).Cells.Item(5).Value) * CInt(grid.Rows.Item(e.RowIndex).Cells.Item(6).Value)

            End If

            j = 0
            suma = 0
            r = Me.dgDetalle.Rows.Count
            While j < r

                suma = suma + CInt(Me.dgDetalle.Rows.Item(j).Cells.Item(7).Value)
                j = j + 1
            End While

            Me.txSubTotal.Text = suma
            Me.txPorcentajeDetalleTotal.Text = CInt((CInt(Me.txSubTotal.Text)) * (CInt(Me.txPorcentajeDetalle.Text) / 100))
            Me.txNetoDet.Text = CInt(Me.txSubTotal.Text) + CInt(Me.txMuestreoDet.Text) - CInt(Me.txPorcentajeDetalleTotal.Text)
            Me.txIvaDet.Text = CInt(CInt(Me.txNetoDet.Text) * 0.19)
            Me.txTotalDet.Text = CInt(Me.txNetoDet.Text) + CInt(Me.txIvaDet.Text)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgDetalle_EditModeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalle.EditModeChanged
        'Try
        '    Dim cd As New CapaDato
        '    Dim grid As New DataGridView

        '    grid = sender

        '    If grid.Rows.Item(e.RowIndex).Cells.Item(6).Value <> "" Then
        '        grid.Rows.Item(e.RowIndex).Cells.Item(7).Value = CInt(grid.Rows.Item(e.RowIndex).Cells.Item(5).Value) * CInt(grid.Rows.Item(e.RowIndex).Cells.Item(6).Value)
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dgDetalle_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalle.RegionChanged
        'Try
        '    Dim cd As New CapaDato
        '    Dim grid As New DataGridView

        '    grid = sender

        '    If grid.Rows.Item(e.RowIndex).Cells.Item(6).Value <> "" Then
        '        grid.Rows.Item(e.RowIndex).Cells.Item(7).Value = CInt(grid.Rows.Item(e.RowIndex).Cells.Item(5).Value) * CInt(grid.Rows.Item(e.RowIndex).Cells.Item(6).Value)
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dgDetalle_RowContextMenuStripChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgDetalle.RowContextMenuStripChanged
        'Try
        '    Dim cd As New CapaDato
        '    Dim grid As New DataGridView

        '    grid = sender

        '    If grid.Rows.Item(e.RowIndex).Cells.Item(6).Value <> "" Then
        '        grid.Rows.Item(e.RowIndex).Cells.Item(7).Value = CInt(grid.Rows.Item(e.RowIndex).Cells.Item(5).Value) * CInt(grid.Rows.Item(e.RowIndex).Cells.Item(6).Value)
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dgDetalle_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.RowEnter, dgDatosAgronomicos.CellClick

        'Try
        '    Dim cd As New CapaDato
        '    Dim grid As New DataGridView

        '    grid = sender

        '    If grid.Rows.Item(e.RowIndex).Cells.Item(6).Value <> "" Then
        '        grid.Rows.Item(e.RowIndex).Cells.Item(7).Value = CInt(grid.Rows.Item(e.RowIndex).Cells.Item(5).Value) * CInt(grid.Rows.Item(e.RowIndex).Cells.Item(6).Value)
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dgDetalle_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgDetalle.RowsRemoved
        Try

            Dim cd As New CapaDato
            Dim grid As New DataGridView

            grid = sender
            If grid.Rows.Item(e.RowIndex).Cells.Item(0).Value <> "" Then
                cd.Inicializar()
                cd.AgregarParametro("@not", CInt(Me.lblNot.Text), SqlDbType.Int)
                cd.AgregarParametro("@analisis", CInt(grid.Rows.Item(e.RowIndex).Cells.Item(0).Value), SqlDbType.Int)
                cd.AgregarParametro("@nLabDesde", CInt(grid.Rows.Item(e.RowIndex).Cells.Item(3).Value), SqlDbType.Int)
                cd.AgregarParametro("@nLabHasta", CInt(grid.Rows.Item(e.RowIndex).Cells.Item(4).Value), SqlDbType.Int)
                cd.EjecutarQuery("ls_borraNlabComprometido")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgDatosAgronomicos_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgDatosAgronomicos.RowsRemoved
        Try

            Dim cd As New CapaDato
            Dim grid As New DataGridView

            grid = sender
            If grid.Rows.Item(e.RowIndex).Cells.Item(0).Value <> "" Then
                cd.Inicializar()
                cd.AgregarParametro("@ot_numero", CInt(Me.lblNot.Text), SqlDbType.Int)
                cd.AgregarParametro("@cod_analisis", CInt(grid.Rows.Item(e.RowIndex).Cells.Item(0).Value), SqlDbType.Int)
                cd.EjecutarQuery("ls_borraAnalisisOT")
            End If

            Dim i, r As Integer

            r = Me.dgRecibo.Rows.Count

            While i < r
                If grid.Rows.Item(e.RowIndex).Cells.Item(0).Value = Me.dgRecibo.Rows.Item(i).Cells.Item(0).Value Then
                    Me.dgRecibo.Rows.Remove(Me.dgRecibo.Rows.Item(i))
                End If
                i = i + 1
            End While

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAnularRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularRe.Click
        Try
            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            Dim respuesta As MsgBoxResult
            Try
                respuesta = MsgBox("Esta seguro de Eliminar la OT : " & Me.lblNot.Text, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    With SP
                        .Inicializar()
                        .AgregarParametro("@NumOt", Me.lblNot.Text, SqlDbType.Int)
                        .EjecutarQuery("usp_EliminaxOrden")
                    End With
                End If
            Catch ex As Exception
                MsgBox("Se debe haber generado la orden antes de  borrarla", MsgBoxStyle.Information)
            End Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Se ha producido un error al anular la Orden de Trabajo, error: ", ex.Message)
        End Try
    End Sub

    Private Sub btnUnir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnir.Click
        Me.PUnir.Visible = True
        unir = True
        existeFila = False
    End Sub

    Private Sub btnUsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsalir.Click
        Me.dgUnir.Rows.Clear()
        ' Determinamos el alto de las filas
        dgUnir.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colF As DataGridViewColumn = dgUnir.Columns(1)
        ' Ajustamos la celda a su contenido.
        colF.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.PUnir.Visible = False
        existeFila = False
        unir = False
    End Sub

    Private Sub btnUAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUAceptar.Click
        Try
            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgUnir.Rows.Item(0).Cells.Item(0).Value.ToString
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgUnir.Rows.Item(0).Cells.Item(2).Value.ToString
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgUnir.Rows.Item(0).Cells.Item(3).Value.ToString
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString
            dgvRow.Cells.Add(dgvCell)

            Me.dgAsignado.Rows.Add(dgvRow)
            ''''
            Me.dgUnir.Rows.Clear()
            Me.PUnir.Visible = False
            unir = False
            existeFila = False

        Catch ex As Exception
            MsgBox("No se han asignado analisis", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub btnEMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEMail.Click
        Dim mOutLookApp As Outlook.Application
        Dim mNameSpace As Outlook.NameSpace
        Dim mItem As Outlook.MailItem
        Dim colAttach As Outlook.Attachments
        Dim l_Attach As Outlook.Attachment
        Dim cd As New CapaDato
        Dim rp As New MailOT

        Call btnGrabarRe_Click(sender, e)

        Cjto_Tablas1.Tables("MailOTEnc").Clear()
        Cjto_Tablas1.Tables("MailOTDet").Clear()

        cd.Inicializar()
        cd.AgregarParametro("@otNumero", CInt(Me.lblNot.Text), SqlDbType.Int)
        cd.EjecutarQueryDt("ls_MailOT", Cjto_Tablas1, "MailOTEnc")

        cd.Inicializar()
        cd.AgregarParametro("@otNumero", CInt(Me.lblNot.Text), SqlDbType.Int)
        cd.EjecutarQueryDt("ls_MailOTDet", Cjto_Tablas1, "MailOTDet")

        rp.Load()
        rp.SetDataSource(Cjto_Tablas1)

        Dim BOLA As Object

        Dim nompr, carpr, via, empn, ate, email, email2, sAño As String
        Dim num_com, f As Integer

        nompr = Me.cbProductor.Text
        ate = Me.txAtencion.Text
        Call control_nombre(ate)
        If ate <> "" Then ate = "Atención:" & ate & Chr(13) Else ate = ""
        via = ""
        For f = 1 To Len(nompr)
            carpr = Mid(nompr, f, 1)
            If carpr = "." Then carpr = " "
            via = via + carpr
        Next
        email = Me.txEmailDespacho1.Text
        email2 = Me.txEmailDespacho2.Text
        mOutLookApp = New Outlook.Application
        mNameSpace = mOutLookApp.GetNamespace("MAPI")
        mItem = mOutLookApp.CreateItem(0)
        mItem.To = email
        mItem.CC = email2
        mItem.Subject = "Orden de Trabajo Agrolab Ltda."
        mItem.Body = "Señor(es):" & Chr(13) & _
                     nompr & Chr(13) & _
                     ate & Chr(13) & _
                     "Adjunto Orden de Trabajo solicitada." & Chr(13) & _
                     "Atentamente," & Chr(13) & Chr(13) & _
                     "Agrolab Ltda." & Chr(13) & Chr(13) & _
                     "Fono   :(02) 225 8087" & Chr(13) & _
                     "e-mail : laboratorio@agrolab.cl" & Chr(13) & _
                     "Web    : www.agrolab.cl" & Chr(13) & Chr(13)
        colAttach = mItem.Attachments

        sAño = Year(Today)
        Dim pdf As String = "F:\Mis documentos\OT\" & CStr(Me.lblNot.Text) & ".pdf"
        ExportToPDF(rp, pdf)

        l_Attach = colAttach.Add(pdf)
        mItem.Display()

    End Sub

    Public Property ExportFormatType() As CrystalDecisions.Shared.ExportFormatType
        Get

        End Get
        Set(ByVal value As CrystalDecisions.Shared.ExportFormatType)

        End Set
    End Property

    Public Function ExportToPDF(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal NombreArchivo As String) As String
        Dim exportOpts As New CrystalDecisions.Shared.ExportOptions()
        Dim vFileName As String
        Dim diskOpts As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Try

            With rpt.ExportOptions

                .ExportDestinationType = exportOpts.ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat

            End With

            vFileName = NombreArchivo

            If File.Exists(vFileName) Then File.Delete(vFileName)
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()

        Catch ex As Exception
            Throw ex
        End Try
        Return vFileName

    End Function

    Private Sub chCancelada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chCancelada.CheckedChanged
        If Me.chCancelada.Checked = True Then
            Me.dtCancelada.Visible = True
            Me.dtCancelada.Text = Today
            Me.cbCondPago.Enabled = False
            Me.txAbono.Enabled = False
            Me.txSaldo.Enabled = False
        Else
            Me.dtCancelada.Visible = False
            Me.cbCondPago.Enabled = True
            Me.txAbono.Enabled = True
            Me.dtCancelada.Text = ""
            Me.txSaldo.Enabled = True
        End If
    End Sub

    Private Sub dgDatosAgronomicos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            Dim codigo As Integer
            codigo = Me.dgDatosAgronomicos.Rows.Item(e.RowIndex).Cells.Item(0).Value

            If codigo >= 1000 And codigo < 2000 Then
                analisisVar = 1000
            ElseIf codigo >= 2000 And codigo < 3000 Then
                analisisVar = 2000
            ElseIf codigo >= 3000 And codigo < 4000 Then
                analisisVar = 3000
            ElseIf codigo >= 4000 And codigo < 5000 Then
                analisisVar = 4000
            ElseIf codigo >= 5000 And codigo < 6000 Then
                analisisVar = 5000
            ElseIf codigo >= 6000 And codigo < 7000 Then
                analisisVar = 6000
            ElseIf codigo = 7302 Then
                analisisVar = 7302
            ElseIf codigo = 7304 Then
                analisisVar = 7304
            ElseIf codigo = 7306 Then
                analisisVar = 7306
            ElseIf codigo = 7308 Then
                analisisVar = 7308
            ElseIf codigo = 8758 Then
                analisisVar = 8758
            ElseIf codigo = 8702 Or codigo = 8704 Or codigo = 8706 Or codigo = 8710 Then
                analisisVar = 8700
            ElseIf codigo >= 7000 And codigo < 8000 Then
                analisisVar = 7000
            ElseIf codigo >= 8000 And codigo < 9000 Then
                analisisVar = 8000
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresaDatAgronomico.Click

        If (analisisVar = 1000) Then
            Dim foliar As New F_DatosAgrFoliares
            foliar.Owner = Me
            foliar.Show()
        ElseIf (analisisVar = 2000) Then
            Dim tejidos As New F_DatosAgrTejidos
            tejidos.Owner = Me
            tejidos.Show()
        ElseIf (analisisVar = 3000) Then
            Dim agua As New F_DatosAgrAgua
            agua.Owner = Me
            agua.Show()
        ElseIf (analisisVar = 4000) Then
            Dim suelo As New F_DatosAgrSuelo
            suelo.Owner = Me
            suelo.Show()
        ElseIf (analisisVar = 5000) Then
            Dim fertQui As New F_DatosAgrFertQui
            fertQui.Owner = Me
            fertQui.Show()
        ElseIf (analisisVar = 6000) Then
            Dim fertOrg As New F_DatosAgrFertOrg
            fertOrg.Owner = Me
            fertOrg.Show()
        ElseIf (analisisVar = 7302) Then
            Dim fito As New F_DatosAgrFitopatologia
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 7304) Then
            Dim fito As New F_DatosAgrFitoRes
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 7306) Then
            Dim fito As New F_DatosAgrFitoEvaluacion
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 7308) Then
            Dim fito As New F_DatosAgrFitoMonitoreo
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 8700) Then 'yemas
            Dim foliar As New F_DatosAgrYemas
            foliar.Owner = Me
            foliar.Show()
        ElseIf (analisisVar = 8758) Then 'nematodos
            Dim foliar As New F_DatosAgrNematodos
            foliar.Owner = Me
            foliar.Show()

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrRecibo.Click

        Dim i, j, a As Integer
        Me.dgRecibo.Rows.Clear()

        j = Me.dgDatosAgronomicos.Rows.Count
        a = 1
        While i < j
            If Me.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Value.ToString <> "C/DA" Then
                a = 2
            End If
            i = i + 1
        End While
        If a = 2 Then
            MsgBox("Debe ingresar todos los Datos Agronomicos.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf a = 1 Then

            Dim ds As New DataSet
            Dim s, r, u, v, k, sumaValores As Integer
            s = 0
            u = 0
            v = 0
            k = 0
            sumaValores = 0
            s = Me.dgDetalle.Rows.Count
            r = Me.dgRecibo.Rows.Count

            Dim entro As Integer = 0

            While u < s
                If Tipo_Ingreso_OT <> "Consulta" Then
                    While k < r

                        If Me.dgDetalle.Rows.Item(u).Cells.Item(0).Value = Me.dgRecibo.Rows.Item(k).Cells.Item(0).Value Then
                            '  MsgBox("Se han guardado los datos Argonómicos " & vbCr & _
                            '     "El análisis N°: " & Me.dgRecibo.Rows.Item(k).Cells.Item(0).Value & ",Ya estaba asignado, por lo que no se volverá a agregar. ", MsgBoxStyle.Information)

                            tbOT.SelectedTab = tbOT.TabPages(4)
                            Exit Sub

                        End If
                        k = k + 1
                    End While
                    k = 0
                End If
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'codigo
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(0).Value()
                dgvRow.Cells.Add(dgvCell)

                'muestra
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(1).Value()
                dgvRow.Cells.Add(dgvCell)

                'descripcion
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(2).Value()
                dgvRow.Cells.Add(dgvCell)

                'lab-desde
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(3).Value()
                dgvRow.Cells.Add(dgvCell)

                'lab-hasta
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(4).Value()
                dgvRow.Cells.Add(dgvCell)

                'cantidad
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(5).Value()
                dgvRow.Cells.Add(dgvCell)

                'valor
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(6).Value()
                dgvRow.Cells.Add(dgvCell)

                sumaValores = sumaValores + (Me.dgDetalle.Rows.Item(u).Cells.Item(5).Value() * Me.dgDetalle.Rows.Item(u).Cells.Item(6).Value())

                'neto
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Me.dgDetalle.Rows.Item(u).Cells.Item(7).Value()
                dgvRow.Cells.Add(dgvCell)

                If Tipo_Ingreso_OT = "Consulta" And entro = 0 Then

                    Me.dgRecibo.Rows.Clear()
                    entro = 1
                End If

                Me.dgRecibo.Rows.Add(dgvRow)

                u = u + 1

            End While

            Dim t, l, subtotal As Integer
            l = 0
            subtotal = 0
            t = Me.dgRecibo.Rows.Count

            While l < t
                subtotal = CInt(subtotal) + CInt(Me.dgRecibo.Rows.Item(l).Cells.Item(7).Value)
                l = l + 1
            End While

            Me.txCantidadRe.Text = Me.txCantidadMuestreo.Text
            Me.txValorUnitRe.Text = Me.txValorMuestreo.Text

            Me.txMuestreoRe.Text = CInt(Me.txCantidadRe.Text) * CInt(Me.txValorUnitRe.Text)
            Me.txPorcentajeDescuentoRe.Text = Me.txPorcentajeDetalle.Text
            Me.txPorcentajeDescuentoTotalRe.Text = Me.txPorcentajeDetalleTotal.Text

            Me.txSubTotalRe.Text = txSubTotal.Text 'subtotal
            Me.txNetoRe.Text = txNetoDet.Text 'CInt(subtotal + CInt(Me.txMuestreoRe.Text) - CInt(Me.txPorcentajeDescuentoTotalRe.Text))
            Me.txIvaRe.Text = txIvaDet.Text 'CInt(CInt(Me.txNetoRe.Text) * 0.19)

            'Dim f, g As Decimal
            'f = Me.txNetoRe.Text
            'g = Me.txIvaRe.Text
            Me.txTotalRe.Text = txTotalDet.Text 'CInt(f + g)
        End If
        If Tipo_Ingreso_OT = "Consulta" Then
            tbOT.SelectedTab = tbOT.TabPages(3)
        Else
            tbOT.SelectedTab = tbOT.TabPages(4)

        End If

    End Sub

    Private Sub txEmail1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmail1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailSolicita1.Text = Me.txEmail1.Text
            Me.txEmailRemite1.Text = Me.txEmail1.Text
            Me.txEmailRS1.Text = Me.txEmail1.Text
            Me.txEmailDespacho1.Text = Me.txEmail1.Text

            Me.txEmail2.Focus()

        End If

    End Sub

    Private Sub txEmail1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txEmail1.Leave
        Me.txEmailSolicita1.Text = Me.txEmail1.Text
        Me.txEmailRemite1.Text = Me.txEmail1.Text
        Me.txEmailRS1.Text = Me.txEmail1.Text
        'Me.txEmailDespacho1.Text = Me.txEmail1.Text
    End Sub

    Private Sub txSolicita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txSolicita.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txSolicita.Text
            Call control_nombre(NOMBREX)
            Me.txSolicita.Text = NOMBREX
            Me.txEncargadoPago.Text = Me.txSolicita.Text
            Me.txRemite.Text = Me.txSolicita.Text
            Me.txAtencion.Text = Me.txSolicita.Text
            Me.txFonoSolicita1.Focus()
        End If
    End Sub

    Private Sub cbLocalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbLocalidad.KeyDown

        If e.KeyData = Keys.Enter Then
            loc = 0
            Dim localidad As New G_Localidad
            localidad.Owner = Me
            localidad.Show()
            SendKeys.Send("{TAB}")
            Me.cbComuna.Focus()
        End If

        MyBase.OnKeyDown(e)

    End Sub

    Private Sub cbEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbEmpresa.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim NOMBREX As String

            NOMBREX = Me.cbEmpresa.Text
            Call control_nombre(NOMBREX)
            Me.cbEmpresa.Text = NOMBREX


            Dim empresa As New G_Empresa
            empresa.Owner = Me
            empresa.Show()

            Me.txPredio.Focus()

        End If
    End Sub

    Private Sub cbComuna_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbComuna.KeyDown

        If e.KeyData = Keys.Enter Then
            loc = 1
            Dim localidad As New G_Localidad
            localidad.Owner = Me
            localidad.Show()
            Me.cbCiudad.Focus()
        End If

        MyBase.OnKeyDown(e)

    End Sub

    Private Sub txSolicita_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txSolicita.Leave
        Me.txRemite.Text = Me.txSolicita.Text
    End Sub

    Private Sub btnBuscaLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaLocalidad.Click
        loc = 0
        Dim localidad As New G_Localidad
        localidad.Owner = Me
        localidad.Show()
    End Sub

    Private Sub btnComunaBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComunaBusca.Click
        loc = 1
        Dim localidad As New G_Localidad
        localidad.Owner = Me
        localidad.Show()
    End Sub

    Private Sub cbProductor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProductor.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim NOMBREX As String

            NOMBREX = Me.cbProductor.Text
            Call control_nombre(NOMBREX)
            Me.cbProductor.Text = NOMBREX
            Me.cbEmpresa.Focus()

            Try

                Dim cd As New CapaDato
                Dim ds As New DataSet
                cd.Inicializar()
                cd.AgregarParametro("@productor", Me.cbProductor.Text, SqlDbType.VarChar)
                dsProductor = cd.EjecutarQuery("ls_traeDatosProductor")

                If dsProductor.Tables(0).Rows.Count <> 0 Then
                    With Me
                        .txRutProductor.Text = dsProductor.Tables(0).Rows(0).Item(1).ToString
                        .cbProductor.Text = dsProductor.Tables(0).Rows(0).Item(0).ToString
                        .txDireccion.Text = dsProductor.Tables(0).Rows(0).Item(4).ToString
                        .cbEmpresa.Text = dsProductor.Tables(0).Rows(0).Item(2).ToString
                        .txPredio.Text = dsProductor.Tables(0).Rows(0).Item(3).ToString


                        If dsProductor.Tables(0).Rows(0).Item(9).ToString <> "" Then
                            If dsProductor.Tables(0).Rows(0).Item(9).ToString = "1" Then
                                .cbRegionN.Text = "I - Tarapaca"
                                .cbRegionN.SelectedValue = 1
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "2" Then
                                .cbRegionN.Text = "II - Antofagasta"
                                .cbRegionN.SelectedValue = 2
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "3" Then
                                .cbRegionN.Text = "III - Atacama"
                                .cbRegionN.SelectedValue = 3
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "4" Then
                                .cbRegionN.Text = "IV - Coquimbo"
                                .cbRegionN.SelectedValue = 4
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "5" Then
                                .cbRegionN.Text = "V - Valparaiso"
                                .cbRegionN.SelectedValue = 5
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "6" Then
                                .cbRegionN.Text = "VI - Gral.B.O`Higgins"
                                .cbRegionN.SelectedValue = 6
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "7" Then
                                .cbRegionN.Text = "VII - Maule"
                                .cbRegionN.SelectedValue = 7
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "8" Then
                                .cbRegionN.Text = "VIII - Biobio"
                                .cbRegionN.SelectedValue = 8
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "9" Then
                                .cbRegionN.Text = "IX - Araucania"
                                .cbRegionN.SelectedValue = 9
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "10" Then
                                .cbRegionN.Text = "X - De los Lagos"
                                .cbRegionN.SelectedValue = 10
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "11" Then
                                .cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)"
                                .cbRegionN.SelectedValue = 11
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "12" Then
                                .cbRegionN.Text = "XII - Magallanes Y Antartica Ch."
                                .cbRegionN.SelectedValue = 12
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "13" Then
                                .cbRegionN.Text = "XIII - Metropolitana"
                                .cbRegionN.SelectedValue = 13
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "0" Then
                                .cbRegionN.Text = "Seleccione Region"
                                .cbRegionN.SelectedValue = 0
                            End If
                        End If
                        .cbLocalidad.Text = dsProductor.Tables(0).Rows(0).Item(5).ToString
                        .cbCiudad.Text = dsProductor.Tables(0).Rows(0).Item(7).ToString
                        .cbComuna.Text = dsProductor.Tables(0).Rows(0).Item(6).ToString
                        .cbProvincia.Text = dsProductor.Tables(0).Rows(0).Item(8).ToString
                        .txFono1.Text = dsProductor.Tables(0).Rows(0).Item(10).ToString
                        .txFono2.Text = dsProductor.Tables(0).Rows(0).Item(11).ToString
                        .txCelular1.Text = dsProductor.Tables(0).Rows(0).Item(12).ToString
                        .txCelular2.Text = dsProductor.Tables(0).Rows(0).Item(13).ToString
                        .txFax1.Text = dsProductor.Tables(0).Rows(0).Item(14).ToString
                        'ot.txFax2.Text = dr.Item(15).ToString
                        .txEmail1.Text = dsProductor.Tables(0).Rows(0).Item(16).ToString
                        .txEmail2.Text = dsProductor.Tables(0).Rows(0).Item(17).ToString
                        .txSolicita.Text = dsProductor.Tables(0).Rows(0).Item(18).ToString
                        .txFonoSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(19).ToString
                        .txFonoSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(20).ToString
                        .txCelularSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(21).ToString
                        .txCelularSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(22).ToString
                        .txFaxSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(23).ToString
                        .txFaxSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(24).ToString
                        .txEmailSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(25).ToString
                        .txEmailSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(26).ToString
                        .txRemite.Text = dsProductor.Tables(0).Rows(0).Item(27).ToString
                        .txFonoRemite1.Text = dsProductor.Tables(0).Rows(0).Item(28).ToString
                        .txFonoRemite2.Text = dsProductor.Tables(0).Rows(0).Item(29).ToString
                        .txCelularRemite1.Text = dsProductor.Tables(0).Rows(0).Item(30).ToString
                        .txCelularRemite2.Text = dsProductor.Tables(0).Rows(0).Item(31).ToString
                        .txFaxRemite1.Text = dsProductor.Tables(0).Rows(0).Item(32).ToString
                        .txFaxRemite2.Text = dsProductor.Tables(0).Rows(0).Item(33).ToString
                        .txEmailRemite1.Text = dsProductor.Tables(0).Rows(0).Item(34).ToString
                        .txEmail2Re.Text = dsProductor.Tables(0).Rows(0).Item(35).ToString
                        .txRutFactura.Text = dsProductor.Tables(0).Rows(0).Item(36).ToString
                        If .txRazonSocial.Text = "" Then
                            .txRazonSocial.Text = dsProductor.Tables(0).Rows(0).Item(37).ToString
                            .txFonoRS1.Text = dsProductor.Tables(0).Rows(0).Item(38).ToString
                            .txFonoRS2.Text = dsProductor.Tables(0).Rows(0).Item(39).ToString
                            .txGiro.Text = dsProductor.Tables(0).Rows(0).Item(40).ToString
                            .txDireccionRS.Text = dsProductor.Tables(0).Rows(0).Item(41).ToString
                            .cbComunaRS.Text = dsProductor.Tables(0).Rows(0).Item(42).ToString
                            .cbCiudadRS.Text = dsProductor.Tables(0).Rows(0).Item(43).ToString
                            .txEncargadoPago.Text = dsProductor.Tables(0).Rows(0).Item(44).ToString
                            .txFonoPagoRS1.Text = dsProductor.Tables(0).Rows(0).Item(45).ToString
                            .txFonoPagoRS2.Text = dsProductor.Tables(0).Rows(0).Item(46).ToString
                            .txEmailRS1.Text = dsProductor.Tables(0).Rows(0).Item(48).ToString
                            .txEmailRS2.Text = dsProductor.Tables(0).Rows(0).Item(49).ToString

                        End If
                        If .txSenores.Text = "" Then
                            .txOtroDespacho.Text = dsProductor.Tables(0).Rows(0).Item(58).ToString
                            .txSenores.Text = dsProductor.Tables(0).Rows(0).Item(59).ToString
                            .txAtencion.Text = dsProductor.Tables(0).Rows(0).Item(60).ToString
                            .txDireccionDespacho.Text = dsProductor.Tables(0).Rows(0).Item(61).ToString
                            .txCasilla.Text = dsProductor.Tables(0).Rows(0).Item(62).ToString
                            .cbCiudadDespacho.Text = dsProductor.Tables(0).Rows(0).Item(64).ToString
                            .cbComunaDespacho.Text = dsProductor.Tables(0).Rows(0).Item(63).ToString
                            'ot.dtFechaDespacho.Text = dr.Item(66)
                            .txFonoDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(66).ToString
                            .txFonoDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(67).ToString
                            .txFaxDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(70).ToString
                            .txFaxDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(71).ToString
                            .txCelularDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(68).ToString
                            .txCelularDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(69).ToString
                            .txEmailDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(72).ToString
                            .txEmailDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(73).ToString
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(51).ToString) = 0 Then
                            .chRetiraLab.Checked = False
                        Else
                            .chRetiraLab.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(52).ToString) = 0 Then
                            .chAvisaFono.Checked = False
                        Else
                            .chAvisaFono.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(53).ToString) = 0 Then
                            .chFax.Checked = False
                        Else
                            .chFax.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(54).ToString) = 0 Then
                            .chEmail.Checked = False
                        Else
                            .chEmail.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(55).ToString) = 0 Then
                            .chCorreo.Checked = False
                        Else
                            .chCorreo.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(56).ToString) = 0 Then
                            .chBus.Checked = False
                        Else
                            .chBus.Checked = True
                        End If
                        If (dsProductor.Tables(0).Rows(0).Item(57).ToString) = 0 Then
                            .chOtro.Checked = False
                        Else
                            .chOtro.Checked = True
                        End If

                    End With
                Else
                    Me.txSenores.Text = cbProductor.Text
                    Me.txRazonSocial.Text = cbProductor.Text
                    Me.txFonoRS1.Text = Me.txFono1.Text
                End If
            Catch ex As Exception

            End Try
            'Me.txRazonSocial.Text = Me.cbProductor.Text
            'Me.txSenores.Text = Me.cbProductor.Text
            Me.cbEmpresa.Focus()
        End If
    End Sub

    Private Sub cbProductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbProductor.KeyPress

        If e.KeyChar = Chr(13) Then


            Try

                Dim cd As New CapaDato
                Dim ds As New DataSet
                cd.Inicializar()
                cd.AgregarParametro("@productor", Me.cbProductor.Text, SqlDbType.VarChar)
                dsProductor = cd.EjecutarQuery("ls_traeDatosProductor")

                If dsProductor.Tables(0).Rows.Count <> 0 Then
                    With Me
                        .txRutProductor.Text = dsProductor.Tables(0).Rows(0).Item(1).ToString
                        .cbProductor.Text = dsProductor.Tables(0).Rows(0).Item(0).ToString
                        .txDireccion.Text = dsProductor.Tables(0).Rows(0).Item(4).ToString
                        .cbEmpresa.Text = dsProductor.Tables(0).Rows(0).Item(2).ToString
                        .txPredio.Text = dsProductor.Tables(0).Rows(0).Item(3).ToString

                        If dsProductor.Tables(0).Rows(0).Item(9).ToString <> "" Then
                            If dsProductor.Tables(0).Rows(0).Item(9).ToString = "1" Then
                                .cbRegionN.Text = "I - Tarapaca"
                                .cbRegionN.SelectedValue = 1
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "2" Then
                                .cbRegionN.Text = "II - Antofagasta"
                                .cbRegionN.SelectedValue = 2
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "3" Then
                                .cbRegionN.Text = "III - Atacama"
                                .cbRegionN.SelectedValue = 3
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "4" Then
                                .cbRegionN.Text = "IV - Coquimbo"
                                .cbRegionN.SelectedValue = 4
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "5" Then
                                .cbRegionN.Text = "V - Valparaiso"
                                .cbRegionN.SelectedValue = 5
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "6" Then
                                .cbRegionN.Text = "VI - Gral.B.O`Higgins"
                                .cbRegionN.SelectedValue = 6
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "7" Then
                                .cbRegionN.Text = "VII - Maule"
                                .cbRegionN.SelectedValue = 7
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "8" Then
                                .cbRegionN.Text = "VIII - Biobio"
                                .cbRegionN.SelectedValue = 8
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "9" Then
                                .cbRegionN.Text = "IX - Araucania"
                                .cbRegionN.SelectedValue = 9
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "10" Then
                                .cbRegionN.Text = "X - De los Lagos"
                                .cbRegionN.SelectedValue = 10
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "11" Then
                                .cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)"
                                .cbRegionN.SelectedValue = 11
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "12" Then
                                .cbRegionN.Text = "XII - Magallanes Y Antartica Ch."
                                .cbRegionN.SelectedValue = 12
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "13" Then
                                .cbRegionN.Text = "XIII - Metropolitana"
                                .cbRegionN.SelectedValue = 13
                            ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "0" Then
                                .cbRegionN.Text = "Seleccione Region"
                                .cbRegionN.SelectedValue = 0
                            End If
                        End If

                        .cbLocalidad.Text = dsProductor.Tables(0).Rows(0).Item(5).ToString
                        .cbCiudad.Text = dsProductor.Tables(0).Rows(0).Item(7).ToString
                        .cbComuna.Text = dsProductor.Tables(0).Rows(0).Item(6).ToString
                        .cbProvincia.Text = dsProductor.Tables(0).Rows(0).Item(8).ToString
                        .txFono1.Text = dsProductor.Tables(0).Rows(0).Item(10).ToString
                        .txFono2.Text = dsProductor.Tables(0).Rows(0).Item(11).ToString
                        .txCelular1.Text = dsProductor.Tables(0).Rows(0).Item(12).ToString
                        .txCelular2.Text = dsProductor.Tables(0).Rows(0).Item(13).ToString
                        .txFax1.Text = dsProductor.Tables(0).Rows(0).Item(14).ToString
                        'ot.txFax2.Text = dr.Item(15).ToString
                        .txEmail1.Text = dsProductor.Tables(0).Rows(0).Item(16).ToString
                        .txEmail2.Text = dsProductor.Tables(0).Rows(0).Item(17).ToString
                        .txSolicita.Text = dsProductor.Tables(0).Rows(0).Item(18).ToString
                        .txFonoSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(19).ToString
                        .txFonoSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(20).ToString
                        .txCelularSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(21).ToString
                        .txCelularSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(22).ToString
                        .txFaxSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(23).ToString
                        .txFaxSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(24).ToString
                        .txEmailSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(25).ToString
                        .txEmailSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(26).ToString
                        .txRemite.Text = dsProductor.Tables(0).Rows(0).Item(27).ToString
                        .txFonoRemite1.Text = dsProductor.Tables(0).Rows(0).Item(28).ToString
                        .txFonoRemite2.Text = dsProductor.Tables(0).Rows(0).Item(29).ToString
                        .txCelularRemite1.Text = dsProductor.Tables(0).Rows(0).Item(30).ToString
                        .txCelularRemite2.Text = dsProductor.Tables(0).Rows(0).Item(31).ToString
                        .txFaxRemite1.Text = dsProductor.Tables(0).Rows(0).Item(32).ToString
                        .txFaxRemite2.Text = dsProductor.Tables(0).Rows(0).Item(33).ToString
                        .txEmailRemite1.Text = dsProductor.Tables(0).Rows(0).Item(34).ToString
                        .txEmail2Re.Text = dsProductor.Tables(0).Rows(0).Item(35).ToString
                        .txRutFactura.Text = dsProductor.Tables(0).Rows(0).Item(36).ToString
                        If .txRazonSocial.Text = "" Then
                            .txRazonSocial.Text = dsProductor.Tables(0).Rows(0).Item(37).ToString
                            .txFonoRS1.Text = dsProductor.Tables(0).Rows(0).Item(38).ToString
                            .txFonoRS2.Text = dsProductor.Tables(0).Rows(0).Item(39).ToString
                            .txGiro.Text = dsProductor.Tables(0).Rows(0).Item(40).ToString
                            .txDireccionRS.Text = dsProductor.Tables(0).Rows(0).Item(41).ToString
                            .cbComunaRS.Text = dsProductor.Tables(0).Rows(0).Item(42).ToString
                            .cbCiudadRS.Text = dsProductor.Tables(0).Rows(0).Item(43).ToString
                            .txEncargadoPago.Text = dsProductor.Tables(0).Rows(0).Item(44).ToString
                            .txFonoPagoRS1.Text = dsProductor.Tables(0).Rows(0).Item(45).ToString
                            .txFonoPagoRS2.Text = dsProductor.Tables(0).Rows(0).Item(46).ToString
                            .txEmailRS1.Text = dsProductor.Tables(0).Rows(0).Item(48).ToString
                            .txEmailRS2.Text = dsProductor.Tables(0).Rows(0).Item(49).ToString

                        End If
                        If .txSenores.Text = "" Then
                            .txOtroDespacho.Text = dsProductor.Tables(0).Rows(0).Item(58).ToString
                            .txSenores.Text = dsProductor.Tables(0).Rows(0).Item(59).ToString
                            .txAtencion.Text = dsProductor.Tables(0).Rows(0).Item(60).ToString
                            .txDireccionDespacho.Text = dsProductor.Tables(0).Rows(0).Item(61).ToString
                            .txCasilla.Text = dsProductor.Tables(0).Rows(0).Item(62).ToString
                            .cbCiudadDespacho.Text = dsProductor.Tables(0).Rows(0).Item(64).ToString
                            .cbComunaDespacho.Text = dsProductor.Tables(0).Rows(0).Item(63).ToString
                            'ot.dtFechaDespacho.Text = dr.Item(66)
                            .txFonoDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(66).ToString
                            .txFonoDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(67).ToString
                            .txFaxDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(70).ToString
                            .txFaxDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(71).ToString
                            .txCelularDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(68).ToString
                            .txCelularDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(69).ToString
                            .txEmailDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(72).ToString
                            .txEmailDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(73).ToString
                        End If
                        If (dsProductor.Tables(0).Rows(0).Item(51).ToString) = 0 Then
                            .chRetiraLab.Checked = False
                        Else
                            .chRetiraLab.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(52).ToString) = 0 Then
                            .chAvisaFono.Checked = False
                        Else
                            .chAvisaFono.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(53).ToString) = 0 Then
                            .chFax.Checked = False
                        Else
                            .chFax.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(54).ToString) = 0 Then
                            .chEmail.Checked = False
                        Else
                            .chEmail.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(55).ToString) = 0 Then
                            .chCorreo.Checked = False
                        Else
                            .chCorreo.Checked = True
                        End If

                        If (dsProductor.Tables(0).Rows(0).Item(56).ToString) = 0 Then
                            .chBus.Checked = False
                        Else
                            .chBus.Checked = True
                        End If
                        If (dsProductor.Tables(0).Rows(0).Item(57).ToString) = 0 Then
                            .chOtro.Checked = False
                        Else
                            .chOtro.Checked = True
                        End If
                    End With
                Else
                    Me.txSenores.Text = cbProductor.Text
                    Me.txRazonSocial.Text = cbProductor.Text
                    Me.txFonoRS1.Text = Me.txFono1.Text
                End If


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnCargaProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaProductor.Click
        Try

            Dim cd As New CapaDato
            Dim ds As New DataSet
            cd.Inicializar()
            cd.AgregarParametro("@productor", Me.cbProductor.Text, SqlDbType.VarChar)
            dsProductor = cd.EjecutarQuery("ls_traeDatosProductor")

            If dsProductor.Tables(0).Rows.Count <> 0 Then
                With Me
                    .txRutProductor.Text = dsProductor.Tables(0).Rows(0).Item(1).ToString
                    .cbProductor.Text = dsProductor.Tables(0).Rows(0).Item(0).ToString
                    .txDireccion.Text = dsProductor.Tables(0).Rows(0).Item(4).ToString
                    .cbEmpresa.Text = dsProductor.Tables(0).Rows(0).Item(2).ToString
                    .txPredio.Text = dsProductor.Tables(0).Rows(0).Item(3).ToString

                    If dsProductor.Tables(0).Rows(0).Item(9).ToString <> "" Then
                        If dsProductor.Tables(0).Rows(0).Item(9).ToString = "1" Then
                            .cbRegionN.Text = "I - Tarapaca"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "2" Then
                            .cbRegionN.Text = "II - Antofagasta"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "3" Then
                            .cbRegionN.Text = "III - Atacama"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "4" Then
                            .cbRegionN.Text = "IV - Coquimbo"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "5" Then
                            .cbRegionN.Text = "V - Valparaiso"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "6" Then
                            .cbRegionN.Text = "VI - Gral.B.O`Higgins"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "7" Then
                            .cbRegionN.Text = "VII - Maule"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "8" Then
                            .cbRegionN.Text = "VIII - Biobio"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "9" Then
                            .cbRegionN.Text = "IX - Araucania"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "10" Then
                            .cbRegionN.Text = "X - De los Lagos"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "11" Then
                            .cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "12" Then
                            .cbRegionN.Text = "XII - Magallanes Y Antartica Ch."
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "13" Then
                            .cbRegionN.Text = "XIII - Metropolitana"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "14" Then
                            .cbRegionN.Text = "XIV - Los Ríos"
                        ElseIf dsProductor.Tables(0).Rows(0).Item(9).ToString = "15" Then
                            .cbRegionN.Text = "XV - Arica y Parinacota"
                        End If
                    End If

                    .cbLocalidad.Text = dsProductor.Tables(0).Rows(0).Item(5).ToString
                    .cbCiudad.Text = dsProductor.Tables(0).Rows(0).Item(7).ToString
                    .cbComuna.Text = dsProductor.Tables(0).Rows(0).Item(6).ToString
                    .cbProvincia.Text = dsProductor.Tables(0).Rows(0).Item(8).ToString
                    .txFono1.Text = dsProductor.Tables(0).Rows(0).Item(10).ToString
                    .txFono2.Text = dsProductor.Tables(0).Rows(0).Item(11).ToString
                    .txCelular1.Text = dsProductor.Tables(0).Rows(0).Item(12).ToString
                    .txCelular2.Text = dsProductor.Tables(0).Rows(0).Item(13).ToString
                    .txFax1.Text = dsProductor.Tables(0).Rows(0).Item(14).ToString
                    'ot.txFax2.Text = dr.Item(15).ToString
                    .txEmail1.Text = dsProductor.Tables(0).Rows(0).Item(16).ToString
                    .txEmail2.Text = dsProductor.Tables(0).Rows(0).Item(17).ToString
                    .txSolicita.Text = dsProductor.Tables(0).Rows(0).Item(18).ToString
                    .txFonoSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(19).ToString
                    .txFonoSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(20).ToString
                    .txCelularSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(21).ToString
                    .txCelularSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(22).ToString
                    .txFaxSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(23).ToString
                    .txFaxSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(24).ToString
                    .txEmailSolicita1.Text = dsProductor.Tables(0).Rows(0).Item(25).ToString
                    .txEmailSolicita2.Text = dsProductor.Tables(0).Rows(0).Item(26).ToString
                    .txRemite.Text = dsProductor.Tables(0).Rows(0).Item(27).ToString
                    .txFonoRemite1.Text = dsProductor.Tables(0).Rows(0).Item(28).ToString
                    .txFonoRemite2.Text = dsProductor.Tables(0).Rows(0).Item(29).ToString
                    .txCelularRemite1.Text = dsProductor.Tables(0).Rows(0).Item(30).ToString
                    .txCelularRemite2.Text = dsProductor.Tables(0).Rows(0).Item(31).ToString
                    .txFaxRemite1.Text = dsProductor.Tables(0).Rows(0).Item(32).ToString
                    .txFaxRemite2.Text = dsProductor.Tables(0).Rows(0).Item(33).ToString
                    .txEmailRemite1.Text = dsProductor.Tables(0).Rows(0).Item(34).ToString
                    .txEmail2Re.Text = dsProductor.Tables(0).Rows(0).Item(35).ToString
                    .txRutFactura.Text = dsProductor.Tables(0).Rows(0).Item(36).ToString
                    .txRutFactura.Text = dsProductor.Tables(0).Rows(0).Item(36).ToString
                    If .txRazonSocial.Text = "" Then
                        .txRazonSocial.Text = dsProductor.Tables(0).Rows(0).Item(37).ToString
                        .txFonoRS1.Text = dsProductor.Tables(0).Rows(0).Item(38).ToString
                        .txFonoRS2.Text = dsProductor.Tables(0).Rows(0).Item(39).ToString
                        .txGiro.Text = dsProductor.Tables(0).Rows(0).Item(40).ToString
                        .txDireccionRS.Text = dsProductor.Tables(0).Rows(0).Item(41).ToString
                        .cbComunaRS.Text = dsProductor.Tables(0).Rows(0).Item(42).ToString
                        .cbCiudadRS.Text = dsProductor.Tables(0).Rows(0).Item(43).ToString
                        .txEncargadoPago.Text = dsProductor.Tables(0).Rows(0).Item(44).ToString
                        .txFonoPagoRS1.Text = dsProductor.Tables(0).Rows(0).Item(45).ToString
                        .txFonoPagoRS2.Text = dsProductor.Tables(0).Rows(0).Item(46).ToString
                        .txEmailRS1.Text = dsProductor.Tables(0).Rows(0).Item(48).ToString
                        .txEmailRS2.Text = dsProductor.Tables(0).Rows(0).Item(49).ToString

                    End If
                    If .txSenores.Text = "" Then
                        .txOtroDespacho.Text = dsProductor.Tables(0).Rows(0).Item(58).ToString
                        .txSenores.Text = dsProductor.Tables(0).Rows(0).Item(59).ToString
                        .txAtencion.Text = dsProductor.Tables(0).Rows(0).Item(60).ToString
                        .txDireccionDespacho.Text = dsProductor.Tables(0).Rows(0).Item(61).ToString
                        .txCasilla.Text = dsProductor.Tables(0).Rows(0).Item(62).ToString
                        .cbCiudadDespacho.Text = dsProductor.Tables(0).Rows(0).Item(64).ToString
                        .cbComunaDespacho.Text = dsProductor.Tables(0).Rows(0).Item(63).ToString
                        'ot.dtFechaDespacho.Text = dr.Item(66)
                        .txFonoDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(66).ToString
                        .txFonoDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(67).ToString
                        .txFaxDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(70).ToString
                        .txFaxDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(71).ToString
                        .txCelularDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(68).ToString
                        .txCelularDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(69).ToString
                        .txEmailDespacho1.Text = dsProductor.Tables(0).Rows(0).Item(72).ToString
                        .txEmailDespacho2.Text = dsProductor.Tables(0).Rows(0).Item(73).ToString
                    End If
                    If (dsProductor.Tables(0).Rows(0).Item(51).ToString) = 0 Then
                        .chRetiraLab.Checked = False
                    Else
                        .chRetiraLab.Checked = True
                    End If

                    If (dsProductor.Tables(0).Rows(0).Item(52).ToString) = 0 Then
                        .chAvisaFono.Checked = False
                    Else
                        .chAvisaFono.Checked = True
                    End If

                    If (dsProductor.Tables(0).Rows(0).Item(53).ToString) = 0 Then
                        .chFax.Checked = False
                    Else
                        .chFax.Checked = True
                    End If

                    If (dsProductor.Tables(0).Rows(0).Item(54).ToString) = 0 Then
                        .chEmail.Checked = False
                    Else
                        .chEmail.Checked = True
                    End If

                    If (dsProductor.Tables(0).Rows(0).Item(55).ToString) = 0 Then
                        .chCorreo.Checked = False
                    Else
                        .chCorreo.Checked = True
                    End If

                    If (dsProductor.Tables(0).Rows(0).Item(56).ToString) = 0 Then
                        .chBus.Checked = False
                    Else
                        .chBus.Checked = True
                    End If
                    If (dsProductor.Tables(0).Rows(0).Item(57).ToString) = 0 Then
                        .chOtro.Checked = False
                    Else
                        .chOtro.Checked = True
                    End If


                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEmpresaCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaCarga.Click


        Dim empresa As New G_Empresa
        empresa.Owner = Me
        empresa.Show()
    End Sub

    Private Sub txRutFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txRutFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            If ValidaRut(Me.txRutFactura.Text) = False Then
                MsgBox("Rut de Factura Inválido")
                GoTo final
            End If
            '##########################################      REVISAR        #################################################
            If Me.txRutFactura.Text = Me.txRutProductor.Text Then
                'If Me.txRutFactura.Text <> "" Then
                'Me.txRutFactura.Text = Me.txRutProductor.Text
                Dim dsProductor As New DataSet
                Dim cn As New CapaNegocio
                dsProductor = cn.buscaProductor(Me.txRutFactura.Text, "", "", "")
                If dsProductor.Tables(0).Rows.Count <> 0 Then
                    btnProductor_Click(sender, e)
                Else
                    MsgBox("El usuario no existe", MsgBoxStyle.Information)
                End If
            Else
                If Me.txRutFactura.Text <> "" Then

                    Dim dsProductor As New DataSet
                    Dim cn As New CapaNegocio
                    dsProductor = cn.buscaProductorporEmpresa(Me.txRutFactura.Text, "", "", "")
                    If dsProductor.Tables(0).Rows.Count <> 0 Then
                        btnProductor_Click(sender, e)
                    Else
                        MsgBox("El usuario no existe", MsgBoxStyle.Information)
                    End If
                    'Else

                    '    Dim cd As New CapaDato
                    '    Dim dsRS As New DataSet

                    '    cd.Inicializar()
                    '    cd.AgregarParametro("@rut", Me.txRutFactura.Text, SqlDbType.VarChar)
                    '    dsRS = cd.EjecutarQuery("ls_obtieneRsocial")

                    '    Me.txRazonSocial.Text = dsRS.Tables(0).Rows.Item(0).Item(0).ToString
                    '    Me.txFonoRS1.Text = dsRS.Tables(0).Rows.Item(0).Item(1).ToString
                    '    Me.txFonoRS2.Text = dsRS.Tables(0).Rows.Item(0).Item(2).ToString
                    '    Me.txGiro.Text = dsRS.Tables(0).Rows.Item(0).Item(3).ToString
                    '    Me.txDireccionRS.Text = dsRS.Tables(0).Rows.Item(0).Item(4).ToString
                    '    Me.cbCiudadRS.Text = dsRS.Tables(0).Rows.Item(0).Item(5).ToString
                    '    Me.cbComunaRS.Text = dsRS.Tables(0).Rows.Item(0).Item(6).ToString
                    '    Me.txEncargadoPago.Text = dsRS.Tables(0).Rows.Item(0).Item(7).ToString
                    '    Me.txFonoPagoRS1.Text = dsRS.Tables(0).Rows.Item(0).Item(8).ToString
                    '    Me.txFonoPagoRS2.Text = dsRS.Tables(0).Rows.Item(0).Item(9).ToString
                    '    Me.txEmailRS1.Text = dsRS.Tables(0).Rows.Item(0).Item(10).ToString
                    '    Me.txEmailRS2.Text = dsRS.Tables(0).Rows.Item(0).Item(11).ToString

                End If
final:

            End If
            Me.cbProductor.Focus()
        End If

    End Sub


    Private Sub txFono1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFono1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFonoRS1.Text = Me.txFono1.Text
            Me.txFonoDespacho1.Text = Me.txFono1.Text
            Me.txFono2.Focus()
        End If
    End Sub

    Private Sub btnEliminaAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaAnalisis.Click
        Try
            Dim cd As New CapaDato

            If Me.dgDetalle.Rows.Item(guardaIndice).Cells.Item(0).Value <> "" Then
                cd.Inicializar()
                cd.AgregarParametro("@not", CInt(Me.lblNot.Text), SqlDbType.Int)
                cd.AgregarParametro("@analisis", CInt(Me.dgDetalle.Rows.Item(guardaIndice).Cells.Item(0).Value), SqlDbType.Int)
                cd.AgregarParametro("@nLabDesde", CInt(Me.dgDetalle.Rows.Item(guardaIndice).Cells.Item(3).Value), SqlDbType.Int)
                cd.AgregarParametro("@nLabHasta", CInt(Me.dgDetalle.Rows.Item(guardaIndice).Cells.Item(4).Value), SqlDbType.Int)
                cd.EjecutarQuery("ls_borraNlabComprometido")
            End If
            Me.dgDetalle.Rows.RemoveAt(guardaIndice)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txEmail2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmail2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailDespacho2.Text = Me.txEmail2.Text
            Me.txSolicita.Focus()
        End If
    End Sub

    Private Sub txPredio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPredio.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txPredio.Text
            Call control_nombre(NOMBREX)
            Me.txPredio.Text = NOMBREX
            Me.txDireccion.Focus()
        End If
    End Sub

    Private Sub txSenores_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txSenores.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txSenores.Text
            Call control_nombre(NOMBREX)
            Me.txSenores.Text = NOMBREX
            Me.txAtencion.Focus()
        End If
    End Sub

    Private Sub txAtencion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txAtencion.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txAtencion.Text
            Call control_nombre(NOMBREX)
            Me.txAtencion.Text = NOMBREX
            Me.txDireccionDespacho.Focus()
        End If
    End Sub

    Private Sub txDireccionDespacho_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txDireccionDespacho.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txDireccionDespacho.Text
            Call control_nombre(NOMBREX)
            Me.txDireccionDespacho.Text = NOMBREX
            Me.cbCiudadDespacho.Focus()
        End If
    End Sub

    Private Sub txCasilla_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCasilla.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFaxDespacho1.Focus()
        End If
    End Sub

    Private Sub txFonoDespacho1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoDespacho1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFonoDespacho2.Focus()
        End If
    End Sub

    Private Sub txFonoDespacho2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoDespacho2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCelularDespacho1.Focus()
        End If
    End Sub

    Private Sub txCelularDespacho1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelularDespacho1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCelularDespacho2.Focus()
        End If
    End Sub

    Private Sub txCelularDespacho2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelularDespacho2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtFechaDespacho.Focus()
        End If
    End Sub

    Private Sub txFaxDespacho1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFaxDespacho1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFaxDespacho2.Focus()
        End If
    End Sub

    Private Sub txFaxDespacho2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFaxDespacho2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFonoDespacho1.Focus()
        End If
    End Sub

    Private Sub txEmailDespacho1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmailDespacho1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailDespacho2.Focus()
        End If
    End Sub

    Private Sub txEmailDespacho2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmailDespacho2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbIngreso.Focus()
        End If
    End Sub

    Private Sub txDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txDireccion.KeyPress

        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txDireccion.Text
            Call control_nombre(NOMBREX)
            Me.txDireccion.Text = NOMBREX
            Me.cbLocalidad.Focus()
        End If

    End Sub

    Private Sub cbCiudad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbCiudad.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbProvincia.Focus()
        End If
    End Sub

    Private Sub cbProvincia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProvincia.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbRegionN.Focus()
        End If

    End Sub

    Private Sub cbRegionN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbRegionN.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.txCelular1.Focus()
        End If
    End Sub

    Private Sub txCelular1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelular1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCelularDespacho1.Text = txCelular1.Text
            Me.txCelular2.Focus()
        End If
    End Sub

    Private Sub txCelular2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelular2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFono1.Focus()
        End If
    End Sub

    Private Sub txFono2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFono2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFax1.Focus()
        End If
    End Sub



    Private Sub txRemite_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txRemite.KeyPress

        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txRemite.Text
            Call control_nombre(NOMBREX)
            Me.txRemite.Text = NOMBREX
            Me.txFonoRemite1.Focus()
        End If
    End Sub

    Private Sub txFonoRemite1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoRemite1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFonoRemite2.Focus()
        End If
    End Sub

    Private Sub txFonoRemite2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoRemite2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCelularRemite1.Focus()
        End If
    End Sub

    Private Sub txCelularRemite1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelularRemite1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCelularRemite2.Focus()
        End If
    End Sub

    Private Sub txCelularRemite2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelularRemite2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFaxRemite1.Focus()
        End If
    End Sub

    Private Sub txFaxRemite1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFaxRemite1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFaxRemite2.Focus()
        End If
    End Sub

    Private Sub txFaxRemite2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFaxRemite2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailRemite1.Focus()
        End If
    End Sub

    Private Sub txEmailRemite1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmailRemite1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmail2Re.Focus()
        End If
    End Sub

    Private Sub txEmail2Re_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmail2Re.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txRazonSocial.Focus()
        End If
    End Sub

    Private Sub txRazonSocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txRazonSocial.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txRazonSocial.Text
            Call control_nombre(NOMBREX)
            Me.txRazonSocial.Text = NOMBREX
            Me.txFonoRS1.Focus()
        End If
    End Sub

    Private Sub txFonoRS1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoRS1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFonoPagoRS1.Text = txFonoRS1.Text
            Me.txFonoRS2.Focus()
        End If
    End Sub

    Private Sub txFonoRS2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoRS2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txGiro.Focus()
        End If
    End Sub

    Private Sub txGiro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txGiro.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txGiro.Text
            Call control_nombre(NOMBREX)
            Me.txGiro.Text = NOMBREX
            Me.txDireccionRS.Focus()
        End If
    End Sub

    Private Sub txDireccionRS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txDireccionRS.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txDireccionRS.Text
            Call control_nombre(NOMBREX)
            Me.txDireccionRS.Text = NOMBREX
            Me.cbCiudadRS.Focus()
        End If
    End Sub

    Private Sub cbCiudadRS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbCiudadRS.KeyDown
        If e.KeyData = Keys.Enter Then

            Me.cbComunaRS.Focus()
        End If
    End Sub

    Private Sub cbComunaRS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbComunaRS.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.txEncargadoPago.Focus()
        End If
    End Sub

    Private Sub txEncargadoPago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEncargadoPago.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txEncargadoPago.Text
            Call control_nombre(NOMBREX)
            Me.txEncargadoPago.Text = NOMBREX
            Me.txFonoPagoRS1.Focus()
        End If
    End Sub

    Private Sub txFonoPagoRS1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoPagoRS1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFonoPagoRS2.Focus()
        End If
    End Sub

    Private Sub txFonoPagoRS2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoPagoRS2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailRS1.Focus()
        End If
    End Sub

    Private Sub txEmailRS1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmailRS1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailRS2.Focus()
        End If
    End Sub

    Private Sub txEmailRS2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmailRS2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txOtroDespacho.Focus()
        End If
    End Sub

    Private Sub txOtroDespacho_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txOtroDespacho.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Me.txOtroDespacho.Text
            Call control_nombre(NOMBREX)
            Me.txOtroDespacho.Text = NOMBREX
            Me.txSenores.Focus()
        End If
    End Sub

    Private Sub cbCiudadDespacho_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbCiudadDespacho.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbComunaDespacho.Focus()
        End If
    End Sub

    Private Sub cbComunaDespacho_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbComunaDespacho.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim cd As New CapaDato
            Dim ds As New DataSet
            cd.Inicializar()
            cd.AgregarParametro("@comuna", Me.cbComunaDespacho.Text, SqlDbType.VarChar)
            dsProductor = cd.EjecutarQuery("ys_trae_ciudad")

            If dsProductor.Tables(0).Rows.Count <> 0 Then
                Me.cbCiudadDespacho.Text = dsProductor.Tables(0).Rows(0).Item(0).ToString
            End If

            Me.txCasilla.Focus()

        End If
    End Sub

    Private Sub txFonoSolicita1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoSolicita1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFonoSolicita2.Focus()
        End If
    End Sub

    Private Sub txFonoSolicita2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFonoSolicita2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCelularSolicita1.Focus()
        End If
    End Sub

    Private Sub txCelularSolicita1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelularSolicita1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txCelularSolicita2.Focus()
        End If
    End Sub

    Private Sub txCelularSolicita2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCelularSolicita2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFaxSolicita1.Focus()
        End If
    End Sub

    Private Sub txFaxSolicita1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFaxSolicita1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFaxSolicita2.Focus()
        End If
    End Sub

    Private Sub txFaxSolicita2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFaxSolicita2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailSolicita1.Focus()
        End If
    End Sub

    Private Sub txEmailSolicita1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmailSolicita1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailSolicita2.Focus()
        End If
    End Sub

    Private Sub txEmailSolicita2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txEmailSolicita2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txRemite.Focus()
        End If
    End Sub

    Private Sub dgAgua_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAgua.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "3004") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 3001
                    ElseIf b <> 1 Then
                        codigoVar = 3002
                    ElseIf c <> 1 Then
                        codigoVar = 3003
                    ElseIf d <> 1 Then
                        codigoVar = 3004
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then

                    asigna.txCantidad.Text = Me.chListaDeNlab.CheckedItems.Count
                    ' asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub



    Private Sub dgFertOrg_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFertOrg.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "6004") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 6001
                    ElseIf b <> 1 Then
                        codigoVar = 6002
                    ElseIf c <> 1 Then
                        codigoVar = 6003
                    ElseIf d <> 1 Then
                        codigoVar = 6004
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then
                    asigna.txCantidad.Text = cantChKl.ToString
                    'asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgFertQui_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFertQui.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "5004") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 5001
                    ElseIf b <> 1 Then
                        codigoVar = 5002
                    ElseIf c <> 1 Then
                        codigoVar = 5003
                    ElseIf d <> 1 Then
                        codigoVar = 5004
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then
                    asigna.txCantidad.Text = cantChKl.ToString
                    'asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgFitopatologia_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFitopatologia.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "7004") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 7001
                    ElseIf b <> 1 Then
                        codigoVar = 7002
                    ElseIf c <> 1 Then
                        codigoVar = 7003
                    ElseIf d <> 1 Then
                        codigoVar = 7004
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then
                    asigna.txCantidad.Text = cantChKl.ToString
                    'asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgFoliar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFoliar.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "1600") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 1001
                    ElseIf b <> 1 Then
                        codigoVar = 1002
                    ElseIf c <> 1 Then
                        codigoVar = 1003
                    ElseIf d <> 1 Then
                        codigoVar = 1600
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion

                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then
                    asigna.txCantidad.Text = cantChKl.ToString
                    'asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgKitOtros_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgKitOtros.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "8004") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 8001
                    ElseIf b <> 1 Then
                        codigoVar = 8002
                    ElseIf c <> 1 Then
                        codigoVar = 8003
                    ElseIf d <> 1 Then
                        codigoVar = 8004
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then
                    asigna.txCantidad.Text = cantChKl.ToString
                    'asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgSuelo_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSuelo.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "4004") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 4001
                    ElseIf b <> 1 Then
                        codigoVar = 4002
                    ElseIf c <> 1 Then
                        codigoVar = 4003
                    ElseIf d <> 1 Then
                        codigoVar = 4004
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then
                    asigna.txCantidad.Text = cantChKl.ToString
                    'asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgTejido_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTejido.CellDoubleClick
        Try
            Dim dg As New DataGridView
            Dim dt As New Data.DataTable
            Dim dr As Data.DataRow
            Dim arr, arr2 As Array
            Dim a, b, c, d, i, j, k, l, m, r, s As Integer

            Dim descripcion, codigoVar As String
            i = 0
            j = 0
            m = 0
            dg = sender
            dt = dg.DataSource
            dr = dt.Rows(e.RowIndex)

            If unir = True Then

                If existeFila = False Then

                    r = Me.dgAsignado.Rows.Count - 1
                    s = 0
                    While s < r
                        If (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2001") Then
                            a = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2002") Then
                            b = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2003") Then
                            c = 1
                        ElseIf (Me.dgAsignado.Rows.Item(s).Cells.Item(0).Value.ToString = "2004") Then
                            d = 1
                        End If
                        s = s + 1
                    End While


                    If a <> 1 Then
                        codigoVar = 2001
                    ElseIf b <> 1 Then
                        codigoVar = 2002
                    ElseIf c <> 1 Then
                        codigoVar = 2003
                    ElseIf d <> 1 Then
                        codigoVar = 2004
                    End If

                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = codigoVar.ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(1).ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ""
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(2).ToString
                    dgvRow.Cells.Add(dgvCell)


                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = dr.Item(0).ToString
                    dgvRow.Cells.Add(dgvCell)

                    Me.dgUnir.Rows.Add(dgvRow)

                    existeFila = True

                Else
                    arr = Split(Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString, "-")
                    arr2 = Split(dr.Item(1).ToString, "-")
                    k = arr.Length
                    l = arr2.Length

                    While i < l
                        While j < k
                            If Trim(arr(j).ToString) = Trim(arr2(i).ToString) Then
                                m = 1
                                Exit While
                            End If
                            j = j + 1
                        End While
                        If m = 0 Then
                            descripcion = descripcion & "-" & Trim(arr2(i).ToString)
                        End If
                        m = 0
                        j = 0
                        i = i + 1
                    End While

                    Me.dgUnir.Rows.Item(0).Cells.Item(4).Value = Me.dgUnir.Rows.Item(0).Cells.Item(4).Value.ToString & "-" & dr.Item(0).ToString
                    Me.dgUnir.Rows.Item(0).Cells.Item(1).Value = Me.dgUnir.Rows.Item(0).Cells.Item(1).Value.ToString & "" & descripcion
                    Me.dgUnir.Rows.Item(0).Cells.Item(3).Value = CInt(Me.dgUnir.Rows.Item(0).Cells.Item(3).Value) + CInt(dr.Item(2))

                End If

            Else
                Dim asigna As New F_AsignaAnalisis
                asigna.Owner = Me
                asigna.txCodigo.Text = dr.Item(0).ToString
                asigna.txDescripcion.Text = dr.Item(1).ToString
                asigna.txValor.Text = dr.Item(2).ToString
                asigna.txCantidad.Focus()
                If Tipo_Ingreso_OT = "Agrega" Then
                    asigna.txCantidad.Text = cantChKl.ToString
                    'asigna.txCantidad.ReadOnly = True
                End If
                asigna.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub




    Private Sub btnAgregaAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaAnalisis.Click

    End Sub

    Private Sub tbCodificacion_Enter(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txFax1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFax1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txFax2.Focus()
        End If
    End Sub

    Private Sub txFax2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txFax2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmail1.Focus()
        End If
    End Sub

    Private Sub dtFechaDespacho_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtFechaDespacho.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txEmailDespacho1.Focus()
        End If
    End Sub

    Private Sub txAbono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txAbono.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txSaldo.Text = CInt(Me.txTotalRe.Text) - CInt(Me.txAbono.Text)
        End If
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'vaDato = "Todos"
        'defineDatos()
        pintaCeldas()
    End Sub

    Private Sub txDescripcionB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txDescripcionB.KeyPress
        If e.KeyChar = Chr(13) Then
            btnBuscarAnalisis_Click(sender, e)
        End If
    End Sub



    Private Sub cbIngreso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbIngreso.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim NOMBREX As String
            NOMBREX = Me.cbIngreso.Text
            Call control_nombre(NOMBREX)
            Me.cbIngreso.Text = NOMBREX
            Me.btnGuardar.Focus()

        End If
    End Sub





    Private Sub tbDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Me.dgDetalle.Rows.Clear()
        ' Determinamos el alto de las filas
        dgDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim colDET As DataGridViewColumn = dgDetalle.Columns(1)
        ' Ajustamos la celda a su contenido.
        colDET.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        colDET.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub dgBusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBusqueda.CellContentClick

    End Sub
    Sub verDatos()

        If vaCodigo >= 1000 And vaCodigo < 2000 Then
            analisisVar = 1000
        ElseIf vaCodigo >= 2000 And vaCodigo < 3000 Then
            analisisVar = 2000
        ElseIf vaCodigo >= 3000 And vaCodigo < 4000 Then
            analisisVar = 3000
        ElseIf vaCodigo >= 4000 And vaCodigo < 5000 Then
            analisisVar = 4000
        ElseIf vaCodigo >= 5000 And vaCodigo < 6000 Then
            analisisVar = 5000
        ElseIf vaCodigo >= 6000 And vaCodigo < 7000 Then
            analisisVar = 6000
        ElseIf vaCodigo = 7302 Then
            analisisVar = 7302
        ElseIf vaCodigo = 7304 Then
            analisisVar = 7304
        ElseIf vaCodigo = 7306 Then
            analisisVar = 7306
        ElseIf vaCodigo = 7308 Then
            analisisVar = 7308
        ElseIf vaCodigo = 8758 Then
            analisisVar = 8758
        ElseIf vaCodigo = 8702 Or vaCodigo = 8704 Or vaCodigo = 8706 Or vaCodigo = 8710 Then
            analisisVar = 8700
        ElseIf vaCodigo >= 7000 And vaCodigo < 8000 Then
            analisisVar = 7000
        ElseIf vaCodigo >= 8000 And vaCodigo < 9000 Then
            analisisVar = 8000
        End If

        If (analisisVar = 1000) Then
            Dim foliar As New F_DatosAgrFoliares
            foliar.Owner = Me
            foliar.Show()
        ElseIf (analisisVar = 2000) Then
            Dim tejidos As New F_DatosAgrTejidos
            tejidos.Owner = Me
            tejidos.Show()
        ElseIf (analisisVar = 3000) Then
            Dim agua As New F_DatosAgrAgua
            agua.Owner = Me
            agua.Show()
        ElseIf (analisisVar = 4000) Then
            Dim suelo As New F_DatosAgrSuelo
            suelo.Owner = Me
            suelo.Show()
        ElseIf (analisisVar = 5000) Then
            Dim fertQui As New F_DatosAgrFertQui
            fertQui.Owner = Me
            fertQui.Show()
        ElseIf (analisisVar = 6000) Then
            Dim fertOrg As New F_DatosAgrFertOrg
            fertOrg.Owner = Me
            fertOrg.Show()
        ElseIf (analisisVar = 7302) Then
            Dim fito As New F_DatosAgrFitopatologia
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 7000) Then
            Dim fito As New F_DatosAgrFitopatologia
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 7304) Then
            Dim fito As New F_DatosAgrFitoRes
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 7306) Then
            Dim fito As New F_DatosAgrFitoEvaluacion
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 7308) Then
            Dim fito As New F_DatosAgrFitoMonitoreo
            fito.Owner = Me
            fito.Show()
        ElseIf (analisisVar = 8700) Then 'yemas
            Dim foliar As New F_DatosAgrYemas
            foliar.Owner = Me
            foliar.Show()
        ElseIf (analisisVar = 8758) Then 'nematodos
            Dim foliar As New F_DatosAgrNematodos
            foliar.Owner = Me
            foliar.Show()

        End If
    End Sub



    Private Sub dgDatosAgronomicos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDatosAgronomicos.CellDoubleClick
        vaCodigo = Me.dgDatosAgronomicos.Rows.Item(e.RowIndex).Cells.Item(0).Value
        verDatos()
    End Sub


    Private Sub dgBusqueda_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBusqueda.CellDoubleClick
        Try
            Dim asigna As New F_AsignaAnalisis
            asigna.Owner = Me
            asigna.txCodigo.Text = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(0).Value
            asigna.txDescripcion.Text = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(1).Value
            asigna.txValor.Text = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(2).Value
            asigna.txCantidad.Focus()
            If Tipo_Ingreso_OT = "Agrega" Then
                asigna.txCantidad.Text = cantChKl.ToString
                'asigna.txCantidad.ReadOnly = True
            End If

            asigna.Show()

        Catch ex As Exception
        End Try
    End Sub


    Private Sub btn_DAOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DAOK.Click
        If MsgBox("¿Desea cambiar el estado a :: C/DA ::?", MsgBoxStyle.OkCancel, "Labsys 2") = MsgBoxResult.Ok Then
            Dim i, j As Integer

            j = Me.dgDatosAgronomicos.Rows.Count

            While i < j
                Me.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Value = "C/DA"

                Me.dgDatosAgronomicos.Rows.Item(i).Cells.Item(6).Style.BackColor = System.Drawing.Color.Blue

                i = i + 1
            End While
        End If

    End Sub


    Private Sub cbRegionN_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbRegionN.MouseClick

    End Sub



    Private Sub cbProductor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProductor.Enter
        If XcargoP <> "Productor" Then
            Call llenaCBProductor()
            XcargoP = "Productor"
        End If
    End Sub

    Private Sub cbEmpresa_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmpresa.Enter
        If XcargoE <> "Empresa" Then
            Call llenaCBEmpresa()
            XcargoE = "Empresa"
        End If
    End Sub

    Private Sub cbRegionN_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRegionN.Enter
        If XcargoR <> "Region" Then
            Call llenaCBRegiones()
            XcargoR = "Region"
        End If
    End Sub

    Private Sub cbLocalidad_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLocalidad.MouseEnter
        If XcargoL <> "Localidad" Then
            Dim fila As DataRow

            Me.cbLocalidad.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("LOCALIDAD").Rows
                Me.cbLocalidad.Items.Add(fila("LOCALIDAD"))
            Next

            XcargoL = "Localidad"
        End If


    End Sub

    Private Sub cbCiudad_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCiudad.Enter
        cargaCiudadComuna()
    End Sub

    Private Sub cbComuna_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbComuna.Enter
        cargaCiudadComuna()
    End Sub

    Private Sub cbCiudadRS_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCiudadRS.Enter
        cargaCiudadComuna()
    End Sub

    Private Sub cbComunaRS_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbComunaRS.Enter
        cargaCiudadComuna()
    End Sub

    Private Sub cbCiudadDespacho_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCiudadDespacho.Enter
        cargaCiudadComuna()
    End Sub
    Sub cargaCiudadComuna()
        If XcargoC <> "Ciudad" Then
            Dim fila As DataRow

            Me.cbComuna.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
                Me.cbComuna.Items.Add(fila("COMUNA"))
            Next

            Me.cbCiudad.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("CIUDAD").Rows
                Me.cbCiudad.Items.Add(fila("CIUDAD"))
            Next

            Me.cbCiudadDespacho.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("CIUDAD").Rows
                Me.cbCiudadDespacho.Items.Add(fila("CIUDAD"))
            Next

            Me.cbCiudadRS.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("CIUDAD").Rows
                Me.cbCiudadRS.Items.Add(fila("CIUDAD"))
            Next

            Me.cbComunaDespacho.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
                Me.cbComunaDespacho.Items.Add(fila("COMUNA"))
            Next

            Me.cbComunaRS.Items.Add("")
            For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
                Me.cbComunaRS.Items.Add(fila("COMUNA"))
            Next
            XcargoC = "Ciudad"
        End If
    End Sub

    Private Sub cbComunaDespacho_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbComunaDespacho.Enter
        cargaCiudadComuna()
    End Sub

End Class





