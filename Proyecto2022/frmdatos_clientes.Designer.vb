<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdatos_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdatos_clientes))
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblruc = New System.Windows.Forms.Label()
        Me.lblci = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblciudad = New System.Windows.Forms.Label()
        Me.lblpais = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.cbociudad = New System.Windows.Forms.ComboBox()
        Me.cbotipocliente = New System.Windows.Forms.ComboBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Snow
        Me.lblnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(66, 337)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(200, 23)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre y Apellido:"
        '
        'lblruc
        '
        Me.lblruc.AutoSize = True
        Me.lblruc.BackColor = System.Drawing.Color.Snow
        Me.lblruc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblruc.Location = New System.Drawing.Point(66, 416)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(56, 23)
        Me.lblruc.TabIndex = 1
        Me.lblruc.Text = "RUC:"
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.BackColor = System.Drawing.Color.Snow
        Me.lblci.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblci.Location = New System.Drawing.Point(66, 376)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(91, 23)
        Me.lblci.TabIndex = 2
        Me.lblci.Text = "C.I. Nro.:"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.BackColor = System.Drawing.Color.Snow
        Me.lbldireccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.Location = New System.Drawing.Point(66, 454)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(106, 23)
        Me.lbldireccion.TabIndex = 4
        Me.lbldireccion.Text = "Dirección:"
        '
        'lblciudad
        '
        Me.lblciudad.AutoSize = True
        Me.lblciudad.BackColor = System.Drawing.Color.Snow
        Me.lblciudad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblciudad.Location = New System.Drawing.Point(66, 507)
        Me.lblciudad.Name = "lblciudad"
        Me.lblciudad.Size = New System.Drawing.Size(88, 23)
        Me.lblciudad.TabIndex = 6
        Me.lblciudad.Text = "Ciudad:"
        '
        'lblpais
        '
        Me.lblpais.AutoSize = True
        Me.lblpais.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpais.Location = New System.Drawing.Point(332, 511)
        Me.lblpais.Name = "lblpais"
        Me.lblpais.Size = New System.Drawing.Size(128, 23)
        Me.lblpais.TabIndex = 7
        Me.lblpais.Text = "Tipo Cliente:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(219, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(400, 578)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(147, 36)
        Me.btncancelar.TabIndex = 18
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(205, 578)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(147, 36)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'cbociudad
        '
        Me.cbociudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbociudad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbociudad.FormattingEnabled = True
        Me.cbociudad.Location = New System.Drawing.Point(160, 510)
        Me.cbociudad.Name = "cbociudad"
        Me.cbociudad.Size = New System.Drawing.Size(143, 31)
        Me.cbociudad.TabIndex = 19
        '
        'cbotipocliente
        '
        Me.cbotipocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipocliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipocliente.FormattingEnabled = True
        Me.cbotipocliente.Location = New System.Drawing.Point(466, 510)
        Me.cbotipocliente.Name = "cbotipocliente"
        Me.cbotipocliente.Size = New System.Drawing.Size(143, 31)
        Me.cbotipocliente.TabIndex = 20
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(272, 337)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(339, 32)
        Me.txtnombre.TabIndex = 21
        '
        'txtruc
        '
        Me.txtruc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.Location = New System.Drawing.Point(272, 416)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(339, 32)
        Me.txtruc.TabIndex = 22
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(272, 376)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(339, 32)
        Me.txtci.TabIndex = 23
        '
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(270, 454)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(339, 32)
        Me.txtdireccion.TabIndex = 25
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(3, 3)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 56)
        Me.btncerrar.TabIndex = 26
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.lblnombre)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.cbotipocliente)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.txtdireccion)
        Me.Panel1.Controls.Add(Me.cbociudad)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.lblpais)
        Me.Panel1.Controls.Add(Me.lblruc)
        Me.Panel1.Controls.Add(Me.txtci)
        Me.Panel1.Controls.Add(Me.txtruc)
        Me.Panel1.Controls.Add(Me.lblci)
        Me.Panel1.Controls.Add(Me.lblciudad)
        Me.Panel1.Controls.Add(Me.lbldireccion)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 638)
        Me.Panel1.TabIndex = 27
        '
        'frmdatos_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 639)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmdatos_clientes"
        Me.Text = "frmpersona"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblnombre As Label
    Friend WithEvents lblruc As Label
    Friend WithEvents lblci As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblciudad As Label
    Friend WithEvents lblpais As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents cbociudad As ComboBox
    Friend WithEvents cbotipocliente As ComboBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtruc As TextBox
    Friend WithEvents txtci As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents btncerrar As Button
    Friend WithEvents Panel1 As Panel
End Class
