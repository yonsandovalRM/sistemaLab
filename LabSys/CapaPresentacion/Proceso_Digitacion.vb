Imports System.Data.SqlClient
Module Proceso_Digitacion

    Public Sub Graba(ByVal FechaAna As DateTime, ByVal FechaDig As DateTime, ByVal Elemento As String, ByVal Analista As String, ByVal Digitador As String, ByVal CodMuestra As Integer)
        Dim Fila, Fila_Int As DataRow
        Dim Tipo, Dato_NLab As String
        Dim Blanco, Factor, Lectura, Resultado As Double
        Dim FactorD, LecturaD, ResultadoD As Double
        Dim FactorR, LecturaR, ResultadoR As Double
        Dim Estandar, Testigo, Retorno As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        For Each Fila In Cjto_Tablas1.Tables("DIGITACION").Rows
            Dim Nlab As String = Fila("OT_NLABX")
            Try
                If InStr(Nlab, "T") Then
                    Testigo = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    Tipo = "T"
                    For Each Fila_Int In Cjto_Tablas1.Tables("DIGITACION").Rows
                        Dim DatPaso As String = Fila_Int("OT_NLABX")
                        If InStr(datpaso, "Blanco") Then
                            Blanco = CDbl(Fila_Int("LECTURA"))
                        End If

                        If InStr(DatPaso, "T") Or InStr(DatPaso, "S") Or InStr(DatPaso, "Blanco") Then
                            GoTo saltopri
                        Else
                            If InStr(DatPaso, "D") Then
                                Dato_NLab = Mid(DatPaso, 1, Len(DatPaso) - 2)
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            Else
                                Dato_NLab = DatPaso
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            End If
                            With SP
                                .Inicializar()
                                .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                                .AgregarParametro("@nlabest", Testigo, SqlDbType.Int)
                                .AgregarParametro("@tipo", Tipo, SqlDbType.NVarChar)
                                .AgregarParametro("@codele", Elemento, SqlDbType.NVarChar)
                                .AgregarParametro("@nlabrelac", CInt(Dato_NLab), SqlDbType.Int)
                                .AgregarParametro("@numdig", 1, SqlDbType.Int)
                                .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                                .AgregarParametro("@fechadigit", FechaDig, SqlDbType.DateTime)
                                .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                                .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                                .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                                .AgregarParametro("@factor", Factor, SqlDbType.Float)
                                .AgregarParametro("@lectura", Lectura, SqlDbType.Float)
                                .AgregarParametro("@resultado", Resultado, SqlDbType.Float)
                                ' Procedimiento almacenado guarda Testigo
                                .EjecutarEscalar("usp_GrabaTesEst")

                            End With
                        End If
saltopri:
                    Next

                ElseIf InStr(Nlab, "S") Then
                    Estandar = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    Tipo = "S"
                    For Each Fila_Int In Cjto_Tablas1.Tables("DIGITACION").Rows
                        Dim DatPaso As String = Fila_Int("OT_NLABX")
                        If InStr(DatPaso, "Blanco") Then
                            Blanco = CDbl(Fila_Int("LECTURA"))
                        End If
                        If InStr(DatPaso, "T") Or InStr(DatPaso, "S") Or InStr(DatPaso, "Blanco") Then
                            GoTo saltopri2
                        Else
                            If InStr(DatPaso, "D") Then
                                Dato_NLab = Mid(DatPaso, 1, Len(DatPaso) - 2)
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            Else
                                Dato_NLab = DatPaso
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            End If
                            With SP
                                .Inicializar()
                                .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                                .AgregarParametro("@nlabest", Estandar, SqlDbType.Int)
                                .AgregarParametro("@tipo", Tipo, SqlDbType.NVarChar)
                                .AgregarParametro("@codele", Elemento, SqlDbType.NVarChar)
                                .AgregarParametro("@nlabrelac", CInt(Dato_NLab), SqlDbType.Int)
                                .AgregarParametro("@numdig", 1, SqlDbType.Int)
                                .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                                .AgregarParametro("@fechadigit", FechaDig, SqlDbType.DateTime)
                                .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                                .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                                .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                                .AgregarParametro("@factor", Factor, SqlDbType.Float)
                                .AgregarParametro("@lectura", Lectura, SqlDbType.Float)
                                .AgregarParametro("@resultado", Resultado, SqlDbType.Float)
                                ' Procedimiento Almacenado guarda Estandar
                                .EjecutarEscalar("usp_GrabaTesEst")

                            End With
                        End If
