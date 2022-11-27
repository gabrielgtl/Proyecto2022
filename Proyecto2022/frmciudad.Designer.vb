<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmciudad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmciudad))
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.dgvciudades = New System.Windows.Forms.DataGridView()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblpoducto = New System.Windows.Forms.Label()
        Me.lblclientes = New System.Windows.Forms.Label()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.pnlform = New System.Windows.Forms.Panel()
        CType(Me.dgvciudades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlform.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(375, 71)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(147, 36)
        Me.btnagregar.TabIndex = 57
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(375, 155)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(147, 36)
        Me.btneliminar.TabIndex = 60
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.BackColor = System.Drawing.Color.Gainsboro
        Me.lblinforme.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinforme.Location = New System.Drawing.Point(165, 173)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(97, 23)
        Me.lblinforme.TabIndex = 62
        Me.lblinforme.Text = "INFORME"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(375, 113)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(147, 36)
        Me.btnmodificar.TabIndex = 58
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'dgvciudades
        '
        Me.dgvciudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvciudades.Location = New System.Drawing.Point(22, 199)
        Me.dgvciudades.Name = "dgvciudades"
        Me.dgvciudades.RowHeadersWidth = 51
        Me.dgvciudades.RowTemplate.Height = 24
        Me.dgvciudades.Size = New System.Drawing.Size(383, 331)
        Me.dgvciudades.TabIndex = 61
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.Gainsboro
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(-6, -2)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 56
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'lblpoducto
        '
        Me.lblpoducto.AutoSize = True
        Me.lblpoducto.BackColor = System.Drawing.Color.Gainsboro
        Me.lblpoducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpoducto.Location = New System.Drawing.Point(41, 102)
        Me.lblpoducto.Name = "lblpoducto"
        Me.lblpoducto.Size = New System.Drawing.Size(88, 23)
        Me.lblpoducto.TabIndex = 54
        Me.lblpoducto.Text = "Ciudad:"
        '
        'lblclientes
        '
        Me.lblclientes.AutoSize = True
        Me.lblclientes.BackColor = System.Drawing.Color.Gainsboro
        Me.lblclientes.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientes.Location = New System.Drawing.Point(147, 10)
        Me.lblclientes.Name = "lblclientes"
        Me.lblclientes.Size = New System.Drawing.Size(180, 49)
        Me.lblclientes.TabIndex = 53
        Me.lblclientes.Text = "CIUDAD"
        '
        'txtciudad
        '
        Me.txtciudad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtciudad.Location = New System.Drawing.Point(137, 99)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(208, 32)
        Me.txtciudad.TabIndex = 65
        '
        'pnlform
        '
        Me.pnlform.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlform.Controls.Add(Me.lblinforme)
        Me.pnlform.Controls.Add(Me.lblclientes)
        Me.pnlform.Controls.Add(Me.txtciudad)
        Me.pnlform.Controls.Add(Me.dgvciudades)
        Me.pnlform.Controls.Add(Me.lblpoducto)
        Me.pnlform.Controls.Add(Me.btneliminar)
        Me.pnlform.Controls.Add(Me.btnagregar)
        Me.pnlform.Controls.Add(Me.btnmodificar)
        Me.pnlform.Location = New System.Drawing.Point(-1, -1)
        Me.pnlform.Name = "pnlform"
        Me.pnlform.Size = New System.Drawing.Size(560, 554)
        Me.pnlform.TabIndex = 68
        '
        'frmciudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 547)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.pnlform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmciudad"
        Me.Text = "frmciudad"
        CType(Me.dgvciudades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlform.ResumeLayout(False)
        Me.pnlform.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents lblinforme As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgvciudades As DataGridView
    Friend WithEvents btncerrar As Button
    Friend WithEvents lblpoducto As Label
    Friend WithEvents lblclientes As Label
    Friend WithEvents txtciudad As TextBox
    Friend WithEvents pnlform As Panel
End Class
