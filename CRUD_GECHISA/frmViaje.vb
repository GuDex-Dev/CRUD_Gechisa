Public Class frmViaje
    Private Sub btnAgregarViaje_Click(sender As Object, e As EventArgs) Handles btnAgregarViaje.Click
        panelViaje.Visible = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelViaje.Visible = False
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub
End Class