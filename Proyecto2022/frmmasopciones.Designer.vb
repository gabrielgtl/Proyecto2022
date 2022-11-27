<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmasopciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmasopciones))
        Me.btnverciudad = New System.Windows.Forms.Button()
        Me.btnvermodelo = New System.Windows.Forms.Button()
        Me.lblcamion = New System.Windows.Forms.Label()
        Me.btnvertiposclientes = New System.Windows.Forms.Button()
        Me.btnvertipousuario = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnverciudad
        '
        Me.btnverciudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnverciudad.FlatAppearance.BorderSize = 0
        Me.btnverciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverciudad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverciudad.Location = New System.Drawing.Point(38, 99)
        Me.btnverciudad.Name = "btnverciudad"
        Me.btnverciudad.Size = New System.Drawing.Size(259, 36)
        Me.btnverciudad.TabIndex = 28
        Me.btnverciudad.Text = "VER CIUDAD"
        Me.btnverciudad.UseVisualStyleBackColor = False
        '
        'btnvermodelo
        '
        Me.btnvermodelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnvermodelo.FlatAppearance.BorderSize = 0
        Me.btnvermodelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvermodelo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvermodelo.Location = New System.Drawing.Point(38, 267)
        Me.btnvermodelo.Name = "btnvermodelo"
        Me.btnvermodelo.Size = New System.Drawing.Size(263, 36)
        Me.btnvermodelo.TabIndex = 30
        Me.btnvermodelo.Text = "VER MODELOS DE CAMION"
        Me.btnvermodelo.UseVisualStyleBackColor = False
        '
        'lblcamion
        '
        Me.lblcamion.AutoSize = True
        Me.lblcamion.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcamion.Location = New System.Drawing.Point(40, 38)
        Me.lblcamion.Name = "lblcamion"
        Me.lblcamion.Size = New System.Drawing.Size(302, 49)
        Me.lblcamion.TabIndex = 31
        Me.lblcamion.Text = "Más Opciones"
        '
        'btnvertiposclientes
        '
        Me.btnvertiposclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnvertiposclientes.FlatAppearance.BorderSize = 0
        Me.btnvertiposclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvertiposclientes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvertiposclientes.Location = New System.Drawing.Point(38, 225)
        Me.btnvertiposclientes.Name = "btnvertiposclientes"
        Me.btnvertiposclientes.Size = New System.Drawing.Size(263, 36)
        Me.btnvertiposclientes.TabIndex = 32
        Me.btnvertiposclientes.Text = "VER TIPOS DE CLIENTES"
        Me.btnvertiposclientes.UseVisualStyleBackColor = False
        '
        'btnvertipousuario
        '
        Me.btnvertipousuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnvertipousuario.FlatAppearance.BorderSize = 0
        Me.btnvertipousuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvertipousuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvertipousuario.Location = New System.Drawing.Point(38, 141)
        Me.btnvertipousuario.Name = "btnvertipousuario"
        Me.btnvertipousuario.Size = New System.Drawing.Size(263, 36)
        Me.btnvertipousuario.TabIndex = 33
        Me.btnvertipousuario.Text = "VER TIPO DE USUARIO"
        Me.btnvertipousuario.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(38, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 36)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "VER FORMA DE PAGO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(1, -2)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 72
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'frmmasopciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 388)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnvertipousuario)
        Me.Controls.Add(Me.btnvertiposclientes)
        Me.Controls.Add(Me.lblcamion)
        Me.Controls.Add(Me.btnvermodelo)
        Me.Controls.Add(Me.btnverciudad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmasopciones"
        Me.Text = "frmagregarnuevo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnverciudad As Button
    Friend WithEvents btnvermodelo As Button
    Friend WithEvents lblcamion As Label
    Friend WithEvents btnvertiposclientes As Button
    Friend WithEvents btnvertipousuario As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btncerrar As Button
End Class
