Imports Microsoft.Office.Interop

Public Class Frm_Inscripciones
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPFechaDesde = New System.Windows.Forms.DateTimePicker
        Me.DTPFechaHasta = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(78, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Desde"
        '
        'DTPFechaDesde
        '
        Me.DTPFechaDesde.CalendarFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDesde.Location = New System.Drawing.Point(136, 50)
        Me.DTPFechaDesde.Name = "DTPFechaDesde"
        Me.DTPFechaDesde.Size = New System.Drawing.Size(96, 20)
        Me.DTPFechaDesde.TabIndex = 10
        '
        'DTPFechaHasta
        '
        Me.DTPFechaHasta.CalendarFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaHasta.Location = New System.Drawing.Point(320, 50)
        Me.DTPFechaHasta.Name = "DTPFechaHasta"
        Me.DTPFechaHasta.Size = New System.Drawing.Size(96, 20)
        Me.DTPFechaHasta.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(272, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hasta"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.printer
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(157, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(294, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Frm_Inscripciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(521, 162)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTPFechaHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTPFechaDesde)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Inscripciones"
        Me.Text = "Inscripciones"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fechacc As String
        Dim fcorta, FCORTA1, fuente, destino, Cuartel1, Cuartel2, Cuartel As String
        Dim largo, sumador, fila, pag, Orden_aux As Integer
        Dim FILA_INSCRIP As DataRow
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim MyDate As Date
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet

        Try
            With SP
                .Inicializar()
                .AgregarParametro("@FecDesde", DTPFechaDesde.Text, SqlDbType.DateTime)
                .AgregarParametro("@FecHasta", DTPFechaHasta.Text, SqlDbType.DateTime)
                ds = .EjecutarQuery("usp_SelectInscripcion")
            End With

        Catch ex As Exception
        End Try

        MyDate = Today
        fechacc = Mid(MyDate, 4, 2) & "-" & Mid(MyDate, 1, 2)
        m_Excel = CreateObject("EXCEL.APPLICATION")
        fuente = "F:\Archivos LabSys\Formatos Labsys\Formato Inscripciones.xls"
        destino = "F:\Archivos LabSys\Inscripciones\Inscripcion cop" & fechacc & ".xls"
        Try
            FileCopy(fuente, destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
        End Try

        objLibroExcel = m_Excel.Workbooks.Open(destino)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()

        fcorta = Format(MyDate, "dd MMMMMMMMMM yyyy")
        FCORTA1 = Format(MyDate, "dd MMMM yyyy")
        largo = Len(FCORTA1)
        FCORTA1 = Mid(FCORTA1, 1, 2) & " de " + Mid(FCORTA1, 4, (largo - 8)) & " de" & Mid(FCORTA1, (largo - 4))
        largo = Len(fcorta)
        fcorta = "Santiago , " & Mid(fcorta, 1, 2) & " de " + Mid(fcorta, 4, (largo - 8)) & " de" & Mid(fcorta, (largo - 4))
        sumador = 0
        fila = 0
        pag = 0
        For Each FILA_INSCRIP In ds.Tables(0).Rows
            fila = fila + 1
            If (fila Mod 62) = 0 Or fila = 1 Then
                fila = fila + 1
                Call Imprime_Encabezado(fila, objHojaExcel)
                pag = pag + 1
                fila = fila + 1
            End If

            objHojaExcel.Range("A" & fila.ToString & ":B" & fila.ToString).Merge()
            objHojaExcel.Range("C" & fila.ToString & ":J" & fila.ToString).Merge()
            objHojaExcel.Range("K" & fila.ToString & ":M" & fila.ToString).Merge()

            If Orden_aux = 0 Or Orden_aux <> FILA_INSCRIP("OT_NUMERO") Then
                objHojaExcel.Range("A" & fila.ToString).Value = FILA_INSCRIP("OT_NUMERO")
                objHojaExcel.Range("A" & fila.ToString).Font.Size = 6
                objHojaExcel.Range("A" & fila.ToString & ":B" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                objHojaExcel.Range("C" & fila.ToString).Value = FILA_INSCRIP("PRO_PRODUCTOR")
                objHojaExcel.Range("C" & fila.ToString).Font.Size = 6
                objHojaExcel.Range("C" & fila.ToString & ":J" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                objHojaExcel.Range("K" & fila.ToString).Value = FILA_INSCRIP("FOLANT_LOCALIDAD")
                objHojaExcel.Range("K" & fila.ToString).Font.Size = 6
                objHojaExcel.Range("K" & fila.ToString & ":M" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            End If

            objHojaExcel.Range("N" & fila.ToString & ":O" & fila.ToString).Merge()
            objHojaExcel.Range("N" & fila.ToString).Value = FILA_INSCRIP("OT_NLAB")
            objHojaExcel.Range("N" & fila.ToString).Font.Size = 6
            objHojaExcel.Range("N" & fila.ToString & ":O" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            Cuartel1 = "" : Cuartel2 = "" : Cuartel = ""

            If IsDBNull(FILA_INSCRIP("FOLANT_CUARTEL1")) = False Then
                Cuartel1 = FILA_INSCRIP("FOLANT_CUARTEL1")
            End If

            If IsDBNull(FILA_INSCRIP("FOLANT_CUARTEL2")) = False Then
                Cuartel2 = FILA_INSCRIP("FOLANT_CUARTEL2")
            End If

            Cuartel = Cuartel1 & " " & Cuartel2

            objHojaExcel.Range("P" & fila.ToString & ":V" & fila.ToString).Merge()
            objHojaExcel.Range("P" & fila.ToString).Value = Cuartel
            objHojaExcel.Range("P" & fila.ToString).Font.Size = 6
            objHojaExcel.Range("P" & fila.ToString & ":V" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            objHojaExcel.Range("W" & fila.ToString & ":Z" & fila.ToString).Merge()
            objHojaExcel.Range("W" & fila.ToString).Value = FILA_INSCRIP("ESPECIE")
            objHojaExcel.Range("W" & fila.ToString).Font.Size = 6
            objHojaExcel.Range("W" & fila.ToString & ":Z" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            objHojaExcel.Range("AA" & fila.ToString & ":AD" & fila.ToString).Merge()
            objHojaExcel.Range("AA" & fila.ToString).Value = FILA_INSCRIP("VARIEDAD")
            objHojaExcel.Range("AA" & fila.ToString).Font.Size = 6
            objHojaExcel.Range("AA" & fila.ToString & ":AD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            objHojaExcel.Range("AE" & fila.ToString & ":AH" & fila.ToString).Merge()
            objHojaExcel.Range("AE" & fila.ToString).Value = FILA_INSCRIP("TEJIDO")
            objHojaExcel.Range("AE" & fila.ToString).Font.Size = 6
            objHojaExcel.Range("AE" & fila.ToString & ":AH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            With objHojaExcel.Range("A" & fila.ToString & ":AH" & fila.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With

            Orden_aux = FILA_INSCRIP("OT_NUMERO")
        Next
        fila = fila + 1
        'objHojaExcel.Range("A" & fila.ToString & ":AH" & fila.ToString).BorderAround()
        Call IMPRIME_NUMERO_PAGINAS(objHojaExcel, pag)
        objHojaExcel.Range("A8").Select()
    End Sub


    Private Sub Imprime_Encabezado(ByRef FILA As Integer, ByVal HOJAEXCEL As Excel.Worksheet)
        HOJAEXCEL.Range("H" & FILA.ToString & ":AA" & FILA.ToString).Merge()
        HOJAEXCEL.Range("H" & FILA.ToString).Value = "LISTADO INGRESO MUESTRAS FOLIARES"
        HOJAEXCEL.Range("H" & FILA.ToString).Font.Size = 9
        HOJAEXCEL.Range("H" & FILA.ToString).Font.Bold = True

        HOJAEXCEL.Range("H" & FILA.ToString & ":AA" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        FILA = FILA + 1
        HOJAEXCEL.Range("AF" & FILA.ToString).Value = "Pag"
        HOJAEXCEL.Range("AF" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("AF" & FILA.ToString & ":AF" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        FILA = FILA + 2
        HOJAEXCEL.Range("A" & FILA.ToString & ":B" & FILA.ToString).Merge()
        HOJAEXCEL.Range("A" & FILA.ToString).Value = "ORDEN"
        HOJAEXCEL.Range("A" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("A" & FILA.ToString & ":B" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("A" & FILA.ToString & ":B" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("C" & FILA.ToString & ":J" & FILA.ToString).Merge()
        HOJAEXCEL.Range("C" & FILA.ToString).Value = "PRODUCTOR"
        HOJAEXCEL.Range("C" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("C" & FILA.ToString & ":J" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJAEXCEL.Range("C" & FILA.ToString & ":J" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("K" & FILA.ToString & ":M" & FILA.ToString).Merge()
        HOJAEXCEL.Range("K" & FILA.ToString).Value = "LOCALIDAD"
        HOJAEXCEL.Range("K" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("K" & FILA.ToString & ":M" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJAEXCEL.Range("K" & FILA.ToString & ":M" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("N" & FILA.ToString & ":O" & FILA.ToString).Merge()
        HOJAEXCEL.Range("N" & FILA.ToString).Value = "N°LAB"
        HOJAEXCEL.Range("N" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("N" & FILA.ToString & ":O" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJAEXCEL.Range("N" & FILA.ToString & ":O" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("P" & FILA.ToString & ":V" & FILA.ToString).Merge()
        HOJAEXCEL.Range("P" & FILA.ToString).Value = "CUARTEL"
        HOJAEXCEL.Range("P" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("P" & FILA.ToString & ":V" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJAEXCEL.Range("P" & FILA.ToString & ":V" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("W" & FILA.ToString & ":Z" & FILA.ToString).Merge()
        HOJAEXCEL.Range("W" & FILA.ToString).Value = "ESPECIE"
        HOJAEXCEL.Range("W" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("W" & FILA.ToString & ":Z" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJAEXCEL.Range("W" & FILA.ToString & ":Z" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("AA" & FILA.ToString & ":AD" & FILA.ToString).Merge()
        HOJAEXCEL.Range("AA" & FILA.ToString).Value = "VARIEDAD"
        HOJAEXCEL.Range("AA" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("AA" & FILA.ToString & ":AD" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJAEXCEL.Range("AA" & FILA.ToString & ":AD" & FILA.ToString).BorderAround()

        HOJAEXCEL.Range("AE" & FILA.ToString & ":AH" & FILA.ToString).Merge()
        HOJAEXCEL.Range("AE" & FILA.ToString).Value = "TEJIDO"
        HOJAEXCEL.Range("AE" & FILA.ToString).Font.Size = 7
        HOJAEXCEL.Range("AE" & FILA.ToString & ":AH" & FILA.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJAEXCEL.Range("AE" & FILA.ToString & ":AH" & FILA.ToString).BorderAround()

    End Sub
    Public Sub IMPRIME_NUMERO_PAGINAS(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pag As Integer)
        Dim NUM_PAG, TOT_PAG, jy, filP, ult_fin, pos_pag As Integer
        Dim junto As String
        ult_fin = pag - 1
        pos_pag = 3
        For jy = 1 To pag
            If jy = 1 Then filP = pos_pag
            If jy <> 1 Then filP = (pos_pag + (62 * (jy - 1)))
            junto = CStr(jy & "/" & pag)
            HOJA_EXCEL.Range("AG" & filP.ToString).Value = "'" & CStr(junto)
            HOJA_EXCEL.Range("AG" & filP.ToString).Font.Size = 7
            HOJA_EXCEL.Range("AG" & filP.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
            'HOJA_EXCEL.Range("AG" & filP.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Next
    End Sub

End Class