saltopri2:
                    Next

                ElseIf InStr(Nlab, "D") Then
                    Dim NumLabD As Integer = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    FactorD = Fila("FACTOR")
                    LecturaD = Fila("LECTURA")
                    ResultadoD = Fila("RESULTADO")
                    With SP
                        .Inicializar()
                        .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                        .AgregarParametro("@nlab", NumLabD, SqlDbType.Int)
                        .AgregarParametro("@elemento", Elemento, SqlDbType.NVarChar)
                        .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                        .AgregarParametro("@fechadig", FechaDig, SqlDbType.DateTime)
                        .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                        .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                        .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                        .AgregarParametro("@factor", FactorD, SqlDbType.Float)
                        .AgregarParametro("@lectura", LecturaD, SqlDbType.Float)
                        .AgregarParametro("@resultado", ResultadoD, SqlDbType.Float)
                        .AgregarParametro("@estado", "xR", SqlDbType.NVarChar)
                        '.AgregarParametro("@hanalisis", 1, SqlDbType.DateTime)
                        'Procedimento almacenado guarda Duplicados
                        .EjecutarEscalar("usp_GrabaDuplicaResultados")

                    End With

                Else

                    If InStr(Nlab, "Blanco") Then
                        Blanco = CDbl(Fila("LECTURA"))
                    Else
                        FactorR = Fila("FACTOR")
                        LecturaR = Fila("LECTURA")
                        ResultadoR = Fila("RESULTADO")
                        If IsNothing(LecturaR) = True Then GoTo salx
                        With SP
                            .Inicializar()
                            .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                            .AgregarParametro("@nlab", CInt(Nlab), SqlDbType.Int)
                            .AgregarParametro("@elemento", Elemento, SqlDbType.NVarChar)
                            .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                            .AgregarParametro("@fechadig", FechaDig, SqlDbType.DateTime)
                            .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                            .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                            .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                            .AgregarParametro("@factor", FactorR, SqlDbType.Float)
                            .AgregarParametro("@lectura", LecturaR, SqlDbType.Float)
                            .AgregarParametro("@resultado", ResultadoR, SqlDbType.Float)
                            .AgregarParametro("@estado", "xR", SqlDbType.NVarChar)
                            'Procedimiento almacenado graba Resultados
                            .EjecutarEscalar("usp_GrabaResultados")
                        End With
