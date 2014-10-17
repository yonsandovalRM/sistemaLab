Imports System.Data.SqlClient
Public Class Frm_Mant_Especie_Variedad
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
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DTGEspecie As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DTGEspecie = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        CType(Me.DTGEspecie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTGEspecie
        '
        Me.DTGEspecie.CaptionVisible = False
        Me.DTGEspecie.DataMember = ""
        Me.DTGEspecie.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGEspecie.Location = New System.Drawing.Point(149, 16)
        Me.DTGEspecie.Name = "DTGEspecie"
        Me.DTGEspecie.Size = New System.Drawing.Size(360, 632)
        Me.DTGEspecie.TabIndex = 0
        Me.DTGEspecie.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGEspecie
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ESPECIE_VARIEDAD_LABSYS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Especie"
        Me.DataGridTextBoxColumn1.MappingName = "ESPECIE"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Variedad"
        Me.DataGridTextBoxColumn2.MappingName = "VARIEDAD"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(424, 672)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(336, 672)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 24)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(160, 672)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 24)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Grabar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Location = New System.Drawing.Point(248, 672)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 24)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Agregar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Frm_Mant_Especie_Variedad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(672, 725)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DTGEspecie)
        Me.Name = "Frm_Mant_Especie_Variedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor Especie/Variedad"
        CType(Me.DTGEspecie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Mant_Tejidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina()
        Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS").Clear()
        Dim Test2 As DbManager = New DbManager("ESPECIE_VARIEDAD_LABSYS", Conexion1)
        Dim query2 As String = "Select ESPECIE,VARIEDAD from ESPECIE_VARIEDAD"
        Test2.Selecccionar(Cjto_Tablas1, query2)
    End Sub

    Private Sub Anti_Elimina()
        DTGEspecie.DataSource = Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DTGEspecie.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DTGEspecie.CurrentCell = mycell
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Variedad, Cod_Especie As String
        Dim respuesta As MsgBoxResult
        cll = DTGEspecie.CurrentCell.ColumnNumber
        fila = DTGEspecie.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS").Rows(fila)
        Cod_Especie = FILA_DATAROW("ESPECIE")
        Cod_Variedad = FILA_DATAROW("VARIEDAD")
        respuesta = MsgBox("Esta seguro de eliminar : " & Cod_Especie & "  " & Cod_Variedad, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Call elimina_fila_grilla_Var(Cod_Variedad, Cod_Especie, FILA_DATAROW)
        End If
    End Sub

    Private Sub elimina_fila_grilla_Var(ByVal COD_VARIEDAD As String, ByVal COD_ESPECIE As String, ByVal FILA_DATAROW As DataRow)
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        consulta_nota = "DELETE FROM ESPECIE_VARIEDAD WHERE ESPECIE=" & "'" & COD_ESPECIE & "' AND VARIEDAD=" & "'" & COD_VARIEDAD & "'"
        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        con.Close()
        Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub Graba_Todas()
        Dim FILA_DATAROW, dr As DataRow
        Dim Especie_original, Variedad_original As String
        Dim con As New SqlConnection(Conexion1)
        Dim consulta_nota, consulta_nota2 As String
        con.Open()

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS").Rows
            If FILA_DATAROW.RowState = DataRowState.Added Then
                consulta_nota = "INSERT INTO ESPECIE_VARIEDAD (ESPECIE,VARIEDAD) VALUES ('" & _
                FILA_DATAROW("ESPECIE") & "','" & FILA_DATAROW("VARIEDAD") & "')"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                Especie_original = FILA_DATAROW("ESPECIE", DataRowVersion.Original)
                Variedad_original = FILA_DATAROW("VARIEDAD", DataRowVersion.Original)
                consulta_nota = "DELETE FROM ESPECIE_VARIEDAD WHERE ESPECIE='" & Especie_original & "' AND VARIEDAD='" & Variedad_original & "'"

                consulta_nota2 = "INSERT INTO ESPECIE_VARIEDAD (ESPECIE,VARIEDAD) VALUES ('" & _
                FILA_DATAROW("ESPECIE") & "','" & FILA_DATAROW("VARIEDAD") & "')"

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

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS").Rows
            If FILA_DATAROW.RowState = DataRowState.Deleted Then
                consulta_nota = "DELETE FROM ESPECIE_VARIEDAD WHERE ESPECIE='" & FILA_DATAROW("ESPECIE") & "' AND VARIEDAD='" & FILA_DATAROW("VARIEDAD") & "'"
                Dim myCommand4 As New SqlCommand(consulta_nota, con)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next
        con.Close()
        Cjto_Tablas1.Tables("ESPECIE_VARIEDAD_LABSYS").AcceptChanges()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call Graba_Todas()
        MsgBox("Grabación finalizada")
    End Sub
End Class
