Public Class frmfacturacion
    Dim ExisteCedula As Boolean
    Dim TotalPagar As Double = 0
    Dim PrecioUnitario As Double = 22
    Dim FechaActual As Date = Date.Today
    Dim iva As Double = 0.2
    Dim codcliente As Integer = 0
    Dim Descuento As Double = 0.2
    Sub BuscarCedula()
        Dim dtDatosCedula As New DataTable
        Dim dtDatosProducto As New DataTable
        dtDatosCedula = generar_datatabla("Select * from CLIENTES where ci= '" & txtDocumento.Text & "'")
        dtDatosProducto = generar_datatabla("Select cantidad from Paquetes")
        If dtDatosCedula.Rows.Count > 0 Then
            txtDocumento.Enabled = False
            ExisteCedula = True
            lblCantidad.Text = dtDatosProducto.Rows(0).Item("cantidad")
            lblCantidad.DataBindings.Add("Text", dtDatosProducto, "cantidad")
            PrecioUnitario = PrecioUnitario * lblCantidad.Text
            txtNombre.Text = dtDatosCedula.Rows(0).Item("nombreapellido")
            lblFecha.Text = FechaActual
            lblIva.Text = iva * PrecioUnitario
            lblSubTotal.Text = lblIva.Text + PrecioUnitario
            lblDireccion.Text = dtDatosCedula.Rows(0).Item("direccion")
            lblRuc.Text = dtDatosCedula.Rows(0).Item("ruc")
            lblDescuento.Text = "0%"
            lblTotal.Text = PrecioUnitario
            If PrecioUnitario > 80 Then
                PrecioUnitario = PrecioUnitario * Descuento
                lblDescuento.Text = "20%"
            End If
            codcliente = dtDatosCedula.Rows(0).Item("idpersona")
        Else
            MsgBox("No se ha encontrado el Numero de Documento ingresado")
        End If
    End Sub


    Private Sub txtDocumento_Leave(sender As Object, e As EventArgs) Handles txtDocumento.Leave
        BuscarCedula()
    End Sub

    Private Sub frmfacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarFormulario()
    End Sub
    Sub LimpiarFormulario()
        lblCantidad.Text = ""
        lblDireccion.Text = ""
        lblFecha.Text = ""
        lblIva.Text = ""
        txtDocumento.Text = ""
        txtNombre.Text = ""
        lblSubTotal.Text = ""
        lblTotal.Text = ""
        lblRuc.Text = ""
        lblDescuento.Text = "0%"
    End Sub
    Function ValidarDatos()
        If txtDocumento.Text = "" Then
            MsgBox("Por favor ingrese un numero de documento")
            txtDocumento.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ExisteCedula = True Then
                If ValidarDatos() = True Then
                    EjecutarSQL("insert into FACTURAS(fechaemision,ruc,cantidad,subtotal,descuento,totalapagar,iva,codcliente)values('" & FechaActual & "','" & lblRuc.Text & "'," & lblCantidad.Text & ",'" & lblSubTotal.Text & "','" & Descuento & "','" & lblTotal.Text & "','" & lblIva.Text & "','" & codcliente & "')")
                    MsgBox("Se ha guardado el pago con exito")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub
End Class