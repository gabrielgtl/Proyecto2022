Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.DataGridView
Imports System.Data.OleDb
Imports System.Windows

Public Class frmcliente
    Dim dtInforme As New DataTable
    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarGrilla()
    End Sub

    '-------SUB RUTINAS------------------------------------------------------------------------------------
    Sub CargarGrilla()
        Try
            dtInforme = generar_datatabla("Select p.idpersona,p.nombreapellido, tp.nombreciudad as 'Ciudades',p.direccion, a.tipocliente as 'TIPOCLIENTE' from Clientes p
join Ciudades tp on p.ciudad=tp.idciudad
join TIPOCLIENTE a on p.tipocliente=a.idtipocliente")
            dgvclientes.DataSource = dtInforme
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub limpiarbusqueda()
        txtci.Clear()
    End Sub

    Private Sub txtci_Leave(sender As Object, e As EventArgs) Handles txtci.Leave
    End Sub

    Sub BuscarCliente()
        Try
            dtInforme = generar_datatabla("Select * from CLIENTES where ci=" & txtci.Text.Trim)
            dgvclientes.DataSource = dtInforme
            If dtInforme.Rows.Count > 0 Then
                lblnombrecliente.Text = dtInforme.Rows(0).Item("nombreapellido")
            Else
                MsgBox("No se ha encontrado resultado para su busqueda")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarCliente()
        If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim id As Integer
                Dim rowindex As Integer
                Dim columnindex As Integer
                rowindex = dgvclientes.CurrentCell.RowIndex
                columnindex = dgvclientes.CurrentCell.ColumnIndex
                id = dgvclientes.Rows(rowindex).Cells(columnindex).Value.ToString()
                EjecutarSQL("Delete from Clientes where idpersona=@1", id)

                'If dtDelete.Rows.Count > 0 Then
                '    dtDelete = generar_datatabla("Delete from CLIENTES where ci=" & txtci.Text.Trim)
                MsgBox("Se ha eliminado correctamente")
                CargarGrilla()
                'End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Error al eliminar, por favor intente más tarde")
        End If

    End Sub

    '--------------BOTONES-----------------------------------------------------------------------------------------------------------

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim frm As New frmdatos_clientes
        frm.vTipoAccion = 0
        frm.ShowDialog()
        CargarGrilla()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim frm As New frmdatos_clientes
        frm.vTipoAccion = 1
        Dim rowindex As Integer
        Dim columnindex As Integer
        rowindex = dgvclientes.CurrentCell.RowIndex
        columnindex = dgvclientes.CurrentCell.ColumnIndex
        frm.id = dgvclientes.Rows(rowindex).Cells(columnindex).Value.ToString()
        frm.ShowDialog()
        CargarGrilla()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        BuscarCliente()
        limpiarbusqueda()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        EliminarCliente()
        limpiarbusqueda()
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------
    Dim Accion As String
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.pnlform.Region = region
        Me.Invalidate()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnopciones_Click(sender As Object, e As EventArgs) Handles btnopciones.Click
        frmmasopciones.Show()
    End Sub
End Class