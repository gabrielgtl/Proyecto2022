<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnltitulo = New System.Windows.Forms.Panel()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnltitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.txtcontrasena)
        Me.Panel1.Controls.Add(Me.txtusuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblusuario)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.pnltitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 769)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(179, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(90, 522)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(436, 43)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(224, 433)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtcontrasena.Size = New System.Drawing.Size(302, 32)
        Me.txtcontrasena.TabIndex = 5
        '
        'txtusuario
        '
        Me.txtusuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(224, 379)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(302, 32)
        Me.txtusuario.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña:"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.White
        Me.lblusuario.Location = New System.Drawing.Point(89, 382)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(93, 23)
        Me.lblusuario.TabIndex = 2
        Me.lblusuario.Text = "Usuario: "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-1, 734)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(632, 34)
        Me.Panel3.TabIndex = 1
        '
        'pnltitulo
        '
        Me.pnltitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.pnltitulo.Controls.Add(Me.btnminimizar)
        Me.pnltitulo.Controls.Add(Me.btncerrar)
        Me.pnltitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnltitulo.Name = "pnltitulo"
        Me.pnltitulo.Size = New System.Drawing.Size(632, 57)
        Me.pnltitulo.TabIndex = 0
        '
        'btnminimizar
        '
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = CType(resources.GetObject("btnminimizar.Image"), System.Drawing.Image)
        Me.btnminimizar.Location = New System.Drawing.Point(510, 12)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(52, 37)
        Me.btnminimizar.TabIndex = 1
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(557, 12)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 764)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Opacity = 0.75R
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnltitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnltitulo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtcontrasena As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnminimizar As Button
    Friend WithEvents btncerrar As Button
End Class
