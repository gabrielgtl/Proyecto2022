<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtipousuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtipousuario))
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.pnlform = New System.Windows.Forms.Panel()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.lblclientes = New System.Windows.Forms.Label()
        Me.txtrol = New System.Windows.Forms.TextBox()
        Me.dgvrol = New System.Windows.Forms.DataGridView()
        Me.lblpoducto = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.pnlform.SuspendLayout()
        CType(Me.dgvrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.Color.Gainsboro
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(-5, 4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 69
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'pnlform
        '
        Me.pnlform.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlform.Controls.Add(Me.lblinforme)
        Me.pnlform.Controls.Add(Me.lblclientes)
        Me.pnlform.Controls.Add(Me.txtrol)
        Me.pnlform.Controls.Add(Me.dgvrol)
        Me.pnlform.Controls.Add(Me.lblpoducto)
        Me.pnlform.Controls.Add(Me.btneliminar)
        Me.pnlform.Controls.Add(Me.btnagregar)
        Me.pnlform.Controls.Add(Me.btnmodificar)
        Me.pnlform.Location = New System.Drawing.Point(0, 1)
        Me.pnlform.Name = "pnlform"
        Me.pnlform.Size = New System.Drawing.Size(560, 554)
        Me.pnlform.TabIndex = 70
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
        'lblclientes
        '
        Me.lblclientes.AutoSize = True
        Me.lblclientes.BackColor = System.Drawing.Color.Gainsboro
        Me.lblclientes.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientes.Location = New System.Drawing.Point(147, 10)
        Me.lblclientes.Name = "lblclientes"
        Me.lblclientes.Size = New System.Drawing.Size(252, 49)
        Me.lblclientes.TabIndex = 53
        Me.lblclientes.Text = "Tipo Usuario"
        '
        'txtrol
        '
        Me.txtrol.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrol.Location = New System.Drawing.Point(169, 99)
        Me.txtrol.Name = "txtrol"
        Me.txtrol.Size = New System.Drawing.Size(208, 32)
        Me.txtrol.TabIndex = 65
        '
        'dgvrol
        '
        Me.dgvrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrol.Location = New System.Drawing.Point(22, 199)
        Me.dgvrol.Name = "dgvrol"
        Me.dgvrol.RowHeadersWidth = 51
        Me.dgvrol.RowTemplate.Height = 24
        Me.dgvrol.Size = New System.Drawing.Size(383, 331)
        Me.dgvrol.TabIndex = 61
        '
        'lblpoducto
        '
        Me.lblpoducto.AutoSize = True
        Me.lblpoducto.BackColor = System.Drawing.Color.Gainsboro
        Me.lblpoducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpoducto.Location = New System.Drawing.Point(41, 102)
        Me.lblpoducto.Name = "lblpoducto"
        Me.lblpoducto.Size = New System.Drawing.Size(128, 23)
        Me.lblpoducto.TabIndex = 54
        Me.lblpoducto.Text = "Tipo Usuario:"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(398, 152)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(147, 36)
        Me.btneliminar.TabIndex = 60
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(398, 68)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(147, 36)
        Me.btnagregar.TabIndex = 57
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(398, 110)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(147, 36)
        Me.btnmodificar.TabIndex = 58
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'frmtipousuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 556)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.pnlform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmtipousuario"
        Me.Text = "frmtipousuario"
        Me.pnlform.ResumeLayout(False)
        Me.pnlform.PerformLayout()
        CType(Me.dgvrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncerrar As Button
    Friend WithEvents pnlform As Panel
    Friend WithEvents lblinforme As Label
    Friend WithEvents lblclientes As Label
    Friend WithEvents txtrol As TextBox
    Friend WithEvents dgvrol As DataGridView
    Friend WithEvents lblpoducto As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnmodificar As Button
End Class
