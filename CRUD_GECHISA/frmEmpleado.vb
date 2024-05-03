Public Class frmEmpleado
    Private Sub btnAgregarempleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        panelEmpleado.Visible = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelEmpleado.Visible = False
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub
End Class