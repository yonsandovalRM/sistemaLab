Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp
Imports iTextSharp.text.Image

Public Class F_OrdenesPorFacturar

    Private Sub btnGeneraPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraPDF.Click
        Dim Documento As New Document(PageSize.LETTER, 30, 30, 30, 30) 'Declaracion del documento
        Dim parrafo As New Paragraph ' Declaracion de un parrafo
        Dim imagendemo As iTextSharp.text.Image 'Declaracion de una imagen
        Dim tablaTitulo As New PdfPTable(8) 'declara la tabla con 12 columnas
        Dim tablaSubTitulo As New PdfPTable(8)
        Dim NombreArchivo As String = "F:\Archivos LabSys\Listados\Ordenes por Facturar\" & Date.Today & " - Listado OT x Facturar.pdf"
        Dim cd As New CapaDato
        Dim r, i, j As Integer
        Dim acumula As String
        Dim ds As New DataSet
        Dim fila As DataRow
        Dim writer As PdfWriter = pdf.PdfWriter.GetInstance(Documento, New FileStream(NombreArchivo, FileMode.Create)) 'Crea el archivo "DEMO.PDF

        Documento.Open() 'Abre documento para su escritura
        parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafo.Font = FontFactory.GetFont("Arial", 10, ALIGN_CENTER) 'Asigan fuente
        parrafo.Add("Listado de Ordenes por Facturar") 'Texto que se insertara
        Documento.Add(parrafo) 'Agrega el parrafo al documento
        parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente



        imagendemo = iTextSharp.text.Image.GetInstance("../../Resources/LogoAgro.jpg") 'Dirreccion a la imagen que se hace referencia
        imagendemo.SetAbsolutePosition(6, 750) 'Posicion en el eje cartesiano
        imagendemo.ScaleAbsoluteWidth(80) 'Ancho de la imagen
        imagendemo.ScaleAbsoluteHeight(40) 'Altura de la imagen
        Documento.Add(imagendemo) ' Agrega la imagen al documento

        Dim widths(7) As Single
        widths(0) = 45
        widths(1) = 48
        widths(2) = 50
        widths(3) = 200
        widths(4) = 130
        widths(5) = 40
        widths(6) = 36
        widths(7) = 40

        Documento.Add(New Paragraph(" ")) 'Salto de linea

        tablaTitulo.SetWidthPercentage(widths, PageSize.LETTER) 'Ajusta el tamaño de cada columna
        tablaTitulo.AddCell(New Paragraph("N° OT", FontFactory.GetFont("Arial", 8)))
        tablaTitulo.AddCell(New Paragraph("F.Ing", FontFactory.GetFont("Arial", 8)))
        tablaTitulo.AddCell(New Paragraph("Rut", FontFactory.GetFont("Arial", 8)))
        tablaTitulo.AddCell(New Paragraph("Razón Social", FontFactory.GetFont("Arial", 8)))
        tablaTitulo.AddCell(New Paragraph("Empresa", FontFactory.GetFont("Arial", 8)))
        tablaTitulo.AddCell(New Paragraph("C.Pago", FontFactory.GetFont("Arial", 8)))
        tablaTitulo.AddCell(New Paragraph("Abono", FontFactory.GetFont("Arial", 8)))
        tablaTitulo.AddCell(New Paragraph("Total", FontFactory.GetFont("Arial", 8)))
        Documento.Add(tablaTitulo) ' Agrega la tabla al documento

        cd.Inicializar()
        cd.AgregarParametro("@desde", Me.dtDesde.Text, SqlDbType.VarChar)
        cd.AgregarParametro("@hasta", Me.dtHasta.Text, SqlDbType.VarChar)
        ds = cd.EjecutarQuery("ls_OTporFacturar")


        tablaSubTitulo.Rows.Clear()

        For Each fila In ds.Tables(0).Rows
            If Mid(Me.dtDesde.Text, 4, 2) = "01" Then



            End If
            tablaSubTitulo.SetWidthPercentage(widths, PageSize.LETTER) 'Ajusta el tamaño de cada columna
            tablaSubTitulo.AddCell(New Paragraph(fila("ot"), FontFactory.GetFont("Arial", 7)))
            tablaSubTitulo.AddCell(New Paragraph(fila("Fot"), FontFactory.GetFont("Arial", 7)))
            tablaSubTitulo.AddCell(New Paragraph(fila("Rut"), FontFactory.GetFont("Arial", 7)))
            tablaSubTitulo.AddCell(New Paragraph(fila("RSocial"), FontFactory.GetFont("Arial", 7)))
            tablaSubTitulo.AddCell(New Paragraph(fila("Empresa"), FontFactory.GetFont("Arial", 7)))
            tablaSubTitulo.AddCell(New Paragraph(fila("CondPago"), FontFactory.GetFont("Arial", 7)))
            tablaSubTitulo.AddCell(New Paragraph(fila("Abono"), FontFactory.GetFont("Arial", 7)))
            tablaSubTitulo.AddCell(New Paragraph(fila("Total"), FontFactory.GetFont("Arial", 7)))
            Documento.Add(tablaSubTitulo)
            tablaSubTitulo.Rows.Clear()
        Next

        Documento.Close() 'Cierra el documento
        System.Diagnostics.Process.Start(NombreArchivo) 'Abre el archivo DEMO.PDF
    End Sub
End Class