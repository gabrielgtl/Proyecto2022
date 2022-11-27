<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmusuario))
        Me.btnopciones = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.dgvusuarios = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblusuarios = New System.Windows.Forms.Label()
        Me.lblnombreusuario = New System.Windows.Forms.Label()
        Me.pnlform = New System.Windows.Forms.Panel()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnopciones
        '
        Me.btnopciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnopciones.FlatAppearance.BorderSize = 0
        Me.btnopciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopciones.Location = New System.Drawing.Point(460, 121)
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
        Me.btnagregar.Location = New System.Drawing.Point(624, 79)
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
        Me.btneliminar.Location = New System.Drawing.Point(624, 163)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(147, 36)
        Me.btneliminar.TabIndex = 46
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.BackColor = System.Drawing.Color.Snow
        Me.lblinforme.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinforme.Location = New System.Drawing.Point(347, 187)
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
        Me.btnmodificar.Location = New System.Drawing.Point(624, 121)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(147, 36)
        Me.btnmodificar.TabIndex = 44
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'dgvusuarios
        '
        Me.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuarios.Location = New System.Drawing.Point(12, 213)
        Me.dgvusuarios.Name = "dgvusuarios"
        Me.dgvusuarios.RowHeadersWidth = 51
        Me.dgvusuarios.RowTemplate.Height = 24
        Me.dgvusuarios.Size = New System.Drawing.Size(780, 553)
        Me.dgvusuarios.TabIndex = 47
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(460, 79)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(147, 36)
        Me.btnbuscar.TabIndex = 45
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(123, 115)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(303, 32)
        Me.txtnombre.TabIndex = 41
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(12, 9)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 40
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Snow
        Me.lblnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(22, 118)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(95, 23)
        Me.lblnombre.TabIndex = 37
        Me.lblnombre.Text = "Nombre:"
        '
        'lblusuarios
        '
        Me.lblusuarios.AutoSize = True
        Me.lblusuarios.BackColor = System.Drawing.Color.Snow
        Me.lblusuarios.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuarios.Location = New System.Drawing.Point(301, 9)
        Me.lblusuarios.Name = "lblusuarios"
        Me.lblusuarios.Size = New System.Drawing.Size(213, 49)
        Me.lblusuarios.TabIndex = 36
        Me.lblusuarios.Text = "USUARIOS"
        '
        'lblnombreusuario
        '
        Me.lblnombreusuario.AutoSize = True
        Me.lblnombreusuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreusuario.Location = New System.Drawing.Point(120, 154)
        Me.lblnombreusuario.Name = "lblnombreusuario"
        Me.lblnombreusuario.Size = New System.Drawing.Size(0, 23)
        Me.lblnombreusuario.TabIndex = 51
        '
        'pnlform
        '
        Me.pnlform.BackColor = System.Drawing.Color.Snow
        Me.pnlform.Location = New System.Drawing.Point(1, 0)
        Me.pnlform.Name = "pnlform"
        Me.pnlform.Size = New System.Drawing.Size(803, 780)
        Me.pnlform.TabIndex = 52
        '
        'frmusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 778)
        Me.Controls.Add(Me.lblnombreusuario)
        Me.Controls.Add(Me.btnopciones)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.lblinforme)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.dgvusuarios)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblusuarios)
        Me.Controls.Add(Me.pnlform)
        Me.Name = "frmusuario"
        Me.Text = "frmusuario"
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnopciones As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents lblinforme As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgvusuarios As DataGridView
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btncerrar As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblusuarios As Label
    Friend WithEvents lblnombreusuario As Label
    Friend WithEvents pnlform As Panel
End Class
