Imports System.Math
Imports System.Data.SqlClient
Imports System.Windows.Forms
Module Formulas
    Public Function Gasto_Blanco_Factor(ByVal lectura As Double, ByVal blanco As Double, ByVal factor As Double) As Double
        Dim resultado As Double
        resultado = (lectura - blanco) * factor
        Return resultado
    End Function
    Public Function Gasto_Blanco_NNH4(ByVal lectura As Double, ByVal blanco As Double, ByVal factor As Double) As Double
        Dim resultado As Double
        resultado = (lectura - blanco) * factor
        Return resultado
    End Function
    Public Function Lectura_Blanco(ByVal Lectura As Double, ByVal Blanco As Double, ByVal Factor As Double)
        Dim resultado As Double
        resultado = (Lectura - Blanco) * Factor
        Return resultado
    End Function
    Public Function Cesmec(ByVal Factor As Double, ByVal Res As Double)
        Dim resultado As Double
        resultado = Factor * Res
        Return resultado
    End Function
    Public Function Potenciometria(ByVal Factor As Double, ByVal Lectura As Double, ByVal Blanco As Double)
        Dim resultado As Double
        resultado = (Lectura - Blanco) * Factor
        Return resultado
    End Function

    Public Function Regresion(ByVal BsumalogXY As Double, ByVal BsumaLogX As Double, ByVal BsumaLogX2 As Double, ByVal BsumaY As Double, ByVal BsumaY2 As Double, ByVal n As Integer, ByVal lectura As Double, ByVal factor As Double) As Double
        Dim ResY, ResB, ResA, ARRIBA, A1, A2, B1, B2, B3, B4, BAJO1 As Double

        A1 = n * BsumalogXY
        A2 = BsumaY * BsumaLogX
        ARRIBA = A1 - A2

        B1 = n * BsumaLogX2
        B2 = Pow(BsumaLogX, 2)
        BAJO1 = B1 - B2

        ResB = ARRIBA / BAJO1
        ResA = (BsumaY - (ResB * BsumaLogX)) / n


        ResY = ResA + (ResB * (Log10(lectura)))
        ResY = ResY * factor
        Return ResY

    End Function
    Public Function RegresionNNO3(ByVal BsumalogYX As Double, ByVal BsumaLogY As Double, ByVal BsumaLogY2 As Double, ByVal BsumaX As Double, ByVal BsumaX2 As Double, ByVal n As Integer, ByVal lectura As Double, ByVal factor As Double) As Double
        Dim AntiLog, LogY, ResY, ResB, ResA, ARRIBA, A1, A2, B1, B2, B3, B4, BAJO1 As Double

        A1 = n * BsumalogYX
        A2 = BsumaX * BsumaLogY
        ARRIBA = A1 - A2

        B1 = n * BsumaX2
        B2 = Pow(BsumaX, 2)
        BAJO1 = B1 - B2

        ResB = ARRIBA / BAJO1

        ResA = (BsumaLogY - (ResB * BsumaX)) / n
        LogY = ResA + ResB * lectura

        AntiLog = Pow(10, LogY)


        ResY = (AntiLog * factor) / 4.43
        Return ResY
    End Function
    Public Function Mascara_Formato(ByVal resultado As Double, ByVal EntRes As Integer, ByVal TMascara As Integer) As String
        Dim con As New SqlConnection(Conexion1)
        Dim Candec, gatos As String
        Dim query As String
        Candec = "000000" : gatos = "####"
        con.Open()
        query = "Select NUMERO_RANGO,RANGO_DESDE,RANGO_HASTA,DECIMALES FROM TIPO_MASCARA WHERE TMASCARA=" & CInt(TMascara)
        Dim myCommand2 As New SqlCommand(query, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand2.ExecuteReader()
        While myReader2.Read()
            If resultado >= myReader2.GetInt32(1) And resultado <= myReader2.GetInt32(2) Then
                Mascara_Formato = Mid(gatos, 1, EntRes) & "." & Mid(Candec, 1, myReader2.GetInt32(3))
            End If
        End While
        myReader2.Close()
        con.Close()
        Return Mascara_Formato
    End Function
    Public Function Densidad(ByVal S As Double, ByVal H As Double, ByVal HE As Double, ByVal HEa As Double)
        Dim DA As Double
        DA = S / ((HE - 1.3) - (HEa - 1.2) - ((HE - 1.3) - (H - 1.3)) / (0.875))
        Return DA
    End Function
    Public Function RetHumedad(ByVal H As Double, ByVal S As Double, ByVal TB As Double)
        Dim RHum As Double
        RHum = ((H - TB) - (S - TB)) / (S - TB)
        RHum = RHum * 100
        Return RHum
    End Function

    Public Sub Granulometria(ByVal Masa16 As Double, ByVal Masa8 As Double, ByVal Masa4 As Double, ByVal Masa2 As Double, ByVal Masa1 As Double, ByVal Masa05 As Double, ByVal Masa025 As Double, ByVal Masa01 As Double, ByVal Masa005 As Double, ByVal MasaFondo As Double, ByRef TotalMasa As Double, ByRef Porc16 As Double, ByRef Porc8 As Double, ByRef Porc4 As Double, ByRef Porc2 As Double, ByRef Porc1 As Double, ByRef Porc05 As Double, ByRef Porc025 As Double, ByRef Porc01 As Double, ByRef Porc005 As Double, ByRef PorcFondo As Double, ByRef PorcTotal As Double)
        If MasaFondo = 0 Then GoTo salto
        TotalMasa = (Masa16 + Masa8 + Masa4 + Masa2 + Masa1 + Masa05 + Masa025 + Masa01 + Masa005 + MasaFondo)
        Porc16 = (100 * Masa16) / TotalMasa
        Porc8 = (100 * Masa8) / TotalMasa
        Porc4 = (100 * Masa4) / TotalMasa
        Porc2 = (100 * Masa2) / TotalMasa
        Porc1 = (100 * Masa1) / TotalMasa
        Porc05 = (100 * Masa05) / TotalMasa
        Porc025 = (100 * Masa025) / TotalMasa
        Porc01 = (100 * Masa01) / TotalMasa
        Porc005 = (100 * Masa005) / TotalMasa
        PorcFondo = (100 * MasaFondo) / TotalMasa
        PorcTotal = (Porc16 + Porc8 + Porc4 + Porc2 + Porc1 + Porc05 + Porc025 + Porc01 + Porc005 + PorcFondo)
salto:
    End Sub

    Public Function Dap_Cilindrica(ByVal Masa As Double, ByVal Volumen As Double, ByVal T_Bandeja As Double)
        Dim Dap As Double
        Dap = (Masa - T_Bandeja) / Volumen
        Return Dap
    End Function

    Public Function Convierte_Resultado_Elemento(ByVal Result As Double, ByVal Elecodi As String) As Double
        If Elecodi = "Ca sal" Then
            Result = Result * 20
        End If
        If Elecodi = "Mg sal" Then
            Result = Result * 12.15
        End If
        If Elecodi = "Na sal" Then
            Result = Result * 23
        End If
        If Elecodi = "K sal" Then
            Result = Result * 39.1
        End If
        If Elecodi = "Cl sal" Then
            Result = Result * 35.45
        End If
        If Elecodi = "SO4 sal" Then
            Result = Result * 48
        End If
        If Elecodi = "HCO3 sal" Then
            Result = Result * 61
        End If
        Return Result
    End Function
End Module
