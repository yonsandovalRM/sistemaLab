Public Class F_LibroVentas
    Dim dsLV As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        With SP
            .Inicializar()

            .AgregarParametro("@desde", Me.txt_desde.Text, SqlDbType.DateTime)
            .AgregarParametro("@hasta", Me.txt_hasta.Text, SqlDbType.DateTime)
            dsLV = .EjecutarQuery("ys_ObtieneLVentas")
        End With

        Dim Datos = New System.Windows.Forms.BindingSource()
        Datos.DataSource = dsLV
        Datos.DataMember = "Table"
        Me.dg_lventas.DataSource = Datos
        calcula_totales()

    End Sub

    Sub calcula_totales()

        Dim i, r, total As Integer

        i = 0
        r = dsLV.Tables("table").Rows.Count

        txt_cantidad.Text = r
        total = 0
        While i < r
            total = total + CInt(dsLV.Tables("table").Rows.Item(i).Item("TOTAL").ToString)
            i = i + 1
        End While
        txt_total.Text = FormatNumber(total, 0)

        'txt_total.Text = Format()

    End Sub
End Class