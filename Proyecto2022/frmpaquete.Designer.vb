<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpaquete
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpaquete))
        Me.btnopciones = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.dgvpaquetes = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblpoducto = New System.Windows.Forms.Label()
        Me.lblclientes = New System.Windows.Forms.Label()
        Me.cbxproducto = New System.Windows.Forms.ComboBox()
        CType(Me.dgvpaquetes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnopciones
        '
        Me.btnopciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnopciones.FlatAppearance.BorderSize = 0
        Me.btnopciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopciones.Location = New System.Drawing.Point(454, 105)
        Me.btnopciones.Name = "btnopciones"
        Me.btnopciones.Size = New System.Drawing.Size(147, 36)
        Me.btnopciones.TabIndex = 50
        Me.btnopciones.Text = "MÁS OPCIONES"
        Me.btnopciones.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(616, 63)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(147, 36)
        Me.btnagregar.TabIndex = 43
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(616, 147)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(147, 36)
        Me.btneliminar.TabIndex = 46
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinforme.Location = New System.Drawing.Point(341, 160)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(97, 23)
        Me.lblinforme.TabIndex = 48
        Me.lblinforme.Text = "INFORME"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(616, 105)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(147, 36)
        Me.btnmodificar.TabIndex = 44
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'dgvpaquetes
        '
        Me.dgvpaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpaquetes.Location = New System.Drawing.Point(30, 197)
        Me.dgvpaquetes.Name = "dgvpaquetes"
        Me.dgvpaquetes.RowHeadersWidth = 51
        Me.dgvpaquetes.RowTemplate.Height = 24
        Me.dgvpaquetes.Size = New System.Drawing.Size(733, 544)
        Me.dgvpaquetes.TabIndex = 47
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(454, 63)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(147, 36)
        Me.btnbuscar.TabIndex = 45
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(12, -2)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 40
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lblpoducto
        '
        Me.lblpoducto.AutoSize = True
        Me.lblpoducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpoducto.Location = New System.Drawing.Point(26, 69)
        Me.lblpoducto.Name = "lblpoducto"
        Me.lblpoducto.Size = New System.Drawing.Size(105, 23)
        Me.lblpoducto.TabIndex = 37
        Me.lblpoducto.Text = "Producto:"
        '
        'lblclientes
        '
        Me.lblclientes.AutoSize = True
        Me.lblclientes.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientes.Location = New System.Drawing.Point(225, -2)
        Me.lblclientes.Name = "lblclientes"
        Me.lblclientes.Size = New System.Drawing.Size(213, 49)
        Me.lblclientes.TabIndex = 36
        Me.lblclientes.Text = "PAQUETES"
        '
        'cbxproducto
        '
        Me.cbxproducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxproducto.FormattingEnabled = True
        Me.cbxproducto.Location = New System.Drawing.Point(137, 66)
        Me.cbxproducto.Name = "cbxproducto"
        Me.cbxproducto.Size = New System.Drawing.Size(294, 31)
        Me.cbxproducto.TabIndex = 51
        '
        'frmpaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 746)
        Me.Controls.Add(Me.cbxproducto)
        Me.Controls.Add(Me.btnopciones)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.lblinforme)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.dgvpaquetes)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.lblpoducto)
        Me.Controls.Add(Me.lblclientes)
        Me.Name = "frmpaquete"
        Me.Text = "frmpaquete"
        CType(Me.dgvpaquetes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnopciones As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents lblinforme As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgvpaquetes As DataGridView
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents lblpoducto As Label
    Friend WithEvents lblclientes As Label
    Friend WithEvents cbxproducto As ComboBox
End Class
