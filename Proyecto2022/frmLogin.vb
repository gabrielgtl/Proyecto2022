Imports System.Runtime.InteropServices
Imports Domain
Imports Common
Imports System.Data.SqlClient


Public Class frmLogin

#Region "Form Behaviors"

    Private Sub btncerr_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

#End Region

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnltitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

#Region "Customize Controls"
    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnlogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnlogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnlogin.Region = New Region(buttonPath)
    End Sub

#End Region

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        'CustomizeComponents()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try

            If usuarioRegistrado(txtusuario.Text) = True Then
                Dim contra As String = contrasena(txtusuario.Text)
                If contra.Equals(txtcontrasena.Text) = True Then
                    Dim frm As New frmprincipal()
                    frm.Show()
                    AddHandler frm.FormClosed, AddressOf Me.Logout
                    Me.Hide()

                    'If ConsultarTipoUsuario(txtusuario.Text) = 1 Then
                    '    FrmAdministrador.ShowDialog()
                    'ElseIf ConsultarTipoUsuario(txtusuario.Text) = 2 Then
                    '    FrmInvitado.ShowDialog()
                    'Else
                    '    FrmEstandar.ShowDialog()
                    'End If
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos." + vbNewLine + "Intentalo otra vez.")
                    txtcontrasena.Clear()
                    txtcontrasena.Focus()
                    txtusuario.Clear()
                    txtusuario.Focus()
                End If
            Else
                MsgBox("El Usuario: " + txtusuario.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtusuario.Clear()
        txtcontrasena.Clear()
        Me.Show()
        txtusuario.Focus()
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CustomizeComponents()
        abrir()
    End Sub


End Class
