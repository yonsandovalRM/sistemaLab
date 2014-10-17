Imports System.Data.SqlClient
Imports System.Math
Module Funciones
    Public Function ValidaRut(ByVal Rut As String) As Boolean
        Dim cadena, temp, final, DV As String
        Dim i, suma As Integer
        suma = 0
        cadena = Rut
        final = ""
        cadena = Trim(cadena)
        DV = LCase(Microsoft.VisualBasic.Right(cadena, 1))
        If InStr(cadena, ".") > 0 Then ValidaRut = False : GoTo rutmalo
        If InStr(cadena, "-") > 0 Then
            While cadena <> ""
                temp = Microsoft.VisualBasic.Right(cadena, 1)
                cadena = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
                If temp = "-" Then
                    While cadena <> ""
                        For i = 2 To 7
                            final = Microsoft.VisualBasic.Right(cadena, 1)
                            If final <> "" Then
                                suma = suma + CInt(final) * i
                            End If
                            temp = Microsoft.VisualBasic.Right(cadena, 1)
                            If Len(cadena) - 1 >= 0 Then
                                cadena = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
                            End If
                        Next
                    End While
                End If
            End While
        Else
            'MsgBox("El rut ingresado no es v·lido, debe ser ingresado sin puntos y con guion", , "LabSys")
        End If
        suma = 11 - (suma Mod 11)
        If suma = 10 Then
            final = "k"
        ElseIf suma = 11 Then
            final = "0"
        Else
            final = suma
        End If
        If final <> DV Then
            ValidaRut = False
        Else
            ValidaRut = True
        End If
