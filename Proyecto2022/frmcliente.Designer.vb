<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcliente))
        Me.pnlform = New System.Windows.Forms.Panel()
        Me.btnopciones = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnombrecliente = New System.Windows.Forms.Label()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lblinforme = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.dgvclientes = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblclientes = New System.Windows.Forms.Label()
        Me.dvwLista = New System.Data.DataView()
        Me.pnlform.SuspendLayout()
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvwLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlform
        '
        Me.pnlform.BackColor = System.Drawing.Color.Snow
        Me.pnlform.Controls.Add(Me.btnopciones)
        Me.pnlform.Controls.Add(Me.Label1)
        Me.pnlform.Controls.Add(Me.lblnombrecliente)
        Me.pnlform.Controls.Add(Me.txtci)
        Me.pnlform.Controls.Add(Me.btnagregar)
        Me.pnlform.Controls.Add(Me.btneliminar)
        Me.pnlform.Controls.Add(Me.lblinforme)
        Me.pnlform.Controls.Add(Me.btnmodificar)
        Me.pnlform.Controls.Add(Me.dgvclientes)
        Me.pnlform.Controls.Add(Me.btnbuscar)
        Me.pnlform.Controls.Add(Me.btncerrar)
        Me.pnlform.Controls.Add(Me.lblnombre)
        Me.pnlform.Controls.Add(Me.lblclientes)
        Me.pnlform.Location = New System.Drawing.Point(-1, 3)
        Me.pnlform.Name = "pnlform"
        Me.pnlform.Size = New System.Drawing.Size(844, 769)
        Me.pnlform.TabIndex = 0
        '
        'btnopciones
        '
        Me.btnopciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnopciones.FlatAppearance.BorderSize = 0
        Me.btnopciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnopciones.Location = New System.Drawing.Point(481, 114)
        Me.btnopciones.Name = "btnopciones"
        Me.btnopciones.Size = New System.Drawing.Size(147, 36)
        Me.btnopciones.TabIndex = 51
        Me.btnopciones.Text = "MÁS OPCIONES"
        Me.btnopciones.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Datos: "
        '
        'lblnombrecliente
        '
        Me.lblnombrecliente.AutoSize = True
        Me.lblnombrecliente.BackColor = System.Drawing.Color.White
        Me.lblnombrecliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombrecliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecliente.Location = New System.Drawing.Point(127, 127)
        Me.lblnombrecliente.Name = "lblnombrecliente"
        Me.lblnombrecliente.Size = New System.Drawing.Size(18, 25)
        Me.lblnombrecliente.TabIndex = 36
        Me.lblnombrecliente.Text = " "
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(127, 74)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(310, 32)
        Me.txtci.TabIndex = 35
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(652, 70)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(147, 36)
        Me.btnagregar.TabIndex = 11
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(652, 159)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(147, 36)
        Me.btneliminar.TabIndex = 14
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'lblinforme
        '
        Me.lblinforme.AutoSize = True
        Me.lblinforme.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinforme.Location = New System.Drawing.Point(390, 185)
        Me.lblinforme.Name = "lblinforme"
        Me.lblinforme.Size = New System.Drawing.Size(97, 23)
        Me.lblinforme.TabIndex = 16
        Me.lblinforme.Text = "INFORME"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(652, 117)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(147, 36)
        Me.btnmodificar.TabIndex = 12
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'dgvclientes
        '
        Me.dgvclientes.AllowUserToAddRows = False
        Me.dgvclientes.AllowUserToDeleteRows = False
        Me.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclientes.Location = New System.Drawing.Point(34, 211)
        Me.dgvclientes.Name = "dgvclientes"
        Me.dgvclientes.ReadOnly = True
        Me.dgvclientes.RowHeadersWidth = 51
        Me.dgvclientes.RowTemplate.Height = 24
        Me.dgvclientes.Size = New System.Drawing.Size(764, 544)
        Me.dgvclientes.TabIndex = 15
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(481, 72)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(147, 36)
        Me.btnbuscar.TabIndex = 13
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(13, 7)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(52, 37)
        Me.btncerrar.TabIndex = 8
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(30, 77)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(91, 23)
        Me.lblnombre.TabIndex = 2
        Me.lblnombre.Text = "C.I. Nro.:"
        '
        'lblclientes
        '
        Me.lblclientes.AutoSize = True
        Me.lblclientes.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientes.Location = New System.Drawing.Point(326, 6)
        Me.lblclientes.Name = "lblclientes"
        Me.lblclientes.Size = New System.Drawing.Size(192, 49)
        Me.lblclientes.TabIndex = 1
        Me.lblclientes.Text = "CLIENTES"
        '
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 774)
        Me.Controls.Add(Me.pnlform)
        Me.Name = "frmcliente"
        Me.Text = "frmcliente"
        Me.pnlform.ResumeLayout(False)
        Me.pnlform.PerformLayout()
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvwLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlform As Panel
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblclientes As Label
    Friend WithEvents dgvclientes As DataGridView
    Friend WithEvents dvwLista As DataView
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents lblinforme As Label
    Friend WithEvents txtci As TextBox
    Friend WithEvents lblnombrecliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnopciones As Button
End Class
