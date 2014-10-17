Public Class G_Localidad

    Private Sub G_Lolalidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim orden As F_OrdenTrabajo = Me.Owner
        Dim cd As New CapaDato
        Dim ds As New DataSet
        Dim i As Integer
        If loc = 0 Then
            cd.Inicializar()
            cd.AgregarParametro("@localidad", orden.cbLocalidad.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@comuna", "", SqlDbType.VarChar)
            ds = cd.EjecutarQuery("ls_traeUbicacionNuevo")
        ElseIf loc = 1 Then
            cd.Inicializar()
            cd.AgregarParametro("@localidad", "", SqlDbType.VarChar)
            cd.AgregarParametro("@comuna", orden.cbComuna.Text, SqlDbType.VarChar)
            ds = cd.EjecutarQuery("ls_traeUbicacionNuevo")

        End If
        

        For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.dgUbicacion.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, _
            ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, _
           ds.Tables(0).Rows(i).Item(4).ToString)

        Next

        dgUbicacion.Refresh()

    End Sub

    Private Sub dgUbicacion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUbicacion.CellDoubleClick

        Dim orden As F_OrdenTrabajo = Me.Owner
       
        If Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 1 Then
            orden.cbRegionN.Text = "I - Tarapaca"
            orden.cbRegionN.SelectedValue = 1
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 2 Then
            orden.cbRegionN.Text = "II - Antofagasta"
            orden.cbRegionN.SelectedValue = 2
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 3 Then
            orden.cbRegionN.Text = "III - Atacama"
            orden.cbRegionN.SelectedValue = 3
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 4 Then
            orden.cbRegionN.Text = "IV - Coquimbo"
            orden.cbRegionN.SelectedValue = 4
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 5 Then
            orden.cbRegionN.Text = "V - Valparaiso"
            orden.cbRegionN.SelectedValue = 5
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 6 Then
            orden.cbRegionN.Text = "VI - Gral.B.O`Higgins"
            orden.cbRegionN.SelectedValue = 6
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 7 Then
            orden.cbRegionN.Text = "VII - Maule"
            orden.cbRegionN.SelectedValue = 7
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 8 Then
            orden.cbRegionN.Text = "VIII - Biobio"
            orden.cbRegionN.SelectedValue = 8
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 9 Then
            orden.cbRegionN.Text = "IX - Araucania"
            orden.cbRegionN.SelectedValue = 9
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 10 Then
            orden.cbRegionN.Text = "X - De los Lagos"
            orden.cbRegionN.SelectedValue = 10
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 11 Then
            orden.cbRegionN.Text = "XI - Aisen(Gral.C.Ibañez)"
            orden.cbRegionN.SelectedValue = 11
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 12 Then
            orden.cbRegionN.Text = "XII - Magallanes Y Antartica Ch."
            orden.cbRegionN.SelectedValue = 12
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 13 Then
            orden.cbRegionN.Text = "XIII - Metropolitana"
            orden.cbRegionN.SelectedValue = 13
        ElseIf Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value = 0 Then
            orden.cbRegionN.Text = "Seleccione Region"
            orden.cbRegionN.SelectedValue = 0
        End If

        ' orden.cbRegionN.Text = Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(4).Value
        orden.cbProvincia.Text = Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(3).Value
        orden.cbCiudad.Text = Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(2).Value
        orden.cbComuna.Text = Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(1).Value
        orden.cbLocalidad.Text = Me.dgUbicacion.Rows.Item(e.RowIndex).Cells.Item(0).Value
        Me.Close()
    End Sub


End Class