RutMalo:
    End Function

    Public Function Busca_Mascara(ByVal FonoI As String, ByRef MascaraO As String)
        Dim largo As Integer
        largo = Len(FonoI)
        If Mid(FonoI, 2, 2) = "2)" Then
            Select Case largo
                Case 10
                    MascaraO = "(#)#######"
                Case 12
                    MascaraO = "(#)#######-#"
                Case 13
                    MascaraO = "(#)#######-##"
                Case 14
                    MascaraO = "(#)#######-###"
                Case 15
                    MascaraO = "(#)#######-####"
            End Select
        Else
            Select Case largo
                Case 10
                    MascaraO = "(##)######"
                Case 11
                    MascaraO = "(##)#######"
                Case 13
                    MascaraO = "(##)#######-#"
                Case 14
                    MascaraO = "(##)#######-##"
                Case 15
                    MascaraO = "(##)#######-###"
                Case 16
                    MascaraO = "(##)#######-####"
            End Select
        End If
    End Function

    Public Function AgregaPtos(ByVal Rut As String) As String
        Dim cadena, temp, final As String
        Dim i As Integer
        cadena = Rut
        final = ""
        cadena = Trim(cadena)
        While cadena <> ""
            final = Microsoft.VisualBasic.Right(cadena, 1) & final
            temp = Microsoft.VisualBasic.Right(cadena, 1)
            cadena = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
            If temp = "-" Then
                While cadena <> ""
                    For i = 1 To 3
                        final = Microsoft.VisualBasic.Right(cadena, 1) & final
                        temp = Microsoft.VisualBasic.Right(cadena, 1)
                        If Len(cadena) - 1 >= 0 Then
                            cadena = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
                        End If
                    Next
                    If temp <> "" Then
                        final = "." & final
                    End If
                End While
            End If
        End While
        AgregaPtos = final
    End Function

    Public Function QuitaPtos(ByVal rut As String) As String
        Dim cadena, temp, final As String
        Dim i As Integer
        cadena = rut
        final = ""
        cadena = Trim(cadena)
        While cadena <> ""
            final = Microsoft.VisualBasic.Right(cadena, 1) & final
            temp = Microsoft.VisualBasic.Right(cadena, 1)
            cadena = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
            If temp = "-" Then
                While cadena <> ""
                    For i = 1 To 3
                        final = Microsoft.VisualBasic.Right(cadena, 1) & final
                        temp = Microsoft.VisualBasic.Right(cadena, 1)
                        If Len(cadena) - 1 >= 0 Then
                            cadena = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
                        End If
                    Next
                    If Len(cadena) - 1 >= 0 Then
                        cadena = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
                    End If
                End While
            End If
        End While
        QuitaPtos = final
    End Function

    Function NumeroGuionyK(ByVal Keyascii As Short) As Short
        If InStr("-1234567890QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm—Ò,", Chr(Keyascii)) = 0 Then
            NumeroGuionyK = 0
        Else
            NumeroGuionyK = Keyascii
        End If
        Select Case Keyascii
            Case 8
                NumeroGuionyK = Keyascii
            Case 13
                NumeroGuionyK = Keyascii
        End Select
    End Function

    Public Function Quita_Guion(ByVal Guion As String) As String
        Dim cadena, final As String
        Dim i, cont As Integer
        cadena = Guion
        final = ""
        cadena = Trim(cadena)
        cont = Len(cadena)
        If Microsoft.VisualBasic.Right(cadena, 1) = "-" Then
            final = Microsoft.VisualBasic.Left(cadena, Len(cadena) - 1)
        End If
        Quita_Guion = final
    End Function

    Function SoloLetra(ByVal Keyascii As Short) As Short
        If InStr(" QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm—Ò", Chr(Keyascii)) = 0 Then
            SoloLetra = 0
        Else
            SoloLetra = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloLetra = Keyascii
            Case 13
                SoloLetra = Keyascii
        End Select
    End Function

    Function SoloEdad(ByVal Keyascii As Short) As Short
        If InStr(" 1234567890QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm—Ò,", Chr(Keyascii)) = 0 Then
            SoloEdad = 0
        Else
            SoloEdad = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloEdad = Keyascii
            Case 13
                SoloEdad = Keyascii
        End Select
    End Function

    Function SoloNombre(ByVal Keyascii As Short) As Short
        If InStr(" 1234567890QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm—Ò∞-#.™", Chr(Keyascii)) = 0 Then
            SoloNombre = 0
        Else
            SoloNombre = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNombre = Keyascii
            Case 13
                SoloNombre = Keyascii
        End Select
    End Function

    Function Solovacio(ByVal Keyascii As Short) As Short
        If InStr("X", Chr(Keyascii)) = 0 Then
            Solovacio = 0
        Else
            Solovacio = Keyascii
        End If
        Select Case Keyascii
            Case 8
                Solovacio = Keyascii
            Case 13
                Solovacio = Keyascii
        End Select
    End Function

    Function SoloMail(ByVal Keyascii As Short) As Short
        If InStr("1234567890QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm@_.", Chr(Keyascii)) = 0 Then
            SoloMail = 0
        Else
            SoloMail = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloMail = Keyascii
            Case 13
                SoloMail = Keyascii
        End Select
    End Function

    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Public Sub control_nombre(ByRef nomb As String)
        Dim lar, i, j As Integer
        Dim acumula As String
        lar = Len(nomb)
        acumula = "" : j = 0
        For i = 1 To lar
            If Mid(nomb, i, 4) = "S.A." Then acumula = acumula & "S.A." : Exit For
            If i = 1 Then acumula = UCase(Mid(nomb, 1, 1)) : GoTo continuar
            If j = 1 Then acumula = acumula & UCase(Mid(nomb, i, 1)) : j = 0 : GoTo continuar
            If Mid(nomb, i, 1) = " " Then acumula = acumula & " " : j = 1 : GoTo continuar
            If Mid(nomb, i, 1) = "." Then acumula = acumula & "." : j = 1 : GoTo continuar
            acumula = acumula & LCase(Mid(nomb, i, 1))
