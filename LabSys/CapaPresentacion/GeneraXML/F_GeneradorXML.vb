
Imports System.Xml
Public Class F_GeneradorXml
    Private Arreglo As New ArrayList
    Private NumElementos As Integer
    Private ArregloDetalle As New ArrayList
    Private NumElementosDetalle As Integer
    Private ArregloCabecera As New ArrayList
    Private NumElementosCabecera As Integer

    Private ArregloElemento As New ArrayList
    Private NumElementosElemento As Integer


    Private Sub F_GeneradorXml_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call LLenaCBProductorXML()
        Call LLenaCBEmpresaXML()

    End Sub

    Private Sub LLenaCBProductorXML()

        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable

        ds = cn.obtieneProductorXML()
        dt = ds.Tables(0)

        Me.cbProductor.DataSource = dt
        Me.cbProductor.DisplayMember = "pro_productor"
        Me.cbProductor.ValueMember = "pro_rut"

    End Sub

    Private Sub LLenaCBEmpresaXML()

        Dim cn As New CapaNegocio
        Dim ds As New DataSet
        Dim dt As New DataTable

        ds = cn.obtieneEmpresaXML()
        dt = ds.Tables(0)

        Me.cbEmpresa.DataSource = dt
        Me.cbEmpresa.DisplayMember = "nombre"
        Me.cbEmpresa.ValueMember = "rut"

    End Sub

    Private Sub btnBuscarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarXML.Click
        Me.dgBusquedaXML.DataSource = ""

        If Me.txNOT.Text = "" Then
            Me.txNOT.Text = 0
        End If
        If Me.txNLabDesde.Text = "" Then
            Me.txNLabDesde.Text = 0
        End If
        If Me.txNlabHasta.Text = "" Then
            Me.txNlabHasta.Text = 0
        End If

        Me.dgBusquedaXML.DataSource = Me.Ls_obtieneBusquedaXMLTableAdapter.GetData(Me.txRutProductor.Text, Me.cbProductor.Text, Me.txRutEmpresa.Text, _
        Me.cbEmpresa.Text, CInt(Me.txNOT.Text), CInt(Me.txNLabDesde.Text), CInt(Me.txNlabHasta.Text), Me.txNFolio.Text)

    End Sub

    Private Sub btnGeneraXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraXML.Click
        Dim cd As New CapaNegocio
        Dim r, s, t, i, j, k, l As Integer
        Dim fecha, ruta As String
        Dim dt, dtTemp As New DataTable
        Dim ds As New DataSet
        Dim objItem, objItem2, objItem3, objItem4 As Parametro
        Dim objXML As New XmlDocument
        Dim objElement, objElement2, objElement3, objElement4 As XmlElement

        i = 0
        j = 0
        k = 0
        l = 0



        Try
            r = Me.dgAsignado.Rows.Count()

            Dim a As Integer

            While a < r

                If (Me.dgAsignado.Rows.Item(a).Cells.Item(5).Value = "") Then

                    Dim valor As String = MsgBox("La Orden: " & Me.dgAsignado.Rows.Item(a).Cells.Item(0).Value.ToString & ", a generar no posee número de folio " & _
                    "¿Desea Continuar?", MsgBoxStyle.YesNo)
                    If valor = MsgBoxResult.Yes Then
                        Exit While
                    ElseIf valor = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
                a = a + 1
            End While

            Dim Archivo As System.IO.FileStream
            ' crea un archivo vacio prueba.txt 
            ruta = "F:\Archivos LabSys\Archivos XML\MYV XML " & Date.Now.Day & "" & Date.Now.Month & "" & Date.Now.Year & "-" & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xml"
            Archivo = System.IO.File.Create(ruta)
            Archivo.Close()
            ' error  



            'Crear Documento XML
            objXML.AppendChild(objXML.CreateElement("Solicitud"))
            'Crear Nodos en Documento XML



            objElement = objXML.CreateElement("Laboratorio")
            objElement.InnerText = "LABOR144"
            objXML.DocumentElement.AppendChild(objElement)

            objElement = objXML.CreateElement("Clave")
            objElement.InnerText = "4ah5FTj3"
            objXML.DocumentElement.AppendChild(objElement)

           


            While i < r

                dt = Me.Ls_obtieneBusquedaXMLTableAdapter.GetData("", "", "", "", CInt(Me.dgAsignado.Rows.Item(i).Cells.Item(0).Value), 0, 0, "")

                s = dt.Rows.Count()
                While j < s
                    objElement = objXML.CreateElement("CabeceraSolicitud")
                    objElement.InnerText = ""
                    objXML.DocumentElement.AppendChild(objElement)

                    fecha = cd.obtieneFechaResultadoXML(dt.Rows.Item(j).Item(0).ToString, dt.Rows.Item(j).Item(17).ToString, _
                    dt.Rows.Item(j).Item(15).ToString, dt.Rows.Item(j).Item(8).ToString)


                    fecha = Date.Today

                    objElement2 = objXML.CreateElement("NroSobre")
                    objElement2.InnerText = dt.Rows.Item(j).Item(15).ToString
                    objElement.AppendChild(objElement2)
                    objElement2 = objXML.CreateElement("NroOrdenTrabajo")
                    objElement2.InnerText = dt.Rows.Item(j).Item(17).ToString
                    objElement.AppendChild(objElement2)
                    objElement2 = objXML.CreateElement("FechaResultado")
                    objElement2.InnerText = fecha
                    objElement.AppendChild(objElement2)
                    objElement2 = objXML.CreateElement("CodigoAnalisisLab")
                    objElement2.InnerText = dt.Rows.Item(j).Item(11).ToString
                    objElement.AppendChild(objElement2)
                    objElement2 = objXML.CreateElement("CodigoAnalisisSuc")
                    objElement2.InnerText = "0"
                    objElement.AppendChild(objElement2)
                    objElement2 = objXML.CreateElement("RutCliente")
                    objElement2.InnerText = dt.Rows.Item(j).Item(1).ToString
                    objElement.AppendChild(objElement2)
                    objElement2 = objXML.CreateElement("RutDistribuidor")
                    objElement2.InnerText = dt.Rows.Item(j).Item(3).ToString
                    objElement.AppendChild(objElement2)

                    objElement = objXML.CreateElement("DetalleSolicitud")
                    objElement.InnerText = ""
                    objXML.DocumentElement.AppendChild(objElement)

                    objElement2 = objXML.CreateElement("NroSobre")
                    objElement2.InnerText = dt.Rows.Item(j).Item(15).ToString
                    objElement.AppendChild(objElement2)

                    ds = cd.obtieneElementosXML(dt.Rows.Item(j).Item(0).ToString, dt.Rows.Item(j).Item(17).ToString, _
                    dt.Rows.Item(j).Item(15).ToString, dt.Rows.Item(j).Item(8).ToString)
                    dtTemp = ds.Tables(0)
                    t = dtTemp.Rows.Count

                    While k < t
                        objElement2 = objXML.CreateElement("Elemento")
                        objElement2.InnerText = ""
                        objElement.AppendChild(objElement2)

                        objElement3 = objXML.CreateElement("CodigoElemento")
                        objElement3.InnerText = dtTemp.Rows.Item(k).Item(5).ToString
                        objElement2.AppendChild(objElement3)
                        objElement3 = objXML.CreateElement("DescripcionElemento")
                        objElement3.InnerText = dtTemp.Rows.Item(k).Item(6).ToString
                        objElement2.AppendChild(objElement3)
                        objElement3 = objXML.CreateElement("ValorResultado")
                        objElement3.InnerText = dtTemp.Rows.Item(k).Item(8).ToString
                        objElement2.AppendChild(objElement3)
                        objElement3 = objXML.CreateElement("UnidadMedida")
                        objElement3.InnerText = dtTemp.Rows.Item(k).Item(7).ToString
                        objElement2.AppendChild(objElement3)

                        k = k + 1
                    End While
                    k = 0
                    dtTemp.Rows.Clear()
                    ds = Nothing
                    j = j + 1
                End While
                j = 0
                i = i + 1
            End While

            objXML.Save(ruta)

            objXML = Nothing

            objElement = Nothing

            MsgBox("Archivo XML Generado Con éxito, quedará almacenado en esta dirección: " & ruta & " ", MsgBoxStyle.Information)

        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgBusquedaXML_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBusquedaXML.CellContentDoubleClick

        Dim dg As New DataGridView
        Dim dt As New Data.DataTable
        Dim dr As Data.DataRow

        dg = sender
        dt = dg.DataSource
        dr = dt.Rows(e.RowIndex)

        Me.dgAsignado.Rows.Add(dr.Item(0).ToString, dr.Item(2).ToString, dr.Item(4).ToString, dr.Item(9).ToString, dr.Item(10).ToString, _
        dr.Item(15).ToString, dr.Item(11).ToString, dr.Item(12).ToString, dr.Item(13).ToString, dr.Item(16).ToString)

    End Sub



End Class
