<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdatoscamion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdatoscamion))
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtidcamion = New System.Windows.Forms.TextBox()
        Me.cbxpedidos = New System.Windows.Forms.ComboBox()
        Me.cbxconductor = New System.Windows.Forms.ComboBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblmodelo = New System.Windows.Forms.Label()
        Me.lblpedidos = New System.Windows.Forms.Label()
        Me.lblconductor = New System.Windows.Forms.Label()
        Me.lblmatricula = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxtipo = New System.Windows.Forms.ComboBox()
        Me.cbxmodelo = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(0, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 45
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(149, 321)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(339, 22)
        Me.txtapellido.TabIndex = 41
        '
        'txtidcamion
        '
        Me.txtidcamion.Location = New System.Drawing.Point(149, 279)
        Me.txtidcamion.Name = "txtidcamion"
        Me.txtidcamion.Size = New System.Drawing.Size(339, 22)
        Me.txtidcamion.TabIndex = 40
        '
        'cbxpedidos
        '
        Me.cbxpedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxpedidos.FormattingEnabled = True
        Me.cbxpedidos.Location = New System.Drawing.Point(161, 399)
        Me.cbxpedidos.Name = "cbxpedidos"
        Me.cbxpedidos.Size = New System.Drawing.Size(327, 24)
        Me.cbxpedidos.TabIndex = 39
        '
        'cbxconductor
        '
        Me.cbxconductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxconductor.FormattingEnabled = True
        Me.cbxconductor.Location = New System.Drawing.Point(186, 363)
        Me.cbxconductor.Name = "cbxconductor"
        Me.cbxconductor.Size = New System.Drawing.Size(302, 24)
        Me.cbxconductor.TabIndex = 38
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(265, 572)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(147, 36)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(102, 572)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(147, 36)
        Me.btnguardar.TabIndex = 36
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(120, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(283, 441)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(53, 23)
        Me.lbltipo.TabIndex = 34
        Me.lbltipo.Text = "Tipo:"
        '
        'lblmodelo
        '
        Me.lblmodelo.AutoSize = True
        Me.lblmodelo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodelo.Location = New System.Drawing.Point(37, 441)
        Me.lblmodelo.Name = "lblmodelo"
        Me.lblmodelo.Size = New System.Drawing.Size(90, 23)
        Me.lblmodelo.TabIndex = 33
        Me.lblmodelo.Text = "Modelo:"
        '
        'lblpedidos
        '
        Me.lblpedidos.AutoSize = True
        Me.lblpedidos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpedidos.Location = New System.Drawing.Point(37, 396)
        Me.lblpedidos.Name = "lblpedidos"
        Me.lblpedidos.Size = New System.Drawing.Size(118, 23)
        Me.lblpedidos.TabIndex = 31
        Me.lblpedidos.Text = "ID Pedidos:"
        '
        'lblconductor
        '
        Me.lblconductor.AutoSize = True
        Me.lblconductor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconductor.Location = New System.Drawing.Point(37, 360)
        Me.lblconductor.Name = "lblconductor"
        Me.lblconductor.Size = New System.Drawing.Size(147, 23)
        Me.lblconductor.TabIndex = 30
        Me.lblconductor.Text = "ID Conductor:"
        '
        'lblmatricula
        '
        Me.lblmatricula.AutoSize = True
        Me.lblmatricula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatricula.Location = New System.Drawing.Point(37, 318)
        Me.lblmatricula.Name = "lblmatricula"
        Me.lblmatricula.Size = New System.Drawing.Size(106, 23)
        Me.lblmatricula.TabIndex = 29
        Me.lblmatricula.Text = "Matricula:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(37, 276)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(118, 23)
        Me.lblnombre.TabIndex = 28
        Me.lblnombre.Text = "ID Camion:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxtipo)
        Me.Panel1.Controls.Add(Me.cbxmodelo)
        Me.Panel1.Controls.Add(Me.cbxconductor)
        Me.Panel1.Controls.Add(Me.cbxpedidos)
        Me.Panel1.Controls.Add(Me.lblmodelo)
        Me.Panel1.Controls.Add(Me.lbltipo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 638)
        Me.Panel1.TabIndex = 46
        '
        'cbxtipo
        '
        Me.cbxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtipo.FormattingEnabled = True
        Me.cbxtipo.Location = New System.Drawing.Point(333, 444)
        Me.cbxtipo.Name = "cbxtipo"
        Me.cbxtipo.Size = New System.Drawing.Size(144, 24)
        Me.cbxtipo.TabIndex = 41
        '
        'cbxmodelo
        '
        Me.cbxmodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxmodelo.FormattingEnabled = True
        Me.cbxmodelo.Location = New System.Drawing.Point(133, 444)
        Me.cbxmodelo.Name = "cbxmodelo"
        Me.cbxmodelo.Size = New System.Drawing.Size(144, 24)
        Me.cbxmodelo.TabIndex = 40
        '
        'frmdatoscamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 643)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtidcamion)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblpedidos)
        Me.Controls.Add(Me.lblconductor)
        Me.Controls.Add(Me.lblmatricula)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmdatoscamion"
        Me.Text = "frmdatoscamion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As Button
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtidcamion As TextBox
    Friend WithEvents cbxpedidos As ComboBox
    Friend WithEvents cbxconductor As ComboBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents lblmodelo As Label
    Friend WithEvents lblpedidos As Label
    Friend WithEvents lblconductor As Label
    Friend WithEvents lblmatricula As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxtipo As ComboBox
    Friend WithEvents cbxmodelo As ComboBox
End Class
