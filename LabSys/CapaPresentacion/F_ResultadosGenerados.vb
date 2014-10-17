Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Public Class F_ResultadosGenerados

    Private Sub F_ResultadosGenerados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()

        dsInicial = cd.EjecutarQuery("ys_ObtieneGenerados")
        dt = dsInicial.Tables(0)


        Me.GrillaResultadosGenerados.DataSource = dt
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()

        dsInicial = cd.EjecutarQuery("ys_ObtieneGenerados")
        dt = dsInicial.Tables(0)


        Me.GrillaResultadosGenerados.DataSource = dt
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDGV.Print_DataGridView(GrillaResultadosGenerados)
    End Sub

    Private Sub GrillaResultadosGenerados_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaResultadosGenerados.CellDoubleClick
        Dim numFila As Integer

        numFila = Me.GrillaResultadosGenerados.CurrentCell.RowIndex
        Orden_Trabajo_Bus = Me.GrillaResultadosGenerados.Rows(numFila).Cells(0).Value
        lbl_ot.Text = Orden_Trabajo_Bus
        Dim ds As New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()

            .AgregarParametro("@ot", Orden_Trabajo_Bus, SqlDbType.Int)
            ds = .EjecutarQuery("ys_EstadosParaEnvio")
        End With
        txt_Ana.Text = ds.Tables(0).Rows.Item(0).Item(0).ToString()
        txt_Pag.Text = ds.Tables(0).Rows.Item(0).Item(1).ToString()
        txt_Fac.Text = ds.Tables(0).Rows.Item(0).Item(2).ToString()
    End Sub

    Private Sub CmdOrdenTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOrdenTrabajo.Click
        Dim datos As New DataSet
        Dim query As String
        Tipo_Ingreso_OT = "Consulta"
        If Orden_Trabajo_Bus = 0 Then
            MsgBox("Orden : " & Orden_Trabajo_Bus & " no existe")
        Else
            Dim Form_Aux As New F_OrdenTrabajo
            Form_Aux.Owner = Me
            Form_Aux.ShowDialog()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        Try


            Dim mOutLookApp As Outlook.Application
            Dim mNameSpace As Outlook.NameSpace
            Dim mItem As Outlook.MailItem
            Dim colAttach As Outlook.Attachments
            Dim l_Attach As Outlook.Attachment
            Dim srutadestPDF, porEstado, envioM As String
            Dim dsOT, dsAvisafono As New DataSet
            Dim porFono, porEmail As Boolean


            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP
                .Inicializar()

                .AgregarParametro("@ot", Orden_Trabajo_Bus, SqlDbType.Int)
                dsOT = .EjecutarQuery("ls_obtieneOtNumero")
            End With

            Dim SP2 As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP2
                .Inicializar()

                .AgregarParametro("@ot", Orden_Trabajo_Bus, SqlDbType.Int)
                dsAvisafono = .EjecutarQuery("ys_obtieneavisafono")
            End With

            porFono = dsAvisafono.Tables(0).Rows.Item(0).Item(0).ToString()
            porEmail = dsAvisafono.Tables(0).Rows.Item(0).Item(1).ToString()
            porEstado = dsAvisafono.Tables(0).Rows.Item(0).Item(2).ToString()
            envioM = "no"
            If porFono = True And porEstado = "Can" Then

                CargaRutas()
                envioM = "si"

            ElseIf porEmail = True And envioM = "no" Then

                CargaRutas()
                envioM = "si"
            ElseIf porEstado = "Can" And envioM = "no" Then
                CargaRutas()
            Else
                MsgBox("Estado: " & porEstado)

            End If



        Catch ex As Exception
            MsgBox("Error :" & ex.Message.ToString, MsgBoxStyle.Information)


        End Try

    End Sub
    Sub CargaRutas()

        Dim nompr, carpr, via, empn, ate, email, email2, sAño As String
        Dim srutadestPDF, porEstado As String
        Dim dsOT, dsAvisafono As New DataSet
        Dim porFono, porEmail As Boolean

        Dim BOLA As Object
        Dim entroNL As Integer
        Dim sRutaDestSuelo2 As String

        Dim num_com, f As Integer
        lbx_lista.Items.Clear()

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()

            .AgregarParametro("@ot", Orden_Trabajo_Bus, SqlDbType.Int)
            dsOT = .EjecutarQuery("ls_obtieneOtNumero")
        End With

        Dim sRutaDest, NlabD, NlabH, pro As String
        Dim i, r, total1, tmu, anac As Integer

        r = dsOT.Tables(0).Rows.Count



        While i < r

            pro = dsOT.Tables(0).Rows.Item(i).Item(0).ToString
            NlabD = dsOT.Tables(0).Rows.Item(i).Item(5).ToString
            NlabH = "-" & Microsoft.VisualBasic.Right(CStr(dsOT.Tables(0).Rows.Item(i).Item(6).ToString), 3)
            sAño = Year(Today)
            tmu = CInt(dsOT.Tables(0).Rows.Item(i).Item(4))
            anac = CInt(dsOT.Tables(0).Rows.Item(i).Item(7))

            If tmu = 1000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Foliar-Labsys\"
            ElseIf tmu = 2000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Frutos-Labsys\"
            ElseIf tmu = 3000 Then
                If anac > 3600 And anac < 3623 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Bactereologicos-Labsys\"
                Else
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Agua-Labsys\"
                End If
            ElseIf tmu = 4000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Suelo-Labsys\"
            ElseIf tmu = 5000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".FertQuimicos-Labsys\"
            ElseIf tmu = 6000 Then
                If anac > 6800 And anac < 6819 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + " Guanos Bacteriologicos\"
                ElseIf anac = 6001 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + " Guanos Bacteriologicos\"
                Else
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".FertOrganicos-Labsys\"
                End If
            ElseIf tmu = 8700 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Yemas-Labsys\"
            ElseIf tmu = 8758 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Nematodos-Labsys\"
            End If



            ' entroNL = 0

            'Try
            Dim arr(), arr2() As String
            Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            ' busca "Hola mundo" en un solo nivel ( SearchTopLevelOnly ) en el directorio c:   
            Archivo = My.Computer.FileSystem.GetFiles(sRutaDest)
            ' recorre la lista  
            Dim sum As Integer
            sum = 0
            For Each names As String In Archivo
                arr = Split(names, "\")
                arr2 = Split(arr(3).ToString, "-")
                If arr2.Length = 1 Then
                    arr2 = Split(arr(3).ToString, " ")
                End If

                If NlabD = arr2(0).ToString Then

                    sRutaDest = names
                    'If sRutaDest = sRutaDest2 Then
                    '    MsgBox("ya se ingreso")
                    'End If
                    srutadestPDF = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "pdf"
                    If File.Exists(srutadestPDF) Then
                        File.Delete(srutadestPDF)
                    End If
                    'sRutaDest2 = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "xls"
                    'guardaRegistro = "nada"
                    If File.Exists(sRutaDest) Then '######### si existe(
                        lbx_lista.Items.Add(sRutaDest)

                    Else '###############################si no existe(
                        sAño = sAño - 1

                        If tmu = 1000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Foliar-Labsys\"
                        ElseIf tmu = 2000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Frutos-Labsys\"
                        ElseIf tmu = 3000 Then
                            If anac > 3600 And anac < 3623 Then
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Bactereologicos-Labsys\"
                            Else
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Agua-Labsys\"
                            End If
                        ElseIf tmu = 4000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Suelo-Labsys\"
                        ElseIf tmu = 5000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".FertQuimicos-Labsys\"
                        ElseIf tmu = 6000 Then
                            If anac > 6800 And anac < 6819 Then
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Guanos Bacteriologicos\"
                            ElseIf anac = 6001 Then
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Guanos Bacteriologicos\"
                            Else
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".FertOrganicos-Labsys\"
                            End If
                        ElseIf tmu = 8700 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Yemas-Labsys\"
                        ElseIf tmu = 8758 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Nematodos-Labsys\"
                        End If




                        ' sRutaDest = names
                        srutadestPDF = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "pdf"

                        sRutaDest = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "xls"
                        If File.Exists(sRutaDest) Then
                            lbx_lista.Items.Add(sRutaDest)

                        End If
                    End If



                End If '######### fin si existe)
            Next

            'srutadestPDF = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "pdf"

            ' Catch ex As Exception

            'End Try




            i = i + 1
        End While

        pnl_Rutas.Visible = True


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
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

            .AgregarParametro("@ot", Orden_Trabajo_Bus, SqlDbType.Int)
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


        For Each item As Object In lbx_lista.SelectedItems
            If MsgBox("Desea adjuntar el resultado en PDF", MsgBoxStyle.YesNo, "Adjuntando...") = MsgBoxResult.Yes Then



                va1 = item
                corrigeMargen(va1)
                archivoPDF = Mid(va1, 1, va1.Length - 3) & "pdf"

                If File.Exists(archivoPDF) Then
                    File.Delete(archivoPDF)
                End If

                ConvertirXLSaPDF(va1, archivoPDF)

                If File.Exists(archivoPDF) Then
                    l_Attach = colAttach.Add(archivoPDF)
                End If

            Else

                va1 = item
                va1 = Mid(va1, 1, va1.Length - 3) & "xls"
                l_Attach = colAttach.Add(va1)

            End If

        Next
        mItem.Display()

        With SP

            .Inicializar()
            .AgregarParametro("@ot", Orden_Trabajo_Bus, SqlDbType.Int)
            .EjecutarQuery("ls_actualizaEstadoOtDesp")

        End With
        pnl_Rutas.Visible = False

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
        oBook.CheckCompatibility = False
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

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.lbx_lista.Items.Clear()
        Me.pnl_Rutas.Visible = False
    End Sub
End Class