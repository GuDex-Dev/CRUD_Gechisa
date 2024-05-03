Public Class frmRuta
    Private Sub btnRutaNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregarRuta.Click
        panelRuta.Visible = True

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelRuta.Visible = False
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub
End Class