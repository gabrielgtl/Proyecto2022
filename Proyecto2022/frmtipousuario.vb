Public Class frmtipousuario

    Friend vTipoAccion As String

    Private Sub frmtipousuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Sub CargarGrilla()
        Try
            dtInforme = generar_datatabla("Select * from ROL")
            dgvrol.DataSource = dtInforme
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If ValidarDatos() = True Then
            Try
                If vTipoAccion = 0 Then
                    EjecutarSQL("insert into ROL(rol) values('" & txtrol.Text & "')")

                    MsgBox("Se ha registrado correctamente")
                    LimpiarFormulario()
                Else
                    EjecutarSQL("update ROL set rol=@1 where id_rol=@2", txtrol.Text, id)
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
        txtrol.Clear()
    End Sub
    Function ValidarDatos()
        If txtrol.Text = "" Then
            MsgBox("Por favor ingrese un nombre")
            txtrol.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim id As Integer = 0
        Dim rowindex As Integer
        Dim columnindex As Integer
        Dim dtrol As DataTable
        rowindex = dgvrol.CurrentCell.RowIndex
        columnindex = dgvrol.CurrentCell.ColumnIndex
        id = dgvrol.Rows(rowindex).Cells(columnindex).Value.ToString()
        If ValidarDatos() = True Then
            EjecutarSQL("update ROL set rol=@1 where id_rol=@2", txtrol.Text, id)
            MsgBox("Actualizado correctamente")
        End If
        CargarGrilla()
    End Sub
    Private Sub dgvciudades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrol.CellClick
        CargarTextBox()
    End Sub

    Sub CargarTextBox()
        Dim rowindex As Integer
        Dim columnindex As Integer
        Dim dtrol As DataTable
        rowindex = dgvrol.CurrentCell.RowIndex
        columnindex = dgvrol.CurrentCell.ColumnIndex
        id = dgvrol.Rows(rowindex).Cells(columnindex).Value.ToString()
        dtrol = generar_datatabla("Select * from ROL where id_rol=" & id)
        If dtrol.Rows.Count > 0 Then
            txtrol.Text = dtrol.Rows(0).Item("rol")
        End If
    End Sub

    Sub EliminarCliente()
        If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim id As Integer
                Dim rowindex As Integer
                Dim columnindex As Integer
                rowindex = dgvrol.CurrentCell.RowIndex
                columnindex = dgvrol.CurrentCell.ColumnIndex
                id = dgvrol.Rows(rowindex).Cells(columnindex).Value.ToString()
                EjecutarSQL("Delete from ROL where id_rol=@1", id)
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

    Private Sub pnlform_Paint(sender As Object, e As PaintEventArgs) Handles pnlform.Paint

    End Sub
End Class