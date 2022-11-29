<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmfacturacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfacturacion))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.lblTituloNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTitulo2 = New System.Windows.Forms.Label()
        Me.lblTituloRuc = New System.Windows.Forms.Label()
        Me.lblTituloPeso = New System.Windows.Forms.Label()
        Me.lblTituloSubTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTituloIVA = New System.Windows.Forms.Label()
        Me.lblTituloFecha = New System.Windows.Forms.Label()
        Me.lblTituloDireccion = New System.Windows.Forms.Label()
        Me.lblTituloTotal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblRuc = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(213, 266)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(380, 349)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(45, 37)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(104, 16)
        Me.lblNroDocumento.TabIndex = 2
        Me.lblNroDocumento.Text = "Nro. Documento"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(170, 37)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(257, 22)
        Me.txtDocumento.TabIndex = 4
        '
        'lblTituloNombre
        '
        Me.lblTituloNombre.AutoSize = True
        Me.lblTituloNombre.Location = New System.Drawing.Point(93, 73)
        Me.lblTituloNombre.Name = "lblTituloNombre"
        Me.lblTituloNombre.Size = New System.Drawing.Size(56, 16)
        Me.lblTituloNombre.TabIndex = 5
        Me.lblTituloNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(170, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(257, 22)
        Me.txtNombre.TabIndex = 6
        '
        'lblTitulo2
        '
        Me.lblTitulo2.AutoSize = True
        Me.lblTitulo2.Location = New System.Drawing.Point(45, 110)
        Me.lblTitulo2.Name = "lblTitulo2"
        Me.lblTitulo2.Size = New System.Drawing.Size(101, 16)
        Me.lblTitulo2.TabIndex = 7
        Me.lblTitulo2.Text = "Datos del Pago"
        '
        'lblTituloRuc
        '
        Me.lblTituloRuc.AutoSize = True
        Me.lblTituloRuc.Location = New System.Drawing.Point(115, 176)
        Me.lblTituloRuc.Name = "lblTituloRuc"
        Me.lblTituloRuc.Size = New System.Drawing.Size(31, 16)
        Me.lblTituloRuc.TabIndex = 10
        Me.lblTituloRuc.Text = "Ruc"
        '
        'lblTituloPeso
        '
        Me.lblTituloPeso.AutoSize = True
        Me.lblTituloPeso.Location = New System.Drawing.Point(107, 204)
        Me.lblTituloPeso.Name = "lblTituloPeso"
        Me.lblTituloPeso.Size = New System.Drawing.Size(39, 16)
        Me.lblTituloPeso.TabIndex = 11
        Me.lblTituloPeso.Text = "Peso"
        '
        'lblTituloSubTotal
        '
        Me.lblTituloSubTotal.AutoSize = True
        Me.lblTituloSubTotal.Location = New System.Drawing.Point(294, 143)
        Me.lblTituloSubTotal.Name = "lblTituloSubTotal"
        Me.lblTituloSubTotal.Size = New System.Drawing.Size(65, 16)
        Me.lblTituloSubTotal.TabIndex = 12
        Me.lblTituloSubTotal.Text = "Sub Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Descuento"
        '
        'lblTituloIVA
        '
        Me.lblTituloIVA.AutoSize = True
        Me.lblTituloIVA.Location = New System.Drawing.Point(334, 204)
        Me.lblTituloIVA.Name = "lblTituloIVA"
        Me.lblTituloIVA.Size = New System.Drawing.Size(25, 16)
        Me.lblTituloIVA.TabIndex = 14
        Me.lblTituloIVA.Text = "Iva"
        '
        'lblTituloFecha
        '
        Me.lblTituloFecha.AutoSize = True
        Me.lblTituloFecha.Location = New System.Drawing.Point(50, 143)
        Me.lblTituloFecha.Name = "lblTituloFecha"
        Me.lblTituloFecha.Size = New System.Drawing.Size(96, 16)
        Me.lblTituloFecha.TabIndex = 15
        Me.lblTituloFecha.Text = "Fecha Emision"
        '
        'lblTituloDireccion
        '
        Me.lblTituloDireccion.AutoSize = True
        Me.lblTituloDireccion.Location = New System.Drawing.Point(505, 143)
        Me.lblTituloDireccion.Name = "lblTituloDireccion"
        Me.lblTituloDireccion.Size = New System.Drawing.Size(64, 16)
        Me.lblTituloDireccion.TabIndex = 16
        Me.lblTituloDireccion.Text = "Direccion"
        '
        'lblTituloTotal
        '
        Me.lblTituloTotal.AutoSize = True
        Me.lblTituloTotal.Location = New System.Drawing.Point(479, 176)
        Me.lblTituloTotal.Name = "lblTituloTotal"
        Me.lblTituloTotal.Size = New System.Drawing.Size(90, 16)
        Me.lblTituloTotal.TabIndex = 17
        Me.lblTituloTotal.Text = "Total A Pagar"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(153, 143)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 18
        Me.lblFecha.Text = "Label1"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(153, 204)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(48, 16)
        Me.lblCantidad.TabIndex = 20
        Me.lblCantidad.Text = "Label3"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(365, 143)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(48, 16)
        Me.lblSubTotal.TabIndex = 21
        Me.lblSubTotal.Text = "Label4"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(365, 176)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(48, 16)
        Me.lblDescuento.TabIndex = 22
        Me.lblDescuento.Text = "Label5"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(365, 204)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(48, 16)
        Me.lblIva.TabIndex = 23
        Me.lblIva.Text = "Label7"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(586, 143)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(48, 16)
        Me.lblDireccion.TabIndex = 24
        Me.lblDireccion.Text = "Label8"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(586, 176)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 16)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "Label9"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(580, 642)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(661, 642)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblRuc
        '
        Me.lblRuc.AutoSize = True
        Me.lblRuc.Location = New System.Drawing.Point(153, 176)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.Size = New System.Drawing.Size(0, 16)
        Me.lblRuc.TabIndex = 28
        '
        'frmfacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 677)
        Me.Controls.Add(Me.lblRuc)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblTituloTotal)
        Me.Controls.Add(Me.lblTituloDireccion)
        Me.Controls.Add(Me.lblTituloFecha)
        Me.Controls.Add(Me.lblTituloIVA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTituloSubTotal)
        Me.Controls.Add(Me.lblTituloPeso)
        Me.Controls.Add(Me.lblTituloRuc)
        Me.Controls.Add(Me.lblTitulo2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTituloNombre)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lblNroDocumento)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmfacturacion"
        Me.Text = "frmfacturacion"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblNroDocumento As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents lblTituloNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTitulo2 As Label
    Friend WithEvents lblTituloRuc As Label
    Friend WithEvents lblTituloSubTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTituloIVA As Label
    Friend WithEvents lblTituloFecha As Label
    Friend WithEvents lblTituloDireccion As Label
    Friend WithEvents lblTituloTotal As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblRuc As Label
    Friend WithEvents lblTituloPeso As Label
End Class