continuar:
        Next
        nomb = acumula
    End Sub

    Public Sub Refresca_Tablas()
        Dim fila As DataRow
        Dim query As String
        Cjto_Tablas1.Tables("ESPECIE").Clear()
        Cjto_Tablas1.Tables("TEJIDO").Clear()
        Cjto_Tablas1.Tables("MUESTRA").Clear()
        Cjto_Tablas1.Tables("CULTIVO").Clear()
        Cjto_Tablas1.Tables("CULTIVO1").Clear()
        Cjto_Tablas1.Tables("TIPO_FERTILIZANTE").Clear()
        Cjto_Tablas1.Tables("ANALISIS").Clear()
        Cjto_Tablas1.Tables("COMBO_ANALISIS").Clear()
        Cjto_Tablas1.Tables("SUBMUESTRA").Clear()
        Cjto_Tablas1.Tables("PRODUCTOR_AUTOCOMPLETA").Clear()
        Cjto_Tablas1.Tables("PRODUCTOR_EMPRESA").Clear()
        Cjto_Tablas1.Tables("COMUNASFACT").Clear()
        Cjto_Tablas1.Tables("COMUNASDESP").Clear()
        Cjto_Tablas1.Tables("LOCALIDAD").Clear()
        Cjto_Tablas1.Tables("COMUNA").Clear()
        Cjto_Tablas1.Tables("CIUDAD").Clear()
        Cjto_Tablas1.Tables("PROVINCIA").Clear()
        Cjto_Tablas1.Tables("REGION").Clear()
        Cjto_Tablas1.Tables("ELEMENTO").Clear()
        Cjto_Tablas1.Tables("CONDICION_PAGO").Clear()
        Cjto_Tablas1.Tables("HOMOLOGA_ELEMENTO").Clear()
        Cjto_Tablas1.Tables("FORMATO_PLADIG").Clear()
        Cjto_Tablas1.Tables("TESTIGO").Clear()
        Cjto_Tablas1.Tables("ESTANDAR").Clear()
        Cjto_Tablas1.Tables("ANALISTA_ELEMENTO").Clear()
        Cjto_Tablas1.Tables("PERSONAL").Clear()
        Cjto_Tablas1.Tables("DICCIONARIO").Clear()
        Cjto_Tablas1.Tables("TIPO_MASCARA").Clear()
        Cjto_Tablas1.Tables("ORDEN_TRABAJO_PASO").Clear()
        Cjto_Tablas1.Tables("MUESTREADORES").Clear()
        Cjto_Tablas1.Tables("FACTURA_PASO").Clear()


        Dim Test1 As DbManager = New DbManager("ESPECIE", Conexion1)
        Dim query1 As String = "Select DISTINCT ESPECIE from ESPECIE_VARIEDAD"
        Test1.Selecccionar(Cjto_Tablas1, query1)

        Dim Test2 As DbManager = New DbManager("TEJIDO", Conexion1)
        Dim query2 As String = "Select * from TEJIDO"
        Test2.Selecccionar(Cjto_Tablas1, query2)

        Dim Test5 As DbManager = New DbManager("MUESTRA", Conexion1)
        Dim query5 As String = "Select * from MUESTRA"
        Test5.Selecccionar(Cjto_Tablas1, query5)

        Dim Test6 As DbManager = New DbManager("CULTIVO", Conexion1)
        Dim query6 As String = "Select * from CULTIVO"
        Test6.Selecccionar(Cjto_Tablas1, query6)

        Dim Test7 As DbManager = New DbManager("CULTIVO1", Conexion1)
        Dim query7 As String = "Select * from CULTIVO"
        Test7.Selecccionar(Cjto_Tablas1, query7)

        Dim Test8 As DbManager = New DbManager("TIPO_FERTILIZANTE", Conexion1)
        Dim query8 As String = "Select * from TIPO_FERTILIZANTE"
        Test8.Selecccionar(Cjto_Tablas1, query8)

        Dim Test9 As DbManager = New DbManager("ANALISIS", Conexion1)
        Dim query9 As String = "Select * from ANALISIS"
        Test9.Selecccionar(Cjto_Tablas1, query9)

        Dim Test10 As DbManager = New DbManager("COMBO_ANALISIS", Conexion1)
        Dim query10 As String = "Select * from COMBO_ANALISIS"
        Test10.Selecccionar(Cjto_Tablas1, query10)

        Dim Test11 As DbManager = New DbManager("SUBMUESTRA", Conexion1)
        Dim query11 As String = "Select * from SUBMUESTRA"
        Test11.Selecccionar(Cjto_Tablas1, query11)

        query = "select distinct PRO_PRODUCTOR from PRODUCTOR_LABSYS"
        Dim dbman As DbManager = New DbManager("PRODUCTOR_AUTOCOMPLETA", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select DISTINCT PRO_EMPRESA from PRODUCTOR_LABSYS where PRO_EMPRESA <> 'NULL' ORDER BY PRO_EMPRESA"
        dbman = New DbManager("PRODUCTOR_EMPRESA", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select distinct COMUNA from LOCALIDAD ORDER BY COMUNA"
        dbman = New DbManager("COMUNASFACT", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select DISTINCT COMUNA from LOCALIDAD ORDER BY COMUNA"
        dbman = New DbManager("COMUNASDESP", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select distinct CIUDAD from LOCALIDAD ORDER BY CIUDAD"
        dbman = New DbManager("CIUDADFACT", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select distinct CIUDAD from LOCALIDAD ORDER BY CIUDAD"
        dbman = New DbManager("CIUDADDESP", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select DISTINCT LOCALIDAD from LOCALIDAD ORDER BY LOCALIDAD"
        dbman = New DbManager("LOCALIDAD", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select DISTINCT COMUNA from LOCALIDAD ORDER BY COMUNA"
        dbman = New DbManager("COMUNA", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select DISTINCT CIUDAD from LOCALIDAD ORDER BY CIUDAD"
        dbman = New DbManager("CIUDAD", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select DISTINCT PROVINCIA from LOCALIDAD ORDER BY PROVINCIA"
        dbman = New DbManager("PROVINCIA", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select COD_REGION,REG_NOMBRE from REGION"
        dbman = New DbManager("REGION", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from ELEMENTO"
        dbman = New DbManager("ELEMENTO", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from CONDICION_PAGO"
        dbman = New DbManager("CONDICION_PAGO", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from HOMOLOGA_ELEMENTO"
        dbman = New DbManager("HOMOLOGA_ELEMENTO", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from FORMATO_PLADIG"
        dbman = New DbManager("FORMATO_PLADIG", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select TES_OT_NLAB from TESTIGO_ESTANDAR WHERE TES_TIPO='T' ORDER BY OT_FECHA_ORDEN DESC"
        dbman = New DbManager("TESTIGO", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select TES_OT_NLAB from TESTIGO_ESTANDAR WHERE TES_TIPO='E' ORDER BY OT_FECHA_ORDEN DESC"
        dbman = New DbManager("ESTANDAR", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from ANALISTA_ELEMENTO"
        dbman = New DbManager("ANALISTA_ELEMENTO", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from PERSONAL"
        dbman = New DbManager("PERSONAL", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from DICCIONARIO"
        dbman = New DbManager("DICCIONARIO", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        query = "Select * from TIPO_MASCARA"
        dbman = New DbManager("TIPO_MASCARA", Conexion1)
        dbman.Selecccionar(Cjto_Tablas1, query)

        dbman = New DbManager("ORDEN_TRABAJO_PASO", Conexion1)
        query = "Select * from ORDEN_TRABAJO ORDER BY OT_NUMERO"
        dbman.Selecccionar(Cjto_Tablas1, query)

        dbman = New DbManager("MUESTREADORES", Conexion1)
        query = "Select TOP 5 MUE_NOMBRE from MUESTREADORES ORDER BY MUE_FECHACRE DESC"
        dbman.Selecccionar(Cjto_Tablas1, query)

        dbman = New DbManager("FACTURA_PASO", Conexion1)
        query = "Select * from FACTURA ORDER BY FAC_NUMERO"
        dbman.Selecccionar(Cjto_Tablas1, query)


    End Sub

    Public Function Clase_Textural(ByVal Arc As Double, ByVal Lim As Double, ByVal Are As Double, ByRef Tipo As String) As String
        ' Esta funcion trabaja en base a limites del triangulo, la cual tiene la funcion de asignar 
        ' el nombre de la clase textural a cual le corresponda.

        ' If Arc > 60 Then Return ("Arcillosa Densa")

        If Arc >= 60 Then Tipo = "Arcillosa"

        If (Are >= 0 And Are <= 45) And (Arc >= 41 And Arc <= 100) And (Lim >= 0 And Lim <= 39) Then Tipo = "Arcillosa"



        If (Are >= 46 And Are <= 65) And (Arc >= 36 And Arc <= 55) And (Lim >= 0 And Lim <= 20) Then Tipo = "Arcillosa Arenosa"

        If (Are >= 0 And Are <= 20) And (Arc >= 41 And Arc <= 60) And (Lim >= 40 And Lim <= 60) Then Tipo = "Arcillo Limosa"

        If (Are >= 46 And Are <= 80) And (Arc >= 21 And Arc <= 35) And (Lim >= 0 And Lim <= 27) Then Tipo = "Fco.Arc.Arenosa"

        If (Are >= 20 And Are <= 45) And (Arc >= 28 And Arc <= 40) And (Lim >= 15 And Lim <= 53) Then Tipo = "Fco.Arcillosa"

        If (Are >= 0 And Are <= 19) And (Arc >= 28 And Arc <= 40) And (Lim >= 40 And Lim <= 73) Then Tipo = "Fco.Arc.Limosa"

        If ((Are >= 53 And Are <= 85) And (Arc >= 0 And Arc <= 20) And (Lim >= 0 And Lim <= 42)) And _
            ((Are <= 85 And Arc >= 15) Or (Are <= 84 And Arc >= 14) Or _
         (Are <= 83 And Arc >= 13) Or (Are <= 82 And Arc >= 12) Or _
         (Are <= 81 And Arc >= 11) Or (Are <= 80 And Arc >= 10) Or _
         (Are <= 79 And Arc >= 9) Or (Are <= 78 And Arc >= 8) Or _
         (Are <= 77 And Arc >= 7) Or (Are <= 76 And Arc >= 6) Or _
         (Are <= 75 And Arc >= 5) Or (Are <= 74 And Arc >= 4) Or _
         (Are <= 73 And Arc >= 3) Or (Are <= 72 And Arc >= 2) Or _
         (Are <= 71 And Arc >= 1) Or (Are <= 70 And Arc >= 0)) Or _
         ((Arc >= 0 And Arc <= 6) And (Lim >= 43 And Lim <= 50)) Then Tipo = "Fco.Arenosa"

        If (Are >= 24 And Are <= 52) And (Arc >= 7 And Arc <= 27) And (Lim >= 28 And Lim <= 50) Then Tipo = "Franca"

        If (Are >= 0 And Are <= 50) And (Arc >= 0 And Arc <= 27) And (Lim >= 51 And Lim <= 80) Or _
        ((Arc >= 12 And Arc <= 20) And (Are >= 0 And Are <= 8) And (Lim >= 81 And Lim <= 88)) Then Tipo = "Fco.Limosa"

        If ((Are >= 85 And Arc <= 15) Or (Are >= 84 And Arc <= 14) Or _
        (Are >= 83 And Arc <= 13) Or (Are >= 82 And Arc <= 12) Or _
        (Are >= 81 And Arc <= 11) Or (Are >= 80 And Arc <= 10) Or _
        (Are >= 79 And Arc <= 9) Or (Are >= 78 And Arc <= 8) Or _
        (Are >= 77 And Arc <= 7) Or (Are >= 76 And Arc <= 6) Or _
        (Are >= 75 And Arc <= 5) Or (Are >= 74 And Arc <= 4) Or _
        (Are >= 73 And Arc <= 3) Or (Are >= 72 And Arc <= 2) Or _
        (Are >= 71 And Arc <= 1) Or (Are >= 70 And Arc <= 0)) And _
        ((Are <= 90 And Arc >= 10) Or (Are <= 89 And Arc >= 9) Or _
        (Are <= 89 And Arc >= 8) Or (Are <= 88 And Arc >= 7) Or _
        (Are <= 88 And Arc >= 6) Or (Are <= 87 And Arc >= 5) Or _
        (Are <= 86 And Arc >= 4) Or (Are <= 86 And Arc >= 3) Or _
        (Are <= 85 And Arc >= 2) Or (Are <= 85 And Arc >= 1) Or _
        (Are <= 84 And Arc >= 0)) And (Lim >= 0 And Lim <= 30) Then Tipo = "Arenosa Fca."

        If (Are >= 0 And Are <= 20) And (Arc >= 0 And Arc <= 11) And (Lim >= 81 And Lim <= 100) Then Tipo = "Limosa"

        If ((Are >= 90 And Arc <= 10) Or (Are >= 89 And Arc <= 9) Or (Are >= 89 And Arc <= 8) Or _
        (Are >= 88 And Arc <= 7) Or (Are >= 88 And Arc <= 6) Or _
        (Are >= 87 And Arc <= 5) Or (Are >= 86 And Arc <= 4) Or _
        (Are >= 86 And Arc <= 3) Or (Are >= 85 And Arc <= 2) Or _
        (Are >= 85 And Arc <= 1) Or (Are >= 84 And Arc <= 0)) Then Tipo = "Arenosa"


    End Function

    Public Sub Clasificacion(ByVal Lect1 As Double, ByVal Lect2 As Double, ByVal Temp1 As Double, ByVal Temp2 As Double, ByRef ARC As Double, ByRef ARE As Double, ByRef LIM As Double, ByRef TOTAL As Double)
        'Este codigo determina la cantidad de Arena,Limo,Arcilla
        'Las variables Lectura y Lectura2 entregan el valor correspondiente a la temperatura (ver tabla Lectura)
        'La varianble Tot1 representa el resultado obtenido para la Arena
        'La variable Tot2 representa el resultado obtenido para la Arcilla
        'La variable Lim representa el resultado obtenido para el Limo

        Dim Lectura, Lectura2, Tot1, Tot2, Lect, Read2 As Double
        Dim consulta_nota, consulta_nota2 As String
        Dim con As New SqlConnection(Conexion1)
        'Se realizan dos querys ya que nesecitamos conocer dos valores correspondientes a dos temperaturas
        'distintas
        con.Open()
        consulta_nota = "SELECT LECTU FROM LECTURA WHERE TEMPERA=" & Temp1
        consulta_nota2 = "SELECT LECTU FROM LECTURA WHERE TEMPERA=" & Temp2

        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim mycommand4 As New SqlCommand(consulta_nota2, con)
        Dim myReader2 As SqlDataReader
        Dim myReader3 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Read()
        Lectura = myReader2.GetDouble(0)
        myReader2.Close()

        myReader3 = mycommand4.ExecuteReader()
        myReader3.Read()
        Lectura2 = myReader3.GetDouble(0)
        myReader3.Close()
        con.Close()

        Select Case Temp1
            Case Is <= 19
                Lect = (Lect1 + Lectura) ' La varible Lect1 es el valor ingresado como lectura1
                Tot1 = (100 - (Lect * 2))
                Tot1 = Round(Tot1, 0) ' El comando Round redondea el resultado
            Case Is > 20
                Lect = (Lect1 + Lectura) ' La varible Lect1 es el valor ingresado como lectura1
                Tot1 = (100 - (Lect * 2))
                Tot1 = Round(Tot1, 0) ' El comando Round redondea el resultado
            Case Is = 20
                Lect = (Lect1 + Lectura) ' La varible Lect1 es el valor ingresado como lectura1
                Tot1 = (100 - (Lect * 2))
                Tot1 = Round(Tot1, 0) ' El comando Round redondea el resultado
        End Select
        Select Case Temp2
            Case Is <= 19
                Read2 = (Lect2 + Lectura2) ' La varible Lect2 es el valor ingresado como lectura2
                Tot2 = (Read2 * 2)
                Tot2 = Round(Tot2, 0) ' El comando Round redondea el resultado
            Case Is >= 21
                Read2 = (Lect2 + Lectura2) ' La varible Lect2 es el valor ingresado como lectura2
                Tot2 = (Read2 * 2)
                Tot2 = Round(Tot2, 0) ' El comando Round redondea el resultado
            Case Is = 20
                Read2 = (Lect2 + Lectura2) ' La varible Lect2 es el valor ingresado como lectura2
                Tot2 = (Read2 * 2)
                Tot2 = Round(Tot2, 0) ' El comando Round redondea el resultado
        End Select
        LIM = (100 - (Tot1 + Tot2))
        If Tot1 <= 0 Then
            LIM = (100 - Tot2) - 1
            Tot1 = 1
        End If
        ARC = Tot2
        ARE = Tot1
        TOTAL = ((Tot1 + Tot2) + LIM)
    End Sub

    Public Function Fraccion_Arena(ByVal C·psulaA As String, ByVal TaraA As Double, ByVal C·psulaB As String, ByVal TaraB As Double, ByVal Arena As String, ByRef dblCap1 As Double, ByRef dblCap2 As Double, ByRef dblTotArena As Double, ByRef dblPorcArena1 As Double, ByRef dblPorcArena2 As Double, ByRef dblPorcArenaTextural1 As Double, ByRef dblPorcArenaTextural2 As Double)
        'La variable dblCap1 y dblCap2 son los valores correspondientes al PESO DE LA MUESTRA

        dblCap1 = CDbl(C·psulaA) - TaraA 'CapsulaA representa el P.Cap+Mue, TaraA representa el P.Capsula
        dblCap1 = Round(dblCap1, 1)
        dblCap2 = CDbl(C·psulaB) - TaraB  'CapsulaA representa el P.Cap+Mue, TaraA representa el P.Capsula
        dblCap2 = Round(dblCap2, 1)
        dblTotArena = dblCap1 + dblCap2 ' Calcula el Total de Arenas
        dblTotArena = Round(dblTotArena, 1)
        dblPorcArena1 = (dblCap1 / dblTotArena) * 100 ' Calcula el porcentaje de Arena Gruesa
        dblPorcArena2 = (dblCap2 / dblTotArena) * 100 ' Calcula el porcentaje de Arena Fina
    End Function

    Public Function F_Arena(ByVal Pagruesa As Double, ByVal Capsula1 As Double, ByVal Pafina As Double, ByVal Capsula2 As Double, ByRef Porc_AFina As Double, ByRef Porc_AGruesa As Double, ByVal Por_Arena As Double)
        Dim Pmuestra1, Pmuestra2, Tot_Arena As Double
        Pmuestra1 = Round((Pagruesa - Capsula1), 1)
        Pmuestra2 = Round((Pafina - Capsula2), 1)
        Tot_Arena = Round((Pmuestra1 + Pmuestra2), 1)
        Porc_AGruesa = (Pmuestra1 / Tot_Arena) * 100
        Porc_AFina = (Pmuestra2 / Tot_Arena) * 100
        Porc_AGruesa = (Porc_AGruesa * Por_Arena) / 100
        Porc_AFina = (Porc_AFina * Por_Arena) / 100
    End Function

    Public Function FormatoDecimales(ByVal ResDec As Double, ByVal dsDecimal As DataSet) As String
        Dim StrRes As String
        Dim PosicionComa As Integer
        Dim ParteEntera As String
        Dim Fila_TMascara As DataRow
        Dim sDecimales As String
        Dim CantDec As Integer = 0

        StrRes = CStr(ResDec)
        PosicionComa = InStr(StrRes, ",")

        If PosicionComa > 0 Then
            ParteEntera = Mid(StrRes, 1, PosicionComa - 1)
            sDecimales = Mid(StrRes, PosicionComa + 1) & "00000"
        Else
            ParteEntera = StrRes
            sDecimales = "00000"
        End If

        For Each Fila_TMascara In dsDecimal.Tables(0).Rows
            If Fila_TMascara("RANGO_DESDE") <= ResDec And ResDec <= Fila_TMascara("RANGO_HASTA") Then
                CantDec = Fila_TMascara("DECIMALES")
                If CantDec = 0 Then StrRes = ParteEntera
                If CantDec = 1 Then StrRes = ParteEntera & "," & Mid(sDecimales, 1, 1)
                If CantDec = 2 Then StrRes = ParteEntera & "," & Mid(sDecimales, 1, 2)
                If CantDec = 3 Then StrRes = ParteEntera & "," & Mid(sDecimales, 1, 3)
                Return StrRes
            End If
        Next
    End Function

    Public Sub Graba_Historia_Estado(ByVal Hotnum As Integer, ByVal Hestana As String, ByVal Hestpag As String, _
                                      ByVal Hestfac As String, ByVal Hfacnum As Integer, ByVal Hfacest As String, _
                                      ByVal Hobs As String)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()
            .AgregarParametro("@NumOT", Hotnum, SqlDbType.Int)
            .AgregarParametro("@EstAna", Hestana, SqlDbType.NVarChar)
            .AgregarParametro("@EstPag", Hestpag, SqlDbType.NVarChar)
            .AgregarParametro("@EstFac", Hestfac, SqlDbType.NVarChar)
            .AgregarParametro("@Fac_Numero", Hfacnum, SqlDbType.Int)
            .AgregarParametro("@Fac_Estado", Hfacest, SqlDbType.NVarChar)
            .AgregarParametro("@Observacion", Hobs, SqlDbType.NVarChar)
            .AgregarParametro("@Usuario", sUserName, SqlDbType.NVarChar)
            .AgregarParametro("@Fecha", Format(Now, "dd-MM-yyyy hh:mm:ss"), SqlDbType.DateTime)
            .EjecutarEscalar("usp_InsertCambioEstado")
        End With
    End Sub

    'Private Function Cantidad_Decimales(ByVal TIPOM As Integer, ByVal ResultadoR As Double) As Integer
    '    Dim BusRango(1) As Object
    '    Dim hg, CaDecimal As Integer
    '    Dim Fila_TMascara As DataRow
    '    For hg = 1 To 9
    '        BusRango(0) = TIPOM
    '        BusRango(1) = hg
    '        Fila_TMascara = Cjto_Tablas1.Tables("TIPO_MASCARA").Rows.Find(BusRango)
    '        If (Fila_TMascara Is Nothing) = False Then
    '            If ResultadoR >= Fila_TMascara("RANGO_DESDE") And ResultadoR < Fila_TMascara("RANGO_HASTA") Then CaDecimal = Fila_TMascara("DECIMALES") : Exit For
    '        End If
    '    Next
    '    Return CaDecimal
    'End Function


End Module
