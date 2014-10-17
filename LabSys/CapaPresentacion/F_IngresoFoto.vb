Public Class F_IngresoFoto

    Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click
        Me.OpenFileDialog1.ShowDialog()
        Me.txRuta.Text = Me.OpenFileDialog1.FileName
    End Sub
End Class