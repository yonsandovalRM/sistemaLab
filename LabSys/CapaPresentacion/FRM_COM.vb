Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO


Public Class FRM_COM
    Private Fila_grilla, codigo_antiguo, TxtDeDG, Muestra, ffi, Columna34, Num_Muestra, PreAna1, PreAna2, PreAna3, le, Fila_Cod, Columna_Cod As Integer
    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@desde", TxtBusOtDesde.Text, SqlDbType.Int)
        cd.AgregarParametro("@hasta", TxtBusOtHasta.Text, SqlDbType.Int)
        dsInicial = cd.EjecutarQuery("COM_X_NOT")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt


    End Sub

    Private Sub TxtBusOtDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusOtDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtBusOtHasta.Focus()
            Me.TxtBusOtHasta.Text = Me.TxtBusOtDesde.Text
        End If
    End Sub

    Private Sub TxtBusOtHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusOtHasta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_Aceptar.Focus()

        End If
    End Sub

    Private Sub FRM_COM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AGROLAB_PRUEBADataSet2.COM' Puede moverla o quitarla según sea necesario.
        'Me.COMTableAdapter.Fill(Me.AGROLAB_PRUEBADataSet2.COM)

    End Sub
    Sub adjuntaPDF()

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

            .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
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

        pnl_resultados.Visible = True


    End Sub

    Private Sub grilla_COM_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla_COM.CellDoubleClick
        Dim numFila, NumOOt As Integer
        Dim DbMan As DbManager
        Dim query As String
        'Try
        '    Me.Button6.Visible = True
        numFila = Me.grilla_COM.CurrentCell.RowIndex
        Orden_Trabajo_Bus = Me.grilla_COM.Rows(numFila).Cells(0).Value
        Orden_Trabajo = Orden_Trabajo_Bus
        Me.txOTSeleccionada.Text = Orden_Trabajo
        If Tipo_Ingreso_OT = "Resultados" Then
            ResultadosMuestrayOrden = Orden_Trabajo_Bus
            ResultadosCantidad = Me.grilla_COM.Rows(numFila).Cells(8).Value
            ResultadosNLab = Me.grilla_COM.Rows(numFila).Cells(9).Value
            Me.Close()
        End If
        If Es_Revision = "S" Then
            'Dim Form_Aux As New Frm_Resultados_Anteriores : Form_Aux.Show()
            GoTo SaltoxRevision
        End If
        '    Select Case Me.grilla_COM.Rows(numFila).Cells(7).Value
        '        Case "FOL"
        '            CodMuestraRev = 1000
        '        Case "+TEJ"
        '            CodMuestraRev = 2000
        '        Case "AGU"
        '            CodMuestraRev = 3000
        '        Case "SUE"
        '            CodMuestraRev = 4000
        '        Case "FORG"
        '            CodMuestraRev = 5000
        '        Case "FQUI"
        '            CodMuestraRev = 6000
        '        Case "VEN"
        '            CodMuestraRev = 7000
        '        Case "OTRO"
        '            CodMuestraRev = 8000
        '    End Select
        '    Ant_NLabDesde = Me.grilla_COM.Rows(numFila).Cells(9).Value
        '    Ant_NLabHasta = Me.grilla_COM.Rows(numFila).Cells(9).Value + Me.grilla_COM.Rows(numFila).Cells(8).Value - 1
        '    Num_Factura = Me.grilla_COM.Rows(numFila).Cells(13).Value
        '    Select Case Me.grilla_COM.Rows(numFila).Cells(7).Value
        '        Case "FOL"
        '            Muestra = 1000
        '            Cjto_Orden1.Tables("OT_FOLIAR_ANTECEDENTES").Clear()
        '            DbMan = New DbManager("OT_FOLIAR_ANTECEDENTES", Conexion1)
        '            query = "Select * from OT_FOLIAR_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
        '            DbMan.Selecccionar(Cjto_Orden1, query)
        '        Case "+TEJ"
        '            Muestra = 2000
        '            Cjto_Orden1.Tables("OT_TEJIDOS_ANTECEDENTES").Clear()
        '            DbMan = New DbManager("OT_TEJIDOS_ANTECEDENTES", Conexion1)
        '            query = "Select * from OT_TEJIDOS_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
        '            DbMan.Selecccionar(Cjto_Orden1, query)
        '        Case "AGUA"
        '            Muestra = 3000
        '            Cjto_Orden1.Tables("OT_AGUA_ANTECEDENTES").Clear()
        '            DbMan = New DbManager("OT_AGUA_ANTECEDENTES", Conexion1)
        '            query = "Select * from OT_AGUA_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
        '            DbMan.Selecccionar(Cjto_Orden1, query)
        '        Case "SUE"
        '            Muestra = 4000
        '            Cjto_Orden1.Tables("OT_SUELO_ANTECEDENTES").Clear()
        '            DbMan = New DbManager("OT_SUELO_ANTECEDENTES", Conexion1)
        '            query = "Select * from OT_SUELO_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
        '            DbMan.Selecccionar(Cjto_Orden1, query)
        '    End Select
        'Catch ex As Exception
        'End Try




        GrbModificacion.Visible = True
        GrbModificacion.Location = New System.Drawing.Point(0, 738)
        GrbModificacion.BringToFront()

