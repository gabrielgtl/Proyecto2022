Public Class frmmasopciones
    Friend vTipoAccion As String

    Private Sub btnverciudad_Click(sender As Object, e As EventArgs) Handles btnverciudad.Click
        frmciudad.Show()
    End Sub

    Private Sub btnvertipousuario_Click(sender As Object, e As EventArgs) Handles btnvertipousuario.Click
        frmtipousuario.Show()
    End Sub

    Private Sub btnvertiposclientes_Click(sender As Object, e As EventArgs) Handles btnvertiposclientes.Click
        frmtipocliente.Show()
    End Sub
End Class