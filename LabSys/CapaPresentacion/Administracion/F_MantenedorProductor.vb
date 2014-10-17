Public Class F_MantenedorProductor
    Inherits System.Windows.Forms.Form
    Private Est As String
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Dtg_Productor As System.Windows.Forms.DataGrid
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Bt_Grabar As System.Windows.Forms.Button
    Friend WithEvents Bt_Agregar As System.Windows.Forms.Button
    Friend WithEvents Bt_Eliminar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Dtg_Productor = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Grabar = New System.Windows.Forms.Button
        Me.Bt_Agregar = New System.Windows.Forms.Button
        Me.Bt_Eliminar = New System.Windows.Forms.Button
        CType(Me.Dtg_Productor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtg_Productor
        '
        Me.Dtg_Productor.CaptionVisible = False
        Me.Dtg_Productor.DataMember = ""
        Me.Dtg_Productor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Productor.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Productor.Location = New System.Drawing.Point(0, 8)
        Me.Dtg_Productor.Name = "Dtg_Productor"
        Me.Dtg_Productor.Size = New System.Drawing.Size(1280, 896)
        Me.Dtg_Productor.TabIndex = 0
        Me.Dtg_Productor.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_Productor
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn18})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "PRODUCTOR_LABSYS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn1.MappingName = "PRO_PRODUCTOR"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 130
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Rut"
        Me.DataGridTextBoxColumn2.MappingName = "PRO_RUT"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Predio"
        Me.DataGridTextBoxColumn3.MappingName = "PRO_PREDIO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 95
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Dirección"
        Me.DataGridTextBoxColumn4.MappingName = "PRO_DIRECCION"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 95
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Localidad"
        Me.DataGridTextBoxColumn5.MappingName = "PRO_LOCALIDAD"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 95
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Comuna"
        Me.DataGridTextBoxColumn6.MappingName = "PRO_COMUNA"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 95
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Ciudad"
        Me.DataGridTextBoxColumn7.MappingName = "PRO_CIUDAD"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 95
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Provincia"
        Me.DataGridTextBoxColumn8.MappingName = "PRO_PROVINCIA"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 95
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Región"
        Me.DataGridTextBoxColumn9.MappingName = "PRO_REGION"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 45
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Fono"
        Me.DataGridTextBoxColumn10.MappingName = "PRO_FONO1"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Celular"
        Me.DataGridTextBoxColumn12.MappingName = "PRO_CELULAR1"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Fax"
        Me.DataGridTextBoxColumn14.MappingName = "PRO_FAX1"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "email"
        Me.DataGridTextBoxColumn16.MappingName = "PRO_EMAIL1"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 130
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "% Dcto."
        Me.DataGridTextBoxColumn18.MappingName = "PRO_PORCDESCUENTO"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 48
        '
        'Bt_Salir
        '
        Me.Bt_Salir.Location = New System.Drawing.Point(1176, 944)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Salir.TabIndex = 13
        Me.Bt_Salir.Text = "Salir"
        '
        'Bt_Grabar
        '
        Me.Bt_Grabar.Location = New System.Drawing.Point(912, 944)
        Me.Bt_Grabar.Name = "Bt_Grabar"
        Me.Bt_Grabar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Grabar.TabIndex = 11
        Me.Bt_Grabar.Text = "Grabar"
        '
        'Bt_Agregar
        '
        Me.Bt_Agregar.Location = New System.Drawing.Point(1000, 944)
        Me.Bt_Agregar.Name = "Bt_Agregar"
        Me.Bt_Agregar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Agregar.TabIndex = 10
        Me.Bt_Agregar.Text = "Agregar"
        '
        'Bt_Eliminar
        '
        Me.Bt_Eliminar.Location = New System.Drawing.Point(1088, 944)
        Me.Bt_Eliminar.Name = "Bt_Eliminar"
        Me.Bt_Eliminar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Eliminar.TabIndex = 9
        Me.Bt_Eliminar.Text = "Eliminar"
        '
        'Frm_MantenedorProductor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1284, 1009)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Grabar)
        Me.Controls.Add(Me.Bt_Agregar)
        Me.Controls.Add(Me.Bt_Eliminar)
        Me.Controls.Add(Me.Dtg_Productor)
        Me.Name = "Frm_MantenedorProductor"
        Me.Text = "Frm_MantenedorProductor"
        CType(Me.Dtg_Productor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Anti_Elimina()
        Dtg_Productor.DataSource = Cjto_Tablas1.Tables("PRODUCTOR_LABSYS")
    End Sub

    Private Sub Frm_MantenedorProductor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina()
    End Sub

    Private Sub Bt_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Grabar.Click
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila, Cont As Integer
        Dim Fila_Dat As DataRow
        Cont = Dtg_Productor.CurrentCell.RowNumber
        Fila = Dtg_Productor.CurrentRowIndex
        Try
            For Each Fila_Dat In Cjto_Tablas1.Tables("PRODUCTOR_LABSYS").Rows
                If Fila_Dat.RowState = DataRowState.Added Then
                    With sp
                        .Inicializar()
                        .AgregarParametro("@nombre", Fila_Dat("PRO_PRODUCTOR"), SqlDbType.NVarChar)
                        .AgregarParametro("@rut", Fila_Dat("PRO_RUT"), SqlDbType.NVarChar)
                        .AgregarParametro("@predio", Fila_Dat("PRO_PREDIO"), SqlDbType.NVarChar)
                        .AgregarParametro("@direccion", Fila_Dat("PRO_DIRECCION"), SqlDbType.NVarChar)
                        .AgregarParametro("@localidad", Fila_Dat("PRO_LOCALIDAD"), SqlDbType.NVarChar)
                        .AgregarParametro("@comuna", Fila_Dat("PRO_COMUNA"), SqlDbType.NVarChar)
                        .AgregarParametro("@ciudad", Fila_Dat("PRO_CIUDAD"), SqlDbType.NVarChar)
                        .AgregarParametro("@provincia", Fila_Dat("PRO_PROVINCIA"), SqlDbType.NVarChar)
                        .AgregarParametro("@region", Fila_Dat("PRO_REGION"), SqlDbType.NVarChar)
                        .AgregarParametro("@fono", Fila_Dat("PRO_FONO1"), SqlDbType.NVarChar)
                        .AgregarParametro("@cel", Fila_Dat("PRO_CELULAR1"), SqlDbType.NVarChar)
                        .AgregarParametro("@fax", Fila_Dat("PRO_FAX1"), SqlDbType.NVarChar)
                        .AgregarParametro("@email", Fila_Dat("PRO_EMAIL1"), SqlDbType.NVarChar)
                        .AgregarParametro("@dcto", Fila_Dat("PRO_PORCDESCUENTO"), SqlDbType.Float)
                        .EjecutarEscalar("usp_InsertaProductor")
                    End With
                End If

                If Fila_Dat.RowState = DataRowState.Modified Then
                    With sp
                        .Inicializar()
                        .AgregarParametro("@nombre", Fila_Dat("PRO_PRODUCTOR"), SqlDbType.NVarChar)
                        .AgregarParametro("@rut", Fila_Dat("PRO_RUT"), SqlDbType.NVarChar)
                        .AgregarParametro("@predio", Fila_Dat("PRO_PREDIO"), SqlDbType.NVarChar)
                        .AgregarParametro("@direccion", Fila_Dat("PRO_DIRECCION"), SqlDbType.NVarChar)
                        .AgregarParametro("@localidad", Fila_Dat("PRO_LOCALIDAD"), SqlDbType.NVarChar)
                        .AgregarParametro("@comuna", Fila_Dat("PRO_COMUNA"), SqlDbType.NVarChar)
                        .AgregarParametro("@ciudad", Fila_Dat("PRO_CIUDAD"), SqlDbType.NVarChar)
                        .AgregarParametro("@provincia", Fila_Dat("PRO_PROVINCIA"), SqlDbType.NVarChar)
                        .AgregarParametro("@region", Fila_Dat("PRO_REGION"), SqlDbType.NVarChar)
                        .AgregarParametro("@fono", Fila_Dat("PRO_FONO1"), SqlDbType.NVarChar)
                        .AgregarParametro("@cel", Fila_Dat("PRO_CELULAR1"), SqlDbType.NVarChar)
                        .AgregarParametro("@fax", Fila_Dat("PRO_FAX1"), SqlDbType.NVarChar)
                        .AgregarParametro("@email", Fila_Dat("PRO_EMAIL1"), SqlDbType.NVarChar)
                        .AgregarParametro("@dcto", Fila_Dat("PRO_PORCDESCUENTO"), SqlDbType.Float)
                        .EjecutarEscalar("usp_ActualizaMantProductor")
                    End With
                End If
            Next



            'If Est = "Agrega" Then
            '    With sp
            '        .Inicializar()
            '        .AgregarParametro("@nombre", Dtg_Productor(Fila, 0), SqlDbType.NVarChar)
            '        .AgregarParametro("@rut", Dtg_Productor(Fila, 1), SqlDbType.NVarChar)
            '        .AgregarParametro("@predio", Dtg_Productor(Fila, 2), SqlDbType.NVarChar)
            '        .AgregarParametro("@direccion", Dtg_Productor(Fila, 3), SqlDbType.NVarChar)
            '        .AgregarParametro("@localidad", Dtg_Productor(Fila, 4), SqlDbType.NVarChar)
            '        .AgregarParametro("@comuna", Dtg_Productor(Fila, 5), SqlDbType.NVarChar)
            '        .AgregarParametro("@ciudad", Dtg_Productor(Fila, 6), SqlDbType.NVarChar)
            '        .AgregarParametro("@provincia", Dtg_Productor(Fila, 7), SqlDbType.NVarChar)
            '        .AgregarParametro("@region", Dtg_Productor(Fila, 8), SqlDbType.NVarChar)
            '        .AgregarParametro("@fono", Dtg_Productor(Fila, 9), SqlDbType.NVarChar)
            '        .AgregarParametro("@cel", Dtg_Productor(Fila, 10), SqlDbType.NVarChar)
            '        .AgregarParametro("@fax", Dtg_Productor(Fila, 11), SqlDbType.NVarChar)
            '        .AgregarParametro("@email", Dtg_Productor(Fila, 12), SqlDbType.NVarChar)
            '        .AgregarParametro("@dcto", Dtg_Productor(Fila, 13), SqlDbType.Float)
            '        .EjecutarEscalar("usp_InsertaProductor")
            '    End With
            'End If
            'With sp
            '    .Inicializar()
            '    .AgregarParametro("@nombre", Dtg_Productor(Fila, 0), SqlDbType.NVarChar)
            '    .AgregarParametro("@rut", Dtg_Productor(Fila, 1), SqlDbType.NVarChar)
            '    .AgregarParametro("@predio", Dtg_Productor(Fila, 2), SqlDbType.NVarChar)
            '    .AgregarParametro("@direccion", Dtg_Productor(Fila, 3), SqlDbType.NVarChar)
            '    .AgregarParametro("@localidad", Dtg_Productor(Fila, 4), SqlDbType.NVarChar)
            '    .AgregarParametro("@comuna", Dtg_Productor(Fila, 5), SqlDbType.NVarChar)
            '    .AgregarParametro("@ciudad", Dtg_Productor(Fila, 6), SqlDbType.NVarChar)
            '    .AgregarParametro("@provincia", Dtg_Productor(Fila, 7), SqlDbType.NVarChar)
            '    .AgregarParametro("@region", Dtg_Productor(Fila, 8), SqlDbType.NVarChar)
            '    .AgregarParametro("@fono", Dtg_Productor(Fila, 9), SqlDbType.NVarChar)
            '    .AgregarParametro("@cel", Dtg_Productor(Fila, 10), SqlDbType.NVarChar)
            '    .AgregarParametro("@fax", Dtg_Productor(Fila, 11), SqlDbType.NVarChar)
            '    .AgregarParametro("@email", Dtg_Productor(Fila, 12), SqlDbType.NVarChar)
            '    .AgregarParametro("@dcto", Dtg_Productor(Fila, 13), SqlDbType.Float)
            '    .EjecutarEscalar("usp_ActualizaMantProductor")
            'End With
            Cjto_Tablas1.Tables("PRODUCTOR_LABSYS").Clear()
            With sp
                .Inicializar()
                .EjecutarQueryDt("Usp_CargaProductorLabsys", Cjto_Tablas1, "PRODUCTOR_LABSYS")
            End With
            MsgBox("Grabación Finalizada")
            Est = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub

    Private Sub Bt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Agregar.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = Dtg_Productor.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        Dtg_Productor.CurrentCell = mycell
        Est = "Agrega"
    End Sub

    Private Sub Bt_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Eliminar.Click
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila As Integer
        Fila = Dtg_Productor.CurrentCell.RowNumber
        Try
            With sp
                .Inicializar()
                .AgregarParametro("@nombre", Dtg_Productor(Fila, 0), SqlDbType.NVarChar)
                .AgregarParametro("@rut", Dtg_Productor(Fila, 1), SqlDbType.NVarChar)
                .AgregarParametro("@predio", Dtg_Productor(Fila, 2), SqlDbType.NVarChar)
                .AgregarParametro("@direccion", Dtg_Productor(Fila, 3), SqlDbType.NVarChar)
                .AgregarParametro("@localidad", Dtg_Productor(Fila, 4), SqlDbType.NVarChar)
                .AgregarParametro("@comuna", Dtg_Productor(Fila, 5), SqlDbType.NVarChar)
                .AgregarParametro("@ciudad", Dtg_Productor(Fila, 6), SqlDbType.NVarChar)
                .AgregarParametro("@provincia", Dtg_Productor(Fila, 7), SqlDbType.NVarChar)
                .AgregarParametro("@region", Dtg_Productor(Fila, 8), SqlDbType.NVarChar)
                .AgregarParametro("@fono", Dtg_Productor(Fila, 9), SqlDbType.NVarChar)
                .AgregarParametro("@cel", Dtg_Productor(Fila, 10), SqlDbType.NVarChar)
                .AgregarParametro("@fax", Dtg_Productor(Fila, 11), SqlDbType.NVarChar)
                .AgregarParametro("@email", Dtg_Productor(Fila, 12), SqlDbType.NVarChar)
                .AgregarParametro("@dcto", Dtg_Productor(Fila, 13), SqlDbType.Float)
                .EjecutarEscalar("usp_EliminaMantProductor")
            End With

            Cjto_Tablas1.Tables("PRODUCTOR_LABSYS").Clear()
            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_CargaProductorLabsys", Cjto_Tablas1, "PRODUCTOR_LABSYS")
            End With
            MsgBox("El registro fue eliminado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
