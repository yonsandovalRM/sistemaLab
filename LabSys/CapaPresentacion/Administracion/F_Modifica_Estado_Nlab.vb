Public Class F_Modifica_Estado_Nlab
    Inherits System.Windows.Forms.Form
    Private ffi As Integer

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
    Friend WithEvents TxtOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTGDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ElPanel1 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtOrden = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTGDetalle = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ElPanel1 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        CType(Me.DTGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtOrden
        '
        Me.TxtOrden.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOrden.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrden.Location = New System.Drawing.Point(80, 16)
        Me.TxtOrden.Name = "TxtOrden"
        Me.TxtOrden.Size = New System.Drawing.Size(72, 21)
        Me.TxtOrden.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "N° OT"
        '
        'DTGDetalle
        '
        Me.DTGDetalle.CaptionVisible = False
        Me.DTGDetalle.DataMember = ""
        Me.DTGDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGDetalle.Location = New System.Drawing.Point(16, 104)
        Me.DTGDetalle.Name = "DTGDetalle"
        Me.DTGDetalle.Size = New System.Drawing.Size(816, 448)
        Me.DTGDetalle.TabIndex = 44
        Me.DTGDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGDetalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MDETORD"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "TMuestra"
        Me.DataGridTextBoxColumn1.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nº Lab"
        Me.DataGridTextBoxColumn2.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 70
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Cod.Analisis"
        Me.DataGridTextBoxColumn3.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 70
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn4.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 500
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Estado"
        Me.DataGridTextBoxColumn5.MappingName = "NLAB_ESTADO"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 70
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "N° Laboratorios"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(456, 592)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Salir"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 592)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Grabar"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"xA", "xR", "Re", "Nula", "DuxA", "DuxR", "DuRe"})
        Me.ComboBox1.Location = New System.Drawing.Point(340, 312)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 66
        Me.ComboBox1.Visible = False
        '
        'ElPanel1
        '
        Me.ElPanel1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel1.Controls.Add(Me.Label1)
        Me.ElPanel1.Controls.Add(Me.Label2)
        Me.ElPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel1.Name = "ElPanel1"
        Me.ElPanel1.Size = New System.Drawing.Size(848, 645)
        Me.ElPanel1.TabIndex = 67
        '
        'F_Modifica_Estado_Nlab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 645)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DTGDetalle)
        Me.Controls.Add(Me.TxtOrden)
        Me.Controls.Add(Me.ElPanel1)
        Me.Name = "F_Modifica_Estado_Nlab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Estado N° Laboratorios"
        CType(Me.DTGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Frm_Modifica_Estado_Nlab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cjto_Tablas1.Tables("MDETORD").Clear()
        Call Anti_Elimina_lineas()
        TxtOrden.Focus()
    End Sub

    Private Sub TxtOrden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOrden.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtOrden.Text <> "" Then Call CargaNLab()
        End If
    End Sub

    Private Sub CargaNLab()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim Fila_Mod, Fila_Data As DataRow

        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", CInt(TxtOrden.Text), SqlDbType.Int)
            .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaEstadoNlab")
        End With
        Call CargaTabla(SP, ds)
    End Sub

    Private Sub CargaTabla(ByVal SP As Procedimiento_Almacenado, ByVal ds As DataSet)
        Dim Fila_Mod, Fila_Data As DataRow
        For Each Fila_Mod In ds.Tables(0).Rows
            Fila_Data = Cjto_Tablas1.Tables("MDETORD").NewRow
            Fila_Data.Item("TMU_CODIGO") = Fila_Mod("TMU_CODIGO")
            Fila_Data.Item("OT_NLAB") = Fila_Mod("OT_NLAB")
            With SP
                .Inicializar()
                .AgregarParametro("@CodAna", Fila_Mod("ANA_CODIGO"), SqlDbType.Float)
                ds = .EjecutarQuery("usp_SelectModificaAna_Analisis")
            End With
            Fila_Data.Item("ANA_CODIGO") = Fila_Mod("ANA_CODIGO")

            If IsDBNull(ds.Tables(0).Rows(0).Item("ANA_ANALISIS")) = False Then
                Fila_Data.Item("ANA_ANALISIS") = ds.Tables(0).Rows(0).Item("ANA_ANALISIS")
            Else
                Fila_Data.Item("ANA_ANALISIS") = ""
            End If

            If IsDBNull(ds.Tables(0).Rows(0).Item("TIPO_COD")) = False Then
                If ds.Tables(0).Rows(0).Item("TIPO_COD") = "JA" Then
                    Fila_Data.Item("ANA_ANALISIS") = BuscaDescripcionJocker(Fila_Data.Item("ANA_CODIGO"), Fila_Data.Item("TMU_CODIGO"), Fila_Data.Item("OT_NLAB"))
                End If
            End If

            Fila_Data.Item("NLAB_ESTADO") = Fila_Mod("NLAB_ESTADO")
            Try
                Cjto_Tablas1.Tables("MDETORD").Rows.Add(Fila_Data)
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Function BuscaDescripcionJocker(ByVal AnaCod As Double, ByVal TMuestra As Integer, ByVal NLab As Integer) As String
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        With SP
            .Inicializar()
            .AgregarParametro("@CodAna", AnaCod, SqlDbType.Float)
            .AgregarParametro("@TMuestra", TMuestra, SqlDbType.Int)
            .AgregarParametro("@NLab", NLab, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectModificaJocker")
        End With

        If IsDBNull(ds.Tables(0).Rows(0).Item("ANA_ANALISIS")) = False Then
            Return ds.Tables(0).Rows(0).Item("ANA_ANALISIS")
        Else
            Return ""
        End If


    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Fila_MDetOrd As DataRow
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        For Each Fila_MDetOrd In Cjto_Tablas1.Tables("MDETORD").Rows

            If Fila_MDetOrd.Item("TMU_CODIGO") = 1000 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NLab", CInt(Fila_MDetOrd("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
                    .AgregarParametro("@Estado", Fila_MDetOrd("NLAB_ESTADO"), SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateModificaEstadoNlab")
                End With
            End If

            If Fila_MDetOrd.Item("TMU_CODIGO") = 2000 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NLab", CInt(Fila_MDetOrd("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
                    .AgregarParametro("@Estado", Fila_MDetOrd("NLAB_ESTADO"), SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateModificaEstadoNlab")
                End With
            End If

            If Fila_MDetOrd.Item("TMU_CODIGO") = 3000 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NLab", CInt(Fila_MDetOrd("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
                    .AgregarParametro("@Estado", Fila_MDetOrd("NLAB_ESTADO"), SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateModificaEstadoNlab")
                End With
            End If

            If Fila_MDetOrd.Item("TMU_CODIGO") = 4000 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NLab", CInt(Fila_MDetOrd("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
                    .AgregarParametro("@Estado", Fila_MDetOrd("NLAB_ESTADO"), SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateModificaEstadoNlab")
                End With
            End If

            If Fila_MDetOrd.Item("TMU_CODIGO") = 5000 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NLab", CInt(Fila_MDetOrd("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
                    .AgregarParametro("@Estado", Fila_MDetOrd("NLAB_ESTADO"), SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateModificaEstadoNlab")
                End With
            End If

            If Fila_MDetOrd.Item("TMU_CODIGO") = 6000 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NLab", CInt(Fila_MDetOrd("OT_NLAB")), SqlDbType.Int)
                    .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
                    .AgregarParametro("@Estado", Fila_MDetOrd("NLAB_ESTADO"), SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateModificaEstadoNlab")
                End With
            End If

        Next
        MsgBox("Grabación finalizada")
    End Sub

    Private Sub DTGDetalle_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGDetalle.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim Fila_Grilla_C As Integer
        Dim muestra As Boolean = False
        Dim myGriC As DataGrid
        myGriC = CType(sender, DataGrid)
        ffi = myGriC.CurrentCell.RowNumber
        If ComboBox1.Visible = True Then ComboBox1.Visible = False
        If myGriC.CurrentCell.ColumnNumber <> 4 Then Exit Sub
        Dim CeldaAlto As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).X + myGriC.Left
        Dim Posiciony As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Y + myGriC.Top
        ComboBox1.Left = Posicionx
        ComboBox1.Top = Posiciony
        ComboBox1.Height = CeldaAlto
        ComboBox1.Width = CeldaAncho
        ComboBox1.Visible = True
        ComboBox1.Text = ""
        ComboBox1.Enabled = True
        ComboBox1.Focus()
        ComboBox1.SelectionStart = 1
        Try
            If IsDBNull(myGriC.Item(ffi, 4)) = False Then ComboBox1.Text = myGriC.Item(ffi, 4)
        Catch ex As Exception
        End Try
yam:
    End Sub

    Private Sub Anti_Elimina_lineas()
        Me.DTGDetalle.DataSource = Cjto_Tablas1.Tables("MDETORD")
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If ComboBox1.Text <> "" Then
                DTGDetalle.Item(ffi, 4) = ComboBox1.Text
                mycell.ColumnNumber = 1
                mycell.RowNumber = ffi
                DTGDetalle.CurrentCell = mycell
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
