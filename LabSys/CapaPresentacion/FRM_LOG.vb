
Public Class FRM_LOG

    Private Sub FRM_LOG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta l�nea de c�digo carga datos en la tabla 'AGROLAB_PRUEBADataSet1.AUDITORIA' Puede moverla o quitarla seg�n sea necesario.
        Me.AUDITORIATableAdapter.Fill(Me.AGROLAB_PRUEBADataSet1.AUDITORIA)
    End Sub


End Class