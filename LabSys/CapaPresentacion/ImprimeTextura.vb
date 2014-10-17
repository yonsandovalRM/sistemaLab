Imports System.Math
Imports Microsoft.Office.Interop

Module ImprimeTextura
    Public Sub EncavezadoPag(ByVal FechaDig As String, ByVal FechaAna As String, ByVal objHojaExcel As Excel.Worksheet)
        Dim Mat As String
        Dim Fila_E As Integer = 2
        Mat = "Suelo"

        ' Imprecion de Encavezado de la Planilla

        objHojaExcel.Range("AI" & Fila_E.ToString & ":BE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("AI" & Fila_E.ToString).Value = "Registro Resultados"
        objHojaExcel.Range("AI" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("AI" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("AI" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AI" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BG" & Fila_E.ToString & ":BM" & Fila_E.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_E.ToString).Value = "Análisis"
        objHojaExcel.Range("BG" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("BG" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BG" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

        objHojaExcel.Range("BN" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("BN" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BN" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("BN" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BN" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BO" & Fila_E.ToString & ":CE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("BO" & Fila_E.ToString).Value = Nombre
        objHojaExcel.Range("BO" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BO" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("BO" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("BO" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BO" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_E.ToString & ":CL" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_E.ToString).Value = "Matriz"
        objHojaExcel.Range("CG" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CG" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

        objHojaExcel.Range("CM" & Fila_E.ToString & ":CM" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CM" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("CM" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CM" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CN" & Fila_E.ToString & ":DB" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CN" & Fila_E.ToString).Value = Mat
        objHojaExcel.Range("CN" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CN" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("CN" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("CN" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CN" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_E.ToString & ":DE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DC" & Fila_E.ToString).Value = "pág"
        objHojaExcel.Range("DC" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DC" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DF" & Fila_E.ToString).Value = "."
        objHojaExcel.Range("DF" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DF" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DF" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DF" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DG" & Fila_E.ToString & ":DJ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DG" & Fila_E.ToString).Value = "1/3"
        objHojaExcel.Range("DG" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DG" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DG" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DG" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        Fila_E = Fila_E + 2


        objHojaExcel.Range("A" & Fila_E.ToString & ":M" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Cód.documento"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("N" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("N" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("N" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("O" & Fila_E.ToString & ":BT" & Fila_E.ToString).Merge()
        objHojaExcel.Range("O" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("O" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("O" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("BV" & Fila_E.ToString & ":CD" & Fila_E.ToString).Merge()
        objHojaExcel.Range("BV" & Fila_E.ToString).Value = "F.digitación"
        objHojaExcel.Range("BV" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BV" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("BV" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BV" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CE" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("CE" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CE" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CE" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CE" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_E.ToString & ":CP" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CF" & Fila_E.ToString).Value = FechaDig
        objHojaExcel.Range("CF" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CR" & Fila_E.ToString & ":CY" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CR" & Fila_E.ToString).Value = "F.análisis"
        objHojaExcel.Range("CR" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CR" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CR" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CR" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CZ" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("CZ" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CZ" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CZ" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CZ" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DA" & Fila_E.ToString & ":DK" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DA" & Fila_E.ToString).Value = FechaAna
        objHojaExcel.Range("DA" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DA" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DA" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DA" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":M" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Metodología"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("N" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("N" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("N" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("O" & Fila_E.ToString & ":CK" & Fila_E.ToString).Merge()
        objHojaExcel.Range("O" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("O" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("O" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    End Sub
    Public Sub EncavezadoTextura(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_E As Integer = 7
        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("CJ" & Fila_E.ToString & ":DJ" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("CJ" & Fila_E.ToString).Value = "Datos calcúlo"
        'objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Bold = 8
        'objHojaExcel.Range("CJ" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'objHojaExcel.Range("CJ" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Arena(%)"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString).Value = "="
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_E.ToString & ":AF" & Fila_E.ToString).Merge()
        objHojaExcel.Range("J" & Fila_E.ToString).Value = "100 - [(A1 - B)] x 2"
        objHojaExcel.Range("J" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Arcilla(%)"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString).Value = "="
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_E.ToString & ":AF" & Fila_E.ToString).Merge()
        objHojaExcel.Range("J" & Fila_E.ToString).Value = "[(A2 - B)] x 2"
        objHojaExcel.Range("J" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Dato del Calculo'''''

        'objHojaExcel.Range("CJ" & Fila_E.ToString & ":CW" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("CJ" & Fila_E.ToString).Value = "Lec hidro Bl"
        'objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("CJ" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'objHojaExcel.Range("CJ" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("CX" & Fila_E.ToString & ":DB" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("CX" & Fila_E.ToString).Value = "g/L"
        'objHojaExcel.Range("CX" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("CX" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("CX" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'objHojaExcel.Range("CX" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("DC" & Fila_E.ToString).Value = ":"
        'objHojaExcel.Range("DC" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("DC" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("DC" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'objHojaExcel.Range("DC" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("DD" & Fila_E.ToString & ":DJ" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("DD" & Fila_E.ToString).Value = ""
        'objHojaExcel.Range("DD" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("DD" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("DD" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'objHojaExcel.Range("DD" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Limo (%)"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString).Value = "="
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_E.ToString & ":AF" & Fila_E.ToString).Merge()
        objHojaExcel.Range("J" & Fila_E.ToString).Value = "100 - (Arena% + Arcilla%) x 2"
        objHojaExcel.Range("J" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 2

        objHojaExcel.Range("A" & Fila_E.ToString & ":AN" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "A1 = 1° Lectura hidrometro + corrección por t°"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":AN" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "A2 = 2° Lectura hidrometro + corrección por t°"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":AN" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "B   = Lectura hidrómetro del blanco + corrección por t°"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


    End Sub
    Public Sub Encavezado_ResultadoTex(ByVal objHojaExcel As Excel.Worksheet, ByVal fila_d As Integer)
        '  Dim fila_d As Integer = 17
        Dim Fila_Ini As Integer = fila_d
        objHojaExcel.Range("A" & fila_d.ToString & ":H" & fila_d + 1.ToString).Merge()
        objHojaExcel.Range("A" & fila_d.ToString).Value = "N° Lab"
        objHojaExcel.Range("A" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & fila_d.ToString).Font.Size = 9
        objHojaExcel.Range("A" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & fila_d.ToString & ":AJ" & fila_d.ToString).Merge()
        objHojaExcel.Range("I" & fila_d.ToString).Value = "Lecturas"
        objHojaExcel.Range("I" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & fila_d.ToString).Font.Size = 8
        objHojaExcel.Range("I" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AK" & fila_d.ToString & ":BT" & fila_d.ToString).Merge()
        objHojaExcel.Range("AK" & fila_d.ToString).Value = "Separación arenas(peso en g)"
        objHojaExcel.Range("AK" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AK" & fila_d.ToString).Font.Size = 8
        objHojaExcel.Range("AK" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AK" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BU" & fila_d.ToString & ":DJ" & fila_d.ToString).Merge()
        objHojaExcel.Range("BU" & fila_d.ToString).Value = "Resultados"
        objHojaExcel.Range("BU" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BU" & fila_d.ToString).Font.Size = 8
        objHojaExcel.Range("BU" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BU" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        fila_d = fila_d + 1

        objHojaExcel.Range("I" & fila_d.ToString & ":L" & fila_d.ToString).Merge()
        objHojaExcel.Range("I" & fila_d.ToString).Value = "Bl"
        objHojaExcel.Range("I" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("I" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("M" & fila_d.ToString & ":R" & fila_d.ToString).Merge()
        objHojaExcel.Range("M" & fila_d.ToString).Value = "1°Lec"
        objHojaExcel.Range("M" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("M" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("M" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("M" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("S" & fila_d.ToString & ":X" & fila_d.ToString).Merge()
        objHojaExcel.Range("S" & fila_d.ToString).Value = "t°"
        objHojaExcel.Range("S" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("S" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("S" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("S" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Y" & fila_d.ToString & ":AD" & fila_d.ToString).Merge()
        objHojaExcel.Range("Y" & fila_d.ToString).Value = "2°Lec"
        objHojaExcel.Range("Y" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Y" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("Y" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("Y" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AE" & fila_d.ToString & ":AJ" & fila_d.ToString).Merge()
        objHojaExcel.Range("AE" & fila_d.ToString).Value = "t°"
        objHojaExcel.Range("AE" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AE" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("AE" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AE" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AK" & fila_d.ToString & ":AP" & fila_d.ToString).Merge()
        objHojaExcel.Range("AK" & fila_d.ToString).Value = "N°cap"
        objHojaExcel.Range("AK" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AK" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("AK" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AK" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AQ" & fila_d.ToString & ":AV" & fila_d.ToString).Merge()
        objHojaExcel.Range("AQ" & fila_d.ToString).Value = "P.cap(g)"
        objHojaExcel.Range("AQ" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AQ" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("AQ" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AQ" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AW" & fila_d.ToString & ":BB" & fila_d.ToString).Merge()
        objHojaExcel.Range("AW" & fila_d.ToString).Value = "cap+agru"
        objHojaExcel.Range("AW" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AW" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("AW" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AW" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & fila_d.ToString & ":BH" & fila_d.ToString).Merge()
        objHojaExcel.Range("BC" & fila_d.ToString).Value = "N°cap"
        objHojaExcel.Range("BC" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("BC" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BC" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BI" & fila_d.ToString & ":BN" & fila_d.ToString).Merge()
        objHojaExcel.Range("BI" & fila_d.ToString).Value = "P.cap(g)"
        objHojaExcel.Range("BI" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BI" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("BI" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BI" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BO" & fila_d.ToString & ":BT" & fila_d.ToString).Merge()
        objHojaExcel.Range("BO" & fila_d.ToString).Value = "cap+afin"
        objHojaExcel.Range("BO" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BO" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("BO" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BO" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BU" & fila_d.ToString & ":BZ" & fila_d.ToString).Merge()
        objHojaExcel.Range("BU" & fila_d.ToString).Value = "Arc(%)"
        objHojaExcel.Range("BU" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BU" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("BU" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BU" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CA" & fila_d.ToString & ":CF" & fila_d.ToString).Merge()
        objHojaExcel.Range("CA" & fila_d.ToString).Value = "Lim(%)"
        objHojaExcel.Range("CA" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CA" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("CA" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CA" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & fila_d.ToString & ":CL" & fila_d.ToString).Merge()
        objHojaExcel.Range("CG" & fila_d.ToString).Value = "Are(%)"
        objHojaExcel.Range("CG" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("CG" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CM" & fila_d.ToString & ":CR" & fila_d.ToString).Merge()
        objHojaExcel.Range("CM" & fila_d.ToString).Value = "agruesa(%)"
        objHojaExcel.Range("CM" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("CM" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CS" & fila_d.ToString & ":CX" & fila_d.ToString).Merge()
        objHojaExcel.Range("CS" & fila_d.ToString).Value = "afina(%)"
        objHojaExcel.Range("CS" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CS" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("CS" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CS" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CY" & fila_d.ToString & ":DJ" & fila_d.ToString).Merge()
        objHojaExcel.Range("CY" & fila_d.ToString).Value = "Clase Textural"
        objHojaExcel.Range("CY" & fila_d.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CY" & fila_d.ToString).Font.Size = 6
        objHojaExcel.Range("CY" & fila_d.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CY" & fila_d.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Bordes

        objHojaExcel.Range("A" & Fila_Ini.ToString & ":DJ" & Fila_Ini + 1.ToString).BorderAround()
        objHojaExcel.Range("I" & Fila_Ini + 1.ToString & ":DJ" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("H" & Fila_Ini.ToString & ":H" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("AJ" & Fila_Ini.ToString & ":AJ" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("BT" & Fila_Ini.ToString & ":BT" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("DJ" & Fila_Ini.ToString & ":DJ" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("CL" & Fila_Ini + 1.ToString & ":CL" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("CX" & Fila_Ini + 1.ToString & ":CX" & Fila_Ini + 1).BorderAround()
        BORDES_DER(objHojaExcel, "L", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "R", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "X", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "AD", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "AP", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "AV", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BB", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BH", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BN", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BZ", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "CF", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "CR", Fila_Ini + 1, Fila_Ini + 1)

    End Sub

    Public Sub BORDES_DER(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal letra As String, ByVal fila_i As String, ByVal fila_f As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(letra & fila_i.ToString & ":" & letra & fila_f.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Public Sub Imprime_PiePagTex(ByVal objHojaExcel As Excel.Worksheet, ByVal Analista As String, ByVal Digitador As String)

        Dim Fila_P As Integer = 58


        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Analista"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("I" & Fila_P.ToString).Value = Analista
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AM" & Fila_P.ToString & ":AS" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_P.ToString).Value = "Digita"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AT" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AT" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AT" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AW" & Fila_P.ToString & ":BX" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AW" & Fila_P.ToString).Value = Digitador
        objHojaExcel.Range("AW" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AW" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AW" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AW" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("BY" & Fila_P.ToString & ":CE" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BY" & Fila_P.ToString).Value = "Revisa"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BY" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BY" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_P.ToString & ":DJ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("CG" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CG" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CG" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("I" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AM" & Fila_P.ToString & ":AS" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AT" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AT" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AT" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AW" & Fila_P.ToString & ":BX" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AW" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("AW" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AW" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AW" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AW" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("BY" & Fila_P.ToString & ":CE" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BY" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BY" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BY" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_P.ToString & ":DJ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("CG" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CG" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CG" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("I" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AM" & Fila_P.ToString & ":AS" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AT" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AT" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AT" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AW" & Fila_P.ToString & ":BX" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AW" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("AW" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AW" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AW" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AW" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("BY" & Fila_P.ToString & ":CE" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BY" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BY" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BY" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_P.ToString & ":DJ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("CG" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CG" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CG" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    End Sub
    Public Sub Imprime_ResultadosTex(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_R As Integer = 19
        Dim Fila_Elemento As DataRow
        Dim Dato As Integer = 19
        Dim cont, Num_pag As Integer
        Num_pag = 1
        cont = 1
        For Each Fila_Elemento In Cjto_Tablas1.Tables("TEXTURA_SUELO1").Rows
            If Num_Pag = 1 Then
                Call Encavezado_ResultadoTex(objHojaExcel, 17)
            ElseIf Num_Pag = 2 Then
                Call Encavezado_ResultadoTex(objHojaExcel, 63)
            ElseIf Num_Pag = 3 Then
                Call Encavezado_ResultadoTex(objHojaExcel, 124)
            ElseIf Num_Pag = 4 Then
                Call Encavezado_ResultadoTex(objHojaExcel, 186)
            ElseIf Num_Pag = 5 Then
                Call Encavezado_ResultadoTex(objHojaExcel, 248)
            End If
            If cont < 39 Then
                objHojaExcel.Range("A" & Fila_R.ToString & ":H" & Fila_R.ToString).Merge()
                objHojaExcel.Range("A" & Fila_R.ToString).Value = Fila_Elemento("OT_NLAB")
                objHojaExcel.Range("A" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("A" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("A" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                objHojaExcel.Range("A" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("I" & Fila_R.ToString & ":L" & Fila_R.ToString).Merge()
                objHojaExcel.Range("I" & Fila_R.ToString).Value = "Bl"
                objHojaExcel.Range("I" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("I" & Fila_R.ToString).Font.Size = 6
                objHojaExcel.Range("I" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("I" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("M" & Fila_R.ToString & ":R" & Fila_R.ToString).Merge()
                objHojaExcel.Range("M" & Fila_R.ToString).Value = Fila_Elemento("LECTURA1")
                objHojaExcel.Range("M" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("M" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("M" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("M" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("S" & Fila_R.ToString & ":X" & Fila_R.ToString).Merge()
                objHojaExcel.Range("S" & Fila_R.ToString).Value = Fila_Elemento("TEMP1")
                objHojaExcel.Range("S" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("S" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("S" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("S" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("Y" & Fila_R.ToString & ":AD" & Fila_R.ToString).Merge()
                objHojaExcel.Range("Y" & Fila_R.ToString).Value = Fila_Elemento("LECTURA2")
                objHojaExcel.Range("Y" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("Y" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("Y" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("Y" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("AE" & Fila_R.ToString & ":AJ" & Fila_R.ToString).Merge()
                objHojaExcel.Range("AE" & Fila_R.ToString).Value = Fila_Elemento("TEMP2")
                objHojaExcel.Range("AE" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("AE" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("AE" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("AE" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("AK" & Fila_R.ToString & ":AP" & Fila_R.ToString).Merge()
                objHojaExcel.Range("AK" & Fila_R.ToString).Value = Fila_Elemento("ID_CAPSULA")
                objHojaExcel.Range("AK" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("AK" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("AK" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("AK" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("AQ" & Fila_R.ToString & ":AV" & Fila_R.ToString).Merge()
                objHojaExcel.Range("AQ" & Fila_R.ToString).Value = Fila_Elemento("TARA_CAPSULA")
                objHojaExcel.Range("AQ" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("AQ" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("AQ" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("AQ" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("AW" & Fila_R.ToString & ":BB" & Fila_R.ToString).Merge()
                objHojaExcel.Range("AW" & Fila_R.ToString).Value = Fila_Elemento("PESO_CAPSULAMASMUESTRA")
                objHojaExcel.Range("AW" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("AW" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("AW" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("AW" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("BC" & Fila_R.ToString & ":BH" & Fila_R.ToString).Merge()
                objHojaExcel.Range("BC" & Fila_R.ToString).Value = Fila_Elemento("ID_CAPSULA2")
                objHojaExcel.Range("BC" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("BC" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("BC" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("BC" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("BI" & Fila_R.ToString & ":BN" & Fila_R.ToString).Merge()
                objHojaExcel.Range("BI" & Fila_R.ToString).Value = Fila_Elemento("TARA_CAPSULA2")
                objHojaExcel.Range("BI" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("BI" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("BI" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("BI" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("BO" & Fila_R.ToString & ":BT" & Fila_R.ToString).Merge()
                objHojaExcel.Range("BO" & Fila_R.ToString).Value = Fila_Elemento("PESO_CAPSULAMASMUESTRA2")
                objHojaExcel.Range("BO" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("BO" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("BO" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("BO" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("BU" & Fila_R.ToString & ":BZ" & Fila_R.ToString).Merge()
                objHojaExcel.Range("BU" & Fila_R.ToString).Value = Fila_Elemento("ARC")
                objHojaExcel.Range("BU" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("BU" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("BU" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("BU" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("CA" & Fila_R.ToString & ":CF" & Fila_R.ToString).Merge()
                objHojaExcel.Range("CA" & Fila_R.ToString).Value = Fila_Elemento("LIMO")
                objHojaExcel.Range("CA" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("CA" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("CA" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("CA" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("CG" & Fila_R.ToString & ":CL" & Fila_R.ToString).Merge()
                objHojaExcel.Range("CG" & Fila_R.ToString).Value = Fila_Elemento("ARENA")
                objHojaExcel.Range("CG" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("CG" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("CG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("CG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("CM" & Fila_R.ToString & ":CR" & Fila_R.ToString).Merge()
                objHojaExcel.Range("CM" & Fila_R.ToString).Value = Fila_Elemento("FRACCION_ARENA")
                objHojaExcel.Range("CM" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("CM" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("CM" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("CM" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("CS" & Fila_R.ToString & ":CX" & Fila_R.ToString).Merge()
                objHojaExcel.Range("CS" & Fila_R.ToString).Value = Fila_Elemento("FRACCION_ARENA2")
                objHojaExcel.Range("CS" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("CS" & Fila_R.ToString).Font.Size = 9
                objHojaExcel.Range("CS" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("CS" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("CY" & Fila_R.ToString & ":DJ" & Fila_R.ToString).Merge()
                objHojaExcel.Range("CY" & Fila_R.ToString).Value = Fila_Elemento("CLASE_TEXTURAL")
                objHojaExcel.Range("CY" & Fila_R.ToString).Font.Name = "Times New Roman"
                objHojaExcel.Range("CY" & Fila_R.ToString).Font.Size = 8
                objHojaExcel.Range("CY" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("CY" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                BORDES(objHojaExcel, Fila_R, Fila_R, "A", "DJ")

                BORDES_DER(objHojaExcel, "L", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "R", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "X", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "AD", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "AP", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "AV", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "BB", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "BH", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "BN", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "BZ", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "CF", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "CR", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "C", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "H", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "AJ", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "BT", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "CL", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "CX", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "DJ", Fila_R, Fila_R)
                BORDES_DER(objHojaExcel, "A", Fila_R, Fila_R)

                Fila_R = Fila_R + 1

                If Fila_R = 54 And Num_pag = 1 Then
                    Fila_R = Fila_R + 11
                    Num_pag = Num_pag + 1
                ElseIf Fila_R = 123 And Num_pag = 2 Then
                    Fila_R = Fila_R + 3
                    Num_pag = Num_pag + 1
                ElseIf Fila_R = 185 And Num_pag = 3 Then
                    Fila_R = Fila_R + 3
                    Num_pag = Num_pag + 1
                ElseIf Fila_R = 247 And Num_pag = 4 Then
                    Fila_R = Fila_R + 3
                    Num_pag = Num_pag + 1
                End If
            End If
           
            'objHojaExcel.Range("A" & Dato.ToString & ":DJ" & Fila_R - 1.ToString).BorderAround()
            'objHojaExcel.Range("H" & Dato.ToString & ":H" & Fila_R - 1.ToString).BorderAround()
            'objHojaExcel.Range("AJ" & Dato.ToString & ":AJ" & Fila_R - 1.ToString).BorderAround()
            'objHojaExcel.Range("BT" & Dato.ToString & ":BT" & Fila_R - 1.ToString).BorderAround()
            'objHojaExcel.Range("CL" & Dato.ToString & ":CL" & Fila_R - 1.ToString).BorderAround()
            'objHojaExcel.Range("CX" & Dato.ToString & ":CX" & Fila_R - 1.ToString).BorderAround()


        Next

    End Sub
    Private Sub BORDES(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila As Integer, ByVal fila2 As Integer, ByVal Letra1 As String, ByVal Letra2 As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila2.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub
    Private Sub BORDES_OSC(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila As Integer, ByVal fila2 As Integer, ByVal Letra1 As String, ByVal Letra2 As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila2.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlThin
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub


    Public Sub Encavezado_Densidad(ByVal objHojaExcel As Excel.Worksheet, ByVal Cal_Den As String)
        Dim Fila_E As Integer = 7
        Dim Fila_D As Integer = 8
        Dim Ini As Integer = 8
        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila_E.ToString & ":DJ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_E.ToString).Value = "Datos calcúlo(Ejemplo)"
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_E, Fila_E, "CJ", "DJ")

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":AN" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = Cal_Den
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 2

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Donde"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "S"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "masa,en g, terrón seco"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "H"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "masa,en g, terrón humedecido"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "HE"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "masa,en g, terrón humedecido cubierto con parafina"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "HEa"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "masa,en g, terrón humedecido cubierto con parafina,suspendido en agua"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "D"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "densidad,en g/cc,parafina"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Dato del Calculo'''''

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa S"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "10.0"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa H"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "12.6"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa HE"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "14.2"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa HEa"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "9.6"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa alambre"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "1.3"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa albre.en agua"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "1.2"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Densidad paraf(D)"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g/cc)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "1.2"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        BORDES_DER(objHojaExcel, "CI", Ini, Fila_D)
        BORDES_DER(objHojaExcel, "DJ", Ini, Fila_D)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Fila_Exp = Fila_E



    End Sub

    Public Sub Encavezado_Resultado_Densidad(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Ini As Integer = Fila

        objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila + 1.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "N°Lab"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila.ToString & ":J" & Fila.ToString).Merge()
        objHojaExcel.Range("I" & Fila.ToString).Value = "N°"
        objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("K" & Fila.ToString & ":AH" & Fila.ToString).Merge()
        objHojaExcel.Range("K" & Fila.ToString).Value = "Masa terrón(g)"
        objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("K" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AI" & Fila.ToString & ":AQ" & Fila.ToString).Merge()
        objHojaExcel.Range("AI" & Fila.ToString).Value = "Obs"
        objHojaExcel.Range("AI" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AR" & Fila.ToString & ":BC" & Fila.ToString).Merge()
        objHojaExcel.Range("AR" & Fila.ToString).Value = "Dap(g/cc)"
        objHojaExcel.Range("AR" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AR" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AR" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("I" & Fila.ToString & ":J" & Fila.ToString).Merge()
        objHojaExcel.Range("I" & Fila.ToString).Value = "t"
        objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("K" & Fila.ToString & ":P" & Fila.ToString).Merge()
        objHojaExcel.Range("K" & Fila.ToString).Value = "Seco"
        objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("K" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Q" & Fila.ToString & ":V" & Fila.ToString).Merge()
        objHojaExcel.Range("Q" & Fila.ToString).Value = "Húmedo"
        objHojaExcel.Range("Q" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Q" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("Q" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("Q" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & Fila.ToString & ":AB" & Fila.ToString).Merge()
        objHojaExcel.Range("W" & Fila.ToString).Value = "+Parafa"
        objHojaExcel.Range("W" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("W" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("W" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("W" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AC" & Fila.ToString & ":AH" & Fila.ToString).Merge()
        objHojaExcel.Range("AC" & Fila.ToString).Value = "en agua"
        objHojaExcel.Range("AC" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AC" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AR" & Fila.ToString & ":AW" & Fila.ToString).Merge()
        objHojaExcel.Range("AR" & Fila.ToString).Value = "terrón"
        objHojaExcel.Range("AR" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AR" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AR" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AX" & Fila.ToString & ":BC" & Fila.ToString).Merge()
        objHojaExcel.Range("AX" & Fila.ToString).Value = "prom"
        objHojaExcel.Range("AX" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AX" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AX" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("A" & Fila_Ini.ToString & ":BC" & Fila.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "H", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "J", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "AH", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "AQ", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "P", Fila, Fila)
        BORDES_DER(objHojaExcel, "V", Fila, Fila)
        BORDES_DER(objHojaExcel, "AB", Fila, Fila)
        BORDES_DER(objHojaExcel, "AW", Fila, Fila)

        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "K", "AH")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "AR", "BC")

        Fila_Exp = Fila
    End Sub

    Public Sub Encavezado_Resultado_Densidad2(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Ini As Integer = Fila

        objHojaExcel.Range("BH" & Fila.ToString & ":BO" & Fila + 1.ToString).Merge()
        objHojaExcel.Range("BH" & Fila.ToString).Value = "N°Lab"
        objHojaExcel.Range("BH" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BH" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("BH" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BH" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BP" & Fila.ToString & ":BQ" & Fila.ToString).Merge()
        objHojaExcel.Range("BP" & Fila.ToString).Value = "N°"
        objHojaExcel.Range("BP" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BP" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BP" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BP" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BR" & Fila.ToString & ":CO" & Fila.ToString).Merge()
        objHojaExcel.Range("BR" & Fila.ToString).Value = "Masa terrón(g)"
        objHojaExcel.Range("BR" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BR" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BR" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CP" & Fila.ToString & ":CX" & Fila.ToString).Merge()
        objHojaExcel.Range("CP" & Fila.ToString).Value = "Obs"
        objHojaExcel.Range("CP" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CP" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CP" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CP" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CY" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        objHojaExcel.Range("CY" & Fila.ToString).Value = "Dap(g/cc)"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("BP" & Fila.ToString & ":BQ" & Fila.ToString).Merge()
        objHojaExcel.Range("BP" & Fila.ToString).Value = "t"
        objHojaExcel.Range("BP" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BP" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BP" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BP" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BR" & Fila.ToString & ":BW" & Fila.ToString).Merge()
        objHojaExcel.Range("BR" & Fila.ToString).Value = "Seco"
        objHojaExcel.Range("BR" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BR" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("BR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BR" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BX" & Fila.ToString & ":CC" & Fila.ToString).Merge()
        objHojaExcel.Range("BX" & Fila.ToString).Value = "Húmedo"
        objHojaExcel.Range("BX" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BX" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("BX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BX" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CD" & Fila.ToString & ":CI" & Fila.ToString).Merge()
        objHojaExcel.Range("CD" & Fila.ToString).Value = "+Parafa"
        objHojaExcel.Range("CD" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CD" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CD" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CD" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila.ToString & ":CO" & Fila.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila.ToString).Value = "en agua"
        objHojaExcel.Range("CJ" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CJ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CJ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CY" & Fila.ToString & ":DD" & Fila.ToString).Merge()
        objHojaExcel.Range("CY" & Fila.ToString).Value = "terrón"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DE" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        objHojaExcel.Range("DE" & Fila.ToString).Value = "prom"
        objHojaExcel.Range("DE" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DE" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("DE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BH" & Fila_Ini.ToString & ":DJ" & Fila.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "BO", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "BQ", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "CO", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "CX", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "BW", Fila, Fila)
        BORDES_DER(objHojaExcel, "CC", Fila, Fila)
        BORDES_DER(objHojaExcel, "CI", Fila, Fila)
        BORDES_DER(objHojaExcel, "DD", Fila, Fila)

        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "BR", "CO")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "CY", "DJ")
    End Sub

    Public Sub Imprime_Resultados_Densidad(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Elemento As DataRow
        Fila = 20
        Dim Fila_Ini As Integer = Fila
        Dim Fila2 As Integer
        Dim cont As String = 0
        Dim cont2 As Integer = 1
        Dim Cam_Col As String = "N"
        Dim Num_Pag As Integer = 1
        Dim promedio, dato As Double
        For Each Fila_Elemento In Cjto_Tablas1.Tables("DENSIDAD").Rows

            If Num_Pag < 2 Then

                If Fila <= 54 Then
                    If Num_Pag = 1 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 18)
                        Fila2 = 20
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 64)
                        Fila2 = 65
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 126)
                        Fila2 = 127
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 188)
                        Fila2 = 189
                    End If


                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLAB")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":J" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("INDICE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 7
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("K" & Fila.ToString & ":P" & Fila.ToString).Merge()
                    objHojaExcel.Range("K" & Fila.ToString).Value = Fila_Elemento("PESO_SECO")
                    objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("K" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("Q" & Fila.ToString & ":V" & Fila.ToString).Merge()
                    objHojaExcel.Range("Q" & Fila.ToString).Value = Fila_Elemento("PESO_HUME")
                    objHojaExcel.Range("Q" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("Q" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("Q" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("Q" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("W" & Fila.ToString & ":AB" & Fila.ToString).Merge()
                    objHojaExcel.Range("W" & Fila.ToString).Value = Fila_Elemento("PESO_EMP")
                    objHojaExcel.Range("W" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("W" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("W" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("W" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AC" & Fila.ToString & ":AH" & Fila.ToString).Merge()
                    objHojaExcel.Range("AC" & Fila.ToString).Value = Fila_Elemento("PESO_EMP_AGUA")
                    objHojaExcel.Range("AC" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AC" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AI" & Fila.ToString & ":AQ" & Fila.ToString).Merge()
                    objHojaExcel.Range("AI" & Fila.ToString).Value = Fila_Elemento("OBSERVACION")
                    objHojaExcel.Range("AI" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AI" & Fila.ToString).Font.Size = 6
                    objHojaExcel.Range("AI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AR" & Fila.ToString & ":AW" & Fila.ToString).Merge()
                    objHojaExcel.Range("AR" & Fila.ToString).Value = Fila_Elemento("DENSIDAD_APA")
                    objHojaExcel.Range("AR" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AR" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AR" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AX" & Fila.ToString & ":BC" & Fila.ToString).Merge()
                    objHojaExcel.Range("AX" & Fila.ToString).Value = promedio
                    objHojaExcel.Range("AX" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AX" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AX" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    BORDES(objHojaExcel, Fila, Fila, "I", "AW")

                    cont = cont + 1

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If cont Mod 5 = 0 Then
                        BORDES_OSC(objHojaExcel, Fila, Fila, "A", "BC")
                    End If
                    'If IsNothing(objHojaExcel.Range("AR" & Fila.ToString).Value) = False Then
                    '    dato = CDbl(objHojaExcel.Range("AR" & Fila.ToString).Value)
                    '    promedio = promedio + dato
                    '    cont2 = cont2 + 1
                    '    promedio = promedio / cont2
                    '    promedio = Round(promedio, 2)
                    'Else

                    'End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "J", Fila, Fila)
                    BORDES_DER(objHojaExcel, "P", Fila, Fila)
                    BORDES_DER(objHojaExcel, "V", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AB", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AH", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AQ", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AW", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AX", Fila, Fila)
                    'objHojaExcel.Range("A" & Fila_Ini.ToString & ":BC" & Fila - 1.ToString).BorderAround()

                    Fila = Fila + 1

                    If Fila = 55 Then
                        Cam_Col = "S"
                        GoTo salto
                    End If
                End If

                If Fila >= 55 And Cam_Col = "S" Then

                    If Num_Pag = 1 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BH" & Fila2.ToString & ":BO" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BH" & Fila2.ToString).Value = Fila_Elemento("OT_NLAB")
                    objHojaExcel.Range("BH" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BH" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BH" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BH" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BP" & Fila2.ToString & ":BQ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BP" & Fila2.ToString).Value = Fila_Elemento("INDICE")
                    objHojaExcel.Range("BP" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BP" & Fila2.ToString).Font.Size = 7
                    objHojaExcel.Range("BP" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BP" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BR" & Fila2.ToString & ":BW" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BR" & Fila2.ToString).Value = Fila_Elemento("PESO_SECO")
                    objHojaExcel.Range("BR" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BR" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BR" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BR" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BX" & Fila2.ToString & ":CC" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BX" & Fila2.ToString).Value = Fila_Elemento("PESO_HUME")
                    objHojaExcel.Range("BX" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BX" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BX" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BX" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CD" & Fila2.ToString & ":CI" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CD" & Fila2.ToString).Value = Fila_Elemento("PESO_EMP")
                    objHojaExcel.Range("CD" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CD" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CD" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CD" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CJ" & Fila2.ToString & ":CO" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CJ" & Fila2.ToString).Value = Fila_Elemento("PESO_EMP_AGUA")
                    objHojaExcel.Range("CJ" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CJ" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CJ" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CJ" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CP" & Fila2.ToString & ":CX" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CP" & Fila2.ToString).Value = Fila_Elemento("OBSERVACION")
                    objHojaExcel.Range("CP" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CP" & Fila2.ToString).Font.Size = 6
                    objHojaExcel.Range("CP" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("Cp" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CY" & Fila2.ToString & ":DD" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CY" & Fila2.ToString).Value = Fila_Elemento("DENSIDAD_APA")
                    objHojaExcel.Range("CY" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CY" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CY" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CY" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("DE" & Fila2.ToString & ":DJ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("DE" & Fila2.ToString).Value = promedio
                    objHojaExcel.Range("DE" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("DE" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("DE" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("DE" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    BORDES(objHojaExcel, Fila2, Fila2, "BP", "DD")

                    cont = cont + 1

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If cont Mod 5 = 0 Then
                        BORDES_OSC(objHojaExcel, Fila2, Fila2, "BH", "DJ")
                    End If
                    'If IsNothing(objHojaExcel.Range("AR" & Fila.ToString).Value) = False Then
                    '    dato = CDbl(objHojaExcel.Range("AR" & Fila.ToString).Value)
                    '    promedio = promedio + dato
                    '    cont2 = cont2 + 1
                    '    promedio = promedio / cont2
                    '    promedio = Round(promedio, 2)
                    'Else

                    'End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    BORDES_DER(objHojaExcel, "BH", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BO", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BQ", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BW", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CC", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CI", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CO", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CX", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "DD", Fila2, Fila2)

                    'objHojaExcel.Range("A" & Fila_Ini.ToString & ":BC" & Fila - 1.ToString).BorderAround()

                    Fila2 = Fila2 + 1

                    If Fila2 = 55 Then
                        Cam_Col = "N"
                        Num_Pag = Num_Pag + 1
                        Fila = Fila2 + 11
                        GoTo salto
                    End If

                End If

            End If

            
            If Num_Pag > 1 Then

                If Cam_Col = "N" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 18)
                        Fila2 = 19
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 64)
                        Fila2 = 66
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 126)
                        Fila2 = 128
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_Resultado_Densidad(objHojaExcel, 188)
                        Fila2 = 190
                    End If

                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLAB")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":J" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("INDICE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 7
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("K" & Fila.ToString & ":P" & Fila.ToString).Merge()
                    objHojaExcel.Range("K" & Fila.ToString).Value = Fila_Elemento("PESO_SECO")
                    objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("K" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("Q" & Fila.ToString & ":V" & Fila.ToString).Merge()
                    objHojaExcel.Range("Q" & Fila.ToString).Value = Fila_Elemento("PESO_HUME")
                    objHojaExcel.Range("Q" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("Q" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("Q" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("Q" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("W" & Fila.ToString & ":AB" & Fila.ToString).Merge()
                    objHojaExcel.Range("W" & Fila.ToString).Value = Fila_Elemento("PESO_EMP")
                    objHojaExcel.Range("W" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("W" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("W" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("W" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AC" & Fila.ToString & ":AH" & Fila.ToString).Merge()
                    objHojaExcel.Range("AC" & Fila.ToString).Value = Fila_Elemento("PESO_EMP_AGUA")
                    objHojaExcel.Range("AC" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AC" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AI" & Fila.ToString & ":AQ" & Fila.ToString).Merge()
                    objHojaExcel.Range("AI" & Fila.ToString).Value = Fila_Elemento("OBSERVACION")
                    objHojaExcel.Range("AI" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AI" & Fila.ToString).Font.Size = 6
                    objHojaExcel.Range("AI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AR" & Fila.ToString & ":AW" & Fila.ToString).Merge()
                    objHojaExcel.Range("AR" & Fila.ToString).Value = Fila_Elemento("DENSIDAD_APA")
                    objHojaExcel.Range("AR" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AR" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AR" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AR" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AX" & Fila.ToString & ":BC" & Fila.ToString).Merge()
                    objHojaExcel.Range("AX" & Fila.ToString).Value = promedio
                    objHojaExcel.Range("AX" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AX" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AX" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AX" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    BORDES(objHojaExcel, Fila, Fila, "I", "AW")

                    cont = cont + 1

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If cont Mod 5 = 0 Then
                        BORDES_OSC(objHojaExcel, Fila, Fila, "A", "BC")
                    End If
                    'If IsNothing(objHojaExcel.Range("AR" & Fila.ToString).Value) = False Then
                    '    dato = CDbl(objHojaExcel.Range("AR" & Fila.ToString).Value)
                    '    promedio = promedio + dato
                    '    cont2 = cont2 + 1
                    '    promedio = promedio / cont2
                    '    promedio = Round(promedio, 2)
                    'Else

                    'End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "J", Fila, Fila)
                    BORDES_DER(objHojaExcel, "P", Fila, Fila)
                    BORDES_DER(objHojaExcel, "V", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AB", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AH", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AQ", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AW", Fila, Fila)
                    'objHojaExcel.Range("A" & Fila_Ini.ToString & ":BC" & Fila - 1.ToString).BorderAround()

                    Fila = Fila + 1
                    cont2 = cont2 + 1
                    If cont2 = 56 Then
                        Cam_Col = "S"
                        cont2 = 1
                        GoTo salto
                    End If

                End If


                If Cam_Col = "S" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_Resultado_Densidad2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BH" & Fila2.ToString & ":BO" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BH" & Fila2.ToString).Value = Fila_Elemento("OT_NLAB")
                    objHojaExcel.Range("BH" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BH" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BH" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BH" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BP" & Fila2.ToString & ":BQ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BP" & Fila2.ToString).Value = Fila_Elemento("INDICE")
                    objHojaExcel.Range("BP" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BP" & Fila2.ToString).Font.Size = 7
                    objHojaExcel.Range("BP" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BP" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BR" & Fila2.ToString & ":BW" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BR" & Fila2.ToString).Value = Fila_Elemento("PESO_SECO")
                    objHojaExcel.Range("BR" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BR" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BR" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BR" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BX" & Fila2.ToString & ":CC" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BX" & Fila2.ToString).Value = Fila_Elemento("PESO_HUME")
                    objHojaExcel.Range("BX" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BX" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BX" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BX" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CD" & Fila2.ToString & ":CI" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CD" & Fila2.ToString).Value = Fila_Elemento("PESO_EMP")
                    objHojaExcel.Range("CD" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CD" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CD" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CD" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CJ" & Fila2.ToString & ":CO" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CJ" & Fila2.ToString).Value = Fila_Elemento("PESO_EMP_AGUA")
                    objHojaExcel.Range("CJ" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CJ" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CJ" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CJ" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CP" & Fila2.ToString & ":CX" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CP" & Fila2.ToString).Value = Fila_Elemento("OBSERVACION")
                    objHojaExcel.Range("CP" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CP" & Fila2.ToString).Font.Size = 6
                    objHojaExcel.Range("CP" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("Cp" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CY" & Fila2.ToString & ":DD" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CY" & Fila2.ToString).Value = Fila_Elemento("DENSIDAD_APA")
                    objHojaExcel.Range("CY" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CY" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CY" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CY" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("DE" & Fila2.ToString & ":DJ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("DE" & Fila2.ToString).Value = promedio
                    objHojaExcel.Range("DE" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("DE" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("DE" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("DE" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    BORDES(objHojaExcel, Fila2, Fila2, "BP", "DD")

                    cont = cont + 1

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If cont Mod 5 = 0 Then
                        BORDES_OSC(objHojaExcel, Fila2, Fila2, "BH", "DJ")
                    End If
                    'If IsNothing(objHojaExcel.Range("AR" & Fila.ToString).Value) = False Then
                    '    dato = CDbl(objHojaExcel.Range("AR" & Fila.ToString).Value)
                    '    promedio = promedio + dato
                    '    cont2 = cont2 + 1
                    '    promedio = promedio / cont2
                    '    promedio = Round(promedio, 2)
                    'Else

                    'End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    BORDES_DER(objHojaExcel, "BH", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BO", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BQ", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BW", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CC", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CI", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CO", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CX", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "DD", Fila2, Fila2)

                    'objHojaExcel.Range("A" & Fila_Ini.ToString & ":BC" & Fila - 1.ToString).BorderAround()

                    Fila2 = Fila2 + 1
                    cont2 = cont2 + 1

                    If cont2 = 56 Then
                        Cam_Col = "N"
                        Num_Pag = Num_Pag + 1
                        Fila = Fila2 + 7
                        cont2 = 1
                        GoTo salto
                    End If

                End If

            End If


salto:
        Next
       
    End Sub

    Public Sub Imprime_Resultados_Densidad2(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila2 As Integer)
        Dim Fila_Elemento As DataRow
        Dim Fila_Ini As Integer = Fila2
        Dim cont As String = 0
        Dim cont2 As Integer = 0
        Dim cam_col = "N"
        Dim promedio, dato As Double
        For Each Fila_Elemento In Cjto_Tablas1.Tables("DENSIDAD").Rows

            objHojaExcel.Range("BH" & Fila2.ToString & ":BO" & Fila2.ToString).Merge()
            objHojaExcel.Range("BH" & Fila2.ToString).Value = Fila_Elemento("OT_NLAB")
            objHojaExcel.Range("BH" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BH" & Fila2.ToString).Font.Size = 9
            objHojaExcel.Range("BH" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BH" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BP" & Fila2.ToString & ":BQ" & Fila2.ToString).Merge()
            objHojaExcel.Range("BP" & Fila2.ToString).Value = Fila_Elemento("INDICE")
            objHojaExcel.Range("BP" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BP" & Fila2.ToString).Font.Size = 7
            objHojaExcel.Range("BP" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BP" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BR" & Fila2.ToString & ":BW" & Fila2.ToString).Merge()
            objHojaExcel.Range("BR" & Fila2.ToString).Value = Fila_Elemento("PESO_SECO")
            objHojaExcel.Range("BR" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BR" & Fila2.ToString).Font.Size = 9
            objHojaExcel.Range("BR" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BR" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BX" & Fila2.ToString & ":CC" & Fila2.ToString).Merge()
            objHojaExcel.Range("BX" & Fila2.ToString).Value = Fila_Elemento("PESO_HUME")
            objHojaExcel.Range("BX" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BX" & Fila2.ToString).Font.Size = 9
            objHojaExcel.Range("BX" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BX" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CD" & Fila2.ToString & ":CI" & Fila2.ToString).Merge()
            objHojaExcel.Range("CD" & Fila2.ToString).Value = Fila_Elemento("PESO_EMP")
            objHojaExcel.Range("CD" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CD" & Fila2.ToString).Font.Size = 9
            objHojaExcel.Range("CD" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CD" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CJ" & Fila2.ToString & ":CO" & Fila2.ToString).Merge()
            objHojaExcel.Range("CJ" & Fila2.ToString).Value = Fila_Elemento("PESO_EMP_AGUA")
            objHojaExcel.Range("CJ" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CJ" & Fila2.ToString).Font.Size = 9
            objHojaExcel.Range("CJ" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CJ" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CP" & Fila2.ToString & ":CX" & Fila2.ToString).Merge()
            objHojaExcel.Range("CP" & Fila2.ToString).Value = Fila_Elemento("OBSERVACION")
            objHojaExcel.Range("CP" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CP" & Fila2.ToString).Font.Size = 6
            objHojaExcel.Range("CP" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("Cp" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CY" & Fila2.ToString & ":DD" & Fila2.ToString).Merge()
            objHojaExcel.Range("CY" & Fila2.ToString).Value = Fila_Elemento("DENSIDAD_APA")
            objHojaExcel.Range("CY" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CY" & Fila2.ToString).Font.Size = 9
            objHojaExcel.Range("CY" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CY" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("DE" & Fila2.ToString & ":DJ" & Fila2.ToString).Merge()
            objHojaExcel.Range("DE" & Fila2.ToString).Value = promedio
            objHojaExcel.Range("DE" & Fila2.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("DE" & Fila2.ToString).Font.Size = 9
            objHojaExcel.Range("DE" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("DE" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            BORDES(objHojaExcel, Fila2, Fila2, "I", "AW")

            cont = cont + 1

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If cont Mod 5 = 0 Then
                BORDES_OSC(objHojaExcel, Fila2, Fila2, "A", "BC")
            End If
            'If IsNothing(objHojaExcel.Range("AR" & Fila.ToString).Value) = False Then
            '    dato = CDbl(objHojaExcel.Range("AR" & Fila.ToString).Value)
            '    promedio = promedio + dato
            '    cont2 = cont2 + 1
            '    promedio = promedio / cont2
            '    promedio = Round(promedio, 2)
            'Else

            'End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            BORDES_DER(objHojaExcel, "H", Fila2, Fila2)
            BORDES_DER(objHojaExcel, "J", Fila2, Fila2)
            BORDES_DER(objHojaExcel, "P", Fila2, Fila2)
            BORDES_DER(objHojaExcel, "V", Fila2, Fila2)
            BORDES_DER(objHojaExcel, "AB", Fila2, Fila2)
            BORDES_DER(objHojaExcel, "AH", Fila2, Fila2)
            BORDES_DER(objHojaExcel, "AQ", Fila2, Fila2)
            BORDES_DER(objHojaExcel, "AW", Fila2, Fila2)
            'objHojaExcel.Range("A" & Fila_Ini.ToString & ":BC" & Fila - 1.ToString).BorderAround()

            Fila2 = Fila2 + 1

            If Fila2 = 59 Then
                cam_col = "S"
            End If

        Next
         End Sub
    Public Sub Encavezado_RetHumedad(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_E As Integer = 7
        Dim Fila_D As Integer = 8
        Dim Ini As Integer = 8
        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila_E.ToString & ":DJ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_E.ToString).Value = "Datos calcúlo(Ejemplo)"
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_E, Fila_E, "CJ", "DJ")

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":AZ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "0,33 bar o PMP(%) = (H 0,33 - S 0,33)/S 0,33"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":AZ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "15,0 bar o PMP(%) = (H 15,0 - S 15,0)/S 15,0"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":AZ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Hum aprovechable(%) = CC(%)-PMP(%)"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":AZ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Donde:"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "H"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "masa,en g, muestra húmeda"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "S"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "masa,en g, muestra seca a 105°C"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":F" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "b"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("G" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("G" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("G" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("G" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_E.ToString & ":BH" & Fila_E.ToString).Merge()
        objHojaExcel.Range("I" & Fila_E.ToString).Value = "masa,en g,tara bandeja"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Dato del Calculo'''''

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa H 0,33"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "30.11"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa S 0,33"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "24.67"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa b 0,33"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "2.5"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa H 15,0"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "24.26"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa S 15,0"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "21,44"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa b 15,0"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "2,5"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Resultado 0,33"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(%)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "24,53"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Resultado 0,15"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(%)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "14,88"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        BORDES_DER(objHojaExcel, "CI", Ini, Fila_D)
        BORDES_DER(objHojaExcel, "DJ", Ini, Fila_D)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Fila_Exp = Fila_E


    End Sub

    Public Sub Encavezado_Resultado_RetHumedad(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Ini As Integer = Fila

        objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila + 1.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "N°Lab"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila.ToString & ":K" & Fila.ToString).Merge()
        objHojaExcel.Range("I" & Fila.ToString).Value = "N°"
        objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("L" & Fila.ToString & ":AI" & Fila.ToString).Merge()
        objHojaExcel.Range("L" & Fila.ToString).Value = "Masa 0,33 bar(g)"
        objHojaExcel.Range("L" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("L" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("L" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AJ" & Fila.ToString & ":AL" & Fila.ToString).Merge()
        objHojaExcel.Range("AJ" & Fila.ToString).Value = "N°"
        objHojaExcel.Range("AJ" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AJ" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AJ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AJ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AM" & Fila.ToString & ":BJ" & Fila.ToString).Merge()
        objHojaExcel.Range("AM" & Fila.ToString).Value = "Masa 15,0 bar(g)"
        objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BK" & Fila.ToString & ":BZ" & Fila.ToString).Merge()
        objHojaExcel.Range("BK" & Fila.ToString).Value = "Resultado 0,33 bar(%)"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CA" & Fila.ToString & ":CP" & Fila.ToString).Merge()
        objHojaExcel.Range("CA" & Fila.ToString).Value = "Resultado 15,0 bar(%)"
        objHojaExcel.Range("CA" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CA" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CQ" & Fila.ToString & ":DF" & Fila.ToString).Merge()
        objHojaExcel.Range("CQ" & Fila.ToString).Value = "Res.Hum.aprov(%)"
        objHojaExcel.Range("CQ" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CQ" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CQ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CQ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        Fila = Fila + 1

        objHojaExcel.Range("I" & Fila.ToString & ":K" & Fila.ToString).Merge()
        objHojaExcel.Range("I" & Fila.ToString).Value = "ban"
        objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("L" & Fila.ToString & ":S" & Fila.ToString).Merge()
        objHojaExcel.Range("L" & Fila.ToString).Value = "Tara band"
        objHojaExcel.Range("L" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("L" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("L" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("T" & Fila.ToString & ":AA" & Fila.ToString).Merge()
        objHojaExcel.Range("T" & Fila.ToString).Value = "Húmedo+b"
        objHojaExcel.Range("T" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("T" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("T" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("T" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AB" & Fila.ToString & ":AI" & Fila.ToString).Merge()
        objHojaExcel.Range("AB" & Fila.ToString).Value = "Seco+b"
        objHojaExcel.Range("AB" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AB" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AB" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AB" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AJ" & Fila.ToString & ":AL" & Fila.ToString).Merge()
        objHojaExcel.Range("AJ" & Fila.ToString).Value = "ban"
        objHojaExcel.Range("AJ" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AJ" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AJ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AJ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AM" & Fila.ToString & ":AT" & Fila.ToString).Merge()
        objHojaExcel.Range("AM" & Fila.ToString).Value = "Tara band"
        objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AU" & Fila.ToString & ":BB" & Fila.ToString).Merge()
        objHojaExcel.Range("AU" & Fila.ToString).Value = "Húmedo+b"
        objHojaExcel.Range("AU" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AU" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila.ToString & ":BJ" & Fila.ToString).Merge()
        objHojaExcel.Range("BC" & Fila.ToString).Value = "Seco+b"
        objHojaExcel.Range("BC" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("BC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BK" & Fila.ToString & ":BR" & Fila.ToString).Merge()
        objHojaExcel.Range("BK" & Fila.ToString).Value = "Res"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("BK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BS" & Fila.ToString & ":BZ" & Fila.ToString).Merge()
        objHojaExcel.Range("BS" & Fila.ToString).Value = "Prom/Dif"
        objHojaExcel.Range("BS" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BS" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("BS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CA" & Fila.ToString & ":CH" & Fila.ToString).Merge()
        objHojaExcel.Range("CA" & Fila.ToString).Value = "Res"
        objHojaExcel.Range("CA" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CA" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CI" & Fila.ToString & ":CP" & Fila.ToString).Merge()
        objHojaExcel.Range("CI" & Fila.ToString).Value = "Prom/Dif"
        objHojaExcel.Range("CI" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CI" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CQ" & Fila.ToString & ":CX" & Fila.ToString).Merge()
        objHojaExcel.Range("CQ" & Fila.ToString).Value = "Res"
        objHojaExcel.Range("CQ" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CQ" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CQ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CQ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CY" & Fila.ToString & ":DF" & Fila.ToString).Merge()
        objHojaExcel.Range("CY" & Fila.ToString).Value = "Prom/Dif"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        'Bordes
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":DF" & Fila.ToString).BorderAround()
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":BJ" & Fila.ToString).BorderAround()

        BORDES_DER(objHojaExcel, "H", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "K", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "AI", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "AL", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "BJ", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "BZ", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "CP", Fila_Ini, Fila)

        BORDES_DER(objHojaExcel, "S", Fila, Fila)
        BORDES_DER(objHojaExcel, "AA", Fila, Fila)
        BORDES_DER(objHojaExcel, "AT", Fila, Fila)
        BORDES_DER(objHojaExcel, "BB", Fila, Fila)
        BORDES_DER(objHojaExcel, "BR", Fila, Fila)
        BORDES_DER(objHojaExcel, "CH", Fila, Fila)
        BORDES_DER(objHojaExcel, "BX", Fila, Fila)

        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "L", "AI")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "AM", "BJ")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "BK", "DF")

        Fila_Exp = Fila
    End Sub

    Public Sub Imprime_Resultado_RetHumedad(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Elemento As DataRow
        Dim Fila_Ini As Integer = Fila
        Dim cont As String = 0
        Dim HumApro As Double
        Dim promedio, dato As Double
        For Each Fila_Elemento In Cjto_Tablas1.Tables("RET_HUMEDAD").Rows
            objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLAB")
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("I" & Fila.ToString & ":K" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("NUM_BANDEJA33")
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("L" & Fila.ToString & ":S" & Fila.ToString).Merge()
            objHojaExcel.Range("L" & Fila.ToString).Value = Fila_Elemento("TARA_BANDEJA33")
            objHojaExcel.Range("L" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("L" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("L" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("T" & Fila.ToString & ":AA" & Fila.ToString).Merge()
            objHojaExcel.Range("T" & Fila.ToString).Value = Fila_Elemento("MUE_HUM33")
            objHojaExcel.Range("T" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("T" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("T" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("T" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AB" & Fila.ToString & ":AI" & Fila.ToString).Merge()
            objHojaExcel.Range("AB" & Fila.ToString).Value = Fila_Elemento("MUE_SEC33")
            objHojaExcel.Range("AB" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AB" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("AB" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AB" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AJ" & Fila.ToString & ":AL" & Fila.ToString).Merge()
            objHojaExcel.Range("AJ" & Fila.ToString).Value = Fila_Elemento("NUM_BANDEJA15")
            objHojaExcel.Range("AJ" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AJ" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("AJ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AJ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AM" & Fila.ToString & ":AT" & Fila.ToString).Merge()
            objHojaExcel.Range("AM" & Fila.ToString).Value = Fila_Elemento("TARA_BANDEJA15")
            objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AU" & Fila.ToString & ":BB" & Fila.ToString).Merge()
            objHojaExcel.Range("AU" & Fila.ToString).Value = Fila_Elemento("MUE_HUM15")
            objHojaExcel.Range("AU" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AU" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("AU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BC" & Fila.ToString & ":BJ" & Fila.ToString).Merge()
            objHojaExcel.Range("BC" & Fila.ToString).Value = Fila_Elemento("MUE_SEC15")
            objHojaExcel.Range("BC" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BC" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("BC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BK" & Fila.ToString & ":BR" & Fila.ToString).Merge()
            objHojaExcel.Range("BK" & Fila.ToString).Value = Fila_Elemento("RESULTADO33")
            objHojaExcel.Range("BK" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BK" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("BK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BS" & Fila.ToString & ":BZ" & Fila.ToString).Merge()
            objHojaExcel.Range("BS" & Fila.ToString).Value = ""
            objHojaExcel.Range("BS" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BS" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("BS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CA" & Fila.ToString & ":CH" & Fila.ToString).Merge()
            objHojaExcel.Range("CA" & Fila.ToString).Value = Fila_Elemento("RESUlTADO15")
            objHojaExcel.Range("CA" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CA" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("CA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CI" & Fila.ToString & ":CP" & Fila.ToString).Merge()
            objHojaExcel.Range("CI" & Fila.ToString).Value = ""
            objHojaExcel.Range("CI" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CI" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("CI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            HumApro = CDbl(objHojaExcel.Range("BK" & Fila.ToString).Text) - CDbl(objHojaExcel.Range("CA" & Fila.ToString).Text)
            HumApro = Round(HumApro, 1)
            objHojaExcel.Range("CQ" & Fila.ToString & ":CX" & Fila.ToString).Merge()
            objHojaExcel.Range("CQ" & Fila.ToString).Value = HumApro
            objHojaExcel.Range("CQ" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CQ" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("CQ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CQ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CY" & Fila.ToString & ":DF" & Fila.ToString).Merge()
            objHojaExcel.Range("CY" & Fila.ToString).Value = ""
            objHojaExcel.Range("CY" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CY" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            cont = cont + 1

            If cont = 2 Then
                BORDES(objHojaExcel, Fila, Fila, "I", "DF")
            End If
            Fila = Fila + 1
            If Fila Mod 59 = 0 Then
                GoTo salto
            End If
        Next
salto:
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":DF" & Fila - 1.ToString).BorderAround()
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":BJ" & Fila - 1.ToString).BorderAround()

        BORDES_DER(objHojaExcel, "H", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "K", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "S", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AA", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AI", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AL", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AT", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BB", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BR", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BZ", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CH", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CP", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CX", Fila_Ini, Fila - 1)


        Fila_Exp = Fila

    End Sub

    Public Sub EncavezadoPagGranulometria(ByVal FechaDig As String, ByVal FechaAna As String, ByVal objHojaExcel As Excel.Worksheet)
        Dim Mat As String
        Dim Fila_E As Integer = 2
        Mat = "Suelo"

        ' Imprecion de Encavezado de la Planilla

        objHojaExcel.Range("AW" & Fila_E.ToString & ":BT" & Fila_E.ToString).Merge()
        objHojaExcel.Range("AW" & Fila_E.ToString).Value = "Registro Resultados"
        objHojaExcel.Range("AW" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AW" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("AW" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("AW" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AW" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BY" & Fila_E.ToString & ":CE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("BY" & Fila_E.ToString).Value = "Análisis"
        objHojaExcel.Range("BY" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BY" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("BY" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BY" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

        objHojaExcel.Range("CF" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("CF" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CF" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_E.ToString & ":DL" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_E.ToString).Value = Nombre
        objHojaExcel.Range("CG" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("CG" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("CG" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CG" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DM" & Fila_E.ToString & ":DS" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DM" & Fila_E.ToString).Value = "Matriz"
        objHojaExcel.Range("DM" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DM" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DM" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DM" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

        objHojaExcel.Range("DT" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("DT" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DT" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DT" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DT" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DU" & Fila_E.ToString & ":ES" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DU" & Fila_E.ToString).Value = Mat
        objHojaExcel.Range("DU" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DU" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("DU" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("DU" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DU" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("EX" & Fila_E.ToString & ":FA" & Fila_E.ToString).Merge()
        objHojaExcel.Range("EX" & Fila_E.ToString).Value = "pág."
        objHojaExcel.Range("EX" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("EX" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("EX" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("EX" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("FB" & Fila_E.ToString & ":FE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("FB" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("FB" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("FB" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("FB" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("FB" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        Fila_E = Fila_E + 2


        objHojaExcel.Range("A" & Fila_E.ToString & ":M" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Cód.documento"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("N" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("N" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("N" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("O" & Fila_E.ToString & ":BT" & Fila_E.ToString).Merge()
        objHojaExcel.Range("O" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("O" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("O" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("DE" & Fila_E.ToString & ":DN" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DE" & Fila_E.ToString).Value = "F.digitación"
        objHojaExcel.Range("DE" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DE" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DE" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DE" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DO" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("DO" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DO" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DO" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DO" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DP" & Fila_E.ToString & ":EA" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DP" & Fila_E.ToString).Value = FechaDig
        objHojaExcel.Range("DP" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DP" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DP" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DP" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("EL" & Fila_E.ToString & ":ES" & Fila_E.ToString).Merge()
        objHojaExcel.Range("EL" & Fila_E.ToString).Value = "F.análisis"
        objHojaExcel.Range("EL" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("EL" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("EL" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("EL" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("ET" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("ET" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("ET" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("ET" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("ET" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("EU" & Fila_E.ToString & ":FE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("EU" & Fila_E.ToString).Value = FechaAna
        objHojaExcel.Range("EU" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("EU" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("EU" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("EU" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":M" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Metodología"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("N" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("N" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("N" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("O" & Fila_E.ToString & ":CK" & Fila_E.ToString).Merge()
        objHojaExcel.Range("O" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("O" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("O" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    End Sub

    Public Sub Imprime_PiePagGranulometria(ByVal objHojaExcel As Excel.Worksheet, ByVal Analista As String, ByVal Digitador As String)

        Dim Fila_P As Integer = 42


        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Analista"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("I" & Fila_P.ToString).Value = Analista
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AX" & Fila_P.ToString & ":BB" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AX" & Fila_P.ToString).Value = "Digita"
        objHojaExcel.Range("AX" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AX" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AX" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AX" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("BC" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BC" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BC" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BD" & Fila_P.ToString & ":BZ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BD" & Fila_P.ToString).Value = Digitador
        objHojaExcel.Range("BD" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BD" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BD" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BD" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("DG" & Fila_P.ToString & ":DK" & Fila_P.ToString).Merge()
        objHojaExcel.Range("DG" & Fila_P.ToString).Value = "Revisa"
        objHojaExcel.Range("DG" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DG" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DG" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DG" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DL" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("DL" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DL" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DL" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DL" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DM" & Fila_P.ToString & ":ER" & Fila_P.ToString).Merge()
        objHojaExcel.Range("DM" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("DM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("I" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AX" & Fila_P.ToString & ":BB" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AX" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("AX" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AX" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AX" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AX" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("BC" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BC" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BC" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BD" & Fila_P.ToString & ":BZ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BD" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("BD" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BD" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BD" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BD" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("DG" & Fila_P.ToString & ":DK" & Fila_P.ToString).Merge()
        objHojaExcel.Range("DG" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("DG" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DG" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DG" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DG" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DL" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("DL" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DL" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DL" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DL" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DM" & Fila_P.ToString & ":ER" & Fila_P.ToString).Merge()
        objHojaExcel.Range("DM" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("DM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("I" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AX" & Fila_P.ToString & ":BB" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AX" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("AX" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AX" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AX" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AX" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("BC" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BC" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BC" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BD" & Fila_P.ToString & ":BZ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BD" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("BD" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BD" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BD" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BD" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("DG" & Fila_P.ToString & ":DK" & Fila_P.ToString).Merge()
        objHojaExcel.Range("DG" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("DG" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DG" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DG" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DG" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DL" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("DL" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DL" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DL" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DL" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DM" & Fila_P.ToString & ":ER" & Fila_P.ToString).Merge()
        objHojaExcel.Range("DM" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("DM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("DM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

    End Sub

    Public Sub Encavezado_Granulometria(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_E As Integer = 7
        'Dim Fila_D As Integer = 8
        'Dim Ini As Integer = 8
        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":BJ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Particulas en tamiz XXmm(%) = Maza en tamiz XXmm(g)/Total maza en tamices(g)"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter






        Fila_Exp = Fila_E



    End Sub

    Public Sub Encavezado_ResultadoGranulometria(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)

        Dim Fila_Ini As Integer = Fila
        objHojaExcel.Range("A" & Fila.ToString & ":K" & Fila + 1.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "N° Lab"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("L" & Fila.ToString & ":N" & Fila.ToString).Merge()
        objHojaExcel.Range("L" & Fila.ToString).Value = "N°"
        objHojaExcel.Range("L" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("L" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("L" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("O" & Fila.ToString & ":CB" & Fila.ToString).Merge()
        objHojaExcel.Range("O" & Fila.ToString).Value = "Maza en cada tamiz (g)"
        objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila.ToString).Font.Bold = 10
        objHojaExcel.Range("O" & Fila.ToString).Font.Size = 10
        objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CC" & Fila.ToString & ":EP" & Fila.ToString).Merge()
        objHojaExcel.Range("CC" & Fila.ToString).Value = "Porcentaje particulas en cada tamiz (%)"
        objHojaExcel.Range("CC" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CC" & Fila.ToString).Font.Size = 10
        objHojaExcel.Range("CC" & Fila.ToString).Font.Bold = 10
        objHojaExcel.Range("CC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("EQ" & Fila.ToString & ":FD" & Fila + 1.ToString).Merge()
        objHojaExcel.Range("EQ" & Fila.ToString).Value = "Obs"
        objHojaExcel.Range("EQ" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("EQ" & Fila.ToString).Font.Size = 10
        objHojaExcel.Range("EQ" & Fila.ToString).Font.Bold = 10
        objHojaExcel.Range("EQ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("EQ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("L" & Fila.ToString & ":N" & Fila.ToString).Merge()
        objHojaExcel.Range("L" & Fila.ToString).Value = "rep"
        objHojaExcel.Range("L" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("L" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("L" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
        objHojaExcel.Range("O" & Fila.ToString).Value = "16mm"
        objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila.ToString & ":Z" & Fila.ToString).Merge()
        objHojaExcel.Range("U" & Fila.ToString).Value = "8mm"
        objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).Merge()
        objHojaExcel.Range("AA" & Fila.ToString).Value = "4mm"
        objHojaExcel.Range("AA" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AA" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AG" & Fila.ToString & ":AL" & Fila.ToString).Merge()
        objHojaExcel.Range("AG" & Fila.ToString).Value = "2mm"
        objHojaExcel.Range("AG" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AG" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AM" & Fila.ToString & ":AR" & Fila.ToString).Merge()
        objHojaExcel.Range("AM" & Fila.ToString).Value = "1mm"
        objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AS" & Fila.ToString & ":AX" & Fila.ToString).Merge()
        objHojaExcel.Range("AS" & Fila.ToString).Value = "0,5mm"
        objHojaExcel.Range("AS" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AS" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AY" & Fila.ToString & ":BD" & Fila.ToString).Merge()
        objHojaExcel.Range("AY" & Fila.ToString).Value = "0,25mm"
        objHojaExcel.Range("AY" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AY" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BE" & Fila.ToString & ":BJ" & Fila.ToString).Merge()
        objHojaExcel.Range("BE" & Fila.ToString).Value = "0,10mm"
        objHojaExcel.Range("BE" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BE" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BK" & Fila.ToString & ":BP" & Fila.ToString).Merge()
        objHojaExcel.Range("BK" & Fila.ToString).Value = "0,05mm"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BQ" & Fila.ToString & ":BV" & Fila.ToString).Merge()
        objHojaExcel.Range("BQ" & Fila.ToString).Value = "Fondo"
        objHojaExcel.Range("BQ" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BQ" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BQ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BQ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BW" & Fila.ToString & ":CB" & Fila.ToString).Merge()
        objHojaExcel.Range("BW" & Fila.ToString).Value = "Total"
        objHojaExcel.Range("BW" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BW" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BW" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BW" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CC" & Fila.ToString & ":CH" & Fila.ToString).Merge()
        objHojaExcel.Range("CC" & Fila.ToString).Value = "16mm"
        objHojaExcel.Range("CC" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CC" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CI" & Fila.ToString & ":CN" & Fila.ToString).Merge()
        objHojaExcel.Range("CI" & Fila.ToString).Value = "8mm"
        objHojaExcel.Range("CI" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CI" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CO" & Fila.ToString & ":CT" & Fila.ToString).Merge()
        objHojaExcel.Range("CO" & Fila.ToString).Value = "4mm"
        objHojaExcel.Range("CO" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CO" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CO" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CO" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CU" & Fila.ToString & ":CZ" & Fila.ToString).Merge()
        objHojaExcel.Range("CU" & Fila.ToString).Value = "2mm"
        objHojaExcel.Range("CU" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CU" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DA" & Fila.ToString & ":DF" & Fila.ToString).Merge()
        objHojaExcel.Range("DA" & Fila.ToString).Value = "1mm"
        objHojaExcel.Range("DA" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DA" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("DA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DG" & Fila.ToString & ":DL" & Fila.ToString).Merge()
        objHojaExcel.Range("DG" & Fila.ToString).Value = "0,5mm"
        objHojaExcel.Range("DG" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DG" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("DG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DM" & Fila.ToString & ":DR" & Fila.ToString).Merge()
        objHojaExcel.Range("DM" & Fila.ToString).Value = "0,25mm"
        objHojaExcel.Range("DM" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DM" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("DM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DS" & Fila.ToString & ":DX" & Fila.ToString).Merge()
        objHojaExcel.Range("DS" & Fila.ToString).Value = "0,10mm"
        objHojaExcel.Range("DS" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DS" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("DS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DY" & Fila.ToString & ":ED" & Fila.ToString).Merge()
        objHojaExcel.Range("DY" & Fila.ToString).Value = "0,05mm"
        objHojaExcel.Range("DY" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DY" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("DY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("EE" & Fila.ToString & ":EJ" & Fila.ToString).Merge()
        objHojaExcel.Range("EE" & Fila.ToString).Value = "Fondo"
        objHojaExcel.Range("EE" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("EE" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("EE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("EE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("EK" & Fila.ToString & ":EP" & Fila.ToString).Merge()
        objHojaExcel.Range("EK" & Fila.ToString).Value = "Total"
        objHojaExcel.Range("EK" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("EK" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("EK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("EK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Bordes

        objHojaExcel.Range("A" & Fila_Ini.ToString & ":FD" & Fila_Ini + 1.ToString).BorderAround()
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":CB" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("O" & Fila_Ini.ToString & ":EP" & Fila_Ini).BorderAround()
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":K" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("L" & Fila_Ini.ToString & ":N" & Fila_Ini + 1).BorderAround()
        objHojaExcel.Range("CC" & Fila_Ini.ToString & ":EP" & Fila_Ini + 1).BorderAround()


        BORDES_DER(objHojaExcel, "T", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "Z", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "AF", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "AL", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "AR", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "AX", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BD", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BJ", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BP", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "BV", Fila_Ini + 1, Fila_Ini + 1)

        BORDES_DER(objHojaExcel, "CH", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "CN", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "CT", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "CZ", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "DF", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "DL", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "DR", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "DX", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "ED", Fila_Ini + 1, Fila_Ini + 1)
        BORDES_DER(objHojaExcel, "EJ", Fila_Ini + 1, Fila_Ini + 1)

        Fila_Exp = Fila

    End Sub

    Public Sub Imprime_Resultado_Granulometria(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Elemento As DataRow
        Dim Fila_Ini As Integer = Fila
        Dim cont As String = 0
        Dim HumApro As Double
        Dim promedio, dato As Double
        For Each Fila_Elemento In Cjto_Tablas1.Tables("GRANULOMETRIA").Rows
            objHojaExcel.Range("A" & Fila.ToString & ":K" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLAB")
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("L" & Fila.ToString & ":N" & Fila.ToString).Merge()
            objHojaExcel.Range("L" & Fila.ToString).Value = Fila_Elemento("INDICE")
            objHojaExcel.Range("L" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("L" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("L" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
            objHojaExcel.Range("O" & Fila.ToString).Value = Fila_Elemento("MAZA_16")
            objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("O" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("U" & Fila.ToString & ":Z" & Fila.ToString).Merge()
            objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("MAZA_8")
            objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("U" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).Merge()
            objHojaExcel.Range("AA" & Fila.ToString).Value = Fila_Elemento("MAZA_4")
            objHojaExcel.Range("AA" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AA" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("AA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AG" & Fila.ToString & ":AL" & Fila.ToString).Merge()
            objHojaExcel.Range("AG" & Fila.ToString).Value = Fila_Elemento("MAZA_2")
            objHojaExcel.Range("AG" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AG" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("AG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AM" & Fila.ToString & ":AR" & Fila.ToString).Merge()
            objHojaExcel.Range("AM" & Fila.ToString).Value = Fila_Elemento("MAZA_1")
            objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AS" & Fila.ToString & ":AX" & Fila.ToString).Merge()
            objHojaExcel.Range("AS" & Fila.ToString).Value = Fila_Elemento("MAZA_05")
            objHojaExcel.Range("AS" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AS" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("AS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AY" & Fila.ToString & ":BD" & Fila.ToString).Merge()
            objHojaExcel.Range("AY" & Fila.ToString).Value = Fila_Elemento("MAZA_025")
            objHojaExcel.Range("AY" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AY" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("AY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BE" & Fila.ToString & ":BJ" & Fila.ToString).Merge()
            objHojaExcel.Range("BE" & Fila.ToString).Value = Fila_Elemento("MAZA_01")
            objHojaExcel.Range("BE" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BE" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("BE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BK" & Fila.ToString & ":BP" & Fila.ToString).Merge()
            objHojaExcel.Range("BK" & Fila.ToString).Value = Fila_Elemento("MAZA_005")
            objHojaExcel.Range("BK" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BK" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("BK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BQ" & Fila.ToString & ":BV" & Fila.ToString).Merge()
            objHojaExcel.Range("BQ" & Fila.ToString).Value = Fila_Elemento("MAZA_FONDO")
            objHojaExcel.Range("BQ" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BQ" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("BQ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BQ" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BW" & Fila.ToString & ":CB" & Fila.ToString).Merge()
            objHojaExcel.Range("BW" & Fila.ToString).Value = Fila_Elemento("MAZA_TOTAL")
            objHojaExcel.Range("BW" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BW" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("BW" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BW" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CC" & Fila.ToString & ":CH" & Fila.ToString).Merge()
            objHojaExcel.Range("CC" & Fila.ToString).Value = Fila_Elemento("PORC_16")
            objHojaExcel.Range("CC" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CC" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("CC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CI" & Fila.ToString & ":CN" & Fila.ToString).Merge()
            objHojaExcel.Range("CI" & Fila.ToString).Value = Fila_Elemento("PORC_8")
            objHojaExcel.Range("CI" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CI" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("CI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CO" & Fila.ToString & ":CT" & Fila.ToString).Merge()
            objHojaExcel.Range("CO" & Fila.ToString).Value = Fila_Elemento("PORC_4")
            objHojaExcel.Range("CO" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CO" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("CO" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CO" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CU" & Fila.ToString & ":CZ" & Fila.ToString).Merge()
            objHojaExcel.Range("CU" & Fila.ToString).Value = Fila_Elemento("PORC_2")
            objHojaExcel.Range("CU" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CU" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("CU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("DA" & Fila.ToString & ":DF" & Fila.ToString).Merge()
            objHojaExcel.Range("DA" & Fila.ToString).Value = Fila_Elemento("PORC_1")
            objHojaExcel.Range("DA" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("DA" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("DA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("DA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("DG" & Fila.ToString & ":DL" & Fila.ToString).Merge()
            objHojaExcel.Range("DG" & Fila.ToString).Value = Fila_Elemento("PORC_05")
            objHojaExcel.Range("DG" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("DG" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("DG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("DG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("DM" & Fila.ToString & ":DR" & Fila.ToString).Merge()
            objHojaExcel.Range("DM" & Fila.ToString).Value = Fila_Elemento("PORC_025")
            objHojaExcel.Range("DM" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("DM" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("DM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("DM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("DS" & Fila.ToString & ":DX" & Fila.ToString).Merge()
            objHojaExcel.Range("DS" & Fila.ToString).Value = Fila_Elemento("PORC_01")
            objHojaExcel.Range("DS" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("DS" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("DS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("DS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("DY" & Fila.ToString & ":ED" & Fila.ToString).Merge()
            objHojaExcel.Range("DY" & Fila.ToString).Value = Fila_Elemento("PORC_005")
            objHojaExcel.Range("DY" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("DY" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("DY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("DY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("EE" & Fila.ToString & ":EJ" & Fila.ToString).Merge()
            objHojaExcel.Range("EE" & Fila.ToString).Value = Fila_Elemento("PORC_FONDO")
            objHojaExcel.Range("EE" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("EE" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("EE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("EE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("EK" & Fila.ToString & ":EP" & Fila.ToString).Merge()
            objHojaExcel.Range("EK" & Fila.ToString).Value = Fila_Elemento("PORC_TOTAL")
            objHojaExcel.Range("EK" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("EK" & Fila.ToString).Font.Size = 8
            objHojaExcel.Range("EK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("EK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            cont = cont + 1

            If cont Mod 2 = 0 Then
                BORDES(objHojaExcel, Fila, Fila, "A", "FD")
            End If
            Fila = Fila + 1
            'If Fila Mod 59 = 0 Then
            '    GoTo salto
            'End If
        Next
salto:
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":EP" & Fila - 1.ToString).BorderAround()
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":CB" & Fila - 1.ToString).BorderAround()
        objHojaExcel.Range("CB" & Fila_Ini.ToString & ":EP" & Fila - 1.ToString).BorderAround()
        objHojaExcel.Range("EP" & Fila_Ini.ToString & ":FD" & Fila - 1.ToString).BorderAround()

        BORDES_DER(objHojaExcel, "K", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "N", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "T", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "Z", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AF", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AL", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AR", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AX", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BD", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BJ", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BP", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BV", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CH", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CN", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CT", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CZ", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "DF", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "DL", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "DR", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "DX", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "ED", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "EJ", Fila_Ini, Fila - 1)


        Fila_Exp = Fila

    End Sub

    Public Sub Encavezado_DapCilindrico(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_E As Integer = 7
        Dim Fila_D As Integer = 8
        Dim Ini As Integer = 8
        objHojaExcel.Range("A" & Fila_E.ToString & ":H" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila_E.ToString & ":DJ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_E.ToString).Value = "Datos calcúlo(Ejemplo)"
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_E.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_E, Fila_E, "CJ", "DJ")

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":BA" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Volumen cilindro(cc) = 3,14 * (r)^2 * H"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":BA" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Dap Cilindro(g/cc)= Maza muestra seca (g)/Volumen cilindro(cc)"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Dato del Calculo'''''

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Radio cilindro"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(cm)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "8,5"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Altura cilindro"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(cm)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "12,6"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Tara bandeja"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "2,5"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa muestra seca"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "125,3"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        BORDES(objHojaExcel, Fila_D, Fila_D, "CJ", "DJ")



        BORDES_DER(objHojaExcel, "CI", Ini, Fila_D)
        BORDES_DER(objHojaExcel, "DJ", Ini, Fila_D)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Fila_Exp = Fila_E



    End Sub

    Public Sub Encavezado_ResultadoDapCilindro(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Ini As Integer = Fila

        objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila + 1.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "N°Lab"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila.ToString & ":J" & Fila.ToString).Merge()
        objHojaExcel.Range("I" & Fila.ToString).Value = "N°"
        objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("K" & Fila.ToString & ":AB" & Fila.ToString).Merge()
        objHojaExcel.Range("K" & Fila.ToString).Value = "Cilindro"
        objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("K" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AC" & Fila.ToString & ":AN" & Fila.ToString).Merge()
        objHojaExcel.Range("AC" & Fila.ToString).Value = "Muestra(g)"
        objHojaExcel.Range("AC" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AC" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AO" & Fila.ToString & ":AZ" & Fila.ToString).Merge()
        objHojaExcel.Range("AO" & Fila.ToString).Value = "Dap(g/cc)"
        objHojaExcel.Range("AO" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AO" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AO" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AO" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("I" & Fila.ToString & ":J" & Fila.ToString).Merge()
        objHojaExcel.Range("I" & Fila.ToString).Value = "Cil"
        objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("K" & Fila.ToString & ":P" & Fila.ToString).Merge()
        objHojaExcel.Range("K" & Fila.ToString).Value = "Radio"
        objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("K" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Q" & Fila.ToString & ":V" & Fila.ToString).Merge()
        objHojaExcel.Range("Q" & Fila.ToString).Value = "Altura"
        objHojaExcel.Range("Q" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Q" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("Q" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("Q" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & Fila.ToString & ":AB" & Fila.ToString).Merge()
        objHojaExcel.Range("W" & Fila.ToString).Value = "Volumen"
        objHojaExcel.Range("W" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("W" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("W" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("W" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AC" & Fila.ToString & ":AH" & Fila.ToString).Merge()
        objHojaExcel.Range("AC" & Fila.ToString).Value = "Tara b"
        objHojaExcel.Range("AC" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AC" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AI" & Fila.ToString & ":AN" & Fila.ToString).Merge()
        objHojaExcel.Range("AI" & Fila.ToString).Value = "Seca"
        objHojaExcel.Range("AI" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AO" & Fila.ToString & ":AT" & Fila.ToString).Merge()
        objHojaExcel.Range("AO" & Fila.ToString).Value = "Cilindro"
        objHojaExcel.Range("AO" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AO" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AO" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AO" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AU" & Fila.ToString & ":AZ" & Fila.ToString).Merge()
        objHojaExcel.Range("AU" & Fila.ToString).Value = "prom"
        objHojaExcel.Range("AU" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AU" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("AU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("A" & Fila_Ini.ToString & ":AZ" & Fila.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "H", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "J", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "AB", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "AN", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "P", Fila, Fila)
        BORDES_DER(objHojaExcel, "V", Fila, Fila)
        BORDES_DER(objHojaExcel, "AH", Fila, Fila)
        BORDES_DER(objHojaExcel, "AT", Fila, Fila)

        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "K", "AZ")

        Fila_Exp = Fila
    End Sub

    Public Sub Encavezado_ResultadoDapCilindro2(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Ini As Integer = Fila

        objHojaExcel.Range("BK" & Fila.ToString & ":BR" & Fila + 1.ToString).Merge()
        objHojaExcel.Range("BK" & Fila.ToString).Value = "N°Lab"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BK" & Fila.ToString).Font.Size = 9
        objHojaExcel.Range("BK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BS" & Fila.ToString & ":BT" & Fila.ToString).Merge()
        objHojaExcel.Range("BS" & Fila.ToString).Value = "N°"
        objHojaExcel.Range("BS" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BS" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BU" & Fila.ToString & ":CL" & Fila.ToString).Merge()
        objHojaExcel.Range("BU" & Fila.ToString).Value = "Cilindro"
        objHojaExcel.Range("BU" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BU" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CM" & Fila.ToString & ":CX" & Fila.ToString).Merge()
        objHojaExcel.Range("CM" & Fila.ToString).Value = "Muestra(g)"
        objHojaExcel.Range("CM" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CY" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        objHojaExcel.Range("CY" & Fila.ToString).Value = "Dap(g/cc)"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila = Fila + 1

        objHojaExcel.Range("BS" & Fila.ToString & ":BT" & Fila.ToString).Merge()
        objHojaExcel.Range("BS" & Fila.ToString).Value = "Cil"
        objHojaExcel.Range("BS" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BS" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("BS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BU" & Fila.ToString & ":BZ" & Fila.ToString).Merge()
        objHojaExcel.Range("BU" & Fila.ToString).Value = "Radio"
        objHojaExcel.Range("BU" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BU" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("BU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CA" & Fila.ToString & ":CF" & Fila.ToString).Merge()
        objHojaExcel.Range("CA" & Fila.ToString).Value = "Altura"
        objHojaExcel.Range("CA" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CA" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila.ToString & ":CL" & Fila.ToString).Merge()
        objHojaExcel.Range("CG" & Fila.ToString).Value = "Volumen"
        objHojaExcel.Range("CG" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CM" & Fila.ToString & ":CR" & Fila.ToString).Merge()
        objHojaExcel.Range("CM" & Fila.ToString).Value = "Tara b"
        objHojaExcel.Range("CM" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CS" & Fila.ToString & ":CX" & Fila.ToString).Merge()
        objHojaExcel.Range("CS" & Fila.ToString).Value = "Seca"
        objHojaExcel.Range("CS" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CS" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CY" & Fila.ToString & ":DD" & Fila.ToString).Merge()
        objHojaExcel.Range("CY" & Fila.ToString).Value = "Cilindro"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CY" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DE" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
        objHojaExcel.Range("DE" & Fila.ToString).Value = "prom"
        objHojaExcel.Range("DE" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DE" & Fila.ToString).Font.Size = 6
        objHojaExcel.Range("DE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BK" & Fila_Ini.ToString & ":DJ" & Fila.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "BR", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "BT", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "CL", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "CX", Fila_Ini, Fila)
        BORDES_DER(objHojaExcel, "BZ", Fila, Fila)
        BORDES_DER(objHojaExcel, "CF", Fila, Fila)
        BORDES_DER(objHojaExcel, "CR", Fila, Fila)
        BORDES_DER(objHojaExcel, "DD", Fila, Fila)

        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "BU", "DJ")

        Fila_Exp = Fila
    End Sub

    Public Sub Imprime_ResultadoDapCilindrica(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Elemento As DataRow
        Dim Fila_Ini As Integer = Fila
        Dim cont As String = 0
        Dim cont2 As Integer = 0
        Dim promedio, dato As Double
        For Each Fila_Elemento In Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").Rows

            objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLAB")
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("I" & Fila.ToString & ":J" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("LINEA")
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = 7
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("K" & Fila.ToString & ":P" & Fila.ToString).Merge()
            objHojaExcel.Range("K" & Fila.ToString).Value = Fila_Elemento("RADIO")
            objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("K" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("Q" & Fila.ToString & ":V" & Fila.ToString).Merge()
            objHojaExcel.Range("Q" & Fila.ToString).Value = Fila_Elemento("ALTURA")
            objHojaExcel.Range("Q" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("Q" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("Q" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("Q" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("W" & Fila.ToString & ":AB" & Fila.ToString).Merge()
            objHojaExcel.Range("W" & Fila.ToString).Value = Fila_Elemento("VOLUMEN")
            objHojaExcel.Range("W" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("W" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("W" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("W" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AC" & Fila.ToString & ":AH" & Fila.ToString).Merge()
            objHojaExcel.Range("AC" & Fila.ToString).Value = "2,5"
            objHojaExcel.Range("AC" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AC" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("AC" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AC" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AI" & Fila.ToString & ":AN" & Fila.ToString).Merge()
            objHojaExcel.Range("AI" & Fila.ToString).Value = Fila_Elemento("PESO_SECO")
            objHojaExcel.Range("AI" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AI" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("AI" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AI" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AO" & Fila.ToString & ":AT" & Fila.ToString).Merge()
            objHojaExcel.Range("AO" & Fila.ToString).Value = Fila_Elemento("DENSIDAD")
            objHojaExcel.Range("AO" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AO" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("AO" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AO" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("AU" & Fila.ToString & ":AZ" & Fila.ToString).Merge()
            objHojaExcel.Range("AU" & Fila.ToString).Value = ""
            objHojaExcel.Range("AU" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("AU" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("AU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("AU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            BORDES(objHojaExcel, Fila, Fila, "I", "AZ")

            cont = cont + 1

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If cont Mod 3 = 0 Then
                BORDES_OSC(objHojaExcel, Fila, Fila, "A", "AZ")
            End If


            Fila = Fila + 1

        Next
        BORDES_DER(objHojaExcel, "H", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "J", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "P", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "V", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AB", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AH", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AN", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "AT", Fila_Ini, Fila - 1)
        objHojaExcel.Range("A" & Fila_Ini.ToString & ":AZ" & Fila - 1.ToString).BorderAround()
    End Sub

    Public Sub Imprime_ResultadoDapCilindrica2(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Elemento As DataRow
        Dim Fila_Ini As Integer = Fila
        Dim cont As String = 0
        Dim cont2 As Integer = 0
        Dim promedio, dato As Double
        For Each Fila_Elemento In Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").Rows

            objHojaExcel.Range("BK" & Fila.ToString & ":BR" & Fila.ToString).Merge()
            objHojaExcel.Range("BK" & Fila.ToString).Value = Fila_Elemento("OT_NLAB")
            objHojaExcel.Range("BK" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BK" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("BK" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BK" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BS" & Fila.ToString & ":BT" & Fila.ToString).Merge()
            objHojaExcel.Range("BS" & Fila.ToString).Value = Fila_Elemento("LINEA")
            objHojaExcel.Range("BS" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BS" & Fila.ToString).Font.Size = 7
            objHojaExcel.Range("BS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("BU" & Fila.ToString & ":BZ" & Fila.ToString).Merge()
            objHojaExcel.Range("BU" & Fila.ToString).Value = Fila_Elemento("RADIO")
            objHojaExcel.Range("BU" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("BU" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("BU" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("BU" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CA" & Fila.ToString & ":CF" & Fila.ToString).Merge()
            objHojaExcel.Range("CA" & Fila.ToString).Value = Fila_Elemento("ALTURA")
            objHojaExcel.Range("CA" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CA" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("CA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CG" & Fila.ToString & ":CL" & Fila.ToString).Merge()
            objHojaExcel.Range("CG" & Fila.ToString).Value = Fila_Elemento("VOLUMEN")
            objHojaExcel.Range("CG" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CG" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("CG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CM" & Fila.ToString & ":CR" & Fila.ToString).Merge()
            objHojaExcel.Range("CM" & Fila.ToString).Value = "2,5"
            objHojaExcel.Range("CM" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CM" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("CM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CS" & Fila.ToString & ":CX" & Fila.ToString).Merge()
            objHojaExcel.Range("CS" & Fila.ToString).Value = Fila_Elemento("PESO_SECO")
            objHojaExcel.Range("CS" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CS" & Fila.ToString).Font.Size = 6
            objHojaExcel.Range("CS" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CS" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("CY" & Fila.ToString & ":DD" & Fila.ToString).Merge()
            objHojaExcel.Range("CY" & Fila.ToString).Value = Fila_Elemento("DENSIDAD")
            objHojaExcel.Range("CY" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("CY" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("CY" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("DE" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
            objHojaExcel.Range("DE" & Fila.ToString).Value = ""
            objHojaExcel.Range("DE" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("DE" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("DE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("DE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            BORDES(objHojaExcel, Fila, Fila, "BS", "DJ")

            cont = cont + 1

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If cont Mod 3 = 0 Then
                BORDES_OSC(objHojaExcel, Fila, Fila, "BK", "DJ")
            End If


            Fila = Fila + 1

        Next
        BORDES_DER(objHojaExcel, "BR", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BT", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "BZ", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CF", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CL", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CR", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "CX", Fila_Ini, Fila - 1)
        BORDES_DER(objHojaExcel, "DD", Fila_Ini, Fila - 1)
        objHojaExcel.Range("BK" & Fila_Ini.ToString & ":DJ" & Fila - 1.ToString).BorderAround()
    End Sub
End Module
