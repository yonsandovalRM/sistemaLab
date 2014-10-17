Public Class F_TraspasoYemas

    Private Sub F_TraspasoYemas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click
        Me.openDialog.ShowDialog()
        Me.txRuta.Text = Me.openDialog.FileName

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim nombrePagina As String
            Dim dt, dtY As New DataTable
            Dim dsY As New DataSet
            Dim valor As String
            Dim i, j As Integer
            i = 0
            j = 3
            nombrePagina = "DIGITA YEMAS"
            Me.dgYemas.Rows.Clear()
            If System.IO.File.Exists(Me.txRuta.Text) Then ' //compruebo que el archivo exista

                Dim objDataSet As System.Data.DataSet
                Dim objDataAdapter As System.Data.OleDb.OleDbDataAdapter

                ' // Declarar la Cadena de conexión  
                Dim sCs As String = "provider=Microsoft.Jet.OLEDB.4.0; " & "data source=" & Me.txRuta.Text & "; Extended Properties=Excel 8.0;"
                Dim objOleConnection As System.Data.OleDb.OleDbConnection
                objOleConnection = New System.Data.OleDb.OleDbConnection(sCs)

                ' // Declarar la consulta SQL que indica el libro y el rango de la hoja  
                Dim sSql As String = "select * from " & "[" & nombrePagina & "$]"
                ' // Obtener los datos  
                objDataAdapter = New System.Data.OleDb.OleDbDataAdapter(sSql, objOleConnection)

                ' // Crear DataSet y llenarlo  
                objDataSet = New System.Data.DataSet

                objDataAdapter.Fill(objDataSet)
                ' // Cerrar la conexión  
                objOleConnection.Close()
                dt = objDataSet.Tables(0)

                Dim r As Integer = dt.Rows.Count
                ' Dim arr(r, 43) As String

                If dt.Rows.Item(i).Item(0).ToString <> "" Then
                    While i < r
                        Dim dgvRow As New DataGridViewRow
                        Dim dgvCell As DataGridViewCell
                        valor = dt.Rows.Item(i).Item(0).ToString
                        'dtY.Rows.Item(i - 1).Item(0) = valor
                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = valor
                        dgvRow.Cells.Add(dgvCell)
                        '   arr(i, 0) = valor
                        valor = dt.Rows.Item(i).Item(1).ToString
                        'dtY.Rows.Item(i - 1).Item(1) = valor
                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = valor
                        dgvRow.Cells.Add(dgvCell)
                        'arr(i, 1) = valor

                        valor = dt.Rows.Item(i).Item(2).ToString
                        'dtY.Rows.Item(i - 1).Item(2) = valor
                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = valor
                        dgvRow.Cells.Add(dgvCell)
                        'arr(i, 2) = valor

                        While j < 43
                            If IsNumeric(dt.Rows.Item(i).Item(j).ToString()) Then
                                Select Case (dt.Rows.Item(i).Item(j).ToString())
                                    Case 1
                                        valor = "F"
                                    Case 2
                                        valor = "V"
                                    Case 3
                                        valor = "MV"
                                    Case 4
                                        valor = "MF"
                                    Case 5
                                        valor = "MM"
                                    Case 6
                                        valor = "A"
                                    Case 7
                                        valor = ""
                                End Select
                            Else
                                valor = "ERROR"
                                If CDbl("0" & dt.Rows.Item(i).Item(j).ToString()) = 0 Then
                                    valor = ""
                                End If
                            End If
                            'dtY.Rows.Item(i - 1).Item(j) = valor
                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = valor
                            dgvRow.Cells.Add(dgvCell)

                            '  arr(i, j) = valor
                            j = j + 1
                        End While
                        Call grabaYemas(dgvRow)
                        Me.dgYemas.Rows.Add(dgvRow)
                        j = 3
                        i = i + 1
                    End While
                Else
                    Dim entro As String
                    Dim desde, hasta As Integer
                    entro = "no"
                    If (dt.Rows.Item(i).Item(1).ToString() <> "") Then
                        dsY = Nothing
                        entro = "si"
                        dsY = buscaOT(dt.Rows.Item(i).Item(1).ToString())
                        If dsY.Tables(0).Rows.Item(0).Item(0).ToString = Nothing Then
                            MsgBox("No existe la orden para este Nlab. error : ", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    End If
                    desde = CInt(dsY.Tables(0).Rows.Item(0).Item(1).ToString())
                    hasta = CInt(dsY.Tables(0).Rows.Item(0).Item(2).ToString())
                    While i < r
                       

                        Dim dgvRow As New DataGridViewRow
                        Dim dgvCell As DataGridViewCell


                        If (dt.Rows.Item(i).Item(1).ToString() <> "" And entro <> "si") Then
                            desde = desde + 1
                            If desde > hasta Then
                                dsY = Nothing
                                entro = "no"
                                dsY = buscaOT(dt.Rows.Item(i).Item(1).ToString())
                                desde = CInt(dsY.Tables(0).Rows.Item(0).Item(1).ToString())
                                hasta = CInt(dsY.Tables(0).Rows.Item(0).Item(2).ToString())
                            End If
                        End If

                        entro = "no"

                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = dsY.Tables(0).Rows.Item(0).Item(0).ToString
                        dgvRow.Cells.Add(dgvCell)

                        valor = dt.Rows.Item(i).Item(1).ToString
                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = desde
                        dgvRow.Cells.Add(dgvCell)

                        valor = dt.Rows.Item(i).Item(2).ToString
                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = valor
                        dgvRow.Cells.Add(dgvCell)

                        While j < 43
                            If IsNumeric(dt.Rows.Item(i).Item(j).ToString()) Then
                                Select Case (dt.Rows.Item(i).Item(j).ToString())
                                    Case 1
                                        valor = "F"
                                    Case 2
                                        valor = "V"
                                    Case 3
                                        valor = "MV"
                                    Case 4
                                        valor = "MF"
                                    Case 5
                                        valor = "MM"
                                    Case 6
                                        valor = "A"
                                    Case 7
                                        valor = ""
                                End Select
                            Else
                                valor = "ERROR"
                                If CDbl("0" & dt.Rows.Item(i).Item(j).ToString()) = 0 Then
                                    valor = ""
                                End If
                            End If

                            dgvCell = New DataGridViewTextBoxCell()
                            dgvCell.Value = valor
                            dgvRow.Cells.Add(dgvCell)


                            j = j + 1
                        End While


                        Call grabaYemas(dgvRow)
                        Me.dgYemas.Rows.Add(dgvRow)

                        j = 3
                        i = i + 1
                    End While
                End If
                Me.txRuta.Text = valor


            End If
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Function buscaOT(ByVal nlab As String)
        Dim cd As New CapaDato
        Dim ds As New DataSet

        cd.Inicializar()
        cd.AgregarParametro("@Nlab", nlab, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_BuscaOTconNLab")

        Return ds

    End Function

  

    Private Sub grabaYemas(ByVal row As DataGridViewRow)

        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@OT_NUMERO", CInt(row.Cells.Item(0).Value), SqlDbType.Int)
            .AgregarParametro("@OT_NLAB", CInt(row.Cells.Item(1).Value), SqlDbType.Int)
            .AgregarParametro("@YEM_YEMA", CInt(row.Cells.Item(2).Value), SqlDbType.Int)
            .AgregarParametro("@YEM_CARGADOR1", row.Cells.Item(3).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR2", row.Cells.Item(4).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR3", row.Cells.Item(5).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR4", row.Cells.Item(6).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR5", row.Cells.Item(7).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR6", row.Cells.Item(8).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR7", row.Cells.Item(9).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR8", row.Cells.Item(10).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR9", row.Cells.Item(11).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR10", row.Cells.Item(12).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR11", row.Cells.Item(13).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR12", row.Cells.Item(14).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR13", row.Cells.Item(15).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR14", row.Cells.Item(16).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR15", row.Cells.Item(17).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR16", row.Cells.Item(18).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR17", row.Cells.Item(19).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR18", row.Cells.Item(20).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR19", row.Cells.Item(21).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR20", row.Cells.Item(22).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR21", row.Cells.Item(23).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR22", row.Cells.Item(24).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR23", row.Cells.Item(25).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR24", row.Cells.Item(26).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR25", row.Cells.Item(27).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR26", row.Cells.Item(28).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR27", row.Cells.Item(29).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR28", row.Cells.Item(30).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR29", row.Cells.Item(31).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR30", row.Cells.Item(32).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR31", row.Cells.Item(33).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR32", row.Cells.Item(34).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR33", row.Cells.Item(35).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR34", row.Cells.Item(36).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR35", row.Cells.Item(37).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR36", row.Cells.Item(38).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR37", row.Cells.Item(39).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR38", row.Cells.Item(40).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR39", row.Cells.Item(41).Value, SqlDbType.NVarChar)
            .AgregarParametro("@YEM_CARGADOR40", row.Cells.Item(42).Value, SqlDbType.NVarChar)
            .EjecutarQuery("agrolab_carga_yemas")
        End With


    End Sub

    Private Sub txRuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txRuta.TextChanged

    End Sub
End Class

