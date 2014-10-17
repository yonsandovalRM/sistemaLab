Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Public Class Frm_EnviaResultados
    Dim sRutaDest1, sRutaDest2, sRutaDest3, sRutaDest4, sRutaDest5, sRutaDest6, sRutaDest7, sRutaDest8, sRutaDest9, sRutaDest10, sRutaDest11, sAño, vaCaso As String
    Dim tmu, anac As Integer

    Sub defineTipo(ByVal sAño)


        sRutaDest1 = "F:\Mis Documentos\" + sAño + ".Agua-Labsys\"

        sRutaDest2 = "F:\Mis Documentos\" + sAño + ".Bactereologicos-Labsys\"

        sRutaDest3 = "F:\Mis Documentos\" + sAño + " Fitopatologicos PDF\"

        sRutaDest4 = "F:\Mis Documentos\" + sAño + ".Frutos-Labsys\"

        sRutaDest5 = "F:\Mis Documentos\" + sAño + ".Suelo-Labsys\"

        sRutaDest6 = "F:\Mis Documentos\" + sAño + ".Yemas-Labsys\"

        sRutaDest7 = "F:\Mis Documentos\" + sAño + ".FertQimicos-Labsys\"

        sRutaDest8 = "F:\Mis Documentos\" + sAño + ".FertOrganicos-Labsys\"

        sRutaDest9 = "F:\Mis Documentos\" + sAño + " Guanos Bacteriologicos\"

        sRutaDest10 = "F:\Mis Documentos\" + sAño + ".Nematodos-Labsys\"

        sRutaDest11 = "F:\Mis Documentos\" + sAño + ".Foliar-Labsys\"


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click


        Try

            Dim porEstado, envioM As String
            Dim dsOT, dsAvisafono As New DataSet
            Dim porFono, porEmail As Boolean


            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP
                .Inicializar()

                .AgregarParametro("@ot", Me.n_OT.Text, SqlDbType.Int)
                dsOT = .EjecutarQuery("ls_obtieneOtNumero")
            End With


            Dim SP2 As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP2
                .Inicializar()

                .AgregarParametro("@ot", Me.n_OT.Text, SqlDbType.Int)
                dsAvisafono = .EjecutarQuery("ys_obtieneavisafono")
            End With

            porFono = dsAvisafono.Tables(0).Rows.Item(0).Item(0).ToString()
            porEmail = dsAvisafono.Tables(0).Rows.Item(0).Item(1).ToString()
            porEstado = dsAvisafono.Tables(0).Rows.Item(0).Item(2).ToString()
            envioM = "no"
            If porFono = True And porEstado = "Can" Then
                If Me.n_OT.Text = "" Or Me.cb_anno.Text = "" Then


                Else

                    sAño = cb_anno.Text
                    defineTipo(sAño)
                    BuscaResultados()
                    envioM = "si"
                End If


            ElseIf porEmail = True And envioM = "no" Then
                If Me.n_OT.Text = "" Or Me.cb_anno.Text = "" Then


                Else

                    sAño = cb_anno.Text
                    defineTipo(sAño)
                    BuscaResultados()
                    envioM = "si"
                End If
            ElseIf porEstado = "Can" And envioM = "no" Then
                If Me.n_OT.Text = "" Or Me.cb_anno.Text = "" Then


                Else


                    sAño = cb_anno.Text
                    defineTipo(sAño)
                    BuscaResultados()
                End If
            Else
                MsgBox("Estado: " & porEstado)

            End If



        Catch ex As Exception
            MsgBox("Error :" & ex.Message.ToString, MsgBoxStyle.Information)


        End Try
    End Sub



    Sub BuscaResultados()

        Dim nompr, carpr, via, empn, ate, email, email2, sAño As String
        Dim srutadestPDF, porEstado As String
        Dim dsOT, dsAvisafono As New DataSet
        Dim porFono, porEmail As Boolean

        Dim BOLA As Object
        Dim entroNL As Integer
        Dim sRutaDestSuelo2 As String

        Dim num_com, f As Integer
        grilla_resultados.Rows.Clear()

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()

            .AgregarParametro("@ot", Me.n_OT.Text, SqlDbType.Int)
            dsOT = .EjecutarQuery("ls_obtieneOtNumero")
        End With

        Dim NlabD, NlabH, pro As String
        Dim i, r As Integer




        r = dsOT.Tables(0).Rows.Count

        While i < r

            pro = dsOT.Tables(0).Rows.Item(i).Item(0).ToString
            NlabD = dsOT.Tables(0).Rows.Item(i).Item(5).ToString
            NlabH = "-" & Microsoft.VisualBasic.Right(CStr(dsOT.Tables(0).Rows.Item(i).Item(6).ToString), 3)


            'Try

            Call archivos1(NlabD)
            Call archivos2(NlabD)
            Call archivos3(NlabD)
            Call archivos4(NlabD)
            Call archivos5(NlabD)
            Call archivos6(NlabD)
            Call archivos7(NlabD)
            Call archivos8(NlabD)
            Call archivos9(NlabD)
            Call archivos10(NlabD)
            Call archivos11(NlabD)


            i = i + 1
        End While
    End Sub
    Sub archivos1(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest1)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then
                vaEncontro = "si"
                If sRutaDest1 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest1 = names
                    srutadestPdf = Mid(sRutaDest1, 1, sRutaDest1.Length - 3) & "pdf"
                    If File.Exists(sRutaDest1) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest1})
                    End If
                Else
                    sRutaDest1 = names
                    srutadestPdf = Mid(sRutaDest1, 1, sRutaDest1.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest1) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest1})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos2(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest2)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest2 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest2 = names
                    srutadestPdf = Mid(sRutaDest2, 1, sRutaDest2.Length - 3) & "pdf"
                    If File.Exists(sRutaDest2) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest2})
                    End If
                Else
                    sRutaDest2 = names
                    srutadestPdf = Mid(sRutaDest2, 1, sRutaDest2.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest2) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest2})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos3(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest3)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest3 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest3 = names
                    srutadestPdf = Mid(sRutaDest3, 1, sRutaDest3.Length - 3) & "pdf"
                    If File.Exists(sRutaDest3) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest3})
                    End If
                Else
                    sRutaDest3 = names
                    srutadestPdf = Mid(sRutaDest3, 1, sRutaDest3.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest3) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest3})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos4(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest4)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest4 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest4 = names
                    srutadestPdf = Mid(sRutaDest4, 1, sRutaDest4.Length - 3) & "pdf"
                    If File.Exists(sRutaDest4) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest4})
                    End If
                Else
                    sRutaDest4 = names
                    srutadestPdf = Mid(sRutaDest4, 1, sRutaDest4.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest4) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest4})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos5(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest5)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest5 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest5 = names
                    srutadestPdf = Mid(sRutaDest5, 1, sRutaDest5.Length - 3) & "pdf"
                    If File.Exists(sRutaDest5) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest5})
                    End If
                Else
                    sRutaDest5 = names
                    srutadestPdf = Mid(sRutaDest5, 1, sRutaDest5.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest5) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest5})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos6(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest6)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest6 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest6 = names
                    srutadestPdf = Mid(sRutaDest6, 1, sRutaDest6.Length - 3) & "pdf"
                    If File.Exists(sRutaDest6) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest6})
                    End If
                Else
                    sRutaDest6 = names
                    srutadestPdf = Mid(sRutaDest6, 1, sRutaDest6.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest6) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest6})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos7(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest7)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest7 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest7 = names
                    srutadestPdf = Mid(sRutaDest7, 1, sRutaDest7.Length - 3) & "pdf"
                    If File.Exists(sRutaDest7) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest7})
                    End If
                Else
                    sRutaDest7 = names
                    srutadestPdf = Mid(sRutaDest7, 1, sRutaDest7.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest7) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest7})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos8(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest8)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest8 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest8 = names
                    srutadestPdf = Mid(sRutaDest8, 1, sRutaDest8.Length - 3) & "pdf"
                    If File.Exists(sRutaDest8) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest8})
                    End If
                Else
                    sRutaDest8 = names
                    srutadestPdf = Mid(sRutaDest8, 1, sRutaDest8.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest8) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest8})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos9(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest9)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest9 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest9 = names
                    srutadestPdf = Mid(sRutaDest9, 1, sRutaDest9.Length - 3) & "pdf"
                    If File.Exists(sRutaDest9) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest9})
                    End If
                Else
                    sRutaDest9 = names
                    srutadestPdf = Mid(sRutaDest9, 1, sRutaDest9.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest9) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest9})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos10(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest10)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest10 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest10 = names
                    srutadestPdf = Mid(sRutaDest10, 1, sRutaDest10.Length - 3) & "pdf"
                    If File.Exists(sRutaDest10) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest10})
                    End If
                Else
                    sRutaDest10 = names
                    srutadestPdf = Mid(sRutaDest10, 1, sRutaDest10.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest10) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest10})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub archivos11(ByVal nlabD As String)
        Dim arr(), arr2(), vaEncontro, vaTamano, vaTamanoNlab, vaRuta, vaPatch As String
        Dim vaTot As String
        Dim vaResto As Integer
        Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Archivo = My.Computer.FileSystem.GetFiles(sRutaDest11)
        vaEncontro = "no"
        For Each names As String In Archivo
            vaTamanoNlab = nlabD.Length

            arr = Split(names, "\")
            arr2 = Split(arr(3).ToString, "-")
            vaRuta = Mid(arr2(0), 1)
            vaTamano = vaRuta.Length

            If vaTamano < 7 Then
                vaPatch = vaRuta
            Else
                vaResto = vaRuta.Length - vaTamanoNlab
                vaTot = Mid(vaRuta, 1, vaRuta.Length - vaResto)
                vaPatch = vaTot
            End If
            If vaPatch = nlabD Then

                vaEncontro = "si"
                If sRutaDest11 = "F:\Mis Documentos\" + cb_anno.Text + " Fitopatologicos PDF\" Then
                    sRutaDest11 = names
                    srutadestPdf = Mid(sRutaDest11, 1, sRutaDest11.Length - 3) & "pdf"
                    If File.Exists(sRutaDest11) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest11})
                    End If
                Else
                    sRutaDest11 = names
                    srutadestPdf = Mid(sRutaDest11, 1, sRutaDest11.Length - 3) & "pdf"
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    If File.Exists(sRutaDest11) Then
                        grilla_resultados.Rows.Add(New String() {sRutaDest11})
                    End If
                End If

            End If
        Next
        If vaEncontro = "no" Then

        End If
    End Sub
    Sub corrigeMargen(ByVal va1 As String)
        
        Dim oExcel As Excel.Application
        Dim oBook As Excel.Workbook
        Dim oBooks As Excel.Workbooks
        Dim hoja_excel As Excel.Worksheet

        'Start Excel y abrir el doc
        oExcel = CreateObject("Excel.Application")
        'oExcel.Visible = True
        oBooks = oExcel.Workbooks
        oBook = oBooks.Open(va1)
        hoja_excel = oExcel.Worksheets(1)
        hoja_excel.Activate()
        'Run the macros.

        With oExcel.ActiveSheet.PageSetup

            .LeftMargin = oExcel.Application.InchesToPoints(0.748031496062992)
            .RightMargin = oExcel.Application.InchesToPoints(0)
            .TopMargin = oExcel.Application.InchesToPoints(0)
            .BottomMargin = oExcel.Application.InchesToPoints(0)
            .HeaderMargin = oExcel.Application.InchesToPoints(0)
            .FooterMargin = oExcel.Application.InchesToPoints(0)

        End With
        oExcel.Application.PrintCommunication = True

        oExcel.ActiveWorkbook.Save() 'guarda solamente, no pregunta si desea reemplazar
        oBook.Close(False)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
        oBook = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
        oBooks = Nothing
        oExcel.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
        oExcel = Nothing

    End Sub

    Private Sub btn_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enviar.Click

        Dim mOutLookApp As Outlook.Application
        Dim mNameSpace As Outlook.NameSpace
        Dim mItem As Outlook.MailItem
        Dim colAttach As Outlook.Attachments
        Dim l_Attach As Outlook.Attachment
        Dim dsOT As New DataSet
        Dim num_com, f As Integer
        Dim va1 As String

        Dim nompr, carpr, via, empn, ate, email, email2, sAño, archivoPDF As String

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()

            .AgregarParametro("@ot", Me.n_OT.Text, SqlDbType.Int)
            dsOT = .EjecutarQuery("ls_obtieneOtNumero")
        End With

        nompr = dsOT.Tables(0).Rows.Item(0).Item(0).ToString
        ate = dsOT.Tables(0).Rows.Item(0).Item(1).ToString
        Call control_nombre(ate)
        If ate <> "" Then ate = "Atención: " & ate & Chr(13) Else ate = ""
        via = ""
        For f = 1 To Len(nompr)
            carpr = Mid(nompr, f, 1)
            If carpr = "." Then carpr = " "
            via = via + carpr
        Next
        email = dsOT.Tables(0).Rows.Item(0).Item(2).ToString
        email2 = dsOT.Tables(0).Rows.Item(0).Item(3).ToString
        mOutLookApp = New Outlook.Application
        mNameSpace = mOutLookApp.GetNamespace("MAPI")
        mItem = mOutLookApp.CreateItem(0)
        mItem.To = email
        mItem.CC = email2
        mItem.Subject = "Resultado Análisis Agrolab Ltda."
        mItem.Body = "Señor(es): " & Chr(13) & _
                     nompr & Chr(13) & _
                     ate & Chr(13) & _
                     "Adjunto resultado de análisis solicitado." & Chr(13) & _
                     "Atentamente," & Chr(13) & Chr(13) & _
                     "Agrolab Ltda." & Chr(13) & Chr(13) & _
                     "Fono   : (02) 225 8087" & Chr(13) & _
                     "e-mail : secreagro@agrolab.cl" & Chr(13) & _
                     "Web    : www.agrolab.cl" & Chr(13) & Chr(13)

        colAttach = mItem.Attachments


        For Each row As Object In Me.grilla_resultados.Rows


            If CBool(row.Cells("PDF").Value) = True Then
                va1 = CStr(row.cells("RutaResultado").value)
                corrigeMargen(va1)
                archivoPDF = Mid(va1, 1, va1.Length - 3) & "pdf"

                'If File.Exists(archivoPDF) Then
                '    File.Delete(archivoPDF)
                'End If

                ConvertirXLSaPDF(va1, archivoPDF)

                If File.Exists(archivoPDF) Then
                    l_Attach = colAttach.Add(archivoPDF)
                End If
            Else
                va1 = CStr(row.cells("RutaResultado").value)
                'va1 = Mid(va1, 1, va1.Length - 3) & "xls"
                l_Attach = colAttach.Add(va1)

            End If



        Next
        mItem.Display()


        With SP

            .Inicializar()
            .AgregarParametro("@ot", Me.n_OT.Text, SqlDbType.Int)
            .EjecutarQuery("ls_actualizaEstadoOtDesp")

        End With

    End Sub
    Private Sub ConvertirXLSaPDF(ByVal sRutaDest As String, ByVal srutadestPDF As String)

        Dim excelApplication As ApplicationClass = New ApplicationClass()
        Dim excelWorkbook As Workbook = Nothing
        Dim paramSourceBookPath As String = sRutaDest

        Dim paramExportFilePath As String = srutadestPDF
        Dim paramExportFormat As XlFixedFormatType = XlFixedFormatType.xlTypePDF
        Dim paramExportQuality As XlFixedFormatQuality = XlFixedFormatQuality.xlQualityStandard
        Dim paramOpenAfterPublish As Boolean = False
        Dim paramIncludeDocProps As Boolean = True
        Dim paramIgnorePrintAreas As Boolean = False
        Dim paramFromPage As Object = Type.Missing
        Dim paramToPage As Object = Type.Missing

        Try
            ' Open the source workbook.
            excelWorkbook = excelApplication.Workbooks.Open(paramSourceBookPath)

            ' Save it in the target format.
            If Not excelWorkbook Is Nothing Then
                excelWorkbook.ExportAsFixedFormat(paramExportFormat, _
                    paramExportFilePath, paramExportQuality, _
                    paramIncludeDocProps, paramIgnorePrintAreas, _
                    paramFromPage, paramToPage, paramOpenAfterPublish)
            End If
        Catch ex As Exception
            ' Respond to the error.
        Finally
            ' Close the workbook object.
            If Not excelWorkbook Is Nothing Then
                excelWorkbook.Close(False)
                excelWorkbook = Nothing
            End If

            ' Quit Excel and release the ApplicationClass object.
            If Not excelApplication Is Nothing Then
                excelApplication.Quit()
                excelApplication = Nothing
            End If

            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try

    End Sub
    Private Sub n_OT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles n_OT.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscar.Select()
        End If
    End Sub

    Private Sub Frm_EnviaResultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cb_anno.Text = Year(Today)
    End Sub

    Private Sub cb_tipoMuestra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.cb_anno.Select()
        End If
    End Sub

    Private Sub cb_anno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_anno.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscar.Select()
        End If
    End Sub

    Private Sub ElPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class