SaltoxRevision:


        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@numero", Me.grilla_COM.Rows(numFila).Cells(13).Value, SqlDbType.Int)
        dsInicial = cd.EjecutarQuery("COM_ESTADOFACTURA")
        dt = dsInicial.Tables(0)

        If dt.Rows.Count > 0 Then
            Me.txt_EstadoFac.Text = dt.Rows(0).Item(0).ToString
        Else
            Me.txt_EstadoFac.Text = "Sin Factura"
        End If

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

                .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
                dsOT = .EjecutarQuery("ls_obtieneOtNumero")
            End With

            Dim SP2 As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP2
                .Inicializar()

                .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
                dsAvisafono = .EjecutarQuery("ys_obtieneavisafono")
            End With

            porFono = dsAvisafono.Tables(0).Rows.Item(0).Item(0).ToString()
            porEmail = dsAvisafono.Tables(0).Rows.Item(0).Item(1).ToString()
            porEstado = dsAvisafono.Tables(0).Rows.Item(0).Item(2).ToString()
            envioM = "no"
            If porFono = True And porEstado = "Can" Then

                adjuntaPDF()
                envioM = "si"

            ElseIf porEmail = True And envioM = "no" Then

                adjuntaPDF()
                envioM = "si"
            ElseIf porEstado = "Can" And envioM = "no" Then
                adjuntaPDF()
            Else
                MsgBox("Estado: " & porEstado)

            End If



        Catch ex As Exception
            MsgBox("Error :" & ex.Message.ToString, MsgBoxStyle.Information)


        End Try


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

            .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
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
            .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
            .EjecutarQuery("ls_actualizaEstadoOtDesp")

        End With

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
        pnl_resultados.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GrbModificacion.Visible = False
        Me.pnl_resultados.Visible = False
        lbx_lista.Items.Clear()
    End Sub

    Private Sub DtpFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFechaDesde.ValueChanged
        TxtBusFechaDesde.Text = DtpFechaDesde.Text
    End Sub

    Private Sub TxtBusProductor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusProductor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaProductor.Focus()
        End If
    End Sub

    Private Sub btn_buscaProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaProductor.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@PRODUCTOR", Me.TxtBusProductor.Text, SqlDbType.VarChar)
        dsInicial = cd.EjecutarQuery("COM_X_PRODUCTOR")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt


    End Sub

    Private Sub CmdAgregarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregarAnalisis.Click
        Dim datos As New DataSet
        Dim query As String
        Tipo_Ingreso_OT = "Agrega"
        If Orden_Trabajo_Bus = 0 Then
            MsgBox("Orden : " & Orden_Trabajo_Bus & " no existe")
        Else
            Dim Form_Aux As New F_OrdenTrabajo
            Form_Aux.Owner = Me
            Form_Aux.tbOT.SelectedTab = Form_Aux.tbOT.TabPages(1)

            Form_Aux.ShowDialog()
        End If
    End Sub

    Private Sub TxtBusEmpresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusEmpresa.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaEmpresa.Focus()
        End If
    End Sub

    Private Sub TxtBusLabDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusLabDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtBusLabHasta.Text = Me.TxtBusLabDesde.Text
            Me.TxtBusLabHasta.Focus()
        End If
    End Sub

    Private Sub TxtBusLabHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusLabHasta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaNlab.Focus()
        End If
    End Sub

    Private Sub btn_buscaNlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaNlab.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@desde", Me.TxtBusLabDesde.Text, SqlDbType.Int)
        cd.AgregarParametro("@hasta", Me.TxtBusLabHasta.Text, SqlDbType.Int)
        dsInicial = cd.EjecutarQuery("COM_X_NLAB")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt

    End Sub

    Private Sub TxtBusFechaDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusFechaDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaFecha.Focus()
        End If
    End Sub

    Private Sub btn_buscaFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaFecha.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@desde", Me.TxtBusFechaDesde.Text, SqlDbType.DateTime)
        dsInicial = cd.EjecutarQuery("COM_X_FECHA")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub

    Private Sub btn_buscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaEmpresa.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@EMPRESA", Me.TxtBusEmpresa.Text, SqlDbType.VarChar)
        dsInicial = cd.EjecutarQuery("COM_X_EMPRESA")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub

    Private Sub TxtBusRemite_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusRemite.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaRemite.Focus()
        End If
    End Sub

    Private Sub btn_buscaRemite_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_buscaRemite.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@REMITE", Me.TxtBusRemite.Text, SqlDbType.VarChar)
        dsInicial = cd.EjecutarQuery("COM_X_REMITE")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub

    Private Sub TxtBusFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaFactura.Focus()
        End If
    End Sub

    Private Sub btn_buscaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaFactura.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@NUMERO", Me.TxtBusFactura.Text, SqlDbType.Int)
        dsInicial = cd.EjecutarQuery("COM_X_FACTURA")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub

    Private Sub TxtBusRut_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusRut.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaRutPro.Focus()
        End If
    End Sub

    Private Sub btn_buscaRutPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaRutPro.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@RUT", Me.TxtBusRut.Text, SqlDbType.VarChar)
        dsInicial = cd.EjecutarQuery("COM_X_RUTPRO")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub

    Private Sub TxtBusRutFact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusRutFact.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaRutFac.Focus()
        End If
    End Sub

    Private Sub btn_buscaRutFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaRutFac.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@RUT", Me.TxtBusRutFact.Text, SqlDbType.VarChar)
        dsInicial = cd.EjecutarQuery("COM_X_RUTFAC")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TxtBusEmpresa.Text = ""
        TxtBusFechaDesde.Text = ""
        TxtBusLabDesde.Text = ""
        TxtBusLabHasta.Text = ""
        TxtBusOtDesde.Text = ""
        TxtBusOtHasta.Text = ""
        TxtBusProductor.Text = ""
        TxtBusRemite.Text = ""
        TxtBusRut.Text = ""
        TxtBusRutFact.Text = ""
        Me.CBBusMuestra.Text = ""
        TxtBusFactura.Text = ""

  

    
    End Sub





    Private Sub FRM_COM_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim myvalor As String
        'MsgBox(e.KeyCode)
        'busca por orden de trabajo ####################################
        If e.KeyCode = 112 Then
            myvalor = InputBox("Ingrese N°:", "Buscar Por Orden", "0")

            If myvalor <> "" Then
                Dim cd As New CapaDato
                Dim dsInicial As New DataSet
                Dim dt As New System.Data.DataTable

                cd.Inicializar()
                cd.AgregarParametro("@desde", myvalor, SqlDbType.Int)
                cd.AgregarParametro("@hasta", myvalor, SqlDbType.Int)
                dsInicial = cd.EjecutarQuery("COM_X_NOT")
                dt = dsInicial.Tables(0)


                Me.grilla_COM.DataSource = dt

            End If
           
        End If
        'busca por orden de trabajo ####################################

        'busca por rut productor ####################################
        If e.KeyCode = 113 Then
            myvalor = InputBox("Ingrese RUT:", "Buscar Por Rut Productor", "0")

            If myvalor <> "" Then
                Dim cd As New CapaDato
                Dim dsInicial As New DataSet
                Dim dt As New System.Data.DataTable

                cd.Inicializar()
                cd.AgregarParametro("@RUT", myvalor, SqlDbType.VarChar)
                dsInicial = cd.EjecutarQuery("COM_X_RUTPRO")
                dt = dsInicial.Tables(0)


                Me.grilla_COM.DataSource = dt

            End If

        End If

        'busca por rut productor ####################################


    End Sub

    Private Sub btn_buscaTipoMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaTipoMuestra.Click
        Dim vaTipo As String
        If Me.CBBusMuestra.Text = "FITOPATOLOGIA" Then
            vaTipo = "Fito"
        ElseIf Me.CBBusMuestra.Text = "FOLIAR" Then
            vaTipo = "Fol"
        ElseIf Me.CBBusMuestra.Text = "AGUA" Then
            vaTipo = "Agu"
        ElseIf Me.CBBusMuestra.Text = "SUELO" Then
            vaTipo = "Sue"
        ElseIf Me.CBBusMuestra.Text = "FERT. QUIMICO" Then
            vaTipo = "FQui"
        ElseIf Me.CBBusMuestra.Text = "FERT. ORGANICO" Then
            vaTipo = "FOrg"
        ElseIf Me.CBBusMuestra.Text = "OTROS" Then
            vaTipo = "Otro"
        ElseIf Me.CBBusMuestra.Text = "TEJIDO" Then
            vaTipo = "Tej"
        End If
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@desde", dt_Tipo.Text, SqlDbType.DateTime)
        cd.AgregarParametro("@Tipo", vaTipo, SqlDbType.NVarChar)
        dsInicial = cd.EjecutarQuery("COM_X_TIPO")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub

 
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.PanelTipo.Visible = True
        Else
            Me.PanelTipo.Visible = False
        End If
    End Sub

    Private Sub TxtBusLabDesdeY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusLabDesdeY.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtBusLabHastaY.Text = Me.TxtBusLabDesdeY.Text
            Me.TxtBusLabHastaY.Focus()
        End If
    End Sub

    Private Sub TxtBusLabHastaY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusLabHastaY.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_buscaNlabY.Focus()
        End If
    End Sub

    Private Sub btn_buscaNlabY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaNlabY.Click
        Dim cd As New CapaDato
        Dim dsInicial As New DataSet
        Dim dt As New System.Data.DataTable

        cd.Inicializar()
        cd.AgregarParametro("@desde", Me.TxtBusLabDesdeY.Text, SqlDbType.Int)
        cd.AgregarParametro("@hasta", Me.TxtBusLabHastaY.Text, SqlDbType.Int)
        dsInicial = cd.EjecutarQuery("COM_X_NLAB_YEMAS")
        dt = dsInicial.Tables(0)


        Me.grilla_COM.DataSource = dt
    End Sub


End Class