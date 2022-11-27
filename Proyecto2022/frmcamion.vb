Public Class frmcamion
    Private Sub btnopciones_Click(sender As Object, e As EventArgs) Handles btnopciones.Click
        Dim frm As New frmmasopciones
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class