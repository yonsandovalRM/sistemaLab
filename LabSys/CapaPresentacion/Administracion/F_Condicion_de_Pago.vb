Imports System.Data.SqlClient
Public Class F_Condicion_de_Pago
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
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTGCondPago As System.Windows.Forms.DataGrid
    Friend WithEvents TT As LabSys.Cjto_Tablas
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TT = New LabSys.Cjto_Tablas
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DTGCondPago = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.TT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGCondPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TT
        '
        Me.TT.DataSetName = "Cjto_Tablas"
        Me.TT.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(416, 352)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Salir"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(328, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Eliminar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Grabar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar"
        '
        'DTGCondPago
        '
        Me.DTGCondPago.CaptionVisible = False
        Me.DTGCondPago.DataMember = "CONDICION_PAGO"
        Me.DTGCondPago.DataSource = Me.TT
        Me.DTGCondPago.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGCondPago.Location = New System.Drawing.Point(232, 8)
        Me.DTGCondPago.Name = "DTGCondPago"
        Me.DTGCondPago.Size = New System.Drawing.Size(192, 336)
        Me.DTGCondPago.TabIndex = 9
        Me.DTGCondPago.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGCondPago
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "CONDICION_PAGO"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Condición de Pago"
        Me.DataGridTextBoxColumn1.MappingName = "CONP_CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'Frm_Condicion_de_Pago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 397)
        Me.Controls.Add(Me.DTGCondPago)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Condicion_de_Pago"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Condicion_de_Pago"
        CType(Me.TT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGCondPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DTGCondPago.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DTGCondPago.CurrentCell = mycell
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Graba_Todas()
        MsgBox("Grabación finalizada")
    End Sub

    Private Sub Graba_Todas()
        Dim FILA_DATAROW, dr As DataRow
        Dim Condicion_original As String
        Dim con As New SqlConnection(Conexion1)
        Dim consulta_nota, consulta_nota2 As String
        con.Open()

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("CONDICION_PAGO").Rows
            If FILA_DATAROW.RowState = DataRowState.Added Then
                consulta_nota = "INSERT INTO CONDICION_PAGO (CONP_CODIGO) VALUES ('" & _
                FILA_DATAROW("CONP_CODIGO") & "')"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("CONDICION_PAGO").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                Condicion_original = FILA_DATAROW("CONP_CODIGO", DataRowVersion.Original)
                consulta_nota = "DELETE FROM CONDICION_PAGO WHERE CONP_CODIGO='" & Condicion_original & "'"

                consulta_nota2 = "INSERT INTO CONDICION_PAGO (CONP_CODIGO) VALUES ('" & _
                FILA_DATAROW("CONP_CODIGO") & "')"

                Dim mycom As New SqlCommand(consulta_nota, con)
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Try
                    mycom.ExecuteNonQuery()
                    mycom.CommandText = consulta_nota2
                    mycom.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                End Try
            End If
        Next

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("CONDICION_PAGO").Rows
            If FILA_DATAROW.RowState = DataRowState.Deleted Then
                consulta_nota = "DELETE FROM CONDICION_PAGO WHERE CONP_CODIGO='" & FILA_DATAROW("CONP_CODIGO") & "'"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next
        con.Close()
        Cjto_Tablas1.Tables("CONDICION_PAGO").AcceptChanges()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Condicion As String
        Dim respuesta As MsgBoxResult
        cll = DTGCondPago.CurrentCell.ColumnNumber
        fila = DTGCondPago.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Tablas1.Tables("CONDICION_PAGO").Rows(fila)
        Cod_Condicion = FILA_DATAROW("CONP_CODIGO")
        respuesta = MsgBox("Esta seguro de eliminar : " & Cod_Condicion, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Call elimina_fila_grilla_Var(Cod_Condicion, FILA_DATAROW)
        End If
    End Sub

    Private Sub elimina_fila_grilla_Var(ByVal COD_CONDICION As String, ByVal FILA_DATAROW As DataRow)
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        consulta_nota = "DELETE FROM CONDICION_PAGO WHERE CONP_CODIGO=" & "'" & COD_CONDICION & "'"
        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        con.Close()
        Cjto_Tablas1.Tables("CONDICION_PAGO").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub Frm_Condicion_de_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina()
        Cjto_Tablas1.Tables("CONDICION_PAGO").Clear()
        Dim Test2 As DbManager = New DbManager("CONDICION_PAGO", Conexion1)
        Dim query2 As String = "Select CONP_CODIGO from CONDICION_PAGO"
        Test2.Selecccionar(Cjto_Tablas1, query2)
    End Sub

    Private Sub Anti_Elimina()
        DTGCondPago.DataSource = Cjto_Tablas1.Tables("CONDICION_PAGO")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