Salx:
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        MsgBox("Grabación Finalizada")
    End Sub
    Public Sub Graba_LecturaDirecta(ByVal FechaAna As DateTime, ByVal FechaDig As DateTime, ByVal Elemento As String, ByVal Analista As String, ByVal Digitador As String, ByVal CodMuestra As Integer)
        Dim Fila, Fila_Int As DataRow
        Dim Tipo, Dato_NLab As String
        Dim Blanco, Factor, Lectura, Resultado As Double
        Dim FactorD, LecturaD, ResultadoD As Double
        Dim FactorR, LecturaR, ResultadoR As Double
        Dim Estandar, Testigo, Retorno As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        For Each Fila In Cjto_Tablas1.Tables("DIGITACION").Rows
            Dim Nlab As String = Fila("OT_NLABX")
            If IsDBNull(Fila("OBSERVACION")) = True Then Fila("OBSERVACION") = 0
            Dim Comen As String = Fila("OBSERVACION")
            Try
                If InStr(Nlab, "T") Then
                    Testigo = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    Tipo = "T"
                    For Each Fila_Int In Cjto_Tablas1.Tables("DIGITACION").Rows
                        Dim DatPaso As String = Fila_Int("OT_NLABX")
                        If InStr(datpaso, "Blanco") Then
                            Blanco = CDbl(Fila_Int("RESULTADO"))
                        End If

                        If InStr(DatPaso, "T") Or InStr(DatPaso, "S") Or InStr(DatPaso, "Blanco") Then
                            GoTo saltopri
                        Else
                            If InStr(DatPaso, "D") Then
                                Dato_NLab = Mid(DatPaso, 1, Len(DatPaso) - 2)
                                Factor = 0
                                Lectura = CDbl(Fila_Int("RESULTADO"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            Else
                                Dato_NLab = DatPaso
                                Factor = 0
                                Lectura = CDbl(Fila_Int("RESULTADO"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            End If
                            With SP
                                .Inicializar()
                                .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                                .AgregarParametro("@nlabest", Testigo, SqlDbType.Int)
                                .AgregarParametro("@tipo", Tipo, SqlDbType.NVarChar)
                                .AgregarParametro("@codele", Elemento, SqlDbType.NVarChar)
                                .AgregarParametro("@nlabrelac", CInt(Dato_NLab), SqlDbType.Int)
                                .AgregarParametro("@numdig", 1, SqlDbType.Int)
                                .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                                .AgregarParametro("@fechadigit", FechaDig, SqlDbType.DateTime)
                                .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                                .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                                .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                                .AgregarParametro("@factor", Factor, SqlDbType.Float)
                                .AgregarParametro("@lectura", Lectura, SqlDbType.Float)
                                .AgregarParametro("@resultado", Resultado, SqlDbType.Float)
                                ' Procedimiento almacenado guarda Testigo
                                .EjecutarEscalar("usp_GrabaTesEst")

                            End With
                        End If
saltopri:
                    Next

                ElseIf InStr(Nlab, "S") Then
                    Estandar = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    Tipo = "S"
                    For Each Fila_Int In Cjto_Tablas1.Tables("DIGITACION").Rows
                        Dim DatPaso As String = Fila_Int("OT_NLABX")
                        If InStr(DatPaso, "Blanco") Then
                            Blanco = CDbl(Fila_Int("RESULTADO"))
                        End If
                        If InStr(DatPaso, "T") Or InStr(DatPaso, "S") Or InStr(DatPaso, "Blanco") Then
                            GoTo saltopri2
                        Else
                            If InStr(DatPaso, "D") Then
                                Dato_NLab = Mid(DatPaso, 1, Len(DatPaso) - 2)
                                Factor = 0
                                Lectura = CDbl(Fila_Int("RESULTADO"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            Else
                                Dato_NLab = DatPaso
                                Factor = 0
                                Lectura = CDbl(Fila_Int("RESULTADO"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            End If
                            With SP
                                .Inicializar()
                                .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                                .AgregarParametro("@nlabest", Estandar, SqlDbType.Int)
                                .AgregarParametro("@tipo", Tipo, SqlDbType.NVarChar)
                                .AgregarParametro("@codele", Elemento, SqlDbType.NVarChar)
                                .AgregarParametro("@nlabrelac", CInt(Dato_NLab), SqlDbType.Int)
                                .AgregarParametro("@numdig", 1, SqlDbType.Int)
                                .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                                .AgregarParametro("@fechadigit", FechaDig, SqlDbType.DateTime)
                                .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                                .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                                .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                                .AgregarParametro("@factor", Factor, SqlDbType.Float)
                                .AgregarParametro("@lectura", Lectura, SqlDbType.Float)
                                .AgregarParametro("@resultado", Resultado, SqlDbType.Float)
                                ' Procedimiento Almacenado guarda Estandar
                                .EjecutarEscalar("usp_GrabaTesEst")

                            End With
                        End If
saltopri2:
                    Next

                ElseIf InStr(Nlab, "D") Then
                    Dim NumLabD As Integer = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    FactorD = 0
                    LecturaD = Fila("RESULTADO")
                    ResultadoD = Fila("RESULTADO")
                    With SP
                        .Inicializar()
                        .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                        .AgregarParametro("@nlab", NumLabD, SqlDbType.Int)
                        .AgregarParametro("@elemento", Elemento, SqlDbType.NVarChar)
                        .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                        .AgregarParametro("@fechadig", FechaDig, SqlDbType.DateTime)
                        .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                        .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                        .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                        .AgregarParametro("@factor", FactorD, SqlDbType.Float)
                        .AgregarParametro("@lectura", LecturaD, SqlDbType.Float)
                        .AgregarParametro("@resultado", ResultadoD, SqlDbType.Float)
                        .AgregarParametro("@estado", "xR", SqlDbType.NVarChar)
                        '.AgregarParametro("@hanalisis", 1, SqlDbType.DateTime)
                        'Procedimento almacenado guarda Duplicados
                        .EjecutarEscalar("usp_GrabaDuplicaResultados")

                    End With

                Else

                    If InStr(Nlab, "Blanco") Then
                        Blanco = CDbl(Fila("RESULTADO"))
                    Else
                        LecturaR = Fila("RESULTADO")
                        ResultadoR = Fila("RESULTADO")
                        If IsNothing(LecturaR) = True Then GoTo salx
                        With SP
                            .Inicializar()
                            .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                            .AgregarParametro("@nlab", CInt(Nlab), SqlDbType.Int)
                            .AgregarParametro("@elemento", Elemento, SqlDbType.NVarChar)
                            .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                            .AgregarParametro("@fechadig", FechaDig, SqlDbType.DateTime)
                            .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                            .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                            .AgregarParametro("@lectura", LecturaR, SqlDbType.Float)
                            .AgregarParametro("@resultado", ResultadoR, SqlDbType.Float)
                            .AgregarParametro("@estado", "xR", SqlDbType.NVarChar)
                            .AgregarParametro("@comentario", Comen, SqlDbType.NVarChar)
                            'Procedimiento almacenado graba Resultados
                            .EjecutarEscalar("usp_GrabaResultadosLecturaDirecta")
                        End With
Salx:
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        MsgBox("Grabación Finalizada")
    End Sub
    Public Sub Graba_EAA(ByVal FechaAna As DateTime, ByVal FechaDig As DateTime, ByVal Elemento As String, ByVal Analista As String, ByVal Digitador As String, ByVal CodMuestra As Integer)
        Dim Fila, Fila_Int As DataRow
        Dim Tipo, Dato_NLab As String
        Dim Blanco, Factor, Lectura, Resultado As Double
        Dim FactorD, LecturaD, ResultadoD As Double
        Dim FactorR, LecturaR, ResultadoR As Double
        Dim Estandar, Testigo, Retorno, Numero As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        For Each Fila In Cjto_Tablas1.Tables("DIGITACION").Rows
            Dim Nlab As String = Fila("OT_NLABX")
            Try
                If InStr(Nlab, "T") Then
                    Testigo = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    Tipo = "T"
                    For Each Fila_Int In Cjto_Tablas1.Tables("DIGITACION").Rows
                        Dim DatPaso As String = Fila_Int("OT_NLABX")
                        If InStr(datpaso, "Blanco") Then
                            Blanco = CDbl(Fila_Int("LECTURA"))
                        End If

                        If InStr(DatPaso, "T") Or InStr(DatPaso, "S") Or InStr(DatPaso, "Blanco") Then
                            GoTo saltopri
                        Else
                            If InStr(DatPaso, "D") Then
                                Dato_NLab = Mid(DatPaso, 1, Len(DatPaso) - 2)
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            Else
                                Dato_NLab = DatPaso
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            End If
                            With SP
                                .Inicializar()
                                .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                                .AgregarParametro("@nlabest", Testigo, SqlDbType.Int)
                                .AgregarParametro("@tipo", Tipo, SqlDbType.NVarChar)
                                .AgregarParametro("@codele", Elemento, SqlDbType.NVarChar)
                                .AgregarParametro("@nlabrelac", CInt(Dato_NLab), SqlDbType.Int)
                                .AgregarParametro("@numdig", 1, SqlDbType.Int)
                                .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                                .AgregarParametro("@fechadigit", FechaDig, SqlDbType.DateTime)
                                .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                                .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                                .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                                .AgregarParametro("@factor", Factor, SqlDbType.Float)
                                .AgregarParametro("@lectura", Lectura, SqlDbType.Float)
                                .AgregarParametro("@resultado", Resultado, SqlDbType.Float)
                                ' Procedimiento almacenado guarda Testigo
                                .EjecutarEscalar("usp_GrabaTesEst")

                            End With
                        End If
saltopri:
                    Next

                ElseIf InStr(Nlab, "S") Then
                    Estandar = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    Tipo = "S"
                    For Each Fila_Int In Cjto_Tablas1.Tables("DIGITACION").Rows
                        Dim DatPaso As String = Fila_Int("OT_NLABX")
                        If InStr(DatPaso, "Blanco") Then
                            Blanco = CDbl(Fila_Int("LECTURA"))
                        End If
                        If InStr(DatPaso, "T") Or InStr(DatPaso, "S") Or InStr(DatPaso, "Blanco") Then
                            GoTo saltopri2
                        Else
                            If InStr(DatPaso, "D") Then
                                Dato_NLab = Mid(DatPaso, 1, Len(DatPaso) - 2)
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            Else
                                Dato_NLab = DatPaso
                                Factor = CDbl(Fila_Int("FACTOR"))
                                Lectura = CDbl(Fila_Int("LECTURA"))
                                Resultado = CDbl(Fila_Int("RESULTADO"))
                            End If
                            With SP
                                .Inicializar()
                                .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                                .AgregarParametro("@nlabest", Estandar, SqlDbType.Int)
                                .AgregarParametro("@tipo", Tipo, SqlDbType.NVarChar)
                                .AgregarParametro("@codele", Elemento, SqlDbType.NVarChar)
                                .AgregarParametro("@nlabrelac", CInt(Dato_NLab), SqlDbType.Int)
                                .AgregarParametro("@numdig", 1, SqlDbType.Int)
                                .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                                .AgregarParametro("@fechadigit", FechaDig, SqlDbType.DateTime)
                                .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                                .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                                .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                                .AgregarParametro("@factor", Factor, SqlDbType.Float)
                                .AgregarParametro("@lectura", Lectura, SqlDbType.Float)
                                .AgregarParametro("@resultado", Resultado, SqlDbType.Float)
                                ' Procedimiento Almacenado guarda Estandar
                                .EjecutarEscalar("usp_GrabaTesEst")

                            End With
                        End If
saltopri2:
                    Next

                ElseIf InStr(Nlab, "D") Then
                    Dim NumLabD As Integer = CInt(Mid(Nlab, 1, Len(Nlab) - 2))
                    FactorD = Fila("FACTOR")
                    LecturaD = Fila("LECTURA")
                    ResultadoD = Fila("RESULTADO")
                    With SP
                        .Inicializar()
                        .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                        .AgregarParametro("@nlab", NumLabD, SqlDbType.Int)
                        .AgregarParametro("@elemento", Elemento, SqlDbType.NVarChar)
                        .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                        .AgregarParametro("@fechadig", FechaDig, SqlDbType.DateTime)
                        .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                        .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                        .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                        .AgregarParametro("@factor", FactorD, SqlDbType.Float)
                        .AgregarParametro("@lectura", LecturaD, SqlDbType.Float)
                        .AgregarParametro("@resultado", ResultadoD, SqlDbType.Float)
                        .AgregarParametro("@estado", "xR", SqlDbType.NVarChar)
                        '.AgregarParametro("@hanalisis", 1, SqlDbType.DateTime)
                        'Procedimento almacenado guarda Duplicados
                        .EjecutarEscalar("usp_GrabaDuplicaResultados")

                    End With

                Else

                    If InStr(Nlab, "Blanco") Then
                        Blanco = CDbl(Fila("LECTURA"))
                    ElseIf InStr(Nlab, "C") Or InStr(Nlab, "H") Or InStr(Nlab, "M") Or InStr(Nlab, "L") Or InStr(Nlab, "E") Then
                        Numero = CInt(Mid(Nlab, 1, Len(Nlab) - 1))
                        FactorR = Fila("FACTOR")
                        LecturaR = Fila("LECTURA")
                        ResultadoR = Fila("RESULTADO")
                        If IsNothing(LecturaR) = True Then GoTo salx
                        With SP
                            .Inicializar()
                            .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                            .AgregarParametro("@nlab", CInt(Numero), SqlDbType.Int)
                            .AgregarParametro("@elemento", Elemento, SqlDbType.NVarChar)
                            .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                            .AgregarParametro("@fechadig", FechaDig, SqlDbType.DateTime)
                            .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                            .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                            .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                            .AgregarParametro("@factor", FactorR, SqlDbType.Float)
                            .AgregarParametro("@lectura", LecturaR, SqlDbType.Float)
                            .AgregarParametro("@resultado", ResultadoR, SqlDbType.Float)
                            .AgregarParametro("@estado", "xR", SqlDbType.NVarChar)
                            'Procedimiento almacenado graba Resultados
                            .EjecutarEscalar("usp_GrabaResultados")
                        End With
                    Else
                        Numero = Nlab
                        FactorR = Fila("FACTOR")
                        LecturaR = Fila("LECTURA")
                        ResultadoR = Fila("RESULTADO")
                        If IsNothing(LecturaR) = True Then GoTo salx
                        With SP
                            .Inicializar()
                            .AgregarParametro("@codana", CodMuestra, SqlDbType.Int)
                            .AgregarParametro("@nlab", CInt(Numero), SqlDbType.Int)
                            .AgregarParametro("@elemento", Elemento, SqlDbType.NVarChar)
                            .AgregarParametro("@fechana", FechaAna, SqlDbType.DateTime)
                            .AgregarParametro("@fechadig", FechaDig, SqlDbType.DateTime)
                            .AgregarParametro("@nomanalista", Analista, SqlDbType.NVarChar)
                            .AgregarParametro("@nomdigitador", Digitador, SqlDbType.NVarChar)
                            .AgregarParametro("@blanco", Blanco, SqlDbType.Float)
                            .AgregarParametro("@factor", FactorR, SqlDbType.Float)
                            .AgregarParametro("@lectura", LecturaR, SqlDbType.Float)
                            .AgregarParametro("@resultado", ResultadoR, SqlDbType.Float)
                            .AgregarParametro("@estado", "xR", SqlDbType.NVarChar)
                            'Procedimiento almacenado graba Resultados
                            .EjecutarEscalar("usp_GrabaResultados")
                        End With
Salx:
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        MsgBox("Grabación Finalizada")
    End Sub
    Public Function RevisaNumDup(ByVal numlab As Integer, ByVal Numd As Integer, ByVal elemento As String, ByVal Nom_Mue As Integer) As Integer
        Dim query As String
        '****************************************
        'Revisa si el numero de laboratorio se carga
        '****************************************
        Dim con As New SqlConnection(Conexion1)
        con.Open()

        query = "Select max(NUMERO_DIGITACION) FROM DUPLICA_RESULTADO WHERE TMU_CODIGO=" & Nom_Mue & " AND OT_NLAB=" & numlab & " AND ELE_CODIGO=" & "'" & elemento & "'"
        Dim myCommand2 As New SqlCommand(query, con)
        Dim myReader2 As SqlDataReader
        Try
            myReader2 = myCommand2.ExecuteReader()
            myReader2.Read()
            If Numd = myReader2.GetInt32(0) Then RevisaNumDup = 0 Else RevisaNumDup = 1
        Catch ex As Exception
            RevisaNumDup = 1
        End Try
        myReader2.Close()
        con.Close()
        Return RevisaNumDup
    End Function
    Public Function RevisaNumLab(ByVal numlab As Integer, ByVal Elemento As String, ByVal Nom_Mue As Integer) As Integer
        Dim query, NumLabDig, Estado_Aux As String
        '****************************************
        'Revisa si el numero de laboratorio se carga
        '****************************************
        Dim con As New SqlConnection(Conexion1)
        con.Open()

        query = "Select ELE_ESTADO FROM DIGITA_RESULTADOS WHERE TMU_CODIGO=" & CodAna & " AND OT_NLAB=" & numlab & " AND ELE_CODIGO=" & "'" & Elemento & "'"
        Dim myCommand2 As New SqlCommand(query, con)
        Dim myReader2 As SqlDataReader
        Try
            myReader2 = myCommand2.ExecuteReader()
            myReader2.Read()
            If IsDBNull(myReader2.GetString(0)) = False Then Estado_Aux = myReader2.GetString(0)
            If Estado_Aux = "DuxA" Or Estado_Aux = "xA" Then RevisaNumLab = 0 Else RevisaNumLab = 1
        Catch ex As Exception
            RevisaNumLab = 2
        End Try
        myReader2.Close()
        con.Close()
        Return RevisaNumLab
    End Function

End Module
