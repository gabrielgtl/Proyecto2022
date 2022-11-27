<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconductor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconductor))
        Me.pnlform = New System.Windows.Forms.Panel()
        Me.lblnombreconductor = New System.Windows.Forms.Label()
        Me.btnopciones = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.dgvconductor = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblconductor = New System.Windows.Forms.Label()
        Me.pnlform.SuspendLayout()
        CType(Me.dgvconductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlform
        '
        Me.pnlform.Controls.Add(Me.lblnombreconductor)
        Me.pnlform.Controls.Add(Me.btnopciones)
        Me.pnlform.Controls.Add(Me.btnagregar)
        Me.pnlform.Controls.Add(Me.btneliminar)
        Me.pnlform.Controls.Add(Me.lblinforme)
        Me.pnlform.Controls.Add(Me.btnmodificar)
        Me.pnlform.Controls.Add(Me.dgvconductor)
        Me.pnlform.Controls.Add(Me.btnbuscar)
        Me.pnlform.Controls.Add(Me.txtci)
        Me.pnlform.Controls.Add(Me.btncerrar)
        Me.pnlform.Controls.Add(Me.lblnombre)
        Me.pnlform.Controls.Add(Me.lblconductor)
        Me.pnlform.Location = New System.Drawing.Point(-2, -1)
        Me.pnlform.Name = "pnlform"
        Me.pnlform.Size = New System.Drawing.Size(807, 811)
        Me.pnlform.TabIndex = 0
        '
        'lblnombreconductor
        '
        Me.lblnombreconductor.AutoSize = True
        Me.lblnombreconductor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreconductor.Location = New System.Drawing.Point(128, 154)
        Me.lblnombreconductor.Name = "lblnombreconductor"
        Me.lblnombreconductor.Size = New System.Drawing.Size(0, 23)
        Me.lblnombreconductor.TabIndex = 36
        '
        'btnopciones
        '
        Me.btnopciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnopciones.FlatAppearance.BorderSize = 0
        Me.btnopciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopciones.Location = New System.Drawing.Point(439, 141)
        Me.btnopciones.Name = "btnopciones"
        Me.btnopciones.Size = New System.Drawing.Size(147, 36)
        Me.btnopciones.TabIndex = 35
        Me.btnopciones.Text = "MÁS OPCIONES"
        Me.btnopciones.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(601, 97)
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
        Me.btneliminar.Location = New System.Drawing.Point(601, 181)
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
        Me.lblinforme.Location = New System.Drawing.Point(358, 215)
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
        Me.btnmodificar.Location = New System.Drawing.Point(601, 139)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(147, 36)
        Me.btnmodificar.TabIndex = 27
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'dgvconductor
        '
        Me.dgvconductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvconductor.Location = New System.Drawing.Point(14, 241)
        Me.dgvconductor.Name = "dgvconductor"
        Me.dgvconductor.RowHeadersWidth = 51
        Me.dgvconductor.RowTemplate.Height = 24
        Me.dgvconductor.Size = New System.Drawing.Size(779, 557)
        Me.dgvconductor.TabIndex = 30
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(439, 97)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(147, 36)
        Me.btnbuscar.TabIndex = 28
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(132, 101)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(256, 32)
        Me.txtci.TabIndex = 24
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(14, 13)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 23
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(35, 104)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(91, 23)
        Me.lblnombre.TabIndex = 20
        Me.lblnombre.Text = "C.I. Nro.:"
        '
        'lblconductor
        '
        Me.lblconductor.AutoSize = True
        Me.lblconductor.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconductor.Location = New System.Drawing.Point(268, 13)
        Me.lblconductor.Name = "lblconductor"
        Me.lblconductor.Size = New System.Drawing.Size(285, 49)
        Me.lblconductor.TabIndex = 19
        Me.lblconductor.Text = "CONDUCTOR"
        '
        'frmconductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 806)
        Me.Controls.Add(Me.pnlform)
        Me.Name = "frmconductor"
        Me.Text = "frmconductor"
        Me.pnlform.ResumeLayout(False)
        Me.pnlform.PerformLayout()
        CType(Me.dgvconductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlform As Panel
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents lblinforme As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgvconductor As DataGridView
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtci As TextBox
    Friend WithEvents btncerrar As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblconductor As Label
    Friend WithEvents btnopciones As Button
    Friend WithEvents lblnombreconductor As Label
End Class
