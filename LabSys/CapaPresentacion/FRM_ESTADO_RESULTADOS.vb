Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Public Class FRM_ESTADO_RESULTADOS

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@tipo", Me.cb_tipo.Text, SqlDbType.VarChar)
        cd.AgregarParametro("@fecha", Me.dt_desde.Text, SqlDbType.DateTime)
        dsInicial = cd.EjecutarQuery("ys_BuscaEstado")
        dt = dsInicial.Tables(0)


        Me.grillaEstados.DataSource = dt
    End Sub

    Private Sub FRM_ESTADO_RESULTADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AGROLAB_PRUEBADataSet4.ESTADOS_OT' Puede moverla o quitarla según sea necesario.
        Me.ESTADOS_OTTableAdapter1.Fill(Me.AGROLAB_PRUEBADataSet4.ESTADOS_OT)


    End Sub

    Private Sub btn_generaExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generaExcel.Click
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado  
            '.Range("B1:L1").Merge()
            '.Range("B1:L1").Value = "AGROLAB"
            '.Range("B1:L1").Font.Bold = True
            '.Range("B1:L1").Font.Size = 15
            ''Subtitulo 
            '.Range("A2:L2").Merge()
            '.Range("A2:L2").Value = titulo
            '.Range("A2:L2").Font.Bold = True
            '.Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 1
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            ' Dim sepDec As String = Excel.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            ' Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            ' Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In Me.grillaEstados.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    ' objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    ' If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                    ' objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    ' End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In Me.grillaEstados.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In Me.grillaEstados.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                        '.Range(strColumna + i, strColumna + i).In()  

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next

            UltimoNumero = i
            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In Me.grillaEstados.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next
            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With
        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub
End Class