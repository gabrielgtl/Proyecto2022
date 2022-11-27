<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcamion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcamion))
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.dgvmatricula = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtmatricula = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnopciones = New System.Windows.Forms.Button()
        Me.lblcamion = New System.Windows.Forms.Label()
        CType(Me.dgvmatricula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(601, 84)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(147, 36)
        Me.btnagregar.TabIndex = 26
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(601, 168)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(147, 36)
        Me.btneliminar.TabIndex = 29
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinforme.Location = New System.Drawing.Point(329, 203)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(97, 23)
        Me.lblinforme.TabIndex = 31
        Me.lblinforme.Text = "INFORME"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(601, 126)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(147, 36)
        Me.btnmodificar.TabIndex = 27
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'dgvmatricula
        '
        Me.dgvmatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmatricula.Location = New System.Drawing.Point(8, 229)
        Me.dgvmatricula.Name = "dgvmatricula"
        Me.dgvmatricula.RowHeadersWidth = 51
        Me.dgvmatricula.RowTemplate.Height = 24
        Me.dgvmatricula.Size = New System.Drawing.Size(756, 556)
        Me.dgvmatricula.TabIndex = 30
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(448, 84)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(147, 36)
        Me.btnbuscar.TabIndex = 28
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtmatricula
        '
        Me.txtmatricula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatricula.Location = New System.Drawing.Point(127, 112)
        Me.txtmatricula.Name = "txtmatricula"
        Me.txtmatricula.Size = New System.Drawing.Size(216, 32)
        Me.txtmatricula.TabIndex = 24
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(8, 3)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(73, 49)
        Me.btncerrar.TabIndex = 23
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(25, 115)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(106, 23)
        Me.lblnombre.TabIndex = 20
        Me.lblnombre.Text = "Matricula:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblinforme)
        Me.Panel1.Controls.Add(Me.btncerrar)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.btnopciones)
        Me.Panel1.Controls.Add(Me.lblcamion)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Controls.Add(Me.btnagregar)
        Me.Panel1.Controls.Add(Me.dgvmatricula)
        Me.Panel1.Controls.Add(Me.btnbuscar)
        Me.Panel1.Location = New System.Drawing.Point(4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 802)
        Me.Panel1.TabIndex = 33
        '
        'btnopciones
        '
        Me.btnopciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnopciones.FlatAppearance.BorderSize = 0
        Me.btnopciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopciones.Location = New System.Drawing.Point(448, 126)
        Me.btnopciones.Name = "btnopciones"
        Me.btnopciones.Size = New System.Drawing.Size(147, 36)
        Me.btnopciones.TabIndex = 33
        Me.btnopciones.Text = "MÁS OPCIONES"
        Me.btnopciones.UseVisualStyleBackColor = False
        '
        'lblcamion
        '
        Me.lblcamion.AutoSize = True
        Me.lblcamion.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcamion.Location = New System.Drawing.Point(284, 10)
        Me.lblcamion.Name = "lblcamion"
        Me.lblcamion.Size = New System.Drawing.Size(195, 49)
        Me.lblcamion.TabIndex = 19
        Me.lblcamion.Text = "CAMION"
        '
        'frmcamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 799)
        Me.Controls.Add(Me.txtmatricula)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmcamion"
        Me.Text = "frmcamion"
        CType(Me.dgvmatricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents lblinforme As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgvmatricula As DataGridView
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtmatricula As TextBox
    Friend WithEvents btncerrar As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnopciones As Button
    Friend WithEvents lblcamion As Label
End Class
