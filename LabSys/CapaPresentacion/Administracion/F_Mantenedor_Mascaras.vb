Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class F_Mantenedor_Mascaras
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TT As LabSys.Cjto_Tablas
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CBTipoMascara As System.Windows.Forms.ComboBox
    Friend WithEvents DTGTMascara As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TT = New LabSys.Cjto_Tablas
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTGTMascara = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.CBTipoMascara = New System.Windows.Forms.ComboBox
        CType(Me.TT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGTMascara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TT
        '
        Me.TT.DataSetName = "Cjto_Tablas"
        Me.TT.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Mascara"
        '
        'DTGTMascara
        '
        Me.DTGTMascara.CaptionVisible = False
        Me.DTGTMascara.DataMember = "TIPO_MASCARA_GRABA"
        Me.DTGTMascara.DataSource = Me.TT
        Me.DTGTMascara.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGTMascara.Location = New System.Drawing.Point(88, 56)
        Me.DTGTMascara.Name = "DTGTMascara"
        Me.DTGTMascara.Size = New System.Drawing.Size(296, 344)
        Me.DTGTMascara.TabIndex = 2
        Me.DTGTMascara.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGTMascara
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TIPO_MASCARA_GRABA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Desde"
        Me.DataGridTextBoxColumn1.MappingName = "RANGO_DESDE"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 70
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Hasta"
        Me.DataGridTextBoxColumn2.MappingName = "RANGO_HASTA"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 70
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Cant.Decimal"
        Me.DataGridTextBoxColumn3.MappingName = "DECIMALES"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Linea"
        Me.DataGridTextBoxColumn4.MappingName = "NUMERO_RANGO"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 35
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Grabar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Eliminar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Imprimir"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(120, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Agregar"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(384, 424)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 24)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Salir"
        '
        'CBTipoMascara
        '
        Me.CBTipoMascara.Location = New System.Drawing.Point(88, 16)
        Me.CBTipoMascara.Name = "CBTipoMascara"
        Me.CBTipoMascara.Size = New System.Drawing.Size(120, 21)
        Me.CBTipoMascara.TabIndex = 8
        '
        'Frm_Mantenedor_Mascaras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 485)
        Me.Controls.Add(Me.CBTipoMascara)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTGTMascara)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Mantenedor_Mascaras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Mantenedor_Mascaras"
        CType(Me.TT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGTMascara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub CBTipoMascara_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBTipoMascara.SelectedValueChanged
        Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Clear()
        Dim Test1 As DbManager = New DbManager("TIPO_MASCARA_GRABA", Conexion1)
        Dim query1 As String = "Select NUMERO_RANGO,RANGO_DESDE,RANGO_HASTA,DECIMALES from TIPO_MASCARA WHERE TMASCARA=" & CInt(CBTipoMascara.Text)
        Test1.Selecccionar(Cjto_Tablas1, query1)
    End Sub
    Private Sub Anti_Elimina()
        DTGTMascara.DataSource = Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA")
    End Sub

    Private Sub Frm_Mantenedor_Mascaras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fila As DataRow
        Dim AuxMasc As Integer
        Call Anti_Elimina()
        Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Clear()
        For Each fila In Cjto_Tablas1.Tables("TIPO_MASCARA").Rows
            If fila("TMASCARA") <> AuxMasc Then CBTipoMascara.Items.Add(fila("TMASCARA"))
            AuxMasc = fila("TMASCARA")
        Next
        CBTipoMascara.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DTGTMascara.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DTGTMascara.CurrentCell = mycell
    End Sub

    Private Sub Graba_Todas()
        Dim FILA_DATAROW, dr As DataRow
        Dim ana_codigo, ana_neto As Double
        Dim Linea, MyPos As Integer
        Dim con As New SqlConnection(Conexion1)
        Dim consulta_nota, consulta_nota2, RDe, RHa As String
        con.Open()

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Rows
            If FILA_DATAROW.RowState = DataRowState.Added Then

                MyPos = InStr(FILA_DATAROW("RANGO_DESDE"), ",")
                If Mypos > 0 Then RDe = Mid(FILA_DATAROW("RANGO_DESDE"), 1, Mypos - 1) & "." & Mid(FILA_DATAROW("RANGO_DESDE"), Mypos + 1) Else RDe = FILA_DATAROW("RANGO_DESDE")

                MyPos = InStr(FILA_DATAROW("RANGO_HASTA"), ",")
                If MyPos > 0 Then RHa = Mid(FILA_DATAROW("RANGO_HASTA"), 1, MyPos - 1) & "." & Mid(FILA_DATAROW("RANGO_HASTA"), MyPos + 1) Else RHa = FILA_DATAROW("RANGO_HASTA")

                consulta_nota = "INSERT INTO TIPO_MASCARA (TMASCARA,NUMERO_RANGO,RANGO_DESDE,RANGO_HASTA,DECIMALES)" & _
                     " VALUES (" & CBTipoMascara.Text & "," & FILA_DATAROW("NUMERO_RANGO") & "," & _
                     RDe & "," & RHa & "," & FILA_DATAROW("DECIMALES") & ")"

                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                Catch ex As Exception
                    MsgBox("Falta valor numerico")
                End Try
            End If
        Next

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                MyPos = InStr(FILA_DATAROW("RANGO_DESDE"), ",")
                If MyPos > 0 Then RDe = Mid(FILA_DATAROW("RANGO_DESDE"), 1, MyPos - 1) & "." & Mid(FILA_DATAROW("RANGO_DESDE"), MyPos + 1) Else RDe = FILA_DATAROW("RANGO_DESDE")
                MyPos = InStr(FILA_DATAROW("RANGO_HASTA"), ",")
                If MyPos > 0 Then RHa = Mid(FILA_DATAROW("RANGO_HASTA"), 1, MyPos - 1) & "." & Mid(FILA_DATAROW("RANGO_HASTA"), MyPos + 1) Else RHa = FILA_DATAROW("RANGO_HASTA")
                Linea = FILA_DATAROW("NUMERO_RANGO", DataRowVersion.Original)
                consulta_nota = "UPDATE TIPO_MASCARA SET TMASCARA=" & CBTipoMascara.Text & "," & _
                                "NUMERO_RANGO=" & FILA_DATAROW("NUMERO_RANGO") & "," & _
                                "RANGO_DESDE=" & RDe & "," & _
                                "RANGO_HASTA=" & RHa & "," & _
                                "DECIMALES=" & FILA_DATAROW("DECIMALES") & _
                                " WHERE TMASCARA=" & CBTipoMascara.Text & " AND NUMERO_RANGO=" & Linea

                Dim mycom As New SqlCommand(consulta_nota, con)
                mycom.ExecuteNonQuery()
SaltoxLimite:
            End If
        Next

        'For Each FILA_DATAROW In Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Rows
        '    If FILA_DATAROW.RowState = DataRowState.Deleted Then
        '        consulta_nota = "DELETE FROM TIPO_MASCARA WHERE TMASCARA=" & CBTipoMascara.Text '& " AND NUMERO_RANGO='" & FILA_DATAROW("NUMERO_RANGO") & "'"
        '        Dim myCommand4 As New SqlCommand(consulta_nota, con)
        '        Dim myReader3 As SqlDataReader
        '        myReader3 = myCommand4.ExecuteReader()
        '        myReader3.Close()
        '    End If
        'Next

        con.Close()
        Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").AcceptChanges()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Graba_Todas()
        Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Clear()

        Dim Test1 As DbManager = New DbManager("TIPO_MASCARA_GRABA", Conexion1)
        Dim query1 As String = "Select NUMERO_RANGO,RANGO_DESDE,RANGO_HASTA,DECIMALES from TIPO_MASCARA WHERE TMASCARA=" & CInt(CBTipoMascara.Text)
        Test1.Selecccionar(Cjto_Tablas1, query1)

        Cjto_Tablas1.Tables("TIPO_MASCARA").Clear()

        Dim Test2 As DbManager = New DbManager("TIPO_MASCARA", Conexion1)
        Dim query2 As String = "Select * from TIPO_MASCARA"
        Test1.Selecccionar(Cjto_Tablas1, query2)

        MsgBox("Grabación finalizada")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_ele As String
        Dim respuesta As MsgBoxResult
        cll = DTGTMascara.CurrentCell.ColumnNumber
        fila = DTGTMascara.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Rows(fila)
        Cod_ele = FILA_DATAROW("NUMERO_RANGO")
        respuesta = MsgBox("Esta seguro de eliminar linea : " & Cod_ele, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Call elimina_fila_grilla(Cod_ele, FILA_DATAROW)
        End If
    End Sub
    Private Sub elimina_fila_grilla(ByVal COD_ELE As String, ByVal FILA_DATAROW As DataRow)
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        consulta_nota = "DELETE FROM TIPO_MASCARA WHERE TMASCARA=" & CBTipoMascara.Text & " AND NUMERO_RANGO='" & COD_ELE & "'"
        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        con.Close()
        Cjto_Tablas1.Tables("TIPO_MASCARA_GRABA").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fuente, destino, fechacc, fcorta, FCORTA1 As String
        Dim largo, numnom, fila, sumador, pag, Mascara_Aux As Integer
        Dim FILA_MASCARA As DataRow
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel, objHojaExcel1 As Excel.Worksheet
        Dim MyDate As Date

        MyDate = Today
        fechacc = Mid(MyDate, 4, 2) & "-" & Mid(MyDate, 1, 2)
        m_Excel = CreateObject("EXCEL.APPLICATION")
        fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formato Tipo Mascara.xls"
        destino = "F:\Mis documentos\LabSys-Pruebas\Listado Tipo Mascara " & fechacc & ".xls"
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

        fila = 5
        pag = 0
        For Each FILA_MASCARA In Cjto_Tablas1.Tables("TIPO_MASCARA").Rows
            fila = fila + 1
            If FILA_MASCARA("TMASCARA") <> Mascara_Aux Then
                fila = fila + 1
                objHojaExcel.Range("B" & fila.ToString).Value = FILA_MASCARA("TMASCARA")
                objHojaExcel.Range("B" & fila.ToString).Font.Size = 8
                objHojaExcel.Range("B" & fila.ToString).Font.Bold = True
                objHojaExcel.Range("B" & fila.ToString & ":B" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                'objHojaExcel.Range("B" & fila.ToString & ":B" & fila.ToString).BorderAround()
            End If

            objHojaExcel.Range("C" & fila.ToString).Value = "'" & FILA_MASCARA("NUMERO_RANGO")
            objHojaExcel.Range("C" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("C" & fila.ToString & ":C" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'objHojaExcel.Range("C" & fila.ToString & ":C" & fila.ToString).BorderAround()

            objHojaExcel.Range("D" & fila.ToString).Value = "'" & FILA_MASCARA("RANGO_DESDE")
            objHojaExcel.Range("D" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("D" & fila.ToString & ":D" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'objHojaExcel.Range("D" & fila.ToString & ":D" & fila.ToString).BorderAround()

            objHojaExcel.Range("E" & fila.ToString).Value = "'" & FILA_MASCARA("RANGO_HASTA")
            objHojaExcel.Range("E" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("E" & fila.ToString & ":E" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'objHojaExcel.Range("E" & fila.ToString & ":E" & fila.ToString).BorderAround()

            objHojaExcel.Range("F" & fila.ToString).Value = "'" & FILA_MASCARA("DECIMALES")
            objHojaExcel.Range("F" & fila.ToString).Font.Size = 8
            objHojaExcel.Range("F" & fila.ToString & ":F" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'objHojaExcel.Range("F" & fila.ToString & ":F" & fila.ToString).BorderAround()
            Mascara_Aux = FILA_MASCARA("TMASCARA")
        Next

        objHojaExcel.Range("A8").Select()
    End Sub
End Class
