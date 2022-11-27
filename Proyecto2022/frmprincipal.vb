Imports System.Runtime.InteropServices
Imports System.Data.SqlClient


Public Class frmprincipal

    '-----------MOSTRAR USUARIO Y ROL------------------------------------------------------------------------------------------------
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuario()
    End Sub
    Sub MostrarUsuario()
        InstruccionSQL = "select * from USUARIOS where rol=" + lblrol.Text
        MiComandoSQL = New SqlCommand(InstruccionSQL, conexion)
        Dim Adaptador As New SqlDataAdapter(MiComandoSQL)
        Dim tabla As New DataTable
        Adaptador.Fill(tabla)
        conexion.Close()
        If tabla.Rows.Count > 0 Then
            lblrol.Text = tabla.Rows(0).Item("rol")
            lblusuario.Text = tabla.Rows(0).Item("nombreusuario")
        End If
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------
    'Esto de aqui es solo para que el form se vea bomnito uwu 
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                    >= (Me.ClientSize.Width - cGrip)) _
                    AndAlso (pos.Y _
                    >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 35
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.pnlcontenedor.Region = region
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub pnlcabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlcabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    '--------ABRIR FORMULARIO EN EL PANEL---------------------------------------------------------------------------------------------
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = pnlformularios.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            pnlformularios.Controls.Add(Formulario)
            pnlformularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    '---------BOTONES/LLAMAR FORMULARIOS---------------------------------------------------------------------------------------------
    Private Sub btncliente_Click(sender As Object, e As EventArgs) Handles btncliente.Click
        AbrirFormEnPanel(Of frmcliente)()
    End Sub

    Private Sub btnconductor_Click(sender As Object, e As EventArgs) Handles btnconductor.Click
        AbrirFormEnPanel(Of frmconductor)()
    End Sub

    Private Sub btncamion_Click(sender As Object, e As EventArgs) Handles btncamion.Click
        AbrirFormEnPanel(Of frmcamion)()
    End Sub

    Private Sub btnpaquete_Click(sender As Object, e As EventArgs) Handles btnpaquete.Click
        AbrirFormEnPanel(Of frmpaquete)()
    End Sub

    Private Sub btnusuario_Click(sender As Object, e As EventArgs) Handles btnusuarios.Click
        AbrirFormEnPanel(Of frmusuario)()
    End Sub

    Private Sub btfacturacion_Click(sender As Object, e As EventArgs) Handles btfacturacion.Click
        AbrirFormEnPanel(Of frmfacturacion)()
    End Sub
    '--------MINIMIZAR---------------------------------------------------------------------------------------------------------------
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '--------CERRAR APLICACION ------------------------------------------------------------------------------------------------------
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estás seguro?", "ATENCION", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    '---------CERRAR SESION ---------------------------------------------------------------------------------------------------------
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MessageBox.Show("Estás seguro?", "ATENCION", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    '---------CERRAR FORMULARIOS-----------------------------------------------------------------------------------------------------
    Private Sub cerrarFormulario(sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("frmcamion") Is Nothing) Then
            btncamion.BackColor = Color.FromArgb(191, 253, 255)
        End If
        If (Application.OpenForms("frmcliente") Is Nothing) Then
            btncliente.BackColor = Color.FromArgb(191, 253, 255)
        End If
        If (Application.OpenForms("frmconductor") Is Nothing) Then
            btnconductor.BackColor = Color.FromArgb(191, 253, 255)
        End If
        If (Application.OpenForms("frmpaquete") Is Nothing) Then
            btnpaquete.BackColor = Color.FromArgb(191, 253, 255)
        End If
        If (Application.OpenForms("frmusuario") Is Nothing) Then
            btnusuarios.BackColor = Color.FromArgb(191, 253, 255)
        End If
        'If (Application.OpenForms("frmfacturacion") Is Nothing) Then
        '    btnfactura.BackColor = Color.FromArgb(59, 140, 222)
        'End If
    End Sub


End Class