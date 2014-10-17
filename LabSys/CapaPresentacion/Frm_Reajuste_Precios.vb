Public Class Frm_Reajuste_Precios

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Porcentaje.TextChanged
        Try
            Dim respuesta As MsgBoxResult
            Dim ana_neto, cdesde, chasta, valrea As Double
            Dim tmu_codigo, largorea, h As Integer
            Dim consulta_nota, reajuste As String

            valrea = Math.Abs(CDbl(Val(txt_Porcentaje.Text)))
            reajuste = CStr(1 + valrea / 100)
            largorea = Len(reajuste)
            For h = 1 To largorea
                If Mid(reajuste, h, 1) = "," Then
                    Mid(reajuste, h, 1) = "."
                    Exit For
                End If
            Next
            txt_PorcentajeReal.Text = reajuste

        Catch ex As Exception
            MsgBox("Ingrese un valor real, Ej: 2.17")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '    Dim respuesta As MsgBoxResult
        '    Dim ana_neto, cdesde, chasta, valrea As Double
        '    Dim tmu_codigo, largorea, h As Integer
        '    Dim consulta_nota, reajuste As String
        '    respuesta = MsgBox("........Confirma Reajuste........", MsgBoxStyle.YesNo)
        '    If respuesta = MsgBoxResult.Yes Then
        '        valrea = Math.Abs(CDbl(Val(TextBox45.Text)))
        '        reajuste = CStr(1 + valrea / 100)
        '        largorea = Len(reajuste)
        '        For h = 1 To largorea
        '            If Mid(reajuste, h, 1) = "," Then
        '                Mid(reajuste, h, 1) = "."
        '                Exit For
        '            End If
        '        Next
        '        cdesde = CDbl(Val(TextBox43.Text))
        '        chasta = CDbl(Val(TextBox44.Text))
        '    End If
    End Sub
End Class