Public Class frmdatos_usuarios
    Dim m As New Integer
    Friend vTipoAccion As String
    Public id As Integer
    Private Sub frmdatos_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If vTipoAccion = 1 Then
                CargarPersona()
            Else
                CargarCombos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargarPersona()
        Dim dtPersona As DataTable
        dtPersona = generar_datatabla("Select * from USUARIOS where id_usuario=" & id)
        If dtPersona.Rows.Count > 0 Then
            txtnombre.Text = dtPersona.Rows(0).Item("nombreusuario")
            txtcontrasena.Text = dtPersona.Rows(0).Item("contrasena")

            cbotipousuario.DataSource = generar_datatabla("Select * from ROL")
            cbotipousuario.DisplayMember = "rol"
            cbotipousuario.ValueMember = "id_rol"
            cbotipousuario.DataBindings.Add("SelectedValue", dtPersona, "rol")


        End If
    End Sub

    Sub CargarCombos()
        cbotipousuario.DataSource = generar_datatabla("Select * from ROL")
        cbotipousuario.DisplayMember = "rol"
        cbotipousuario.ValueMember = "id_rol"

    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If ValidarDatos() = True Then
            Try
                If vTipoAccion = 0 Then
                    EjecutarSQL("insert into USUARIOS (nombreusuario,contrasena,rol) values('" & txtnombre.Text & "','" & txtcontrasena.Text + "','" & cbotipousuario.SelectedIndex & "')")
                    'EjecutarSQL("update into CLIENTES(nombreapellido,ci,ruc,direccion,ciudad,tipocliente) values('" & txtnombre.Text & "','" & txtci.Text + "'," & txtruc.Text & ",'" & txtdireccion.Text & "','" & cbociudad.SelectedIndex & "','" & cbotipocliente.SelectedIndex & "')")
                    MsgBox("Se ha registrado correctamente")
                    LimpiarFormulario()
                Else
                    EjecutarSQL("update USUARIOS set nombreusuario=@1,contrasena=@2,rol=@3 where id_usuario=@4", txtnombre.Text, txtcontrasena.Text, cbotipousuario.SelectedValue, id)
                    MsgBox("Se ha actualizado correctamente")
                    LimpiarFormulario()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub
    Sub LimpiarFormulario()
        txtnombre.Clear()
        txtcontrasena.Clear()
        cbotipousuario.SelectedIndex = -1
    End Sub
    Function ValidarDatos()
        If txtnombre.Text = "" Then
            MsgBox("Por favor ingrese un nombre")
            txtnombre.Focus()
            Return False
        End If
        If txtcontrasena.Text = "" Then
            MsgBox("Por favor ingrese una contrasena")
            txtcontrasena.Focus()
            Return False
        End If
        If cbotipousuario.SelectedIndex = -1 Then
            MsgBox("Por favor seleccione un tipo de usuario")
            cbotipousuario.Focus()
            Return False
        End If
        Return True
    End Function



End Class