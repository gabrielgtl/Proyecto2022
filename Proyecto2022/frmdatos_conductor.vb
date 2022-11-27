Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class frmdatos_conductor
    Dim m As New Integer
    Friend vTipoAccion As String
    Public id As Integer
    Private Sub frmdatos_conductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dtPersona = generar_datatabla("Select * from CONDUCTORES where id_conductor=" & id)
        If dtPersona.Rows.Count > 0 Then
            txtci.Text = dtPersona.Rows(0).Item("ci")
            txtdireccion.Text = dtPersona.Rows(0).Item("direccion")
            txtnombre.Text = dtPersona.Rows(0).Item("nombreapellido")
            txtruc.Text = dtPersona.Rows(0).Item("ruc")
            txtsalario.Text = dtPersona.Rows(0).Item("salario")

            cbociudad.DataSource = generar_datatabla("Select * from CIUDADES")
            cbociudad.DisplayMember = "nombreciudad"
            cbociudad.ValueMember = "idciudad"
            cbociudad.DataBindings.Add("SelectedValue", dtPersona, "ciudad")
        End If
    End Sub

    Sub CargarCombos()
        cbociudad.DataSource = generar_datatabla("Select * from CIUDADES order by nombreciudad")
        cbociudad.DisplayMember = "nombreciudad"
        cbociudad.ValueMember = "idciudad"

    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If ValidarDatos() = True Then
            Try
                If vTipoAccion = 0 Then
                    EjecutarSQL("insert into CONDUCTORES(nombreapellido,ci,ruc,direccion,ciudad,salario) values('" & txtnombre.Text & "','" & txtci.Text + "'," & txtruc.Text & ",'" & txtdireccion.Text & "','" & txtsalario.Text & "','" & cbociudad.SelectedIndex & "')")
                    'EjecutarSQL("update into CLIENTES(nombreapellido,ci,ruc,direccion,ciudad,tipocliente) values('" & txtnombre.Text & "','" & txtci.Text + "'," & txtruc.Text & ",'" & txtdireccion.Text & "','" & cbociudad.SelectedIndex & "','" & cbotipocliente.SelectedIndex & "')")
                    MsgBox("Se ha registrado correctamente")
                    LimpiarFormulario()
                Else
                    EjecutarSQL("update CONDUCTORES set nombreapellido=@1,ci=@2,ruc=@3,direccion=@4,salario=@5,ciudad=@6 where id_conductor=@7", txtnombre.Text, txtci.Text, txtruc.Text, txtdireccion.Text, txtsalario.Text, cbociudad.SelectedValue, id)
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
        txtci.Clear()
        txtruc.Clear()
        txtdireccion.Clear()
        txtsalario.Clear()
        cbociudad.SelectedIndex = -1
    End Sub
    Function ValidarDatos()
        If txtnombre.Text = "" Then
            MsgBox("Por favor ingrese un nombre")
            txtnombre.Focus()
            Return False
        End If
        If txtruc.Text = "" Then
            MsgBox("Por favor ingrese un ruc")
            txtruc.Focus()
            Return False
        End If
        If txtci.Text = "" Then
            MsgBox("Por favor ingrese una cedula")
            txtci.Focus()
            Return False
        End If
        If txtdireccion.Text = "" Then
            MsgBox("Por favor ingrese una direccion")
            txtdireccion.Focus()
            Return False
        End If
        If txtsalario.Text = "" Then
            MsgBox("Por favor ingrese el salario")
            txtsalario.Focus()
            Return False
        End If
        If cbociudad.SelectedIndex = -1 Then
            MsgBox("Por favor seleccione una ciudad")
            cbociudad.Focus()
            Return False
        End If
        Return True
    End Function
End Class