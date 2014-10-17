Imports System.Data.SqlClient
Public Class F_Muestreador
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
    Friend WithEvents DTGMuestreador As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DTGMuestreador = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DTGMuestreador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(384, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Salir"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(296, 384)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Eliminar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Grabar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar"
        '
        'DTGMuestreador
        '
        Me.DTGMuestreador.CaptionVisible = False
        Me.DTGMuestreador.DataMember = ""
        Me.DTGMuestreador.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGMuestreador.Location = New System.Drawing.Point(128, 8)
        Me.DTGMuestreador.Name = "DTGMuestreador"
        Me.DTGMuestreador.Size = New System.Drawing.Size(336, 344)
        Me.DTGMuestreador.TabIndex = 9
        Me.DTGMuestreador.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGMuestreador
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MUESTREADORES"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nombre Muestreador"
        Me.DataGridTextBoxColumn1.MappingName = "MUE_NOMBRE"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 200
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "F.Creación"
        Me.DataGridTextBoxColumn2.MappingName = "MUE_FECHACRE"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'Frm_Muestreador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 445)
        Me.Controls.Add(Me.DTGMuestreador)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Muestreador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Muestreador"
        CType(Me.DTGMuestreador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DTGMuestreador.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DTGMuestreador.CurrentCell = mycell
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Graba_Todas()
        MsgBox("Grabación finalizada")
    End Sub

    Private Sub Graba_Todas()
        Dim FILA_DATAROW, dr As DataRow
        Dim Mue_original As String
        Dim con As New SqlConnection(Conexion1)
        Dim consulta_nota, consulta_nota2 As String
        con.Open()

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("MUESTREADORES").Rows
            If FILA_DATAROW.RowState = DataRowState.Added Then
                consulta_nota = "INSERT INTO MUESTREADORES (MUE_NOMBRE,MUE_FECHACRE) VALUES ('" & _
                FILA_DATAROW("MUE_NOMBRE") & "','" & FILA_DATAROW("MUE_FECHACRE") & "')"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("MUESTREADORES").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                Mue_original = FILA_DATAROW("MUE_NOMBRE", DataRowVersion.Original)
                consulta_nota = "DELETE FROM MUESTREADORES WHERE MUE_NOMBRE='" & Mue_original & "'"

                consulta_nota2 = "INSERT INTO MUESTREADORES (MUE_NOMBRE,MUE_FECHACRE) VALUES ('" & _
                FILA_DATAROW("MUE_NOMBRE") & "','" & FILA_DATAROW("MUE_FECHACRE") & "')"

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

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("MUESTREADORES").Rows
            If FILA_DATAROW.RowState = DataRowState.Deleted Then
                consulta_nota = "DELETE FROM MUESTREADORES WHERE MUE_NOMBRE='" & FILA_DATAROW("MUE_NOMBRE") & "'"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next
        con.Close()
        Cjto_Tablas1.Tables("MUESTREADORES").AcceptChanges()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Nombre As String
        Dim respuesta As MsgBoxResult
        cll = DTGMuestreador.CurrentCell.ColumnNumber
        fila = DTGMuestreador.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Tablas1.Tables("MUESTREADORES").Rows(fila)
        Cod_Nombre = FILA_DATAROW("MUE_NOMBRE")
        respuesta = MsgBox("Esta seguro de eliminar : " & Cod_Nombre, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Call elimina_fila_grilla_Var(Cod_Nombre, FILA_DATAROW)
        End If
    End Sub


    Private Sub elimina_fila_grilla_Var(ByVal COD_MUESTREADOR As String, ByVal FILA_DATAROW As DataRow)
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        consulta_nota = "DELETE FROM MUESTREADORES WHERE MUE_NOMBRE=" & "'" & COD_MUESTREADOR & "'"
        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        con.Close()
        Cjto_Tablas1.Tables("MUESTREADORES").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Frm_Muestreador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina()
        Cjto_Tablas1.Tables("MUESTREADORES").Clear()
        Dim Test2 As DbManager = New DbManager("MUESTREADORES", Conexion1)
        Dim query2 As String = "Select MUE_NOMBRE,MUE_FECHACRE from MUESTREADORES"
        Test2.Selecccionar(Cjto_Tablas1, query2)
    End Sub

    Private Sub Anti_Elimina()
        DTGMuestreador.DataSource = Cjto_Tablas1.Tables("MUESTREADORES")
    End Sub
End Class
