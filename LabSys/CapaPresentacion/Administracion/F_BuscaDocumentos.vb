Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO

Public Class F_BuscaDocumentos

    Private Sub chFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFecha.CheckedChanged
        If Me.chFecha.Checked = True Then
            Me.dtDesde.Enabled = True
            Me.dtHasta.Enabled = True
        Else
            Me.dtDesde.Enabled = False
            Me.dtHasta.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        'Funcion para limpiar y activar controles
        Me.chFecha.Checked = False
        Me.txNFactura.Text = ""
        Me.txNlabdesde.Text = ""
        Me.txNlabHasta.Text = ""
        Me.txOT.Text = ""
        Me.txOTH.Text = ""
        Me.txRutEmpresa.Text = ""
        Me.txRutProductor.Text = ""
        Me.cbEmpresa.Text = ""
        Me.cbProductor.Text = ""
        Me.RbAgua.Checked = False
        Me.rbFertOrg.Checked = False
        Me.rbFertQui.Checked = False
        Me.rbFoliar.Checked = False
        Me.rbNematodos.Checked = False
        Me.rbSuelo.Checked = False
        Me.rbTejidos.Checked = False
        Me.rbYemas.Checked = False

    End Sub

    Private Sub F_BuscaDocumentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cuando carga el mantenedor llena los combos productor, empresas

        Call llenaCBProductor()
        Call llenaCBEmpresa()

        'controla los radio buttons
        Me.RbAgua.Checked = False
        Me.rbFertOrg.Checked = False
        Me.rbFertQui.Checked = False
        Me.rbFoliar.Checked = False
        Me.rbNematodos.Checked = False
        Me.rbSuelo.Checked = False
        Me.rbTejidos.Checked = False
        Me.rbYemas.Checked = False
    End Sub

    Private Sub llenaCBProductor() 'funcion que llena el combo productor
        Try
            Dim cn As New CapaNegocio
            Dim ds As New DataSet
            Dim dt As New Data.DataTable

            ds = cn.ObtieneProductor()
            dt = ds.Tables(0)

            Me.cbProductor.DataSource = dt
            Me.cbProductor.DisplayMember = "nombre"
            Me.cbProductor.ValueMember = "rut"
        Catch ex As Exception
            MsgBox("Se ha producido un error en el sub 'llenaCBProductor', error: " & ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub llenaCBEmpresa() 'funcion que llena el combo empresa
        Try
            Dim cn As New CapaNegocio
            Dim ds As New DataSet
            Dim dt As New Data.DataTable
            dt.Columns.Add("empresa")
            Dim dr As DataRow

            dr = dt.NewRow()
            dr("empresa") = "Seleccionar Empresa"
            dt.Rows.Add(dr)


            ds = cn.ObtieneEmpresa()
            dt = ds.Tables(0)

            Me.cbEmpresa.DataSource = dt
            Me.cbEmpresa.DisplayMember = "empresa"
            Me.cbEmpresa.ValueMember = "empresa"

        Catch ex As Exception
            MsgBox("Se ha producido un error en el sub 'llenaCBEmpresa', error: " & ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Me.dgBusqueda.Rows.Clear()

        Dim tmu, ot, otH, fac, Ndesde, Nhasta As Integer
        Dim cd As New CapaDato
        Dim ds As New DataSet

        If Me.RbAgua.Checked = True Then
            tmu = 3000
        ElseIf Me.rbFertOrg.Checked = True Then
            tmu = 6000
        ElseIf Me.rbFertQui.Checked = True Then
            tmu = 5000
        ElseIf Me.rbFoliar.Checked = True Then
            tmu = 1000
        ElseIf Me.rbNematodos.Checked = True Then
            tmu = 8758
        ElseIf Me.rbSuelo.Checked = True Then
            tmu = 4000
        ElseIf Me.rbTejidos.Checked = True Then
            tmu = 2000
        ElseIf Me.rbYemas.Checked = True Then
            tmu = 8700
        End If

        If Me.txNFactura.Text = "" Then
            fac = 0
        Else
            fac = CInt(Me.txNFactura.Text)
        End If

        If Me.txNlabdesde.Text = "" Then
            Ndesde = 0
        Else
            Ndesde = CInt(Me.txNlabdesde.Text)
        End If

        If Me.txNlabHasta.Text = "" Then
            Nhasta = 0
        Else
            Nhasta = CInt(Me.txNlabHasta.Text)
        End If


        If Me.chFecha.Checked = True Then
            'con fecha
            cd.Inicializar()
            cd.AgregarParametro("@NotD", Me.txOT.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@NotH", Me.txOTH.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@Productor", Me.cbProductor.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@rutProductor", Me.txRutProductor.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@Empresa", Me.cbEmpresa.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@rutFac", Me.txRutEmpresa.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@tmu", tmu, SqlDbType.Int)
            cd.AgregarParametro("@NlabDesde", Ndesde, SqlDbType.Int)
            cd.AgregarParametro("@NlabHasta", Nhasta, SqlDbType.Int)
            cd.AgregarParametro("@Factura", fac, SqlDbType.Int)
            cd.AgregarParametro("@fDesde", Me.dtDesde.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@fHasta", Me.dtHasta.Text, SqlDbType.VarChar)
            ds = cd.EjecutarQuery("ls_obtieneResultados")

            If ds.Tables(0).Rows.Count = 0 Then
                cd.Inicializar()
                cd.AgregarParametro("@NotD", Me.txOT.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@NotH", Me.txOTH.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@Productor", Me.cbProductor.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@rutProductor", Me.txRutProductor.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@Empresa", Me.cbEmpresa.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@rutFac", Me.txRutEmpresa.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@tmu", tmu, SqlDbType.Int)
                cd.AgregarParametro("@NlabDesde", Ndesde, SqlDbType.Int)
                cd.AgregarParametro("@NlabHasta", Nhasta, SqlDbType.Int)
                cd.AgregarParametro("@Factura", fac, SqlDbType.Int)
                cd.AgregarParametro("@fDesde", Me.dtDesde.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@fHasta", Me.dtHasta.Text, SqlDbType.VarChar)
                ds = cd.EjecutarQuery("ls_ObtieneResultadosHistorico")
            End If

        Else
            'sin fecha
            cd.Inicializar()
            cd.AgregarParametro("@NotD", Me.txOT.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@NotH", Me.txOTH.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@Productor", Me.cbProductor.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@rutProductor", Me.txRutProductor.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@Empresa", Me.cbEmpresa.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@rutFac", Me.txRutEmpresa.Text, SqlDbType.VarChar)
            cd.AgregarParametro("@tmu", tmu, SqlDbType.Int)
            cd.AgregarParametro("@NlabDesde", Ndesde, SqlDbType.Int)
            cd.AgregarParametro("@NlabHasta", Nhasta, SqlDbType.Int)
            cd.AgregarParametro("@Factura", fac, SqlDbType.Int)
            cd.AgregarParametro("@fDesde", "", SqlDbType.VarChar)
            cd.AgregarParametro("@fHasta", "", SqlDbType.VarChar)
            ds = cd.EjecutarQuery("ls_obtieneResultados")

            If ds.Tables(0).Rows.Count = 0 Then
                cd.Inicializar()
                cd.AgregarParametro("@NotD", Me.txOT.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@NotH", Me.txOTH.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@Productor", Me.cbProductor.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@rutProductor", Me.txRutProductor.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@Empresa", Me.cbEmpresa.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@rutFac", Me.txRutEmpresa.Text, SqlDbType.VarChar)
                cd.AgregarParametro("@tmu", tmu, SqlDbType.Int)
                cd.AgregarParametro("@NlabDesde", Ndesde, SqlDbType.Int)
                cd.AgregarParametro("@NlabHasta", Nhasta, SqlDbType.Int)
                cd.AgregarParametro("@Factura", fac, SqlDbType.Int)
                cd.AgregarParametro("@fDesde", "", SqlDbType.VarChar)
                cd.AgregarParametro("@fHasta", "", SqlDbType.VarChar)
                ds = cd.EjecutarQuery("ls_ObtieneResultadosHistorico")
            End If

        End If

        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            Me.dgBusqueda.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, _
            ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, _
            ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, _
            ds.Tables(0).Rows(i).Item(6).ToString, ds.Tables(0).Rows(i).Item(7).ToString, _
            ds.Tables(0).Rows(i).Item(8).ToString, ds.Tables(0).Rows(i).Item(9).ToString, _
            ds.Tables(0).Rows(i).Item(10).ToString, ds.Tables(0).Rows(i).Item(11).ToString, _
            ds.Tables(0).Rows(i).Item(12).ToString, ds.Tables(0).Rows(i).Item(13).ToString)

        Next


    End Sub

    Private Sub dgBusqueda_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBusqueda.CellDoubleClick

        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(0).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(1).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(2).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(3).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(4).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(5).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(6).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(7).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(8).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(9).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(10).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(11).Value
        dgvRow.Cells.Add(dgvCell)

        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(12).Value
        dgvRow.Cells.Add(dgvCell)
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Me.dgBusqueda.Rows.Item(e.RowIndex).Cells.Item(13).Value
        dgvRow.Cells.Add(dgvCell)



        Me.dgAdjuntar.Rows.Add(dgvRow)


    End Sub


    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntar.Click
        Try


            Dim mOutLookApp As Outlook.Application
            Dim mNameSpace As Outlook.NameSpace
            Dim mItem As Outlook.MailItem
            Dim colAttach As Outlook.Attachments
            Dim l_Attach As Outlook.Attachment
            Dim cd As New CapaDato
            Dim rp As New MailOT
            Dim dsOT As New DataSet

            'cd.Inicializar()
            'cd.AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
            'dsOT = cd.EjecutarQuery("ls_obtieneOtNumero")

            Dim BOLA As Object

            Dim nompr, carpr, via, empn, ate, email, email2, sAño As String
            Dim num_com, f, j, s As Integer


            nompr = Me.dgAdjuntar.Rows.Item(0).Cells.Item(3).Value.ToString
            '  ate = dsOT.Tables(0).Rows.Item(0).Item(1).ToString
            'Call control_nombre(ate)
            ' If ate <> "" Then ate = "Atención:" & ate & Chr(13) Else ate = ""
            via = ""
            For f = 1 To Len(nompr)
                carpr = Mid(nompr, f, 1)
                If carpr = "." Then carpr = " "
                via = via + carpr
            Next

            email = Me.dgAdjuntar.Rows.Item(0).Cells.Item(12).Value.ToString
            email2 = Me.dgAdjuntar.Rows.Item(0).Cells.Item(13).Value.ToString
            mOutLookApp = New Outlook.Application
            mNameSpace = mOutLookApp.GetNamespace("MAPI")
            mItem = mOutLookApp.CreateItem(0)
            mItem.To = email
            mItem.CC = email2
            mItem.Subject = "Resultado Análisis Agrolab Ltda."
            mItem.Body = "Señor(es):" & Chr(13) & _
                         nompr & Chr(13) & _
                         "Adjunto Resultado Análisis solicitado." & Chr(13) & _
                         "Atentamente," & Chr(13) & Chr(13) & _
                         "Agrolab Ltda." & Chr(13) & Chr(13) & _
                         "Fono   :(02) 225 8087" & Chr(13) & _
                         "e-mail : secreagro@agrolab.cl" & Chr(13) & _
                         "Web    : www.agrolab.cl" & Chr(13) & Chr(13)
            colAttach = mItem.Attachments
            Dim sRutaDest, NlabD, NlabH, pro As String
            Dim i, r, tmu As Integer

            r = Me.dgAdjuntar.Rows.Count

            While i < r


                NlabD = Me.dgAdjuntar.Rows.Item(0).Cells.Item(10).Value.ToString
                If CStr(Me.dgAdjuntar.Rows.Item(0).Cells.Item(11).Value.ToString) <> "" Then
                    NlabH = "-" & Microsoft.VisualBasic.Right(CStr(Me.dgAdjuntar.Rows.Item(0).Cells.Item(10).Value.ToString), 3)
                End If

                sAño = Year(Today)
                tmu = CInt(Me.dgAdjuntar.Rows.Item(0).Cells.Item(7).Value.ToString)

                If tmu = 1000 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Foliar-Labsys\"
                ElseIf tmu = 2000 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Frutos-Labsys\"
                ElseIf tmu = 3000 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Agua-Labsys\"
                ElseIf tmu = 4000 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Suelo-Labsys\"
                ElseIf tmu = 5000 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".FertQuimicos-Labsys\"
                ElseIf tmu = 6000 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".FertOrganicos-Labsys\"
                ElseIf tmu = 8700 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Yemas-Labsys\"
                ElseIf tmu = 8758 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Nematodos-Labsys\"
                End If

                Try
                    Dim arr(), arr2() As String
                    Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                    ' busca "Hola mundo" en un solo nivel ( SearchTopLevelOnly ) en el directorio c:   
                    Archivo = My.Computer.FileSystem.GetFiles(sRutaDest)
                    ' recorre la lista  
                    For Each names As String In Archivo
                        arr = Split(names, "\")
                        arr2 = Split(arr(3).ToString, "-")
                        If arr2.Length = 1 Then
                            arr2 = Split(arr(3).ToString, " ")
                        End If

                        If NlabD = arr2(0).ToString Then
                            sRutaDest = names
                        End If

                    Next

                    srutadestPdf = Mid(sRutaDest, 1, sRutaDest.Length - 3) & ".pdf"

                Catch ex As Exception

                End Try

                If File.Exists(sRutaDest) Then
                    If File.Exists(srutadestPdf) Then
                        File.Delete(srutadestPdf)
                    End If
                    ConvertirXLSaPDF(sRutaDest)
                    If File.Exists(srutadestPdf) Then


                        Dim valor As String
                        valor = MsgBox("Desea adjuntar el resultado en PDF ", MsgBoxStyle.YesNo)

                        If valor = MsgBoxResult.Yes Then
                            l_Attach = colAttach.Add(srutadestPdf)
                        Else
                            File.Delete(srutadestPdf)
                            l_Attach = colAttach.Add(sRutaDest)
                        End If
                    Else
                        l_Attach = colAttach.Add(sRutaDest)
                    End If

                Else
                    MsgBox("El archivo no se ha encontrado, puede que haya cambiado el nombre del archivo o no este generado aún.", MsgBoxStyle.Information)
                End If

                '   cd.Inicializar()
                '  cd.AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
                ' cd.EjecutarQuery("ls_actualizaEstadoOtDesp")

                i = i + 1
            End While


            mItem.Display()
        Catch ex As Exception
            MsgBox("Error :" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub ConvertirXLSaPDF(ByVal sRutaDest As String)

        Dim excelApplication As ApplicationClass = New ApplicationClass()
        Dim excelWorkbook As Workbook = Nothing
        Dim paramSourceBookPath As String = sRutaDest

        Dim paramExportFilePath As String = srutadestPdf
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


End Class