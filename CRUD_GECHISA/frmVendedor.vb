Public Class frmVendedor
    Private Sub btnAgregarVendedor_Click(sender As Object, e As EventArgs) Handles btnAgregarVendedor.Click
        panelVendedor.Visible = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelVendedor.Visible = False
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub
End Class