<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprincipal))
        Me.pnlcontenedor = New System.Windows.Forms.Panel()
        Me.pnlmenu = New System.Windows.Forms.Panel()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblrol = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnusuarios = New System.Windows.Forms.Button()
        Me.btfacturacion = New System.Windows.Forms.Button()
        Me.btnpaquete = New System.Windows.Forms.Button()
        Me.btncamion = New System.Windows.Forms.Button()
        Me.btnconductor = New System.Windows.Forms.Button()
        Me.btncliente = New System.Windows.Forms.Button()
        Me.pnlformularios = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.pnlcontenedor.SuspendLayout()
        Me.pnlmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlformularios.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlcontenedor
        '
        Me.pnlcontenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlcontenedor.Controls.Add(Me.pnlmenu)
        Me.pnlcontenedor.Controls.Add(Me.pnlformularios)
        Me.pnlcontenedor.Controls.Add(Me.pnlcabecera)
        Me.pnlcontenedor.Location = New System.Drawing.Point(-13, -5)
        Me.pnlcontenedor.Name = "pnlcontenedor"
        Me.pnlcontenedor.Size = New System.Drawing.Size(1246, 808)
        Me.pnlcontenedor.TabIndex = 1
        '
        'pnlmenu
        '
        Me.pnlmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.pnlmenu.Controls.Add(Me.lblusuario)
        Me.pnlmenu.Controls.Add(Me.lblrol)
        Me.pnlmenu.Controls.Add(Me.PictureBox1)
        Me.pnlmenu.Controls.Add(Me.btnlogout)
        Me.pnlmenu.Controls.Add(Me.btnusuarios)
        Me.pnlmenu.Controls.Add(Me.btfacturacion)
        Me.pnlmenu.Controls.Add(Me.btnpaquete)
        Me.pnlmenu.Controls.Add(Me.btncamion)
        Me.pnlmenu.Controls.Add(Me.btnconductor)
        Me.pnlmenu.Controls.Add(Me.btncliente)
        Me.pnlmenu.Location = New System.Drawing.Point(12, 52)
        Me.pnlmenu.Name = "pnlmenu"
        Me.pnlmenu.Size = New System.Drawing.Size(308, 768)
        Me.pnlmenu.TabIndex = 1
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.White
        Me.lblusuario.Location = New System.Drawing.Point(118, 78)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(79, 23)
        Me.lblusuario.TabIndex = 9
        Me.lblusuario.Text = "Usuario"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.ForeColor = System.Drawing.Color.White
        Me.lblrol.Location = New System.Drawing.Point(118, 37)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(40, 23)
        Me.lblrol.TabIndex = 8
        Me.lblrol.Text = "Rol"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnlogout
        '
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(31, 675)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(250, 54)
        Me.btnlogout.TabIndex = 6
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnusuarios
        '
        Me.btnusuarios.FlatAppearance.BorderSize = 0
        Me.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnusuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusuarios.ForeColor = System.Drawing.Color.White
        Me.btnusuarios.Image = CType(resources.GetObject("btnusuarios.Image"), System.Drawing.Image)
        Me.btnusuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnusuarios.Location = New System.Drawing.Point(42, 512)
        Me.btnusuarios.Name = "btnusuarios"
        Me.btnusuarios.Size = New System.Drawing.Size(250, 54)
        Me.btnusuarios.TabIndex = 5
        Me.btnusuarios.Text = "Usuarios"
        Me.btnusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnusuarios.UseVisualStyleBackColor = True
        '
        'btfacturacion
        '
        Me.btfacturacion.FlatAppearance.BorderSize = 0
        Me.btfacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btfacturacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btfacturacion.ForeColor = System.Drawing.Color.White
        Me.btfacturacion.Image = CType(resources.GetObject("btfacturacion.Image"), System.Drawing.Image)
        Me.btfacturacion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btfacturacion.Location = New System.Drawing.Point(42, 452)
        Me.btfacturacion.Name = "btfacturacion"
        Me.btfacturacion.Size = New System.Drawing.Size(250, 54)
        Me.btfacturacion.TabIndex = 4
        Me.btfacturacion.Text = "Facturación"
        Me.btfacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btfacturacion.UseVisualStyleBackColor = True
        '
        'btnpaquete
        '
        Me.btnpaquete.FlatAppearance.BorderSize = 0
        Me.btnpaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpaquete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaquete.ForeColor = System.Drawing.Color.White
        Me.btnpaquete.Image = CType(resources.GetObject("btnpaquete.Image"), System.Drawing.Image)
        Me.btnpaquete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnpaquete.Location = New System.Drawing.Point(42, 392)
        Me.btnpaquete.Name = "btnpaquete"
        Me.btnpaquete.Size = New System.Drawing.Size(250, 54)
        Me.btnpaquete.TabIndex = 3
        Me.btnpaquete.Text = "Pedidos"
        Me.btnpaquete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpaquete.UseVisualStyleBackColor = True
        '
        'btncamion
        '
        Me.btncamion.FlatAppearance.BorderSize = 0
        Me.btncamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncamion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncamion.ForeColor = System.Drawing.Color.White
        Me.btncamion.Image = CType(resources.GetObject("btncamion.Image"), System.Drawing.Image)
        Me.btncamion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btncamion.Location = New System.Drawing.Point(42, 332)
        Me.btncamion.Name = "btncamion"
        Me.btncamion.Size = New System.Drawing.Size(250, 54)
        Me.btncamion.TabIndex = 2
        Me.btncamion.Text = "Camion"
        Me.btncamion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncamion.UseVisualStyleBackColor = True
        '
        'btnconductor
        '
        Me.btnconductor.FlatAppearance.BorderSize = 0
        Me.btnconductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconductor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconductor.ForeColor = System.Drawing.Color.White
        Me.btnconductor.Image = CType(resources.GetObject("btnconductor.Image"), System.Drawing.Image)
        Me.btnconductor.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnconductor.Location = New System.Drawing.Point(42, 272)
        Me.btnconductor.Name = "btnconductor"
        Me.btnconductor.Size = New System.Drawing.Size(250, 54)
        Me.btnconductor.TabIndex = 1
        Me.btnconductor.Text = "Conductor"
        Me.btnconductor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnconductor.UseVisualStyleBackColor = True
        '
        'btncliente
        '
        Me.btncliente.FlatAppearance.BorderSize = 0
        Me.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncliente.ForeColor = System.Drawing.Color.White
        Me.btncliente.Image = CType(resources.GetObject("btncliente.Image"), System.Drawing.Image)
        Me.btncliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btncliente.Location = New System.Drawing.Point(42, 212)
        Me.btncliente.Name = "btncliente"
        Me.btncliente.Size = New System.Drawing.Size(250, 54)
        Me.btncliente.TabIndex = 0
        Me.btncliente.Text = "Cliente"
        Me.btncliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncliente.UseVisualStyleBackColor = True
        '
        'pnlformularios
        '
        Me.pnlformularios.BackColor = System.Drawing.Color.White
        Me.pnlformularios.Controls.Add(Me.PictureBox2)
        Me.pnlformularios.Location = New System.Drawing.Point(320, 52)
        Me.pnlformularios.Name = "pnlformularios"
        Me.pnlformularios.Size = New System.Drawing.Size(926, 765)
        Me.pnlformularios.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(238, 171)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(380, 349)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'pnlcabecera
        '
        Me.pnlcabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.pnlcabecera.Controls.Add(Me.btnminimizar)
        Me.pnlcabecera.Controls.Add(Me.btncerrar)
        Me.pnlcabecera.Location = New System.Drawing.Point(-1, 1)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(1247, 51)
        Me.pnlcabecera.TabIndex = 0
        '
        'btnminimizar
        '
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = CType(resources.GetObject("btnminimizar.Image"), System.Drawing.Image)
        Me.btnminimizar.Location = New System.Drawing.Point(1136, 8)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(52, 37)
        Me.btnminimizar.TabIndex = 8
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(1181, 8)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 7
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1222, 801)
        Me.Controls.Add(Me.pnlcontenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmprincipal"
        Me.Text = "Form1"
        Me.pnlcontenedor.ResumeLayout(False)
        Me.pnlmenu.ResumeLayout(False)
        Me.pnlmenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlformularios.ResumeLayout(False)
        Me.pnlformularios.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcabecera.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlcontenedor As Panel
    Friend WithEvents pnlmenu As Panel
    Friend WithEvents pnlformularios As Panel
    Friend WithEvents pnlcabecera As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnusuarios As Button
    Friend WithEvents btfacturacion As Button
    Friend WithEvents btnpaquete As Button
    Friend WithEvents btncamion As Button
    Friend WithEvents btnconductor As Button
    Friend WithEvents btncliente As Button
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblrol As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnminimizar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
