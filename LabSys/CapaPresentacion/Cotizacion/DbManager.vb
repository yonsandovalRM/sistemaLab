'Clase DBManager creada para insercion, modificacion y eliminacion de datos en una base de datos
'Sql Server o MSDE. Se usa como constructor el string de conexion que indica el nombre de la base
'de datos y la tabla a ocupar.
'
'MODO DE USO
'
'En el procedimiento que se desee ocupar el objeto debe declararse una nueva
'variable del tipo DBManager de la siguiente forma (anteriormente se deberia haber
'agregado la clase al proyecto):
'
'Dim test as DBManager
'
'para inicializar el objeto se debe tener el string de conexion y el nombre de la tabla
'que se desea ocupar del dataset:
'
'test = New DBManager(tabla,conexion)
'
'Luego para insertar filas en la base de datos primero se las debe insertar
'en el dataset (el cual contiene las estructuras de las tablas previamente)
' de la siguiente manera:
'
'fila = Me.DSestructura.Tables("Personal").NewRow
'fila.Item(0) = "3123123-2"
'fila.Item(1) = "Perez Morales"
'fila.Item(2) = "Sebastian"
'fila.Item(3) = "223322"
'fila.Item(4) = "Suecia 1000"
'Me.DSestructura.Tables("Personal").Rows.Add(fila)
'Me.DSestructura.AcceptChanges()
'
'test.Insertar(DSestructura) (si el dataset contiene solo filas que no existen en la DB)
'test.update(DSestructura) ( si el dataset contiene tanto filas nuevas como existentes)
'
'Para recuperar datos de la base de datos se debe tener el dataset y crear un string
'que sea la query a ejecutar:
'
'query = "Select * from personal"
'test.Selecccionar(datos, query)
'
'
'Copyright 2005 Sebastian Perez M.
Imports System.Data.SqlClient
Public Class DbManager
    Public DSDatos As New DataSet
    Public test As String
    Private stringConexion As String
    Private conexion As SqlConnection
    Private tabla As String
    Private Adapter As SqlDataAdapter
    Private command As SqlCommand
    'Constructor de la clase, guarda el nombre de la tabla y el string de conexion en variables globales
    'ademas inicializa la conexion con el string dado
    Public Sub New(ByVal table As String, ByVal stringcon As String)
        Me.tabla = table
        Me.stringConexion = stringcon
        conexion = New SqlConnection(Me.stringConexion)
    End Sub

    Public Overloads Sub Insertar(ByVal datos As DataSet)
        Dim insertquery, temp As String
        Dim i, j, flag As Integer
        Dim fila As DataRow
        i = 0
        j = 0
        insertquery = "insert into " & Me.tabla & " ("
        For i = 0 To 40
            Try
                insertquery = insertquery & datos.Tables(Me.tabla).Columns(i).ColumnName & ","
            Catch ex As Exception
                insertquery = Left(insertquery, insertquery.Length - 1)
                insertquery = insertquery & ") Values ("
                temp = insertquery
                i = 40
            End Try
        Next
        For Each fila In datos.Tables(Me.tabla).Rows
            For i = 0 To 40
                Try
                    If IsNumeric(fila.Item(i)) Then
                        insertquery = insertquery & fila.Item(i) & ","
                    Else
                        insertquery = insertquery & "'" & fila(i) & "'" & ","
                    End If
                Catch ex As Exception
                    insertquery = Left(insertquery, insertquery.Length - 1)
                    insertquery = insertquery & ")"
                    i = 40
                    Me.test = insertquery
                    Me.command = New SqlCommand(insertquery, conexion)
                    Try
                        conexion.Open()
                        If Me.command.ExecuteNonQuery() > 0 Then
                            MsgBox("Los datos han sido ingresados correctamente")
                        End If
                    Catch exa As Exception
                        MsgBox("La insercion ha fallado")
                        conexion.Close()
                    End Try
                    conexion.Close()
                    insertquery = temp
                End Try
            Next
        Next
    End Sub

    Public Sub Update(ByVal datos As DataSet)
        Dim updatequery, temp As String
        Dim i, j, flag As Integer
        Dim fila As DataRow
        Dim rest As Constraint
        Dim rel As DataRelation
        Dim cstrt As UniqueConstraint
       
        For Each fila In datos.Tables(Me.tabla).Rows
            If fila.RowState <> DataRowState.Deleted Then
                updatequery = "UPDATE " & Me.tabla & " set "
                For i = 0 To 40
                    Try
                        If IsNumeric(fila.Item(i)) Then
                            updatequery = updatequery & datos.Tables(Me.tabla).Columns(i).ColumnName & "=" & fila.Item(i) & ","
                        Else
                            updatequery = updatequery & datos.Tables(Me.tabla).Columns(i).ColumnName & "='" & fila.Item(i) & "',"
                        End If
                    Catch ex As Exception
                        updatequery = Left(updatequery, updatequery.Length - 1)
                        updatequery = updatequery & " where "
                        i = 40
                    End Try
                Next
                For Each cstrt In datos.Tables(Me.tabla).Constraints
                    For j = 0 To 40
                        If cstrt.IsPrimaryKey Then
                            Try
                                If IsNumeric(fila.Item(j)) Then
                                    updatequery = updatequery & cstrt.Columns(j).ColumnName & "=" & fila.Item(j) & " AND "
                                Else
                                    updatequery = updatequery & cstrt.Columns(j).ColumnName & "='" & fila.Item(j) & "' AND "
                                End If
                            Catch ex As Exception
                                updatequery = Left(updatequery, updatequery.Length - 5)
                                j = 40
                            End Try
                        End If
                    Next
                Next
                Me.command = New SqlCommand(updatequery, conexion)
                Try
                    conexion.Open()
                    If Me.command.ExecuteNonQuery() > 0 Then
                        'datos actualizados correctamente
                    Else
                        conexion.Close()
                        Insertar(fila)
                    End If
                Catch exa As Exception
                    conexion.Close()
                    Insertar(fila)
                End Try
                conexion.Close()
            Else
                Delete(fila)
            End If
        Next
        Me.test = updatequery
    End Sub

    Public Overloads Sub Insertar(ByVal fila As DataRow)
        Dim insertquery, temp As String
        Dim i, j, flag As Integer
        i = 0
        j = 0
        insertquery = "insert into " & Me.tabla & " ("

        For i = 0 To 40
            Try
                insertquery = insertquery & fila.Table.Columns(i).ColumnName & ","
            Catch ex As Exception
                insertquery = Left(insertquery, insertquery.Length - 1)
                insertquery = insertquery & ") Values ("
                temp = insertquery
                i = 40
            End Try
        Next
        For i = 0 To 40
            Try
                If IsNumeric(fila.Item(i)) Then
                    insertquery = insertquery & fila.Item(i) & ","
                Else
                    insertquery = insertquery & "'" & fila(i) & "'" & ","
                End If
            Catch ex As Exception
                insertquery = Left(insertquery, insertquery.Length - 1)
                insertquery = insertquery & ")"
                i = 40
                Me.test = insertquery
                Me.command = New SqlCommand(insertquery, conexion)
                Try
                    conexion.Open()
                    If Me.command.ExecuteNonQuery() > 0 Then
                        MsgBox("Los datos han sido ingresados correctamente")
                    End If
                Catch exa As Exception
                    MsgBox("La insercion ha fallado")
                    conexion.Close()
                End Try
                conexion.Close()
                insertquery = temp
            End Try
        Next
    End Sub

    Public Overloads Sub Delete(ByVal datos As DataSet)
        Dim deletequery, temp As String
        Dim i, j, flag As Integer
        Dim fila As DataRow
        Dim clave As UniqueConstraint
        i = 0
        j = 0
        For Each fila In datos.Tables(Me.tabla).Rows
            fila.RejectChanges()
            deletequery = "DELETE FROM " & Me.tabla & " WHERE "
            For Each clave In datos.Tables(Me.tabla).Constraints
                For j = 0 To 40
                    If clave.IsPrimaryKey Then
                        Try
                            If IsNumeric(fila.Item(j)) Then
                                deletequery = deletequery & clave.Columns(j).ColumnName & "=" & fila.Item(j) & " AND "
                            Else
                                deletequery = deletequery & clave.Columns(j).ColumnName & "='" & fila.Item(j) & "' AND "
                            End If
                        Catch ex As Exception
                            deletequery = Left(deletequery, deletequery.Length - 5)
                            j = 40
                        End Try
                    End If
                Next
                fila.Delete()

                Try
                    Me.command = New SqlCommand(deletequery, conexion)
                    conexion.Open()
                    Me.command.ExecuteNonQuery()
                    conexion.Close()
                Catch ex As Exception
                    conexion.Close()
                End Try
            Next
        Next
    End Sub

    Public Overloads Sub Delete(ByVal fila As DataRow)
        Dim deletequery, temp As String
        Dim i, j, flag As Integer
        Dim clave As UniqueConstraint
        i = 0
        j = 0
        deletequery = "DELETE FROM " & Me.tabla & " WHERE "
        fila.RejectChanges()
        For Each clave In fila.Table.Constraints
            For j = 0 To 40
                If clave.IsPrimaryKey Then
                    Try
                        If IsNumeric(fila.Item(j)) Then
                            deletequery = deletequery & clave.Columns(j).ColumnName & "=" & fila.Item(j) & " AND "
                        Else
                            deletequery = deletequery & clave.Columns(j).ColumnName & "='" & fila.Item(j) & "' AND "
                        End If
                    Catch ex As Exception
                        deletequery = Left(deletequery, deletequery.Length - 5)
                        j = 40
                    End Try
                End If
            Next
            fila.Delete()
            Try
                Me.command = New SqlCommand(deletequery, conexion)
                conexion.Open()
                Me.command.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        Next
    End Sub
    Public Sub Selecccionar(ByRef datos As DataSet, ByVal query As String)
        Dim adapter As New SqlDataAdapter
        'datos.EnforceConstraints = True
        adapter.SelectCommand = New SqlCommand(query, conexion)
        adapter.Fill(datos, Me.tabla)
        '88, 48
    End Sub
End Class