Public Class F_AsignaAnalisis

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell
        Dim ds As New DataSet
        Dim cd As New CapaDato
        Dim i, r As Integer
        Dim mensaje As String
        i = 0
        mensaje = "false"

        r = orden.dgAsignado.Rows.Count

        While i < r
            Dim codigoAnalisis As String = orden.dgAsignado.Rows.Item(i).Cells.Item(0).Value
            If codigoAnalisis = Nothing Then
                Exit While
            End If
            cd.Inicializar()
            cd.AgregarParametro("@codigoAnalisis", CInt(Me.txCodigo.Text), SqlDbType.Int)
            cd.AgregarParametro("@codigoAsignado", CInt(codigoAnalisis), SqlDbType.Int)
            ds = cd.EjecutarQuery("ls_validaElementosAnalisis")


            For Each dr As Data.DataRow In ds.Tables(0).Rows 'extraigo el primer campo

                mensaje = dr("mensaje").ToString



            Next
            If mensaje = "true" Then
                Dim valor As String = MsgBox(" existen elementos repetidos en los analisis, ¿Desea continuar?", MsgBoxStyle.YesNo)
                If valor = MsgBoxResult.Yes Then
                    Exit While
                ElseIf valor = MsgBoxResult.No Then
                    Me.Close()
                    Exit Sub
                End If
            End If
            i = i + 1
        End While

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.txCodigo.Text
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.txDescripcion.Text
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.txCantidad.Text
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.txValor.Text
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.txCodigo.Text
        dgvRow.Cells.Add(dgvCell)

        orden.dgAsignado.Rows.Add(dgvRow)
        ' Determinamos el alto de las filas
        orden.dgAsignado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' Referenciamos la cuarta columna del control DataGridView.
        Dim col As DataGridViewColumn = orden.dgAsignado.Columns(1)
        ' Ajustamos la celda a su contenido.
        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ' Especificamos el ancho de la columna
        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.Close()

    End Sub

    Private Sub txCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txCantidad.KeyPress

        If e.KeyChar = Chr(13) Then
            Me.btnAceptar_Click(sender, e)
        End If

    End Sub

 
End Class