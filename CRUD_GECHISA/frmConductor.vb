Public Class frmConductor
    Private Sub btnAgregarConductor_Click(sender As Object, e As EventArgs) Handles btnAgregarConductor.Click
        panelConductor.Visible = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelConductor.Visible = False
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub
End Class