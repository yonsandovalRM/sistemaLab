Public Class F_Login

    Inherits System.Windows.Forms.Form
    Private iOK As Int32
    Dim sUserName As String


    Private Sub F_Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'dejo en blanco los campos de texto
        'Me.txUsuario.Text = "sando"
        'Me.txClave.Text = "1"

        'rescato la variable de usuario de windows y se la asigno al campo de usuario
        sUserName = System.Environment.UserName.ToString
        Me.txUsuario.Text = sUserName
        'sUserName = "sando"
        txClave.Select()
       


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub


    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        'Dim cd As New CapaDato
        'With cd
        '    .Inicializar()
        '    .EjecutarQueryDt("usp_SelectCondPago", Cjto_Tablas1, "CONDICION_PAGO")

        '    .Inicializar()
        '    .EjecutarQueryDt("usp_SelectIngresadores", Cjto_Tablas1, "INGRESADORES")

        '    .Inicializar()
        '    .EjecutarQueryDt("usp_SelectTipoMascara", Cjto_Tablas1, "TIPO_MASCARA")

        '    .Inicializar()
        '    .AgregarParametro("@TipoConsulta", 3, SqlDbType.Int)
        '    .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "LOCALIDAD")

        '    .Inicializar()
        '    .AgregarParametro("@TipoConsulta", 1, SqlDbType.Int)
        '    .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "COMUNA")


        '    .Inicializar()
        '    .AgregarParametro("@TipoConsulta", 2, SqlDbType.Int)
        '    .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "CIUDAD")

        '    .Inicializar()
        '    .EjecutarQueryDt("usp_SelectOrdenTrabajoPaso", Cjto_Tablas1, "ORDEN_TRABAJO_PASO")

        '    .Inicializar()
        '    .EjecutarQueryDt("usp_SelectFacturaPaso", Cjto_Tablas1, "FACTURA_PASO")


        'End With

        Dim cn As New CapaNegocio
        Dim mensaje As String = ""

        ' valido que hayan digitado algun dato en el campo usuario
        If Trim(Me.txUsuario.Text) = "" Then
            MsgBox("Debe Ingresar su Usuario")
            Me.txUsuario.Focus()
            Exit Sub
        End If
        ' valido que hayan digitado algun dato en el campo clave
        If Trim(Me.txClave.Text) = "" Then
            MsgBox("Debe Ingresar su Clave")
            Me.txClave.Focus()
            Exit Sub
        End If

        mensaje = cn.validar(Me.txUsuario.Text, Me.txClave.Text)

        If mensaje = "1" Then
            MsgBox("¡El Usuario: " & Me.txUsuario.Text & ", no existe en la base de datos!" & vbCr & _
                   "¡Por favor, verifique y vuelva a ingresar!")
        ElseIf mensaje = "2" Then
            iOK = iOK + 1

            If iOK = 3 Then
                MsgBox("¡Lo siento. No está permitido su acceso!" & vbCr & _
                       "Comuníquese con el Administrador de Sistema")
                Me.Dispose()
            End If

            MsgBox("¡Su Clave no es correcta!" & vbCr & _
                   "¡Por favor, verifique y reintente ingresar!")

        End If

    End Sub

    Private Sub txUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txUsuario.KeyPress

        If e.KeyChar = Chr(13) Then
            Me.txClave.Focus()
        End If

    End Sub

    Private Sub txClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txClave.KeyPress

        If e.KeyChar = Chr(13) Then
            btnIngresar_Click(sender, e)
        End If

    End Sub

End Class
