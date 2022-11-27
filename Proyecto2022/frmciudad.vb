Public Class frmciudad
    Friend vTipoAccion As String

    Private Sub frmciudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Sub CargarGrilla()
        Try
            dtInforme = generar_datatabla("Select * from CIUDADES")
            dgvciudades.DataSource = dtInforme
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If ValidarDatos() = True Then
            Try
                If vTipoAccion = 0 Then
                    EjecutarSQL("insert into CIUDADES(nombreciudad) values('" & txtciudad.Text & "')")

                    MsgBox("Se ha registrado correctamente")
                    LimpiarFormulario()
                Else
                    EjecutarSQL("update CIUDADES set nombreciudad=@1 where idciudad=@2", txtciudad.Text, id)
                    MsgBox("Se ha actualizado correctamente")
                    LimpiarFormulario()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        CargarGrilla()
    End Sub


    Sub LimpiarFormulario()
        txtciudad.Clear()
    End Sub
    Function ValidarDatos()
        If txtciudad.Text = "" Then
            MsgBox("Por favor ingrese un nombre")
            txtciudad.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim id As Integer = 0
        Dim rowindex As Integer
        Dim columnindex As Integer
        Dim dtCiudad As DataTable
        rowindex = dgvciudades.CurrentCell.RowIndex
        columnindex = dgvciudades.CurrentCell.ColumnIndex
        id = dgvciudades.Rows(rowindex).Cells(columnindex).Value.ToString()
        If ValidarDatos() = True Then
            EjecutarSQL("update CIUDADES set nombreciudad=@1 where idciudad=@2", txtciudad.Text, id)
            MsgBox("Actualizado correctamente")
        End If
        CargarGrilla()
    End Sub
    Private Sub dgvciudades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvciudades.CellClick
        CargarTextBox()
    End Sub

    Sub CargarTextBox()
        Dim rowindex As Integer
        Dim columnindex As Integer
        Dim dtCiudad As DataTable
        rowindex = dgvciudades.CurrentCell.RowIndex
        columnindex = dgvciudades.CurrentCell.ColumnIndex
        id = dgvciudades.Rows(rowindex).Cells(columnindex).Value.ToString()
        dtCiudad = generar_datatabla("Select * from CIUDADES where idciudad=" & id)
        If dtCiudad.Rows.Count > 0 Then
            txtciudad.Text = dtCiudad.Rows(0).Item("nombreciudad")
        End If
    End Sub

    Sub EliminarCliente()
        If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim id As Integer
                Dim rowindex As Integer
                Dim columnindex As Integer
                rowindex = dgvciudades.CurrentCell.RowIndex
                columnindex = dgvciudades.CurrentCell.ColumnIndex
                id = dgvciudades.Rows(rowindex).Cells(columnindex).Value.ToString()
                EjecutarSQL("Delete from CIUDADES where idciudad=@1", id)
                MsgBox("Se ha eliminado correctamente")
                CargarGrilla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Error al eliminar, por favor intente más tarde")
        End If

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        EliminarCliente()

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class